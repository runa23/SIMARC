Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPetugas
    Dim kode As Integer
    Dim conses() As String

    Private Sub FrmPetugas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KaryawanTableAdapter.Fill(Me.SIMARCData_Set.Karyawan)
        SetTombol(True)
    End Sub
    Sub Clear()
        TxtNama.Clear()
        TxtAlamat.Clear()
        TxtTelp.Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
        'CmbStats.Text = ""
        'CmbWilayah.Text = ""
        CmbStats.SelectedIndex = -1
        CmbWilayah.SelectedIndex = -1
    End Sub
   Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub ReloadData()
        KaryawanTableAdapter.Fill(SIMARCData_Set.Karyawan)
    End Sub
    Sub Insert()
        If TxtNama.Text = "" Or
            TxtAlamat.Text = "" Or
            TxtTelp.Text = "" Or
            TxtUsername.Text = "" Or
            TxtPassword.Text = "" Or
            CmbStats.Text = "" Or
            CmbWilayah.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else

            OpenConnection()
            Try
                conses = Split(CmbWilayah.Text, " - ")
                sql = "SpInsertKaryawan '" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtTelp.Text & "','" _
                        & CmbStats.Text & "'," & conses(0) & ",'" & TxtUsername.Text & "','" & TxtPassword.Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ReloadData()
            Clear()
            CloseConnection()
        End If
    End Sub
    Sub Edit()
        If TxtNama.Text = "" Or
            TxtAlamat.Text = "" Or
            TxtTelp.Text = "" Or
            TxtUsername.Text = "" Or
            TxtPassword.Text = "" Or
            CmbStats.Text = "" Or
            CmbWilayah.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            OpenConnection()
            Try
                conses = Split(CmbWilayah.Text, " - ")
                sql = "SpUpdateKaryawan " & kode & ",'" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtTelp.Text & "'," _
                        & conses(0) & ",'" & CmbStats.Text & "','" & TxtUsername.Text & "','" & TxtPassword.Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Update", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ReloadData()
            Clear()
            SetTombol(True)
            CloseConnection()
        End If
    End Sub
    Sub Delete()
        OpenConnection()
        Try
            sql = "SpDeleteKaryawan " & kode & ""
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data sedang digunakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        ReloadData()
        Clear()
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
        Clear()
        SetTombol(True)
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub

    Private Sub DgPetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPetugas.CellContentClick
        With DgPetugas.Rows(e.RowIndex)
            kode = .Cells(0).Value
            TxtNama.Text = .Cells(1).Value
            TxtAlamat.Text = .Cells(2).Value
            TxtTelp.Text = .Cells(3).Value
            CmbStats.Text = .Cells(4).Value
            CmbWilayah.SelectedIndex = .Cells(5).Value - 1
            TxtUsername.Text = .Cells(6).Value
            TxtPassword.Text = .Cells(7).Value
        End With
        SetTombol(False)
    End Sub
End Class
