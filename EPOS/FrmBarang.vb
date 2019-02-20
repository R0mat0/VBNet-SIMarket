Imports System.Data.SqlClient

Public Class FrmBarang

    Dim StatusChk As Byte

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Function sp_Satuan(ByVal f_status As String) As Boolean
        Try

            Dim sp As SqlClient.SqlTransaction = con.BeginTransaction
            Dim cr_command As SqlClient.SqlCommand = con.CreateCommand
            With cr_command
                .CommandText = "AU_Satuan"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Transaction = sp

                .Parameters.Add("@kode", SqlDbType.Char, 3).Value = Trim(TxtKdSatuan.Text)
                .Parameters.Add("@Satuan", SqlDbType.VarChar, 50).Value = Trim(TxtSatuan.Text)
                .Parameters.Add("@KdKelompok", SqlDbType.Char, 2).Value = Trim(CboKelSatuan.SelectedValue)
                .Parameters.Add("@ket", SqlDbType.VarChar, 100).Value = Trim(TxtKetSatuan.Text)
                .Parameters.Add("@StatusAktif", SqlDbType.TinyInt).Value = IIf(ChkStat2.Enabled = True, 1, 0)

                .Parameters.Add("@Status", SqlDbType.Char, 1).Value = f_status
                .ExecuteNonQuery()
            End With
            sp.Commit()

            Return True
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
             & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
             & ex.Message.ToString, vbCritical, "Validasi")

            Return False
        End Try
    End Function

    Private Function sp_TypeBrg(ByVal f_status As Char) As Boolean
        Try

            Dim sp As SqlClient.SqlTransaction = con.BeginTransaction
            Dim cr_command As SqlClient.SqlCommand = con.CreateCommand
            With cr_command
                .CommandText = "AU_TypeBrg"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Transaction = sp

                .Parameters.Add("@kode", SqlDbType.Char, 3).Value = Trim(TxtKdType.Text)
                .Parameters.Add("@TypeBrg", SqlDbType.VarChar, 50).Value = Trim(TxtTypeBrg.Text)
                .Parameters.Add("@Ket", SqlDbType.VarChar, 100).Value = Trim(TxtKetType.Text)
                .Parameters.Add("@StatusAktif", SqlDbType.TinyInt).Value = IIf(ChkStat3.Enabled = True, 1, 0)

                .Parameters.Add("@Status", SqlDbType.Char, 1).Value = f_status
                .ExecuteNonQuery()
            End With
            sp.Commit()

            Return True
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
             & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
             & ex.Message.ToString, vbCritical, "Validasi")

            Return False
        End Try

    End Function

    Private Function sp_jenisBrg(ByVal f_status As Char) As Boolean
        Try

            Dim sp As SqlClient.SqlTransaction = con.BeginTransaction
            Dim cr_command As SqlClient.SqlCommand = con.CreateCommand
            With cr_command
                .CommandText = "AU_JenisBarang"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Transaction = sp

                .Parameters.Add("@kode", SqlDbType.Char, 3).Value = Trim(TxtKdJenisBrg.Text)
                .Parameters.Add("@JenisBrg", SqlDbType.VarChar, 50).Value = Trim(TxtJenisBrg.Text)
                .Parameters.Add("@Ket", SqlDbType.VarChar, 100).Value = Trim(TxtKetJenisBrg.Text)
                .Parameters.Add("@StatusAktif", SqlDbType.TinyInt).Value = IIf(ChkStat1.Enabled = True, 1, 0)

                .Parameters.Add("@Status", SqlDbType.Char, 1).Value = f_status
                .ExecuteNonQuery()
            End With
            sp.Commit()

            Return True
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
             & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
             & ex.Message.ToString, vbCritical, "Validasi")

            Return False
        End Try

    End Function

    Private Function sp_Barang(ByVal f_status As Char) As Boolean
        Try

            Call KoneksiDatabase()
            Dim sp As SqlClient.SqlTransaction = con.BeginTransaction
            Dim cr_command As SqlClient.SqlCommand = con.CreateCommand
            With cr_command
                .CommandText = "Add_Barang"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Transaction = sp

                .Parameters.Add("@KdBarang", SqlDbType.Char, 9).Value = Trim(txtKode.Text)
                .Parameters.Add("@NamaBrg", SqlDbType.VarChar, 50).Value = Trim(TxtBrg.Text)

                .Parameters.Add("@KdJenisBrg", SqlDbType.Char, 3).Value = Trim(CbJenisBrg.SelectedValue)
                .Parameters.Add("@KdSatuan", SqlDbType.Char, 3).Value = Trim(CbSatuan.SelectedValue)
                .Parameters.Add("@KdType", SqlDbType.Char, 3).Value = Trim(CbTypeBrg.SelectedValue)

                .Parameters.Add("@Merk", SqlDbType.VarChar, 30).Value = Trim(TxtMerk.Text)
                .Parameters.Add("@warna", SqlDbType.VarChar, 30).Value = Trim(Txtwarna.Text)
                .Parameters.Add("@size", SqlDbType.Char, 10).Value = Trim(TxtSize.Text)

                .Parameters.Add("@Konsinyasi", SqlDbType.TinyInt).Value = IIf(ChkKonsinyasi.Checked = True, 1, 0)

                .Parameters.Add("@catatan", SqlDbType.VarChar, 150).Value = Trim(TxtCatatan.Text)
                .Parameters.Add("@panjang", SqlDbType.Float).Value = Val(txtpanjang.Text)
                .Parameters.Add("@Volume", SqlDbType.Float).Value = Val(TxtVol.Text)
                .Parameters.Add("@Dimensi", SqlDbType.Float).Value = Val(TxtDimensi.Text)
                .Parameters.Add("@berat", SqlDbType.Float).Value = Val(Txtberat.Text)

                .Parameters.Add("@StatusFifo", SqlDbType.TinyInt).Value = 0
                .Parameters.Add("@StatInputHarga", SqlDbType.Char).Value = IIf(ChkInputHrg.Checked = True, "Y", "N")
                .Parameters.Add("@HrgPokok", SqlDbType.Money).Value = Val(TxtHrgPokok.Text)
                .Parameters.Add("@HrgJual", SqlDbType.Money).Value = Val(TxtHrgJual.Text)

                .Parameters.Add("@StatInputStok", SqlDbType.Char).Value = IIf(ChkInputStok.Checked = True, "Y", "N")
                .Parameters.Add("@StokReal", SqlDbType.Float).Value = Val(TxtStokReal.Text)
                .Parameters.Add("@StokMax", SqlDbType.Float).Value = Val(TxtStokMax.Text)
                .Parameters.Add("@StokMin", SqlDbType.Float).Value = Val(TxtStokMin.Text)
                .Parameters.Add("@StokIn", SqlDbType.Float).Value = Val(TxtStokIn.Text)
                .Parameters.Add("@StokOut", SqlDbType.Float).Value = Val(TxtStokOut.Text)

                .Parameters.Add("@Status", SqlDbType.Char, 1).Value = f_status
                .ExecuteNonQuery()
            End With
            sp.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
             & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
             & ex.Message.ToString, vbCritical, "Validasi")

            Return False
        End Try

    End Function

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Try

            If Tab.SelectedTab Is TabPage1 Then

                If sp_Barang("A") = False Then Exit Sub
                Bersih(TabPage1)
                Bersih(GroupBox1)
                Bersih(GroupBox2)

            ElseIf Tab.SelectedTab Is TabPage2 Then

                If sp_jenisBrg("A") = False Then Exit Sub
                Bersih(TabPage2)
                Call SubLoadDataListView("")

            ElseIf Tab.SelectedTab Is TabPage3 Then

                If sp_Satuan("A") = False Then Exit Sub
                Bersih(TabPage3)
                Call SubLoadDataListView("")

            ElseIf Tab.SelectedTab Is TabPage4 Then

                If sp_TypeBrg("A") = False Then Exit Sub
                Bersih(TabPage4)
                Call SubLoadDataListView("")

            End If

            MsgBox("Data Berhasil di Simpan", vbInformation)

        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        Try

            If Tab.SelectedTab Is TabPage2 Then

                If sp_jenisBrg("D") = False Then Exit Sub
                Bersih(TabPage2)
                Call SubLoadDataListView("")

            ElseIf Tab.SelectedTab Is TabPage3 Then

                If sp_Satuan("D") = False Then Exit Sub
                Bersih(TabPage3)
                Call SubLoadDataListView("")

            ElseIf Tab.SelectedTab Is TabPage4 Then

                If sp_TypeBrg("D") = False Then Exit Sub
                Bersih(TabPage4)
                Call SubLoadDataListView("")

            End If

            MsgBox("Data Berhasil di Hapus", vbInformation, "Hapus")

        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub SubLoadDataListView(ByVal StrParameterCari As String)
        Try

            If Tab.SelectedTab Is TabPage2 Then

                strSQL = "SELECT kdJenisBrg as [Kode],JenisBarang,ket as [Keterangan],StatusAktif as Status FROM MasterJenisBrg WHERE JenisBarang like  '" & StrParameterCari & "%' ORDER BY KdJenisBrg ASC"
                FillListView(LsvJenisBrg, GetData(strSQL))
                TxtJenisBrg.Focus()

            ElseIf Tab.SelectedTab Is TabPage3 Then

                strSQL = "SELECT kdSatuan as [Kode],SatuanBrg as [Satuan],Kelompok,ket as [Keterangan],StatusAktif,KdKelompok as Status FROM V_SatuanBrg WHERE SatuanBrg like  '" & StrParameterCari & "%' ORDER BY KdSatuan ASC"
                FillListView(LsvSatuanBrg, GetData(strSQL))
                TxtSatuan.Focus()

            ElseIf Tab.SelectedTab Is TabPage4 Then

                strSQL = "SELECT kdType as [Kode],TypeBarang,ket as [Keterangan],StatusAktif as Status FROM MasterTypeBrg WHERE TypeBarang like  '" & StrParameterCari & "%' ORDER BY KdType ASC"
                FillListView(LsvTypeBrg, GetData(strSQL))
                TxtTypeBrg.Focus()
            End If


        Catch ex As Exception
            ex.Message.ToString()
        End Try

    End Sub

    Private Sub FrmBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call subLoadCombo()
    End Sub

    Private Sub subLoadCombo()
        fillCombo(CbJenisBrg, "kdJenisBrg", "jenisBarang", "MasterJenisbrg")
        fillCombo(CbSatuan, "KdSatuan", "satuanBrg", "masterSatuanBrg")
        fillCombo(CboKelSatuan, "KdKelompok", "kelompok", "MasterKelompokSatuan")
        fillCombo(CbTypeBrg, "KdType", "TypeBarang", "MasterTypeBrg")
    End Sub

    Private Sub Tab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab.SelectedIndexChanged
        Call SubLoadDataListView("")
    End Sub


    Private Sub TxtBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CbSatuan.Focus()

    End Sub

    Private Sub CbJenisBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbJenisBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtMerk.Focus()
    End Sub

    Private Sub TxtMerk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMerk.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CbTypeBrg.Focus()
    End Sub

    Private Sub CbTypeBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbTypeBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then Txtwarna.Focus()
    End Sub


    Private Sub TxtJenisBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJenisBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtKetJenisBrg.Focus()
    End Sub


    Private Sub TxtKetJenisBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKetJenisBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then ChkStat1.Focus()
    End Sub

    Private Sub ChkStat1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkStat1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CmdSimpan.Focus()
    End Sub

    Private Sub TxtSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSatuan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CboKelSatuan.Focus()
    End Sub

    Private Sub CboKelSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboKelSatuan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtKetSatuan.Focus()
    End Sub

    Private Sub TxtKetSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKetSatuan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then ChkStat2.Focus()
    End Sub

    Private Sub ChkStat2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkStat2.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CmdSimpan.Focus()
    End Sub

    Private Sub TxtTypeBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTypeBrg.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtKetType.Focus()
    End Sub

    Private Sub TxtKetType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKetType.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then ChkStat3.Focus()
    End Sub

    Private Sub ChkStat3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkStat3.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CmdSimpan.Focus()
    End Sub

    Private Sub TxtHrgPokok_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHrgPokok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtHrgJual.Focus()
    End Sub

    Private Sub TxtHrgJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHrgJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then ChkInputStok.Focus()
    End Sub

    Private Sub Txtwarna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtwarna.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then ChkInputHrg.Focus()
    End Sub

    Private Sub ChkInputHrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkInputHrg.Click
        If ChkInputHrg.Checked = True Then

            TxtHrgPokok.Focus()
            TxtHrgJual.BackColor = Color.White
            TxtHrgPokok.BackColor = Color.White

        Else

            TxtHrgJual.Text = 0
            TxtHrgPokok.Text = 0
            TxtHrgJual.BackColor = Color.Gray
            TxtHrgPokok.BackColor = Color.Gray
        End If
    End Sub


    Private Sub ChkInputStok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkInputStok.Click
        If ChkInputStok.Checked = True Then

            TxtStokReal.Focus()

            TxtStokReal.BackColor = Color.White
            TxtStokMax.BackColor = Color.White
            TxtStokMin.BackColor = Color.White
            TxtStokOut.BackColor = Color.White
            TxtStokIn.BackColor = Color.White

        Else

            TxtStokReal.Text = 0
            TxtStokMax.Text = 0
            TxtStokMin.Text = 0
            TxtStokIn.Text = 0
            TxtStokOut.Text = 0

            TxtStokReal.BackColor = Color.Gray
            TxtStokMax.BackColor = Color.Gray
            TxtStokMin.BackColor = Color.Gray
            TxtStokOut.BackColor = Color.Gray
            TxtStokIn.BackColor = Color.Gray

        End If
    End Sub


    Private Sub TxtStokReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStokReal.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtStokMax.Focus()
    End Sub

    Private Sub TxtStokMax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStokMax.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtStokMin.Focus()
    End Sub

    Private Sub TxtStokMin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStokMin.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtStokIn.Focus()
    End Sub

    Private Sub TxtStokIn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStokIn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then TxtStokOut.Focus()
    End Sub

    Private Sub TxtCatatan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCatatan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then CmdSimpan.Focus()
    End Sub

    Private Sub SubNonAktif()
        txtpanjang.Enabled = False
        Txtberat.Enabled = False
        TxtVol.Enabled = False
        txtSize.Enabled = False
        TxtDimensi.Enabled = False

        txtpanjang.BackColor = Color.Gray
        Txtberat.BackColor = Color.Gray
        TxtVol.BackColor = Color.Gray
        TxtSize.BackColor = Color.Gray
        TxtDimensi.BackColor = Color.Gray
    End Sub



    Private Sub CbSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbSatuan.KeyPress
        Try
            If (e.KeyChar = ChrW(Keys.Enter)) Then

                rd.Close()
                strSQL = "SELECT KdSatuan,KdKelompok FROM V_SatuanBrg WHERE KdSatuan ='" & CbSatuan.SelectedValue & "'"
                GetDtReadValue(strSQL, rd)
                StrKdKel = Trim(rd.Item(1).ToString)

                Select Case StrKdKel
                    Case "01"
                        SubNonAktif()
                        Txtberat.Enabled = True
                        Txtberat.BackColor = Color.White
                        Txtberat.Focus()

                    Case "02"
                        SubNonAktif()
                        txtpanjang.Enabled = True
                        txtpanjang.BackColor = Color.White
                        txtpanjang.Focus()

                    Case "03"
                        SubNonAktif()
                        TxtVol.Enabled = True
                        TxtVol.BackColor = Color.White
                        TxtVol.Focus()

                    Case "04"
                        SubNonAktif()
                        TxtSize.Enabled = True
                        TxtSize.BackColor = Color.White
                        TxtSize.Focus()

                    Case "05"
                        SubNonAktif()
                        TxtDimensi.Enabled = True
                        TxtDimensi.BackColor = Color.White
                        TxtDimensi.Focus()

                    Case "06"
                        SubNonAktif()
                        CbJenisBrg.Focus()

                End Select

            End If

        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

   
    Private Sub Txtberat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtberat.KeyPress
        If Not ((Asc(e.KeyChar) >= 49 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then CbJenisBrg.Focus()
    End Sub

   
    Private Sub txtpanjang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpanjang.KeyPress
        If Not ((Asc(e.KeyChar) >= 49 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then CbJenisBrg.Focus()
    End Sub

  
    Private Sub TxtVol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVol.KeyPress
        If Not ((Asc(e.KeyChar) >= 49 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = ChrW(Keys.Enter)) Then CbJenisBrg.Focus()
    End Sub

    Private Sub TxtCariTypeBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCariTypeBrg.TextChanged
        Call SubLoadDataListView(TxtCariTypeBrg.Text)
        TxtCariTypeBrg.Focus()
    End Sub

    Private Sub TxtCariSatuan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCariSatuan.TextChanged
        Call SubLoadDataListView(TxtCariSatuan.Text)
        TxtCariSatuan.Focus()
    End Sub

    Private Sub TxtCariJenisBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCariJenisBrg.TextChanged
        Call SubLoadDataListView(TxtCariJenisBrg.Text)
        TxtCariJenisBrg.Focus()
    End Sub

    Private Sub LsvTypeBrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsvTypeBrg.Click

        With LsvTypeBrg
            TxtKdType.Text = .FocusedItem.Text
            TxtTypeBrg.Text = .FocusedItem.SubItems(1).Text
            TxtKetType.Text = .FocusedItem.SubItems(2).Text
            StatusChk = Val(.FocusedItem.SubItems(3).Text)

            If StatusChk = 1 Then
                ChkStat3.Checked = True
            Else
                ChkStat3.Checked = False
            End If
        End With
    End Sub


    Private Sub LsvSatuanBrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsvSatuanBrg.Click
        With LsvSatuanBrg
            TxtKdSatuan.Text = .FocusedItem.Text
            TxtSatuan.Text = .FocusedItem.SubItems(1).Text
            CboKelSatuan.SelectedValue = .FocusedItem.SubItems(5).Text
            TxtKetSatuan.Text = .FocusedItem.SubItems(3).Text
            StatusChk = Val(.FocusedItem.SubItems(4).Text)

            If StatusChk = 1 Then
                ChkStat2.Checked = True
            Else
                ChkStat2.Checked = False
            End If
        End With
    End Sub

   
   
    Private Sub LsvJenisBrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsvJenisBrg.Click
        With LsvJenisBrg
            TxtKdJenisBrg.Text = .FocusedItem.Text
            TxtJenisBrg.Text = .FocusedItem.SubItems(1).Text
            TxtKetJenisBrg.Text = .FocusedItem.SubItems(2).Text
            StatusChk = Val(.FocusedItem.SubItems(3).Text)

            If StatusChk = 1 Then
                ChkStat1.Checked = True
            Else
                ChkStat1.Checked = False
            End If
        End With
    End Sub
End Class