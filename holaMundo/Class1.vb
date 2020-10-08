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
    Private Function executeSql(ByVal sql As String)
        micomand.Connection = miconexion
        micomand.CommandText = sql
        Return micomand.ExecuteNonQuery()
    End Function


End Class
