Imports System.Data
Public Class UpdateSolution
    Private SQL As New SqlControl
    Private Sub UpdateSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchSolutions()
    End Sub

    Private Sub GetSolution(Title As String)
        SQL.AddParam("@Title", Title)
        SQL.ExecQuery("SELECT * " &
            "FROM Solutions " &
            "WHERE Title = @Title;")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtTitle.Text = R("Title")
            txtContent.Text = R("Content")
            txtTopic.Text = R("Topic")
            txtComments.Text = R("Comments")
            txtID.Text = R("SolutionID")
        Next
    End Sub

    Public Sub FetchSolutions()
        'refresh users list
        lbSolution.Items.Clear()

        'add params and run query
        SQL.AddParam("@Title", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select Title,Topic " &
                      "from Solutions " &
                      "where (Topic like 'TroubleShooting' or Topic like 'Others') and Title like @Title " &
                      "ORDER by Title ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list 
        For Each r As DataRow In SQL.DBDT.Rows
            lbSolution.Items.Add(r("Title"))
        Next

    End Sub

    Private Sub UpdateSolution()
        'add paramater and add a command
        SQL.AddParam("@SolutionID", txtID.Text)
        SQL.AddParam("@Content", txtContent.Text)
        SQL.AddParam("@Comments", txtComments.Text)

        SQL.ExecQuery("UPDATE Solutions " &
        "SET Content=@Content,Comments=@Comments,UpdateDate=GETDATE() " &
        "WHERE SolutionID=@SolutionID;")

        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Solution has been updated.")

    End Sub

    Private Sub DeleteSolutions(Title As String)
        SQL.AddParam("@Title", Title)
        If MsgBox("The selected Solution will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete Solution?") = MsgBoxResult.Yes Then
            'generate mass delete command

            SQL.ExecQuery("DELETE " &
            "FROM Solutions " &
            "WHERE Title=@Title;")
            'report and abort erro
            If SQL.HasExCeption(True) Then Exit Sub
            MsgBox("The selected user have been deleted successfully.")
            'refresh users list
            FetchSolutions()
        End If
    End Sub

    Private Sub lbSolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSolution.SelectedIndexChanged
        GetSolution(lbSolution.Text)
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchSolutions()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtContent.Text) Then

            MessageBox.Show("You have entered a blank Content")

        ElseIf txtContent.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no Content that starts with space!")

        Else
            UpdateSolution()

            txtComments.Clear()
            txtTopic.SelectedIndex = -1
            txtContent.Clear()
            txtTitle.Clear()
            txtID.Clear()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtComments.Clear()
        txtTopic.SelectedIndex = -1
        txtContent.Clear()
        txtTitle.Clear()
        txtID.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteSolutions(lbSolution.Text)
    End Sub
End Class