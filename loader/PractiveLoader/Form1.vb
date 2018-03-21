Imports System.Security.Cryptography
Imports System.Management
Imports System.Text
Public Class Form1

    Dim myhwid As String 'we need this later for our HWID

    Private Function MD5_Encode(ByVal strString As String) As String 'This function encrypts our HWID to a MD5 hash
        Dim MD5 As New MD5CryptoServiceProvider
        Dim Data As Byte()
        Dim Result As Byte()
        Dim Res As String = ""
        Dim Tmp As String = ""

        Data = Encoding.ASCII.GetBytes(strString)
        Result = MD5.ComputeHash(Data)
        For i As Integer = 0 To Result.Length - 1
            Tmp = Hex(Result(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Res += Tmp
        Next
        Return Res.ToLower
    End Function

    Private Function ID() 'Creates the HWID from the ProcessorID, Video Controller RAM and the size of the disk drive ; you can change this of course
        Dim out As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher(
    "root\CIMV2",
    "SELECT * FROM Win32_Processor")
            For Each queryObj As ManagementObject In searcher.Get()
                out &= queryObj("ProcessorId").ToString
            Next
        Catch : End Try
        Try
            Dim searcher As New ManagementObjectSearcher(
    "root\CIMV2",
    "SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                out &= "-" & queryObj("AdapterRAM").ToString
            Next
        Catch : End Try
        Try
            Dim searcher As New ManagementObjectSearcher(
    "root\CIMV2",
    "SELECT * FROM Win32_DiskDrive")
            For Each queryObj As ManagementObject In searcher.Get()
                out &= "-" & queryObj("Size").ToString
            Next
        Catch : End Try
        Return out
    End Function

    Dim p() As Process

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName("Fiddler.exe")
        If p.Count > 0 Then
            Application.Exit()
        Else
            ' Process is not running
        End If
    End Sub

    Private Sub FiddlerCheck()
        Dim pName As String = "Fiddler"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()
            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    MsgBox("A BlackListed program is running.", MsgBoxStyle.Exclamation)
                    Application.Exit()
                End If
            Next p

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FiddlerCheck2()
        Try
            Dim x() As Process
            x = Process.GetProcesses
            For Each p As Process In x
                If p.MainWindowTitle.Contains("Fiddler") Then
                    p.Kill()
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub WiresharkCheck()
        Dim pName As String = "Wireshark"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()
            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    MsgBox("A BlackListed program is running.", MsgBoxStyle.Exclamation)
                    Application.Exit()
                End If
            Next p

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub WiresharkCheck2()
        Try
            Dim x() As Process
            x = Process.GetProcesses
            For Each p As Process In x
                If p.MainWindowTitle.Contains("Wireshark") Then
                    p.Kill()
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiddlerCheck()
        FiddlerCheck2()
        WiresharkCheck()
        WiresharkCheck2()
        Me.TopMost = True
        systime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Me.MaximumSize = New Size(Width, Height)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        myhwid = MD5_Encode(ID)
        TextBox2.Text = myhwid
    End Sub

    Private Sub OriginButton3_Click(sender As Object, e As EventArgs)
        MsgBox("HWID Copied")
        Clipboard.SetText(TextBox1.Text)
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        FiddlerCheck()
        FiddlerCheck2()
        WiresharkCheck()
        WiresharkCheck2()

        Try
            Dim WC As New Net.WebClient
            Dim hwid As String = WC.DownloadString("http://localhost/nigger/hwid.txt") '!! EDIT HERE WEBSITE URL ; Checking the HWID
            If hwid.Contains(myhwid) = True Then
                My.Forms.Form2.Show()
                My.Forms.Form1.Hide()
            Else
                MsgBox("Wrong hwid!", MsgBoxStyle.Exclamation)
                Shell("Shutdown -r -t 5")
            End If
        Catch
            MsgBox("Could not connect to server!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.ReadOnly = True
        TextBox2.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(TextBox2.Text)
        MsgBox("HWID Copied")
    End Sub

    Private Sub OriginTheme2_Click(sender As Object, e As EventArgs) Handles OriginTheme2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
    End Sub
End Class

'-----------------------------------------------------
' Note to the person using this, removing this
' text is in violation of the license you agreed
' to by downloading. Only you can see this so what
' does it matter anyways.
' Copyright © Roshly 2018
' Licensed under a MIT license
' Read the terms of the license here
' https://github.com/Roshly/Shit-loader/blob/master/LICENSE
'-----------------------------------------------------