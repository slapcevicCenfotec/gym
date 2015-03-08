Imports System.IO
Imports System.Drawing
Public Class FrmRegistrarTiposMaquinas

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

            objGestorTipoDeMaquina.insertarTipoDeMaquina(foto, nombre, descripcion, habilitado)
            clearScreen()
        End If

    End Sub

    Private Function validarFormRegistrarTiposDeMaquina() As Boolean
        Dim validado As Boolean = True
        If txtTipoDeMaquina.Text.Length = 0 Then
            lblValidarNombre.Text = "Tipo de máquina es requerido"
            validado = False
        End If

        If rtbDescripcion.TextLength = 0 Or rtbDescripcion.TextLength > 250 Then
            lblValidarDescripcion.Text = "Descripción es requerida y no debe ser mayor a 250 caracteres"
            validado = False
        End If

        If txtNombreImagen.Text.Length = 0 Then
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
