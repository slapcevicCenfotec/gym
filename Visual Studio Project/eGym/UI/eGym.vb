Public Class eGym
    Private usuarioSesion As EL.Usuario
    Private lblSelected As String
    Private showUserInfo As Boolean

    Public Sub New()
        showUserInfo = False
        InitializeComponent()
    End Sub

    Public Sub New(usuario As EL.Usuario)
        usuarioSesion = usuario
        showUserInfo = False
        InitializeComponent()
    End Sub

    Private Sub eGym_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarMenu()
    End Sub


    Private Sub InicializarMenu()
        lblNombreUsuario.Text = usuarioSesion.Nombre + " " + usuarioSesion.Apellido
        Dim clear As Boolean
        For Each lbl As Label In menuPanel.Controls.OfType(Of Label)()
            clear = False
            For Each permiso As EL.Permiso In usuarioSesion.Rol.ListaPermisos
                If lbl.Text.Trim() = permiso.Nombre.Trim() Then
                    clear = True
                    AddHandler lbl.Click, Function(senderObj, args) Seleccionar(lbl)
                    AddHandler lbl.MouseEnter, Function(senderObj, args) Marcar(lbl)
                    AddHandler lbl.MouseLeave, Function(senderObj, args) Desmarcar(lbl)
                End If
            Next
            If clear = False Then
                lbl.Visible = False
            End If
        Next

    End Sub

    Private Function Seleccionar(lbl As Label)
        For Each ctr As Label In menuPanel.Controls.OfType(Of Label)()
            ctr.BackColor = Color.FromArgb(17, 17, 17)
            ctr.ForeColor = Color.White
        Next
        lbl.BackColor = Color.FromArgb(124, 65, 153)
        lbl.ForeColor = Color.White
        lblSelected = lbl.Name
        Return lbl
    End Function

    Private Function Marcar(lbl As Label)
        For Each ctr As Label In menuPanel.Controls.OfType(Of Label)()
            If Not lblSelected Is ctr.Name Then
                ctr.BackColor = Color.FromArgb(17, 17, 17)
                ctr.ForeColor = Color.White
            End If
        Next
        If Not lblSelected Is lbl.Name Then
            lbl.BackColor = Color.FromArgb(34, 34, 34)
            lbl.ForeColor = Color.White
        End If
        Return lbl
    End Function

    Private Function Desmarcar(lbl As Label)
        If Not lblSelected Is lbl.Name Then
            lbl.BackColor = Color.FromArgb(17, 17, 17)
            lbl.ForeColor = Color.White
        End If
        Return lbl
    End Function

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim ctr As Control
        ctr = New FrmListarUsuarios()
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        Dim ctr As Control
        ctr = New FrmListarPago
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub btnMaquinas_Click(sender As Object, e As EventArgs) Handles btnMaquinas.Click
        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click
        Dim ctr As Control
        ctr = New FrmListarRoles
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        Dim ctr As Control
        ctr = New FrmListarMusculo
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click
        Dim ctr As Control
        ctr = New FrmListarEjercicio
        ctr.Dock = DockStyle.Fill
        MetroPanel1.Controls.Clear()
        MetroPanel1.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel5_Click(sender As Object, e As EventArgs) Handles MetroLabel5.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        objGestorSesion.cerrarSesion()
        usuarioSesion = Nothing
        frmIniciarSesion.Show()
        Me.Close()
    End Sub

    Private Sub pcbUsuario_Click(sender As Object, e As EventArgs) Handles pcbUsuario.Click
        pnlInformacionUsuario.Visible = Not pnlInformacionUsuario.Visible
    End Sub

    Private Sub eGym_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        objGestorSesion.cerrarSesion()
        usuarioSesion = Nothing
    End Sub
End Class