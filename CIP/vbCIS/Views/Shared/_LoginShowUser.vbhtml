@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
    Dim userName = User.Identity.GetUserName()
    Dim newlen = userName.Length()
    If (newlen > 16) Then
        newlen = 15
    End If
    userName = userName.Remove(newlen - 1)
    @Html.ActionLink(userName, "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage", .style = "width: 150px; color: white;"})
End If
