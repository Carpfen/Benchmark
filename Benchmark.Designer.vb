<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Benchmark
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CPUBtn = New System.Windows.Forms.Button()
        Me.RAMBtn = New System.Windows.Forms.Button()
        Me.DiskBtn = New System.Windows.Forms.Button()
        Me.TestAllBtn = New System.Windows.Forms.Button()
        Me.CPULbl = New System.Windows.Forms.Label()
        Me.RAMLbl = New System.Windows.Forms.Label()
        Me.DiskLbl = New System.Windows.Forms.Label()
        Me.InfoBtn = New System.Windows.Forms.Button()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.HardwareBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CPUBtn
        '
        Me.CPUBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CPUBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CPUBtn.Location = New System.Drawing.Point(50, 25)
        Me.CPUBtn.Name = "CPUBtn"
        Me.CPUBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUBtn.Size = New System.Drawing.Size(250, 75)
        Me.CPUBtn.TabIndex = 0
        Me.CPUBtn.Text = "Teste CPU:"
        Me.CPUBtn.UseVisualStyleBackColor = False
        '
        'RAMBtn
        '
        Me.RAMBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RAMBtn.Location = New System.Drawing.Point(50, 125)
        Me.RAMBtn.Name = "RAMBtn"
        Me.RAMBtn.Size = New System.Drawing.Size(250, 75)
        Me.RAMBtn.TabIndex = 1
        Me.RAMBtn.Text = "Teste RAM:"
        Me.RAMBtn.UseVisualStyleBackColor = False
        '
        'DiskBtn
        '
        Me.DiskBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DiskBtn.Location = New System.Drawing.Point(50, 225)
        Me.DiskBtn.Name = "DiskBtn"
        Me.DiskBtn.Size = New System.Drawing.Size(250, 75)
        Me.DiskBtn.TabIndex = 2
        Me.DiskBtn.Text = "Teste Disk:"
        Me.DiskBtn.UseVisualStyleBackColor = False
        '
        'TestAllBtn
        '
        Me.TestAllBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TestAllBtn.Location = New System.Drawing.Point(50, 325)
        Me.TestAllBtn.Name = "TestAllBtn"
        Me.TestAllBtn.Size = New System.Drawing.Size(250, 75)
        Me.TestAllBtn.TabIndex = 3
        Me.TestAllBtn.Text = "Teste Alles"
        Me.TestAllBtn.UseVisualStyleBackColor = False
        '
        'CPULbl
        '
        Me.CPULbl.Location = New System.Drawing.Point(425, 25)
        Me.CPULbl.Name = "CPULbl"
        Me.CPULbl.Size = New System.Drawing.Size(250, 75)
        Me.CPULbl.TabIndex = 4
        Me.CPULbl.Text = "CPU-Werte"
        Me.CPULbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RAMLbl
        '
        Me.RAMLbl.Location = New System.Drawing.Point(425, 125)
        Me.RAMLbl.Name = "RAMLbl"
        Me.RAMLbl.Size = New System.Drawing.Size(250, 75)
        Me.RAMLbl.TabIndex = 5
        Me.RAMLbl.Text = "RAM-Werte"
        Me.RAMLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiskLbl
        '
        Me.DiskLbl.Location = New System.Drawing.Point(425, 225)
        Me.DiskLbl.Name = "DiskLbl"
        Me.DiskLbl.Size = New System.Drawing.Size(250, 75)
        Me.DiskLbl.TabIndex = 6
        Me.DiskLbl.Text = "Disk-Werte"
        Me.DiskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoBtn
        '
        Me.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoBtn.Location = New System.Drawing.Point(50, 465)
        Me.InfoBtn.Name = "InfoBtn"
        Me.InfoBtn.Size = New System.Drawing.Size(250, 75)
        Me.InfoBtn.TabIndex = 8
        Me.InfoBtn.Text = "Informationen"
        Me.InfoBtn.UseVisualStyleBackColor = False
        '
        'CopyBtn
        '
        Me.CopyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyBtn.Location = New System.Drawing.Point(425, 325)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(250, 75)
        Me.CopyBtn.TabIndex = 7
        Me.CopyBtn.Text = "Kopiere Werte"
        Me.CopyBtn.UseVisualStyleBackColor = False
        '
        'HardwareBtn
        '
        Me.HardwareBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HardwareBtn.Location = New System.Drawing.Point(425, 465)
        Me.HardwareBtn.Name = "HardwareBtn"
        Me.HardwareBtn.Size = New System.Drawing.Size(250, 75)
        Me.HardwareBtn.TabIndex = 9
        Me.HardwareBtn.Text = "Hardware"
        Me.HardwareBtn.UseVisualStyleBackColor = False
        '
        'Benchmark
        '
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.HardwareBtn)
        Me.Controls.Add(Me.CopyBtn)
        Me.Controls.Add(Me.InfoBtn)
        Me.Controls.Add(Me.DiskLbl)
        Me.Controls.Add(Me.RAMLbl)
        Me.Controls.Add(Me.CPULbl)
        Me.Controls.Add(Me.TestAllBtn)
        Me.Controls.Add(Me.DiskBtn)
        Me.Controls.Add(Me.RAMBtn)
        Me.Controls.Add(Me.CPUBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Benchmark"
        Me.Text = "Benchmark"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CPUBtn As Button
    Friend WithEvents RAMBtn As Button
    Friend WithEvents DiskBtn As Button
    Friend WithEvents TestAllBtn As Button
    Friend WithEvents CPULbl As Label
    Friend WithEvents RAMLbl As Label
    Friend WithEvents DiskLbl As Label
    Friend WithEvents InfoBtn As Button
    Friend WithEvents CopyBtn As Button
    Friend WithEvents HardwareBtn As Button
End Class
