Public Class FrmListarRoles

    Private Sub FrmListarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblListarRoles.DataSource = objGestorRol.listarRoles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ctr As Control
        ctr = New FrmRegistrarRol
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim ctr As Control
        Dim idRol As Int32
        idRol = Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value)
        ctr = New FrmModificarRol(idRol)
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idRol As Int32
        idRol = Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value)
        objGestorRol.EliminarRol(idRol)
        Me.Refresh()
    End Sub
End Class
