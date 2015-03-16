Public Class FrmListarPago

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub FrmListarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnTipoDePago_Click(sender As Object, e As EventArgs) Handles btnTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnRegistarPago_Click(sender As Object, e As EventArgs) Handles btnRegistarPago.Click
        Dim ctr As Control
        ctr = New FrmRegistrarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
