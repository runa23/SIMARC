Imports System.Data
Imports System.Data.SqlClient
Public Class FrmMerk
    Dim kode As String

    Private Sub FrmMerk_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Type_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Type_Aset)
        Me.Merk_AsetTableAdapter.Fill(Me.SIMARCData_Set.Merk_Aset)
        CmbType.SelectedIndex = 0
        SetTombol(True)
    End Sub
    Sub LoadType()
        With CmbType
            .DataSource = SIMARCData_Set.Tables("Type_Aset")
            .DisplayMember = "nm_type"
            .ValueMember = "Kd_type"
        End With
    End Sub
    Sub Bersih()
        kode = ""
        CmbType.SelectedIndex = 0
        TxtMerk.Clear()
        CmbType.Focus()
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub Reload()
        DgMerk.ClearSelection()
        Merk_AsetTableAdapter.Fill(SIMARCData_Set.Merk_Aset)
    End Sub
    Sub Insert()
        If txtMerk.Text = "" Or CmbType.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            Try
                OpenConnection()
                sql = "SpInsertMerk '" & TxtMerk.Text & "'," & CmbType.SelectedValue &
                      "," & Menu_Utama.Kd_Karyawan.Text & ""
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
        If txtMerk.Text = "" Or CmbType.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            Try
                OpenConnection()
                sql = "SpUpdateMerk " & kode & ",'" & TxtMerk.Text &
                      "'," & CmbType.SelectedValue & "," & Menu_Utama.Kd_Karyawan.Text & ""
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Bersih()
            Reload()
            SetTombol(True)
            CloseConnection()
        End If
    End Sub
    Sub Delete()
        Try
            OpenConnection()
            sql = "SpDeleteMerk " & kode & ""
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Delete", "Informasi", MessageBoxButtons.OK)
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

    Private Sub DgMerk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMerk.CellContentClick
        Try
            With DgMerk.Rows(e.RowIndex)
                kode = .Cells(0).Value
                TxtMerk.Text = .Cells(1).Value
                CmbType.SelectedValue = .Cells(2).Value
            End With
            SetTombol(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class