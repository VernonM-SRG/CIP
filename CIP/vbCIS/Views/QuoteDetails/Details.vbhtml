@ModelType vbCIS.QuoteDetail
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>QuoteDetail</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quantity)
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
            @Html.DisplayNameFor(Function(model) model.InsurerDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsurerDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OtherInformation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OtherInformation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PLU)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PLU)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PLUDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PLUDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PLUQuantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PLUQuantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PLUPrice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PLUPrice)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DiscountApplied)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DiscountApplied)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SRGBrandSupplying)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SRGBrandSupplying)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SRGStoreSupplying)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SRGStoreSupplying)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Comments)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Comments)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Specialorder)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Specialorder)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Isapproved)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Isapproved)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Quote.ClaimNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quote.ClaimNum)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RecordStatusCode.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RecordStatusCode.Description)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.QuoteDetailID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
