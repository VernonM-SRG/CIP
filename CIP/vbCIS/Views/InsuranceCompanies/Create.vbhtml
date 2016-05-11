@ModelType vbCIS.InsuranceCompany
@Code
    ViewData("Title") = "Create"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Insurer</b> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u class="SRGrightPadding">Create</u> @Html.Partial("_LoginRegister")
    </div>
</div>
<div style="position: relative; top: 50px;">

    @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal SRGform">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shortname, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Shortname, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Shortname, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Address1, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Address1, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Address1, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Address2, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Address2, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Address2, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.State, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.State, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.State, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Postcode, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Postcode, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Postcode, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Phone, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Phone, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Phone, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            <b class="control-label col-md-2 SRGlabel">Status</b>
            
                @Html.DropDownList("RecordStatusCodeID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
                @Html.ValidationMessageFor(Function(model) model.RecordStatusCodeID, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            <b class="control-label col-md-2 SRGlabel">Parent Company</b>
            
                @Html.DropDownList("ParentInsuranceCompanyID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
                @Html.ValidationMessageFor(Function(model) model.ParentInsuranceCompanyID, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CreditLimit, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.CreditLimit, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.CreditLimit, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.StandardDiscount, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.StandardDiscount, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.StandardDiscount, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ReportingCommitments, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.ReportingCommitments, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.ReportingCommitments, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BrandAssociations, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.BrandAssociations, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.BrandAssociations, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.GiftCardLetter, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.GiftCardLetter, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.GiftCardLetter, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LetterHeads, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.LetterHeads, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.LetterHeads, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Notes, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.TextAreaFor(Function(model) model.Notes, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Notes, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
    End Using

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
</div>