Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmPilihTanggal
    Public Active As String
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        CloseConnection()
        Me.Dispose()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim CryRpt As New ReportDocument
        Dim CrConnectionInfo As New ConnectionInfo

        Try
            With CrConnectionInfo
                .ServerName = ServerName
                .DatabaseName = DatabaseName
                .UserID = userID
                .Password = Password
            End With

            If Active = "SparePart" Then
                With CrConnectionInfo
                    FrmLapSparepart.CrSparePart1.DataSourceConnections.Clear()
                    FrmLapSparepart.CrSparePart1.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapSparepart.CrSparePart1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapSparepart.CrSparePart1.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapSparepart.CrSparePart1.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapSparepart.MdiParent = Menu_Utama
                FrmLapSparepart.Dock = DockStyle.Fill
                FrmLapSparepart.WindowState = FormWindowState.Maximized
                FrmLapSparepart.Show()
            End If

            If Active = "Maintenance" Then
                With CrConnectionInfo
                    FrmLapMT.CrMaintenance1.DataSourceConnections.Clear()
                    FrmLapMT.CrMaintenance1.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapMT.CrMaintenance1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapMT.CrMaintenance1.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapMT.CrMaintenance1.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapMT.MdiParent = Menu_Utama
                FrmLapMT.Dock = DockStyle.Fill
                FrmLapMT.WindowState = FormWindowState.Maximized
                FrmLapMT.Show()
            End If

            If Active = "Checklist" Then
                With CrConnectionInfo
                    FrmLapChecklist.CrMT21.DataSourceConnections.Clear()
                    FrmLapChecklist.CrMT21.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapChecklist.CrMT21.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapChecklist.CrMT21.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapChecklist.CrMT21.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapChecklist.MdiParent = Menu_Utama
                FrmLapChecklist.Dock = DockStyle.Fill
                FrmLapChecklist.WindowState = FormWindowState.Maximized
                FrmLapChecklist.Show()
            End If

            If Active = "Repair" Then
                With CrConnectionInfo
                    FrmLapRepair.CrRepair1.DataSourceConnections.Clear()
                    FrmLapRepair.CrRepair1.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapRepair.CrRepair1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapRepair.CrRepair1.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapRepair.CrRepair1.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapRepair.MdiParent = Menu_Utama
                FrmLapRepair.Dock = DockStyle.Fill
                FrmLapRepair.WindowState = FormWindowState.Maximized
                FrmLapRepair.Show()
            End If

            If Active = "RepairLengkap" Then
                With CrConnectionInfo
                    FrmLapRepairLengkap.CrRepair21.DataSourceConnections.Clear()
                    FrmLapRepairLengkap.CrRepair21.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapRepairLengkap.CrRepair21.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapRepairLengkap.CrRepair21.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapRepairLengkap.CrRepair21.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapRepairLengkap.MdiParent = Menu_Utama
                FrmLapRepairLengkap.Dock = DockStyle.Fill
                FrmLapRepairLengkap.WindowState = FormWindowState.Maximized
                FrmLapRepairLengkap.Show()
            End If

            If Active = "Keuangan" Then
                With CrConnectionInfo
                    FrmLapKeuangan.CrKeuangan1.DataSourceConnections.Clear()
                    FrmLapKeuangan.CrKeuangan1.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapKeuangan.CrKeuangan1.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapKeuangan.CrKeuangan1.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapKeuangan.CrKeuangan1.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapKeuangan.MdiParent = Menu_Utama
                FrmLapKeuangan.Dock = DockStyle.Fill
                FrmLapKeuangan.WindowState = FormWindowState.Maximized
                FrmLapKeuangan.Show()
            End If

            If Active = "KeuanganLengkap" Then
                With CrConnectionInfo
                    FrmLapKeuanganLengkap.CrKeuangan21.DataSourceConnections.Clear()
                    FrmLapKeuanganLengkap.CrKeuangan21.DataSourceConnections.Item(0).SetConnection(.ServerName, .DatabaseName, .UserID, .Password)
                    FrmLapKeuanganLengkap.CrKeuangan21.SetDatabaseLogon(.UserID, .Password, .ServerName, .DatabaseName)
                End With
                FrmLapKeuanganLengkap.CrKeuangan21.SetParameterValue("Tanggal Awal", DTAwal.Value)
                FrmLapKeuanganLengkap.CrKeuangan21.SetParameterValue("Tanggal Akhir", DTAkhir.Value)

                FrmLapKeuanganLengkap.MdiParent = Menu_Utama
                FrmLapKeuanganLengkap.Dock = DockStyle.Fill
                FrmLapKeuanganLengkap.WindowState = FormWindowState.Maximized
                FrmLapKeuanganLengkap.Show()
            End If

            CloseConnection()
            Active = ""
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub FrmPilihTanggal_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
    End Sub
End Class