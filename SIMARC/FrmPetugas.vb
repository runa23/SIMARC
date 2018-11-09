Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPetugas
    Dim kode As Integer
    Dim conses() As String

    Private Sub FrmPetugas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tampil()
        SetTombol1()
    End Sub
    Sub Tampil()
        OpenConnection()
        sql = "select * from Karyawan where kd_karyawan not in(0)"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgPetugas.DataSource = ds.Tables(0)
        SetHeader()
        CloseConnection()
    End Sub
    Sub SetHeader()
        With DgPetugas
            .Columns(0).HeaderText = "Kode"
            .Columns(1).HeaderText = "Nama"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "Telp"
            .Columns(4).HeaderText = "Level"
            .Columns(5).HeaderText = "Wilayah"
            .Columns(6).HeaderText = "Username"
            .Columns(7).HeaderText = "Password"
        End With
    End Sub
    Sub Clear()
        TxtNama.Clear()
        TxtAlamat.Clear()
        TxtTelp.Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
        CmbStats.Text = ""
        CmbWilayah.Text = ""
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
        If TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtTelp.Text = "" Or TxtUsername.Text = "" Or TxtPassword.Text = "" Or
            CmbStats.Text = "" Or CmbWilayah.Text = "" Then
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
                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Tampil()
            Clear()
            CloseConnection()
        End If
    End Sub
    Sub Edit()
        If TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtTelp.Text = "" Or TxtUsername.Text = "" Or TxtPassword.Text = "" Or
            CmbStats.Text = "" Or CmbWilayah.Text = "" Then
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
                MessageBox.Show("Data Berhasil di Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Tampil()
            Clear()
            SetTombol1()
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
        Tampil()
        Clear()
        SetTombol1()
        CloseConnection()
    End Sub
    Private Sub DgPetugas_DoubleClick(sender As Object, e As EventArgs) Handles DgPetugas.DoubleClick
        Dim wil As Integer

        With DgPetugas
            kode = .Item(0, .CurrentRow.Index).Value
            TxtNama.Text = .Item(1, .CurrentRow.Index).Value
            TxtAlamat.Text = .Item(2, .CurrentRow.Index).Value
            TxtTelp.Text = .Item(3, .CurrentRow.Index).Value

            CmbStats.Text = .Item(4, .CurrentRow.Index).Value

            wil = .Item(5, .CurrentRow.Index).Value
            CmbWilayah.SelectedIndex = wil - 1

            TxtUsername.Text = .Item(6, .CurrentRow.Index).Value
            TxtPassword.Text = .Item(7, .CurrentRow.Index).Value
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
