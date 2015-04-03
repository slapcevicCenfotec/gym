Public Class FrmReporteFuncionarios

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.SP_ListarFuncionariosTableAdapter.Fill(Me.eGymDBDataSet.SP_ListarFuncionarios())
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
