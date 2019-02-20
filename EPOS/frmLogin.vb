Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        End
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click


        If Periksa("text", txtUsername, "Data Tidak boleh kosong") = False Then Exit Sub
        If Periksa("text", txtPassword, "Data Tidak boleh kosong") = False Then Exit Sub

        StrUserLogin = txtUsername.Text
        StrPassLogin = txtPassword.Text


        Try

            strSQL = "SELECT * from V_Login where IdUser = '" & StrUserLogin & "' AND Password = '" & StrPassLogin & "' AND KdBagian = '" & mstrKdBagian & "' AND IdPegawai = '" & strIDPegawai & "'"
            GetDtReadValue(strSQL, rd)

            If Not rd.HasRows Then
                MsgBox("Username dan Password anda salah...", MsgBoxStyle.Critical, "Informasi")
                Bersih(GroupBox1)
                txtUsername.Focus()
                Exit Sub
            Else
                frmMenuUtama.Show()
                Me.Visible = False

            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi error (periksa settingan): " + ex.Message)
            Bersih(GroupBox1)
            txtUsername.Focus()

        End Try
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsername.Focus()
    End Sub

  

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim frm As New frmsetting


        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F12 Then
            frm.ShowDialog()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.TabIndex = 1
        Call con_getSetting()
    End Sub



    Private Sub txtUsername_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                strSQL = "select * from V_Login WHERE IdUser='" & Trim(txtUsername.Text) & "'"

                GetDtReadValue(strSQL, rd)
                If Not rd.HasRows Then
                    MsgBox("Id User tidak terdaftar, hubungi administrator", vbInformation, "Informasi")
                    txtUsername.Focus()
                    Exit Sub
                End If

                mstrKdBagian = Trim(rd("kdBagian").ToString)
                strNamaPegawai = Trim(rd("namaLengkap").ToString)
                TxtNamaUser.Text = strNamaPegawai
                strIDPegawai = Trim(rd("IdPegawai").ToString)

                TxtNamaUser.BackColor = Color.Aquamarine

                strKdLokasi = Trim(rd("KdLokasi").ToString)
                TxtBagian.Text = Trim(rd("NamaBagian").ToString)
                TxtBagian.BackColor = Color.Aquamarine

                TxtLokasi.Text = Trim(rd("Lokasi"))
                TxtLokasi.BackColor = Color.Aquamarine



                txtPassword.Focus()

            End If



        Catch ex As Exception

            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
              & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
              & Err.Number & " - " & Err.Description, vbCritical, "Validasi")
        End Try
    End Sub


    Private Sub txtPassword_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then cmdLogin.Focus()

    End Sub
End Class