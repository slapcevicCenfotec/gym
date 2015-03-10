<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarUsuario))
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.SPListarTiposIdentificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposIdentificacionDataSet = New UI.eGymDBDataSet1()
        Me.SP_ListarTiposIdentificacionTableAdapter = New UI.eGymDBDataSet1TableAdapters.SP_ListarTiposIdentificacionTableAdapter()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.SPListarGenerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerosDataSet = New UI.eGymDBDataSet2()
        Me.SP_ListarGenerosTableAdapter = New UI.eGymDBDataSet2TableAdapters.SP_ListarGenerosTableAdapter()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.SPListarRolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGymDBDataSet3 = New UI.eGymDBDataSet3()
        Me.pcbFotografia = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SP_ListarRolesTableAdapter = New UI.eGymDBDataSet3TableAdapters.SP_ListarRolesTableAdapter()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnEliminarFotografia = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.SPListarTiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposIdentificacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarGenerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarRolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGymDBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIdentificacion.Location = New System.Drawing.Point(67, 128)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(300, 33)
        Me.txtIdentificacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificacion"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombre.Location = New System.Drawing.Point(67, 256)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 33)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Segundo Nombre"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSegundoNombre.Location = New System.Drawing.Point(67, 320)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(300, 33)
        Me.txtSegundoNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApellido.Location = New System.Drawing.Point(67, 384)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(300, 33)
        Me.txtApellido.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Segundo Apellido"
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSegundoApellido.Location = New System.Drawing.Point(67, 448)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(300, 33)
        Me.txtSegundoApellido.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alias"
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAlias.Location = New System.Drawing.Point(67, 512)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(300, 33)
        Me.txtAlias.TabIndex = 6
        '
        'txtCelular
        '
        Me.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCelular.Location = New System.Drawing.Point(467, 384)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(300, 33)
        Me.txtCelular.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTelefono.Location = New System.Drawing.Point(467, 320)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(300, 33)
        Me.txtTelefono.TabIndex = 10
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(467, 512)
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(300, 33)
        Me.txtRepetirContrasena.TabIndex = 13
        '
        'txtContrasena
        '
        Me.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContrasena.Location = New System.Drawing.Point(467, 448)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.Size = New System.Drawing.Size(300, 33)
        Me.txtContrasena.TabIndex = 12
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(467, 256)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(300, 33)
        Me.txtCorreoElectronico.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Celular"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(462, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Telefono"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(462, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 25)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Repetir contrasena"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(462, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Contrasena"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 25)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Correo electronico"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(462, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 25)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Fecha de nacimiento"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(62, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Tipo de identificacion"
        '
        'cmbTipoIdentificacion
        '
        Me.cmbTipoIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTipoIdentificacion.DataSource = Me.SPListarTiposIdentificacionBindingSource
        Me.cmbTipoIdentificacion.DisplayMember = "NOMBRE"
        Me.cmbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoIdentificacion.FormattingEnabled = True
        Me.cmbTipoIdentificacion.Location = New System.Drawing.Point(67, 192)
        Me.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion"
        Me.cmbTipoIdentificacion.Size = New System.Drawing.Size(300, 33)
        Me.cmbTipoIdentificacion.TabIndex = 1
        Me.cmbTipoIdentificacion.ValueMember = "ID"
        '
        'SPListarTiposIdentificacionBindingSource
        '
        Me.SPListarTiposIdentificacionBindingSource.DataMember = "SP_ListarTiposIdentificacion"
        Me.SPListarTiposIdentificacionBindingSource.DataSource = Me.TiposIdentificacionDataSet
        '
        'TiposIdentificacionDataSet
        '
        Me.TiposIdentificacionDataSet.DataSetName = "eGymDBDataSet1"
        Me.TiposIdentificacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarTiposIdentificacionTableAdapter
        '
        Me.SP_ListarTiposIdentificacionTableAdapter.ClearBeforeFill = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(462, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 25)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Genero"
        '
        'cmbGenero
        '
        Me.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbGenero.DataSource = Me.SPListarGenerosBindingSource
        Me.cmbGenero.DisplayMember = "NOMBRE"
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(467, 128)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(300, 33)
        Me.cmbGenero.TabIndex = 7
        Me.cmbGenero.ValueMember = "ID"
        '
        'SPListarGenerosBindingSource
        '
        Me.SPListarGenerosBindingSource.DataMember = "SP_ListarGeneros"
        Me.SPListarGenerosBindingSource.DataSource = Me.GenerosDataSet
        '
        'GenerosDataSet
        '
        Me.GenerosDataSet.DataSetName = "eGymDBDataSet2"
        Me.GenerosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListarGenerosTableAdapter
        '
        Me.SP_ListarGenerosTableAdapter.ClearBeforeFill = True
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(862, 484)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 25)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Rol"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbRol
        '
        Me.cmbRol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbRol.DataSource = Me.SPListarRolesBindingSource
        Me.cmbRol.DisplayMember = "NOMBRE"
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(867, 512)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(300, 33)
        Me.cmbRol.TabIndex = 14
        Me.cmbRol.ValueMember = "ID"
        '
        'SPListarRolesBindingSource
        '
        Me.SPListarRolesBindingSource.DataMember = "SP_ListarRoles"
        Me.SPListarRolesBindingSource.DataSource = Me.EGymDBDataSet3
        '
        'EGymDBDataSet3
        '
        Me.EGymDBDataSet3.DataSetName = "eGymDBDataSet3"
        Me.EGymDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pcbFotografia
        '
        Me.pcbFotografia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pcbFotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbFotografia.Location = New System.Drawing.Point(867, 128)
        Me.pcbFotografia.Name = "pcbFotografia"
        Me.pcbFotografia.Size = New System.Drawing.Size(300, 353)
        Me.pcbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbFotografia.TabIndex = 42
        Me.pcbFotografia.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SP_ListarRolesTableAdapter
        '
        Me.SP_ListarRolesTableAdapter.ClearBeforeFill = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(467, 192)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(300, 33)
        Me.dtpFechaNacimiento.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.Location = New System.Drawing.Point(867, 576)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(300, 35)
        Me.btnAgregar.TabIndex = 43
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(862, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 25)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Fotografia"
        '
        'btnEliminarFotografia
        '
        Me.btnEliminarFotografia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarFotografia.AutoSize = True
        Me.btnEliminarFotografia.Location = New System.Drawing.Point(1134, 126)
        Me.btnEliminarFotografia.Name = "btnEliminarFotografia"
        Me.btnEliminarFotografia.Size = New System.Drawing.Size(33, 35)
        Me.btnEliminarFotografia.TabIndex = 45
        Me.btnEliminarFotografia.Text = "X"
        Me.btnEliminarFotografia.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 60)
        Me.Panel1.TabIndex = 46
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 25)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Agregar Usuario"
        '
        'FrmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEliminarFotografia)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.pcbFotografia)
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbTipoIdentificacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtRepetirContrasena)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmAgregarUsuario"
        Me.Size = New System.Drawing.Size(1229, 814)
        CType(Me.SPListarTiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposIdentificacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarGenerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarRolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGymDBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtRepetirContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoIdentificacion As System.Windows.Forms.ComboBox
    Friend WithEvents SPListarTiposIdentificacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposIdentificacionDataSet As UI.eGymDBDataSet1
    Friend WithEvents SP_ListarTiposIdentificacionTableAdapter As UI.eGymDBDataSet1TableAdapters.SP_ListarTiposIdentificacionTableAdapter
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents SPListarGenerosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenerosDataSet As UI.eGymDBDataSet2
    Friend WithEvents SP_ListarGenerosTableAdapter As UI.eGymDBDataSet2TableAdapters.SP_ListarGenerosTableAdapter
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents pcbFotografia As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SPListarRolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EGymDBDataSet3 As UI.eGymDBDataSet3
    Friend WithEvents SP_ListarRolesTableAdapter As UI.eGymDBDataSet3TableAdapters.SP_ListarRolesTableAdapter
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnEliminarFotografia As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
