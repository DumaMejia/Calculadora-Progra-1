﻿Public Class alergia
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Public idc As Integer
    Dim cambio As String = "nuevo"
    Private Sub alergia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        controlesInicio(True)
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdatos().Tables("alergia")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("Idalergia")}
    End Sub
    Sub mostrardatos()
        Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString()

        TextBox1.Text = datatable.Rows(posicion).ItemArray(1).ToString()
        TextBox2.Text = datatable.Rows(posicion).ItemArray(2).ToString()
        TextBox4.Text = datatable.Rows(posicion).ItemArray(3).ToString()

    End Sub
    Private Sub SeleccionarDato()
        idc = DataGridView1.CurrentRow.Cells("Idalergia").Value.ToString()
    End Sub
    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        filtrar(TextBox3.Text)
        If e.KeyCode = 13 Then
            SeleccionarDato()
        End If
    End Sub
    Private Sub filtrar(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "nombre like '%" & valor & "%' or nombre like '%" & valor & "%'"
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
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Buscar" Then
            Button1.Text = "Seleccionar"
            eliminarBT.Text = "Cancelar"
            DataGridView1.DataSource = conexion.obtenerdatos().Tables("alergia").DefaultView
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
            nuevoBT.Text = "Guardar"
            modificarBT.Text = "Cancelar"
            cambio = "nuevo"

            controlesNuevo(True)
            limpiarCampos()
        Else 'Guardar
            Dim msg = conexion.mantenimientoAlergia(New String() {
                Me.Tag, TextBox1.Text, TextBox2.Text, TextBox4.Text
               }, cambio)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                controlesInicio(True)
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
            If (MessageBox.Show("Esta seguro de borrar " + "este registro", "de la base de datos",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                conexion.mantenimientoAlergia(New String() {Me.Tag}, "eliminar")
                limpiarCampos()
            End If
        Else
            controlesInicio(True)
            Button1.Text = "Buscar"
            eliminarBT.Text = "Eliminar"
        End If
    End Sub
End Class