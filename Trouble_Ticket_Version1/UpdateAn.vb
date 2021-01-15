Public Class UpdateAn

    Private SQL As New SqlControl

    Private Sub UpdateAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAnnouncement()
    End Sub

    Private Sub GetAnnouncement(Title As String)
        SQL.AddParam("@Title", Title)
        SQL.ExecQuery("SELECT * " &
            "FROM Announcement " &
            "WHERE Title = @Title;")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtTitle.Text = R("Title")
            txtContent.Text = R("Content")
            txtID.Text = R("AnnouncementID")
        Next
    End Sub

    Public Sub FetchAnnouncement()
        'refresh users list
        lbAnnouncement.Items.Clear()

        'add params and run query
        SQL.AddParam("@Title", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select Title " &
                      "from Announcement " &
                      "where  Title like @Title " &
                      "ORDER by Title ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list 
        For Each r As DataRow In SQL.DBDT.Rows
            lbAnnouncement.Items.Add(r("Title"))
        Next

    End Sub


    Private Sub UpdateAnnouncement()
        'add paramater and add a command
        SQL.AddParam("@AnnouncementID", txtID.Text)
        SQL.AddParam("@Content", txtContent.Text)


        SQL.ExecQuery("UPDATE Announcement " &
        "SET Content=@Content,CreateDate=GETDATE() " &
        "WHERE AnnouncementID=@AnnouncementID;")

        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Solution has been updated.")

    End Sub

    Private Sub DeleteAnnouncement(Title As String)
        SQL.AddParam("@Title", Title)
        If MsgBox("The selected Announcement will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete Solution?") = MsgBoxResult.Yes Then
            'generate mass delete command

            SQL.ExecQuery("DELETE " &
            "FROM Announcement " &
            "WHERE Title=@Title;")
            'report and abort erro
            If SQL.HasExCeption(True) Then Exit Sub
            MsgBox("The selected user have been deleted successfully.")
            'refresh users list
            FetchAnnouncement()
        End If
    End Sub

    Private Sub lbSolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAnnouncement.SelectedIndexChanged
        GetAnnouncement(lbAnnouncement.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateAnnouncement()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteAnnouncement(lbAnnouncement.Text)
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged

    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchAnnouncement()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        txtContent.Clear()
        txtTitle.Clear()
        txtID.Clear()
    End Sub
End Class