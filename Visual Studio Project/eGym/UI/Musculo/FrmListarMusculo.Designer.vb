<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarMusculo
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtFiltro = New MetroFramework.Controls.MetroTextBox()
        Me.tblMusculos = New MetroFramework.Controls.MetroGrid()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inserccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inervacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Irrigacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        CType(Me.tblMusculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 76)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(62, 30)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 21
        Me.MetroLabel2.Text = "Buscar"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFiltro.Lines = New String(-1) {}
        Me.txtFiltro.Location = New System.Drawing.Point(82, 76)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtFiltro.MaxLength = 32767
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFiltro.SelectedText = ""
        Me.txtFiltro.Size = New System.Drawing.Size(445, 35)
        Me.txtFiltro.TabIndex = 22
        Me.txtFiltro.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFiltro.UseSelectable = True
        '
        'tblMusculos
        '
        Me.tblMusculos.AllowUserToAddRows = False
        Me.tblMusculos.AllowUserToDeleteRows = False
        Me.tblMusculos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblMusculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.tblMusculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMusculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblMusculos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblMusculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblMusculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblMusculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMusculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tblMusculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMusculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Ubicacion, Me.Origen, Me.Inserccion, Me.Inervacion, Me.Irrigacion})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblMusculos.DefaultCellStyle = DataGridViewCellStyle8
        Me.tblMusculos.EnableHeadersVisualStyles = False
        Me.tblMusculos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblMusculos.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblMusculos.Location = New System.Drawing.Point(17, 122)
        Me.tblMusculos.Margin = New System.Windows.Forms.Padding(16)
        Me.tblMusculos.MultiSelect = False
        Me.tblMusculos.Name = "tblMusculos"
        Me.tblMusculos.ReadOnly = True
        Me.tblMusculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMusculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.tblMusculos.RowHeadersVisible = False
        Me.tblMusculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblMusculos.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.tblMusculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblMusculos.Size = New System.Drawing.Size(928, 525)
        Me.tblMusculos.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblMusculos.TabIndex = 23
        Me.tblMusculos.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        '
        'Origen
        '
        Me.Origen.HeaderText = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.ReadOnly = True
        '
        'Inserccion
        '
        Me.Inserccion.HeaderText = "Insercción"
        Me.Inserccion.Name = "Inserccion"
        Me.Inserccion.ReadOnly = True
        '
        'Inervacion
        '
        Me.Inervacion.HeaderText = "Inervación"
        Me.Inervacion.Name = "Inervacion"
        Me.Inervacion.ReadOnly = True
        '
        'Irrigacion
        '
        Me.Irrigacion.HeaderText = "Irrigación"
        Me.Irrigacion.Name = "Irrigacion"
        Me.Irrigacion.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminar.Location = New System.Drawing.Point(542, 76)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(125, 30)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminar.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(679, 76)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(125, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 25
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAgregar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAgregar.Location = New System.Drawing.Point(815, 76)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 30)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregar.UseSelectable = True
        '
        'FrmListarMusculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.tblMusculos)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "FrmListarMusculo"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.tblMusculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFiltro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tblMusculos As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inserccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inervacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Irrigacion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
