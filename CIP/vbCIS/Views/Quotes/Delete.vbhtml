@ModelType vbCIS.Quote
@Code
    ViewData("Title") = "Delete"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Quote</b> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u>Delete</u> @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
    </div>
</div>

<div style="position: relative; top: 50px;">
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ClaimNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClaimNum)
        </dd>
        <dt>
            Insurer
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsuranceCompany.Name)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.StoreIDs)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StoreIDs)
        </dd>
    </dl>
    
    <dl class="dl-horizontal" style="border: solid 1px; border-color: darkgray;">
        <dt>
            <b>Customer:</b><br />
        </dt>
        <dd>

        </dd>
        <dt>
            Name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerName)
        </dd>

        <dt>
            Address1
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerAddress1)
        </dd>

        <dt>
            Address2
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerAddress2)
        </dd>

        <dt>
            City
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerCity)
        </dd>

        <dt>
            State
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerState)
        </dd>

        <dt>
            Postcode
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerPostcode)
        </dd>

        <dt>
            Phone
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerPhone)
        </dd>

        <dt>
            Email
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerEmail)
        </dd>

        <dt>
            DateOfBirth
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerDateOfBirth)
        </dd>
    </dl>
    <dl class="dl-horizontal" style="border: solid 1px; border-color: darkgray;">
        <dt>
            <b>Next Of Kin:</b><br />
        </dt>
        <dd>

        </dd>
        <dt>
            Name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinName)
        </dd>

        <dt>
           Address1
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinAddress1)
        </dd>

        <dt>
            Address2
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinAddress2)
        </dd>

        <dt>
            City
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinCity)
        </dd>

        <dt>
           State
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinState)
        </dd>

        <dt>
            Postcode
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinPostcode)
        </dd>

        <dt>
            Phone
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinPhone)
        </dd>

        <dt>
            Email
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinEmail)
        </dd>

        <dt>
            Date Of Birth
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinDateOfBirth)
        </dd>
        </dl>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerContactAllowed)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerContactAllowed)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PolicyLimit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PolicyLimit)
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
            @Html.DisplayNameFor(Function(model) model.QuotePriority)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuotePriority)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TeamMemberResponsible)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TeamMemberResponsible)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Notes)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Notes)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FulfilmentMethod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FulfilmentMethod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FulfilmentType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FulfilmentType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PreferredBrands)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PreferredBrands)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClosestStores)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClosestStores)
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
        <input type="submit" value="Delete" class="btn btn-default" /> |
    </div>
    End Using
</div>
