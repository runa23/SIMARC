Imports System.Data.SqlClient
Imports SIMARC.Modul
Public Class FrmPopUpRepair

    Private Sub FrmPopUpRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub
    Sub Cari()
        sql = "select * from repair where kd_aset like '%" & TxtBarcode.Text & "%'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgListRepair.DataSource = ds.Tables(0)
        SetHeader()
    End Sub
    Sub Tampil()
        sql = "select * from repair"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgListRepair.DataSource = ds.Tables(0)
        SetHeader()
    End Sub
    Sub SetHeader()
        DgListRepair.Columns(0).HeaderText = "Kode Repair"
        DgListRepair.Columns(1).HeaderText = "Barcode"
        DgListRepair.Columns(2).HeaderText = "Kode Outlet"
        DgListRepair.Columns(3).HeaderText = "Tanggal Repair Awal"
        DgListRepair.Columns(4).HeaderText = "User"
        DgListRepair.Columns(5).HeaderText = "Tanggal Repair Akhir"
        DgListRepair.Columns(6).HeaderText = "User"
    End Sub

    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        Cari()
    End Sub

    Private Sub DgListRepair_DoubleClick(sender As Object, e As EventArgs) Handles DgListRepair.DoubleClick
        Try
            With DgListRepair
                FrmRepair.KDRP = .Item(0, .CurrentRow.Index).Value
                FrmRepair.TxtBarcode.Text = .Item(1, .CurrentRow.Index).Value

                OpenConnection()
                sql = "SELECT A.*,m.nm_model,t.nm_type,ma.nm_merk FROM Aset A " &
                      "JOIN Model_Aset m ON m.kd_model = A.kd_model " &
                      "JOIN Type_Aset t ON t.kd_type = A.kd_type " &
                      "join Merk_Aset ma on ma.kd_merk = A.kd_merk " &
                      "where A.kd_aset = '" & .Item(1, .CurrentRow.Index).Value & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                FrmRepair.CmbType.Text = rdr.Item(2) & " - " & rdr.Item(6)
                FrmRepair.LoadType()
                FrmRepair.CmbMerk.Enabled = True
                FrmRepair.CmbMerk.Text = rdr.Item(3) & " - " & rdr.Item(7)
                FrmRepair.LoadMerk()
                FrmRepair.CmbModel.Enabled = True
                FrmRepair.CmbModel.Text = rdr.Item(1) & " - " & rdr.Item(5)
                FrmRepair.LoadModel()
                FrmRepair.HitungLiter()

                rdr.Close()
                CloseConnection()

                FrmRepair.TxtKode.Text = .Item(2, .CurrentRow.Index).Value

                OpenConnection()
                sql = "select * from Lokasi where kd_lokasi='" & .Item(2, .CurrentRow.Index).Value & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                FrmRepair.TxtNama.Text = rdr.Item(1)
                FrmRepair.TxtAlamat.Text = rdr.Item(2)
                FrmRepair.TxtTelp.Text = rdr.Item(3)

                rdr.Close()
                CloseConnection()

                FrmRepair.DtpMulai.Value = .Item(3, .CurrentRow.Index).Value
                FrmRepair.DtpSelesai.Value = .Item(5, .CurrentRow.Index).Value

                OpenConnection()
                sql = "select H.kd_part, S.nm_part, (H.stock_update * -1) as qty from History_Sparepart H " &
                      "join Sparepart S on H.kd_part = S.kd_part " &
                      "where H.kd_rp ='" & .Item(0, .CurrentRow.Index).Value & "'"
                cmd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(cmd)
                ds = New DataSet
                da.Fill(ds, 0)
                rdr = cmd.ExecuteReader
                If rdr.Read Then
                    With FrmRepair
                        .LvSparePart.Clear()
                        .SetLV()
                    End With
                    Dim i, j As Integer
                    i = 0
                    j = 0
                    Dim itemcoll(100) As String
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString
                        Next
                        Dim lst As New ListViewItem(itemcoll)
                        FrmRepair.LvSparePart.Items.Add(lst)
                    Next
                End If
            End With
            FrmRepair.BtnReset.Visible = True
            FrmRepair.BtnProses.Enabled = False
            Me.Dispose()
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class