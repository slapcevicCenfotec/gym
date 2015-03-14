<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarEjercicio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroUserControl1 = New MetroFramework.Controls.MetroUserControl()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtFiltro = New MetroFramework.Controls.MetroTextBox()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.tblEjercicio = New MetroFramework.Controls.MetroGrid()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErroresComunes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tblEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroUserControl1
        '
        Me.MetroUserControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroUserControl1.Name = "MetroUserControl1"
        Me.MetroUserControl1.Size = New System.Drawing.Size(960, 718)
        Me.MetroUserControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroUserControl1.TabIndex = 3
        Me.MetroUserControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroUserControl1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 34)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 30)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 19
        Me.MetroLabel1.Text = "Buscar"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFiltro.Lines = New String(-1) {}
        Me.txtFiltro.Location = New System.Drawing.Point(88, 34)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtFiltro.MaxLength = 32767
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFiltro.SelectedText = ""
        Me.txtFiltro.Size = New System.Drawing.Size(431, 30)
        Me.txtFiltro.TabIndex = 20
        Me.txtFiltro.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFiltro.UseSelectable = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminar.Location = New System.Drawing.Point(534, 34)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(125, 30)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminar.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(666, 34)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(125, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 22
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAgregar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAgregar.Location = New System.Drawing.Point(795, 34)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 30)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregar.UseSelectable = True
        '
        'tblEjercicio
        '
        Me.tblEjercicio.AllowUserToAddRows = False
        Me.tblEjercicio.AllowUserToDeleteRows = False
        Me.tblEjercicio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblEjercicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tblEjercicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblEjercicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEjercicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblEjercicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblEjercicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEjercicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEjercicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Alia, Me.PosicionInicial, Me.PosicionFinal, Me.ErroresComunes, Me.Descripcion})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblEjercicio.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblEjercicio.EnableHeadersVisualStyles = False
        Me.tblEjercicio.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblEjercicio.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblEjercicio.Location = New System.Drawing.Point(6, 85)
        Me.tblEjercicio.Margin = New System.Windows.Forms.Padding(16)
        Me.tblEjercicio.MultiSelect = False
        Me.tblEjercicio.Name = "tblEjercicio"
        Me.tblEjercicio.ReadOnly = True
        Me.tblEjercicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEjercicio.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblEjercicio.RowHeadersVisible = False
        Me.tblEjercicio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblEjercicio.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tblEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblEjercicio.Size = New System.Drawing.Size(928, 525)
        Me.tblEjercicio.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblEjercicio.TabIndex = 24
        Me.tblEjercicio.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Alia
        '
        Me.Alia.HeaderText = "Alias"
        Me.Alia.Name = "Alia"
        Me.Alia.ReadOnly = True
        '
        'PosicionInicial
        '
        Me.PosicionInicial.HeaderText = "Posicion Inicial"
        Me.PosicionInicial.Name = "PosicionInicial"
        Me.PosicionInicial.ReadOnly = True
        '
        'PosicionFinal
        '
        Me.PosicionFinal.HeaderText = "Posicion Final"
        Me.PosicionFinal.Name = "PosicionFinal"
        Me.PosicionFinal.ReadOnly = True
        '
        'ErroresComunes
        '
        Me.ErroresComunes.HeaderText = "Errores Comunes"
        Me.ErroresComunes.Name = "ErroresComunes"
        Me.ErroresComunes.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'FrmListarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.tblEjercicio)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroUserControl1)
        Me.Name = "FrmListarEjercicio"
        Me.Size = New System.Drawing.Size(960, 695)
        CType(Me.tblEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroUserControl1 As MetroFramework.Controls.MetroUserControl
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFiltro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents tblEjercicio As MetroFramework.Controls.MetroGrid
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PosicionInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PosicionFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErroresComunes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
