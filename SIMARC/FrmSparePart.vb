Imports System.Data
Imports System.Data.SqlClient
Public Class FrmSparePart
    Dim kode, repair As String

    Private Sub FrmSparePart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        SetTombol1()
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
    Sub SetTombol1()
        BtnSimpan.Enabled = True
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        BtnKeluar.Enabled = True
    End Sub
    Sub SetTombol2()
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnBatal.Enabled = True
        BtnKeluar.Enabled = False
    End Sub
    Sub Clear()
        TxtNama.Clear()
        TxtStock.Clear()
        TxtHarga.Clear()
        kode = ""
        TxtNama.Enabled = True
    End Sub
    Sub Insert()
        If TxtNama.Text = "" Or TxtStock.Text = "" Or TxtHarga.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else

            Try
                OpenConnection()
                sql = "SpInsertPart '" & TxtNama.Text & "'," & Val(TxtHarga.Text) &
                  "," & Val(TxtStock.Text) & ",'" & Format(DtpPart.Value, "yyyy-MM-dd") &
                  "'," & Menu_Utama.Kd_Karyawan.Text & ",NULL"
                Debug.Print(sql)
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'sql = "SpInsertHistory " & Val(TxtHarga.Text) &
                '  "," & Val(TxtStock.Text) & ",'" & Format(DtpPart.Value, "yyyy-MM-dd") &
                '  "'," & Menu_Utama.Kd_Karyawan.Text & ",NULL"
                'Debug.Print(sql)
                'cmd = New SqlCommand(sql, con)
                'cmd.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            TampilData()
            CloseConnection()
        End If
    End Sub
    Sub Edit()
        If TxtNama.Text = "" Or TxtStock.Text = "" Or TxtHarga.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
            Exit Sub
        Else
            Try
                OpenConnection()
                sql = "SpUpdatePart " & kode & ",'" & TxtNama.Text & "','" & Format(DtpPart.Value, "yyyy-MM-dd") &
                      "'," & Val(TxtHarga.Text) & "," & Val(TxtStock.Text) & "," & Menu_Utama.Kd_Karyawan.Text &
                      ",NULL"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            SetTombol1()
            TampilData()
            CloseConnection()
        End If
    End Sub
    Sub Delete()
        Try
            OpenConnection()
            sql = "SpDeletePart " & kode & ""
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data sedang digunakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Clear()
        SetTombol1()
        TampilData()
        CloseConnection()
    End Sub

    Private Sub DgSparepart_DoubleClick(sender As Object, e As EventArgs) Handles DgSparepart.DoubleClick
        With DgSparepart
            kode = .Item(0, .CurrentRow.Index).Value
            TxtNama.Text = .Item(1, .CurrentRow.Index).Value
            TxtHarga.Text = Val(.Item(2, .CurrentRow.Index).Value)
            TxtStock.Text = 0
            TxtNama.Enabled = False

        End With
        SetTombol2()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Insert()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Edit()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Delete()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Clear()
        SetTombol1()
        TampilData()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
End Class