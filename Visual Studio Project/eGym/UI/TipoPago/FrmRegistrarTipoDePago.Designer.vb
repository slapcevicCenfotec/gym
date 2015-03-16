<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarTipoDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarTipoDePago))
        Me.lblTipoDePagoNombre = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDePagoMonto = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDePagoDuracion = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New MetroFramework.Controls.MetroTextBox()
        Me.txtDuracion = New MetroFramework.Controls.MetroTextBox()
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ErPrValidaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoDePagoNombre
        '
        Me.lblTipoDePagoNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDePagoNombre.AutoSize = True
        Me.lblTipoDePagoNombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDePagoNombre.ForeColor = System.Drawing.Color.Transparent
        Me.lblTipoDePagoNombre.Location = New System.Drawing.Point(91, 16)
        Me.lblTipoDePagoNombre.Name = "lblTipoDePagoNombre"
        Me.lblTipoDePagoNombre.Size = New System.Drawing.Size(75, 25)
        Me.lblTipoDePagoNombre.TabIndex = 0
        Me.lblTipoDePagoNombre.Text = "Nombre"
        Me.lblTipoDePagoNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDePagoNombre.UseCustomBackColor = True
        '
        'lblTipoDePagoMonto
        '
        Me.lblTipoDePagoMonto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDePagoMonto.AutoSize = True
        Me.lblTipoDePagoMonto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDePagoMonto.ForeColor = System.Drawing.Color.Transparent
        Me.lblTipoDePagoMonto.Location = New System.Drawing.Point(91, 82)
        Me.lblTipoDePagoMonto.Name = "lblTipoDePagoMonto"
        Me.lblTipoDePagoMonto.Size = New System.Drawing.Size(62, 25)
        Me.lblTipoDePagoMonto.TabIndex = 0
        Me.lblTipoDePagoMonto.Text = "Monto"
        Me.lblTipoDePagoMonto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDePagoMonto.UseCustomBackColor = True
        '
        'lblTipoDePagoDuracion
        '
        Me.lblTipoDePagoDuracion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDePagoDuracion.AutoSize = True
        Me.lblTipoDePagoDuracion.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoDePagoDuracion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDePagoDuracion.Location = New System.Drawing.Point(91, 148)
        Me.lblTipoDePagoDuracion.Name = "lblTipoDePagoDuracion"
        Me.lblTipoDePagoDuracion.Size = New System.Drawing.Size(123, 25)
        Me.lblTipoDePagoDuracion.TabIndex = 0
        Me.lblTipoDePagoDuracion.Text = "Duracion(Días)"
        Me.lblTipoDePagoDuracion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDePagoDuracion.UseCustomBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtMonto.Lines = New String(-1) {}
        Me.txtMonto.Location = New System.Drawing.Point(91, 110)
        Me.txtMonto.MaxLength = 32767
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(250, 35)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtMonto.UseSelectable = True
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDuracion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDuracion.Lines = New String(-1) {}
        Me.txtDuracion.Location = New System.Drawing.Point(91, 176)
        Me.txtDuracion.MaxLength = 32767
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuracion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDuracion.SelectedText = ""
        Me.txtDuracion.Size = New System.Drawing.Size(250, 35)
        Me.txtDuracion.TabIndex = 3
        Me.txtDuracion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDuracion.UseSelectable = True
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
        Me.btnCancelar.Location = New System.Drawing.Point(16, 358)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 35)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(266, 358)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel1.Controls.Add(Me.txtNombre)
        Me.MetroPanel1.Controls.Add(Me.lblTipoDePagoNombre)
        Me.MetroPanel1.Controls.Add(Me.lblTipoDePagoDuracion)
        Me.MetroPanel1.Controls.Add(Me.lblTipoDePagoMonto)
        Me.MetroPanel1.Controls.Add(Me.txtMonto)
        Me.MetroPanel1.Controls.Add(Me.txtDuracion)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(432, 262)
        Me.MetroPanel1.TabIndex = 23
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(91, 44)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(205, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "AGREGAR TIPO DE PAGO"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ErPrValidaciones
        '
        Me.ErPrValidaciones.BlinkRate = 0
        Me.ErPrValidaciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidaciones.ContainerControl = Me
        Me.ErPrValidaciones.Icon = CType(resources.GetObject("ErPrValidaciones.Icon"), System.Drawing.Icon)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroPanel2.Controls.Add(Me.MetroPanel1)
        Me.MetroPanel2.Controls.Add(Me.btnCancelar)
        Me.MetroPanel2.Controls.Add(Me.btnGuardar)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(264, 30)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(432, 409)
        Me.MetroPanel2.TabIndex = 30
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'FrmRegistrarTipoDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "FrmRegistrarTipoDePago"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTipoDePagoNombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDePagoMonto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDePagoDuracion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMonto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDuracion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel

End Class
