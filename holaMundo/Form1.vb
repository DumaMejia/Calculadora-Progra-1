Public Class Form1
    Dim objInteres As New interes()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        objInteres.inter = txtinteres.Text
        objInteres.tiempo = txtTiempo.Text
        objInteres.monto = txtcapital.Text
        lblInteresSimple.Text = "Interes Simple: $" & objInteres.interesSimple()
        lblinteresCompuesto.Text = "Interes Compuesto: $" & objInteres.interesCompuesto()
    End Sub
End Class

Class interes
    Dim _interes As Double, _ntiempo As Int16, _capital As Double

    Public Property inter
        Set(value)
            If value >= 0 And value <= 100 Then
                _interes = value
            Else
                MessageBox.Show("El valor del interes no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _interes
        End Get
    End Property
    Public Property tiempo
        Set(value)
            If value >= 1 And value <= 120 Then
                _ntiempo = value
            Else
                MessageBox.Show("Tiempo no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _ntiempo
        End Get
    End Property
    Public Property monto
        Set(value)
            If value > 0 Then
                _capital = value
            Else
                MessageBox.Show("El capital debe ser mayor a 0", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _capital
        End Get
    End Property

    Public Function interesSimple()
        Dim ins = _capital * (_interes / 100) * (_ntiempo / 12)
        Return Math.Round(ins, 2)
    End Function
    Public Function interesCompuesto()
        Dim inC = _capital * (1 + _interes / 100) ^ _ntiempo
        Return Math.Round(inC, 2)
    End Function
End Class


