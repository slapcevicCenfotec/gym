Imports EL
Class FrmListarTipoDePago

    Public Property tipoPagoToPass As TipoDePago
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmModificarTipoDePago(tblListaTipoDePago.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        Dim auxTipoDePago As TipoDePago
        auxTipoDePago = tblListaTipoDePago.CurrentRow.DataBoundItem
        objGestorTipoPago.eliminarTipoDePago(auxTipoDePago.Id)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub FrmListarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblListaTipoDePago.DataSource = objGestorTipoPago.listarTiposDePago()
        tblListaTipoDePago.Columns("Id").Visible = False
        tblListaTipoDePago.Columns("isValid").Visible = False
        tblListaTipoDePago.Columns("Habilitado").Visible = False

    End Sub
 

    Private Sub tblListaTipoDePago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)



    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MetroPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnAgregarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmRegistrarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnModificarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnModificarTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmModificarTipoDePago(tblListaTipoDePago.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoDePago.Click
        Dim auxTipoDePago As TipoDePago
        auxTipoDePago = tblListaTipoDePago.CurrentRow.DataBoundItem
        objGestorTipoPago.eliminarTipoDePago(auxTipoDePago.Id)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
