@ModelType vbCIS.InsuranceCompany
@Code
    ViewData("Title") = "Delete"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Insurer</b> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u>Delete</u> @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
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
            @Html.DisplayNameFor(Function(model) model.Address1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.State)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.State)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Postcode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Postcode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
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
            @Html.DisplayNameFor(Function(model) model.ParentInsuranceCompanyID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ParentInsuranceCompanyID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreditLimit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreditLimit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.StandardDiscount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StandardDiscount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ReportingCommitments)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ReportingCommitments)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BrandAssociations)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BrandAssociations)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GiftCardLetter)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GiftCardLetter)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LetterHeads)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LetterHeads)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Notes)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Notes)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RecordStatusCode.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RecordStatusCode.Description)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" />
        </div>
    End Using
</div>
