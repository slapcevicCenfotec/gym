<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblTitulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblTitulo))
        Me.ErPrValidaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErPrValidaciones
        '
        Me.ErPrValidaciones.BlinkRate = 0
        Me.ErPrValidaciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidaciones.ContainerControl = Me
        Me.ErPrValidaciones.Icon = CType(resources.GetObject("ErPrValidaciones.Icon"), System.Drawing.Icon)
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
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(65, 352)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 35)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDeMaquina.ForeColor = System.Drawing.Color.Transparent
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(106, 16)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(141, 25)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        Me.lblTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDeMaquina.UseCustomBackColor = True
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeActivo.ForeColor = System.Drawing.Color.Transparent
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(106, 82)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(148, 25)
        Me.lblNumeroDeActivo.TabIndex = 0
        Me.lblNumeroDeActivo.Text = "Número de activo"
        Me.lblNumeroDeActivo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblNumeroDeActivo.UseCustomBackColor = True
        '
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(106, 148)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(171, 25)
        Me.lblNumeroDeMaquina.TabIndex = 0
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        Me.lblNumeroDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblNumeroDeMaquina.UseCustomBackColor = True
        '
        'txtNumeroDeActivo
        '
        Me.txtNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeActivo.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeActivo.Lines = New String(-1) {}
        Me.txtNumeroDeActivo.Location = New System.Drawing.Point(106, 110)
        Me.txtNumeroDeActivo.MaxLength = 32767
        Me.txtNumeroDeActivo.Name = "txtNumeroDeActivo"
        Me.txtNumeroDeActivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeActivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeActivo.SelectedText = ""
        Me.txtNumeroDeActivo.Size = New System.Drawing.Size(250, 35)
        Me.txtNumeroDeActivo.TabIndex = 2
        Me.txtNumeroDeActivo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNumeroDeActivo.UseSelectable = True
        '
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTipoDeMaquina.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 29
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(106, 44)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.cmbTipoDeMaquina.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbTipoDeMaquina.TabIndex = 1
        Me.cmbTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbTipoDeMaquina.UseSelectable = True
        '
        'txtNumeroDeMaquina
        '
        Me.txtNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeMaquina.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeMaquina.Lines = New String(-1) {}
        Me.txtNumeroDeMaquina.Location = New System.Drawing.Point(106, 176)
        Me.txtNumeroDeMaquina.MaxLength = 32767
        Me.txtNumeroDeMaquina.Name = "txtNumeroDeMaquina"
        Me.txtNumeroDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeMaquina.SelectedText = ""
        Me.txtNumeroDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.txtNumeroDeMaquina.TabIndex = 3
        Me.txtNumeroDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNumeroDeMaquina.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(247, 352)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroPanel2.Controls.Add(Me.btnCancelar)
        Me.MetroPanel2.Controls.Add(Me.btnGuardar)
        Me.MetroPanel2.Controls.Add(Me.MetroPanel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(249, 30)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(463, 403)
        Me.MetroPanel2.TabIndex = 31
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel3.AutoScroll = True
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel3.Controls.Add(Me.lblTipoDeMaquina)
        Me.MetroPanel3.Controls.Add(Me.lblNumeroDeActivo)
        Me.MetroPanel3.Controls.Add(Me.txtNumeroDeActivo)
        Me.MetroPanel3.Controls.Add(Me.lblNumeroDeMaquina)
        Me.MetroPanel3.Controls.Add(Me.txtNumeroDeMaquina)
        Me.MetroPanel3.Controls.Add(Me.cmbTipoDeMaquina)
        Me.MetroPanel3.HorizontalScrollbar = True
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 60)
        Me.MetroPanel3.Margin = New System.Windows.Forms.Padding(3, 67, 3, 67)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(463, 278)
        Me.MetroPanel3.TabIndex = 27
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbar = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel4.Location = New System.Drawing.Point(0, 16)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(172, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 28
        Me.MetroLabel4.Text = "AGREGAR MÁQUINA"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'lblTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "lblTitulo"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel

End Class
