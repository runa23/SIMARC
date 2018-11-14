Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports SIMARC.Modul

Public Class FrmMaintenance

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Type_AsetTableAdapter.FillBy_ComboBox(SIMARCData_Set.Type_Aset)
        Merk_AsetTableAdapter.FillBy_ComboBox(SIMARCData_Set.Merk_Aset, 0)
        Model_AsetTableAdapter.FillBy_ComboBox(SIMARCData_Set.Model_Aset, 0)
    End Sub
    Sub loadAset()
        Try
            AsetTableAdapter.FillByWhere(Me.SIMARCData_Set.Aset, TxtBacode.Text)
            Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, AsetBindingSource.Current("kd_type"))
            AsetTableAdapter.FillByWhere(Me.SIMARCData_Set.Aset, TxtBacode.Text)
            Model_AsetTableAdapter.FillBy_ComboBox(SIMARCData_Set.Model_Aset, AsetBindingSource.Current("kd_merk"))
            AsetTableAdapter.FillByWhere(Me.SIMARCData_Set.Aset, TxtBacode.Text)

        Catch ex As Exception
            MessageBox.Show("Kode Barcode tidak terdaftar")
        End Try
        
    End Sub

    Private Sub TxtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs)
        HanyaAngka(e)
    End Sub

    Private Sub TxtBacode_TextChanged(sender As Object, e As EventArgs) Handles TxtBacode.TextChanged
        loadAset()
    End Sub
    Private Sub TxtBacode_Validated(sender As Object, e As EventArgs) Handles TxtBacode.Validated

    End Sub
    'Private Sub CmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbType.SelectedValueChanged
    '    If CmbType.SelectedValue = Nothing Then
    '        Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, 0)
    '    Else
    '        Merk_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Merk_Aset, CmbType.SelectedValue)
    '    End If
    'End Sub

    'Private Sub CmbMerk_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbMerk.SelectedValueChanged
    '    If CmbMerk.SelectedValue = Nothing Then
    '        Model_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Model_Aset, 0)
    '    Else
    '        Model_AsetTableAdapter.FillBy_ComboBox(Me.SIMARCData_Set.Model_Aset, CmbMerk.SelectedValue)
    '    End If
    'End Sub
End Class