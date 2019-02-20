Module ModVar

    Public con As SqlClient.SqlConnection
    Public SQLcmd As New SqlClient.SqlCommand
    Public dtAdapter As SqlClient.SqlDataAdapter
    Public rs As SqlClient.SqlDataReader
    Public rd As SqlClient.SqlDataReader

    Public dts As DataSet
    Public dtbl As DataTable

    Public record As New BindingSource

    Public StrKdKel As String
    Public strKdLokasi As String
    Public strIDPegawai As String
    Public strNamaPegawai As String
    Public strSQL As String
  

    Public StrPassLogin As String
    Public StrUserLogin As String
    Public mstrKdBagian As String

    Public StrPass As String
    Public StrServer As String
    Public StrUserid As String
    Public StrDatabase As String

    Public Constring As String

    Public strGroup As String
    Public strTglAwal As String
    Public strTglAkhir As String
    Public strJenisBarang As String
    Public strNamaBarang As String
    Public strKategori As String
    Public strKelas As String

    Public strHakAkses As String

End Module
