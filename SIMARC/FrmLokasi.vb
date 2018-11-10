Imports System.Data
Imports System.Data.SqlClient
Imports SIMARC.Modul
Public Class FrmLokasi
    Dim kode As String

    Private Sub FrmLokasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LokasiTableAdapter.Fill(Me.SIMARCData_Set.Lokasi)
        SetTombol(True)
    End Sub
    Sub Clear()
        TxtNama.Clear()
        TxtAlamat.Clear()
        TxtTelp.Clear()
        TxtKode.Clear()
    End Sub
    Sub ReloadData()
        LokasiTableAdapter.Fill(SIMARCData_Set.Lokasi)
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub Insert()
        If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtTelp.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            OpenConnection()
            Try
                sql = "SpInsertLokasi '" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & _
                  "','" & TxtTelp.Text & "','" & Menu_Utama.Kd_Karyawan.Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            ReloadData()
            CloseConnection()
        End If
    End Sub
    Sub Edit()
        If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtTelp.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            OpenConnection()
            Try
                sql = "SpUpdateLokasi '" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtTelp.Text & _
                  "','" & Menu_Utama.Kd_Karyawan.Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SetTombol(True)
            Clear()
            ReloadData()
            CloseConnection()
        End If
    End Sub
    Sub Delete()
        OpenConnection()
        Try
            sql = "SpDeleteLokasi '" & TxtKode.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data sedang digunakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Clear()
        ReloadData()
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

    Private Sub DgLokasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgLokasi.CellContentClick
        With DgLokasi.Rows(e.RowIndex)
            TxtKode.Text = .Cells(0).Value
            TxtNama.Text = .Cells(1).Value
            TxtAlamat.Text = .Cells(2).Value
            TxtTelp.Text = .Cells(3).Value
        End With
        SetTombol(False)
    End Sub

    Private Sub TxtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelp.KeyPress
        HanyaAngka(e)
    End Sub
End Class