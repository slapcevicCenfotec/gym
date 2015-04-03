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
        Me.dtHasta = New MetroFramework.Controls.MetroDateTime()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
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
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.ErPrValidaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroPanel1.SuspendLayout()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtHasta
        '
        Me.dtHasta.Location = New System.Drawing.Point(504, 324)
        Me.dtHasta.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(250, 29)
        Me.dtHasta.Style = MetroFramework.MetroColorStyle.Purple
        Me.dtHasta.TabIndex = 28
        Me.dtHasta.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(89, 32)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(327, 35)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtBuscar.UseSelectable = True
        '
        'lbclientes
        '
        Me.lbclientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lbclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbclientes.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbclientes.FormattingEnabled = True
        Me.lbclientes.Location = New System.Drawing.Point(16, 77)
        Me.lbclientes.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lbclientes.Name = "lbclientes"
        Me.lbclientes.Size = New System.Drawing.Size(400, 275)
        Me.lbclientes.TabIndex = 29
        '
        'dtDesde
        '
        Me.dtDesde.Location = New System.Drawing.Point(504, 257)
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
        Me.dbTipo.Location = New System.Drawing.Point(504, 59)
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
        Me.MetroLabel3.Location = New System.Drawing.Point(504, 296)
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
        Me.lblTxtFactura.Location = New System.Drawing.Point(502, 163)
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
        Me.txtMonto.Location = New System.Drawing.Point(504, 125)
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
        Me.lblTipoDePagoMonto.Location = New System.Drawing.Point(504, 97)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(499, 229)
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
        Me.lblTipoDePagoDuracion.Location = New System.Drawing.Point(504, 31)
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
        Me.txtFactura.Location = New System.Drawing.Point(504, 191)
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
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.btnCancelar)
        Me.MetroPanel1.Controls.Add(Me.txtBuscar)
        Me.MetroPanel1.Controls.Add(Me.btnGuardar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.lbclientes)
        Me.MetroPanel1.Controls.Add(Me.dtHasta)
        Me.MetroPanel1.Controls.Add(Me.txtFactura)
        Me.MetroPanel1.Controls.Add(Me.dtDesde)
        Me.MetroPanel1.Controls.Add(Me.lblTipoDePagoDuracion)
        Me.MetroPanel1.Controls.Add(Me.dbTipo)
        Me.MetroPanel1.Controls.Add(Me.lblTipoDePagoMonto)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.txtMonto)
        Me.MetroPanel1.Controls.Add(Me.lblTxtFactura)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(82, 58)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(796, 465)
        Me.MetroPanel1.TabIndex = 27
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 37)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(67, 25)
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = "Buscar "
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(16, 414)
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
        Me.btnGuardar.Location = New System.Drawing.Point(630, 414)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'ErPrExcepciones
        '
        Me.ErPrExcepciones.BlinkRate = 0
        Me.ErPrExcepciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrExcepciones.ContainerControl = Me
        Me.ErPrExcepciones.Icon = CType(resources.GetObject("ErPrExcepciones.Icon"), System.Drawing.Icon)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(-114, -29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel1.TabIndex = 26
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(82, 30)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(146, 25)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel7.TabIndex = 60
        Me.MetroLabel7.Text = "REGISTRAR PAGO"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'ErPrValidaciones
        '
        Me.ErPrValidaciones.BlinkRate = 0
        Me.ErPrValidaciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidaciones.ContainerControl = Me
        Me.ErPrValidaciones.Icon = CType(resources.GetObject("ErPrValidaciones.Icon"), System.Drawing.Icon)
        '
        'FrmRegistrarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FrmRegistrarPago"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtHasta As MetroFramework.Controls.MetroDateTime
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
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbclientes As System.Windows.Forms.ListBox
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider

End Class
