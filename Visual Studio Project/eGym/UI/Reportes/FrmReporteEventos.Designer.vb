<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteEventos
    Inherits System.Windows.Forms.UserControl

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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGymDBDataSet = New UI.eGymDBDataSet()
        Me.SP_ListarEventosTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarEventosTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ListarEventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGymDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ListarEventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "SP_ListarEventos"
        Me.BindingSource1.DataSource = Me.EGymDBDataSet
        '
        'EGymDBDataSet
        '
        Me.EGymDBDataSet.DataSetName = "eGymDBDataSet"
        Me.EGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarEventosTableAdapter
        '
        Me.SP_ListarEventosTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetEventos"
        ReportDataSource1.Value = Me.SP_ListarEventosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReporteEventos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 695)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_ListarEventosBindingSource
        '
        Me.SP_ListarEventosBindingSource.DataMember = "SP_ListarEventos"
        Me.SP_ListarEventosBindingSource.DataSource = Me.EGymDBDataSet
        '
        'FrmReporteEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteEventos"
        Me.Size = New System.Drawing.Size(960, 695)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGymDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ListarEventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EGymDBDataSet As UI.eGymDBDataSet
    Friend WithEvents SP_ListarEventosTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarEventosTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ListarEventosBindingSource As System.Windows.Forms.BindingSource

End Class
