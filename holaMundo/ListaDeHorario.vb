Public Class ListaDeHorario
    Private Sub ListaDeHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.ListHorario' Puede moverla o quitarla según sea necesario.
        Me.ListHorarioTableAdapter.FillHorarioList(Me.DBClinicaDataSetFinal.ListHorario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class