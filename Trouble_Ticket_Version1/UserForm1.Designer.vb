<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.UserName1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDepartment = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPriority = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMemberConfirmation = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFeedback = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lbPending = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDuedate = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Welcome)
        Me.Panel1.Controls.Add(Me.UserName1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 65)
        Me.Panel1.TabIndex = 1
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.Location = New System.Drawing.Point(17, 11)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(75, 20)
        Me.Welcome.TabIndex = 2
        Me.Welcome.Text = "Welcome"
        '
        'UserName1
        '
        Me.UserName1.AutoSize = True
        Me.UserName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName1.ForeColor = System.Drawing.Color.Silver
        Me.UserName1.Location = New System.Drawing.Point(15, 31)
        Me.UserName1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.UserName1.Name = "UserName1"
        Me.UserName1.Size = New System.Drawing.Size(144, 31)
        Me.UserName1.TabIndex = 1
        Me.UserName1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "My request Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pending"
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Enabled = False
        Me.TxtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartment.FormattingEnabled = True
        Me.TxtDepartment.Items.AddRange(New Object() {"Admin", "Compliance", "Communication", "Engineering", "Finance", "H.R.", "I.T.", "Legal", "Marketing", "Office of the President", "Purchasing", "Risk Management"})
        Me.TxtDepartment.Location = New System.Drawing.Point(343, 172)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(284, 28)
        Me.TxtDepartment.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(232, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Department"
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Items.AddRange(New Object() {"Desktop Hardware", "General", "Internet", "Netwok", "Operating System", "Printers", "Software"})
        Me.txtCategory.Location = New System.Drawing.Point(343, 217)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(284, 28)
        Me.txtCategory.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Category"
        '
        'txtSite
        '
        Me.txtSite.Enabled = False
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.FormattingEnabled = True
        Me.txtSite.Items.AddRange(New Object() {"Makati Office", "Minsesite Office", "Butuan Office"})
        Me.txtSite.Location = New System.Drawing.Point(343, 481)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(284, 28)
        Me.txtSite.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "*Site"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(343, 342)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(475, 116)
        Me.txtDescription.TabIndex = 30
        Me.txtDescription.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Description"
        '
        'txtSubject
        '
        Me.txtSubject.Enabled = False
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(343, 303)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(475, 26)
        Me.txtSubject.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(257, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "*Subject"
        '
        'txtPriority
        '
        Me.txtPriority.Enabled = False
        Me.txtPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriority.FormattingEnabled = True
        Me.txtPriority.Items.AddRange(New Object() {"High", "Low", "Medium", "Normal"})
        Me.txtPriority.Location = New System.Drawing.Point(343, 257)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(284, 28)
        Me.txtPriority.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Priority"
        '
        'txtMemberConfirmation
        '
        Me.txtMemberConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberConfirmation.FormattingEnabled = True
        Me.txtMemberConfirmation.Items.AddRange(New Object() {"Resolved", "Open", "Onhold"})
        Me.txtMemberConfirmation.Location = New System.Drawing.Point(343, 525)
        Me.txtMemberConfirmation.Name = "txtMemberConfirmation"
        Me.txtMemberConfirmation.Size = New System.Drawing.Size(284, 28)
        Me.txtMemberConfirmation.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(260, 533)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "*Status "
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(257, 611)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 29)
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(253, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Ticket ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(343, 91)
        Me.txtID.MaxLength = 30
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(69, 26)
        Me.txtID.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Member Details"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(246, 588)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Feedback"
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(343, 571)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(284, 96)
        Me.txtFeedback.TabIndex = 45
        Me.txtFeedback.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(269, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "*Name"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(343, 130)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(284, 26)
        Me.txtName.TabIndex = 24
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(37, 102)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(78, 23)
        Me.cmdRefresh.TabIndex = 46
        Me.cmdRefresh.Text = "Refresh List"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'lbPending
        '
        Me.lbPending.FormattingEnabled = True
        Me.lbPending.Location = New System.Drawing.Point(32, 172)
        Me.lbPending.Name = "lbPending"
        Me.lbPending.Size = New System.Drawing.Size(172, 381)
        Me.lbPending.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(537, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 20)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Due by Date"
        '
        'txtDuedate
        '
        Me.txtDuedate.Enabled = False
        Me.txtDuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuedate.Location = New System.Drawing.Point(641, 88)
        Me.txtDuedate.MaxLength = 30
        Me.txtDuedate.Name = "txtDuedate"
        Me.txtDuedate.Size = New System.Drawing.Size(177, 26)
        Me.txtDuedate.TabIndex = 49
        '
        'UserForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 668)
        Me.Controls.Add(Me.txtDuedate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbPending)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtMemberConfirmation)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtDepartment)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserForm1"
        Me.Text = "UserForm1"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserName1 As Label
    Friend WithEvents TxtDepartment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSite As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPriority As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMemberConfirmation As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFeedback As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Welcome As Label
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents lbPending As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDuedate As TextBox
End Class
