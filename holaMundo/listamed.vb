Public Class listamed
    Private Sub listamed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.medicina' Puede moverla o quitarla según sea necesario.
        Me.medicinaTableAdapter.Fill(Me.DBClinicaDataSet3.medicina)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class