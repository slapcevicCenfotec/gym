Imports EL
Public Class FrmListarPago
    Private listaOriginal As List(Of Pago)

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub FrmListarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaOriginal = objGestorPago.listarPagos()
        tblPago.AutoGenerateColumns = False
        tblPago.DataSource = listaOriginal
        tblPago.Columns("Factura").DataPropertyName = "Factura"
        tblPago.Columns("Monto").DataPropertyName = "Monto"
        tblPago.Columns("Fecha").DataPropertyName = "Fecha"
        tblPago.Columns("Desde").DataPropertyName = "Desde"
        tblPago.Columns("Hasta").DataPropertyName = "Hasta"
        tblPago.Columns("tipoDePago").DataPropertyName = "tipoDePago"
        tblPago.Columns("nombreCliente").DataPropertyName = "nombreCliente"
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        AplicarFiltro(txtBuscar.Text.ToUpper)
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.Pago) = New List(Of EL.Pago)
        If Not listaOriginal Is Nothing Then
            For Each pago As Pago In listaOriginal
                If pago.Factura.ToUpper.Contains(filtro) Or pago.Monto.ToString().Contains(filtro) Or pago.Fecha.ToString().Contains(filtro) Or pago.Desde.ToString().Contains(filtro) Or pago.Hasta.ToString().Contains(filtro) Then
                    listaFiltrada.Add(pago)
                End If
            Next
        End If
        tblPago.DataSource = listaFiltrada
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnTipoDePago_Click(sender As Object, e As EventArgs) Handles btnTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnRegistarPago_Click(sender As Object, e As EventArgs) Handles btnRegistarPago.Click
        Dim ctr As Control
        ctr = New FrmRegistrarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub tblPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblPago.CellContentClick

    End Sub
End Class
