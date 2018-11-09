<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHakAkses))
        Me.CmbStats = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkPetugas = New System.Windows.Forms.CheckBox()
        Me.ChkOutlet = New System.Windows.Forms.CheckBox()
        Me.ChkType = New System.Windows.Forms.CheckBox()
        Me.ChkMerk = New System.Windows.Forms.CheckBox()
        Me.ChkMT = New System.Windows.Forms.CheckBox()
        Me.ChkLapAset = New System.Windows.Forms.CheckBox()
        Me.ChkRepair = New System.Windows.Forms.CheckBox()
        Me.ChkLapSpare = New System.Windows.Forms.CheckBox()
        Me.ChkModel = New System.Windows.Forms.CheckBox()
        Me.ChkSparepart = New System.Windows.Forms.CheckBox()
        Me.ChkAset = New System.Windows.Forms.CheckBox()
        Me.ChkLapChecklist = New System.Windows.Forms.CheckBox()
        Me.ChkLapMT = New System.Windows.Forms.CheckBox()
        Me.ChkLapKeuangan = New System.Windows.Forms.CheckBox()
        Me.ChkAkses = New System.Windows.Forms.CheckBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.ChkLapRepair = New System.Windows.Forms.CheckBox()
        Me.ChkLapRepair2 = New System.Windows.Forms.CheckBox()
        Me.ChkLapKeuanganLngkp = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CmbStats
        '
        Me.CmbStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStats.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbStats.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStats.FormattingEnabled = True
        Me.CmbStats.Items.AddRange(New Object() {"Admin", "CLO", "Keuangan", "OM", "Teknisi"})
        Me.CmbStats.Location = New System.Drawing.Point(105, 7)
        Me.CmbStats.Name = "CmbStats"
        Me.CmbStats.Size = New System.Drawing.Size(222, 28)
        Me.CmbStats.Sorted = True
        Me.CmbStats.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Jabatan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChkPetugas
        '
        Me.ChkPetugas.AutoSize = True
        Me.ChkPetugas.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkPetugas.Location = New System.Drawing.Point(45, 41)
        Me.ChkPetugas.Name = "ChkPetugas"
        Me.ChkPetugas.Size = New System.Drawing.Size(82, 24)
        Me.ChkPetugas.TabIndex = 37
        Me.ChkPetugas.Text = "Petugas"
        Me.ChkPetugas.UseVisualStyleBackColor = True
        '
        'ChkOutlet
        '
        Me.ChkOutlet.AutoSize = True
        Me.ChkOutlet.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkOutlet.Location = New System.Drawing.Point(45, 71)
        Me.ChkOutlet.Name = "ChkOutlet"
        Me.ChkOutlet.Size = New System.Drawing.Size(74, 24)
        Me.ChkOutlet.TabIndex = 37
        Me.ChkOutlet.Text = "Outlet"
        Me.ChkOutlet.UseVisualStyleBackColor = True
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkType.Location = New System.Drawing.Point(45, 101)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.Size = New System.Drawing.Size(99, 24)
        Me.ChkType.TabIndex = 37
        Me.ChkType.Text = "Type Aset"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'ChkMerk
        '
        Me.ChkMerk.AutoSize = True
        Me.ChkMerk.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkMerk.Location = New System.Drawing.Point(45, 131)
        Me.ChkMerk.Name = "ChkMerk"
        Me.ChkMerk.Size = New System.Drawing.Size(102, 24)
        Me.ChkMerk.TabIndex = 37
        Me.ChkMerk.Text = "Merk Aset"
        Me.ChkMerk.UseVisualStyleBackColor = True
        '
        'ChkMT
        '
        Me.ChkMT.AutoSize = True
        Me.ChkMT.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkMT.Location = New System.Drawing.Point(45, 251)
        Me.ChkMT.Name = "ChkMT"
        Me.ChkMT.Size = New System.Drawing.Size(116, 24)
        Me.ChkMT.TabIndex = 37
        Me.ChkMT.Text = "Maintenance"
        Me.ChkMT.UseVisualStyleBackColor = True
        '
        'ChkLapAset
        '
        Me.ChkLapAset.AutoSize = True
        Me.ChkLapAset.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapAset.Location = New System.Drawing.Point(181, 71)
        Me.ChkLapAset.Name = "ChkLapAset"
        Me.ChkLapAset.Size = New System.Drawing.Size(120, 24)
        Me.ChkLapAset.TabIndex = 37
        Me.ChkLapAset.Text = "Laporan Aset"
        Me.ChkLapAset.UseVisualStyleBackColor = True
        '
        'ChkRepair
        '
        Me.ChkRepair.AutoSize = True
        Me.ChkRepair.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkRepair.Location = New System.Drawing.Point(181, 41)
        Me.ChkRepair.Name = "ChkRepair"
        Me.ChkRepair.Size = New System.Drawing.Size(72, 24)
        Me.ChkRepair.TabIndex = 37
        Me.ChkRepair.Text = "Repair"
        Me.ChkRepair.UseVisualStyleBackColor = True
        '
        'ChkLapSpare
        '
        Me.ChkLapSpare.AutoSize = True
        Me.ChkLapSpare.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapSpare.Location = New System.Drawing.Point(181, 101)
        Me.ChkLapSpare.Name = "ChkLapSpare"
        Me.ChkLapSpare.Size = New System.Drawing.Size(162, 24)
        Me.ChkLapSpare.TabIndex = 37
        Me.ChkLapSpare.Text = "Laporan Spare Part"
        Me.ChkLapSpare.UseVisualStyleBackColor = True
        '
        'ChkModel
        '
        Me.ChkModel.AutoSize = True
        Me.ChkModel.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkModel.Location = New System.Drawing.Point(45, 161)
        Me.ChkModel.Name = "ChkModel"
        Me.ChkModel.Size = New System.Drawing.Size(107, 24)
        Me.ChkModel.TabIndex = 37
        Me.ChkModel.Text = "Model Aset"
        Me.ChkModel.UseVisualStyleBackColor = True
        '
        'ChkSparepart
        '
        Me.ChkSparepart.AutoSize = True
        Me.ChkSparepart.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkSparepart.Location = New System.Drawing.Point(45, 221)
        Me.ChkSparepart.Name = "ChkSparepart"
        Me.ChkSparepart.Size = New System.Drawing.Size(103, 24)
        Me.ChkSparepart.TabIndex = 37
        Me.ChkSparepart.Text = "Spare Part"
        Me.ChkSparepart.UseVisualStyleBackColor = True
        '
        'ChkAset
        '
        Me.ChkAset.AutoSize = True
        Me.ChkAset.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkAset.Location = New System.Drawing.Point(45, 191)
        Me.ChkAset.Name = "ChkAset"
        Me.ChkAset.Size = New System.Drawing.Size(61, 24)
        Me.ChkAset.TabIndex = 37
        Me.ChkAset.Text = "Aset"
        Me.ChkAset.UseVisualStyleBackColor = True
        '
        'ChkLapChecklist
        '
        Me.ChkLapChecklist.AutoSize = True
        Me.ChkLapChecklist.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapChecklist.Location = New System.Drawing.Point(181, 161)
        Me.ChkLapChecklist.Name = "ChkLapChecklist"
        Me.ChkLapChecklist.Size = New System.Drawing.Size(151, 24)
        Me.ChkLapChecklist.TabIndex = 37
        Me.ChkLapChecklist.Text = "Laporan Checklist"
        Me.ChkLapChecklist.UseVisualStyleBackColor = True
        '
        'ChkLapMT
        '
        Me.ChkLapMT.AutoSize = True
        Me.ChkLapMT.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapMT.Location = New System.Drawing.Point(181, 131)
        Me.ChkLapMT.Name = "ChkLapMT"
        Me.ChkLapMT.Size = New System.Drawing.Size(175, 24)
        Me.ChkLapMT.TabIndex = 37
        Me.ChkLapMT.Text = "Laporan Maintenance"
        Me.ChkLapMT.UseVisualStyleBackColor = True
        '
        'ChkLapKeuangan
        '
        Me.ChkLapKeuangan.AutoSize = True
        Me.ChkLapKeuangan.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapKeuangan.Location = New System.Drawing.Point(180, 251)
        Me.ChkLapKeuangan.Name = "ChkLapKeuangan"
        Me.ChkLapKeuangan.Size = New System.Drawing.Size(152, 24)
        Me.ChkLapKeuangan.TabIndex = 37
        Me.ChkLapKeuangan.Text = "Laporan Keuangan"
        Me.ChkLapKeuangan.UseVisualStyleBackColor = True
        '
        'ChkAkses
        '
        Me.ChkAkses.AutoSize = True
        Me.ChkAkses.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkAkses.Location = New System.Drawing.Point(45, 281)
        Me.ChkAkses.Name = "ChkAkses"
        Me.ChkAkses.Size = New System.Drawing.Size(103, 24)
        Me.ChkAkses.TabIndex = 37
        Me.ChkAkses.Text = "Hak Akses"
        Me.ChkAkses.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackgroundImage = Global.SIMARC.My.Resources.Resources.door_out
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(295, 321)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 49)
        Me.BtnKeluar.TabIndex = 39
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackgroundImage = Global.SIMARC.My.Resources.Resources.Save_16x16
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSimpan.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(218, 321)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(71, 49)
        Me.BtnSimpan.TabIndex = 38
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'ChkLapRepair
        '
        Me.ChkLapRepair.AutoSize = True
        Me.ChkLapRepair.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapRepair.Location = New System.Drawing.Point(181, 191)
        Me.ChkLapRepair.Name = "ChkLapRepair"
        Me.ChkLapRepair.Size = New System.Drawing.Size(131, 24)
        Me.ChkLapRepair.TabIndex = 40
        Me.ChkLapRepair.Text = "Laporan Repair"
        Me.ChkLapRepair.UseVisualStyleBackColor = True
        '
        'ChkLapRepair2
        '
        Me.ChkLapRepair2.AutoSize = True
        Me.ChkLapRepair2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapRepair2.Location = New System.Drawing.Point(181, 221)
        Me.ChkLapRepair2.Name = "ChkLapRepair2"
        Me.ChkLapRepair2.Size = New System.Drawing.Size(192, 24)
        Me.ChkLapRepair2.TabIndex = 40
        Me.ChkLapRepair2.Text = "Laporan Repair Lengkap"
        Me.ChkLapRepair2.UseVisualStyleBackColor = True
        '
        'ChkLapKeuanganLngkp
        '
        Me.ChkLapKeuanganLngkp.AutoSize = True
        Me.ChkLapKeuanganLngkp.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.ChkLapKeuanganLngkp.Location = New System.Drawing.Point(181, 281)
        Me.ChkLapKeuanganLngkp.Name = "ChkLapKeuanganLngkp"
        Me.ChkLapKeuanganLngkp.Size = New System.Drawing.Size(213, 24)
        Me.ChkLapKeuanganLngkp.TabIndex = 41
        Me.ChkLapKeuanganLngkp.Text = "Laporan Keuangan Lengkap"
        Me.ChkLapKeuanganLngkp.UseVisualStyleBackColor = True
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 382)
        Me.Controls.Add(Me.ChkLapKeuanganLngkp)
        Me.Controls.Add(Me.ChkLapRepair2)
        Me.Controls.Add(Me.ChkLapRepair)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.ChkAkses)
        Me.Controls.Add(Me.ChkLapKeuangan)
        Me.Controls.Add(Me.ChkLapSpare)
        Me.Controls.Add(Me.ChkMerk)
        Me.Controls.Add(Me.ChkLapMT)
        Me.Controls.Add(Me.ChkRepair)
        Me.Controls.Add(Me.ChkAset)
        Me.Controls.Add(Me.ChkLapChecklist)
        Me.Controls.Add(Me.ChkOutlet)
        Me.Controls.Add(Me.ChkLapAset)
        Me.Controls.Add(Me.ChkSparepart)
        Me.Controls.Add(Me.ChkType)
        Me.Controls.Add(Me.ChkMT)
        Me.Controls.Add(Me.ChkModel)
        Me.Controls.Add(Me.ChkPetugas)
        Me.Controls.Add(Me.CmbStats)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHakAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hak Akses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbStats As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkPetugas As System.Windows.Forms.CheckBox
    Friend WithEvents ChkOutlet As System.Windows.Forms.CheckBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMerk As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapAset As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRepair As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapSpare As System.Windows.Forms.CheckBox
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSparepart As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAset As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapChecklist As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapMT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapKeuangan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAkses As System.Windows.Forms.CheckBox
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents ChkLapRepair As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapRepair2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLapKeuanganLngkp As System.Windows.Forms.CheckBox
End Class
