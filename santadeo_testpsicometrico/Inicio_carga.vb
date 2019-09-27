Public Class inicio_carga
    Dim tiempo As Integer
    Private Sub inicio_carga_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1
        If tiempo = 4 Then
            Timer1.Stop()
            menuMainST.Show()
            Me.Close()
        End If
    End Sub

    
End Class