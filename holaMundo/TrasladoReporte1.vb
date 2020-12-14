Public Class TrasladoReporte1
    Public _idTra As Integer
    Private Sub TrasladoReporte1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.TrasladoReporte' Puede moverla o quitarla según sea necesario.
        Me.TrasladoReporteTableAdapter.FillTraslado(Me.DBClinicaDataSetFinal.TrasladoReporte, _idTra)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class