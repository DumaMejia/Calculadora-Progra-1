Public Class Form4
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
        datatable = conexion.obtenerdatos().Tables("enfermedades")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("idEnfermedad")}
    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString() 'ID de Cliente
        txtnombre.Text = datatable.Rows(posicion).ItemArray(1).ToString()
        txtdescripcion.Text = datatable.Rows(posicion).ItemArray(2).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VentanaEnfermedad As New Form2
        VentanaEnfermedad.ShowDialog()
        If VentanaEnfermedad.idc > 0 Then
            controlesBuscar(True)
            posicion = datatable.Rows.IndexOf(datatable.Rows.Find(VentanaEnfermedad.idc))
        End If
        mostrardatos()
    End Sub

    Private Sub nuevoBT_Click(sender As Object, e As EventArgs) Handles nuevoBT.Click
        If nuevoBT.Text = "Nuevo" Then 'Nuevo
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"

            controlesNuevo(False)
            limpiarCampos()
        Else 'Guardar
            Dim msg = conexion.mantenimientoEnfermedades(New String() {
                Me.Tag, txtnombre.Text, txtdescripcion.Text
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
    Private Sub limpiarCampos()
        txtnombre.Text = ""
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
            conexion.mantenimientoEnfermedades(New String() {Me.Tag}, "eliminar")
            limpiarCampos()
        End If
    End Sub
End Class