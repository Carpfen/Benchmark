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
        CPUBtn = New Button()
        RAMBtn = New Button()
        DiskBtn = New Button()
        TestAllBtn = New Button()
        CPULbl = New Label()
        RAMLbl = New Label()
        DiskLbl = New Label()
        InfoBtn = New Button()
        CopyBtn = New Button()
        SuspendLayout()
        ' 
        ' CPUBtn
        ' 
        CPUBtn.BackColor = SystemColors.Control
        CPUBtn.Cursor = Cursors.Hand
        CPUBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CPUBtn.Location = New Point(58, 29)
        CPUBtn.Margin = New Padding(4, 3, 4, 3)
        CPUBtn.Name = "CPUBtn"
        CPUBtn.RightToLeft = RightToLeft.No
        CPUBtn.Size = New Size(292, 87)
        CPUBtn.TabIndex = 0
        CPUBtn.Text = "Teste CPU:"
        CPUBtn.UseVisualStyleBackColor = False
        ' 
        ' RAMBtn
        ' 
        RAMBtn.Cursor = Cursors.Hand
        RAMBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RAMBtn.Location = New Point(58, 144)
        RAMBtn.Margin = New Padding(4, 3, 4, 3)
        RAMBtn.Name = "RAMBtn"
        RAMBtn.Size = New Size(292, 87)
        RAMBtn.TabIndex = 1
        RAMBtn.Text = "Teste RAM:"
        RAMBtn.UseVisualStyleBackColor = False
        ' 
        ' DiskBtn
        ' 
        DiskBtn.Cursor = Cursors.Hand
        DiskBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DiskBtn.Location = New Point(58, 260)
        DiskBtn.Margin = New Padding(4, 3, 4, 3)
        DiskBtn.Name = "DiskBtn"
        DiskBtn.Size = New Size(292, 87)
        DiskBtn.TabIndex = 2
        DiskBtn.Text = "Teste Disk:"
        DiskBtn.UseVisualStyleBackColor = False
        ' 
        ' TestAllBtn
        ' 
        TestAllBtn.Cursor = Cursors.Hand
        TestAllBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TestAllBtn.Location = New Point(58, 375)
        TestAllBtn.Margin = New Padding(4, 3, 4, 3)
        TestAllBtn.Name = "TestAllBtn"
        TestAllBtn.Size = New Size(292, 87)
        TestAllBtn.TabIndex = 3
        TestAllBtn.Text = "Teste Alles"
        TestAllBtn.UseVisualStyleBackColor = False
        ' 
        ' CPULbl
        ' 
        CPULbl.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CPULbl.Location = New Point(496, 29)
        CPULbl.Margin = New Padding(4, 0, 4, 0)
        CPULbl.Name = "CPULbl"
        CPULbl.Size = New Size(292, 87)
        CPULbl.TabIndex = 4
        CPULbl.Text = "CPU-Werte"
        CPULbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RAMLbl
        ' 
        RAMLbl.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RAMLbl.Location = New Point(496, 144)
        RAMLbl.Margin = New Padding(4, 0, 4, 0)
        RAMLbl.Name = "RAMLbl"
        RAMLbl.Size = New Size(292, 87)
        RAMLbl.TabIndex = 5
        RAMLbl.Text = "RAM-Werte"
        RAMLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DiskLbl
        ' 
        DiskLbl.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DiskLbl.Location = New Point(496, 260)
        DiskLbl.Margin = New Padding(4, 0, 4, 0)
        DiskLbl.Name = "DiskLbl"
        DiskLbl.Size = New Size(292, 87)
        DiskLbl.TabIndex = 6
        DiskLbl.Text = "Disk-Werte"
        DiskLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' InfoBtn
        ' 
        InfoBtn.Cursor = Cursors.Hand
        InfoBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InfoBtn.Location = New Point(58, 490)
        InfoBtn.Margin = New Padding(4, 3, 4, 3)
        InfoBtn.Name = "InfoBtn"
        InfoBtn.Size = New Size(292, 87)
        InfoBtn.TabIndex = 7
        InfoBtn.Text = "Informationen"
        InfoBtn.UseVisualStyleBackColor = False
        ' 
        ' CopyBtn
        ' 
        CopyBtn.Cursor = Cursors.Hand
        CopyBtn.Font = New Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CopyBtn.Location = New Point(496, 375)
        CopyBtn.Margin = New Padding(4, 3, 4, 3)
        CopyBtn.Name = "CopyBtn"
        CopyBtn.Size = New Size(292, 87)
        CopyBtn.TabIndex = 8
        CopyBtn.Text = "Kopiere Werte"
        CopyBtn.UseVisualStyleBackColor = False
        ' 
        ' Benchmark
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(856, 599)
        Controls.Add(CopyBtn)
        Controls.Add(InfoBtn)
        Controls.Add(DiskLbl)
        Controls.Add(RAMLbl)
        Controls.Add(CPULbl)
        Controls.Add(TestAllBtn)
        Controls.Add(DiskBtn)
        Controls.Add(RAMBtn)
        Controls.Add(CPUBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Benchmark"
        Text = "Benchmark"
        ResumeLayout(False)

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
End Class
