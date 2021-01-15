Imports System.Data.SqlClient
Public Class CreateSolution
    Private SQL As New SqlControl
    Private Sub CreateSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateSolution()
        SQL.AddParam("@Title", txtTitle.Text)
        SQL.AddParam("@Content", txtContent.Text)
        SQL.AddParam("@Topic", txtTopic.Text)
        SQL.AddParam("@Comments", txtComments.Text)
        SQL.AddParam("@Solution_Owner", AdminForm.UsernameAdmin.Text)

        SQL.ExecQuery("Insert Into Solutions(Title, Content, Topic, Comments, UpdateDate, Solution_Owner)" &
                      "Values(@Title,@Content,@Topic,@Comments,GETDATE(),@Solution_Owner);", True)
        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Solution Created Successfully!")

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTopic.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then

            MessageBox.Show("You have entered a blank Title")

        ElseIf txtTitle.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no Title that starts with space!")
        ElseIf String.IsNullOrWhiteSpace(txtContent.Text) Then
            MessageBox.Show("You have entered a blank Content")
        ElseIf txtTopic.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Topic!")


        Else
            UpdateSolution()

            txtTitle.Clear()
            txtTopic.SelectedIndex = -1
            txtComments.Clear()
            txtContent.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtTitle.Clear()
        txtTopic.SelectedIndex = -1
        txtComments.Clear()
        txtContent.Clear()
    End Sub
End Class