<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarMaquina))
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 23
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(308, 122)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(200, 29)
        Me.cmbTipoDeMaquina.TabIndex = 11
        Me.cmbTipoDeMaquina.UseSelectable = True
        '
        'txtNumeroDeMaquina
        '
        Me.txtNumeroDeMaquina.Lines = New String(-1) {}
        Me.txtNumeroDeMaquina.Location = New System.Drawing.Point(308, 243)
        Me.txtNumeroDeMaquina.MaxLength = 32767
        Me.txtNumeroDeMaquina.Name = "txtNumeroDeMaquina"
        Me.txtNumeroDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeMaquina.SelectedText = ""
        Me.txtNumeroDeMaquina.Size = New System.Drawing.Size(200, 23)
        Me.txtNumeroDeMaquina.TabIndex = 13
        Me.txtNumeroDeMaquina.UseSelectable = True
        '
        'txtNumeroDeActivo
        '
        Me.txtNumeroDeActivo.Lines = New String(-1) {}
        Me.txtNumeroDeActivo.Location = New System.Drawing.Point(308, 184)
        Me.txtNumeroDeActivo.MaxLength = 32767
        Me.txtNumeroDeActivo.Name = "txtNumeroDeActivo"
        Me.txtNumeroDeActivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeActivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeActivo.SelectedText = ""
        Me.txtNumeroDeActivo.Size = New System.Drawing.Size(200, 23)
        Me.txtNumeroDeActivo.TabIndex = 12
        Me.txtNumeroDeActivo.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(127, 245)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(132, 19)
        Me.lblNumeroDeMaquina.TabIndex = 8
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(127, 186)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(115, 19)
        Me.lblNumeroDeActivo.TabIndex = 9
        Me.lblNumeroDeActivo.Text = "Número de activo"
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(127, 127)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 10
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'FrmModificarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbTipoDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeActivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNumeroDeMaquina)
        Me.Controls.Add(Me.lblNumeroDeActivo)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmModificarMaquina"
        Me.Size = New System.Drawing.Size(650, 400)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
