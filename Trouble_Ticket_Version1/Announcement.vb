Public Class An
    Private SQL As New SqlControl
    Private Sub Announcement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateAnnouncement()
        SQL.AddParam("@Title", txtTitle.Text)
        SQL.AddParam("@Content", txtContent.Text)
        SQL.AddParam("@Solution_Owner", AdminForm.UsernameAdmin.Text)

        SQL.ExecQuery("Insert Into Announcement(Title,Content,CreateDate,AnnoucementCreator) " &
                      "Values(@Title,@Content,GETDATE(),@Solution_Owner);", True)
        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Announcement Created Successfully!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then

            MessageBox.Show("You have entered a blank Title")

        ElseIf txtTitle.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no Announcement that starts with space!")
        ElseIf String.IsNullOrWhiteSpace(txtContent.Text) Then
            MessageBox.Show("You have entered a blank Content")



        Else
            UpdateAnnouncement()

            txtTitle.Clear()

            txtContent.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtTitle.Clear()

        txtContent.Clear()
    End Sub
End Class