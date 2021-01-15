Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Text

Public Class FrmSuccess
    Private SQL As New SqlControl
    Private Sub FrmSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        Lbrequest.Visible = False
        lbUser1.Visible = False
        cmdAccept.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Me.ShowInTaskbar = False

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)

            Lbrequest.Visible = True
            lbUser1.Visible = True
            cmdAccept.Visible = True
        Loop

        ChangeColor()

    End Sub

    Private Sub ChangeColor()
        If txtPriority.Text = "Urgent" Then
            txtPriority.ForeColor = Color.DarkRed
        End If
        If txtPriority.Text = "High" Then
            txtPriority.ForeColor = Color.DarkRed
        End If
    End Sub
    Public Sub AcceptRequest()
        SQL.AddParam("@user", lbUser1.Text)
        SQL.AddParam("@RequestId", RequestId.Text)
        SQL.AddParam("@Priority", txtPriority.Text)

        SQL.ExecQuery("insert into acceptdata$(RequestID,Name,Priority,AcceptDATE) " &
        "Values(@RequestID,@user,@Priority,GETDATE());", True)

        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub

    End Sub
    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        AdminForm.FetchUsers()
        AdminForm.FetchUsersOnhold()
        AcceptRequest()
        Me.Close()
    End Sub

    Private Sub cmdAccept_MouseHover(sender As Object, e As EventArgs) Handles cmdAccept.MouseHover
        cmdAccept.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdAccept_MouseLeave(sender As Object, e As EventArgs) Handles cmdAccept.MouseLeave
        cmdAccept.BackColor = Color.Empty
    End Sub

    Private Sub txtPriority_Click(sender As Object, e As EventArgs) Handles txtPriority.Click

    End Sub
End Class