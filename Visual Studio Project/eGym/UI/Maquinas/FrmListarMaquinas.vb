Imports EL

Public Class FrmListarMaquinas
    Private Property listaMaquinas As List(Of Maquina)

    Private Sub FrmListarMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaMaquinas = objGestorMaquina.listarMaquinas()
        tblMaquinas.DataSource = listaMaquinas
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub tblMaquinas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles tblMaquinas.DataBindingComplete

        tblMaquinas.Columns(0).Visible = False
        tblMaquinas.Columns(1).HeaderText = "Número de activo"
        tblMaquinas.Columns(2).HeaderText = "Número de máquina"
        tblMaquinas.Columns(3).Visible = False
        tblMaquinas.Columns(4).Visible = False
        tblMaquinas.Columns(5).HeaderText = "Tipo de máquina"
        tblMaquinas.Columns(1).Width = (tblMaquinas.Width) / 4
        tblMaquinas.Columns(2).Width = ((tblMaquinas.Width) / 4)
        tblMaquinas.Columns(5).Width = ((tblMaquinas.Width) / 4) * 2
        tblMaquinas.Columns(6).Visible = False


        tblMaquinas.MultiSelect = False
        tblMaquinas.AllowUserToResizeColumns = False
        tblMaquinas.AllowUserToOrderColumns = False
        tblMaquinas.ClearSelection()
        tblMaquinas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tblMaquinas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        aplicarFiltro(txtBuscar.Text.ToUpper)
    End Sub

    Private Sub aplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of Maquina) = New List(Of Maquina)
        For Each maquina As Maquina In listaMaquinas
            If maquina.NombreTipoMaquina.ToUpper.Contains(filtro) Or maquina.NumeroActivo.ToUpper.Contains(filtro) Or maquina.NumeroMaquina.ToUpper.Contains(filtro) Then
                listaFiltrada.Add(maquina)
            End If
        Next
        tblMaquinas.DataSource = listaFiltrada
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ctr As Control
        ctr = New lblTitulo
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msg As String = "Desea eliminar la máquina?"
        Dim maquinaPorEliminar As Maquina = tblMaquinas.CurrentRow.DataBoundItem
        Dim mensaje As New FrmMensaje(msg, maquinaPorEliminar)
        mensaje.ShowDialog()
        listaMaquinas = objGestorMaquina.listarMaquinas()
        tblMaquinas.DataSource = listaMaquinas
    End Sub

    Private Sub tblMaquinas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMaquinas.CellClick
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub btnTiposDeMaquina_Click(sender As Object, e As EventArgs) Handles btnTiposDeMaquina.Click
        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
