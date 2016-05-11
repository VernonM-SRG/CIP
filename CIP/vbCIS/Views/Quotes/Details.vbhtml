@ModelType vbCIS.Quote
@Code
    ViewData("Title") = "Details"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Quote</b> <a href="#Customer" class="SRGNavigationLink SRGrightPadding">Customer</a> <a href="#NextOfKin" class="SRGNavigationLink SRGrightPadding">Next Of Kin</a> <a href="#Policy" class="SRGNavigationLink SRGrightPadding">Policy</a> @Html.ActionLink("Edit", "Edit", New With {.id = Model.QuoteID}, htmlAttributes:=New With {.class = "SRGNavigationLink"}) @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.ActionLink("Delete", "Delete", New With {.id = Model.QuoteID}, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
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
        
        <dt>
            <a name="Customer"></a>
            @Html.DisplayNameFor(Function(model) model.CustomerName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerAddress1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerAddress1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerAddress2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerAddress2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerCity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerCity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerState)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerState)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerPostcode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerPostcode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerPhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerPhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerDateOfBirth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerDateOfBirth)
        </dd>

        <dt>
            <a name="NextOfKin"></a>
            @Html.DisplayNameFor(Function(model) model.NextOfKinName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinAddress1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinAddress1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinAddress2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinAddress2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinCity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinCity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinState)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinState)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinPostcode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinPostcode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinPhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinPhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NextOfKinDateOfBirth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NextOfKinDateOfBirth)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerContactAllowed)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerContactAllowed)
        </dd>

        <dt>
            <a name="Policy"></a>
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
</div>
