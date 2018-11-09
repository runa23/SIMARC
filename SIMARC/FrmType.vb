Imports System.Data
Imports System.Data.SqlClient
Public Class FrmType
    Dim kode As String

    Private Sub FrmType_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Type_AsetTableAdapter.Fill(Me.SIMARCData_Set.Type_Aset)
        SetTombol(True)
    End Sub
    Sub Bersih()
        TxtNama.Clear()
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub Reload()
        DgType.ClearSelection()
        Type_AsetTableAdapter.Fill(SIMARCData_Set.Type_Aset)
    End Sub
    Sub Insert()
        If TxtNama.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else

            OpenConnection()
            Try
                sql = "SpInsertType '" & TxtNama.Text & "'," & Menu_Utama.Kd_Karyawan.Text & ""
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Bersih()
            Reload()
            CloseConnection()
        End If
    End Sub
    Sub Edit()
        If TxtNama.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            OpenConnection()
            Try
                sql = "SpUpdateType " & kode & ",'" & TxtNama.Text & "'," & Menu_Utama.Kd_Karyawan.Text & ""
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Bersih()
            Reload()
            SetTombol(False)
            CloseConnection()
        End If
    End Sub
    Sub Delete()
        OpenConnection()
        Try
            sql = "SpDeleteType " & kode & ""
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Hapus", "Informasi", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Data tidak bisa di Hapus, Sedang digunakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Bersih()
        Reload()
        SetTombol(True)
        CloseConnection()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Insert()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Edit()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Delete()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Bersih()
        SetTombol(True)
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub

    Private Sub DgType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgType.CellContentClick
        Try
            With DgType.Rows(e.RowIndex)
                kode = .Cells(0).Value
                TxtNama.Text = .Cells(1).Value
            End With
            SetTombol(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class