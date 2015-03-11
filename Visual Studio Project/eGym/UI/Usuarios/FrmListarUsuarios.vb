Public Class FrmListarUsuarios

    Private Sub FrmListarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblUsuarios.AutoGenerateColumns = False
        tblUsuarios.DataSource = Gestor.ListarUsuarios()
        tblUsuarios.Columns("Identificacion").DataPropertyName = "Identificacion"
        tblUsuarios.Columns("Nombre").DataPropertyName = "Nombre"
        tblUsuarios.Columns("AliasUsuario").DataPropertyName = "Alias"
        tblUsuarios.Columns("FechaIngreso").DataPropertyName = "FechaIngreso"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Dim frmAgregar As UserControl = New FrmAgregarUsuario
        'frmAgregar.Dock = DockStyle.Fill
        'Me.Parent.Controls("FrmListarUsuarios1").Visible = False
        'Me.Parent.Controls.Add(frmAgregar)
    End Sub
End Class
