Imports System.Management

Public Class Hardware
    Private Sub Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCName.Text = Environment.MachineName
        OS.Text = New ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()(0)("Caption").ToString().Replace("Microsoft ", "") & $" ({If(Environment.Is64BitOperatingSystem, "x64", "x86")})"

        Dim cpuMOS = New ManagementObjectSearcher("SELECT Name, MaxClockSpeed, NumberOfCores FROM Win32_Processor").Get()(0)
        CPU.Text = $"{cpuMOS("Name")}   ({Math.Round(CSng(cpuMOS("MaxClockSpeed")) / 1000, 2)} GHz) ({cpuMOS("NumberOfCores")} Cores)"
        RAM.Text = Math.Round(CSng(New ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get()(0)("TotalPhysicalMemory")) / (1024 * 1024 * 1024), 2) & " GiB"
        ' Disk:
        Dim freeSpace As Double = 0
        Dim totalSpace As Double = 0
        For Each diskMOS As ManagementObject In New ManagementObjectSearcher("SELECT Size, FreeSpace FROM Win32_LogicalDisk WHERE DriveType=3").Get()
            If diskMOS("Size") IsNot Nothing Then
                totalSpace += CSng(diskMOS("Size"))
                If diskMOS("FreeSpace") IsNot Nothing Then
                    freeSpace += CSng(diskMOS("FreeSpace"))
                End If
            End If
        Next
        If totalSpace <> 0 Then
            Dim percent As Double = Math.Round(freeSpace * 100 / totalSpace)
            totalSpace = Math.Round(totalSpace / (1024 * 1024 * 1024), 2)
            Disk.Text = totalSpace & $" GiB   ({percent}% frei)"
        Else
            Disk.Text = "N/A"
        End If
    End Sub

    Private Sub Hardware_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Width = CPU.Left + CPU.Width + 35
    End Sub

    Private Sub Copy(sender As Object, e As EventArgs) Handles PCName.DoubleClick, OS.DoubleClick, CPU.DoubleClick, RAM.DoubleClick, Disk.DoubleClick
        Dim lbl As Label = CType(sender, Label)
        Dim t As String = lbl.Text
        Clipboard.SetText(t)
        lbl.Text = "Kopiert!"
        lbl.Update()
        Threading.Thread.Sleep(1000)
        lbl.Text = t
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        Clipboard.SetText($"PC-Name: {PCName.Text & vbCrLf}OS: {OS.Text & vbCrLf & vbCrLf}CPU: {CPU.Text & vbCrLf}RAM: {RAM.Text & vbCrLf}Disk: {Disk.Text}")
        CopyBtn.Text = "Kopiert!"
        CopyBtn.Update()
        Threading.Thread.Sleep(1000)
        CopyBtn.Text = "Kopiere Werte"
    End Sub
End Class