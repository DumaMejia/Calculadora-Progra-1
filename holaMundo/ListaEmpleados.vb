Public Class ListaEmpleados
    Private Sub ListaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSetFinal.personal' Puede moverla o quitarla según sea necesario.
        Me.personalTableAdapter.Fill(Me.DBClinicaDataSetFinal.personal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class