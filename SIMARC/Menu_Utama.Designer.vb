<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Kd_Karyawan = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Nm_Karyawan = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrezerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerkAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportMerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChecklistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanSparePartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanChecklistToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanRepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanRepairLengkapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKeuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKeuanganLengkapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Kd_Karyawan, Me.Nm_Karyawan, Me.Time})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(805, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(568, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Sistem Informasi Maintenance dan Repair (SIMARC)"
        '
        'Kd_Karyawan
        '
        Me.Kd_Karyawan.Name = "Kd_Karyawan"
        Me.Kd_Karyawan.Size = New System.Drawing.Size(88, 17)
        Me.Kd_Karyawan.Text = "Kode Karyawan"
        '
        'Nm_Karyawan
        '
        Me.Nm_Karyawan.Name = "Nm_Karyawan"
        Me.Nm_Karyawan.Size = New System.Drawing.Size(93, 17)
        Me.Nm_Karyawan.Text = "Nama Karyawan"
        '
        'Time
        '
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(41, 17)
        Me.Time.Text = "Waktu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.ChecklistToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(805, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.monitor
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbahPasswordToolStripMenuItem, Me.HakAksesToolStripMenuItem})
        Me.SettingToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.setting
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Login2
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UbahPasswordToolStripMenuItem.Text = "Ubah Password"
        '
        'HakAksesToolStripMenuItem
        '
        Me.HakAksesToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Key1
        Me.HakAksesToolStripMenuItem.Name = "HakAksesToolStripMenuItem"
        Me.HakAksesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.HakAksesToolStripMenuItem.Text = "Hak Akses"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 6)
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Logout1
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Door1
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasToolStripMenuItem, Me.OutletToolStripMenuItem, Me.FrezerToolStripMenuItem, Me.SpareToolStripMenuItem, Me.ImportToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.MasterData1
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Petugas
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'OutletToolStripMenuItem
        '
        Me.OutletToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Store1
        Me.OutletToolStripMenuItem.Name = "OutletToolStripMenuItem"
        Me.OutletToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OutletToolStripMenuItem.Text = "Outlet"
        '
        'FrezerToolStripMenuItem
        '
        Me.FrezerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeAsetToolStripMenuItem, Me.MerkAsetToolStripMenuItem, Me.ModelAsetToolStripMenuItem, Me.AsetToolStripMenuItem})
        Me.FrezerToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Freezer
        Me.FrezerToolStripMenuItem.Name = "FrezerToolStripMenuItem"
        Me.FrezerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FrezerToolStripMenuItem.Text = "Frezer"
        '
        'TypeAsetToolStripMenuItem
        '
        Me.TypeAsetToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.typeAsetType
        Me.TypeAsetToolStripMenuItem.Name = "TypeAsetToolStripMenuItem"
        Me.TypeAsetToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TypeAsetToolStripMenuItem.Text = "Type Aset"
        '
        'MerkAsetToolStripMenuItem
        '
        Me.MerkAsetToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.TypeMerk
        Me.MerkAsetToolStripMenuItem.Name = "MerkAsetToolStripMenuItem"
        Me.MerkAsetToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.MerkAsetToolStripMenuItem.Text = "Merk Aset"
        '
        'ModelAsetToolStripMenuItem
        '
        Me.ModelAsetToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.TypeModel
        Me.ModelAsetToolStripMenuItem.Name = "ModelAsetToolStripMenuItem"
        Me.ModelAsetToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ModelAsetToolStripMenuItem.Text = "Model Aset"
        '
        'AsetToolStripMenuItem
        '
        Me.AsetToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Freezer
        Me.AsetToolStripMenuItem.Name = "AsetToolStripMenuItem"
        Me.AsetToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AsetToolStripMenuItem.Text = "Aset"
        '
        'SpareToolStripMenuItem
        '
        Me.SpareToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Sparepart
        Me.SpareToolStripMenuItem.Name = "SpareToolStripMenuItem"
        Me.SpareToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpareToolStripMenuItem.Text = "Spare Part"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportTypeToolStripMenuItem, Me.ImportMerkToolStripMenuItem, Me.ImportModelToolStripMenuItem, Me.ImportAsetToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ImportTypeToolStripMenuItem
        '
        Me.ImportTypeToolStripMenuItem.Name = "ImportTypeToolStripMenuItem"
        Me.ImportTypeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportTypeToolStripMenuItem.Text = "Import Type"
        '
        'ImportMerkToolStripMenuItem
        '
        Me.ImportMerkToolStripMenuItem.Name = "ImportMerkToolStripMenuItem"
        Me.ImportMerkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportMerkToolStripMenuItem.Text = "Import Merk"
        '
        'ImportModelToolStripMenuItem
        '
        Me.ImportModelToolStripMenuItem.Name = "ImportModelToolStripMenuItem"
        Me.ImportModelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportModelToolStripMenuItem.Text = "Import Model"
        '
        'ImportAsetToolStripMenuItem
        '
        Me.ImportAsetToolStripMenuItem.Name = "ImportAsetToolStripMenuItem"
        Me.ImportAsetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportAsetToolStripMenuItem.Text = "Import Aset"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Import Outlet"
        '
        'ChecklistToolStripMenuItem
        '
        Me.ChecklistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceToolStripMenuItem, Me.RepairToolStripMenuItem})
        Me.ChecklistToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Check_16x16
        Me.ChecklistToolStripMenuItem.Name = "ChecklistToolStripMenuItem"
        Me.ChecklistToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ChecklistToolStripMenuItem.Text = "Checklist"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.checklist
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'RepairToolStripMenuItem
        '
        Me.RepairToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.tools
        Me.RepairToolStripMenuItem.Name = "RepairToolStripMenuItem"
        Me.RepairToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RepairToolStripMenuItem.Text = "Repair"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanAsetToolStripMenuItem, Me.LaporanSparePartToolStripMenuItem, Me.LaporanMaintenanceToolStripMenuItem, Me.LaporanChecklistToolStripMenuItem1, Me.LaporanRepairToolStripMenuItem, Me.LaporanRepairLengkapToolStripMenuItem, Me.LaporanKeuanganToolStripMenuItem, Me.LaporanKeuanganLengkapToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.Reportchecklist
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanAsetToolStripMenuItem
        '
        Me.LaporanAsetToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanAset
        Me.LaporanAsetToolStripMenuItem.Name = "LaporanAsetToolStripMenuItem"
        Me.LaporanAsetToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanAsetToolStripMenuItem.Text = "Laporan Aset"
        '
        'LaporanSparePartToolStripMenuItem
        '
        Me.LaporanSparePartToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanSParepart
        Me.LaporanSparePartToolStripMenuItem.Name = "LaporanSparePartToolStripMenuItem"
        Me.LaporanSparePartToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanSparePartToolStripMenuItem.Text = "Laporan Spare Part"
        '
        'LaporanMaintenanceToolStripMenuItem
        '
        Me.LaporanMaintenanceToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanMaintenance
        Me.LaporanMaintenanceToolStripMenuItem.Name = "LaporanMaintenanceToolStripMenuItem"
        Me.LaporanMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanMaintenanceToolStripMenuItem.Text = "Laporan Maintenance"
        '
        'LaporanChecklistToolStripMenuItem1
        '
        Me.LaporanChecklistToolStripMenuItem1.Image = Global.SIMARC.My.Resources.Resources.LaporanCeklist1
        Me.LaporanChecklistToolStripMenuItem1.Name = "LaporanChecklistToolStripMenuItem1"
        Me.LaporanChecklistToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.LaporanChecklistToolStripMenuItem1.Text = "Laporan Cheklist"
        '
        'LaporanRepairToolStripMenuItem
        '
        Me.LaporanRepairToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanRepair
        Me.LaporanRepairToolStripMenuItem.Name = "LaporanRepairToolStripMenuItem"
        Me.LaporanRepairToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanRepairToolStripMenuItem.Text = "Laporan Repair"
        '
        'LaporanRepairLengkapToolStripMenuItem
        '
        Me.LaporanRepairLengkapToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanRepairLengkap
        Me.LaporanRepairLengkapToolStripMenuItem.Name = "LaporanRepairLengkapToolStripMenuItem"
        Me.LaporanRepairLengkapToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanRepairLengkapToolStripMenuItem.Text = "Laporan Repair Lengkap"
        '
        'LaporanKeuanganToolStripMenuItem
        '
        Me.LaporanKeuanganToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanKeuangan1
        Me.LaporanKeuanganToolStripMenuItem.Name = "LaporanKeuanganToolStripMenuItem"
        Me.LaporanKeuanganToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanKeuanganToolStripMenuItem.Text = "Laporan Keuangan"
        '
        'LaporanKeuanganLengkapToolStripMenuItem
        '
        Me.LaporanKeuanganLengkapToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.LaporanKeuangan1
        Me.LaporanKeuanganLengkapToolStripMenuItem.Name = "LaporanKeuanganLengkapToolStripMenuItem"
        Me.LaporanKeuanganLengkapToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaporanKeuanganLengkapToolStripMenuItem.Text = "Laporan Keuangan Lengkap"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.SIMARC.My.Resources.Resources.About2
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SIMARC.My.Resources.Resources.MenuUtama
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "Menu_Utama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Kd_Karyawan As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Nm_Karyawan As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrezerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MerkAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChecklistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanSparePartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanChecklistToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanRepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanRepairLengkapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKeuanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKeuanganLengkapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportMerkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportModelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
