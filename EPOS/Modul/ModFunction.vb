Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text

Module ModFunction

    Public Function Periksa(ByVal vCase As String, ByVal vObj As Object, ByVal vPesan As String) As Boolean
        Periksa = True

        Select Case LCase(vCase)
            Case "text"
                If Len(Trim(vObj.Text)) > 0 Then Exit Function
            Case "nilai"
                If Val(vObj) > 0 Then Exit Function
            Case "combobox"
                If vObj.ListIndex >= 0 Then Exit Function
        End Select

        MsgBox(vPesan, vbExclamation, "Validasi")
        vObj.focus()
        Periksa = False
    End Function

    Public Sub Bersih(ByVal group As Object) ' parameter group yaitu groupbox
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = Nothing
            End If
        Next

    End Sub

    ' fungsi untuk mengeksport data dari datagridview ke format excel
    Public Sub ExportExcel(ByVal obj As Object) ' obj = datagridview
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = obj.RowCount
            colsTotal = obj.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = obj.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = obj.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    ' fungsi untuk mengkonvert nilai angka menjadi kalimat terbilang
    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Public Sub fillCombo(ByVal cbo As ComboBox, ByVal id As String, ByVal member As String, ByVal tabel As String)

        Try
            dtAdapter = New SqlDataAdapter("Select * From " & tabel & " where statusAktif=1", ModKoneksi.KoneksiDatabase)
            dtbl = New DataTable
            dtAdapter.Fill(dtbl)
            With cbo
                .DataSource = dtbl
                .ValueMember = id
                .DisplayMember = member
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        'da.Dispose()
    End Sub

    ' fungsi untuk mengambil data dari database
    Public Function GetData(ByVal query As String)

        Dim sqlCmd As SqlCommand = New SqlCommand(query, ModKoneksi.KoneksiDatabase)
        Dim myData As SqlDataReader

        Try
            sqlCmd.Connection = con
            myData = sqlCmd.ExecuteReader
            Return myData
        Catch ex As Exception
            ex.Message.ToString()
            Return ex
        End Try
    End Function

    Public Function GetDtReadValue(ByVal query As String, ByRef dtReader As SqlDataReader)
        Dim sqlCmd As SqlCommand = New SqlCommand(query, ModKoneksi.KoneksiDatabase)

        Try
            sqlCmd.Connection = con
            dtReader = sqlCmd.ExecuteReader
            dtReader.Read()
            Return dtReader
        Catch ex As Exception
            ex.Message.ToString()
            Return ex
        End Try
    End Function

    ' fungsi untuk menampilkan data dari database ke datagridview
    Public Sub LoadDatagrid(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            With SQLcmd
                .Connection = con
                .CommandText = sql
            End With
            dtbl = New DataTable
            dtAdapter = New SqlDataAdapter(sql, con)
            dtAdapter.Fill(dtbl)
            dtg.DataSource = dtbl
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        End Try

        con.Close()
        dtAdapter.Dispose()
    End Sub

    ' fungsi untuk menampilkan data ke listview dari database
    Public Sub FillListView(ByRef lvList As ListView, ByRef myData As SqlDataReader)
        Dim itmListItem As ListViewItem

        Dim strValue As String
        lvList.Items.Clear()
        Do While myData.Read
            itmListItem = New ListViewItem()
            strValue = IIf(myData.IsDBNull(0), "", myData.GetValue(0))
            itmListItem.Text = strValue

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetValue(shtCntr))
                End If
            Next shtCntr

            lvList.Items.Add(itmListItem)
        Loop
    End Sub

    ' fungsi untuk mengunci data enkripsi
    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    ' fungsi untuk membuka kunci enkripsi (dekripsi)
    Public Function Decrypt(ByVal encryptpwd As String) As String
        Dim decryptpwd As String = String.Empty
        Dim encodepwd As New UTF8Encoding()
        Dim Decode As Decoder = encodepwd.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(encryptpwd)
        Dim charCount As Integer = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        decryptpwd = New [String](decoded_char)
        Return decryptpwd
    End Function
End Module
