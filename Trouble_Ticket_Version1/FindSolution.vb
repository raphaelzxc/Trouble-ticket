Imports System.Data
Public Class FindSolution
    Private SQL As New SqlControl
    Private Sub FindSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txtAdmin.Text = R("Solution_Owner")
            txtDate.Text = R("UpdateDate")

        Next
    End Sub

    Public Sub FetchSolutions()
        'refresh users list
        lbSolution.Items.Clear()

        'add params and run query
        SQL.AddParam("@Title", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select Title,Topic " &
                      "from Solutions " &
                      "where Topic like 'TroubleShooting' and Title like @Title " &
                      "ORDER by Title ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list 
        For Each r As DataRow In SQL.DBDT.Rows
            lbSolution.Items.Add(r("Title"))
        Next

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

End Class