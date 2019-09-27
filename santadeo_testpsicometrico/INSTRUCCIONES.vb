Imports System.Data.SqlClient

Public Class INSTRUCCIONES
    Public total_Respuestas As Integer = 0
    Public s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 As Integer
    Private Sub INSTRUCCIONES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        dtpfechahoy.Value = Today
        txtSuId.Text = registro1.identificador
        informacion(registro1.identificador)
        txtNombre.Text = Conexion.nombre
        txtescolaridad.Text = Conexion.escolaridad
        txtEdad.Text = CInt(Conexion.edad)
        txtPuesto.Text = Conexion.puesto
        Try
            Dim resultado As Integer
            Dim query As String = "SELECT MAX(id_terman_merril) FROM rh_test_merril"
            Dim comando As SqlCommand
            Dim lector As SqlDataReader
            comando = New SqlCommand(query, conexiones)
            lector = comando.ExecuteReader
            If lector.Read Then
                resultado = CInt(lector(0).ToString)
            End If
            lector.Close()
            txtId.Text = resultado + 1

            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width
            If width < 1280 Then '1280
                Me.Location = New Point(0, (height / 2) - 281)
                Me.Size = New System.Drawing.Size(width, 562)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If txtSuId.Text = "" Or txtescolaridad.Text = "" Or txtEdad.Text = "" Or txtNombre.Text = "" Or txtPuesto.Text = "" Then
            MessageBox.Show("Faltan información requerida, proporciónela por favor")
        Else
            Try
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
                        Dim query3 As String = "select id_candidato from vistas.dbo.rh_test_merril where id_candidato=" + resid
                        Dim comando3 As SqlCommand
                        Dim lector3 As SqlDataReader
                        comando3 = New SqlCommand(query3, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
                        lector3 = comando3.ExecuteReader
                        If lector3.Read = False Then
                            lector3.Close()
                            'insertar(CInt(txtId.Text), CInt(txtSuId.Text), txtNombre.Text, CDate(dtpfechahoy.Text), txtescolaridad.Text, txtEdad.Text, txtPuesto.Text)
                        End If

                        SERIE1.txtId.Text = txtId.Text - 1
                        SERIE1.Show()
                        Me.Visible = False
                    Else
                        lector2.Close()
                        MsgBox("El nombre de usuario no coincide con su id, Verifique su información")
                    End If
                Else
                    lector2.Close()
                    MsgBox("No existe ese id, Verifique su información")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            
        End If


    End Sub
End Class