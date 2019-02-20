Public Class frmMenuUtama

    Private Sub CmdGud_Click(sender As System.Object, e As System.EventArgs) Handles CmdGud.Click

    End Sub

    Private Sub CmdTutup_Click(sender As System.Object, e As System.EventArgs) Handles CmdTutup.Click
        End
    End Sub

    Private Sub CmdSysAdmin_Click(sender As System.Object, e As System.EventArgs) Handles CmdSysAdmin.Click

        frmModSysAdmin.Show()
    End Sub

    Private Sub frmMenuUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdSwith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSwith.Click
        Me.Close()
        With frmLogin

            Bersih(.GroupBox1)


            .Show()
            .Focus()
        End With

    End Sub
End Class