<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainF))
        Me.ID = New System.Windows.Forms.TextBox()
        Me.USERNAME = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pwPath = New System.Windows.Forms.TextBox()
        Me.listitems = New System.Windows.Forms.RichTextBox()
        Me.FormSkin1 = New Password_Manager.FormSkin()
        Me.FlatClose1 = New Password_Manager.FlatClose()
        Me.FlatTabControl1 = New Password_Manager.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ElegantThemeListBox1 = New System.Windows.Forms.ListBox()
        Me.FlatGroupBox1 = New Password_Manager.FlatGroupBox()
        Me.FlatButton3 = New Password_Manager.FlatButton()
        Me.FlatLabel1 = New Password_Manager.FlatLabel()
        Me.FlatToggle1 = New Password_Manager.FlatToggle()
        Me.ElegantThemeTextBox4 = New Password_Manager.FlatTextBox()
        Me.ElegantThemeTextBox3 = New Password_Manager.FlatTextBox()
        Me.ElegantThemeTextBox2 = New Password_Manager.FlatTextBox()
        Me.FlatButton2 = New Password_Manager.FlatButton()
        Me.FlatButton1 = New Password_Manager.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(783, 36)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(100, 20)
        Me.ID.TabIndex = 4
        '
        'USERNAME
        '
        Me.USERNAME.Location = New System.Drawing.Point(783, 83)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.ReadOnly = True
        Me.USERNAME.Size = New System.Drawing.Size(100, 20)
        Me.USERNAME.TabIndex = 5
        '
        'PASSWORD
        '
        Me.PASSWORD.Location = New System.Drawing.Point(783, 138)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.ReadOnly = True
        Me.PASSWORD.Size = New System.Drawing.Size(100, 20)
        Me.PASSWORD.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(766, 93)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(4000, 96)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'pwPath
        '
        Me.pwPath.Location = New System.Drawing.Point(946, 155)
        Me.pwPath.Name = "pwPath"
        Me.pwPath.ReadOnly = True
        Me.pwPath.Size = New System.Drawing.Size(100, 20)
        Me.pwPath.TabIndex = 8
        '
        'listitems
        '
        Me.listitems.Location = New System.Drawing.Point(766, 230)
        Me.listitems.Name = "listitems"
        Me.listitems.Size = New System.Drawing.Size(4000, 96)
        Me.listitems.TabIndex = 9
        Me.listitems.Text = ""
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Blue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(504, 439)
        Me.FormSkin1.TabIndex = 10
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(483, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 1
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.Blue
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(12, 66)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(482, 361)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ElegantThemeListBox1)
        Me.TabPage1.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage1.Controls.Add(Me.FlatButton2)
        Me.TabPage1.Controls.Add(Me.FlatButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(474, 313)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Password Manager"
        '
        'ElegantThemeListBox1
        '
        Me.ElegantThemeListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ElegantThemeListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ElegantThemeListBox1.ForeColor = System.Drawing.Color.Silver
        Me.ElegantThemeListBox1.FormattingEnabled = True
        Me.ElegantThemeListBox1.ItemHeight = 17
        Me.ElegantThemeListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ElegantThemeListBox1.Name = "ElegantThemeListBox1"
        Me.ElegantThemeListBox1.Size = New System.Drawing.Size(207, 255)
        Me.ElegantThemeListBox1.TabIndex = 6
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatToggle1)
        Me.FlatGroupBox1.Controls.Add(Me.ElegantThemeTextBox4)
        Me.FlatGroupBox1.Controls.Add(Me.ElegantThemeTextBox3)
        Me.FlatGroupBox1.Controls.Add(Me.ElegantThemeTextBox2)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(218, 6)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(263, 292)
        Me.FlatGroupBox1.TabIndex = 3
        Me.FlatGroupBox1.Text = "Website Information"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(139, 259)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(104, 30)
        Me.FlatButton3.TabIndex = 7
        Me.FlatButton3.Text = "Logout"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(23, 119)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(115, 19)
        Me.FlatLabel1.TabIndex = 5
        Me.FlatLabel1.Text = "Show Password  :"
        '
        'FlatToggle1
        '
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = False
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(156, 112)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = Password_Manager.FlatToggle._Options.Style1
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 4
        Me.FlatToggle1.Text = "FlatToggle1"
        '
        'ElegantThemeTextBox4
        '
        Me.ElegantThemeTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox4.Location = New System.Drawing.Point(20, 151)
        Me.ElegantThemeTextBox4.MaxLength = 32767
        Me.ElegantThemeTextBox4.Multiline = True
        Me.ElegantThemeTextBox4.Name = "ElegantThemeTextBox4"
        Me.ElegantThemeTextBox4.ReadOnly = True
        Me.ElegantThemeTextBox4.Size = New System.Drawing.Size(223, 104)
        Me.ElegantThemeTextBox4.TabIndex = 3
        Me.ElegantThemeTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox4.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox4.UseSystemPasswordChar = False
        '
        'ElegantThemeTextBox3
        '
        Me.ElegantThemeTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox3.Location = New System.Drawing.Point(20, 77)
        Me.ElegantThemeTextBox3.MaxLength = 32767
        Me.ElegantThemeTextBox3.Multiline = False
        Me.ElegantThemeTextBox3.Name = "ElegantThemeTextBox3"
        Me.ElegantThemeTextBox3.ReadOnly = True
        Me.ElegantThemeTextBox3.Size = New System.Drawing.Size(223, 29)
        Me.ElegantThemeTextBox3.TabIndex = 1
        Me.ElegantThemeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox3.UseSystemPasswordChar = True
        '
        'ElegantThemeTextBox2
        '
        Me.ElegantThemeTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox2.Location = New System.Drawing.Point(20, 42)
        Me.ElegantThemeTextBox2.MaxLength = 32767
        Me.ElegantThemeTextBox2.Multiline = False
        Me.ElegantThemeTextBox2.Name = "ElegantThemeTextBox2"
        Me.ElegantThemeTextBox2.ReadOnly = True
        Me.ElegantThemeTextBox2.Size = New System.Drawing.Size(223, 29)
        Me.ElegantThemeTextBox2.TabIndex = 0
        Me.ElegantThemeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox2.UseSystemPasswordChar = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(147, 268)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(30, 30)
        Me.FlatButton2.TabIndex = 2
        Me.FlatButton2.Text = "-"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(183, 268)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(30, 30)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "+"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'mainF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 439)
        Me.Controls.Add(Me.FormSkin1)
        Me.Controls.Add(Me.listitems)
        Me.Controls.Add(Me.pwPath)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.Controls.Add(Me.ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainF"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Manager - Logged In"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As TextBox
    Friend WithEvents USERNAME As TextBox
    Friend WithEvents PASSWORD As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents pwPath As TextBox
    Friend WithEvents listitems As RichTextBox
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatToggle1 As FlatToggle
    Friend WithEvents ElegantThemeTextBox4 As FlatTextBox
    Friend WithEvents ElegantThemeTextBox3 As FlatTextBox
    Friend WithEvents ElegantThemeTextBox2 As FlatTextBox
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents ElegantThemeListBox1 As ListBox
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatButton3 As FlatButton
End Class
