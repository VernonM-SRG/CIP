@ModelType vbCIS.SRGBrand
@Code
    ViewData("Title") = "Create"
End Code

<div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 150px; top: 0; height: 50px; width: 100%;">
    <div class="nav navbar-nav navbar-inverse navbar-left" style="color: white; position: fixed; left: 160px; top: 10px; height: 20px; width: 100%;">
        <b class="SRGrightPadding">Divisions</b> @Html.ActionLink("List", "Index", routeValues:=Nothing, htmlAttributes:=New With {.class = "SRGNavigationLink SRGrightPadding"}) <u class="SRGrightPadding">Create</u> @Html.Partial("_LoginRegister")
    </div>
</div>
<div style="position: relative; top: 50px;">
    @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal  SRGform">

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
            @Html.LabelFor(Function(model) model.RecordStatusCodeID, "RecordStatusCodeID", htmlAttributes:=New With {.class = "control-label col-md-2 SRGlabel"})

            @Html.DropDownList("RecordStatusCodeID", Nothing, htmlAttributes:=New With {.class = "form-control SRGinput"})
            @Html.ValidationMessageFor(Function(model) model.RecordStatusCodeID, "", New With {.class = "text-danger"})

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