Imports MySql.Data.MySqlClient
Module connection
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Sub Connect_To_DB()
        conn = New MySqlConnection("
            server = localhost;
            userid = root;
            password = .Marcus113001;
            database = ecommerce_db
        ")
        conn.Open()
    End Sub
End Module
