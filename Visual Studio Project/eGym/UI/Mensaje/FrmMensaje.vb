Imports EL
Public Class FrmMensaje
    Private Property elementoPorEliminar As IEntity
    Public Sub New(ByVal pmensaje As String, ByVal pmaquinaPorEliminar As IEntity)
        elementoPorEliminar = pmaquinaPorEliminar
        InitializeComponent()
        lblMensaje.Text = pmensaje
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Select Case True
            Case TypeOf elementoPorEliminar Is Maquina
                objGestorMaquina.eliminarMaquina(elementoPorEliminar)
            Case TypeOf elementoPorEliminar Is TipoDeMaquina
                objGestorTipoDeMaquina.eliminarTipoDeMaquina(elementoPorEliminar)
        End Select
        Me.Close()
    End Sub
End Class