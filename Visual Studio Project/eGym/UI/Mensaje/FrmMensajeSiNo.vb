Imports EL
Public Class FrmMensajeSiNo
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
                Dim tipoDeMaquinaPorEliminar As TipoDeMaquina = elementoPorEliminar
                Dim msg As String = "Borre las máquinas asociadas primero."
                If tipoDeMaquinaPorEliminar.Cantidad > 0 Then
                    Me.Close()
                    Dim mensaje As New FrmMensajeOk(msg)
                    mensaje.ShowDialog()
                Else
                    objGestorTipoDeMaquina.eliminarTipoDeMaquina(elementoPorEliminar)
                End If
            Case TypeOf elementoPorEliminar Is Ejercicio
                objeGestorEjercicio.eliminarEjercicio(elementoPorEliminar)
            Case TypeOf elementoPorEliminar Is Musculo
                objGestorMusculo.eliminarMusculo(elementoPorEliminar)

        End Select
        Me.Close()
    End Sub
End Class