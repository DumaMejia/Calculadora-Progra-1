Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Uni = unidades.Text
        Dim Res = respuesta.Text
        Dim Can = cantidad.Text
        Dim NoIntRes
        Dim SubIn

        If respuesta.Text = "" Then
            Res = Can / Uni
            NoIntRes = Int(Res)
            SubIn = (NoIntRes * Uni) - Can
            respuesta.Text = NoIntRes + "/" + SubIn
        End If
        If cantidad.Text = "" Then
            cantidad.Text = Res * Uni
        End If
    End Sub
End Class

