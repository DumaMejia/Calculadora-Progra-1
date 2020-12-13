Public Class Listapersonal
    Private Sub Listapersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.personal' Puede moverla o quitarla según sea necesario.
        Me.personalTableAdapter.Fill(Me.DBClinicaDataSet3.personal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class