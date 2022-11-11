Public Class NMatricula
    Public Function Insertar(Id_Alumno As Int32, Grado As String, Modalidad As String,
                             fecha As Date, Año As Int32) As String
        Dim Obj As New DMatricula()
        Obj.Id_Alumnos = Id_Alumno
        Obj.Grado = Grado
        Obj.Modalidad = Modalidad
        Obj.Fecha = fecha
        Obj.Año = Año

        Return Obj.Insertar_Matricula(Obj)
    End Function

    Public Function Insertar_Id_Mined(IdMinied As String, Grado As String, Modalidad As String,
                             fecha As Date, Año As Int32, turno As String, seccion As String) As String
        Dim Obj As New DMatricula()
        Obj.Id_Mined = IdMinied
        Obj.Grado = Grado
        Obj.Modalidad = Modalidad
        Obj.Fecha = fecha
        Obj.Año = Año
        Obj.Turno = turno
        Obj.Seccion = seccion

        Return Obj.Insertar_Matricula_id_Mined(Obj)
    End Function

    Public Function Editar(idmatricula As Int32, Id_Alumno As Int32, Grado As String, Modalidad As String, turno As String, seccion As String) As String
        Dim Obj As New DMatricula()
        Obj.Id_Alumnos = Id_Alumno
        Obj.Grado = Grado
        Obj.Modalidad = Modalidad
        Obj.Id_Matricula = idmatricula
        Obj.Turno = turno
        Obj.Seccion = seccion

        Return Obj.Editar_Matricula(Obj)
    End Function

    Public Function Eliminar(Id_Matricula As Int32) As String
        Return New DMatricula().Eliminar_Matricula(Id_Matricula)
    End Function

    Public Function Suspender(Id_Matricula As Int32, id_alumno As Int32, Año As Int32) As String
        Return New DMatricula().Suspender_Matricula(Id_Matricula, id_alumno, Año)
    End Function

    Public Function Restaurar(Id_Matricula As Int32, id_alumno As Int32, Año As Int32) As String
        Return New DMatricula().Restaurar_Matricula(Id_Matricula, id_alumno, Año)
    End Function
    Public Function Buscar_Modalidad_Año(Año As Int32) As DataTable
        Return New DMatricula().Buscar_Modalidad_Año(Año)
    End Function
    Public Function Buscar_Turno_Año(Modalidad As String, Año As Int32) As DataTable
        Return New DMatricula().Buscar_Turno_Año(Modalidad, Año)
    End Function
    Public Function Buscar_Grado_Modalidad_Año(Año As Int32, Modalidad As String) As DataTable
        Return New DMatricula().Buscar_Grado_Modalidad_Año(Año, Modalidad)
    End Function
    Public Function Buscar_Grado_Modalidad_Año_Turno(Año As Int32, Modalidad As String, Turno As String) As DataTable
        Return New DMatricula().Buscar_Grado_Modalidad_Año_Turno(Año, Modalidad, Turno)
    End Function

    Public Function Buscar_Seccion_Grado_Modalidad_Año_Turno(Año As Int32, Modalidad As String, Turno As String, Grado As String) As DataTable
        Return New DMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(Año, Modalidad, Turno, Grado)
    End Function
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String) As DataTable
        Return New DMatricula().Buscar_Listado_Estudiantes(Año, Modalidad, Turno)
    End Function
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String, Grado As String) As DataTable
        Return New DMatricula().Buscar_Listado_Estudiantes(Año, Modalidad, Turno, Grado)
    End Function
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DMatricula().Buscar_Listado_Estudiantes(Año, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String) As DataTable
        Return New DMatricula().Buscar_Listado_Estudiantes(Año, Modalidad)
    End Function
    Public Function Buscar_Listado_Estudiantes(Año As Int32) As DataTable
        Return New DMatricula().Buscar_Listado_Estudiantes(Año)
    End Function
    Public Function Get_Id_Matricula(IdAlumno As Int32, Año As Int32) As Int32
        Return New DMatricula().Get_IdMatricula(IdAlumno, Año)
    End Function
End Class
