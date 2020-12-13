Public Class ReporteCompra
    Public _idCpra As Integer
    Private Sub ReporteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.ReporteCompra' Puede moverla o quitarla según sea necesario.
        Me.ReporteCompraTableAdapter.FillReporteCompra(Me.DBClinicaDataSet3.ReporteCompra, _idCpra)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class