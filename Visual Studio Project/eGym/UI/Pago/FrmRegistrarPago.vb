Imports EL
Imports System.Text.RegularExpressions
Public Class FrmRegistrarPago
    Dim montoRegex As Regex = New Regex("[+-]?(?=\d*[.eE])(?=\.?\d)\d*\.?\d*(?:[eE][+-]?\d+)?")
    Dim duracionRegex As Regex = New Regex("^[0-9]+$")
    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If validarRegistrarPago() = True Then
            MsgBox(seTipo.SelectedValue)
        End If

    End Sub

    Private Sub FrmRegistrarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listTipo As New List(Of TipoDePago)
        listTipo = objGestorTipoPago.listarTiposDePago()
        seTipo.DataSource = listTipo
        seTipo.DisplayMember = "Nombre"
        seTipo.ValueMember = "Id"
    End Sub

    Private Sub seTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seTipo.SelectedIndexChanged

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim ctr As Control
        ctr = New FrmListarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
    Private Function validarRegistrarPago() As Boolean

        Dim result As Boolean = True

        If txtFactura.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtFactura, "Debe ingresar una factura")
        End If
        If txtMonto.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtMonto, "Debe ingresar un monto")
        End If
        If txtDesde.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtDesde, "Debe ingresar un desde")
        
        End If
        Return result

    End Function
End Class
