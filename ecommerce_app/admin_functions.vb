Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Module admin_functions
    Sub Load_Admin_Function(tableName As String, dg As DataGridView)
        Connect_To_DB()
        Dim sql As String = "SELECT * FROM " & tableName
        Dim dataAdapter As New MySqlDataAdapter(sql, conn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, tableName)
        conn.Close()

        dg.DataSource = dataSet.Tables(tableName)
        dg.ReadOnly = True
    End Sub
    Sub export_excel(dgName As DataGridView, directory As String, type As String)
        Try
            Dim exlFile = New Excel.Application
            Dim columnIndex As Integer = 0
            Dim rowIndex As Integer = 0
            Dim exlBook = exlFile.Workbooks.Open(directory)

            With exlFile
                .Cells(2, 1) = "As of " & FormatDateTime(Now(), DateFormat.LongDate)
                For Each column As DataGridViewColumn In dgName.Columns
                    columnIndex += 1
                    rowIndex = 4
                    For Each row As DataGridViewRow In dgName.Rows
                        rowIndex += 1
                        .Cells(rowIndex, columnIndex) = row.Cells(column.Name).Value
                    Next
                Next

            End With

            Dim saveFileDiaglog As New SaveFileDialog()
            saveFileDiaglog.InitialDirectory = "C:\Users\1130m\Documents\School Works\BSIT 3B - 2nd Semester\IT 120 - EDP\Try\ecommerce_app\export"
            saveFileDiaglog.Filter = "Excel Files(*.xlsx)|*.xlsx"
            saveFileDiaglog.FileName = type & " " & DateTime.Today.ToString("MM-dd-yyyy")

            If saveFileDiaglog.ShowDialog() = DialogResult.OK Then
                exlBook.SaveAs(saveFileDiaglog.FileName)
                MsgBox("Data Exported Successfully!")
            Else
                exlBook.Close()
            End If

            ReleaseObject(exlFile)
            exlBook.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
