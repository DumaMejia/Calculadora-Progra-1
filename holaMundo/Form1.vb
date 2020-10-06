Public Class Form1
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("medicina")

        mostrardatos()
    End Sub
    Sub mostrardatos()
        MessageBox.Show("Nombre: " + datatable.Rows(1).ItemArray(1).ToString())
    End Sub

End Class

