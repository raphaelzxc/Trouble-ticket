Imports System.Data.SqlClient

Public Class Requester
    Public sql As New SqlControl
    Private Sub Requester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GroupBox8.Show()
        GroupBox1.Show()
        GroupBox7.Show()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GETuserInfo()
        getAnounce()
    End Sub
    Private Sub GETuserInfo()

        sql.RunQuery("SELECT Admin,username " &
                      "FROM members " &
                      "WHERE UserName='" & Login.AuthUser & "' ")

        For Each i As Object In sql.SQLDS.Tables(0).Rows
            Me.Text = i.item("username")
        Next



    End Sub

    Private Sub getAnounce()

        sql.RunQuery("Select Title,Content,datediff(day,CreateDate,GETDATE()) As Datedifference " &
                      "From Announcement " &
                      "Where datediff(day,CreateDate,GETDATE()) = 0 " &
                        "GROUP BY Title,Content,datediff(day,CreateDate,GETDATE()) ")

        For Each i As Object In sql.SQLDS.Tables(0).Rows
            txtTitle.Text = i.item("Title")
            txtContent.Text = i.item("Content")
        Next


    End Sub
    Private Sub Requester_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next ctl


    End Sub
    Public Sub BrenAttending()
        '  sql.AddParam("@ID", AdminForm.txtID.Text)
        sql.ExecQuery("SELECT * FROM Message " &
         "WHERE MessageId = ( " &
         "SELECT IDENT_CURRENT('Message')) ")

        If sql.HasExCeption(True) Then Exit Sub

        If sql.DBDT.Rows.Count = 1 Then
            For Each R As DataRow In sql.DBDT.Rows
                MsgBox(R("Username") + Environment.NewLine + R("Subject"), MsgBoxStyle.Information, "I.T. Personnel is Currently Assisting  User:")
            Next

        End If




    End Sub
    Private Sub FormTemplate(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template$ " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            NewRequest.txtSubject.Text = R("Subject")
            NewRequest.txtDescription.Text = R("Description")

        Next
    End Sub



    Private Sub GetTemplate1(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("subject2")

            Lbl5.Text = R("subject3")

            NewRequest.txtCategory.Text = R("template")
        Next
    End Sub

    Private Sub GetTemplate2(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("subject2")


        Next
    End Sub
    Private Sub GetTemplate3(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("subject2")

            Lbl5.Text = R("subject3")

            Lbl7.Text = R("subject4")

            lbl9.Text = R("subject5")

        Next
    End Sub
    Private Sub GetTemplate4(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("Subject2")



        Next
    End Sub
    Private Sub GetTemplate5(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("Subject2")

        Next
    End Sub
    Private Sub GetTemplate6(Template As String)
        sql.AddParam("@Template", Template)
        sql.ExecQuery("SELECT * " &
            "FROM Template1 " &
            "WHERE Template = @Template;")


        If sql.RecordCount < 1 Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows

            lbl1.Text = R("Subject")

            Lbl3.Text = R("subject2")

            Lbl5.Text = R("subject3")


        Next
    End Sub
    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click


    End Sub

    Private Sub cmdCommunication_Click(sender As Object, e As EventArgs) Handles cmdCommunication.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate1(cmdCommunication.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub

    Private Sub cmdEmail_Click(sender As Object, e As EventArgs) Handles cmdEmail.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate2(cmdEmail.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub



    Private Sub cmdHardware_Click(sender As Object, e As EventArgs) Handles cmdHardware.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox5.Show()
        GroupBox6.Show()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate3(cmdHardware.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub



    Private Sub cmdInternet_Click(sender As Object, e As EventArgs) Handles cmdInternet.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate4(cmdInternet.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub

    Private Sub cmdSoftware_Click(sender As Object, e As EventArgs) Handles cmdSoftware.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate5(cmdSoftware.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub

    Private Sub cmdOthers_Click(sender As Object, e As EventArgs) Handles cmdOthers.Click
        GroupBox1.Hide()

        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Show()
        GetTemplate6(cmdOthers.Text)
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmChangePassword.Click
        ChangePassword.Show()
    End Sub



    Private Sub lbl1_MouseHover(sender As Object, e As EventArgs)
        lbl1.ForeColor = Color.Blue
    End Sub

    Private Sub lbl1_MouseLeave(sender As Object, e As EventArgs)
        lbl1.ForeColor = Color.Black

    End Sub

    Private Sub Lbl3_MouseHover(sender As Object, e As EventArgs)
        Lbl3.ForeColor = Color.Blue
    End Sub

    Private Sub Lbl3_MouseLeave(sender As Object, e As EventArgs)
        Lbl3.ForeColor = Color.Black

    End Sub

    Private Sub Lbl5_MouseHover(sender As Object, e As EventArgs)
        Lbl5.ForeColor = Color.Blue
    End Sub

    Private Sub Lbl5_MouseLeave(sender As Object, e As EventArgs)
        Lbl5.ForeColor = Color.Black

    End Sub

    Private Sub Lbl7_MouseHover(sender As Object, e As EventArgs)
        Lbl7.ForeColor = Color.Blue
    End Sub

    Private Sub Lbl7_MouseLeave(sender As Object, e As EventArgs)
        Lbl7.ForeColor = Color.Black

    End Sub

    Private Sub lbl9_MouseHover(sender As Object, e As EventArgs)
        lbl9.ForeColor = Color.Blue
    End Sub

    Private Sub lbl9_MouseLeave(sender As Object, e As EventArgs)
        lbl9.ForeColor = Color.Black

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub cmdCommunication_MouseHover(sender As Object, e As EventArgs) Handles cmdCommunication.MouseHover
        cmdCommunication.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdCommunication_MouseLeave(sender As Object, e As EventArgs) Handles cmdCommunication.MouseLeave
        cmdCommunication.BackColor = Color.Gainsboro

    End Sub

    Private Sub cmdEmail_MouseHover(sender As Object, e As EventArgs) Handles cmdEmail.MouseHover
        cmdEmail.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdEmail_MouseLeave(sender As Object, e As EventArgs) Handles cmdEmail.MouseLeave
        cmdEmail.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmdHardware_MouseHover(sender As Object, e As EventArgs) Handles cmdHardware.MouseHover
        cmdHardware.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdHardware_MouseLeave(sender As Object, e As EventArgs) Handles cmdHardware.MouseLeave
        cmdHardware.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmdInternet_MouseHover(sender As Object, e As EventArgs) Handles cmdInternet.MouseHover
        cmdInternet.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdInternet_MouseLeave(sender As Object, e As EventArgs) Handles cmdInternet.MouseLeave
        cmdInternet.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmdSoftware_MouseHover(sender As Object, e As EventArgs) Handles cmdSoftware.MouseHover
        cmdSoftware.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdSoftware_MouseLeave(sender As Object, e As EventArgs) Handles cmdSoftware.MouseLeave
        cmdSoftware.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmdOthers_MouseHover(sender As Object, e As EventArgs) Handles cmdOthers.MouseHover
        cmdOthers.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdOthers_MouseLeave(sender As Object, e As EventArgs) Handles cmdOthers.MouseLeave
        cmdOthers.BackColor = Color.Gainsboro
    End Sub

    Private Sub Requester_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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



    Private Sub lbl1_CheckedChanged_1(sender As Object, e As EventArgs) Handles lbl1.CheckedChanged




        If lbl1.Checked = True Then
            FormTemplate(lbl1.Text)
            NewRequest.MdiParent = Me
            NewRequest.Dock = DockStyle.Fill
            NewRequest.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
            GroupBox8.Hide()
            lbl1.Checked = False
            Lbl3.Checked = False
            Lbl5.Checked = False
            Lbl7.Checked = False
            lbl9.Checked = False
        End If


    End Sub
    Private Sub Lbl3_CheckedChanged_1(sender As Object, e As EventArgs) Handles Lbl3.CheckedChanged



        If Lbl3.Checked = True Then
            FormTemplate(Lbl3.Text)
            NewRequest.MdiParent = Me
            NewRequest.Dock = DockStyle.Fill
            NewRequest.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
            GroupBox8.Hide()
            lbl1.Checked = False
            Lbl3.Checked = False
            Lbl5.Checked = False
            Lbl7.Checked = False
            lbl9.Checked = False
        End If
    End Sub

    Private Sub Lbl5_CheckedChanged(sender As Object, e As EventArgs) Handles Lbl5.CheckedChanged


        If Lbl5.Checked = True Then
            FormTemplate(Lbl5.Text)
            NewRequest.MdiParent = Me
            NewRequest.Dock = DockStyle.Fill
            NewRequest.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
            GroupBox8.Hide()

            Lbl3.Checked = False
            lbl1.Checked = False
            Lbl5.Checked = False
            Lbl7.Checked = False
            lbl9.Checked = False
        End If
    End Sub

    Private Sub Lbl7_CheckedChanged(sender As Object, e As EventArgs) Handles Lbl7.CheckedChanged


        If Lbl7.Checked = True Then
            FormTemplate(Lbl7.Text)
            NewRequest.MdiParent = Me
            NewRequest.Dock = DockStyle.Fill
            NewRequest.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
            GroupBox8.Hide()
            Lbl3.Checked = False
            Lbl5.Checked = False
            lbl1.Checked = False
            Lbl7.Checked = False
            lbl9.Checked = False
        End If
    End Sub

    Private Sub lbl9_CheckedChanged(sender As Object, e As EventArgs) Handles lbl9.CheckedChanged



        If lbl9.Checked = True Then
            FormTemplate(lbl9.Text)
            NewRequest.MdiParent = Me
            NewRequest.Dock = DockStyle.Fill
            NewRequest.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
            GroupBox8.Hide()
            Lbl3.Checked = False
            Lbl5.Checked = False
            Lbl7.Checked = False
            lbl1.Checked = False
            lbl9.Checked = False
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub FindSolutionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindSolutionsToolStripMenuItem.Click

        GroupBox1.Hide()
        FindSolution.MdiParent = Me
        FindSolution.Dock = DockStyle.Fill
        FindSolution.Show()
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Hide()
        UserForm1.Close()
        NewRequest.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRequestStatus.Click
        BrenAttending()
        GroupBox1.Hide()
        UserForm1.MdiParent = Me
        UserForm1.Dock = DockStyle.Fill
        UserForm1.Show()
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox7.Hide()
        GroupBox8.Hide()

        NewRequest.Close()
    End Sub

    Private Sub AdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdToolStripMenuItem.Click
        GroupBox8.Show()
        GroupBox1.Show()
        GroupBox7.Show()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GETuserInfo()
        NewRequest.Close()
        UserForm1.Close()
        FindSolution.Close()
    End Sub

    Private Sub cmdRequestStatus_MouseHover(sender As Object, e As EventArgs) Handles cmdRequestStatus.MouseHover
        cmdRequestStatus.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdRequestStatus_MouseLeave(sender As Object, e As EventArgs) Handles cmdRequestStatus.MouseLeave
        cmdRequestStatus.BackColor = Color.Gainsboro
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
End Class