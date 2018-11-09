Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapAset

    Private Sub FrmLapAset_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrAset1.SetDatabaseLogon("user", "user12345")
        CrAset1.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class