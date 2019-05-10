<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add))
        Me.FormSkin1 = New Password_Manager.FormSkin()
        Me.ElegantThemeTextBox1 = New Password_Manager.FlatTextBox()
        Me.ElegantThemeTextBox2 = New Password_Manager.FlatTextBox()
        Me.ElegantThemeTextBox3 = New Password_Manager.FlatTextBox()
        Me.ElegantThemeRichTextBox1 = New Password_Manager.FlatTextBox()
        Me.FlatButton1 = New Password_Manager.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ElegantThemeRichTextBox1)
        Me.FormSkin1.Controls.Add(Me.ElegantThemeTextBox3)
        Me.FormSkin1.Controls.Add(Me.ElegantThemeTextBox2)
        Me.FormSkin1.Controls.Add(Me.ElegantThemeTextBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Blue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(302, 319)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Add A Login"
        '
        'ElegantThemeTextBox1
        '
        Me.ElegantThemeTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox1.Location = New System.Drawing.Point(12, 62)
        Me.ElegantThemeTextBox1.MaxLength = 32767
        Me.ElegantThemeTextBox1.Multiline = False
        Me.ElegantThemeTextBox1.Name = "ElegantThemeTextBox1"
        Me.ElegantThemeTextBox1.ReadOnly = False
        Me.ElegantThemeTextBox1.Size = New System.Drawing.Size(278, 29)
        Me.ElegantThemeTextBox1.TabIndex = 0
        Me.ElegantThemeTextBox1.Text = "Website Name..."
        Me.ElegantThemeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox1.UseSystemPasswordChar = False
        '
        'ElegantThemeTextBox2
        '
        Me.ElegantThemeTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox2.Location = New System.Drawing.Point(12, 97)
        Me.ElegantThemeTextBox2.MaxLength = 32767
        Me.ElegantThemeTextBox2.Multiline = False
        Me.ElegantThemeTextBox2.Name = "ElegantThemeTextBox2"
        Me.ElegantThemeTextBox2.ReadOnly = False
        Me.ElegantThemeTextBox2.Size = New System.Drawing.Size(278, 29)
        Me.ElegantThemeTextBox2.TabIndex = 1
        Me.ElegantThemeTextBox2.Text = "Email/Username..."
        Me.ElegantThemeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox2.UseSystemPasswordChar = False
        '
        'ElegantThemeTextBox3
        '
        Me.ElegantThemeTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox3.Location = New System.Drawing.Point(12, 132)
        Me.ElegantThemeTextBox3.MaxLength = 32767
        Me.ElegantThemeTextBox3.Multiline = False
        Me.ElegantThemeTextBox3.Name = "ElegantThemeTextBox3"
        Me.ElegantThemeTextBox3.ReadOnly = False
        Me.ElegantThemeTextBox3.Size = New System.Drawing.Size(278, 29)
        Me.ElegantThemeTextBox3.TabIndex = 2
        Me.ElegantThemeTextBox3.Text = "Password..."
        Me.ElegantThemeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeTextBox3.UseSystemPasswordChar = False
        '
        'ElegantThemeRichTextBox1
        '
        Me.ElegantThemeRichTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeRichTextBox1.Location = New System.Drawing.Point(12, 167)
        Me.ElegantThemeRichTextBox1.MaxLength = 32767
        Me.ElegantThemeRichTextBox1.Multiline = True
        Me.ElegantThemeRichTextBox1.Name = "ElegantThemeRichTextBox1"
        Me.ElegantThemeRichTextBox1.ReadOnly = False
        Me.ElegantThemeRichTextBox1.Size = New System.Drawing.Size(278, 104)
        Me.ElegantThemeRichTextBox1.TabIndex = 3
        Me.ElegantThemeRichTextBox1.Text = "Other Text..."
        Me.ElegantThemeRichTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeRichTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ElegantThemeRichTextBox1.UseSystemPasswordChar = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Blue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 277)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(278, 32)
        Me.FlatButton1.TabIndex = 4
        Me.FlatButton1.Text = "Add Login"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 319)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents ElegantThemeRichTextBox1 As FlatTextBox
    Friend WithEvents ElegantThemeTextBox3 As FlatTextBox
    Friend WithEvents ElegantThemeTextBox2 As FlatTextBox
    Friend WithEvents ElegantThemeTextBox1 As FlatTextBox
End Class
