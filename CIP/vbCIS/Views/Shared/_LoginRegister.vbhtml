@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .style = "display: inline"})

        @Html.AntiForgeryToken()
        @<a href = "javascript:document.getElementById('logoutForm').submit()" Class="glyphicon glyphicon-log-out" style="color: white; font-weight: normal; display: inline;"></a>
    End Using
Else
          @Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "SRGnavigationLink SRGrightPadding"})
          @Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "SRGnavigationLink SRGrightPadding"})
End If

