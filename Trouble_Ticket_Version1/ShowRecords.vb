
Public Class ShowRecords
    Public SQL As New SqlControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("select * from Request;")
        Else
            SQL.ExecQuery(Query)
        End If

        'error handling
        If SQL.HasExCeption(True) Then Exit Sub

        dgvData.DataSource = SQL.DBDT
    End Sub
    Private Sub LoadCBX()
        'REFRESH ITEMS OR COMBOBOX
        cbxItems.Items.Clear()
        'run query

        SQL.ExecQuery("SELECT Name from request ORDER BY name ASC;")

        If SQL.HasExCeption(True) Then Exit Sub

        'loop row add combobox

        For Each r As DataRow In SQL.DBDT.Rows
            cbxItems.Items.Add(r("Name").ToString)
        Next

    End Sub

    Private Sub Finditem()
        SQL.AddParam("@name", "%" & txtSearch.Text & "%")
        LoadGrid("select * from request where name LIKE @name;")
    End Sub

    Private Sub ShowRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ' LoadCBX()
    End Sub

    Private Sub GetUserDetails(Username As String)
        SQL.AddParam("@name", Username)
        SQL.ExecQuery("SELECT TOP 1 * " &
            "FROM request " &
            "WHERE name = @name;")
        If SQL.RecordCount < 1 Then Exit Sub
    End Sub
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadCBX()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        GetUserDetails(dgvData.Text)
    End Sub

    Private Sub cbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItems.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class