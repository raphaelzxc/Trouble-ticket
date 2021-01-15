Imports System.Data.SqlClient
Public Class FrmInfo

    Private SQL As New SqlControl
    Private Sub FrmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        TxtMessage.Visible = False
        LabelIT.Visible = False
        cmdSend.Visible = False
        Lbuser1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Me.ShowInTaskbar = False

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)

            TxtMessage.Visible = True
            LabelIT.Visible = True
            cmdSend.Visible = True
            Lbuser1.Visible = True
        Loop
    End Sub

    Private Sub GetMessage()
        'add paramater and add a command
        SQL.AddParam("@Message", TxtMessage.Text)
        SQL.AddParam("@Name", Lbuser1.Text)
        SQL.AddParam("@subject", AdminForm.txtSubject.Text)
        SQL.ExecQuery("insert into Message(Message,Username,Datesend,subject)" &
                      "Values(@Message,@Name,getdate(),@subject);", True)

        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Message sent!")

    End Sub

    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click

        If String.IsNullOrWhiteSpace(TxtMessage.Text) Then

            MessageBox.Show("You have entered a blank message")

        ElseIf txtMessage.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Message starts with space!")
        Else
            GetMessage()
            TxtMessage.Clear()
            Me.Hide()
        End If
    End Sub



End Class