<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensajeOk
    Inherits MetroFramework.Forms.MetroForm
    'Form overrides dispose to clean up the component list.
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
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.lblMensaje = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.AutoSize = True
        Me.btnOk.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnOk.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnOk.Location = New System.Drawing.Point(175, 182)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 35)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnOk.UseSelectable = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMensaje.Location = New System.Drawing.Point(28, 100)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(16, 16, 3, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 0)
        Me.lblMensaje.TabIndex = 8
        Me.lblMensaje.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMensaje.UseCustomBackColor = True
        '
        'FrmMensajeOk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "FrmMensajeOk"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Mensaje"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents lblMensaje As MetroFramework.Controls.MetroLabel
End Class
