@ModelType IEnumerable(Of vbCIS.QuoteDetail)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Created)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastModified)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.InsurerDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OtherInformation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PLU)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PLUDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PLUQuantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PLUPrice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiscountApplied)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SRGBrandSupplying)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SRGStoreSupplying)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Comments)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Specialorder)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Isapproved)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Quote.ClaimNum)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RecordStatusCode.Description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Quantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Created)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastModified)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.InsurerDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OtherInformation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PLU)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PLUDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PLUQuantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PLUPrice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiscountApplied)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SRGBrandSupplying)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SRGStoreSupplying)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Comments)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Specialorder)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Isapproved)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Quote.ClaimNum)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RecordStatusCode.Description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.QuoteDetailID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.QuoteDetailID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.QuoteDetailID })
        </td>
    </tr>
Next

</table>
