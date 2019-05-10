Imports System.IO
Imports System.Text



Public Class registerFrm

    'Variables for later use
    Dim password As String = Nothing
    Dim username As String = Nothing
    Dim email As String = Nothing
    Dim loginLineEnc As String = Nothing
    Dim ready_to_register As Boolean = False



    'Used for encrypting text
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


    'Used for decrypting text
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

    'Used for easially creating error messages
    Public Sub errorBox(msg As String, title As String)

        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'When form is closed show register form
    Private Sub registerFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        loginFrm.Show()
    End Sub


    'Until otherwise stated via comments this code will change the preview text inside the boxes



    'setting defult data
    Private Sub registerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'ensure the form is set up properly for user sign up.
        ready_to_register = False
        emailTxt.Text = "Enter email..."
        passwordTxt.Text = "Choose a password..."
        confirmTxt.Text = "Confirm password..."
        usrnameTxt.Text = "Choose an username..."

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        'Info is entered
        If (Trim(passwordTxt.Text) <> "") And (Trim(confirmTxt.Text) <> "") And (Trim(emailTxt.Text) <> "") And (Trim(usrnameTxt.Text) <> "") Then

            'Real info is entered
            If passwordTxt.Text <> "Choose a password..." And confirmTxt.Text <> "Confirm password..." And usrnameTxt.Text <> "Choose an username..." And emailTxt.Text <> "Enter email..." Then
                If passwordTxt.Text = confirmTxt.Text Then
                    'passwords match

                    If emailTxt.Text.Contains("@") Then
                        'valid email entered completly ready
                        ready_to_register = True
                    Else
                        errorBox("Enter a valid email and try again!", "Error")
                        Exit Sub
                    End If
                Else
                    errorBox("Check your passwords match and try again!", "Error")
                    Exit Sub
                End If
            Else
                'invalid credintals
                errorBox("Check your information and try again!", "Error")
                Exit Sub
            End If

        Else
            errorBox("Check your information and try again!", "Error")
            Exit Sub
        End If

        Dim count As Integer = 0

        If ready_to_register = True Then
            email = emailTxt.Text
            password = passwordTxt.Text
            username = usrnameTxt.Text
            Dim lineCOunt As Integer = Nothing


            'Encrypt Text
            loginLineEnc = Encrypt(username, "asdf") + "|" + Encrypt(password, "asdf") + "|" + Encrypt(email, "asdf" + Environment.NewLine)
            'Get UID based on lines in file

            If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\login.txt") Then
                'its there already
                lineCOunt = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\login.txt").Length


                Dim path As String = AppDomain.CurrentDomain.BaseDirectory + "\login.txt"

            Else
                'make it
                lineCOunt = 0
                Dim path As String = AppDomain.CurrentDomain.BaseDirectory + "\login.txt"
                Dim fs As FileStream = File.Create(path)
                fs.Close()
            End If

            loginLineEnc = (lineCOunt + 1).ToString + "|" + loginLineEnc
            Dim loginFile As System.IO.StreamWriter
            loginFile = My.Computer.FileSystem.OpenTextFileWriter(AppDomain.CurrentDomain.BaseDirectory + "\login.txt", True)
            loginFile.WriteLine(loginLineEnc)
            loginFile.Close()
            Me.Close()
            loginFrm.Show()



        End If
    End Sub

    Private Sub usrnameTxt_Enter(sender As Object, e As EventArgs) Handles usrnameTxt.Enter
        If usrnameTxt.Text = "Choose an username..." Then
            usrnameTxt.Text = ""
        End If
    End Sub

    Private Sub usrnameTxt_Leave(sender As Object, e As EventArgs) Handles usrnameTxt.Leave
        If usrnameTxt.Text = "" Then
            usrnameTxt.Text = "Choose an username..."
        End If
    End Sub

    Private Sub passwordTxt_Enter(sender As Object, e As EventArgs) Handles passwordTxt.Enter
        If passwordTxt.Text = "Choose a password..." Then
            passwordTxt.Text = ""
            passwordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordTxt_Leave(sender As Object, e As EventArgs) Handles passwordTxt.Leave
        If passwordTxt.Text = "" Then
            passwordTxt.Text = "Choose a password..."
            passwordTxt.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub confirmTxt_Enter(sender As Object, e As EventArgs) Handles confirmTxt.Enter
        If confirmTxt.Text = "Confirm password..." Then
            confirmTxt.Text = ""
            confirmTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub confirmTxt_Leave(sender As Object, e As EventArgs) Handles confirmTxt.Leave
        If confirmTxt.Text = "" Then
            confirmTxt.Text = "Confirm password..."
            confirmTxt.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub emailTxt_Enter(sender As Object, e As EventArgs) Handles emailTxt.Enter
        If emailTxt.Text = "Enter email..." Then
            emailTxt.Text = ""
        End If
    End Sub

    Private Sub emailTxt_Leave(sender As Object, e As EventArgs) Handles emailTxt.Leave
        If emailTxt.Text = "" Then
            emailTxt.Text = "Enter email..."
        End If
    End Sub
End Class