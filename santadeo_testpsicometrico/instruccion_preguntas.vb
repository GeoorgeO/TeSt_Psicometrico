Public Class instruccion_preguntas

    Private Sub instruccion_preguntas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbid.Text = "Su ID es: " + CStr(registro1.identificador)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Test_Zavic.Show()
        Me.Close()
    End Sub
End Class