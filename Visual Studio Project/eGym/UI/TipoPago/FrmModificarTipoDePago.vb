Public Class FrmModificarTipoDePago

    Private Sub FrmModificarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
