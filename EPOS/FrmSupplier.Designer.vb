<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtAtasNama = New System.Windows.Forms.TextBox()
        Me.TxtBank = New System.Windows.Forms.TextBox()
        Me.TxtRekening = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.txtHp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPos = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Txttlpn = New System.Windows.Forms.TextBox()
        Me.TxtKota = New System.Windows.Forms.TextBox()
        Me.TxtNpwp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSupplier = New System.Windows.Forms.TextBox()
        Me.TxtKdIntrnal = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtWebsite = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DgSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdHapus)
        Me.GroupBox3.Controls.Add(Me.CmdBatal)
        Me.GroupBox3.Controls.Add(Me.CmdSimpan)
        Me.GroupBox3.Controls.Add(Me.CmdExit)
        Me.GroupBox3.Location = New System.Drawing.Point(926, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(135, 506)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TxtWebsite)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtCatatan)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtFax)
        Me.GroupBox1.Controls.Add(Me.txtHp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtPos)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.Txttlpn)
        Me.GroupBox1.Controls.Add(Me.TxtKota)
        Me.GroupBox1.Controls.Add(Me.TxtNpwp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSupplier)
        Me.GroupBox1.Controls.Add(Me.TxtKdIntrnal)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 313)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.TxtAtasNama)
        Me.GroupBox2.Controls.Add(Me.TxtBank)
        Me.GroupBox2.Controls.Add(Me.TxtRekening)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 62)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        '
        'TxtAtasNama
        '
        Me.TxtAtasNama.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtAtasNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtasNama.Location = New System.Drawing.Point(549, 34)
        Me.TxtAtasNama.Name = "TxtAtasNama"
        Me.TxtAtasNama.Size = New System.Drawing.Size(301, 22)
        Me.TxtAtasNama.TabIndex = 60
        '
        'TxtBank
        '
        Me.TxtBank.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBank.Location = New System.Drawing.Point(276, 34)
        Me.TxtBank.Name = "TxtBank"
        Me.TxtBank.Size = New System.Drawing.Size(267, 22)
        Me.TxtBank.TabIndex = 59
        '
        'TxtRekening
        '
        Me.TxtRekening.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtRekening.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRekening.Location = New System.Drawing.Point(9, 34)
        Me.TxtRekening.Name = "TxtRekening"
        Me.TxtRekening.Size = New System.Drawing.Size(261, 22)
        Me.TxtRekening.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(546, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 14)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Atas Nama"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 14)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "No.Rekening"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(273, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 14)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Bank"
        '
        'TxtFax
        '
        Me.TxtFax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFax.Location = New System.Drawing.Point(671, 114)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(203, 22)
        Me.TxtFax.TabIndex = 64
        '
        'txtHp
        '
        Me.txtHp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHp.Location = New System.Drawing.Point(412, 116)
        Me.txtHp.Name = "txtHp"
        Me.txtHp.Size = New System.Drawing.Size(203, 22)
        Me.txtHp.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(621, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 14)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "No.Fax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 14)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Kode Pos"
        '
        'TxtPos
        '
        Me.TxtPos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPos.Location = New System.Drawing.Point(556, 62)
        Me.TxtPos.Name = "TxtPos"
        Me.TxtPos.Size = New System.Drawing.Size(242, 22)
        Me.TxtPos.TabIndex = 59
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlamat.Location = New System.Drawing.Point(114, 88)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(760, 22)
        Me.TxtAlamat.TabIndex = 58
        '
        'Txttlpn
        '
        Me.Txttlpn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttlpn.Location = New System.Drawing.Point(114, 116)
        Me.Txttlpn.Name = "Txttlpn"
        Me.Txttlpn.Size = New System.Drawing.Size(261, 22)
        Me.Txttlpn.TabIndex = 57
        '
        'TxtKota
        '
        Me.TxtKota.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKota.Location = New System.Drawing.Point(114, 62)
        Me.TxtKota.Name = "TxtKota"
        Me.TxtKota.Size = New System.Drawing.Size(350, 22)
        Me.TxtKota.TabIndex = 56
        '
        'TxtNpwp
        '
        Me.TxtNpwp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNpwp.Location = New System.Drawing.Point(671, 37)
        Me.TxtNpwp.Name = "TxtNpwp"
        Me.TxtNpwp.Size = New System.Drawing.Size(213, 22)
        Me.TxtNpwp.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Nama Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(668, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "NPWP"
        '
        'TxtSupplier
        '
        Me.TxtSupplier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplier.Location = New System.Drawing.Point(218, 37)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.Size = New System.Drawing.Size(447, 22)
        Me.TxtSupplier.TabIndex = 52
        '
        'TxtKdIntrnal
        '
        Me.TxtKdIntrnal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKdIntrnal.Location = New System.Drawing.Point(114, 37)
        Me.TxtKdIntrnal.Name = "TxtKdIntrnal"
        Me.TxtKdIntrnal.Size = New System.Drawing.Size(98, 22)
        Me.TxtKdIntrnal.TabIndex = 51
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKode.Enabled = False
        Me.txtKode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(18, 37)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(90, 22)
        Me.txtKode.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 14)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Kode Internal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Kode "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(18, 172)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 18)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Isi Data Bank "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxtCatatan
        '
        Me.TxtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCatatan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCatatan.Location = New System.Drawing.Point(73, 240)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(715, 61)
        Me.TxtCatatan.TabIndex = 69
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Blue
        Me.TxtEmail.Location = New System.Drawing.Point(114, 144)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(261, 22)
        Me.TxtEmail.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Catatan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(20, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 14)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Email"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(384, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 14)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Website"
        '
        'TxtWebsite
        '
        Me.TxtWebsite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWebsite.ForeColor = System.Drawing.Color.Blue
        Me.TxtWebsite.Location = New System.Drawing.Point(442, 144)
        Me.TxtWebsite.Name = "TxtWebsite"
        Me.TxtWebsite.Size = New System.Drawing.Size(292, 22)
        Me.TxtWebsite.TabIndex = 71
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(794, 284)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox2.TabIndex = 72
        Me.CheckBox2.Text = "Status Aktif"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'DgSupplier
        '
        Me.DgSupplier.AllowUserToAddRows = False
        Me.DgSupplier.AllowUserToDeleteRows = False
        Me.DgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSupplier.Location = New System.Drawing.Point(12, 334)
        Me.DgSupplier.Name = "DgSupplier"
        Me.DgSupplier.ReadOnly = True
        Me.DgSupplier.Size = New System.Drawing.Size(908, 184)
        Me.DgSupplier.TabIndex = 62
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1055, 530)
        Me.Controls.Add(Me.DgSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSupplier"
        Me.Text = "Master Supplier"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdIntrnal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents TxtNpwp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPos As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Txttlpn As System.Windows.Forms.TextBox
    Friend WithEvents TxtKota As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAtasNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtBank As System.Windows.Forms.TextBox
    Friend WithEvents TxtRekening As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtHp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TxtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents DgSupplier As System.Windows.Forms.DataGridView
End Class
