Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapSparepart

    Private Sub FrmLapSparepart_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrSparePart1.SetDatabaseLogon("user", "user12345")
        CrSparePart1.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class