Public Class frmModSysAdmin

 
    Private Sub CmdBrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBrg.Click
        PanelLayout.Controls.Clear()
        FrmBarang.TopLevel = False
        FrmBarang.TopMost = True
        FrmBarang.MdiParent = Me
        PanelLayout.Controls.Add(FrmBarang)
        FrmBarang.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogot.Click
        Me.Close()
        frmMenuUtama.Show()

    End Sub

    
End Class