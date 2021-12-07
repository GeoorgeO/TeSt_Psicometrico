Imports System.Data.SqlClient

Public Class SERIE4
    Dim bloque1 As Integer = 0
    Dim bloque2 As Integer = 0
    Dim bloque3 As Integer
    Dim bloque4 As Integer
    Dim bloque5 As Integer
    Dim bloque6 As Integer
    Dim bloque7 As Integer
    Dim bloque8 As Integer
    Dim bloque9 As Integer
    Dim bloque10 As Integer
    Dim bloque11 As Integer
    Dim bloque12 As Integer
    Dim bloque13 As Integer
    Dim bloque14 As Integer
    Dim bloque15 As Integer
    Dim bloque16 As Integer
    Dim bloque17 As Integer
    Dim bloque18 As Integer

    Private Sub SERIE4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label15.Text = "00"
        Label16.Text = "00"
        Label17.Text = "0"
        Try
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width

            If width < 1333 Then '1333; 
                Me.Location = New Point(0, (height / 2) - 480)
                Me.MaximumSize = New Size(width, 961)
                Me.MinimumSize = New Size(width, 961)
                Me.Size = New System.Drawing.Size(width, 961)
            End If
            If height < 961 Then '961
                Me.Location = New Point((width / 2) - 666, 0)
                Me.MaximumSize = New Size(1333, height - 45)
                Me.MinimumSize = New Size(1333, height - 45)
                Me.Size = New System.Drawing.Size(1333, height - 45)
            End If
            If width < 1333 And height < 961 Then
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

        If Label15.Text = 3 Then '3
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
            '*********************************
            If CheckBox10.Checked = True And CheckBox9.Checked = True Then
                resp1 = "A;B"
            End If
            If CheckBox10.Checked = True And CheckBox8.Checked = True Then
                resp1 = "A;C"
            End If
            If CheckBox10.Checked = True And CheckBox7.Checked = True Then
                resp1 = "A;D"
            End If
            If CheckBox10.Checked = True And CheckBox6.Checked = True Then
                resp1 = "A;E"
            End If
            If CheckBox9.Checked = True And CheckBox8.Checked = True Then
                resp1 = "B;C"
            End If
            If CheckBox9.Checked = True And CheckBox7.Checked = True Then
                resp1 = "B;D"
            End If
            If CheckBox9.Checked = True And CheckBox6.Checked = True Then
                resp1 = "B;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox8.Checked = True And CheckBox7.Checked = True Then
                resp1 = "C;D"
            End If
            If CheckBox8.Checked = True And CheckBox6.Checked = True Then
                resp1 = "C;E"
            End If
            If CheckBox7.Checked = True And CheckBox6.Checked = True Then
                resp1 = "D;E"
            End If
            '*************************************************************
            If CheckBox15.Checked = True And CheckBox14.Checked = True Then
                resp2 = "A;B"
            End If
            If CheckBox15.Checked = True And CheckBox13.Checked = True Then
                resp2 = "A;C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox15.Checked = True And CheckBox12.Checked = True Then
                resp2 = "A;D"
            End If
            If CheckBox15.Checked = True And CheckBox11.Checked = True Then
                resp2 = "A;E"
            End If
            If CheckBox14.Checked = True And CheckBox13.Checked = True Then
                resp2 = "B;C"
            End If
            If CheckBox14.Checked = True And CheckBox12.Checked = True Then
                resp2 = "B;D"
            End If
            If CheckBox14.Checked = True And CheckBox11.Checked = True Then
                resp2 = "B;E"
            End If
            If CheckBox13.Checked = True And CheckBox12.Checked = True Then
                resp2 = "C;D"
            End If
            If CheckBox13.Checked = True And CheckBox11.Checked = True Then
                resp2 = "C;E"
            End If
            If CheckBox12.Checked = True And CheckBox11.Checked = True Then
                resp2 = "D;E"
            End If
            '*************************************************************
            If CheckBox20.Checked = True And CheckBox19.Checked = True Then
                resp3 = "A;B"
            End If
            If CheckBox20.Checked = True And CheckBox18.Checked = True Then
                resp3 = "A;C"
            End If
            If CheckBox20.Checked = True And CheckBox17.Checked = True Then
                resp3 = "A;D"
            End If
            If CheckBox20.Checked = True And CheckBox16.Checked = True Then
                resp3 = "A;E"
            End If
            If CheckBox19.Checked = True And CheckBox18.Checked = True Then
                resp3 = "B;C"
            End If
            If CheckBox19.Checked = True And CheckBox17.Checked = True Then
                resp3 = "B;D"
            End If
            If CheckBox19.Checked = True And CheckBox16.Checked = True Then
                resp3 = "B;E"
            End If
            If CheckBox18.Checked = True And CheckBox17.Checked = True Then
                resp3 = "C;D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox18.Checked = True And CheckBox16.Checked = True Then
                resp3 = "C;E"
            End If
            If CheckBox17.Checked = True And CheckBox16.Checked = True Then
                resp3 = "D;E"
            End If
            '*************************************************************
            If CheckBox25.Checked = True And CheckBox24.Checked = True Then
                resp4 = "A;B"
            End If
            If CheckBox25.Checked = True And CheckBox23.Checked = True Then
                resp4 = "A;C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox25.Checked = True And CheckBox22.Checked = True Then
                resp4 = "A;D"
            End If
            If CheckBox25.Checked = True And CheckBox21.Checked = True Then
                resp4 = "A;E"
            End If
            If CheckBox24.Checked = True And CheckBox23.Checked = True Then
                resp4 = "B;C"
            End If
            If CheckBox24.Checked = True And CheckBox22.Checked = True Then
                resp4 = "B;D"
            End If
            If CheckBox24.Checked = True And CheckBox21.Checked = True Then
                resp4 = "B;E"
            End If
            If CheckBox23.Checked = True And CheckBox22.Checked = True Then
                resp4 = "C;D"
            End If
            If CheckBox23.Checked = True And CheckBox21.Checked = True Then
                resp4 = "C;E"
            End If
            If CheckBox22.Checked = True And CheckBox21.Checked = True Then
                resp4 = "D;E"
            End If
            '*************************************************************
            If CheckBox30.Checked = True And CheckBox29.Checked = True Then
                resp5 = "A;B"
            End If
            If CheckBox30.Checked = True And CheckBox28.Checked = True Then
                resp5 = "A;C"
            End If
            If CheckBox30.Checked = True And CheckBox27.Checked = True Then
                resp5 = "A;D"
            End If
            If CheckBox30.Checked = True And CheckBox26.Checked = True Then
                resp5 = "A;E"
            End If
            If CheckBox29.Checked = True And CheckBox28.Checked = True Then
                resp5 = "B;C"
            End If
            If CheckBox29.Checked = True And CheckBox27.Checked = True Then
                resp5 = "B;D"
            End If
            If CheckBox29.Checked = True And CheckBox26.Checked = True Then
                resp5 = "B;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox28.Checked = True And CheckBox27.Checked = True Then
                resp5 = "C;D"
            End If
            If CheckBox28.Checked = True And CheckBox26.Checked = True Then
                resp5 = "C;E"
            End If
            If CheckBox27.Checked = True And CheckBox26.Checked = True Then
                resp5 = "D;E"
            End If
            '*************************************************************
            If CheckBox35.Checked = True And CheckBox34.Checked = True Then
                resp6 = "A;B"
            End If
            If CheckBox35.Checked = True And CheckBox33.Checked = True Then
                resp6 = "A;C"
            End If
            If CheckBox35.Checked = True And CheckBox32.Checked = True Then
                resp6 = "A;D"
            End If
            If CheckBox35.Checked = True And CheckBox31.Checked = True Then
                resp6 = "A;E"
            End If
            If CheckBox34.Checked = True And CheckBox33.Checked = True Then
                resp6 = "B;C"
            End If
            If CheckBox34.Checked = True And CheckBox32.Checked = True Then
                resp6 = "B;D"
            End If
            If CheckBox34.Checked = True And CheckBox31.Checked = True Then
                resp6 = "B;E"
            End If
            If CheckBox33.Checked = True And CheckBox32.Checked = True Then
                resp6 = "C;D"
            End If
            If CheckBox33.Checked = True And CheckBox31.Checked = True Then
                resp6 = "C;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox32.Checked = True And CheckBox31.Checked = True Then
                resp6 = "D;E"
            End If
            '*************************************************************

            If CheckBox40.Checked = True And CheckBox39.Checked = True Then
                resp7 = "A;B"
            End If
            If CheckBox40.Checked = True And CheckBox38.Checked = True Then
                resp7 = "A;C"
            End If
            If CheckBox40.Checked = True And CheckBox37.Checked = True Then
                resp7 = "A;D"
            End If
            If CheckBox40.Checked = True And CheckBox36.Checked = True Then
                resp7 = "A;E"
            End If
            If CheckBox39.Checked = True And CheckBox38.Checked = True Then
                resp7 = "B;C"
            End If
            If CheckBox39.Checked = True And CheckBox37.Checked = True Then
                resp7 = "B;D"
            End If
            If CheckBox39.Checked = True And CheckBox36.Checked = True Then
                resp7 = "B;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox38.Checked = True And CheckBox37.Checked = True Then
                resp7 = "C;D"
            End If
            If CheckBox38.Checked = True And CheckBox36.Checked = True Then
                resp7 = "C;E"
            End If
            If CheckBox37.Checked = True And CheckBox36.Checked = True Then
                resp7 = "D;E"
            End If
            '*************************************************************
            If CheckBox45.Checked = True And CheckBox44.Checked = True Then
                resp8 = "A;B"
            End If
            If CheckBox45.Checked = True And CheckBox43.Checked = True Then
                resp8 = "A;C"
            End If
            If CheckBox45.Checked = True And CheckBox42.Checked = True Then
                resp8 = "A;D"
            End If
            If CheckBox45.Checked = True And CheckBox41.Checked = True Then
                resp8 = "A;E"
            End If
            If CheckBox44.Checked = True And CheckBox43.Checked = True Then
                resp8 = "B;C"
            End If
            If CheckBox44.Checked = True And CheckBox42.Checked = True Then
                resp8 = "B;D"
            End If
            If CheckBox44.Checked = True And CheckBox41.Checked = True Then
                resp8 = "B;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox43.Checked = True And CheckBox42.Checked = True Then
                resp8 = "C;D"
            End If
            If CheckBox43.Checked = True And CheckBox41.Checked = True Then
                resp8 = "C;E"
            End If
            If CheckBox42.Checked = True And CheckBox41.Checked = True Then
                resp8 = "D;E"
            End If
            '**************************************************************
            If CheckBox50.Checked = True And CheckBox49.Checked = True Then
                resp9 = "A;B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox50.Checked = True And CheckBox48.Checked = True Then
                resp9 = "A;C"
            End If
            If CheckBox50.Checked = True And CheckBox47.Checked = True Then
                resp9 = "A;D"
            End If
            If CheckBox50.Checked = True And CheckBox46.Checked = True Then
                resp9 = "A;E"
            End If
            If CheckBox49.Checked = True And CheckBox48.Checked = True Then
                resp9 = "B;C"
            End If
            If CheckBox49.Checked = True And CheckBox47.Checked = True Then
                resp9 = "B;D"
            End If
            If CheckBox49.Checked = True And CheckBox46.Checked = True Then
                resp9 = "B;E"
            End If
            If CheckBox48.Checked = True And CheckBox47.Checked = True Then
                resp9 = "C;D"
            End If
            If CheckBox48.Checked = True And CheckBox46.Checked = True Then
                resp9 = "C;E"
            End If
            If CheckBox47.Checked = True And CheckBox46.Checked = True Then
                resp9 = "D;E"
            End If
            '*************************************************************
            If CheckBox55.Checked = True And CheckBox54.Checked = True Then
                resp18 = "A;B"
            End If
            If CheckBox55.Checked = True And CheckBox53.Checked = True Then
                resp18 = "A;C"
            End If
            If CheckBox55.Checked = True And CheckBox52.Checked = True Then
                resp18 = "A;D"
            End If
            If CheckBox55.Checked = True And CheckBox51.Checked = True Then
                resp18 = "A;E"
            End If
            If CheckBox54.Checked = True And CheckBox53.Checked = True Then
                resp18 = "B;C"
            End If
            If CheckBox54.Checked = True And CheckBox52.Checked = True Then
                resp18 = "B;D"
            End If
            If CheckBox54.Checked = True And CheckBox51.Checked = True Then
                resp18 = "B;E"
            End If
            If CheckBox53.Checked = True And CheckBox52.Checked = True Then
                resp18 = "C;D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox53.Checked = True And CheckBox51.Checked = True Then
                resp18 = "C;E"
            End If
            If CheckBox52.Checked = True And CheckBox51.Checked = True Then
                resp18 = "D;E"
            End If
            '*************************************************************
            If CheckBox60.Checked = True And CheckBox9.Checked = True Then
                resp17 = "A;B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox60.Checked = True And CheckBox58.Checked = True Then
                resp17 = "A;C"
            End If
            If CheckBox60.Checked = True And CheckBox57.Checked = True Then
                resp17 = "A;D"
            End If
            If CheckBox60.Checked = True And CheckBox56.Checked = True Then
                resp17 = "A;E"
            End If
            If CheckBox9.Checked = True And CheckBox58.Checked = True Then
                resp17 = "B;C"
            End If
            If CheckBox9.Checked = True And CheckBox57.Checked = True Then
                resp17 = "B;D"
            End If
            If CheckBox9.Checked = True And CheckBox56.Checked = True Then
                resp17 = "B;E"
            End If
            If CheckBox58.Checked = True And CheckBox57.Checked = True Then
                resp17 = "C;D"
            End If
            If CheckBox58.Checked = True And CheckBox56.Checked = True Then
                resp17 = "C;E"
            End If
            If CheckBox57.Checked = True And CheckBox56.Checked = True Then
                resp17 = "D;E"
            End If
            '*************************************************************
            If CheckBox65.Checked = True And CheckBox64.Checked = True Then
                resp16 = "A;B"
            End If
            If CheckBox65.Checked = True And CheckBox63.Checked = True Then
                resp16 = "A;C"
            End If
            If CheckBox65.Checked = True And CheckBox62.Checked = True Then
                resp16 = "A;D"
            End If
            If CheckBox65.Checked = True And CheckBox61.Checked = True Then
                resp16 = "A;E"
            End If
            If CheckBox64.Checked = True And CheckBox63.Checked = True Then
                resp16 = "B;C"
            End If
            If CheckBox64.Checked = True And CheckBox62.Checked = True Then
                resp16 = "B;D"
            End If
            If CheckBox64.Checked = True And CheckBox61.Checked = True Then
                resp16 = "B;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox63.Checked = True And CheckBox62.Checked = True Then
                resp16 = "C;D"
            End If
            If CheckBox63.Checked = True And CheckBox61.Checked = True Then
                resp16 = "C;E"
            End If
            If CheckBox62.Checked = True And CheckBox61.Checked = True Then
                resp16 = "D;E"
            End If
            '*************************************************************
            If CheckBox70.Checked = True And CheckBox69.Checked = True Then
                resp15 = "A;B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox70.Checked = True And CheckBox68.Checked = True Then
                resp15 = "A;C"
            End If
            If CheckBox70.Checked = True And CheckBox67.Checked = True Then
                resp15 = "A;D"
            End If
            If CheckBox70.Checked = True And CheckBox66.Checked = True Then
                resp15 = "A;E"
            End If
            If CheckBox69.Checked = True And CheckBox68.Checked = True Then
                resp15 = "B;C"
            End If
            If CheckBox69.Checked = True And CheckBox67.Checked = True Then
                resp15 = "B;D"
            End If
            If CheckBox69.Checked = True And CheckBox66.Checked = True Then
                resp15 = "B;E"
            End If
            If CheckBox68.Checked = True And CheckBox67.Checked = True Then
                resp15 = "C;D"
            End If
            If CheckBox68.Checked = True And CheckBox66.Checked = True Then
                resp15 = "C;E"
            End If
            If CheckBox67.Checked = True And CheckBox66.Checked = True Then
                resp15 = "D;E"
            End If
            '*************************************************************
            If CheckBox75.Checked = True And CheckBox74.Checked = True Then
                resp14 = "A;B"
            End If
            If CheckBox75.Checked = True And CheckBox73.Checked = True Then
                resp14 = "A;C"
            End If
            If CheckBox75.Checked = True And CheckBox72.Checked = True Then
                resp14 = "A;D"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox75.Checked = True And CheckBox71.Checked = True Then
                resp14 = "A;E"
            End If
            If CheckBox74.Checked = True And CheckBox73.Checked = True Then
                resp14 = "B;C"
            End If
            If CheckBox74.Checked = True And CheckBox72.Checked = True Then
                resp14 = "B;D"
            End If
            If CheckBox74.Checked = True And CheckBox71.Checked = True Then
                resp14 = "B;E"
            End If
            If CheckBox73.Checked = True And CheckBox72.Checked = True Then
                resp14 = "C;D"
            End If
            If CheckBox73.Checked = True And CheckBox71.Checked = True Then
                resp14 = "C;E"
            End If
            If CheckBox72.Checked = True And CheckBox71.Checked = True Then
                resp14 = "D;E"
            End If
            '*************************************************************
            If CheckBox80.Checked = True And CheckBox79.Checked = True Then
                resp13 = "A;B"
            End If
            If CheckBox80.Checked = True And CheckBox78.Checked = True Then
                resp13 = "A;C"
            End If
            If CheckBox80.Checked = True And CheckBox77.Checked = True Then
                resp13 = "A;D"
            End If
            If CheckBox80.Checked = True And CheckBox76.Checked = True Then
                resp13 = "A;E"
            End If
            If CheckBox79.Checked = True And CheckBox78.Checked = True Then
                resp13 = "B;C"
            End If
            If CheckBox79.Checked = True And CheckBox77.Checked = True Then
                resp13 = "B;D"
            End If
            If CheckBox79.Checked = True And CheckBox76.Checked = True Then
                resp13 = "B;E"
            End If
            If CheckBox78.Checked = True And CheckBox77.Checked = True Then
                resp13 = "C;D"
            End If
            If CheckBox78.Checked = True And CheckBox76.Checked = True Then
                resp13 = "C;E"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox77.Checked = True And CheckBox76.Checked = True Then
                resp13 = "D;E"
            End If
            '*************************************************************
            If CheckBox85.Checked = True And CheckBox84.Checked = True Then
                resp12 = "A;B"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox85.Checked = True And CheckBox83.Checked = True Then
                resp12 = "A;C"
            End If
            If CheckBox85.Checked = True And CheckBox82.Checked = True Then
                resp12 = "A;D"
            End If
            If CheckBox85.Checked = True And CheckBox81.Checked = True Then
                resp12 = "A;E"
            End If
            If CheckBox84.Checked = True And CheckBox83.Checked = True Then
                resp12 = "B;C"
            End If
            If CheckBox84.Checked = True And CheckBox82.Checked = True Then
                resp12 = "B;D"
            End If
            If CheckBox84.Checked = True And CheckBox81.Checked = True Then
                resp12 = "B;E"
            End If
            If CheckBox83.Checked = True And CheckBox82.Checked = True Then
                resp12 = "C;D"
            End If
            If CheckBox83.Checked = True And CheckBox81.Checked = True Then
                resp12 = "C;E"
            End If
            If CheckBox82.Checked = True And CheckBox81.Checked = True Then
                resp12 = "D;E"
            End If
            '*************************************************************
            If CheckBox90.Checked = True And CheckBox89.Checked = True Then
                resp11 = "A;B"
            End If
            If CheckBox90.Checked = True And CheckBox88.Checked = True Then
                resp11 = "A;C"
            End If
            If CheckBox90.Checked = True And CheckBox87.Checked = True Then
                resp11 = "A;D"
            End If
            If CheckBox90.Checked = True And CheckBox86.Checked = True Then
                resp11 = "A;E"
            End If
            If CheckBox89.Checked = True And CheckBox88.Checked = True Then
                resp11 = "B;C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox89.Checked = True And CheckBox87.Checked = True Then
                resp11 = "B;D"
            End If
            If CheckBox89.Checked = True And CheckBox86.Checked = True Then
                resp11 = "B;E"
            End If
            If CheckBox88.Checked = True And CheckBox87.Checked = True Then
                resp11 = "C;D"
            End If
            If CheckBox88.Checked = True And CheckBox86.Checked = True Then
                resp11 = "C;E"
            End If
            If CheckBox87.Checked = True And CheckBox86.Checked = True Then
                resp11 = "D;E"
            End If
            '*************************************************************
            If CheckBox95.Checked = True And CheckBox94.Checked = True Then
                resp10 = "A;B"
            End If
            If CheckBox95.Checked = True And CheckBox93.Checked = True Then
                resp10 = "A;C"
                INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
            End If
            If CheckBox95.Checked = True And CheckBox92.Checked = True Then
                resp10 = "A;D"
            End If
            If CheckBox95.Checked = True And CheckBox91.Checked = True Then
                resp10 = "A;E"
            End If
            If CheckBox94.Checked = True And CheckBox93.Checked = True Then
                resp10 = "B;C"
            End If
            If CheckBox94.Checked = True And CheckBox92.Checked = True Then
                resp10 = "B;D"
            End If
            If CheckBox94.Checked = True And CheckBox91.Checked = True Then
                resp10 = "B;E"
            End If
            If CheckBox93.Checked = True And CheckBox92.Checked = True Then
                resp10 = "C;D"
            End If
            If CheckBox93.Checked = True And CheckBox91.Checked = True Then
                resp10 = "C;E"
            End If
            If CheckBox92.Checked = True And CheckBox91.Checked = True Then
                resp10 = "D;E"
            End If
            '*************************************************************
            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_merril SET sr4_resp1 = @resp1,sr4_resp2 = @resp2,sr4_resp3 = @resp3,sr4_resp4 = @resp4,sr4_resp5 = @resp5,sr4_resp6 = @resp6,sr4_resp7 = @resp7,sr4_resp8 = @resp8,sr4_resp9 = @resp9,sr4_resp10 = @resp10,sr4_resp11 = @resp11,sr4_resp12 = @resp12,sr4_resp13 = @resp13,sr4_resp14 = @resp14,sr4_resp15 = @resp15,sr4_resp16 = @resp16,sr4_resp17 = @resp17,sr4_resp18 = @resp18 WHERE id_candidato = @id_test"
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

                SERIE5.Show()
                Me.Close()
            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            INSTRUCCIONES.s4 = INSTRUCCIONES.total_Respuestas
            'MsgBox(INSTRUCCIONES.s4)
            SERIE5.txtId.Text = txtId.Text
        End If
    End Sub




    Private Sub btguardar4_Click(sender As System.Object, e As System.EventArgs) Handles btguardar4.Click
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
        '*********************************
        If CheckBox10.Checked = True And CheckBox9.Checked = True Then
            resp1 = "A;B"
        End If
        If CheckBox10.Checked = True And CheckBox8.Checked = True Then
            resp1 = "A;C"
        End If
        If CheckBox10.Checked = True And CheckBox7.Checked = True Then
            resp1 = "A;D"
        End If
        If CheckBox10.Checked = True And CheckBox6.Checked = True Then
            resp1 = "A;E"
        End If
        If CheckBox9.Checked = True And CheckBox8.Checked = True Then
            resp1 = "B;C"
        End If
        If CheckBox9.Checked = True And CheckBox7.Checked = True Then
            resp1 = "B;D"
        End If
        If CheckBox9.Checked = True And CheckBox6.Checked = True Then
            resp1 = "B;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox8.Checked = True And CheckBox7.Checked = True Then
            resp1 = "C;D"
        End If
        If CheckBox8.Checked = True And CheckBox6.Checked = True Then
            resp1 = "C;E"
        End If
        If CheckBox7.Checked = True And CheckBox6.Checked = True Then
            resp1 = "D;E"
        End If
        '*************************************************************
        If CheckBox15.Checked = True And CheckBox14.Checked = True Then
            resp2 = "A;B"
        End If
        If CheckBox15.Checked = True And CheckBox13.Checked = True Then
            resp2 = "A;C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox15.Checked = True And CheckBox12.Checked = True Then
            resp2 = "A;D"
        End If
        If CheckBox15.Checked = True And CheckBox11.Checked = True Then
            resp2 = "A;E"
        End If
        If CheckBox14.Checked = True And CheckBox13.Checked = True Then
            resp2 = "B;C"
        End If
        If CheckBox14.Checked = True And CheckBox12.Checked = True Then
            resp2 = "B;D"
        End If
        If CheckBox14.Checked = True And CheckBox11.Checked = True Then
            resp2 = "B;E"
        End If
        If CheckBox13.Checked = True And CheckBox12.Checked = True Then
            resp2 = "C;D"
        End If
        If CheckBox13.Checked = True And CheckBox11.Checked = True Then
            resp2 = "C;E"
        End If
        If CheckBox12.Checked = True And CheckBox11.Checked = True Then
            resp2 = "D;E"
        End If
        '*************************************************************
        If CheckBox20.Checked = True And CheckBox19.Checked = True Then
            resp3 = "A;B"
        End If
        If CheckBox20.Checked = True And CheckBox18.Checked = True Then
            resp3 = "A;C"
        End If
        If CheckBox20.Checked = True And CheckBox17.Checked = True Then
            resp3 = "A;D"
        End If
        If CheckBox20.Checked = True And CheckBox16.Checked = True Then
            resp3 = "A;E"
        End If
        If CheckBox19.Checked = True And CheckBox18.Checked = True Then
            resp3 = "B;C"
        End If
        If CheckBox19.Checked = True And CheckBox17.Checked = True Then
            resp3 = "B;D"
        End If
        If CheckBox19.Checked = True And CheckBox16.Checked = True Then
            resp3 = "B;E"
        End If
        If CheckBox18.Checked = True And CheckBox17.Checked = True Then
            resp3 = "C;D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox18.Checked = True And CheckBox16.Checked = True Then
            resp3 = "C;E"
        End If
        If CheckBox17.Checked = True And CheckBox16.Checked = True Then
            resp3 = "D;E"
        End If
        '*************************************************************
        If CheckBox25.Checked = True And CheckBox24.Checked = True Then
            resp4 = "A;B"
        End If
        If CheckBox25.Checked = True And CheckBox23.Checked = True Then
            resp4 = "A;C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox25.Checked = True And CheckBox22.Checked = True Then
            resp4 = "A;D"
        End If
        If CheckBox25.Checked = True And CheckBox21.Checked = True Then
            resp4 = "A;E"
        End If
        If CheckBox24.Checked = True And CheckBox23.Checked = True Then
            resp4 = "B;C"
        End If
        If CheckBox24.Checked = True And CheckBox22.Checked = True Then
            resp4 = "B;D"
        End If
        If CheckBox24.Checked = True And CheckBox21.Checked = True Then
            resp4 = "B;E"
        End If
        If CheckBox23.Checked = True And CheckBox22.Checked = True Then
            resp4 = "C;D"
        End If
        If CheckBox23.Checked = True And CheckBox21.Checked = True Then
            resp4 = "C;E"
        End If
        If CheckBox22.Checked = True And CheckBox21.Checked = True Then
            resp4 = "D;E"
        End If
        '*************************************************************
        If CheckBox30.Checked = True And CheckBox29.Checked = True Then
            resp5 = "A;B"
        End If
        If CheckBox30.Checked = True And CheckBox28.Checked = True Then
            resp5 = "A;C"
        End If
        If CheckBox30.Checked = True And CheckBox27.Checked = True Then
            resp5 = "A;D"
        End If
        If CheckBox30.Checked = True And CheckBox26.Checked = True Then
            resp5 = "A;E"
        End If
        If CheckBox29.Checked = True And CheckBox28.Checked = True Then
            resp5 = "B;C"
        End If
        If CheckBox29.Checked = True And CheckBox27.Checked = True Then
            resp5 = "B;D"
        End If
        If CheckBox29.Checked = True And CheckBox26.Checked = True Then
            resp5 = "B;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox28.Checked = True And CheckBox27.Checked = True Then
            resp5 = "C;D"
        End If
        If CheckBox28.Checked = True And CheckBox26.Checked = True Then
            resp5 = "C;E"
        End If
        If CheckBox27.Checked = True And CheckBox26.Checked = True Then
            resp5 = "D;E"
        End If
        '*************************************************************
        If CheckBox35.Checked = True And CheckBox34.Checked = True Then
            resp6 = "A;B"
        End If
        If CheckBox35.Checked = True And CheckBox33.Checked = True Then
            resp6 = "A;C"
        End If
        If CheckBox35.Checked = True And CheckBox32.Checked = True Then
            resp6 = "A;D"
        End If
        If CheckBox35.Checked = True And CheckBox31.Checked = True Then
            resp6 = "A;E"
        End If
        If CheckBox34.Checked = True And CheckBox33.Checked = True Then
            resp6 = "B;C"
        End If
        If CheckBox34.Checked = True And CheckBox32.Checked = True Then
            resp6 = "B;D"
        End If
        If CheckBox34.Checked = True And CheckBox31.Checked = True Then
            resp6 = "B;E"
        End If
        If CheckBox33.Checked = True And CheckBox32.Checked = True Then
            resp6 = "C;D"
        End If
        If CheckBox33.Checked = True And CheckBox31.Checked = True Then
            resp6 = "C;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox32.Checked = True And CheckBox31.Checked = True Then
            resp6 = "D;E"
        End If
        '*************************************************************

        If CheckBox40.Checked = True And CheckBox39.Checked = True Then
            resp7 = "A;B"
        End If
        If CheckBox40.Checked = True And CheckBox38.Checked = True Then
            resp7 = "A;C"
        End If
        If CheckBox40.Checked = True And CheckBox37.Checked = True Then
            resp7 = "A;D"
        End If
        If CheckBox40.Checked = True And CheckBox36.Checked = True Then
            resp7 = "A;E"
        End If
        If CheckBox39.Checked = True And CheckBox38.Checked = True Then
            resp7 = "B;C"
        End If
        If CheckBox39.Checked = True And CheckBox37.Checked = True Then
            resp7 = "B;D"
        End If
        If CheckBox39.Checked = True And CheckBox36.Checked = True Then
            resp7 = "B;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox38.Checked = True And CheckBox37.Checked = True Then
            resp7 = "C;D"
        End If
        If CheckBox38.Checked = True And CheckBox36.Checked = True Then
            resp7 = "C;E"
        End If
        If CheckBox37.Checked = True And CheckBox36.Checked = True Then
            resp7 = "D;E"
        End If
        '*************************************************************
        If CheckBox45.Checked = True And CheckBox44.Checked = True Then
            resp8 = "A;B"
        End If
        If CheckBox45.Checked = True And CheckBox43.Checked = True Then
            resp8 = "A;C"
        End If
        If CheckBox45.Checked = True And CheckBox42.Checked = True Then
            resp8 = "A;D"
        End If
        If CheckBox45.Checked = True And CheckBox41.Checked = True Then
            resp8 = "A;E"
        End If
        If CheckBox44.Checked = True And CheckBox43.Checked = True Then
            resp8 = "B;C"
        End If
        If CheckBox44.Checked = True And CheckBox42.Checked = True Then
            resp8 = "B;D"
        End If
        If CheckBox44.Checked = True And CheckBox41.Checked = True Then
            resp8 = "B;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox43.Checked = True And CheckBox42.Checked = True Then
            resp8 = "C;D"
        End If
        If CheckBox43.Checked = True And CheckBox41.Checked = True Then
            resp8 = "C;E"
        End If
        If CheckBox42.Checked = True And CheckBox41.Checked = True Then
            resp8 = "D;E"
        End If
        '**************************************************************
        If CheckBox50.Checked = True And CheckBox49.Checked = True Then
            resp9 = "A;B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox50.Checked = True And CheckBox48.Checked = True Then
            resp9 = "A;C"
        End If
        If CheckBox50.Checked = True And CheckBox47.Checked = True Then
            resp9 = "A;D"
        End If
        If CheckBox50.Checked = True And CheckBox46.Checked = True Then
            resp9 = "A;E"
        End If
        If CheckBox49.Checked = True And CheckBox48.Checked = True Then
            resp9 = "B;C"
        End If
        If CheckBox49.Checked = True And CheckBox47.Checked = True Then
            resp9 = "B;D"
        End If
        If CheckBox49.Checked = True And CheckBox46.Checked = True Then
            resp9 = "B;E"
        End If
        If CheckBox48.Checked = True And CheckBox47.Checked = True Then
            resp9 = "C;D"
        End If
        If CheckBox48.Checked = True And CheckBox46.Checked = True Then
            resp9 = "C;E"
        End If
        If CheckBox47.Checked = True And CheckBox46.Checked = True Then
            resp9 = "D;E"
        End If
        '*************************************************************
        If CheckBox55.Checked = True And CheckBox54.Checked = True Then
            resp18 = "A;B"
        End If
        If CheckBox55.Checked = True And CheckBox53.Checked = True Then
            resp18 = "A;C"
        End If
        If CheckBox55.Checked = True And CheckBox52.Checked = True Then
            resp18 = "A;D"
        End If
        If CheckBox55.Checked = True And CheckBox51.Checked = True Then
            resp18 = "A;E"
        End If
        If CheckBox54.Checked = True And CheckBox53.Checked = True Then
            resp18 = "B;C"
        End If
        If CheckBox54.Checked = True And CheckBox52.Checked = True Then
            resp18 = "B;D"
        End If
        If CheckBox54.Checked = True And CheckBox51.Checked = True Then
            resp18 = "B;E"
        End If
        If CheckBox53.Checked = True And CheckBox52.Checked = True Then
            resp18 = "C;D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox53.Checked = True And CheckBox51.Checked = True Then
            resp18 = "C;E"
        End If
        If CheckBox52.Checked = True And CheckBox51.Checked = True Then
            resp18 = "D;E"
        End If
        '*************************************************************
        If CheckBox60.Checked = True And CheckBox9.Checked = True Then
            resp17 = "A;B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox60.Checked = True And CheckBox58.Checked = True Then
            resp17 = "A;C"
        End If
        If CheckBox60.Checked = True And CheckBox57.Checked = True Then
            resp17 = "A;D"
        End If
        If CheckBox60.Checked = True And CheckBox56.Checked = True Then
            resp17 = "A;E"
        End If
        If CheckBox9.Checked = True And CheckBox58.Checked = True Then
            resp17 = "B;C"
        End If
        If CheckBox9.Checked = True And CheckBox57.Checked = True Then
            resp17 = "B;D"
        End If
        If CheckBox9.Checked = True And CheckBox56.Checked = True Then
            resp17 = "B;E"
        End If
        If CheckBox58.Checked = True And CheckBox57.Checked = True Then
            resp17 = "C;D"
        End If
        If CheckBox58.Checked = True And CheckBox56.Checked = True Then
            resp17 = "C;E"
        End If
        If CheckBox57.Checked = True And CheckBox56.Checked = True Then
            resp17 = "D;E"
        End If
        '*************************************************************
        If CheckBox65.Checked = True And CheckBox64.Checked = True Then
            resp16 = "A;B"
        End If
        If CheckBox65.Checked = True And CheckBox63.Checked = True Then
            resp16 = "A;C"
        End If
        If CheckBox65.Checked = True And CheckBox62.Checked = True Then
            resp16 = "A;D"
        End If
        If CheckBox65.Checked = True And CheckBox61.Checked = True Then
            resp16 = "A;E"
        End If
        If CheckBox64.Checked = True And CheckBox63.Checked = True Then
            resp16 = "B;C"
        End If
        If CheckBox64.Checked = True And CheckBox62.Checked = True Then
            resp16 = "B;D"
        End If
        If CheckBox64.Checked = True And CheckBox61.Checked = True Then
            resp16 = "B;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox63.Checked = True And CheckBox62.Checked = True Then
            resp16 = "C;D"
        End If
        If CheckBox63.Checked = True And CheckBox61.Checked = True Then
            resp16 = "C;E"
        End If
        If CheckBox62.Checked = True And CheckBox61.Checked = True Then
            resp16 = "D;E"
        End If
        '*************************************************************
        If CheckBox70.Checked = True And CheckBox69.Checked = True Then
            resp15 = "A;B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox70.Checked = True And CheckBox68.Checked = True Then
            resp15 = "A;C"
        End If
        If CheckBox70.Checked = True And CheckBox67.Checked = True Then
            resp15 = "A;D"
        End If
        If CheckBox70.Checked = True And CheckBox66.Checked = True Then
            resp15 = "A;E"
        End If
        If CheckBox69.Checked = True And CheckBox68.Checked = True Then
            resp15 = "B;C"
        End If
        If CheckBox69.Checked = True And CheckBox67.Checked = True Then
            resp15 = "B;D"
        End If
        If CheckBox69.Checked = True And CheckBox66.Checked = True Then
            resp15 = "B;E"
        End If
        If CheckBox68.Checked = True And CheckBox67.Checked = True Then
            resp15 = "C;D"
        End If
        If CheckBox68.Checked = True And CheckBox66.Checked = True Then
            resp15 = "C;E"
        End If
        If CheckBox67.Checked = True And CheckBox66.Checked = True Then
            resp15 = "D;E"
        End If
        '*************************************************************
        If CheckBox75.Checked = True And CheckBox74.Checked = True Then
            resp14 = "A;B"
        End If
        If CheckBox75.Checked = True And CheckBox73.Checked = True Then
            resp14 = "A;C"
        End If
        If CheckBox75.Checked = True And CheckBox72.Checked = True Then
            resp14 = "A;D"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox75.Checked = True And CheckBox71.Checked = True Then
            resp14 = "A;E"
        End If
        If CheckBox74.Checked = True And CheckBox73.Checked = True Then
            resp14 = "B;C"
        End If
        If CheckBox74.Checked = True And CheckBox72.Checked = True Then
            resp14 = "B;D"
        End If
        If CheckBox74.Checked = True And CheckBox71.Checked = True Then
            resp14 = "B;E"
        End If
        If CheckBox73.Checked = True And CheckBox72.Checked = True Then
            resp14 = "C;D"
        End If
        If CheckBox73.Checked = True And CheckBox71.Checked = True Then
            resp14 = "C;E"
        End If
        If CheckBox72.Checked = True And CheckBox71.Checked = True Then
            resp14 = "D;E"
        End If
        '*************************************************************
        If CheckBox80.Checked = True And CheckBox79.Checked = True Then
            resp13 = "A;B"
        End If
        If CheckBox80.Checked = True And CheckBox78.Checked = True Then
            resp13 = "A;C"
        End If
        If CheckBox80.Checked = True And CheckBox77.Checked = True Then
            resp13 = "A;D"
        End If
        If CheckBox80.Checked = True And CheckBox76.Checked = True Then
            resp13 = "A;E"
        End If
        If CheckBox79.Checked = True And CheckBox78.Checked = True Then
            resp13 = "B;C"
        End If
        If CheckBox79.Checked = True And CheckBox77.Checked = True Then
            resp13 = "B;D"
        End If
        If CheckBox79.Checked = True And CheckBox76.Checked = True Then
            resp13 = "B;E"
        End If
        If CheckBox78.Checked = True And CheckBox77.Checked = True Then
            resp13 = "C;D"
        End If
        If CheckBox78.Checked = True And CheckBox76.Checked = True Then
            resp13 = "C;E"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox77.Checked = True And CheckBox76.Checked = True Then
            resp13 = "D;E"
        End If
        '*************************************************************
        If CheckBox85.Checked = True And CheckBox84.Checked = True Then
            resp12 = "A;B"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox85.Checked = True And CheckBox83.Checked = True Then
            resp12 = "A;C"
        End If
        If CheckBox85.Checked = True And CheckBox82.Checked = True Then
            resp12 = "A;D"
        End If
        If CheckBox85.Checked = True And CheckBox81.Checked = True Then
            resp12 = "A;E"
        End If
        If CheckBox84.Checked = True And CheckBox83.Checked = True Then
            resp12 = "B;C"
        End If
        If CheckBox84.Checked = True And CheckBox82.Checked = True Then
            resp12 = "B;D"
        End If
        If CheckBox84.Checked = True And CheckBox81.Checked = True Then
            resp12 = "B;E"
        End If
        If CheckBox83.Checked = True And CheckBox82.Checked = True Then
            resp12 = "C;D"
        End If
        If CheckBox83.Checked = True And CheckBox81.Checked = True Then
            resp12 = "C;E"
        End If
        If CheckBox82.Checked = True And CheckBox81.Checked = True Then
            resp12 = "D;E"
        End If
        '*************************************************************
        If CheckBox90.Checked = True And CheckBox89.Checked = True Then
            resp11 = "A;B"
        End If
        If CheckBox90.Checked = True And CheckBox88.Checked = True Then
            resp11 = "A;C"
        End If
        If CheckBox90.Checked = True And CheckBox87.Checked = True Then
            resp11 = "A;D"
        End If
        If CheckBox90.Checked = True And CheckBox86.Checked = True Then
            resp11 = "A;E"
        End If
        If CheckBox89.Checked = True And CheckBox88.Checked = True Then
            resp11 = "B;C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox89.Checked = True And CheckBox87.Checked = True Then
            resp11 = "B;D"
        End If
        If CheckBox89.Checked = True And CheckBox86.Checked = True Then
            resp11 = "B;E"
        End If
        If CheckBox88.Checked = True And CheckBox87.Checked = True Then
            resp11 = "C;D"
        End If
        If CheckBox88.Checked = True And CheckBox86.Checked = True Then
            resp11 = "C;E"
        End If
        If CheckBox87.Checked = True And CheckBox86.Checked = True Then
            resp11 = "D;E"
        End If
        '*************************************************************
        If CheckBox95.Checked = True And CheckBox94.Checked = True Then
            resp10 = "A;B"
        End If
        If CheckBox95.Checked = True And CheckBox93.Checked = True Then
            resp10 = "A;C"
            INSTRUCCIONES.total_Respuestas = INSTRUCCIONES.total_Respuestas + 1
        End If
        If CheckBox95.Checked = True And CheckBox92.Checked = True Then
            resp10 = "A;D"
        End If
        If CheckBox95.Checked = True And CheckBox91.Checked = True Then
            resp10 = "A;E"
        End If
        If CheckBox94.Checked = True And CheckBox93.Checked = True Then
            resp10 = "B;C"
        End If
        If CheckBox94.Checked = True And CheckBox92.Checked = True Then
            resp10 = "B;D"
        End If
        If CheckBox94.Checked = True And CheckBox91.Checked = True Then
            resp10 = "B;E"
        End If
        If CheckBox93.Checked = True And CheckBox92.Checked = True Then
            resp10 = "C;D"
        End If
        If CheckBox93.Checked = True And CheckBox91.Checked = True Then
            resp10 = "C;E"
        End If
        If CheckBox92.Checked = True And CheckBox91.Checked = True Then
            resp10 = "D;E"
        End If
        '*************************************************************
        Try
            Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=$3rv3r5q10621%")
                cnx.Open()
                Using cmd As New SqlCommand()
                    cmd.Connection = cnx
                    cmd.CommandText = "UPDATE rh_test_merril SET sr4_resp1 = @resp1,sr4_resp2 = @resp2,sr4_resp3 = @resp3,sr4_resp4 = @resp4,sr4_resp5 = @resp5,sr4_resp6 = @resp6,sr4_resp7 = @resp7,sr4_resp8 = @resp8,sr4_resp9 = @resp9,sr4_resp10 = @resp10,sr4_resp11 = @resp11,sr4_resp12 = @resp12,sr4_resp13 = @resp13,sr4_resp14 = @resp14,sr4_resp15 = @resp15,sr4_resp16 = @resp16,sr4_resp17 = @resp17,sr4_resp18 = @resp18 WHERE id_candidato = @id_test"
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

            SERIE5.Show()
            Me.Close()
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Error al guardar las respuestas, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        INSTRUCCIONES.s4 = INSTRUCCIONES.total_Respuestas
        'MsgBox(INSTRUCCIONES.s4)
        SERIE5.txtId.Text = txtId.Text
    End Sub
    'bloque 1------------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox10_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            If bloque1 <= 2 Then
                bloque1 = bloque1 + 1
                CheckBox10.Checked = True
                CheckBox10.Enabled = False
                If bloque1 = 2 Then
                    CheckBox9.Enabled = False
                    CheckBox8.Enabled = False
                    CheckBox7.Enabled = False
                    CheckBox6.Enabled = False
                    Button2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            If bloque1 <= 2 Then
                bloque1 = bloque1 + 1
                CheckBox9.Checked = True
                CheckBox9.Enabled = False
                If bloque1 = 2 Then
                    CheckBox10.Enabled = False
                    CheckBox8.Enabled = False
                    CheckBox7.Enabled = False
                    CheckBox6.Enabled = False
                    Button2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            If bloque1 <= 2 Then
                bloque1 = bloque1 + 1
                CheckBox8.Checked = True
                CheckBox8.Enabled = False
                If bloque1 = 2 Then
                    CheckBox9.Enabled = False
                    CheckBox10.Enabled = False
                    CheckBox7.Enabled = False
                    CheckBox6.Enabled = False
                    Button2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            If bloque1 <= 2 Then
                bloque1 = bloque1 + 1
                CheckBox7.Checked = True
                CheckBox7.Enabled = False
                If bloque1 = 2 Then
                    CheckBox9.Enabled = False
                    CheckBox8.Enabled = False
                    CheckBox10.Enabled = False
                    CheckBox6.Enabled = False
                    Button2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            If bloque1 <= 2 Then
                bloque1 = bloque1 + 1
                CheckBox6.Checked = True
                CheckBox6.Enabled = False
                If bloque1 = 2 Then
                    CheckBox9.Enabled = False
                    CheckBox8.Enabled = False
                    CheckBox7.Enabled = False
                    CheckBox10.Enabled = False
                    Button2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CheckBox10.Enabled = True
        CheckBox9.Enabled = True
        CheckBox8.Enabled = True
        CheckBox7.Enabled = True
        CheckBox6.Enabled = True

        CheckBox10.Checked = False
        CheckBox9.Checked = False
        CheckBox8.Checked = False
        CheckBox7.Checked = False
        CheckBox6.Checked = False
        Button2.Visible = False
        bloque1 = 0
    End Sub
    'bloque 2--------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox15_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            If bloque2 <= 2 Then
                bloque2 = bloque2 + 1
                CheckBox15.Checked = True
                CheckBox15.Enabled = False
                If bloque2 = 2 Then
                    CheckBox14.Enabled = False
                    CheckBox13.Enabled = False
                    CheckBox12.Enabled = False
                    CheckBox11.Enabled = False
                    Button3.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            If bloque2 <= 2 Then
                bloque2 = bloque2 + 1
                CheckBox14.Checked = True
                CheckBox14.Enabled = False
                If bloque2 = 2 Then
                    CheckBox15.Enabled = False
                    CheckBox13.Enabled = False
                    CheckBox12.Enabled = False
                    CheckBox11.Enabled = False
                    Button3.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            If bloque2 <= 2 Then
                bloque2 = bloque2 + 1
                CheckBox13.Checked = True
                CheckBox13.Enabled = False
                If bloque2 = 2 Then
                    CheckBox14.Enabled = False
                    CheckBox15.Enabled = False
                    CheckBox12.Enabled = False
                    CheckBox11.Enabled = False
                    Button3.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            If bloque2 <= 2 Then
                bloque2 = bloque2 + 1
                CheckBox12.Checked = True
                CheckBox12.Enabled = False
                If bloque2 = 2 Then
                    CheckBox14.Enabled = False
                    CheckBox13.Enabled = False
                    CheckBox15.Enabled = False
                    CheckBox11.Enabled = False
                    Button3.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            If bloque2 <= 2 Then
                bloque2 = bloque2 + 1
                CheckBox11.Checked = True
                CheckBox11.Enabled = False
                If bloque2 = 2 Then
                    CheckBox14.Enabled = False
                    CheckBox13.Enabled = False
                    CheckBox12.Enabled = False
                    CheckBox15.Enabled = False
                    Button3.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CheckBox15.Enabled = True
        CheckBox14.Enabled = True
        CheckBox13.Enabled = True
        CheckBox12.Enabled = True
        CheckBox11.Enabled = True

        CheckBox15.Checked = False
        CheckBox14.Checked = False
        CheckBox13.Checked = False
        CheckBox12.Checked = False
        CheckBox11.Checked = False
        Button3.Visible = False
        bloque2 = 0
    End Sub
    'bloque 3----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox20_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            If bloque3 <= 2 Then
                bloque3 = bloque3 + 1
                CheckBox20.Checked = True
                CheckBox20.Enabled = False
                If bloque3 = 2 Then
                    CheckBox19.Enabled = False
                    CheckBox18.Enabled = False
                    CheckBox17.Enabled = False
                    CheckBox16.Enabled = False
                    Button4.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            If bloque3 <= 2 Then
                bloque3 = bloque3 + 1
                CheckBox19.Checked = True
                CheckBox19.Enabled = False
                If bloque3 = 2 Then
                    CheckBox20.Enabled = False
                    CheckBox18.Enabled = False
                    CheckBox17.Enabled = False
                    CheckBox16.Enabled = False
                    Button4.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            If bloque3 <= 2 Then
                bloque3 = bloque3 + 1
                CheckBox18.Checked = True
                CheckBox18.Enabled = False
                If bloque3 = 2 Then
                    CheckBox19.Enabled = False
                    CheckBox20.Enabled = False
                    CheckBox17.Enabled = False
                    CheckBox16.Enabled = False
                    Button4.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            If bloque3 <= 2 Then
                bloque3 = bloque3 + 1
                CheckBox17.Checked = True
                CheckBox17.Enabled = False
                If bloque3 = 2 Then
                    CheckBox19.Enabled = False
                    CheckBox18.Enabled = False
                    CheckBox20.Enabled = False
                    CheckBox16.Enabled = False
                    Button4.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            If bloque3 <= 2 Then
                bloque3 = bloque3 + 1
                CheckBox16.Checked = True
                CheckBox16.Enabled = False
                If bloque3 = 2 Then
                    CheckBox19.Enabled = False
                    CheckBox18.Enabled = False
                    CheckBox17.Enabled = False
                    CheckBox20.Enabled = False
                    Button4.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CheckBox20.Enabled = True
        CheckBox19.Enabled = True
        CheckBox18.Enabled = True
        CheckBox17.Enabled = True
        CheckBox16.Enabled = True

        CheckBox20.Checked = False
        CheckBox19.Checked = False
        CheckBox18.Checked = False
        CheckBox17.Checked = False
        CheckBox16.Checked = False
        Button4.Visible = False
        bloque3 = 0
    End Sub
    'bloque 4-----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox25_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            If bloque4 <= 2 Then
                bloque4 = bloque4 + 1
                CheckBox25.Checked = True
                CheckBox25.Enabled = False
                If bloque4 = 2 Then
                    CheckBox24.Enabled = False
                    CheckBox23.Enabled = False
                    CheckBox22.Enabled = False
                    CheckBox21.Enabled = False
                    Button5.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            If bloque4 <= 2 Then
                bloque4 = bloque4 + 1
                CheckBox24.Checked = True
                CheckBox24.Enabled = False
                If bloque4 = 2 Then
                    CheckBox25.Enabled = False
                    CheckBox23.Enabled = False
                    CheckBox22.Enabled = False
                    CheckBox21.Enabled = False
                    Button5.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            If bloque4 <= 2 Then
                bloque4 = bloque4 + 1
                CheckBox23.Checked = True
                CheckBox23.Enabled = False
                If bloque4 = 2 Then
                    CheckBox24.Enabled = False
                    CheckBox25.Enabled = False
                    CheckBox22.Enabled = False
                    CheckBox21.Enabled = False
                    Button5.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            If bloque4 <= 2 Then
                bloque4 = bloque4 + 1
                CheckBox22.Checked = True
                CheckBox22.Enabled = False
                If bloque4 = 2 Then
                    CheckBox24.Enabled = False
                    CheckBox23.Enabled = False
                    CheckBox25.Enabled = False
                    CheckBox21.Enabled = False
                    Button5.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            If bloque4 <= 2 Then
                bloque4 = bloque4 + 1
                CheckBox21.Checked = True
                CheckBox21.Enabled = False
                If bloque4 = 2 Then
                    CheckBox24.Enabled = False
                    CheckBox23.Enabled = False
                    CheckBox22.Enabled = False
                    CheckBox25.Enabled = False
                    Button5.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        CheckBox25.Enabled = True
        CheckBox24.Enabled = True
        CheckBox23.Enabled = True
        CheckBox22.Enabled = True
        CheckBox21.Enabled = True

        CheckBox25.Checked = False
        CheckBox24.Checked = False
        CheckBox23.Checked = False
        CheckBox22.Checked = False
        CheckBox21.Checked = False
        Button5.Visible = False
        bloque4 = 0
    End Sub
    'bloque 5-----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox30_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            If bloque5 <= 2 Then
                bloque5 = bloque5 + 1
                CheckBox30.Checked = True
                CheckBox30.Enabled = False
                If bloque5 = 2 Then
                    CheckBox29.Enabled = False
                    CheckBox28.Enabled = False
                    CheckBox27.Enabled = False
                    CheckBox26.Enabled = False
                    Button6.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then
            If bloque5 <= 2 Then
                bloque5 = bloque5 + 1
                CheckBox29.Checked = True
                CheckBox29.Enabled = False
                If bloque5 = 2 Then
                    CheckBox30.Enabled = False
                    CheckBox28.Enabled = False
                    CheckBox27.Enabled = False
                    CheckBox26.Enabled = False
                    Button6.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            If bloque5 <= 2 Then
                bloque5 = bloque5 + 1
                CheckBox28.Checked = True
                CheckBox28.Enabled = False
                If bloque5 = 2 Then
                    CheckBox29.Enabled = False
                    CheckBox30.Enabled = False
                    CheckBox27.Enabled = False
                    CheckBox26.Enabled = False
                    Button6.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            If bloque5 <= 2 Then
                bloque5 = bloque5 + 1
                CheckBox27.Checked = True
                CheckBox27.Enabled = False
                If bloque5 = 2 Then
                    CheckBox29.Enabled = False
                    CheckBox28.Enabled = False
                    CheckBox30.Enabled = False
                    CheckBox26.Enabled = False
                    Button6.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            If bloque5 <= 2 Then
                bloque5 = bloque5 + 1
                CheckBox26.Checked = True
                CheckBox26.Enabled = False
                If bloque5 = 2 Then
                    CheckBox29.Enabled = False
                    CheckBox28.Enabled = False
                    CheckBox27.Enabled = False
                    CheckBox30.Enabled = False
                    Button6.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        CheckBox30.Enabled = True
        CheckBox29.Enabled = True
        CheckBox28.Enabled = True
        CheckBox27.Enabled = True
        CheckBox26.Enabled = True

        CheckBox30.Checked = False
        CheckBox29.Checked = False
        CheckBox28.Checked = False
        CheckBox27.Checked = False
        CheckBox26.Checked = False
        Button6.Visible = False
        bloque5 = 0
    End Sub
    'bloque 6-----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox35_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            If bloque6 <= 2 Then
                bloque6 = bloque6 + 1
                CheckBox35.Checked = True
                CheckBox35.Enabled = False
                If bloque6 = 2 Then
                    CheckBox34.Enabled = False
                    CheckBox33.Enabled = False
                    CheckBox32.Enabled = False
                    CheckBox31.Enabled = False
                    Button7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            If bloque6 <= 2 Then
                bloque6 = bloque6 + 1
                CheckBox34.Checked = True
                CheckBox34.Enabled = False
                If bloque6 = 2 Then
                    CheckBox35.Enabled = False
                    CheckBox33.Enabled = False
                    CheckBox32.Enabled = False
                    CheckBox31.Enabled = False
                    Button7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked = True Then
            If bloque6 <= 2 Then
                bloque6 = bloque6 + 1
                CheckBox33.Checked = True
                CheckBox33.Enabled = False
                If bloque6 = 2 Then
                    CheckBox34.Enabled = False
                    CheckBox35.Enabled = False
                    CheckBox32.Enabled = False
                    CheckBox31.Enabled = False
                    Button7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked = True Then
            If bloque6 <= 2 Then
                bloque6 = bloque6 + 1
                CheckBox32.Checked = True
                CheckBox32.Enabled = False
                If bloque6 = 2 Then
                    CheckBox34.Enabled = False
                    CheckBox33.Enabled = False
                    CheckBox35.Enabled = False
                    CheckBox31.Enabled = False
                    Button7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked = True Then
            If bloque6 <= 2 Then
                bloque6 = bloque6 + 1
                CheckBox31.Checked = True
                CheckBox31.Enabled = False
                If bloque6 = 2 Then
                    CheckBox34.Enabled = False
                    CheckBox33.Enabled = False
                    CheckBox32.Enabled = False
                    CheckBox35.Enabled = False
                    Button7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        CheckBox35.Enabled = True
        CheckBox34.Enabled = True
        CheckBox33.Enabled = True
        CheckBox32.Enabled = True
        CheckBox31.Enabled = True

        CheckBox35.Checked = False
        CheckBox34.Checked = False
        CheckBox33.Checked = False
        CheckBox32.Checked = False
        CheckBox31.Checked = False
        Button7.Visible = False
        bloque6 = 0
    End Sub
    'bloque 7---------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox40_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked = True Then
            If bloque7 <= 2 Then
                bloque7 = bloque7 + 1
                CheckBox40.Checked = True
                CheckBox40.Enabled = False
                If bloque7 = 2 Then
                    CheckBox39.Enabled = False
                    CheckBox38.Enabled = False
                    CheckBox37.Enabled = False
                    CheckBox36.Enabled = False
                    Button11.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked = True Then
            If bloque7 <= 2 Then
                bloque7 = bloque7 + 1
                CheckBox39.Checked = True
                CheckBox39.Enabled = False
                If bloque7 = 2 Then
                    CheckBox40.Enabled = False
                    CheckBox38.Enabled = False
                    CheckBox37.Enabled = False
                    CheckBox36.Enabled = False
                    Button11.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            If bloque7 <= 2 Then
                bloque7 = bloque7 + 1
                CheckBox38.Checked = True
                CheckBox38.Enabled = False
                If bloque7 = 2 Then
                    CheckBox39.Enabled = False
                    CheckBox40.Enabled = False
                    CheckBox37.Enabled = False
                    CheckBox36.Enabled = False
                    Button11.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            If bloque7 <= 2 Then
                bloque7 = bloque7 + 1
                CheckBox37.Checked = True
                CheckBox37.Enabled = False
                If bloque7 = 2 Then
                    CheckBox39.Enabled = False
                    CheckBox38.Enabled = False
                    CheckBox40.Enabled = False
                    CheckBox36.Enabled = False
                    Button11.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            If bloque7 <= 2 Then
                bloque7 = bloque7 + 1
                CheckBox36.Checked = True
                CheckBox36.Enabled = False
                If bloque7 = 2 Then
                    CheckBox39.Enabled = False
                    CheckBox38.Enabled = False
                    CheckBox37.Enabled = False
                    CheckBox40.Enabled = False
                    Button11.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        CheckBox40.Enabled = True
        CheckBox39.Enabled = True
        CheckBox38.Enabled = True
        CheckBox37.Enabled = True
        CheckBox36.Enabled = True

        CheckBox40.Checked = False
        CheckBox39.Checked = False
        CheckBox38.Checked = False
        CheckBox37.Checked = False
        CheckBox36.Checked = False
        Button11.Visible = False
        bloque7 = 0
    End Sub
    'bloque 8-------------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox45_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.Checked = True Then
            If bloque8 <= 2 Then
                bloque8 = bloque8 + 1
                CheckBox45.Checked = True
                CheckBox45.Enabled = False
                If bloque8 = 2 Then
                    CheckBox44.Enabled = False
                    CheckBox43.Enabled = False
                    CheckBox42.Enabled = False
                    CheckBox41.Enabled = False
                    Button12.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.Checked = True Then
            If bloque8 <= 2 Then
                bloque8 = bloque8 + 1
                CheckBox44.Checked = True
                CheckBox44.Enabled = False
                If bloque8 = 2 Then
                    CheckBox45.Enabled = False
                    CheckBox43.Enabled = False
                    CheckBox42.Enabled = False
                    CheckBox41.Enabled = False
                    Button12.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox43.CheckedChanged
        If CheckBox43.Checked = True Then
            If bloque8 <= 2 Then
                bloque8 = bloque8 + 1
                CheckBox43.Checked = True
                CheckBox43.Enabled = False
                If bloque8 = 2 Then
                    CheckBox44.Enabled = False
                    CheckBox45.Enabled = False
                    CheckBox42.Enabled = False
                    CheckBox41.Enabled = False
                    Button12.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked = True Then
            If bloque8 <= 2 Then
                bloque8 = bloque8 + 1
                CheckBox42.Checked = True
                CheckBox42.Enabled = False
                If bloque8 = 2 Then
                    CheckBox44.Enabled = False
                    CheckBox43.Enabled = False
                    CheckBox45.Enabled = False
                    CheckBox41.Enabled = False
                    Button12.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked = True Then
            If bloque8 <= 2 Then
                bloque8 = bloque8 + 1
                CheckBox41.Checked = True
                CheckBox41.Enabled = False
                If bloque8 = 2 Then
                    CheckBox44.Enabled = False
                    CheckBox43.Enabled = False
                    CheckBox42.Enabled = False
                    CheckBox45.Enabled = False
                    Button12.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        CheckBox45.Enabled = True
        CheckBox44.Enabled = True
        CheckBox43.Enabled = True
        CheckBox42.Enabled = True
        CheckBox41.Enabled = True

        CheckBox45.Checked = False
        CheckBox44.Checked = False
        CheckBox43.Checked = False
        CheckBox42.Checked = False
        CheckBox41.Checked = False
        Button12.Visible = False
        bloque8 = 0
    End Sub

    Private Sub CheckBox50_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked = True Then
            If bloque9 <= 2 Then
                bloque9 = bloque9 + 1
                CheckBox50.Checked = True
                CheckBox50.Enabled = False
                If bloque9 = 2 Then
                    CheckBox49.Enabled = False
                    CheckBox48.Enabled = False
                    CheckBox47.Enabled = False
                    CheckBox46.Enabled = False
                    Button13.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox49_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox49.CheckedChanged
        If CheckBox49.Checked = True Then
            If bloque9 <= 2 Then
                bloque9 = bloque9 + 1
                CheckBox49.Checked = True
                CheckBox49.Enabled = False
                If bloque9 = 2 Then
                    CheckBox50.Enabled = False
                    CheckBox48.Enabled = False
                    CheckBox47.Enabled = False
                    CheckBox46.Enabled = False
                    Button13.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.Checked = True Then
            If bloque9 <= 2 Then
                bloque9 = bloque9 + 1
                CheckBox48.Checked = True
                CheckBox48.Enabled = False
                If bloque9 = 2 Then
                    CheckBox49.Enabled = False
                    CheckBox50.Enabled = False
                    CheckBox47.Enabled = False
                    CheckBox46.Enabled = False
                    Button13.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked = True Then
            If bloque9 <= 2 Then
                bloque9 = bloque9 + 1
                CheckBox47.Checked = True
                CheckBox47.Enabled = False
                If bloque9 = 2 Then
                    CheckBox49.Enabled = False
                    CheckBox48.Enabled = False
                    CheckBox50.Enabled = False
                    CheckBox46.Enabled = False
                    Button13.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox46_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.Checked = True Then
            If bloque9 <= 2 Then
                bloque9 = bloque9 + 1
                CheckBox46.Checked = True
                CheckBox46.Enabled = False
                If bloque9 = 2 Then
                    CheckBox49.Enabled = False
                    CheckBox48.Enabled = False
                    CheckBox47.Enabled = False
                    CheckBox50.Enabled = False
                    Button13.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button13_Click_1(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        CheckBox50.Enabled = True
        CheckBox49.Enabled = True
        CheckBox48.Enabled = True
        CheckBox47.Enabled = True
        CheckBox46.Enabled = True

        CheckBox50.Checked = False
        CheckBox49.Checked = False
        CheckBox48.Checked = False
        CheckBox47.Checked = False
        CheckBox46.Checked = False
        Button13.Visible = False
        bloque9 = 0
    End Sub
    'bloque 10------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox95_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox95.CheckedChanged
        If CheckBox95.Checked = True Then
            If bloque10 <= 2 Then
                bloque10 = bloque10 + 1
                CheckBox95.Checked = True
                CheckBox95.Enabled = False
                If bloque10 = 2 Then
                    CheckBox94.Enabled = False
                    CheckBox93.Enabled = False
                    CheckBox92.Enabled = False
                    CheckBox91.Enabled = False
                    Button8.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox94_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox94.CheckedChanged
        If CheckBox94.Checked = True Then
            If bloque10 <= 2 Then
                bloque10 = bloque10 + 1
                CheckBox94.Checked = True
                CheckBox94.Enabled = False
                If bloque10 = 2 Then
                    CheckBox95.Enabled = False
                    CheckBox93.Enabled = False
                    CheckBox92.Enabled = False
                    CheckBox91.Enabled = False
                    Button8.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox93_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox93.CheckedChanged
        If CheckBox93.Checked = True Then
            If bloque10 <= 2 Then
                bloque10 = bloque10 + 1
                CheckBox93.Checked = True
                CheckBox93.Enabled = False
                If bloque10 = 2 Then
                    CheckBox94.Enabled = False
                    CheckBox95.Enabled = False
                    CheckBox92.Enabled = False
                    CheckBox91.Enabled = False
                    Button8.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox92_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox92.CheckedChanged
        If CheckBox92.Checked = True Then
            If bloque10 <= 2 Then
                bloque10 = bloque10 + 1
                CheckBox92.Checked = True
                CheckBox92.Enabled = False
                If bloque10 = 2 Then
                    CheckBox94.Enabled = False
                    CheckBox93.Enabled = False
                    CheckBox95.Enabled = False
                    CheckBox91.Enabled = False
                    Button8.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox91_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox91.CheckedChanged
        If CheckBox91.Checked = True Then
            If bloque10 <= 2 Then
                bloque10 = bloque10 + 1
                CheckBox91.Checked = True
                CheckBox91.Enabled = False
                If bloque10 = 2 Then
                    CheckBox94.Enabled = False
                    CheckBox93.Enabled = False
                    CheckBox92.Enabled = False
                    CheckBox95.Enabled = False
                    Button8.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        CheckBox95.Enabled = True
        CheckBox94.Enabled = True
        CheckBox93.Enabled = True
        CheckBox92.Enabled = True
        CheckBox91.Enabled = True

        CheckBox95.Checked = False
        CheckBox94.Checked = False
        CheckBox93.Checked = False
        CheckBox92.Checked = False
        CheckBox91.Checked = False
        Button8.Visible = False
        bloque10 = 0
    End Sub
    'bloque 11----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox90_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox90.CheckedChanged
        If CheckBox90.Checked = True Then
            If bloque11 <= 2 Then
                bloque11 = bloque11 + 1
                CheckBox90.Checked = True
                CheckBox90.Enabled = False
                If bloque11 = 2 Then
                    CheckBox89.Enabled = False
                    CheckBox88.Enabled = False
                    CheckBox87.Enabled = False
                    CheckBox86.Enabled = False
                    Button10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox89_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox89.CheckedChanged
        If CheckBox89.Checked = True Then
            If bloque11 <= 2 Then
                bloque11 = bloque11 + 1
                CheckBox89.Checked = True
                CheckBox89.Enabled = False
                If bloque11 = 2 Then
                    CheckBox90.Enabled = False
                    CheckBox88.Enabled = False
                    CheckBox87.Enabled = False
                    CheckBox86.Enabled = False
                    Button10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox88_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox88.CheckedChanged
        If CheckBox88.Checked = True Then
            If bloque11 <= 2 Then
                bloque11 = bloque11 + 1
                CheckBox88.Checked = True
                CheckBox88.Enabled = False
                If bloque11 = 2 Then
                    CheckBox89.Enabled = False
                    CheckBox90.Enabled = False
                    CheckBox87.Enabled = False
                    CheckBox86.Enabled = False
                    Button10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox87_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox87.CheckedChanged
        If CheckBox87.Checked = True Then
            If bloque11 <= 2 Then
                bloque11 = bloque11 + 1
                CheckBox87.Checked = True
                CheckBox87.Enabled = False
                If bloque11 = 2 Then
                    CheckBox89.Enabled = False
                    CheckBox88.Enabled = False
                    CheckBox90.Enabled = False
                    CheckBox86.Enabled = False
                    Button10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox86_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox86.CheckedChanged
        If CheckBox86.Checked = True Then
            If bloque11 <= 2 Then
                bloque11 = bloque11 + 1
                CheckBox86.Checked = True
                CheckBox86.Enabled = False
                If bloque11 = 2 Then
                    CheckBox89.Enabled = False
                    CheckBox88.Enabled = False
                    CheckBox87.Enabled = False
                    CheckBox90.Enabled = False
                    Button10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button10_Click_1(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        CheckBox90.Enabled = True
        CheckBox89.Enabled = True
        CheckBox88.Enabled = True
        CheckBox87.Enabled = True
        CheckBox86.Enabled = True

        CheckBox90.Checked = False
        CheckBox89.Checked = False
        CheckBox88.Checked = False
        CheckBox87.Checked = False
        CheckBox86.Checked = False
        Button10.Visible = False
        bloque11 = 0
    End Sub
    'bloque 12----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox85_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox85.CheckedChanged
        If CheckBox85.Checked = True Then
            If bloque12 <= 2 Then
                bloque12 = bloque12 + 1
                CheckBox85.Checked = True
                CheckBox85.Enabled = False
                If bloque12 = 2 Then
                    CheckBox84.Enabled = False
                    CheckBox83.Enabled = False
                    CheckBox82.Enabled = False
                    CheckBox81.Enabled = False
                    Button9.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox84_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox84.CheckedChanged
        If CheckBox84.Checked = True Then
            If bloque12 <= 2 Then
                bloque12 = bloque12 + 1
                CheckBox84.Checked = True
                CheckBox84.Enabled = False
                If bloque12 = 2 Then
                    CheckBox85.Enabled = False
                    CheckBox83.Enabled = False
                    CheckBox82.Enabled = False
                    CheckBox81.Enabled = False
                    Button9.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox83_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox83.CheckedChanged
        If CheckBox83.Checked = True Then
            If bloque12 <= 2 Then
                bloque12 = bloque12 + 1
                CheckBox83.Checked = True
                CheckBox83.Enabled = False
                If bloque12 = 2 Then
                    CheckBox84.Enabled = False
                    CheckBox85.Enabled = False
                    CheckBox82.Enabled = False
                    CheckBox81.Enabled = False
                    Button9.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox82_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox82.CheckedChanged
        If CheckBox82.Checked = True Then
            If bloque12 <= 2 Then
                bloque12 = bloque12 + 1
                CheckBox82.Checked = True
                CheckBox82.Enabled = False
                If bloque12 = 2 Then
                    CheckBox84.Enabled = False
                    CheckBox83.Enabled = False
                    CheckBox85.Enabled = False
                    CheckBox81.Enabled = False
                    Button9.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox81_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox81.CheckedChanged
        If CheckBox81.Checked = True Then
            If bloque12 <= 2 Then
                bloque12 = bloque12 + 1
                CheckBox81.Checked = True
                CheckBox81.Enabled = False
                If bloque12 = 2 Then
                    CheckBox84.Enabled = False
                    CheckBox83.Enabled = False
                    CheckBox82.Enabled = False
                    CheckBox85.Enabled = False
                    Button9.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        CheckBox85.Enabled = True
        CheckBox84.Enabled = True
        CheckBox83.Enabled = True
        CheckBox82.Enabled = True
        CheckBox81.Enabled = True

        CheckBox85.Checked = False
        CheckBox84.Checked = False
        CheckBox83.Checked = False
        CheckBox82.Checked = False
        CheckBox81.Checked = False
        Button9.Visible = False
        bloque12 = 0
    End Sub
    'bloque 13---------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox80_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox80.CheckedChanged
        If CheckBox80.Checked = True Then
            If bloque13 <= 2 Then
                bloque13 = bloque13 + 1
                CheckBox80.Checked = True
                CheckBox80.Enabled = False
                If bloque13 = 2 Then
                    CheckBox79.Enabled = False
                    CheckBox78.Enabled = False
                    CheckBox77.Enabled = False
                    CheckBox76.Enabled = False
                    Button19.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox79_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox79.CheckedChanged
        If CheckBox79.Checked = True Then
            If bloque13 <= 2 Then
                bloque13 = bloque13 + 1
                CheckBox79.Checked = True
                CheckBox79.Enabled = False
                If bloque13 = 2 Then
                    CheckBox80.Enabled = False
                    CheckBox78.Enabled = False
                    CheckBox77.Enabled = False
                    CheckBox76.Enabled = False
                    Button19.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox78_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox78.CheckedChanged
        If CheckBox78.Checked = True Then
            If bloque13 <= 2 Then
                bloque13 = bloque13 + 1
                CheckBox78.Checked = True
                CheckBox78.Enabled = False
                If bloque13 = 2 Then
                    CheckBox79.Enabled = False
                    CheckBox80.Enabled = False
                    CheckBox77.Enabled = False
                    CheckBox76.Enabled = False
                    Button19.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox77_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox77.CheckedChanged
        If CheckBox77.Checked = True Then
            If bloque13 <= 2 Then
                bloque13 = bloque13 + 1
                CheckBox77.Checked = True
                CheckBox77.Enabled = False
                If bloque13 = 2 Then
                    CheckBox79.Enabled = False
                    CheckBox78.Enabled = False
                    CheckBox80.Enabled = False
                    CheckBox76.Enabled = False
                    Button19.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox76_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox76.CheckedChanged
        If CheckBox76.Checked = True Then
            If bloque13 <= 2 Then
                bloque13 = bloque13 + 1
                CheckBox76.Checked = True
                CheckBox76.Enabled = False
                If bloque13 = 2 Then
                    CheckBox79.Enabled = False
                    CheckBox78.Enabled = False
                    CheckBox77.Enabled = False
                    CheckBox80.Enabled = False
                    Button19.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button19_Click_1(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        CheckBox80.Enabled = True
        CheckBox79.Enabled = True
        CheckBox78.Enabled = True
        CheckBox77.Enabled = True
        CheckBox76.Enabled = True

        CheckBox80.Checked = False
        CheckBox79.Checked = False
        CheckBox78.Checked = False
        CheckBox77.Checked = False
        CheckBox76.Checked = False
        Button19.Visible = False
        bloque13 = 0
    End Sub
    'bloque 14------------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox75_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox75.CheckedChanged
        If CheckBox75.Checked = True Then
            If bloque14 <= 2 Then
                bloque14 = bloque14 + 1
                CheckBox75.Checked = True
                CheckBox75.Enabled = False
                If bloque14 = 2 Then
                    CheckBox74.Enabled = False
                    CheckBox73.Enabled = False
                    CheckBox72.Enabled = False
                    CheckBox71.Enabled = False
                    Button18.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox74_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox74.CheckedChanged
        If CheckBox74.Checked = True Then
            If bloque14 <= 2 Then
                bloque14 = bloque14 + 1
                CheckBox74.Checked = True
                CheckBox74.Enabled = False
                If bloque14 = 2 Then
                    CheckBox75.Enabled = False
                    CheckBox73.Enabled = False
                    CheckBox72.Enabled = False
                    CheckBox71.Enabled = False
                    Button18.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox73_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox73.CheckedChanged
        If CheckBox73.Checked = True Then
            If bloque14 <= 2 Then
                bloque14 = bloque14 + 1
                CheckBox73.Checked = True
                CheckBox73.Enabled = False
                If bloque14 = 2 Then
                    CheckBox74.Enabled = False
                    CheckBox75.Enabled = False
                    CheckBox72.Enabled = False
                    CheckBox71.Enabled = False
                    Button18.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox72.CheckedChanged
        If CheckBox72.Checked = True Then
            If bloque14 <= 2 Then
                bloque14 = bloque14 + 1
                CheckBox72.Checked = True
                CheckBox72.Enabled = False
                If bloque14 = 2 Then
                    CheckBox74.Enabled = False
                    CheckBox73.Enabled = False
                    CheckBox75.Enabled = False
                    CheckBox71.Enabled = False
                    Button18.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox71_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox71.CheckedChanged
        If CheckBox71.Checked = True Then
            If bloque14 <= 2 Then
                bloque14 = bloque14 + 1
                CheckBox71.Checked = True
                CheckBox71.Enabled = False
                If bloque14 = 2 Then
                    CheckBox74.Enabled = False
                    CheckBox73.Enabled = False
                    CheckBox72.Enabled = False
                    CheckBox75.Enabled = False
                    Button18.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button18_Click_1(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        CheckBox75.Enabled = True
        CheckBox74.Enabled = True
        CheckBox73.Enabled = True
        CheckBox72.Enabled = True
        CheckBox71.Enabled = True

        CheckBox75.Checked = False
        CheckBox74.Checked = False
        CheckBox73.Checked = False
        CheckBox72.Checked = False
        CheckBox71.Checked = False
        Button18.Visible = False
        bloque14 = 0
    End Sub
    'bloque 15----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox70_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox70.CheckedChanged
        If CheckBox70.Checked = True Then
            If bloque15 <= 2 Then
                bloque15 = bloque15 + 1
                CheckBox70.Checked = True
                CheckBox70.Enabled = False
                If bloque15 = 2 Then
                    CheckBox69.Enabled = False
                    CheckBox68.Enabled = False
                    CheckBox67.Enabled = False
                    CheckBox66.Enabled = False
                    Button17.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox69_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox69.CheckedChanged
        If CheckBox69.Checked = True Then
            If bloque15 <= 2 Then
                bloque15 = bloque15 + 1
                CheckBox69.Checked = True
                CheckBox69.Enabled = False
                If bloque15 = 2 Then
                    CheckBox70.Enabled = False
                    CheckBox68.Enabled = False
                    CheckBox67.Enabled = False
                    CheckBox66.Enabled = False
                    Button17.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox68_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox68.CheckedChanged
        If CheckBox68.Checked = True Then
            If bloque15 <= 2 Then
                bloque15 = bloque15 + 1
                CheckBox68.Checked = True
                CheckBox68.Enabled = False
                If bloque15 = 2 Then
                    CheckBox69.Enabled = False
                    CheckBox70.Enabled = False
                    CheckBox67.Enabled = False
                    CheckBox66.Enabled = False
                    Button17.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox67_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox67.CheckedChanged
        If CheckBox67.Checked = True Then
            If bloque15 <= 2 Then
                bloque15 = bloque15 + 1
                CheckBox67.Checked = True
                CheckBox67.Enabled = False
                If bloque15 = 2 Then
                    CheckBox69.Enabled = False
                    CheckBox68.Enabled = False
                    CheckBox70.Enabled = False
                    CheckBox66.Enabled = False
                    Button17.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox66_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox66.CheckedChanged
        If CheckBox66.Checked = True Then
            If bloque15 <= 2 Then
                bloque15 = bloque15 + 1
                CheckBox66.Checked = True
                CheckBox66.Enabled = False
                If bloque15 = 2 Then
                    CheckBox69.Enabled = False
                    CheckBox68.Enabled = False
                    CheckBox67.Enabled = False
                    CheckBox70.Enabled = False
                    Button17.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button17_Click_1(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        CheckBox70.Enabled = True
        CheckBox69.Enabled = True
        CheckBox68.Enabled = True
        CheckBox67.Enabled = True
        CheckBox66.Enabled = True

        CheckBox70.Checked = False
        CheckBox69.Checked = False
        CheckBox68.Checked = False
        CheckBox67.Checked = False
        CheckBox66.Checked = False
        Button17.Visible = False
        bloque15 = 0
    End Sub
    'bloque 16-----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox65_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox65.CheckedChanged
        If CheckBox65.Checked = True Then
            If bloque16 <= 2 Then
                bloque16 = bloque16 + 1
                CheckBox65.Checked = True
                CheckBox65.Enabled = False
                If bloque16 = 2 Then
                    CheckBox64.Enabled = False
                    CheckBox63.Enabled = False
                    CheckBox62.Enabled = False
                    CheckBox61.Enabled = False
                    Button16.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox64_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox64.CheckedChanged
        If CheckBox64.Checked = True Then
            If bloque16 <= 2 Then
                bloque16 = bloque16 + 1
                CheckBox64.Checked = True
                CheckBox64.Enabled = False
                If bloque16 = 2 Then
                    CheckBox65.Enabled = False
                    CheckBox63.Enabled = False
                    CheckBox62.Enabled = False
                    CheckBox61.Enabled = False
                    Button16.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.Checked = True Then
            If bloque16 <= 2 Then
                bloque16 = bloque16 + 1
                CheckBox63.Checked = True
                CheckBox63.Enabled = False
                If bloque16 = 2 Then
                    CheckBox64.Enabled = False
                    CheckBox65.Enabled = False
                    CheckBox62.Enabled = False
                    CheckBox61.Enabled = False
                    Button16.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox62_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox62.CheckedChanged
        If CheckBox62.Checked = True Then
            If bloque16 <= 2 Then
                bloque16 = bloque16 + 1
                CheckBox62.Checked = True
                CheckBox62.Enabled = False
                If bloque16 = 2 Then
                    CheckBox64.Enabled = False
                    CheckBox63.Enabled = False
                    CheckBox65.Enabled = False
                    CheckBox61.Enabled = False
                    Button16.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox61_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox61.CheckedChanged
        If CheckBox61.Checked = True Then
            If bloque16 <= 2 Then
                bloque16 = bloque16 + 1
                CheckBox61.Checked = True
                CheckBox61.Enabled = False
                If bloque16 = 2 Then
                    CheckBox64.Enabled = False
                    CheckBox63.Enabled = False
                    CheckBox62.Enabled = False
                    CheckBox65.Enabled = False
                    Button16.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button16_Click_1(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        CheckBox65.Enabled = True
        CheckBox64.Enabled = True
        CheckBox63.Enabled = True
        CheckBox62.Enabled = True
        CheckBox61.Enabled = True

        CheckBox65.Checked = False
        CheckBox64.Checked = False
        CheckBox63.Checked = False
        CheckBox62.Checked = False
        CheckBox61.Checked = False
        Button16.Visible = False
        bloque16 = 0
    End Sub
    'bloque 17--------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox60_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox60.CheckedChanged
        If CheckBox60.Checked = True Then
            If bloque17 <= 2 Then
                bloque17 = bloque17 + 1
                CheckBox60.Checked = True
                CheckBox60.Enabled = False
                If bloque17 = 2 Then
                    CheckBox59.Enabled = False
                    CheckBox58.Enabled = False
                    CheckBox57.Enabled = False
                    CheckBox56.Enabled = False
                    Button15.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox59_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox59.CheckedChanged
        If CheckBox59.Checked = True Then
            If bloque17 <= 2 Then
                bloque17 = bloque17 + 1
                CheckBox59.Checked = True
                CheckBox59.Enabled = False
                If bloque17 = 2 Then
                    CheckBox60.Enabled = False
                    CheckBox58.Enabled = False
                    CheckBox57.Enabled = False
                    CheckBox56.Enabled = False
                    Button15.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox58_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox58.CheckedChanged
        If CheckBox58.Checked = True Then
            If bloque17 <= 2 Then
                bloque17 = bloque17 + 1
                CheckBox58.Checked = True
                CheckBox58.Enabled = False
                If bloque17 = 2 Then
                    CheckBox59.Enabled = False
                    CheckBox60.Enabled = False
                    CheckBox57.Enabled = False
                    CheckBox56.Enabled = False
                    Button15.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox57_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox57.CheckedChanged
        If CheckBox57.Checked = True Then
            If bloque17 <= 2 Then
                bloque17 = bloque17 + 1
                CheckBox57.Checked = True
                CheckBox57.Enabled = False
                If bloque17 = 2 Then
                    CheckBox59.Enabled = False
                    CheckBox58.Enabled = False
                    CheckBox60.Enabled = False
                    CheckBox56.Enabled = False
                    Button15.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.Checked = True Then
            If bloque17 <= 2 Then
                bloque17 = bloque17 + 1
                CheckBox56.Checked = True
                CheckBox56.Enabled = False
                If bloque17 = 2 Then
                    CheckBox59.Enabled = False
                    CheckBox58.Enabled = False
                    CheckBox57.Enabled = False
                    CheckBox60.Enabled = False
                    Button15.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button15_Click_1(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        CheckBox60.Enabled = True
        CheckBox59.Enabled = True
        CheckBox58.Enabled = True
        CheckBox57.Enabled = True
        CheckBox56.Enabled = True

        CheckBox60.Checked = False
        CheckBox59.Checked = False
        CheckBox58.Checked = False
        CheckBox57.Checked = False
        CheckBox56.Checked = False
        Button15.Visible = False
        bloque17 = 0
    End Sub
    'bloque 18-----------------------------------------------------------------------------------------------------------------------
    Private Sub CheckBox55_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.Checked = True Then
            If bloque18 <= 2 Then
                bloque18 = bloque18 + 1
                CheckBox55.Checked = True
                CheckBox55.Enabled = False
                If bloque18 = 2 Then
                    CheckBox54.Enabled = False
                    CheckBox53.Enabled = False
                    CheckBox52.Enabled = False
                    CheckBox51.Enabled = False
                    Button14.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.Checked = True Then
            If bloque18 <= 2 Then
                bloque18 = bloque18 + 1
                CheckBox54.Checked = True
                CheckBox54.Enabled = False
                If bloque18 = 2 Then
                    CheckBox55.Enabled = False
                    CheckBox53.Enabled = False
                    CheckBox52.Enabled = False
                    CheckBox51.Enabled = False
                    Button14.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.Checked = True Then
            If bloque18 <= 2 Then
                bloque18 = bloque18 + 1
                CheckBox53.Checked = True
                CheckBox53.Enabled = False
                If bloque18 = 2 Then
                    CheckBox54.Enabled = False
                    CheckBox55.Enabled = False
                    CheckBox52.Enabled = False
                    CheckBox51.Enabled = False
                    Button14.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.Checked = True Then
            If bloque18 <= 2 Then
                bloque18 = bloque18 + 1
                CheckBox52.Checked = True
                CheckBox52.Enabled = False
                If bloque18 = 2 Then
                    CheckBox54.Enabled = False
                    CheckBox53.Enabled = False
                    CheckBox55.Enabled = False
                    CheckBox51.Enabled = False
                    Button14.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked = True Then
            If bloque18 <= 2 Then
                bloque18 = bloque18 + 1
                CheckBox51.Checked = True
                CheckBox51.Enabled = False
                If bloque18 = 2 Then
                    CheckBox54.Enabled = False
                    CheckBox53.Enabled = False
                    CheckBox52.Enabled = False
                    CheckBox55.Enabled = False
                    Button14.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button14_Click_1(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        CheckBox55.Enabled = True
        CheckBox54.Enabled = True
        CheckBox53.Enabled = True
        CheckBox52.Enabled = True
        CheckBox51.Enabled = True

        CheckBox55.Checked = False
        CheckBox54.Checked = False
        CheckBox53.Checked = False
        CheckBox52.Checked = False
        CheckBox51.Checked = False
        Button14.Visible = False
        bloque18 = 0
    End Sub

    
    Private Sub btiniciar4_Click(sender As System.Object, e As System.EventArgs) Handles btiniciar4.Click
        Timer1.Start()
        Panel1.Visible = True
        btiniciar4.Visible = False
        lbmensaje.Visible = False
        GroupBox1.Focus()
    End Sub
End Class