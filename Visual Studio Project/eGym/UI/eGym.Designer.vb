<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eGym
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.menuBorder = New MetroFramework.Controls.MetroPanel()
        Me.menuPanel = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnFacturacion = New MetroFramework.Controls.MetroLabel()
        Me.btnUsuarios = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.panel = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.menuBorder.SuspendLayout()
        Me.menuPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBorder
        '
        Me.menuBorder.AutoScroll = True
        Me.menuBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.menuBorder.Controls.Add(Me.menuPanel)
        Me.menuBorder.HorizontalScrollbar = True
        Me.menuBorder.HorizontalScrollbarBarColor = True
        Me.menuBorder.HorizontalScrollbarHighlightOnWheel = False
        Me.menuBorder.HorizontalScrollbarSize = 10
        Me.menuBorder.Location = New System.Drawing.Point(89, 58)
        Me.menuBorder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.menuBorder.Name = "menuBorder"
        Me.menuBorder.Size = New System.Drawing.Size(827, 50)
        Me.menuBorder.Style = MetroFramework.MetroColorStyle.Teal
        Me.menuBorder.TabIndex = 2
        Me.menuBorder.UseCustomBackColor = True
        Me.menuBorder.VerticalScrollbar = True
        Me.menuBorder.VerticalScrollbarBarColor = True
        Me.menuBorder.VerticalScrollbarHighlightOnWheel = False
        Me.menuBorder.VerticalScrollbarSize = 10
        '
        'menuPanel
        '
        Me.menuPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menuPanel.Controls.Add(Me.MetroLabel6)
        Me.menuPanel.Controls.Add(Me.MetroLabel5)
        Me.menuPanel.Controls.Add(Me.MetroLabel4)
        Me.menuPanel.Controls.Add(Me.MetroLabel3)
        Me.menuPanel.Controls.Add(Me.MetroLabel2)
        Me.menuPanel.Controls.Add(Me.MetroLabel1)
        Me.menuPanel.Controls.Add(Me.btnFacturacion)
        Me.menuPanel.Controls.Add(Me.btnUsuarios)
        Me.menuPanel.HorizontalScrollbarBarColor = True
        Me.menuPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.menuPanel.HorizontalScrollbarSize = 10
        Me.menuPanel.Location = New System.Drawing.Point(3, 3)
        Me.menuPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(820, 44)
        Me.menuPanel.TabIndex = 2
        Me.menuPanel.VerticalScrollbarBarColor = True
        Me.menuPanel.VerticalScrollbarHighlightOnWheel = False
        Me.menuPanel.VerticalScrollbarSize = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.BackColor = System.Drawing.Color.White
        Me.MetroLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel6.Location = New System.Drawing.Point(710, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel6.TabIndex = 17
        Me.MetroLabel6.Text = "Configuracion"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.BackColor = System.Drawing.Color.White
        Me.MetroLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel5.Location = New System.Drawing.Point(610, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Reportes"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.BackColor = System.Drawing.Color.White
        Me.MetroLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel4.Location = New System.Drawing.Point(410, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "Ejercicios"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.BackColor = System.Drawing.Color.White
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel3.Location = New System.Drawing.Point(510, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel3.TabIndex = 14
        Me.MetroLabel3.Text = "Roles"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.BackColor = System.Drawing.Color.White
        Me.MetroLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel2.Location = New System.Drawing.Point(310, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Musculos"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.BackColor = System.Drawing.Color.White
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel1.Location = New System.Drawing.Point(210, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 44)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Maquinas"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'btnFacturacion
        '
        Me.btnFacturacion.BackColor = System.Drawing.Color.White
        Me.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFacturacion.Location = New System.Drawing.Point(110, 0)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(100, 44)
        Me.btnFacturacion.TabIndex = 11
        Me.btnFacturacion.Text = "Facturacion"
        Me.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFacturacion.UseCustomBackColor = True
        Me.btnFacturacion.UseCustomForeColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.White
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUsuarios.Location = New System.Drawing.Point(10, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(100, 44)
        Me.btnUsuarios.TabIndex = 10
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUsuarios.UseCustomBackColor = True
        Me.btnUsuarios.UseCustomForeColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(33, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(1017, 58)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(150, 50)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "Cerrar Sesion"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(929, 35)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(238, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "[Nombre de usuario] - [Rol de usuario]"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.panel.Controls.Add(Me.MetroPanel1)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.HorizontalScrollbarBarColor = True
        Me.panel.HorizontalScrollbarHighlightOnWheel = False
        Me.panel.HorizontalScrollbarSize = 10
        Me.panel.Location = New System.Drawing.Point(33, 115)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1134, 627)
        Me.panel.TabIndex = 9
        Me.panel.UseCustomBackColor = True
        Me.panel.VerticalScrollbarBarColor = True
        Me.panel.VerticalScrollbarHighlightOnWheel = False
        Me.panel.VerticalScrollbarSize = 10
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(1, 1)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1132, 625)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(531, 783)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel9.TabIndex = 10
        Me.MetroLabel9.Text = "eGym - Cantaros 2015"
        '
        'eGym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 780)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.menuBorder)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "eGym"
        Me.Padding = New System.Windows.Forms.Padding(33, 115, 33, 38)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = " [Gimnasio]"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuBorder.ResumeLayout(False)
        Me.menuPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuBorder As MetroFramework.Controls.MetroPanel
    Friend WithEvents menuPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnUsuarios As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnFacturacion As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panel As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
End Class
