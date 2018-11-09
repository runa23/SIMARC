Imports System.Data.SqlClient
Imports SIMARC.Modul

Public Class FrmPopUpMT

    Private Sub FrmPopUpMTvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub
    Sub Tampil()
        sql = "select * from Maintenance"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgListMT.DataSource = ds.Tables(0)
        SetHeader()
    End Sub
    Sub Cari()
        sql = "select * from Maintenance where kd_aset like '%" & TxtBarcode.Text & "%'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgListMT.DataSource = ds.Tables(0)
        SetHeader()
    End Sub
    Sub SetHeader()
        DgListMT.Columns(0).HeaderText = "Kode MT"
        DgListMT.Columns(1).HeaderText = "Tgl Awal"
        DgListMT.Columns(2).HeaderText = "Tgl Akhir"
        DgListMT.Columns(3).HeaderText = "Barcode"
        DgListMT.Columns(4).HeaderText = "Kode Outlet"
        DgListMT.Columns(5).HeaderText = "Kode User"
    End Sub
    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        Cari()
    End Sub

    Private Sub DgListMT_DoubleClick(sender As Object, e As EventArgs) Handles DgListMT.DoubleClick
        Try
            With DgListMT
                FrmMT.KDMT = .Item(0, .CurrentRow.Index).Value
                FrmMT.TxtBarcode.Text = .Item(3, .CurrentRow.Index).Value

                OpenConnection()
                sql = "SELECT A.*,m.nm_model,t.nm_type,ma.nm_merk FROM Aset A " &
                      "JOIN Model_Aset m ON m.kd_model = A.kd_model " &
                      "JOIN Type_Aset t ON t.kd_type = A.kd_type " &
                      "join Merk_Aset ma on ma.kd_merk = A.kd_merk " &
                      "where A.kd_aset = '" & .Item(3, .CurrentRow.Index).Value & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                FrmMT.CmbType.Text = rdr.Item(2) & " - " & rdr.Item(6)
                FrmMT.LoadType()
                FrmMT.CmbMerk.Enabled = True
                FrmMT.CmbMerk.Text = rdr.Item(3) & " - " & rdr.Item(7)
                FrmMT.LoadMerk()
                FrmMT.CmbModel.Enabled = True
                FrmMT.CmbModel.Text = rdr.Item(1) & " - " & rdr.Item(5)
                FrmMT.LoadModel()
                FrmMT.HitungLiter()

                rdr.Close()
                CloseConnection()

                FrmMT.TxtKode.Text = .Item(4, .CurrentRow.Index).Value

                OpenConnection()
                sql = "select * from Lokasi where kd_lokasi='" & .Item(4, .CurrentRow.Index).Value & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                FrmMT.TxtNama.Text = rdr.Item(1)
                FrmMT.TxtAlamat.Text = rdr.Item(2)
                FrmMT.TxtTelp.Text = rdr.Item(3)

                rdr.Close()
                CloseConnection()

                FrmMT.DtpMulai.Value = .Item(1, .CurrentRow.Index).Value
                FrmMT.DtpSelesai.Value = .Item(2, .CurrentRow.Index).Value

                OpenConnection()
                sql = "select kasus.kd_kasus, Kasus.nm_kasus, ma.Baik, ma.Rusak, ma.Ganti, ma.Rusak_total from Maintenance_Action ma" &
                      " join Kasus on Kasus.kd_kasus = ma.kd_kasus" &
                      " where ma.kd_mt = '" & .Item(0, .CurrentRow.Index).Value & "'"
                da = New SqlDataAdapter(sql, con)
                ds = New DataSet
                da.Fill(ds, 0)


                For i = 0 To ds.Tables(0).Rows.Count - 1

                    If ds.Tables(0).Rows(i)(2).ToString = "True" Then
                        FrmMT.DgChecklist.Rows(i).Cells("KB").Value = True
                    Else
                        FrmMT.DgChecklist.Rows(i).Cells("KB").Value = False
                    End If
                    If ds.Tables(0).Rows(i)(3).ToString = "True" Then
                        FrmMT.DgChecklist.Rows(i).Cells("KR").Value = True
                    Else
                        FrmMT.DgChecklist.Rows(i).Cells("KR").Value = False
                    End If
                    If ds.Tables(0).Rows(i)(4).ToString = "True" Then
                        FrmMT.DgChecklist.Rows(i).Cells("TG").Value = True
                    Else
                        FrmMT.DgChecklist.Rows(i).Cells("TG").Value = False
                    End If
                    If ds.Tables(0).Rows(i)(5).ToString = "True" Then
                        FrmMT.DgChecklist.Rows(i).Cells("TR").Value = True
                    Else
                        FrmMT.DgChecklist.Rows(i).Cells("TR").Value = False
                    End If
                Next
            End With
            FrmMT.BtnReset.Visible = True
            FrmMT.BtnCeklist.Enabled = False
            FrmMT.BtnProses.Enabled = False
            Me.Dispose()
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class