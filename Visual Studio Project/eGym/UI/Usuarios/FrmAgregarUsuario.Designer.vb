<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarUsuario))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabUsuario = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnEliminarFotografia = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaNacimiento = New MetroFramework.Controls.MetroDateTime()
        Me.cmbRol = New MetroFramework.Controls.MetroComboBox()
        Me.SPListarRolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGymDBDataSet = New UI.eGymDBDataSet()
        Me.cmbGenero = New MetroFramework.Controls.MetroComboBox()
        Me.SPListarGenerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoIdentificacion = New MetroFramework.Controls.MetroComboBox()
        Me.SPListarTiposIdentificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pcbFotografia = New System.Windows.Forms.PictureBox()
        Me.txtRepetirContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.txtCelular = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.txtCorreoElectronico = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlias = New MetroFramework.Controls.MetroTextBox()
        Me.txtSegundoApellido = New MetroFramework.Controls.MetroTextBox()
        Me.txtApellido = New MetroFramework.Controls.MetroTextBox()
        Me.txtSegundoNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdentificacion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.txtParentescoContacto2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefonoContacto2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombreContacto2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.txtParentescoContacto1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtTelefonoContacto1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreContacto1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.txtDomingoSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtDomingoEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtSabadoSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtSabadoEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtViernesSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtViernesEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtJuevesSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtJuevesEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtMiercolesSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtMiercolesEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtMartesSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtMartesEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtLunesSalida = New System.Windows.Forms.MaskedTextBox()
        Me.txtLunesEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SP_ListarTiposIdentificacionTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarTiposIdentificacionTableAdapter()
        Me.SP_ListarGenerosTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarGenerosTableAdapter()
        Me.SP_ListarRolesTableAdapter = New UI.eGymDBDataSetTableAdapters.SP_ListarRolesTableAdapter()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabUsuario.SuspendLayout()
        CType(Me.SPListarRolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGymDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarGenerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarTiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.tabUsuario)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1055, 526)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabUsuario
        '
        Me.tabUsuario.Controls.Add(Me.MetroLabel13)
        Me.tabUsuario.Controls.Add(Me.MetroLabel14)
        Me.tabUsuario.Controls.Add(Me.MetroLabel15)
        Me.tabUsuario.Controls.Add(Me.MetroLabel35)
        Me.tabUsuario.Controls.Add(Me.MetroLabel7)
        Me.tabUsuario.Controls.Add(Me.MetroLabel8)
        Me.tabUsuario.Controls.Add(Me.MetroLabel9)
        Me.tabUsuario.Controls.Add(Me.MetroLabel10)
        Me.tabUsuario.Controls.Add(Me.MetroLabel11)
        Me.tabUsuario.Controls.Add(Me.MetroLabel12)
        Me.tabUsuario.Controls.Add(Me.MetroLabel5)
        Me.tabUsuario.Controls.Add(Me.MetroLabel6)
        Me.tabUsuario.Controls.Add(Me.MetroLabel3)
        Me.tabUsuario.Controls.Add(Me.MetroLabel4)
        Me.tabUsuario.Controls.Add(Me.MetroLabel2)
        Me.tabUsuario.Controls.Add(Me.MetroLabel1)
        Me.tabUsuario.Controls.Add(Me.btnEliminarFotografia)
        Me.tabUsuario.Controls.Add(Me.dtpFechaNacimiento)
        Me.tabUsuario.Controls.Add(Me.cmbRol)
        Me.tabUsuario.Controls.Add(Me.cmbGenero)
        Me.tabUsuario.Controls.Add(Me.cmbTipoIdentificacion)
        Me.tabUsuario.Controls.Add(Me.pcbFotografia)
        Me.tabUsuario.Controls.Add(Me.txtRepetirContrasena)
        Me.tabUsuario.Controls.Add(Me.txtContrasena)
        Me.tabUsuario.Controls.Add(Me.txtCelular)
        Me.tabUsuario.Controls.Add(Me.txtTelefono)
        Me.tabUsuario.Controls.Add(Me.txtCorreoElectronico)
        Me.tabUsuario.Controls.Add(Me.txtAlias)
        Me.tabUsuario.Controls.Add(Me.txtSegundoApellido)
        Me.tabUsuario.Controls.Add(Me.txtApellido)
        Me.tabUsuario.Controls.Add(Me.txtSegundoNombre)
        Me.tabUsuario.Controls.Add(Me.txtNombre)
        Me.tabUsuario.Controls.Add(Me.txtIdentificacion)
        Me.tabUsuario.HorizontalScrollbarBarColor = True
        Me.tabUsuario.HorizontalScrollbarHighlightOnWheel = False
        Me.tabUsuario.HorizontalScrollbarSize = 3
        Me.tabUsuario.Location = New System.Drawing.Point(4, 47)
        Me.tabUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.tabUsuario.Name = "tabUsuario"
        Me.tabUsuario.Size = New System.Drawing.Size(1047, 475)
        Me.tabUsuario.Style = MetroFramework.MetroColorStyle.Purple
        Me.tabUsuario.TabIndex = 0
        Me.tabUsuario.Text = "   Usuario   "
        Me.tabUsuario.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tabUsuario.VerticalScrollbarBarColor = True
        Me.tabUsuario.VerticalScrollbarHighlightOnWheel = False
        Me.tabUsuario.VerticalScrollbarSize = 4
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(746, 357)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(153, 25)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel13.TabIndex = 48
        Me.MetroLabel13.Text = "Repetir contrasena"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(749, 291)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel14.TabIndex = 47
        Me.MetroLabel14.Text = "Contrasena"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.Location = New System.Drawing.Point(745, 225)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(36, 25)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel15.TabIndex = 46
        Me.MetroLabel15.Text = "Rol"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel35.Location = New System.Drawing.Point(748, 27)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel35.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel35.TabIndex = 43
        Me.MetroLabel35.Text = "Fotografia"
        Me.MetroLabel35.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(396, 357)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel7.TabIndex = 42
        Me.MetroLabel7.Text = "Celular"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(399, 291)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel8.TabIndex = 41
        Me.MetroLabel8.Text = "Telefono"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(395, 225)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(152, 25)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel9.TabIndex = 40
        Me.MetroLabel9.Text = "Correo electronico"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(398, 159)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel10.TabIndex = 39
        Me.MetroLabel10.Text = "Fecha nacimiento"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(395, 93)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(68, 25)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel11.TabIndex = 38
        Me.MetroLabel11.Text = "Genero"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(398, 27)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(47, 25)
        Me.MetroLabel12.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel12.TabIndex = 37
        Me.MetroLabel12.Text = "Alias"
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(46, 357)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel5.TabIndex = 36
        Me.MetroLabel5.Text = "Segundo apellido"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(49, 291)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(74, 25)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 35
        Me.MetroLabel6.Text = "Apellido"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(45, 225)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 34
        Me.MetroLabel3.Text = "Segundo nombre"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(48, 159)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 33
        Me.MetroLabel4.Text = "Nombre"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(45, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(174, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 32
        Me.MetroLabel2.Text = "Tipo de identificacion"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(48, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 31
        Me.MetroLabel1.Text = "Identificacion"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnEliminarFotografia
        '
        Me.btnEliminarFotografia.AutoSize = True
        Me.btnEliminarFotografia.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminarFotografia.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminarFotografia.Location = New System.Drawing.Point(963, 55)
        Me.btnEliminarFotografia.Margin = New System.Windows.Forms.Padding(16)
        Me.btnEliminarFotografia.Name = "btnEliminarFotografia"
        Me.btnEliminarFotografia.Size = New System.Drawing.Size(35, 35)
        Me.btnEliminarFotografia.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminarFotografia.TabIndex = 13
        Me.btnEliminarFotografia.Text = "X"
        Me.btnEliminarFotografia.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminarFotografia.UseSelectable = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.FontSize = MetroFramework.MetroDateTimeSize.Tall
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(398, 187)
        Me.dtpFechaNacimiento.MinimumSize = New System.Drawing.Size(0, 35)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(250, 35)
        Me.dtpFechaNacimiento.Style = MetroFramework.MetroColorStyle.Purple
        Me.dtpFechaNacimiento.TabIndex = 9
        Me.dtpFechaNacimiento.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cmbRol
        '
        Me.cmbRol.DataSource = Me.SPListarRolesBindingSource
        Me.cmbRol.DisplayMember = "NOMBRE"
        Me.cmbRol.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.ItemHeight = 29
        Me.cmbRol.Location = New System.Drawing.Point(748, 253)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(250, 35)
        Me.cmbRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbRol.TabIndex = 14
        Me.cmbRol.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbRol.UseSelectable = True
        Me.cmbRol.ValueMember = "ID"
        '
        'SPListarRolesBindingSource
        '
        Me.SPListarRolesBindingSource.DataMember = "SP_ListarRoles"
        Me.SPListarRolesBindingSource.DataSource = Me.EGymDBDataSet
        '
        'EGymDBDataSet
        '
        Me.EGymDBDataSet.DataSetName = "eGymDBDataSet"
        Me.EGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbGenero
        '
        Me.cmbGenero.DataSource = Me.SPListarGenerosBindingSource
        Me.cmbGenero.DisplayMember = "NOMBRE"
        Me.cmbGenero.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.ItemHeight = 29
        Me.cmbGenero.Location = New System.Drawing.Point(398, 121)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(250, 35)
        Me.cmbGenero.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbGenero.TabIndex = 8
        Me.cmbGenero.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbGenero.UseSelectable = True
        Me.cmbGenero.ValueMember = "ID"
        '
        'SPListarGenerosBindingSource
        '
        Me.SPListarGenerosBindingSource.DataMember = "SP_ListarGeneros"
        Me.SPListarGenerosBindingSource.DataSource = Me.EGymDBDataSet
        '
        'cmbTipoIdentificacion
        '
        Me.cmbTipoIdentificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbTipoIdentificacion.DataSource = Me.SPListarTiposIdentificacionBindingSource
        Me.cmbTipoIdentificacion.DisplayMember = "NOMBRE"
        Me.cmbTipoIdentificacion.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cmbTipoIdentificacion.FormattingEnabled = True
        Me.cmbTipoIdentificacion.ItemHeight = 29
        Me.cmbTipoIdentificacion.Location = New System.Drawing.Point(48, 121)
        Me.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion"
        Me.cmbTipoIdentificacion.Size = New System.Drawing.Size(250, 35)
        Me.cmbTipoIdentificacion.Style = MetroFramework.MetroColorStyle.Purple
        Me.cmbTipoIdentificacion.TabIndex = 2
        Me.cmbTipoIdentificacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmbTipoIdentificacion.UseCustomBackColor = True
        Me.cmbTipoIdentificacion.UseSelectable = True
        Me.cmbTipoIdentificacion.ValueMember = "ID"
        '
        'SPListarTiposIdentificacionBindingSource
        '
        Me.SPListarTiposIdentificacionBindingSource.DataMember = "SP_ListarTiposIdentificacion"
        Me.SPListarTiposIdentificacionBindingSource.DataSource = Me.EGymDBDataSet
        '
        'pcbFotografia
        '
        Me.pcbFotografia.BackColor = System.Drawing.Color.Transparent
        Me.pcbFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbFotografia.Location = New System.Drawing.Point(748, 55)
        Me.pcbFotografia.Name = "pcbFotografia"
        Me.pcbFotografia.Size = New System.Drawing.Size(250, 167)
        Me.pcbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbFotografia.TabIndex = 30
        Me.pcbFotografia.TabStop = False
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtRepetirContrasena.Lines = New String(-1) {}
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(748, 385)
        Me.txtRepetirContrasena.MaxLength = 32767
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepetirContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRepetirContrasena.SelectedText = ""
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(250, 35)
        Me.txtRepetirContrasena.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtRepetirContrasena.TabIndex = 16
        Me.txtRepetirContrasena.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtRepetirContrasena.UseSelectable = True
        '
        'txtContrasena
        '
        Me.txtContrasena.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtContrasena.Lines = New String(-1) {}
        Me.txtContrasena.Location = New System.Drawing.Point(748, 319)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.Size = New System.Drawing.Size(250, 35)
        Me.txtContrasena.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtContrasena.TabIndex = 15
        Me.txtContrasena.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtContrasena.UseSelectable = True
        '
        'txtCelular
        '
        Me.txtCelular.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCelular.Lines = New String(-1) {}
        Me.txtCelular.Location = New System.Drawing.Point(401, 385)
        Me.txtCelular.MaxLength = 32767
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCelular.SelectedText = ""
        Me.txtCelular.Size = New System.Drawing.Size(250, 35)
        Me.txtCelular.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtCelular.TabIndex = 12
        Me.txtCelular.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCelular.UseSelectable = True
        '
        'txtTelefono
        '
        Me.txtTelefono.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(398, 319)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.Size = New System.Drawing.Size(250, 35)
        Me.txtTelefono.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTelefono.TabIndex = 11
        Me.txtTelefono.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTelefono.UseSelectable = True
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCorreoElectronico.Lines = New String(-1) {}
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(398, 253)
        Me.txtCorreoElectronico.MaxLength = 32767
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreoElectronico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCorreoElectronico.SelectedText = ""
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(250, 35)
        Me.txtCorreoElectronico.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtCorreoElectronico.TabIndex = 10
        Me.txtCorreoElectronico.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCorreoElectronico.UseSelectable = True
        '
        'txtAlias
        '
        Me.txtAlias.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAlias.Lines = New String(-1) {}
        Me.txtAlias.Location = New System.Drawing.Point(398, 55)
        Me.txtAlias.MaxLength = 32767
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlias.SelectedText = ""
        Me.txtAlias.Size = New System.Drawing.Size(250, 35)
        Me.txtAlias.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtAlias.TabIndex = 7
        Me.txtAlias.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAlias.UseSelectable = True
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSegundoApellido.Lines = New String(-1) {}
        Me.txtSegundoApellido.Location = New System.Drawing.Point(48, 385)
        Me.txtSegundoApellido.MaxLength = 32767
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSegundoApellido.SelectedText = ""
        Me.txtSegundoApellido.Size = New System.Drawing.Size(250, 35)
        Me.txtSegundoApellido.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtSegundoApellido.TabIndex = 6
        Me.txtSegundoApellido.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtSegundoApellido.UseSelectable = True
        '
        'txtApellido
        '
        Me.txtApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtApellido.Lines = New String(-1) {}
        Me.txtApellido.Location = New System.Drawing.Point(48, 319)
        Me.txtApellido.MaxLength = 32767
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.Size = New System.Drawing.Size(250, 35)
        Me.txtApellido.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtApellido.TabIndex = 5
        Me.txtApellido.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtApellido.UseSelectable = True
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSegundoNombre.Lines = New String(-1) {}
        Me.txtSegundoNombre.Location = New System.Drawing.Point(48, 253)
        Me.txtSegundoNombre.MaxLength = 32767
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSegundoNombre.SelectedText = ""
        Me.txtSegundoNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtSegundoNombre.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtSegundoNombre.TabIndex = 4
        Me.txtSegundoNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtSegundoNombre.UseSelectable = True
        '
        'txtNombre
        '
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(48, 187)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtNombre.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIdentificacion.Lines = New String(-1) {}
        Me.txtIdentificacion.Location = New System.Drawing.Point(49, 55)
        Me.txtIdentificacion.MaxLength = 32767
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdentificacion.SelectedText = ""
        Me.txtIdentificacion.Size = New System.Drawing.Size(250, 35)
        Me.txtIdentificacion.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtIdentificacion.TabIndex = 1
        Me.txtIdentificacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtIdentificacion.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.txtParentescoContacto2)
        Me.MetroTabPage2.Controls.Add(Me.txtTelefonoContacto2)
        Me.MetroTabPage2.Controls.Add(Me.txtNombreContacto2)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel21)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel22)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel23)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel24)
        Me.MetroTabPage2.Controls.Add(Me.txtParentescoContacto1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel20)
        Me.MetroTabPage2.Controls.Add(Me.txtTelefonoContacto1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel19)
        Me.MetroTabPage2.Controls.Add(Me.txtNombreContacto1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel18)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel17)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 3
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 47)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1047, 475)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "   Contactos   "
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 4
        '
        'txtParentescoContacto2
        '
        Me.txtParentescoContacto2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtParentescoContacto2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtParentescoContacto2.Lines = New String(-1) {}
        Me.txtParentescoContacto2.Location = New System.Drawing.Point(557, 288)
        Me.txtParentescoContacto2.MaxLength = 32767
        Me.txtParentescoContacto2.Name = "txtParentescoContacto2"
        Me.txtParentescoContacto2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParentescoContacto2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtParentescoContacto2.SelectedText = ""
        Me.txtParentescoContacto2.Size = New System.Drawing.Size(250, 35)
        Me.txtParentescoContacto2.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtParentescoContacto2.TabIndex = 21
        Me.txtParentescoContacto2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtParentescoContacto2.UseSelectable = True
        '
        'txtTelefonoContacto2
        '
        Me.txtTelefonoContacto2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelefonoContacto2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTelefonoContacto2.Lines = New String(-1) {}
        Me.txtTelefonoContacto2.Location = New System.Drawing.Point(557, 222)
        Me.txtTelefonoContacto2.MaxLength = 32767
        Me.txtTelefonoContacto2.Name = "txtTelefonoContacto2"
        Me.txtTelefonoContacto2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonoContacto2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonoContacto2.SelectedText = ""
        Me.txtTelefonoContacto2.Size = New System.Drawing.Size(250, 35)
        Me.txtTelefonoContacto2.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTelefonoContacto2.TabIndex = 20
        Me.txtTelefonoContacto2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTelefonoContacto2.UseSelectable = True
        '
        'txtNombreContacto2
        '
        Me.txtNombreContacto2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreContacto2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombreContacto2.Lines = New String(-1) {}
        Me.txtNombreContacto2.Location = New System.Drawing.Point(557, 156)
        Me.txtNombreContacto2.MaxLength = 32767
        Me.txtNombreContacto2.Name = "txtNombreContacto2"
        Me.txtNombreContacto2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreContacto2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreContacto2.SelectedText = ""
        Me.txtNombreContacto2.Size = New System.Drawing.Size(250, 35)
        Me.txtNombreContacto2.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombreContacto2.TabIndex = 19
        Me.txtNombreContacto2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombreContacto2.UseSelectable = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel21.Location = New System.Drawing.Point(557, 260)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(94, 25)
        Me.MetroLabel21.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel21.TabIndex = 18
        Me.MetroLabel21.Text = "Parentesco"
        Me.MetroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel22
        '
        Me.MetroLabel22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel22.Location = New System.Drawing.Point(557, 194)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel22.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel22.TabIndex = 17
        Me.MetroLabel22.Text = "Telefono"
        Me.MetroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel23
        '
        Me.MetroLabel23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel23.Location = New System.Drawing.Point(557, 128)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel23.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel23.TabIndex = 16
        Me.MetroLabel23.Text = "Nombre"
        Me.MetroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel24
        '
        Me.MetroLabel24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel24.Location = New System.Drawing.Point(557, 103)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(115, 25)
        Me.MetroLabel24.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel24.TabIndex = 15
        Me.MetroLabel24.Text = "Contacto #2"
        Me.MetroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtParentescoContacto1
        '
        Me.txtParentescoContacto1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtParentescoContacto1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtParentescoContacto1.Lines = New String(-1) {}
        Me.txtParentescoContacto1.Location = New System.Drawing.Point(207, 288)
        Me.txtParentescoContacto1.MaxLength = 32767
        Me.txtParentescoContacto1.Name = "txtParentescoContacto1"
        Me.txtParentescoContacto1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParentescoContacto1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtParentescoContacto1.SelectedText = ""
        Me.txtParentescoContacto1.Size = New System.Drawing.Size(250, 35)
        Me.txtParentescoContacto1.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtParentescoContacto1.TabIndex = 8
        Me.txtParentescoContacto1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtParentescoContacto1.UseSelectable = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel20.Location = New System.Drawing.Point(207, 260)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(94, 25)
        Me.MetroLabel20.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel20.TabIndex = 7
        Me.MetroLabel20.Text = "Parentesco"
        Me.MetroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtTelefonoContacto1
        '
        Me.txtTelefonoContacto1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelefonoContacto1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTelefonoContacto1.Lines = New String(-1) {}
        Me.txtTelefonoContacto1.Location = New System.Drawing.Point(207, 222)
        Me.txtTelefonoContacto1.MaxLength = 32767
        Me.txtTelefonoContacto1.Name = "txtTelefonoContacto1"
        Me.txtTelefonoContacto1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonoContacto1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonoContacto1.SelectedText = ""
        Me.txtTelefonoContacto1.Size = New System.Drawing.Size(250, 35)
        Me.txtTelefonoContacto1.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTelefonoContacto1.TabIndex = 6
        Me.txtTelefonoContacto1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTelefonoContacto1.UseSelectable = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel19.Location = New System.Drawing.Point(207, 194)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel19.TabIndex = 5
        Me.MetroLabel19.Text = "Telefono"
        Me.MetroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombreContacto1
        '
        Me.txtNombreContacto1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreContacto1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombreContacto1.Lines = New String(-1) {}
        Me.txtNombreContacto1.Location = New System.Drawing.Point(207, 156)
        Me.txtNombreContacto1.MaxLength = 32767
        Me.txtNombreContacto1.Name = "txtNombreContacto1"
        Me.txtNombreContacto1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreContacto1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreContacto1.SelectedText = ""
        Me.txtNombreContacto1.Size = New System.Drawing.Size(250, 35)
        Me.txtNombreContacto1.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombreContacto1.TabIndex = 4
        Me.txtNombreContacto1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombreContacto1.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel18.Location = New System.Drawing.Point(207, 128)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel18.TabIndex = 3
        Me.MetroLabel18.Text = "Nombre"
        Me.MetroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel17
        '
        Me.MetroLabel17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.Location = New System.Drawing.Point(207, 103)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(115, 25)
        Me.MetroLabel17.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel17.TabIndex = 2
        Me.MetroLabel17.Text = "Contacto #1"
        Me.MetroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.txtDomingoSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtDomingoEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtSabadoSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtSabadoEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtViernesSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtViernesEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtJuevesSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtJuevesEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtMiercolesSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtMiercolesEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtMartesSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtMartesEntrada)
        Me.MetroTabPage3.Controls.Add(Me.txtLunesSalida)
        Me.MetroTabPage3.Controls.Add(Me.txtLunesEntrada)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel34)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel25)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel26)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel27)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel29)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel30)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel31)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel32)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 3
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 47)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(1047, 475)
        Me.MetroTabPage3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "   Horarios   "
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 4
        '
        'txtDomingoSalida
        '
        Me.txtDomingoSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDomingoSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDomingoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomingoSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomingoSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtDomingoSalida.Location = New System.Drawing.Point(855, 222)
        Me.txtDomingoSalida.Mask = "00:00"
        Me.txtDomingoSalida.Name = "txtDomingoSalida"
        Me.txtDomingoSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtDomingoSalida.TabIndex = 89
        Me.txtDomingoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDomingoSalida.ValidatingType = GetType(Date)
        '
        'txtDomingoEntrada
        '
        Me.txtDomingoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDomingoEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDomingoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomingoEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomingoEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtDomingoEntrada.Location = New System.Drawing.Point(731, 222)
        Me.txtDomingoEntrada.Mask = "00:00"
        Me.txtDomingoEntrada.Name = "txtDomingoEntrada"
        Me.txtDomingoEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtDomingoEntrada.TabIndex = 88
        Me.txtDomingoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDomingoEntrada.ValidatingType = GetType(Date)
        '
        'txtSabadoSalida
        '
        Me.txtSabadoSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSabadoSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSabadoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSabadoSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSabadoSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtSabadoSalida.Location = New System.Drawing.Point(855, 156)
        Me.txtSabadoSalida.Mask = "00:00"
        Me.txtSabadoSalida.Name = "txtSabadoSalida"
        Me.txtSabadoSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtSabadoSalida.TabIndex = 87
        Me.txtSabadoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSabadoSalida.ValidatingType = GetType(Date)
        '
        'txtSabadoEntrada
        '
        Me.txtSabadoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSabadoEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSabadoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSabadoEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSabadoEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtSabadoEntrada.Location = New System.Drawing.Point(731, 156)
        Me.txtSabadoEntrada.Mask = "00:00"
        Me.txtSabadoEntrada.Name = "txtSabadoEntrada"
        Me.txtSabadoEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtSabadoEntrada.TabIndex = 86
        Me.txtSabadoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSabadoEntrada.ValidatingType = GetType(Date)
        '
        'txtViernesSalida
        '
        Me.txtViernesSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtViernesSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtViernesSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtViernesSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViernesSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtViernesSalida.Location = New System.Drawing.Point(505, 222)
        Me.txtViernesSalida.Mask = "00:00"
        Me.txtViernesSalida.Name = "txtViernesSalida"
        Me.txtViernesSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtViernesSalida.TabIndex = 85
        Me.txtViernesSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtViernesSalida.ValidatingType = GetType(Date)
        '
        'txtViernesEntrada
        '
        Me.txtViernesEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtViernesEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtViernesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtViernesEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViernesEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtViernesEntrada.Location = New System.Drawing.Point(381, 222)
        Me.txtViernesEntrada.Mask = "00:00"
        Me.txtViernesEntrada.Name = "txtViernesEntrada"
        Me.txtViernesEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtViernesEntrada.TabIndex = 84
        Me.txtViernesEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtViernesEntrada.ValidatingType = GetType(Date)
        '
        'txtJuevesSalida
        '
        Me.txtJuevesSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtJuevesSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtJuevesSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJuevesSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuevesSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtJuevesSalida.Location = New System.Drawing.Point(505, 156)
        Me.txtJuevesSalida.Mask = "00:00"
        Me.txtJuevesSalida.Name = "txtJuevesSalida"
        Me.txtJuevesSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtJuevesSalida.TabIndex = 83
        Me.txtJuevesSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtJuevesSalida.ValidatingType = GetType(Date)
        '
        'txtJuevesEntrada
        '
        Me.txtJuevesEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtJuevesEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtJuevesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJuevesEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuevesEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtJuevesEntrada.Location = New System.Drawing.Point(381, 156)
        Me.txtJuevesEntrada.Mask = "00:00"
        Me.txtJuevesEntrada.Name = "txtJuevesEntrada"
        Me.txtJuevesEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtJuevesEntrada.TabIndex = 82
        Me.txtJuevesEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtJuevesEntrada.ValidatingType = GetType(Date)
        '
        'txtMiercolesSalida
        '
        Me.txtMiercolesSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiercolesSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMiercolesSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiercolesSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiercolesSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtMiercolesSalida.Location = New System.Drawing.Point(155, 288)
        Me.txtMiercolesSalida.Mask = "00:00"
        Me.txtMiercolesSalida.Name = "txtMiercolesSalida"
        Me.txtMiercolesSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtMiercolesSalida.TabIndex = 81
        Me.txtMiercolesSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMiercolesSalida.ValidatingType = GetType(Date)
        '
        'txtMiercolesEntrada
        '
        Me.txtMiercolesEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiercolesEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMiercolesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiercolesEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiercolesEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtMiercolesEntrada.Location = New System.Drawing.Point(31, 288)
        Me.txtMiercolesEntrada.Mask = "00:00"
        Me.txtMiercolesEntrada.Name = "txtMiercolesEntrada"
        Me.txtMiercolesEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtMiercolesEntrada.TabIndex = 80
        Me.txtMiercolesEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMiercolesEntrada.ValidatingType = GetType(Date)
        '
        'txtMartesSalida
        '
        Me.txtMartesSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMartesSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMartesSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMartesSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMartesSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtMartesSalida.Location = New System.Drawing.Point(155, 222)
        Me.txtMartesSalida.Mask = "00:00"
        Me.txtMartesSalida.Name = "txtMartesSalida"
        Me.txtMartesSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtMartesSalida.TabIndex = 79
        Me.txtMartesSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMartesSalida.ValidatingType = GetType(Date)
        '
        'txtMartesEntrada
        '
        Me.txtMartesEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMartesEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMartesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMartesEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMartesEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtMartesEntrada.Location = New System.Drawing.Point(31, 222)
        Me.txtMartesEntrada.Mask = "00:00"
        Me.txtMartesEntrada.Name = "txtMartesEntrada"
        Me.txtMartesEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtMartesEntrada.TabIndex = 78
        Me.txtMartesEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMartesEntrada.ValidatingType = GetType(Date)
        '
        'txtLunesSalida
        '
        Me.txtLunesSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLunesSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtLunesSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLunesSalida.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunesSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtLunesSalida.Location = New System.Drawing.Point(155, 156)
        Me.txtLunesSalida.Mask = "00:00"
        Me.txtLunesSalida.Name = "txtLunesSalida"
        Me.txtLunesSalida.Size = New System.Drawing.Size(125, 35)
        Me.txtLunesSalida.TabIndex = 77
        Me.txtLunesSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLunesSalida.ValidatingType = GetType(Date)
        '
        'txtLunesEntrada
        '
        Me.txtLunesEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLunesEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtLunesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLunesEntrada.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunesEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtLunesEntrada.Location = New System.Drawing.Point(31, 156)
        Me.txtLunesEntrada.Mask = "00:00"
        Me.txtLunesEntrada.Name = "txtLunesEntrada"
        Me.txtLunesEntrada.Size = New System.Drawing.Size(125, 35)
        Me.txtLunesEntrada.TabIndex = 76
        Me.txtLunesEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLunesEntrada.ValidatingType = GetType(Date)
        '
        'MetroLabel34
        '
        Me.MetroLabel34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel34.Location = New System.Drawing.Point(731, 194)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel34.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel34.TabIndex = 64
        Me.MetroLabel34.Text = "Domingo"
        Me.MetroLabel34.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel25
        '
        Me.MetroLabel25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel25.Location = New System.Drawing.Point(731, 128)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel25.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel25.TabIndex = 63
        Me.MetroLabel25.Text = "Sabado"
        Me.MetroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel26
        '
        Me.MetroLabel26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel26.Location = New System.Drawing.Point(381, 194)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(68, 25)
        Me.MetroLabel26.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel26.TabIndex = 62
        Me.MetroLabel26.Text = "Viernes"
        Me.MetroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel27
        '
        Me.MetroLabel27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel27.Location = New System.Drawing.Point(381, 128)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(61, 25)
        Me.MetroLabel27.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel27.TabIndex = 61
        Me.MetroLabel27.Text = "Jueves"
        Me.MetroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel29
        '
        Me.MetroLabel29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel29.Location = New System.Drawing.Point(31, 260)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(84, 25)
        Me.MetroLabel29.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel29.TabIndex = 59
        Me.MetroLabel29.Text = "Miercoles"
        Me.MetroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel30
        '
        Me.MetroLabel30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel30.Location = New System.Drawing.Point(31, 194)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(64, 25)
        Me.MetroLabel30.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel30.TabIndex = 57
        Me.MetroLabel30.Text = "Martes"
        Me.MetroLabel30.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel31
        '
        Me.MetroLabel31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel31.Location = New System.Drawing.Point(31, 128)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(56, 25)
        Me.MetroLabel31.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel31.TabIndex = 55
        Me.MetroLabel31.Text = "Lunes"
        Me.MetroLabel31.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel32
        '
        Me.MetroLabel32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel32.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel32.Location = New System.Drawing.Point(31, 103)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(137, 25)
        Me.MetroLabel32.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel32.TabIndex = 54
        Me.MetroLabel32.Text = "Entrada/Salida"
        Me.MetroLabel32.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAceptar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAceptar.Location = New System.Drawing.Point(914, 16)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(125, 35)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAceptar.TabIndex = 18
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAceptar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(16, 16)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 35)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 576)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 67)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MetroTabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 526)
        Me.Panel2.TabIndex = 22
        '
        'MetroLabel28
        '
        Me.MetroLabel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroLabel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel28.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel28.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(1055, 50)
        Me.MetroLabel28.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel28.TabIndex = 21
        Me.MetroLabel28.Text = "    AGREGAR USUARIO"
        Me.MetroLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel28.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel28.UseCustomBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'SP_ListarTiposIdentificacionTableAdapter
        '
        Me.SP_ListarTiposIdentificacionTableAdapter.ClearBeforeFill = True
        '
        'SP_ListarGenerosTableAdapter
        '
        Me.SP_ListarGenerosTableAdapter.ClearBeforeFill = True
        '
        'SP_ListarRolesTableAdapter
        '
        Me.SP_ListarRolesTableAdapter.ClearBeforeFill = True
        '
        'FrmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MetroLabel28)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmAgregarUsuario"
        Me.Size = New System.Drawing.Size(1055, 643)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UseCustomBackColor = True
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabUsuario.ResumeLayout(False)
        Me.tabUsuario.PerformLayout()
        CType(Me.SPListarRolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGymDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarGenerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarTiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtParentescoContacto1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelefonoContacto1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreContacto1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtParentescoContacto2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefonoContacto2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombreContacto2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabUsuario As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnEliminarFotografia As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFechaNacimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbRol As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbGenero As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTipoIdentificacion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents pcbFotografia As System.Windows.Forms.PictureBox
    Friend WithEvents txtRepetirContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCelular As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCorreoElectronico As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSegundoApellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSegundoNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdentificacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLunesEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDomingoSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDomingoEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSabadoSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSabadoEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtViernesSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtViernesEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtJuevesSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtJuevesEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMiercolesSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMiercolesEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMartesSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMartesEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLunesSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents SPListarRolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EGymDBDataSet As UI.eGymDBDataSet
    Friend WithEvents SPListarGenerosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SPListarTiposIdentificacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ListarTiposIdentificacionTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarTiposIdentificacionTableAdapter
    Friend WithEvents SP_ListarGenerosTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarGenerosTableAdapter
    Friend WithEvents SP_ListarRolesTableAdapter As UI.eGymDBDataSetTableAdapters.SP_ListarRolesTableAdapter

End Class
