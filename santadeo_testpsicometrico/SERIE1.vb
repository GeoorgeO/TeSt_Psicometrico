Imports System.Data.SqlClient

Public Class SERIE1

    Private Sub SERIE1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()

        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"

        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        
        If width < 1341 Then '1341
            Me.Location = New Point(0, (height / 2) - 394)
            Me.MaximumSize = New Size(width, 789)
            Me.MinimumSize = New Size(width, 789)
            Me.Size = New System.Drawing.Size(width, 789)
        End If
        If height < 789 Then '789
            Me.Location = New Point((width / 2) - 670, 0)
            Me.MaximumSize = New Size(1341, height - 45)
            Me.MinimumSize = New Size(1341, height - 45)
            Me.Size = New System.Drawing.Size(1341, height - 45)
        End If
        If width < 1341 And height < 789 Then
            Me.Location = New Point(0, 0)
            Me.MaximumSize = New Size(width, height)
            Me.MinimumSize = New Size(width, height)
            Me.Size = New System.Drawing.Size(width, height - 45)
        End If
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
            If btnresp1.Checked = True Then
                resp1 = "A"
            End If
            If RadioButton7.Checked = True Then
                resp1 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton6.Checked = True Then
                resp1 = "C"
            End If
            If RadioButton5.Checked = True Then
                resp1 = "D"
            End If
            '************************************'
            If RadioButton12.Checked = True Then
                resp2 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton11.Checked = True Then
                resp2 = "B"
            End If
            If RadioButton10.Checked = True Then
                resp2 = "C"
            End If
            If RadioButton9.Checked = True Then
                resp2 = "D"
            End If
            '************************************'
            If RadioButton16.Checked = True Then
                resp3 = "A"
            End If
            If RadioButton15.Checked = True Then
                resp3 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton14.Checked = True Then
                resp3 = "C"
            End If
            If RadioButton13.Checked = True Then
                resp3 = "D"
            End If
            '************************************'
            If RadioButton20.Checked = True Then
                resp4 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton19.Checked = True Then
                resp4 = "B"
            End If
            If RadioButton18.Checked = True Then
                resp4 = "C"
            End If
            If RadioButton17.Checked = True Then
                resp4 = "D"
            End If
            '************************************'
            If RadioButton24.Checked = True Then
                resp5 = "A"
            End If
            If RadioButton23.Checked = True Then
                resp5 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton22.Checked = True Then
                resp5 = "C"
            End If
            If RadioButton21.Checked = True Then
                resp5 = "D"
            End If
            '************************************'
            If RadioButton28.Checked = True Then
                resp6 = "A"
            End If
            If RadioButton27.Checked = True Then
                resp6 = "B"
            End If
            If RadioButton26.Checked = True Then
                resp6 = "C"
            End If
            If RadioButton25.Checked = True Then
                resp6 = "D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '************************************'
            If RadioButton32.Checked = True Then
                resp7 = "A"
            End If
            If RadioButton31.Checked = True Then
                resp7 = "B"
            End If
            If RadioButton30.Checked = True Then
                resp7 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton29.Checked = True Then
                resp7 = "D"
            End If
            '************************************'
            If RadioButton36.Checked = True Then
                resp8 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton35.Checked = True Then
                resp8 = "B"
            End If
            If RadioButton34.Checked = True Then
                resp8 = "C"
            End If
            If RadioButton33.Checked = True Then
                resp8 = "D"
            End If
            '************************************'
            If RadioButton40.Checked = True Then
                resp9 = "A"
            End If
            If RadioButton39.Checked = True Then
                resp9 = "B"
            End If
            If RadioButton38.Checked = True Then
                resp9 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton37.Checked = True Then
                resp9 = "D"
            End If
            '************************************'
            If RadioButton44.Checked = True Then
                resp10 = "A"
            End If
            If RadioButton43.Checked = True Then
                resp10 = "B"
            End If
            If RadioButton42.Checked = True Then
                resp10 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton41.Checked = True Then
                resp10 = "D"
            End If
            '************************************'
            If RadioButton48.Checked = True Then
                resp11 = "A"
            End If
            If RadioButton47.Checked = True Then
                resp11 = "B"
            End If
            If RadioButton46.Checked = True Then
                resp11 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton45.Checked = True Then
                resp11 = "D"
            End If
            '************************************'
            If RadioButton52.Checked = True Then
                resp12 = "A"
            End If
            If RadioButton51.Checked = True Then
                resp12 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton50.Checked = True Then
                resp12 = "C"
            End If
            If RadioButton49.Checked = True Then
                resp12 = "D"
            End If
            '************************************'
            If RadioButton56.Checked = True Then
                resp13 = "A"
            End If
            If RadioButton55.Checked = True Then
                resp13 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton54.Checked = True Then
                resp13 = "C"
            End If
            If RadioButton53.Checked = True Then
                resp13 = "D"
            End If
            '************************************'
            If RadioButton60.Checked = True Then
                resp14 = "A"
            End If
            If RadioButton59.Checked = True Then
                resp14 = "B"
            End If
            If RadioButton58.Checked = True Then
                resp14 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton57.Checked = True Then
                resp14 = "D"
            End If
            '************************************'
            If RadioButton64.Checked = True Then
                resp15 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton63.Checked = True Then
                resp15 = "B"
            End If
            If RadioButton62.Checked = True Then
                resp15 = "C"
            End If
            If RadioButton61.Checked = True Then
                resp15 = "D"
            End If
            '************************************'
            If RadioButton68.Checked = True Then
                resp16 = "A"
            End If
            If RadioButton67.Checked = True Then
                resp16 = "B"
            End If
            If RadioButton66.Checked = True Then
                resp16 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton65.Checked = True Then
                resp16 = "D"
            End If
            '************************************'
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr1_resp1 = @resp1,sr1_resp2 = @resp2,sr1_resp3 = @resp3,sr1_resp4 = @resp4,sr1_resp5 = @resp5,sr1_resp6 = @resp6,sr1_resp7 = @resp7,sr1_resp8 = @resp8,sr1_resp9 = @resp9,sr1_resp10 = @resp10,sr1_resp11 = @resp11,sr1_resp12 = @resp12,sr1_resp13 = @resp13,sr1_resp14 = @resp14,sr1_resp15 = @resp15,sr1_resp16 = @resp16 WHERE id_candidato = @id_test"
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
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                End Using
                Timer1.Stop()
                SERIE2.txtId.Text = txtId.Text
                SERIE2.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Timer1.Stop()
            End Try
            INSTRUCCIONES.s1 = INSTRUCCIONES.total_Respuestas
            'MsgBox(INSTRUCCIONES.s1)

        End If
    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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
        If btnresp1.Checked = True Then
            resp1 = "A"
        End If
        If RadioButton7.Checked = True Then
            resp1 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton6.Checked = True Then
            resp1 = "C"
        End If
        If RadioButton5.Checked = True Then
            resp1 = "D"
        End If
        '************************************'
        If RadioButton12.Checked = True Then
            resp2 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton11.Checked = True Then
            resp2 = "B"
        End If
        If RadioButton10.Checked = True Then
            resp2 = "C"
        End If
        If RadioButton9.Checked = True Then
            resp2 = "D"
        End If
        '************************************'
        If RadioButton16.Checked = True Then
            resp3 = "A"
        End If
        If RadioButton15.Checked = True Then
            resp3 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton14.Checked = True Then
            resp3 = "C"
        End If
        If RadioButton13.Checked = True Then
            resp3 = "D"
        End If
        '************************************'
        If RadioButton20.Checked = True Then
            resp4 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton19.Checked = True Then
            resp4 = "B"
        End If
        If RadioButton18.Checked = True Then
            resp4 = "C"
        End If
        If RadioButton17.Checked = True Then
            resp4 = "D"
        End If
        '************************************'
        If RadioButton24.Checked = True Then
            resp5 = "A"
        End If
        If RadioButton23.Checked = True Then
            resp5 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton22.Checked = True Then
            resp5 = "C"
        End If
        If RadioButton21.Checked = True Then
            resp5 = "D"
        End If
        '************************************'
        If RadioButton28.Checked = True Then
            resp6 = "A"
        End If
        If RadioButton27.Checked = True Then
            resp6 = "B"
        End If
        If RadioButton26.Checked = True Then
            resp6 = "C"
        End If
        If RadioButton25.Checked = True Then
            resp6 = "D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '************************************'
        If RadioButton32.Checked = True Then
            resp7 = "A"
        End If
        If RadioButton31.Checked = True Then
            resp7 = "B"
        End If
        If RadioButton30.Checked = True Then
            resp7 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton29.Checked = True Then
            resp7 = "D"
        End If
        '************************************'
        If RadioButton36.Checked = True Then
            resp8 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton35.Checked = True Then
            resp8 = "B"
        End If
        If RadioButton34.Checked = True Then
            resp8 = "C"
        End If
        If RadioButton33.Checked = True Then
            resp8 = "D"
        End If
        '************************************'
        If RadioButton40.Checked = True Then
            resp9 = "A"
        End If
        If RadioButton39.Checked = True Then
            resp9 = "B"
        End If
        If RadioButton38.Checked = True Then
            resp9 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton37.Checked = True Then
            resp9 = "D"
        End If
        '************************************'
        If RadioButton44.Checked = True Then
            resp10 = "A"
        End If
        If RadioButton43.Checked = True Then
            resp10 = "B"
        End If
        If RadioButton42.Checked = True Then
            resp10 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton41.Checked = True Then
            resp10 = "D"
        End If
        '************************************'
        If RadioButton48.Checked = True Then
            resp11 = "A"
        End If
        If RadioButton47.Checked = True Then
            resp11 = "B"
        End If
        If RadioButton46.Checked = True Then
            resp11 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton45.Checked = True Then
            resp11 = "D"
        End If
        '************************************'
        If RadioButton52.Checked = True Then
            resp12 = "A"
        End If
        If RadioButton51.Checked = True Then
            resp12 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton50.Checked = True Then
            resp12 = "C"
        End If
        If RadioButton49.Checked = True Then
            resp12 = "D"
        End If
        '************************************'
        If RadioButton56.Checked = True Then
            resp13 = "A"
        End If
        If RadioButton55.Checked = True Then
            resp13 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton54.Checked = True Then
            resp13 = "C"
        End If
        If RadioButton53.Checked = True Then
            resp13 = "D"
        End If
        '************************************'
        If RadioButton60.Checked = True Then
            resp14 = "A"
        End If
        If RadioButton59.Checked = True Then
            resp14 = "B"
        End If
        If RadioButton58.Checked = True Then
            resp14 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton57.Checked = True Then
            resp14 = "D"
        End If
        '************************************'
        If RadioButton64.Checked = True Then
            resp15 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton63.Checked = True Then
            resp15 = "B"
        End If
        If RadioButton62.Checked = True Then
            resp15 = "C"
        End If
        If RadioButton61.Checked = True Then
            resp15 = "D"
        End If
        '************************************'
        If RadioButton68.Checked = True Then
            resp16 = "A"
        End If
        If RadioButton67.Checked = True Then
            resp16 = "B"
        End If
        If RadioButton66.Checked = True Then
            resp16 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton65.Checked = True Then
            resp16 = "D"
        End If
        '************************************'
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr1_resp1 = @resp1,sr1_resp2 = @resp2,sr1_resp3 = @resp3,sr1_resp4 = @resp4,sr1_resp5 = @resp5,sr1_resp6 = @resp6,sr1_resp7 = @resp7,sr1_resp8 = @resp8,sr1_resp9 = @resp9,sr1_resp10 = @resp10,sr1_resp11 = @resp11,sr1_resp12 = @resp12,sr1_resp13 = @resp13,sr1_resp14 = @resp14,sr1_resp15 = @resp15,sr1_resp16 = @resp16 WHERE id_candidato = @id_test"
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
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Timer1.Stop()
            SERIE2.txtId.Text = txtId.Text
            SERIE2.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Stop()
        End Try
        INSTRUCCIONES.s1 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s1)
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar.Visible = False
        lbmensaje.Visible=false
    End Sub
End Class