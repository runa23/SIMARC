Imports System.Data
Imports System.Data.SqlClient
Imports SIMARC.Modul
Public Class FrmModel
    Dim kode As String
    Dim model As String

    Private Sub FrmModel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Type_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Type_Aset)
        Me.Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
        Me.Model_AsetTableAdapter.Fill(Me.SIMARCData_Set.Model_Aset)

        CmbType.SelectedValue = 0
        CmbMerk.SelectedValue = 0
        TxtUkuran.Text = 0

        SetTombol(True)
    End Sub
    Sub Bersih()
        kode = ""
        CmbType.SelectedValue = 0
        CmbMerk.SelectedValue = 0
        TxtNama.Clear()
        CmbType.Focus()
        TxtUkuran.Text = 0
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub Reload()
        Me.Type_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Type_Aset)
        Me.Model_AsetTableAdapter.Fill(Me.SIMARCData_Set.Model_Aset)
    End Sub
    Sub Insert()
        If CmbMerk.Text = "" Or
            TxtNama.Text = "" Or
             TxtUkuran.Text = 0 Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            Try
                model = TxtNama.Text & Microsoft.VisualBasic.Left(TxtUkuran.Text, 2)
                OpenConnection()
                sql = "SpInsertModel '" & model & "'," & CmbMerk.SelectedValue &
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
        If CmbMerk.Text = "" Or
            TxtNama.Text = "" Or
             TxtUkuran.Text = 0 Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            model = Microsoft.VisualBasic.Left(TxtNama.Text, Len(TxtNama.Text) - 2) & Microsoft.VisualBasic.Left(TxtUkuran.Text, 2)
            OpenConnection()
            Try
                sql = "SpUpdateModel " & kode & ",'" & model & "'," & CmbMerk.SelectedValue &
                      "," & Menu_Utama.Kd_Karyawan.Text & ""
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
        OpenConnection()
        Try
            sql = "SpDeleteModel " & kode & ""
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Delete", "Informasi", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Data tidak bisa di Hapus, Sedang digunakan", "Informasi", MessageBoxButtons.OK)
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

    Private Sub DgModel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgModel.CellContentClick
        Try
            With DgModel.Rows(e.RowIndex)
                kode = .Cells(0).Value
                CmbType.SelectedValue = .Cells(4).Value
                TxtNama.Text = .Cells(1).Value
                CmbMerk.SelectedValue = .Cells(2).Value
                TxtUkuran.Text = Microsoft.VisualBasic.Right(.Cells(1).Value, 2) * 10
            End With
            SetTombol(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtUkuran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUkuran.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub CmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbType.SelectedValueChanged
        If CmbType.SelectedValue = Nothing Then
            Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
        Else
            Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, CmbType.SelectedValue)
        End If

    End Sub
End Class