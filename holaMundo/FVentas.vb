Public Class FVentas
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Public idD As Integer
    Dim cambio As String = "nuevo"
    Private Sub FVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
        posicion = 0
        controlesInicio(True)
        totalizar()
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("Ventas")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("IdVentas")}

        ComboBox1.DataSource = conexion.obtenerdatos().Tables("personal").DefaultView()
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "personal.IdPersonal"

        ComboBox2.DataSource = conexion.obtenerdatos().Tables("Tfactura").DefaultView()
        ComboBox2.DisplayMember = "tipo"
        ComboBox2.ValueMember = "Tfactura.IdTfactura"

        ComboBox3.DataSource = conexion.obtenerdatos().Tables("Pago").DefaultView()
        ComboBox3.DisplayMember = "forma"
        ComboBox3.ValueMember = "Pago.IdPago"
    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString()

        ComboBox1.SelectedValue = datatable.Rows(posicion).ItemArray(1).ToString()
        ComboBox2.SelectedValue = datatable.Rows(posicion).ItemArray(2).ToString()
        ComboBox3.SelectedValue = datatable.Rows(posicion).ItemArray(3).ToString()

        TextBox1.Text = datatable.Rows(posicion).ItemArray(4).ToString()
        TextBox2.Text = datatable.Rows(posicion).ItemArray(5).ToString()
        TextBox3.Text = datatable.Rows(posicion).ItemArray(6).ToString()
    End Sub
    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DataGridView1.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DataGridView1.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(ComboBox2.SelectedValue = 3, sumas * 0.13, 0)
            total = sumas + iva

            LSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            LIva.Text = "$ " + Math.Round(iva, 2).ToString()
            LTotal.Text = "$ " + Math.Round(total, 2).ToString()

        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub
    Private Sub DatosGrid()
        DataGridView1.DataSource = conexion.obtenerdatos().Tables("DVenta").DefaultView
        filtrar(TextBox2.Text.Trim)
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
        Button3.Enabled = Not estado
    End Sub
    Private Sub controlesBuscar(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        PanelBD.Enabled = estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = estado
        nuevoBT.Enabled = estado
        Button2.Enabled = estado
        Button3.Enabled = estado
    End Sub
    Private Sub controlesOpen(ByVal estado As Boolean)
        PanelDatos.Enabled = Not estado
        PanelBD.Enabled = Not estado
        eliminarBT.Enabled = estado
        Button1.Enabled = estado
        modificarBT.Enabled = estado
        nuevoBT.Enabled = estado
        Button2.Enabled = estado
        Button3.Enabled = estado
    End Sub
    Private Sub limpiarCampos()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        LSuma.Text = "00.00"
        LIva.Text = "00.00"
        LTotal.Text = "00.00"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Buscar As New BuscarVenta
        limpiarCampos()
        obtenerdatos()
        Buscar.ShowDialog()

        If Buscar.idc > 0 Then
            controlesBuscar(True)
            posicion = datatable.Rows.IndexOf(datatable.Rows.Find(Buscar.idc))
        End If
        controlesOpen(True)
        mostrardatos()
        DatosGrid()
        mostrardatos()
        totalizar()
    End Sub
    Private Sub nuevoBT_Click(sender As Object, e As EventArgs) Handles nuevoBT.Click
        If nuevoBT.Text = "Nuevo" Then 'Nuevo
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"

            controlesNuevo(True)
            limpiarCampos()
        Else
            Dim msg = conexion.mantenimientoVenta(New String() {
                Me.Tag, ComboBox1.SelectedValue, ComboBox2.SelectedValue, ComboBox3.SelectedValue, TextBox1.Text, TextBox2.Text, TextBox3.Text
               }, cambio)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If cambio = "nuevo" Then
                    obtenerdatos()
                    posicion = datatable.Rows.Count - 1
                    mostrardatos()
                    controlesOpen(True)
                End If
                obtenerdatos()
                mostrardatos()
                totalizar()
                controlesOpen(True)
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
            Button2.Enabled = True
            mostrardatos()
        Else 'Cancelar
            mostrardatos()
            controlesOpen(True)
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
                    Valore(i, 0) = fila.Cells("IdDVenta").Value.ToString
                Next
                For i = 0 To Nfilas - 1
                    conexion.mantenimientoDVenta(New String() {Valore(i, 0)}, "eliminar")
                    DatosGrid()
                Next
                conexion.mantenimientoVenta(New String() {Me.Tag}, "eliminar")
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
        mostrardatos()
        Dim detalle As New DetalleVenta
        detalle.factura = TextBox2.Text
        detalle.IdV = Me.Tag
        detalle.ShowDialog()

        mostrardatos()
        DatosGrid()
        mostrardatos()
        totalizar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Imprimir As New FRventa
        Imprimir._idVta = Me.Tag
        Imprimir.ShowDialog()
        mostrardatos()
    End Sub
End Class