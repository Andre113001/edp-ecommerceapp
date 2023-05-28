Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Module CRUD
    Sub register_user(email As String, password As String, username As String)
        Connect_To_DB()
        Dim query As String
        query = "INSERT INTO users (Username, Password, Email, RoleID)
                 VALUES (@username, @password, @email, 1)"

        Using comm As New MySqlCommand
            With comm
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@username", username)
                .Parameters.AddWithValue("@password", password)
                .Parameters.AddWithValue("@email", email)
            End With
            Try
                comm.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Welcome to CartMe " & username & "!", "Register Completed!")
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Error Message")
            End Try
        End Using
    End Sub

    Sub login_user(email As String, password As String)
        Connect_To_DB()
        Try
            cmd = New MySqlCommand("SELECT * FROM users WHERE Email=@Email AND Password=@Password", conn)
            cmd.Parameters.AddWithValue("Email", email)
            cmd.Parameters.AddWithValue("Password", password)
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader

            If reader.Read Then
                Dim role As String = reader.GetValue("4")
                Dim username As String = reader.GetValue("1")
                If role = 1 Then
                    frmLogin.Hide()
                    frmWelcome.Show()
                ElseIf role = 2 Then
                    frmLogin.Hide()
                    frmAdmin.Show()
                End If


                conn.Close()
            Else
                MessageBox.Show("Incorrect Email or Password", "Error: Wrong password or email")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub

    Function fetch_user(email As String)
        Connect_To_DB()
        cmd = New MySqlCommand("SELECT * FROM users WHERE Email = @Email", conn)
        With cmd
            .Parameters.AddWithValue("@Email", email)
            .ExecuteNonQuery()
        End With
        reader = cmd.ExecuteReader

        If reader.Read Then
            fetch_user = reader.GetValue("1")
        End If
    End Function

    Function add_item(itemName As String, itemPrice As Integer, itemCategory As Integer)
        Connect_To_DB()
        cmd = New MySqlCommand("INSERT INTO products (ProductName, Price, CategoryID) VALUES(@ProductName, @Price, @CategoryID)", conn)
        With cmd
            .Parameters.AddWithValue("@ProductName", itemName)
            .Parameters.AddWithValue("@Price", itemPrice)
            .Parameters.AddWithValue("@CategoryID", itemCategory)
        End With
        Try
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show(itemName + " has been added")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Function

End Module
