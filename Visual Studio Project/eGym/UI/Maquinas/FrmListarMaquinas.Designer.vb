<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarMaquinas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tblMaquinas = New MetroFramework.Controls.MetroGrid()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.btnTiposDeMaquina = New MetroFramework.Controls.MetroButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'tblMaquinas
        '
        Me.tblMaquinas.AllowUserToAddRows = False
        Me.tblMaquinas.AllowUserToDeleteRows = False
        Me.tblMaquinas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblMaquinas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tblMaquinas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMaquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblMaquinas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblMaquinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblMaquinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMaquinas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblMaquinas.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblMaquinas.EnableHeadersVisualStyles = False
        Me.tblMaquinas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblMaquinas.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblMaquinas.Location = New System.Drawing.Point(16, 62)
        Me.tblMaquinas.Margin = New System.Windows.Forms.Padding(16)
        Me.tblMaquinas.MultiSelect = False
        Me.tblMaquinas.Name = "tblMaquinas"
        Me.tblMaquinas.ReadOnly = True
        Me.tblMaquinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMaquinas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblMaquinas.RowHeadersVisible = False
        Me.tblMaquinas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblMaquinas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tblMaquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblMaquinas.Size = New System.Drawing.Size(928, 617)
        Me.tblMaquinas.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblMaquinas.TabIndex = 14
        Me.tblMaquinas.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblBuscar
        '
        Me.lblBuscar.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblBuscar.Location = New System.Drawing.Point(16, 16)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(62, 30)
        Me.lblBuscar.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblBuscar.TabIndex = 23
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminar.Location = New System.Drawing.Point(814, 15)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 30)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminar.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(674, 15)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAgregar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAgregar.Location = New System.Drawing.Point(534, 15)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregar.UseSelectable = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(93, 16)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(281, 30)
        Me.txtBuscar.TabIndex = 19
        Me.txtBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtBuscar.UseSelectable = True
        '
        'btnTiposDeMaquina
        '
        Me.btnTiposDeMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTiposDeMaquina.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnTiposDeMaquina.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnTiposDeMaquina.Location = New System.Drawing.Point(389, 15)
        Me.btnTiposDeMaquina.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnTiposDeMaquina.Name = "btnTiposDeMaquina"
        Me.btnTiposDeMaquina.Size = New System.Drawing.Size(130, 30)
        Me.btnTiposDeMaquina.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnTiposDeMaquina.TabIndex = 24
        Me.btnTiposDeMaquina.Text = "Tipos de máquina"
        Me.btnTiposDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnTiposDeMaquina.UseSelectable = True
        '
        'FrmListarMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnTiposDeMaquina)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.tblMaquinas)
        Me.Name = "FrmListarMaquinas"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tblMaquinas As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnTiposDeMaquina As MetroFramework.Controls.MetroButton

End Class
