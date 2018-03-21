<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OriginTheme2 = New SanityFramework.OriginTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.systime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CopyButton = New SanityFramework.OriginButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.closebutton = New SanityFramework.OriginButton()
        Me.LoginButton = New SanityFramework.OriginButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OriginTheme2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 0
        '
        'OriginTheme2
        '
        Me.OriginTheme2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OriginTheme2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OriginTheme2.Controls.Add(Me.Label1)
        Me.OriginTheme2.Controls.Add(Me.systime)
        Me.OriginTheme2.Controls.Add(Me.PictureBox1)
        Me.OriginTheme2.Controls.Add(Me.CopyButton)
        Me.OriginTheme2.Controls.Add(Me.TextBox2)
        Me.OriginTheme2.Controls.Add(Me.closebutton)
        Me.OriginTheme2.Controls.Add(Me.LoginButton)
        Me.OriginTheme2.Customization = "JiYn//////8="
        Me.OriginTheme2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginTheme2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OriginTheme2.Image = Nothing
        Me.OriginTheme2.Location = New System.Drawing.Point(0, 0)
        Me.OriginTheme2.Movable = True
        Me.OriginTheme2.Name = "OriginTheme2"
        Me.OriginTheme2.NoRounding = False
        Me.OriginTheme2.Sizable = True
        Me.OriginTheme2.Size = New System.Drawing.Size(284, 261)
        Me.OriginTheme2.SmartBounds = True
        Me.OriginTheme2.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.OriginTheme2.TabIndex = 1
        Me.OriginTheme2.Text = "OriginTheme2"
        Me.OriginTheme2.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme2.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "System Time:"
        '
        'systime
        '
        Me.systime.AutoSize = True
        Me.systime.Location = New System.Drawing.Point(142, 132)
        Me.systime.Name = "systime"
        Me.systime.Size = New System.Drawing.Size(69, 15)
        Me.systime.TabIndex = 6
        Me.systime.Text = "00:00:00 am"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SanityFramework.My.Resources.Resources.Sanityframwork
        Me.PictureBox1.Location = New System.Drawing.Point(14, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 77)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'CopyButton
        '
        Me.CopyButton.Customization = "AKX/////////////"
        Me.CopyButton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CopyButton.Image = Nothing
        Me.CopyButton.Location = New System.Drawing.Point(71, 178)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.NoRounding = False
        Me.CopyButton.Size = New System.Drawing.Size(148, 23)
        Me.CopyButton.TabIndex = 4
        Me.CopyButton.Text = "Copy HWID"
        Me.CopyButton.Transparent = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(40, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 23)
        Me.TextBox2.TabIndex = 3
        '
        'closebutton
        '
        Me.closebutton.Customization = "AKX/////////////"
        Me.closebutton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.closebutton.Image = Nothing
        Me.closebutton.Location = New System.Drawing.Point(167, 209)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.NoRounding = False
        Me.closebutton.Size = New System.Drawing.Size(105, 40)
        Me.closebutton.TabIndex = 2
        Me.closebutton.Text = "Close"
        Me.closebutton.Transparent = False
        '
        'LoginButton
        '
        Me.LoginButton.Customization = "AKX/////////////"
        Me.LoginButton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LoginButton.Image = Nothing
        Me.LoginButton.Location = New System.Drawing.Point(12, 209)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.NoRounding = False
        Me.LoginButton.Size = New System.Drawing.Size(105, 40)
        Me.LoginButton.TabIndex = 1
        Me.LoginButton.Text = "Login"
        Me.LoginButton.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.OriginTheme2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "SanityFramework"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme2.ResumeLayout(False)
        Me.OriginTheme2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OriginTheme1 As OriginTheme
    Friend WithEvents OriginButton2 As OriginButton
    Friend WithEvents OriginButton1 As OriginButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OriginButton3 As OriginButton
    Friend WithEvents OriginTheme2 As OriginTheme
    Friend WithEvents LoginButton As OriginButton
    Friend WithEvents closebutton As OriginButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CopyButton As OriginButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents systime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
