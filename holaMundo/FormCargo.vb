Public Class FormCargo
    Dim conexion As New db_conexion()
    Dim datatable As New DataTable
    Dim posicion As Integer
    Dim cambio As String = "nuevo"
    Private Sub FormCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = conexion.obtenerdatos().Tables("CargoPersonal").DefaultView
    End Sub
End Class