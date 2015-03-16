Public Class FrmReportes
    Inherits MetroFramework.Controls.MetroUserControl

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim ctr As Control
        ctr = New FrmReporteExcepciones
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub
End Class
