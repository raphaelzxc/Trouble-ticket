Public Class UserForm1
    Public SQL As New SqlControl

    Private Sub GETuserInfo()

        SQL.RunQuery("SELECT Admin,username " &
                      "FROM members " &
                      "WHERE UserName='" & Login.AuthUser & "' ")

        For Each i As Object In SQL.SQLDS.Tables(0).Rows
            UserName1.Text = i.item("username")
            Me.Text = i.item("username")
        Next



    End Sub

    Private Sub Fetchrequest()
        'refresh users list
        lbpending.Items.Clear()

        'add params and run query
        SQL.AddParam("@user", UserName1.Text)
        SQL.ExecQuery("select b.username,a.MemberConfirmation, a.Status,a.name " &
                      "from request a " &
                      "RIGHT JOIN members b " &
                      "ON a.Name = b.username " &
                      "WHERE   (a.status like 'open%' or a.status like 'onhold') and a.MemberConfirmation is null and b.username='" & UserName1.Text & "' ")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list
        For Each r As DataRow In SQL.DBDT.Rows
            lbpending.Items.Add(r("Username"))
        Next

    End Sub
    Private Sub UserForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GETuserInfo()
        Fetchrequest()
        If Requester.Text = Requester.Text Then UserName1.Text = Requester.Text
    End Sub

    Private Sub Getmessage(name As String)
        SQL.AddParam("@name", name)
        SQL.ExecQuery("SELECT * " &
                     "FROM Message " &
                     "WHERE username =@name ")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            FrmResponse.txtMessage.Text = R("Message")
        Next
        FrmResponse.Show()

    End Sub
    Private Sub GetUserDetails(Username As String)
        SQL.AddParam("@user", Username)
        SQL.ExecQuery("SELECT  * " &
            "FROM request a " &
            "FULL JOIN members b " &
            "ON a.Name = b.username " &
            "WHERE  (a.status like 'open%' or a.status like 'onhold') and b.username='" & UserName1.Text & "' ")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtID.Text = R("RequestID")
            txtName.Text = R("Name")
            txtCategory.Text = R("Category")
            txtPriority.Text = R("Priority")
            txtSubject.Text = R("Subject")
            txtDescription.Text = R("Description")
            txtSite.Text = R("Site")
            TxtDepartment.Text = R("Department")
            txtDuedate.Text = R("DuebyDate")
        Next
    End Sub

    Private Sub UpdateUserRequest()
        'add paramater and add a command

        SQL.AddParam("@Category", txtCategory.Text)
        SQL.AddParam("@Priority", txtPriority.Text)
        SQL.AddParam("@Subject", txtSubject.Text)
        SQL.AddParam("@Description", txtDescription.Text)
        SQL.AddParam("@site", txtSite.Text)
        SQL.AddParam("@status", txtMemberConfirmation.Text)
        SQL.AddParam("@RequestID", txtID.Text)
        SQL.AddParam("@Feedback", txtFeedback.Text)
        SQL.AddParam("@Department", TxtDepartment.Text)

        SQL.ExecQuery("UPDATE Request " &
        "SET MemberConfirmation=@status,Feedback=@Feedback,MemberDateconfirmation=GETDATE() " &
        "WHERE Requestid=@RequestID;")

        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Request Resolved Successfully!")

    End Sub



    Private Sub UserName1_Click(sender As Object, e As EventArgs) Handles UserName1.Click

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then

            MessageBox.Show("You have entered a blank name")

        ElseIf txtname.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no name that starts with space!")
        Else
            UpdateUserRequest()
            txtFeedback.Clear()
            txtDescription.Clear()
            txtMemberConfirmation.SelectedIndex = -1
            TxtDepartment.SelectedIndex = -1
            txtCategory.SelectedIndex = -1
            txtPriority.SelectedIndex = -1
            txtSite.SelectedIndex = -1
            txtSubject.Clear()
            txtID.Clear()
            txtName.Clear()
            txtDuedate.Clear()
        End If


    End Sub

    Private Sub lbpending_SelectedIndexChanged(sender As Object, e As EventArgs)
        GetUserDetails(lbPending.Text)
    End Sub

    Private Sub txtFeedback_TextChanged(sender As Object, e As EventArgs) Handles txtFeedback.TextChanged
        If Not String.IsNullOrWhiteSpace(txtFeedback.Text) Then
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Fetchrequest()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub



    Private Sub cmdRefresh_Click_1(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Fetchrequest()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        NewRequest.Show()
    End Sub

    Private Sub lbPending_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lbPending.SelectedIndexChanged
        GetUserDetails(lbPending.Text)

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Getmessage(txtName.Text)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class