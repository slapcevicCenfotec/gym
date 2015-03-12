Imports EL

Public Class FrmRegistrarPago

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        MsgBox(seTipo.SelectedValue)
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
End Class
