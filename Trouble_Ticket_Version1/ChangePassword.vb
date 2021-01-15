Imports System.Data.SqlClient


Public Class ChangePassword
    Public sql As New SqlControl
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GETuserInfo()
        Fetchrequest()
        If Requester.Text = Requester.Text Then Me.Text = Requester.Text
    End Sub



    Private Sub GetUserDetails(Username As String)
        Sql.AddParam("@user", Username)
        sql.ExecQuery("SELECT TOP 1 * " &
            "FROM Members " &
            "WHERE username ='" & Requester.Text & "' ")


        If Sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In Sql.DBDT.Rows
            txtID.Text = R("ID")
            txtUser.Text = R("Username")
            txtPass.Text = R("Password")

        Next
    End Sub

    Private Sub GETuserInfo()

        Sql.RunQuery("Select Admin, Username " &
                      "FROM members " &
                      "WHERE UserName='" & Login.AuthUser & "' ")

        For Each i As Object In Sql.SQLDS.Tables(0).Rows

            Requester.Text = i.item("username")
        Next
    End Sub

    Private Sub Fetchrequest()
        'refresh users list
        lbUsers.Items.Clear()

        'add params and run query
        sql.AddParam("@user", Requester.Text)
        sql.ExecQuery("select b.username,a.MemberConfirmation, a.Status,a.name " &
                      "from request a " &
                      "RIGHT JOIN members b " &
                      "ON a.Name = b.username " &
                      "WHERE   (a.status like 'open%' or a.status like 'onhold') and a.MemberConfirmation is null and b.username='" & Requester.Text & "' ")
        'report and abort error
        If sql.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list
        For Each r As DataRow In sql.DBDT.Rows
            lbUsers.Items.Add(r("Username"))
        Next
    End Sub
    Private Sub UpdateUser()
        sql.AddParam("@pass", txtPass.Text)

        sql.AddParam("@ID", txtID.Text)

        sql.ExecQuery("UPDATE members " &
        "SET Password=@pass " &
        "WHERE ID=@id;")

        If sql.HasExCeption(True) Then Exit Sub

        MsgBox("Password Succesfully Change!.")

    End Sub
    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        GetUserDetails(lbUsers.Text)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If String.IsNullOrWhiteSpace(txtPass.Text) Then

            MessageBox.Show("You have entered a blank Password")

        ElseIf txtPass.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no Password that starts with space!")

        Else
            UpdateUser()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class