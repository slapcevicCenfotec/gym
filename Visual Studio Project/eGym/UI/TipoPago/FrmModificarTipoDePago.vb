﻿Imports EL
Public Class FrmModificarTipoDePago
    Public actual As TipoDePago
    Public Sub New(ByVal ptipoDePago As TipoDePago)
        actual = ptipoDePago
        InitializeComponent()
    End Sub
    Private Sub FrmAgregarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = actual.Nombre
        txtMonto.Text = actual.Monto
        txtDuracion.Text = actual.Duracion
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        objGestorTipoPago.modificarTipoDePago(actual.Id, txtNombre.Text, txtMonto.Text, txtDuracion.Text, 1)
    End Sub
    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub
    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub
    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs) Handles txtMonto.Click

    End Sub
    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub
    Private Sub MetroTextBox3_Click(sender As Object, e As EventArgs) Handles txtDuracion.Click

    End Sub
    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
