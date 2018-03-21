<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OriginTheme2 = New SanityFramework.OriginTheme()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Statusbox = New System.Windows.Forms.GroupBox()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.DetectionStatus = New System.Windows.Forms.Label()
        Me.ServerStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InjectButton = New SanityFramework.OriginButton()
        Me.closebutton = New SanityFramework.OriginButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OriginTheme2.SuspendLayout()
        Me.Statusbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OriginTheme2
        '
        Me.OriginTheme2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OriginTheme2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OriginTheme2.Controls.Add(Me.RichTextBox1)
        Me.OriginTheme2.Controls.Add(Me.Label2)
        Me.OriginTheme2.Controls.Add(Me.Statusbox)
        Me.OriginTheme2.Controls.Add(Me.InjectButton)
        Me.OriginTheme2.Controls.Add(Me.closebutton)
        Me.OriginTheme2.Customization = "JiYn//////8="
        Me.OriginTheme2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginTheme2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OriginTheme2.Image = Nothing
        Me.OriginTheme2.Location = New System.Drawing.Point(0, 0)
        Me.OriginTheme2.Movable = True
        Me.OriginTheme2.Name = "OriginTheme2"
        Me.OriginTheme2.NoRounding = False
        Me.OriginTheme2.Sizable = True
        Me.OriginTheme2.Size = New System.Drawing.Size(371, 297)
        Me.OriginTheme2.SmartBounds = True
        Me.OriginTheme2.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.OriginTheme2.TabIndex = 0
        Me.OriginTheme2.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme2.Transparent = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(19, 62)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(166, 177)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Welcomeback"
        '
        'Statusbox
        '
        Me.Statusbox.Controls.Add(Me.lblNetwork)
        Me.Statusbox.Controls.Add(Me.DetectionStatus)
        Me.Statusbox.Controls.Add(Me.ServerStatus)
        Me.Statusbox.Controls.Add(Me.Label1)
        Me.Statusbox.Location = New System.Drawing.Point(191, 39)
        Me.Statusbox.Name = "Statusbox"
        Me.Statusbox.Size = New System.Drawing.Size(168, 77)
        Me.Statusbox.TabIndex = 6
        Me.Statusbox.TabStop = False
        Me.Statusbox.Text = "Status"
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.ForeColor = System.Drawing.Color.Lime
        Me.lblNetwork.Location = New System.Drawing.Point(99, 48)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(68, 15)
        Me.lblNetwork.TabIndex = 3
        Me.lblNetwork.Text = "Undetected"
        '
        'DetectionStatus
        '
        Me.DetectionStatus.AutoSize = True
        Me.DetectionStatus.Location = New System.Drawing.Point(7, 48)
        Me.DetectionStatus.Name = "DetectionStatus"
        Me.DetectionStatus.Size = New System.Drawing.Size(96, 15)
        Me.DetectionStatus.TabIndex = 2
        Me.DetectionStatus.Text = "Detection Status:"
        '
        'ServerStatus
        '
        Me.ServerStatus.AutoSize = True
        Me.ServerStatus.Location = New System.Drawing.Point(91, 23)
        Me.ServerStatus.Name = "ServerStatus"
        Me.ServerStatus.Size = New System.Drawing.Size(0, 15)
        Me.ServerStatus.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Status:"
        '
        'InjectButton
        '
        Me.InjectButton.Customization = "AKX/////////////"
        Me.InjectButton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.InjectButton.Image = Nothing
        Me.InjectButton.Location = New System.Drawing.Point(12, 245)
        Me.InjectButton.Name = "InjectButton"
        Me.InjectButton.NoRounding = False
        Me.InjectButton.Size = New System.Drawing.Size(105, 40)
        Me.InjectButton.TabIndex = 4
        Me.InjectButton.Text = "Inject"
        Me.InjectButton.Transparent = False
        '
        'closebutton
        '
        Me.closebutton.Customization = "AKX/////////////"
        Me.closebutton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.closebutton.Image = Nothing
        Me.closebutton.Location = New System.Drawing.Point(254, 245)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.NoRounding = False
        Me.closebutton.Size = New System.Drawing.Size(105, 40)
        Me.closebutton.TabIndex = 3
        Me.closebutton.Text = "Close"
        Me.closebutton.Transparent = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 297)
        Me.Controls.Add(Me.OriginTheme2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "SanityFramework - Loader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme2.ResumeLayout(False)
        Me.OriginTheme2.PerformLayout()
        Me.Statusbox.ResumeLayout(False)
        Me.Statusbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OriginTheme1 As OriginTheme
    Friend WithEvents OriginButton1 As OriginButton
    Friend WithEvents OriginTheme2 As OriginTheme
    Friend WithEvents closebutton As OriginButton
    Friend WithEvents InjectButton As OriginButton
    Friend WithEvents Statusbox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ServerStatus As Label
    Friend WithEvents DetectionStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblNetwork As Label
End Class
