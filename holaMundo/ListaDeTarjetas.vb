Public Class ListaDeTarjetas
    Private Sub ListaDeTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.TajetaReporte' Puede moverla o quitarla según sea necesario.
        Me.TajetaReporteTableAdapter.FillTarjetas(Me.DBClinicaDataSetFinal.TajetaReporte)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class