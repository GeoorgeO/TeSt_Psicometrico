Imports System.Data.SqlClient

Public Class SERIE10

    Private Sub SERIE10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()

        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Try
            '1159; 641
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1159 Then '1159
                Me.Location = New Point(0, (height / 2) - 320)
                Me.MaximumSize = New Size(width, 641)
                Me.MinimumSize = New Size(width, 641)
                Me.Size = New System.Drawing.Size(width, 641)
            End If
            If height < 641 Then '641
                Me.Location = New Point((width / 2) - 579, 0)
                Me.MaximumSize = New Size(1159, height - 45)
                Me.MinimumSize = New Size(1159, height - 45)
                Me.Size = New System.Drawing.Size(1159, height - 45)
            End If
            If width < 1159 And height < 641 Then
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

        If Label15.Text = 4 Then '4
            Timer1.Stop()
            txt1.Text = txt1.Text.Replace(" "c, String.Empty)
            txt1.Text = txt1.Text.Replace(","c, String.Empty)

            txt2.Text = txt2.Text.Replace(" "c, String.Empty)
            txt2.Text = txt2.Text.Replace(","c, String.Empty)

            txt3.Text = txt3.Text.Replace(" "c, String.Empty)
            txt3.Text = txt3.Text.Replace(","c, String.Empty)

            txt4.Text = txt4.Text.Replace(" "c, String.Empty)
            txt4.Text = txt4.Text.Replace(","c, String.Empty)

            txt5.Text = txt5.Text.Replace(" "c, String.Empty)
            txt5.Text = txt5.Text.Replace(","c, String.Empty)

            txt6.Text = txt6.Text.Replace(" "c, String.Empty)
            txt6.Text = txt6.Text.Replace(","c, String.Empty)

            txt7.Text = txt7.Text.Replace(" "c, String.Empty)
            txt7.Text = txt7.Text.Replace(","c, String.Empty)

            txt8.Text = txt8.Text.Replace(" "c, String.Empty)
            txt8.Text = txt8.Text.Replace(","c, String.Empty)

            txt9.Text = txt9.Text.Replace(" "c, String.Empty)
            txt9.Text = txt9.Text.Replace(","c, String.Empty)

            txt10.Text = txt10.Text.Replace(" "c, String.Empty)
            txt10.Text = txt10.Text.Replace(","c, String.Empty)

            txt11.Text = txt11.Text.Replace(" "c, String.Empty)
            txt11.Text = txt11.Text.Replace(","c, String.Empty)

            If txt1.Text = "21" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt2.Text = "3338" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt3.Text = "64128" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt4.Text = "22" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt5.Text = "13131/4" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt6.Text = "2021" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt7.Text = "1/41/8" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt8.Text = "85.394.3" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt9.Text = "68" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt10.Text = "3334" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If txt11.Text = "25125" Then
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            'INSTRUCCIONES.total_Respuestas = 207
            Dim ci As Integer = 0
            If INSTRUCCIONES.total_Respuestas >= 67 And INSTRUCCIONES.total_Respuestas <= 69 Then
                ci = 80
            End If
            If INSTRUCCIONES.total_Respuestas >= 70 And INSTRUCCIONES.total_Respuestas <= 71 Then
                ci = 81
            End If
            If INSTRUCCIONES.total_Respuestas >= 72 And INSTRUCCIONES.total_Respuestas <= 74 Then
                ci = 82
            End If
            If INSTRUCCIONES.total_Respuestas >= 75 And INSTRUCCIONES.total_Respuestas <= 76 Then
                ci = 83
            End If
            If INSTRUCCIONES.total_Respuestas >= 77 And INSTRUCCIONES.total_Respuestas <= 80 Then
                ci = 84
            End If
            If INSTRUCCIONES.total_Respuestas >= 81 And INSTRUCCIONES.total_Respuestas <= 82 Then
                ci = 85
            End If
            If INSTRUCCIONES.total_Respuestas >= 83 And INSTRUCCIONES.total_Respuestas <= 85 Then
                ci = 86
            End If
            If INSTRUCCIONES.total_Respuestas = 86 Then
                ci = 87
            End If
            If INSTRUCCIONES.total_Respuestas >= 87 And INSTRUCCIONES.total_Respuestas <= 90 Then
                ci = 88
            End If
            If INSTRUCCIONES.total_Respuestas >= 91 And INSTRUCCIONES.total_Respuestas <= 93 Then
                ci = 89
            End If
            If INSTRUCCIONES.total_Respuestas >= 94 And INSTRUCCIONES.total_Respuestas <= 96 Then
                ci = 90
            End If
            If INSTRUCCIONES.total_Respuestas >= 97 And INSTRUCCIONES.total_Respuestas <= 99 Then
                ci = 91
            End If
            If INSTRUCCIONES.total_Respuestas >= 100 And INSTRUCCIONES.total_Respuestas <= 102 Then
                ci = 92
            End If
            If INSTRUCCIONES.total_Respuestas >= 103 And INSTRUCCIONES.total_Respuestas <= 104 Then
                ci = 93
            End If
            If INSTRUCCIONES.total_Respuestas >= 105 And INSTRUCCIONES.total_Respuestas <= 106 Then
                ci = 94
            End If
            If INSTRUCCIONES.total_Respuestas >= 107 And INSTRUCCIONES.total_Respuestas <= 110 Then
                ci = 95
            End If
            If INSTRUCCIONES.total_Respuestas >= 111 And INSTRUCCIONES.total_Respuestas <= 113 Then
                ci = 96
            End If
            If INSTRUCCIONES.total_Respuestas >= 114 And INSTRUCCIONES.total_Respuestas <= 116 Then
                ci = 97
            End If
            If INSTRUCCIONES.total_Respuestas >= 117 And INSTRUCCIONES.total_Respuestas <= 119 Then
                ci = 98
            End If
            If INSTRUCCIONES.total_Respuestas >= 120 And INSTRUCCIONES.total_Respuestas <= 123 Then
                ci = 99
            End If
            If INSTRUCCIONES.total_Respuestas >= 124 And INSTRUCCIONES.total_Respuestas <= 125 Then
                ci = 100
            End If
            If INSTRUCCIONES.total_Respuestas >= 126 And INSTRUCCIONES.total_Respuestas <= 129 Then
                ci = 101
            End If
            If INSTRUCCIONES.total_Respuestas >= 130 And INSTRUCCIONES.total_Respuestas <= 133 Then
                ci = 102
            End If
            If INSTRUCCIONES.total_Respuestas >= 134 And INSTRUCCIONES.total_Respuestas <= 137 Then
                ci = 103
            End If
            If INSTRUCCIONES.total_Respuestas >= 138 And INSTRUCCIONES.total_Respuestas <= 141 Then
                ci = 104
            End If
            If INSTRUCCIONES.total_Respuestas >= 142 And INSTRUCCIONES.total_Respuestas <= 145 Then
                ci = 105
            End If
            If INSTRUCCIONES.total_Respuestas >= 146 And INSTRUCCIONES.total_Respuestas <= 149 Then
                ci = 106
            End If
            If INSTRUCCIONES.total_Respuestas >= 150 And INSTRUCCIONES.total_Respuestas <= 153 Then
                ci = 107
            End If
            If INSTRUCCIONES.total_Respuestas >= 154 And INSTRUCCIONES.total_Respuestas <= 157 Then
                ci = 108
            End If
            If INSTRUCCIONES.total_Respuestas >= 158 And INSTRUCCIONES.total_Respuestas <= 159 Then
                ci = 109
            End If
            If INSTRUCCIONES.total_Respuestas >= 160 And INSTRUCCIONES.total_Respuestas <= 162 Then
                ci = 110
            End If
            If INSTRUCCIONES.total_Respuestas >= 163 And INSTRUCCIONES.total_Respuestas <= 166 Then
                ci = 111
            End If
            If INSTRUCCIONES.total_Respuestas = 167 Then
                ci = 112
            End If
            If INSTRUCCIONES.total_Respuestas >= 168 And INSTRUCCIONES.total_Respuestas <= 170 Then
                ci = 113
            End If
            If INSTRUCCIONES.total_Respuestas >= 171 And INSTRUCCIONES.total_Respuestas <= 173 Then
                ci = 114
            End If
            If INSTRUCCIONES.total_Respuestas >= 174 And INSTRUCCIONES.total_Respuestas <= 175 Then
                ci = 115
            End If
            If INSTRUCCIONES.total_Respuestas >= 176 And INSTRUCCIONES.total_Respuestas <= 177 Then
                ci = 116
            End If
            If INSTRUCCIONES.total_Respuestas >= 178 And INSTRUCCIONES.total_Respuestas <= 180 Then
                ci = 117
            End If
            If INSTRUCCIONES.total_Respuestas >= 181 And INSTRUCCIONES.total_Respuestas <= 183 Then
                ci = 118
            End If
            If INSTRUCCIONES.total_Respuestas >= 184 And INSTRUCCIONES.total_Respuestas <= 185 Then
                ci = 119
            End If
            If INSTRUCCIONES.total_Respuestas = 186 Then
                ci = 120
            End If
            If INSTRUCCIONES.total_Respuestas = 187 Then
                ci = 121
            End If
            If INSTRUCCIONES.total_Respuestas = 188 Then
                ci = 122
            End If
            If INSTRUCCIONES.total_Respuestas = 189 Then
                ci = 123
            End If
            If INSTRUCCIONES.total_Respuestas = 190 Then
                ci = 124
            End If
            If INSTRUCCIONES.total_Respuestas = 191 Then
                ci = 125
            End If
            If INSTRUCCIONES.total_Respuestas = 192 Then
                ci = 126
            End If
            If INSTRUCCIONES.total_Respuestas = 193 Then
                ci = 127
            End If
            If INSTRUCCIONES.total_Respuestas = 194 Then
                ci = 128
            End If
            If INSTRUCCIONES.total_Respuestas = 195 Then
                ci = 129
            End If
            If INSTRUCCIONES.total_Respuestas = 196 Then
                ci = 130
            End If
            If INSTRUCCIONES.total_Respuestas = 197 Then
                ci = 131
            End If
            If INSTRUCCIONES.total_Respuestas = 198 Then
                ci = 132
            End If
            If INSTRUCCIONES.total_Respuestas = 199 Then
                ci = 133
            End If
            If INSTRUCCIONES.total_Respuestas = 200 Then
                ci = 134
            End If
            If INSTRUCCIONES.total_Respuestas = 201 Then
                ci = 135
            End If
            If INSTRUCCIONES.total_Respuestas = 202 Then
                ci = 136
            End If
            If INSTRUCCIONES.total_Respuestas = 203 Then
                ci = 137
            End If
            If INSTRUCCIONES.total_Respuestas = 204 Then
                ci = 138
            End If
            If INSTRUCCIONES.total_Respuestas = 205 Then
                ci = 139
            End If
            If INSTRUCCIONES.total_Respuestas = 206 Then
                ci = 140
            End If
            If INSTRUCCIONES.total_Respuestas = 207 Then
                ci = 141
            End If
            'MsgBox(ci)
            TotalyCI(INSTRUCCIONES.total_Respuestas, ci)

            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=vistas_Campo;User ID=sa;Password=$3rv3r5q10621%")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr10_resp1 = @resp1,sr10_resp2 = @resp2,sr10_resp3 = @resp3,sr10_resp4 = @resp4,sr10_resp5 = @resp5,sr10_resp6 = @resp6,sr10_resp7 = @resp7,sr10_resp8 = @resp8,sr10_resp9 = @resp9,sr10_resp10 = @resp10,sr10_resp11 = @resp11 WHERE id_candidato = @id_test"
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
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()

                    End Using
                    cnx.Close()
                End Using
                INSTRUCCIONES.s10 = INSTRUCCIONES.total_Respuestas
                calculaRango(registro1.identificador)
                Timer1.Stop()
                End
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub btguardar10_Click(sender As System.Object, e As System.EventArgs) Handles btguardar10.Click
        txt1.Text = txt1.Text.Replace(" "c, String.Empty)
        txt1.Text = txt1.Text.Replace(","c, String.Empty)

        txt2.Text = txt2.Text.Replace(" "c, String.Empty)
        txt2.Text = txt2.Text.Replace(","c, String.Empty)

        txt3.Text = txt3.Text.Replace(" "c, String.Empty)
        txt3.Text = txt3.Text.Replace(","c, String.Empty)

        txt4.Text = txt4.Text.Replace(" "c, String.Empty)
        txt4.Text = txt4.Text.Replace(","c, String.Empty)

        txt5.Text = txt5.Text.Replace(" "c, String.Empty)
        txt5.Text = txt5.Text.Replace(","c, String.Empty)

        txt6.Text = txt6.Text.Replace(" "c, String.Empty)
        txt6.Text = txt6.Text.Replace(","c, String.Empty)

        txt7.Text = txt7.Text.Replace(" "c, String.Empty)
        txt7.Text = txt7.Text.Replace(","c, String.Empty)

        txt8.Text = txt8.Text.Replace(" "c, String.Empty)
        txt8.Text = txt8.Text.Replace(","c, String.Empty)

        txt9.Text = txt9.Text.Replace(" "c, String.Empty)
        txt9.Text = txt9.Text.Replace(","c, String.Empty)

        txt10.Text = txt10.Text.Replace(" "c, String.Empty)
        txt10.Text = txt10.Text.Replace(","c, String.Empty)

        txt11.Text = txt11.Text.Replace(" "c, String.Empty)
        txt11.Text = txt11.Text.Replace(","c, String.Empty)

        If txt1.Text = "21" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt2.Text = "3338" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt3.Text = "64128" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt4.Text = "22" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt5.Text = "13131/4" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt6.Text = "2021" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt7.Text = "1/41/8" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt8.Text = "85.394.3" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt9.Text = "68" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt10.Text = "3334" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If txt11.Text = "25125" Then
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        ' INSTRUCCIONES.total_Respuestas = 207
        ' MsgBox(INSTRUCCIONES.total_Respuestas)
        Dim ci As Integer = 0
        If INSTRUCCIONES.total_Respuestas >= 67 And INSTRUCCIONES.total_Respuestas <= 69 Then
            ci = 80
        End If
        If INSTRUCCIONES.total_Respuestas >= 70 And INSTRUCCIONES.total_Respuestas <= 71 Then
            ci = 81
        End If
        If INSTRUCCIONES.total_Respuestas >= 72 And INSTRUCCIONES.total_Respuestas <= 74 Then
            ci = 82
        End If
        If INSTRUCCIONES.total_Respuestas >= 75 And INSTRUCCIONES.total_Respuestas <= 76 Then
            ci = 83
        End If
        If INSTRUCCIONES.total_Respuestas >= 77 And INSTRUCCIONES.total_Respuestas <= 80 Then
            ci = 84
        End If
        If INSTRUCCIONES.total_Respuestas >= 81 And INSTRUCCIONES.total_Respuestas <= 82 Then
            ci = 85
        End If
        If INSTRUCCIONES.total_Respuestas >= 83 And INSTRUCCIONES.total_Respuestas <= 85 Then
            ci = 86
        End If
        If INSTRUCCIONES.total_Respuestas = 86 Then
            ci = 87
        End If
        If INSTRUCCIONES.total_Respuestas >= 87 And INSTRUCCIONES.total_Respuestas <= 90 Then
            ci = 88
        End If
        If INSTRUCCIONES.total_Respuestas >= 91 And INSTRUCCIONES.total_Respuestas <= 93 Then
            ci = 89
        End If
        If INSTRUCCIONES.total_Respuestas >= 94 And INSTRUCCIONES.total_Respuestas <= 96 Then
            ci = 90
        End If
        If INSTRUCCIONES.total_Respuestas >= 97 And INSTRUCCIONES.total_Respuestas <= 99 Then
            ci = 91
        End If
        If INSTRUCCIONES.total_Respuestas >= 100 And INSTRUCCIONES.total_Respuestas <= 102 Then
            ci = 92
        End If
        If INSTRUCCIONES.total_Respuestas >= 103 And INSTRUCCIONES.total_Respuestas <= 104 Then
            ci = 93
        End If
        If INSTRUCCIONES.total_Respuestas >= 105 And INSTRUCCIONES.total_Respuestas <= 106 Then
            ci = 94
        End If
        If INSTRUCCIONES.total_Respuestas >= 107 And INSTRUCCIONES.total_Respuestas <= 110 Then
            ci = 95
        End If
        If INSTRUCCIONES.total_Respuestas >= 111 And INSTRUCCIONES.total_Respuestas <= 113 Then
            ci = 96
        End If
        If INSTRUCCIONES.total_Respuestas >= 114 And INSTRUCCIONES.total_Respuestas <= 116 Then
            ci = 97
        End If
        If INSTRUCCIONES.total_Respuestas >= 117 And INSTRUCCIONES.total_Respuestas <= 119 Then
            ci = 98
        End If
        If INSTRUCCIONES.total_Respuestas >= 120 And INSTRUCCIONES.total_Respuestas <= 123 Then
            ci = 99
        End If
        If INSTRUCCIONES.total_Respuestas >= 124 And INSTRUCCIONES.total_Respuestas <= 125 Then
            ci = 100
        End If
        If INSTRUCCIONES.total_Respuestas >= 126 And INSTRUCCIONES.total_Respuestas <= 129 Then
            ci = 101
        End If
        If INSTRUCCIONES.total_Respuestas >= 130 And INSTRUCCIONES.total_Respuestas <= 133 Then
            ci = 102
        End If
        If INSTRUCCIONES.total_Respuestas >= 134 And INSTRUCCIONES.total_Respuestas <= 137 Then
            ci = 103
        End If
        If INSTRUCCIONES.total_Respuestas >= 138 And INSTRUCCIONES.total_Respuestas <= 141 Then
            ci = 104
        End If
        If INSTRUCCIONES.total_Respuestas >= 142 And INSTRUCCIONES.total_Respuestas <= 145 Then
            ci = 105
        End If
        If INSTRUCCIONES.total_Respuestas >= 146 And INSTRUCCIONES.total_Respuestas <= 149 Then
            ci = 106
        End If
        If INSTRUCCIONES.total_Respuestas >= 150 And INSTRUCCIONES.total_Respuestas <= 153 Then
            ci = 107
        End If
        If INSTRUCCIONES.total_Respuestas >= 154 And INSTRUCCIONES.total_Respuestas <= 157 Then
            ci = 108
        End If
        If INSTRUCCIONES.total_Respuestas >= 158 And INSTRUCCIONES.total_Respuestas <= 159 Then
            ci = 109
        End If
        If INSTRUCCIONES.total_Respuestas >= 160 And INSTRUCCIONES.total_Respuestas <= 162 Then
            ci = 110
        End If
        If INSTRUCCIONES.total_Respuestas >= 163 And INSTRUCCIONES.total_Respuestas <= 166 Then
            ci = 111
        End If
        If INSTRUCCIONES.total_Respuestas = 167 Then
            ci = 112
        End If
        If INSTRUCCIONES.total_Respuestas >= 168 And INSTRUCCIONES.total_Respuestas <= 170 Then
            ci = 113
        End If
        If INSTRUCCIONES.total_Respuestas >= 171 And INSTRUCCIONES.total_Respuestas <= 173 Then
            ci = 114
        End If
        If INSTRUCCIONES.total_Respuestas >= 174 And INSTRUCCIONES.total_Respuestas <= 175 Then
            ci = 115
        End If
        If INSTRUCCIONES.total_Respuestas >= 176 And INSTRUCCIONES.total_Respuestas <= 177 Then
            ci = 116
        End If
        If INSTRUCCIONES.total_Respuestas >= 178 And INSTRUCCIONES.total_Respuestas <= 180 Then
            ci = 117
        End If
        If INSTRUCCIONES.total_Respuestas >= 181 And INSTRUCCIONES.total_Respuestas <= 183 Then
            ci = 118
        End If
        If INSTRUCCIONES.total_Respuestas >= 184 And INSTRUCCIONES.total_Respuestas <= 185 Then
            ci = 119
        End If
        If INSTRUCCIONES.total_Respuestas = 186 Then
            ci = 120
        End If
        If INSTRUCCIONES.total_Respuestas = 187 Then
            ci = 121
        End If
        If INSTRUCCIONES.total_Respuestas = 188 Then
            ci = 122
        End If
        If INSTRUCCIONES.total_Respuestas = 189 Then
            ci = 123
        End If
        If INSTRUCCIONES.total_Respuestas = 190 Then
            ci = 124
        End If
        If INSTRUCCIONES.total_Respuestas = 191 Then
            ci = 125
        End If
        If INSTRUCCIONES.total_Respuestas = 192 Then
            ci = 126
        End If
        If INSTRUCCIONES.total_Respuestas = 193 Then
            ci = 127
        End If
        If INSTRUCCIONES.total_Respuestas = 194 Then
            ci = 128
        End If
        If INSTRUCCIONES.total_Respuestas = 195 Then
            ci = 129
        End If
        If INSTRUCCIONES.total_Respuestas = 196 Then
            ci = 130
        End If
        If INSTRUCCIONES.total_Respuestas = 197 Then
            ci = 131
        End If
        If INSTRUCCIONES.total_Respuestas = 198 Then
            ci = 132
        End If
        If INSTRUCCIONES.total_Respuestas = 199 Then
            ci = 133
        End If
        If INSTRUCCIONES.total_Respuestas = 200 Then
            ci = 134
        End If
        If INSTRUCCIONES.total_Respuestas = 201 Then
            ci = 135
        End If
        If INSTRUCCIONES.total_Respuestas = 202 Then
            ci = 136
        End If
        If INSTRUCCIONES.total_Respuestas = 203 Then
            ci = 137
        End If
        If INSTRUCCIONES.total_Respuestas = 204 Then
            ci = 138
        End If
        If INSTRUCCIONES.total_Respuestas = 205 Then
            ci = 139
        End If
        If INSTRUCCIONES.total_Respuestas = 206 Then
            ci = 140
        End If
        If INSTRUCCIONES.total_Respuestas = 207 Then
            ci = 141
        End If
        'MsgBox(ci)
        'calculaRango(registro1.identificador)
        TotalyCI(INSTRUCCIONES.total_Respuestas, ci)
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=vistas_Campo;User ID=sa;Password=$3rv3r5q10621%")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr10_resp1 = @resp1,sr10_resp2 = @resp2,sr10_resp3 = @resp3,sr10_resp4 = @resp4,sr10_resp5 = @resp5,sr10_resp6 = @resp6,sr10_resp7 = @resp7,sr10_resp8 = @resp8,sr10_resp9 = @resp9,sr10_resp10 = @resp10,sr10_resp11 = @resp11 WHERE id_candidato = @id_test"
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
                    cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                    cmd.ExecuteNonQuery()

                End Using
                cnx.Close()
            End Using
            calculaRango(registro1.identificador)
            Timer1.Stop()
            End
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s10 = INSTRUCCIONES.total_Respuestas
        
    End Sub

    Private Sub btinicio10_Click(sender As System.Object, e As System.EventArgs) Handles btinicio10.Click
        Timer1.Start()
        Panel1.Visible = True
        btinicio10.Visible = False
        lbmensaje.Visible = False
    End Sub
End Class