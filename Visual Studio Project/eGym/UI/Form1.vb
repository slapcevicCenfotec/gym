Imports EL
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim servicio As New ServicioEnClases.ServicioFichasDeMedicion

        Dim ficha As String
        ficha = servicio.obtenerFichaById(1004)
        Console.WriteLine(ficha)
        servicio.insertarFichaDeMedicion(ficha)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim servicio As New ServicioEnClases.ServicioFichasDeMedicion

        Dim lista As String

        lista = servicio.obtenerFichasPorCliente(122)
        Console.WriteLine(lista)

    End Sub
End Class