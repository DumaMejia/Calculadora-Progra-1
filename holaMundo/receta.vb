Public Class receta
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Public idD As Integer
    Dim cambio As String = "nuevo"
    Private Sub FVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        controlesInicio(True)
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("receta")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("Idreceta")}

        ComboBox1.DataSource = conexion.obtenerdatos().Tables("personal").DefaultView()
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "personal.IdPersonal"

        ComboBox2.DataSource = conexion.obtenerdatos().Tables("expediente").DefaultView()
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "expediente.IdExpediente"

        ComboBox3.DataSource = conexion.obtenerdatos().Tables("enfermedades").DefaultView()
        ComboBox3.DisplayMember = "nombre"
        ComboBox3.ValueMember = "enfermedades.IdEnfermedad"

    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString()
        TextBox1.Text = datatable.Rows(posicion).ItemArray(1).ToString()
        ComboBox1.SelectedValue = datatable.Rows(posicion).ItemArray(2).ToString()
        ComboBox2.SelectedValue = datatable.Rows(posicion).ItemArray(3).ToString()
        ComboBox3.SelectedValue = datatable.Rows(posicion).ItemArray(4).ToString()
        TextBox2.Text = datatable.Rows(posicion).ItemArray(5).ToString()
    End Sub
    Private Sub DatosGrid()
        DataGridView1.DataSource = conexion.obtenerdatos().Tables("Dreceta").DefaultView
        filtrar(TextBox2.Text.Trim)
    End Sub
    Private Sub filtrar(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Nreceta like '%" & valor & "%' or Nreceta like '%" & valor & "%'"
        DataGridView1.DataSource = bs
    End Sub
    Private Sub controlesNuevo(ByVal estado As Boolean)
        nuevoBT.Enabled = estado
        PanelDatos.Enabled = estado
        eliminarBT.Enabled = Not estado
        Button1.Enabled = Not estado
        modificarBT.Enabled = estado
        Button2.Enabled = Not estado
    End Sub
    Private Sub controlesInicio(ByVal estado As Boolean)
        nuevoBT.Enabled = estado
        PanelBD.Enabled = Not estado
        PanelDatos.Enabled = Not estado
        eliminarBT.Enabled = Not estado
        Button1.Enabled = estado
        modificarBT.Enabled = Not estado
        Button2.Enabled = Not estado
    End Sub
    Private Sub controlesBuscar(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        PanelBD.Enabled = estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = estado
        nuevoBT.Enabled = estado
        Button2.Enabled = estado
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
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Buscar As New BuscarReceta
        Buscar.ShowDialog()

        If Buscar.idc > 0 Then
            controlesBuscar(True)
            posicion = datatable.Rows.IndexOf(datatable.Rows.Find(Buscar.idc))
        End If
        mostrardatos()
        DatosGrid()
        controlesBuscar(True)
    End Sub
    Private Sub nuevoBT_Click(sender As Object, e As EventArgs) Handles nuevoBT.Click
        If nuevoBT.Text = "Nuevo" Then 'Nuevo
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"

            controlesNuevo(True)
            limpiarCampos()
        Else 'Guardar
            Dim msg = conexion.mantenimientoReceta(New String() {
                Me.Tag, TextBox1.Text, ComboBox1.SelectedValue, ComboBox2.SelectedValue, ComboBox3.SelectedValue, TextBox2.Text
               }, cambio)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerdatos()
                posicion = datatable.Rows.Count - 1
                mostrardatos()
                Dim detalle As New DetalleReceta
                detalle.factura = TextBox2.Text
                detalle.IdV = Me.Tag
                detalle.ShowDialog()

                DatosGrid()
                controlesBuscar(True)
                nuevoBT.Text = "Nuevo"
                modificarBT.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub modificarBT_Click(sender As Object, e As EventArgs) Handles modificarBT.Click
        If modificarBT.Text = "Modificar" Then 'Modificar
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "modificar"
            controlesNuevo(True)
        Else 'Cancelar
            obtenerdatos()
            controlesInicio(True)
            nuevoBT.Text = "Nuevo"
            modificarBT.Text = "Modificar"
        End If
    End Sub
    Private Sub eliminarBT_Click(sender As Object, e As EventArgs) Handles eliminarBT.Click
        If eliminarBT.Text = "Eliminar" Then
            If (MessageBox.Show("Esta seguro de borrar " + "este", " registro",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Dim Nfilas As Integer = DataGridView1.Rows.Count
                Dim Valore(Nfilas, 1) As String
                Dim fila As New DataGridViewRow
                For i = 0 To Nfilas - 1
                    fila = DataGridView1.Rows(i)
                    Valore(i, 0) = fila.Cells("IdDreceta").Value.ToString
                Next
                For i = 0 To Nfilas - 1
                    conexion.mantenimientoDreceta(New String() {Valore(i, 0)}, "eliminar")
                    DatosGrid()
                Next
                conexion.mantenimientoReceta(New String() {Me.Tag}, "eliminar")
                limpiarCampos()
                controlesInicio(True)
            End If
        Else
            controlesInicio(True)
            Button1.Text = "Buscar"
            eliminarBT.Text = "Eliminar"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim detalle As New DetalleReceta
        detalle.factura = TextBox2.Text
        detalle.IdV = Me.Tag
        detalle.ShowDialog()

        DatosGrid()
    End Sub
End Class