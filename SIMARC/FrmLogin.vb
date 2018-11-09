Imports System.Data
Imports System.Data.SqlClient

Public Class FrmLogin
    Dim jabatan As String
    Dim conses() As String
    Sub Login()
        OpenConnection()
        conses = Split(CmbWilayah.Text, " - ")
        If CmbWilayah.Text = "" Or UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Concess / Username / Password tidak boleh kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql = "select * from Karyawan where username='" & UsernameTextBox.Text & _
                  "' and password='" & PasswordTextBox.Text & _
                  "' and wlyh_karyawan=" & conses(0) & ""
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()
            If rdr.HasRows Then

                Menu_Utama.Kd_Karyawan.Text = rdr.Item(0)
                Menu_Utama.Nm_Karyawan.Text = rdr.Item(1)
                jabatan = rdr.Item(4)
                rdr.Close()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                CmbWilayah.SelectedIndex = -1
                Akses()
                Me.Hide()
                Menu_Utama.Show()
            Else
                rdr.Close()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                CmbWilayah.SelectedIndex = -1
                CmbWilayah.Focus()
                MsgBox("Username / Password Salah")
            End If
        End If
        CloseConnection()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Login()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Sub Akses()
        Try
            OpenConnection()
            sql = "select * from Hak_Akses where Jabatan='" & jabatan & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()

            If Not rdr.HasRows Then
                With Menu_Utama
                    .PetugasToolStripMenuItem.Enabled = False
                    .OutletToolStripMenuItem.Enabled = False
                    .TypeAsetToolStripMenuItem.Enabled = False
                    .MerkAsetToolStripMenuItem.Enabled = False
                    .ModelAsetToolStripMenuItem.Enabled = False
                    .AsetToolStripMenuItem.Enabled = False
                    .SpareToolStripMenuItem.Enabled = False
                    .MaintenanceToolStripMenuItem.Enabled = False
                    .RepairToolStripMenuItem.Enabled = False
                    .LaporanAsetToolStripMenuItem.Enabled = False
                    .LaporanSparePartToolStripMenuItem.Enabled = False
                    .LaporanMaintenanceToolStripMenuItem.Enabled = False
                    .LaporanMaintenanceToolStripMenuItem.Enabled = False
                    .LaporanRepairToolStripMenuItem.Enabled = False
                    .LaporanRepairLengkapToolStripMenuItem.Enabled = False
                    .LaporanKeuanganToolStripMenuItem.Enabled = False
                    .LaporanKeuanganLengkapToolStripMenuItem.Enabled = False
                    .HakAksesToolStripMenuItem.Enabled = False
                End With
            Else
                With Menu_Utama
                    .PetugasToolStripMenuItem.Enabled = rdr.Item(1)
                    .PetugasToolStripMenuItem.Visible = rdr.Item(1)
                    .OutletToolStripMenuItem.Enabled = rdr.Item(2)
                    .OutletToolStripMenuItem.Visible = rdr.Item(2)
                    .TypeAsetToolStripMenuItem.Enabled = rdr.Item(3)
                    .TypeAsetToolStripMenuItem.Visible = rdr.Item(3)
                    .MerkAsetToolStripMenuItem.Enabled = rdr.Item(4)
                    .MerkAsetToolStripMenuItem.Visible = rdr.Item(4)
                    .ModelAsetToolStripMenuItem.Enabled = rdr.Item(5)
                    .ModelAsetToolStripMenuItem.Visible = rdr.Item(5)
                    .AsetToolStripMenuItem.Enabled = rdr.Item(6)
                    .AsetToolStripMenuItem.Visible = rdr.Item(6)
                    .SpareToolStripMenuItem.Enabled = rdr.Item(7)
                    .SpareToolStripMenuItem.Visible = rdr.Item(7)
                    .MaintenanceToolStripMenuItem.Enabled = rdr.Item(8)
                    .MaintenanceToolStripMenuItem.Visible = rdr.Item(8)
                    .RepairToolStripMenuItem.Enabled = rdr.Item(9)
                    .RepairToolStripMenuItem.Visible = rdr.Item(9)
                    .LaporanAsetToolStripMenuItem.Enabled = rdr.Item(10)
                    .LaporanAsetToolStripMenuItem.Visible = rdr.Item(10)
                    .LaporanSparePartToolStripMenuItem.Enabled = rdr.Item(11)
                    .LaporanSparePartToolStripMenuItem.Visible = rdr.Item(11)
                    .LaporanMaintenanceToolStripMenuItem.Enabled = rdr.Item(12)
                    .LaporanMaintenanceToolStripMenuItem.Visible = rdr.Item(12)
                    .LaporanChecklistToolStripMenuItem1.Enabled = rdr.Item(13)
                    .LaporanChecklistToolStripMenuItem1.Visible = rdr.Item(13)
                    .LaporanRepairToolStripMenuItem.Enabled = rdr.Item(14)
                    .LaporanRepairToolStripMenuItem.Visible = rdr.Item(14)
                    .LaporanRepairLengkapToolStripMenuItem.Enabled = rdr.Item(15)
                    .LaporanRepairLengkapToolStripMenuItem.Visible = rdr.Item(15)
                    .LaporanKeuanganToolStripMenuItem.Enabled = rdr.Item(16)
                    .LaporanKeuanganToolStripMenuItem.Visible = rdr.Item(16)
                    .LaporanKeuanganLengkapToolStripMenuItem.Enabled = rdr.Item(17)
                    .LaporanKeuanganLengkapToolStripMenuItem.Visible = rdr.Item(17)
                    .HakAksesToolStripMenuItem.Enabled = rdr.Item(18)
                    .HakAksesToolStripMenuItem.Visible = rdr.Item(18)
                End With
                rdr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
