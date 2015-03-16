Imports EL
Imports System.Text.RegularExpressions
Public Class FrmRegistrarPago
    Private listaOriginal As List(Of Usuario)
    Dim montoRegex As Regex = New Regex("[+-]?(?=\d*[.eE])(?=\.?\d)\d*\.?\d*(?:[eE][+-]?\d+)?")

    Private Sub FrmRegistrarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbTipo.DataSource = objGestorTipoPago.listarTiposDePago()
        dbTipo.DisplayMember = "Nombre"
        dbTipo.ValueMember = "Id"
        txtMonto.Enabled = False
        Dim auxlist As List(Of Usuario)
        Dim clean As List(Of Usuario) = New List(Of Usuario)
        auxlist = Gestor.ListarUsuarios()
        For Each user In auxlist
            If user.Rol.Id = 19 Then
                If user.Alias = "" Then
                    user.Nombre = user.Apellido + " " + user.SegundoApellido + " " + user.Nombre + " " + user.SegundoNombre
                Else
                    user.Nombre = user.Apellido + " " + user.SegundoApellido + " " + user.Nombre + " " + user.SegundoNombre + " " + "'" + user.Alias + "'"
                End If
                clean.Add(user)
            End If
        Next
        listaOriginal = clean
        lbclientes.DataSource = listaOriginal
        lbclientes.DisplayMember = "Nombre"
        lbclientes.ValueMember = "Id"
    End Sub
    Private Function validarRegistarPago() As Boolean
        Dim validado As Boolean = True
        If dbTipo.SelectedValue = Nothing Then
            ErPrValidaciones.SetError(dbTipo, "El tipo es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(dbTipo, "")
        End If

        If txtMonto.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtMonto, "El monto es un campo obligatorio")
            validado = False
        Else
            If montoRegex.IsMatch(txtMonto.Text) = False Then
                validado = False
                ErPrValidaciones.SetError(txtMonto, "Monto debe ser un numero")
            End If
            ErPrValidaciones.SetError(txtMonto, "")
        End If

        If txtFactura.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtFactura, "La factura es un dato obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtFactura, "")
        End If
        If dtDesde.Text.Length = 0 Then
            ErPrValidaciones.SetError(dtDesde, "La fecha desde es un dato obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(dtDesde, "")
        End If
        If dtHasta.Text.Length = 0 Then
            ErPrValidaciones.SetError(dtHasta, "La fecha hasta es un dato obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(dtHasta, "")
        End If
        ErPrValidaciones.SetError(dtHasta, "")
        If dtHasta.Value.Date <= dtDesde.Value.Date Then
            ErPrValidaciones.SetError(dtHasta, "La fecha desde debe ser menor que la fechas hasta")
            ErPrValidaciones.SetError(dtDesde, "La fecha desde debe ser menor que la fechas hasta")
            validado = False
        Else
            ErPrValidaciones.SetError(dtHasta, "")
        End If
        If lbclientes.SelectedValue Is Nothing Then
            ErPrValidaciones.SetError(lbclientes, "Debe seleccionar por lo menos un cliente")
            validado = False
        Else
            ErPrValidaciones.SetError(dtHasta, "")
        End If
        Return validado
    End Function
    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.Usuario) = New List(Of EL.Usuario)
        If Not listaOriginal Is Nothing Then
            For Each usuario As Usuario In listaOriginal
                If usuario.Nombre.ToUpper.Contains(filtro) Then
                    listaFiltrada.Add(usuario)
                End If
            Next
        End If
        lbclientes.DataSource = listaFiltrada
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        AplicarFiltro(txtBuscar.Text.ToUpper)
    End Sub
    Private Sub lbMusculosSecundarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbclientes.SelectedIndexChanged

    End Sub

    Private Sub lblTxtFactura_Click(sender As Object, e As EventArgs) Handles lblTxtFactura.Click

    End Sub

    Private Sub dbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dbTipo.SelectedIndexChanged
        Dim auxTipo As TipoDePago = New TipoDePago()
        Dim auxLista As List(Of TipoDePago) = objGestorTipoPago.listarTiposDePago()
        If dbTipo.SelectedValue.GetType() Is auxTipo.GetType() Then
            For Each item In auxLista
                auxTipo = dbTipo.SelectedValue
                If auxTipo.Id = item.Id Then
                    txtMonto.Text = item.Monto.ToString()
                End If
            Next
        Else
            For Each item In auxLista
                Dim auxNum As Integer = dbTipo.SelectedValue
                If auxNum = item.Id Then
                    txtMonto.Text = item.Monto.ToString()
                End If
            Next
        End If
       

    End Sub

    Private Sub lblTipoDePagoDuracion_Click(sender As Object, e As EventArgs) Handles lblTipoDePagoDuracion.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.regresaListar()
    End Sub
    Private Sub regresaListar()
        Dim ctr As Control
        ctr = New FrmListarPago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarRegistarPago() = True Then
            objGestorPago.insertarPago(txtFactura.Text, txtMonto.Text, dbTipo.SelectedValue, dtHasta.Text, dtDesde.Text, lbclientes.SelectedValue)
            Me.regresaListar()
        End If
    End Sub

    Private Function validarAgregarTipoDePago() As Boolean

    End Function

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

    End Sub
End Class

