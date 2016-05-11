Imports System.Web.Mvc

Namespace Controllers
    Public Class AuditTrailRecord
        Inherits Controller

        ' Setup Variables
        Public Property AuditTrailID As Integer
        Public Property TableName As String
        Public Property ColumnName As String
        Public Property RecordStatusCodeID As Integer
        Public Property Created As DateTime
        Public Property BeforeValue As String
        Public Property AfterValue As String
        Public Property Details As String

        Public Property RemoteObjectPrimaryKeyID As Integer

        Private Shared Property connString As String = "Data Source=LAPTOP-ISSE06\SQLEXPRESS;Initial Catalog=CIS;Persist Security Info=True;User ID=sa;Password=!Elizabeth;Pooling=False"

        ' GET: AuditTrailRecord
        Function Index() As ActionResult
            Return View()
        End Function

        Public Sub New(tableName As String, columnName As String, beforeValue As String, afterValue As String, details As String, remoteObjectPrimaryKeyID As Integer)
            Me.TableName = tableName
            Me.ColumnName = columnName
            Me.BeforeValue = beforeValue
            Me.AfterValue = afterValue
            Me.Details = details
            Me.RemoteObjectPrimaryKeyID = remoteObjectPrimaryKeyID
        End Sub

        Shared Function CreateAuditRecord(beforeObject As Object, afterObject As Object, details As String, remoteObjectPrimaryKeyID As Integer, excludedFields As List(Of String)) As Boolean
            Dim result As Boolean
            result = False

            Dim beforeType = beforeObject.GetType
            Dim afterType = afterObject.GetType

            Dim props = afterType.GetProperties

            Dim savedRecordCount As Integer
            Dim recordCount As Integer

            savedRecordCount = 0
            recordCount = 0

            For Each prop As System.Reflection.PropertyInfo In props
                If (excludedFields.Contains(prop.Name)) Then
                Else
                    Dim beforeValue As String
                    beforeValue = ""
                    Try
                        Dim val = prop.GetValue(beforeObject, Nothing)


                        If (IsNothing(prop.GetValue(beforeObject, Nothing))) Then
                        Else
                            beforeValue = prop.GetValue(beforeObject, Nothing).ToString
                        End If
                    Catch ex As Exception
                        beforeValue = ""
                    End Try

                    Dim afterValue As String
                    afterValue = ""
                    Try
                        If (IsNothing(prop.GetValue(afterObject, Nothing))) Then
                        Else
                            afterValue = prop.GetValue(afterObject, Nothing).ToString
                        End If
                    Catch ex As Exception
                        afterValue = ""
                    End Try
                    If (beforeValue.Equals(afterValue)) Then
                    Else
                        recordCount = recordCount + 1
                        Dim atr As AuditTrailRecord = New AuditTrailRecord(afterType.Name, prop.Name, beforeValue, afterValue, details, remoteObjectPrimaryKeyID)
                        savedRecordCount = savedRecordCount + atr.Insert()
                    End If
                End If
            Next
            Return result
        End Function

        Function Insert() As Integer
            Dim result As Integer = 0
            Try
                Dim sqlConn As New System.Data.SqlClient.SqlConnection(connString)

                Dim commandText As String = "INSERT INTO AuditTrail (TableName, ColumnName, BeforeValue, AfterValue, RemoteObjectPrimaryKeyID, Details) VALUES ('"
                commandText = commandText + TableName + "', '"
                commandText = commandText + ColumnName + "', '"
                commandText = commandText + BeforeValue + "', '"
                commandText = commandText + AfterValue + "', "
                commandText = commandText + RemoteObjectPrimaryKeyID.ToString + ", '"
                commandText = commandText + Details + "')"

                Dim sqlCommand As New SqlClient.SqlCommand
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand.CommandText = commandText
                sqlCommand.Connection = sqlConn

                sqlConn.Open()
                sqlCommand.ExecuteNonQuery()
                sqlConn.Close()
                result = 1
            Catch ex As Exception
            End Try
            Return result
        End Function

        Public Shared Function ListAllHTML(tableFilter As String, remoteObjectPrimaryKeyIDFilter As Integer) As String
            Dim result As String = "No Records Found"
            Try
                Dim sqlConn As New System.Data.SqlClient.SqlConnection(connString)

                Dim commandText As String = "SELECT TOP 200 Created, ColumnName, BeforeValue, AfterValue, Details FROM AuditTrail WHERE TableName='" + tableFilter + "' AND RemoteObjectPrimaryKeyID=" + remoteObjectPrimaryKeyIDFilter.ToString + " ORDER BY AuditTrailID DESC"


                Dim sqlCommand As New SqlClient.SqlCommand
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand.CommandText = commandText
                sqlCommand.Connection = sqlConn

                sqlConn.Open()
                Dim records As System.Data.SqlClient.SqlDataReader
                records = sqlCommand.ExecuteReader()
                If (records.HasRows) Then

                    '                    result = "<table width=100% border=0>"
                    'result = result + "<tr><td>When</td><td>Who</td><td>What</td><td>Now</td><td>Was</td></tr>"

                    Dim hdrWhen As String = New String("When").PadRight(24)
                    Dim hdrWho As String = New String("Who").PadRight(40)
                    Dim hdrWhat As String = New String("What").PadRight(40)
                    Dim hdrNow As String = New String("Now").PadRight(50)
                    Dim hdrWas As String = New String("Was").PadRight(50)
                    result = hdrWhen + hdrWho + hdrWhat + hdrNow + hdrWas + vbCrLf
                    While records.Read
                        result = result + records("Created").ToString.PadRight(24)
                        'result = result.Remove(24)


                        'result = result + vbTab

                        result = result + records("Details").ToString.PadRight(40).Remove(39) + " "

                        'result = result.Remove(44)

                        'result = result + vbTab
                        result = result + records("ColumnName").ToString.PadRight(40).Remove(39) + " "
                        'result = result.Remove(84)
                        'result = result + vbTab
                        result = result + records("AfterValue").ToString.PadRight(50).Remove(49) + " "
                        'result = result.Remove(134)
                        'result = result + vbTab
                        result = result + records("BeforeValue").ToString.PadRight(50).Remove(49)
                        'result = result.Remove(184)
                        result = result + vbCrLf

                    End While
                    'result = result + "</table>"

                Else

                End If



                sqlConn.Close()

            Catch ex As Exception
            End Try
            Return result
        End Function

    End Class
End Namespace