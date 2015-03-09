Imports System.Text.RegularExpressions
Imports EL.Usuario

Public Class frmIniciarSesion

    Dim EmailRegex As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim validado As Boolean = validarInicio()
        If validado = True Then
            Dim correo As String = txtNombreUsuario.Text
            Dim contrasena As String = txtContrasena.Text
            Dim usuario As EL.Usuario
            usuario = objGestorSesion.iniciarSesion(correo, contrasena)

            If usuario Is Nothing Then
                lblError.Text = "Este nombre de usuario o contraseña no son válidos" + Constants.vbCrLf
                lblError.Visible = True
            Else
                
            End If

        End If

    End Sub

    Private Function validarInicio() As Boolean
        lblError.Text = ""
        Dim resul As Boolean = True
        Dim validacionCorreo As Match = EmailRegex.Match(txtNombreUsuario.Text)

        If txtNombreUsuario.Text = "" Then
            resul = False
            lblError.Text = "Ingrese un correo válido para el usuario" + Constants.vbCrLf
            lblError.Visible = True
            txtNombreUsuario.BackColor = Color.Pink
        Else
            If EmailRegex.IsMatch(txtNombreUsuario.Text) = False Then
                resul = False
                lblError.Text = "El campo del correo debe tener formato de correo" + Constants.vbCrLf
                lblError.Visible = True
                txtNombreUsuario.BackColor = Color.Pink
            Else
                txtNombreUsuario.BackColor = Color.White
            End If
        End If
        If txtContrasena.Text = Nothing Then
            resul = False
            lblError.Text += "Debe ingresar una contraseña"
            lblError.Visible = True
            txtContrasena.BackColor = Color.Pink
        Else
            txtContrasena.BackColor = Color.White
        End If

        Return resul

    End Function

End Class