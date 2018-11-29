<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPilihTanggal
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTAwal = New System.Windows.Forms.DateTimePicker()
        Me.DTAkhir = New System.Windows.Forms.DateTimePicker()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Tanggal Awal :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Tanggal Akhir :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTAwal
        '
        Me.DTAwal.CustomFormat = "dd MMMM yyyy"
        Me.DTAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTAwal.Location = New System.Drawing.Point(121, 17)
        Me.DTAwal.Name = "DTAwal"
        Me.DTAwal.Size = New System.Drawing.Size(200, 24)
        Me.DTAwal.TabIndex = 38
        '
        'DTAkhir
        '
        Me.DTAkhir.CustomFormat = "dd MMMM yyyy"
        Me.DTAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTAkhir.Location = New System.Drawing.Point(121, 54)
        Me.DTAkhir.Name = "DTAkhir"
        Me.DTAkhir.Size = New System.Drawing.Size(200, 24)
        Me.DTAkhir.TabIndex = 38
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackgroundImage = Global.SIMARC.My.Resources.Resources.door_out
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(207, 95)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 49)
        Me.BtnKeluar.TabIndex = 47
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackgroundImage = Global.SIMARC.My.Resources.Resources.Save_16x16
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(130, 95)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(71, 49)
        Me.BtnSimpan.TabIndex = 48
        Me.BtnSimpan.Text = "Proses"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'FrmPilihTanggal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.DTAkhir)
        Me.Controls.Add(Me.DTAwal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmPilihTanggal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Tanggal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
End Class
