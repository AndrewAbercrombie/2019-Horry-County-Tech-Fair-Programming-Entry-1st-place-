<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerFrm))
        Me.FormSkin1 = New Password_Manager.FormSkin()
        Me.emailTxt = New Password_Manager.FlatTextBox()
        Me.FlatButton1 = New Password_Manager.FlatButton()
        Me.usrnameTxt = New Password_Manager.FlatTextBox()
        Me.confirmTxt = New Password_Manager.FlatTextBox()
        Me.passwordTxt = New Password_Manager.FlatTextBox()
        Me.FlatClose1 = New Password_Manager.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.emailTxt)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.usrnameTxt)
        Me.FormSkin1.Controls.Add(Me.confirmTxt)
        Me.FormSkin1.Controls.Add(Me.passwordTxt)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Blue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(299, 263)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Register"
        '
        'emailTxt
        '
        Me.emailTxt.BackColor = System.Drawing.Color.Transparent
        Me.emailTxt.Location = New System.Drawing.Point(12, 172)
        Me.emailTxt.MaxLength = 32767
        Me.emailTxt.Multiline = False
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.ReadOnly = False
        Me.emailTxt.Size = New System.Drawing.Size(276, 29)
        Me.emailTxt.TabIndex = 4
        Me.emailTxt.Text = "Enter Email"
        Me.emailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.emailTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.emailTxt.UseSystemPasswordChar = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 216)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(276, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "Register"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'usrnameTxt
        '
        Me.usrnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.usrnameTxt.Location = New System.Drawing.Point(12, 67)
        Me.usrnameTxt.MaxLength = 32767
        Me.usrnameTxt.Multiline = False
        Me.usrnameTxt.Name = "usrnameTxt"
        Me.usrnameTxt.ReadOnly = False
        Me.usrnameTxt.Size = New System.Drawing.Size(276, 29)
        Me.usrnameTxt.TabIndex = 2
        Me.usrnameTxt.Text = "Choose an username..."
        Me.usrnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usrnameTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usrnameTxt.UseSystemPasswordChar = False
        '
        'confirmTxt
        '
        Me.confirmTxt.BackColor = System.Drawing.Color.Transparent
        Me.confirmTxt.Location = New System.Drawing.Point(12, 137)
        Me.confirmTxt.MaxLength = 32767
        Me.confirmTxt.Multiline = False
        Me.confirmTxt.Name = "confirmTxt"
        Me.confirmTxt.ReadOnly = False
        Me.confirmTxt.Size = New System.Drawing.Size(276, 29)
        Me.confirmTxt.TabIndex = 1
        Me.confirmTxt.Text = "Confirm password..."
        Me.confirmTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.confirmTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.confirmTxt.UseSystemPasswordChar = False
        '
        'passwordTxt
        '
        Me.passwordTxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordTxt.Location = New System.Drawing.Point(12, 102)
        Me.passwordTxt.MaxLength = 32767
        Me.passwordTxt.Multiline = False
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.ReadOnly = False
        Me.passwordTxt.Size = New System.Drawing.Size(276, 29)
        Me.passwordTxt.TabIndex = 0
        Me.passwordTxt.Text = "Choose a password..."
        Me.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.passwordTxt.UseSystemPasswordChar = False
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(278, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'registerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 263)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(299, 263)
        Me.MinimumSize = New System.Drawing.Size(299, 263)
        Me.Name = "registerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents emailTxt As FlatTextBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents usrnameTxt As FlatTextBox
    Friend WithEvents confirmTxt As FlatTextBox
    Friend WithEvents passwordTxt As FlatTextBox
    Friend WithEvents FlatClose1 As FlatClose
End Class
