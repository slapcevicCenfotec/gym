<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarMaquina))
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.ErPrValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        CType(Me.ErPrValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTipoDeMaquina.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 29
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(355, 121)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.cmbTipoDeMaquina.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbTipoDeMaquina.TabIndex = 11
        Me.cmbTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbTipoDeMaquina.UseSelectable = True
        '
        'txtNumeroDeMaquina
        '
        Me.txtNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeMaquina.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeMaquina.Lines = New String(-1) {}
        Me.txtNumeroDeMaquina.Location = New System.Drawing.Point(355, 337)
        Me.txtNumeroDeMaquina.MaxLength = 32767
        Me.txtNumeroDeMaquina.Name = "txtNumeroDeMaquina"
        Me.txtNumeroDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeMaquina.SelectedText = ""
        Me.txtNumeroDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.txtNumeroDeMaquina.TabIndex = 13
        Me.txtNumeroDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNumeroDeMaquina.UseSelectable = True
        '
        'txtNumeroDeActivo
        '
        Me.txtNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeActivo.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeActivo.Lines = New String(-1) {}
        Me.txtNumeroDeActivo.Location = New System.Drawing.Point(355, 229)
        Me.txtNumeroDeActivo.MaxLength = 32767
        Me.txtNumeroDeActivo.Name = "txtNumeroDeActivo"
        Me.txtNumeroDeActivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeActivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeActivo.SelectedText = ""
        Me.txtNumeroDeActivo.Size = New System.Drawing.Size(250, 35)
        Me.txtNumeroDeActivo.TabIndex = 12
        Me.txtNumeroDeActivo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNumeroDeActivo.UseSelectable = True
        '
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(355, 309)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(171, 25)
        Me.lblNumeroDeMaquina.TabIndex = 8
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        Me.lblNumeroDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(355, 201)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(148, 25)
        Me.lblNumeroDeActivo.TabIndex = 9
        Me.lblNumeroDeActivo.Text = "Número de activo"
        Me.lblNumeroDeActivo.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(355, 93)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(141, 25)
        Me.lblTipoDeMaquina.TabIndex = 10
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        Me.lblTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ErPrValidacion
        '
        Me.ErPrValidacion.BlinkRate = 0
        Me.ErPrValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidacion.ContainerControl = Me
        Me.ErPrValidacion.Icon = CType(resources.GetObject("ErPrValidacion.Icon"), System.Drawing.Icon)
        '
        'ErPrExcepciones
        '
        Me.ErPrExcepciones.BlinkRate = 0
        Me.ErPrExcepciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrExcepciones.ContainerControl = Me
        Me.ErPrExcepciones.Icon = CType(resources.GetObject("ErPrExcepciones.Icon"), System.Drawing.Icon)
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(819, 16)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 30)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(679, 16)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 30)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'FrmModificarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbTipoDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeActivo)
        Me.Controls.Add(Me.lblNumeroDeMaquina)
        Me.Controls.Add(Me.lblNumeroDeActivo)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmModificarMaquina"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErPrValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErPrValidacion As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton

End Class
