@ModelType vbCIS.SRGBrand
@Code
    ViewData("Title") = "Edit"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 40px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Division</b> <u class="SRGrightPadding">Edit</u> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.ActionLink("Create", "Create", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.ActionLink("Delete", "Delete", New With {.id = Model.SRGBrandID}, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) @Html.Partial("_LoginRegister")
    </div>
</div>
<div style="position: relative; top: 40px;">
    @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal SRGform">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.SRGBrandID)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2  SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shortname, htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.EditorFor(Function(model) model.Shortname, New With {.htmlAttributes = New With {.class = "form-control SRGinput"}})
                @Html.ValidationMessageFor(Function(model) model.Shortname, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.RecordStatusCodeID, "RecordStatusCodeID", htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})
            
                @Html.DropDownList("RecordStatusCodeID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
                @Html.ValidationMessageFor(Function(model) model.RecordStatusCodeID, "", New With {.class = "text-danger"})
            
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default navbar-right" />
            </div>
        </div>
    </div>
    End Using


    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
    </div>