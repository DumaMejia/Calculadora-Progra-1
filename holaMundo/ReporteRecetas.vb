Public Class ReporteRecetas
    Public _idRta As Integer
    Private Sub ReporteRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.ReporteReceta' Puede moverla o quitarla según sea necesario.
        Me.ReporteRecetaTableAdapter.FillReporteReceta(Me.DBClinicaDataSet3.ReporteReceta, _idRta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class