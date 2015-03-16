Imports Microsoft.Reporting.WinForms
Public Class FrmReporteExcepciones

    Inherits MetroFramework.Controls.MetroUserControl

    Private Sub FrmReporteExcepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SP_ListarExcepcionesTableAdapter.Fill(Me.eGymDBDataSet.SP_ListarExcepciones())
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
