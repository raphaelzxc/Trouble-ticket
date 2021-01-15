Public Class DeleteUser

    Private SQL As New SqlControl
    Private Sub FetchUsers()
        'refresh users list
        clbUsers.Items.Clear()

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
            clbUsers.Items.Add(r("Username"))
        Next

    End Sub

    Private Sub DeleteUsers()
        If MsgBox("The selected User will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete User?") = MsgBoxResult.Yes Then
            'generate mass delete command
            Dim c As Integer ' unique id for auto generated numbers
            Dim DelString As String = "" ' query string builder

            For Each i As String In clbUsers.CheckedItems
                SQL.AddParam("@user" & c, i)
                DelString += "DELETE FROM members WHERE username=@user" & c & ";"
                c += 1
            Next

            SQL.ExecQuery(DelString)
            'report and abort erro
            If SQL.HasExCeption(True) Then Exit Sub
            MsgBox("The selected user have been deleted successfully.")
            'refresh users list
            FetchUsers()
        End If
    End Sub


    Private Sub DeleteUservb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUsers()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If clbUsers.CheckedItems.Count > 0 Then DeleteUsers()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class