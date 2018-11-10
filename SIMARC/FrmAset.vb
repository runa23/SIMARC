Imports System.Data
Imports System.Data.SqlClient
Imports SIMARC.Modul
Public Class FrmAset
    Private Sub FrmAset_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Type_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Type_Aset)
        Me.Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
        Me.Model_AsetTableAdapter.FillBy_ComboBox(SIMARCData_Set.Model_Aset, 0)
        Me.AsetTableAdapter.Fill(Me.SIMARCData_Set.Aset)

        Clear()
        SetTombol(True)
    End Sub
    
    Sub Clear()
        TxtBarcode.Clear()
        LblUkuran.Text = 0
        CmbType.SelectedValue = 0
        CmbMerk.SelectedValue = 0
        CmbModel.SelectedValue = 0
        TxtBarcode.Focus()
    End Sub

    Sub ReloadData()
        Me.Type_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Type_Aset)
        Me.Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
        Me.AsetTableAdapter.Fill(Me.SIMARCData_Set.Aset)
    End Sub
    Sub HitungLiter()
        Dim ltr As Integer = 0
        ltr = Val(Microsoft.VisualBasic.Right(CmbModel.Text, 2)) * 10
        LblUkuran.Text = ltr
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub

    Private Sub CmbModel_SelectedIndexChanged(sender As Object, e As EventArgs)
        HitungLiter()
    End Sub
    Sub Insert()
        If TxtBarcode.Text = "" Or
            CmbType.SelectedValue = 0 Or
            CmbMerk.SelectedValue = 0 Or
            CmbModel.SelectedValue = 0 Then
            MsgBox("Silahkan data dilengkapi terlebih dahulu")
            Exit Sub
        Else
            Try
                OpenConnection()
                sql = "SpInsertAset '" & TxtBarcode.Text & "'," & CmbModel.SelectedValue &
                      "," & CmbType.SelectedValue & "," & CmbMerk.SelectedValue &
                      "," & Menu_Utama.Kd_Karyawan.Text & ""
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
        If TxtBarcode.Text = "" Or
            CmbType.SelectedValue = 0 Or
            CmbMerk.SelectedValue = 0 Or
            CmbModel.SelectedValue = 0 Then
            MsgBox("Silahkan data dilengkapi terlebih dahulu")
            Exit Sub
        Else
            Try
                OpenConnection()
                sql = "SpUpdateAset '" & TxtBarcode.Text & "'," & CmbModel.SelectedValue &
                      "," & CmbType.SelectedValue & "," & CmbMerk.SelectedValue &
                      "," & Menu_Utama.Kd_Karyawan.Text & ""
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK)
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
        Try
            OpenConnection()
            sql = "SpDeleteAset '" & TxtBarcode.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Delete", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data tidak bisa di Hapus, Sedang digunakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub DgAset_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAset.CellContentClick
        Try
            With DgAset.Rows(e.RowIndex)
                TxtBarcode.Text = .Cells(0).Value
                CmbType.SelectedValue = .Cells(5).Value
                CmbMerk.SelectedValue = .Cells(3).Value
                CmbModel.SelectedValue = .Cells(1).Value
                HitungLiter()
            End With
            SetTombol(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbType.SelectedValueChanged
        If CmbType.SelectedValue = Nothing Then
            Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
        Else
            Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, CmbType.SelectedValue)
        End If
    End Sub

    Private Sub CmbMerk_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbMerk.SelectedValueChanged
        If CmbMerk.SelectedValue = Nothing Then
            Model_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Model_Aset, 0)
        Else
            Model_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Model_Aset, CmbMerk.SelectedValue)
        End If
    End Sub

    Private Sub TxtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBarcode.KeyPress
        HanyaAngka(e)
    End Sub
End Class