Public Class ListaDeUsuarios
    Private Sub ListaDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet3.UsuarioP' Puede moverla o quitarla según sea necesario.
        Me.UsuarioPTableAdapter.FillUsuariosP(Me.DBClinicaDataSet3.UsuarioP)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class