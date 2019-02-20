<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModSysAdmin
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
        Me.PanelLayout = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnLogot = New System.Windows.Forms.Button()
        Me.BtnKonfig = New System.Windows.Forms.Button()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.BtnPegawai = New System.Windows.Forms.Button()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.BtnCustomer = New System.Windows.Forms.Button()
        Me.CmdBrg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLayout
        '
        Me.PanelLayout.AutoSize = True
        Me.PanelLayout.BackColor = System.Drawing.Color.White
        Me.PanelLayout.Location = New System.Drawing.Point(12, 124)
        Me.PanelLayout.Name = "PanelLayout"
        Me.PanelLayout.Size = New System.Drawing.Size(1356, 565)
        Me.PanelLayout.TabIndex = 60
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1378, 19)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'BtnLogot
        '
        Me.BtnLogot.BackgroundImage = Global.EPOS.My.Resources.Resources.LOGOUT_REVISI
        Me.BtnLogot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogot.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogot.Location = New System.Drawing.Point(708, 27)
        Me.BtnLogot.Name = "BtnLogot"
        Me.BtnLogot.Size = New System.Drawing.Size(110, 84)
        Me.BtnLogot.TabIndex = 7
        Me.BtnLogot.Text = "Logout"
        Me.BtnLogot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogot.UseVisualStyleBackColor = True
        '
        'BtnKonfig
        '
        Me.BtnKonfig.BackgroundImage = Global.EPOS.My.Resources.Resources.settting
        Me.BtnKonfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKonfig.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKonfig.Location = New System.Drawing.Point(592, 27)
        Me.BtnKonfig.Name = "BtnKonfig"
        Me.BtnKonfig.Size = New System.Drawing.Size(110, 84)
        Me.BtnKonfig.TabIndex = 6
        Me.BtnKonfig.Text = "Konfigurasi"
        Me.BtnKonfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKonfig.UseVisualStyleBackColor = True
        '
        'BtnProfile
        '
        Me.BtnProfile.BackgroundImage = Global.EPOS.My.Resources.Resources.master_profile
        Me.BtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnProfile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.Location = New System.Drawing.Point(476, 27)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(110, 84)
        Me.BtnProfile.TabIndex = 5
        Me.BtnProfile.Text = "Master Profile"
        Me.BtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProfile.UseVisualStyleBackColor = True
        '
        'BtnPegawai
        '
        Me.BtnPegawai.BackgroundImage = Global.EPOS.My.Resources.Resources.master_pegawai
        Me.BtnPegawai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPegawai.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPegawai.Location = New System.Drawing.Point(360, 27)
        Me.BtnPegawai.Name = "BtnPegawai"
        Me.BtnPegawai.Size = New System.Drawing.Size(110, 84)
        Me.BtnPegawai.TabIndex = 4
        Me.BtnPegawai.Text = "Master Pegawai"
        Me.BtnPegawai.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPegawai.UseVisualStyleBackColor = True
        '
        'BtnSupplier
        '
        Me.BtnSupplier.BackgroundImage = Global.EPOS.My.Resources.Resources.master_supplyer
        Me.BtnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSupplier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupplier.Location = New System.Drawing.Point(244, 27)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Size = New System.Drawing.Size(110, 84)
        Me.BtnSupplier.TabIndex = 3
        Me.BtnSupplier.Text = "Master Supplier"
        Me.BtnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSupplier.UseVisualStyleBackColor = True
        '
        'BtnCustomer
        '
        Me.BtnCustomer.BackgroundImage = Global.EPOS.My.Resources.Resources.master_customer
        Me.BtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomer.Location = New System.Drawing.Point(128, 27)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(110, 84)
        Me.BtnCustomer.TabIndex = 2
        Me.BtnCustomer.Text = "Master Customer"
        Me.BtnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCustomer.UseVisualStyleBackColor = True
        '
        'CmdBrg
        '
        Me.CmdBrg.BackgroundImage = Global.EPOS.My.Resources.Resources.master_barang
        Me.CmdBrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdBrg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBrg.Location = New System.Drawing.Point(12, 27)
        Me.CmdBrg.Name = "CmdBrg"
        Me.CmdBrg.Size = New System.Drawing.Size(110, 84)
        Me.CmdBrg.TabIndex = 0
        Me.CmdBrg.Text = "Master Barang"
        Me.CmdBrg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdBrg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EPOS.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1378, 106)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmModSysAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 701)
        Me.Controls.Add(Me.PanelLayout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnLogot)
        Me.Controls.Add(Me.BtnKonfig)
        Me.Controls.Add(Me.BtnProfile)
        Me.Controls.Add(Me.BtnPegawai)
        Me.Controls.Add(Me.BtnSupplier)
        Me.Controls.Add(Me.BtnCustomer)
        Me.Controls.Add(Me.CmdBrg)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "frmModSysAdmin"
        Me.Text = "Modul System Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdBrg As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnSupplier As System.Windows.Forms.Button
    Friend WithEvents BtnPegawai As System.Windows.Forms.Button
    Friend WithEvents BtnProfile As System.Windows.Forms.Button
    Friend WithEvents BtnKonfig As System.Windows.Forms.Button
    Friend WithEvents BtnLogot As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLayout As System.Windows.Forms.Panel
End Class
