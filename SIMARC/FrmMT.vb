Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports SIMARC.Modul

Public Class FrmMT
    Public KDMT As String
    Dim type() As String
    Dim merk() As String
    Dim model() As String

    Dim MT As String
    Private Sub FrmMT_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tampil()
        DtpMulai.Value = Now
        DtpSelesai.Value = Now
        Aktif()
        BtnReset.Visible = False
    End Sub
    Sub Tampil()
        Try
            OpenConnection()
            sql = "select kd_kasus, nm_kasus from kasus"
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            dt = New DataTable
            da.Fill(ds, "kd_kasus")
            DgChecklist.DataSource = ds.Tables("kd_kasus")
            DgChecklist.Columns(0).HeaderText = "No"
            DgChecklist.Columns(0).Name = "no"
            DgChecklist.Columns(1).HeaderText = "Point Pemeriksaan"
            DgChecklist.Columns(1).Name = "point"
            Kolom()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Sub Kolom()
        Dim KB, KR, TG, TR As New DataGridViewCheckBoxColumn

        With KB
            .HeaderText = "Kondisi Baik"
            .Name = "KB"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        With KR
            .HeaderText = "Kondisi Rusak"
            .Name = "KR"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        With TG
            .HeaderText = "Ganti/Perbaikan"
            .Name = "TG"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        With TR
            .HeaderText = "Rusak"
            .Name = "TR"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        DgChecklist.Columns.Insert(2, KB)
        DgChecklist.Columns.Insert(3, KR)
        DgChecklist.Columns.Insert(4, TG)
        DgChecklist.Columns.Insert(5, TR)
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
        rdr.Close()
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
            type = Split(CmbType.Text, " - ")
            sql = "select * from Merk_Aset where kd_type = " & type(0) & ""
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

    Private Sub CmbType_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles CmbType.SelectedIndexChanged
        CmbMerk.Enabled = True
        LoadMerk()
    End Sub

    Private Sub CmbMerk_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles CmbMerk.SelectedIndexChanged
        CmbModel.Enabled = True
        LoadModel()
    End Sub

    Private Sub CmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModel.SelectedIndexChanged
        HitungLiter()
    End Sub
    Sub ValidateCK()
        For Each R As DataGridViewRow In DgChecklist.Rows
            If R.Cells("KB").Value = True Then
                R.Cells("KR").ReadOnly = True
                R.Cells("TG").ReadOnly = True
                R.Cells("TR").ReadOnly = True
                R.Cells("KR").Value = False
                R.Cells("TG").Value = False
                R.Cells("TR").Value = False

            ElseIf R.Cells("KB").Value = False Then
                R.Cells("KR").ReadOnly = False
                R.Cells("TG").ReadOnly = False
                R.Cells("TR").ReadOnly = False
            End If
        Next
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
        DgChecklist.Columns.Clear()
    End Sub
    Sub Insert()
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
                    If Not rdr.HasRows Then
                        type = Split(CmbType.Text, " - ")
                        merk = Split(CmbMerk.Text, " - ")
                        model = Split(CmbModel.Text, " - ")
                        sql = "SpInsertAset '" & TxtBarcode.Text & "'," & model(0) & _
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
                    If Not rdr.HasRows Then
                        sql = "SpInsertLokasi '" & TxtKode.Text & "','" & TxtNama.Text & _
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
                    sql = "SpInsertMT '" & Format(DtpMulai.Value, "yyyy-MM-dd") & "','" & Format(DtpSelesai.Value, "yyyy-MM-dd") & _
                      "','" & TxtBarcode.Text & "','" & TxtKode.Text & "','" & Menu_Utama.Kd_Karyawan.Text & "'"
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    Debug.Print(sql)
                    Dim tgl, mon, thn, urut As String

                    tgl = DtpMulai.Value.ToString("dd")
                    mon = DtpMulai.Value.ToString("MM")
                    thn = DtpMulai.Value.ToString("yy")
                    urut = thn & mon & tgl

                    sql = "select * from Maintenance where kd_mt like '%" & urut & "%' order by kd_mt desc"
                    cmd = New SqlCommand(sql, con)
                    rdr = cmd.ExecuteReader
                    rdr.Read()
                    MT = rdr.Item(0)
                    rdr.Close()

                    For i As Integer = 0 To DgChecklist.RowCount - 1
                        Dim KB As Integer, KR As Integer, TG As Integer, TR As Integer

                        If DgChecklist.Rows(i).Cells("KB").Value = True Then
                            KB = 1
                        Else
                            KB = 0
                        End If

                        If DgChecklist.Rows(i).Cells("KR").Value = True Then
                            KR = 1
                        Else
                            KR = 0
                        End If

                        If DgChecklist.Rows(i).Cells("TG").Value = True Then
                            TG = 1
                        Else
                            TG = 0
                        End If

                        If DgChecklist.Rows(i).Cells("TR").Value = True Then
                            TR = 1
                        Else
                            TR = 0
                        End If

                        sql = "SpInsertMA '" & MT & "'," & Val(DgChecklist.Rows(i).Cells("no").Value) & _
                              "," & Val(KB) & "," & Val(KR) & "," & Val(TG) & "," & Val(TR) & ""
                        cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                        Debug.Print(sql)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MessageBox.Show("Data berhasil di Proses", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                Tampil()
                TxtBarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
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
                    sql = "select * from Maintenance where kd_mt='" & KDMT & "'"
                    cmd = New SqlCommand(sql, con)
                    rdr = cmd.ExecuteReader
                    rdr.Read()

                    If rdr.HasRows Then
                        sql = "SpUpdateMT '" & KDMT & "','" & Format(DtpMulai.Value, "yyyy-MM-dd") & "','" & Format(DtpSelesai.Value, "yyyy-MM-dd") & _
                              "','" & TxtBarcode.Text & "','" & TxtKode.Text & "','" & Menu_Utama.Kd_Karyawan.Text & "'"
                        cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        sql = "SpDeleteMA '" & KDMT & "'"
                        cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        For i As Integer = 0 To DgChecklist.RowCount - 1
                            Dim KB As Integer, KR As Integer, TG As Integer, TR As Integer

                            If DgChecklist.Rows(i).Cells("KB").Value = True Then
                                KB = 1
                            Else
                                KB = 0
                            End If

                            If DgChecklist.Rows(i).Cells("KR").Value = True Then
                                KR = 1
                            Else
                                KR = 0
                            End If

                            If DgChecklist.Rows(i).Cells("TG").Value = True Then
                                TG = 1
                            Else
                                TG = 0
                            End If

                            If DgChecklist.Rows(i).Cells("TR").Value = True Then
                                TR = 1
                            Else
                                TR = 0
                            End If

                            sql = "SpInsertMA '" & KDMT & "'," & Val(DgChecklist.Rows(i).Cells("no").Value) & _
                                  "," & Val(KB) & "," & Val(KR) & "," & Val(TG) & "," & Val(TR) & ""
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
                KDMT = ""
                Tampil()
                BtnCeklist.Enabled = True
                BtnProses.Enabled = True
                BtnReset.Visible = False
                TxtBarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseConnection()
    End Sub
    Private Sub DgChecklist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgChecklist.CellClick
        ValidateCK()
    End Sub
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Insert()
    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub

    Private Sub BtnCeklist_Click(sender As Object, e As EventArgs) Handles BtnCeklist.Click
        For Each R As DataGridViewRow In DgChecklist.Rows
            R.Cells("KB").Value = True
        Next
    End Sub

    Private Sub TxtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKode.KeyDown
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub
    Sub LoadAset()
        Try
            OpenConnection()
            If TxtBarcode.Text <> "" Then
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rdr.Close()
        CloseConnection()
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
            sql = "select * from Maintenance where kd_mt='" & KDMT & "'"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader
            rdr.Read()

            If rdr.HasRows Then
                Edit()
                KDMT = ""

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
            FrmPopUpMT.MdiParent = Menu_Utama
            FrmPopUpMT.Show()
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Clear()
        KDMT = ""
        Tampil()
        TxtBarcode.Focus()
        BtnProses.Enabled = True
        BtnCeklist.Enabled = True
        BtnReset.Visible = False
    End Sub
End Class