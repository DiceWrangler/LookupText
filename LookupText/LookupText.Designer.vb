<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LookupText
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.lblTenantName = New System.Windows.Forms.Label()
        Me.txtTenantName = New System.Windows.Forms.TextBox()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.lblCellPhone = New System.Windows.Forms.Label()
        Me.txtPrimaryEmail = New System.Windows.Forms.TextBox()
        Me.lblPrimaryEmail = New System.Windows.Forms.Label()
        Me.txtMessageSent = New System.Windows.Forms.TextBox()
        Me.lblMessageSent = New System.Windows.Forms.Label()
        Me.txtSubjectLine = New System.Windows.Forms.TextBox()
        Me.lblSubjectLine = New System.Windows.Forms.Label()
        Me.txtBodyText = New System.Windows.Forms.TextBox()
        Me.lblBodyText = New System.Windows.Forms.Label()
        Me.lblAddressDesc = New System.Windows.Forms.Label()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.txtProperty = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.grpMessage = New System.Windows.Forms.GroupBox()
        Me.txtSentByEmail = New System.Windows.Forms.TextBox()
        Me.lblSentByEmail = New System.Windows.Forms.Label()
        Me.txtSentByName = New System.Windows.Forms.TextBox()
        Me.lblSentByName = New System.Windows.Forms.Label()
        Me.grpTenant = New System.Windows.Forms.GroupBox()
        Me.grpAsset = New System.Windows.Forms.GroupBox()
        Me.btnToClipboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSentMessages = New System.Windows.Forms.ListBox()
        Me.grpMessage.SuspendLayout()
        Me.grpTenant.SuspendLayout()
        Me.grpAsset.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(144, 24)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(218, 20)
        Me.txtEmailAddress.TabIndex = 0
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(24, 28)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(117, 13)
        Me.lblEmailAddress.TabIndex = 1
        Me.lblEmailAddress.Text = "Partial TextTo Address:"
        '
        'btnLookup
        '
        Me.btnLookup.FlatAppearance.BorderSize = 2
        Me.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookup.Location = New System.Drawing.Point(408, 21)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnLookup.TabIndex = 2
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'lblTenantName
        '
        Me.lblTenantName.AutoSize = True
        Me.lblTenantName.Location = New System.Drawing.Point(6, 19)
        Me.lblTenantName.Name = "lblTenantName"
        Me.lblTenantName.Size = New System.Drawing.Size(75, 13)
        Me.lblTenantName.TabIndex = 3
        Me.lblTenantName.Text = "Tenant Name:"
        '
        'txtTenantName
        '
        Me.txtTenantName.BackColor = System.Drawing.SystemColors.Info
        Me.txtTenantName.Location = New System.Drawing.Point(88, 15)
        Me.txtTenantName.Name = "txtTenantName"
        Me.txtTenantName.ReadOnly = True
        Me.txtTenantName.Size = New System.Drawing.Size(216, 20)
        Me.txtTenantName.TabIndex = 4
        '
        'txtCellPhone
        '
        Me.txtCellPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtCellPhone.Location = New System.Drawing.Point(88, 41)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.ReadOnly = True
        Me.txtCellPhone.Size = New System.Drawing.Size(216, 20)
        Me.txtCellPhone.TabIndex = 6
        '
        'lblCellPhone
        '
        Me.lblCellPhone.AutoSize = True
        Me.lblCellPhone.Location = New System.Drawing.Point(6, 45)
        Me.lblCellPhone.Name = "lblCellPhone"
        Me.lblCellPhone.Size = New System.Drawing.Size(61, 13)
        Me.lblCellPhone.TabIndex = 5
        Me.lblCellPhone.Text = "Cell Phone:"
        '
        'txtPrimaryEmail
        '
        Me.txtPrimaryEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrimaryEmail.Location = New System.Drawing.Point(88, 67)
        Me.txtPrimaryEmail.Name = "txtPrimaryEmail"
        Me.txtPrimaryEmail.ReadOnly = True
        Me.txtPrimaryEmail.Size = New System.Drawing.Size(216, 20)
        Me.txtPrimaryEmail.TabIndex = 8
        '
        'lblPrimaryEmail
        '
        Me.lblPrimaryEmail.AutoSize = True
        Me.lblPrimaryEmail.Location = New System.Drawing.Point(6, 67)
        Me.lblPrimaryEmail.Name = "lblPrimaryEmail"
        Me.lblPrimaryEmail.Size = New System.Drawing.Size(72, 13)
        Me.lblPrimaryEmail.TabIndex = 7
        Me.lblPrimaryEmail.Text = "Primary Email:"
        '
        'txtMessageSent
        '
        Me.txtMessageSent.BackColor = System.Drawing.SystemColors.Info
        Me.txtMessageSent.Location = New System.Drawing.Point(101, 220)
        Me.txtMessageSent.Name = "txtMessageSent"
        Me.txtMessageSent.ReadOnly = True
        Me.txtMessageSent.Size = New System.Drawing.Size(218, 20)
        Me.txtMessageSent.TabIndex = 10
        '
        'lblMessageSent
        '
        Me.lblMessageSent.AutoSize = True
        Me.lblMessageSent.Location = New System.Drawing.Point(24, 224)
        Me.lblMessageSent.Name = "lblMessageSent"
        Me.lblMessageSent.Size = New System.Drawing.Size(78, 13)
        Me.lblMessageSent.TabIndex = 9
        Me.lblMessageSent.Text = "Message Sent:"
        '
        'txtSubjectLine
        '
        Me.txtSubjectLine.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectLine.Location = New System.Drawing.Point(101, 247)
        Me.txtSubjectLine.Name = "txtSubjectLine"
        Me.txtSubjectLine.ReadOnly = True
        Me.txtSubjectLine.Size = New System.Drawing.Size(218, 20)
        Me.txtSubjectLine.TabIndex = 12
        '
        'lblSubjectLine
        '
        Me.lblSubjectLine.AutoSize = True
        Me.lblSubjectLine.Location = New System.Drawing.Point(24, 251)
        Me.lblSubjectLine.Name = "lblSubjectLine"
        Me.lblSubjectLine.Size = New System.Drawing.Size(69, 13)
        Me.lblSubjectLine.TabIndex = 11
        Me.lblSubjectLine.Text = "Subject Line:"
        '
        'txtBodyText
        '
        Me.txtBodyText.BackColor = System.Drawing.SystemColors.Info
        Me.txtBodyText.Location = New System.Drawing.Point(88, 71)
        Me.txtBodyText.Multiline = True
        Me.txtBodyText.Name = "txtBodyText"
        Me.txtBodyText.ReadOnly = True
        Me.txtBodyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBodyText.Size = New System.Drawing.Size(538, 65)
        Me.txtBodyText.TabIndex = 14
        '
        'lblBodyText
        '
        Me.lblBodyText.AutoSize = True
        Me.lblBodyText.Location = New System.Drawing.Point(24, 297)
        Me.lblBodyText.Name = "lblBodyText"
        Me.lblBodyText.Size = New System.Drawing.Size(58, 13)
        Me.lblBodyText.TabIndex = 13
        Me.lblBodyText.Text = "Body Text:"
        '
        'lblAddressDesc
        '
        Me.lblAddressDesc.AutoSize = True
        Me.lblAddressDesc.Location = New System.Drawing.Point(4, 45)
        Me.lblAddressDesc.Name = "lblAddressDesc"
        Me.lblAddressDesc.Size = New System.Drawing.Size(48, 13)
        Me.lblAddressDesc.TabIndex = 15
        Me.lblAddressDesc.Text = "Address:"
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(4, 19)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(49, 13)
        Me.lblProperty.TabIndex = 16
        Me.lblProperty.Text = "Property:"
        '
        'txtProperty
        '
        Me.txtProperty.BackColor = System.Drawing.SystemColors.Info
        Me.txtProperty.Location = New System.Drawing.Point(79, 15)
        Me.txtProperty.Name = "txtProperty"
        Me.txtProperty.ReadOnly = True
        Me.txtProperty.Size = New System.Drawing.Size(216, 20)
        Me.txtProperty.TabIndex = 18
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(79, 41)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(216, 20)
        Me.txtAddress.TabIndex = 17
        '
        'grpMessage
        '
        Me.grpMessage.Controls.Add(Me.txtSentByEmail)
        Me.grpMessage.Controls.Add(Me.lblSentByEmail)
        Me.grpMessage.Controls.Add(Me.txtSentByName)
        Me.grpMessage.Controls.Add(Me.lblSentByName)
        Me.grpMessage.Controls.Add(Me.txtBodyText)
        Me.grpMessage.Location = New System.Drawing.Point(12, 204)
        Me.grpMessage.Name = "grpMessage"
        Me.grpMessage.Size = New System.Drawing.Size(640, 152)
        Me.grpMessage.TabIndex = 19
        Me.grpMessage.TabStop = False
        Me.grpMessage.Text = "Last Message Sent"
        '
        'txtSentByEmail
        '
        Me.txtSentByEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtSentByEmail.Location = New System.Drawing.Point(408, 43)
        Me.txtSentByEmail.Name = "txtSentByEmail"
        Me.txtSentByEmail.ReadOnly = True
        Me.txtSentByEmail.Size = New System.Drawing.Size(218, 20)
        Me.txtSentByEmail.TabIndex = 18
        '
        'lblSentByEmail
        '
        Me.lblSentByEmail.AutoSize = True
        Me.lblSentByEmail.Location = New System.Drawing.Point(314, 47)
        Me.lblSentByEmail.Name = "lblSentByEmail"
        Me.lblSentByEmail.Size = New System.Drawing.Size(75, 13)
        Me.lblSentByEmail.TabIndex = 17
        Me.lblSentByEmail.Text = "Sent By Email:"
        '
        'txtSentByName
        '
        Me.txtSentByName.BackColor = System.Drawing.SystemColors.Info
        Me.txtSentByName.Location = New System.Drawing.Point(408, 16)
        Me.txtSentByName.Name = "txtSentByName"
        Me.txtSentByName.ReadOnly = True
        Me.txtSentByName.Size = New System.Drawing.Size(218, 20)
        Me.txtSentByName.TabIndex = 16
        '
        'lblSentByName
        '
        Me.lblSentByName.AutoSize = True
        Me.lblSentByName.Location = New System.Drawing.Point(314, 20)
        Me.lblSentByName.Name = "lblSentByName"
        Me.lblSentByName.Size = New System.Drawing.Size(78, 13)
        Me.lblSentByName.TabIndex = 15
        Me.lblSentByName.Text = "Sent By Name:"
        '
        'grpTenant
        '
        Me.grpTenant.Controls.Add(Me.txtPrimaryEmail)
        Me.grpTenant.Controls.Add(Me.txtTenantName)
        Me.grpTenant.Controls.Add(Me.txtCellPhone)
        Me.grpTenant.Controls.Add(Me.lblPrimaryEmail)
        Me.grpTenant.Controls.Add(Me.lblTenantName)
        Me.grpTenant.Controls.Add(Me.lblCellPhone)
        Me.grpTenant.Location = New System.Drawing.Point(12, 357)
        Me.grpTenant.Name = "grpTenant"
        Me.grpTenant.Size = New System.Drawing.Size(325, 100)
        Me.grpTenant.TabIndex = 20
        Me.grpTenant.TabStop = False
        Me.grpTenant.Text = "Tenant"
        '
        'grpAsset
        '
        Me.grpAsset.Controls.Add(Me.txtProperty)
        Me.grpAsset.Controls.Add(Me.lblAddressDesc)
        Me.grpAsset.Controls.Add(Me.lblProperty)
        Me.grpAsset.Controls.Add(Me.txtAddress)
        Me.grpAsset.Location = New System.Drawing.Point(343, 357)
        Me.grpAsset.Name = "grpAsset"
        Me.grpAsset.Size = New System.Drawing.Size(310, 100)
        Me.grpAsset.TabIndex = 21
        Me.grpAsset.TabStop = False
        Me.grpAsset.Text = "Property"
        '
        'btnToClipboard
        '
        Me.btnToClipboard.Location = New System.Drawing.Point(514, 21)
        Me.btnToClipboard.Name = "btnToClipboard"
        Me.btnToClipboard.Size = New System.Drawing.Size(75, 23)
        Me.btnToClipboard.TabIndex = 22
        Me.btnToClipboard.Text = "To Clipboard"
        Me.btnToClipboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Full TextTo Address:"
        '
        'txtFullEmailAddress
        '
        Me.txtFullEmailAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtFullEmailAddress.Location = New System.Drawing.Point(144, 175)
        Me.txtFullEmailAddress.Name = "txtFullEmailAddress"
        Me.txtFullEmailAddress.ReadOnly = True
        Me.txtFullEmailAddress.Size = New System.Drawing.Size(218, 20)
        Me.txtFullEmailAddress.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(603, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "v180907"
        '
        'lbSentMessages
        '
        Me.lbSentMessages.FormattingEnabled = True
        Me.lbSentMessages.Location = New System.Drawing.Point(27, 65)
        Me.lbSentMessages.Name = "lbSentMessages"
        Me.lbSentMessages.Size = New System.Drawing.Size(611, 95)
        Me.lbSentMessages.TabIndex = 26
        '
        'LookupText
        '
        Me.AcceptButton = Me.btnLookup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 466)
        Me.Controls.Add(Me.lbSentMessages)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFullEmailAddress)
        Me.Controls.Add(Me.btnToClipboard)
        Me.Controls.Add(Me.grpAsset)
        Me.Controls.Add(Me.grpTenant)
        Me.Controls.Add(Me.lblBodyText)
        Me.Controls.Add(Me.txtSubjectLine)
        Me.Controls.Add(Me.lblSubjectLine)
        Me.Controls.Add(Me.txtMessageSent)
        Me.Controls.Add(Me.lblMessageSent)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.grpMessage)
        Me.Name = "LookupText"
        Me.Text = "LookupText"
        Me.grpMessage.ResumeLayout(False)
        Me.grpMessage.PerformLayout()
        Me.grpTenant.ResumeLayout(False)
        Me.grpTenant.PerformLayout()
        Me.grpAsset.ResumeLayout(False)
        Me.grpAsset.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents btnLookup As Button
    Friend WithEvents lblTenantName As Label
    Friend WithEvents txtTenantName As TextBox
    Friend WithEvents txtCellPhone As TextBox
    Friend WithEvents lblCellPhone As Label
    Friend WithEvents txtPrimaryEmail As TextBox
    Friend WithEvents lblPrimaryEmail As Label
    Friend WithEvents txtMessageSent As TextBox
    Friend WithEvents lblMessageSent As Label
    Friend WithEvents txtSubjectLine As TextBox
    Friend WithEvents lblSubjectLine As Label
    Friend WithEvents txtBodyText As TextBox
    Friend WithEvents lblBodyText As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents lblAddressDesc As Label
    Friend WithEvents lblProperty As Label
    Friend WithEvents txtProperty As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents grpMessage As GroupBox
    Friend WithEvents grpTenant As GroupBox
    Friend WithEvents grpAsset As GroupBox
    Friend WithEvents txtSentByEmail As TextBox
    Friend WithEvents lblSentByEmail As Label
    Friend WithEvents txtSentByName As TextBox
    Friend WithEvents lblSentByName As Label
    Friend WithEvents btnToClipboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullEmailAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbSentMessages As ListBox
End Class
