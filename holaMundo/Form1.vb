Public Class Form1
    Dim conexion As New db_conexion()
    Dim datatable As New DataTable
    Dim posicion As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("medicina")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("id")}
        mostrardatos()
    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString() 'ID de Cliente
        txtnombre.Text = datatable.Rows(posicion).ItemArray(1).ToString()
        txtcantidad.Text = datatable.Rows(posicion).ItemArray(2).ToString()
        txtcaducidad.Text = datatable.Rows(posicion).ItemArray(3).ToString()
        txtdescripcion.Text = datatable.Rows(posicion).ItemArray(4).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ventana As New Form3
        Ventana.ShowDialog()
        If Ventana.idc > 0 Then
            posicion = datatable.Rows.IndexOf(datatable.Rows.Find(Ventana.idc))
        End If
        mostrardatos()
    End Sub
End Class

