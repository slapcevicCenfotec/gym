Public Class Graficos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("_USERPERMISSION") Is Nothing Then
            Response.Redirect("http://localhost/egym/iniciarsesion.aspx")
        End If
        Dim permissions = TryCast(Session("_USERPERMISSION"), List(Of String))
        Dim valido = False
        For Each permission As String In permissions
            If permission = "12" Then
                valido = True
            End If
        Next
        If Session("_USERID") Is Nothing Or Session("_USERID") = String.Empty Then
            Response.Redirect("http://localhost/egym/iniciarsesion.aspx")
        ElseIf valido = False Then
            Response.Redirect("http://localhost/egym/iniciarsesion.aspx")
        End If

    End Sub

End Class