Imports EL

Public Class FrmListarMaquinas

    Private Sub FrmListarMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblMaquinas.DataSource = objGestorMaquina.listarMaquinas()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False

        'Dim bs As New BindingSource
        'bs.DataSource = objGestorMaquina.listarMaquinas()
        'bs.Filter = "Número de activo LIKE'" & txtBuscar.Text & "%'"
        'tblMaquinas.DataSource = bs
    End Sub

    Private Sub configurarColumnas(ByVal sender As Object, _
        ByVal e As DataGridViewBindingCompleteEventArgs) _
        Handles tblMaquinas.DataBindingComplete

        tblMaquinas.Columns(0).Visible = False
        tblMaquinas.Columns(1).HeaderText = "Número de activo"
        tblMaquinas.Columns(2).HeaderText = "Número de máquina"
        tblMaquinas.Columns(3).Visible = False
        tblMaquinas.Columns(4).Visible = False
        tblMaquinas.Columns(5).HeaderText = "Tipo de máquina"
        tblMaquinas.Columns(1).Width = (tblMaquinas.Width) / 4
        tblMaquinas.Columns(2).Width = ((tblMaquinas.Width) / 4)
        tblMaquinas.Columns(5).Width = ((tblMaquinas.Width) / 4) * 2


        tblMaquinas.MultiSelect = False
        tblMaquinas.AllowUserToResizeColumns = False
        tblMaquinas.AllowUserToOrderColumns = False
        tblMaquinas.ClearSelection()
        tblMaquinas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tblMaquinas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarMaquina.Click
        Dim ctr As Control
        ctr = New FrmRegistrarMaquina
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim maquinaPorEliminar As Maquina = tblMaquinas.CurrentRow.DataBoundItem
        objGestorMaquina.eliminarMaquina(maquinaPorEliminar)
        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ctr As Control
        ctr = New FrmModificarMaquina(tblMaquinas.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnTiposDeMaquina_Click(sender As Object, e As EventArgs) Handles btnTiposDeMaquina.Click
        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub tblMaquinas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMaquinas.CellClick
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click

    End Sub

    Private Sub tblMaquinas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMaquinas.CellContentClick

    End Sub
End Class
