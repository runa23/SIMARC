Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapChecklist

    Private Sub FrmLapChecklist_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrMT21.SetDatabaseLogon("user", "user12345")
        CrMT21.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class