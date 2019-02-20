<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdTutup = New System.Windows.Forms.Button()
        Me.CmdSwith = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdGud = New System.Windows.Forms.Button()
        Me.CmdPenj = New System.Windows.Forms.Button()
        Me.CmdPemb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmdSysAdmin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(454, 320)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(90, 30)
        Me.CmdTutup.TabIndex = 13
        Me.CmdTutup.Text = "Exit"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdSwith
        '
        Me.CmdSwith.Location = New System.Drawing.Point(358, 320)
        Me.CmdSwith.Name = "CmdSwith"
        Me.CmdSwith.Size = New System.Drawing.Size(90, 30)
        Me.CmdSwith.TabIndex = 12
        Me.CmdSwith.Text = "Switch User"
        Me.CmdSwith.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 172)
        Me.Panel1.TabIndex = 14
        '
        'CmdGud
        '
        Me.CmdGud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGud.Image = Global.EPOS.My.Resources.Resources.inventory
        Me.CmdGud.Location = New System.Drawing.Point(416, 35)
        Me.CmdGud.Name = "CmdGud"
        Me.CmdGud.Size = New System.Drawing.Size(128, 99)
        Me.CmdGud.TabIndex = 11
        Me.CmdGud.Text = "Gudang"
        Me.CmdGud.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdGud.UseVisualStyleBackColor = True
        '
        'CmdPenj
        '
        Me.CmdPenj.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPenj.Image = Global.EPOS.My.Resources.Resources.penjualan
        Me.CmdPenj.Location = New System.Drawing.Point(282, 35)
        Me.CmdPenj.Name = "CmdPenj"
        Me.CmdPenj.Size = New System.Drawing.Size(128, 99)
        Me.CmdPenj.TabIndex = 10
        Me.CmdPenj.Text = "Penjualan"
        Me.CmdPenj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdPenj.UseVisualStyleBackColor = True
        '
        'CmdPemb
        '
        Me.CmdPemb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPemb.Image = Global.EPOS.My.Resources.Resources.pembelian
        Me.CmdPemb.Location = New System.Drawing.Point(148, 35)
        Me.CmdPemb.Name = "CmdPemb"
        Me.CmdPemb.Size = New System.Drawing.Size(128, 99)
        Me.CmdPemb.TabIndex = 9
        Me.CmdPemb.Text = "Pembelian"
        Me.CmdPemb.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdPemb.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(573, 32)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CmdSysAdmin
        '
        Me.CmdSysAdmin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSysAdmin.Image = Global.EPOS.My.Resources.Resources.administrator_icon_60px
        Me.CmdSysAdmin.Location = New System.Drawing.Point(12, 35)
        Me.CmdSysAdmin.Name = "CmdSysAdmin"
        Me.CmdSysAdmin.Size = New System.Drawing.Size(128, 99)
        Me.CmdSysAdmin.TabIndex = 7
        Me.CmdSysAdmin.Text = "SysAdmin"
        Me.CmdSysAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSysAdmin.UseVisualStyleBackColor = True
        '
        'frmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdSwith)
        Me.Controls.Add(Me.CmdGud)
        Me.Controls.Add(Me.CmdPenj)
        Me.Controls.Add(Me.CmdPemb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CmdSysAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents CmdSwith As System.Windows.Forms.Button
    Friend WithEvents CmdGud As System.Windows.Forms.Button
    Friend WithEvents CmdPenj As System.Windows.Forms.Button
    Friend WithEvents CmdPemb As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdSysAdmin As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
