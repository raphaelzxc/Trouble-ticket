<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.LabelIT = New System.Windows.Forms.Label()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.Lbuser1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 106)
        Me.Panel1.TabIndex = 0
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(465, 62)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(84, 34)
        Me.cmdSend.TabIndex = 5
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'LabelIT
        '
        Me.LabelIT.AutoSize = True
        Me.LabelIT.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIT.Location = New System.Drawing.Point(134, 9)
        Me.LabelIT.Name = "LabelIT"
        Me.LabelIT.Size = New System.Drawing.Size(158, 19)
        Me.LabelIT.TabIndex = 4
        Me.LabelIT.Text = "I.T. Personnel Message"
        '
        'TxtMessage
        '
        Me.TxtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessage.Location = New System.Drawing.Point(138, 70)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.Size = New System.Drawing.Size(285, 26)
        Me.TxtMessage.TabIndex = 6
        '
        'Lbuser1
        '
        Me.Lbuser1.AutoSize = True
        Me.Lbuser1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbuser1.Location = New System.Drawing.Point(134, 38)
        Me.Lbuser1.Name = "Lbuser1"
        Me.Lbuser1.Size = New System.Drawing.Size(39, 19)
        Me.Lbuser1.TabIndex = 7
        Me.Lbuser1.Text = "User"
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(572, 108)
        Me.Controls.Add(Me.Lbuser1)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.LabelIT)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmInfo"
        Me.Text = "Send Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdSend As Button
    Friend WithEvents LabelIT As Label
    Friend WithEvents TxtMessage As TextBox
    Friend WithEvents Lbuser1 As Label
End Class
