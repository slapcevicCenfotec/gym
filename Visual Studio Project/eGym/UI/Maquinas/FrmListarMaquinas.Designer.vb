<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarMaquinas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarMaquinas))
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregarMaquina = New MetroFramework.Controls.MetroButton()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.tblMaquinas = New MetroFramework.Controls.MetroGrid()
        Me.btnTiposDeMaquina = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.tblMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(406, 45)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(113, 23)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseSelectable = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(521, 45)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseSelectable = True
        '
        'btnAgregarMaquina
        '
        Me.btnAgregarMaquina.Location = New System.Drawing.Point(291, 45)
        Me.btnAgregarMaquina.Name = "btnAgregarMaquina"
        Me.btnAgregarMaquina.Size = New System.Drawing.Size(113, 23)
        Me.btnAgregarMaquina.TabIndex = 8
        Me.btnAgregarMaquina.Text = "Agregar"
        Me.btnAgregarMaquina.UseSelectable = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(61, 45)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.txtBuscar.TabIndex = 7
        Me.txtBuscar.UseSelectable = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(12, 50)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 6
        Me.lblBuscar.Text = "Buscar:"
        '
        'tblMaquinas
        '
        Me.tblMaquinas.AllowUserToResizeRows = False
        Me.tblMaquinas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblMaquinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblMaquinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMaquinas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblMaquinas.DefaultCellStyle = DataGridViewCellStyle2
        Me.tblMaquinas.EnableHeadersVisualStyles = False
        Me.tblMaquinas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblMaquinas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblMaquinas.Location = New System.Drawing.Point(15, 99)
        Me.tblMaquinas.Name = "tblMaquinas"
        Me.tblMaquinas.ReadOnly = True
        Me.tblMaquinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblMaquinas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblMaquinas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tblMaquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblMaquinas.Size = New System.Drawing.Size(619, 252)
        Me.tblMaquinas.TabIndex = 11
        '
        'btnTiposDeMaquina
        '
        Me.btnTiposDeMaquina.Location = New System.Drawing.Point(176, 45)
        Me.btnTiposDeMaquina.Name = "btnTiposDeMaquina"
        Me.btnTiposDeMaquina.Size = New System.Drawing.Size(113, 23)
        Me.btnTiposDeMaquina.TabIndex = 12
        Me.btnTiposDeMaquina.Text = "Tipos de máquina"
        Me.btnTiposDeMaquina.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'FrmListarMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTiposDeMaquina)
        Me.Controls.Add(Me.tblMaquinas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregarMaquina)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Name = "FrmListarMaquinas"
        Me.Size = New System.Drawing.Size(650, 400)
        CType(Me.tblMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregarMaquina As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents tblMaquinas As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnTiposDeMaquina As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
