Imports System.IO

Public Class Benchmark
    Dim StartTime As DateTime
    Dim Version = "2.0"

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

    Public Sub Disk()
        Dim time As Double
        DiskLbl.Text = "Berechne . . ."
        DiskLbl.BackColor = CPUBtn.BackColor
        DiskLbl.Update()
        StartTime = Now

        Dim writer As StreamWriter
        writer = New StreamWriter("tempfile.ckbm", False)
        For i As Long = 0 To If(Environment.Is64BitProcess, 30000000, 25000000)
            writer.Write("1")
        Next
        writer.Close()
        writer.Dispose()

        Dim reader As StreamReader
        reader = New StreamReader("tempfile.ckbm")
        For i As Long = 0 To If(Environment.Is64BitProcess, 550000, 500000)
            reader.ReadToEnd()
        Next
        reader.Close()
        reader.Dispose()
        time = Now.Subtract(StartTime).TotalSeconds
        File.Delete("tempfile.ckbm")
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
        While File.Exists("tempfile.ckbm")
            If failedAttempts = 0 Then
                MsgBox("tempfile.ckbm konnte nicht wieder gelöscht werden.", vbExclamation, "Fehler beim Löschen")
                Exit While
            End If
            File.Delete("tempfile.ckbm")
            failedAttempts -= 1
        End While
    End Sub

    Public Sub Enable(enabled As Boolean)
        CPUBtn.Enabled = enabled
        RAMBtn.Enabled = enabled
        DiskBtn.Enabled = enabled
        TestAllBtn.Enabled = enabled
        InfoBtn.Enabled = enabled
        CopyBtn.Enabled = enabled
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
        Text &= $" ({Version}_{If(Environment.Is64BitProcess, "x64", "x86")})"
        Show()
        TestAllBtn.Focus()
    End Sub

    Private Sub InfoBtn_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
        MsgBox($"Ersteller des Benchmarks:{vbCrLf}Carsten Kranz{vbCrLf & vbCrLf}Version:{vbCrLf & Version & vbCrLf & vbCrLf & vbCrLf}Die Werte geben die Zeit des jeweiligen Prozesses in Sekunden an.{vbCrLf}Doppelklicken Sie die Werte, um sie in der Zwischenablage zu speichern.", vbInformation, "Informationen")
    End Sub

    Private Sub CPULbl_DoubleClick(sender As Object, e As EventArgs) Handles CPULbl.DoubleClick
        Dim t As String
        If IsNumeric(CPULbl.Text.ToCharArray()(0)) Then
            t = CPULbl.Text
            Clipboard.SetText(t)
            CPULbl.Text = "Kopiert!"
            CPULbl.Update()
            Threading.Thread.Sleep(1000)
            CPULbl.Text = t
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub RAMLbl_DoubleClick(sender As Object, e As EventArgs) Handles RAMLbl.DoubleClick
        Dim t As String
        If IsNumeric(RAMLbl.Text.ToCharArray()(0)) Then
            t = RAMLbl.Text
            Clipboard.SetText(t)
            RAMLbl.Text = "Kopiert!"
            RAMLbl.Update()
            Threading.Thread.Sleep(1000)
            RAMLbl.Text = t
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub DiskLbl_DoubleClick(sender As Object, e As EventArgs) Handles DiskLbl.DoubleClick
        Dim t As String
        If IsNumeric(DiskLbl.Text.ToCharArray()(0)) Then
            t = DiskLbl.Text
            Clipboard.SetText(t)
            DiskLbl.Text = "Kopiert!"
            DiskLbl.Update()
            Threading.Thread.Sleep(1000)
            DiskLbl.Text = t
        Else
            Clipboard.Clear()
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

        Clipboard.SetText($"Benchmark ({Version}) Ergebnisse:{vbCrLf}CPU: {cpu & vbCrLf}RAM: {ram & vbCrLf}Disk: {disk}")
        CopyBtn.Text = "Kopiert!"
        CopyBtn.Update()
        Threading.Thread.Sleep(1000)
        CopyBtn.Text = "Kopiere Werte"
    End Sub
End Class