Imports EL
Public Class FrmListarEjercicio

    Private listaOriginal As List(Of Ejercicio)


    Private Sub FrmListarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaOriginal = objeGestorEjercicio.listarEjercicios()

        tblEjercicio.AutoGenerateColumns = False
        tblEjercicio.DataSource = listaOriginal
        tblEjercicio.Columns("Nombre").DataPropertyName = "Nombre"
        tblEjercicio.Columns("Alia").DataPropertyName = "Alias"
        tblEjercicio.Columns("PosicionInicial").DataPropertyName = "PosicionInicial"
        tblEjercicio.Columns("PosicionFinal").DataPropertyName = "PosicionFinal"
        tblEjercicio.Columns("ErroresComunes").DataPropertyName = "ErroresComunes"
        tblEjercicio.Columns("Descripcion").DataPropertyName = "Descripcion"

    End Sub

    Private Sub btnAgregarEjercicio_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmModificarEjercicio(tblEjercicio.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmModificarEjercicio(tblEjercicio.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
    
    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs)
        AplicarFiltro(txtFiltro.Text.ToUpper)
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.Ejercicio) = New List(Of EL.Ejercicio)
        If Not listaOriginal Is Nothing Then
            For Each ejercicio As Ejercicio In listaOriginal
                If ejercicio.Nombre.ToUpper.Contains(filtro) Or ejercicio.Alias.ToUpper.Contains(filtro) Or ejercicio.PosicionInicial.ToUpper.Contains(filtro) Or ejercicio.PosicionFinal.ToUpper.Contains(filtro) Or ejercicio.ErroresComunes.ToUpper.Contains(filtro) Or ejercicio.Descripcion.ToUpper.Contains(filtro) Then
                    listaFiltrada.Add(ejercicio)
                End If
            Next
        End If
        tblEjercicio.DataSource = listaFiltrada
    End Sub
  
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmModificarEjercicio(tblEjercicio.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim ctr As Control
        ctr = New FrmRegistrarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ejercicioPorEliminar As Ejercicio = tblEjercicio.CurrentRow.DataBoundItem
        objeGestorEjercicio.eliminarEjercicio(ejercicioPorEliminar)
        Dim ctr As Control
        ctr = New FrmListarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub txtFiltro_Click(sender As Object, e As EventArgs) Handles txtFiltro.Click

    End Sub
End Class
