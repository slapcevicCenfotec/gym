Imports System.Text.RegularExpressions

Public Class frmIniciarSesion

    Dim EmailRegex As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim validado As Boolean = validarInicio()

        Dim correo As String = txtNombreUsuario.Text
        Dim contrasena As String = txtContrasena.Text
    End Sub

    Private Function validarInicio() As Boolean
        lblError.Text = ""
        Dim resul As Boolean = True
        Dim validacionCorreo As Match = EmailRegex.Match(txtNombreUsuario.Text)

        If txtNombreUsuario.Text = "" Then
            resul = False
            lblError.Text = "Ingrese un correo válido para el usuario" + Constants.vbCrLf
            lblError.Visible = True
        Else
            If EmailRegex.IsMatch(txtNombreUsuario.Text) = False Then
                resul = False
                lblError.Text = "El campo del correo debe tener formato de correo" + Constants.vbCrLf
                lblError.Visible = True
            End If
        End If
        If txtContrasena.Text = Nothing Then
            resul = False
            lblError.Text += "Debe ingresar una contraseña"
            lblError.Visible = True
        End If

        Return resul

    End Function

End Class