<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requester
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
        Dim lb2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requester))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolutionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindSolutionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lbl5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lbl7 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl9 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.RichTextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdRequestStatus = New System.Windows.Forms.Button()
        Me.cmdOthers = New System.Windows.Forms.Button()
        Me.cmdSoftware = New System.Windows.Forms.Button()
        Me.cmdInternet = New System.Windows.Forms.Button()
        Me.cmdHardware = New System.Windows.Forms.Button()
        Me.cmdEmail = New System.Windows.Forms.Button()
        Me.cmdCommunication = New System.Windows.Forms.Button()
        lb2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb2
        '
        lb2.AutoSize = True
        lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb2.Location = New System.Drawing.Point(230, 67)
        lb2.Name = "lb2"
        lb2.Size = New System.Drawing.Size(0, 18)
        lb2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdToolStripMenuItem, Me.RequestToolStripMenuItem, Me.SolutionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1052, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdToolStripMenuItem
        '
        Me.AdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmChangePassword, Me.UserToolStripMenuItem})
        Me.AdToolStripMenuItem.Name = "AdToolStripMenuItem"
        Me.AdToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AdToolStripMenuItem.Text = "Home"
        '
        'tsmChangePassword
        '
        Me.tsmChangePassword.Name = "tsmChangePassword"
        Me.tsmChangePassword.Size = New System.Drawing.Size(168, 22)
        Me.tsmChangePassword.Text = "Change Password"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UserToolStripMenuItem.Text = "Log Out"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'SolutionsToolStripMenuItem
        '
        Me.SolutionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindSolutionsToolStripMenuItem})
        Me.SolutionsToolStripMenuItem.Name = "SolutionsToolStripMenuItem"
        Me.SolutionsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SolutionsToolStripMenuItem.Text = "Solutions"
        '
        'FindSolutionsToolStripMenuItem
        '
        Me.FindSolutionsToolStripMenuItem.Name = "FindSolutionsToolStripMenuItem"
        Me.FindSolutionsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.FindSolutionsToolStripMenuItem.Text = "Find Solutions"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.cmdRequestStatus)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdOthers)
        Me.Panel1.Controls.Add(Me.cmdSoftware)
        Me.Panel1.Controls.Add(Me.cmdInternet)
        Me.Panel1.Controls.Add(Me.cmdHardware)
        Me.Panel1.Controls.Add(Me.cmdEmail)
        Me.Panel1.Controls.Add(Me.cmdCommunication)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 695)
        Me.Panel1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Trouble Ticket System"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl1)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 65)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 14)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(35, 22)
        Me.lbl1.TabIndex = 4
        Me.lbl1.TabStop = True
        Me.lbl1.Text = "1"
        Me.lbl1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl3)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(630, 65)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(6, 15)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(35, 22)
        Me.Lbl3.TabIndex = 5
        Me.Lbl3.TabStop = True
        Me.Lbl3.Text = "3"
        Me.Lbl3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Lbl5)
        Me.GroupBox4.Location = New System.Drawing.Point(224, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(630, 65)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(6, 12)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(35, 22)
        Me.Lbl5.TabIndex = 6
        Me.Lbl5.TabStop = True
        Me.Lbl5.Text = "5"
        Me.Lbl5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Lbl7)
        Me.GroupBox5.Location = New System.Drawing.Point(224, 227)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(630, 65)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(6, 18)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(35, 22)
        Me.Lbl7.TabIndex = 7
        Me.Lbl7.TabStop = True
        Me.Lbl7.Text = "7"
        Me.Lbl7.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl9)
        Me.GroupBox6.Location = New System.Drawing.Point(224, 292)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(630, 65)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(6, 13)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(35, 22)
        Me.lbl9.TabIndex = 8
        Me.lbl9.TabStop = True
        Me.lbl9.Text = "9"
        Me.lbl9.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(468, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "One request at a time, otherwise your previous request will be on hold."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(505, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please choose trouble/complaints from the button on the left pane"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 115)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtContent)
        Me.GroupBox7.Controls.Add(Me.txtTitle)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(224, 363)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(828, 334)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(22, 49)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(0, 18)
        Me.txtTitle.TabIndex = 11
        '
        'txtContent
        '
        Me.txtContent.Enabled = False
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(9, 98)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(805, 212)
        Me.txtContent.TabIndex = 12
        Me.txtContent.Text = "There are no new announcements today."
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = CType(resources.GetObject("GroupBox8.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox8.Location = New System.Drawing.Point(860, 27)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(178, 115)
        Me.GroupBox8.TabIndex = 16
        Me.GroupBox8.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.Trouble_Ticket_Version1.My.Resources.Resources.Screenshot_1
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "          Announcement"
        '
        'cmdRequestStatus
        '
        Me.cmdRequestStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRequestStatus.Image = Global.Trouble_Ticket_Version1.My.Resources.Resources.Screenshot_21
        Me.cmdRequestStatus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmdRequestStatus.Location = New System.Drawing.Point(27, 488)
        Me.cmdRequestStatus.Name = "cmdRequestStatus"
        Me.cmdRequestStatus.Size = New System.Drawing.Size(151, 43)
        Me.cmdRequestStatus.TabIndex = 9
        Me.cmdRequestStatus.Text = "        Request Status"
        Me.cmdRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRequestStatus.UseVisualStyleBackColor = True
        '
        'cmdOthers
        '
        Me.cmdOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOthers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOthers.Image = CType(resources.GetObject("cmdOthers.Image"), System.Drawing.Image)
        Me.cmdOthers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOthers.Location = New System.Drawing.Point(27, 388)
        Me.cmdOthers.Name = "cmdOthers"
        Me.cmdOthers.Size = New System.Drawing.Size(151, 43)
        Me.cmdOthers.TabIndex = 7
        Me.cmdOthers.Text = "Others"
        Me.cmdOthers.UseVisualStyleBackColor = True
        '
        'cmdSoftware
        '
        Me.cmdSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSoftware.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSoftware.Image = CType(resources.GetObject("cmdSoftware.Image"), System.Drawing.Image)
        Me.cmdSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSoftware.Location = New System.Drawing.Point(27, 325)
        Me.cmdSoftware.Name = "cmdSoftware"
        Me.cmdSoftware.Size = New System.Drawing.Size(151, 42)
        Me.cmdSoftware.TabIndex = 6
        Me.cmdSoftware.Text = "Software"
        Me.cmdSoftware.UseVisualStyleBackColor = True
        '
        'cmdInternet
        '
        Me.cmdInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInternet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdInternet.Image = CType(resources.GetObject("cmdInternet.Image"), System.Drawing.Image)
        Me.cmdInternet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInternet.Location = New System.Drawing.Point(27, 265)
        Me.cmdInternet.Name = "cmdInternet"
        Me.cmdInternet.Size = New System.Drawing.Size(151, 41)
        Me.cmdInternet.TabIndex = 5
        Me.cmdInternet.Text = "Internet"
        Me.cmdInternet.UseVisualStyleBackColor = True
        '
        'cmdHardware
        '
        Me.cmdHardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHardware.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdHardware.Image = CType(resources.GetObject("cmdHardware.Image"), System.Drawing.Image)
        Me.cmdHardware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHardware.Location = New System.Drawing.Point(27, 204)
        Me.cmdHardware.Name = "cmdHardware"
        Me.cmdHardware.Size = New System.Drawing.Size(151, 43)
        Me.cmdHardware.TabIndex = 4
        Me.cmdHardware.Text = "Hardware"
        Me.cmdHardware.UseVisualStyleBackColor = True
        '
        'cmdEmail
        '
        Me.cmdEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdEmail.Image = CType(resources.GetObject("cmdEmail.Image"), System.Drawing.Image)
        Me.cmdEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEmail.Location = New System.Drawing.Point(27, 143)
        Me.cmdEmail.Name = "cmdEmail"
        Me.cmdEmail.Size = New System.Drawing.Size(151, 48)
        Me.cmdEmail.TabIndex = 3
        Me.cmdEmail.Text = "Email"
        Me.cmdEmail.UseVisualStyleBackColor = True
        '
        'cmdCommunication
        '
        Me.cmdCommunication.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCommunication.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommunication.Image = CType(resources.GetObject("cmdCommunication.Image"), System.Drawing.Image)
        Me.cmdCommunication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCommunication.Location = New System.Drawing.Point(27, 81)
        Me.cmdCommunication.Name = "cmdCommunication"
        Me.cmdCommunication.Size = New System.Drawing.Size(151, 50)
        Me.cmdCommunication.TabIndex = 2
        Me.cmdCommunication.Text = "Communication"
        Me.cmdCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCommunication.UseVisualStyleBackColor = False
        '
        'Requester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 719)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(lb2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Requester"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmChangePassword As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdCommunication As Button
    Friend WithEvents cmdEmail As Button
    Friend WithEvents cmdHardware As Button
    Friend WithEvents cmdInternet As Button
    Friend WithEvents cmdSoftware As Button
    Friend WithEvents cmdOthers As Button
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl1 As RadioButton
    Friend WithEvents Lbl3 As RadioButton
    Friend WithEvents Lbl5 As RadioButton
    Friend WithEvents Lbl7 As RadioButton
    Friend WithEvents lbl9 As RadioButton
    Friend WithEvents SolutionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindSolutionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdRequestStatus As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As Label
    Friend WithEvents txtContent As RichTextBox
End Class
