Imports System.IO

Public Class FrmAgregarUsuario

    Private Sub FrmAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SP_ListarTiposIdentificacionTableAdapter.Fill(TiposIdentificacionDataSet.SP_ListarTiposIdentificacion)
        SP_ListarGenerosTableAdapter.Fill(GenerosDataSet.SP_ListarGeneros)
        SP_ListarRolesTableAdapter.Fill(EGymDBDataSet3.SP_ListarRoles)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtIdentificacion.Text.Length = 0 Then
            ErrorProvider.SetError(txtIdentificacion, "La identificacion es un campo requerido")
        Else
            ErrorProvider.SetError(txtIdentificacion, "")
        End If
        If txtNombre.Text.Length = 0 Then
            ErrorProvider.SetError(txtNombre, "El nombre es un campo requerido")
        Else
            ErrorProvider.SetError(txtNombre, "")
        End If
        If txtApellido.Text.Length = 0 Then
            ErrorProvider.SetError(txtApellido, "El apellido es un campo requerido")
        Else
            ErrorProvider.SetError(txtApellido, "")
        End If
        If txtCorreoElectronico.Text.Length = 0 Then
            ErrorProvider.SetError(txtCorreoElectronico, "El correo electronico es un campo requerido")
        Else
            ErrorProvider.SetError(txtCorreoElectronico, "")
        End If
        If txtTelefono.Text.Length = 0 And txtCelular.Text.Length = 0 Then
            ErrorProvider.SetError(txtTelefono, "Un telefono es un campo requerido")
        Else
            ErrorProvider.SetError(txtTelefono, "")
        End If
        If txtContrasena.Text.Length = 0 Then
            ErrorProvider.SetError(txtContrasena, "La contrasena es un campo requerido")
        Else
            ErrorProvider.SetError(txtContrasena, "")
            If txtContrasena.Text = txtRepetirContrasena.Text Then
                ErrorProvider.SetError(txtRepetirContrasena, "")
            Else
                ErrorProvider.SetError(txtRepetirContrasena, "Las contrasenas no coinciden")
            End If
        End If
    End Sub

    Private Sub pcbFotografia_Click(sender As Object, e As EventArgs) Handles pcbFotografia.Click
        Dim myStream As Stream = Nothing
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = OpenFileDialog.OpenFile()
                If (myStream IsNot Nothing) Then
                    pcbFotografia.Image = Image.FromStream(myStream)
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open. 
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnEliminarFotografia_Click_1(sender As Object, e As EventArgs) Handles btnEliminarFotografia.Click
        pcbFotografia.Image = Nothing
    End Sub
End Class
