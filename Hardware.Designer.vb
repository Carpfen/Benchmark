<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hardware
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PCNameLbl = New System.Windows.Forms.Label()
        Me.PCName = New System.Windows.Forms.Label()
        Me.OSLbl = New System.Windows.Forms.Label()
        Me.OS = New System.Windows.Forms.Label()
        Me.CPULbl = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.Label()
        Me.RAMLbl = New System.Windows.Forms.Label()
        Me.RAM = New System.Windows.Forms.Label()
        Me.DiskLbl = New System.Windows.Forms.Label()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PCNameLbl
        '
        Me.PCNameLbl.AutoSize = True
        Me.PCNameLbl.Location = New System.Drawing.Point(25, 25)
        Me.PCNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PCNameLbl.Name = "PCNameLbl"
        Me.PCNameLbl.Size = New System.Drawing.Size(141, 31)
        Me.PCNameLbl.TabIndex = 0
        Me.PCNameLbl.Text = "PC-Name:"
        '
        'PCName
        '
        Me.PCName.AutoSize = True
        Me.PCName.Location = New System.Drawing.Point(205, 25)
        Me.PCName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PCName.Name = "PCName"
        Me.PCName.Size = New System.Drawing.Size(133, 31)
        Me.PCName.TabIndex = 1
        Me.PCName.Text = "PC-Name"
        '
        'OSLbl
        '
        Me.OSLbl.AutoSize = True
        Me.OSLbl.Location = New System.Drawing.Point(25, 75)
        Me.OSLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OSLbl.Name = "OSLbl"
        Me.OSLbl.Size = New System.Drawing.Size(61, 31)
        Me.OSLbl.TabIndex = 2
        Me.OSLbl.Text = "OS:"
        '
        'OS
        '
        Me.OS.AutoSize = True
        Me.OS.Location = New System.Drawing.Point(205, 75)
        Me.OS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OS.Name = "OS"
        Me.OS.Size = New System.Drawing.Size(53, 31)
        Me.OS.TabIndex = 3
        Me.OS.Text = "OS"
        '
        'CPULbl
        '
        Me.CPULbl.AutoSize = True
        Me.CPULbl.Location = New System.Drawing.Point(25, 161)
        Me.CPULbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CPULbl.Name = "CPULbl"
        Me.CPULbl.Size = New System.Drawing.Size(80, 31)
        Me.CPULbl.TabIndex = 4
        Me.CPULbl.Text = "CPU:"
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.Location = New System.Drawing.Point(205, 161)
        Me.CPU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(72, 31)
        Me.CPU.TabIndex = 5
        Me.CPU.Text = "CPU"
        '
        'RAMLbl
        '
        Me.RAMLbl.AutoSize = True
        Me.RAMLbl.Location = New System.Drawing.Point(25, 211)
        Me.RAMLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RAMLbl.Name = "RAMLbl"
        Me.RAMLbl.Size = New System.Drawing.Size(82, 31)
        Me.RAMLbl.TabIndex = 6
        Me.RAMLbl.Text = "RAM:"
        '
        'RAM
        '
        Me.RAM.AutoSize = True
        Me.RAM.Location = New System.Drawing.Point(205, 211)
        Me.RAM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RAM.Name = "RAM"
        Me.RAM.Size = New System.Drawing.Size(74, 31)
        Me.RAM.TabIndex = 7
        Me.RAM.Text = "RAM"
        '
        'DiskLbl
        '
        Me.DiskLbl.AutoSize = True
        Me.DiskLbl.Location = New System.Drawing.Point(25, 261)
        Me.DiskLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiskLbl.Name = "DiskLbl"
        Me.DiskLbl.Size = New System.Drawing.Size(76, 31)
        Me.DiskLbl.TabIndex = 8
        Me.DiskLbl.Text = "Disk:"
        '
        'CopyBtn
        '
        Me.CopyBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyBtn.Location = New System.Drawing.Point(246, 12)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(199, 44)
        Me.CopyBtn.TabIndex = 9
        Me.CopyBtn.Text = "Kopiere Werte"
        Me.CopyBtn.UseVisualStyleBackColor = False
        '
        'Hardware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 317)
        Me.Controls.Add(Me.CopyBtn)
        Me.Controls.Add(Me.DiskLbl)
        Me.Controls.Add(Me.RAM)
        Me.Controls.Add(Me.RAMLbl)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.CPULbl)
        Me.Controls.Add(Me.OS)
        Me.Controls.Add(Me.OSLbl)
        Me.Controls.Add(Me.PCName)
        Me.Controls.Add(Me.PCNameLbl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Hardware"
        Me.Text = "Hardware"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PCNameLbl As Label
    Friend WithEvents PCName As Label
    Friend WithEvents OSLbl As Label
    Friend WithEvents OS As Label
    Friend WithEvents CPULbl As Label
    Friend WithEvents CPU As Label
    Friend WithEvents RAMLbl As Label
    Friend WithEvents RAM As Label
    Friend WithEvents DiskLbl As Label
    Friend WithEvents CopyBtn As Button
End Class
