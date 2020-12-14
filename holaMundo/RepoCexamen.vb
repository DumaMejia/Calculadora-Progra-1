Public Class RepoCexamen
    Public _idExa As Integer
    Private Sub RepoCexamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.RepoExaPaciente' Puede moverla o quitarla según sea necesario.
        Me.RepoExaPacienteTableAdapter.FillExaPaciente(Me.DBClinicaDataSetFinal.RepoExaPaciente, _idExa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class