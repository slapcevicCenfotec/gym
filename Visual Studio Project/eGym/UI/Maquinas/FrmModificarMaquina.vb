Imports EL

Public Class FrmModificarMaquina
    Private Property maquinaPorModificar As Maquina
    Private Property listaTiposDeMaquinas As List(Of TipoDeMaquina)

    Public Sub New(ByVal pmaquina As Maquina)
        maquinaPorModificar = pmaquina
        InitializeComponent()
    End Sub

    Private Sub FrmModificarMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listaTiposDeMaquinas = objGestorTipoDeMaquina.listarTiposDeMaquinas()

        For Each tipoDeMaquina In listaTiposDeMaquinas
            cmbTipoDeMaquina.Items.Add(tipoDeMaquina.Nombre)
        Next

        cmbTipoDeMaquina.SelectedItem = maquinaPorModificar.NombreTipoMaquina
        txtNumeroDeActivo.Text = maquinaPorModificar.NumeroActivo
        txtNumeroDeMaquina.Text = maquinaPorModificar.NumeroMaquina
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim numeroActivo As String = txtNumeroDeActivo.Text
        Dim numeroMaquina As String = txtNumeroDeMaquina.Text
        Dim tipoDeMaquina As String = cmbTipoDeMaquina.SelectedItem
        Dim habilitado As Boolean = True
        Dim idTipoMaquina As Integer

        For Each tipoMaquina In listaTiposDeMaquinas
            If tipoMaquina.Nombre = tipoDeMaquina Then
                idTipoMaquina = tipoMaquina.Id
            End If
        Next

        resetValidarLabels()

        If validarFormRegistrarMaquina() Then
            objGestorMaquina.modificarMaquina(maquinaPorModificar.Id, numeroActivo, numeroMaquina, habilitado, idTipoMaquina)
            clearScreen()
        End If

        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)

    End Sub

    Private Function validarFormRegistrarMaquina() As Boolean
        Dim validado As Boolean = True
        If txtNumeroDeActivo.Text.Length = 0 Then
            lblValidarNumeroActivo.Text = "Número de activo es requerido"
            validado = False
        End If

        If txtNumeroDeMaquina.Text.Length = 0 Then
            lblValidarNumeroMaquina.Text = "Número de máquina es requerido"
            validado = False
        End If

        If cmbTipoDeMaquina.SelectedItem = Nothing Then
            lblValidarTipoDeMaquina.Text = "Tipo de máquina es requerido"
            validado = False
        End If

        Return validado
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()
        resetValidarLabels()

        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Sub clearScreen()
        Me.txtNumeroDeActivo.Text = String.Empty
        Me.txtNumeroDeMaquina.Text = String.Empty
        Me.cmbTipoDeMaquina.SelectedItem = Nothing
    End Sub

    Sub resetValidarLabels()
        lblValidarNumeroActivo.Text = Nothing
        lblValidarNumeroMaquina.Text = Nothing
        lblValidarTipoDeMaquina.Text = Nothing
    End Sub
End Class
