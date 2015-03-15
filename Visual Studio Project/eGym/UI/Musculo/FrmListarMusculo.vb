Imports EL
Public Class FrmListarMusculo

    Private listaOriginal As List(Of Musculo)

    Private Sub FrmListarMusculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaOriginal = objGestorMusculo.listarMusculos()

        tblMusculos.AutoGenerateColumns = False
        tblMusculos.DataSource = listaOriginal
        tblMusculos.Columns("Nombre").DataPropertyName = "Nombre"
        tblMusculos.Columns("Ubicacion").DataPropertyName = "Ubicacion"
        tblMusculos.Columns("Origen").DataPropertyName = "Origen"
        tblMusculos.Columns("Inserccion").DataPropertyName = "Inserccion"
        tblMusculos.Columns("Inervacion").DataPropertyName = "Inervacion"
        tblMusculos.Columns("Irrigacion").DataPropertyName = "Irrigacion"
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmModificarMusculo(tblMusculos.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmRegistrarMusculo
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ctr As Control
        ctr = New FrmModificarMusculo(tblMusculos.CurrentRow.DataBoundItem)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ctr As Control
        ctr = New FrmRegistrarMusculo
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        AplicarFiltro(txtFiltro.Text.ToUpper)
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        Dim listaFiltrada As List(Of EL.Musculo) = New List(Of EL.Musculo)
        If Not listaOriginal Is Nothing Then
            For Each musculo As Musculo In listaOriginal

                If musculo.Nombre.ToUpper.Contains(filtro) Or musculo.Ubicacion.ToUpper.Contains(filtro) Or musculo.Origen.ToUpper.Contains(filtro) Or musculo.Inserccion.ToUpper.Contains(filtro) Or musculo.Inervacion.ToUpper.Contains(filtro) Or musculo.Irrigacion.ToUpper.Contains(filtro) Then
                    listaFiltrada.Add(musculo)
                End If
            Next
        End If
        tblMusculos.DataSource = listaFiltrada
    End Sub
  
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim musculoPorEliminar As Musculo = tblMusculos.CurrentRow.DataBoundItem
        objGestorMusculo.eliminarMusculo(musculoPorEliminar)
        Dim ctr As Control
        ctr = New FrmListarMusculo
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

End Class
