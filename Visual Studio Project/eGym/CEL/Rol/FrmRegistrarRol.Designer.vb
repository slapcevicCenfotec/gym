<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarRol
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarRol))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.pnlPermisos = New MetroFramework.Controls.MetroPanel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 16)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 67)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Descripcion"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombre
        '
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(136, 16)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(300, 33)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 62)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 33)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDescripcion.UseSelectable = True
        '
        'pnlPermisos
        '
        Me.pnlPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPermisos.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlPermisos.HorizontalScrollbarBarColor = True
        Me.pnlPermisos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlPermisos.HorizontalScrollbarSize = 10
        Me.pnlPermisos.Location = New System.Drawing.Point(16, 149)
        Me.pnlPermisos.Margin = New System.Windows.Forms.Padding(0, 16, 16, 0)
        Me.pnlPermisos.Name = "pnlPermisos"
        Me.pnlPermisos.Size = New System.Drawing.Size(913, 456)
        Me.pnlPermisos.TabIndex = 4
        Me.pnlPermisos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlPermisos.VerticalScrollbarBarColor = True
        Me.pnlPermisos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlPermisos.VerticalScrollbarSize = 10
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 108)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(16, 16, 16, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(80, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "Permisos"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(664, 620)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 30)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(804, 620)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 30)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'FrmRegistrarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.pnlPermisos)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FrmRegistrarRol"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlPermisos As MetroFramework.Controls.MetroPanel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton

End Class
