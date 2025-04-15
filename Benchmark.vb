Imports System.IO

Public Class Benchmark
    Dim StartTime As DateTime
    Dim cDisk As String = ""
    ReadOnly Version As String = "2.3_" & If(Environment.Is64BitProcess, "x64", "x86")

    Public Sub CPU()
        Dim n As Byte
        Dim time As Double
        CPULbl.Text = "Berechne . . ."
        CPULbl.BackColor = CPUBtn.BackColor
        CPULbl.Update()
        StartTime = Now
        For i As Long = 0 To If(Environment.Is64BitProcess, 1500000000, 500000000)
            n = i Mod 7
        Next
        time = Now.Subtract(StartTime).TotalSeconds
        CPULbl.Text = time.ToString.Substring(0, 4)
        If time < 3 Then
            CPULbl.BackColor = Color.Green
        ElseIf time < 6 Then
            CPULbl.BackColor = Color.Yellow
        Else
            CPULbl.BackColor = Color.Red
        End If
        CPULbl.Update()
    End Sub

    Public Sub RAM()
        Dim list As New ArrayList()
        Dim time As Double
        RAMLbl.Text = "Berechne . . ."
        RAMLbl.BackColor = RAMBtn.BackColor
        RAMLbl.Update()
        StartTime = Now
        For i As Long = 0 To If(Environment.Is64BitProcess, 23000000, 20000000)
            list.Add(1)
        Next
        time = Now.Subtract(StartTime).TotalSeconds
        RAMLbl.Text = time.ToString.Substring(0, 4)
        If time < 3 Then
            RAMLbl.BackColor = Color.Green
        ElseIf time < 6 Then
            RAMLbl.BackColor = Color.Yellow
        Else
            RAMLbl.BackColor = Color.Red
        End If
        RAMLbl.Update()
    End Sub

    Public Sub Disk(Optional fileNumber As Integer = 0)
        Dim time As Double
        cDisk = Hardware.currentDisk
        Dim fileName As String = $"{cDisk}\tempfile {fileNumber}.ckbm"
        DiskLbl.Text = "Berechne . . ."
        DiskLbl.BackColor = CPUBtn.BackColor
        DiskLbl.Update()
        Try
            StartTime = Now

            Dim writer As StreamWriter
            writer = New StreamWriter(fileName, False)
            For i As Long = 0 To If(Environment.Is64BitProcess, 30000000, 25000000)
                writer.Write("1")
            Next
            writer.Close()
            writer.Dispose()

            Dim reader As StreamReader
            reader = New StreamReader(fileName)
            For i As Long = 0 To If(Environment.Is64BitProcess, 550000, 500000)
                reader.ReadToEnd()
            Next
            reader.Close()
            reader.Dispose()
            time = Now.Subtract(StartTime).TotalSeconds
            File.Delete(fileName)
            DiskLbl.Text = time.ToString.Substring(0, 4)
            If time < 3 Then
                DiskLbl.BackColor = Color.Green
            ElseIf time < 6 Then
                DiskLbl.BackColor = Color.Yellow
            Else
                DiskLbl.BackColor = Color.Red
            End If
            DiskLbl.Update()

            Dim failedAttempts As Byte = 10
            While File.Exists(fileName)
                If failedAttempts = 0 Then
                    MsgBox(fileName & " konnte nicht wieder gelöscht werden.", vbExclamation, "Fehler beim Löschen")
                    Exit While
                End If
                File.Delete(fileName)
                Threading.Thread.Sleep(1000)
                failedAttempts -= 1
            End While
        Catch ex As UnauthorizedAccessException
            DiskLbl.Text = "Nicht Berechtigt"
            MsgBox($"Das Programm ist nicht berechtigt, eine Datei in {If(cDisk <> "", cDisk, "das CWD")} zu schreiben.", vbCritical, "Fehlende Berechtigung")
        Catch ex As Exception
            Disk(fileNumber + 1)
        End Try
    End Sub

    Public Sub Enable(enabled As Boolean)
        CPUBtn.Enabled = enabled
        RAMBtn.Enabled = enabled
        DiskBtn.Enabled = enabled
        TestAllBtn.Enabled = enabled
        InfoBtn.Enabled = enabled
        CopyBtn.Enabled = enabled
        HardwareBtn.Enabled = enabled
    End Sub

    Private Sub CPUBtn_Click(sender As Object, e As EventArgs) Handles CPUBtn.Click
        Enable(False)
        CPU()
        Enable(True)
        CPUBtn.Focus()
    End Sub

    Private Sub RAMBtn_Click(sender As Object, e As EventArgs) Handles RAMBtn.Click
        Enable(False)
        RAM()
        Enable(True)
        RAMBtn.Focus()
    End Sub

    Private Sub DiskBtn_Click(sender As Object, e As EventArgs) Handles DiskBtn.Click
        Enable(False)
        Disk()
        Enable(True)
        DiskBtn.Focus()
    End Sub

    Private Sub TestAllBtn_Click(sender As Object, e As EventArgs) Handles TestAllBtn.Click
        Enable(False)
        CPU()
        RAM()
        Disk()
        Enable(True)
        TestAllBtn.Focus()
    End Sub

    Private Sub Benchmark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hardware.InitDisks()
        If Hardware.currentDisk <> "" Then
            DiskBtn.Text &= $" ({Hardware.currentDisk})"
        End If
        Text &= $" ({Version})"
        Show()
        TestAllBtn.Focus()
    End Sub

    Private Sub Copy(sender As Object, e As EventArgs) Handles CPULbl.DoubleClick, RAMLbl.DoubleClick, DiskLbl.DoubleClick
        Dim lbl As Label = CType(sender, Label)
        If IsNumeric(lbl.Text.ToCharArray()(0)) Then
            Dim t As String = lbl.Text
            Clipboard.SetText(t)
            lbl.Text = "Kopiert!"
            lbl.Update()
            Threading.Thread.Sleep(1000)
            lbl.Text = t
        End If
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        Dim cpu As String
        Dim ram As String
        Dim disk As String

        If IsNumeric(CPULbl.Text.ToCharArray()(0)) Then
            cpu = CPULbl.Text
        Else
            cpu = "-"
        End If
        If IsNumeric(RAMLbl.Text.ToCharArray()(0)) Then
            ram = RAMLbl.Text
        Else
            ram = "-"
        End If
        If IsNumeric(DiskLbl.Text.ToCharArray()(0)) Then
            disk = DiskLbl.Text
        Else
            disk = "-"
        End If

        Dim diskH As String = If(cDisk <> "" AndAlso Hardware.disks.ContainsKey(cDisk), $" ({Hardware.disks(cDisk)})", "")

        Clipboard.SetText($"Benchmark ({Version}) Ergebnisse:{vbCrLf}CPU: {cpu} ({Hardware.GetCPU()}){vbCrLf}RAM: {ram} ({Hardware.GetRAM()}){vbCrLf}Disk: {disk & diskH}")
        CopyBtn.Text = "Kopiert!"
        CopyBtn.Update()
        Threading.Thread.Sleep(1000)
        CopyBtn.Text = "Kopiere Werte"
    End Sub


    Private Sub InfoBtn_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
        MsgBox($"Ersteller des Benchmarks:{vbCrLf}Carsten Kranz{vbCrLf & vbCrLf}Version:{vbCrLf & Version & vbCrLf & vbCrLf & vbCrLf}Die Werte geben die Zeit des jeweiligen Prozesses in Sekunden an.{vbCrLf}Doppelklicken Sie die Werte, um sie in der Zwischenablage zu speichern.", vbInformation, "Informationen")
    End Sub

    Private Sub HardwareBtn_Click(sender As Object, e As EventArgs) Handles HardwareBtn.Click
        Dim hw As New Hardware()
        hw.ShowDialog()
        DiskBtn.Text = "Teste Disk:" & If(Hardware.currentDisk <> "", $" ({Hardware.currentDisk})", "")
    End Sub
End Class