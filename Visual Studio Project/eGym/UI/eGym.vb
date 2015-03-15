﻿Public Class eGym
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
        'lblUsuario.Text = usuarioSesion.Nombre + " " + usuarioSesion.Apellido + " - ROL"
        For Each lbl As Label In menuPanel.Controls.OfType(Of Label)()
            AddHandler lbl.Click, Function(senderObj, args) Seleccionar(lbl)
            AddHandler lbl.MouseEnter, Function(senderObj, args) Marcar(lbl)
            AddHandler lbl.MouseLeave, Function(senderObj, args) Desmarcar(lbl)

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
        Me.Hide()
        usuarioSesion = Nothing
        frmIniciarSesion.Show()

    End Sub

    Private Sub pcbUsuario_Click(sender As Object, e As EventArgs) Handles pcbUsuario.Click
        pnlInformacionUsuario.Visible = Not pnlInformacionUsuario.Visible
    End Sub

    Private Sub MetroLabel6_Click(sender As Object, e As EventArgs) Handles MetroLabel6.Click
        Dim listaGimnasio As List(Of EL.Gimnasio)
        listaGimnasio = objGestorGimnasio.listarGimnasios()
        If listaGimnasio Is Nothing Then
            If MsgBox("No se han ingresado los datos del gimnasio. Desea agregarlos?", vbYesNo, "Datos del gimnasio") = MsgBoxResult.Yes Then
                Dim ctr As Control
                ctr = New FrmGimnasio("Insertar", 0)
                ctr.Dock = DockStyle.Fill
                MetroPanel1.Controls.Clear()
                MetroPanel1.Controls.Add(ctr)
            End If
        Else
            Dim ctr As Control
            ctr = New FrmGimnasio("Modificar", listaGimnasio(0).Id)
            ctr.Dock = DockStyle.Fill
            MetroPanel1.Controls.Clear()
            MetroPanel1.Controls.Add(ctr)
        End If
    End Sub
End Class