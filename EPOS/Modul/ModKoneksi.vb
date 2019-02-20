Imports System.Data.SqlClient


Module ModKoneksi

    Public Function KoneksiDatabase() As SqlClient.SqlConnection
        Try
            If StrUserid = "" And StrPass = "" Then
                '-----tanpa Authentication
                con = New SqlConnection("integrated security=SSPi;Persist Security Info=True;Data Source='" & StrServer & "';Initial Catalog='" & StrDatabase & "';User Id= '" & StrUserid & "';Password='" & StrPass & "';MultipleActiveResultSets=True;connection timeout=30")
                con.Open()
            Else
                '-----Authentication
                con = New SqlConnection("Persist Security Info=True;Data Source='" & StrServer & "';Initial Catalog='" & StrDatabase & "';User Id= '" & StrUserid & "';Password='" & StrPass & "';MultipleActiveResultSets=True;connection timeout=30")
                con.Open()
            End If

        Catch ex As Exception

            MsgBox("Ada kesalahan dalam loading data" & vbNewLine _
              & "Hubungi administrator dan laporkan pesan berikut" & vbNewLine _
              & Err.Number & " - " & ex.Message.ToString, vbCritical, "Validasi")

        End Try


        Return con
        con = Nothing
    End Function

    Public Sub con_getSetting()
        StrServer = GetSetting("EPOS", "config", "server", "")
        StrUserid = GetSetting("EPOS", "config", "userid", "")
        StrPass = GetSetting("EPOS", "config", "password", "")
        StrDatabase = GetSetting("EPOS", "config", "database", "")
    End Sub

    Public Sub con_savesetting(ByVal server As String, ByVal userid As String, ByVal password As String, ByVal database As String)
        Call SaveSetting("EPOS", "config", "server", server)
        Call SaveSetting("EPOS", "config", "userid", userid)
        Call SaveSetting("EPOS", "config", "password", password)
        Call SaveSetting("EPOS", "config", "database", database)
        Call con_getSetting()
    End Sub

End Module
