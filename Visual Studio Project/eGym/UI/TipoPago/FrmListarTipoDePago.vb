Imports EL
Class FrmListarTipoDePago

    Public Property tipoPagoToPass As TipoDePago
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim ctr As Control
        ctr = New FrmAgregarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmModificarTipoDePago(Me.tipoPagoToPass)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

    End Sub

    Private Sub FrmListarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblListaTipoDePago.DataSource = objGestorTipoPago.listarTiposDePago()
    End Sub

    Private Sub tblListaTipoDePago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblListaTipoDePago.CellContentClick
        Me.tipoPagoToPass = tblListaTipoDePago.CurrentRow.DataBoundItem()
    End Sub
End Class
