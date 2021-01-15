Public Class NewUser
    Private SQL As New SqlControl

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InsertUser()
        'add paramater and add a command
        SQL.AddParam("@Lname", txtLname.Text)
        SQL.AddParam("@Fname", txtFName.Text)
        SQL.AddParam("@user", txtUser.Text)
        SQL.AddParam("@pass", txtPass.Text)
        SQL.AddParam("@active", cbActive.Checked)
        SQL.AddParam("@admin", cvAdmin.Checked)

        SQL.ExecQuery("insert into members(LastName,Firstname,Username,Password,Joindate,Active,Admin)" &
                      "Values(@Lname,@Fname,@user,@pass,GETDATE(),@active,@admin);", True)

        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub
        MsgBox("User Created Successfully!")
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click

        If String.IsNullOrWhiteSpace(txtFName.Text) Then
            MessageBox.Show("You have entered a blank name")

        ElseIf String.IsNullOrWhiteSpace(txtLname.Text) Then
            MessageBox.Show("You have entered a blank name")

        ElseIf String.IsNullOrWhiteSpace(txtuser.Text) Then
            MessageBox.Show("You have entered a blank username")

        ElseIf String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("You have entered a blank password")

        ElseIf txtFName.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no name that starts with space!")
        ElseIf txtLname.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no name that starts with space!")
        ElseIf txtUser.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no username that starts with space!")
        ElseIf txtPass.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no password that starts with space!")
        Else
            InsertUser()
            'clear fields
            txtFName.Clear()
            txtLname.Clear()
            txtPass.Clear()
            txtUser.Clear()
            cbActive.Checked = False
            cvAdmin.Checked = False
            cmdSubmit.Enabled = False
        End If



    End Sub

    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged, txtLname.TextChanged,
            txtPass.TextChanged, txtUser.TextChanged
        'basic validation

        If Not String.IsNullOrWhiteSpace(txtFName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtLname.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass.Text) AndAlso Not String.IsNullOrWhiteSpace(txtUser.Text) Then
            cmdSubmit.Enabled = True

        End If
    End Sub
End Class