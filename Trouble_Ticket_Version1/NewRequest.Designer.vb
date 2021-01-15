<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRequest))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxTemplate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPriority = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.ComboBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.TxtDepartment = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFname_Lname = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Request"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cbxTemplate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 124)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(641, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 115)
        Me.Panel2.TabIndex = 24
        '
        'cbxTemplate
        '
        Me.cbxTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTemplate.FormattingEnabled = True
        Me.cbxTemplate.Location = New System.Drawing.Point(368, 30)
        Me.cbxTemplate.Name = "cbxTemplate"
        Me.cbxTemplate.Size = New System.Drawing.Size(269, 28)
        Me.cbxTemplate.TabIndex = 21
        Me.cbxTemplate.Text = "--Default Request--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(251, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Template"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Priority"
        '
        'txtPriority
        '
        Me.txtPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriority.FormattingEnabled = True
        Me.txtPriority.Items.AddRange(New Object() {"High", "Low", "Medium", "Urgent"})
        Me.txtPriority.Location = New System.Drawing.Point(128, 229)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(394, 28)
        Me.txtPriority.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Complain"
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(128, 326)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(585, 26)
        Me.txtSubject.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description/Preferred Schedule"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(128, 391)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(585, 157)
        Me.txtDescription.TabIndex = 11
        Me.txtDescription.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "*Site"
        '
        'txtSite
        '
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.FormattingEnabled = True
        Me.txtSite.Items.AddRange(New Object() {"Makati Office", "Minsesite Office", "Butuan Office"})
        Me.txtSite.Location = New System.Drawing.Point(128, 559)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(377, 28)
        Me.txtSite.TabIndex = 13
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.ForeColor = System.Drawing.Color.Silver
        Me.cmdSubmit.Location = New System.Drawing.Point(140, 608)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(146, 44)
        Me.cmdSubmit.TabIndex = 16
        Me.cmdSubmit.Text = "Submit Request"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Silver
        Me.cmdClear.Location = New System.Drawing.Point(325, 608)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(146, 44)
        Me.cmdClear.TabIndex = 17
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Silver
        Me.cmdCancel.Location = New System.Drawing.Point(527, 608)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(146, 44)
        Me.cmdCancel.TabIndex = 18
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Category"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Items.AddRange(New Object() {"Hardware", "Internet", "Network", "Operating System", "Others", "Printers", "Software"})
        Me.txtCategory.Location = New System.Drawing.Point(128, 277)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(394, 28)
        Me.txtCategory.TabIndex = 20
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartment.FormattingEnabled = True
        Me.TxtDepartment.Items.AddRange(New Object() {"Admin", "Audit", "Compliance", "Communication", "Engineering", "Finance", "H.R.", "I.T.", "Legal", "Marketing", "Office of the President", "Purchasing", "Risk Management"})
        Me.TxtDepartment.Location = New System.Drawing.Point(128, 185)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(394, 28)
        Me.TxtDepartment.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Department"
        '
        'txtFname_Lname
        '
        Me.txtFname_Lname.AutoSize = True
        Me.txtFname_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname_Lname.Location = New System.Drawing.Point(124, 150)
        Me.txtFname_Lname.Name = "txtFname_Lname"
        Me.txtFname_Lname.Size = New System.Drawing.Size(83, 20)
        Me.txtFname_Lname.TabIndex = 23
        Me.txtFname_Lname.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(443, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(502, 144)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(333, 26)
        Me.txtEmail.TabIndex = 25
        '
        'NewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(847, 693)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFname_Lname)
        Me.Controls.Add(Me.TxtDepartment)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "NewRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TroubleTicket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPriority As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSite As ComboBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxTemplate As ComboBox
    Friend WithEvents TxtDepartment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFname_Lname As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
