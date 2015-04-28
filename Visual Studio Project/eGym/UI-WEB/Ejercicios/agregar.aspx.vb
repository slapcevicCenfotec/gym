Imports System.IO
'Imports BLL
Public Class InsertarEjercicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If IsPostBack Then
        '    Dim imagen As String = Request.Form("fotoFile")
        '    Dim fs As New FileStream(imagen, FileMode.Open, FileAccess.Read)
        '    Dim bReader As New BinaryReader(fs)
        '    Dim foto(fs.Length) As Byte
        '    bReader.Read(foto, 0, fs.Length)
        '    fs.Close()

        '    Dim Gestor As GestorEjercicio = New GestorEjercicio()

        '    Gestor.insertarEjercicio("1", "1", "1", foto, "1", foto, "1", "1", 1, "1")
        'End If



    End Sub

End Class