Public Class ReporteHorario
    Private Sub ReporteHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFINAL1.ReporteHorario' Puede moverla o quitarla según sea necesario.
        Me.ReporteHorarioTableAdapter.FillHorarioList(Me.DBClinicaDataSetFINAL1.ReporteHorario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class