Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Public Class AdminForm
    Public RequestCount As String
    Private SQL As New SqlControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GETuserInfo()
        FetchUsers()
        FetchUsersOnhold()
        countPending()
        countResolved()
        EodContinuation()
        'Productive()
        Timer1.Interval = 1000
        Timer2.Interval = 1000
        Timer3.Interval = 1000
        Timer4.Interval = 1000
    End Sub


    Private Sub GETuserInfo()

        SQL.RunQuery("SELECT Admin,username " &
                      "FROM members " &
                      "WHERE UserName='" & Login.AuthUser & "' ")

        For Each i As Object In SQL.SQLDS.Tables(0).Rows
            UsernameAdmin.Text = i.item("username")
            Me.Text = i.item("Username")
        Next



    End Sub
    'get user infos 
    Private Sub getFormInfo(Name As String)
        SQL.AddParam("@name", Name)
        SQL.ExecQuery("select b.username, a.Status,a.name " &
                      "from request a " &
                      "RIGHT JOIN members b " &
                      "ON a.Name = b.username " &
                      "WHERE   name = @name")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            FrmInfo.Lbuser1.Text = R("Name")

        Next
        FrmInfo.Show()
    End Sub

    Public Sub FetchUsers()
        'refresh users list
        lbUsers.Items.Clear()

        'add params and run query
        SQL.AddParam("@name", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select Name,Status " &
                      "from request " &
                      "where status like 'open%' and  name like @name " &
                      "ORDER by name ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("name")) '+ "," + r("status"))
        Next

    End Sub

    Public Sub FetchUsersOnhold()
        'refresh users list
        lbOnhold.Items.Clear()

        'add params and run query
        SQL.AddParam("@name", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("select name " &
                      "from request " &
                      "where status like 'onhold%' and  name like @name " &
                      "ORDER by name ASC;")
        'report and abort error
        If SQL.HasExCeption(True) Then Exit Sub

        'loop rows and return user to our list
        For Each r As DataRow In SQL.DBDT.Rows
            lbOnhold.Items.Add(r("name")) '+ "," + r("status"))
        Next

    End Sub

    'retrieve data from requests onhold requests
    Private Sub GetUserOnhold(Name As String)
        SQL.AddParam("@name", Name)
        SQL.ExecQuery("SELECT a.RequestID, a.Name, a.Priority, a.Subject,a.Department, a.Description, " &
                       "a.Site,a.category, a.Daterequest,b.Email_address,a.Status, a.Notes, a.Duebydate " &
                     "From Request a " &
                     "Full Join Members b " &
                     "On a.name = b.UserName " &
            "WHERE status like 'onhold%' and name = @name;")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtID.Text = R("RequestID")
            txtFname_Lname.Text = R("Name")
            txtEmail.Text = R("Email_Address")
            txtPriority.Text = R("Priority")
            txtCategory.Text = R("Category")
            txtSubject.Text = R("Subject")
            txtDescription.Text = R("Description")
            txtSite.Text = R("Site")
            txtDepartment.Text = R("Department")
            txtNotes.Text = R("Notes")
            txtDuedate.Text = R("DuebyDate")
        Next
    End Sub
    'retrieve data from requests Open requests
    Private Sub GetUserDetails(Name As String)
        SQL.AddParam("@name", Name)
        SQL.ExecQuery("SELECT a.RequestID, a.Name, a.Priority, a.Subject,a.Department,a.Description,a.Category, a.Site, a.Daterequest,b.Email_address, " &
                       "a.Status, a.Notes, a.Duebydate " &
                     "From Request a " &
                     "Full Join Members b " &
                     "On a.name = b.UserName " &
                     "WHERE name = @name and status like 'open%' " &
                     "order by case when priority = 'urgent' then 1 " &
                      "when priority = 'high' then 2 " &
                        "when priority = 'medium' then 3 " &
                        "when priority = 'low' then 4 " &
                        "End")


        If SQL.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In SQL.DBDT.Rows
            txtID.Text = R("RequestID")
            txtFname_Lname.Text = R("Name")
            txtEmail.Text = R("Email_Address")
            txtPriority.Text = R("Priority")
            txtCategory.Text = R("Category")
            txtSubject.Text = R("Subject")
            txtDescription.Text = R("Description")
            txtSite.Text = R("Site")
            txtDepartment.Text = R("Department")
            txtDuedate.Text = R("DuebyDate")
        Next
    End Sub
    Private Sub countResolved()
        'Dim i, j As Integer

        SQL.RunQuery("Select count(STATUS) As countStatus,datediff(day,UPDATEDATE,GETDATE()) As Datedifference " &
                      "FROM request " &
                      "WHERE status ='resolved'and datediff(day,UPDATEDATE,GETDATE()) = 0 " &
                     "GROUP BY status,datediff(day,UPDATEDATE,GETDATE()) ")

        For Each i As Object In SQL.SQLDS.Tables(0).Rows
            RequestResolved.Text = i.item("countStatus")
        Next


    End Sub

    Private Sub countPending()

        SQL.RunQuery("SELECT count(STATUS) as countStatus,datediff(day,UPDATEDATE,GETDATE()) as Datedifference " &
                      "FROM request " &
                      "WHERE status ='onhold'and datediff(day,UPDATEDATE,GETDATE()) = 0 " &
                     "GROUP BY status,datediff(day,UPDATEDATE,GETDATE()) ")

        For Each i As Object In SQL.SQLDS.Tables(0).Rows
            OnholdRequest.Text = i.item("countStatus")
        Next


    End Sub
    Private Sub UpdateRequest()
        'add paramater and add a command
        SQL.AddParam("@Fname_Lname", txtFname_Lname.Text)
        SQL.AddParam("@Category", txtEmail.Text)
        SQL.AddParam("@Priority", txtPriority.Text)
        SQL.AddParam("@Subject", txtSubject.Text)
        SQL.AddParam("@Description", txtDescription.Text)
        SQL.AddParam("@site", txtSite.Text)
        SQL.AddParam("@status", txtStatus.Text)
        SQL.AddParam("@RequestID", txtID.Text)
        SQL.AddParam("@Notes", txtNotes.Text)
        SQL.AddParam("@Department", txtDepartment.Text)
        SQL.AddParam("@rph", lbRph.Text)

        SQL.ExecQuery("UPDATE Request " &
        "SET Status=@status,Notes=@Notes,HandlingTime=@rph,UpdateDate=GETDATE() " &
        "WHERE Requestid=@RequestID;")

        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("Request has been updated.")

    End Sub

    Private Sub SendMail()

        Try
            Dim strMsg As String = Nothing
            Dim mail As New MailMessage
            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("troubleticketsystem1@gmail.com")
            mail.To.Add(txtEmail.Text)
            mail.Subject = "Ticket ID :" + txtID.Text + " " + txtStatus.Text
            ' Always create this type of string to form HTML otherwise if you add long html string at the 
            ' time of alternateview creation, you will get confused 
            strMsg = ""
            strMsg = strMsg & "<html><body><p></p>"
            strMsg = strMsg & "Dear " + txtFname_Lname.Text + ",<p></p>"
            strMsg = strMsg & "We have successfully completed your trouble ticket request with the following details:<p></p>"
            strMsg = strMsg & "<table width='600' style='border:1px solid #333' >"
            strMsg = strMsg & "<tr align='center'><th><h2><center><span style='color:#006400'>Trouble Ticket Request Details</span></center></h2></th></tr>"
            strMsg = strMsg & "<table align='center' width='600' border='1' cellspacing='0' cellpadding='0' style='border:1px solid #333'>"
            strMsg = strMsg & "<tr><td>Your Ticket ID</td>"
            strMsg = strMsg & "<td>" + txtID.Text + "</td>"
            strMsg = strMsg & "</tr>"
            strMsg = strMsg & "<tr><td>Category</td>"
            strMsg = strMsg & "<td>" + txtCategory.Text + "</td>"
            strMsg = strMsg & "</tr>"
            strMsg = strMsg & "<tr><td>Description</td>"
            strMsg = strMsg & "<td>" + txtDescription.Text + "</td>"
            strMsg = strMsg & "</tr>"
            strMsg = strMsg & "<tr><td>Status</td>"
            strMsg = strMsg & "<td>" + txtStatus.Text + "</td>"
            strMsg = strMsg & "</tr>"
            strMsg = strMsg & "<tr><td>Assist by</td>"
            strMsg = strMsg & "<td>" + UsernameAdmin.Text + "</td>"
            strMsg = strMsg & "</tr>"
            strMsg = strMsg & "<tr><td>Notes</td>"
            strMsg = strMsg & "<td>" + txtNotes.Text + "</td>"
            strMsg = strMsg & "</tr></table></table></center><br>"
            strMsg = strMsg & "For any concerns regarding this request please dial or Call local 704.  <br><br>"
            strMsg = strMsg & "Thank you For Using Trouble Ticket system. <br><br>"
            strMsg = strMsg & "Marcventures Information Technology Team <br><br>"
            strMsg = strMsg & "<b>*** This Is a system generated message. Do Not REPLY To THIS EMAIL.***</b></body></html>"
            mail.Body = strMsg
            mail.IsBodyHtml = True
            Smtp_Server.Port = 587
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("troubleticketsystem1@gmail.com", "Mightyzxc022")
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(mail)
            MsgBox("Email Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles UsernameAdmin.Click
        'Label1.Text = Environment.UserName
    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        If SQL.HasConnection = True Then
            If getwork() = True Then

                getFormsuccess()

            End If
        End If

        txtNotes.Clear()

    End Sub




    Public Function getwork() As Boolean
        'clear existing records
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()

        End If

        SQL.RunQuery("Select count(*) As RequestCount from (Select requestid, name FROM Request " &
                    "EXCEPT " &
                   "Select requestid, name FROM acceptdata$) a ")
        If SQL.SQLDS.Tables(0).Rows(0).Item("RequestCount") > 0 Then
            Return True
        End If
        MsgBox("No New Ticket", MsgBoxStyle.Information, "Trouble Ticket")
        Return False


    End Function


    Public Sub getFormsuccess()



        SQL.ExecQuery("Select requestid, name, Priority FROM Request " &
                    "EXCEPT " &
                   "Select requestid, name,Priority FROM acceptdata$ ")
        If SQL.HasExCeption(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            For Each R As DataRow In SQL.DBDT.Rows
                FrmSuccess.lbUser1.Text = R("Name")
                FrmSuccess.RequestId.Text = R("RequestID")
                FrmSuccess.txtPriority.Text = R("Priority")


            Next

        End If

        FrmSuccess.Show()

    End Sub

    Private Sub EodContinuation()

        SQL.RunQuery("Select Productive,Lunchbreak,Meeting " &
                      "From EOD " &
         "WHERE  datediff(day,EODDATE,GETDATE()) = 0 " &
                     "GROUP BY Productive,Lunchbreak,Meeting,datediff(day,EodDATE,GETDATE()) ")
        For Each i As Object In SQL.SQLDS.Tables(0).Rows
            ProductiveTimeLabel.Text = i.item("Productive")
            LunchTimeLabel.Text = i.item("Lunchbreak")
            MeetingTimelabel.Text = i.item("Meeting")

        Next

    End Sub


    Private Sub EOD() 'END OF DAY
        SQL.AddParam("@Productive", ProductiveTimeLabel.Text)
        SQL.AddParam("@Lunch", LunchTimeLabel.Text)
        SQL.AddParam("@RequestResolve", RequestResolved.Text)
        SQL.AddParam("@RequestOnhold", OnholdRequest.Text)
        SQL.AddParam("@user", UsernameAdmin.Text)
        SQL.AddParam("@meeting", MeetingTimelabel.Text)

        SQL.ExecQuery("insert into EOD(Username,Productive,LunchBreak,Meeting,RequestResolved,RequestOnhold,EODDate)" &
                      "Values(@user,@Productive,@Lunch,@meeting,@RequestResolve,@RequestOnhold,GETDATE());", True)

        'get errors and abort
        If SQL.HasExCeption(True) Then Exit Sub

        MsgBox("End Of day save")
    End Sub



    Private sw1 As New Stopwatch


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbProductive.CheckedChanged


        If rbProductive.Checked = True Then Me.sw1.Start() Else Me.sw1.Stop()
        If rbProductive.Checked = True Then Me.Timer1.Start()


        If rbProductive.Checked = True Then MessageBox.Show("You selected Productive")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed = Me.sw1.Elapsed

        If rbProductive.Checked = False Then Timer1.Stop()

        ProductiveTimeLabel.Text = String.Format("{0}:{1}:{2}", sw1.Elapsed.Hours.ToString("00"), sw1.Elapsed.Minutes.ToString("00"), sw1.Elapsed.Seconds.ToString("00"))


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Login.Show()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbStartUp.CheckedChanged



    End Sub
    Private sw2 As New Stopwatch
    Private Sub LunchBreakRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbLunchBreak.CheckedChanged

        If rbLunchBreak.Checked = True Then Me.sw2.Start() Else Me.sw2.Stop()
        If rbLunchBreak.Checked = True Then Me.Timer2.Start()


        If rbLunchBreak.Checked = True Then MessageBox.Show("You selected LunchBreak")


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim elapsed = Me.sw2.Elapsed

        If rbLunchBreak.Checked = False Then Timer2.Stop()


        LunchTimeLabel.Text = String.Format("{0}:{1}:{2}", sw2.Elapsed.Hours.ToString("00"), sw2.Elapsed.Minutes.ToString("00"), sw2.Elapsed.Seconds.ToString("00"))
    End Sub

    Private Sub LogOffRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbLogOff.CheckedChanged
        EOD()
        If rbLogOff.Checked = True Then MessageBox.Show("Log Off")

        Frontpage.Close()
        Me.Close()
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        ShowRecords.Show()

    End Sub

    Private Sub msiNewUser_Click(sender As Object, e As EventArgs) Handles msiNewUser.Click
        NewUser.Show()
    End Sub

    Private Sub msiEditUser_Click(sender As Object, e As EventArgs) Handles msiEditUser.Click
        EditUser.Show()
    End Sub

    Private Sub msiDeleteUser_Click(sender As Object, e As EventArgs) Handles msiDeleteUser.Click
        DeleteUser.Show()
    End Sub
    Private sw4 As New Stopwatch
    Public Sub txtFname_Lname_TextChanged(sender As Object, e As EventArgs) Handles txtFname_Lname.TextChanged
        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) = False Then Me.sw4.Start()  'rph
        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) = True Then Me.sw4.Stop()
        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) = False Then Me.Timer4.Start()
        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) = True Then Me.Timer4.Stop()
        getFormInfo(txtFname_Lname.Text)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim elapsed = Me.sw4.Elapsed




        lbRph.Text = String.Format("{0}:{1}:{2}", sw4.Elapsed.Hours.ToString("00"), sw4.Elapsed.Minutes.ToString("00"), sw4.Elapsed.Seconds.ToString("00"))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        GetUserDetails(lbUsers.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SendMail()

        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) Then

            MessageBox.Show("You have entered a blank name")

        ElseIf txtFname_Lname.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no name that starts with space!")
        Else
            UpdateRequest()
            FetchUsers()
            FetchUsersOnhold()
            countResolved()
            countPending()

            txtFname_Lname.Clear()
            txtDescription.Clear()
            txtNotes.Clear()
            txtDepartment.Clear()
            txtEmail.Clear()
            txtCategory.Clear()
            txtPriority.Clear()
            txtSite.Clear()
            txtSubject.Clear()
            txtID.Clear()
            txtSite.Clear()
            txtDuedate.Clear()
            txtStatus.SelectedIndex = -1
            sw4.Stop()
            Timer4.Stop()
            sw4.Reset()
            lbRph.Text = "00:00:00"
        End If



    End Sub

    Private Sub txtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtStatus.SelectedIndexChanged

    End Sub

    Private Sub txtStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStatus.KeyPress
        e.Handled = True
    End Sub




    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click

        ' Dim i, j As Integer

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = CreateObject("Excel.Application")
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        SQL.DbCon.Open()
        SQL.Dbcmd = New SqlCommand("SELECT * FROM request where (status Like 'resolved%' or status like 'Onhold%') and datediff(day,UPDATEDATE,GETDATE()) = 0  ", SQL.DbCon)

        SQL.SQLDA = New SqlDataAdapter(SQL.Dbcmd)
        SQL.SQLDS = New DataSet
        SQL.SQLDA.Fill(SQL.SQLDS)

        Dim i As Integer = 1
        For col = 0 To SQL.SQLDS.Tables(0).Columns.Count - 1
            xlWorkSheet.Cells(1, i).value = SQL.SQLDS.Tables(0).Columns(col).ColumnName
            xlWorkSheet.Cells(1, i).EntireRow.Font.Bold = True
            i += 1
        Next
        i = 2
        Dim j As Integer = 1
        For col = 0 To SQL.SQLDS.Tables(0).Columns.Count - 1
            i = 2
            For row = 0 To SQL.SQLDS.Tables(0).Rows.Count - 1
                xlWorkSheet.Cells(i, j).Value = SQL.SQLDS.Tables(0).Rows(row).ItemArray(col)
                i += 1
            Next
            j += 1
        Next

        'For i = 0 To SQL.SQLDS.Tables(0).Rows.Count - 1
        'For j = 0 To SQL.SQLDS.Tables(0).Columns.Count - 1
        ' xlWorkSheet.Cells(i + 1, j + 1) =
        'SQL.SQLDS.Tables(0).Rows(i).Item(j)
        'Next
        ' Next

        xlWorkSheet.SaveAs("C:\Users\Super Admin\Desktop\EOD.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        SQL.DbCon.Close()

        MsgBox("You can find the file Desktop\EOD.xlsx")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub




    Private Sub lbOnhold_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbOnhold.SelectedIndexChanged
        GetUserOnhold(lbOnhold.Text)
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        If Not String.IsNullOrWhiteSpace(txtNotes.Text) Then
            cmdSave.Enabled = True
        End If
    End Sub
    Private sw3 As New Stopwatch
    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Rbmeeting.CheckedChanged
        If Rbmeeting.Checked = True Then Me.sw3.Start() Else Me.sw3.Stop()
        If Rbmeeting.Checked = True Then Me.Timer3.Start()


        If Rbmeeting.Checked = True Then MessageBox.Show("You selected Meeting")
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim elapsed = Me.sw3.Elapsed

        If Rbmeeting.Checked = False Then Timer3.Stop()


        MeetingTimelabel.Text = String.Format("{0}:{1}:{2}", sw3.Elapsed.Hours.ToString("00"), sw3.Elapsed.Minutes.ToString("00"), sw3.Elapsed.Seconds.ToString("00"))
    End Sub



    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub txtDuedate_TextChanged(sender As Object, e As EventArgs) Handles txtDuedate.TextChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub cmdExtract_MouseHover(sender As Object, e As EventArgs) Handles cmdExtract.MouseHover
        cmdExtract.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdExtract_MouseLeave(sender As Object, e As EventArgs) Handles cmdExtract.MouseLeave
        cmdExtract.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmdShow_MouseHover(sender As Object, e As EventArgs) Handles cmdShow.MouseHover
        cmdShow.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdShow_MouseLeave(sender As Object, e As EventArgs) Handles cmdShow.MouseLeave
        cmdShow.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged

    End Sub

    Private Sub AdminForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SqlDependency.Stop("Server=VPCONTROLLER\SQLEXPRESS;Database = Request;Integrated security=true;")
    End Sub

    Private Sub SolutionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolutionsToolStripMenuItem.Click

    End Sub

    Private Sub UpdateSolutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSolutionToolStripMenuItem.Click
        CreateSolution.Show()
    End Sub

    Private Sub UpdateSolutionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateSolutionToolStripMenuItem1.Click
        UpdateSolution.Show()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub AdminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes

                Frontpage.Close()
            'nothing to do here the form is already closing
            Case Windows.Forms.DialogResult.No
                e.Cancel = True 'cancel the form closing event
                'minimize to tray/hide etc here 
        End Select
        Login.Close()
    End Sub

    Private Sub CreateAnnouncementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnnouncementToolStripMenuItem.Click
        An.Show()
    End Sub

    Private Sub UpdateAnnouncementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnnouncementToolStripMenuItem.Click
        UpdateAn.Show()
    End Sub
End Class