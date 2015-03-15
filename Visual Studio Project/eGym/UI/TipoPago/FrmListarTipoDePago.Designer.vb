<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarTipoDePago
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
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.btnModificarTipoDePago = New MetroFramework.Controls.MetroButton()
        Me.btnAgregarTipoDePago = New MetroFramework.Controls.MetroButton()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.tblListaTipoDePago = New MetroFramework.Controls.MetroGrid()
        Me.btnEliminarTipoDePago = New MetroFramework.Controls.MetroButton()
        CType(Me.tblListaTipoDePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblBuscar.Location = New System.Drawing.Point(16, 16)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(62, 30)
        Me.lblBuscar.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblBuscar.TabIndex = 29
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnModificarTipoDePago
        '
        Me.btnModificarTipoDePago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarTipoDePago.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificarTipoDePago.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificarTipoDePago.Location = New System.Drawing.Point(674, 15)
        Me.btnModificarTipoDePago.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificarTipoDePago.Name = "btnModificarTipoDePago"
        Me.btnModificarTipoDePago.Size = New System.Drawing.Size(130, 30)
        Me.btnModificarTipoDePago.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificarTipoDePago.TabIndex = 28
        Me.btnModificarTipoDePago.Text = "Modificar"
        Me.btnModificarTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificarTipoDePago.UseSelectable = True
        '
        'btnAgregarTipoDePago
        '
        Me.btnAgregarTipoDePago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarTipoDePago.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAgregarTipoDePago.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnAgregarTipoDePago.Location = New System.Drawing.Point(534, 15)
        Me.btnAgregarTipoDePago.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnAgregarTipoDePago.Name = "btnAgregarTipoDePago"
        Me.btnAgregarTipoDePago.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarTipoDePago.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnAgregarTipoDePago.TabIndex = 27
        Me.btnAgregarTipoDePago.Text = "Agregar"
        Me.btnAgregarTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregarTipoDePago.UseSelectable = True
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
        Me.txtBuscar.TabIndex = 26
        Me.txtBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtBuscar.UseSelectable = True
        '
        'tblListaTipoDePago
        '
        Me.tblListaTipoDePago.AllowUserToAddRows = False
        Me.tblListaTipoDePago.AllowUserToDeleteRows = False
        Me.tblListaTipoDePago.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblListaTipoDePago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tblListaTipoDePago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblListaTipoDePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblListaTipoDePago.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblListaTipoDePago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblListaTipoDePago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblListaTipoDePago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblListaTipoDePago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblListaTipoDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblListaTipoDePago.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblListaTipoDePago.EnableHeadersVisualStyles = False
        Me.tblListaTipoDePago.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblListaTipoDePago.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblListaTipoDePago.Location = New System.Drawing.Point(16, 62)
        Me.tblListaTipoDePago.Margin = New System.Windows.Forms.Padding(16)
        Me.tblListaTipoDePago.MultiSelect = False
        Me.tblListaTipoDePago.Name = "tblListaTipoDePago"
        Me.tblListaTipoDePago.ReadOnly = True
        Me.tblListaTipoDePago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblListaTipoDePago.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblListaTipoDePago.RowHeadersVisible = False
        Me.tblListaTipoDePago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblListaTipoDePago.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tblListaTipoDePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblListaTipoDePago.Size = New System.Drawing.Size(928, 617)
        Me.tblListaTipoDePago.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblListaTipoDePago.TabIndex = 25
        Me.tblListaTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnEliminarTipoDePago
        '
        Me.btnEliminarTipoDePago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarTipoDePago.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminarTipoDePago.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminarTipoDePago.Location = New System.Drawing.Point(389, 15)
        Me.btnEliminarTipoDePago.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnEliminarTipoDePago.Name = "btnEliminarTipoDePago"
        Me.btnEliminarTipoDePago.Size = New System.Drawing.Size(130, 30)
        Me.btnEliminarTipoDePago.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminarTipoDePago.TabIndex = 30
        Me.btnEliminarTipoDePago.Text = "Eliminar"
        Me.btnEliminarTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminarTipoDePago.UseSelectable = True
        '
        'FrmListarTipoDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnEliminarTipoDePago)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnModificarTipoDePago)
        Me.Controls.Add(Me.btnAgregarTipoDePago)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.tblListaTipoDePago)
        Me.Name = "FrmListarTipoDePago"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.tblListaTipoDePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnModificarTipoDePago As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregarTipoDePago As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tblListaTipoDePago As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnEliminarTipoDePago As MetroFramework.Controls.MetroButton

End Class
