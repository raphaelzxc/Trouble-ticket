
Public Class Login

    Public SQL As New SqlControl
    Public AuthUser As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Public Function IsAuthenticated() As Boolean
        'clear existing records
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()

        End If
        SQL.RunQuery("SELECT count(username) As Usercount  " &
                      "FROM members " &
                      "WHERE username='" & txtUser.Text & "' " &
                      "AND password='" & txtPass.Text & "'COLLATE SQL_Latin1_General_CP1_CS_AS")
        If SQL.SQLDS.Tables(0).Rows(0).Item("Usercount") = 1 Then
            Return True
        End If
        MsgBox("Invalid User Credentials.", MsgBoxStyle.Critical, "LOGIN FAILED")
        Return False
    End Function
    Public Sub GETuserForm()

        SQL.RunQuery("SELECT Admin,username " &
                      "FROM members " &
                      "WHERE UserName='" & AuthUser & "' ")

        If SQL.SQLDS.Tables(0).Rows(0).Item("Admin") = True Then AdminForm.Show()
        If SQL.SQLDS.Tables(0).Rows(0).Item("Admin") = False Then Requester.Show()


    End Sub
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                AuthUser = txtUser.Text
                MsgBox("Login successful!")
                GETuserForm()


                Me.Hide()
                txtPass.Clear()
                txtUser.Clear()
            End If
        End If
    End Sub

    Private Sub cmdLogin_MouseHover(sender As Object, e As EventArgs) Handles cmdLogin.MouseHover
        cmdLogin.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdLogin_MouseLeave(sender As Object, e As EventArgs) Handles cmdLogin.MouseLeave
        cmdLogin.BackColor = Color.DarkGreen
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
