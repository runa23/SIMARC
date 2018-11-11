Imports System.Data
Imports System.Data.SqlClient
Public Class FrmSparePart
    Dim kode, repair As String

    Private Sub FrmSparePart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SparepartTableAdapter.Fill(Me.SIMARCData_Set.Sparepart)
        SetTombol(True)
    End Sub
    Sub SetTombol(ByVal st As Boolean)
        BtnSimpan.Enabled = st
        BtnEdit.Enabled = Not st
        BtnHapus.Enabled = Not st
        BtnBatal.Enabled = Not st
        BtnKeluar.Enabled = st
    End Sub
    Sub ReloadData()
        SparepartTableAdapter.Fill(SIMARCData_Set.Sparepart)
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

                MessageBox.Show("Data Berhasil di Simpan", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            ReloadData()
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
                MessageBox.Show("Data Berhasil di Edit", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            SetTombol(True)
            ReloadData()
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
        SetTombol(True)
        ReloadData()
        CloseConnection()
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
        SetTombol(True)
        ReloadData()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub

    Private Sub DgSparepart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSparepart.CellContentClick
        With DgSparepart.Rows(e.RowIndex)
            kode = .Cells(0).Value
            TxtNama.Text = .Cells(1).Value
            TxtHarga.Text = Val(.Cells(2).Value)
            TxtStock.Text = 0
            TxtNama.Enabled = False
        End With
        SetTombol(False)
    End Sub
End Class