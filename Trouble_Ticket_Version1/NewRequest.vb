Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Public Class NewRequest
    Public sql As New SqlControl

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GETuserInfo()

        Me.MaximumSize = New Size(5000, Screen.PrimaryScreen.Bounds.Height)


        LoadCBX()
        If Requester.Text = Requester.Text Then txtFname_Lname.Text = Requester.Text
    End Sub
    Private Sub GETuserInfo()

        sql.RunQuery("SELECT Admin,username,Email_Address " &
      "FROM members " &
     "WHERE UserName='" & Login.AuthUser & "' ")

        For Each i As Object In sql.SQLDS.Tables(0).Rows
            txtFname_Lname.Text = i.item("username")
            Me.Text = i.item("username")
            txtEmail.Text = i.item("Email_Address")
        Next



    End Sub

    Private Sub SendMail()

        Try
            Dim strBody As String = ""
            Dim mail As New MailMessage
            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("troubleticketsystem1@gmail.com")
            mail.To.Add(txtEmail.Text)
            If sql.DBDT.Rows.Count > 0 Then
                Dim r As DataRow = sql.DBDT.Rows(0)
                mail.Subject = "Your Ticket ID has been successfully created : " + r.Item("LastID").ToString
            End If
            strBody = ""
            strBody += "<html><body><p></p>"
            strBody += "Dear " + txtFname_Lname.Text + ",<p></p>"
            strBody += "You have successfully created your trouble ticket request with the following details:<p></p>"
            strBody += "<table width='600' style='border:1px solid #333' >"
            strBody += "<tr align='center'><th><h2><center><span style='color:#006400'>Trouble Ticket Request Details</span></center></th></h2></tr>"
            strBody += "<table align='center' width='600' border='1' cellspacing='0' cellpadding='0' style='border:1px solid #333'>"
            If sql.DBDT.Rows.Count > 0 Then
                Dim r As DataRow = sql.DBDT.Rows(0)
                strBody += "<tr><td>Your Ticket ID</td><td> " + r.Item("LastID").ToString + "</td></tr>"
            End If
            strBody += "<tr><td>Department</td><td>" + TxtDepartment.Text + "</td></tr>"
            strBody += "<tr><td>Category</td><td> " + txtCategory.Text + "</td></tr>"
            strBody += "<tr><td>Priority</td><td> " + txtPriority.Text + "</td></tr>"
            strBody += "<tr><td>Complain</td><td> " + txtSubject.Text + "</td></tr>"
            strBody += "<tr><td>Description</td><td>  " + txtDescription.Text + "</td></tr>"
            strBody += "<tr><td>Site</td><td>" + txtSite.Text + "</td></tr></table></table></center><br>"
            strBody += "For any concerns regarding this request please dial local 704  <br><br>"
            strBody += "Thank you for using Trouble Ticket System <br><br>"
            strBody += "Marcventures Information Technology Team <br><br>"
            strBody += "<b>*** This is a system generated message. DO NOT REPLY TO THIS EMAIL.***</b></body></html>"
            mail.Body = strBody
            mail.IsBodyHtml = True
            Smtp_Server.Port = 587
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("troubleticketsystem1@gmail.com", "Mightyzxc022")
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(mail)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub GetTemplate(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template$ " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            txtSubject.Text = R("Subject")
            txtDescription.Text = R("Description")

        Next
    End Sub
    Private Sub LoadCBX()
        'REFRESH ITEMS OR COMBOBOX
        cbxTemplate.Items.Clear()
        'run query

        sql.ExecQuery("SELECT Template from Template$ ORDER BY Template ASC;")

        If sql.HasExCeption(True) Then Exit Sub

        'loop row add combobox

        For Each r As DataRow In sql.DBDT.Rows
            cbxTemplate.Items.Add(r("Template").ToString)
        Next



    End Sub

    Public Sub DueDate()

        Dim current = DateTime.Now.AddHours(1)
        MsgBox(current.ToString(), MsgBoxStyle.Information, "I.T. Personnel will attend your Request DueDate:")

    End Sub
    Private Sub InsertRequest()
        'add paramater and add a command
        sql.AddParam("@Fname_Lname", txtFname_Lname.Text)
        sql.AddParam("@Category", txtCategory.Text)
        sql.AddParam("@Priority", txtPriority.Text)
        sql.AddParam("@Subject", txtSubject.Text)
        sql.AddParam("@Description", txtDescription.Text)
        sql.AddParam("@site", txtSite.Text)
        sql.AddParam("@Department", TxtDepartment.Text)

        sql.ExecQuery("declare @num_hours int;" &
                       "set @num_hours = 1;" &
            "insert into Request(Name, Category, Priority, Subject, Description, Site, Status, Department, DateRequest , DuebyDate)" &
                      "Values(@Fname_Lname,@Category,@Priority,@Subject,@Description,@site,'Open',@Department,GETDATE(),dateadd(HOUR, @num_hours, getdate()));", True)

        'get errors and abort
        If sql.HasExCeption(True) Then Exit Sub

        If sql.DBDT.Rows.Count > 0 Then
            Dim r As DataRow = sql.DBDT.Rows(0)
            MsgBox(r("LastID").ToString, MsgBoxStyle.Information, "Ticket ID")

        End If
        MsgBox("Request Created Successfully!")





    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged,
            txtCategory.TextChanged, txtPriority.TextChanged, txtSite.TextChanged, TxtDepartment.TextChanged
        If Not String.IsNullOrWhiteSpace(txtFname_Lname.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDescription.Text) AndAlso Not String.IsNullOrWhiteSpace(txtCategory.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPriority.Text) AndAlso Not String.IsNullOrWhiteSpace(txtSite.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtDepartment.Text) Then
            cmdSubmit.Enabled = True
        End If

    End Sub




    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPriority.KeyPress
        e.Handled = True
    End Sub


    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSite.KeyPress
        e.Handled = True
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click


        If String.IsNullOrWhiteSpace(txtFname_Lname.Text) Then

            MessageBox.Show("You have entered a blank name")

        ElseIf txtFname_Lname.Text(0) = " " Then 'First letter is a space
            MessageBox.Show("Theres no name that starts with space!")
        ElseIf TxtDepartment.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Department!")
        ElseIf txtCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Category!")
        ElseIf txtPriority.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Priority!")
        ElseIf txtSite.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Site!")
        Else
            InsertRequest()
            DueDate()
            SendMail()
            txtDescription.Clear()
            TxtDepartment.SelectedIndex = -1
            txtCategory.SelectedIndex = -1
            txtPriority.SelectedIndex = -1
            txtSite.SelectedIndex = -1
            txtSubject.Clear()

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Requester.GroupBox8.Show()
        Requester.GroupBox1.Show()
        Requester.GroupBox7.Show()

        Me.Close()
    End Sub


    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtDescription.Clear()
        TxtDepartment.SelectedIndex = -1
        txtCategory.SelectedIndex = -1
        txtPriority.SelectedIndex = -1
        txtSite.SelectedIndex = -1
        txtSubject.Clear()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Public selected As String
    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxTemplate.SelectedIndexChanged
        GetTemplate(cbxTemplate.SelectedItem)
        ' Call the ToString() method to get the text.
        'Select Case cbxTemplate.SelectedItem.ToString()

        'Case "Default Request"
        ''  selected = "Default Request"
        'End Select
        ' You need to catch if the selected variable has not value set.
        'txtSubject.Text = selected.ToString()
    End Sub
    Private Sub TemplateComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxTemplate.KeyPress
        e.Handled = True
    End Sub






    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub



    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub



    Private Sub TxtDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDepartment.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmdSubmit_MouseHover(sender As Object, e As EventArgs) Handles cmdSubmit.MouseHover
        cmdSubmit.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdSubmit_MouseLeave(sender As Object, e As EventArgs) Handles cmdSubmit.MouseLeave
        cmdSubmit.BackColor = Color.DarkGreen
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles cmdClear.MouseHover
        cmdClear.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdClear_MouseLeave(sender As Object, e As EventArgs) Handles cmdClear.MouseLeave
        cmdClear.BackColor = Color.DarkGreen
    End Sub

    Private Sub cmdCancel_MouseHover(sender As Object, e As EventArgs) Handles cmdCancel.MouseHover
        cmdCancel.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdCancel_MouseLeave(sender As Object, e As EventArgs) Handles cmdCancel.MouseLeave
        cmdCancel.BackColor = Color.DarkGreen
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtPriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPriority.SelectedIndexChanged

    End Sub


End Class
