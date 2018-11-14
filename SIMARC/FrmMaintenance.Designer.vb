<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Kd_asetLabel As System.Windows.Forms.Label
        Dim Nm_typeLabel As System.Windows.Forms.Label
        Dim Nm_merkLabel As System.Windows.Forms.Label
        Dim Nm_modelLabel As System.Windows.Forms.Label
        Dim Kd_lokasiLabel As System.Windows.Forms.Label
        Dim Nm_lokasiLabel As System.Windows.Forms.Label
        Dim Almt_lokasiLabel As System.Windows.Forms.Label
        Dim Tlp_lokasiLabel As System.Windows.Forms.Label
        Me.DtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.DtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Group_Aset = New System.Windows.Forms.GroupBox()
        Me.TxtBacode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbModel = New System.Windows.Forms.ComboBox()
        Me.AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIMARCData_Set = New SIMARC.SIMARCData_Set()
        Me.Model_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMerk = New System.Windows.Forms.ComboBox()
        Me.Merk_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.Type_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group_Outlet = New System.Windows.Forms.GroupBox()
        Me.Tlp_lokasiTextBox = New System.Windows.Forms.TextBox()
        Me.LokasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Almt_lokasiTextBox = New System.Windows.Forms.TextBox()
        Me.Nm_lokasiTextBox = New System.Windows.Forms.TextBox()
        Me.Kd_lokasiTextBox = New System.Windows.Forms.TextBox()
        Me.Type_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter()
        Me.Merk_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter()
        Me.Model_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Model_AsetTableAdapter()
        Me.LokasiTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.LokasiTableAdapter()
        Me.Maintenance_ActionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Maintenance_ActionTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Maintenance_ActionTableAdapter()
        Me.Maintenance_ActionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnCeklist = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.AsetTableAdapter()
        Me.TableAdapterManager = New SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager()
        Kd_asetLabel = New System.Windows.Forms.Label()
        Nm_typeLabel = New System.Windows.Forms.Label()
        Nm_merkLabel = New System.Windows.Forms.Label()
        Nm_modelLabel = New System.Windows.Forms.Label()
        Kd_lokasiLabel = New System.Windows.Forms.Label()
        Nm_lokasiLabel = New System.Windows.Forms.Label()
        Almt_lokasiLabel = New System.Windows.Forms.Label()
        Tlp_lokasiLabel = New System.Windows.Forms.Label()
        Me.Group_Aset.SuspendLayout()
        CType(Me.AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Model_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Outlet.SuspendLayout()
        CType(Me.LokasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maintenance_ActionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maintenance_ActionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kd_asetLabel
        '
        Kd_asetLabel.AutoSize = True
        Kd_asetLabel.Location = New System.Drawing.Point(8, 22)
        Kd_asetLabel.Name = "Kd_asetLabel"
        Kd_asetLabel.Size = New System.Drawing.Size(72, 18)
        Kd_asetLabel.TabIndex = 0
        Kd_asetLabel.Text = "Barcode :"
        '
        'Nm_typeLabel
        '
        Nm_typeLabel.AutoSize = True
        Nm_typeLabel.Location = New System.Drawing.Point(36, 52)
        Nm_typeLabel.Name = "Nm_typeLabel"
        Nm_typeLabel.Size = New System.Drawing.Size(44, 18)
        Nm_typeLabel.TabIndex = 2
        Nm_typeLabel.Text = "Tipe :"
        '
        'Nm_merkLabel
        '
        Nm_merkLabel.AutoSize = True
        Nm_merkLabel.Location = New System.Drawing.Point(30, 85)
        Nm_merkLabel.Name = "Nm_merkLabel"
        Nm_merkLabel.Size = New System.Drawing.Size(50, 18)
        Nm_merkLabel.TabIndex = 4
        Nm_merkLabel.Text = "Merk :"
        '
        'Nm_modelLabel
        '
        Nm_modelLabel.AutoSize = True
        Nm_modelLabel.Location = New System.Drawing.Point(23, 116)
        Nm_modelLabel.Name = "Nm_modelLabel"
        Nm_modelLabel.Size = New System.Drawing.Size(57, 18)
        Nm_modelLabel.TabIndex = 6
        Nm_modelLabel.Text = "Model :"
        '
        'Kd_lokasiLabel
        '
        Kd_lokasiLabel.AutoSize = True
        Kd_lokasiLabel.Location = New System.Drawing.Point(17, 22)
        Kd_lokasiLabel.Name = "Kd_lokasiLabel"
        Kd_lokasiLabel.Size = New System.Drawing.Size(94, 18)
        Kd_lokasiLabel.TabIndex = 0
        Kd_lokasiLabel.Text = "Kode Outlet :"
        '
        'Nm_lokasiLabel
        '
        Nm_lokasiLabel.AutoSize = True
        Nm_lokasiLabel.Location = New System.Drawing.Point(12, 52)
        Nm_lokasiLabel.Name = "Nm_lokasiLabel"
        Nm_lokasiLabel.Size = New System.Drawing.Size(99, 18)
        Nm_lokasiLabel.TabIndex = 2
        Nm_lokasiLabel.Text = "Nama Outlet :"
        '
        'Almt_lokasiLabel
        '
        Almt_lokasiLabel.AutoSize = True
        Almt_lokasiLabel.Location = New System.Drawing.Point(50, 82)
        Almt_lokasiLabel.Name = "Almt_lokasiLabel"
        Almt_lokasiLabel.Size = New System.Drawing.Size(61, 18)
        Almt_lokasiLabel.TabIndex = 4
        Almt_lokasiLabel.Text = "Alamat :"
        '
        'Tlp_lokasiLabel
        '
        Tlp_lokasiLabel.AutoSize = True
        Tlp_lokasiLabel.Location = New System.Drawing.Point(34, 143)
        Tlp_lokasiLabel.Name = "Tlp_lokasiLabel"
        Tlp_lokasiLabel.Size = New System.Drawing.Size(77, 18)
        Tlp_lokasiLabel.TabIndex = 6
        Tlp_lokasiLabel.Text = "Telp / HP :"
        '
        'DtpSelesai
        '
        Me.DtpSelesai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpSelesai.CustomFormat = "dd MMMM yyyy"
        Me.DtpSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpSelesai.Location = New System.Drawing.Point(673, 15)
        Me.DtpSelesai.Name = "DtpSelesai"
        Me.DtpSelesai.Size = New System.Drawing.Size(216, 24)
        Me.DtpSelesai.TabIndex = 103
        '
        'DtpMulai
        '
        Me.DtpMulai.CustomFormat = "dd MMMM yyyy"
        Me.DtpMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpMulai.Location = New System.Drawing.Point(128, 15)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(216, 24)
        Me.DtpMulai.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(547, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 18)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Tanggal Selesai :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 18)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Tanggal Mulai :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Group_Aset
        '
        Me.Group_Aset.Controls.Add(Me.TxtBacode)
        Me.Group_Aset.Controls.Add(Me.Label7)
        Me.Group_Aset.Controls.Add(Me.LblUkuran)
        Me.Group_Aset.Controls.Add(Me.Label5)
        Me.Group_Aset.Controls.Add(Nm_modelLabel)
        Me.Group_Aset.Controls.Add(Me.CmbModel)
        Me.Group_Aset.Controls.Add(Nm_merkLabel)
        Me.Group_Aset.Controls.Add(Me.CmbMerk)
        Me.Group_Aset.Controls.Add(Nm_typeLabel)
        Me.Group_Aset.Controls.Add(Me.CmbType)
        Me.Group_Aset.Controls.Add(Kd_asetLabel)
        Me.Group_Aset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Aset.Location = New System.Drawing.Point(11, 61)
        Me.Group_Aset.Name = "Group_Aset"
        Me.Group_Aset.Size = New System.Drawing.Size(381, 184)
        Me.Group_Aset.TabIndex = 105
        Me.Group_Aset.TabStop = False
        Me.Group_Aset.Text = "Aset"
        '
        'TxtBacode
        '
        Me.TxtBacode.Location = New System.Drawing.Point(86, 19)
        Me.TxtBacode.Name = "TxtBacode"
        Me.TxtBacode.Size = New System.Drawing.Size(268, 24)
        Me.TxtBacode.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(148, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Liter"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(90, 146)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(16, 18)
        Me.LblUkuran.TabIndex = 102
        Me.LblUkuran.Text = "0"
        Me.LblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Ukuran :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbModel
        '
        Me.CmbModel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AsetBindingSource, "kd_model", True))
        Me.CmbModel.DataSource = Me.Model_AsetBindingSource
        Me.CmbModel.DisplayMember = "nm_model"
        Me.CmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbModel.FormattingEnabled = True
        Me.CmbModel.Location = New System.Drawing.Point(86, 113)
        Me.CmbModel.Name = "CmbModel"
        Me.CmbModel.Size = New System.Drawing.Size(268, 26)
        Me.CmbModel.TabIndex = 7
        Me.CmbModel.ValueMember = "kd_model"
        '
        'AsetBindingSource
        '
        Me.AsetBindingSource.DataMember = "Aset"
        Me.AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'SIMARCData_Set
        '
        Me.SIMARCData_Set.DataSetName = "SIMARCData_Set"
        Me.SIMARCData_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Model_AsetBindingSource
        '
        Me.Model_AsetBindingSource.DataMember = "Model_Aset"
        Me.Model_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'CmbMerk
        '
        Me.CmbMerk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AsetBindingSource, "kd_merk", True))
        Me.CmbMerk.DataSource = Me.Merk_AsetBindingSource
        Me.CmbMerk.DisplayMember = "nm_merk"
        Me.CmbMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMerk.FormattingEnabled = True
        Me.CmbMerk.Location = New System.Drawing.Point(86, 81)
        Me.CmbMerk.Name = "CmbMerk"
        Me.CmbMerk.Size = New System.Drawing.Size(268, 26)
        Me.CmbMerk.TabIndex = 5
        Me.CmbMerk.ValueMember = "kd_merk"
        '
        'Merk_AsetBindingSource
        '
        Me.Merk_AsetBindingSource.DataMember = "Merk_Aset"
        Me.Merk_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'CmbType
        '
        Me.CmbType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AsetBindingSource, "kd_type", True))
        Me.CmbType.DataSource = Me.Type_AsetBindingSource
        Me.CmbType.DisplayMember = "nm_type"
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Location = New System.Drawing.Point(86, 49)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(268, 26)
        Me.CmbType.TabIndex = 3
        Me.CmbType.ValueMember = "kd_type"
        '
        'Type_AsetBindingSource
        '
        Me.Type_AsetBindingSource.DataMember = "Type_Aset"
        Me.Type_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Group_Outlet
        '
        Me.Group_Outlet.Controls.Add(Tlp_lokasiLabel)
        Me.Group_Outlet.Controls.Add(Me.Tlp_lokasiTextBox)
        Me.Group_Outlet.Controls.Add(Almt_lokasiLabel)
        Me.Group_Outlet.Controls.Add(Me.Almt_lokasiTextBox)
        Me.Group_Outlet.Controls.Add(Nm_lokasiLabel)
        Me.Group_Outlet.Controls.Add(Me.Nm_lokasiTextBox)
        Me.Group_Outlet.Controls.Add(Kd_lokasiLabel)
        Me.Group_Outlet.Controls.Add(Me.Kd_lokasiTextBox)
        Me.Group_Outlet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Outlet.Location = New System.Drawing.Point(398, 61)
        Me.Group_Outlet.Name = "Group_Outlet"
        Me.Group_Outlet.Size = New System.Drawing.Size(491, 175)
        Me.Group_Outlet.TabIndex = 106
        Me.Group_Outlet.TabStop = False
        Me.Group_Outlet.Text = "Outlet"
        '
        'Tlp_lokasiTextBox
        '
        Me.Tlp_lokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LokasiBindingSource, "tlp_lokasi", True))
        Me.Tlp_lokasiTextBox.Location = New System.Drawing.Point(117, 140)
        Me.Tlp_lokasiTextBox.Name = "Tlp_lokasiTextBox"
        Me.Tlp_lokasiTextBox.Size = New System.Drawing.Size(232, 24)
        Me.Tlp_lokasiTextBox.TabIndex = 7
        '
        'LokasiBindingSource
        '
        Me.LokasiBindingSource.DataMember = "Lokasi"
        Me.LokasiBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Almt_lokasiTextBox
        '
        Me.Almt_lokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LokasiBindingSource, "almt_lokasi", True))
        Me.Almt_lokasiTextBox.Location = New System.Drawing.Point(117, 79)
        Me.Almt_lokasiTextBox.Multiline = True
        Me.Almt_lokasiTextBox.Name = "Almt_lokasiTextBox"
        Me.Almt_lokasiTextBox.Size = New System.Drawing.Size(354, 55)
        Me.Almt_lokasiTextBox.TabIndex = 5
        '
        'Nm_lokasiTextBox
        '
        Me.Nm_lokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LokasiBindingSource, "nm_lokasi", True))
        Me.Nm_lokasiTextBox.Location = New System.Drawing.Point(117, 49)
        Me.Nm_lokasiTextBox.Name = "Nm_lokasiTextBox"
        Me.Nm_lokasiTextBox.Size = New System.Drawing.Size(232, 24)
        Me.Nm_lokasiTextBox.TabIndex = 3
        '
        'Kd_lokasiTextBox
        '
        Me.Kd_lokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LokasiBindingSource, "kd_lokasi", True))
        Me.Kd_lokasiTextBox.Location = New System.Drawing.Point(117, 19)
        Me.Kd_lokasiTextBox.Name = "Kd_lokasiTextBox"
        Me.Kd_lokasiTextBox.Size = New System.Drawing.Size(232, 24)
        Me.Kd_lokasiTextBox.TabIndex = 1
        '
        'Type_AsetTableAdapter
        '
        Me.Type_AsetTableAdapter.ClearBeforeFill = True
        '
        'Merk_AsetTableAdapter
        '
        Me.Merk_AsetTableAdapter.ClearBeforeFill = True
        '
        'Model_AsetTableAdapter
        '
        Me.Model_AsetTableAdapter.ClearBeforeFill = True
        '
        'LokasiTableAdapter
        '
        Me.LokasiTableAdapter.ClearBeforeFill = True
        '
        'Maintenance_ActionBindingSource
        '
        Me.Maintenance_ActionBindingSource.DataMember = "Maintenance_Action"
        Me.Maintenance_ActionBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Maintenance_ActionTableAdapter
        '
        Me.Maintenance_ActionTableAdapter.ClearBeforeFill = True
        '
        'Maintenance_ActionDataGridView
        '
        Me.Maintenance_ActionDataGridView.AllowUserToAddRows = False
        Me.Maintenance_ActionDataGridView.AllowUserToDeleteRows = False
        Me.Maintenance_ActionDataGridView.AllowUserToOrderColumns = True
        Me.Maintenance_ActionDataGridView.AutoGenerateColumns = False
        Me.Maintenance_ActionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Maintenance_ActionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.Maintenance_ActionDataGridView.DataSource = Me.Maintenance_ActionBindingSource
        Me.Maintenance_ActionDataGridView.Location = New System.Drawing.Point(11, 242)
        Me.Maintenance_ActionDataGridView.Name = "Maintenance_ActionDataGridView"
        Me.Maintenance_ActionDataGridView.ReadOnly = True
        Me.Maintenance_ActionDataGridView.Size = New System.Drawing.Size(878, 261)
        Me.Maintenance_ActionDataGridView.TabIndex = 106
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kd_kasus"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nm_kasus"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Point Pemeriksaan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Baik"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Kondisi Baik"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Rusak"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Kondisi Rusak"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Ganti"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Ganti / Perbaikan"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Rusak_total"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Rusak"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kd_mt"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kd_mt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "posisi_kasus"
        Me.DataGridViewTextBoxColumn4.HeaderText = "posisi_kasus"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackgroundImage = Global.SIMARC.My.Resources.Resources.Cancel_16x16
        Me.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(508, 509)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(71, 47)
        Me.BtnReset.TabIndex = 111
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackgroundImage = Global.SIMARC.My.Resources.Resources.Edit_16x16
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(584, 509)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(71, 47)
        Me.BtnEdit.TabIndex = 110
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnCeklist
        '
        Me.BtnCeklist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCeklist.BackgroundImage = Global.SIMARC.My.Resources.Resources.Check_16x16
        Me.BtnCeklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCeklist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCeklist.Location = New System.Drawing.Point(661, 509)
        Me.BtnCeklist.Name = "BtnCeklist"
        Me.BtnCeklist.Size = New System.Drawing.Size(71, 47)
        Me.BtnCeklist.TabIndex = 107
        Me.BtnCeklist.Text = "Ceklist"
        Me.BtnCeklist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCeklist.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKeluar.BackgroundImage = Global.SIMARC.My.Resources.Resources.door_out
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(815, 509)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 49)
        Me.BtnKeluar.TabIndex = 109
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnProses
        '
        Me.BtnProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProses.BackgroundImage = Global.SIMARC.My.Resources.Resources.Save_16x16
        Me.BtnProses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProses.Location = New System.Drawing.Point(738, 509)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(71, 49)
        Me.BtnProses.TabIndex = 108
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'AsetTableAdapter
        '
        Me.AsetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.KasusTableAdapter = Nothing
        Me.TableAdapterManager.MaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.SparepartTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 570)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnCeklist)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.Maintenance_ActionDataGridView)
        Me.Controls.Add(Me.Group_Outlet)
        Me.Controls.Add(Me.Group_Aset)
        Me.Controls.Add(Me.DtpSelesai)
        Me.Controls.Add(Me.DtpMulai)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FrmMaintenance"
        Me.Text = "Maintenance"
        Me.Group_Aset.ResumeLayout(False)
        Me.Group_Aset.PerformLayout()
        CType(Me.AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Model_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Outlet.ResumeLayout(False)
        Me.Group_Outlet.PerformLayout()
        CType(Me.LokasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maintenance_ActionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maintenance_ActionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtpSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Group_Aset As System.Windows.Forms.GroupBox
    Friend WithEvents Group_Outlet As System.Windows.Forms.GroupBox
    Friend WithEvents SIMARCData_Set As SIMARC.SIMARCData_Set
    Friend WithEvents Type_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Merk_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Merk_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter
    Friend WithEvents CmbMerk As System.Windows.Forms.ComboBox
    Friend WithEvents Model_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Model_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Model_AsetTableAdapter
    Friend WithEvents CmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents LokasiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LokasiTableAdapter As SIMARC.SIMARCData_SetTableAdapters.LokasiTableAdapter
    Friend WithEvents Kd_lokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nm_lokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Almt_lokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tlp_lokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUkuran As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Maintenance_ActionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Maintenance_ActionTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Maintenance_ActionTableAdapter
    Friend WithEvents Maintenance_ActionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnCeklist As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.AsetTableAdapter
    Friend WithEvents TxtBacode As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager
End Class
