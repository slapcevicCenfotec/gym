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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.btnCancelar.Location = New System.Drawing.Point(16, 16)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 35)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel1.Controls.Add(Me.Panel2)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.Panel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(322, 71)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(432, 479)
        Me.MetroPanel1.TabIndex = 22
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGREGAR MAQUINA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 412)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 67)
        Me.Panel1.TabIndex = 23
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(264, 16)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'txtNumeroDeMaquina
        '
        Me.txtNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeMaquina.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeMaquina.Lines = New String(-1) {}
        Me.txtNumeroDeMaquina.Location = New System.Drawing.Point(91, 235)
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
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTipoDeMaquina.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 29
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(91, 103)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.cmbTipoDeMaquina.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbTipoDeMaquina.TabIndex = 1
        Me.cmbTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbTipoDeMaquina.UseSelectable = True
        '
        'txtNumeroDeActivo
        '
        Me.txtNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumeroDeActivo.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumeroDeActivo.Lines = New String(-1) {}
        Me.txtNumeroDeActivo.Location = New System.Drawing.Point(91, 169)
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
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(91, 207)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(171, 25)
        Me.lblNumeroDeMaquina.TabIndex = 0
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        Me.lblNumeroDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblNumeroDeMaquina.UseCustomBackColor = True
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNumeroDeActivo.ForeColor = System.Drawing.Color.Transparent
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(91, 141)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(148, 25)
        Me.lblNumeroDeActivo.TabIndex = 0
        Me.lblNumeroDeActivo.Text = "Número de activo"
        Me.lblNumeroDeActivo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblNumeroDeActivo.UseCustomBackColor = True
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDeMaquina.ForeColor = System.Drawing.Color.Transparent
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(91, 75)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(141, 25)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        Me.lblTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDeMaquina.UseCustomBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTipoDeMaquina)
        Me.Panel2.Controls.Add(Me.lblNumeroDeActivo)
        Me.Panel2.Controls.Add(Me.lblNumeroDeMaquina)
        Me.Panel2.Controls.Add(Me.txtNumeroDeActivo)
        Me.Panel2.Controls.Add(Me.cmbTipoDeMaquina)
        Me.Panel2.Controls.Add(Me.txtNumeroDeMaquina)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 345)
        Me.Panel2.TabIndex = 24
        '
        'lblTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "lblTitulo"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton

End Class
