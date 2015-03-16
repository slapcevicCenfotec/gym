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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRegistarPago = New MetroFramework.Controls.MetroButton()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.btnTipoDePago = New MetroFramework.Controls.MetroButton()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.tblPago = New MetroFramework.Controls.MetroGrid()
        CType(Me.tblPago, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tblPago
        '
        Me.tblPago.AllowUserToAddRows = False
        Me.tblPago.AllowUserToDeleteRows = False
        Me.tblPago.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tblPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tblPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblPago.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblPago.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblPago.EnableHeadersVisualStyles = False
        Me.tblPago.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblPago.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tblPago.Location = New System.Drawing.Point(16, 62)
        Me.tblPago.Margin = New System.Windows.Forms.Padding(16)
        Me.tblPago.MultiSelect = False
        Me.tblPago.Name = "tblPago"
        Me.tblPago.ReadOnly = True
        Me.tblPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblPago.RowHeadersVisible = False
        Me.tblPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tblPago.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tblPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblPago.Size = New System.Drawing.Size(928, 617)
        Me.tblPago.Style = MetroFramework.MetroColorStyle.Silver
        Me.tblPago.TabIndex = 31
        Me.tblPago.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'FrmListarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnRegistarPago)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnTipoDePago)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.tblPago)
        Me.Name = "FrmListarPago"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.tblPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegistarPago As MetroFramework.Controls.MetroButton
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnTipoDePago As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tblPago As MetroFramework.Controls.MetroGrid

End Class
