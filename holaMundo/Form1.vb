Public Class Form1
    Dim objromano = New conversor_romanos

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblRespuestaRomano.Text = objromano.convertir(txtnumero.Text)
    End Sub

End Class

Class conversor_romanos
    Dim romanos()() As String = {
        New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},'0->Unidades
        New String() {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},'1->Decenas
        New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"} '2->Centenas
    }
    Dim u, d, c, temp As Integer

    Public Function convertir(ByVal num As Integer)
        u = num Mod 10
        c = num \ 100
        temp = num Mod 100
        d = temp \ 10
        Return romanos(2)(c) + romanos(1)(d) + romanos(0)(u)
    End Function
End Class

