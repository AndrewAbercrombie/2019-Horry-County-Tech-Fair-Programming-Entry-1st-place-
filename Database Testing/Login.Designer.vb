<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginFrm))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FormSkin1 = New Password_Manager.FormSkin()
        Me.Divider1 = New Password_Manager.Divider()
        Me.FlatButton2 = New Password_Manager.FlatButton()
        Me.FlatButton1 = New Password_Manager.FlatButton()
        Me.passwordTxt = New Password_Manager.FlatTextBox()
        Me.usrnameTxt = New Password_Manager.FlatTextBox()
        Me.FlatClose2 = New Password_Manager.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(467, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(659, 251)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose2)
        Me.FormSkin1.Controls.Add(Me.Divider1)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.passwordTxt)
        Me.FormSkin1.Controls.Add(Me.usrnameTxt)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Blue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(294, 315)
        Me.FormSkin1.TabIndex = 8
        Me.FormSkin1.Text = "Login"
        '
        'Divider1
        '
        Me.Divider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Divider1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Divider1.Location = New System.Drawing.Point(3, 234)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(288, 23)
        Me.Divider1.TabIndex = 15
        Me.Divider1.Text = "Divider1"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(12, 263)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(271, 32)
        Me.FlatButton2.TabIndex = 14
        Me.FlatButton2.Text = "Register"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(11, 166)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(271, 32)
        Me.FlatButton1.TabIndex = 13
        Me.FlatButton1.Text = "Login"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'passwordTxt
        '
        Me.passwordTxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordTxt.Location = New System.Drawing.Point(12, 107)
        Me.passwordTxt.MaxLength = 32767
        Me.passwordTxt.Multiline = False
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.ReadOnly = False
        Me.passwordTxt.Size = New System.Drawing.Size(271, 29)
        Me.passwordTxt.TabIndex = 12
        Me.passwordTxt.Text = "Enter password here..."
        Me.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.passwordTxt.UseSystemPasswordChar = False
        '
        'usrnameTxt
        '
        Me.usrnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.usrnameTxt.Location = New System.Drawing.Point(11, 60)
        Me.usrnameTxt.MaxLength = 32767
        Me.usrnameTxt.Multiline = False
        Me.usrnameTxt.Name = "usrnameTxt"
        Me.usrnameTxt.ReadOnly = False
        Me.usrnameTxt.Size = New System.Drawing.Size(271, 29)
        Me.usrnameTxt.TabIndex = 11
        Me.usrnameTxt.Text = "Enter username here..."
        Me.usrnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usrnameTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usrnameTxt.UseSystemPasswordChar = False
        '
        'FlatClose2
        '
        Me.FlatClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose2.BackColor = System.Drawing.Color.White
        Me.FlatClose2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose2.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose2.Location = New System.Drawing.Point(273, 3)
        Me.FlatClose2.Name = "FlatClose2"
        Me.FlatClose2.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose2.TabIndex = 17
        Me.FlatClose2.Text = "\"
        Me.FlatClose2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'loginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(294, 315)
        Me.Controls.Add(Me.FormSkin1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents Divider1 As Divider
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents passwordTxt As FlatTextBox
    Friend WithEvents usrnameTxt As FlatTextBox
    Friend WithEvents FlatClose2 As FlatClose
End Class
