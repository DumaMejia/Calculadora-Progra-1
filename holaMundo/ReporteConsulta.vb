Public Class ReporteConsulta
    Public _idCon As Integer
    Private Sub ReporteConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.RepoConsulta' Puede moverla o quitarla según sea necesario.
        Me.RepoConsultaTableAdapter.FillConsulta(Me.DBClinicaDataSetFinal.RepoConsulta, _idCon)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class