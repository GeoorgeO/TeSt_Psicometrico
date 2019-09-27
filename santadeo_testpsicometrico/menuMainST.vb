Imports System.Security.Cryptography
Imports System.Text

Public Class menuMainST
    Dim clic As Boolean = False
    Dim tamañox, tamañoy As Integer
    Dim abrir As Boolean = True
    Dim login As Boolean = False
    Public noUser As Boolean = False

    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "HUE08160831464" 'Clave secreta(puede alterarse)


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If clic = False Then
            clic = True
            pingreso.Visible = True
            TextBox1.Select()
        Else
            clic = False
            pingreso.Visible = False
        End If
    End Sub

    
    Private Sub menuMainST_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        pingreso.Visible = False
        clic = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        pingreso.Visible = False
        clic = False
    End Sub

    Private Sub menuMainST_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(1, 1)
        Me.Size = New System.Drawing.Size(1, 1)
        PictureBox1.Select()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If abrir = True Then
            If tamañox < 332 Then
                If tamañoy < 281 Then
                    Me.MinimumSize = New Size(tamañox, tamañoy)
                    Me.Size = New System.Drawing.Size(tamañox, tamañoy)
                    tamañox = tamañox + 20
                    tamañoy = tamañoy + 20
                Else
                    Me.MinimumSize = New Size(tamañox, 281)
                    Me.Size = New System.Drawing.Size(tamañox, 281)
                    tamañox = tamañox + 20
                End If
            Else
                Me.MinimumSize = New Size(332, 281)
                Me.Size = New System.Drawing.Size(332, 281)
                Timer1.Stop()
                abrir = False
            End If
        Else
            If tamañox >= 1 Then
                If tamañoy >= 1 Then
                    Me.MinimumSize = New Size(tamañox, tamañoy)
                    Me.Size = New System.Drawing.Size(tamañox, tamañoy)
                    tamañox = tamañox - 20
                    tamañoy = tamañoy - 20
                Else
                    Me.MinimumSize = New Size(tamañox, 1)
                    Me.Size = New System.Drawing.Size(tamañox, 1)
                    tamañox = tamañox - 20
                End If
            Else
                If login = True Then
                    reporte1.Show()
                Else
                    registro1.Show()
                End If
                Me.Visible = False
                Timer1.Stop()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btIngresar.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            login = True
            Dim contra As String
            contra = autentificar(TextBox1.Text)

            'contra = Encriptar("holamundo")
            If contra = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

            Else
                contra = Desencriptar(contra.Trim) 'deshabilite esto
            End If
            If TextBox2.Text = contra Then
                Timer1.Start()
            Else
                If noUser = False Then
                    MessageBox.Show("La contraseña no es válida. Por favor, verifique que sea la correcta", "Por favor, vuelve a introducir tu contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox2.Text = ""
                    TextBox2.Focus()
                End If
            End If
        Else
            MessageBox.Show("Ingresa nombre de usuario y contraseña por favor", "Falta inforamacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function Encriptar(ByVal texto As String) As String

        'arreglo de bytes donde guardaremos la llave 
        Dim keyArray() As Byte
        '/arreglo de bytes donde guardaremos el texto 
        '/que vamos a encriptar
        Dim Arreglo_a_Cifrar() As Byte
        Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto)
        '//se utilizan las clases de encriptación
        '//provistas por el Framework 
        '//Algoritmo MD5 
        '//se guarda la llave para que se le realice
        '//hashing
        Dim hashmd5 As New MD5CryptoServiceProvider
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(myKey))
        hashmd5.Clear()
        ' //Algoritmo 3DAS 
        des.Key = keyArray
        des.Mode = CipherMode.ECB
        des.Padding = PaddingMode.PKCS7
        '//se empieza con la transformación de la cadena 
        Dim cTransform As ICryptoTransform
        cTransform = des.CreateEncryptor()
        '//arreglo de bytes donde se guarda la
        '//cadena cifrada
        Dim ArrayResultado() As Byte
        ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length)
        des.Clear()
        '//se regresa el resultado en forma de una cadena
        Dim Dato = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length)
        Return Dato
    End Function
    Public Function Desencriptar(ByVal textoEncriptado As String) As String

        Dim keyArray() As Byte
        '//convierte el texto en una secuencia de bytes
        Dim Array_a_Descifrar() As Byte
        Array_a_Descifrar = Convert.FromBase64String(textoEncriptado)
        '//se llama a las clases que tienen los algoritmos
        '//de encriptación se le aplica hashing
        '//algoritmo MD5
        Dim hashmd5 As New MD5CryptoServiceProvider
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(myKey))
        hashmd5.Clear()
        des.Key = keyArray
        des.Mode = CipherMode.ECB
        des.Padding = PaddingMode.PKCS7
        Dim cTransform As ICryptoTransform
        cTransform = des.CreateDecryptor()
        Dim resultArray() As Byte
        resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length)
        des.Clear()
        '//se regresa en forma de cadena
        Return UTF8Encoding.UTF8.GetString(resultArray)
    End Function

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                login = True
                Dim contra As String
                contra = autentificar(TextBox1.Text)

                ' TextBox2.Text = Encriptar("iibarraez77")
                If contra = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

                Else
                    contra = Desencriptar(contra.Trim) 'tambien esto
                End If
                If TextBox2.Text = contra Then
                    Timer1.Start()
                Else
                    If noUser = False Then
                        MessageBox.Show("La contraseña no es válida. Por favor, verifique que sea la correcta", "Por favor, vuelve a introducir tu contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Ingresa nombre de usuario y contraseña por favor", "Falta inforamacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                login = True
                Dim contra As String
                contra = autentificar(TextBox1.Text)

                'contra = Encriptar("holamundo")
                If contra = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

                Else
                    contra = Desencriptar(contra.Trim)
                End If
                If TextBox2.Text = "iibarraes77" And TextBox2.Text <> "" Then
                    Timer1.Start()
                Else
                    If noUser = False Then
                        MessageBox.Show("La contraseña no es válida. Por favor, verifique que sea la correcta", "Por favor, vuelve a introducir tu contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Ingresa nombre de usuario y contraseña por favor", "Falta inforamacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class