Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmLapRepairLengkap

    Private Sub FrmLapRepairLengkap_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrRepair21.SetDatabaseLogon("user", "user12345")
        CrRepair21.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class