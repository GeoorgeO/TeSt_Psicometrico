Imports System.ComponentModel
Imports System.Text
Imports System.Security.Cryptography
Public Class Encriptacion
    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "HUE08160831464" 'Clave secreta(puede alterarse)
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
        DES.Key = keyArray
        DES.Mode = CipherMode.ECB
        DES.Padding = PaddingMode.PKCS7
        '//se empieza con la transformación de la cadena 
        Dim cTransform As ICryptoTransform
        cTransform = DES.CreateEncryptor()
        '//arreglo de bytes donde se guarda la
        '//cadena cifrada
        Dim ArrayResultado() As Byte
        ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length)
        DES.Clear()
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
        DES.Key = keyArray
        DES.Mode = CipherMode.ECB
        DES.Padding = PaddingMode.PKCS7
        Dim cTransform As ICryptoTransform
        cTransform = DES.CreateDecryptor()
        Dim resultArray() As Byte
        resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length)
        DES.Clear()
        '//se regresa en forma de cadena
        Return UTF8Encoding.UTF8.GetString(resultArray)
    End Function
End Class
