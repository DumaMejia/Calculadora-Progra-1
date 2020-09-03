Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Uni = unidades.Text
        Dim Res = respuesta.Text
        Dim Resp
        Dim Resp2
        Dim Can = cantidad.Text
        Dim NoIntRes
        Dim SubIn
        Dim CnSuma
        Dim x



        If respuesta.Text = "" Then
            Resp = (Can / Uni)
            NoIntRes = Int(Resp)
            SubIn = Can - (NoIntRes * Uni)
            respuesta.Text = NoIntRes.ToString() + "/" + SubIn.ToString()
        End If
        If cantidad.Text = "" Then
            Resp2 = respuesta.Text.Substring(0, 1)
            x = respuesta.Text.Substring(2)
            CnSuma = Resp2 * Uni + x
            cantidad.Text = CnSuma
        End If

    End Sub
End Class

