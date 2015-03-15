Imports EL

Public Class FrmListarRoles
    Inherits MetroFramework.Controls.MetroUserControl

    Dim listaRolesOringinal As New List(Of Rol)

    Private Sub FrmListarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaRolesOringinal = objGestorRol.listarRoles()
        tblListarRoles.DataSource = listaRolesOringinal

    End Sub

    Private Sub configurarColumnas(ByVal sender As Object, _
    ByVal e As DataGridViewBindingCompleteEventArgs) _
    Handles tblListarRoles.DataBindingComplete


        tblListarRoles.Columns(0).Visible = False
        tblListarRoles.Columns(1).HeaderText = "Nombre"
        tblListarRoles.Columns(2).HeaderText = "Descripcion"
        tblListarRoles.Columns(3).Visible = False
        tblListarRoles.Columns(4).Visible = False
        tblListarRoles.MultiSelect = False
        tblListarRoles.AllowUserToResizeColumns = False
        tblListarRoles.AllowUserToOrderColumns = False
        tblListarRoles.ClearSelection()
        tblListarRoles.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tblListarRoles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub


    Private Sub AplicarFiltro(filtro As String)
        Dim listarFiltrada As List(Of EL.Rol) = New List(Of Rol)
        For Each rol As EL.Rol In listaRolesOringinal
            If rol.Nombre.ToUpper.Contains(filtro) Or rol.Descripcion.ToUpper.Contains(filtro) Then
                listarFiltrada.Add(rol)
            End If
        Next

        tblListarRoles.DataSource = listarFiltrada

    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        AplicarFiltro(Me.txtBuscar.Text.ToUpper)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ctr As Control
        ctr = New FrmRegistrarRol
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ctr As Control
        Dim idRol As Int32
        idRol = Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value)
        ctr = New FrmModificarRol(idRol)
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idRol As Int32
        If MsgBox("Desea Eliminar el Rol?", vbYesNo, "Eliminar Rol") = MsgBoxResult.Yes Then
            idRol = Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value)
            objGestorRol.EliminarRol(Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value), tblListarRoles.CurrentRow.Cells(1).Value, tblListarRoles.CurrentRow.Cells(2).Value)
            Me.Refresh()
        End If
    End Sub

End Class
