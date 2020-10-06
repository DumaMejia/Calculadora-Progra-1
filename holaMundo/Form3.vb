Public Class Form3
    Dim objconexion As New db_conexion
    Public idc As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = objconexion.obtenerdatos().Tables("medicina").DefaultView
    End Sub
End Class