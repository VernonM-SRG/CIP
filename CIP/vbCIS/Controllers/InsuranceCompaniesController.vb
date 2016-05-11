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
    Public Class InsuranceCompaniesController
        Inherits System.Web.Mvc.Controller

        Private db As New CISEntitiesA

        ' GET: InsuranceCompanies
        Function Index() As ActionResult
            Dim insuranceCompanies = db.InsuranceCompanies.Include(Function(i) i.RecordStatusCode)
            'insuranceCompanies.Include(Function(i) i.ParentInsuranceCompany)
            Return View(insuranceCompanies.ToList())
        End Function

        ' GET: InsuranceCompanies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuranceCompany As InsuranceCompany = db.InsuranceCompanies.Find(id)
            If IsNothing(insuranceCompany) Then
                Return HttpNotFound()
            End If
            Return View(insuranceCompany)
        End Function

        ' GET: InsuranceCompanies/Create
        Function Create() As ActionResult
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description")
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname")
            Return View()
        End Function

        Function Create2() As ActionResult
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description")
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname")
            Return View()
        End Function

        ' POST: InsuranceCompanies/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="InsuranceCompanyID,Name,Shortname,Address1,Address2,State,Postcode,Phone,Email,RecordStatusCodeID,Created,LastModified,ParentInsuranceCompanyID,CreditLimit,StandardDiscount,ReportingCommitments,BrandAssociations,GiftCardLetter,LetterHeads,Notes")> ByVal insuranceCompany As InsuranceCompany) As ActionResult
            If ModelState.IsValid Then
                'VERN: Update Created and Modified Code.
                insuranceCompany.Created = DateTime.Now
                insuranceCompany.LastModified = DateTime.Now

                Dim userName As String = User.Identity.GetUserName()

                db.InsuranceCompanies.Add(insuranceCompany)
                db.SaveChanges()

                'VERN: Add Audit Trail Code
                Dim atr = New AuditTrailRecord("InsuranceCompany", "InsuranceCompanyID", "", insuranceCompany.InsuranceCompanyID, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                Dim savedRecordCount As Integer = 0
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Name", "", insuranceCompany.Name, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Shortname", "", insuranceCompany.Shortname, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Address1", "", insuranceCompany.Address1, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Address2", "", insuranceCompany.Address2, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "State", "", insuranceCompany.State, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Postcode", "", insuranceCompany.Postcode, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Phone", "", insuranceCompany.Phone, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "Email", "", insuranceCompany.Email, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                atr = New AuditTrailRecord("InsuranceCompany", "ParentInsuranceCompanyID", "", insuranceCompany.ParentInsuranceCompanyID, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()


                atr = New AuditTrailRecord("InsuranceCompany", "RecordStatusCodeID", "", insuranceCompany.RecordStatusCodeID, "Create - " + userName, insuranceCompany.InsuranceCompanyID)
                savedRecordCount = savedRecordCount + atr.Insert()
                'VERN: End
                db.SaveChanges()
                'Return RedirectToAction("Create2")
                Return Create2(insuranceCompany)
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", insuranceCompany.RecordStatusCodeID)
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname", insuranceCompany.ParentInsuranceCompanyID)
            Return View(insuranceCompany)
        End Function


        ' POST: InsuranceCompanies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create2(<Bind(Include:="InsuranceCompanyID,Name,Shortname,Address1,Address2,State,Postcode,Phone,Email,RecordStatusCodeID,Created,LastModified,ParentInsuranceCompanyID,CreditLimit,StandardDiscount,ReportingCommitments,BrandAssociations,GiftCardLetter,LetterHeads,Notes")> ByVal insuranceCompany As InsuranceCompany) As ActionResult
            If ModelState.IsValid Then
                'VERN: Audit Trail Code
                Dim tmpDb As New CISEntitiesA
                Dim oldRecord As InsuranceCompany
                oldRecord = tmpDb.InsuranceCompanies.Find(insuranceCompany.InsuranceCompanyID)
                insuranceCompany.Created = oldRecord.Created
                Dim excludedFields As New List(Of String)
                excludedFields.Add("RecordStatusCode")
                excludedFields.Add("LastModified")
                Dim userName As String = User.Identity.GetUserName()
                Dim saved As Boolean = AuditTrailRecord.CreateAuditRecord(oldRecord, insuranceCompany, "Update - " + userName, insuranceCompany.InsuranceCompanyID, excludedFields)
                tmpDb.Dispose()
                insuranceCompany.LastModified = DateTime.Now
                'VERN: end
                db.Entry(insuranceCompany).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", insuranceCompany.RecordStatusCodeID)
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname", insuranceCompany.ParentInsuranceCompanyID)
            Return View(insuranceCompany)
        End Function





        ' GET: InsuranceCompanies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuranceCompany As InsuranceCompany = db.InsuranceCompanies.Find(id)
            If IsNothing(insuranceCompany) Then
                Return HttpNotFound()
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", insuranceCompany.RecordStatusCodeID)
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname", insuranceCompany.ParentInsuranceCompanyID)
            Return View(insuranceCompany)
        End Function

        ' POST: InsuranceCompanies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="InsuranceCompanyID,Name,Shortname,Address1,Address2,State,Postcode,Phone,Email,RecordStatusCodeID,Created,LastModified,ParentInsuranceCompanyID,CreditLimit,StandardDiscount,ReportingCommitments,BrandAssociations,GiftCardLetter,LetterHeads,Notes")> ByVal insuranceCompany As InsuranceCompany) As ActionResult
            If ModelState.IsValid Then
                'VERN: Audit Trail Code
                Dim tmpDb As New CISEntitiesA
                Dim oldRecord As InsuranceCompany
                oldRecord = tmpDb.InsuranceCompanies.Find(insuranceCompany.InsuranceCompanyID)
                insuranceCompany.Created = oldRecord.Created
                Dim excludedFields As New List(Of String)
                excludedFields.Add("RecordStatusCode")
                excludedFields.Add("LastModified")
                Dim userName As String = User.Identity.GetUserName()
                Dim saved As Boolean = AuditTrailRecord.CreateAuditRecord(oldRecord, insuranceCompany, "Update - " + userName, insuranceCompany.InsuranceCompanyID, excludedFields)
                tmpDb.Dispose()
                insuranceCompany.LastModified = DateTime.Now
                'VERN: end
                db.Entry(insuranceCompany).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.RecordStatusCodeID = New SelectList(db.RecordStatusCodes, "RecordStatusCodeID", "Description", insuranceCompany.RecordStatusCodeID)
            ViewBag.ParentInsuranceCompanyID = New SelectList(db.InsuranceCompanies, "ParentInsuranceCompanyID", "Shortname", insuranceCompany.ParentInsuranceCompanyID)
            Return View(insuranceCompany)
        End Function

        ' GET: InsuranceCompanies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuranceCompany As InsuranceCompany = db.InsuranceCompanies.Find(id)
            If IsNothing(insuranceCompany) Then
                Return HttpNotFound()
            End If
            Return View(insuranceCompany)
        End Function

        ' POST: InsuranceCompanies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim insuranceCompany As InsuranceCompany = db.InsuranceCompanies.Find(id)
            'VERN: Add Audit Trail.
            Dim userName As String = User.Identity.GetUserName()
            Dim atr As New AuditTrailRecord("InsuranceCompany", "RecordStatusCodeID", insuranceCompany.RecordStatusCodeID.ToString(), "3", "Delete - " + userName, insuranceCompany.InsuranceCompanyID)
            Dim savedRecord As Integer = atr.Insert()
            'VERN: Do NOT Delete it, update it's status
            'db.InsuranceCompanies.Remove(insuranceCompany)
            insuranceCompany.RecordStatusCodeID = 3
            db.Entry(insuranceCompany).State = EntityState.Modified
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
