Imports System.ComponentModel
Imports System.Management

Public Class Hardware
    Private minWidth As Integer
    Private minHeight As Integer
    Private diskLabels As New List(Of Label)

    Private Shared startPoint As Point = Nothing
    Public updateValues As Boolean = False
    Public Shared disks As New Dictionary(Of String, String)
    Public Shared currentDisk As String

    Private Sub Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PCName.Text = Environment.MachineName
            OS.Text = New ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()(0)("Caption").ToString().Replace("Microsoft ", "") & $" ({If(Environment.Is64BitOperatingSystem, "x64", "x86")})"

            CPU.Text = GetCPU()
            minWidth = CPU.Width
            RAM.Text = GetRAM()
            ' Disk:
            InitDisks()
            Dim dHeight As Integer = 261
            If disks.Count > 1 Then
                DiskLbl.Text = "Disks:"
            End If
            For Each kvp As KeyValuePair(Of String, String) In disks
                Dim l As New Label With {
                    .AutoSize = True,
                    .Cursor = Cursors.Hand,
                    .Location = New Point(205, dHeight),
                    .Tag = kvp.Key,
                    .Text = kvp.Value
                }
                dHeight += 50
                If kvp.Key <> currentDisk Then l.ForeColor = Color.Gray
                AddHandler l.MouseClick, AddressOf SelectDisk
                AddHandler l.DoubleClick, AddressOf Close
                diskLabels.Add(l)
                Controls.Add(l)
                If minWidth < l.Width Then minWidth = l.Width
            Next
            minHeight = dHeight + 40

            If startPoint <> Nothing Then Location = startPoint
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Fehler beim Laden der Hardwareinformation")
            Close()
        End Try
    End Sub

    Private Sub Hardware_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Width = CPU.Left + minWidth + 35
        Height = minHeight
    End Sub

    Private Sub Copy(sender As Object, e As EventArgs) Handles PCName.DoubleClick, OS.DoubleClick, CPU.DoubleClick, RAM.DoubleClick
        Dim lbl As Label = CType(sender, Label)
        Dim t As String = lbl.Text
        Clipboard.SetText(t)
        lbl.Text = "Kopiert!"
        lbl.Update()
        Threading.Thread.Sleep(1000)
        lbl.Text = t
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        Dim disks As New Dictionary(Of String, String)
        Clipboard.SetText($"PC-Name: {PCName.Text & vbCrLf}OS: {OS.Text & vbCrLf & vbCrLf}CPU: {CPU.Text & vbCrLf}RAM: {RAM.Text & vbCrLf}Disk{If(disks.Count > 1, "s", "")}: {String.Join(vbCrLf & "       ", disks.Values)}")
        CopyBtn.Text = "Kopiert!"
        CopyBtn.Update()
        Threading.Thread.Sleep(1000)
        CopyBtn.Text = "Kopiere Werte"
    End Sub



    Public Shared Function GetCPU() As String
        Try
            Dim cpuMOS = New ManagementObjectSearcher("SELECT Name, MaxClockSpeed, NumberOfCores FROM Win32_Processor").Get()(0)
            Return $"{cpuMOS("Name")}  ({Math.Round(CSng(cpuMOS("MaxClockSpeed")) / 1000, 2)} GHz) ({cpuMOS("NumberOfCores")} Cores)"
        Catch
            Return "N/A"
        End Try
    End Function

    Public Shared Function GetRAM() As String
        Try
            Return Math.Round(CSng(New ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get()(0)("TotalPhysicalMemory")) / (1024 * 1024 * 1024), 2) & " GiB"
        Catch
            Return "N/A"
        End Try
    End Function

    Public Shared Sub InitDisks()
        disks.Clear()
        If startPoint = Nothing Then currentDisk = Environment.GetCommandLineArgs(0)
        Try
            For Each diskMOS As ManagementObject In New ManagementObjectSearcher("SELECT Caption, Description, FileSystem, Size, FreeSpace, ProviderName FROM Win32_LogicalDisk").Get()
                Try
                    Dim size As Single = diskMOS("Size")
                    Dim freePercent As Single = Math.Round(CSng(diskMOS("FreeSpace")) * 100 / size)
                    disks(diskMOS("Caption")) = $"{diskMOS("Caption")} {diskMOS("Description")} ({diskMOS("FileSystem")})  -  {Math.Round(size / (1024 * 1024 * 1024), 2)} GiB  ({freePercent}% frei)"

                    If diskMOS("ProviderName") <> "" Then
                        If currentDisk.StartsWith(diskMOS("ProviderName")) Then
                            currentDisk = currentDisk.Replace(diskMOS("ProviderName"), diskMOS("Caption"))
                        End If
                    End If
                Catch
                End Try
            Next
        Catch
            MsgBox("Die Disks können nicht geladen werden.", vbExclamation, "Fehler beim Laden der Disks")
        End Try
        If startPoint = Nothing Then currentDisk = currentDisk.Split("\")(0)
    End Sub


    Private Sub SelectDisk(sender As Object, e As MouseEventArgs)
        Dim cLbl As Label = CType(sender, Label)
        If e.Button = MouseButtons.Left Then
            For Each lbl As Label In diskLabels
                lbl.ForeColor = Color.Gray
            Next
            cLbl.ForeColor = SystemColors.ControlText
            currentDisk = cLbl.Tag
        ElseIf e.Button = MouseButtons.Right Then
            Dim t As String = cLbl.Text
            Clipboard.SetText(t)
            cLbl.Text = "Kopiert!"
            cLbl.Update()
            Threading.Thread.Sleep(1000)
            cLbl.Text = t
        End If
    End Sub


    Private Sub Hardware_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        updateValues = True
        Close()
    End Sub

    Private Sub Hardware_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        startPoint = Location
    End Sub
End Class