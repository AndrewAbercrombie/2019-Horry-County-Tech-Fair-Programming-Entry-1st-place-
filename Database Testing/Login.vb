Class loginFrm

    'This variable will check if the user has logged in
    Dim loggedIn As Boolean = False

    'Used for easially showing messages
    Public Sub errorBox(msg As String, title As String)

        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Used  for encrypting text
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

    'Used for decyrpting text
    Public Function Decrypt(ByVal input As String, ByVal pass As String) As String
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
            Dim DecyptModule As System.Security.Cryptography.ICryptoTransform = AESenc.CreateDecryptor
            Dim bufferInfo As Byte() = Convert.FromBase64String(input)
            final = System.Text.ASCIIEncoding.ASCII.GetString(DecyptModule.TransformFinalBlock(bufferInfo, 0, bufferInfo.Length))
            Return final
        Catch ex As Exception
        End Try
    End Function





    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        'ensure the file exists
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\login.txt") Then

            'Read the login infmation
            Dim fileReader As String
            RichTextBox1.Clear()
            fileReader = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\login.txt")



            RichTextBox1.Text = fileReader


            'Loop through login lines to check for the correct login
            For Each encLine As String In RichTextBox1.Lines


                'Varibales for later use
                Dim decUser As String = Nothing
                Dim decPass As String = Nothing
                Dim decID As String = Nothing

                Try

                    'Attmept to split the line over a | to check just the username
                    Dim encLineSpl() As String = encLine.Split("|")

                    'Decrypt the username ID and password
                    decID = encLineSpl(0)
                    decUser = Decrypt(encLineSpl(1), "asdf")
                    decPass = Decrypt(encLineSpl(2), "asdf")


                Catch ex As Exception

                End Try

                'Ensuye the username and pass arent blank
                If Trim(decUser) <> "" And Trim(decPass) <> "" Then

                    'Check if the username matches
                    If decUser = usrnameTxt.Text Then

                        'Check if the password matches
                        If decPass = passwordTxt.Text Then


                            'User logged in!
                            loggedIn = True

                            'pass the ID, username and password to the main form for later use
                            mainF.ID.Text = decID
                            mainF.USERNAME.Text = decUser
                            mainF.PASSWORD.Text = decPass

                            'Show the main form and hide the login form.
                            mainF.Show()
                            Me.Hide()






                            Exit Sub
                        Else
                            'incorrect password
                            loggedIn = False
                        End If
                    Else

                        'incorect username
                        loggedIn = False
                    End If
                End If



            Next

            'Display error bc improper login info
            If loggedIn = False Then
                errorBox("Invalid credidentaisl please try again!", "Error")

            End If

        End If

    End Sub

    Private Sub usrnameTxt_Leave(sender As Object, e As EventArgs) Handles usrnameTxt.Leave
        If usrnameTxt.Text = "" Then
            usrnameTxt.Text = "Enter username here..."
        End If
    End Sub

    Private Sub usrnameTxt_Enter(sender As Object, e As EventArgs) Handles usrnameTxt.Enter
        If usrnameTxt.Text = "Enter username here..." Then
            usrnameTxt.Text = ""
        End If
    End Sub

    Private Sub passwordTxt_Enter(sender As Object, e As EventArgs) Handles passwordTxt.Enter
        If passwordTxt.Text = "Enter password here..." Then
            passwordTxt.Text = ""
            passwordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordTxt_Leave(sender As Object, e As EventArgs) Handles passwordTxt.Leave
        If passwordTxt.Text = "" Then
            passwordTxt.UseSystemPasswordChar = False
            passwordTxt.Text = "Enter password here..."
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        'hide this form and show the register form
        Me.Hide()
        registerFrm.ShowDialog()
    End Sub
End Class

