Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports SIMARC.Modul
Public Class FrmRepair
    Dim type() As String
    Dim merk() As String
    Dim model() As String
    Dim repair As String = ""
    Public sparepart As String = ""
    Public KDRP As String


    'Dim WithEvents tm As New Timer With {.Interval = 5000, .Enabled = True}
    Private Sub FrmRepair_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tampil()
        SetLV()
        DtpMulai.Value = Now
        DtpSelesai.Value = Now
        Aktif()
        BtnReset.Visible = False
    End Sub
    Sub Tampil()
        Try
            OpenConnection()
            sql = "select Repair.kd_rp, Repair.kd_aset, Repair.kd_lokasi, Lokasi.nm_lokasi," & _
                  "Repair.tgl_rp_awal, Repair.si, Karyawan.nm_karyawan, Repair.tgl_rp_akhir, Repair.so," & _
                  "Karyawan.nm_karyawan as Nama from Repair " & _
                  "join Lokasi on Repair.kd_lokasi = Lokasi.kd_lokasi " & _
                  "join Karyawan on Repair.si = Karyawan.kd_karyawan " & _
                  "where repair.so is null or repair.tgl_rp_akhir is null"
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, 0)
            DgRepair.DataSource = ds.Tables(0)
            SetHeader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
    End Sub
    Sub SetHeader()
        With DgRepair
            .Columns(0).HeaderText = "Kode Repair"
            .Columns(1).HeaderText = "Barcode"
            .Columns(2).HeaderText = "Kode Lokasi"
            .Columns(3).HeaderText = "Nama Lokasi"
            .Columns(4).HeaderText = "Tanggal Masuk"
            .Columns(5).HeaderText = "Kode Karyawan"
            .Columns(6).HeaderText = "Nama Karyawan"
            .Columns(7).HeaderText = "Tanggal Selesai"
            .Columns(8).HeaderText = "Kode Karyawan"
            .Columns(9).HeaderText = "Nama Karyawan"
        End With
    End Sub
    Sub Aktif()
        If TxtBarcode.Text = "" Then
            CmbType.Enabled = False
            CmbMerk.Enabled = False
            CmbModel.Enabled = False
        Else
            CmbType.Enabled = True
        End If

        If TxtKode.Text = "" Then
            TxtNama.Enabled = False
            TxtAlamat.Enabled = False
            TxtTelp.Enabled = False
        Else
            TxtNama.Enabled = True
            TxtAlamat.Enabled = True
            TxtTelp.Enabled = True
        End If
    End Sub
    Sub LoadLokasi()
        OpenConnection()
        Try
            sql = "select * from Lokasi where kd_lokasi='" & TxtKode.Text & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()
            If rdr.HasRows Then
                TxtNama.Text = rdr.Item(1)
                TxtAlamat.Text = rdr.Item(2)
                TxtTelp.Text = rdr.Item(3)
            Else
                TxtNama.Text = ""
                TxtAlamat.Text = ""
                TxtTelp.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Sub LoadType()
        OpenConnection()
        Try
            sql = "select * from Type_Aset"
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds)
            CmbType.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                CmbType.Items.Add(ds.Tables(0).Rows(i).Item(0).ToString & " - " & ds.Tables(0).Rows(i).Item(1).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        CloseConnection()
    End Sub
    Sub LoadMerk()
        OpenConnection()
        Try
            Type = Split(CmbType.Text, " - ")
            sql = "select * from Merk_Aset where kd_type = " & Type(0) & ""
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds)
            CmbMerk.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                CmbMerk.Items.Add(ds.Tables(0).Rows(i).Item(0).ToString & " - " & ds.Tables(0).Rows(i).Item(1).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Sub LoadModel()
        OpenConnection()
        Try
            merk = Split(CmbMerk.Text, " - ")
            sql = "select * from Model_Aset where kd_merk = " & merk(0) & ""
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds)
            CmbModel.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                CmbModel.Items.Add(ds.Tables(0).Rows(i).Item(0).ToString & " - " & ds.Tables(0).Rows(i).Item(1).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Sub HitungLiter()
        Dim ltr As Integer = 0
        ltr = Val(Microsoft.VisualBasic.Right(CmbModel.Text, 2)) * 10
        LblUkuran.Text = ltr
    End Sub
    Sub SetLV()
        With LvSparePart
            .Columns.Add("Kode", 80, HorizontalAlignment.Left)
            .Columns.Add("Nama Spare Part", 200, HorizontalAlignment.Left)
            .Columns.Add("Stock", 80, HorizontalAlignment.Center)
            .GridLines = True
            .View = View.Details
            .FullRowSelect = True
        End With
    End Sub
    Sub IsiLV()
        Dim lst As New ListViewItem
        With lst
            .Text = sparepart
            .SubItems.Add(TxtNmSP.Text)
            .SubItems.Add(TxtStock.Text)
        End With
        LvSparePart.Items.Add(lst)
    End Sub
    Sub DelLV()
        If LvSparePart.Items.Count > 0 Then
            LvSparePart.Items.Remove(LvSparePart.SelectedItems(0))
        End If
    End Sub

    Private Sub TxtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBarcode.KeyDown
        'Try
        '    OpenConnection()
        '    If e.KeyCode = Keys.Enter Then
        '        sql = "select aset.kd_aset, Aset.kd_type, Type_Aset.nm_type, aset.kd_merk, Merk_Aset.nm_merk," & _
        '              "aset.kd_model, Model_Aset.nm_model from Aset " & _
        '              "join Type_Aset on Aset.kd_type = Type_Aset.kd_type " & _
        '              "join Merk_Aset on aset.kd_merk = Merk_Aset.kd_merk " & _
        '              "join Model_Aset on aset.kd_model = Model_Aset.kd_model " & _
        '              "where Aset.Kd_Aset='" & TxtBarcode.Text & "'"
        '        cmd = New SqlCommand(sql, con)
        '        rdr = cmd.ExecuteReader()
        '        rdr.Read()
        '        If rdr.HasRows Then
        '            CmbType.Text = rdr.Item(1) & " - " & rdr.Item(2)
        '            CmbMerk.Text = rdr.Item(3) & " - " & rdr.Item(4)
        '            CmbModel.Text = rdr.Item(5) & " - " & rdr.Item(6)
        '            HitungLiter()
        '        Else
        '            LoadType()
        '            CmbType.Text = ""
        '            CmbMerk.Text = ""
        '            CmbModel.Text = ""
        '            LblUkuran.Text = ""
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'rdr.Close()
        'CloseConnection()
    End Sub
    
    Private Sub CmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbType.SelectedIndexChanged
        CmbMerk.Enabled = True
        LoadMerk()
    End Sub

    Private Sub CmbMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMerk.SelectedIndexChanged
        CmbModel.Enabled = True
        LoadModel()
    End Sub

    Private Sub CmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModel.SelectedIndexChanged
        HitungLiter()
    End Sub
    Sub Clear()
        DtpMulai.Value = Now
        DtpSelesai.Value = Now
        TxtBarcode.Clear()
        CmbType.Text = ""
        CmbMerk.Text = ""
        CmbModel.Text = ""
        LblUkuran.Text = ""
        TxtKode.Clear()
        TxtNama.Clear()
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
        repair = ""
        LvSparePart.Clear()
        SetLV()
    End Sub

    Private Sub BtnCariPart_Click(sender As Object, e As EventArgs) Handles BtnCariPart.Click
        FrmPopUpSparePart.MdiParent = Menu_Utama
        FrmPopUpSparePart.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        IsiLV()
        TxtNmSP.Clear()
        TxtStock.Clear()
        sparepart = ""
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        DelLV()
    End Sub
    Sub Insert()
        If TxtBarcode.Text = "" Or
                    CmbType.Text = "" Or
                    CmbMerk.Text = "" Or
                    CmbModel.Text = "" Or
                    TxtKode.Text = "" Or
                    TxtNama.Text = "" Or
                    TxtAlamat.Text = "" Or
                    TxtTelp.Text = "" Or
                    LvSparePart.Items.Count <= 0 Then
            MsgBox("Data Belum lengkap, Silahkan diisi terlebih dahulu")
            Exit Sub
        Else
            Try
                If repair = "" Then
                    OpenConnection()
                    Try
                        sql = "select * from Aset where kd_aset ='" & TxtBarcode.Text & "'"
                        Debug.Print(sql)
                        cmd = New SqlCommand(sql, con)
                        rdr = cmd.ExecuteReader
                        rdr.Read()
                        If Not rdr.HasRows Then
                            type = Split(CmbType.Text, " - ")
                            merk = Split(CmbMerk.Text, " - ")
                            model = Split(CmbModel.Text, " - ")
                            sql = "SpInsertAset '" & TxtBarcode.Text & "'," & model(0) & _
                                  "," & type(0) & "," & merk(0) & "," & Menu_Utama.Kd_Karyawan.Text & ""
                            Debug.Print(sql)
                            cmd = New SqlCommand(sql, con)
                            cmd.ExecuteNonQuery()
                        End If
                        rdr.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    CloseConnection()

                    Try
                        OpenConnection()
                        sql = "select * from Lokasi where kd_lokasi = '" & TxtKode.Text & "'"
                        Debug.Print(sql)
                        cmd = New SqlCommand(sql, con)
                        rdr = cmd.ExecuteReader
                        rdr.Read()
                        If Not rdr.HasRows Then
                            sql = "SpInsertLokasi '" & TxtKode.Text & "','" & TxtNama.Text & _
                                  "','" & TxtAlamat.Text & "','" & TxtTelp.Text & _
                                  "'," & Menu_Utama.Kd_Karyawan.Text & ""
                            cmd = New SqlCommand(sql, con)
                            cmd.ExecuteNonQuery()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    CloseConnection()

                    Try
                        OpenConnection()
                        sql = "SpInsertRepair '" & TxtBarcode.Text & "','" & TxtKode.Text & _
                              "','" & Format(DtpMulai.Value, "yyyy-MM-dd") & "'," & Menu_Utama.Kd_Karyawan.Text & ""
                        Debug.Print(sql)
                        cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        Dim tgl, mon, thn, urut As String

                        tgl = DtpMulai.Value.ToString("dd")
                        mon = DtpMulai.Value.ToString("MM")
                        thn = DtpMulai.Value.ToString("yy")
                        urut = thn & mon & tgl

                        sql = "select * from Repair where kd_rp like '%" & urut & "%' order by kd_rp desc"
                        Debug.Print(sql)
                        cmd = New SqlCommand(sql, con)
                        rdr = cmd.ExecuteReader
                        rdr.Read()
                        repair = rdr.Item(0)
                        rdr.Close()

                        For i As Integer = 0 To LvSparePart.Items.Count - 1
                            With LvSparePart.Items(i)

                                sql = "select hrg_part from sparepart where kd_part=" & .Text & ""
                                Debug.Print(sql)
                                cmd = New SqlCommand(sql, con)
                                rdr = cmd.ExecuteReader
                                rdr.Read()
                                Dim harga As String = rdr.Item(0)
                                rdr.Close()

                                sql = "insert into Det_Repair values('" & repair & "'," & .Text & _
                                      "," & .SubItems(2).Text & "," & Val(harga) & ")"
                                cmd = New SqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "update Sparepart set stock = stock - " & .SubItems(2).Text & _
                                      " where kd_part=" & .Text & ""
                                cmd = New SqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "Insert into History_Sparepart values(" & .Text & _
                                      ",'" & Format(DtpMulai.Value, "yyyy-MM-dd") & "'," & Val(harga) & _
                                      "," & (Val(.SubItems(2).Text) * -1) & "," & Menu_Utama.Kd_Karyawan.Text & _
                                      ",'" & repair & "')"
                                cmd = New SqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                            End With
                        Next
                        Clear()
                        Tampil()
                        MessageBox.Show("Berhasil di proses", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    CloseConnection()

                Else
                    OpenConnection()
                    sql = "SpUpdateRepair '" & repair & "','" & Format(DtpSelesai.Value, "yyyy-MM-dd") & _
                          "'," & Menu_Utama.Kd_Karyawan.Text & ""
                    Debug.Print(sql)
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    Clear()
                    Tampil()
                    MessageBox.Show("Berhasil di proses", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                CloseConnection()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub Edit()
        Try
        If TxtBarcode.Text = "" Or
            CmbType.Text = "" Or
            CmbMerk.Text = "" Or
            CmbModel.Text = "" Or
            TxtKode.Text = "" Or
            TxtNama.Text = "" Or
            TxtAlamat.Text = "" Or
            TxtTelp.Text = "" Then

            MsgBox("Data Belum lengkap, Silahkan diisi terlebih dahulu")
            Exit Sub

        Else
            OpenConnection()
            Try
                sql = ""
                sql = "select * from Aset where kd_aset ='" & TxtBarcode.Text & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()
                If rdr.HasRows Then
                    type = Split(CmbType.Text, " - ")
                    merk = Split(CmbMerk.Text, " - ")
                    model = Split(CmbModel.Text, " - ")
                    sql = "SpUpdateAset '" & TxtBarcode.Text & "'," & model(0) & _
                          "," & type(0) & "," & merk(0) & "," & Menu_Utama.Kd_Karyawan.Text & ""
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End If
                rdr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                sql = "select * from Lokasi where kd_lokasi = '" & TxtKode.Text & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()
                If rdr.HasRows Then
                    sql = "SpUpdateLokasi '" & TxtKode.Text & "','" & TxtNama.Text & _
                          "','" & TxtAlamat.Text & "','" & TxtTelp.Text & _
                          "'," & Menu_Utama.Kd_Karyawan.Text & ""
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End If
                rdr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                sql = "select * from repair where kd_rp ='" & KDRP & "'"
                cmd = New SqlCommand(sql, con)
                rdr = cmd.ExecuteReader
                rdr.Read()

                If rdr.HasRows Then
                    sql = "SpUpdateRepair2 '" & KDRP & "','" & Format(DtpMulai.Value, "yyyy-MM-dd") & "','" & Format(DtpSelesai.Value, "yyyy-MM-dd") & _
                              "','" & TxtBarcode.Text & "','" & TxtKode.Text & "','" & Menu_Utama.Kd_Karyawan.Text & "'"
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End If
                rdr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

                Try
                    sql = "select * from History_Sparepart where kd_rp ='" & KDRP & "'"
                    cmd = New SqlCommand(sql, con)
                    da = New SqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, 0)
                    rdr = cmd.ExecuteReader
                    rdr.Read()

                    If rdr.HasRows Then
                        For i = 0 To ds.Tables.Count
                            sql = "update History_Sparepart set tgl_update ='" & Format(DtpMulai.Value, "yyyy-MM-dd") & "' where kd_rp='" & KDRP & "'"
                            cmd = New SqlCommand(sql, con)
                            cmd.ExecuteNonQuery()
                        Next
                    End If
                    rdr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MessageBox.Show("Data berhasil di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                KDRP = ""
                Tampil()
                BtnProses.Enabled = True
                BtnReset.Visible = False
                TxtBarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Private Sub DgRepair_DoubleClick(sender As Object, e As EventArgs) Handles DgRepair.DoubleClick
        With DgRepair
            repair = .Item(0, .CurrentRow.Index).Value

            TxtBarcode.Text = .Item(1, .CurrentRow.Index).Value
            LoadAset()

            TxtKode.Text = .Item(2, .CurrentRow.Index).Value
            LoadLokasi()

            LoadPart()
        End With
    End Sub
    Sub LoadPart()
        OpenConnection()
        sql = "select Det_Repair.kd_part, Sparepart.nm_part, Det_Repair.qty_part from Det_Repair" & _
              " join Sparepart on Sparepart.kd_part = Det_Repair.kd_part" & _
              " where Det_Repair.kd_rp='" & repair & "'"
        cmd = New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, 0)
        rdr = cmd.ExecuteReader
        If rdr.Read Then
            LvSparePart.Clear()
            SetLV()
            Dim i, j As Integer
            i = 0
            j = 0
            Dim itemcoll(100) As String
            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString
                Next
                Dim lst As New ListViewItem(itemcoll)
                LvSparePart.Items.Add(lst)
            Next
        End If
        rdr.Close()
        CloseConnection()
    End Sub
    Sub LoadAset()
        Try
            OpenConnection()
            sql = "select aset.kd_aset, Aset.kd_type, Type_Aset.nm_type, aset.kd_merk, Merk_Aset.nm_merk," & _
                      "aset.kd_model, Model_Aset.nm_model from Aset " & _
                      "join Type_Aset on Aset.kd_type = Type_Aset.kd_type " & _
                      "join Merk_Aset on aset.kd_merk = Merk_Aset.kd_merk " & _
                      "join Model_Aset on aset.kd_model = Model_Aset.kd_model " & _
                      "where Aset.Kd_Aset='" & TxtBarcode.Text & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader()
            rdr.Read()
            If rdr.HasRows Then
                CmbType.Text = rdr.Item(1) & " - " & rdr.Item(2)
                CmbMerk.Text = rdr.Item(3) & " - " & rdr.Item(4)
                CmbModel.Text = rdr.Item(5) & " - " & rdr.Item(6)
                HitungLiter()
            Else
                LoadType()
                CmbType.Text = ""
                CmbMerk.Text = ""
                CmbModel.Text = ""
                LblUkuran.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rdr.Close()
        CloseConnection()
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Insert()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
    Private Sub TxtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBarcode.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        Aktif()
        If TxtBarcode.Text = "" Then
            LoadType()
            CmbType.Text = ""
            CmbMerk.Text = ""
            CmbModel.Text = ""
            LblUkuran.Text = ""
        Else
            LoadAset()
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        Aktif()
        LoadLokasi()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtBarcode.Text <> "" Or TxtKode.Text <> "" Then
            OpenConnection()
            sql = "select * from Repair where kd_rp='" & KDRP & "'"
            Debug.Print(sql)
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()

            If rdr.HasRows Then
                Edit()
                KDRP = ""

            ElseIf TxtBarcode.Text <> "" Or TxtKode.Text = "" Then
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Clear()
                Tampil()
                TxtBarcode.Focus()
                FrmPopUpMT.MdiParent = Menu_Utama
                FrmPopUpMT.Show()
            ElseIf TxtBarcode.Text = "" Or TxtKode.Text <> "" Then
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Clear()
                Tampil()
                TxtBarcode.Focus()
                FrmPopUpMT.MdiParent = Menu_Utama
                FrmPopUpMT.Show()
            Else
                MessageBox.Show("Data tidak terdaftar, silahkan input terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Clear()
                Tampil()
                TxtBarcode.Focus()
                Exit Sub
            End If
            rdr.Close()
            CloseConnection()
        Else
            FrmPopUpRepair.MdiParent = Menu_Utama
            FrmPopUpRepair.Show()
        End If
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Clear()
        KDRP = ""
        Tampil()
        TxtBarcode.Focus()
        BtnProses.Enabled = True
        BtnReset.Visible = False
    End Sub
End Class