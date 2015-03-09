Public Class eGym
    Public Property passedIdMaquina As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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
        ctr = New FrmListarTiposDeMaquinas
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub
End Class