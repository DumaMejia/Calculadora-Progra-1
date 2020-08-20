Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("prueba")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")
                ComboBox2.Items.Add("1")

                ComboBox3.Items.Add("ejemplo")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")
            Case 1
                ComboBox3.Items.Add("1")
                ComboBox3.Items.Add("1")

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox2.SelectedIndex
            Case 0
                Dim Array() = {1, 2, 3, 4, 5}, Valor = Caja.Text
                If ComboBox3.SelectedIndex = 0 Then
                    Respuesta.Text = Valor * Array(0)
                End If
        End Select
    End Sub
End Class
