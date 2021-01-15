<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MeetingTimelabel = New System.Windows.Forms.Label()
        Me.Rbmeeting = New System.Windows.Forms.RadioButton()
        Me.cmdExtract = New System.Windows.Forms.Button()
        Me.LunchTimeLabel = New System.Windows.Forms.Label()
        Me.ProductiveTimeLabel = New System.Windows.Forms.Label()
        Me.rbLogOff = New System.Windows.Forms.RadioButton()
        Me.rbStartUp = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbLunchBreak = New System.Windows.Forms.RadioButton()
        Me.rbProductive = New System.Windows.Forms.RadioButton()
        Me.UsernameAdmin = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiEditUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolutionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSolutionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OnholdRequest = New System.Windows.Forms.Label()
        Me.RequestResolved = New System.Windows.Forms.Label()
        Me.lbOnhold = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbRph = New System.Windows.Forms.Label()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lbUsers = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDuedate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.txtPriority = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFname_Lname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.AnouncementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAnnouncementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnnouncementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.MeetingTimelabel)
        Me.Panel1.Controls.Add(Me.Rbmeeting)
        Me.Panel1.Controls.Add(Me.cmdExtract)
        Me.Panel1.Controls.Add(Me.LunchTimeLabel)
        Me.Panel1.Controls.Add(Me.ProductiveTimeLabel)
        Me.Panel1.Controls.Add(Me.rbLogOff)
        Me.Panel1.Controls.Add(Me.rbStartUp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rbLunchBreak)
        Me.Panel1.Controls.Add(Me.rbProductive)
        Me.Panel1.Controls.Add(Me.UsernameAdmin)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.cmdShow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 113)
        Me.Panel1.TabIndex = 6
        '
        'MeetingTimelabel
        '
        Me.MeetingTimelabel.AutoSize = True
        Me.MeetingTimelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeetingTimelabel.Location = New System.Drawing.Point(328, 92)
        Me.MeetingTimelabel.Name = "MeetingTimelabel"
        Me.MeetingTimelabel.Size = New System.Drawing.Size(16, 18)
        Me.MeetingTimelabel.TabIndex = 31
        Me.MeetingTimelabel.Text = "0"
        '
        'Rbmeeting
        '
        Me.Rbmeeting.AutoSize = True
        Me.Rbmeeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbmeeting.Location = New System.Drawing.Point(307, 72)
        Me.Rbmeeting.Name = "Rbmeeting"
        Me.Rbmeeting.Size = New System.Drawing.Size(78, 22)
        Me.Rbmeeting.TabIndex = 30
        Me.Rbmeeting.Text = "Meeting"
        Me.Rbmeeting.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        Me.cmdExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExtract.Location = New System.Drawing.Point(803, 38)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(93, 33)
        Me.cmdExtract.TabIndex = 29
        Me.cmdExtract.Text = "Extract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'LunchTimeLabel
        '
        Me.LunchTimeLabel.AutoSize = True
        Me.LunchTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LunchTimeLabel.Location = New System.Drawing.Point(217, 92)
        Me.LunchTimeLabel.Name = "LunchTimeLabel"
        Me.LunchTimeLabel.Size = New System.Drawing.Size(16, 18)
        Me.LunchTimeLabel.TabIndex = 28
        Me.LunchTimeLabel.Text = "0"
        '
        'ProductiveTimeLabel
        '
        Me.ProductiveTimeLabel.AutoSize = True
        Me.ProductiveTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductiveTimeLabel.Location = New System.Drawing.Point(120, 92)
        Me.ProductiveTimeLabel.Name = "ProductiveTimeLabel"
        Me.ProductiveTimeLabel.Size = New System.Drawing.Size(16, 18)
        Me.ProductiveTimeLabel.TabIndex = 27
        Me.ProductiveTimeLabel.Text = "0"
        '
        'rbLogOff
        '
        Me.rbLogOff.AutoSize = True
        Me.rbLogOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLogOff.Location = New System.Drawing.Point(386, 72)
        Me.rbLogOff.Name = "rbLogOff"
        Me.rbLogOff.Size = New System.Drawing.Size(71, 22)
        Me.rbLogOff.TabIndex = 26
        Me.rbLogOff.Text = "LogOff"
        Me.rbLogOff.UseVisualStyleBackColor = True
        '
        'rbStartUp
        '
        Me.rbStartUp.AutoSize = True
        Me.rbStartUp.Checked = True
        Me.rbStartUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStartUp.Location = New System.Drawing.Point(11, 72)
        Me.rbStartUp.Name = "rbStartUp"
        Me.rbStartUp.Size = New System.Drawing.Size(73, 22)
        Me.rbStartUp.TabIndex = 25
        Me.rbStartUp.TabStop = True
        Me.rbStartUp.Text = "Startup"
        Me.rbStartUp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(611, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "My Summary"
        '
        'rbLunchBreak
        '
        Me.rbLunchBreak.AutoSize = True
        Me.rbLunchBreak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLunchBreak.Location = New System.Drawing.Point(192, 72)
        Me.rbLunchBreak.Name = "rbLunchBreak"
        Me.rbLunchBreak.Size = New System.Drawing.Size(109, 22)
        Me.rbLunchBreak.TabIndex = 24
        Me.rbLunchBreak.Text = "Lunch Break"
        Me.rbLunchBreak.UseVisualStyleBackColor = True
        '
        'rbProductive
        '
        Me.rbProductive.AutoSize = True
        Me.rbProductive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProductive.Location = New System.Drawing.Point(90, 72)
        Me.rbProductive.Name = "rbProductive"
        Me.rbProductive.Size = New System.Drawing.Size(96, 22)
        Me.rbProductive.TabIndex = 23
        Me.rbProductive.Text = "Productive"
        Me.rbProductive.UseVisualStyleBackColor = True
        '
        'UsernameAdmin
        '
        Me.UsernameAdmin.AutoSize = True
        Me.UsernameAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameAdmin.ForeColor = System.Drawing.Color.Silver
        Me.UsernameAdmin.Location = New System.Drawing.Point(6, 34)
        Me.UsernameAdmin.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.UsernameAdmin.Name = "UsernameAdmin"
        Me.UsernameAdmin.Size = New System.Drawing.Size(144, 31)
        Me.UsernameAdmin.TabIndex = 0
        Me.UsernameAdmin.Text = "UserName"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ManageUserToolStripMenuItem, Me.SolutionsToolStripMenuItem, Me.AnouncementToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiNewUser, Me.msiDeleteUser, Me.msiEditUser})
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ManageUserToolStripMenuItem.Text = "Manage users"
        '
        'msiNewUser
        '
        Me.msiNewUser.Name = "msiNewUser"
        Me.msiNewUser.Size = New System.Drawing.Size(132, 22)
        Me.msiNewUser.Text = "New user"
        '
        'msiDeleteUser
        '
        Me.msiDeleteUser.Name = "msiDeleteUser"
        Me.msiDeleteUser.Size = New System.Drawing.Size(132, 22)
        Me.msiDeleteUser.Text = "Delete user"
        '
        'msiEditUser
        '
        Me.msiEditUser.Name = "msiEditUser"
        Me.msiEditUser.Size = New System.Drawing.Size(132, 22)
        Me.msiEditUser.Text = "Edit user"
        '
        'SolutionsToolStripMenuItem
        '
        Me.SolutionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateSolutionToolStripMenuItem, Me.UpdateSolutionToolStripMenuItem1})
        Me.SolutionsToolStripMenuItem.Name = "SolutionsToolStripMenuItem"
        Me.SolutionsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SolutionsToolStripMenuItem.Text = "Solutions"
        '
        'UpdateSolutionToolStripMenuItem
        '
        Me.UpdateSolutionToolStripMenuItem.Name = "UpdateSolutionToolStripMenuItem"
        Me.UpdateSolutionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateSolutionToolStripMenuItem.Text = "Create Solution"
        '
        'UpdateSolutionToolStripMenuItem1
        '
        Me.UpdateSolutionToolStripMenuItem1.Name = "UpdateSolutionToolStripMenuItem1"
        Me.UpdateSolutionToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UpdateSolutionToolStripMenuItem1.Text = "Update Solution"
        '
        'cmdShow
        '
        Me.cmdShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShow.Location = New System.Drawing.Point(915, 38)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(95, 33)
        Me.cmdShow.TabIndex = 3
        Me.cmdShow.Text = "Show All"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.OnholdRequest)
        Me.Panel2.Controls.Add(Me.RequestResolved)
        Me.Panel2.Controls.Add(Me.lbOnhold)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 632)
        Me.Panel2.TabIndex = 7
        '
        'OnholdRequest
        '
        Me.OnholdRequest.AutoSize = True
        Me.OnholdRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnholdRequest.Location = New System.Drawing.Point(170, 66)
        Me.OnholdRequest.Name = "OnholdRequest"
        Me.OnholdRequest.Size = New System.Drawing.Size(16, 18)
        Me.OnholdRequest.TabIndex = 31
        Me.OnholdRequest.Text = "0"
        '
        'RequestResolved
        '
        Me.RequestResolved.AutoSize = True
        Me.RequestResolved.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestResolved.Location = New System.Drawing.Point(170, 24)
        Me.RequestResolved.Name = "RequestResolved"
        Me.RequestResolved.Size = New System.Drawing.Size(16, 18)
        Me.RequestResolved.TabIndex = 30
        Me.RequestResolved.Text = "0"
        '
        'lbOnhold
        '
        Me.lbOnhold.FormattingEnabled = True
        Me.lbOnhold.Location = New System.Drawing.Point(17, 121)
        Me.lbOnhold.Name = "lbOnhold"
        Me.lbOnhold.Size = New System.Drawing.Size(144, 472)
        Me.lbOnhold.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Onhold Requests"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Requests Resolved"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lbRph)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.txtFilter)
        Me.Panel3.Controls.Add(Me.lbUsers)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(822, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 632)
        Me.Panel3.TabIndex = 8
        '
        'lbRph
        '
        Me.lbRph.AutoSize = True
        Me.lbRph.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRph.Location = New System.Drawing.Point(107, 80)
        Me.lbRph.Name = "lbRph"
        Me.lbRph.Size = New System.Drawing.Size(16, 18)
        Me.lbRph.TabIndex = 32
        Me.lbRph.Text = "0"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdRefresh.Location = New System.Drawing.Point(10, 67)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(91, 31)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "Get Work"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Location = New System.Drawing.Point(16, 30)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(172, 20)
        Me.txtFilter.TabIndex = 3
        '
        'lbUsers
        '
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(16, 109)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(172, 485)
        Me.lbUsers.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "My Task"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtCategory)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtDuedate)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtDepartment)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txtNotes)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.cmdSave)
        Me.Panel4.Controls.Add(Me.txtStatus)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.txtSite)
        Me.Panel4.Controls.Add(Me.txtPriority)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtDescription)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtSubject)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.txtFname_Lname)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 113)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(622, 632)
        Me.Panel4.TabIndex = 9
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(103, 167)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(224, 26)
        Me.txtCategory.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Category"
        '
        'txtDuedate
        '
        Me.txtDuedate.Enabled = False
        Me.txtDuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuedate.Location = New System.Drawing.Point(442, 80)
        Me.txtDuedate.MaxLength = 30
        Me.txtDuedate.Name = "txtDuedate"
        Me.txtDuedate.Size = New System.Drawing.Size(170, 26)
        Me.txtDuedate.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Due by Date"
        '
        'txtDepartment
        '
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(103, 121)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(224, 26)
        Me.txtDepartment.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 20)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Department"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(39, 527)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 20)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(103, 524)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(307, 96)
        Me.txtNotes.TabIndex = 42
        Me.txtNotes.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Member Details"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(103, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(52, 26)
        Me.txtID.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Ticket ID"
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(16, 574)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 29)
        Me.cmdSave.TabIndex = 38
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.FormattingEnabled = True
        Me.txtStatus.Items.AddRange(New Object() {"Resolved", "Open", "Onhold"})
        Me.txtStatus.Location = New System.Drawing.Point(103, 482)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(307, 28)
        Me.txtStatus.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 490)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 20)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "*Status"
        '
        'txtSite
        '
        Me.txtSite.Enabled = False
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.Location = New System.Drawing.Point(103, 450)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.ReadOnly = True
        Me.txtSite.Size = New System.Drawing.Size(307, 26)
        Me.txtSite.TabIndex = 34
        '
        'txtPriority
        '
        Me.txtPriority.Enabled = False
        Me.txtPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriority.Location = New System.Drawing.Point(103, 210)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.ReadOnly = True
        Me.txtPriority.Size = New System.Drawing.Size(224, 26)
        Me.txtPriority.TabIndex = 33
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(283, 40)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(333, 26)
        Me.txtEmail.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(219, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "*Site"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(103, 287)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(373, 157)
        Me.txtDescription.TabIndex = 28
        Me.txtDescription.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Description"
        '
        'txtSubject
        '
        Me.txtSubject.Enabled = False
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(103, 255)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(373, 26)
        Me.txtSubject.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Complain"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Priority"
        '
        'txtFname_Lname
        '
        Me.txtFname_Lname.Enabled = False
        Me.txtFname_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname_Lname.Location = New System.Drawing.Point(103, 80)
        Me.txtFname_Lname.Name = "txtFname_Lname"
        Me.txtFname_Lname.Size = New System.Drawing.Size(224, 26)
        Me.txtFname_Lname.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "*Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1000
        '
        'AnouncementToolStripMenuItem
        '
        Me.AnouncementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateAnnouncementToolStripMenuItem, Me.UpdateAnnouncementToolStripMenuItem})
        Me.AnouncementToolStripMenuItem.Name = "AnouncementToolStripMenuItem"
        Me.AnouncementToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.AnouncementToolStripMenuItem.Text = "Announcement"
        '
        'CreateAnnouncementToolStripMenuItem
        '
        Me.CreateAnnouncementToolStripMenuItem.Name = "CreateAnnouncementToolStripMenuItem"
        Me.CreateAnnouncementToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CreateAnnouncementToolStripMenuItem.Text = "Create Announcement"
        '
        'UpdateAnnouncementToolStripMenuItem
        '
        Me.UpdateAnnouncementToolStripMenuItem.Name = "UpdateAnnouncementToolStripMenuItem"
        Me.UpdateAnnouncementToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UpdateAnnouncementToolStripMenuItem.Text = "Update Announcement"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1022, 745)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UsernameAdmin As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbProductive As RadioButton
    Friend WithEvents rbLunchBreak As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdShow As Button
    Friend WithEvents rbLogOff As RadioButton
    Friend WithEvents rbStartUp As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProductiveTimeLabel As Label
    Friend WithEvents LunchTimeLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ManageUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msiNewUser As ToolStripMenuItem
    Friend WithEvents msiDeleteUser As ToolStripMenuItem
    Friend WithEvents msiEditUser As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFname_Lname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSite As TextBox
    Friend WithEvents txtPriority As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStatus As ComboBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lbUsers As ListBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdExtract As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lbOnhold As ListBox
    Friend WithEvents OnholdRequest As Label
    Friend WithEvents RequestResolved As Label
    Friend WithEvents Rbmeeting As RadioButton
    Friend WithEvents MeetingTimelabel As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents lbRph As Label
    Friend WithEvents txtDuedate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SolutionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateSolutionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateSolutionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AnouncementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAnnouncementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnnouncementToolStripMenuItem As ToolStripMenuItem
End Class
