<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarPago))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.dtHasta = New MetroFramework.Controls.MetroDateTime()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbclientes = New System.Windows.Forms.ListBox()
        Me.dtDesde = New MetroFramework.Controls.MetroDateTime()
        Me.dbTipo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblTxtFactura = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New MetroFramework.Controls.MetroTextBox()
        Me.lblTipoDePagoMonto = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDePagoDuracion = New MetroFramework.Controls.MetroLabel()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErPrValidaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 412)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 67)
        Me.Panel1.TabIndex = 23
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(16, 19)
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
        Me.btnGuardar.Location = New System.Drawing.Point(695, 19)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'dtHasta
        '
        Me.dtHasta.Location = New System.Drawing.Point(613, 168)
        Me.dtHasta.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(250, 29)
        Me.dtHasta.Style = MetroFramework.MetroColorStyle.Purple
        Me.dtHasta.TabIndex = 28
        Me.dtHasta.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MetroTextBox1)
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Controls.Add(Me.lbclientes)
        Me.Panel2.Controls.Add(Me.dtHasta)
        Me.Panel2.Controls.Add(Me.dtDesde)
        Me.Panel2.Controls.Add(Me.dbTipo)
        Me.Panel2.Controls.Add(Me.MetroLabel3)
        Me.Panel2.Controls.Add(Me.lblTxtFactura)
        Me.Panel2.Controls.Add(Me.txtMonto)
        Me.Panel2.Controls.Add(Me.lblTipoDePagoMonto)
        Me.Panel2.Controls.Add(Me.MetroLabel2)
        Me.Panel2.Controls.Add(Me.lblTipoDePagoDuracion)
        Me.Panel2.Controls.Add(Me.txtFactura)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 345)
        Me.Panel2.TabIndex = 24
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(299, 41)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(250, 35)
        Me.MetroTextBox1.TabIndex = 31
        Me.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTextBox1.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Location = New System.Drawing.Point(299, 13)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel4.TabIndex = 30
        Me.MetroLabel4.Text = "Buscar cliente"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'lbclientes
        '
        Me.lbclientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lbclientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbclientes.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbclientes.FormattingEnabled = True
        Me.lbclientes.Location = New System.Drawing.Point(16, 13)
        Me.lbclientes.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lbclientes.Name = "lbclientes"
        Me.lbclientes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbclientes.Size = New System.Drawing.Size(250, 312)
        Me.lbclientes.TabIndex = 29
        '
        'dtDesde
        '
        Me.dtDesde.Location = New System.Drawing.Point(613, 293)
        Me.dtDesde.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(250, 29)
        Me.dtDesde.Style = MetroFramework.MetroColorStyle.Purple
        Me.dtDesde.TabIndex = 27
        Me.dtDesde.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'dbTipo
        '
        Me.dbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dbTipo.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.dbTipo.FormattingEnabled = True
        Me.dbTipo.ItemHeight = 29
        Me.dbTipo.Location = New System.Drawing.Point(299, 168)
        Me.dbTipo.Name = "dbTipo"
        Me.dbTipo.Size = New System.Drawing.Size(250, 35)
        Me.dbTipo.Style = MetroFramework.MetroColorStyle.Purple
        Me.dbTipo.TabIndex = 26
        Me.dbTipo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.dbTipo.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(613, 140)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(54, 25)
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "Hasta"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'lblTxtFactura
        '
        Me.lblTxtFactura.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTxtFactura.AutoSize = True
        Me.lblTxtFactura.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTxtFactura.ForeColor = System.Drawing.Color.Transparent
        Me.lblTxtFactura.Location = New System.Drawing.Point(613, 13)
        Me.lblTxtFactura.Name = "lblTxtFactura"
        Me.lblTxtFactura.Size = New System.Drawing.Size(156, 25)
        Me.lblTxtFactura.TabIndex = 0
        Me.lblTxtFactura.Text = "Numero de factura"
        Me.lblTxtFactura.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTxtFactura.UseCustomBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtMonto.Lines = New String(-1) {}
        Me.txtMonto.Location = New System.Drawing.Point(299, 293)
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
        'lblTipoDePagoMonto
        '
        Me.lblTipoDePagoMonto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDePagoMonto.AutoSize = True
        Me.lblTipoDePagoMonto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDePagoMonto.ForeColor = System.Drawing.Color.Transparent
        Me.lblTipoDePagoMonto.Location = New System.Drawing.Point(299, 265)
        Me.lblTipoDePagoMonto.Name = "lblTipoDePagoMonto"
        Me.lblTipoDePagoMonto.Size = New System.Drawing.Size(62, 25)
        Me.lblTipoDePagoMonto.TabIndex = 0
        Me.lblTipoDePagoMonto.Text = "Monto"
        Me.lblTipoDePagoMonto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDePagoMonto.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(613, 265)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 25)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Desde"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'lblTipoDePagoDuracion
        '
        Me.lblTipoDePagoDuracion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDePagoDuracion.AutoSize = True
        Me.lblTipoDePagoDuracion.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoDePagoDuracion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDePagoDuracion.Location = New System.Drawing.Point(299, 140)
        Me.lblTipoDePagoDuracion.Name = "lblTipoDePagoDuracion"
        Me.lblTipoDePagoDuracion.Size = New System.Drawing.Size(45, 25)
        Me.lblTipoDePagoDuracion.TabIndex = 0
        Me.lblTipoDePagoDuracion.Text = "Tipo"
        Me.lblTipoDePagoDuracion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDePagoDuracion.UseCustomBackColor = True
        '
        'txtFactura
        '
        Me.txtFactura.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFactura.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFactura.Lines = New String(-1) {}
        Me.txtFactura.Location = New System.Drawing.Point(613, 41)
        Me.txtFactura.MaxLength = 32767
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactura.SelectedText = ""
        Me.txtFactura.Size = New System.Drawing.Size(250, 35)
        Me.txtFactura.TabIndex = 4
        Me.txtFactura.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFactura.UseSelectable = True
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
        Me.MetroPanel1.Location = New System.Drawing.Point(138, 64)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(900, 479)
        Me.MetroPanel1.TabIndex = 27
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR PAGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErPrExcepciones
        '
        Me.ErPrExcepciones.BlinkRate = 0
        Me.ErPrExcepciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrExcepciones.ContainerControl = Me
        Me.ErPrExcepciones.Icon = CType(resources.GetObject("ErPrExcepciones.Icon"), System.Drawing.Icon)
        '
        'ErPrValidaciones
        '
        Me.ErPrValidaciones.BlinkRate = 0
        Me.ErPrValidaciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidaciones.ContainerControl = Me
        Me.ErPrValidaciones.Icon = CType(resources.GetObject("ErPrValidaciones.Icon"), System.Drawing.Icon)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(-114, -29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel1.TabIndex = 26
        '
        'FrmRegistrarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FrmRegistrarPago"
        Me.Size = New System.Drawing.Size(1052, 650)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents dtHasta As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtDesde As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dbTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTxtFactura As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMonto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTipoDePagoMonto As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDePagoDuracion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbclientes As System.Windows.Forms.ListBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel

End Class
