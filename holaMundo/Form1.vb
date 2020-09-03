Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Uni = unidades.Text
        Dim Res = respuesta.Text
        Dim Resp
        Dim ReC
        Dim Can = cantidad.Text
        Dim NoIntRes
        Dim SubIn
        Dim Valor2
        Dim N
        Dim Valor1
        Dim a
        Dim Fleca
        Dim Resultado


        If respuesta.Text = "" Then
            Resp = (Can / Uni)
            NoIntRes = Int(Resp)
            SubIn = Can - (NoIntRes * Uni)
            respuesta.Text = NoIntRes.ToString() + "/" + SubIn.ToString()
        End If
        If cantidad.Text = "" Then
            ReC = ""
            a = 0
            N = respuesta.Text.Length
            While a < N
                ReC = respuesta.Text.Substring(a, 1)
                If ReC = "/" Then
                    Fleca = a
                End If
                a = a + 1
            End While
            Valor1 = respuesta.Text.Substring(0, Fleca)
            N = (N - Fleca) - 1
            Fleca = Fleca + 1
            Valor2 = respuesta.Text.Substring(Fleca, N)
            Resultado = (Valor1 * Uni) + Valor2
            cantidad.Text = Resultado
        End If
    End Sub
End Class

