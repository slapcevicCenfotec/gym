Imports EL

''' <summary>
''' Autor: Alexis Soto
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol para listar Rol
''' </summary>
Public Class FrmListarRoles
    Inherits MetroFramework.Controls.MetroUserControl

    Dim listaRolesOringinal As New List(Of Rol)

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Llena con los datos obtenidos de ListarRol y se los pasa el Datagridview
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmListarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaRolesOringinal = objGestorRol.listarRoles()
        tblListarRoles.DataSource = listaRolesOringinal

    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Configura el datagridview para mostrar los datos
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
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


    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Filtra el datagridview y refresca los datos
    ''' </summary>
    ''' <param name="filtro">The filtro.</param>
    Private Sub AplicarFiltro(filtro As String)
        Dim listarFiltrada As List(Of EL.Rol) = New List(Of Rol)
        For Each rol As EL.Rol In listaRolesOringinal
            If rol.Nombre.ToUpper.Contains(filtro) Or rol.Descripcion.ToUpper.Contains(filtro) Then
                listarFiltrada.Add(rol)
            End If
        Next

        tblListarRoles.DataSource = listarFiltrada

    End Sub
    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene el texto a buscar y se lo envia el metodo aplicarFiltro
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        AplicarFiltro(Me.txtBuscar.Text.ToUpper)
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Crea una instacio de FrmRegistrarRol 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ctr As Control
        ctr = New FrmRegistrarRol
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Crea una instacio de FrmModificarRolRol 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ctr As Control
        Dim idRol As Int32
        idRol = Convert.ToInt32(tblListarRoles.CurrentRow.Cells(0).Value)
        ctr = New FrmModificarRol(idRol)
        ctr.Dock = DockStyle.Fill
        Me.Parent.Controls.Add(ctr)
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Llama el evento EliminarRol Del GestorRol y le envia el Id de la fila que se encuentra seleccionada en el DataGridView
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msg As String = "Desea eliminar el Rol?"
        Dim rolPorEliminar As Rol = tblListarRoles.CurrentRow.DataBoundItem
        Dim mensaje As New FrmMensajeSiNo(msg, rolPorEliminar)
        mensaje.ShowDialog()
        listaRolesOringinal = objGestorRol.listarRoles()
        tblListarRoles.AutoGenerateColumns = False
        tblListarRoles.DataSource = listaRolesOringinal
    End Sub

End Class
