Imports System.IO
Imports System.Drawing
Public Class FrmRegistrarTiposMaquinas

    Private Sub btnAgregarCambiar_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
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

        objGestorTipoDeMaquina.insertarTipoDeMaquina(foto, nombre, descripcion, habilitado)
        clearScreen()

    End Sub

    Sub clearScreen()
        Me.txtTipoDeMaquina.Text = String.Empty
        Me.rtbDescripcion.Text = String.Empty
        Me.txtNombreImagen.Text = String.Empty
        Me.pbxFoto.Image = Nothing
    End Sub
End Class
