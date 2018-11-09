Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapMT

    Private Sub FrmLapMT_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrMaintenance1.SetDatabaseLogon("user", "user12345")
        CrMaintenance1.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class