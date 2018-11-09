Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapRepair

    Private Sub FrmLapRepair_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrRepair1.SetDatabaseLogon("user", "user12345")
        CrRepair1.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class