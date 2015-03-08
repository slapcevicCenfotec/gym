Imports System.IO
Imports System.Drawing

Public Class FrmRegistrarEjercicio

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar.ShowDialog()
        ptbPosicionInicial.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim nombre As String = txtTipoDeMaquina.Text
        'Dim descripcion As String = rtbDescripcion.Text
        'Dim habilitado As Boolean = True

        'Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
        'Dim bReader As New BinaryReader(fs)
        'Dim foto(fs.Length) As Byte
        'bReader.Read(foto, 0, fs.Length)
        'fs.Close()

        'objGestorTipoDeMaquina.insertarTipoDeMaquina(foto, nombre, descripcion, habilitado)
        'clearScreen()


        Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
        Dim bReader As New BinaryReader(fs)
        Dim foto(fs.Length) As Byte
        bReader.Read(foto, 0, fs.Length)
        fs.Close()

        objeGestorEjercicio.insertarEjercicio(foto)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        ofdBuscar2.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar2.ShowDialog()
        ptbPosicionInicial.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub
End Class
