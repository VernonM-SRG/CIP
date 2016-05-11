@ModelType IEnumerable(Of vbCIS.Quote)
@Code
ViewData("Title") = "Index"
End Code
<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Quotes</b> <u class="SRGrightPadding">List</u> @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
    </div>
</div>
<div style="position: relative; top: 50px;">

    <table class="table">
        <tr>
            <th>
                Action
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.ClaimNum)
            </th>
            <th>
                Insurer
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.CustomerName)
            </th>
            
            <th>
                @Html.DisplayNameFor(Function(model) model.QuotePriority)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.TeamMemberResponsible)
            </th>
            
            <th>
                Status
            </th>
            
        </tr>

        @For Each item In Model
    @<tr>
        <td>
             @Html.ActionLink(".", "Edit", New With {.id = item.QuoteID}, New With {.class = "glyphicon glyphicon-edit"})
             @Html.ActionLink(".", "Details", New With {.id = item.QuoteID}, New With {.class = "glyphicon glyphicon-eye-open"})
             @Html.ActionLink(".", "Delete", New With {.id = item.QuoteID}, New With {.class = "glyphicon glyphicon-remove-circle"})
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClaimNum)
        </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.InsuranceCompany.Name)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.QuotePriority)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TeamMemberResponsible)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RecordStatusCode.Description)
        </td>
    </tr>
        Next

    </table>
    </div>