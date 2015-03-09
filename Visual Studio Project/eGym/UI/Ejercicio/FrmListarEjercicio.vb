Public Class FrmListarEjercicio

    Private Sub FrmListarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblEjercicio.DataSource = objeGestorEjercicio.listarEjercicios()

    End Sub

    Private Sub btnAgregarEjercicio_Click(sender As Object, e As EventArgs) Handles btnAgregarEjercicio.Click
        Dim ctr As Control
        ctr = New FrmRegistrarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
