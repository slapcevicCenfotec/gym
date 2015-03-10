Imports EL
Public Class FrmListarTiposDeMaquinas
    Private Property listaTiposDeMaquinas As List(Of TipoDeMaquina)

    Private Sub FrmListarTiposDeMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaTiposDeMaquinas = objGestorTipoDeMaquina.listarTiposDeMaquinas()
        tblTiposDeMaquinas.DataSource = listaTiposDeMaquinas
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub configurarColumnas(ByVal sender As Object, _
        ByVal e As DataGridViewBindingCompleteEventArgs) _
        Handles tblTiposDeMaquinas.DataBindingComplete

        tblTiposDeMaquinas.Columns(0).Visible = False
        tblTiposDeMaquinas.Columns(1).Visible = False
        tblTiposDeMaquinas.Columns(2).HeaderText = "Nombre"
        tblTiposDeMaquinas.Columns(2).Width = (tblTiposDeMaquinas.Width) / 4
        tblTiposDeMaquinas.Columns(3).HeaderText = "Descripción"
        tblTiposDeMaquinas.Columns(3).Width = ((tblTiposDeMaquinas.Width) / 4) * 3
        tblTiposDeMaquinas.Columns(4).Visible = False

        tblTiposDeMaquinas.MultiSelect = False
        tblTiposDeMaquinas.AllowUserToResizeColumns = False
        tblTiposDeMaquinas.AllowUserToOrderColumns = False
        tblTiposDeMaquinas.ClearSelection()
        tblTiposDeMaquinas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tblTiposDeMaquinas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ctr As Control
        ctr = New FrmModificarTipoDeMaquina(tblTiposDeMaquinas.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ctr As Control
        ctr = New FrmRegistrarTiposMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim eliminar As MsgBoxResult = MsgBox("Desea eliminar el tipo de máquina?", MsgBoxStyle.YesNo, "Elminar")

        If eliminar = MsgBoxResult.Yes Then
            Dim maquinaPorEliminar As TipoDeMaquina = tblTiposDeMaquinas.CurrentRow.DataBoundItem
            objGestorTipoDeMaquina.eliminarTipoDeMaquina(maquinaPorEliminar)
            Dim ctr As Control
            ctr = New FrmListarTiposDeMaquinas
            ctr.Dock = DockStyle.Fill
            Me.Controls.Clear()
            Me.Controls.Add(ctr)
        End If
    End Sub

    Private Sub tblTiposDeMaquinas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblTiposDeMaquinas.CellClick
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        aplicarFiltro(txtBuscar.Text.ToUpper)
    End Sub

    Private Sub aplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of TipoDeMaquina) = New List(Of TipoDeMaquina)
        For Each tipoMaquina As TipoDeMaquina In listaTiposDeMaquinas
            If tipoMaquina.Nombre.ToUpper.Contains(filtro) Or tipoMaquina.Descripcion.ToUpper.Contains(filtro) Then
                listaFiltrada.Add(tipoMaquina)
            End If
        Next
        tblTiposDeMaquinas.DataSource = listaFiltrada
    End Sub
End Class



