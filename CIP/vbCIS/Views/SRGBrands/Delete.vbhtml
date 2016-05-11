@ModelType vbCIS.SRGBrand
@Code
    ViewData("Title") = "Delete"
End Code
<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Division</b> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u>Delete</u> @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
    </div>
</div>

<div style="position: relative; top: 50px;">
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Shortname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Shortname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Created)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Created)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastModified)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastModified)
        </dd>

        <dt>
            Status
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RecordStatusCode.Description)
        </dd>

    </dl>
    @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-actions no-color">
        <input type="submit" value="Delete" class="btn btn-default navbar-right" />

    </div>
    End Using
</div>
