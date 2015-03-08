Public Class eGym

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

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        Dim ctr As Control
        ctr = New FrmRegistrarTiposMaquinas
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click
        Dim ctr As Control
        ctr = New FrmListarRoles
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub
End Class