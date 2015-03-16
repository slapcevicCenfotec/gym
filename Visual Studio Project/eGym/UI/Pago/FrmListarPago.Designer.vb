<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarPago
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRegistarPago = New MetroFramework.Controls.MetroButton()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.btnTipoDePago = New MetroFramework.Controls.MetroButton()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.tblListaTipoDePago = New MetroFramework.Controls.MetroGrid()
        CType(Me.tblListaTipoDePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistarPago
        '
        Me.btnRegistarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistarPago.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnRegistarPago.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnRegistarPago.Location = New System.Drawing.Point(389, 16)
        Me.btnRegistarPago.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnRegistarPago.Name = "btnRegistarPago"
        Me.btnRegistarPago.Size = New System.Drawing.Size(130, 30)
        Me.btnRegistarPago.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnRegistarPago.TabIndex = 36
        Me.btnRegistarPago.Text = "Registrar pago"
        Me.btnRegistarPago.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnRegistarPago.UseSelectable = True
        '
        'lblBuscar
        '
        Me.lblBuscar.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblBuscar.Location = New System.Drawing.Point(16, 17)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(62, 30)
        Me.lblBuscar.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblBuscar.TabIndex = 35
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnTipoDePago
        '
        Me.btnTipoDePago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTipoDePago.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnTipoDePago.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnTipoDePago.Location = New System.Drawing.Point(534, 16)
        Me.btnTipoDePago.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnTipoDePago.Name = "btnTipoDePago"
        Me.btnTipoDePago.Size = New System.Drawing.Size(130, 30)
        Me.btnTipoDePago.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnTipoDePago.TabIndex = 33
        Me.btnTipoDePago.Text = "Tipo de  pagos"
        Me.btnTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnTipoDePago.UseSelectable = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(93, 17)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(281, 30)
        Me.txtBuscar.TabIndex = 32
        Me.txtBuscar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtBuscar.UseSelectable = True
        '
        'tblListaTipoDePago
        '
        Me.tblListaTipoDePago.AllowUserToAddRows = False
        Me.tblListaTipoDePago.AllowUserToDeleteRows = False
        Me.tblListaTipoDePago.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblListaTipoDePago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.tblListaTipoDePago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblListaTipoDePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblListaTipoDePago.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblListaTipoDePago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblListaTipoDePago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblListaTipoDePago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblListaTipoDePago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.tblListaTipoDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblListaTipoDePago.DefaultCellStyle = DataGridViewCellStyle13
        Me.tblListaTipoDePago.EnableHeadersVisualStyles = False
        Me.tblListaTipoDePago.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblListaTipoDePago.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblListaTipoDePago.Location = New System.Drawing.Point(16, 62)
        Me.tblListaTipoDePago.Margin = New System.Windows.Forms.Padding(16)
        Me.tblListaTipoDePago.MultiSelect = False
        Me.tblListaTipoDePago.Name = "tblListaTipoDePago"
        Me.tblListaTipoDePago.ReadOnly = True
        Me.tblListaTipoDePago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblListaTipoDePago.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.tblListaTipoDePago.RowHeadersVisible = False
        Me.tblListaTipoDePago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblListaTipoDePago.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.tblListaTipoDePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblListaTipoDePago.Size = New System.Drawing.Size(928, 617)
        Me.tblListaTipoDePago.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblListaTipoDePago.TabIndex = 31
        Me.tblListaTipoDePago.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'FrmListarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnRegistarPago)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnTipoDePago)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.tblListaTipoDePago)
        Me.Name = "FrmListarPago"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.tblListaTipoDePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegistarPago As MetroFramework.Controls.MetroButton
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnTipoDePago As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tblListaTipoDePago As MetroFramework.Controls.MetroGrid

End Class
