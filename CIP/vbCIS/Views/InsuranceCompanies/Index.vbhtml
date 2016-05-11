@ModelType IEnumerable(Of vbCIS.InsuranceCompany)
@Code
    ViewData("Title") = "Index"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Insurers</b> <u class="SRGrightPadding">List</u> @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
        </div>
    </div>
<div style="position: relative; top: 50px;">
<table class="table">
    <tr>
        <th>Actions</th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Shortname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Postcode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
             <td>
                 @Html.ActionLink(".", "Edit", New With {.id = item.InsuranceCompanyID}, New With {.class = "glyphicon glyphicon-edit"})
                 @Html.ActionLink(".", "Details", New With {.id = item.InsuranceCompanyID}, New With {.class = "glyphicon glyphicon-eye-open"})
                 @Html.ActionLink(".", "Delete", New With {.id = item.InsuranceCompanyID}, New With {.class = "glyphicon glyphicon-remove-circle"})
             </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Shortname)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Address1)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Address2)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.State)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Postcode)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Phone)
            </td>
            
        </tr>
    Next

</table>
    </div>