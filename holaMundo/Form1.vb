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

    Dim Array()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Selec = ComCA.SelectedIndex
        Dim Valor = TxtCON.Text
        Dim Resp
        Select Case ComCD.SelectedIndex
            Case 0
                Array = {1, 0.13, 0.11, 0.09, 0.00014, 0.000013, 0.0000092903}
                TxtA.Text = Valor * Array(Selec)
            Case 1
                Array = {7.53, 1, 0.84, 0.7, 0.001140024348, 0.000102568523, 0.000071684731}
                TxtA.Text = Valor * Array(Selec)
            Case 2
                Array = {9, 1.19, 1, 0.84, 0.0001474656489, 0.00011963544791, 0.00008361204013}
                TxtA.Text = Valor * Array(Selec)
            Case 3
                Array = {10.76, 1.53, 1.2, 1, 0.00159, 0.00014308280488, 0.0001}
                TxtA.Text = Valor * Array(Selec)
            Case 4
                Array = {4703.82, 624.29, 522.65, 437, 1, 0.06, 0.04}
                TxtA.Text = Valor * Array(Selec)
            Case 5
                Array = {75347.32, 10000, 8371.93, 7000, 16.02, 1, 0.7}
                TxtA.Text = Valor * Array(Selec)
            Case 6
                Array = {107639, 14285.71, 11959.9, 10000, 22.88, 1.43, 1}
                TxtA.Text = Valor * Array(Selec)
        End Select
    End Sub
End Class

