<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtkota = New System.Windows.Forms.TextBox()
        Me.TxtKdInternal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Txttlpn = New System.Windows.Forms.TextBox()
        Me.TxtHp = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.Txtpos = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.ChkStatAktif = New System.Windows.Forms.CheckBox()
        Me.DgCustomer = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdHapus)
        Me.GroupBox3.Controls.Add(Me.CmdBatal)
        Me.GroupBox3.Controls.Add(Me.CmdSimpan)
        Me.GroupBox3.Controls.Add(Me.CmdExit)
        Me.GroupBox3.Location = New System.Drawing.Point(871, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(135, 506)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ChkStatAktif)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtCatatan)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Txtpos)
        Me.GroupBox1.Controls.Add(Me.TxtFax)
        Me.GroupBox1.Controls.Add(Me.TxtHp)
        Me.GroupBox1.Controls.Add(Me.Txttlpn)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txtkota)
        Me.GroupBox1.Controls.Add(Me.TxtKdInternal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtcustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 281)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(562, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 14)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "No.Fax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(325, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 14)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Kode Pos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Catatan"
        '
        'Txtkota
        '
        Me.Txtkota.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtkota.Location = New System.Drawing.Point(116, 80)
        Me.Txtkota.Name = "Txtkota"
        Me.Txtkota.Size = New System.Drawing.Size(326, 22)
        Me.Txtkota.TabIndex = 47
        '
        'TxtKdInternal
        '
        Me.TxtKdInternal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKdInternal.Location = New System.Drawing.Point(116, 48)
        Me.TxtKdInternal.Name = "TxtKdInternal"
        Me.TxtKdInternal.Size = New System.Drawing.Size(111, 22)
        Me.TxtKdInternal.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 14)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Kode Internal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Telepon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Email"
        '
        'Txtcustomer
        '
        Me.Txtcustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcustomer.Location = New System.Drawing.Point(233, 48)
        Me.Txtcustomer.Name = "Txtcustomer"
        Me.Txtcustomer.Size = New System.Drawing.Size(512, 22)
        Me.Txtcustomer.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Kode "
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKode.Enabled = False
        Me.txtKode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(20, 48)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(90, 22)
        Me.txtKode.TabIndex = 38
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlamat.Location = New System.Drawing.Point(116, 109)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(699, 22)
        Me.TxtAlamat.TabIndex = 52
        '
        'Txttlpn
        '
        Me.Txttlpn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttlpn.Location = New System.Drawing.Point(116, 139)
        Me.Txttlpn.Name = "Txttlpn"
        Me.Txttlpn.Size = New System.Drawing.Size(203, 22)
        Me.Txttlpn.TabIndex = 53
        '
        'TxtHp
        '
        Me.TxtHp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHp.Location = New System.Drawing.Point(353, 139)
        Me.TxtHp.Name = "TxtHp"
        Me.TxtHp.Size = New System.Drawing.Size(203, 22)
        Me.TxtHp.TabIndex = 54
        '
        'TxtFax
        '
        Me.TxtFax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFax.Location = New System.Drawing.Point(612, 137)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(203, 22)
        Me.TxtFax.TabIndex = 55
        '
        'Txtpos
        '
        Me.Txtpos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpos.Location = New System.Drawing.Point(512, 76)
        Me.Txtpos.Name = "Txtpos"
        Me.Txtpos.Size = New System.Drawing.Size(203, 22)
        Me.Txtpos.TabIndex = 56
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(116, 167)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(238, 22)
        Me.TxtEmail.TabIndex = 57
        '
        'TxtCatatan
        '
        Me.TxtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCatatan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCatatan.Location = New System.Drawing.Point(116, 195)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(599, 78)
        Me.TxtCatatan.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(230, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 14)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Nama Customer"
        '
        'cmdHapus
        '
        Me.cmdHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Image = Global.EPOS.My.Resources.Resources.Cancel_File_32x32__1
        Me.cmdHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHapus.Location = New System.Drawing.Point(6, 106)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(121, 37)
        Me.cmdHapus.TabIndex = 5
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdBatal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBatal.Image = Global.EPOS.My.Resources.Resources.Undo
        Me.CmdBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdBatal.Location = New System.Drawing.Point(6, 63)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(121, 37)
        Me.CmdBatal.TabIndex = 4
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSimpan.Image = Global.EPOS.My.Resources.Resources.Save_File__32x32_
        Me.CmdSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSimpan.Location = New System.Drawing.Point(6, 20)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(121, 37)
        Me.CmdSimpan.TabIndex = 3
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdExit
        '
        Me.CmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Image = Global.EPOS.My.Resources.Resources.Logout_icon
        Me.CmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdExit.Location = New System.Drawing.Point(8, 463)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(121, 37)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "Tutup"
        Me.CmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'ChkStatAktif
        '
        Me.ChkStatAktif.AutoSize = True
        Me.ChkStatAktif.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkStatAktif.Location = New System.Drawing.Point(729, 256)
        Me.ChkStatAktif.Name = "ChkStatAktif"
        Me.ChkStatAktif.Size = New System.Drawing.Size(93, 17)
        Me.ChkStatAktif.TabIndex = 61
        Me.ChkStatAktif.Text = "Status Aktif"
        Me.ChkStatAktif.UseVisualStyleBackColor = True
        '
        'DgCustomer
        '
        Me.DgCustomer.AllowUserToAddRows = False
        Me.DgCustomer.AllowUserToDeleteRows = False
        Me.DgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCustomer.Location = New System.Drawing.Point(12, 295)
        Me.DgCustomer.Name = "DgCustomer"
        Me.DgCustomer.ReadOnly = True
        Me.DgCustomer.Size = New System.Drawing.Size(840, 217)
        Me.DgCustomer.TabIndex = 61
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 528)
        Me.Controls.Add(Me.DgCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCustomer"
        Me.Text = "Master Customer"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Txtpos As System.Windows.Forms.TextBox
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents TxtHp As System.Windows.Forms.TextBox
    Friend WithEvents Txttlpn As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtkota As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdInternal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents ChkStatAktif As System.Windows.Forms.CheckBox
    Friend WithEvents DgCustomer As System.Windows.Forms.DataGridView
End Class
