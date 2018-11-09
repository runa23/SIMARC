Imports System.Data.SqlClient
Public Class FrmUbahPass

    Private Sub FrmUbahPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub UbahPass()
        If TxtPassBaru.Text = "" Or TxtPassLama.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            OpenConnection()
            sql = "select kd_karyawan, password from Karyawan where kd_karyawan=" & Menu_Utama.Kd_Karyawan.Text & " and password='" & TxtPassLama.Text & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader()
            rdr.Read()
            If rdr.HasRows Then
                sql = "update Karyawan set Password='" & TxtPassBaru.Text & "' where kd_karyawan=" & Menu_Utama.Kd_Karyawan.Text & " "
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password Berhasil diganti", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtPassBaru.Clear()
                TxtPassLama.Clear()
            Else
                MessageBox.Show("Password Lama Salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtPassBaru.Clear()
                TxtPassLama.Clear()
                TxtPassLama.Focus()
            End If
            CloseConnection()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        UbahPass()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
End Class