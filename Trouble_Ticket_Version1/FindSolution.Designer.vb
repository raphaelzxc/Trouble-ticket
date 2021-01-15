<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindSolution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindSolution))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbSolution = New System.Windows.Forms.ListBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTopic = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 122)
        Me.Panel1.TabIndex = 0
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(12, 128)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(293, 26)
        Me.txtFilter.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Search"
        '
        'lbSolution
        '
        Me.lbSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSolution.FormattingEnabled = True
        Me.lbSolution.ItemHeight = 16
        Me.lbSolution.Location = New System.Drawing.Point(12, 199)
        Me.lbSolution.Name = "lbSolution"
        Me.lbSolution.Size = New System.Drawing.Size(222, 420)
        Me.lbSolution.TabIndex = 25
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(339, 161)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(439, 26)
        Me.txtTitle.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Title"
        '
        'txtContent
        '
        Me.txtContent.Enabled = False
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(339, 208)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(439, 315)
        Me.txtContent.TabIndex = 30
        Me.txtContent.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Content"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Topic"
        '
        'txtTopic
        '
        Me.txtTopic.Enabled = False
        Me.txtTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.FormattingEnabled = True
        Me.txtTopic.Items.AddRange(New Object() {"Hardware", "Desktop Hardware", "Printers", "Routers", "Switches", "Network", "Internet", "Softwares", "Customizations", "Settings", "Troubleshooting", "Others"})
        Me.txtTopic.Location = New System.Drawing.Point(339, 538)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(439, 28)
        Me.txtTopic.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "I'm looking for solution"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(649, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 115)
        Me.Panel2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(12, 633)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Solution Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 668)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Created  by"
        '
        'txtAdmin
        '
        Me.txtAdmin.AutoSize = True
        Me.txtAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmin.Location = New System.Drawing.Point(144, 668)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(0, 18)
        Me.txtAdmin.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(259, 668)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Created  on"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(396, 668)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(0, 18)
        Me.txtDate.TabIndex = 37
        '
        'FindSolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(832, 751)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTopic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbSolution)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FindSolution"
        Me.Text = "FindSolution"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbSolution As ListBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContent As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTopic As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDate As Label
End Class
