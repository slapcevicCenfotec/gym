Imports EL
Class FrmListarTipoDePago
    Private listaOriginal As List(Of TipoDePago)

    Public Property tipoPagoToPass As TipoDePago
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmModificarTipoDePago(tblListaTipoDePago.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        Dim auxTipoDePago As TipoDePago
        auxTipoDePago = tblListaTipoDePago.CurrentRow.DataBoundItem
        objGestorTipoPago.eliminarTipoDePago(auxTipoDePago.Id)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub FrmListarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaOriginal = objGestorTipoPago.listarTiposDePago()


        tblListaTipoDePago.AutoGenerateColumns = False
        tblListaTipoDePago.DataSource = listaOriginal
        tblListaTipoDePago.Columns("Nombre").DataPropertyName = "Nombre"
        tblListaTipoDePago.Columns("Monto").DataPropertyName = "Monto"
        tblListaTipoDePago.Columns("Duracion").DataPropertyName = "Duracion"
       

    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        AplicarFiltro(txtBuscar.Text.ToUpper)
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.TipoDePago) = New List(Of EL.TipoDePago)
        If Not listaOriginal Is Nothing Then
            For Each tipo As TipoDePago In listaOriginal
                If tipo.Nombre.ToUpper.Contains(filtro) Or tipo.Monto.ToString().Contains(filtro) Or tipo.Duracion.ToString().Contains(filtro) Then
                    listaFiltrada.Add(tipo)
                End If
            Next
        End If
        tblListaTipoDePago.DataSource = listaFiltrada
    End Sub

    Private Sub tblListaTipoDePago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)



    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MetroPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnAgregarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmRegistrarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnModificarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnModificarTipoDePago.Click
        Dim ctr As Control
        ctr = New FrmModificarTipoDePago(tblListaTipoDePago.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminarTipoDePago_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoDePago.Click
        Dim msg As String = "¿Desea eliminar el tipo de pago?"
        Dim musculoPorEliminar As TipoDePago = tblListaTipoDePago.CurrentRow.DataBoundItem
        Dim mensaje As New FrmMensajeSiNo(msg, musculoPorEliminar)
        mensaje.ShowDialog()
        Dim auxTipoDePago As TipoDePago
        auxTipoDePago = tblListaTipoDePago.CurrentRow.DataBoundItem
        objGestorTipoPago.eliminarTipoDePago(auxTipoDePago.Id)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
