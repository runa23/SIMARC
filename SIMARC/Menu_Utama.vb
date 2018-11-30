Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Menu_Utama

    Dim WithEvents tm As New Timer With {.Interval = 1000, .Enabled = True}

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        Time.Text = Now.ToString("dd MMMM yyyy HH:mm:ss")
    End Sub

    Private Sub AsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsetToolStripMenuItem.Click
        FrmAset.MdiParent = Me
        FrmAset.Show()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        FrmPetugas.MdiParent = Me
        FrmPetugas.Show()
    End Sub

    Private Sub SpareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpareToolStripMenuItem.Click
        FrmSparePart.MdiParent = Me
        FrmSparePart.Show()
    End Sub

    Private Sub OutletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutletToolStripMenuItem.Click
        FrmLokasi.MdiParent = Me
        FrmLokasi.Show()
    End Sub

    Private Sub TypeAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeAsetToolStripMenuItem.Click
        FrmType.MdiParent = Me
        FrmType.Show()
    End Sub

    Private Sub MerkAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerkAsetToolStripMenuItem.Click
        FrmMerk.MdiParent = Me
        FrmMerk.Show()
    End Sub

    Private Sub ModelAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelAsetToolStripMenuItem.Click
        FrmModel.MdiParent = Me
        FrmModel.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        FrmHakAkses.MdiParent = Me
        FrmHakAkses.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.CmbWilayah.Focus()
        FrmLogin.UsernameTextBox.Text = ""
        FrmLogin.PasswordTextBox.Text = ""
    End Sub

    Private Sub RepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairToolStripMenuItem.Click
        FrmRepair.MdiParent = Me
        FrmRepair.Show()
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        FrmMT.MdiParent = Me
        FrmMT.Show()
    End Sub

    Private Sub LaporanAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanAsetToolStripMenuItem.Click
        Dim CryRpt As New ReportDocument
        Dim CrConnectionInfo As New ConnectionInfo

        With CrConnectionInfo
            .ServerName = ServerName
            .DatabaseName = DatabaseName
            .UserID = userID
            .Password = Password
        End With

        With CrConnectionInfo
            FrmLapAset.CrAset1.DataSourceConnections.Clear()
            FrmLapAset.CrAset1.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
            FrmLapAset.CrAset1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
        End With

        FrmLapAset.MdiParent = Me
        FrmLapAset.Dock = DockStyle.Fill
        FrmLapAset.WindowState = FormWindowState.Maximized
        FrmLapAset.Show()
    End Sub

    Private Sub LaporanSparePartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanSparePartToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "SparePart"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub LaporanMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanMaintenanceToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "Maintenance"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub LaporanChecklistToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaporanChecklistToolStripMenuItem1.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "Checklist"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub LaporanRepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanRepairToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "Repair"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub LaporanRepairLengkapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanRepairLengkapToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "RepairLengkap"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub LaporanKeuanganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKeuanganToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "Keuangan"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        FrmUbahPass.MdiParent = Me
        FrmUbahPass.Show()
    End Sub

    Private Sub LaporanKeuanganLengkapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKeuanganLengkapToolStripMenuItem.Click
        FrmPilihTanggal.MdiParent = Me
        FrmPilihTanggal.Active = "KeuanganLengkap"
        FrmPilihTanggal.Show()
    End Sub

    Private Sub ImportTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportTypeToolStripMenuItem.Click
        FrmImType.MdiParent = Me
        FrmImType.Show()
    End Sub

    Private Sub ImportMerkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportMerkToolStripMenuItem.Click
        FrmImMerk.MdiParent = Me
        FrmImMerk.Show()
    End Sub

    Private Sub ImportModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportModelToolStripMenuItem.Click
        FrmImModel.MdiParent = Me
        FrmImModel.Show()
    End Sub

    Private Sub ImportAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportAsetToolStripMenuItem.Click
        FrmImAset.MdiParent = Me
        FrmImAset.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FrmImOutlet.MdiParent = Me
        FrmImOutlet.Show()
    End Sub

    Private Sub Menu_Utama_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Application.Exit()
    End Sub
End Class
