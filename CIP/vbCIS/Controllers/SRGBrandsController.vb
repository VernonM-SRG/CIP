Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports vbCIS
Imports Microsoft.AspNet.Identity

Namespace Controllers
    Public Class SRGBrandsController
        Inherits System.Web.Mvc.Controller

        Private db As New CISEntitiesA

        ' GET: SRGBrands
        Function Index() As ActionResult
            Dim sRGBrands = db.SRGBrands.Include(Function(s) s.RecordStatusCode)
            Return View(sRGBrands.ToList())
        End Function

        ' GET: SRGBrands/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sRGBrand As SRGBrand = db.SRGBrands.Find(id)
            If IsNothing(sRGBrand) Then
                Return HttpNotFound()
            End If
            Return View(sRGBrand)
        End Function

        ' GET: SRGBrands/Create
        Function Create() As ActionResult
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description")
            Return View()
        End Function

        ' POST: SRGBrands/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SRGBrandID,Name,Shortname,Created,LastModified,RecordStatusCodeID")> ByVal sRGBrand As SRGBrand) As ActionResult
            If ModelState.IsValid Then
                'VERN: Update Created and Modified Code.
                sRGBrand.Created = DateTime.Now
                sRGBrand.LastModified = DateTime.Now

                Dim userName As String = User.Identity.GetUserName()

                db.SRGBrands.Add(sRGBrand)
                db.SaveChanges()

                'VERN: Add Audit Trail Code
                Dim atr = New AuditTrailRecord("SRGBrand", "Name", "", sRGBrand.Name, "Create - " + userName, sRGBrand.SRGBrandID)
                Dim savedRecordCount As Integer = 0
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("SRGBrand", "Shortname", "", sRGBrand.Shortname, "Create - " + userName, sRGBrand.SRGBrandID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("SRGBrand", "RecordStatusCodeID", "", sRGBrand.RecordStatusCodeID, "Create - " + userName, sRGBrand.SRGBrandID)
                savedRecordCount = savedRecordCount + atr.Insert()
                'VERN: End

                Return RedirectToAction("Index")
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", sRGBrand.RecordStatusCodeID)
            Return View(sRGBrand)
        End Function

        ' GET: SRGBrands/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sRGBrand As SRGBrand = db.SRGBrands.Find(id)
            If IsNothing(sRGBrand) Then
                Return HttpNotFound()
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", sRGBrand.RecordStatusCodeID)
            Return View(sRGBrand)
        End Function

        ' POST: SRGBrands/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SRGBrandID,Name,Shortname,Created,LastModified,RecordStatusCodeID")> ByVal sRGBrand As SRGBrand) As ActionResult
            If ModelState.IsValid Then
                'VERN: Audit Trail Code
                Dim tmpDb As New CISEntitiesA
                Dim oldRecord As SRGBrand
                oldRecord = tmpDb.SRGBrands.Find(sRGBrand.SRGBrandID)
                sRGBrand.Created = oldRecord.Created
                Dim excludedFields As New List(Of String)
                excludedFields.Add("RecordStatusCode")
                excludedFields.Add("LastModified")
                Dim userName As String = User.Identity.GetUserName()
                Dim saved As Boolean = AuditTrailRecord.CreateAuditRecord(oldRecord, sRGBrand, "Update - " + userName, sRGBrand.SRGBrandID, excludedFields)
                tmpDb.Dispose()
                sRGBrand.LastModified = DateTime.Now
                'VERN: end

                db.Entry(sRGBrand).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", sRGBrand.RecordStatusCodeID)
            Return View(sRGBrand)
        End Function

        ' GET: SRGBrands/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sRGBrand As SRGBrand = db.SRGBrands.Find(id)
            If IsNothing(sRGBrand) Then
                Return HttpNotFound()
            End If
            Return View(sRGBrand)
        End Function

        ' POST: SRGBrands/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim sRGBrand As SRGBrand = db.SRGBrands.Find(id)
            'VERN: Add Audit Trail.
            Dim userName As String = User.Identity.GetUserName()
            Dim atr As New AuditTrailRecord("SRGBrand", "RecordStatusCodeID", sRGBrand.RecordStatusCodeID.ToString(), "3", "Delete - " + userName, sRGBrand.SRGBrandID)
            Dim savedRecord As Integer = atr.Insert()
            'VERN: Do NOT Delete it, update it's status
            'db.SRGBrands.Remove(sRGBrand)
            sRGBrand.RecordStatusCodeID = 3
            db.Entry(sRGBrand).State = EntityState.Modified
            'VERN: end
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
