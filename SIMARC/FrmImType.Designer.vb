<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImType
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
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(88, 45)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(94, 38)
        Me.BtnImport.TabIndex = 0
        Me.BtnImport.Text = "Pilih Data"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'FrmImType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 146)
        Me.Controls.Add(Me.BtnImport)
        Me.Name = "FrmImType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Type"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnImport As System.Windows.Forms.Button
End Class
