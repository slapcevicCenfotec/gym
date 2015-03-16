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

        txtDescripcion.MaxLength = 250
        txtTipoDeMaquina.MaxLength = 50
        txtNombreImagen.Visible = False
        txtNombreImagen.Enabled = False

        txtTipoDeMaquina.Text = tipoDeMaquinaPorModificar.Nombre
        txtDescripcion.Text = tipoDeMaquinaPorModificar.Descripcion
        pbxFoto.Image = foto

    End Sub

    Private Sub pbxFoto_Click(sender As Object, e As EventArgs) Handles pbxFoto.Click
        Try
            ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            ofdBuscar.ShowDialog()
            pbxFoto.Image = Image.FromFile(ofdBuscar.FileName)
            txtNombreImagen.Text = ofdBuscar.SafeFileName
        Catch ex As Exception
            'Si no agrega la foto tira una excepción
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtTipoDeMaquina.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim habilitado As Boolean = True
        Dim foto As Byte()

        If txtNombreImagen.Text.Length <> 0 Then
            Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
            Dim bReader As New BinaryReader(fs)
            Dim nuevaFoto(fs.Length) As Byte
            bReader.Read(nuevaFoto, 0, fs.Length)
            fs.Close()
            foto = nuevaFoto
        Else
            foto = tipoDeMaquinaPorModificar.Foto
        End If

        If validarFormModificarTiposDeMaquina() Then

            Try
                objGestorTipoDeMaquina.modificarTipoDeMaquina(tipoDeMaquinaPorModificar.Id, foto, nombre, descripcion, habilitado)
                clearScreen()

                Dim ctr As Control
                ctr = New FrmListarTiposDeMaquinas
                ctr.Dock = DockStyle.Fill
                Me.Controls.Clear()
                Me.Controls.Add(ctr)

            Catch ex As Exception
                ErPrExcepciones.SetError(btnGuardar, ex.Message)
            End Try
        End If
    End Sub

    Private Function validarFormModificarTiposDeMaquina() As Boolean
        Dim validado As Boolean = True

        If pbxFoto.Image Is Nothing Then
            ErrorProvider.SetError(lblFoto, "La foto es un campo obligatorio")
            validado = False
        End If

        If txtTipoDeMaquina.Text.Length = 0 Then
            ErrorProvider.SetError(txtTipoDeMaquina, "El tipo de máquina es un campo obligatorio")
            validado = False
        Else
            ErrorProvider.SetError(txtTipoDeMaquina, "")
        End If

        If txtDescripcion.Text.Length = 0 Then
            ErrorProvider.SetError(txtDescripcion, "La descripción es un campo obligatorio")
            validado = False
        Else
            ErrorProvider.SetError(txtDescripcion, "")
        End If

        Return validado
    End Function

    Sub clearScreen()
        Me.txtTipoDeMaquina.Text = String.Empty
        Me.txtDescripcion.Text = String.Empty
        Me.txtNombreImagen.Text = String.Empty
        Me.pbxFoto.Image = Nothing
    End Sub

    Private Sub btnEliminarFoto_Click(sender As Object, e As EventArgs) Handles btnEliminarFoto.Click
        pbxFoto.Image = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()

        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
