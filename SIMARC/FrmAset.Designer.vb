<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAset))
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SIMARCData_Set = New SIMARC.SIMARCData_Set()
        Me.AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.AsetTableAdapter()
        Me.TableAdapterManager = New SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager()
        Me.DgAset = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Type_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.Merk_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Merk_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter()
        Me.CmbMerk = New System.Windows.Forms.ComboBox()
        Me.Model_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Model_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Model_AsetTableAdapter()
        Me.CmbModel = New System.Windows.Forms.ComboBox()
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Model_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackgroundImage = Global.SIMARC.My.Resources.Resources.door_out
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(330, 172)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 49)
        Me.BtnKeluar.TabIndex = 104
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Liter"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(113, 144)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(16, 18)
        Me.LblUkuran.TabIndex = 99
        Me.LblUkuran.Text = "0"
        Me.LblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Ukuran :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Model :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Merk :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Tipe :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtBarcode
        '
        Me.TxtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(113, 9)
        Me.TxtBarcode.Multiline = True
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(288, 24)
        Me.TxtBarcode.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Barcode :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBatal
        '
        Me.BtnBatal.BackgroundImage = Global.SIMARC.My.Resources.Resources.Cancel_16x16
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(253, 172)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(71, 49)
        Me.BtnBatal.TabIndex = 103
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.BackgroundImage = Global.SIMARC.My.Resources.Resources.Delete_16x16
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(176, 172)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(71, 49)
        Me.BtnHapus.TabIndex = 102
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = Global.SIMARC.My.Resources.Resources.Edit_16x16
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(99, 172)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(71, 49)
        Me.BtnEdit.TabIndex = 101
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackgroundImage = Global.SIMARC.My.Resources.Resources.Save_16x16
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(22, 172)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(71, 49)
        Me.BtnSimpan.TabIndex = 100
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'SIMARCData_Set
        '
        Me.SIMARCData_Set.DataSetName = "SIMARCData_Set"
        Me.SIMARCData_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsetBindingSource
        '
        Me.AsetBindingSource.DataMember = "Aset"
        Me.AsetBindingSource.DataSource = Me.SIMARCData_Set
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
        'DgAset
        '
        Me.DgAset.AllowUserToAddRows = False
        Me.DgAset.AllowUserToDeleteRows = False
        Me.DgAset.AllowUserToOrderColumns = True
        Me.DgAset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgAset.AutoGenerateColumns = False
        Me.DgAset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9})
        Me.DgAset.DataSource = Me.AsetBindingSource
        Me.DgAset.Location = New System.Drawing.Point(12, 227)
        Me.DgAset.Name = "DgAset"
        Me.DgAset.ReadOnly = True
        Me.DgAset.Size = New System.Drawing.Size(397, 329)
        Me.DgAset.TabIndex = 105
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kd_aset"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kd_model"
        Me.DataGridViewTextBoxColumn2.HeaderText = "kd_model"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nm_model"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "kd_merk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "kd_merk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nm_merk"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Merk"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kd_type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "kd_type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nm_type"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "kd_karyawan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "kd_karyawan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nm_karyawan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Created By"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Type_AsetBindingSource
        '
        Me.Type_AsetBindingSource.DataMember = "Type_Aset"
        Me.Type_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Type_AsetTableAdapter
        '
        Me.Type_AsetTableAdapter.ClearBeforeFill = True
        '
        'CmbType
        '
        Me.CmbType.DataSource = Me.Type_AsetBindingSource
        Me.CmbType.DisplayMember = "nm_type"
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Location = New System.Drawing.Point(113, 40)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(288, 26)
        Me.CmbType.TabIndex = 106
        Me.CmbType.ValueMember = "kd_type"
        '
        'Merk_AsetBindingSource
        '
        Me.Merk_AsetBindingSource.DataMember = "Merk_Aset"
        Me.Merk_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Merk_AsetTableAdapter
        '
        Me.Merk_AsetTableAdapter.ClearBeforeFill = True
        '
        'CmbMerk
        '
        Me.CmbMerk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AsetBindingSource, "kd_merk", True))
        Me.CmbMerk.DataSource = Me.Merk_AsetBindingSource
        Me.CmbMerk.DisplayMember = "nm_merk"
        Me.CmbMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMerk.FormattingEnabled = True
        Me.CmbMerk.Location = New System.Drawing.Point(113, 75)
        Me.CmbMerk.Name = "CmbMerk"
        Me.CmbMerk.Size = New System.Drawing.Size(288, 26)
        Me.CmbMerk.TabIndex = 107
        Me.CmbMerk.ValueMember = "kd_merk"
        '
        'Model_AsetBindingSource
        '
        Me.Model_AsetBindingSource.DataMember = "Model_Aset"
        Me.Model_AsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'Model_AsetTableAdapter
        '
        Me.Model_AsetTableAdapter.ClearBeforeFill = True
        '
        'CmbModel
        '
        Me.CmbModel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AsetBindingSource, "kd_model", True))
        Me.CmbModel.DataSource = Me.Model_AsetBindingSource
        Me.CmbModel.DisplayMember = "nm_model"
        Me.CmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModel.FormattingEnabled = True
        Me.CmbModel.Location = New System.Drawing.Point(113, 109)
        Me.CmbModel.Name = "CmbModel"
        Me.CmbModel.Size = New System.Drawing.Size(288, 26)
        Me.CmbModel.TabIndex = 108
        Me.CmbModel.ValueMember = "kd_model"
        '
        'FrmAset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 568)
        Me.Controls.Add(Me.CmbModel)
        Me.Controls.Add(Me.CmbMerk)
        Me.Controls.Add(Me.CmbType)
        Me.Controls.Add(Me.DgAset)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBarcode)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aset"
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Model_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUkuran As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SIMARCData_Set As SIMARC.SIMARCData_Set
    Friend WithEvents AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.AsetTableAdapter
    Friend WithEvents TableAdapterManager As SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager
    Friend WithEvents DgAset As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Merk_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Merk_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter
    Friend WithEvents CmbMerk As System.Windows.Forms.ComboBox
    Friend WithEvents Model_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Model_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Model_AsetTableAdapter
    Friend WithEvents CmbModel As System.Windows.Forms.ComboBox

End Class
