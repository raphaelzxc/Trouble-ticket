Public Class EditUser
    Private SQL As New SqlControl

    Private Sub FetchUsers()
        'refresh users list
        lbUsers.Items.Clear()

        'add params and run query
        SQL.AddParam("@users", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select username " &
                      "from members " &
                      "where username like @users " &
                      "ORDER by username ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("Username"))
        Next

    End Sub
    Private Sub GetUserDetails(Username As String)
        SQL.AddParam("@user", Username)
        SQL.ExecQuery("SELECT TOP 1 * " &
            "FROM Members " &
            "WHERE username = @user;")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtID.Text = R("ID")
            txtUser.Text = R("Username")
            txtPass.Text = R("Password")
            cbActive.Checked = R("Active")
            cbAdmin.Checked = R("Admin")
        Next
    End Sub

    Private Sub UpdateUser()
        SQL.AddParam("@pass", txtPass.Text)
        SQL.AddParam("@Active", cbActive.Checked)
        SQL.AddParam("@admin", cbAdmin.Checked)
        SQL.AddParam("@ID", txtID.Text)
        SQL.AddParam("@Email", txtEmailAdress.Text)

        SQL.ExecQuery("UPDATE members " &
        "SET Password=@pass,Active=@active,Admin=@admin,Email_Address=@Email " &
        "WHERE ID=@id;")

        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("User has been updated.")

    End Sub


    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUsers()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        GetUserDetails(lbUsers.Text)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        UpdateUser()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged

    End Sub
End Class