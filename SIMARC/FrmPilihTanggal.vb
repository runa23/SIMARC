Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmPilihTanggal

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        CloseConnection()
        Me.Dispose()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim CryRpt As New ReportDocument
        Dim CrConnectionInfo As New ConnectionInfo

        With CrConnectionInfo
            .ServerName = "."
            .DatabaseName = "SIMARF"
            .UserID = "user"
            .Password = "user12345"

            FrmLapRepair.CrRepair1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
        End With

        FrmLapRepair.CrRepair1.SetParameterValue("Tanggal Awal", DTAwal.Value)
        FrmLapRepair.CrRepair1.SetParameterValue("Tanggal Akhir", DTAkhir.Value)
        'FrmLapRepair.CrystalReportViewer1.RefreshReport()

        FrmLapRepair.MdiParent = Menu_Utama
        FrmLapRepair.Dock = DockStyle.Fill
        FrmLapRepair.WindowState = FormWindowState.Maximized
        FrmLapRepair.Show()

        CloseConnection()
        Me.Dispose()
    End Sub

    Private Sub FrmPilihTanggal_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
    End Sub
End Class