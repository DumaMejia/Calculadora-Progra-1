Public Class Dcompra
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Public idc As Integer
    Dim cambio As String = "nuevo"
    Public factura As String
    Public IdV As Integer
    Private Sub DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        posicion = 0
        obtenerdatos()
        controlesInicio(True)
        DatosGrid()
        TextBox1.Enabled = False
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("Dcompra")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("IdDcompra")}

        TextBox1.Text = factura
        IdVentaLbl.Text = IdV
        ComboBox2.DataSource = conexion.obtenerdatos().Tables("medicina").DefaultView()
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "medicina.Id"



    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString()

        ComboBox2.SelectedValue = datatable.Rows(posicion).ItemArray(2).ToString()

        TextBox2.Text = datatable.Rows(posicion).ItemArray(3).ToString()
        TextBox3.Text = datatable.Rows(posicion).ItemArray(4).ToString()

    End Sub

    Private Sub DatosGrid()
        DataGridView1.DataSource = conexion.obtenerdatos().Tables("Dcompra").DefaultView
        filtrar(TextBox1.Text.Trim)
    End Sub
    Private Sub filtrar(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Nfactura like '%" & valor & "%' or Nfactura like '%" & valor & "%'"
        DataGridView1.DataSource = bs
    End Sub
    Private Sub controlesNuevo(ByVal estado As Boolean)
        nuevoBT.Enabled = estado
        PanelDatos.Enabled = estado
        eliminarBT.Enabled = Not estado
        Button1.Enabled = Not estado
        modificarBT.Enabled = estado

    End Sub
    Private Sub controlesInicio(ByVal estado As Boolean)
        nuevoBT.Enabled = estado
        PanelBD.Enabled = Not estado
        PanelDatos.Enabled = Not estado
        eliminarBT.Enabled = Not estado
        Button1.Enabled = estado
        modificarBT.Enabled = Not estado

    End Sub
    Private Sub controlesBuscar(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        PanelBD.Enabled = estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = Not estado
        nuevoBT.Enabled = Not estado
    End Sub
    Private Sub controlesOpen(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        PanelBD.Enabled = Not estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = estado
        nuevoBT.Enabled = estado
    End Sub
    Private Sub limpiarCampos()
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub SeleccionarDato()
        idc = DataGridView1.CurrentRow.Cells("IdDcompra").Value.ToString()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Buscar" Then
            Button1.Text = "Seleccionar"
            eliminarBT.Text = "Cancelar"
            DatosGrid()
            controlesBuscar(True)
        Else
            SeleccionarDato()
            If idc > 0 Then
                posicion = datatable.Rows.IndexOf(datatable.Rows.Find(idc))
                mostrardatos()
            End If
            controlesOpen(True)
            Button1.Text = "Buscar"
            eliminarBT.Text = "Eliminar"
        End If
    End Sub
    Private Sub nuevoBT_Click(sender As Object, e As EventArgs) Handles nuevoBT.Click
        If nuevoBT.Text = "Nuevo" Then 'Nuevo
            nuevoBT.Text = "Agregar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"
            controlesNuevo(True)
            limpiarCampos()
        Else 'Guardar
            Dim msg = conexion.mantenimientoDcompra(New String() {
                Me.Tag, IdVentaLbl.Text, ComboBox2.SelectedValue, TextBox2.Text, TextBox3.Text
               }, cambio)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                limpiarCampos()
                DatosGrid()
                controlesInicio(True)
                nuevoBT.Text = "Nuevo"
                modificarBT.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub modificarBT_Click(sender As Object, e As EventArgs) Handles modificarBT.Click
        If modificarBT.Text = "Modificar" Then 'Modificar
            nuevoBT.Text = "Aceptar"
            modificarBT.Text = "Cancelar"
            cambio = "modificar"
            controlesNuevo(True)
        Else 'Cancelar
            limpiarCampos()
            controlesInicio(True)
            nuevoBT.Text = "Nuevo"
            modificarBT.Text = "Modificar"
        End If
    End Sub
    Private Sub eliminarBT_Click(sender As Object, e As EventArgs) Handles eliminarBT.Click
        If eliminarBT.Text = "Eliminar" Then
            If (MessageBox.Show("Esta seguro de borrar " + "este", " registro",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                conexion.mantenimientoDcompra(New String() {Me.Tag}, "eliminar")
                limpiarCampos()
            End If
        Else
            controlesInicio(True)
        End If
    End Sub

    Private Sub finalizarBtn_Click(sender As Object, e As EventArgs) Handles finalizarBtn.Click
        Me.Close()
    End Sub
End Class