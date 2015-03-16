Imports EL
Public Class FrmRegistrarPago

   
    Private Sub FrmRegistrarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbTipo.DataSource = objGestorTipoPago.listarTiposDePago()
        dbTipo.DisplayMember = "Nombre"
        dbTipo.ValueMember = "Id"
        Dim auxlist As List(Of Usuario)
        Dim clean As List(Of Usuario) = New List(Of Usuario)
        auxlist = Gestor.ListarUsuarios()

        For Each user In auxlist
            If user.Rol.Id = 19 Then
                clean.Add(user)
            End If
        Next


        lbclientes.DataSource = clean
        lbclientes.DisplayMember = "Nombre"
        lbclientes.ValueMember = "Id"



    End Sub
    Private Sub lbMusculosSecundarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbclientes.SelectedIndexChanged

    End Sub

    Private Sub lblTxtFactura_Click(sender As Object, e As EventArgs) Handles lblTxtFactura.Click

    End Sub

    Private Sub cmbTipoDeMaquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dbTipo.SelectedIndexChanged

    End Sub

    Private Sub lblTipoDePagoDuracion_Click(sender As Object, e As EventArgs) Handles lblTipoDePagoDuracion.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control
        ctr = New FrmListarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        objGestorPago.insertarPago(txtFactura.Text, txtMonto.Text, dbTipo.SelectedValue, dtHasta.Text, dtDesde.Text, lbclientes.SelectedValue)

    End Sub

    Private Function validarAgregarTipoDePago() As Boolean
        
    End Function
End Class

