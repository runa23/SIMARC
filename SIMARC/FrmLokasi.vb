Imports System.Data
Imports System.Data.SqlClient
Public Class FrmLokasi
    Dim kode As String

    Private Sub FrmLokasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        TampilData()
        SetTombol1()
    End Sub
    Sub TampilData()
        OpenConnection()
        sql = "Select * from Lokasi"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgLokasi.DataSource = ds.Tables(0)
        SetHeader()
        CloseConnection()
    End Sub
    Sub SetHeader()
        With DgLokasi
            .Columns(0).HeaderText = "Kode"
            .Columns(1).HeaderText = "Nama"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "Telp"
            .Columns(4).HeaderText = "Karyawan"
        End With
    End Sub
    Sub Clear()
        TxtNama.Clear()
        TxtAlamat.Clear()
        TxtTelp.Clear()
        TxtKode.Clear()
    End Sub
    Sub SetTombol1()
        BtnSimpan.Enabled = True
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        BtnKeluar.Enabled = True
    End Sub
    Sub SetTombol2()
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnBatal.Enabled = True
        BtnKeluar.Enabled = False
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
                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            TampilData()
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
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SetTombol1()
            Clear()
            TampilData()
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
        TampilData()
        SetTombol1()
        CloseConnection()
    End Sub
    Private Sub DgLokasi_DoubleClick(sender As Object, e As EventArgs) Handles DgLokasi.DoubleClick
        With DgLokasi
            TxtKode.Text = .Item(0, .CurrentRow.Index).Value
            TxtNama.Text = .Item(1, .CurrentRow.Index).Value
            TxtAlamat.Text = .Item(2, .CurrentRow.Index).Value
            TxtTelp.Text = .Item(3, .CurrentRow.Index).Value
        End With
        SetTombol2()
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
        SetTombol1()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
End Class