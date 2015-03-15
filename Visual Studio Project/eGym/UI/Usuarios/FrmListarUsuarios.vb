Imports EL

Public Class FrmListarUsuarios

    Private listaOriginal As List(Of Usuario)

    Private Sub FrmListarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaOriginal = Gestor.ListarUsuarios()

        tblUsuarios.AutoGenerateColumns = False
        tblUsuarios.DataSource = listaOriginal
        tblUsuarios.Columns("Identificacion").DataPropertyName = "Identificacion"
        tblUsuarios.Columns("Nombre").DataPropertyName = "NombreCompleto"
        tblUsuarios.Columns("AliasUsuario").DataPropertyName = "Alias"
        tblUsuarios.Columns("FechaIngreso").DataPropertyName = "FechaIngreso"
        tblUsuarios.Columns("Habilitado").DataPropertyName = "HabilitadoString"
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        AplicarFiltro(txtFiltro.Text.ToUpper)
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.Usuario) = New List(Of EL.Usuario)
        If Not listaOriginal Is Nothing Then
            For Each usuario As Usuario In listaOriginal

                If usuario.Identificacion.ToUpper.Contains(filtro) Or usuario.Nombre.ToUpper.Contains(filtro) Or usuario.Alias.ToUpper.Contains(filtro) Then
                    listaFiltrada.Add(usuario)
                End If
            Next
        End If
        tblUsuarios.DataSource = listaFiltrada
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim ctr As Control = New FrmAgregarUsuario()
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        Dim selectRow As Integer = tblUsuarios.CurrentRow.Index
        Dim usuario As Usuario = tblUsuarios.CurrentRow.DataBoundItem
        Gestor.EliminarUsuario(usuario)
        listaOriginal = Gestor.ListarUsuarios()
        AplicarFiltro(txtFiltro.Text.ToUpper)
        tblUsuarios.CurrentCell = tblUsuarios.Rows(selectRow).Cells(0)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim usuario As Usuario = tblUsuarios.CurrentRow.DataBoundItem
        Dim ctr As Control = New FrmModificarUsuario(usuario.Id)
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub
End Class
