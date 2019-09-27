
Imports System.Data.SqlClient
Imports System.IO

Public Class registro1
    Public identificador As Integer = 0
    Public nombre, escolaridad, edad, puesto As String
    Dim clic As Boolean = False
    Dim vcurriculum As Boolean = False
    Dim controlExp As Boolean = False
    Dim Exp As Boolean = False

    Public Function guardararchivo(ByVal ruta As String, ByVal nombre As String)
        Dim fs As New FileStream(ruta, FileMode.Open) 'cargar el archivo
        Dim data(fs.Length - 1) As Byte
        fs.Read(data, 0, Convert.ToInt32(fs.Length - 1))
        identificador = selectid(TextBox1.Text)

        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "insert into rh_candidatos_curriculums (id_candidato,rh_curriculum,rh_img_cand) values (@id,@curriculum,@img)"
                    cmd.Parameters.AddWithValue("@id", identificador)
                    cmd.Parameters.AddWithValue("@curriculum", nombre)
                    cmd.Parameters.AddWithValue("@img", data)
                    cmd.ExecuteNonQuery()

                End Using
                cnx.Close()
            End Using
            vcurriculum = True
            MessageBox.Show("Tu curriculum se a agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar el Curriculum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            vcurriculum = False
        End Try
        fs.Dispose()
        fs.Close()
        Return Nothing
    End Function

    Private Sub registro1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbfecha.Text = CStr(Today)
        abrir()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        abrir()
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox10.Text <> "" And ComboBox1.Text <> "" Then
            Dim viaje, radico As String
            identificador = selectid(TextBox1.Text)
            If RadioButton1.Checked = True Then
                viaje = "si"
            Else
                viaje = "no"
            End If
            If RadioButton4.Checked = True Then
                radico = "si"
            Else
                radico = "no"
            End If
            Try
                Dim query4 As String = "select rh_nombre_candidato from rh_candidatos_empleos where rh_nombre_candidato='" & TextBox1.Text & "'"
                Dim comando4 As SqlCommand
                Dim lector4 As SqlDataReader
                comando4 = New SqlCommand(query4, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
                lector4 = comando4.ExecuteReader

                If lector4.Read = False Then
                    lector4.Close()
                    If TextBox9.Text = "" Then
                        TextBox9.Text = "0"
                    End If

                    If TextBox12.Text = "" Then
                        TextBox12.Text = "0"
                    End If

                    agregarcandidato(TextBox1.Text, DateTimePicker1.Text, TextBox5.Text, TextBox2.Text, TextBox6.Text, TextBox3.Text, TextBox7.Text, TextBox4.Text, TextBox8.Text, lbfecha.Text, TextBox10.Text, TextBox9.Text, viaje, radico, ComboBox1.Text, TextBox11.Text, ComboBox2.Text, TextBox12.Text)

                    identificador = selectid(TextBox1.Text)
                    f_test_zavic(identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text, 0, 0, 0, 0, 0, 0, 0, 0)

                    abrir()
                    Dim resultado As Integer
                    Dim query As String = "SELECT MAX(id_cleaver) FROM rh_test_cleaver"
                    Dim comando As SqlCommand
                    Dim lector As SqlDataReader
                    comando = New SqlCommand(query, conexiones)
                    lector = comando.ExecuteReader
                    If lector.Read Then
                        resultado = CInt(lector(0).ToString)
                    End If
                    lector.Close()
                    Dim idCleaver = CStr(resultado + 1)
                    agregar(CInt(idCleaver), identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text)

                    abrir()
                    Dim resultado2 As Integer
                    Dim query2 As String = "SELECT MAX(id_terman_merril) FROM rh_test_merril"
                    Dim comando2 As SqlCommand
                    Dim lector2 As SqlDataReader
                    comando2 = New SqlCommand(query2, conexiones)
                    lector2 = comando2.ExecuteReader
                    If lector2.Read Then
                        resultado2 = CInt(lector2(0).ToString)
                    End If
                    lector2.Close()
                    Dim idMerril = resultado2 + 1
                    insertar(idMerril, identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text)

                    controlExp = True
                    Exp = True
                Else
                    controlExp = False
                End If
                lector4.Close()
                Dim openFileDialog1 As New OpenFileDialog()
                openFileDialog1.Filter = "*.doc|*.docx"
                openFileDialog1.Title = "Selecciona tu curriculum en un formato de microsoft office word"
                Dim archivo, ruta As String
                ' Show the Dialog.
                ' If the user clicked OK in the dialog and 
                ' a .CUR file was selected, open it.
                If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    ' Assign the cursor in the Stream to the Form's Cursor property.
                    archivo = openFileDialog1.SafeFileName
                    ruta = openFileDialog1.FileName

                    guardararchivo(ruta, archivo)
                    If vcurriculum = True Then
                        lbcurriculum.Text = archivo
                        lbcurriculum.Visible = True
                        lbelimina.Visible = True
                        Button1.Enabled = False
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la conexión, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        Else
            MessageBox.Show("Llena los campos requeridos antes de cargar tu curriculum", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If clic = False Then
            gbexperiencias.Visible = True
            clic = True
        Else
            gbexperiencias.Visible = False
            clic = False
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox10.Text <> "" And ComboBox1.Text <> "" Then
            identificador = selectid(TextBox1.Text)
            abrir()
            Dim viaje, radico As String
            If RadioButton1.Checked = True Then
                viaje = "si"
            Else
                viaje = "no"
            End If
            If RadioButton4.Checked = True Then
                radico = "si"
            Else
                radico = "no"
            End If
            Try
                Dim query4 As String = "select rh_nombre_candidato from rh_candidatos_empleos where rh_nombre_candidato='" & TextBox1.Text & "'"
                Dim comando4 As SqlCommand
                Dim lector4 As SqlDataReader
                comando4 = New SqlCommand(query4, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
                lector4 = comando4.ExecuteReader

                If lector4.Read = False Then
                    If TextBox9.Text = "" Then
                        TextBox9.Text = "0"
                    End If

                    If TextBox12.Text = "" Then
                        TextBox12.Text = "0"
                    End If
                    lector4.Close()
                    agregarcandidato(TextBox1.Text, DateTimePicker1.Text, TextBox5.Text, TextBox2.Text, TextBox6.Text, TextBox3.Text, TextBox7.Text, TextBox4.Text, TextBox8.Text, lbfecha.Text, TextBox10.Text, TextBox9.Text, viaje, radico, ComboBox1.Text, TextBox11.Text, ComboBox2.Text, TextBox12.Text)
                    identificador = selectid(TextBox1.Text)
                    f_test_zavic(identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text, 0, 0, 0, 0, 0, 0, 0, 0)

                    abrir()
                    Dim resultado As Integer
                    Dim query As String = "SELECT MAX(id_cleaver) FROM rh_test_cleaver"
                    Dim comando As SqlCommand
                    Dim lector As SqlDataReader
                    comando = New SqlCommand(query, conexiones)
                    lector = comando.ExecuteReader
                    If lector.Read Then
                        resultado = CInt(lector(0).ToString)
                    End If
                    lector.Close()
                    Dim idCleaver = CStr(resultado + 1)
                    agregar(CInt(idCleaver), identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text)

                    abrir()
                    Dim resultado2 As Integer
                    Dim query2 As String = "SELECT MAX(id_terman_merril) FROM rh_test_merril"
                    Dim comando2 As SqlCommand
                    Dim lector2 As SqlDataReader
                    comando2 = New SqlCommand(query2, conexiones)
                    lector2 = comando2.ExecuteReader
                    If lector2.Read Then
                        resultado2 = CInt(lector2(0).ToString)
                    End If
                    lector2.Close()
                    Dim idMerril = resultado2 + 1
                    insertar(idMerril, identificador, TextBox1.Text, CDate(Date.Now.Date), ComboBox1.Text, TextBox5.Text, TextBox10.Text)

                Else
                    controlExp = True
                End If
                lector4.Close()

                If controlExp = True And Exp = True Or Exp = False And controlExp = False Then
                    If CheckBox1.Checked = True Then
                        registro(identificador, DateTimePicker2.Text, DateTimePicker7.Text, TextBox15.Text, TextBox16.Text, RichTextBox1.Text, TextBox17.Text, RichTextBox10.Text)
                    End If
                    If CheckBox2.Checked = True Then
                        registro(identificador, DateTimePicker3.Text, DateTimePicker8.Text, TextBox24.Text, TextBox23.Text, RichTextBox2.Text, TextBox22.Text, RichTextBox9.Text)
                    End If
                    If CheckBox3.Checked = True Then
                        registro(identificador, DateTimePicker4.Text, DateTimePicker9.Text, TextBox31.Text, TextBox30.Text, RichTextBox3.Text, TextBox29.Text, RichTextBox8.Text)
                    End If
                    If CheckBox4.Checked = True Then
                        registro(identificador, DateTimePicker4.Text, DateTimePicker10.Text, TextBox38.Text, TextBox37.Text, RichTextBox4.Text, TextBox36.Text, RichTextBox7.Text)
                    End If
                    If CheckBox5.Checked = True Then
                        registro(identificador, DateTimePicker6.Text, DateTimePicker11.Text, TextBox45.Text, TextBox44.Text, RichTextBox5.Text, TextBox43.Text, RichTextBox6.Text)
                    End If
                End If

                nombre = TextBox1.Text
                escolaridad = ComboBox1.Text
                edad = TextBox5.Text
                puesto = TextBox10.Text
                instruccion_preguntas.Show()
                Me.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar inforacion intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try

        Else
            MessageBox.Show("Llena los campos requeridos antes de continuar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    'bloque para expreriencia lab. 1------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox15.TextChanged
        If TextBox15.Text <> "" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    
    'bloque para expreriencia lab. 2------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox24_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox24.TextChanged
        If TextBox24.Text <> "" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
    End Sub

    
    'bloque para expreriencia lab. 3------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox31_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox31.TextChanged
        If TextBox31.Text <> "" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
    End Sub

    
    'bloque para expreriencia lab. 4------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox38_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox38.TextChanged
        If TextBox38.Text <> "" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
    End Sub

    
    'bloque para expreriencia lab. 5------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox45_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox45.TextChanged
        If TextBox45.Text <> "" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
    End Sub

    
    Private Sub lbelimina_Click(sender As System.Object, e As System.EventArgs) Handles lbelimina.Click
        lbcurriculum.Text = ""
        lbcurriculum.Visible = False
        lbelimina.Visible = False
        Button1.Enabled = True
        elimina_curriculum(identificador)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim año, mes, dia, Cedad As Integer
        año = DateTimePicker1.Value.Year
        mes = DateTimePicker1.Value.Month
        dia = DateTimePicker1.Value.Day
        Cedad = DateDiff(DateInterval.Year, DateTimePicker1.Value, Now.Date)
        Dim hoymes, hoydia As Integer
        hoymes = Now.Date.Month
        hoydia = Now.Date.Day
        If mes = hoymes Then
            If dia <= hoydia Then
                TextBox5.Text = Cedad
            Else
                TextBox5.Text = Cedad - 1
            End If
        End If
        If mes > hoymes Then
            TextBox5.Text = Cedad - 1
        End If
        If mes < hoymes Then
            TextBox5.Text = Cedad
        End If
    End Sub

    
    Private Sub lbelimina_MouseEnter(sender As Object, e As System.EventArgs) Handles lbelimina.MouseEnter
        ToolTip1.SetToolTip(Me.lbelimina, "Eliminar curriculum")
    End Sub

    
End Class