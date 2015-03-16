Public Class FrmReporteEventos

    Private Sub FrmReporteEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SP_ListarEventosTableAdapter.Fill(Me.EGymDBDataSet.SP_ListarEventos())
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
