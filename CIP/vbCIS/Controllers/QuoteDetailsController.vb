Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports vbCIS

Namespace Controllers
    Public Class QuoteDetailsController
        Inherits System.Web.Mvc.Controller

        Private db As New CISEntitiesA

        ' GET: QuoteDetails
        Function Index() As ActionResult
            Dim quoteDetails = db.QuoteDetails.Include(Function(q) q.Quote).Include(Function(q) q.RecordStatusCode)
            Return View(quoteDetails.ToList())
        End Function

        ' GET: QuoteDetails/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quoteDetail As QuoteDetail = db.QuoteDetails.Find(id)
            If IsNothing(quoteDetail) Then
                Return HttpNotFound()
            End If
            Return View(quoteDetail)
        End Function

        ' GET: QuoteDetails/Create
        Function Create() As ActionResult
            ViewBag.QuoteID = New SelectList(db.Quotes, "QuoteID", "ClaimNum")
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description")
            Return View()
        End Function

        ' POST: QuoteDetails/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="QuoteDetailID,QuoteID,Quantity,Created,LastModified,RecordStatusCodeID,InsurerDescription,OtherInformation,PLU,PLUDescription,PLUQuantity,PLUPrice,DiscountApplied,SRGBrandSupplying,SRGStoreSupplying,Comments,Specialorder,Isapproved")> ByVal quoteDetail As QuoteDetail) As ActionResult
            If ModelState.IsValid Then
                db.QuoteDetails.Add(quoteDetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.QuoteID = New SelectList(db.Quotes, "QuoteID", "ClaimNum", quoteDetail.QuoteID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quoteDetail.RecordStatusCodeID)
            Return View(quoteDetail)
        End Function

        ' GET: QuoteDetails/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quoteDetail As QuoteDetail = db.QuoteDetails.Find(id)
            If IsNothing(quoteDetail) Then
                Return HttpNotFound()
            End If
            ViewBag.QuoteID = New SelectList(db.Quotes, "QuoteID", "ClaimNum", quoteDetail.QuoteID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quoteDetail.RecordStatusCodeID)
            Return View(quoteDetail)
        End Function

        ' POST: QuoteDetails/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="QuoteDetailID,QuoteID,Quantity,Created,LastModified,RecordStatusCodeID,InsurerDescription,OtherInformation,PLU,PLUDescription,PLUQuantity,PLUPrice,DiscountApplied,SRGBrandSupplying,SRGStoreSupplying,Comments,Specialorder,Isapproved")> ByVal quoteDetail As QuoteDetail) As ActionResult
            If ModelState.IsValid Then
                db.Entry(quoteDetail).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.QuoteID = New SelectList(db.Quotes, "QuoteID", "ClaimNum", quoteDetail.QuoteID)
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", quoteDetail.RecordStatusCodeID)
            Return View(quoteDetail)
        End Function

        ' GET: QuoteDetails/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim quoteDetail As QuoteDetail = db.QuoteDetails.Find(id)
            If IsNothing(quoteDetail) Then
                Return HttpNotFound()
            End If
            Return View(quoteDetail)
        End Function

        ' POST: QuoteDetails/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim quoteDetail As QuoteDetail = db.QuoteDetails.Find(id)
            db.QuoteDetails.Remove(quoteDetail)
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
