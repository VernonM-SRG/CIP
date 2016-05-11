


<div Class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; top: 80px; height: 20px; width: 150px; font-weight: bold; border-top: white 1px solid;">
    Work
</div>
<div Class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; padding-left: 10px; top: 100px; height: 20px; width: 150px;">
    @Html.ActionLink("Raise Quote", "Create", "Quotes", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink"})
</div>
<div Class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; top: 120px; height: 20px; width: 150px;">
    Dashboard
</div>




<div Class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; top: 140px; height: 20px; width: 150px; border-top: white 1px solid;">
    Manage
</div>
<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; padding-left: 10px; top: 160px; height: 20px; width: 150px;">
    @Html.ActionLink("Divisions", "Index", "SRGBrands", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink"})
</div>
<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; padding-left: 10px; top: 180px; height: 20px; width: 150px;">
    @Html.ActionLink("Insurers", "Index", "InsuranceCompanies", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink"})
</div>

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 0px; padding-left: 10px; top: 200px; height: 20px; width: 150px;">
    @Html.ActionLink("Quotes", "Index", "Quotes", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink"})
</div>

