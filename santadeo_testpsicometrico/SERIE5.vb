Imports System.Data.SqlClient

Public Class SERIE5

    Private Sub SERIE5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"

        Timer1.Start()
        Try
            '1331; 685
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1331 Then '1331
                Me.Location = New Point(0, (height / 2) - 342)
                Me.MaximumSize = New Size(width, 685)
                Me.MinimumSize = New Size(width, 685)
                Me.Size = New System.Drawing.Size(width, 685)
            End If
            If height < 685 Then '685
                Me.Location = New Point((width / 2) - 665, 0)
                Me.MaximumSize = New Size(1331, height - 45)
                Me.MinimumSize = New Size(1331, height - 45)
                Me.Size = New System.Drawing.Size(1331, height - 45)
            End If
            If width < 1331 And height < 685 Then
                Me.Location = New Point(0, 0)
                Me.MaximumSize = New Size(width, height)
                Me.MinimumSize = New Size(width, height)
                Me.Size = New System.Drawing.Size(width, height - 45)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txt1.Text = "20" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt2.Text = "11" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt3.Text = "50" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt4.Text = "50" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt5.Text = "12" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt6.Text = "18" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt7.Text = "500" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt8.Text = "2" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt9.Text = "28" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt10.Text = "360" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt11.Text = "2" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt12.Text = "25" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr5_resp1 = @resp1,sr5_resp2 = @resp2,sr5_resp3 = @resp3,sr5_resp4 = @resp4,sr5_resp5 = @resp5,sr5_resp6 = @resp6,sr5_resp7 = @resp7,sr5_resp8 = @resp8,sr5_resp9 = @resp9,sr5_resp10 = @resp10,sr5_resp11 = @resp11,sr5_resp12 = @resp12 WHERE id_candidato = @id_test"
                    cmd.Parameters.AddWithValue("@resp1", txt1.Text)
                    cmd.Parameters.AddWithValue("@resp2", txt2.Text)
                    cmd.Parameters.AddWithValue("@resp3", txt3.Text)
                    cmd.Parameters.AddWithValue("@resp4", txt4.Text)
                    cmd.Parameters.AddWithValue("@resp5", txt5.Text)
                    cmd.Parameters.AddWithValue("@resp6", txt6.Text)
                    cmd.Parameters.AddWithValue("@resp7", txt7.Text)
                    cmd.Parameters.AddWithValue("@resp8", txt8.Text)
                    cmd.Parameters.AddWithValue("@resp9", txt9.Text)
                    cmd.Parameters.AddWithValue("@resp10", txt10.Text)
                    cmd.Parameters.AddWithValue("@resp11", txt11.Text)
                    cmd.Parameters.AddWithValue("@resp12", txt12.Text)
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Timer1.Stop()

            SERIE6.Show()
            Me.Close()
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s5 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s5)
        SERIE6.txtId.Text = txtId.Text
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

        If Label15.Text = 5 Then '5
            Timer1.Stop()
            If txt1.Text = "20" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt2.Text = "11" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt3.Text = "50" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt4.Text = "50" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt5.Text = "12" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt6.Text = "18" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt7.Text = "500" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt8.Text = "2" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt9.Text = "28" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt10.Text = "360" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt11.Text = "2" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt12.Text = "25" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If

            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr5_resp1 = @resp1,sr5_resp2 = @resp2,sr5_resp3 = @resp3,sr5_resp4 = @resp4,sr5_resp5 = @resp5,sr5_resp6 = @resp6,sr5_resp7 = @resp7,sr5_resp8 = @resp8,sr5_resp9 = @resp9,sr5_resp10 = @resp10,sr5_resp11 = @resp11,sr5_resp12 = @resp12 WHERE id_candidato = @id_test"
                        cmd.Parameters.AddWithValue("@resp1", txt1.Text)
                        cmd.Parameters.AddWithValue("@resp2", txt2.Text)
                        cmd.Parameters.AddWithValue("@resp3", txt3.Text)
                        cmd.Parameters.AddWithValue("@resp4", txt4.Text)
                        cmd.Parameters.AddWithValue("@resp5", txt5.Text)
                        cmd.Parameters.AddWithValue("@resp6", txt6.Text)
                        cmd.Parameters.AddWithValue("@resp7", txt7.Text)
                        cmd.Parameters.AddWithValue("@resp8", txt8.Text)
                        cmd.Parameters.AddWithValue("@resp9", txt9.Text)
                        cmd.Parameters.AddWithValue("@resp10", txt10.Text)
                        cmd.Parameters.AddWithValue("@resp11", txt11.Text)
                        cmd.Parameters.AddWithValue("@resp12", txt12.Text)
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                End Using
                Timer1.Stop()

                SERIE6.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s5 = INSTRUCCIONES.total_Respuestas
            'MsgBox(INSTRUCCIONES.s5)
            SERIE6.txtId.Text = txtId.Text
        End If
    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt4.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt5.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt6.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt7.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt8_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt8.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt9_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt9.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt10_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt10.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt11_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt11.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt12_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt12.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
        Else
            e.Handled = True
        End If
    End Sub
End Class