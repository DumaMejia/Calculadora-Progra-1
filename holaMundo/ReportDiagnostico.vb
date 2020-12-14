Public Class ReportDiagnostico
    Public _idDiag As Integer
    Private Sub ReportDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.DiagRepo' Puede moverla o quitarla según sea necesario.
        Me.DiagRepoTableAdapter.FillDiag(Me.DBClinicaDataSetFinal.DiagRepo, _idDiag)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class