Public Class FrmListarTiposDeMaquinas
    Public Property idToPass As Integer

    Private Sub FrmListarTiposDeMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblTiposDeMaquinas.DataSource = objGestorTipoDeMaquina.listarMaquinas()
        configurarColumnas()
    End Sub
    Private Sub configurarColumnas()
        tblTiposDeMaquinas.Columns(0).Visible = False
        tblTiposDeMaquinas.Columns(1).Visible = False
        tblTiposDeMaquinas.Columns(2).HeaderText = "Nombre"
        tblTiposDeMaquinas.Columns(3).HeaderText = "Descripción"
        tblTiposDeMaquinas.Columns(4).Visible = False
    End Sub

    Private Sub tblTiposDeMaquinas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblTiposDeMaquinas.CellContentClick
        Dim selectedRow As DataGridViewRow = Me.tblTiposDeMaquinas.Rows(e.RowIndex)
        idToPass = selectedRow.Cells("ID").Value.ToString
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If idToPass <> 0 Then
            Dim ctr As Control
            eGym.passedIdMaquina = idToPass
            ctr = New FrmModificarTipoDeMaquina
            ctr.Dock = DockStyle.Fill
            Me.Controls.Clear()
            Me.Controls.Add(ctr)
        End If
    End Sub
End Class



