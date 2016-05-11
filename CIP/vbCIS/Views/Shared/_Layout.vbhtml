@Imports Microsoft.AspNet.Identity
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Commercial Insurance System</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="nav navbar-nav navbar-inverse navbar-left" style="position: fixed; left: 0px; top: 0px; height: 1024px; width: 150px;">
        <a href="/"><img src="/Content/logo.png" height="40px" width="150px" /></a>
    </div>
    <div class="nav navbar-nav navbar-inverse navbar-left" style="position: fixed; left: 0px; top: 40px; height: 20px; width: 150px;">
        @Html.Partial("_LoginShowUser")
    </div>
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; top: 60px; height: 20px; width: 150px; border-bottom: white 1px solid">
        <input class="SRGsearch" type="text" size="10" value="Search..." onfocus='this.value = "";'/><span class="glyphicon glyphicon-search" style="color: white; text-align: right; position: fixed; top: 60px; left: 130px;">&nbsp;</span>
    </div>
    @Html.Partial("_PartialNavTree")




    <div style="position: absolute; left: 150px; top: 0px;">
        @RenderBody()
    </div>
    <!--
    <footer class="navbar-brand navbar-inverse navbar-fixed-bottom">
        <p>&copy; @DateTime.Now.Year - Super Retail Group</p>
    </footer>
        -->

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>

</html>
