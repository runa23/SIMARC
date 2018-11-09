Imports System.Data
Imports System.Data.SqlClient
Public Class FrmHakAkses

    Private Sub FrmHakAkses_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Sub LoadHakAkses()
        Try
            OpenConnection()
            If CmbStats.Text = "Admin" Then
                ChkAkses.Visible = False
            Else : ChkAkses.Visible = True
            End If

            sql = "Select * from Hak_Akses where Jabatan='" & CmbStats.Text & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()

            If Not rdr.HasRows Then
                Uncheck()
            Else
                With rdr
                    ChkPetugas.Checked = .Item(1)
                    ChkOutlet.Checked = .Item(2)
                    ChkType.Checked = .Item(3)
                    ChkMerk.Checked = .Item(4)
                    ChkModel.Checked = .Item(5)
                    ChkAset.Checked = .Item(6)
                    ChkSparepart.Checked = .Item(7)
                    ChkMT.Checked = .Item(8)
                    ChkRepair.Checked = .Item(9)
                    ChkLapAset.Checked = .Item(10)
                    ChkLapSpare.Checked = .Item(11)
                    ChkLapMT.Checked = .Item(12)
                    ChkLapChecklist.Checked = .Item(13)
                    ChkLapRepair.Checked = .Item(14)
                    ChkLapRepair2.Checked = .Item(15)
                    ChkLapKeuangan.Checked = .Item(16)
                    ChkLapKeuanganLngkp.Checked = .Item(17)
                    ChkAkses.Checked = .Item(18)
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rdr.Close()
        CloseConnection()
    End Sub
    Sub Uncheck()
        ChkPetugas.Checked = False
        ChkOutlet.Checked = False
        ChkType.Checked = False
        ChkMerk.Checked = False
        ChkModel.Checked = False
        ChkAset.Checked = False
        ChkSparepart.Checked = False
        ChkMT.Checked = False
        ChkRepair.Checked = False
        ChkLapAset.Checked = False
        ChkLapSpare.Checked = False
        ChkLapMT.Checked = False
        ChkLapChecklist.Checked = False
        ChkLapRepair.Checked = False
        ChkLapRepair2.Checked = False
        ChkLapKeuangan.Checked = False
        ChkLapKeuanganLngkp.Checked = False
        ChkAkses.Checked = False
    End Sub

    Private Sub CmbStats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStats.SelectedIndexChanged
        LoadHakAkses()
    End Sub
    Sub InputAkses()
        Try
            OpenConnection()
            sql = "SpInsertAkses '" & CmbStats.Text & "','" & CInt(ChkPetugas.Checked) * -1 & "','" _
                  & CInt(ChkOutlet.Checked) * -1 & "','" & CInt(ChkType.Checked) * -1 & "','" _
                  & CInt(ChkMerk.Checked) * -1 & "','" & CInt(ChkModel.Checked) * -1 & "','" _
                  & CInt(ChkAset.Checked) * -1 & "','" & CInt(ChkSparepart.Checked) * -1 & "','" _
                  & CInt(ChkMT.Checked) * -1 & "','" & CInt(ChkRepair.Checked) * -1 & "','" _
                  & CInt(ChkLapAset.Checked) * -1 & "','" & CInt(ChkLapSpare.Checked) * -1 & "','" _
                  & CInt(ChkLapMT.Checked) * -1 & "','" & CInt(ChkLapChecklist.Checked) * -1 & "','" _
                  & CInt(ChkLapRepair.Checked) * -1 & "','" & CInt(ChkLapRepair2.Checked) * -1 & "','" _
                  & CInt(ChkLapKeuangan.Checked) * -1 & "','" & CInt(ChkLapKeuanganLngkp.Checked) * -1 & "','" _
                  & CInt(ChkAkses.Checked) * -1 & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Sub UpdateAkses()
        Try
            OpenConnection()
            sql = "SpUpdateAkses '" & CmbStats.Text & "','" & CInt(ChkPetugas.Checked) * -1 & "','" _
                  & CInt(ChkOutlet.Checked) * -1 & "','" & CInt(ChkType.Checked) * -1 & "','" _
                  & CInt(ChkMerk.Checked) * -1 & "','" & CInt(ChkModel.Checked) * -1 & "','" _
                  & CInt(ChkAset.Checked) * -1 & "','" & CInt(ChkSparepart.Checked) * -1 & "','" _
                  & CInt(ChkMT.Checked) * -1 & "','" & CInt(ChkRepair.Checked) * -1 & "','" _
                  & CInt(ChkLapAset.Checked) * -1 & "','" & CInt(ChkLapSpare.Checked) * -1 & "','" _
                  & CInt(ChkLapMT.Checked) * -1 & "','" & CInt(ChkLapChecklist.Checked) * -1 & "','" _
                  & CInt(ChkLapRepair.Checked) * -1 & "','" & CInt(ChkLapRepair2.Checked) * -1 & "','" _
                  & CInt(ChkLapKeuangan.Checked) * -1 & "','" & CInt(ChkLapKeuanganLngkp.Checked) * -1 & "','" _
                  & CInt(ChkAkses.Checked) * -1 & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If CmbStats.Text = "" Then
            MsgBox("Silahkan pilih data terlebih dahulu")
            Exit Sub
        Else

            Try
                OpenConnection()
                sql = "select * from Hak_Akses where Jabatan ='" & CmbStats.Text & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                If Not rdr.HasRows Then
                    InputAkses()
                Else
                    UpdateAkses()
                End If
                rdr.Close()
                Uncheck()
                CmbStats.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
End Class