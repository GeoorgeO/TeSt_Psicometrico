Imports System.Data.SqlClient

Public Class SERIE6

    Private Sub SERIE6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Try
            '1250; 835
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1250 Then '1250
                Me.Location = New Point(0, (height / 2) - 417)
                Me.MaximumSize = New Size(width, 835)
                Me.MinimumSize = New Size(width, 835)
                Me.Size = New System.Drawing.Size(width, 835)
            End If
            If height < 835 Then '835
                Me.Location = New Point((width / 2) - 625, 0)
                Me.MaximumSize = New Size(1250, height - 45)
                Me.MinimumSize = New Size(1250, height - 45)
                Me.Size = New System.Drawing.Size(1250, height - 45)
            End If
            If width < 1250 And height < 683 Then
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
            '************************
            If RadioButton6.Checked = True Then
                resp1 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton5.Checked = True Then
                resp1 = "NO"
            End If
            '***********************************
            If RadioButton8.Checked = True Then
                resp2 = "SI"
            End If
            If RadioButton7.Checked = True Then
                resp2 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton10.Checked = True Then
                resp3 = "SI"
            End If
            If RadioButton9.Checked = True Then
                resp3 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton12.Checked = True Then
                resp4 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton11.Checked = True Then
                resp4 = "NO"
            End If
            '***********************************
            If RadioButton14.Checked = True Then
                resp5 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton13.Checked = True Then
                resp5 = "NO"
            End If
            '***********************************
            If RadioButton16.Checked = True Then
                resp6 = "SI"
            End If
            If RadioButton15.Checked = True Then
                resp6 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton18.Checked = True Then
                resp7 = "SI"
            End If
            If RadioButton17.Checked = True Then
                resp7 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton20.Checked = True Then
                resp8 = "SI"
            End If
            If RadioButton19.Checked = True Then
                resp8 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton22.Checked = True Then
                resp9 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton21.Checked = True Then
                resp9 = "NO"
            End If
            '***********************************
            If RadioButton24.Checked = True Then
                resp10 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton23.Checked = True Then
                resp10 = "NO"
            End If
            '***********************************
            If RadioButton26.Checked = True Then
                resp11 = "SI"
            End If
            If RadioButton25.Checked = True Then
                resp11 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton28.Checked = True Then
                resp12 = "SI"
            End If
            If RadioButton27.Checked = True Then
                resp12 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton30.Checked = True Then
                resp13 = "SI"
            End If
            If RadioButton29.Checked = True Then
                resp13 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton32.Checked = True Then
                resp14 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton31.Checked = True Then
                resp14 = "NO"
            End If
            '***********************************
            If RadioButton34.Checked = True Then
                resp15 = "SI"
            End If
            If RadioButton33.Checked = True Then
                resp15 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton36.Checked = True Then
                resp16 = "SI"
            End If
            If RadioButton35.Checked = True Then
                resp16 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton38.Checked = True Then
                resp17 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton37.Checked = True Then
                resp17 = "NO"
            End If
            '***********************************
            If RadioButton40.Checked = True Then
                resp18 = "SI"
            End If
            If RadioButton39.Checked = True Then
                resp18 = "NO"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton42.Checked = True Then
                resp19 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton41.Checked = True Then
                resp19 = "NO"
            End If
            '***********************************
            If RadioButton44.Checked = True Then
                resp20 = "SI"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton43.Checked = True Then
                resp20 = "NO"
            End If
            '***********************************
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr6_resp1 = @resp1,sr6_resp2 = @resp2,sr6_resp3 = @resp3,sr6_resp4 = @resp4,sr6_resp5 = @resp5,sr6_resp6 = @resp6,sr6_resp7 = @resp7,sr6_resp8 = @resp8,sr6_resp9 = @resp9,sr6_resp10 = @resp10,sr6_resp11 = @resp11,sr6_resp12 = @resp12,sr6_resp13 = @resp13,sr6_resp14 = @resp14,sr6_resp15 = @resp15,sr6_resp16 = @resp16,sr6_resp17 = @resp17,sr6_resp18 = @resp18,sr6_resp19 = @resp19,sr6_resp20 = @resp20 WHERE id_candidato = @id_test"
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
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                End Using
                Timer1.Stop()

                SERIE7.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s6 = INSTRUCCIONES.total_Respuestas
            ' MsgBox(INSTRUCCIONES.s6)
            SERIE7.txtId.Text = txtId.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btguardar6.Click
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
        '************************
        If RadioButton6.Checked = True Then
            resp1 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton5.Checked = True Then
            resp1 = "NO"
        End If
        '***********************************
        If RadioButton8.Checked = True Then
            resp2 = "SI"
        End If
        If RadioButton7.Checked = True Then
            resp2 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton10.Checked = True Then
            resp3 = "SI"
        End If
        If RadioButton9.Checked = True Then
            resp3 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton12.Checked = True Then
            resp4 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton11.Checked = True Then
            resp4 = "NO"
        End If
        '***********************************
        If RadioButton14.Checked = True Then
            resp5 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton13.Checked = True Then
            resp5 = "NO"
        End If
        '***********************************
        If RadioButton16.Checked = True Then
            resp6 = "SI"
        End If
        If RadioButton15.Checked = True Then
            resp6 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton18.Checked = True Then
            resp7 = "SI"
        End If
        If RadioButton17.Checked = True Then
            resp7 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton20.Checked = True Then
            resp8 = "SI"
        End If
        If RadioButton19.Checked = True Then
            resp8 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton22.Checked = True Then
            resp9 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton21.Checked = True Then
            resp9 = "NO"
        End If
        '***********************************
        If RadioButton24.Checked = True Then
            resp10 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton23.Checked = True Then
            resp10 = "NO"
        End If
        '***********************************
        If RadioButton26.Checked = True Then
            resp11 = "SI"
        End If
        If RadioButton25.Checked = True Then
            resp11 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton28.Checked = True Then
            resp12 = "SI"
        End If
        If RadioButton27.Checked = True Then
            resp12 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton30.Checked = True Then
            resp13 = "SI"
        End If
        If RadioButton29.Checked = True Then
            resp13 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton32.Checked = True Then
            resp14 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton31.Checked = True Then
            resp14 = "NO"
        End If
        '***********************************
        If RadioButton34.Checked = True Then
            resp15 = "SI"
        End If
        If RadioButton33.Checked = True Then
            resp15 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton36.Checked = True Then
            resp16 = "SI"
        End If
        If RadioButton35.Checked = True Then
            resp16 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton38.Checked = True Then
            resp17 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton37.Checked = True Then
            resp17 = "NO"
        End If
        '***********************************
        If RadioButton40.Checked = True Then
            resp18 = "SI"
        End If
        If RadioButton39.Checked = True Then
            resp18 = "NO"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton42.Checked = True Then
            resp19 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton41.Checked = True Then
            resp19 = "NO"
        End If
        '***********************************
        If RadioButton44.Checked = True Then
            resp20 = "SI"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton43.Checked = True Then
            resp20 = "NO"
        End If
        '***********************************
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr6_resp1 = @resp1,sr6_resp2 = @resp2,sr6_resp3 = @resp3,sr6_resp4 = @resp4,sr6_resp5 = @resp5,sr6_resp6 = @resp6,sr6_resp7 = @resp7,sr6_resp8 = @resp8,sr6_resp9 = @resp9,sr6_resp10 = @resp10,sr6_resp11 = @resp11,sr6_resp12 = @resp12,sr6_resp13 = @resp13,sr6_resp14 = @resp14,sr6_resp15 = @resp15,sr6_resp16 = @resp16,sr6_resp17 = @resp17,sr6_resp18 = @resp18,sr6_resp19 = @resp19,sr6_resp20 = @resp20 WHERE id_candidato = @id_test"
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
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Timer1.Stop()

            SERIE7.Show()
            Me.Close()
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s6 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s6)
        SERIE7.txtId.Text = txtId.Text
    End Sub

    
    Private Sub btiniciar6_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar6.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar6.Visible = False
        lbmensaje.Visible = False
        GroupBox3.Focus()
    End Sub
End Class