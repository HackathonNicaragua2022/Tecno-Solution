Public Class NDocentes
    Public Function Insertar(nombres As String, apellidos As String, cedula As String, sexo As String,
                             user As String, pass As String, acceso As String, telefono As String)
        Dim Obj As New DDocentes()
        With Obj
            .Nombres = nombres
            .Apellidos = apellidos
            .Cedula = cedula
            .Sexo = sexo
            .User = user
            .Pass = pass
            .Acceso = acceso
            .Telefono = telefono
        End With
        Return Obj.Insertar(Obj)
    End Function

    Public Function Editar(id_docente As Int32, nombres As String, apellidos As String,
                           cedula As String, sexo As String, user As String, pass As String, acceso As String, telefono As String)
        Dim Obj As New DDocentes()
        With Obj
            .Id_Docente = id_docente
            .Nombres = nombres
            .Apellidos = apellidos
            .Cedula = cedula
            .Sexo = sexo
            .User = user
            .Pass = pass
            .Acceso = acceso
            .Telefono = telefono
        End With
        Return Obj.Editar(Obj)
    End Function

    Public Function Eliminar(id_docente As Int32)
        Return New DDocentes().Eliminar(id_docente)
    End Function

    Public Function Buscar(TextoBuscar As String, av As Int32) As DataTable
        Return New DDocentes().Buscar(TextoBuscar, av)
    End Function

    Public Function Asignar_Grado(iddocente As Int32, grado As String, modalidad As String, año As Int32, turno As String, seccion As String) As String
        Dim Obj As New DDocentes()
        Obj.Id_Docente = iddocente
        Obj.Grado = grado
        Obj.Modalidad = modalidad
        Obj.Año = año
        Obj.Turno = turno
        Obj.Seccion = seccion

        Return Obj.Asignar_Grado(Obj)
    End Function

    Public Function Editar_Asignacion_Grado(idAsignacion As Int32, iddocente As Int32, grado As String, modalidad As String, año As Int32, turno As String, seccion As String) As String
        Dim Obj As New DDocentes()
        Obj.Id_Asignacion = idAsignacion
        Obj.Id_Docente = iddocente
        Obj.Grado = grado
        Obj.Modalidad = modalidad
        Obj.Año = año
        Obj.Turno = turno
        Obj.Seccion = seccion
        Return Obj.Editar_asignacion_Grado(Obj)
    End Function

    Public Function Eliminar_Asignacion_Grado(idAsignacion As Int32) As String
        Return New DDocentes().Eliminar_Asignacion_Grado(idAsignacion)
    End Function

    Public Function Buscar_Asignacion_Grado(iddocente As Int32) As DataTable
        Return New DDocentes().Buscar_Asignacion_de_Grado(iddocente)
    End Function

    Public Function Obtener_Id_Docente(id_Alumno_Mined As String, Año As Int32) As Int32
        Return New DDocentes().Obtener_Id_Docente(id_Alumno_Mined, Año)
    End Function
    Public Function Obtener_Id_Docente(Nombres As String, Apellidos As String) As Int32
        Return New DDocentes().Obtener_Id_Docente(Nombres, Apellidos)
    End Function

    Public Function User_Login(User As String, Pass As String, ip As String, pc As String) As Int32
        Dim Obj As New DDocentes()
        With Obj
            .User = User
            .Pass = Pass
            .Ip = ip
            .Pc = pc
        End With
        Dim rpta As Int32 = Obj.User_Login(Obj)
        Return rpta

        'se retorna le ID de la sesion iniciasa si es igual a cero las credenciales son incorrectas

    End Function

    Public Function User_Login_Datos(Sesion_Id As Int32) As DataTable
        Return New DDocentes().User_Login_Datos(Sesion_Id)
    End Function
End Class
