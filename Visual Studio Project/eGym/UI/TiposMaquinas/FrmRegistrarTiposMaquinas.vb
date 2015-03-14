Imports System.IO
Imports System.Drawing
Public Class FrmRegistrarTiposMaquinas

    Private Sub FrmRegistrarTiposMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbDescripcion.MaxLength = 250
        txtTipoDeMaquina.MaxLength = 50
        txtNombreImagen.Enabled = False
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

    Private Function validarFormRegistrarTiposDeMaquina() As Boolean
        Dim validado As Boolean = True
        If txtNombreImagen.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtNombreImagen, "La foto es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtNombreImagen, "")
        End If

        If txtTipoDeMaquina.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtTipoDeMaquina, "El tipo de máquina es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtTipoDeMaquina, "")
        End If

        If rtbDescripcion.Text.Length = 0 Then
            ErPrValidaciones.SetError(rtbDescripcion, "La descripción es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(rtbDescripcion, "")
        End If

        Return validado
    End Function

    Sub clearScreen()
        Me.txtTipoDeMaquina.Text = String.Empty
        Me.rtbDescripcion.Text = String.Empty
        Me.txtNombreImagen.Text = String.Empty
        Me.pbxFoto.Image = Nothing
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtTipoDeMaquina.Text
        Dim descripcion As String = rtbDescripcion.Text
        Dim habilitado As Boolean = True

        If validarFormRegistrarTiposDeMaquina() Then
            Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
            Dim bReader As New BinaryReader(fs)
            Dim foto(fs.Length) As Byte
            bReader.Read(foto, 0, fs.Length)
            fs.Close()

            Try
                objGestorTipoDeMaquina.insertarTipoDeMaquina(foto, nombre, descripcion, habilitado)
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()

        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
