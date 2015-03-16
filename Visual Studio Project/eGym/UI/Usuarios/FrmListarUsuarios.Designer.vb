<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblUsuarios = New MetroFramework.Controls.MetroGrid()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AliasUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltro = New MetroFramework.Controls.MetroTextBox()
        Me.btnCambiarEstado = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblUsuarios
        '
        Me.tblUsuarios.AllowUserToAddRows = False
        Me.tblUsuarios.AllowUserToDeleteRows = False
        Me.tblUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tblUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.AliasUsuario, Me.FechaIngreso, Me.Habilitado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblUsuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblUsuarios.EnableHeadersVisualStyles = False
        Me.tblUsuarios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblUsuarios.Location = New System.Drawing.Point(16, 62)
        Me.tblUsuarios.Margin = New System.Windows.Forms.Padding(16)
        Me.tblUsuarios.MultiSelect = False
        Me.tblUsuarios.Name = "tblUsuarios"
        Me.tblUsuarios.ReadOnly = True
        Me.tblUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblUsuarios.RowHeadersVisible = False
        Me.tblUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tblUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblUsuarios.Size = New System.Drawing.Size(928, 617)
        Me.tblUsuarios.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblUsuarios.TabIndex = 13
        Me.tblUsuarios.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Identificacion
        '
        Me.Identificacion.HeaderText = "IDENTIFICACION"
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'AliasUsuario
        '
        Me.AliasUsuario.HeaderText = "ALIAS"
        Me.AliasUsuario.Name = "AliasUsuario"
        Me.AliasUsuario.ReadOnly = True
        '
        'FechaIngreso
        '
        Me.FechaIngreso.HeaderText = "INGRESO"
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.HeaderText = "ESTADO"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFiltro.Lines = New String(-1) {}
        Me.txtFiltro.Location = New System.Drawing.Point(93, 16)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtFiltro.MaxLength = 32767
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFiltro.SelectedText = ""
        Me.txtFiltro.Size = New System.Drawing.Size(431, 30)
        Me.txtFiltro.TabIndex = 14
        Me.txtFiltro.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFiltro.UseSelectable = True
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarEstado.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCambiarEstado.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCambiarEstado.Location = New System.Drawing.Point(819, 16)
        Me.btnCambiarEstado.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(125, 30)
        Me.btnCambiarEstado.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCambiarEstado.TabIndex = 15
        Me.btnCambiarEstado.Text = "Cambiar estado"
        Me.btnCambiarEstado.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCambiarEstado.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(679, 16)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(125, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAgregar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAgregar.Location = New System.Drawing.Point(539, 16)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 30)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 16)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 30)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "Buscar"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'FrmListarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.tblUsuarios)
        Me.Name = "FrmListarUsuarios"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblUsuarios As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtFiltro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCambiarEstado As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Identificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AliasUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
