Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPopUpSparePart

    Private Sub FrmPopUpSparePart_Load(sender As Object, e As EventArgs) Handles Me.Load
        TampilData()
    End Sub
    Sub TampilData()
        OpenConnection()
        sql = "select * from SparePart"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgSparepart.DataSource = ds.Tables(0)
        SetHeader()
        CloseConnection()
    End Sub
    Sub SetHeader()
        With DgSparepart
            .Columns(0).HeaderText = "No"
            .Columns(1).HeaderText = "Nama"
            .Columns(2).HeaderText = "Harga"
            .Columns(3).HeaderText = "stock"

        End With
    End Sub
    Sub Cari()
        OpenConnection()
        sql = "select * from SparePart where nm_part like '%" & TxtNama.Text & _
              "%' or kd_part like '%" & TxtNama.Text & "%'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, 0)
        DgSparepart.DataSource = ds.Tables(0)
        SetHeader()
        CloseConnection()
    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged
        If TxtNama.Text = "" Then
            TampilData()
        Else
            Cari()
        End If
    End Sub
    Private Sub DgSparepart_DoubleClick(sender As Object, e As EventArgs) Handles DgSparepart.DoubleClick
        Try
            With DgSparepart
                FrmRepair.sparepart = .Item(0, .CurrentRow.Index).Value
                FrmRepair.TxtNmSP.Text = .Item(1, .CurrentRow.Index).Value
            End With
            Me.Close()
            FrmRepair.TxtStock.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class