Imports EL
Imports System.IO
Public Class FrmModificarTipoDeMaquina
    Private Property tipoDeMaquinaPorModificar As TipoDeMaquina

    Public Sub New(ByVal ptipoDeMaquina As TipoDeMaquina)
        tipoDeMaquinaPorModificar = ptipoDeMaquina
        InitializeComponent()
    End Sub

    Private Sub FrmModificarTipoDeMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim foto As Image
        Dim ms As MemoryStream = New System.IO.MemoryStream(tipoDeMaquinaPorModificar.Foto)
        foto = System.Drawing.Image.FromStream(ms)

        txtTipoDeMaquina.Text = tipoDeMaquinaPorModificar.Nombre
        rtbDescripcion.Text = tipoDeMaquinaPorModificar.Descripcion
        pbxFoto.Image = foto

    End Sub

    Private Sub btnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        Try
            ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            ofdBuscar.ShowDialog()
            pbxFoto.Image = Image.FromFile(ofdBuscar.FileName)
            txtNombreImagen.Text = ofdBuscar.SafeFileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtTipoDeMaquina.Text
        Dim descripcion As String = rtbDescripcion.Text
        Dim habilitado As Boolean = True

        resetValidarLabels()

        If validarFormRegistrarTiposDeMaquina() Then
            Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
            Dim bReader As New BinaryReader(fs)
            Dim foto(fs.Length) As Byte
            bReader.Read(foto, 0, fs.Length)
            fs.Close()

            objGestorTipoDeMaquina.modificarTipoDeMaquina(tipoDeMaquinaPorModificar.Id, foto, nombre, descripcion, habilitado)
            clearScreen()
        End If

        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)

    End Sub

    Private Function validarFormRegistrarTiposDeMaquina() As Boolean
        Dim validado As Boolean = True
        If txtTipoDeMaquina.Text = "" Then
            lblValidarNombre.Text = "Tipo de máquina es requerido"
            lblValidarNombre.ForeColor = Color.Red
            validado = False
        End If

        If rtbDescripcion.Text = "" Or rtbDescripcion.TextLength > 250 Then
            lblValidarDescripcion.Text = "Descripción es requerida y no debe ser mayor a 250 caracteres"
            validado = False
        End If

        If txtNombreImagen.Text = "" Then
            lblValidarFoto.Text = "Foto de la máquina es requerida"
            validado = False
        End If

        Return validado
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()
        resetValidarLabels()

        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Sub clearScreen()
        Me.txtTipoDeMaquina.Text = String.Empty
        Me.rtbDescripcion.Text = String.Empty
        Me.txtNombreImagen.Text = String.Empty
        Me.pbxFoto.Image = Nothing
    End Sub

    Sub resetValidarLabels()
        lblValidarDescripcion.Text = ""
        lblValidarFoto.Text = ""
        lblValidarNombre.Text = ""
    End Sub
End Class
