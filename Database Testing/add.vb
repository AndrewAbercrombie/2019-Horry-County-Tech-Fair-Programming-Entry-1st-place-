Public Class add

    'usedf for encrypting text
    Public Function Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AESenc As New System.Security.Cryptography.RijndaelManaged
        Dim hash1 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim final As String = ""
        Try
            Dim hash(31) As Byte
            Dim x As Byte() = hash1.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(x, 0, hash, 0, 16)
            Array.Copy(x, 0, hash, 15, 16)
            AESenc.Key = hash
            AESenc.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESModule As System.Security.Cryptography.ICryptoTransform = AESenc.CreateEncryptor
            Dim bufferInfo As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            final = Convert.ToBase64String(DESModule.TransformFinalBlock(bufferInfo, 0, bufferInfo.Length))
            Return final
        Catch ex As Exception
        End Try
    End Function

    'Until otherwise stated via comments this code will change the preview text inside the boxes
    Private Sub ElegantThemeTextBox1_Enter(sender As Object, e As EventArgs)
        If ElegantThemeTextBox1.Text = "Website Name..." Then
            ElegantThemeTextBox1.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox1_Leave(sender As Object, e As EventArgs)
        If ElegantThemeTextBox1.Text = "" Then
            ElegantThemeTextBox1.Text = "Website Name..."
        End If
    End Sub

    Private Sub ElegantThemeTextBox2_Enter(sender As Object, e As EventArgs)
        If ElegantThemeTextBox2.Text = "Email/Username..." Then
            ElegantThemeTextBox2.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox2_Leave(sender As Object, e As EventArgs)
        If ElegantThemeTextBox2.Text = "" Then
            ElegantThemeTextBox2.Text = "Email/Username..."
        End If
    End Sub

    Private Sub ElegantThemeTextBox3_Enter(sender As Object, e As EventArgs)
        If ElegantThemeTextBox3.Text = "Password..." Then
            ElegantThemeTextBox3.UseSystemPasswordChar = True
            ElegantThemeTextBox3.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox3_Leave(sender As Object, e As EventArgs)
        If ElegantThemeTextBox3.Text = "" Then
            ElegantThemeTextBox3.UseSystemPasswordChar = False
            ElegantThemeTextBox3.Text = "Password..."
        End If
    End Sub

    Private Sub ElegantThemeRichTextBox1_Enter(sender As Object, e As EventArgs)
        If ElegantThemeRichTextBox1.Text = "Other Text..." Then
            ElegantThemeRichTextBox1.Text = ""

        End If
    End Sub

    Private Sub ElegantThemeRichTextBox1_Leave(sender As Object, e As EventArgs)
        If ElegantThemeRichTextBox1.Text = "" Then
            ElegantThemeRichTextBox1.Text = "Other Text..."
        End If
    End Sub

    'Add account to view.
    Private Sub ElegantThemeButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        'Ensure this account hasnt already been added.
        For Each c As String In mainF.listitems.Lines
            If c.ToLower = Me.ElegantThemeTextBox1.Text Then
                Exit Sub
            End If
        Next

        'Ensure that the user filled each box 
        If ElegantThemeTextBox1.Text <> "" And ElegantThemeTextBox2.Text <> "" And ElegantThemeTextBox3.Text <> "" Then

            'Create variables for later use
            Dim encName As String = Nothing
            Dim encUser As String = Nothing
            Dim encPass As String = Nothing
            Dim otherText As String = Nothing




            'If the user typed nothing for other text
            If Trim(ElegantThemeRichTextBox1.Text = "Other Text...") Then

                Try
                    'Ecmrypt all the data
                    encName = Encrypt(ElegantThemeTextBox1.Text, "ASDFGHJKL")
                    encUser = Encrypt(ElegantThemeTextBox2.Text, "ASDFGHJKL")
                    encPass = Encrypt(ElegantThemeTextBox3.Text, "ASDFGHJKL")
                    otherText = "None!"
                Catch ex As Exception

                End Try
                'User utilized the other text option
            Else
                Try
                    'Encrypt all the data
                    encName = Encrypt(ElegantThemeTextBox1.Text, "ASDFGHJKL")
                    encUser = Encrypt(ElegantThemeTextBox2.Text, "ASDFGHJKL")
                    encPass = Encrypt(ElegantThemeTextBox3.Text, "ASDFGHJKL")
                    otherText = Encrypt(ElegantThemeRichTextBox1.Text, "ASDFGHJKL")
                Catch ex As Exception

                End Try

            End If

            'Clear the list for later use
            mainF.listitems.Clear()

            'This will be the new line added to the hidden list on the mainform
            Dim final As String = encName + "|" + encUser + "|" + encPass + "|" + otherText

            'Add the line to the login file
            Dim loginFile As System.IO.StreamWriter
            loginFile = My.Computer.FileSystem.OpenTextFileWriter(mainF.pwPath.Text, True)
            loginFile.WriteLine(final)
            loginFile.Close()

            'Clear the listbox for later use
            mainF.ElegantThemeListBox1.Items.Clear()

            'reaload all the passwords
            mainF.loadPasswords()
            'close the form and reset all the texboxes to defult text.
            Me.Close()
            ElegantThemeTextBox1.Text = "Website Name..."
            ElegantThemeTextBox2.Text = "Email/Username..."
            ElegantThemeTextBox3.Text = "Password..."
            ElegantThemeRichTextBox1.Text = "Other Text..."

        End If
    End Sub

    Private Sub ElegantThemeTextBox1_Enter_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox1.Enter
        If ElegantThemeTextBox1.Text = "Website Name..." Then
            ElegantThemeTextBox1.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox1_Leave_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox1.Leave
        If ElegantThemeTextBox1.Text = "" Then
            ElegantThemeTextBox1.Text = "Website Name..."
        End If
    End Sub

    Private Sub ElegantThemeTextBox2_Enter_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox2.Enter
        If ElegantThemeTextBox2.Text = "Email/Username..." Then
            ElegantThemeTextBox2.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox2_Leave_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox2.Leave
        If ElegantThemeTextBox2.Text = "" Then
            ElegantThemeTextBox2.Text = "Email/Username..."
        End If
    End Sub

    Private Sub ElegantThemeTextBox3_Enter_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox3.Enter
        If ElegantThemeTextBox3.Text = "Password..." Then
            ElegantThemeTextBox3.UseSystemPasswordChar = True
            ElegantThemeTextBox3.Text = ""
        End If
    End Sub

    Private Sub ElegantThemeTextBox3_Leave_1(sender As Object, e As EventArgs) Handles ElegantThemeTextBox3.Leave
        If ElegantThemeTextBox3.Text = "" Then
            ElegantThemeTextBox3.UseSystemPasswordChar = False
            ElegantThemeTextBox3.Text = "Password..."
        End If
    End Sub

    Private Sub ElegantThemeRichTextBox1_Enter_1(sender As Object, e As EventArgs) Handles ElegantThemeRichTextBox1.Enter
        If ElegantThemeRichTextBox1.Text = "Other Text..." Then
            ElegantThemeRichTextBox1.Text = ""

        End If
    End Sub

    Private Sub ElegantThemeRichTextBox1_Leave_1(sender As Object, e As EventArgs) Handles ElegantThemeRichTextBox1.Leave
        If ElegantThemeRichTextBox1.Text = "" Then
            ElegantThemeRichTextBox1.Text = "Other Text..."
        End If
    End Sub
End Class