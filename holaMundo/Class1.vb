Imports System.Data
Imports System.Data.SqlClient
Public Class db_conexion
    Dim miconexion As New SqlConnection
    Dim micomand As New SqlCommand
    Dim miadapter As New SqlDataAdapter
    Dim ds As New DataSet

    Public Sub New()
        Dim c_conexion As String
        c_conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBClinica.mdf;Integrated Security=True"
        miconexion.ConnectionString = c_conexion

        miconexion.Open()
    End Sub

    Public Function obtenerdatos()
        ds.Clear()
        micomand.Connection = miconexion

        micomand.CommandText = "select * from medicina"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "medicina")

        micomand.CommandText = "select * from enfermedades"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "enfermedades")

        micomand.CommandText = "select * from proveedor"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "proveedor")
        Return ds
    End Function
    Public Function mantenimientoMedicina(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO medicina (nombre,cantidad,caducidad,descripcion) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE medicina SET nombre='" + datos(1) + "',cantidad='" + datos(2) + "',caducidad='" + datos(3) + "',descripcion='" + datos(4) + "' WHERE id='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM medicina WHERE id='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoProveedor(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO proveedor (nombre,propietario,direccion,telefono,correo) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE proveedor SET nombre='" + datos(1) + "',propietario='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "',correo='" + datos(5) + "' WHERE idproveedor='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM proveedor WHERE idproveedor='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoEnfermedades(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO enfermedades (nombre,descripcion) VALUES('" + datos(1) + "','" + datos(2) + "')"
            Case "modificar"
                sql = "UPDATE enfermedades SET nombre='" + datos(1) + "',descripcion='" + datos(2) + "' WHERE idEnfermedad='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM enfermedades WHERE idEnfermedad='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        micomand.Connection = miconexion
        micomand.CommandText = sql
        Return micomand.ExecuteNonQuery()
    End Function
End Class
