<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSuccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuccess))
        Me.Lbrequest = New System.Windows.Forms.Label()
        Me.lbUser1 = New System.Windows.Forms.Label()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RequestId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPriority = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbrequest
        '
        Me.Lbrequest.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbrequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbrequest.Location = New System.Drawing.Point(126, 6)
        Me.Lbrequest.Name = "Lbrequest"
        Me.Lbrequest.Size = New System.Drawing.Size(113, 21)
        Me.Lbrequest.TabIndex = 0
        Me.Lbrequest.Text = "Request From"
        '
        'lbUser1
        '
        Me.lbUser1.AutoSize = True
        Me.lbUser1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbUser1.Location = New System.Drawing.Point(126, 37)
        Me.lbUser1.Name = "lbUser1"
        Me.lbUser1.Size = New System.Drawing.Size(46, 23)
        Me.lbUser1.TabIndex = 1
        Me.lbUser1.Text = "User"
        '
        'cmdAccept
        '
        Me.cmdAccept.BackgroundImage = CType(resources.GetObject("cmdAccept.BackgroundImage"), System.Drawing.Image)
        Me.cmdAccept.Location = New System.Drawing.Point(389, -3)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(113, 79)
        Me.cmdAccept.TabIndex = 2
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ticket ID"
        '
        'RequestId
        '
        Me.RequestId.AutoSize = True
        Me.RequestId.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RequestId.Location = New System.Drawing.Point(10, 29)
        Me.RequestId.Name = "RequestId"
        Me.RequestId.Size = New System.Drawing.Size(104, 33)
        Me.RequestId.TabIndex = 4
        Me.RequestId.Text = "Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(309, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Priority"
        '
        'txtPriority
        '
        Me.txtPriority.AutoSize = True
        Me.txtPriority.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriority.ForeColor = System.Drawing.Color.White
        Me.txtPriority.Location = New System.Drawing.Point(307, 37)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(70, 23)
        Me.txtPriority.TabIndex = 6
        Me.txtPriority.Text = "Priority"
        '
        'FrmSuccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(503, 77)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RequestId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.lbUser1)
        Me.Controls.Add(Me.Lbrequest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSuccess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbrequest As Label
    Friend WithEvents lbUser1 As Label
    Friend WithEvents cmdAccept As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RequestId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPriority As Label
End Class
