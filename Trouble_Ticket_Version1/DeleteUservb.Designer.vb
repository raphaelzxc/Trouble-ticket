<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteUser
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
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.clbUsers = New System.Windows.Forms.CheckedListBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(12, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(198, 24)
        Me.txtFilter.TabIndex = 0
        '
        'clbUsers
        '
        Me.clbUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbUsers.FormattingEnabled = True
        Me.clbUsers.Location = New System.Drawing.Point(12, 51)
        Me.clbUsers.Name = "clbUsers"
        Me.clbUsers.Size = New System.Drawing.Size(198, 251)
        Me.clbUsers.TabIndex = 1
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(247, 292)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(147, 35)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 339)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.clbUsers)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilter As TextBox
    Friend WithEvents clbUsers As CheckedListBox
    Friend WithEvents cmdDelete As Button
End Class
