Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration


Public Class LookupText

    Dim gDBConn As SqlConnection
    Dim gSentMessages As ArrayList


    Public Structure SentMessage
        Public MessageID As Integer
        Public BatchID As Integer
        Public TextTypeID As Integer
        Public SentByUserID As Integer
        Public SentTime As DateTime
        Public TenantID As Integer
        Public AssetID As Integer
        Public TextToEmail As String
        Public SubjectLine As String
        Public BodyText As String
    End Structure

    Public Structure Tenant
        Public TenantID As Integer
        Public FullName As String
        Public CellPhone As String
        Public PrimaryEmail As String
    End Structure

    Public Structure Asset
        Public AssetID As Integer
        Public AddressDesc As String
        Public PropertyDesc As String
    End Structure

    Public Structure SecurityUser
        Public UserID As Integer
        Public FullName As String
        Public Email As String
        Public ActiveEmployee As Char ' Y | N
    End Structure


    Private Sub LookupText_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call DBOpen()

    End Sub


    Private Sub LookupText_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Call DBClose()

    End Sub


    Private Sub Lookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click

        Dim lEmailAddress As String
        Dim lMessageIdx As Integer
        Dim lSentMessage As SentMessage
        Dim lDisplayRow As String

        lbSentMessages.Items.Clear()

        txtFullEmailAddress.Text = ""
        txtMessageSent.Text = ""
        txtSubjectLine.Text = ""
        txtBodyText.Text = ""

        txtSentByName.Text = ""
        txtSentByEmail.Text = ""

        txtTenantName.Text = ""
        txtCellPhone.Text = ""
        txtPrimaryEmail.Text = ""

        txtAddress.Text = ""
        txtProperty.Text = ""

        lEmailAddress = txtEmailAddress.Text
        gSentMessages = GetSentMessagesByEmail(lEmailAddress)

        If gSentMessages.Count > 0 Then

            For lMessageIdx = 0 To (gSentMessages.Count - 1)

                lSentMessage = gSentMessages.Item(lMessageIdx)
                lDisplayRow = LSet(lSentMessage.TextToEmail, 22) & " " & LSet(lSentMessage.SentTime.ToString, 22) & " " & LSet(lSentMessage.BodyText, 40)
                lbSentMessages.Items.Add(lDisplayRow)

            Next

            lbSentMessages.Update()
            lbSentMessages.Focus()
            lbSentMessages.SetSelected(0, True)

        Else

            MessageBox.Show("Unable to find a text message sent to: " & lEmailAddress, "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


    Private Sub ToClipboard_Click(sender As Object, e As EventArgs) Handles btnToClipboard.Click

        Dim lClipboardText As String

        lClipboardText = "TextTo Address: " + txtFullEmailAddress.Text + Environment.NewLine + Environment.NewLine
        lClipboardText += LSet("Message Sent: " + txtMessageSent.Text, 40) + "Sent By Name: " + txtSentByName.Text + Environment.NewLine
        lClipboardText += LSet("Subject Line: " + txtSubjectLine.Text, 40) + "Sent By Email: " + txtSentByEmail.Text + Environment.NewLine
        lClipboardText += Environment.NewLine + "Body Text: " + Environment.NewLine + txtBodyText.Text + Environment.NewLine + Environment.NewLine
        lClipboardText += LSet("Tenant Name: " + txtTenantName.Text, 40) + "Property: " + txtProperty.Text + Environment.NewLine
        lClipboardText += LSet("Cell Phone: " + txtCellPhone.Text, 40) + "Address: " + txtAddress.Text + Environment.NewLine
        lClipboardText += "Primary Email: " + txtPrimaryEmail.Text

        Clipboard.SetText(lClipboardText)

    End Sub


    Private Sub lbSentMessages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSentMessages.SelectedIndexChanged

        Dim lMessageIdx As Integer
        Dim lSentMessage As SentMessage
        Dim lTenant As Tenant
        Dim lAsset As Asset
        Dim lSecurityUser As SecurityUser

        lMessageIdx = lbSentMessages.SelectedIndex

        If (lMessageIdx >= 0) And (lMessageIdx < gSentMessages.Count) Then

            lSentMessage = gSentMessages.Item(lMessageIdx)

            lTenant = GetTenant(lSentMessage.TenantID)
            lAsset = GetAsset(lSentMessage.AssetID)
            lSecurityUser = GetSecurityUser(lSentMessage.SentByUserID)

            txtFullEmailAddress.Text = lSentMessage.TextToEmail
            txtMessageSent.Text = lSentMessage.SentTime.ToString
            txtSubjectLine.Text = lSentMessage.SubjectLine
            txtBodyText.Text = lSentMessage.BodyText

            txtSentByName.Text = lSecurityUser.FullName
            txtSentByEmail.Text = lSecurityUser.Email

            txtTenantName.Text = lTenant.FullName
            txtCellPhone.Text = lTenant.CellPhone
            txtPrimaryEmail.Text = lTenant.PrimaryEmail

            txtAddress.Text = lAsset.AddressDesc
            txtProperty.Text = lAsset.PropertyDesc

        End If

    End Sub


    Public Function DBOpen() As Integer

        Dim lError As Integer = 0
        Dim lConnectionString As String

        Try

            'gDBConn = New SqlConnection("Initial Catalog=SendText;Data Source=localhost;Integrated Security=SSPI;MultipleActiveResultSets=True;")
            lConnectionString = ConfigurationManager.ConnectionStrings("SendText").ConnectionString
            gDBConn = New SqlConnection(lConnectionString)
            gDBConn.Open()

        Catch ex As Exception

            lError = -1 ' Flag failure to open database
            MessageBox.Show("DBOpen: " & ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        DBOpen = lError

    End Function


    Public Sub DBClose()

        Try

            gDBConn.Close()
            gDBConn.Dispose()

        Catch

            ' No worries if error encountered while closing

        Finally

            gDBConn = Nothing

        End Try

    End Sub


    Public Function GetSentMessagesByEmail(pEmailAddress As String) As ArrayList

        Dim lSentMessage As SentMessage
        Dim lSentMessages As New ArrayList
        Dim lCmd As New SqlCommand
        Dim lReader As SqlDataReader

        lSentMessage = Nothing

        Try

            lCmd = gDBConn.CreateCommand

            lCmd.CommandText = "GetSentMessagesByEmail"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.Add("@EmailAddress", SqlDbType.VarChar)
            lCmd.Parameters("@EmailAddress").Value = pEmailAddress

            lReader = lCmd.ExecuteReader()
            If lReader.HasRows Then

                While lReader.Read()

                    With lSentMessage

                        .MessageID = lReader.GetInt32(0)
                        .BatchID = lReader.GetInt32(1)
                        .TextTypeID = lReader.GetInt32(2)
                        .SentByUserID = lReader.GetInt32(3)
                        .SentTime = lReader.GetDateTime(4)
                        .TenantID = lReader.GetInt32(5)
                        .AssetID = lReader.GetInt32(6)
                        .TextToEmail = lReader.GetString(7)
                        .SubjectLine = lReader.GetString(8)
                        .BodyText = lReader.GetString(9)

                    End With

                    lSentMessages.Add(lSentMessage)

                End While

            End If

        Catch ex As Exception

            MessageBox.Show("GetLastSentMessageByEmail: " & ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            lReader = Nothing

            lCmd.Dispose()
            lCmd = Nothing

        End Try

        GetSentMessagesByEmail = lSentMessages

    End Function


    Public Function GetTenant(pTenantID As Integer) As Tenant

        Dim lTenant As Tenant
        Dim lCmd As New SqlCommand
        Dim lReader As SqlDataReader

        lTenant = Nothing

        Try

            lCmd = gDBConn.CreateCommand

            lCmd.CommandText = "GetTenant"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.Add("@TenantID", SqlDbType.Int)
            lCmd.Parameters("@TenantID").Value = pTenantID

            lReader = lCmd.ExecuteReader(CommandBehavior.SingleRow)
            lReader.Read()

            If lReader.HasRows Then

                With lTenant

                    .TenantID = pTenantID
                    .FullName = lReader.GetString(0)
                    .CellPhone = lReader.GetString(1)
                    .PrimaryEmail = lReader.GetString(2)

                End With

            End If

        Catch ex As Exception

            MessageBox.Show("GetTenant: " & ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            lReader = Nothing

            lCmd.Dispose()
            lCmd = Nothing

        End Try

        GetTenant = lTenant

    End Function


    Public Function GetAsset(pAssetID As Integer) As Asset

        Dim lAsset As Asset
        Dim lCmd As New SqlCommand
        Dim lReader As SqlDataReader

        lAsset = Nothing

        Try

            lCmd = gDBConn.CreateCommand

            lCmd.CommandText = "GetAsset"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.Add("@AssetID", SqlDbType.Int)
            lCmd.Parameters("@AssetID").Value = pAssetID

            lReader = lCmd.ExecuteReader(CommandBehavior.SingleRow)
            lReader.Read()

            If lReader.HasRows Then

                With lAsset

                    .AssetID = pAssetID
                    .AddressDesc = lReader.GetString(0)
                    .PropertyDesc = lReader.GetString(1)

                End With

            End If

        Catch ex As Exception

            MessageBox.Show("GetAsset: " & ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            lReader = Nothing

            lCmd.Dispose()
            lCmd = Nothing

        End Try

        GetAsset = lAsset

    End Function


    Public Function GetSecurityUser(pUserID As Integer) As SecurityUser

        Dim lSecurityUser As SecurityUser
        Dim lCmd As New SqlCommand
        Dim lReader As SqlDataReader

        lSecurityUser = Nothing

        Try

            lCmd = gDBConn.CreateCommand

            lCmd.CommandText = "GetSecurityUser"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.Add("@UserID", SqlDbType.Int)
            lCmd.Parameters("@UserID").Value = pUserID

            lReader = lCmd.ExecuteReader(CommandBehavior.SingleRow)
            lReader.Read()

            If lReader.HasRows Then

                With lSecurityUser

                    .UserID = pUserID
                    .FullName = lReader.GetString(0)
                    .Email = lReader.GetString(1)
                    .ActiveEmployee = lReader.GetString(2)

                End With

            End If

        Catch ex As Exception

            MessageBox.Show("GetSecurityUser: " & ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            lReader = Nothing

            lCmd.Dispose()
            lCmd = Nothing

        End Try

        GetSecurityUser = lSecurityUser

    End Function

End Class
