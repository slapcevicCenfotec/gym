<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarTipoPago
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
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(18, 13)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(85, 23)
        Me.MetroLink1.TabIndex = 0
        Me.MetroLink1.Text = "Tipo de Pagos"
        Me.MetroLink1.UseSelectable = True
        '
        'FrmListarTipoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLink1)
        Me.Name = "FrmListarTipoPago"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink

End Class
