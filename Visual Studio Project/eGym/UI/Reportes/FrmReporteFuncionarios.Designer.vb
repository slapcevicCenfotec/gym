<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteFuncionarios
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.eGymDBDataSet = New UI.eGymDBDataSet()
        Me.SP_ListarFuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ListarFuncionariosTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarFuncionariosTableAdapter()
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ListarFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ListarFuncionariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReporteFuncionarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 695)
        Me.ReportViewer1.TabIndex = 0
        '
        'eGymDBDataSet
        '
        Me.eGymDBDataSet.DataSetName = "eGymDBDataSet"
        Me.eGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarFuncionariosBindingSource
        '
        Me.SP_ListarFuncionariosBindingSource.DataMember = "SP_ListarFuncionarios"
        Me.SP_ListarFuncionariosBindingSource.DataSource = Me.eGymDBDataSet
        '
        'SP_ListarFuncionariosTableAdapter
        '
        Me.SP_ListarFuncionariosTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteFuncionarios"
        Me.Size = New System.Drawing.Size(960, 695)
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ListarFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ListarFuncionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGymDBDataSet As UI.eGymDBDataSet
    Friend WithEvents SP_ListarFuncionariosTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarFuncionariosTableAdapter

End Class
