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
    Public Class QuotesController
        Inherits System.Web.Mvc.Controller

        Private db As New CISEntitiesA

        ' GET: Quotes
        Function Index() As ActionResult
            Dim quotes = db.Quotes.Include(Function(q) q.InsuranceCompany).Include(Function(q) q.RecordStatusCode)
            Return View(quotes.ToList())
        End Function

        ' GET: Quotes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quote As Quote = db.Quotes.Find(id)
            If IsNothing(quote) Then
                Return HttpNotFound()
            End If
            Return View(quote)
        End Function

        ' GET: Quotes/Create
        Function Create() As ActionResult
            ViewBag.InsuranceCompanyID = New SelectList(db.InsuranceCompanies, "InsuranceCompanyID", "Name")
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description")
            Return View()
        End Function

        ' POST: Quotes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="QuoteID,InsuranceCompanyID,ClaimNum,StoreIDs,CustomerName,CustomerAddress1,CustomerAddress2,CustomerCity,CustomerState,CustomerPostcode,CustomerPhone,CustomerEmail,CustomerDateOfBirth,NextOfKinName,NextOfKinAddress1,NextOfKinAddress2,NextOfKinCity,NextOfKinState,NextOfKinPostcode,NextOfKinPhone,NextOfKinEmail,NextOfKinDateOfBirth,CustomerContactAllowed,PolicyLimit,Created,LastModified,RecordStatusCodeID,QuotePriority,TeamMemberResponsible,Notes,FulfilmentMethod,FulfilmentType,PreferredBrands,ClosestStores")> ByVal quote As Quote) As ActionResult
            If ModelState.IsValid Then
                'VERN: Update Created and Modified Code.
                quote.Created = DateTime.Now
                quote.LastModified = DateTime.Now

                Dim userName As String = User.Identity.GetUserName()

                db.Quotes.Add(quote)
                db.SaveChanges()

                'VERN: Add Audit Trail Code
                Dim atr = New AuditTrailRecord("Quote", "InsuranceCompanyID", "", quote.InsuranceCompanyID, "Create - " + userName, quote.QuoteID)
                Dim savedRecordCount As Integer = 0
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("Quote", "ClaimNum", "", quote.ClaimNum, "Create - " + userName, quote.QuoteID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("Quote", "StoreIDs", "", quote.StoreIDs, "Create - " + userName, quote.QuoteID)
                savedRecordCount = savedRecordCount + atr.Insert()
                'VERN: End

                Return RedirectToAction("Index")
            End If
            ViewBag.InsuranceCompanyID = New SelectList(db.InsuranceCompanies, "InsuranceCompanyID", "Name", quote.InsuranceCompanyID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quote.RecordStatusCodeID)
            Return View(quote)
        End Function

        ' GET: Quotes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quote As Quote = db.Quotes.Find(id)
            If IsNothing(quote) Then
                Return HttpNotFound()
            End If
            ViewBag.InsuranceCompanyID = New SelectList(db.InsuranceCompanies, "InsuranceCompanyID", "Name", quote.InsuranceCompanyID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quote.RecordStatusCodeID)
            Return View(quote)
        End Function

        ' POST: Quotes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="QuoteID,InsuranceCompanyID,ClaimNum,StoreIDs,CustomerName,CustomerAddress1,CustomerAddress2,CustomerCity,CustomerState,CustomerPostcode,CustomerPhone,CustomerEmail,CustomerDateOfBirth,NextOfKinName,NextOfKinAddress1,NextOfKinAddress2,NextOfKinCity,NextOfKinState,NextOfKinPostcode,NextOfKinPhone,NextOfKinEmail,NextOfKinDateOfBirth,CustomerContactAllowed,PolicyLimit,Created,LastModified,RecordStatusCodeID,QuotePriority,TeamMemberResponsible,Notes,FulfilmentMethod,FulfilmentType,PreferredBrands,ClosestStores")> ByVal quote As Quote) As ActionResult
            If ModelState.IsValid Then
                'VERN: Audit Trail Code
                Dim tmpDb As New CISEntitiesA
                Dim oldRecord As Quote
                oldRecord = tmpDb.Quotes.Find(quote.QuoteID)
                quote.Created = oldRecord.Created
                Dim excludedFields As New List(Of String)
                excludedFields.Add("RecordStatusCode")
                excludedFields.Add("LastModified")
                Dim userName As String = User.Identity.GetUserName()
                Dim saved As Boolean = AuditTrailRecord.CreateAuditRecord(oldRecord, quote, "Update - " + userName, quote.QuoteID, excludedFields)
                tmpDb.Dispose()
                quote.LastModified = DateTime.Now
                'VERN: end
                db.Entry(quote).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.InsuranceCompanyID = New SelectList(db.InsuranceCompanies, "InsuranceCompanyID", "Name", quote.InsuranceCompanyID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quote.RecordStatusCodeID)
            Return View(quote)
        End Function

        ' GET: Quotes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quote As Quote = db.Quotes.Find(id)
            If IsNothing(quote) Then
                Return HttpNotFound()
            End If
            Return View(quote)
        End Function

        ' POST: Quotes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim quote As Quote = db.Quotes.Find(id)
            'VERN: Add Audit Trail.
            Dim userName As String = User.Identity.GetUserName()
            Dim atr As New AuditTrailRecord("SRGBrand", "RecordStatusCodeID", quote.RecordStatusCodeID.ToString(), "3", "Delete - " + userName, quote.QuoteID)
            Dim savedRecord As Integer = atr.Insert()
            'VERN: Do NOT Delete it, update it's status
            'db.Quotes.Remove(quote)
            quote.RecordStatusCodeID = 3
            db.Entry(quote).State = EntityState.Modified
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
