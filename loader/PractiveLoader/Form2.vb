Imports System.Management
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Imports System.Diagnostics

Public Class Form2
    Dim clockon As Integer
    Dim online As Integer
    Dim check As Integer

#Region "Check Server Status"
    Private Sub CheckServerStatus()
        Dim tryconnect As New TcpClient

        Try
            tryconnect.Connect("localhost", 80)
            ServerStatus.ForeColor = Color.Lime
            ServerStatus.Text = "Online"
        Catch ex As Exception
            ServerStatus.ForeColor = Color.Red
            ServerStatus.Text = "Offline"
        End Try
    End Sub
#End Region

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.MaximumSize = New Size(Width, Height)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        CheckServerStatus()
        Label2.Text = ("Welcome Back, " + Environment.UserName)
        Dim address As String = "http://localhost/nigger/changelog.txt" ' Make this your changes.txt
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        RichTextBox1.Text = reader.ReadToEnd
        RichTextBox1.Multiline = True
        RichTextBox1.ReadOnly = True
    End Sub
    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Application.Exit()
    End Sub

    Private Sub InjectButton_Click(sender As Object, e As EventArgs) Handles InjectButton.Click
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "SanityCheatsInjector.exe" 'Look Below
        IO.File.WriteAllBytes(filename, My.Resources.SanityCheatsInjector)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "SanityCheatsInjector.exe")
        Application.Exit()
    End Sub

    Private Sub OriginButton2_Click(sender As Object, e As EventArgs) 
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "injector2.exe" 'Look Below
        IO.File.WriteAllBytes(filename, My.Resources.Injector2)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "injector2.exe")
        Application.Exit()
    End Sub

    Private Sub OriginTheme2_Click(sender As Object, e As EventArgs) Handles OriginTheme2.Click

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