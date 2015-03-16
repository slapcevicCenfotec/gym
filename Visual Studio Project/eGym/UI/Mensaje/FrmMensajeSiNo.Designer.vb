<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensajeSiNo
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
        Me.btnNo = New MetroFramework.Controls.MetroButton()
        Me.lblMensaje = New MetroFramework.Controls.MetroLabel()
        Me.btnSi = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNo.AutoSize = True
        Me.btnNo.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnNo.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnNo.Location = New System.Drawing.Point(70, 176)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(100, 35)
        Me.btnNo.TabIndex = 0
        Me.btnNo.Text = "No"
        Me.btnNo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnNo.UseSelectable = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMensaje.Location = New System.Drawing.Point(70, 92)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(16, 16, 3, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 0)
        Me.lblMensaje.TabIndex = 7
        Me.lblMensaje.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMensaje.UseCustomBackColor = True
        '
        'btnSi
        '
        Me.btnSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSi.AutoSize = True
        Me.btnSi.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSi.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnSi.Location = New System.Drawing.Point(299, 176)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(100, 35)
        Me.btnSi.TabIndex = 0
        Me.btnSi.Text = "Si"
        Me.btnSi.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSi.UseSelectable = True
        '
        'FrmMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnNo)
        Me.Name = "FrmMensaje"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Eliminar"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNo As MetroFramework.Controls.MetroButton
    Friend WithEvents lblMensaje As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSi As MetroFramework.Controls.MetroButton
End Class
