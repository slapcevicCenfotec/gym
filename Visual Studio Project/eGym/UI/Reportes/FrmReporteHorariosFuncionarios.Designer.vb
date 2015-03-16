<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteHorariosFuncionarios
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
        Me.eGymDBDataSet = New UI.eGymDBDataSet()
        Me.SP_ListarHorariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ListarHorariosFuncionarios = New UI.eGymDBDataSetTableAdapters.SP_ListarFuncionariosTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ListarHorariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eGymDBDataSet
        '
        Me.eGymDBDataSet.DataSetName = "eGymDBDataSet"
        Me.eGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarHorariosBindingSource
        '
        Me.SP_ListarHorariosBindingSource.DataMember = "SP_ListarFuncionarios"
        Me.SP_ListarHorariosBindingSource.DataSource = Me.eGymDBDataSet
        '
        'SP_ListarHorariosFuncionarios
        '
        Me.SP_ListarHorariosFuncionarios.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 695)
        Me.ReportViewer1.TabIndex = 0
        '
        'FrmReporteHorariosFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteHorariosFuncionarios"
        Me.Size = New System.Drawing.Size(960, 695)
        CType(Me.eGymDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ListarHorariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents eGymDBDataSet As UI.eGymDBDataSet
    Friend WithEvents SP_ListarHorariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ListarHorariosFuncionarios As UI.eGymDBDataSetTableAdapters.SP_ListarFuncionariosTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

End Class
