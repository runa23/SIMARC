Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmImMerk

    Private Sub FrmImMerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter

        Dim fBrowse As New OpenFileDialog
        With fBrowse
            .Filter = "Excel files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If fBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fname As String
            fname = fBrowse.FileName
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & fname & " '; " & "Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select nm_merk,kd_type from [Merk Aset$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "Test")
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            MyConnection.Close()
            For Each Drr As DataRow In DtSet.Tables(0).Rows
                sql = "SpInsertMerk '" & Drr(0).ToString & "'," & Val(Drr(1).ToString) & "," & Menu_Utama.Kd_Karyawan.Text & ""
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Successfully Saved")

        End If
    End Sub
End Class