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

        micomand.CommandText = "select * from Ecivil"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Ecivil")

        micomand.CommandText = "select * from genero"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "genero")

        micomand.CommandText = "select * from oficio"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "oficio")

        micomand.CommandText = "select * from TipoSangre"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "TipoSangre")


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

        micomand.CommandText = "select * from edades"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "edades")

        micomand.CommandText = "select * from Tfactura"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Tfactura")

        micomand.CommandText = "select * from Pago"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Pago")

        micomand.CommandText = "
            select DatosPersonales.IdDatos, DatosPersonales.IdCivil, DatosPersonales.IdOficio, DatosPersonales.Idsangre, DatosPersonales.Idgenero, DatosPersonales.nacimiento, DatosPersonales.telefono, DatosPersonales.direccion, DatosPersonales.correo, Ecivil.estado, oficio.oficio, TipoSangre.tipo, genero.genero
            from DatosPersonales
            inner join Ecivil on(Ecivil.Idcivil=DatosPersonales.IdCivil)
            inner join oficio on(oficio.IdOficio=DatosPersonales.IdOficio)
            inner join TipoSangre on(TipoSangre.Idsangre=DatosPersonales.Idsangre)
            inner join genero on(genero.Idgenero=DatosPersonales.Idgenero)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "DatosPersonales")

        micomand.CommandText = "
            select expediente.IdExpediente, expediente.nombre, expediente.apellido, expediente.Idedad, expediente.peso, expediente.Idalergia, expediente.IdDatos, expediente.Idfamiliar, expediente.fechaRe, edades.edad, alergia.nombre, DatosPersonales.nacimiento, Dfamilia.nombre
            from expediente
            inner join edades on(edades.Idedad=expediente.Idedad)
            inner join alergia on(alergia.Idalergia=expediente.Idalergia)
            inner join DatosPersonales on(DatosPersonales.IdDatos=expediente.IdDatos)
            inner join Dfamilia on(Dfamilia.Idfamiliar=expediente.Idfamiliar)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "expediente")

        micomand.CommandText = "
            select personal.IdPersonal, personal.nombre, personal.apellido, personal.direccion, personal.correo, personal.telefono, personal.IdCargo, personal.IdEspecialista, CargoPersonal.cargoper, especialista.especialidad
            from personal
            inner join CargoPersonal on(CargoPersonal.IdCargo=personal.IdCargo)
            inner join especialista on(especialista.IdEspecialista=personal.IdEspecialista)

        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "personal")

        micomand.CommandText = "
            select Dfamilia.Idfamiliar, Dfamilia.nombre, Dfamilia.apellido, Dfamilia.Idedad, Dfamilia.parentesco, Dfamilia.Idgenero, Dfamilia.Idsangre, edades.edad, genero.genero, TipoSangre.tipo
            from Dfamilia
            inner join edades on(edades.Idedad=Dfamilia.Idedad)
            inner join genero on(genero.Idgenero=Dfamilia.Idgenero)
            inner join TipoSangre on(TipoSangre.Idsangre=Dfamilia.Idsangre)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Dfamilia")

        micomand.CommandText = "
            select Ventas.IdVentas, Ventas.IdPersonal, Ventas.IdTfactura, Ventas.IdPago, Ventas.cliente, Ventas.Nfactura, Ventas.fecha, personal.nombre, Tfactura.tipo, pago.forma
            from Ventas
            inner join Personal on(Personal.IdPersonal=Ventas.IdPersonal)
            inner join Tfactura on(Tfactura.IdTfactura=Ventas.IdTfactura)
            inner join Pago on(Pago.IdPago=Ventas.IdPago)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Ventas")

        micomand.CommandText = "
            select Dventa.IdDventa, Dventa.IdVentas, Dventa.Id, Dventa.cantidad, Dventa.precio, Ventas.Nfactura, medicina.nombre
            from Dventa
            inner join Ventas on(Ventas.IdVentas=Dventa.IdVentas)
            inner join medicina on(medicina.Id=Dventa.Id)
        "
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "Dventa")

        micomand.CommandText = "select * from CargoPersonal"
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
            select usuario.Idusuario, usuario.Idusertype, usuario.username, usuario.contra, usuario.IdPersonal, tipoUsuario.tipo, personal.nombre
            from usuario
            inner join tipoUsuario on(tipoUsuario.Idusertype=usuario.Idusertype)
            inner join personal on(personal.IdPersonal=usuario.IdPersonal)
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
            select horario.Idhorario, horario.IdCargo, horario.horario, CargoPersonal.cargoper
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
                sql = "INSERT INTO CargoPersonal (cargoper) VALUES('" + datos(1) + "')"
            Case "modificar"
                sql = "UPDATE CargoPersonal SET cargoper='" + datos(1) + "' WHERE IdCargo='" + datos(0) + "'"
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
                sql = "INSERT INTO usuario (Idusertype,username,contra,IdPersonal) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE usuario SET Idusertype='" + datos(1) + "',username='" + datos(2) + "',contra='" + datos(3) + "',IdPersonal='" + datos(4) + "' WHERE Idusuario='" + datos(0) + "'"
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
                sql = "DELETE FROM horario WHERE Idhorario='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosPersonales(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO DatosPersonales (IdCivil,IdOficio,Idsangre,Idgenero,IdEnfermedad,nacimiento,telefono,direccion,correo) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "','" + datos(8) + "','" + datos(9) + "')"
            Case "modificar"
                sql = "UPDATE DatosPersonales SET IdCivil='" + datos(1) + "',IdOficio='" + datos(2) + "',Idsangre='" + datos(3) + "',Idgenero='" + datos(4) + "',IdEnfermedad='" + datos(5) + "',nacimiento='" + datos(6) + "',telefono='" + datos(7) + "',direccion='" + datos(8) + "',correo='" + datos(9) + "' WHERE IdDatos='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM DatosPersonales WHERE IdDatos='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosFamiliar(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO Dfamilia (nombre,apellido,Idedad,parentesco,Idgenero,Idsangre) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE Dfamilia SET nombre='" + datos(1) + "',apellido='" + datos(2) + "',Idedad='" + datos(3) + "',parentesco='" + datos(4) + "',Idgenero='" + datos(5) + "',Idsangre='" + datos(6) + "' WHERE Idfamiliar='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Dfamilia WHERE Idfamiliar='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoPersonal(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO personal (nombre,apellido,direccion,correo,telefono,IdCargo,IdEspecialista) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "')"
            Case "modificar"
                sql = "UPDATE personal SET nombre='" + datos(1) + "',apellido='" + datos(2) + "',direccion='" + datos(3) + "',correo='" + datos(4) + "',telefono='" + datos(5) + "',IdCargo='" + datos(6) + "',IdEspecialista='" + datos(7) + "' WHERE IdDfamiliar='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM personal WHERE IdPersonal='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoExpediente(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO expediente (nombre,apellido,Idedad,peso,Idalergia,IdDatos,Idfamiliar,fechaRe) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "','" + datos(8) + "')"
            Case "modificar"
                sql = "UPDATE expediente SET nombre='" + datos(1) + "',apellido='" + datos(2) + "',Idedad='" + datos(3) + "',peso='" + datos(4) + "',Idalergia='" + datos(5) + "',IdDatos='" + datos(6) + "',Idfamiliar='" + datos(7) + "',fechaRe='" + datos(8) + "' WHERE IdExpediente='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM expediente WHERE IdExpediente='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoVenta(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO Ventas (IdPersonal,IdTfactura,IdPago,Cliente,Nfactura,fecha) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE Ventas SET IdPersonal='" + datos(1) + "',IdTfactura='" + datos(2) + "',IdPago='" + datos(3) + "',Cliente='" + datos(4) + "',Nfactura='" + datos(5) + "',fecha='" + datos(6) + "' WHERE IdVentas='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Ventas WHERE IdVentas='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDVenta(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO Dventa (IdVentas,Id,cantidad,Precio) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE Dventa SET IdVentas='" + datos(1) + "',Id='" + datos(2) + "',cantidad='" + datos(3) + "',Precio='" + datos(4) + "' WHERE IdDventa='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Dventa WHERE IdDventa='" + datos(0) + "'"
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
