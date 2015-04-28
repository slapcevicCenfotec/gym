Imports ServicioEnClases

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim service As New ServicioFichasDeMedicion

        Dim fichas As String

        fichas = service.obtenerFichasPorCliente(122)
    End Sub
End Class