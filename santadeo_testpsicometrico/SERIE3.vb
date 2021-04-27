Imports System.Data.SqlClient

Public Class SERIE3

    Private Sub SERIE3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Try
            '1287; 683
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1287 Then '1287
                Me.Location = New Point(0, (height / 2) - 341)
                Me.MaximumSize = New Size(width, 683)
                Me.MinimumSize = New Size(width, 683)
                Me.Size = New System.Drawing.Size(width, 683)
            End If
            If height < 683 Then '683
                Me.Location = New Point((width / 2) - 643, 0)
                Me.MaximumSize = New Size(1287, height - 45)
                Me.MinimumSize = New Size(1287, height - 45)
                Me.Size = New System.Drawing.Size(1287, height - 45)
            End If
            If width < 1287 And height < 683 Then
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
            Dim resp19 As String = ""
            Dim resp20 As String = ""
            Dim resp21 As String = ""
            Dim resp22 As String = ""
            Dim resp23 As String = ""
            Dim resp24 As String = ""
            Dim resp25 As String = ""
            Dim resp26 As String = ""
            Dim resp27 As String = ""
            Dim resp28 As String = ""
            Dim resp29 As String = ""
            Dim resp30 As String = ""
            '************************
            If RadioButton6.Checked = True Then
                resp1 = "I"
            End If
            If RadioButton5.Checked = True Then
                resp1 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton8.Checked = True Then
                resp2 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton7.Checked = True Then
                resp2 = "O"
            End If
            '***********************************
            If RadioButton10.Checked = True Then
                resp3 = "I"
            End If
            If RadioButton9.Checked = True Then
                resp3 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton12.Checked = True Then
                resp4 = "I"
            End If
            If RadioButton11.Checked = True Then
                resp4 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton14.Checked = True Then
                resp5 = "I"
            End If
            If RadioButton13.Checked = True Then
                resp5 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton16.Checked = True Then
                resp6 = "I"
            End If
            If RadioButton15.Checked = True Then
                resp6 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton18.Checked = True Then
                resp7 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton17.Checked = True Then
                resp7 = "O"
            End If
            '***********************************
            If RadioButton20.Checked = True Then
                resp8 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton19.Checked = True Then
                resp8 = "O"
            End If
            '***********************************
            If RadioButton22.Checked = True Then
                resp9 = "I"
            End If
            If RadioButton21.Checked = True Then
                resp9 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton24.Checked = True Then
                resp10 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton23.Checked = True Then
                resp10 = "O"
            End If
            '***********************************
            If RadioButton26.Checked = True Then
                resp11 = "I"
            End If
            If RadioButton25.Checked = True Then
                resp11 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton28.Checked = True Then
                resp12 = "I"
            End If
            If RadioButton27.Checked = True Then
                resp12 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton30.Checked = True Then
                resp13 = "I"
            End If
            If RadioButton29.Checked = True Then
                resp13 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton32.Checked = True Then
                resp14 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton31.Checked = True Then
                resp14 = "O"
            End If
            '***********************************
            If RadioButton34.Checked = True Then
                resp15 = "I"
            End If
            If RadioButton33.Checked = True Then
                resp15 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton36.Checked = True Then
                resp16 = "I"
            End If
            If RadioButton35.Checked = True Then
                resp16 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton38.Checked = True Then
                resp17 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton37.Checked = True Then
                resp17 = "O"
            End If
            '***********************************
            If RadioButton40.Checked = True Then
                resp18 = "I"
            End If
            If RadioButton39.Checked = True Then
                resp18 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton42.Checked = True Then
                resp19 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton41.Checked = True Then
                resp19 = "O"
            End If
            '***********************************
            If RadioButton44.Checked = True Then
                resp20 = "I"
            End If
            If RadioButton43.Checked = True Then
                resp20 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton46.Checked = True Then
                resp21 = "I"
            End If
            If RadioButton45.Checked = True Then
                resp21 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton48.Checked = True Then
                resp22 = "I"
            End If
            If RadioButton47.Checked = True Then
                resp22 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton50.Checked = True Then
                resp23 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton49.Checked = True Then
                resp23 = "O"
            End If
            '***********************************
            If RadioButton52.Checked = True Then
                resp24 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton51.Checked = True Then
                resp24 = "O"
            End If
            '***********************************
            If RadioButton54.Checked = True Then
                resp25 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton53.Checked = True Then
                resp25 = "O"
            End If
            '***********************************
            If RadioButton56.Checked = True Then
                resp26 = "I"
            End If
            If RadioButton55.Checked = True Then
                resp26 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton58.Checked = True Then
                resp27 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton57.Checked = True Then
                resp27 = "O"
            End If
            '***********************************
            If RadioButton60.Checked = True Then
                resp28 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton59.Checked = True Then
                resp28 = "O"
            End If
            '***********************************
            If RadioButton62.Checked = True Then
                resp29 = "I"
            End If
            If RadioButton61.Checked = True Then
                resp29 = "O"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton64.Checked = True Then
                resp30 = "I"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton63.Checked = True Then
                resp30 = "O"
            End If
            '***********************************
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$d45q1w1n2#")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr3_resp1 = @resp1,sr3_resp2 = @resp2,sr3_resp3 = @resp3,sr3_resp4 = @resp4,sr3_resp5 = @resp5,sr3_resp6 = @resp6,sr3_resp7 = @resp7,sr3_resp8 = @resp8,sr3_resp9 = @resp9,sr3_resp10 = @resp10,sr3_resp11 = @resp11,sr3_resp12 = @resp12,sr3_resp13 = @resp13,sr3_resp14 = @resp14,sr3_resp15 = @resp15,sr3_resp16 = @resp16,sr3_resp17 = @resp17,sr3_resp18 = @resp18,sr3_resp19 = @resp19,sr3_resp20 = @resp20,sr3_resp21 = @resp21,sr3_resp22 = @resp22,sr3_resp23 = @resp23,sr3_resp24 = @resp24,sr3_resp25 = @resp25,sr3_resp26 = @resp26,sr3_resp27 = @resp27,sr3_resp28 = @resp28,sr3_resp29 = @resp29,sr3_resp30 = @resp30 WHERE id_candidato = @id_test"
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
                        cmd.Parameters.AddWithValue("@resp19", resp19)
                        cmd.Parameters.AddWithValue("@resp20", resp20)
                        cmd.Parameters.AddWithValue("@resp21", resp21)
                        cmd.Parameters.AddWithValue("@resp22", resp22)
                        cmd.Parameters.AddWithValue("@resp23", resp23)
                        cmd.Parameters.AddWithValue("@resp24", resp24)
                        cmd.Parameters.AddWithValue("@resp25", resp25)
                        cmd.Parameters.AddWithValue("@resp26", resp26)
                        cmd.Parameters.AddWithValue("@resp27", resp27)
                        cmd.Parameters.AddWithValue("@resp28", resp28)
                        cmd.Parameters.AddWithValue("@resp29", resp29)
                        cmd.Parameters.AddWithValue("@resp30", resp30)
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                End Using
                Timer1.Stop()
                SERIE4.txtId.Text = txtId.Text
                SERIE4.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s3 = INSTRUCCIONES.total_Respuestas
            'MsgBox(INSTRUCCIONES.s3)
            SERIE4.txtId.Text = txtId.Text
        End If
    End Sub

    Private Sub btguardar3_Click(sender As System.Object, e As System.EventArgs) Handles btguardar3.Click
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
        Dim resp19 As String = ""
        Dim resp20 As String = ""
        Dim resp21 As String = ""
        Dim resp22 As String = ""
        Dim resp23 As String = ""
        Dim resp24 As String = ""
        Dim resp25 As String = ""
        Dim resp26 As String = ""
        Dim resp27 As String = ""
        Dim resp28 As String = ""
        Dim resp29 As String = ""
        Dim resp30 As String = ""
        '************************
        If RadioButton6.Checked = True Then
            resp1 = "I"
        End If
        If RadioButton5.Checked = True Then
            resp1 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton8.Checked = True Then
            resp2 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton7.Checked = True Then
            resp2 = "O"
        End If
        '***********************************
        If RadioButton10.Checked = True Then
            resp3 = "I"
        End If
        If RadioButton9.Checked = True Then
            resp3 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton12.Checked = True Then
            resp4 = "I"
        End If
        If RadioButton11.Checked = True Then
            resp4 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton14.Checked = True Then
            resp5 = "I"
        End If
        If RadioButton13.Checked = True Then
            resp5 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton16.Checked = True Then
            resp6 = "I"
        End If
        If RadioButton15.Checked = True Then
            resp6 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton18.Checked = True Then
            resp7 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton17.Checked = True Then
            resp7 = "O"
        End If
        '***********************************
        If RadioButton20.Checked = True Then
            resp8 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton19.Checked = True Then
            resp8 = "O"
        End If
        '***********************************
        If RadioButton22.Checked = True Then
            resp9 = "I"
        End If
        If RadioButton21.Checked = True Then
            resp9 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton24.Checked = True Then
            resp10 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton23.Checked = True Then
            resp10 = "O"
        End If
        '***********************************
        If RadioButton26.Checked = True Then
            resp11 = "I"
        End If
        If RadioButton25.Checked = True Then
            resp11 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton28.Checked = True Then
            resp12 = "I"
        End If
        If RadioButton27.Checked = True Then
            resp12 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton30.Checked = True Then
            resp13 = "I"
        End If
        If RadioButton29.Checked = True Then
            resp13 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton32.Checked = True Then
            resp14 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton31.Checked = True Then
            resp14 = "O"
        End If
        '***********************************
        If RadioButton34.Checked = True Then
            resp15 = "I"
        End If
        If RadioButton33.Checked = True Then
            resp15 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton36.Checked = True Then
            resp16 = "I"
        End If
        If RadioButton35.Checked = True Then
            resp16 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton38.Checked = True Then
            resp17 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton37.Checked = True Then
            resp17 = "O"
        End If
        '***********************************
        If RadioButton40.Checked = True Then
            resp18 = "I"
        End If
        If RadioButton39.Checked = True Then
            resp18 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton42.Checked = True Then
            resp19 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton41.Checked = True Then
            resp19 = "O"
        End If
        '***********************************
        If RadioButton44.Checked = True Then
            resp20 = "I"
        End If
        If RadioButton43.Checked = True Then
            resp20 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton46.Checked = True Then
            resp21 = "I"
        End If
        If RadioButton45.Checked = True Then
            resp21 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton48.Checked = True Then
            resp22 = "I"
        End If
        If RadioButton47.Checked = True Then
            resp22 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton50.Checked = True Then
            resp23 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton49.Checked = True Then
            resp23 = "O"
        End If
        '***********************************
        If RadioButton52.Checked = True Then
            resp24 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton51.Checked = True Then
            resp24 = "O"
        End If
        '***********************************
        If RadioButton54.Checked = True Then
            resp25 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton53.Checked = True Then
            resp25 = "O"
        End If
        '***********************************
        If RadioButton56.Checked = True Then
            resp26 = "I"
        End If
        If RadioButton55.Checked = True Then
            resp26 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton58.Checked = True Then
            resp27 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton57.Checked = True Then
            resp27 = "O"
        End If
        '***********************************
        If RadioButton60.Checked = True Then
            resp28 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton59.Checked = True Then
            resp28 = "O"
        End If
        '***********************************
        If RadioButton62.Checked = True Then
            resp29 = "I"
        End If
        If RadioButton61.Checked = True Then
            resp29 = "O"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton64.Checked = True Then
            resp30 = "I"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton63.Checked = True Then
            resp30 = "O"
        End If
        '***********************************
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$d45q1w1n2#")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr3_resp1 = @resp1,sr3_resp2 = @resp2,sr3_resp3 = @resp3,sr3_resp4 = @resp4,sr3_resp5 = @resp5,sr3_resp6 = @resp6,sr3_resp7 = @resp7,sr3_resp8 = @resp8,sr3_resp9 = @resp9,sr3_resp10 = @resp10,sr3_resp11 = @resp11,sr3_resp12 = @resp12,sr3_resp13 = @resp13,sr3_resp14 = @resp14,sr3_resp15 = @resp15,sr3_resp16 = @resp16,sr3_resp17 = @resp17,sr3_resp18 = @resp18,sr3_resp19 = @resp19,sr3_resp20 = @resp20,sr3_resp21 = @resp21,sr3_resp22 = @resp22,sr3_resp23 = @resp23,sr3_resp24 = @resp24,sr3_resp25 = @resp25,sr3_resp26 = @resp26,sr3_resp27 = @resp27,sr3_resp28 = @resp28,sr3_resp29 = @resp29,sr3_resp30 = @resp30 WHERE id_candidato = @id_test"
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
                    cmd.Parameters.AddWithValue("@resp19", resp19)
                    cmd.Parameters.AddWithValue("@resp20", resp20)
                    cmd.Parameters.AddWithValue("@resp21", resp21)
                    cmd.Parameters.AddWithValue("@resp22", resp22)
                    cmd.Parameters.AddWithValue("@resp23", resp23)
                    cmd.Parameters.AddWithValue("@resp24", resp24)
                    cmd.Parameters.AddWithValue("@resp25", resp25)
                    cmd.Parameters.AddWithValue("@resp26", resp26)
                    cmd.Parameters.AddWithValue("@resp27", resp27)
                    cmd.Parameters.AddWithValue("@resp28", resp28)
                    cmd.Parameters.AddWithValue("@resp29", resp29)
                    cmd.Parameters.AddWithValue("@resp30", resp30)
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Timer1.Stop()

            SERIE4.Show()
            Me.Close()
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s3 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s3)
        SERIE4.txtId.Text = txtId.Text
    End Sub

    Private Sub btiniciar3_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar3.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar3.Visible = False
        lbmensaje.Visible = False

    End Sub
End Class