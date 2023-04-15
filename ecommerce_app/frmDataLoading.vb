Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmDataLoading
    Private Sub frmDataLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect_To_DB()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files|*.csv"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog1.FileName
            tbFileDir.Text = openFileDialog1.FileName.ToString
            Dim table As New DataTable()

            Try
                Using sr As New StreamReader(file)
                    Dim headers() As String = sr.ReadLine().Split(","c)
                    For Each header As String In headers
                        table.Columns.Add(header)
                    Next

                    While Not sr.EndOfStream
                        Dim content() As String = sr.ReadLine().Split(","c)
                        Dim row As DataRow = table.NewRow()
                        row.ItemArray = content
                        table.Rows.Add(row)
                    End While
                End Using

                dgViewItem.DataSource = table
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\Users\1130m\Desktop\Database Backup"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.FileName = "backup"
        backup.Filter = "SQL files (*.sql)| *.sql"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            MessageBox.Show("Database backup sucessfully at " & backup.FileName)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim query As String = "INSERT INTO products (ProductName, Price, CategoryID) VALUES (@ProductName, @Price, @CategoryID)"


        For Each row As DataGridViewRow In dgViewItem.Rows
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@ProductName", row.Cells("ProductName").Value)
                command.Parameters.AddWithValue("@Price", row.Cells("Price").Value)
                command.Parameters.AddWithValue("@CategoryID", row.Cells("CategoryID").Value)

                command.ExecuteNonQuery()
            End Using
        Next

        MessageBox.Show("Data uploaded successfully.")
    End Sub


End Class