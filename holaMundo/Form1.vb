Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim Tablas, i As SByte
        Tablas = Ctexto.Text

        Tablas1.Items.Clear()
        If Tablas <= 12 Then
            For i = 1 To 10
                Tablas1.Items.Add(Tablas.ToString() + "x" + i.ToString() + "=" + (Tablas * i).ToString())
            Next
        Else
            Tablas1.Items.Add("Por Favor  ingrese  solo tablas menores o iguales a 12")
        End If
    End Sub

    Private Sub Tablas1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tablas1.SelectedIndexChanged

    End Sub
End Class
