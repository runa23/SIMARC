<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMerk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMerk))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SIMARCData_Set = New SIMARC.SIMARCData_Set()
        Me.Merk_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Merk_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter()
        Me.TableAdapterManager = New SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager()
        Me.DgMerk = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_AsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Type_AsetTableAdapter = New SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.TypeAsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtMerk = New System.Windows.Forms.TextBox()
        Me.TypeAsetMerkAsetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeAsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeAsetMerkAsetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Tipe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Merk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackgroundImage = Global.SIMARC.My.Resources.Resources.Save_16x16
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(30, 71)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(71, 49)
        Me.BtnSimpan.TabIndex = 62
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = Global.SIMARC.My.Resources.Resources.Edit_16x16
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.Location = New System.Drawing.Point(107, 71)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(71, 49)
        Me.BtnEdit.TabIndex = 63
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.BackgroundImage = Global.SIMARC.My.Resources.Resources.Delete_16x16
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.Location = New System.Drawing.Point(184, 71)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(71, 49)
        Me.BtnHapus.TabIndex = 64
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.BackgroundImage = Global.SIMARC.My.Resources.Resources.Cancel_16x16
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.Location = New System.Drawing.Point(261, 71)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(71, 49)
        Me.BtnBatal.TabIndex = 65
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackgroundImage = Global.SIMARC.My.Resources.Resources.door_out
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.Location = New System.Drawing.Point(338, 71)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 49)
        Me.BtnKeluar.TabIndex = 66
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'SIMARCData_Set
        '
        Me.SIMARCData_Set.DataSetName = "SIMARCData_Set"
        Me.SIMARCData_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DgMerk
        '
        Me.DgMerk.AllowUserToAddRows = False
        Me.DgMerk.AllowUserToDeleteRows = False
        Me.DgMerk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgMerk.AutoGenerateColumns = False
        Me.DgMerk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMerk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4})
        Me.DgMerk.DataSource = Me.Merk_AsetBindingSource
        Me.DgMerk.Location = New System.Drawing.Point(16, 126)
        Me.DgMerk.Name = "DgMerk"
        Me.DgMerk.ReadOnly = True
        Me.DgMerk.Size = New System.Drawing.Size(405, 396)
        Me.DgMerk.TabIndex = 69
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kd_merk"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Merk"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nm_merk"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Merk"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kd_type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nm_type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nm_karyawan"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Created By"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "kd_karyawan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "kd_karyawan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
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
        Me.CmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merk_AsetBindingSource, "kd_type", True))
        Me.CmbType.DataSource = Me.TypeAsetBindingSource
        Me.CmbType.DisplayMember = "nm_type"
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Location = New System.Drawing.Point(93, 9)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(258, 26)
        Me.CmbType.TabIndex = 70
        Me.CmbType.ValueMember = "kd_type"
        '
        'TypeAsetBindingSource
        '
        Me.TypeAsetBindingSource.DataMember = "Type_Aset"
        Me.TypeAsetBindingSource.DataSource = Me.SIMARCData_Set
        '
        'TxtMerk
        '
        Me.TxtMerk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMerk.Location = New System.Drawing.Point(92, 41)
        Me.TxtMerk.Name = "TxtMerk"
        Me.TxtMerk.Size = New System.Drawing.Size(259, 24)
        Me.TxtMerk.TabIndex = 71
        '
        'TypeAsetMerkAsetBindingSource
        '
        Me.TypeAsetMerkAsetBindingSource.DataMember = "Type_Aset_Merk_Aset"
        Me.TypeAsetMerkAsetBindingSource.DataSource = Me.Type_AsetBindingSource
        '
        'FrmMerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 534)
        Me.Controls.Add(Me.TxtMerk)
        Me.Controls.Add(Me.CmbType)
        Me.Controls.Add(Me.DgMerk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMerk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merk Aset"
        CType(Me.SIMARCData_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Merk_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_AsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeAsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeAsetMerkAsetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents SIMARCData_Set As SIMARC.SIMARCData_Set
    Friend WithEvents Merk_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Merk_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Merk_AsetTableAdapter
    Friend WithEvents TableAdapterManager As SIMARC.SIMARCData_SetTableAdapters.TableAdapterManager
    Friend WithEvents DgMerk As System.Windows.Forms.DataGridView
    Friend WithEvents Type_AsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_AsetTableAdapter As SIMARC.SIMARCData_SetTableAdapters.Type_AsetTableAdapter
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMerk As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeAsetMerkAsetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeAsetBindingSource As System.Windows.Forms.BindingSource
End Class
