Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapKeuangan

    Private Sub FrmLapKeuangan_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrKeuangan1.SetDatabaseLogon("user", "user12345")
        CrKeuangan1.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class