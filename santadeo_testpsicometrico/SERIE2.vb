Imports System.Data.SqlClient

Public Class SERIE2

    Private Sub SERIE2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Label1.Select()
        Try
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1491 Then '1491
                Me.Location = New Point(0, (height / 2) - 433)
                Me.MaximumSize = New Size(width, 867)
                Me.MinimumSize = New Size(width, 867)
                Me.Size = New System.Drawing.Size(width, 867)
            End If
            If height < 867 Then '867
                Me.Location = New Point((width / 2) - 745, 0)
                Me.MaximumSize = New Size(1491, height - 45)
                Me.MinimumSize = New Size(1491, height - 45)
                Me.Size = New System.Drawing.Size(1491, height - 45)
            End If
            If width < 1491 And height < 867 Then
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
            '***********************************
            If RadioButton8.Checked = True Then
                resp1 = "A"
            End If
            If RadioButton7.Checked = True Then
                resp1 = "B"
            End If
            If RadioButton6.Checked = True Then
                resp1 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
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
            '************************************
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
            '***********************************
            If RadioButton20.Checked = True Then
                resp4 = "A"
            End If
            If RadioButton19.Checked = True Then
                resp4 = "B"
            End If
            If RadioButton18.Checked = True Then
                resp4 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton24.Checked = True Then
                resp5 = "A"
            End If
            If RadioButton23.Checked = True Then
                resp5 = "B"
            End If
            If RadioButton22.Checked = True Then
                resp5 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton28.Checked = True Then
                resp6 = "A"
            End If
            If RadioButton27.Checked = True Then
                resp6 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton26.Checked = True Then
                resp6 = "C"
            End If
            '***********************************
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
            '***********************************
            If RadioButton36.Checked = True Then
                resp8 = "A"
            End If
            If RadioButton35.Checked = True Then
                resp8 = "B"
            End If
            If RadioButton34.Checked = True Then
                resp8 = "C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            '***********************************
            If RadioButton40.Checked = True Then
                resp9 = "A"
            End If
            If RadioButton39.Checked = True Then
                resp9 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton38.Checked = True Then
                resp9 = "C"
            End If
            '***********************************
            If RadioButton44.Checked = True Then
                resp10 = "A"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton43.Checked = True Then
                resp10 = "B"
            End If
            If RadioButton42.Checked = True Then
                resp10 = "C"
            End If
            '***********************************
            If RadioButton48.Checked = True Then
                resp11 = "A"
            End If
            If RadioButton47.Checked = True Then
                resp11 = "B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If RadioButton46.Checked = True Then
                resp11 = "C"
            End If
            '***********************************
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr2_resp1 = @resp1,sr2_resp2 = @resp2,sr2_resp3 = @resp3,sr2_resp4 = @resp4,sr2_resp5 = @resp5,sr2_resp6 = @resp6,sr2_resp7 = @resp7,sr2_resp8 = @resp8,sr2_resp9 = @resp9,sr2_resp10 = @resp10,sr2_resp11 = @resp11 WHERE id_candidato = @id_test"
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
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Timer1.Stop()
                SERIE3.txtId.Text = txtId.Text
                SERIE3.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s2 = INSTRUCCIONES.total_Respuestas
            'MsgBox(INSTRUCCIONES.s2)
        End If
    End Sub

   
    Private Sub btguardar2_Click(sender As System.Object, e As System.EventArgs) Handles btguardar2.Click
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
        '***********************************
        If RadioButton8.Checked = True Then
            resp1 = "A"
        End If
        If RadioButton7.Checked = True Then
            resp1 = "B"
        End If
        If RadioButton6.Checked = True Then
            resp1 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
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
        '************************************
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
        '***********************************
        If RadioButton20.Checked = True Then
            resp4 = "A"
        End If
        If RadioButton19.Checked = True Then
            resp4 = "B"
        End If
        If RadioButton18.Checked = True Then
            resp4 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton24.Checked = True Then
            resp5 = "A"
        End If
        If RadioButton23.Checked = True Then
            resp5 = "B"
        End If
        If RadioButton22.Checked = True Then
            resp5 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton28.Checked = True Then
            resp6 = "A"
        End If
        If RadioButton27.Checked = True Then
            resp6 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton26.Checked = True Then
            resp6 = "C"
        End If
        '***********************************
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
        '***********************************
        If RadioButton36.Checked = True Then
            resp8 = "A"
        End If
        If RadioButton35.Checked = True Then
            resp8 = "B"
        End If
        If RadioButton34.Checked = True Then
            resp8 = "C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        '***********************************
        If RadioButton40.Checked = True Then
            resp9 = "A"
        End If
        If RadioButton39.Checked = True Then
            resp9 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton38.Checked = True Then
            resp9 = "C"
        End If
        '***********************************
        If RadioButton44.Checked = True Then
            resp10 = "A"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton43.Checked = True Then
            resp10 = "B"
        End If
        If RadioButton42.Checked = True Then
            resp10 = "C"
        End If
        '***********************************
        If RadioButton48.Checked = True Then
            resp11 = "A"
        End If
        If RadioButton47.Checked = True Then
            resp11 = "B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If RadioButton46.Checked = True Then
            resp11 = "C"
        End If
        '***********************************
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr2_resp1 = @resp1,sr2_resp2 = @resp2,sr2_resp3 = @resp3,sr2_resp4 = @resp4,sr2_resp5 = @resp5,sr2_resp6 = @resp6,sr2_resp7 = @resp7,sr2_resp8 = @resp8,sr2_resp9 = @resp9,sr2_resp10 = @resp10,sr2_resp11 = @resp11 WHERE id_candidato = @id_test"
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
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Timer1.Stop()
            SERIE3.txtId.Text = txtId.Text
            SERIE3.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Stop()
        End Try
        INSTRUCCIONES.s2 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s2)
        
    End Sub

    Private Sub btiniciar2_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar2.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar2.Visible = False
        lbmensaje.Visible = False
        Label1.Select()
    End Sub
End Class