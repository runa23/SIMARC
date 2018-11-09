Public Class FrmLapKeuanganLengkap

    Private Sub FrmLapKeuanganLengkap_Load(sender As Object, e As EventArgs) Handles Me.Load
        CrKeuangan21.SetDatabaseLogon("user", "user12345")
        CrKeuangan21.SetParameterValue("Cetak", Menu_Utama.Nm_Karyawan.Text)
        CrystalReportViewer1.Refresh()
    End Sub
End Class