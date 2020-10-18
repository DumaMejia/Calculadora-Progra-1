Public Class BuscarProveedor
    Dim objconexion As New db_conexion
    Public idc As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = objconexion.obtenerdatos().Tables("proveedor").DefaultView
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        filtrar(TextBox1.Text)
        If e.KeyCode = 13 Then
            seleccionarDato()
        End If
    End Sub
    Private Sub seleccionarDato()
        idc = DataGridView1.CurrentRow.Cells("Idproveedor").Value.ToString()
        Close()
    End Sub
    Private Sub filtrar(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "nombre like '%" & valor & "%' or nombre like '%" & valor & "%'"
        DataGridView1.DataSource = bs
    End Sub

    Private Sub seleccionar_Click(sender As Object, e As EventArgs) Handles seleccionar.Click
        seleccionarDato()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
        idc = 0
    End Sub
End Class