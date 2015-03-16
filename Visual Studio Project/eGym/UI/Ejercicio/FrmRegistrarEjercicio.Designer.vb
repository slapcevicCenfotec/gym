<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarEjercicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarEjercicio))
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.ptbPosicionInicial = New System.Windows.Forms.PictureBox()
        Me.ofdBuscar2 = New System.Windows.Forms.OpenFileDialog()
        Me.ptbPosicionFinal = New System.Windows.Forms.PictureBox()
        Me.cbListaMusculosPrincipales = New MetroFramework.Controls.MetroComboBox()
        Me.lbMusculosSecundarios = New System.Windows.Forms.ListBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtAlias = New MetroFramework.Controls.MetroTextBox()
        Me.txtPosInicial = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtPosFinal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtErroresComunes = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbPosicionInicial
        '
        Me.ptbPosicionInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbPosicionInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ptbPosicionInicial.Location = New System.Drawing.Point(697, 150)
        Me.ptbPosicionInicial.Name = "ptbPosicionInicial"
        Me.ptbPosicionInicial.Size = New System.Drawing.Size(250, 250)
        Me.ptbPosicionInicial.TabIndex = 17
        Me.ptbPosicionInicial.TabStop = False
        '
        'ptbPosicionFinal
        '
        Me.ptbPosicionFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbPosicionFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ptbPosicionFinal.Location = New System.Drawing.Point(400, 140)
        Me.ptbPosicionFinal.Name = "ptbPosicionFinal"
        Me.ptbPosicionFinal.Size = New System.Drawing.Size(250, 250)
        Me.ptbPosicionFinal.TabIndex = 20
        Me.ptbPosicionFinal.TabStop = False
        '
        'cbListaMusculosPrincipales
        '
        Me.cbListaMusculosPrincipales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbListaMusculosPrincipales.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cbListaMusculosPrincipales.ForeColor = System.Drawing.Color.YellowGreen
        Me.cbListaMusculosPrincipales.FormattingEnabled = True
        Me.cbListaMusculosPrincipales.ItemHeight = 29
        Me.cbListaMusculosPrincipales.Location = New System.Drawing.Point(106, 221)
        Me.cbListaMusculosPrincipales.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cbListaMusculosPrincipales.Name = "cbListaMusculosPrincipales"
        Me.cbListaMusculosPrincipales.Size = New System.Drawing.Size(250, 35)
        Me.cbListaMusculosPrincipales.TabIndex = 23
        Me.cbListaMusculosPrincipales.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbListaMusculosPrincipales.UseSelectable = True
        '
        'lbMusculosSecundarios
        '
        Me.lbMusculosSecundarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbMusculosSecundarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lbMusculosSecundarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbMusculosSecundarios.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbMusculosSecundarios.FormattingEnabled = True
        Me.lbMusculosSecundarios.ItemHeight = 30
        Me.lbMusculosSecundarios.Location = New System.Drawing.Point(106, 300)
        Me.lbMusculosSecundarios.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lbMusculosSecundarios.Name = "lbMusculosSecundarios"
        Me.lbMusculosSecundarios.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbMusculosSecundarios.Size = New System.Drawing.Size(250, 240)
        Me.lbMusculosSecundarios.TabIndex = 25
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(106, 46)
        Me.MetroLabel13.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(100, 30)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel13.TabIndex = 28
        Me.MetroLabel13.Text = "Nombre "
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(106, 79)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtNombre.TabIndex = 46
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(106, 117)
        Me.MetroLabel14.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(100, 30)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel14.TabIndex = 47
        Me.MetroLabel14.Text = "Alias"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlias.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAlias.Lines = New String(-1) {}
        Me.txtAlias.Location = New System.Drawing.Point(106, 150)
        Me.txtAlias.MaxLength = 32767
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlias.SelectedText = ""
        Me.txtAlias.Size = New System.Drawing.Size(250, 35)
        Me.txtAlias.TabIndex = 48
        Me.txtAlias.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAlias.UseSelectable = True
        '
        'txtPosInicial
        '
        Me.txtPosInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosInicial.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPosInicial.Lines = New String(-1) {}
        Me.txtPosInicial.Location = New System.Drawing.Point(697, 79)
        Me.txtPosInicial.MaxLength = 32767
        Me.txtPosInicial.Name = "txtPosInicial"
        Me.txtPosInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosInicial.SelectedText = ""
        Me.txtPosInicial.Size = New System.Drawing.Size(250, 35)
        Me.txtPosInicial.TabIndex = 49
        Me.txtPosInicial.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPosInicial.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(697, 46)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(133, 30)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 50
        Me.MetroLabel1.Text = "Posición Inicial"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton3.AutoSize = True
        Me.MetroButton3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton3.Location = New System.Drawing.Point(907, 150)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(40, 40)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroButton3.TabIndex = 58
        Me.MetroButton3.Text = "X"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton3.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(697, 117)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(220, 30)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 59
        Me.MetroLabel2.Text = "Fotografía Posición Inicial"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtPosFinal
        '
        Me.txtPosFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosFinal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPosFinal.Lines = New String(-1) {}
        Me.txtPosFinal.Location = New System.Drawing.Point(412, 79)
        Me.txtPosFinal.MaxLength = 32767
        Me.txtPosFinal.Name = "txtPosFinal"
        Me.txtPosFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosFinal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosFinal.SelectedText = ""
        Me.txtPosFinal.Size = New System.Drawing.Size(250, 35)
        Me.txtPosFinal.TabIndex = 60
        Me.txtPosFinal.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPosFinal.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(412, 46)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(133, 30)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 61
        Me.MetroLabel3.Text = "Posición Final"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(412, 117)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(220, 30)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 63
        Me.MetroLabel4.Text = "Fotografía Posición Final"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.Location = New System.Drawing.Point(697, 403)
        Me.MetroLabel15.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel15.TabIndex = 64
        Me.MetroLabel15.Text = "Errores Comunes"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtErroresComunes
        '
        Me.txtErroresComunes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtErroresComunes.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtErroresComunes.Lines = New String(-1) {}
        Me.txtErroresComunes.Location = New System.Drawing.Point(697, 436)
        Me.txtErroresComunes.MaxLength = 32767
        Me.txtErroresComunes.Multiline = True
        Me.txtErroresComunes.Name = "txtErroresComunes"
        Me.txtErroresComunes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtErroresComunes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtErroresComunes.SelectedText = ""
        Me.txtErroresComunes.Size = New System.Drawing.Size(250, 106)
        Me.txtErroresComunes.TabIndex = 65
        Me.txtErroresComunes.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtErroresComunes.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(412, 403)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel7.TabIndex = 66
        Me.MetroLabel7.Text = "Descripción"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(412, 436)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(250, 106)
        Me.txtDescripcion.TabIndex = 67
        Me.txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDescripcion.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(106, 188)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel5.TabIndex = 68
        Me.MetroLabel5.Text = "Músculo Principal"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(106, 263)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(180, 30)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 69
        Me.MetroLabel6.Text = "Músculo Secundarios"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton1.AutoSize = True
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton1.Location = New System.Drawing.Point(622, 150)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(40, 40)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroButton1.TabIndex = 70
        Me.MetroButton1.Text = "X"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(792, 551)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 71
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(110, 551)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 40)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 72
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(103, 20)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(170, 25)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel8.TabIndex = 73
        Me.MetroLabel8.Text = "AGREGAR EJERCICIO"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'FrmRegistrarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtErroresComunes)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtPosFinal)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtPosInicial)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.lbMusculosSecundarios)
        Me.Controls.Add(Me.cbListaMusculosPrincipales)
        Me.Controls.Add(Me.ptbPosicionFinal)
        Me.Controls.Add(Me.ptbPosicionInicial)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "FrmRegistrarEjercicio"
        Me.Size = New System.Drawing.Size(1052, 650)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ptbPosicionInicial As System.Windows.Forms.PictureBox
    Friend WithEvents ofdBuscar2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ptbPosicionFinal As System.Windows.Forms.PictureBox
    Friend WithEvents cbListaMusculosPrincipales As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lbMusculosSecundarios As System.Windows.Forms.ListBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAlias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPosInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPosFinal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtErroresComunes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
