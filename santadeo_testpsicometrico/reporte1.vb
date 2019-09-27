Imports System.Data.SqlClient
Imports System.IO


Public Class reporte1
    Dim variableControlError As Boolean = False
    Private Sub reporte1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistasDataSet2.rh_candidatos_empleos' Puede moverla o quitarla según sea necesario.
        Me.rh_candidatos_empleosTableAdapter.Fill(Me.VistasDataSet.rh_candidatos_empleos)
        Me.ReportViewer1.RefreshReport()
        NumRegistros()
        Me.ReportViewer3.RefreshReport()
    End Sub
    Function NumRegistros()
        abrir()
        ComboBox1.SelectedIndex = 0
        Try
            Dim comando As SqlCommand
            Dim lector As SqlDataReader
            comando = New SqlCommand("SELECT rh_nombre_candidato FROM rh_candidatos_empleos", conexiones)
            lector = comando.ExecuteReader
            While lector.Read
                ComboBox1.Items.Add(lector(0).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al obtener informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        menuMainST.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles ComboBox1.MouseEnter
        ToolTip3.SetToolTip(Me.ComboBox1, "Clic para mostrar candidatos")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button2.Text = "EXPERIENCIAS"
        variableControlError = False
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        If ComboBox1.SelectedIndex = 0 Then
            ReportViewer1.Select()
            Try
                If height >= 715 Then
                    Me.Location = New Point(0, 0)
                    Me.Size = New System.Drawing.Size(width, 715) 'esto es para ára si la ventana no cabe en la pantalla
                    ReportViewer1.Size = New System.Drawing.Size(width - 5, 650)
                Else
                    Me.WindowState = FormWindowState.Maximized
                    ReportViewer1.Size = New System.Drawing.Size(width - 5, height - 90)
                End If

                ReportViewer1.Visible = True
                ReportViewer2.Visible = False
                ReportViewer3.Visible = False
                Me.rh_candidatos_empleosTableAdapter.Fill(Me.VistasDataSet.rh_candidatos_empleos)
                Me.ReportViewer1.RefreshReport()
                btcurriculum.Visible = False
                Button2.Visible = False
                ReportViewer1.Select()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ReportViewer2.Select()
            Try
                If width >= 857 Then
                    Me.Size = New System.Drawing.Size(857, height - 45)
                    Me.Location = New Point((width / 2) - 428, 0)
                Else
                    Me.WindowState = FormWindowState.Maximized
                    ReportViewer2.Size = New System.Drawing.Size(width - 5, height - 90)
                End If

                ReportViewer2.Visible = True
                ReportViewer1.Visible = False
                ReportViewer3.Visible = False
                abrir()
                Dim id As Integer = selectid(ComboBox1.Text())
                ' MsgBox(id)
                Me.rh_test_merrilTableAdapter.Fill(Me.VistasDataSet.rh_test_merril, id)
                Me.ReportViewer2.RefreshReport()
                btcurriculum.Visible = True
                Button2.Visible = True
                ReportViewer2.Select()
            Catch ex As Exception
                ' MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If variableControlError = False Then
                    variableControlError = True
                    ComboBox1_SelectedIndexChanged(ComboBox1, New System.EventArgs)
                End If
            End Try

        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btcurriculum.Click
        Try
            Dim directorio As String = "\\SRVAGV\51.- Recursos Humanos\ITZAMAR\Curriculums"
            abrir()
            Dim archivo() As Byte
            Dim id As Integer = selectid(ComboBox1.Text())
            Dim query As String = "select rh_img_cand from rh_candidatos_curriculums where id_candidato=" & id & ""
            Dim comando As SqlCommand
            Dim lector As SqlDataReader
            comando = New SqlCommand(query, conexiones)
            lector = comando.ExecuteReader
            If lector.Read Then
                archivo = lector(0)
                If Not Directory.Exists(directorio) Then
                    Directory.CreateDirectory(directorio)
                End If
                File.WriteAllBytes(directorio + "\curriculum_" + ComboBox1.Text() + ".docx", archivo)


                MessageBox.Show("Descarga completada", "Operación realizada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Esta persona no cargo ningún curriculum", "No se encontró curriculum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Descargar el curriculum", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        Try
            If Button2.Text = "EXPERIENCIAS" Then
                ReportViewer3.Select()
                ReportViewer2.Visible = False
                ReportViewer1.Visible = False
                ReportViewer3.Visible = True
                abrir()
                Dim id As Integer = selectid(ComboBox1.Text())
                Me.rh_candidatos_explabTableAdapter.Fill_experiencias(Me.VistasDataSet.rh_candidatos_explab, id)
                Me.ReportViewer3.RefreshReport()
                Button2.Text = "RESULTADOS"
            Else
                Button2.Text = "EXPERIENCIAS"
                ReportViewer2.Select()
                If width >= 857 Then
                    Me.Size = New System.Drawing.Size(857, height - 45)
                    Me.Location = New Point((width / 2) - 428, 0)
                Else
                    Me.WindowState = FormWindowState.Maximized
                    ReportViewer2.Size = New System.Drawing.Size(width - 5, height - 90)
                End If

                ReportViewer2.Visible = True
                ReportViewer1.Visible = False
                ReportViewer3.Visible = False
                abrir()
                Dim id As Integer = selectid(ComboBox1.Text())
                Me.rh_test_merrilTableAdapter.Fill(Me.VistasDataSet.rh_test_merril, id)
                Me.ReportViewer2.RefreshReport()
                btcurriculum.Visible = True
                Button2.Visible = True
                ReportViewer2.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As System.EventArgs) Handles Button1.MouseEnter
        ToolTip1.SetToolTip(Me.Button1, "Cerrar sesión")
    End Sub

    Private Sub btcurriculum_MouseEnter(sender As Object, e As System.EventArgs) Handles btcurriculum.MouseEnter
        ToolTip2.SetToolTip(Me.btcurriculum, "Descargar curriculum")
    End Sub
End Class