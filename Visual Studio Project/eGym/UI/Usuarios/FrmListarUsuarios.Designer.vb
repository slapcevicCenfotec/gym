<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarUsuarios
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
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.tblUsuarios = New System.Windows.Forms.DataGridView()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AliasUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.Location = New System.Drawing.Point(9, 18)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(100, 32)
        Me.lblUsuarios.TabIndex = 0
        Me.lblUsuarios.Text = "Usuarios"
        '
        'tblUsuarios
        '
        Me.tblUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.AliasUsuario, Me.FechaIngreso})
        Me.tblUsuarios.Location = New System.Drawing.Point(15, 65)
        Me.tblUsuarios.Margin = New System.Windows.Forms.Padding(15)
        Me.tblUsuarios.MultiSelect = False
        Me.tblUsuarios.Name = "tblUsuarios"
        Me.tblUsuarios.RowHeadersVisible = False
        Me.tblUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblUsuarios.Size = New System.Drawing.Size(503, 365)
        Me.tblUsuarios.TabIndex = 1
        '
        'Identificacion
        '
        Me.Identificacion.HeaderText = "Identificacion"
        Me.Identificacion.Name = "Identificacion"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'AliasUsuario
        '
        Me.AliasUsuario.HeaderText = "Alias"
        Me.AliasUsuario.Name = "AliasUsuario"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.HeaderText = "Fecha de ingreso"
        Me.FechaIngreso.Name = "FechaIngreso"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.Location = New System.Drawing.Point(418, 15)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(15, 15, 15, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 35)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FrmListarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tblUsuarios)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmListarUsuarios"
        Me.Size = New System.Drawing.Size(533, 445)
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    Friend WithEvents tblUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Identificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AliasUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button

End Class
