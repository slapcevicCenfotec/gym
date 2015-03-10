Imports System.Text.RegularExpressions
Imports EL.Usuario

Public Class frmIniciarSesion

    Dim EmailRegex As Regex = New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim validado As Boolean = validarInicio()
        If validado = True Then
            Dim correo As String = txtNombreUsuario.Text
            Dim contrasena As String = txtContrasena.Text
            Dim usuario As EL.Usuario
            usuario = objGestorSesion.iniciarSesion(correo, contrasena)

            If usuario Is Nothing Then
                ErrorProvider1.SetError(btnIngresar, "Este nombre de usuario o contraseña no son válidos")
            Else
                ErrorProvider1.SetError(btnIngresar, "")
                Me.Hide()
                txtContrasena.Text = Nothing
                usuarioSesion = usuario
                eGym.Show()

            End If

        End If

    End Sub

    Private Function validarInicio() As Boolean

        lblError.Text = ""
        Dim resul As Boolean = True
        Dim validacionCorreo As Match = EmailRegex.Match(txtNombreUsuario.Text)

        If txtNombreUsuario.Text = "" Then
            resul = False
            ErrorProvider1.SetError(txtNombreUsuario, "Ingrese un correo válido para el usuario")
        Else
            If EmailRegex.IsMatch(txtNombreUsuario.Text) = False Then
                resul = False
                ErrorProvider1.SetError(txtNombreUsuario, "El campo del correo debe tener formato de correo")
            Else
                ErrorProvider1.SetError(txtNombreUsuario, "")
            End If
        End If
        If txtContrasena.Text = Nothing Then
            resul = False
            ErrorProvider1.SetError(txtContrasena, "Debe ingresar una contraseña")
        Else
            ErrorProvider1.SetError(txtContrasena, "")
        End If

        Return resul

    End Function

End Class