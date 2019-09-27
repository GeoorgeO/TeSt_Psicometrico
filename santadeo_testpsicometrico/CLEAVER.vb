Imports System.Data.SqlClient

Public Class CLEAVER
    Public estadoarea As Integer = 0
    Private Sub CLEAVER_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        abrir()
        Label145.Select()
        Try
            Dim desktopSize As Size
            desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            Dim height As Integer = desktopSize.Height
            Dim width As Integer = desktopSize.Width
            If width < 1158 Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.Location = New Point((width / 2) - 579, 0)
                Me.Size = New System.Drawing.Size(1158, height - 45)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    
    

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox1.Checked = False
            
            CheckBox5.Checked = True
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = True
            CheckBox3.Checked = False
            CheckBox4.Checked = False

            CheckBox6.Checked = False
            
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then

            CheckBox2.Checked = False
            
            CheckBox5.Checked = False
            CheckBox6.Checked = True
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = True
            CheckBox4.Checked = False
            
            CheckBox7.Checked = False

        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            
            CheckBox3.Checked = False

            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = True
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = True
            
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = True
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            CheckBox15.Checked = False
            CheckBox14.Checked = False
            CheckBox13.Checked = False
            CheckBox12.Checked = False
            CheckBox16.Checked = True
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            CheckBox16.Checked = False
            CheckBox14.Checked = False
            CheckBox13.Checked = False
            CheckBox11.Checked = False
            CheckBox15.Checked = True
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            CheckBox16.Checked = False
            CheckBox15.Checked = False
            CheckBox13.Checked = False
            CheckBox10.Checked = False
            CheckBox14.Checked = True
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            CheckBox16.Checked = False
            CheckBox15.Checked = False
            CheckBox14.Checked = False
            CheckBox9.Checked = False
            CheckBox13.Checked = True
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox9.Checked = False
            CheckBox16.Checked = False
            CheckBox12.Checked = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox12.Checked = False
            CheckBox10.Checked = False
            CheckBox9.Checked = False
            CheckBox15.Checked = False
            CheckBox11.Checked = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox12.Checked = False
            CheckBox11.Checked = False
            CheckBox9.Checked = False
            CheckBox14.Checked = False
            CheckBox10.Checked = True
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            CheckBox12.Checked = False
            CheckBox11.Checked = False
            CheckBox10.Checked = False
            CheckBox13.Checked = False
            CheckBox9.Checked = True
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            CheckBox23.Checked = False
            CheckBox22.Checked = False
            CheckBox21.Checked = False
            CheckBox20.Checked = False
            CheckBox24.Checked = True
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            CheckBox24.Checked = False
            CheckBox22.Checked = False
            CheckBox21.Checked = False
            CheckBox19.Checked = False
            CheckBox23.Checked = True
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            CheckBox24.Checked = False
            CheckBox23.Checked = False
            CheckBox21.Checked = False
            CheckBox18.Checked = False
            CheckBox22.Checked = True
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            CheckBox24.Checked = False
            CheckBox23.Checked = False
            CheckBox22.Checked = False
            CheckBox17.Checked = False
            CheckBox21.Checked = True
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            CheckBox19.Checked = False
            CheckBox18.Checked = False
            CheckBox24.Checked = False
            CheckBox17.Checked = False
            CheckBox20.Checked = True
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            CheckBox20.Checked = False
            CheckBox18.Checked = False
            CheckBox17.Checked = False
            CheckBox23.Checked = False
            CheckBox19.Checked = True
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            CheckBox20.Checked = False
            CheckBox19.Checked = False
            CheckBox17.Checked = False
            CheckBox22.Checked = False
            CheckBox18.Checked = True
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            CheckBox20.Checked = False
            CheckBox19.Checked = False
            CheckBox18.Checked = False
            CheckBox21.Checked = False
            CheckBox17.Checked = True
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked = True Then
            CheckBox31.Checked = False
            CheckBox30.Checked = False
            CheckBox29.Checked = False
            CheckBox28.Checked = False
            CheckBox32.Checked = True
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked = True Then
            CheckBox32.Checked = False
            CheckBox30.Checked = False
            CheckBox29.Checked = False
            CheckBox27.Checked = False
            CheckBox31.Checked = True
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            CheckBox32.Checked = False
            CheckBox31.Checked = False
            CheckBox29.Checked = False
            CheckBox26.Checked = False
            CheckBox30.Checked = True
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then
            CheckBox32.Checked = False
            CheckBox31.Checked = False
            CheckBox30.Checked = False
            CheckBox25.Checked = False
            CheckBox29.Checked = True
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            CheckBox27.Checked = False
            CheckBox26.Checked = False
            CheckBox25.Checked = False
            CheckBox32.Checked = False
            CheckBox28.Checked = True
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            CheckBox28.Checked = False
            CheckBox26.Checked = False
            CheckBox25.Checked = False
            CheckBox31.Checked = False
            CheckBox27.Checked = True
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            CheckBox28.Checked = False
            CheckBox27.Checked = False
            CheckBox25.Checked = False
            CheckBox30.Checked = False
            CheckBox26.Checked = True
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            CheckBox28.Checked = False
            CheckBox27.Checked = False
            CheckBox26.Checked = False
            CheckBox29.Checked = False
            CheckBox25.Checked = True
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked = True Then
            CheckBox39.Checked = False
            CheckBox38.Checked = False
            CheckBox37.Checked = False
            CheckBox36.Checked = False
            CheckBox40.Checked = True
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked = True Then
            CheckBox40.Checked = False
            CheckBox38.Checked = False
            CheckBox37.Checked = False
            CheckBox35.Checked = False
            CheckBox39.Checked = True
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            CheckBox40.Checked = False
            CheckBox39.Checked = False
            CheckBox37.Checked = False
            CheckBox34.Checked = False
            CheckBox38.Checked = True
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            CheckBox40.Checked = False
            CheckBox39.Checked = False
            CheckBox38.Checked = False
            CheckBox33.Checked = False
            CheckBox37.Checked = True
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            CheckBox35.Checked = False
            CheckBox34.Checked = False
            CheckBox33.Checked = False
            CheckBox40.Checked = False
            CheckBox36.Checked = True
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            CheckBox36.Checked = False
            CheckBox34.Checked = False
            CheckBox33.Checked = False
            CheckBox39.Checked = False
            CheckBox35.Checked = True
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            CheckBox36.Checked = False
            CheckBox35.Checked = False
            CheckBox33.Checked = False
            CheckBox38.Checked = False
            CheckBox34.Checked = True
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked = True Then
            CheckBox36.Checked = False
            CheckBox35.Checked = False
            CheckBox34.Checked = False
            CheckBox37.Checked = False
            CheckBox33.Checked = True
        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.Checked = True Then
            CheckBox47.Checked = False
            CheckBox46.Checked = False
            CheckBox45.Checked = False
            CheckBox44.Checked = False
            CheckBox48.Checked = True
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked = True Then
            CheckBox48.Checked = False
            CheckBox46.Checked = False
            CheckBox45.Checked = False
            CheckBox43.Checked = False
            CheckBox47.Checked = True
        End If
    End Sub

    Private Sub CheckBox46_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.Checked = True Then
            CheckBox48.Checked = False
            CheckBox47.Checked = False
            CheckBox45.Checked = False
            CheckBox42.Checked = False
            CheckBox46.Checked = True
        End If
    End Sub

    Private Sub CheckBox45_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.Checked = True Then
            CheckBox48.Checked = False
            CheckBox47.Checked = False
            CheckBox46.Checked = False
            CheckBox41.Checked = False
            CheckBox45.Checked = True
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.Checked = True Then
            CheckBox43.Checked = False
            CheckBox42.Checked = False
            CheckBox41.Checked = False
            CheckBox48.Checked = False
            CheckBox44.Checked = True
        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox43.CheckedChanged
        If CheckBox43.Checked = True Then
            CheckBox44.Checked = False
            CheckBox42.Checked = False
            CheckBox41.Checked = False
            CheckBox47.Checked = False
            CheckBox43.Checked = True
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked = True Then
            CheckBox44.Checked = False
            CheckBox43.Checked = False
            CheckBox41.Checked = False
            CheckBox46.Checked = False
            CheckBox42.Checked = True
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked = True Then
            CheckBox44.Checked = False
            CheckBox43.Checked = False
            CheckBox42.Checked = False
            CheckBox45.Checked = False
            CheckBox41.Checked = True
        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.Checked = True Then
            CheckBox55.Checked = False
            CheckBox54.Checked = False
            CheckBox53.Checked = False
            CheckBox52.Checked = False
            CheckBox56.Checked = True
        End If
    End Sub

    Private Sub CheckBox55_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.Checked = True Then
            CheckBox56.Checked = False
            CheckBox54.Checked = False
            CheckBox53.Checked = False
            CheckBox51.Checked = False
            CheckBox55.Checked = True
        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.Checked = True Then
            CheckBox56.Checked = False
            CheckBox55.Checked = False
            CheckBox53.Checked = False
            CheckBox50.Checked = False
            CheckBox54.Checked = True
        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.Checked = True Then
            CheckBox56.Checked = False
            CheckBox55.Checked = False
            CheckBox54.Checked = False
            CheckBox49.Checked = False
            CheckBox53.Checked = True
        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.Checked = True Then
            CheckBox51.Checked = False
            CheckBox50.Checked = False
            CheckBox49.Checked = False
            CheckBox56.Checked = False
            CheckBox52.Checked = True
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked = True Then
            CheckBox52.Checked = False
            CheckBox50.Checked = False
            CheckBox49.Checked = False
            CheckBox55.Checked = False
            CheckBox51.Checked = True
        End If
    End Sub

    Private Sub CheckBox50_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked = True Then
            CheckBox52.Checked = False
            CheckBox51.Checked = False
            CheckBox49.Checked = False
            CheckBox54.Checked = False
            CheckBox50.Checked = True
        End If
    End Sub

    Private Sub CheckBox49_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox49.CheckedChanged
        If CheckBox49.Checked = True Then
            CheckBox52.Checked = False
            CheckBox51.Checked = False
            CheckBox50.Checked = False
            CheckBox53.Checked = False
            CheckBox49.Checked = True
        End If
    End Sub

    Private Sub CheckBox64_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox64.CheckedChanged
        If CheckBox64.Checked = True Then
            CheckBox63.Checked = False
            CheckBox62.Checked = False
            CheckBox61.Checked = False
            CheckBox60.Checked = False
            CheckBox64.Checked = True
        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.Checked = True Then
            CheckBox64.Checked = False
            CheckBox62.Checked = False
            CheckBox61.Checked = False
            CheckBox59.Checked = False
            CheckBox63.Checked = True
        End If
    End Sub

    Private Sub CheckBox62_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox62.CheckedChanged
        If CheckBox62.Checked = True Then
            CheckBox64.Checked = False
            CheckBox63.Checked = False
            CheckBox61.Checked = False
            CheckBox58.Checked = False
            CheckBox62.Checked = True
        End If
    End Sub

    Private Sub CheckBox61_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox61.CheckedChanged
        If CheckBox61.Checked = True Then
            CheckBox64.Checked = False
            CheckBox63.Checked = False
            CheckBox62.Checked = False
            CheckBox57.Checked = False
            CheckBox61.Checked = True
        End If
    End Sub

    Private Sub CheckBox60_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox60.CheckedChanged
        If CheckBox60.Checked = True Then
            CheckBox59.Checked = False
            CheckBox58.Checked = False
            CheckBox57.Checked = False
            CheckBox64.Checked = False
            CheckBox60.Checked = True
        End If
    End Sub

    Private Sub CheckBox59_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox59.CheckedChanged
        If CheckBox59.Checked = True Then
            CheckBox60.Checked = False
            CheckBox58.Checked = False
            CheckBox57.Checked = False
            CheckBox63.Checked = False
            CheckBox59.Checked = True
        End If
    End Sub

    Private Sub CheckBox58_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox58.CheckedChanged
        If CheckBox58.Checked = True Then
            CheckBox60.Checked = False
            CheckBox59.Checked = False
            CheckBox57.Checked = False
            CheckBox62.Checked = False
            CheckBox58.Checked = True
        End If
    End Sub

    Private Sub CheckBox57_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox57.CheckedChanged
        If CheckBox57.Checked = True Then
            CheckBox60.Checked = False
            CheckBox59.Checked = False
            CheckBox58.Checked = False
            CheckBox61.Checked = False
            CheckBox57.Checked = True
        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox72.CheckedChanged
        If CheckBox72.Checked = True Then
            CheckBox71.Checked = False
            CheckBox70.Checked = False
            CheckBox69.Checked = False
            CheckBox68.Checked = False
            CheckBox72.Checked = True
        End If
    End Sub

    Private Sub CheckBox71_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox71.CheckedChanged
        If CheckBox71.Checked = True Then
            CheckBox72.Checked = False
            CheckBox70.Checked = False
            CheckBox69.Checked = False
            CheckBox67.Checked = False
            CheckBox71.Checked = True
        End If
    End Sub

    Private Sub CheckBox70_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox70.CheckedChanged
        If CheckBox70.Checked = True Then
            CheckBox72.Checked = False
            CheckBox71.Checked = False
            CheckBox69.Checked = False
            CheckBox66.Checked = False
            CheckBox70.Checked = True
        End If
    End Sub

    Private Sub CheckBox69_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox69.CheckedChanged
        If CheckBox69.Checked = True Then
            CheckBox72.Checked = False
            CheckBox71.Checked = False
            CheckBox70.Checked = False
            CheckBox65.Checked = False
            CheckBox69.Checked = True
        End If
    End Sub

    Private Sub CheckBox68_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox68.CheckedChanged
        If CheckBox68.Checked = True Then
            CheckBox67.Checked = False
            CheckBox66.Checked = False
            CheckBox65.Checked = False
            CheckBox72.Checked = False
            CheckBox68.Checked = True
        End If
    End Sub

    Private Sub CheckBox67_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox67.CheckedChanged
        If CheckBox67.Checked = True Then
            CheckBox68.Checked = False
            CheckBox66.Checked = False
            CheckBox65.Checked = False
            CheckBox71.Checked = False
            CheckBox67.Checked = True
        End If
    End Sub

    Private Sub CheckBox66_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox66.CheckedChanged
        If CheckBox66.Checked = True Then
            CheckBox67.Checked = False
            CheckBox68.Checked = False
            CheckBox65.Checked = False
            CheckBox70.Checked = False
            CheckBox66.Checked = True
        End If
    End Sub

    Private Sub CheckBox65_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox65.CheckedChanged
        If CheckBox65.Checked = True Then
            CheckBox67.Checked = False
            CheckBox66.Checked = False
            CheckBox68.Checked = False
            CheckBox69.Checked = False
            CheckBox65.Checked = True
        End If
    End Sub

    Private Sub CheckBox80_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox80.CheckedChanged
        If CheckBox80.Checked = True Then
            CheckBox79.Checked = False
            CheckBox78.Checked = False
            CheckBox77.Checked = False
            CheckBox76.Checked = False
            CheckBox80.Checked = True
        End If
    End Sub

    Private Sub CheckBox79_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox79.CheckedChanged
        If CheckBox79.Checked = True Then
            CheckBox80.Checked = False
            CheckBox78.Checked = False
            CheckBox77.Checked = False
            CheckBox75.Checked = False
            CheckBox79.Checked = True
        End If
    End Sub

    Private Sub CheckBox78_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox78.CheckedChanged
        If CheckBox78.Checked = True Then
            CheckBox80.Checked = False
            CheckBox79.Checked = False
            CheckBox77.Checked = False
            CheckBox74.Checked = False
            CheckBox78.Checked = True
        End If
    End Sub

    Private Sub CheckBox77_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox77.CheckedChanged
        If CheckBox77.Checked = True Then
            CheckBox80.Checked = False
            CheckBox79.Checked = False
            CheckBox78.Checked = False
            CheckBox73.Checked = False
            CheckBox77.Checked = True
        End If
    End Sub

    Private Sub CheckBox76_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox76.CheckedChanged
        If CheckBox76.Checked = True Then
            CheckBox75.Checked = False
            CheckBox74.Checked = False
            CheckBox73.Checked = False
            CheckBox80.Checked = False
            CheckBox76.Checked = True
        End If
    End Sub

    Private Sub CheckBox75_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox75.CheckedChanged
        If CheckBox75.Checked = True Then
            CheckBox76.Checked = False
            CheckBox74.Checked = False
            CheckBox73.Checked = False
            CheckBox79.Checked = False
            CheckBox75.Checked = True
        End If
    End Sub

    Private Sub CheckBox74_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox74.CheckedChanged
        If CheckBox74.Checked = True Then
            CheckBox75.Checked = False
            CheckBox76.Checked = False
            CheckBox73.Checked = False
            CheckBox78.Checked = False
            CheckBox74.Checked = True
        End If
    End Sub

    Private Sub CheckBox73_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox73.CheckedChanged
        If CheckBox73.Checked = True Then
            CheckBox75.Checked = False
            CheckBox74.Checked = False
            CheckBox76.Checked = False
            CheckBox77.Checked = False
            CheckBox73.Checked = True
        End If
    End Sub

    Private Sub CheckBox88_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox88.CheckedChanged
        If CheckBox88.Checked = True Then
            CheckBox87.Checked = False
            CheckBox86.Checked = False
            CheckBox85.Checked = False
            CheckBox84.Checked = False
            CheckBox88.Checked = True
        End If
    End Sub

    Private Sub CheckBox87_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox87.CheckedChanged
        If CheckBox87.Checked = True Then
            CheckBox88.Checked = False
            CheckBox86.Checked = False
            CheckBox85.Checked = False
            CheckBox83.Checked = False
            CheckBox87.Checked = True
        End If
    End Sub

    Private Sub CheckBox86_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox86.CheckedChanged
        If CheckBox86.Checked = True Then
            CheckBox87.Checked = False
            CheckBox88.Checked = False
            CheckBox85.Checked = False
            CheckBox82.Checked = False
            CheckBox86.Checked = True
        End If
    End Sub

    Private Sub CheckBox85_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox85.CheckedChanged
        If CheckBox85.Checked = True Then
            CheckBox87.Checked = False
            CheckBox86.Checked = False
            CheckBox88.Checked = False
            CheckBox81.Checked = False
            CheckBox85.Checked = True
        End If
    End Sub

    Private Sub CheckBox84_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox84.CheckedChanged
        If CheckBox84.Checked = True Then
            CheckBox83.Checked = False
            CheckBox82.Checked = False
            CheckBox81.Checked = False
            CheckBox88.Checked = False
            CheckBox84.Checked = True
        End If
    End Sub

    Private Sub CheckBox83_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox83.CheckedChanged
        If CheckBox83.Checked = True Then
            CheckBox84.Checked = False
            CheckBox82.Checked = False
            CheckBox81.Checked = False
            CheckBox87.Checked = False
            CheckBox83.Checked = True
        End If
    End Sub

    Private Sub CheckBox82_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox82.CheckedChanged
        If CheckBox82.Checked = True Then
            CheckBox83.Checked = False
            CheckBox84.Checked = False
            CheckBox81.Checked = False
            CheckBox86.Checked = False
            CheckBox82.Checked = True
        End If
    End Sub

    Private Sub CheckBox81_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox81.CheckedChanged
        If CheckBox81.Checked = True Then
            CheckBox83.Checked = False
            CheckBox82.Checked = False
            CheckBox84.Checked = False
            CheckBox85.Checked = False
            CheckBox81.Checked = True
        End If
    End Sub

    Private Sub CheckBox96_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox96.CheckedChanged
        If CheckBox96.Checked = True Then
            CheckBox95.Checked = False
            CheckBox94.Checked = False
            CheckBox93.Checked = False
            CheckBox92.Checked = False
            CheckBox96.Checked = True
        End If
    End Sub

    Private Sub CheckBox95_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox95.CheckedChanged
        If CheckBox95.Checked = True Then
            CheckBox96.Checked = False
            CheckBox94.Checked = False
            CheckBox93.Checked = False
            CheckBox91.Checked = False
            CheckBox95.Checked = True
        End If
    End Sub

    Private Sub CheckBox94_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox94.CheckedChanged
        If CheckBox94.Checked = True Then
            CheckBox95.Checked = False
            CheckBox96.Checked = False
            CheckBox93.Checked = False
            CheckBox90.Checked = False
            CheckBox94.Checked = True
        End If
    End Sub

    Private Sub CheckBox93_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox93.CheckedChanged
        If CheckBox93.Checked = True Then
            CheckBox95.Checked = False
            CheckBox94.Checked = False
            CheckBox96.Checked = False
            CheckBox89.Checked = False
            CheckBox93.Checked = True
        End If
    End Sub

    Private Sub CheckBox92_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox92.CheckedChanged
        If CheckBox92.Checked = True Then
            CheckBox91.Checked = False
            CheckBox90.Checked = False
            CheckBox89.Checked = False
            CheckBox96.Checked = False
            CheckBox92.Checked = True
        End If
    End Sub

    Private Sub CheckBox91_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox91.CheckedChanged
        If CheckBox91.Checked = True Then
            CheckBox92.Checked = False
            CheckBox90.Checked = False
            CheckBox89.Checked = False
            CheckBox95.Checked = False
            CheckBox91.Checked = True
        End If
    End Sub

    Private Sub CheckBox90_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox90.CheckedChanged
        If CheckBox90.Checked = True Then
            CheckBox91.Checked = False
            CheckBox92.Checked = False
            CheckBox89.Checked = False
            CheckBox94.Checked = False
            CheckBox90.Checked = True
        End If
    End Sub

    Private Sub CheckBox89_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox89.CheckedChanged
        If CheckBox89.Checked = True Then
            CheckBox91.Checked = False
            CheckBox90.Checked = False
            CheckBox92.Checked = False
            CheckBox93.Checked = False
            CheckBox89.Checked = True
        End If
    End Sub

    Private Sub CheckBox104_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox104.CheckedChanged
        If CheckBox104.Checked = True Then
            CheckBox100.Checked = False
            CheckBox103.Checked = False
            CheckBox102.Checked = False
            CheckBox101.Checked = False
            CheckBox104.Checked = True
        End If
    End Sub

    Private Sub CheckBox103_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox103.CheckedChanged
        If CheckBox103.Checked = True Then
            CheckBox99.Checked = False
            CheckBox104.Checked = False
            CheckBox102.Checked = False
            CheckBox101.Checked = False
            CheckBox103.Checked = True
        End If
    End Sub

    Private Sub CheckBox102_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox102.CheckedChanged
        If CheckBox102.Checked = True Then
            CheckBox98.Checked = False
            CheckBox103.Checked = False
            CheckBox104.Checked = False
            CheckBox101.Checked = False
            CheckBox102.Checked = True
        End If
    End Sub

    Private Sub CheckBox101_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox101.CheckedChanged
        If CheckBox101.Checked = True Then
            CheckBox97.Checked = False
            CheckBox103.Checked = False
            CheckBox102.Checked = False
            CheckBox104.Checked = False
            CheckBox101.Checked = True
        End If
    End Sub

    Private Sub CheckBox100_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox100.CheckedChanged
        If CheckBox100.Checked = True Then
            CheckBox104.Checked = False
            CheckBox99.Checked = False
            CheckBox98.Checked = False
            CheckBox97.Checked = False
            CheckBox100.Checked = True
        End If
    End Sub

    Private Sub CheckBox99_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox99.CheckedChanged
        If CheckBox99.Checked = True Then
            CheckBox103.Checked = False
            CheckBox100.Checked = False
            CheckBox98.Checked = False
            CheckBox97.Checked = False
            CheckBox99.Checked = True
        End If
    End Sub

    Private Sub CheckBox98_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox98.CheckedChanged
        If CheckBox98.Checked = True Then
            CheckBox102.Checked = False
            CheckBox100.Checked = False
            CheckBox99.Checked = False
            CheckBox97.Checked = False
            CheckBox98.Checked = True
        End If
    End Sub

    Private Sub CheckBox97_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox97.CheckedChanged
        If CheckBox97.Checked = True Then
            CheckBox101.Checked = False
            CheckBox100.Checked = False
            CheckBox99.Checked = False
            CheckBox98.Checked = False
            CheckBox97.Checked = True
        End If
    End Sub

    Private Sub CheckBox112_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox112.CheckedChanged
        If CheckBox112.Checked = True Then
            CheckBox108.Checked = False
            CheckBox111.Checked = False
            CheckBox110.Checked = False
            CheckBox109.Checked = False
            CheckBox112.Checked = True
        End If
    End Sub

    Private Sub CheckBox111_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox111.CheckedChanged
        If CheckBox111.Checked = True Then
            CheckBox107.Checked = False
            CheckBox112.Checked = False
            CheckBox110.Checked = False
            CheckBox109.Checked = False
            CheckBox111.Checked = True
        End If
    End Sub

    Private Sub CheckBox110_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox110.CheckedChanged
        If CheckBox110.Checked = True Then
            CheckBox106.Checked = False
            CheckBox112.Checked = False
            CheckBox111.Checked = False
            CheckBox109.Checked = False
            CheckBox110.Checked = True
        End If
    End Sub

    Private Sub CheckBox109_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox109.CheckedChanged
        If CheckBox109.Checked = True Then
            CheckBox105.Checked = False
            CheckBox111.Checked = False
            CheckBox110.Checked = False
            CheckBox112.Checked = False
            CheckBox109.Checked = True
        End If
    End Sub

    Private Sub CheckBox108_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox108.CheckedChanged
        If CheckBox108.Checked = True Then
            CheckBox112.Checked = False
            CheckBox107.Checked = False
            CheckBox106.Checked = False
            CheckBox105.Checked = False
            CheckBox108.Checked = True
        End If
    End Sub

    Private Sub CheckBox107_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox107.CheckedChanged
        If CheckBox107.Checked = True Then
            CheckBox111.Checked = False
            CheckBox108.Checked = False
            CheckBox106.Checked = False
            CheckBox105.Checked = False
            CheckBox107.Checked = True
        End If
    End Sub

    Private Sub CheckBox106_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox106.CheckedChanged
        If CheckBox106.Checked = True Then
            CheckBox110.Checked = False
            CheckBox108.Checked = False
            CheckBox107.Checked = False
            CheckBox105.Checked = False
            CheckBox106.Checked = True
        End If
    End Sub

    Private Sub CheckBox105_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox105.CheckedChanged
        If CheckBox105.Checked = True Then
            CheckBox109.Checked = False
            CheckBox107.Checked = False
            CheckBox106.Checked = False
            CheckBox108.Checked = False
            CheckBox105.Checked = True
        End If
    End Sub

    Private Sub CheckBox120_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox120.CheckedChanged
        If CheckBox120.Checked = True Then
            CheckBox116.Checked = False
            CheckBox119.Checked = False
            CheckBox118.Checked = False
            CheckBox117.Checked = False
            CheckBox120.Checked = True
        End If
    End Sub

    Private Sub CheckBox119_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox119.CheckedChanged
        If CheckBox119.Checked = True Then
            CheckBox115.Checked = False
            CheckBox120.Checked = False
            CheckBox118.Checked = False
            CheckBox117.Checked = False
            CheckBox119.Checked = True
        End If
    End Sub

    Private Sub CheckBox118_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox118.CheckedChanged
        If CheckBox118.Checked = True Then
            CheckBox114.Checked = False
            CheckBox120.Checked = False
            CheckBox119.Checked = False
            CheckBox117.Checked = False
            CheckBox118.Checked = True
        End If
    End Sub

    Private Sub CheckBox117_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox117.CheckedChanged
        If CheckBox117.Checked = True Then
            CheckBox113.Checked = False
            CheckBox119.Checked = False
            CheckBox118.Checked = False
            CheckBox120.Checked = False
            CheckBox117.Checked = True
        End If
    End Sub

    Private Sub CheckBox116_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox116.CheckedChanged
        If CheckBox116.Checked = True Then
            CheckBox120.Checked = False
            CheckBox115.Checked = False
            CheckBox114.Checked = False
            CheckBox113.Checked = False
            CheckBox116.Checked = True
        End If
    End Sub

    Private Sub CheckBox115_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox115.CheckedChanged
        If CheckBox115.Checked = True Then
            CheckBox119.Checked = False
            CheckBox116.Checked = False
            CheckBox114.Checked = False
            CheckBox113.Checked = False
            CheckBox115.Checked = True
        End If
    End Sub

    Private Sub CheckBox114_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox114.CheckedChanged
        If CheckBox114.Checked = True Then
            CheckBox118.Checked = False
            CheckBox115.Checked = False
            CheckBox116.Checked = False
            CheckBox113.Checked = False
            CheckBox114.Checked = True
        End If
    End Sub

    Private Sub CheckBox113_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox113.CheckedChanged
        If CheckBox113.Checked = True Then
            CheckBox117.Checked = False
            CheckBox115.Checked = False
            CheckBox114.Checked = False
            CheckBox116.Checked = False
            CheckBox113.Checked = True
        End If
    End Sub

    Private Sub CheckBox128_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox128.CheckedChanged
        If CheckBox128.Checked = True Then
            CheckBox124.Checked = False
            CheckBox127.Checked = False
            CheckBox126.Checked = False
            CheckBox125.Checked = False
            CheckBox128.Checked = True
        End If
    End Sub

    Private Sub CheckBox127_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox127.CheckedChanged
        If CheckBox127.Checked = True Then
            CheckBox123.Checked = False
            CheckBox128.Checked = False
            CheckBox126.Checked = False
            CheckBox125.Checked = False
            CheckBox127.Checked = True
        End If
    End Sub

    Private Sub CheckBox126_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox126.CheckedChanged
        If CheckBox126.Checked = True Then
            CheckBox122.Checked = False
            CheckBox127.Checked = False
            CheckBox128.Checked = False
            CheckBox125.Checked = False
            CheckBox126.Checked = True
        End If
    End Sub

    Private Sub CheckBox125_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox125.CheckedChanged
        If CheckBox125.Checked = True Then
            CheckBox121.Checked = False
            CheckBox127.Checked = False
            CheckBox126.Checked = False
            CheckBox128.Checked = False
            CheckBox125.Checked = True
        End If
    End Sub

    Private Sub CheckBox124_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox124.CheckedChanged
        If CheckBox124.Checked = True Then
            CheckBox128.Checked = False
            CheckBox123.Checked = False
            CheckBox122.Checked = False
            CheckBox121.Checked = False
            CheckBox124.Checked = True
        End If
    End Sub

    Private Sub CheckBox123_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox123.CheckedChanged
        If CheckBox123.Checked = True Then
            CheckBox127.Checked = False
            CheckBox124.Checked = False
            CheckBox122.Checked = False
            CheckBox121.Checked = False
            CheckBox123.Checked = True
        End If
    End Sub

    Private Sub CheckBox122_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox122.CheckedChanged
        If CheckBox122.Checked = True Then
            CheckBox126.Checked = False
            CheckBox123.Checked = False
            CheckBox124.Checked = False
            CheckBox121.Checked = False
            CheckBox122.Checked = True
        End If
    End Sub

    Private Sub CheckBox121_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox121.CheckedChanged
        If CheckBox121.Checked = True Then
            CheckBox125.Checked = False
            CheckBox122.Checked = False
            CheckBox123.Checked = False
            CheckBox124.Checked = False
            CheckBox121.Checked = True
        End If
    End Sub

    Private Sub CheckBox136_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox136.CheckedChanged
        If CheckBox136.Checked = True Then
            CheckBox132.Checked = False
            CheckBox135.Checked = False
            CheckBox134.Checked = False
            CheckBox133.Checked = False
            CheckBox136.Checked = True
        End If
    End Sub

    Private Sub CheckBox135_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox135.CheckedChanged
        If CheckBox135.Checked = True Then
            CheckBox131.Checked = False
            CheckBox136.Checked = False
            CheckBox134.Checked = False
            CheckBox133.Checked = False
            CheckBox135.Checked = True
        End If
    End Sub

    Private Sub CheckBox134_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox134.CheckedChanged
        If CheckBox134.Checked = True Then
            CheckBox130.Checked = False
            CheckBox135.Checked = False
            CheckBox136.Checked = False
            CheckBox133.Checked = False
            CheckBox134.Checked = True
        End If
    End Sub

    Private Sub CheckBox133_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox133.CheckedChanged
        If CheckBox133.Checked = True Then
            CheckBox129.Checked = False
            CheckBox135.Checked = False
            CheckBox134.Checked = False
            CheckBox136.Checked = False
            CheckBox133.Checked = True
        End If
    End Sub

    Private Sub CheckBox132_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox132.CheckedChanged
        If CheckBox132.Checked = True Then
            CheckBox136.Checked = False
            CheckBox131.Checked = False
            CheckBox130.Checked = False
            CheckBox129.Checked = False
            CheckBox132.Checked = True
        End If
    End Sub

    Private Sub CheckBox131_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox131.CheckedChanged
        If CheckBox131.Checked = True Then
            CheckBox135.Checked = False
            CheckBox132.Checked = False
            CheckBox130.Checked = False
            CheckBox129.Checked = False
            CheckBox131.Checked = True
        End If
    End Sub

    Private Sub CheckBox130_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox130.CheckedChanged
        If CheckBox130.Checked = True Then
            CheckBox134.Checked = False
            CheckBox131.Checked = False
            CheckBox132.Checked = False
            CheckBox129.Checked = False
            CheckBox130.Checked = True
        End If
    End Sub

    Private Sub CheckBox129_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox129.CheckedChanged
        If CheckBox129.Checked = True Then
            CheckBox133.Checked = False
            CheckBox131.Checked = False
            CheckBox130.Checked = False
            CheckBox132.Checked = False
            CheckBox129.Checked = True
        End If
    End Sub

    Private Sub CheckBox144_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox144.CheckedChanged
        If CheckBox144.Checked = True Then
            CheckBox140.Checked = False
            CheckBox143.Checked = False
            CheckBox142.Checked = False
            CheckBox141.Checked = False
            CheckBox144.Checked = True
        End If
    End Sub

    Private Sub CheckBox143_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox143.CheckedChanged
        If CheckBox143.Checked = True Then
            CheckBox139.Checked = False
            CheckBox144.Checked = False
            CheckBox142.Checked = False
            CheckBox141.Checked = False
            CheckBox143.Checked = True
        End If
    End Sub

    Private Sub CheckBox142_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox142.CheckedChanged
        If CheckBox142.Checked = True Then
            CheckBox138.Checked = False
            CheckBox143.Checked = False
            CheckBox144.Checked = False
            CheckBox141.Checked = False
            CheckBox142.Checked = True
        End If
    End Sub

    Private Sub CheckBox141_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox141.CheckedChanged
        If CheckBox141.Checked = True Then
            CheckBox137.Checked = False
            CheckBox143.Checked = False
            CheckBox142.Checked = False
            CheckBox144.Checked = False
            CheckBox141.Checked = True
        End If
    End Sub

    Private Sub CheckBox140_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox140.CheckedChanged
        If CheckBox140.Checked = True Then
            CheckBox144.Checked = False
            CheckBox139.Checked = False
            CheckBox138.Checked = False
            CheckBox137.Checked = False
            CheckBox140.Checked = True
        End If
    End Sub

    Private Sub CheckBox139_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox139.CheckedChanged
        If CheckBox139.Checked = True Then
            CheckBox143.Checked = False
            CheckBox140.Checked = False
            CheckBox138.Checked = False
            CheckBox137.Checked = False
            CheckBox139.Checked = True
        End If
    End Sub

    Private Sub CheckBox138_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox138.CheckedChanged
        If CheckBox138.Checked = True Then
            CheckBox142.Checked = False
            CheckBox139.Checked = False
            CheckBox140.Checked = False
            CheckBox137.Checked = False
            CheckBox138.Checked = True
        End If
    End Sub

    Private Sub CheckBox137_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox137.CheckedChanged
        If CheckBox137.Checked = True Then
            CheckBox141.Checked = False
            CheckBox139.Checked = False
            CheckBox138.Checked = False
            CheckBox140.Checked = False
            CheckBox137.Checked = True
        End If
    End Sub

    Private Sub CheckBox192_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox192.CheckedChanged
        If CheckBox192.Checked = True Then
            CheckBox188.Checked = False
            CheckBox191.Checked = False
            CheckBox190.Checked = False
            CheckBox189.Checked = False
            CheckBox192.Checked = True
        End If
    End Sub

    Private Sub CheckBox191_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox191.CheckedChanged
        If CheckBox191.Checked = True Then
            CheckBox187.Checked = False
            CheckBox192.Checked = False
            CheckBox190.Checked = False
            CheckBox189.Checked = False
            CheckBox191.Checked = True
        End If
    End Sub

    Private Sub CheckBox190_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox190.CheckedChanged
        If CheckBox190.Checked = True Then
            CheckBox186.Checked = False
            CheckBox191.Checked = False
            CheckBox192.Checked = False
            CheckBox189.Checked = False
            CheckBox190.Checked = True
        End If
    End Sub

    Private Sub CheckBox189_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox189.CheckedChanged
        If CheckBox189.Checked = True Then
            CheckBox185.Checked = False
            CheckBox191.Checked = False
            CheckBox190.Checked = False
            CheckBox182.Checked = False
            CheckBox189.Checked = True
        End If
    End Sub

    Private Sub CheckBox188_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox188.CheckedChanged
        If CheckBox188.Checked = True Then
            CheckBox192.Checked = False
            CheckBox187.Checked = False
            CheckBox186.Checked = False
            CheckBox185.Checked = False
            CheckBox188.Checked = True
        End If
    End Sub

    Private Sub CheckBox187_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox187.CheckedChanged
        If CheckBox187.Checked = True Then
            CheckBox191.Checked = False
            CheckBox188.Checked = False
            CheckBox186.Checked = False
            CheckBox185.Checked = False
            CheckBox187.Checked = True
        End If
    End Sub

    Private Sub CheckBox186_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox186.CheckedChanged
        If CheckBox186.Checked = True Then
            CheckBox190.Checked = False
            CheckBox187.Checked = False
            CheckBox188.Checked = False
            CheckBox185.Checked = False
            CheckBox186.Checked = True
        End If
    End Sub

    Private Sub CheckBox185_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox185.CheckedChanged
        If CheckBox185.Checked = True Then
            CheckBox189.Checked = False
            CheckBox187.Checked = False
            CheckBox186.Checked = False
            CheckBox188.Checked = False
            CheckBox185.Checked = True
        End If
    End Sub

    Private Sub CheckBox184_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox184.CheckedChanged
        If CheckBox184.Checked = True Then
            CheckBox180.Checked = False
            CheckBox183.Checked = False
            CheckBox182.Checked = False
            CheckBox181.Checked = False
            CheckBox184.Checked = True
        End If
    End Sub

    Private Sub CheckBox183_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox183.CheckedChanged
        If CheckBox183.Checked = True Then
            CheckBox179.Checked = False
            CheckBox184.Checked = False
            CheckBox182.Checked = False
            CheckBox181.Checked = False
            CheckBox183.Checked = True
        End If
    End Sub

    Private Sub CheckBox182_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox182.CheckedChanged
        If CheckBox182.Checked = True Then
            CheckBox178.Checked = False
            CheckBox183.Checked = False
            CheckBox184.Checked = False
            CheckBox181.Checked = False
            CheckBox182.Checked = True
        End If
    End Sub

    Private Sub CheckBox181_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox181.CheckedChanged
        If CheckBox181.Checked = True Then
            CheckBox177.Checked = False
            CheckBox183.Checked = False
            CheckBox182.Checked = False
            CheckBox184.Checked = False
            CheckBox181.Checked = True
        End If
    End Sub

    Private Sub CheckBox180_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox180.CheckedChanged
        If CheckBox180.Checked = True Then
            CheckBox184.Checked = False
            CheckBox179.Checked = False
            CheckBox178.Checked = False
            CheckBox177.Checked = False
            CheckBox180.Checked = True
        End If
    End Sub

    Private Sub CheckBox179_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox179.CheckedChanged
        If CheckBox179.Checked = True Then
            CheckBox183.Checked = False
            CheckBox180.Checked = False
            CheckBox178.Checked = False
            CheckBox177.Checked = False
            CheckBox179.Checked = True
        End If
    End Sub

    Private Sub CheckBox178_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox178.CheckedChanged
        If CheckBox178.Checked = True Then
            CheckBox182.Checked = False
            CheckBox179.Checked = False
            CheckBox180.Checked = False
            CheckBox177.Checked = False
            CheckBox178.Checked = True
        End If
    End Sub

    Private Sub CheckBox177_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox177.CheckedChanged
        If CheckBox177.Checked = True Then
            CheckBox181.Checked = False
            CheckBox179.Checked = False
            CheckBox178.Checked = False
            CheckBox180.Checked = False
            CheckBox177.Checked = True
        End If
    End Sub

    Private Sub CheckBox176_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox176.CheckedChanged
        If CheckBox176.Checked = True Then
            CheckBox172.Checked = False
            CheckBox175.Checked = False
            CheckBox174.Checked = False
            CheckBox173.Checked = False
            CheckBox176.Checked = True
        End If
    End Sub

    Private Sub CheckBox175_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox175.CheckedChanged
        If CheckBox175.Checked = True Then
            CheckBox171.Checked = False
            CheckBox176.Checked = False
            CheckBox174.Checked = False
            CheckBox173.Checked = False
            CheckBox175.Checked = True
        End If
    End Sub

    Private Sub CheckBox174_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox174.CheckedChanged
        If CheckBox174.Checked = True Then
            CheckBox170.Checked = False
            CheckBox175.Checked = False
            CheckBox176.Checked = False
            CheckBox173.Checked = False
            CheckBox174.Checked = True
        End If
    End Sub

    Private Sub CheckBox173_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox173.CheckedChanged
        If CheckBox173.Checked = True Then
            CheckBox169.Checked = False
            CheckBox175.Checked = False
            CheckBox174.Checked = False
            CheckBox176.Checked = False
            CheckBox173.Checked = True
        End If
    End Sub

    Private Sub CheckBox172_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox172.CheckedChanged
        If CheckBox172.Checked = True Then
            CheckBox176.Checked = False
            CheckBox171.Checked = False
            CheckBox170.Checked = False
            CheckBox169.Checked = False
            CheckBox172.Checked = True
        End If
    End Sub

    Private Sub CheckBox171_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox171.CheckedChanged
        If CheckBox171.Checked = True Then
            CheckBox175.Checked = False
            CheckBox172.Checked = False
            CheckBox170.Checked = False
            CheckBox169.Checked = False
            CheckBox171.Checked = True
        End If
    End Sub

    Private Sub CheckBox170_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox170.CheckedChanged
        If CheckBox170.Checked = True Then
            CheckBox174.Checked = False
            CheckBox171.Checked = False
            CheckBox172.Checked = False
            CheckBox169.Checked = False
            CheckBox170.Checked = True
        End If
    End Sub

    Private Sub CheckBox169_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox169.CheckedChanged
        If CheckBox169.Checked = True Then
            CheckBox173.Checked = False
            CheckBox171.Checked = False
            CheckBox170.Checked = False
            CheckBox172.Checked = False
            CheckBox169.Checked = True
        End If
    End Sub

    Private Sub CheckBox168_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox168.CheckedChanged
        If CheckBox168.Checked = True Then
            CheckBox164.Checked = False
            CheckBox167.Checked = False
            CheckBox166.Checked = False
            CheckBox165.Checked = False
            CheckBox168.Checked = True
        End If
    End Sub

    Private Sub CheckBox167_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox167.CheckedChanged
        If CheckBox167.Checked = True Then
            CheckBox163.Checked = False
            CheckBox168.Checked = False
            CheckBox166.Checked = False
            CheckBox165.Checked = False
            CheckBox167.Checked = True
        End If
    End Sub

    Private Sub CheckBox166_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox166.CheckedChanged
        If CheckBox166.Checked = True Then
            CheckBox162.Checked = False
            CheckBox167.Checked = False
            CheckBox168.Checked = False
            CheckBox165.Checked = False
            CheckBox166.Checked = True
        End If
    End Sub

    Private Sub CheckBox165_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox165.CheckedChanged
        If CheckBox165.Checked = True Then
            CheckBox161.Checked = False
            CheckBox167.Checked = False
            CheckBox166.Checked = False
            CheckBox168.Checked = False
            CheckBox165.Checked = True
        End If
    End Sub

    Private Sub CheckBox164_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox164.CheckedChanged
        If CheckBox164.Checked = True Then
            CheckBox168.Checked = False
            CheckBox163.Checked = False
            CheckBox162.Checked = False
            CheckBox161.Checked = False
            CheckBox164.Checked = True
        End If
    End Sub

    Private Sub CheckBox163_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox163.CheckedChanged
        If CheckBox163.Checked = True Then
            CheckBox167.Checked = False
            CheckBox164.Checked = False
            CheckBox162.Checked = False
            CheckBox161.Checked = False
            CheckBox163.Checked = True
        End If
    End Sub

    Private Sub CheckBox162_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox162.CheckedChanged
        If CheckBox162.Checked = True Then
            CheckBox166.Checked = False
            CheckBox163.Checked = False
            CheckBox164.Checked = False
            CheckBox161.Checked = False
            CheckBox162.Checked = True
        End If
    End Sub

    Private Sub CheckBox161_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox161.CheckedChanged
        If CheckBox161.Checked = True Then
            CheckBox165.Checked = False
            CheckBox163.Checked = False
            CheckBox162.Checked = False
            CheckBox164.Checked = False
            CheckBox161.Checked = True
        End If
    End Sub

    Private Sub CheckBox160_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox160.CheckedChanged
        If CheckBox160.Checked = True Then
            CheckBox156.Checked = False
            CheckBox159.Checked = False
            CheckBox158.Checked = False
            CheckBox157.Checked = False
            CheckBox160.Checked = True
        End If
    End Sub

    Private Sub CheckBox159_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox159.CheckedChanged
        If CheckBox159.Checked = True Then
            CheckBox155.Checked = False
            CheckBox160.Checked = False
            CheckBox158.Checked = False
            CheckBox157.Checked = False
            CheckBox159.Checked = True
        End If
    End Sub

    Private Sub CheckBox158_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox158.CheckedChanged
        If CheckBox158.Checked = True Then
            CheckBox154.Checked = False
            CheckBox159.Checked = False
            CheckBox160.Checked = False
            CheckBox157.Checked = False
            CheckBox158.Checked = True
        End If
    End Sub

    Private Sub CheckBox157_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox157.CheckedChanged
        If CheckBox157.Checked = True Then
            CheckBox153.Checked = False
            CheckBox159.Checked = False
            CheckBox158.Checked = False
            CheckBox160.Checked = False
            CheckBox157.Checked = True
        End If
    End Sub

    Private Sub CheckBox156_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox156.CheckedChanged
        If CheckBox156.Checked = True Then
            CheckBox160.Checked = False
            CheckBox155.Checked = False
            CheckBox154.Checked = False
            CheckBox153.Checked = False
            CheckBox156.Checked = True
        End If
    End Sub

    Private Sub CheckBox155_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox155.CheckedChanged
        If CheckBox155.Checked = True Then
            CheckBox159.Checked = False
            CheckBox156.Checked = False
            CheckBox154.Checked = False
            CheckBox153.Checked = False
            CheckBox155.Checked = True
        End If
    End Sub

    Private Sub CheckBox154_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox154.CheckedChanged
        If CheckBox154.Checked = True Then
            CheckBox158.Checked = False
            CheckBox155.Checked = False
            CheckBox156.Checked = False
            CheckBox153.Checked = False
            CheckBox154.Checked = True
        End If
    End Sub

    Private Sub CheckBox153_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox153.CheckedChanged
        If CheckBox153.Checked = True Then
            CheckBox157.Checked = False
            CheckBox155.Checked = False
            CheckBox154.Checked = False
            CheckBox156.Checked = False
            CheckBox153.Checked = True
        End If
    End Sub

    Private Sub CheckBox152_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox152.CheckedChanged
        If CheckBox152.Checked = True Then
            CheckBox148.Checked = False
            CheckBox151.Checked = False
            CheckBox150.Checked = False
            CheckBox149.Checked = False
            CheckBox152.Checked = True
        End If
    End Sub

    Private Sub CheckBox151_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox151.CheckedChanged
        If CheckBox151.Checked = True Then
            CheckBox147.Checked = False
            CheckBox152.Checked = False
            CheckBox150.Checked = False
            CheckBox149.Checked = False
            CheckBox151.Checked = True
        End If
    End Sub

    Private Sub CheckBox150_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox150.CheckedChanged
        If CheckBox150.Checked = True Then
            CheckBox146.Checked = False
            CheckBox151.Checked = False
            CheckBox152.Checked = False
            CheckBox149.Checked = False
            CheckBox150.Checked = True
        End If
    End Sub

    Private Sub CheckBox149_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox149.CheckedChanged
        If CheckBox149.Checked = True Then
            CheckBox145.Checked = False
            CheckBox151.Checked = False
            CheckBox150.Checked = False
            CheckBox152.Checked = False
            CheckBox149.Checked = True
        End If
    End Sub

    Private Sub CheckBox148_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox148.CheckedChanged
        If CheckBox148.Checked = True Then
            CheckBox152.Checked = False
            CheckBox147.Checked = False
            CheckBox146.Checked = False
            CheckBox145.Checked = False
            CheckBox148.Checked = True
        End If
    End Sub

    Private Sub CheckBox147_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox147.CheckedChanged
        If CheckBox147.Checked = True Then
            CheckBox151.Checked = False
            CheckBox148.Checked = False
            CheckBox146.Checked = False
            CheckBox145.Checked = False
            CheckBox147.Checked = True
        End If
    End Sub

    Private Sub CheckBox146_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox146.CheckedChanged
        If CheckBox146.Checked = True Then
            CheckBox150.Checked = False
            CheckBox147.Checked = False
            CheckBox148.Checked = False
            CheckBox145.Checked = False
            CheckBox146.Checked = True
        End If
    End Sub

    Private Sub CheckBox145_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox145.CheckedChanged
        If CheckBox145.Checked = True Then
            CheckBox149.Checked = False
            CheckBox147.Checked = False
            CheckBox146.Checked = False
            CheckBox148.Checked = False
            CheckBox145.Checked = True
        End If
    End Sub

    
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim empujem As Integer
        Dim influenciam As Integer
        Dim constanciam As Integer
        Dim cumpliminetom As Integer
        Dim empujel As Integer
        Dim influencial As Integer
        Dim constancial As Integer
        Dim cumpliminetol As Integer

        '*******************************

        If CheckBox1.Checked = True Then
            lbl1.Text = "1"
        Else
            lbl1.Text = "0"
        End If

        If CheckBox2.Checked = True Then
            lbl3.Text = "1"
        Else
            lbl3.Text = "0"
        End If

        If CheckBox3.Checked = True Then
            lbl5.Text = "1"
        Else
            lbl5.Text = "0"
        End If

        If CheckBox4.Checked = True Then
            lbl7.Text = "1"
        Else
            lbl7.Text = "0"
        End If

        If CheckBox5.Checked = True Then
            lbl2.Text = "1"
        Else
            lbl2.Text = "0"
        End If

        If CheckBox6.Checked = True Then
            lbl4.Text = "1"
        Else
            lbl4.Text = "0"
        End If

        If CheckBox7.Checked = True Then
            lbl6.Text = "1"
        Else
            lbl6.Text = "0"
        End If

        If CheckBox8.Checked = True Then
            lbl8.Text = "1"
        Else
            lbl8.Text = "0"
        End If

        If CheckBox9.Checked = True Then
            lbl16.Text = "1"
        Else
            lbl16.Text = "0"
        End If

        If CheckBox10.Checked = True Then
            lbl14.Text = "1"
        Else
            lbl14.Text = "0"
        End If

        If CheckBox11.Checked = True Then
            lbl12.Text = "1"
        Else
            lbl12.Text = "0"
        End If

        If CheckBox12.Checked = True Then
            lbl10.Text = "1"
        Else
            lbl10.Text = "0"
        End If

        If CheckBox13.Checked = True Then
            lbl15.Text = "1"
        Else
            lbl15.Text = "0"
        End If

        If CheckBox14.Checked = True Then
            lbl13.Text = "1"
        Else
            lbl13.Text = "0"
        End If

        If CheckBox15.Checked = True Then
            lbl11.Text = "1"
        Else
            lbl11.Text = "0"
        End If

        If CheckBox16.Checked = True Then
            lbl9.Text = "1"
        Else
            lbl9.Text = "0"
        End If

        If CheckBox17.Checked = True Then
            lbl24.Text = "1"
        Else
            lbl24.Text = "0"
        End If

        If CheckBox18.Checked = True Then
            lbl22.Text = "1"
        Else
            lbl22.Text = "0"
        End If

        If CheckBox19.Checked = True Then
            lbl20.Text = "1"
        Else
            lbl20.Text = "0"
        End If

        If CheckBox20.Checked = True Then
            lbl18.Text = "1"
        Else
            lbl18.Text = "0"
        End If

        If CheckBox21.Checked = True Then
            lbl23.Text = "1"
        Else
            lbl23.Text = "0"
        End If

        If CheckBox22.Checked = True Then
            lbl21.Text = "1"
        Else
            lbl21.Text = "0"
        End If

        If CheckBox23.Checked = True Then
            lbl19.Text = "1"
        Else
            lbl19.Text = "0"
        End If

        If CheckBox24.Checked = True Then
            lbl17.Text = "1"
        Else
            lbl17.Text = "0"
        End If

        If CheckBox25.Checked = True Then
            lbl32.Text = "1"
        Else
            lbl32.Text = "0"
        End If

        If CheckBox26.Checked = True Then
            lbl30.Text = "1"
        Else
            lbl30.Text = "0"
        End If

        If CheckBox27.Checked = True Then
            lbl28.Text = "1"
        Else
            lbl28.Text = "0"
        End If

        If CheckBox28.Checked = True Then
            lbl26.Text = "1"
        Else
            lbl26.Text = "0"
        End If

        If CheckBox29.Checked = True Then
            lbl31.Text = "1"
        Else
            lbl31.Text = "0"
        End If

        If CheckBox30.Checked = True Then
            lbl29.Text = "1"
        Else
            lbl29.Text = "0"
        End If

        If CheckBox31.Checked = True Then
            lbl27.Text = "1"
        Else
            lbl27.Text = "0"
        End If

        If CheckBox32.Checked = True Then
            lbl25.Text = "1"
        Else
            lbl25.Text = "0"
        End If

        If CheckBox33.Checked = True Then
            lbl40.Text = "1"
        Else
            lbl40.Text = "0"
        End If

        If CheckBox34.Checked = True Then
            lbl38.Text = "1"
        Else
            lbl38.Text = "0"
        End If

        If CheckBox35.Checked = True Then
            lbl36.Text = "1"
        Else
            lbl36.Text = "0"
        End If

        If CheckBox36.Checked = True Then
            lbl34.Text = "1"
        Else
            lbl34.Text = "0"
        End If

        If CheckBox37.Checked = True Then
            lbl39.Text = "1"
        Else
            lbl39.Text = "0"
        End If

        If CheckBox38.Checked = True Then
            lbl37.Text = "1"
        Else
            lbl37.Text = "0"
        End If

        If CheckBox39.Checked = True Then
            lbl35.Text = "1"
        Else
            lbl35.Text = "0"
        End If

        If CheckBox40.Checked = True Then
            lbl33.Text = "1"
        Else
            lbl33.Text = "0"
        End If

        If CheckBox41.Checked = True Then
            lbl48.Text = "1"
        Else
            lbl48.Text = "0"
        End If

        If CheckBox42.Checked = True Then
            lbl46.Text = "1"
        Else
            lbl46.Text = "0"
        End If

        If CheckBox43.Checked = True Then
            lbl44.Text = "1"
        Else
            lbl44.Text = "0"
        End If

        If CheckBox44.Checked = True Then
            lbl42.Text = "1"
        Else
            lbl42.Text = "0"
        End If

        If CheckBox45.Checked = True Then
            lbl47.Text = "1"
        Else
            lbl47.Text = "0"
        End If

        If CheckBox46.Checked = True Then
            lbl45.Text = "1"
        Else
            lbl45.Text = "0"
        End If

        If CheckBox47.Checked = True Then
            lbl43.Text = "1"
        Else
            lbl43.Text = "0"
        End If

        If CheckBox48.Checked = True Then
            lbl41.Text = "1"
        Else
            lbl41.Text = "0"
        End If

        If CheckBox49.Checked = True Then
            lbl56.Text = "1"
        Else
            lbl56.Text = "0"
        End If

        If CheckBox50.Checked = True Then
            lbl54.Text = "1"
        Else
            lbl54.Text = "0"
        End If

        If CheckBox51.Checked = True Then
            lbl52.Text = "1"
        Else
            lbl52.Text = "0"
        End If

        If CheckBox52.Checked = True Then
            lbl50.Text = "1"
        Else
            lbl50.Text = "0"
        End If

        If CheckBox53.Checked = True Then
            lbl55.Text = "1"
        Else
            lbl55.Text = "0"
        End If

        If CheckBox54.Checked = True Then
            lbl53.Text = "1"
        Else
            lbl53.Text = "0"
        End If

        If CheckBox55.Checked = True Then
            lbl51.Text = "1"
        Else
            lbl51.Text = "0"
        End If

        If CheckBox56.Checked = True Then
            lbl49.Text = "1"
        Else
            lbl49.Text = "0"
        End If

        If CheckBox57.Checked = True Then
            lbl64.Text = "1"
        Else
            lbl64.Text = "0"
        End If

        If CheckBox58.Checked = True Then
            lbl62.Text = "1"
        Else
            lbl62.Text = "0"
        End If

        If CheckBox59.Checked = True Then
            lbl60.Text = "1"
        Else
            lbl60.Text = "0"
        End If

        If CheckBox60.Checked = True Then
            lbl58.Text = "1"
        Else
            lbl58.Text = "0"
        End If

        If CheckBox61.Checked = True Then
            lbl63.Text = "1"
        Else
            lbl63.Text = "0"
        End If

        If CheckBox62.Checked = True Then
            lbl61.Text = "1"
        Else
            lbl61.Text = "0"
        End If

        If CheckBox63.Checked = True Then
            lbl59.Text = "1"
        Else
            lbl59.Text = "0"
        End If

        If CheckBox64.Checked = True Then
            lbl57.Text = "1"
        Else
            lbl57.Text = "0"
        End If

        If CheckBox65.Checked = True Then
            lbl72.Text = "1"
        Else
            lbl72.Text = "0"
        End If

        If CheckBox66.Checked = True Then
            lbl70.Text = "1"
        Else
            lbl70.Text = "0"
        End If

        If CheckBox67.Checked = True Then
            lbl68.Text = "1"
        Else
            lbl68.Text = "0"
        End If

        If CheckBox68.Checked = True Then
            lbl66.Text = "1"
        Else
            lbl66.Text = "0"
        End If

        If CheckBox69.Checked = True Then
            lbl71.Text = "1"
        Else
            lbl71.Text = "0"
        End If

        If CheckBox70.Checked = True Then
            lbl69.Text = "1"
        Else
            lbl69.Text = "0"
        End If

        If CheckBox71.Checked = True Then
            lbl67.Text = "1"
        Else
            lbl67.Text = "0"
        End If

        If CheckBox72.Checked = True Then
            lbl65.Text = "1"
        Else
            lbl65.Text = "0"
        End If

        If CheckBox73.Checked = True Then
            lbl80.Text = "1"
        Else
            lbl80.Text = "0"
        End If

        If CheckBox74.Checked = True Then
            lbl78.Text = "1"
        Else
            lbl78.Text = "0"
        End If

        If CheckBox75.Checked = True Then
            lbl76.Text = "1"
        Else
            lbl76.Text = "0"
        End If

        If CheckBox76.Checked = True Then
            lbl74.Text = "1"
        Else
            lbl74.Text = "0"
        End If

        If CheckBox77.Checked = True Then
            lbl79.Text = "1"
        Else
            lbl79.Text = "0"
        End If

        If CheckBox78.Checked = True Then
            lbl77.Text = "1"
        Else
            lbl77.Text = "0"
        End If

        If CheckBox79.Checked = True Then
            lbl75.Text = "1"
        Else
            lbl75.Text = "0"
        End If

        If CheckBox80.Checked = True Then
            lbl73.Text = "1"
        Else
            lbl73.Text = "0"
        End If

        If CheckBox81.Checked = True Then
            lbl88.Text = "1"
        Else
            lbl88.Text = "0"
        End If

        If CheckBox82.Checked = True Then
            lbl86.Text = "1"
        Else
            lbl86.Text = "0"
        End If

        If CheckBox83.Checked = True Then
            lbl84.Text = "1"
        Else
            lbl84.Text = "0"
        End If

        If CheckBox84.Checked = True Then
            lbl82.Text = "1"
        Else
            lbl82.Text = "0"
        End If

        If CheckBox85.Checked = True Then
            lbl87.Text = "1"
        Else
            lbl87.Text = "0"
        End If

        If CheckBox86.Checked = True Then
            lbl85.Text = "1"
        Else
            lbl85.Text = "0"
        End If

        If CheckBox87.Checked = True Then
            lbl83.Text = "1"
        Else
            lbl83.Text = "0"
        End If

        If CheckBox88.Checked = True Then
            lbl81.Text = "1"
        Else
            lbl81.Text = "0"
        End If

        If CheckBox89.Checked = True Then
            lbl96.Text = "1"
        Else
            lbl96.Text = "0"
        End If

        If CheckBox90.Checked = True Then
            lbl94.Text = "1"
        Else
            lbl94.Text = "0"
        End If

        If CheckBox91.Checked = True Then
            lbl92.Text = "1"
        Else
            lbl92.Text = "0"
        End If

        If CheckBox92.Checked = True Then
            lbl90.Text = "1"
        Else
            lbl90.Text = "0"
        End If

        If CheckBox93.Checked = True Then
            lbl95.Text = "1"
        Else
            lbl95.Text = "0"
        End If

        If CheckBox94.Checked = True Then
            lbl93.Text = "1"
        Else
            lbl93.Text = "0"
        End If

        If CheckBox95.Checked = True Then
            lbl91.Text = "1"
        Else
            lbl91.Text = "0"
        End If

        If CheckBox96.Checked = True Then
            lbl89.Text = "1"
        Else
            lbl89.Text = "0"
        End If

        If CheckBox97.Checked = True Then
            lbl104.Text = "1"
        Else
            lbl104.Text = "0"
        End If

        If CheckBox98.Checked = True Then
            lbl102.Text = "1"
        Else
            lbl102.Text = "0"
        End If

        If CheckBox99.Checked = True Then
            lbl100.Text = "1"
        Else
            lbl100.Text = "0"
        End If

        If CheckBox100.Checked = True Then
            lbl98.Text = "1"
        Else
            lbl98.Text = "0"
        End If

        If CheckBox101.Checked = True Then
            lbl103.Text = "1"
        Else
            lbl103.Text = "0"
        End If

        If CheckBox102.Checked = True Then
            lbl101.Text = "1"
        Else
            lbl101.Text = "0"
        End If

        If CheckBox103.Checked = True Then
            lbl99.Text = "1"
        Else
            lbl99.Text = "0"
        End If

        If CheckBox104.Checked = True Then
            lbl97.Text = "1"
        Else
            lbl97.Text = "0"
        End If
        If CheckBox105.Checked = True Then
            lbl112.Text = "1"
        Else
            lbl112.Text = "0"
        End If

        If CheckBox106.Checked = True Then
            lbl110.Text = "1"
        Else
            lbl110.Text = "0"
        End If

        If CheckBox107.Checked = True Then
            lbl108.Text = "1"
        Else
            lbl108.Text = "0"
        End If

        If CheckBox108.Checked = True Then
            lbl106.Text = "1"
        Else
            lbl106.Text = "0"
        End If

        If CheckBox109.Checked = True Then
            lbl111.Text = "1"
        Else
            lbl111.Text = "0"
        End If

        If CheckBox110.Checked = True Then
            lbl109.Text = "1"
        Else
            lbl109.Text = "0"
        End If

        If CheckBox111.Checked = True Then
            lbl107.Text = "1"
        Else
            lbl107.Text = "0"
        End If

        If CheckBox112.Checked = True Then
            lbl105.Text = "1"
        Else
            lbl105.Text = "0"
        End If

        If CheckBox113.Checked = True Then
            lbl120.Text = "1"
        Else
            lbl120.Text = "0"
        End If

        If CheckBox114.Checked = True Then
            lbl118.Text = "1"
        Else
            lbl118.Text = "0"
        End If

        If CheckBox115.Checked = True Then
            lbl116.Text = "1"
        Else
            lbl116.Text = "0"
        End If

        If CheckBox116.Checked = True Then
            lbl114.Text = "1"
        Else
            lbl114.Text = "0"
        End If

        If CheckBox117.Checked = True Then
            lbl119.Text = "1"
        Else
            lbl119.Text = "0"
        End If

        If CheckBox118.Checked = True Then
            lbl117.Text = "1"
        Else
            lbl117.Text = "0"
        End If

        If CheckBox119.Checked = True Then
            lbl115.Text = "1"
        Else
            lbl115.Text = "0"
        End If

        If CheckBox120.Checked = True Then
            lbl113.Text = "1"
        Else
            lbl113.Text = "0"
        End If

        If CheckBox121.Checked = True Then
            lbl128.Text = "1"
        Else
            lbl128.Text = "0"
        End If

        If CheckBox122.Checked = True Then
            lbl126.Text = "1"
        Else
            lbl126.Text = "0"
        End If

        If CheckBox123.Checked = True Then
            lbl124.Text = "1"
        Else
            lbl124.Text = "0"
        End If

        If CheckBox124.Checked = True Then
            lbl122.Text = "1"
        Else
            lbl122.Text = "0"
        End If

        If CheckBox125.Checked = True Then
            lbl127.Text = "1"
        Else
            lbl127.Text = "0"
        End If

        If CheckBox126.Checked = True Then
            lbl125.Text = "1"
        Else
            lbl125.Text = "0"
        End If

        If CheckBox127.Checked = True Then
            lbl123.Text = "1"
        Else
            lbl123.Text = "0"
        End If

        If CheckBox128.Checked = True Then
            lbl121.Text = "1"
        Else
            lbl121.Text = "0"
        End If

        If CheckBox129.Checked = True Then
            lbl136.Text = "1"
        Else
            lbl136.Text = "0"
        End If

        If CheckBox130.Checked = True Then
            lbl134.Text = "1"
        Else
            lbl134.Text = "0"
        End If

        If CheckBox131.Checked = True Then
            lbl132.Text = "1"
        Else
            lbl132.Text = "0"
        End If

        If CheckBox132.Checked = True Then
            lbl130.Text = "1"
        Else
            lbl130.Text = "0"
        End If

        If CheckBox133.Checked = True Then
            lbl135.Text = "1"
        Else
            lbl135.Text = "0"
        End If

        If CheckBox134.Checked = True Then
            lbl133.Text = "1"
        Else
            lbl133.Text = "0"
        End If

        If CheckBox135.Checked = True Then
            lbl131.Text = "1"
        Else
            lbl131.Text = "0"
        End If

        If CheckBox136.Checked = True Then
            lbl129.Text = "1"
        Else
            lbl129.Text = "0"
        End If

        If CheckBox137.Checked = True Then
            lbl144.Text = "1"
        Else
            lbl144.Text = "0"
        End If

        If CheckBox138.Checked = True Then
            lbl142.Text = "1"
        Else
            lbl142.Text = "0"
        End If

        If CheckBox139.Checked = True Then
            lbl140.Text = "1"
        Else
            lbl140.Text = "0"
        End If

        If CheckBox140.Checked = True Then
            lbl138.Text = "1"
        Else
            lbl138.Text = "0"
        End If

        If CheckBox141.Checked = True Then
            lbl143.Text = "1"
        Else
            lbl143.Text = "0"
        End If

        If CheckBox142.Checked = True Then
            lbl141.Text = "1"
        Else
            lbl141.Text = "0"
        End If

        If CheckBox143.Checked = True Then
            lbl139.Text = "1"
        Else
            lbl139.Text = "0"
        End If

        If CheckBox144.Checked = True Then
            lbl137.Text = "1"
        Else
            lbl137.Text = "0"
        End If

        If CheckBox145.Checked = True Then
            lbl192.Text = "1"
        Else
            lbl192.Text = "0"
        End If

        If CheckBox146.Checked = True Then
            lbl190.Text = "1"
        Else
            lbl190.Text = "0"
        End If

        If CheckBox147.Checked = True Then
            lbl188.Text = "1"
        Else
            lbl188.Text = "0"
        End If

        If CheckBox148.Checked = True Then
            lbl186.Text = "1"
        Else
            lbl186.Text = "0"
        End If

        If CheckBox149.Checked = True Then
            lbl191.Text = "1"
        Else
            lbl191.Text = "0"
        End If

        If CheckBox150.Checked = True Then
            lbl189.Text = "1"
        Else
            lbl189.Text = "0"
        End If

        If CheckBox151.Checked = True Then
            lbl187.Text = "1"
        Else
            lbl187.Text = "0"
        End If

        If CheckBox152.Checked = True Then
            lbl185.Text = "1"
        Else
            lbl185.Text = "0"
        End If

        If CheckBox153.Checked = True Then
            lbl184.Text = "1"
        Else
            lbl184.Text = "0"
        End If

        If CheckBox154.Checked = True Then
            lbl182.Text = "1"
        Else
            lbl182.Text = "0"
        End If

        If CheckBox155.Checked = True Then
            lbl180.Text = "1"
        Else
            lbl180.Text = "0"
        End If

        If CheckBox156.Checked = True Then
            lbl178.Text = "1"
        Else
            lbl178.Text = "0"
        End If

        If CheckBox157.Checked = True Then
            lbl183.Text = "1"
        Else
            lbl183.Text = "0"
        End If

        If CheckBox158.Checked = True Then
            lbl181.Text = "1"
        Else
            lbl181.Text = "0"
        End If

        If CheckBox159.Checked = True Then
            lbl179.Text = "1"
        Else
            lbl179.Text = "0"
        End If

        If CheckBox160.Checked = True Then
            lbl177.Text = "1"
        Else
            lbl177.Text = "0"
        End If

        If CheckBox161.Checked = True Then
            lbl176.Text = "1"
        Else
            lbl176.Text = "0"
        End If

        If CheckBox162.Checked = True Then
            lbl174.Text = "1"
        Else
            lbl174.Text = "0"
        End If

        If CheckBox163.Checked = True Then
            lbl172.Text = "1"
        Else
            lbl172.Text = "0"
        End If

        If CheckBox164.Checked = True Then
            lbl170.Text = "1"
        Else
            lbl170.Text = "0"
        End If

        If CheckBox165.Checked = True Then
            lbl175.Text = "1"
        Else
            lbl175.Text = "0"
        End If

        If CheckBox166.Checked = True Then
            lbl173.Text = "1"
        Else
            lbl173.Text = "0"
        End If

        If CheckBox167.Checked = True Then
            lbl171.Text = "1"
        Else
            lbl171.Text = "0"
        End If

        If CheckBox168.Checked = True Then
            lbl169.Text = "1"
        Else
            lbl169.Text = "0"
        End If

        If CheckBox169.Checked = True Then
            lbl168.Text = "1"
        Else
            lbl168.Text = "0"
        End If

        If CheckBox170.Checked = True Then
            lbl166.Text = "1"
        Else
            lbl166.Text = "0"
        End If

        If CheckBox171.Checked = True Then
            lbl164.Text = "1"
        Else
            lbl164.Text = "0"
        End If

        If CheckBox172.Checked = True Then
            lbl162.Text = "1"
        Else
            lbl162.Text = "0"
        End If

        If CheckBox173.Checked = True Then
            lbl167.Text = "1"
        Else
            lbl167.Text = "0"
        End If

        If CheckBox174.Checked = True Then
            lbl165.Text = "1"
        Else
            lbl165.Text = "0"
        End If

        If CheckBox175.Checked = True Then
            lbl163.Text = "1"
        Else
            lbl163.Text = "0"
        End If

        If CheckBox176.Checked = True Then
            lbl161.Text = "1"
        Else
            lbl161.Text = "0"
        End If

        If CheckBox177.Checked = True Then
            lbl160.Text = "1"
        Else
            lbl160.Text = "0"
        End If

        If CheckBox178.Checked = True Then
            lbl158.Text = "1"
        Else
            lbl158.Text = "0"
        End If

        If CheckBox179.Checked = True Then
            lbl156.Text = "1"
        Else
            lbl156.Text = "0"
        End If

        If CheckBox180.Checked = True Then
            lbl154.Text = "1"
        Else
            lbl154.Text = "0"
        End If

        If CheckBox181.Checked = True Then
            lbl159.Text = "1"
        Else
            lbl159.Text = "0"
        End If

        If CheckBox182.Checked = True Then
            lbl157.Text = "1"
        Else
            lbl157.Text = "0"
        End If

        If CheckBox183.Checked = True Then
            lbl155.Text = "1"
        Else
            lbl155.Text = "0"
        End If

        If CheckBox184.Checked = True Then
            lbl153.Text = "1"
        Else
            lbl153.Text = "0"
        End If

        If CheckBox185.Checked = True Then
            lbl152.Text = "1"
        Else
            lbl152.Text = "0"
        End If

        If CheckBox186.Checked = True Then
            lbl150.Text = "1"
        Else
            lbl150.Text = "0"
        End If

        If CheckBox187.Checked = True Then
            lbl148.Text = "1"
        Else
            lbl148.Text = "0"
        End If

        If CheckBox188.Checked = True Then
            lbl146.Text = "1"
        Else
            lbl146.Text = "0"
        End If

        If CheckBox189.Checked = True Then
            lbl151.Text = "1"
        Else
            lbl151.Text = "0"
        End If

        If CheckBox190.Checked = True Then
            lbl149.Text = "1"
        Else
            lbl149.Text = "0"
        End If

        If CheckBox191.Checked = True Then
            lbl147.Text = "1"
        Else
            lbl147.Text = "0"
        End If

        If CheckBox192.Checked = True Then
            lbl145.Text = "1"
        Else
            lbl145.Text = "0"
        End If

        Dim ctotal As Integer
        ctotal = 0
        ctotal = CInt(lbl1.Text) + CInt(lbl2.Text) + CInt(lbl3.Text) + CInt(lbl4.Text) + CInt(lbl5.Text) + CInt(lbl6.Text) + CInt(lbl7.Text) + CInt(lbl8.Text) +
            CInt(lbl9.Text) + CInt(lbl10.Text) + CInt(lbl11.Text) + CInt(lbl12.Text) + CInt(lbl13.Text) + CInt(lbl14.Text) + CInt(lbl15.Text) + CInt(lbl16.Text) +
            CInt(lbl17.Text) + CInt(lbl18.Text) + CInt(lbl19.Text) + CInt(lbl20.Text) + CInt(lbl21.Text) + CInt(lbl22.Text) + CInt(lbl23.Text) + CInt(lbl24.Text) +
            CInt(lbl25.Text) + CInt(lbl26.Text) + CInt(lbl27.Text) + CInt(lbl28.Text) + CInt(lbl29.Text) + CInt(lbl30.Text) + CInt(lbl31.Text) + CInt(lbl32.Text) +
            CInt(lbl33.Text) + CInt(lbl34.Text) + CInt(lbl35.Text) + CInt(lbl36.Text) + CInt(lbl37.Text) + CInt(lbl38.Text) + CInt(lbl39.Text) + CInt(lbl40.Text) + CInt(lbl41.Text) +
            CInt(lbl42.Text) + CInt(lbl43.Text) + CInt(lbl44.Text) + CInt(lbl45.Text) + CInt(lbl46.Text) + CInt(lbl47.Text) + CInt(lbl48.Text) + CInt(lbl49.Text) + CInt(lbl50.Text) +
            CInt(lbl51.Text) + CInt(lbl52.Text) + CInt(lbl53.Text) + CInt(lbl54.Text) + CInt(lbl55.Text) + CInt(lbl56.Text) + CInt(lbl57.Text) + CInt(lbl58.Text) + CInt(lbl59.Text) +
            CInt(lbl60.Text) + CInt(lbl61.Text) + CInt(lbl62.Text) + CInt(lbl63.Text) + CInt(lbl64.Text) + CInt(lbl65.Text) + CInt(lbl66.Text) + CInt(lbl67.Text) + CInt(lbl68.Text) +
            CInt(lbl69.Text) + CInt(lbl70.Text) + CInt(lbl71.Text) + CInt(lbl72.Text) + CInt(lbl73.Text) + CInt(lbl74.Text) + CInt(lbl75.Text) + CInt(lbl76.Text) + CInt(lbl77.Text) +
            CInt(lbl78.Text) + CInt(lbl79.Text) + CInt(lbl80.Text) + CInt(lbl81.Text) + CInt(lbl82.Text) + CInt(lbl83.Text) + CInt(lbl84.Text) + CInt(lbl85.Text) + CInt(lbl86.Text) +
            CInt(lbl87.Text) + CInt(lbl88.Text) + CInt(lbl89.Text) + CInt(lbl90.Text) + CInt(lbl91.Text) + CInt(lbl92.Text) + CInt(lbl93.Text) + CInt(lbl94.Text) + CInt(lbl95.Text) +
            CInt(lbl96.Text) + CInt(lbl97.Text) + CInt(lbl98.Text) + CInt(lbl99.Text) + CInt(lbl100.Text) + CInt(lbl101.Text) + CInt(lbl102.Text) + CInt(lbl103.Text) + CInt(lbl104.Text) +
            CInt(lbl105.Text) + CInt(lbl106.Text) + CInt(lbl107.Text) + CInt(lbl108.Text) + CInt(lbl109.Text) + CInt(lbl110.Text) + CInt(lbl111.Text) + CInt(lbl112.Text) + CInt(lbl113.Text) +
            CInt(lbl114.Text) + CInt(lbl115.Text) + CInt(lbl116.Text) + CInt(lbl117.Text) + CInt(lbl118.Text) + CInt(lbl119.Text) + CInt(lbl120.Text) + CInt(lbl121.Text) + CInt(lbl122.Text) +
            CInt(lbl123.Text) + CInt(lbl124.Text) + CInt(lbl125.Text) + CInt(lbl126.Text) + CInt(lbl127.Text) + CInt(lbl128.Text) + CInt(lbl129.Text) + CInt(lbl130.Text) + CInt(lbl131.Text) +
            CInt(lbl132.Text) + CInt(lbl133.Text) + CInt(lbl134.Text) + CInt(lbl135.Text) + CInt(lbl136.Text) + CInt(lbl137.Text) + CInt(lbl138.Text) + CInt(lbl139.Text) + CInt(lbl140.Text) +
            CInt(lbl141.Text) + CInt(lbl142.Text) + CInt(lbl143.Text) + CInt(lbl144.Text) + CInt(lbl145.Text) + CInt(lbl146.Text) + CInt(lbl147.Text) + CInt(lbl148.Text) + CInt(lbl149.Text) +
            CInt(lbl150.Text) + CInt(lbl151.Text) + CInt(lbl152.Text) + CInt(lbl153.Text) + CInt(lbl154.Text) + CInt(lbl155.Text) + CInt(lbl156.Text) + CInt(lbl157.Text) + CInt(lbl158.Text) +
            CInt(lbl159.Text) + CInt(lbl160.Text) + CInt(lbl161.Text) + CInt(lbl162.Text) + CInt(lbl163.Text) + CInt(lbl164.Text) + CInt(lbl165.Text) + CInt(lbl166.Text) + CInt(lbl167.Text) +
            CInt(lbl168.Text) + CInt(lbl169.Text) + CInt(lbl170.Text) + CInt(lbl171.Text) + CInt(lbl172.Text) + CInt(lbl173.Text) + CInt(lbl174.Text) + CInt(lbl175.Text) + CInt(lbl176.Text) +
            CInt(lbl177.Text) + CInt(lbl178.Text) + CInt(lbl179.Text) + CInt(lbl180.Text) + CInt(lbl181.Text) + CInt(lbl182.Text) + CInt(lbl183.Text) + CInt(lbl184.Text) + CInt(lbl185.Text) +
            CInt(lbl186.Text) + CInt(lbl187.Text) + CInt(lbl188.Text) + CInt(lbl189.Text) + CInt(lbl190.Text) + CInt(lbl191.Text) + CInt(lbl192.Text)
        If ctotal >= 48 Then
            '*******************************

            empujem = CInt(lbl9.Text) + CInt(lbl21.Text) + CInt(lbl27.Text) + CInt(lbl35.Text) + CInt(lbl63.Text) + CInt(lbl79.Text) + CInt(lbl81.Text) + CInt(lbl95.Text) + CInt(lbl101.Text) + CInt(lbl107.Text) + CInt(lbl113.Text) + CInt(lbl123.Text) + CInt(lbl133.Text) + CInt(lbl143.Text) + CInt(lbl145.Text) + CInt(lbl157.Text) + CInt(lbl167.Text) + CInt(lbl173.Text) + CInt(lbl179.Text) + CInt(lbl185.Text)
            empujel = CInt(lbl8.Text) + CInt(lbl22.Text) + CInt(lbl36.Text) + CInt(lbl48.Text) + CInt(lbl50.Text) + CInt(lbl64.Text) + CInt(lbl70.Text) + CInt(lbl80.Text) + CInt(lbl82.Text) + CInt(lbl96.Text) + CInt(lbl102.Text) + CInt(lbl108.Text) + CInt(lbl124.Text) + CInt(lbl134.Text) + CInt(lbl144.Text) + CInt(lbl146.Text) + CInt(lbl158.Text) + CInt(lbl168.Text) + CInt(lbl174.Text) + CInt(lbl180.Text) + CInt(lbl186.Text)
            influenciam = CInt(lbl1.Text) + CInt(lbl11.Text) + CInt(lbl23.Text) + CInt(lbl29.Text) + CInt(lbl39.Text) + CInt(lbl55.Text) + CInt(lbl57.Text) + CInt(lbl89.Text) + CInt(lbl103.Text) + CInt(lbl109.Text) + CInt(lbl115.Text) + CInt(lbl127.Text) + CInt(lbl129.Text) + CInt(lbl149.Text) + CInt(lbl159.Text) + CInt(lbl161.Text) + CInt(lbl175.Text) + CInt(lbl187.Text)
            influencial = CInt(lbl12.Text) + CInt(lbl24.Text) + CInt(lbl30.Text) + CInt(lbl40.Text) + CInt(lbl56.Text) + CInt(lbl72.Text) + CInt(lbl78.Text) + CInt(lbl84.Text) + CInt(lbl104.Text) + CInt(lbl110.Text) + CInt(lbl128.Text) + CInt(lbl130.Text) + CInt(lbl140.Text) + CInt(lbl150.Text) + CInt(lbl160.Text) + CInt(lbl162.Text) + CInt(lbl176.Text) + CInt(lbl182.Text) + CInt(lbl188.Text)
            constanciam = CInt(lbl3.Text) + CInt(lbl13.Text) + CInt(lbl31.Text) + CInt(lbl37.Text) + CInt(lbl41.Text) + CInt(lbl53.Text) + CInt(lbl65.Text) + CInt(lbl75.Text) + CInt(lbl85.Text) + CInt(lbl91.Text) + CInt(lbl97.Text) + CInt(lbl111.Text) + CInt(lbl131.Text) + CInt(lbl139.Text) + CInt(lbl151.Text) + CInt(lbl153.Text) + CInt(lbl163.Text) + CInt(lbl183.Text) + CInt(lbl189.Text)
            constancial = CInt(lbl4.Text) + CInt(lbl14.Text) + CInt(lbl18.Text) + CInt(lbl54.Text) + CInt(lbl60.Text) + CInt(lbl66.Text) + CInt(lbl76.Text) + CInt(lbl86.Text) + CInt(lbl112.Text) + CInt(lbl118.Text) + CInt(lbl126.Text) + CInt(lbl132.Text) + CInt(lbl138.Text) + CInt(lbl152.Text) + CInt(lbl154.Text) + CInt(lbl164.Text) + CInt(lbl170.Text) + CInt(lbl184.Text) + CInt(lbl190.Text)
            cumpliminetom = CInt(lbl5.Text) + CInt(lbl19.Text) + CInt(lbl25.Text) + CInt(lbl45.Text) + CInt(lbl51.Text) + CInt(lbl67.Text) + CInt(lbl73.Text) + CInt(lbl105.Text) + CInt(lbl121.Text) + CInt(lbl135.Text) + CInt(lbl141.Text) + CInt(lbl147.Text) + CInt(lbl171.Text) + CInt(lbl177.Text) + CInt(lbl191.Text)
            cumpliminetol = CInt(lbl6.Text) + CInt(lbl16.Text) + CInt(lbl20.Text) + CInt(lbl26.Text) + CInt(lbl34.Text) + CInt(lbl46.Text) + CInt(lbl62.Text) + CInt(lbl68.Text) + CInt(lbl88.Text) + CInt(lbl94.Text) + CInt(lbl100.Text) + CInt(lbl120.Text) + CInt(lbl142.Text) + CInt(lbl156.Text) + CInt(lbl166.Text) + CInt(lbl192.Text)

            Try
                Using cnx = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
                    cnx.Open()
                    Using cmd As New SqlCommand()
                        cmd.Connection = cnx
                        cmd.CommandText = "UPDATE rh_test_cleaver SET  tst_empuje_m= @resp1,tst_empuje_l = @resp2,tst_influencia_m = @resp3,tst_influencia_l = @resp4,tst_constancia_m = @resp5,tst_constancia_l = @resp6,tst_cumplimiento_m = @resp7,tst_cumplimiento_l = @resp8 WHERE id_candidato= @id_test"
                        cmd.Parameters.AddWithValue("@resp1", empujem)
                        cmd.Parameters.AddWithValue("@resp2", empujel)
                        cmd.Parameters.AddWithValue("@resp3", influenciam)
                        cmd.Parameters.AddWithValue("@resp4", influencial)
                        cmd.Parameters.AddWithValue("@resp5", constanciam)
                        cmd.Parameters.AddWithValue("@resp6", constancial)
                        cmd.Parameters.AddWithValue("@resp7", cumpliminetom)
                        cmd.Parameters.AddWithValue("@resp8", cumpliminetol)
                        cmd.Parameters.AddWithValue("@id_test", registro1.identificador)
                        cmd.ExecuteNonQuery()
                    End Using
                    cnx.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al actualizar la información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If estadoarea = 1 Then
                INSTRUCCIONES.Show()
                Me.Close()
            Else
                End
            End If
            'Me.Close()
        Else
            MsgBox("No has llenado todas las respuestas necesarias, rectifica tus respuestas.")
        End If

    End Sub
End Class