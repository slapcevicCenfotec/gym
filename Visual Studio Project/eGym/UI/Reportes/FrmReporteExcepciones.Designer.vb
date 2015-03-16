<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteExcepciones
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_ListarExcepcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGymDBDataSet = New UI.eGymDBDataSet()
        Me.SP_ListarExcepcionesTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarExcepcionesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.SP_ListarExcepcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_ListarExcepcionesBindingSource
        '
        Me.SP_ListarExcepcionesBindingSource.DataMember = "SP_ListarExcepciones"
        Me.SP_ListarExcepcionesBindingSource.DataSource = Me.eGymDBDataSet
        '
        'eGymDBDataSet
        '
        Me.eGymDBDataSet.DataSetName = "eGymDBDataSet"
        Me.eGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarExcepcionesTableAdapter
        '
        Me.SP_ListarExcepcionesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsReporteExcepciones"
        ReportDataSource1.Value = Me.SP_ListarExcepcionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReporteExcepciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 695)
        Me.ReportViewer1.TabIndex = 5
        '
        'FrmReporteExcepciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteExcepciones"
        Me.Size = New System.Drawing.Size(960, 695)
        CType(Me.SP_ListarExcepcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SP_ListarExcepcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGymDBDataSet As UI.eGymDBDataSet
    Friend WithEvents SP_ListarExcepcionesTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarExcepcionesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

End Class
