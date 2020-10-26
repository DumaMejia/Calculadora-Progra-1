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

        micomand.CommandText = "select * from alergia"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "alergia")

        micomand.CommandText = "select * from enfermedades"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "enfermedades")

        micomand.CommandText = "select * from proveedor"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "proveedor")

        micomand.CommandText = "select * from traslado"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "traslado")

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

        micomand.CommandText = "
            select usuario.Idusuario, usuario.Idusertype, usuario.username, usuario.contra, tipoUsuario.tipo
            from usuario
            inner join tipoUsuario on(tipoUsuario.Idusertype=usuario.Idusertype)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "usuario")

        micomand.CommandText = "
            select receta.Idreceta, receta.id, receta.descripcion, medicina.nombre 
            from receta
            inner join medicina on(medicina.Id=receta.id)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "receta")

        micomand.CommandText = "
            select horario.Idhorario, horario.IdCargo, horario.horario, CargoPersonal.cargoper, CargoPersonal.IdEspecialista
            from horario
            inner join CargoPersonal on(CargoPersonal.IdCargo=horario.IdCargo)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "horario")

        micomand.CommandText = "select * from tipoUsuario"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "tipoUsuario")

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
    Public Function mantenimientoTraslado(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO traslado (lugar,motivo,fecha) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE traslado SET lugar='" + datos(1) + "',motivo='" + datos(2) + "',fecha='" + datos(3) + "' WHERE Idtraslado='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM traslado WHERE Idtraslado='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoAlergia(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO alergia (nombre,descripcion,tratamiento) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE alergia SET nombre='" + datos(1) + "',descripcion='" + datos(2) + "',tratamiento='" + datos(3) + "' WHERE Idalergia='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM alergia WHERE Idalergia='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosCargo(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO CargoPersonal (IdEspecialista,cargoper) VALUES('" + datos(1) + "','" + datos(2) + "')"
            Case "modificar"
                sql = "UPDATE CargoPersonal SET IdEspecialista='" + datos(1) + "',cargoper='" + datos(2) + "' WHERE IdCargo='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM CargoPersonal WHERE IdCargo='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDiag(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO diagnostico (IdEnfermedad,diag,descripcion) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE diagnostico SET Idenfermedad='" + datos(1) + "',diag='" + datos(2) + "',descripcion='" + datos(3) + "' WHERE IdDiag='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM diagnostico WHERE IdDiag='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoUsuario(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO usuario (Idusertype,username,contra) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE usuario SET Idusertype='" + datos(1) + "',username='" + datos(2) + "',contra='" + datos(3) + "' WHERE Idusuario='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM usuario WHERE Idusuario='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoReceta(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO receta (Id,descripcion) VALUES('" + datos(1) + "','" + datos(2) + "')"
            Case "modificar"
                sql = "UPDATE receta SET Id='" + datos(1) + "',descripcion='" + datos(2) + "' WHERE Idreceta='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM receta WHERE Idreceta='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoHorario(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO horario (IdCargo,horario) VALUES('" + datos(1) + "','" + datos(2) + "')"
            Case "modificar"
                sql = "UPDATE horario SET IdCargo='" + datos(1) + "',horario='" + datos(2) + "' WHERE Idhorario='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM receta WHERE Idhorario='" + datos(0) + "'"
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
