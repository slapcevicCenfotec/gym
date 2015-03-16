Imports System.IO

Public Class FrmAgregarUsuario

    Private imageByte As Byte()

    Private Sub pcbFotografia_Click(sender As Object, e As EventArgs) Handles pcbFotografia.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                pcbFotografia.Image = Image.FromFile(OpenFileDialog.FileName)
                imageByte = File.ReadAllBytes(OpenFileDialog.FileName)
            Catch ex As Exception
                ' La imagen cargada no es valida
            End Try
        End If
    End Sub

    Private Sub btnEliminarFotografia_Click(sender As Object, e As EventArgs) Handles btnEliminarFotografia.Click
        pcbFotografia.Image = Nothing
        imageByte = Nothing
    End Sub

    Private Sub FrmAgregarUsuario_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        SP_ListarTiposIdentificacionTableAdapter.Fill(EGymDBDataSet.SP_ListarTiposIdentificacion)
        SP_ListarGenerosTableAdapter.Fill(EGymDBDataSet.SP_ListarGeneros)
        SP_ListarRolesTableAdapter.Fill(EGymDBDataSet.SP_ListarRoles)
        MetroTabControl1.TabPages.Remove(MetroTabPage3)
        RevisarRol()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not Revisar() Then
            Gestor.AgregarUsuario(txtIdentificacion.Text, txtNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtAlias.Text, dtpFechaNacimiento.Text, txtCorreoElectronico.Text, txtContrasena.Text, imageByte, Date.Now, txtTelefono.Text, txtCelular.Text, cmbRol.SelectedValue, cmbGenero.SelectedValue, cmbTipoIdentificacion.SelectedValue)
            Gestor.AgregarContacto(txtNombreContacto1.Text, txtTelefonoContacto1.Text, txtParentescoContacto1.Text, Nothing)
            If (txtNombreContacto2.Text.Length > 0 And txtTelefonoContacto2.Text.Length > 0 And txtParentescoContacto2.Text.Length > 0) Then
                Gestor.AgregarContacto(txtNombreContacto2.Text, txtTelefonoContacto2.Text, txtParentescoContacto2.Text, Nothing)
            End If
            If IsDate(txtLunesEntrada.Text) And IsDate(txtLunesSalida.Text) Then
                Gestor.AgregarHorario(txtLunesEntrada.Text, txtLunesSalida.Text, 1, Nothing)
            End If
            If IsDate(txtMartesEntrada.Text) And IsDate(txtMartesSalida.Text) Then
                Gestor.AgregarHorario(txtMartesEntrada.Text, txtMartesSalida.Text, 2, Nothing)
            End If
            If IsDate(txtMiercolesEntrada.Text) And IsDate(txtMiercolesSalida.Text) Then
                Gestor.AgregarHorario(txtMiercolesEntrada.Text, txtMiercolesSalida.Text, 3, Nothing)
            End If
            If IsDate(txtJuevesEntrada.Text) And IsDate(txtJuevesSalida.Text) Then
                Gestor.AgregarHorario(txtJuevesEntrada.Text, txtJuevesSalida.Text, 4, Nothing)
            End If
            If IsDate(txtViernesEntrada.Text) And IsDate(txtViernesSalida.Text) Then
                Gestor.AgregarHorario(txtViernesEntrada.Text, txtViernesSalida.Text, 5, Nothing)
            End If
            If IsDate(txtSabadoEntrada.Text) And IsDate(txtSabadoSalida.Text) Then
                Gestor.AgregarHorario(txtSabadoEntrada.Text, txtSabadoSalida.Text, 6, Nothing)
            End If
            If IsDate(txtDomingoEntrada.Text) And IsDate(txtDomingoSalida.Text) Then
                Gestor.AgregarHorario(txtDomingoEntrada.Text, txtDomingoSalida.Text, 0, Nothing)
            End If
            Dim ctr As Control = New FrmListarUsuarios()
            ctr.Dock = DockStyle.Fill
            Me.Parent.Controls.Add(ctr)
            Me.Dispose()
        End If
    End Sub

    Private Function Revisar() As Boolean
        Dim conError As Boolean = False
        ErrorProvider.Clear()
        If txtIdentificacion.Text.Length = 0 Then
            ErrorProvider.SetError(txtIdentificacion, "La identificación es un campo obligatorio")
            conError = True
        End If
        If txtNombre.Text.Length = 0 Then
            ErrorProvider.SetError(txtNombre, "El nombre es un campo obligatorio")
            conError = True
        End If
        If txtApellido.Text.Length = 0 Then
            ErrorProvider.SetError(txtApellido, "El apellido es un campo obligatorio")
            conError = True
        End If
        If txtCorreoElectronico.Text.Length = 0 Then
            ErrorProvider.SetError(txtCorreoElectronico, "El correo electrónico es un campo obligatorio")
            conError = True
        End If
        If txtTelefono.Text.Length = 0 And txtCelular.Text.Length = 0 Then
            ErrorProvider.SetError(txtTelefono, "Un número de teléfono es obligatorio")
            conError = True
        End If
        If txtContrasena.Text.Length = 0 Then
            ErrorProvider.SetError(txtContrasena, "La contraseña es un campo obligatorio")
            conError = True
        Else
            If txtContrasena.Text <> txtRepetirContrasena.Text Then
                ErrorProvider.SetError(txtContrasena, "Las contraseñas no coinciden")
            End If
        End If
        If txtNombreContacto1.Text.Length = 0 Then
            ErrorProvider.SetError(txtNombreContacto1, "El nombre del contacto 1 es un campo obligatorio")
            conError = True
        End If
        If txtTelefonoContacto1.Text.Length = 0 Then
            ErrorProvider.SetError(txtTelefonoContacto1, "El teléfono del contacto 1 es un campo obligatorio")
            conError = True
        End If
        If txtParentescoContacto1.Text.Length = 0 Then
            ErrorProvider.SetError(txtParentescoContacto1, "El parentesco del contacto 1 es un campo obligatorio")
            conError = True
        End If

        If txtNombreContacto2.Text.Length > 0 Or txtTelefonoContacto2.Text.Length > 0 Or txtParentescoContacto2.Text.Length > 0 Then
            If txtNombreContacto2.Text.Length = 0 Then
                ErrorProvider.SetError(txtNombreContacto2, "El nombre del contacto 2 es un campo obligatorio")
                conError = True
            Else
                ErrorProvider.SetError(txtNombreContacto2, "")
            End If
            If txtTelefonoContacto2.Text.Length = 0 Then
                ErrorProvider.SetError(txtTelefonoContacto2, "El telefono del contacto 2 es un campo obligatorio")
                conError = True
            Else
                ErrorProvider.SetError(txtTelefonoContacto2, "")
            End If
            If txtParentescoContacto2.Text.Length = 0 Then
                ErrorProvider.SetError(txtParentescoContacto2, "El parentesco del contacto 2 es un campo obligatorio")
                conError = True
            Else
                ErrorProvider.SetError(txtParentescoContacto2, "")
            End If
        End If

        If Not (txtLunesEntrada.Text.Trim = ":" And txtLunesSalida.Text.Trim = ":") Then
            If Not (txtLunesEntrada.Text.Trim = ":" Or IsDate(txtLunesEntrada.Text) Or txtLunesSalida.Text.Trim = ":" Or IsDate(txtLunesSalida.Text)) Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de entrada y salida del lunes tienen formato invalido")
                conError = True
            ElseIf Not (txtLunesEntrada.Text.Trim = ":" Or IsDate(txtLunesEntrada.Text)) Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de entrada del lunes tiene formato invalido")
                conError = True
            ElseIf Not (txtLunesSalida.Text.Trim = ":" Or IsDate(txtLunesSalida.Text)) Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de salida del lunes tiene formato invalido")
                conError = True
            ElseIf txtLunesEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de entrada del lunes es un campo requerido")
                conError = True
            ElseIf txtLunesSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de salida del lunes es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtLunesEntrada.Text) > Convert.ToDateTime(txtLunesSalida.Text) Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtLunesEntrada.Text) = Convert.ToDateTime(txtLunesSalida.Text) Then
                ErrorProvider.SetError(txtLunesSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtMartesEntrada.Text.Trim = ":" And txtMartesSalida.Text.Trim = ":") Then
            If Not (txtMartesEntrada.Text.Trim = ":" Or IsDate(txtMartesEntrada.Text) Or txtMartesSalida.Text.Trim = ":" Or IsDate(txtMartesSalida.Text)) Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de entrada y salida del Martes tienen formato invalido")
                conError = True
            ElseIf Not (txtMartesEntrada.Text.Trim = ":" Or IsDate(txtMartesEntrada.Text)) Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de entrada del Martes tiene formato invalido")
                conError = True
            ElseIf Not (txtMartesSalida.Text.Trim = ":" Or IsDate(txtMartesSalida.Text)) Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de salida del Martes tiene formato invalido")
                conError = True
            ElseIf txtMartesEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de entrada del Martes es un campo requerido")
                conError = True
            ElseIf txtMartesSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de salida del Martes es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtMartesEntrada.Text) > Convert.ToDateTime(txtMartesSalida.Text) Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtMartesEntrada.Text) = Convert.ToDateTime(txtMartesSalida.Text) Then
                ErrorProvider.SetError(txtMartesSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtMiercolesEntrada.Text.Trim = ":" And txtMiercolesSalida.Text.Trim = ":") Then
            If Not (txtMiercolesEntrada.Text.Trim = ":" Or IsDate(txtMiercolesEntrada.Text) Or txtMiercolesSalida.Text.Trim = ":" Or IsDate(txtMiercolesSalida.Text)) Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de entrada y salida del Miercoles tienen formato invalido")
                conError = True
            ElseIf Not (txtMiercolesEntrada.Text.Trim = ":" Or IsDate(txtMiercolesEntrada.Text)) Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de entrada del Miercoles tiene formato invalido")
                conError = True
            ElseIf Not (txtMiercolesSalida.Text.Trim = ":" Or IsDate(txtMiercolesSalida.Text)) Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de salida del Miercoles tiene formato invalido")
                conError = True
            ElseIf txtMiercolesEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de entrada del Miercoles es un campo requerido")
                conError = True
            ElseIf txtMiercolesSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de salida del Miercoles es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtMiercolesEntrada.Text) > Convert.ToDateTime(txtMiercolesSalida.Text) Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtMiercolesEntrada.Text) = Convert.ToDateTime(txtMiercolesSalida.Text) Then
                ErrorProvider.SetError(txtMiercolesSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtJuevesEntrada.Text.Trim = ":" And txtJuevesSalida.Text.Trim = ":") Then
            If Not (txtJuevesEntrada.Text.Trim = ":" Or IsDate(txtJuevesEntrada.Text) Or txtJuevesSalida.Text.Trim = ":" Or IsDate(txtJuevesSalida.Text)) Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de entrada y salida del Jueves tienen formato invalido")
                conError = True
            ElseIf Not (txtJuevesEntrada.Text.Trim = ":" Or IsDate(txtJuevesEntrada.Text)) Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de entrada del Jueves tiene formato invalido")
                conError = True
            ElseIf Not (txtJuevesSalida.Text.Trim = ":" Or IsDate(txtJuevesSalida.Text)) Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de salida del Jueves tiene formato invalido")
                conError = True
            ElseIf txtJuevesEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de entrada del Jueves es un campo requerido")
                conError = True
            ElseIf txtJuevesSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de salida del Jueves es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtJuevesEntrada.Text) > Convert.ToDateTime(txtJuevesSalida.Text) Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtJuevesEntrada.Text) = Convert.ToDateTime(txtJuevesSalida.Text) Then
                ErrorProvider.SetError(txtJuevesSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtViernesEntrada.Text.Trim = ":" And txtViernesSalida.Text.Trim = ":") Then
            If Not (txtViernesEntrada.Text.Trim = ":" Or IsDate(txtViernesEntrada.Text) Or txtViernesSalida.Text.Trim = ":" Or IsDate(txtViernesSalida.Text)) Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de entrada y salida del Viernes tienen formato invalido")
                conError = True
            ElseIf Not (txtViernesEntrada.Text.Trim = ":" Or IsDate(txtViernesEntrada.Text)) Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de entrada del Viernes tiene formato invalido")
                conError = True
            ElseIf Not (txtViernesSalida.Text.Trim = ":" Or IsDate(txtViernesSalida.Text)) Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de salida del Viernes tiene formato invalido")
                conError = True
            ElseIf txtViernesEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de entrada del Viernes es un campo requerido")
                conError = True
            ElseIf txtViernesSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de salida del Viernes es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtViernesEntrada.Text) > Convert.ToDateTime(txtViernesSalida.Text) Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtViernesEntrada.Text) = Convert.ToDateTime(txtViernesSalida.Text) Then
                ErrorProvider.SetError(txtViernesSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtSabadoEntrada.Text.Trim = ":" And txtSabadoSalida.Text.Trim = ":") Then
            If Not (txtSabadoEntrada.Text.Trim = ":" Or IsDate(txtSabadoEntrada.Text) Or txtSabadoSalida.Text.Trim = ":" Or IsDate(txtSabadoSalida.Text)) Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de entrada y salida del Sabado tienen formato invalido")
                conError = True
            ElseIf Not (txtSabadoEntrada.Text.Trim = ":" Or IsDate(txtSabadoEntrada.Text)) Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de entrada del Sabado tiene formato invalido")
                conError = True
            ElseIf Not (txtSabadoSalida.Text.Trim = ":" Or IsDate(txtSabadoSalida.Text)) Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de salida del Sabado tiene formato invalido")
                conError = True
            ElseIf txtSabadoEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de entrada del Sabado es un campo requerido")
                conError = True
            ElseIf txtSabadoSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de salida del Sabado es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtSabadoEntrada.Text) > Convert.ToDateTime(txtSabadoSalida.Text) Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtSabadoEntrada.Text) = Convert.ToDateTime(txtSabadoSalida.Text) Then
                ErrorProvider.SetError(txtSabadoSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        If Not (txtDomingoEntrada.Text.Trim = ":" And txtDomingoSalida.Text.Trim = ":") Then
            If Not (txtDomingoEntrada.Text.Trim = ":" Or IsDate(txtDomingoEntrada.Text) Or txtDomingoSalida.Text.Trim = ":" Or IsDate(txtDomingoSalida.Text)) Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de entrada y salida del Domingo tienen formato invalido")
                conError = True
            ElseIf Not (txtDomingoEntrada.Text.Trim = ":" Or IsDate(txtDomingoEntrada.Text)) Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de entrada del Domingo tiene formato invalido")
                conError = True
            ElseIf Not (txtDomingoSalida.Text.Trim = ":" Or IsDate(txtDomingoSalida.Text)) Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de salida del Domingo tiene formato invalido")
                conError = True
            ElseIf txtDomingoEntrada.Text.Trim = ":" Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de entrada del Domingo es un campo requerido")
                conError = True
            ElseIf txtDomingoSalida.Text.Trim = ":" Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de salida del Domingo es un campo requerido")
                conError = True
            ElseIf Convert.ToDateTime(txtDomingoEntrada.Text) > Convert.ToDateTime(txtDomingoSalida.Text) Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de entrada no puede ser mayor a la hora de salida")
                conError = True
            ElseIf Convert.ToDateTime(txtDomingoEntrada.Text) = Convert.ToDateTime(txtDomingoSalida.Text) Then
                ErrorProvider.SetError(txtDomingoSalida, "La hora de entrada no puede ser igual a la hora de salida")
                conError = True
            End If
        End If

        Return conError
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control = New FrmListarUsuarios()
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub

    Private Sub cmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRol.SelectedIndexChanged
        RevisarRol()
    End Sub

    Private Sub RevisarRol()
        Try
            Dim rol As EL.Rol = objGestorRol.obtenerRol(cmbRol.SelectedValue)(0)
            Dim mostrar As Boolean = False
            For Each permiso As EL.Permiso In rol.ListaPermisos
                If permiso.Id = 10 Then
                    mostrar = True
                End If
            Next
            If mostrar Then
                MetroTabControl1.TabPages.Add(MetroTabPage3)
            Else
                MetroTabControl1.TabPages.Remove(MetroTabPage3)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
