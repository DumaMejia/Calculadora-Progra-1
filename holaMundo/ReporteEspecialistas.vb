Public Class ReporteEspecialistas
    Private Sub ReporteEspecialistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.ListaEspecialista' Puede moverla o quitarla según sea necesario.
        Me.ListaEspecialistaTableAdapter.FillListEspecialista(Me.DBClinicaDataSetFinal.ListaEspecialista)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class