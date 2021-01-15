Public Class FrmResponse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmResponse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        txtMessage.Visible = False
        Label2.Visible = False
        Button1.Visible = False


        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Me.ShowInTaskbar = False

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)

            txtMessage.Visible = True
            Label2.Visible = True
            Button1.Visible = True
        Loop
    End Sub
End Class