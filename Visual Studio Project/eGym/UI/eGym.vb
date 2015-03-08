Public Class eGym
    Public Property passedIdMaquina As Integer

    Private Sub eGym_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarMenu()
    End Sub

    Private Sub InicializarMenu()
        For Each lbl As Label In menuPanel.Controls.OfType(Of Label)()
            AddHandler lbl.Click, Function(senderObj, args) Seleccionar(lbl)
        Next
    End Sub

    Private Function Seleccionar(lbl As Label)
        For Each ctr As Label In menuPanel.Controls.OfType(Of Label)()
            ctr.BackColor = Color.White
            ctr.ForeColor = Color.Black
        Next
        lbl.BackColor = Color.FromArgb(0, 170, 171)
        lbl.ForeColor = Color.White
        Return lbl
    End Function

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        Dim ctr As Control
        ctr = New FrmListarPago
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub btnMaquinas_Click(sender As Object, e As EventArgs) Handles btnMaquinas.Click
        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        Dim ctr As Control
        ctr = New FrmListarMusculo
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click
        Dim ctr As Control
        ctr = New FrmListarEjercicio
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel5_Click(sender As Object, e As EventArgs) Handles MetroLabel5.Click

    End Sub
End Class