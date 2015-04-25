Imports System.Web.Services

Public Class Session
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod> _
    Public Shared Sub SetUserId(userId As String)
        HttpContext.Current.Session("_USERID") = userId
    End Sub

    <WebMethod> _
    Public Shared Sub LogOff()
        HttpContext.Current.Session("_USERID") = Nothing
    End Sub


End Class