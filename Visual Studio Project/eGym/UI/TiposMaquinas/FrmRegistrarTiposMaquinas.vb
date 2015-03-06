Imports System.IO
Imports System.Drawing
Public Class FrmRegistrarTiposMaquinas

    Private Sub btnAgregarCambiar_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        ofdBuscar.ShowDialog()
        pbxFoto.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim tipoDeMaquinas As String = txtNombreImagen.Text
        Dim descripcion As String = rtbDescripcion.Text
        'Dim foto As Image

        'Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        'Dim bReader As New BinaryReader(fs)
        'Dim foto(fs.Length) As Byte
        'bReader.Read(foto, 0, fs.Length)
        'fs.Close()
        'objGestorTiposDeMaquina.insertarTipoDeMaquina(tipoDeMaquinas, descripcion, foto)

        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = String.Empty
            End If
        Next
    End Sub
End Class
