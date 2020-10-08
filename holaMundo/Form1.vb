Public Class Form1
    Dim conexion As New db_conexion()
    Dim datatable As New DataTable
    Dim posicion As Integer
    Dim cambio As String = "nuevo"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerdatos()
        controlesInicio(True)
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("medicina")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("id")}
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
            controlesBuscar(True)
            posicion = datatable.Rows.IndexOf(datatable.Rows.Find(Ventana.idc))
        End If
        mostrardatos()
    End Sub

    Private Sub nuevoBT_Click(sender As Object, e As EventArgs) Handles nuevoBT.Click
        If nuevoBT.Text = "Nuevo" Then 'Nuevo
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"

            controlesNuevo(False)
            limpiarMedicina()
        Else 'Guardar
            Dim msg = conexion.mantenimientoMedicina(New String() {
                Me.Tag, txtnombre.Text, txtcantidad.Text, txtcaducidad.Text, txtdescripcion.Text
               }, cambio)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerdatos()
                controlesNuevo(True)
                nuevoBT.Text = "Nuevo"
                modificarBT.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub controlesNuevo(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = Not estado
    End Sub
    Private Sub controlesInicio(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        eliminarBT.Enabled = Not estado
        Button1.Enabled = estado
        modificarBT.Enabled = Not estado
    End Sub
    Private Sub controlesBuscar(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = estado
    End Sub
    Private Sub limpiarMedicina()
        txtnombre.Text = ""
        txtcantidad.Text = ""
        txtcaducidad.Text = ""
        txtdescripcion.Text = ""
    End Sub

    Private Sub modificarBT_Click(sender As Object, e As EventArgs) Handles modificarBT.Click
        If modificarBT.Text = "Modificar" Then 'Modificar
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "modificar"
            controlesNuevo(False)
        Else 'Cancelar
            obtenerdatos()
            controlesNuevo(True)
            nuevoBT.Text = "Nuevo"
            modificarBT.Text = "Modificar"
        End If
    End Sub

    Private Sub eliminarBT_Click(sender As Object, e As EventArgs) Handles eliminarBT.Click
        If (MessageBox.Show("Esta seguro de borrar " + txtnombre.Text, "Registro de cliente",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            conexion.mantenimientoMedicina(New String() {Me.Tag}, "eliminar")
            limpiarMedicina()
        End If
    End Sub
End Class

