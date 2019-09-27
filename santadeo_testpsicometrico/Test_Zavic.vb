Imports System.Data.SqlClient

Public Class Test_Zavic
    Dim fecha As Date
    Private Sub Test_Zavic_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSuId.Text = "" + CStr(registro1.identificador)
        abrir()
        informacion(registro1.identificador)
        Try
            txtNombre.Text = Conexion.nombre
            txtescolaridad.Text = Conexion.escolaridad
            txtEdad.Text = CInt(Conexion.edad)
            txtPuesto.Text = Conexion.puesto
            DateTimePicker1.Value = Today
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width
            If width < 1096 Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.Location = New Point((width / 2) - 548, 0)
                Me.Size = New System.Drawing.Size(1096, height - 45)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtSuId.Text <> "" And txtEdad.Text <> "" And txtPuesto.Text <> "" And txtescolaridad.Text <> "" And txtNombre.Text <> "" And
            txta1.Text <> "" And
        txta2.Text <> "" And txta3.Text <> "" And txta4.Text <> "" And txta5.Text <> "" And txta6.Text <> "" And txta13.Text <> "" And txta8.Text <> "" And
        txta9.Text <> "" And txta10.Text <> "" And txta11.Text <> "" And txta12.Text <> "" And txta7.Text <> "" And txta14.Text <> "" And
        txta15.Text <> "" And txta16.Text <> "" And txta17.Text <> "" And txta18.Text <> "" And txta19.Text <> "" And txta20.Text <> "" And
            txtb1.Text <> "" And
        txtb2.Text <> "" And txtb3.Text <> "" And txtb4.Text <> "" And txtb5.Text <> "" And txtb6.Text <> "" And txtb13.Text <> "" And
        txtb8.Text <> "" And txtb9.Text <> "" And txtb10.Text <> "" And txtb11.Text <> "" And txtb12.Text <> "" And txtb7.Text <> "" And
        txtb14.Text <> "" And txtb15.Text <> "" And txtb16.Text <> "" And txtb17.Text <> "" And txtb18.Text <> "" And txtb19.Text <> "" And
        txtb20.Text <> "" And
            txtc1.Text <> "" And
        txtc2.Text <> "" And txtc3.Text <> "" And txtc4.Text <> "" And txtc5.Text <> "" And txtc6.Text <> "" And txtc13.Text <> "" And txtc8.Text <> "" And
        txtc9.Text <> "" And txtc10.Text <> "" And txtc11.Text <> "" And txtc12.Text <> "" And txtc7.Text <> "" And txtc14.Text <> "" And
        txtc15.Text <> "" And txtc16.Text <> "" And txtc17.Text <> "" And txtc18.Text <> "" And txtc19.Text <> "" And txtc20.Text <> "" And
            txtd1.Text <> "" And
        txtd2.Text <> "" And txtd3.Text <> "" And txtd4.Text <> "" And txtd5.Text <> "" And txtd6.Text <> "" And txtd13.Text <> "" And txtd8.Text <> "" And
        txtd9.Text <> "" And txtd10.Text <> "" And txtd11.Text <> "" And txtd12.Text <> "" And txtd7.Text <> "" And txtd14.Text <> "" And
        txtd15.Text <> "" And txtd16.Text <> "" And txtd17.Text <> "" And txtd18.Text <> "" And txtd19.Text <> "" And txtd20.Text <> "" Then

            Dim t_moral, t_legalidad, t_indiferencia, t_corrupto, t_economico, t_politico, t_social, t_religioso As Integer
            'valores ºººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº
            t_moral = CInt(txta3.Text) + CInt(txtd4.Text) + CInt(txta6.Text) + CInt(txtb8.Text) + CInt(txtb9.Text) + CInt(txtb12.Text) + CInt(txta13.Text) + CInt(txtd15.Text) + CInt(txtd17.Text) + CInt(txta19.Text)
            t_legalidad = CInt(txtb3.Text) + CInt(txtc4.Text) + CInt(txtb6.Text) + CInt(txta8.Text) + CInt(txta9.Text) + CInt(txtd12.Text) + CInt(txtb13.Text) + CInt(txtc15.Text) + CInt(txtb17.Text) + CInt(txtd19.Text)
            t_indiferencia = CInt(txtc3.Text) + CInt(txta4.Text) + CInt(txtd6.Text) + CInt(txtc8.Text) + CInt(txtd9.Text) + CInt(txta12.Text) + CInt(txtc13.Text) + CInt(txtb15.Text) + CInt(txta17.Text) + CInt(txtb19.Text)
            t_corrupto = CInt(txtd3.Text) + CInt(txtb4.Text) + CInt(txtc6.Text) + CInt(txtd8.Text) + CInt(txtc9.Text) + CInt(txtc12.Text) + CInt(txtd13.Text) + CInt(txta15.Text) + CInt(txtc17.Text) + CInt(txtc19.Text)
            'interesesººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº
            t_economico = CInt(txtc1.Text) + CInt(txtc2.Text) + CInt(txtd5.Text) + CInt(txtb7.Text) + CInt(txta10.Text) + CInt(txta11.Text) + CInt(txta14.Text) + CInt(txta16.Text) + CInt(txtb18.Text) + CInt(txta20.Text)
            t_politico = CInt(txtb1.Text) + CInt(txtd2.Text) + CInt(txtb5.Text) + CInt(txtc7.Text) + CInt(txtb10.Text) + CInt(txtd11.Text) + CInt(txtb14.Text) + CInt(txtb16.Text) + CInt(txtc18.Text) + CInt(txtb20.Text)
            t_social = CInt(txta1.Text) + CInt(txtb2.Text) + CInt(txta5.Text) + CInt(txta7.Text) + CInt(txtd10.Text) + CInt(txtb11.Text) + CInt(txtc14.Text) + CInt(txtd16.Text) + CInt(txtd18.Text) + CInt(txtd20.Text)
            t_religioso = CInt(txtd1.Text) + CInt(txta2.Text) + CInt(txtc5.Text) + CInt(txtd7.Text) + CInt(txtc10.Text) + CInt(txtc11.Text) + CInt(txtd14.Text) + CInt(txtc16.Text) + CInt(txta18.Text) + CInt(txtc20.Text)
            Try
                'Dim query4 As String = "select t_nombre from rh_test_zavic where t_nombre='" & txtNombre.Text & "'"
                'Dim comando4 As SqlCommand
                'Dim lector4 As SqlDataReader
                'comando4 = New SqlCommand(query4, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
                'lector4 = comando4.ExecuteReader

                'If lector4.Read = False Then
                'lector4.Close()
                ' f_test_zavic(txtSuId.Text, txtNombre.Text, CDate(DateTimePicker1.Text), txtescolaridad.Text, txtEdad.Text, txtPuesto.Text, t_moral, t_legalidad, t_indiferencia, t_corrupto, t_economico, t_politico, t_social, t_religioso)
                actualizaZavic(registro1.identificador, CDate(DateTimePicker1.Text), t_moral, t_legalidad, t_indiferencia, t_corrupto, t_economico, t_politico, t_social, t_religioso)
                'End If
                'lector4.Close()
                DATOS_PERSONALES.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la conexión, intente más tarde", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try

        Else
            MessageBox.Show("Faltan respuestas que llenar, verifícalas por favor", "No se puede completar la acción", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txta1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta1.TextChanged
        If txtb1.Text = txta1.Text And txtb1.Text <> "" Or txtc1.Text = txta1.Text And txtc1.Text <> "" Or txtd1.Text = txta1.Text And txtd1.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta1.Clear()
            txta1.Focus()
        End If
        If txta1.Text <> "1" And txta1.Text <> "2" And txta1.Text <> "3" And txta1.Text <> "4" And txta1.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta1.Clear()
            txta1.Focus()

        End If
    End Sub

    Private Sub txtd1_TextChanged(sender As Object, e As System.EventArgs) Handles txtd1.TextChanged
        If txtb1.Text = txtd1.Text And txtb1.Text <> "" Or txtc1.Text = txtd1.Text And txtc1.Text <> "" Or txtd1.Text = txta1.Text And txta1.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd1.Clear()
            txtd1.Focus()
        End If
        If txtd1.Text <> "1" And txtd1.Text <> "2" And txtd1.Text <> "3" And txtd1.Text <> "4" And txtd1.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd1.Clear()
            txtd1.Focus()
        End If
    End Sub

    Private Sub txtb1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb1.TextChanged
        If txtb1.Text = txta1.Text And txta1.Text <> "" Or txtc1.Text = txtb1.Text And txtc1.Text <> "" Or txtd1.Text = txtb1.Text And txtd1.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb1.Clear()
            txtb1.Focus()
        End If
        If txtb1.Text <> "1" And txtb1.Text <> "2" And txtb1.Text <> "3" And txtb1.Text <> "4" And txtb1.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb1.Clear()
            txtb1.Focus()
        End If
    End Sub

    Private Sub txtc1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc1.TextChanged
        If txtb1.Text = txtc1.Text And txtb1.Text <> "" Or txtc1.Text = txta1.Text And txta1.Text <> "" Or txtd1.Text = txtc1.Text And txtd1.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc1.Clear()
            txtc1.Focus()
        End If
        If txtc1.Text <> "1" And txtc1.Text <> "2" And txtc1.Text <> "3" And txtc1.Text <> "4" And txtc1.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc1.Clear()
            txtc1.Focus()
        End If
    End Sub

    Private Sub txta2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta2.TextChanged
        If txtb2.Text = txta2.Text And txtb2.Text <> "" Or txtc2.Text = txta2.Text And txtc2.Text <> "" Or txtd2.Text = txta2.Text And txtd2.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta2.Clear()
            txta2.Focus()
        End If
        If txta2.Text <> "1" And txta2.Text <> "2" And txta2.Text <> "3" And txta2.Text <> "4" And txta2.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta2.Clear()
            txta2.Focus()
        End If
    End Sub

    Private Sub txtb2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb2.TextChanged
        If txtb2.Text = txta2.Text And txta2.Text <> "" Or txtc2.Text = txtb2.Text And txtc2.Text <> "" Or txtd2.Text = txtb2.Text And txtd2.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb2.Clear()
            txtb2.Focus()
        End If
        If txtb2.Text <> "1" And txtb2.Text <> "2" And txtb2.Text <> "3" And txtb2.Text <> "4" And txtb2.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb2.Clear()
            txtb2.Focus()
        End If
    End Sub

    Private Sub txtc2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc2.TextChanged
        If txtb2.Text = txtc2.Text And txtb2.Text <> "" Or txtc2.Text = txta2.Text And txta2.Text <> "" Or txtd2.Text = txtc2.Text And txtd2.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc2.Clear()
            txtc2.Focus()
        End If
        If txtc2.Text <> "1" And txtc2.Text <> "2" And txtc2.Text <> "3" And txtc2.Text <> "4" And txtc2.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc2.Clear()
            txtc2.Focus()
        End If
    End Sub

    Private Sub txtd2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd2.TextChanged
        If txtb2.Text = txtd2.Text And txtb2.Text <> "" Or txtc2.Text = txtd2.Text And txtc2.Text <> "" Or txtd2.Text = txta2.Text And txta2.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd2.Clear()
            txtd2.Focus()
        End If
        If txtd2.Text <> "1" And txtd2.Text <> "2" And txtd2.Text <> "3" And txtd2.Text <> "4" And txtd2.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd2.Clear()
            txtd2.Focus()
        End If
    End Sub

    Private Sub txta3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta3.TextChanged
        If txtb3.Text = txta3.Text And txtb3.Text <> "" Or txtc3.Text = txta3.Text And txtc3.Text <> "" Or txtd3.Text = txta3.Text And txtd3.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta3.Clear()
            txta3.Focus()
        End If
        If txta3.Text <> "1" And txta3.Text <> "2" And txta3.Text <> "3" And txta3.Text <> "4" And txta3.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta3.Clear()
            txta3.Focus()
        End If
    End Sub

    Private Sub txtb3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb3.TextChanged
        If txtb3.Text = txta3.Text And txta3.Text <> "" Or txtc3.Text = txtb3.Text And txtc3.Text <> "" Or txtd3.Text = txtb3.Text And txtd3.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb3.Clear()
            txtb3.Focus()
        End If
        If txtb3.Text <> "1" And txtb3.Text <> "2" And txtb3.Text <> "3" And txtb3.Text <> "4" And txtb3.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb3.Clear()
            txtb3.Focus()
        End If
    End Sub

    Private Sub txtc3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc3.TextChanged
        If txtb3.Text = txtc3.Text And txtb3.Text <> "" Or txtc3.Text = txta3.Text And txta3.Text <> "" Or txtd3.Text = txtc3.Text And txtd3.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc3.Clear()
            txtc3.Focus()
        End If
        If txtc3.Text <> "1" And txtc3.Text <> "2" And txtc3.Text <> "3" And txtc3.Text <> "4" And txtc3.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc3.Clear()
            txtc3.Focus()
        End If
    End Sub

    Private Sub txtd3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd3.TextChanged
        If txtb3.Text = txtd3.Text And txtb3.Text <> "" Or txtc3.Text = txtd3.Text And txtc3.Text <> "" Or txtd3.Text = txta3.Text And txta3.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd3.Clear()
            txtd3.Focus()
        End If
        If txtd3.Text <> "1" And txtd3.Text <> "2" And txtd3.Text <> "3" And txtd3.Text <> "4" And txtd3.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd3.Clear()
            txtd3.Focus()
        End If
    End Sub

    Private Sub txta4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta4.TextChanged
        If txtb4.Text = txta4.Text And txtb4.Text <> "" Or txtc4.Text = txta4.Text And txtc4.Text <> "" Or txtd4.Text = txta4.Text And txtd4.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta4.Clear()
            txta4.Focus()
        End If
        If txta4.Text <> "1" And txta4.Text <> "2" And txta4.Text <> "3" And txta4.Text <> "4" And txta4.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta4.Clear()
            txta4.Focus()
        End If
    End Sub

    Private Sub txtb4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb4.TextChanged
        If txtb4.Text = txta4.Text And txta4.Text <> "" Or txtc4.Text = txtb4.Text And txtc4.Text <> "" Or txtd4.Text = txtb4.Text And txtd4.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb4.Clear()
            txtb4.Focus()
        End If
        If txtb4.Text <> "1" And txtb4.Text <> "2" And txtb4.Text <> "3" And txtb4.Text <> "4" And txtb4.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb4.Clear()
            txtb4.Focus()
        End If
    End Sub

    Private Sub txtc4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc4.TextChanged
        If txtb4.Text = txtc4.Text And txtb4.Text <> "" Or txtc4.Text = txta4.Text And txta4.Text <> "" Or txtd4.Text = txtc4.Text And txtd4.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc4.Clear()
            txtc4.Focus()
        End If
        If txtc4.Text <> "1" And txtc4.Text <> "2" And txtc4.Text <> "3" And txtc4.Text <> "4" And txtc4.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc4.Clear()
            txtc4.Focus()
        End If
    End Sub

    Private Sub txtd4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd4.TextChanged
        If txtb4.Text = txtd4.Text And txtb4.Text <> "" Or txtc4.Text = txtd4.Text And txtc4.Text <> "" Or txtd4.Text = txta4.Text And txta4.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd4.Clear()
            txtd4.Focus()
        End If
        If txtd4.Text <> "1" And txtd4.Text <> "2" And txtd4.Text <> "3" And txtd4.Text <> "4" And txtd4.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd4.Clear()
            txtd4.Focus()
        End If
    End Sub

    Private Sub txta5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta5.TextChanged
        If txtb5.Text = txta5.Text And txtb5.Text <> "" Or txtc5.Text = txta5.Text And txtc5.Text <> "" Or txtd5.Text = txta5.Text And txtd5.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta5.Clear()
            txta5.Focus()
        End If
        If txta5.Text <> "1" And txta5.Text <> "2" And txta5.Text <> "3" And txta5.Text <> "4" And txta5.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta5.Clear()
            txta5.Focus()
        End If
    End Sub

    Private Sub txtb5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb5.TextChanged
        If txtb5.Text = txta5.Text And txta5.Text <> "" Or txtc5.Text = txtb5.Text And txtc5.Text <> "" Or txtd5.Text = txtb5.Text And txtd5.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb5.Clear()
            txtb5.Focus()
        End If
        If txtb5.Text <> "1" And txtb5.Text <> "2" And txtb5.Text <> "3" And txtb5.Text <> "4" And txtb5.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb5.Clear()
            txtb5.Focus()
        End If
    End Sub

    Private Sub txtc5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc5.TextChanged
        If txtb5.Text = txtc5.Text And txtb5.Text <> "" Or txtc5.Text = txta5.Text And txta5.Text <> "" Or txtd5.Text = txtc5.Text And txtd5.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc5.Clear()
            txtc5.Focus()
        End If
        If txtc5.Text <> "1" And txtc5.Text <> "2" And txtc5.Text <> "3" And txtc5.Text <> "4" And txtc5.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc5.Clear()
            txtc5.Focus()
        End If
    End Sub

    Private Sub txtd5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd5.TextChanged
        If txtb5.Text = txtd5.Text And txtb5.Text <> "" Or txtc5.Text = txtd5.Text And txtc5.Text <> "" Or txtd5.Text = txta5.Text And txta5.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd5.Clear()
            txtd5.Focus()
        End If
        If txtd5.Text <> "1" And txtd5.Text <> "2" And txtd5.Text <> "3" And txtd5.Text <> "4" And txtd5.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd5.Clear()
            txtd5.Focus()
        End If
    End Sub

    Private Sub txta6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta6.TextChanged
        If txtb6.Text = txta6.Text And txtb6.Text <> "" Or txtc6.Text = txta6.Text And txtc6.Text <> "" Or txtd6.Text = txta6.Text And txtd6.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta6.Clear()
            txta6.Focus()
        End If
        If txta6.Text <> "1" And txta6.Text <> "2" And txta6.Text <> "3" And txta6.Text <> "4" And txta6.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta6.Clear()
            txta6.Focus()
        End If
    End Sub

    Private Sub txtb6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb6.TextChanged
        If txtb6.Text = txta6.Text And txta6.Text <> "" Or txtc6.Text = txtb6.Text And txtc6.Text <> "" Or txtd6.Text = txtb6.Text And txtd6.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb6.Clear()
            txtb6.Focus()
        End If
        If txtb6.Text <> "1" And txtb6.Text <> "2" And txtb6.Text <> "3" And txtb6.Text <> "4" And txtb6.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb6.Clear()
            txtb6.Focus()
        End If
    End Sub

    Private Sub txtc6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc6.TextChanged
        If txtb6.Text = txtc6.Text And txtb6.Text <> "" Or txtc6.Text = txta6.Text And txta6.Text <> "" Or txtd6.Text = txtc6.Text And txtd6.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc6.Clear()
            txtc6.Focus()
        End If
        If txtc6.Text <> "1" And txtc6.Text <> "2" And txtc6.Text <> "3" And txtc6.Text <> "4" And txtc6.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc6.Clear()
            txtc6.Focus()
        End If
    End Sub

    Private Sub txtd6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd6.TextChanged
        If txtb6.Text = txtd6.Text And txtb6.Text <> "" Or txtc6.Text = txtd6.Text And txtc6.Text <> "" Or txtd6.Text = txta6.Text And txta6.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd6.Clear()
            txtd6.Focus()
        End If
        If txtd6.Text <> "1" And txtd6.Text <> "2" And txtd6.Text <> "3" And txtd6.Text <> "4" And txtd6.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd6.Clear()
            txtd6.Focus()
        End If
    End Sub

    Private Sub txta7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta7.TextChanged
        If txtb7.Text = txta7.Text And txtb7.Text <> "" Or txtc7.Text = txta7.Text And txtc7.Text <> "" Or txtd7.Text = txta7.Text And txtd7.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta7.Clear()
            txta7.Focus()
        End If
        If txta7.Text <> "1" And txta7.Text <> "2" And txta7.Text <> "3" And txta7.Text <> "4" And txta7.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta7.Clear()
            txta7.Focus()
        End If
    End Sub

    Private Sub txtb7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb7.TextChanged
        If txtb7.Text = txta7.Text And txta7.Text <> "" Or txtc7.Text = txtb7.Text And txtc7.Text <> "" Or txtd7.Text = txtb7.Text And txtd7.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb7.Clear()
            txtb7.Focus()
        End If
        If txtb7.Text <> "1" And txtb7.Text <> "2" And txtb7.Text <> "3" And txtb7.Text <> "4" And txtb7.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb7.Clear()
            txtb7.Focus()
        End If
    End Sub

    Private Sub txtc7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc7.TextChanged
        If txtb7.Text = txtc7.Text And txtb7.Text <> "" Or txtc7.Text = txta7.Text And txta7.Text <> "" Or txtd7.Text = txtc7.Text And txtd7.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc7.Clear()
            txtc7.Focus()
        End If
        If txtc7.Text <> "1" And txtc7.Text <> "2" And txtc7.Text <> "3" And txtc7.Text <> "4" And txtc7.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc7.Clear()
            txtc7.Focus()
        End If
    End Sub

    Private Sub txtd7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd7.TextChanged
        If txtb7.Text = txtd7.Text And txtb7.Text <> "" Or txtc7.Text = txtd7.Text And txtc7.Text <> "" Or txtd7.Text = txta7.Text And txta7.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd7.Clear()
            txtd7.Focus()
        End If
        If txtd7.Text <> "1" And txtd7.Text <> "2" And txtd7.Text <> "3" And txtd7.Text <> "4" And txtd7.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd7.Clear()
            txtd7.Focus()
        End If
    End Sub

    Private Sub txta8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta8.TextChanged
        If txtb8.Text = txta8.Text And txtb8.Text <> "" Or txtc8.Text = txta8.Text And txtc8.Text <> "" Or txtd8.Text = txta8.Text And txtd8.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta8.Clear()
            txta8.Focus()
        End If
        If txta8.Text <> "1" And txta8.Text <> "2" And txta8.Text <> "3" And txta8.Text <> "4" And txta8.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta8.Clear()
            txta8.Focus()
        End If
    End Sub

    Private Sub txtb8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb8.TextChanged
        If txtb8.Text = txta8.Text And txta8.Text <> "" Or txtc8.Text = txtb8.Text And txtc8.Text <> "" Or txtd8.Text = txtb8.Text And txtd8.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb8.Clear()
            txtb8.Focus()
        End If
        If txtb8.Text <> "1" And txtb8.Text <> "2" And txtb8.Text <> "3" And txtb8.Text <> "4" And txtb8.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb8.Clear()
            txtb8.Focus()
        End If
    End Sub

    Private Sub txtc8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc8.TextChanged
        If txtb8.Text = txtc8.Text And txtb8.Text <> "" Or txtc8.Text = txta8.Text And txta8.Text <> "" Or txtd8.Text = txtc8.Text And txtd8.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc8.Clear()
            txtc8.Focus()
        End If
        If txtc8.Text <> "1" And txtc8.Text <> "2" And txtc8.Text <> "3" And txtc8.Text <> "4" And txtc8.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc8.Clear()
            txtc8.Focus()
        End If
    End Sub

    Private Sub txtd8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd8.TextChanged
        If txtb8.Text = txtd8.Text And txtb8.Text <> "" Or txtc8.Text = txtd8.Text And txtc8.Text <> "" Or txtd8.Text = txta8.Text And txta8.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd8.Clear()
            txtd8.Focus()
        End If
        If txtd8.Text <> "1" And txtd8.Text <> "2" And txtd8.Text <> "3" And txtd8.Text <> "4" And txtd8.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd8.Clear()
            txtd8.Focus()
        End If
    End Sub

    Private Sub txta9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta9.TextChanged
        If txtb9.Text = txta9.Text And txtb9.Text <> "" Or txtc9.Text = txta9.Text And txtc9.Text <> "" Or txtd9.Text = txta9.Text And txtd9.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta9.Clear()
            txta9.Focus()
        End If
        If txta9.Text <> "1" And txta9.Text <> "2" And txta9.Text <> "3" And txta9.Text <> "4" And txta9.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta9.Clear()
            txta9.Focus()
        End If
    End Sub

    Private Sub txtb9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb9.TextChanged
        If txtb9.Text = txta9.Text And txta9.Text <> "" Or txtc9.Text = txtb9.Text And txtc9.Text <> "" Or txtd9.Text = txtb9.Text And txtd9.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb9.Clear()
            txtb9.Focus()
        End If
        If txtb9.Text <> "1" And txtb9.Text <> "2" And txtb9.Text <> "3" And txtb9.Text <> "4" And txtb9.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb9.Clear()
            txtb9.Focus()
        End If
    End Sub

    Private Sub txtc9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc9.TextChanged
        If txtb9.Text = txtc9.Text And txtb9.Text <> "" Or txtc9.Text = txta9.Text And txta9.Text <> "" Or txtd9.Text = txtc9.Text And txtd9.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc9.Clear()
            txtc9.Focus()
        End If
        If txtc9.Text <> "1" And txtc9.Text <> "2" And txtc9.Text <> "3" And txtc9.Text <> "4" And txtc9.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc9.Clear()
            txtc9.Focus()
        End If
    End Sub

    Private Sub txtd9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd9.TextChanged
        If txtb9.Text = txtd9.Text And txtb9.Text <> "" Or txtc9.Text = txtd9.Text And txtc9.Text <> "" Or txtd9.Text = txta9.Text And txta9.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd9.Clear()
            txtd9.Focus()
        End If
        If txtd9.Text <> "1" And txtd9.Text <> "2" And txtd9.Text <> "3" And txtd9.Text <> "4" And txtd9.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd9.Clear()
            txtd9.Focus()
        End If
    End Sub

    Private Sub txta10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta10.TextChanged
        If txtb10.Text = txta10.Text And txtb10.Text <> "" Or txtc10.Text = txta10.Text And txtc10.Text <> "" Or txtd10.Text = txta10.Text And txtd10.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta10.Clear()
            txta10.Focus()
        End If
        If txta10.Text <> "1" And txta10.Text <> "2" And txta10.Text <> "3" And txta10.Text <> "4" And txta10.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta10.Clear()
            txta10.Focus()
        End If
    End Sub

    Private Sub txtb10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb10.TextChanged
        If txtb10.Text = txta10.Text And txta10.Text <> "" Or txtc10.Text = txtb10.Text And txtc10.Text <> "" Or txtd10.Text = txtb10.Text And txtd10.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb10.Clear()
            txtb10.Focus()
        End If
        If txtb10.Text <> "1" And txtb10.Text <> "2" And txtb10.Text <> "3" And txtb10.Text <> "4" And txtb10.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb10.Clear()
            txtb10.Focus()
        End If
    End Sub

    Private Sub txtc10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc10.TextChanged
        If txtb10.Text = txtc10.Text And txtb10.Text <> "" Or txtc10.Text = txta10.Text And txta10.Text <> "" Or txtd10.Text = txtc10.Text And txtd10.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc10.Clear()
            txtc10.Focus()
        End If
        If txtc10.Text <> "1" And txtc10.Text <> "2" And txtc10.Text <> "3" And txtc10.Text <> "4" And txtc10.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc10.Clear()
            txtc10.Focus()
        End If
    End Sub

    Private Sub txtd10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd10.TextChanged
        If txtb10.Text = txtd10.Text And txtb10.Text <> "" Or txtc10.Text = txtd10.Text And txtc10.Text <> "" Or txtd10.Text = txta10.Text And txta10.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd10.Clear()
            txtd10.Focus()
        End If
        If txtd10.Text <> "1" And txtd10.Text <> "2" And txtd10.Text <> "3" And txtd10.Text <> "4" And txtd10.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd10.Clear()
            txtd10.Focus()
        End If
    End Sub

    Private Sub txta11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta11.TextChanged
        If txtb11.Text = txta11.Text And txtb11.Text <> "" Or txtc11.Text = txta11.Text And txtc11.Text <> "" Or txtd11.Text = txta11.Text And txtd11.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta11.Clear()
            txta11.Focus()
        End If
        If txta11.Text <> "1" And txta11.Text <> "2" And txta11.Text <> "3" And txta11.Text <> "4" And txta11.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta11.Clear()
            txta11.Focus()
        End If
    End Sub

    Private Sub txtb11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb11.TextChanged
        If txtb11.Text = txta11.Text And txta11.Text <> "" Or txtc11.Text = txtb11.Text And txtc11.Text <> "" Or txtd11.Text = txtb11.Text And txtd11.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb11.Clear()
            txtb11.Focus()
        End If
        If txtb11.Text <> "1" And txtb11.Text <> "2" And txtb11.Text <> "3" And txtb11.Text <> "4" And txtb11.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb11.Clear()
            txtb11.Focus()
        End If
    End Sub

    Private Sub txtc11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc11.TextChanged
        If txtb11.Text = txtc11.Text And txtb11.Text <> "" Or txtc11.Text = txta11.Text And txta11.Text <> "" Or txtd11.Text = txtc11.Text And txtd11.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc11.Clear()
            txtc11.Focus()
        End If
        If txtc11.Text <> "1" And txtc11.Text <> "2" And txtc11.Text <> "3" And txtc11.Text <> "4" And txtc11.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc11.Clear()
            txtc11.Focus()
        End If
    End Sub

    Private Sub txtd11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd11.TextChanged
        If txtb11.Text = txtd11.Text And txtb11.Text <> "" Or txtc11.Text = txtd11.Text And txtc11.Text <> "" Or txtd11.Text = txta11.Text And txta11.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd11.Clear()
            txtd11.Focus()
        End If
        If txtd11.Text <> "1" And txtd11.Text <> "2" And txtd11.Text <> "3" And txtd11.Text <> "4" And txtd11.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd11.Clear()
            txtd11.Focus()
        End If
    End Sub

    Private Sub txta12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta12.TextChanged
        If txtb12.Text = txta12.Text And txtb12.Text <> "" Or txtc12.Text = txta12.Text And txtc12.Text <> "" Or txtd12.Text = txta12.Text And txtd12.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta12.Clear()
            txta12.Focus()
        End If
        If txta12.Text <> "1" And txta12.Text <> "2" And txta12.Text <> "3" And txta12.Text <> "4" And txta12.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta12.Clear()
            txta12.Focus()
        End If
    End Sub

    Private Sub txtb12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb12.TextChanged
        If txtb12.Text = txta12.Text And txta12.Text <> "" Or txtc12.Text = txtb12.Text And txtc12.Text <> "" Or txtd12.Text = txtb12.Text And txtd12.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb12.Clear()
            txtb12.Focus()
        End If
        If txtb12.Text <> "1" And txtb12.Text <> "2" And txtb12.Text <> "3" And txtb12.Text <> "4" And txtb12.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb12.Clear()
            txtb12.Focus()
        End If
    End Sub

    Private Sub txtc12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc12.TextChanged
        If txtb12.Text = txtc12.Text And txtb12.Text <> "" Or txtc12.Text = txta12.Text And txta12.Text <> "" Or txtd12.Text = txtc12.Text And txtd12.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc12.Clear()
            txtc12.Focus()
        End If
        If txtc12.Text <> "1" And txtc12.Text <> "2" And txtc12.Text <> "3" And txtc12.Text <> "4" And txtc12.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc12.Clear()
            txtc12.Focus()
        End If
    End Sub

    Private Sub txtd12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd12.TextChanged
        If txtb12.Text = txtd12.Text And txtb12.Text <> "" Or txtc12.Text = txtd12.Text And txtc12.Text <> "" Or txtd12.Text = txta12.Text And txta12.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd12.Clear()
            txtd12.Focus()
        End If
        If txtd12.Text <> "1" And txtd12.Text <> "2" And txtd12.Text <> "3" And txtd12.Text <> "4" And txtd12.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd12.Clear()
            txtd12.Focus()
        End If
    End Sub

    Private Sub txta13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta13.TextChanged
        If txtb13.Text = txta13.Text And txtb13.Text <> "" Or txtc13.Text = txta13.Text And txtc13.Text <> "" Or txtd13.Text = txta13.Text And txtd13.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta13.Clear()
            txta13.Focus()
        End If
        If txta13.Text <> "1" And txta13.Text <> "2" And txta13.Text <> "3" And txta13.Text <> "4" And txta13.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta13.Clear()
            txta13.Focus()
        End If
    End Sub

    Private Sub txtb13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb13.TextChanged
        If txtb13.Text = txta13.Text And txta13.Text <> "" Or txtc13.Text = txtb13.Text And txtc13.Text <> "" Or txtd13.Text = txtb13.Text And txtd13.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb13.Clear()
            txtb13.Focus()
        End If
        If txtb13.Text <> "1" And txtb13.Text <> "2" And txtb13.Text <> "3" And txtb13.Text <> "4" And txtb13.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb13.Clear()
            txtb13.Focus()
        End If
    End Sub

    Private Sub txtc13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc13.TextChanged
        If txtb13.Text = txtc13.Text And txtb13.Text <> "" Or txtc13.Text = txta13.Text And txta13.Text <> "" Or txtd13.Text = txtc13.Text And txtd13.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc13.Clear()
            txtc13.Focus()
        End If
        If txtc13.Text <> "1" And txtc13.Text <> "2" And txtc13.Text <> "3" And txtc13.Text <> "4" And txtc13.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc13.Clear()
            txtc13.Focus()
        End If
    End Sub

    Private Sub txtd13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd13.TextChanged
        If txtb13.Text = txtd13.Text And txtb13.Text <> "" Or txtc13.Text = txtd13.Text And txtc13.Text <> "" Or txtd13.Text = txta13.Text And txta13.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd13.Clear()
            txtd13.Focus()
        End If
        If txtd13.Text <> "1" And txtd13.Text <> "2" And txtd13.Text <> "3" And txtd13.Text <> "4" And txtd13.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd13.Clear()
            txtd13.Focus()
        End If
    End Sub

    Private Sub txta14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta14.TextChanged
        If txtb14.Text = txta14.Text And txtb14.Text <> "" Or txtc14.Text = txta14.Text And txtc14.Text <> "" Or txtd14.Text = txta14.Text And txtd14.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta14.Clear()
            txta14.Focus()
        End If
        If txta14.Text <> "1" And txta14.Text <> "2" And txta14.Text <> "3" And txta14.Text <> "4" And txta14.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta14.Clear()
            txta14.Focus()
        End If
    End Sub

    Private Sub txtb14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb14.TextChanged
        If txtb14.Text = txta14.Text And txta14.Text <> "" Or txtc14.Text = txtb14.Text And txtc14.Text <> "" Or txtd14.Text = txtb14.Text And txtd14.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb14.Clear()
            txtb14.Focus()
        End If
        If txtb14.Text <> "1" And txtb14.Text <> "2" And txtb14.Text <> "3" And txtb14.Text <> "4" And txtb14.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb14.Clear()
            txtb14.Focus()
        End If
    End Sub

    Private Sub txtc14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc14.TextChanged
        If txtb14.Text = txtc14.Text And txtb14.Text <> "" Or txtc14.Text = txta14.Text And txta14.Text <> "" Or txtd14.Text = txtc14.Text And txtd14.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc14.Clear()
            txtc14.Focus()
        End If
        If txtc14.Text <> "1" And txtc14.Text <> "2" And txtc14.Text <> "3" And txtc14.Text <> "4" And txtc14.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc14.Clear()
            txtc14.Focus()
        End If
    End Sub

    Private Sub txtd14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd14.TextChanged
        If txtb14.Text = txtd14.Text And txtb14.Text <> "" Or txtc14.Text = txtd14.Text And txtc14.Text <> "" Or txtd14.Text = txta14.Text And txta14.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd14.Clear()
            txtd14.Focus()
        End If
        If txtd14.Text <> "1" And txtd14.Text <> "2" And txtd14.Text <> "3" And txtd14.Text <> "4" And txtd14.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd14.Clear()
            txtd14.Focus()
        End If
    End Sub

    Private Sub txta15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta15.TextChanged
        If txtb15.Text = txta15.Text And txtb15.Text <> "" Or txtc15.Text = txta15.Text And txtc15.Text <> "" Or txtd15.Text = txta15.Text And txtd15.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta15.Clear()
            txta15.Focus()
        End If
        If txta15.Text <> "1" And txta15.Text <> "2" And txta15.Text <> "3" And txta15.Text <> "4" And txta15.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta15.Clear()
            txta15.Focus()
        End If
    End Sub

    Private Sub txtb15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb15.TextChanged
        If txtb15.Text = txta15.Text And txta15.Text <> "" Or txtc15.Text = txtb15.Text And txtc15.Text <> "" Or txtd15.Text = txtb15.Text And txtd15.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb15.Clear()
            txtb15.Focus()
        End If
        If txtb15.Text <> "1" And txtb15.Text <> "2" And txtb15.Text <> "3" And txtb15.Text <> "4" And txtb15.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb15.Clear()
            txtb15.Focus()
        End If
    End Sub

    Private Sub txtc15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc15.TextChanged
        If txtb15.Text = txtc15.Text And txtb15.Text <> "" Or txtc15.Text = txta15.Text And txta15.Text <> "" Or txtd15.Text = txtc15.Text And txtd15.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc15.Clear()
            txtc15.Focus()
        End If
        If txtc15.Text <> "1" And txtc15.Text <> "2" And txtc15.Text <> "3" And txtc15.Text <> "4" And txtc15.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc15.Clear()
            txtc15.Focus()
        End If
    End Sub

    Private Sub txtd15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd15.TextChanged
        If txtb15.Text = txtd15.Text And txtb15.Text <> "" Or txtc15.Text = txtd15.Text And txtc15.Text <> "" Or txtd15.Text = txta15.Text And txta15.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd15.Clear()
            txtd15.Focus()
        End If
        If txtd15.Text <> "1" And txtd15.Text <> "2" And txtd15.Text <> "3" And txtd15.Text <> "4" And txtd15.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd15.Clear()
            txtd15.Focus()
        End If
    End Sub

    Private Sub txta16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta16.TextChanged
        If txtb16.Text = txta16.Text And txtb16.Text <> "" Or txtc16.Text = txta16.Text And txtc16.Text <> "" Or txtd16.Text = txta16.Text And txtd16.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta16.Clear()
            txta16.Focus()
        End If
        If txta16.Text <> "1" And txta16.Text <> "2" And txta16.Text <> "3" And txta16.Text <> "4" And txta16.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta16.Clear()
            txta16.Focus()
        End If
    End Sub

    Private Sub txtb16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb16.TextChanged
        If txtb16.Text = txta16.Text And txta16.Text <> "" Or txtc16.Text = txtb16.Text And txtc16.Text <> "" Or txtd16.Text = txtb16.Text And txtd16.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb16.Clear()
            txtb16.Focus()
        End If
        If txtb16.Text <> "1" And txtb16.Text <> "2" And txtb16.Text <> "3" And txtb16.Text <> "4" And txtb16.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb16.Clear()
            txtb16.Focus()
        End If
    End Sub

    Private Sub txtc16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc16.TextChanged
        If txtb16.Text = txtc16.Text And txtb16.Text <> "" Or txtc16.Text = txta16.Text And txta16.Text <> "" Or txtd16.Text = txtc16.Text And txtd16.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc16.Clear()
            txtc16.Focus()
        End If
        If txtc16.Text <> "1" And txtc16.Text <> "2" And txtc16.Text <> "3" And txtc16.Text <> "4" And txtc16.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc16.Clear()
            txtc16.Focus()
        End If
    End Sub

    Private Sub txtd16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd16.TextChanged
        If txtb16.Text = txtd16.Text And txtb16.Text <> "" Or txtc16.Text = txtd16.Text And txtc16.Text <> "" Or txtd16.Text = txta16.Text And txta16.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd16.Clear()
            txtd16.Focus()
        End If
        If txtd16.Text <> "1" And txtd16.Text <> "2" And txtd16.Text <> "3" And txtd16.Text <> "4" And txtd16.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd16.Clear()
            txtd16.Focus()
        End If
    End Sub

    Private Sub txta17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta17.TextChanged
        If txtb17.Text = txta17.Text And txtb17.Text <> "" Or txtc17.Text = txta17.Text And txtc17.Text <> "" Or txtd17.Text = txta17.Text And txtd17.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta17.Clear()
            txta17.Focus()
        End If
        If txta17.Text <> "1" And txta17.Text <> "2" And txta17.Text <> "3" And txta17.Text <> "4" And txta17.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta17.Clear()
            txta17.Focus()
        End If
    End Sub

    Private Sub txtb17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb17.TextChanged
        If txtb17.Text = txta17.Text And txta17.Text <> "" Or txtc17.Text = txtb17.Text And txtc17.Text <> "" Or txtd17.Text = txtb17.Text And txtd17.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb17.Clear()
            txtb17.Focus()
        End If
        If txtb17.Text <> "1" And txtb17.Text <> "2" And txtb17.Text <> "3" And txtb17.Text <> "4" And txtb17.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb17.Clear()
            txtb17.Focus()
        End If
    End Sub

    Private Sub txtc17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc17.TextChanged
        If txtb17.Text = txtc17.Text And txtb17.Text <> "" Or txtc17.Text = txta17.Text And txta17.Text <> "" Or txtd17.Text = txtc17.Text And txtd17.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc17.Clear()
            txtc17.Focus()
        End If
        If txtc17.Text <> "1" And txtc17.Text <> "2" And txtc17.Text <> "3" And txtc17.Text <> "4" And txtc17.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc17.Clear()
            txtc17.Focus()
        End If
    End Sub

    Private Sub txtd17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd17.TextChanged
        If txtb17.Text = txtd17.Text And txtb17.Text <> "" Or txtc17.Text = txtd17.Text And txtc17.Text <> "" Or txtd17.Text = txta17.Text And txta17.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd17.Clear()
            txtd17.Focus()
        End If
        If txtd17.Text <> "1" And txtd17.Text <> "2" And txtd17.Text <> "3" And txtd17.Text <> "4" And txtd17.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd17.Clear()
            txtd17.Focus()
        End If
    End Sub

    Private Sub txta18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta18.TextChanged
        If txtb18.Text = txta18.Text And txtb18.Text <> "" Or txtc18.Text = txta18.Text And txtc18.Text <> "" Or txtd18.Text = txta18.Text And txtd18.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta18.Clear()
            txta18.Focus()
        End If
        If txta18.Text <> "1" And txta18.Text <> "2" And txta18.Text <> "3" And txta18.Text <> "4" And txta18.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta18.Clear()
            txta18.Focus()
        End If
    End Sub

    Private Sub txtb18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb18.TextChanged
        If txtb18.Text = txta18.Text And txta18.Text <> "" Or txtc18.Text = txtb18.Text And txtc18.Text <> "" Or txtd18.Text = txtb18.Text And txtd18.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb18.Clear()
            txtb18.Focus()
        End If
        If txtb18.Text <> "1" And txtb18.Text <> "2" And txtb18.Text <> "3" And txtb18.Text <> "4" And txtb18.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb18.Clear()
            txtb18.Focus()
        End If
    End Sub

    Private Sub txtc18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc18.TextChanged
        If txtb18.Text = txtc18.Text And txtb18.Text <> "" Or txtc18.Text = txta18.Text And txta18.Text <> "" Or txtd18.Text = txtc18.Text And txtd18.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc18.Clear()
            txtc18.Focus()
        End If
        If txtc18.Text <> "1" And txtc18.Text <> "2" And txtc18.Text <> "3" And txtc18.Text <> "4" And txtc18.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc18.Clear()
            txtc18.Focus()
        End If
    End Sub

    Private Sub txtd18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd18.TextChanged
        If txtb18.Text = txtd18.Text And txtb18.Text <> "" Or txtc18.Text = txtd18.Text And txtc18.Text <> "" Or txtd18.Text = txta18.Text And txta18.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd18.Clear()
            txtd18.Focus()
        End If
        If txtd18.Text <> "1" And txtd18.Text <> "2" And txtd18.Text <> "3" And txtd18.Text <> "4" And txtd18.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd18.Clear()
            txtd18.Focus()
        End If
    End Sub

    Private Sub txta19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta19.TextChanged
        If txtb19.Text = txta19.Text And txtb19.Text <> "" Or txtc19.Text = txta19.Text And txtc19.Text <> "" Or txtd19.Text = txta19.Text And txtd19.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta19.Clear()
            txta19.Focus()
        End If
        If txta19.Text <> "1" And txta19.Text <> "2" And txta19.Text <> "3" And txta19.Text <> "4" And txta19.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta19.Clear()
            txta19.Focus()
        End If
    End Sub

    Private Sub txtb19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb19.TextChanged
        If txtb19.Text = txta19.Text And txta19.Text <> "" Or txtc19.Text = txtb19.Text And txtc19.Text <> "" Or txtd19.Text = txtb19.Text And txtd19.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb19.Clear()
            txtb19.Focus()
        End If
        If txtb19.Text <> "1" And txtb19.Text <> "2" And txtb19.Text <> "3" And txtb19.Text <> "4" And txtb19.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb19.Clear()
            txtb19.Focus()
        End If
    End Sub

    Private Sub txtc19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc19.TextChanged
        If txtb19.Text = txtc19.Text And txtb19.Text <> "" Or txtc19.Text = txta19.Text And txta19.Text <> "" Or txtd19.Text = txtc19.Text And txtd19.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc19.Clear()
            txtc19.Focus()
        End If
        If txtc19.Text <> "1" And txtc19.Text <> "2" And txtc19.Text <> "3" And txtc19.Text <> "4" And txtc19.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc19.Clear()
            txtc19.Focus()
        End If
    End Sub

    Private Sub txtd19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd19.TextChanged
        If txtb19.Text = txtd19.Text And txtb19.Text <> "" Or txtc19.Text = txtd19.Text And txtc19.Text <> "" Or txtd19.Text = txta19.Text And txta19.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd19.Clear()
            txtd19.Focus()
        End If
        If txtd19.Text <> "1" And txtd19.Text <> "2" And txtd19.Text <> "3" And txtd19.Text <> "4" And txtd19.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd19.Clear()
            txtd19.Focus()
        End If
    End Sub

    Private Sub txta20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta20.TextChanged
        If txtb20.Text = txta20.Text And txtb20.Text <> "" Or txtc20.Text = txta20.Text And txtc20.Text <> "" Or txtd20.Text = txta20.Text And txtd20.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta20.Clear()
            txta20.Focus()
        End If
        If txta20.Text <> "1" And txta20.Text <> "2" And txta20.Text <> "3" And txta20.Text <> "4" And txta20.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txta20.Clear()
            txta20.Focus()
        End If
    End Sub

    Private Sub txtb20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb20.TextChanged
        If txtb20.Text = txta20.Text And txta20.Text <> "" Or txtc20.Text = txtb20.Text And txtc20.Text <> "" Or txtd20.Text = txtb20.Text And txtd20.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb20.Clear()
            txtb20.Focus()
        End If
        If txtb20.Text <> "1" And txtb20.Text <> "2" And txtb20.Text <> "3" And txtb20.Text <> "4" And txtb20.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtb20.Clear()
            txtb20.Focus()
        End If
    End Sub

    Private Sub txtc20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc20.TextChanged
        If txtb20.Text = txtc20.Text And txtb20.Text <> "" Or txtc20.Text = txta20.Text And txta20.Text <> "" Or txtd20.Text = txtc20.Text And txtd20.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc20.Clear()
            txtc20.Focus()
        End If
        If txtc20.Text <> "1" And txtc20.Text <> "2" And txtc20.Text <> "3" And txtc20.Text <> "4" And txtc20.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtc20.Clear()
            txtc20.Focus()
        End If
    End Sub

    Private Sub txtd20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtd20.TextChanged
        If txtb20.Text = txtd20.Text And txtb20.Text <> "" Or txtc20.Text = txtd20.Text And txtc20.Text <> "" Or txtd20.Text = txta20.Text And txta20.Text <> "" Then
            MessageBox.Show("Ya ingresaste ese número en otra opción, utiliza otro número valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd20.Clear()
            txtd20.Focus()
        End If
        If txtd20.Text <> "1" And txtd20.Text <> "2" And txtd20.Text <> "3" And txtd20.Text <> "4" And txtd20.Text <> "" Then
            MessageBox.Show("Solo puedes ingresar números del 1 al 4", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtd20.Clear()
            txtd20.Focus()
        End If
    End Sub
End Class