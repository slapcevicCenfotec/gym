Public Class ListarMusculos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim s As String
        s = Request.QueryString("field1")

        If Not String.IsNullOrEmpty(s) Then

        End If

    End Sub

End Class