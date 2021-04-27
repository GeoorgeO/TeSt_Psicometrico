Imports System.Data.SqlClient

Public Class SERIE9

    Private Sub SERIE9_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()

        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Try
            '1320; 756
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1320 Then '1320
                Me.Location = New Point(0, (height / 2) - 378)
                Me.MaximumSize = New Size(width, 756)
                Me.MinimumSize = New Size(width, 756)
                Me.Size = New System.Drawing.Size(width, 756)
            End If
            If height < 756 Then '756
                Me.Location = New Point((width / 2) - 660, 0)
                Me.MaximumSize = New Size(1320, height - 45)
                Me.MinimumSize = New Size(1320, height - 45)
                Me.Size = New System.Drawing.Size(1320, height - 45)
            End If
            If width < 1320 And height < 756 Then
                Me.Location = New Point(0, 0)
                Me.MaximumSize = New Size(width, height)
                Me.MinimumSize = New Size(width, height)
                Me.Size = New System.Drawing.Size(width, height - 45)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 10
        Label17.Text += 1
        If Label17.Text = "60" Then
            Label16.Text += 1
            Label17.Text = 0
        End If
        If Label16.Text = 60 Then
            Label15.Text += 1
            Label16.Text = 0
        End If

        If Label15.Text = 2 Then '2
            Timer1.Stop()
            Dim resp1 As String = ""
            Dim resp2 As String = ""
            Dim resp3 As String = ""
            Dim resp4 As String = ""
            Dim resp5 As String = ""
            Dim resp6 As String = ""
            Dim resp7 As String = ""
            Dim resp8 As String = ""
            Dim resp9 As String = ""
            Dim resp10 As String = ""
            Dim resp11 As String = ""
            Dim resp12 As String = ""
            Dim resp13 As String = ""
            Dim resp14 As String = ""
            Dim resp15 As String = ""
            Dim resp16 As String = ""
            Dim resp17 As String = ""
            Dim resp18 As String = ""
            '************************
            If RadioButton15.Checked = True Then
                resp1 = "A"
            End If
            If RadioButton14.Checked = True Then
                resp1 = "B"
            End If
            If RadioButton13.Checked = True Then
                resp1 = "C"
            End If
            If RadioButton12.Checked = True Then
                resp1 = "D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton11.Checked = True Then
                resp1 = "E"
            End If
            '************************************
            If RadioButton20.Checked = True Then
                resp2 = "A"
            End If
            If RadioButton19.Checked = True Then
                resp2 = "B"
            End If
            If RadioButton18.Checked = True Then
                resp2 = "C"
            End If
            If RadioButton17.Checked = True Then
                resp2 = "D"
            End If
            If RadioButton16.Checked = True Then
                resp2 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton25.Checked = True Then
                resp3 = "A"
            End If
            If RadioButton24.Checked = True Then
                resp3 = "B"
            End If
            If RadioButton23.Checked = True Then
                resp3 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton22.Checked = True Then
                resp3 = "D"
            End If
            If RadioButton21.Checked = True Then
                resp3 = "E"
            End If
            '************************************
            If RadioButton30.Checked = True Then
                resp4 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton29.Checked = True Then
                resp4 = "B"
            End If
            If RadioButton28.Checked = True Then
                resp4 = "C"
            End If
            If RadioButton27.Checked = True Then
                resp4 = "D"
            End If
            If RadioButton26.Checked = True Then
                resp4 = "E"
            End If
            '************************************
            If RadioButton35.Checked = True Then
                resp5 = "A"
            End If
            If RadioButton34.Checked = True Then
                resp5 = "B"
            End If
            If RadioButton33.Checked = True Then
                resp5 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton32.Checked = True Then
                resp5 = "D"
            End If
            If RadioButton31.Checked = True Then
                resp5 = "E"
            End If
            '************************************
            If RadioButton40.Checked = True Then
                resp6 = "A"
            End If
            If RadioButton39.Checked = True Then
                resp6 = "B"
            End If
            If RadioButton38.Checked = True Then
                resp6 = "C"
            End If
            If RadioButton37.Checked = True Then
                resp6 = "D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton36.Checked = True Then
                resp6 = "E"
            End If
            '************************************
            If RadioButton45.Checked = True Then
                resp7 = "A"
            End If
            If RadioButton44.Checked = True Then
                resp7 = "B"
            End If
            If RadioButton43.Checked = True Then
                resp7 = "C"
            End If
            If RadioButton42.Checked = True Then
                resp7 = "D"
            End If
            If RadioButton41.Checked = True Then
                resp7 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton50.Checked = True Then
                resp8 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton49.Checked = True Then
                resp8 = "B"
            End If
            If RadioButton48.Checked = True Then
                resp8 = "C"
            End If
            If RadioButton47.Checked = True Then
                resp8 = "D"
            End If
            If RadioButton46.Checked = True Then
                resp8 = "E"
            End If
            '************************************
            If RadioButton55.Checked = True Then
                resp9 = "A"
            End If
            If RadioButton54.Checked = True Then
                resp9 = "B"
            End If
            If RadioButton53.Checked = True Then
                resp9 = "C"
            End If
            If RadioButton52.Checked = True Then
                resp9 = "D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton51.Checked = True Then
                resp9 = "E"
            End If
            '************************************
            If RadioButton60.Checked = True Then
                resp10 = "A"
            End If
            If RadioButton59.Checked = True Then
                resp10 = "B"
            End If
            If RadioButton58.Checked = True Then
                resp10 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton57.Checked = True Then
                resp10 = "D"
            End If
            If RadioButton56.Checked = True Then
                resp10 = "E"
            End If
            '************************************
            If RadioButton65.Checked = True Then
                resp11 = "A"
            End If
            If RadioButton64.Checked = True Then
                resp11 = "B"
            End If
            If RadioButton63.Checked = True Then
                resp11 = "C"
            End If
            If RadioButton62.Checked = True Then
                resp11 = "D"
            End If
            If RadioButton61.Checked = True Then
                resp11 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton70.Checked = True Then
                resp12 = "A"
            End If
            If RadioButton69.Checked = True Then
                resp12 = "B"
            End If
            If RadioButton68.Checked = True Then
                resp12 = "C"
            End If
            If RadioButton67.Checked = True Then
                resp12 = "D"
            End If
            If RadioButton66.Checked = True Then
                resp12 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton75.Checked = True Then
                resp13 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton74.Checked = True Then
                resp13 = "B"
            End If
            If RadioButton73.Checked = True Then
                resp13 = "C"
            End If
            If RadioButton72.Checked = True Then
                resp13 = "D"
            End If
            If RadioButton71.Checked = True Then
                resp13 = "E"
            End If
            '************************************
            If RadioButton80.Checked = True Then
                resp14 = "A"
            End If
            If RadioButton79.Checked = True Then
                resp14 = "B"
            End If
            If RadioButton78.Checked = True Then
                resp14 = "C"
            End If
            If RadioButton77.Checked = True Then
                resp14 = "D"
            End If
            If RadioButton76.Checked = True Then
                resp14 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton85.Checked = True Then
                resp15 = "A"
            End If
            If RadioButton84.Checked = True Then
                resp15 = "B"
            End If
            If RadioButton83.Checked = True Then
                resp15 = "C"
            End If
            If RadioButton82.Checked = True Then
                resp15 = "D"
            End If
            If RadioButton81.Checked = True Then
                resp15 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            If RadioButton90.Checked = True Then
                resp16 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton89.Checked = True Then
                resp16 = "B"
            End If
            If RadioButton88.Checked = True Then
                resp16 = "C"
            End If
            If RadioButton87.Checked = True Then
                resp16 = "D"
            End If
            If RadioButton86.Checked = True Then
                resp16 = "E"
            End If
            '************************************
            If RadioButton95.Checked = True Then
                resp17 = "A"
            End If
            If RadioButton94.Checked = True Then
                resp17 = "B"
            End If
            If RadioButton93.Checked = True Then
                resp17 = "C"
            End If
            If RadioButton92.Checked = True Then
                resp17 = "D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton91.Checked = True Then
                resp17 = "E"
            End If
            '************************************
            If RadioButton100.Checked = True Then
                resp18 = "A"
            End If
            If RadioButton99.Checked = True Then
                resp18 = "B"
            End If
            If RadioButton98.Checked = True Then
                resp18 = "C"
            End If
            If RadioButton97.Checked = True Then
                resp18 = "D"
            End If
            If RadioButton96.Checked = True Then
                resp18 = "E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$d45q1w1n2#")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr9_resp1 = @resp1,sr9_resp2 = @resp2,sr9_resp3 = @resp3,sr9_resp4 = @resp4,sr9_resp5 = @resp5,sr9_resp6 = @resp6,sr9_resp7 = @resp7,sr9_resp8 = @resp8,sr9_resp9 = @resp9,sr9_resp10 = @resp10,sr9_resp11 = @resp11,sr9_resp12 = @resp12,sr9_resp13 = @resp13,sr9_resp14 = @resp14,sr9_resp15 = @resp15,sr9_resp16 = @resp16,sr9_resp17 = @resp17,sr9_resp18 = @resp18 WHERE id_candidato = @id_test"
                        cmd.Parameters.AddWithValue("@resp1", resp1)
                        cmd.Parameters.AddWithValue("@resp2", resp2)
                        cmd.Parameters.AddWithValue("@resp3", resp3)
                        cmd.Parameters.AddWithValue("@resp4", resp4)
                        cmd.Parameters.AddWithValue("@resp5", resp5)
                        cmd.Parameters.AddWithValue("@resp6", resp6)
                        cmd.Parameters.AddWithValue("@resp7", resp7)
                        cmd.Parameters.AddWithValue("@resp8", resp8)
                        cmd.Parameters.AddWithValue("@resp9", resp9)
                        cmd.Parameters.AddWithValue("@resp10", resp10)
                        cmd.Parameters.AddWithValue("@resp11", resp11)
                        cmd.Parameters.AddWithValue("@resp12", resp12)
                        cmd.Parameters.AddWithValue("@resp13", resp13)
                        cmd.Parameters.AddWithValue("@resp14", resp14)
                        cmd.Parameters.AddWithValue("@resp15", resp15)
                        cmd.Parameters.AddWithValue("@resp16", resp16)
                        cmd.Parameters.AddWithValue("@resp17", resp17)
                        cmd.Parameters.AddWithValue("@resp18", resp18)
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                End Using
                Timer1.Stop()

                SERIE10.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s9 = INSTRUCCIONES.total_Respuestas
            ' MsgBox(INSTRUCCIONES.s9)
            SERIE10.txtId.Text = txtId.Text
        End If
    End Sub

    Private Sub btguardar9_Click(sender As System.Object, e As System.EventArgs) Handles btguardar9.Click
        Dim resp1 As String = ""
        Dim resp2 As String = ""
        Dim resp3 As String = ""
        Dim resp4 As String = ""
        Dim resp5 As String = ""
        Dim resp6 As String = ""
        Dim resp7 As String = ""
        Dim resp8 As String = ""
        Dim resp9 As String = ""
        Dim resp10 As String = ""
        Dim resp11 As String = ""
        Dim resp12 As String = ""
        Dim resp13 As String = ""
        Dim resp14 As String = ""
        Dim resp15 As String = ""
        Dim resp16 As String = ""
        Dim resp17 As String = ""
        Dim resp18 As String = ""
        '************************
        If RadioButton15.Checked = True Then
            resp1 = "A"
        End If
        If RadioButton14.Checked = True Then
            resp1 = "B"
        End If
        If RadioButton13.Checked = True Then
            resp1 = "C"
        End If
        If RadioButton12.Checked = True Then
            resp1 = "D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton11.Checked = True Then
            resp1 = "E"
        End If
        '************************************
        If RadioButton20.Checked = True Then
            resp2 = "A"
        End If
        If RadioButton19.Checked = True Then
            resp2 = "B"
        End If
        If RadioButton18.Checked = True Then
            resp2 = "C"
        End If
        If RadioButton17.Checked = True Then
            resp2 = "D"
        End If
        If RadioButton16.Checked = True Then
            resp2 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton25.Checked = True Then
            resp3 = "A"
        End If
        If RadioButton24.Checked = True Then
            resp3 = "B"
        End If
        If RadioButton23.Checked = True Then
            resp3 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton22.Checked = True Then
            resp3 = "D"
        End If
        If RadioButton21.Checked = True Then
            resp3 = "E"
        End If
        '************************************
        If RadioButton30.Checked = True Then
            resp4 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton29.Checked = True Then
            resp4 = "B"
        End If
        If RadioButton28.Checked = True Then
            resp4 = "C"
        End If
        If RadioButton27.Checked = True Then
            resp4 = "D"
        End If
        If RadioButton26.Checked = True Then
            resp4 = "E"
        End If
        '************************************
        If RadioButton35.Checked = True Then
            resp5 = "A"
        End If
        If RadioButton34.Checked = True Then
            resp5 = "B"
        End If
        If RadioButton33.Checked = True Then
            resp5 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton32.Checked = True Then
            resp5 = "D"
        End If
        If RadioButton31.Checked = True Then
            resp5 = "E"
        End If
        '************************************
        If RadioButton40.Checked = True Then
            resp6 = "A"
        End If
        If RadioButton39.Checked = True Then
            resp6 = "B"
        End If
        If RadioButton38.Checked = True Then
            resp6 = "C"
        End If
        If RadioButton37.Checked = True Then
            resp6 = "D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton36.Checked = True Then
            resp6 = "E"
        End If
        '************************************
        If RadioButton45.Checked = True Then
            resp7 = "A"
        End If
        If RadioButton44.Checked = True Then
            resp7 = "B"
        End If
        If RadioButton43.Checked = True Then
            resp7 = "C"
        End If
        If RadioButton42.Checked = True Then
            resp7 = "D"
        End If
        If RadioButton41.Checked = True Then
            resp7 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton50.Checked = True Then
            resp8 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton49.Checked = True Then
            resp8 = "B"
        End If
        If RadioButton48.Checked = True Then
            resp8 = "C"
        End If
        If RadioButton47.Checked = True Then
            resp8 = "D"
        End If
        If RadioButton46.Checked = True Then
            resp8 = "E"
        End If
        '************************************
        If RadioButton55.Checked = True Then
            resp9 = "A"
        End If
        If RadioButton54.Checked = True Then
            resp9 = "B"
        End If
        If RadioButton53.Checked = True Then
            resp9 = "C"
        End If
        If RadioButton52.Checked = True Then
            resp9 = "D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton51.Checked = True Then
            resp9 = "E"
        End If
        '************************************
        If RadioButton60.Checked = True Then
            resp10 = "A"
        End If
        If RadioButton59.Checked = True Then
            resp10 = "B"
        End If
        If RadioButton58.Checked = True Then
            resp10 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton57.Checked = True Then
            resp10 = "D"
        End If
        If RadioButton56.Checked = True Then
            resp10 = "E"
        End If
        '************************************
        If RadioButton65.Checked = True Then
            resp11 = "A"
        End If
        If RadioButton64.Checked = True Then
            resp11 = "B"
        End If
        If RadioButton63.Checked = True Then
            resp11 = "C"
        End If
        If RadioButton62.Checked = True Then
            resp11 = "D"
        End If
        If RadioButton61.Checked = True Then
            resp11 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton70.Checked = True Then
            resp12 = "A"
        End If
        If RadioButton69.Checked = True Then
            resp12 = "B"
        End If
        If RadioButton68.Checked = True Then
            resp12 = "C"
        End If
        If RadioButton67.Checked = True Then
            resp12 = "D"
        End If
        If RadioButton66.Checked = True Then
            resp12 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton75.Checked = True Then
            resp13 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton74.Checked = True Then
            resp13 = "B"
        End If
        If RadioButton73.Checked = True Then
            resp13 = "C"
        End If
        If RadioButton72.Checked = True Then
            resp13 = "D"
        End If
        If RadioButton71.Checked = True Then
            resp13 = "E"
        End If
        '************************************
        If RadioButton80.Checked = True Then
            resp14 = "A"
        End If
        If RadioButton79.Checked = True Then
            resp14 = "B"
        End If
        If RadioButton78.Checked = True Then
            resp14 = "C"
        End If
        If RadioButton77.Checked = True Then
            resp14 = "D"
        End If
        If RadioButton76.Checked = True Then
            resp14 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton85.Checked = True Then
            resp15 = "A"
        End If
        If RadioButton84.Checked = True Then
            resp15 = "B"
        End If
        If RadioButton83.Checked = True Then
            resp15 = "C"
        End If
        If RadioButton82.Checked = True Then
            resp15 = "D"
        End If
        If RadioButton81.Checked = True Then
            resp15 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        If RadioButton90.Checked = True Then
            resp16 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton89.Checked = True Then
            resp16 = "B"
        End If
        If RadioButton88.Checked = True Then
            resp16 = "C"
        End If
        If RadioButton87.Checked = True Then
            resp16 = "D"
        End If
        If RadioButton86.Checked = True Then
            resp16 = "E"
        End If
        '************************************
        If RadioButton95.Checked = True Then
            resp17 = "A"
        End If
        If RadioButton94.Checked = True Then
            resp17 = "B"
        End If
        If RadioButton93.Checked = True Then
            resp17 = "C"
        End If
        If RadioButton92.Checked = True Then
            resp17 = "D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton91.Checked = True Then
            resp17 = "E"
        End If
        '************************************
        If RadioButton100.Checked = True Then
            resp18 = "A"
        End If
        If RadioButton99.Checked = True Then
            resp18 = "B"
        End If
        If RadioButton98.Checked = True Then
            resp18 = "C"
        End If
        If RadioButton97.Checked = True Then
            resp18 = "D"
        End If
        If RadioButton96.Checked = True Then
            resp18 = "E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$d45q1w1n2#")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr9_resp1 = @resp1,sr9_resp2 = @resp2,sr9_resp3 = @resp3,sr9_resp4 = @resp4,sr9_resp5 = @resp5,sr9_resp6 = @resp6,sr9_resp7 = @resp7,sr9_resp8 = @resp8,sr9_resp9 = @resp9,sr9_resp10 = @resp10,sr9_resp11 = @resp11,sr9_resp12 = @resp12,sr9_resp13 = @resp13,sr9_resp14 = @resp14,sr9_resp15 = @resp15,sr9_resp16 = @resp16,sr9_resp17 = @resp17,sr9_resp18 = @resp18 WHERE id_candidato = @id_test"
                    cmd.Parameters.AddWithValue("@resp1", resp1)
                    cmd.Parameters.AddWithValue("@resp2", resp2)
                    cmd.Parameters.AddWithValue("@resp3", resp3)
                    cmd.Parameters.AddWithValue("@resp4", resp4)
                    cmd.Parameters.AddWithValue("@resp5", resp5)
                    cmd.Parameters.AddWithValue("@resp6", resp6)
                    cmd.Parameters.AddWithValue("@resp7", resp7)
                    cmd.Parameters.AddWithValue("@resp8", resp8)
                    cmd.Parameters.AddWithValue("@resp9", resp9)
                    cmd.Parameters.AddWithValue("@resp10", resp10)
                    cmd.Parameters.AddWithValue("@resp11", resp11)
                    cmd.Parameters.AddWithValue("@resp12", resp12)
                    cmd.Parameters.AddWithValue("@resp13", resp13)
                    cmd.Parameters.AddWithValue("@resp14", resp14)
                    cmd.Parameters.AddWithValue("@resp15", resp15)
                    cmd.Parameters.AddWithValue("@resp16", resp16)
                    cmd.Parameters.AddWithValue("@resp17", resp17)
                    cmd.Parameters.AddWithValue("@resp18", resp18)
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Timer1.Stop()

            SERIE10.Show()
            Me.Close()
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s9 = INSTRUCCIONES.total_Respuestas
        ' MsgBox(INSTRUCCIONES.s9)
        SERIE10.txtId.Text = txtId.Text
    End Sub

    Private Sub btiniciar9_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar9.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar9.Visible = False
        lbmensaje.Visible = False
        GroupBox6.Focus()
    End Sub
End Class