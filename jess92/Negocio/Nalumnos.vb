Public Class Nalumnos
    Public Function Insertar(idmined As String, nombres As String,
                             apellidos As String, sexo As String,
                             nacimiento As Date) As String
        Dim obj As New DAlumnos()
        obj.Id_Mined = idmined
        obj.Nombres = nombres
        obj.Apellidos = apellidos
        obj.Sexo = sexo
        obj.Nacimiento = nacimiento

        Return obj.Insertar(obj)
    End Function

    Public Function Editar(idalumno As Int32, idmined As String,
                            nombres As String, apellidos As String,
                            sexo As String, nacimiento As Date) As String
        Dim obj As New DAlumnos()
        obj.Id_Alumnos = idalumno
        obj.Id_Mined = idmined
        obj.Nombres = nombres
        obj.Apellidos = apellidos
        obj.Sexo = sexo
        obj.Nacimiento = nacimiento

        Return obj.Editar(obj)
    End Function

    Public Function Eliminar(idalumno As Int32) As String
        Dim obj As New DAlumnos()
        obj.Id_Alumnos = idalumno

        Return obj.Eliminar(obj)
    End Function

    Public Function Buscar(Nombres As String) As DataTable
        Return New DAlumnos().Buscar(Nombres)
    End Function

    Public Function Mostrar_Notas(Id_Alumno As Int32, año As Int32) As DataTable
        Return New DAlumnos().Mostrar_Notas(Id_Alumno, año)
    End Function

    Public Function Buscar_Apellido(Nombres As String, Apellidos As String) As DataTable
        Return New DAlumnos().Buscar_Apellido(Nombres, Apellidos)
    End Function

    Public Function Buscar_Matricula(Id_Alumno As Int32) As DataTable
        Return New DAlumnos().Buscar_Matricula(Id_Alumno)
    End Function
    Public Function Buscar_Matricula_Año(Año As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Buscar_Matricula_Año(Año, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Excelencia_Academica(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Excelencia_Academica(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Alumnos_Destacados(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Alumnos_Destacados(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Alumnos_en_Af(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Alumnos_en_Af(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Alumnos_en_Ai(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Alumnos_en_Ai(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Alumnos_Reprobados(Año As Int32, Corte As Int32) As DataTable
        Return New DAlumnos().Alumnos_Reprobados(Año, Corte)
    End Function
    Public Function Alumnos_Reprobados_Detallados(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Alumnos_Reprobados_Detallados(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function

    Public Function Estudiantes_Retirados(Año As Int32, Corte As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Return New DAlumnos().Estudiantes_Retirados(Año, Corte, Modalidad, Turno, Grado, Seccion)
    End Function
    Public Function Matricula(Año As Int32) As DataTable
        Return New DAlumnos().Matricula(Año)
    End Function

End Class
