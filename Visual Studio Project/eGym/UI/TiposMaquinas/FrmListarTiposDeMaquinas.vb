Imports EL
Public Class FrmListarTiposDeMaquinas

    Private Sub FrmListarTiposDeMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblTiposDeMaquinas.DataSource = objGestorTipoDeMaquina.listarTiposDeMaquinas()
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
        Dim maquinaPorEliminar As TipoDeMaquina = tblTiposDeMaquinas.CurrentRow.DataBoundItem
        objGestorTipoDeMaquina.eliminarTipoDeMaquina(maquinaPorEliminar)
        Dim ctr As Control
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub tblTiposDeMaquinas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblTiposDeMaquinas.CellClick
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        tblTiposDeMaquinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        tblTiposDeMaquinas.ClearSelection()

        For Each myRow As DataGridViewRow In tblTiposDeMaquinas.Rows
            For Each myCell As DataGridViewCell In myRow.Cells
                If myCell.ColumnIndex <> 2 Then
                    If myCell.Value <> Nothing Then
                        If InStr(myCell.Value.ToString.ToLower, txtBuscar.Text.ToLower) Then
                            myRow.Selected = True
                            If txtBuscar.Text = "" Then
                                tblTiposDeMaquinas.ClearSelection()
                            End If
                        End If
                    End If
                End If
            Next
        Next
    End Sub
End Class



