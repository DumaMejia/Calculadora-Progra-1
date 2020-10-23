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
        parametros()
    End Sub
    Private Sub parametros()
        micomand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        micomand.Parameters.Add("@idEspec", SqlDbType.Int).Value = 0
        micomand.Parameters.Add("@IdDiag", SqlDbType.Int).Value = 0
        micomand.Parameters.Add("@IdEnfer", SqlDbType.Int).Value = 0
        micomand.Parameters.Add("@diag", SqlDbType.Char).Value = ""
        micomand.Parameters.Add("@desc", SqlDbType.Char).Value = ""
        micomand.Parameters.Add("@cargo", SqlDbType.Char).Value = ""
        micomand.Parameters.Add("@espe", SqlDbType.Char).Value = ""
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

        micomand.CommandText = "
            select CargoPersonal.IdCargo, CargoPersonal.IdEspecialista, CargoPersonal.cargoper, especialista.especialidad
            from CargoPersonal 
            inner join especialista on(especialista.IdEspecialista=CargoPersonal.IdEspecialista)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "CargoPersonal")

        micomand.CommandText = "
            select diagnostico.IdDiag, diagnostico.IdEnfermedad, diagnostico.diag, diagnostico.descripcion, enfermedades.nombre
            from diagnostico 
            inner join enfermedades on(enfermedades.IdEnfermedad=diagnostico.IdEnfermedad)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "diagnostico")

        micomand.CommandText = "select * from especialista"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "especialista")
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
    Public Function mantenimientoDatosCargo(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Cargo (cargo) VALUES(@cargo)"
            Case "modificar"
                sql = "UPDATE cargo SET cargo=@cargo WHERE idcargo=@id"
            Case "eliminar"
                sql = "DELETE FROM cargo WHERE idCargo=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@cargo").Value = datos(1)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDiag(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO diagnostico (diag,descripcion) VALUES(@diag,@desc)"
            Case "modificar"
                sql = "UPDATE diagnostico SET IdEnfermedad=@IdEnfer,diag=@diag,descripcion=@desc WHERE IdDiag=@id"
            Case "eliminar"
                sql = "DELETE FROM diagnostico WHERE idDiag=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@idEnfer").Value = datos(1)
            micomand.Parameters("@diag").Value = datos(2)
            micomand.Parameters("@des").Value = datos(3)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
End Class
