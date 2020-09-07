Public Class estadistica
    Dim media As Double

    Public Function calcularMedia(serie() As String)
        media = 0
        For Each num In serie
            media += num
        Next
        Return Math.Round(media / serie.Length, 2)
    End Function
    Public Function calcularVarianza(serie() As String)
        Dim m = calcularMedia(serie), var As Double

        For Each x1 In serie
            var += Math.Pow(x1 - m, 2)
        Next
        Return var / serie.Length
    End Function
    Public Function calcularDesvTipica(serie() As String)
        Dim var = calcularVarianza(serie)
        Return Math.Round(Math.Sqrt(var), 2)
    End Function
End Class
