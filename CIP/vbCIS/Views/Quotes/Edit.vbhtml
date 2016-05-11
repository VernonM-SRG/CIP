@ModelType vbCIS.Quote
@Code
    ViewData("Title") = "Edit"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Quote</b> <a href="#Customer" class="SRGNavigationLink SRGrightPadding">Customer</a> <a href="#NextOfKin" class="SRGNavigationLink SRGrightPadding">Next Of Kin</a> <a href="#Policy" class="SRGNavigationLink SRGrightPadding">Policy</a>  @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u class="SRGrightPadding">Create</u> @Html.Partial("_LoginRegister")
    </div>
</div>
<div style="position: relative; top: 50px;">
    @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal SRGform">
        
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.QuoteID)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InsuranceCompanyID, "InsuranceCompanyID", htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.DropDownList("InsuranceCompanyID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
                @Html.ValidationMessageFor(Function(model) model.InsuranceCompanyID, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClaimNum, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.ClaimNum, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.ClaimNum, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.StoreIDs, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.StoreIDs, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.StoreIDs, "", New With {.class = "text-danger"})
            
        </div>
    <hr />
    <a name="Customer"></a>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerName, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerName, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerName, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerAddress1, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerAddress1, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerAddress1, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerAddress2, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerAddress2, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerAddress2, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerCity, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerCity, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerCity, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerState, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerState, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerState, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerPostcode, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerPostcode, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerPostcode, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerPhone, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerPhone, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerPhone, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerEmail, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerEmail, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerEmail, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerDateOfBirth, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.CustomerDateOfBirth, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerDateOfBirth, "", New With {.class = "text-danger"})
            
        </div>
    <hr />
    <a name="NextOfKin"></a>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinName, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinName, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinName, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinAddress1, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinAddress1, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinAddress1, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinAddress2, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinAddress2, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinAddress2, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinCity, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinCity, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinCity, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinState, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinState, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinState, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinPostcode, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinPostcode, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinPostcode, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinPhone, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinPhone, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinPhone, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinEmail, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinEmail, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinEmail, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NextOfKinDateOfBirth, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.NextOfKinDateOfBirth, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.NextOfKinDateOfBirth, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerContactAllowed, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.CustomerContactAllowed)
                    @Html.ValidationMessageFor(Function(model) model.CustomerContactAllowed, "", New With {.class = "text-danger"})
                </div>
            </div>
        </div>
    <hr />
    <a name="Policy"></a>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PolicyLimit, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.PolicyLimit, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.PolicyLimit, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Created, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Created, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Created, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LastModified, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.LastModified, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.LastModified, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.RecordStatusCodeID, "RecordStatusCodeID", htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.DropDownList("RecordStatusCodeID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
                @Html.ValidationMessageFor(Function(model) model.RecordStatusCodeID, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.QuotePriority, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.QuotePriority, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.QuotePriority, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TeamMemberResponsible, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.TeamMemberResponsible, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.TeamMemberResponsible, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Notes, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Notes, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Notes, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FulfilmentMethod, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.FulfilmentMethod, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.FulfilmentMethod, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FulfilmentType, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.FulfilmentType, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.FulfilmentType, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PreferredBrands, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.PreferredBrands, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.PreferredBrands, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClosestStores, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.ClosestStores, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.ClosestStores, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
    End Using

        @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
    </div>