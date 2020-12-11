Public Class BuscarVenta
    Dim objconexion As New db_conexion
    Public idc As Integer
    Private Sub BuscarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = objconexion.obtenerdatos().Tables("Ventas").DefaultView
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        filtrar(TextBox1.Text)
        If e.KeyCode = 13 Then
            seleccionarDato()
        End If
    End Sub
    Private Sub seleccionarDato()
        idc = DataGridView1.CurrentRow.Cells("IdVentas").Value.ToString()
        Close()
    End Sub
    Private Sub filtrar(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Cliente like '%" & valor & "%' or Cliente like '%" & valor & "%'"
        DataGridView1.DataSource = bs
    End Sub

    Private Sub seleccionar_Click(sender As Object, e As EventArgs) Handles seleccionar.Click
        seleccionarDato()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
        idc = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class