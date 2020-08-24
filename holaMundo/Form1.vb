Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim es una palabra reservada para declarar una variable
        Dim num1, num2, respuesta As Double 'Declaro las variables en linea separadas por comas del mismo tipo

        num1 = txtnum1.Text 'capturando el dato que ingres el usuario a la caja de texto, asigno dicho valor a la variable num1.
        num2 = txtnum2.Text

        If optSuma.Checked Then 'If -> si de condicion
            lblrespuesta.Text = num1 + num2 'realizamos la suma
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2 'realizamos la resta
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2 'realizamos la multiplicacion
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2 'realizamos la division
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100 'Realizar el proceso de porcentaje....
        End If
        If optExponenciacion.Checked Then
            lblrespuesta.Text = num1 ^ num2 'Realizar el proceso de exponenciacion....
        End If
        If OptResiduo.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If

        Select Case ComboBox2.SelectedIndex
            Case 0
                lblrespuesta.Text = num1 + num2

            Case 1
                lblrespuesta.Text = num1 - num2

            Case 2
                lblrespuesta.Text = num1 * num2

            Case 3
                lblrespuesta.Text = num1 / num2

            Case 4
                lblrespuesta.Text = num1 * num2 / 100

            Case 5
                lblrespuesta.Text = num1 ^ num2

            Case 6
                lblrespuesta.Text = num1 Mod num2

        End Select
    End Sub
End Class

