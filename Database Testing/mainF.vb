Public Class mainF

    'Global variables for later use
    Dim globalUserName As String = Nothing
    Dim globalPassword As String = Nothing
    Dim globalID As String = Nothing
    Dim websiteEnc As String = Nothing
    Dim emailEnc As String = Nothing
    Dim passwordEnc As String = Nothing
    Dim otherInfoEnc As String = Nothing


    'Encrypt function for encrypting all data
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


    'Decrypt function for decrypting all data
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




    'used for loading the passwords into the software properly
    Public Sub loadPasswords()
        'Clear the richtextbox for later use
        RichTextBox1.Clear()

        'Check if a user has ever saved a password by checking if there directory exist.
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt") Then

            'Load the passwords 
            RichTextBox1.Text = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt")

            'Loop through each line 
            For Each encLine As String In RichTextBox1.Lines

                'split each line over the delimiter (|)
                Dim encLineSpl() As String = encLine.Split("|")

                'clear the listbox so we can re add each item into the listbox
                ElegantThemeListBox1.Items.Clear()

                Try
                    'Ensuring the line isnt blank
                    If (encLineSpl(0) <> "") And (encLineSpl(1) <> "") And (encLineSpl(2) <> "") And (encLineSpl(3) <> "") Then
                        'store each part of the line as a variable
                        websiteEnc = encLineSpl(0)
                        emailEnc = encLineSpl(1)
                        passwordEnc = encLineSpl(2)
                        otherInfoEnc = encLineSpl(3)
                        'Decrypt and add each item to the richtextbox for later use
                        Me.listitems.Text = listitems.Text + Decrypt(websiteEnc, "ASDFGHJKL") + vbNewLine
                    End If

                Catch ex As Exception
                End Try
            Next
            'add items into the lsitbox from the richtextbox
            For Each x As String In listitems.Lines
                ElegantThemeListBox1.Items.Add(x)
            Next

        Else
            'Create the directory for the logged in user
            My.Computer.FileSystem.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text)
            Dim path As String = AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt"
            Dim fs As System.IO.FileStream = System.IO.File.Create(path)
            fs.Close()
        End If
    End Sub


    'Ensure the form is set up for use
    Private Sub main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        'Get directory for user passwords.
        pwPath.Text = AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt"

        'load the passwords into the software
        loadPasswords()

        'Change form title
        Me.FormSkin1.Text = "Password Manager - Logged in as: " + USERNAME.Text

    End Sub


    'Ensure form closes properly so that next login will be good
    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'Show the login form so the next user can login
        loginFrm.Show()

        'Clear all textbox's so next login is ready 
        loginFrm.passwordTxt.Text = ""
        loginFrm.usrnameTxt.Text = ""
        listitems.Clear()
        ElegantThemeListBox1.Items.Clear()
        RichTextBox1.Clear()
        ElegantThemeTextBox2.Text = ""

        'Reset defult value for this checkbox
        FlatToggle1.Checked = False

    End Sub








    Private Sub FlatToggle1_CheckedChanged(sender As Object) Handles FlatToggle1.CheckedChanged
        If Me.FlatToggle1.Checked Then
            ElegantThemeTextBox3.UseSystemPasswordChar = False
        Else
            ElegantThemeTextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        'show the add login screen
        add.ShowDialog()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        'Reset values for proper use
        Dim notDeletedLines2 As String = ""
        Dim NotDeletedLines As String = ""

        'get the login were going to delte
        Dim lineToDelete As String = ElegantThemeListBox1.SelectedItem


        'loop through logins and find the proper one
        For Each RichWebName As String In listitems.Lines
            If RichWebName = lineToDelete Then
                'do nothing
            Else

                'These are the values we need to KEEP
                NotDeletedLines = NotDeletedLines + RichWebName + vbNewLine

            End If
        Next

        'Clear this so we can put in the values were keeping
        listitems.Clear()

        'Reenter the values to keep
        listitems.Text = NotDeletedLines

        'Clear the listbox
        Me.ElegantThemeListBox1.Items.Clear()


        'Loop through lines and search for the proper one
        For Each lineEnc As String In Me.RichTextBox1.Lines
            Dim lineSpl() As String = lineEnc.Split("|")


            If Trim(lineSpl(0) <> "") Then

                Dim websiteEnc As String = Encrypt(lineToDelete, "ASDFGHJKL")

                'Ensure this is the correct login
                If websiteEnc = lineSpl(0) Then
                    'do nothing
                Else
                    'Keep this value for later use
                    notDeletedLines2 = notDeletedLines2 + lineEnc + vbNewLine

                End If
            End If
        Next

        'Clear this so we can re add the proper sites left
        RichTextBox1.Clear()

        'add the sites left
        RichTextBox1.Text = notDeletedLines2

        'Path for the info document
        Dim pathaa As String = AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt"

        'Delete the file so we can recreate it with the proper information
        My.Computer.FileSystem.DeleteFile(pathaa)

        'recreate the file 
        My.Computer.FileSystem.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text)
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory + "login\" + ID.Text + "\info.txt"
        Dim fs As System.IO.FileStream = System.IO.File.Create(path)

        'Close the filestream to stop memmory leaks
        fs.Close()

        'Write the infomation to the file
        Dim loginFile As System.IO.StreamWriter
        loginFile = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        loginFile.WriteLine(RichTextBox1.Text)

        'Again avoiding memory leaks
        loginFile.Close()

        'Clear this for later use
        listitems.Clear()

        'Call load passwords to reload passwords into the listbox and listitems richtextbox
        loadPasswords()
    End Sub



    Private Sub ElegantThemeListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElegantThemeListBox1.SelectedIndexChanged
        'Get the account were looking for
        Dim itemToDisplay As String = Encrypt(ElegantThemeListBox1.SelectedItem, "ASDFGHJKL")

        'Loop through them to match it to what was selected
        For Each x As String In RichTextBox1.Lines

            'split the line over the delimter
            Dim xSpl() As String = x.Split("|")


            'Match the splitted portion to the selected item
            If itemToDisplay = xSpl(0) Then
                Try
                    'Right item therefor display the information
                    ElegantThemeTextBox2.Text = Decrypt(xSpl(1), "ASDFGHJKL")
                    ElegantThemeTextBox3.Text = Decrypt(xSpl(2), "ASDFGHJKL")
                    ElegantThemeTextBox4.Text = Decrypt(xSpl(3), "ASDFGHJKL")
                Catch


                End Try

            End If
        Next
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click


    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        'Show the login form so the next user can login
        loginFrm.Show()

        'Clear all textbox's so next login is ready 
        loginFrm.passwordTxt.Text = ""
        loginFrm.usrnameTxt.Text = ""
        listitems.Clear()
        ElegantThemeListBox1.Items.Clear()
        RichTextBox1.Clear()
        ElegantThemeTextBox2.Text = ""

        'Reset defult value for this checkbox
        Me.FlatToggle1.Checked = False
        Me.Close()
        loginFrm.Show()
        Exit Sub
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class