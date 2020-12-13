Public Class FRventa
    Public _idVta As Integer

    Private Sub FRventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.VentasReporte' Puede moverla o quitarla según sea necesario.
        Me.VentasReporteTableAdapter.FillVentasReporte(Me.DBClinicaDataSet3.VentasReporte, _idVta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class