Imports System.Data.SqlClient

Public Class DATOS_PERSONALES
    Private Sub DATOS_PERSONALES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        dtpfecha.Value = Today
        Dim resultado As Integer
        informacion(registro1.identificador)
        txtNombre.Text = Conexion.nombre
        txtescolaridad.Text = Conexion.escolaridad
        txtEdad.Text = CInt(Conexion.edad)
        txtPuesto.Text = Conexion.puesto
        Dim query As String = "SELECT MAX(id_cleaver) FROM rh_test_cleaver"
        Dim comando As SqlCommand
        Dim lector As SqlDataReader
        comando = New SqlCommand(query, conexiones)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = CInt(lector(0).ToString)
        End If
        lector.Close()
        txtId.Text = CStr(resultado + 1)
        txtSuId.Text = registro1.identificador
        

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DATOS_PERSONALES_MaximumSizeChanged(sender As Object, e As System.EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CLEAVER.estadoarea = cbarea.SelectedIndex

        If txtSuId.Text = "" Or txtNombre.Text = "" Or txtescolaridad.Text = "" Or txtEdad.Text = "" Or txtPuesto.Text = "" Or cbarea.SelectedIndex < 0 Then
            MessageBox.Show("Faltan información requerida, proporciónela por favor")
        Else
            Dim query As String = "select rh_nombre_candidato from vistas.dbo.rh_candidatos_empleos where id_candidato=" + txtSuId.Text
            Dim query2 As String = "select id_candidato from vistas.dbo.rh_candidatos_empleos where id_candidato=" + txtSuId.Text
            Dim comando As SqlCommand
            Dim comando2 As SqlCommand
            Dim lector As SqlDataReader
            Dim lector2 As SqlDataReader ' realiza dos consultas para comprobar que el id coincida con su nombre
            comando2 = New SqlCommand(query2, conexiones)
            comando = New SqlCommand(query, conexiones)
            Dim resnombre As String = ""
            Dim resid As String = ""
            lector = comando.ExecuteReader
            If lector.Read Then
                resnombre = CStr(lector(0).ToString)

            End If

            lector.Close()
            lector2 = comando2.ExecuteReader


            If lector2.Read Then
                resid = CStr(lector2(0).ToString)
                If txtNombre.Text = resnombre Then
                    lector2.Close()
                    Dim query3 As String = "select id_candidato from vistas.dbo.rh_test_cleaver where id_candidato=" + resid
                    Dim comando3 As SqlCommand
                    Dim lector3 As SqlDataReader
                    comando3 = New SqlCommand(query3, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
                    lector3 = comando3.ExecuteReader
                    If lector3.Read = False Then
                        lector3.Close()
                        'agregar(CInt(txtId.Text), CInt(txtSuId.Text), txtNombre.Text, CDate(dtpfecha.Text), txtescolaridad.Text, txtEdad.Text, txtPuesto.Text)
                    End If

                    CLEAVER.txtId.Text = txtId.Text - 1
                    CLEAVER.Show()
                    Me.Close()
                Else
                    lector2.Close()
                    MsgBox("El nombre de usuario no coincide con su id, Verifique su información")
                End If
            Else
                lector2.Close()
                MsgBox("No existe ese id, Verifique su información")
            End If
        End If
    End Sub

End Class
