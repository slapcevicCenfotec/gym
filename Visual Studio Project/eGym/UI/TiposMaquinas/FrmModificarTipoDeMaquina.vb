Imports EL
Imports System.IO

Public Class FrmModificarTipoDeMaquina

    Private Sub FrmModificarTipoDeMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipoMaquina As TipoDeMaquina = objGestorTipoDeMaquina.GetMaquinaById(eGym.passedIdMaquina)
        Dim foto As Image
        Dim ms As MemoryStream = New System.IO.MemoryStream(tipoMaquina.Foto)
        foto = System.Drawing.Image.FromStream(ms)
        txtTipoDeMaquina.Text = tipoMaquina.Nombre
        rtbDescripcion.Text = tipoMaquina.Descripcion
        pbxFoto.Image = foto
        ckbHabilitado.Checked = tipoMaquina.Habilitado

    End Sub

    Private Sub btnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar.ShowDialog()
        pbxFoto.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtTipoDeMaquina.Text
        Dim descripcion As String = rtbDescripcion.Text
        Dim habilitado As Boolean = True

        Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
        Dim bReader As New BinaryReader(fs)
        Dim foto(fs.Length) As Byte
        bReader.Read(foto, 0, fs.Length)
        fs.Close()

        objGestorTipoDeMaquina.modificarTipoDeMaquina(eGym.passedIdMaquina, foto, nombre, descripcion, habilitado)
        clearScreen()
    End Sub

    Sub clearScreen()
        Me.txtTipoDeMaquina.Text = String.Empty
        Me.rtbDescripcion.Text = String.Empty
        Me.txtNombreImagen.Text = String.Empty
        Me.pbxFoto.Image = Nothing
    End Sub
End Class
