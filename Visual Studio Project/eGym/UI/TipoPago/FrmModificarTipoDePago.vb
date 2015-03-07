Public Class FrmModificarTipoDePago

    Private actual As Integer
    Public Sub New(ByVal ID As Integer)
        Me.actual = ID
    End Sub

    Private Sub FrmModificarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load









    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

    End Sub
End Class
