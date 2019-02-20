Public Class FrmSettingDBS

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Call con_getSetting()
        TxtserverName.Text = StrServer
        txtUserId.Text = StrUserid
        txtPassword.Text = StrPass
        TxtDatabase.Text = StrDatabase
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Call con_savesetting(TxtserverName.Text, txtUserId.Text, txtPassword.Text, TxtDatabase.Text)
        MsgBox("Setting disimpan", MsgBoxStyle.Information, "Informasi")
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            txtDatabase.Focus()
        End If
    End Sub

    Private Sub txtDatabase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatabase.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            txtUserId.Focus()
        End If
    End Sub

    Private Sub txtUserId_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserId.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            cmdSave.Focus()
        End If
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = False
            GroupBox1.Enabled = False
            txtUserId.Text = ""
            txtPassword.Text = ""
        Else
            CheckBox1.Checked = True
            GroupBox1.Enabled = True
        End If
    End Sub


    Private Sub FrmSettingDBS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If StrUserid = "" Then
            CheckBox1.Checked = False
            GroupBox1.Enabled = False
            txtUserId.Text = ""
            txtPassword.Text = ""
        Else
            CheckBox1.Checked = True
            GroupBox1.Enabled = True
        End If

        Call cmdCancel_Click(cmdCancel, New System.EventArgs)
        TxtserverName.Select()
    End Sub
End Class