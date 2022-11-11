Public Class NNotas
    Public Function MostrarAlumnosparaInsertar(alumno As String, modalidad As String, grado As String, año As Int32, idcorte As Int32, turno As String, seccion As String)
        Dim Obj As New DNotas
        Obj.Nombres = alumno
        Obj.Modalidad = modalidad
        Obj.Grado = grado
        Obj.Año = año
        Obj.Id_Corte = idcorte
        Obj.Turno = turno
        Obj.Seccion = seccion
        Return Obj.MostrarAlumnos_paraInsertar(Obj)
    End Function
    Public Function Mostrar_Notas(idalumno As Int32, idcorte As Int32, año As Int32) As DataTable
        Dim Obj As New DNotas
        Obj.Id_Alumno = idalumno
        Obj.Id_Corte = idcorte
        Obj.Año = año
        Return Obj.Mostrar_Notas(Obj)
    End Function
    Public Function Mostrar_Asignaturas_Por_Docente(idalumno As Int32, idcorte As Int32, año As Int32, id_Docente As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Dim Obj As New DNotas
        Obj.Id_Alumno = idalumno
        Obj.Id_Corte = idcorte
        Obj.Año = año
        Obj.Id_Docente = id_Docente
        Obj.Modalidad = Modalidad
        Obj.Turno = Turno
        Obj.Seccion = Seccion
        Obj.Grado = Grado
        Return Obj.Mostrar_Asignaturas_Por_Docente(Obj)
    End Function

    Public Function Mostrar_Asignaturas_Eliminadas(TextoBuscar As String) As DataTable
        Return New DNotas().Mostrar_Asignaturas_Eliminadas(TextoBuscar)
    End Function

    Public Function Mostrar_Intentos_de_Eliminacion(TextoBuscar As String) As DataTable
        Return New DNotas().Mostrar_Intentos_de_Eliminacion(TextoBuscar)
    End Function

    Public Function Mostrar_Asignaturas(idalumno As Int32, idcorte As Int32, modalidad As String, grado As String, año As Int32) As DataTable
        Dim Obj As New DNotas
        Obj.Id_Alumno = idalumno
        Obj.Id_Corte = idcorte

        Obj.Modalidad = modalidad
        Obj.Grado = grado
        Obj.Año = año
        Return Obj.Mostrar_Asignaturas(Obj)
    End Function

    Public Function Insertar_Nota(idalumno As Int32, idcorte As Int32, idasignatura As Int32, iddocente As Int32, nivel As String, año As Int32, nota As Int32, Corte As String) As String
        Dim Obj As New DNotas
        Obj.Id_Alumno = idalumno
        Obj.Id_Docente = iddocente
        Obj.Id_Asignatura = idasignatura
        Obj.Id_Corte = idcorte
        Obj.Nivel = nivel
        Obj.Año = año
        Obj.Nota = nota
        Obj.Corte = Corte.Trim
        Return Obj.Insertar_Nota(Obj)
    End Function

    Public Function Insertar_Nota_Por_Lote(CodigoAlumno As String, corte As String, asignatura As String, iddocente As Int32, nivel As String, año As Int32, nota As Int32) As String
        Dim Obj As New DNotas
        Obj.Id_Mined = CodigoAlumno
        Obj.Id_Docente = iddocente
        Obj.Asignatura = asignatura
        Obj.Corte = corte
        Obj.Nivel = nivel
        Obj.Año = año
        Obj.Nota = nota
        Return Obj.Insertar_Nota_Por_Lote(Obj)
    End Function
    Public Function Insertar_Nota_Lote(idalumno As Int32, idcorte As Int32, asignatura As String, iddocente As Int32, nivel As String, año As Int32, nota As Int32) As String
        Dim Obj As New DNotas
        Obj.Id_Alumno = idalumno
        Obj.Id_Docente = iddocente
        Obj.Asignatura = asignatura
        Obj.Id_Corte = idcorte
        Obj.Nivel = nivel
        Obj.Año = año
        Obj.Nota = nota
        Return Obj.Insertar_Nota_Lote(Obj)
    End Function

    Public Function Eliminar_Nota(idnota As Int32, Corte As String, idalumno As Int32, año As Int32, idasignatura As Int32) As String
        Dim Obj As New DNotas
        Obj.Id_Nota = idnota
        Obj.Corte = Corte
        Obj.Id_Alumno = idalumno
        Obj.Id_Asignatura = idasignatura
        Obj.Año = año
        Return Obj.Eliminar_Nota(Obj)
    End Function

    Public Function AsignarAsignaturas_A_Grado_Modalidad(idAsignatura As Int32, modalidad As String, grado As String) As String
        Dim Obj As New DNotas
        Obj.Id_Asignatura = idAsignatura
        Obj.Modalidad = modalidad
        Obj.Grado = grado
        Return Obj.Asignar_Asignatura_y_Modalidad_A_Grado(Obj)
    End Function

    Public Function Mostrar_AsignarAsignaturas_Por_Grado_Modalidad(modalidad As String, Grado As String) As DataTable
        Dim Obj As New DNotas
        Return Obj.Mostrar_Asignatura_y_Modalidad_Por_Grado(modalidad, Grado)
    End Function

    Public Function Asignaturas_Por_Grado_Modalidad_Eliminar(id_Asignacion As Int32) As String

        Return New DNotas().AsignaturasPorGrado_Eliminar(id_Asignacion)
    End Function

    Public Function Mostrar_Semestre_Primero_Segundo(grado As String, año As Int32, semestre As String) As DataTable
        Return New DNotas().Mostrar_Semestre_Primero_Segundo(grado, año, semestre)
    End Function
    Public Function Mostrar_Final_Primero_Segundo(grado As String, año As Int32) As DataTable
        Return New DNotas().Mostrar_Final_Primero_Segundo(grado, año)
    End Function
    Public Function Mostrar_Semestre_Tercero_Sexto(grado As String, año As Int32, semestre As String) As DataTable
        Return New DNotas().Mostrar_Semestre_Tercero_Sexto(grado, año, semestre)
    End Function
    Public Function Mostrar_Final_Tercero_Sexto(grado As String, año As Int32) As DataTable
        Return New DNotas().Mostrar_Final_Tercero_Sexto(grado, año)
    End Function
    Public Function Mostrar_Semestre_Secundaria(grado As String, año As Int32, semestre As String) As DataTable
        Return New DNotas().Mostrar_Semestre_Secundaria(grado, año, semestre)
    End Function
    Public Function Mostrar_Final_Secundaria(grado As String, año As Int32) As DataTable
        Return New DNotas().Mostrar_Final_Secundaria(grado, año)
    End Function

    Public Function Obtener_Id_Asignatuta(Asignatura As String) As Int32
        Return New DNotas().Obtener_Id_Asignatuta(Asignatura)
    End Function

    Public Function Obtener_Id_Alumno(Id_Mined As String) As Int32
        Return New DNotas().Obtener_Id_Alumno(Id_Mined)
    End Function

    Public Function Autorizacion_De_Eliminacon(Pass As String) As String
        Return New DNotas().Autorizacion_De_Eliminacon(Pass)
    End Function

    Public Function Autorizacion_Eliminacion_Insertar(Autorizador As Int32, Id_Docente As Int32, Id_Alumno As Int32, Id_Corte As Int32,
                                           Anio As Int32, Id_Asignatura As Int32, Nota As Int32) As String


        Return New DNotas().Autorizacion_Eliminacion_Insertar(Autorizador, Id_Docente, Id_Alumno, Id_Corte,
                                           Anio, Id_Asignatura, Nota)
    End Function


    Public Function Intentos_de_Eliminacion_Insertar(Id_Login As Int32, Autorizador As Int32, Id_Docente As Int32, Id_Alumno As Int32, Id_Corte As Int32,
                                           Anio As Int32, Id_Asignatura As Int32, Nota As Int32, Descripcion As String) As String


        Return New DNotas().Intentos_de_Eliminacion_Insertar(Id_Login, Autorizador, Id_Docente, Id_Alumno, Id_Corte,
                                           Anio, Id_Asignatura, Nota, Descripcion)
    End Function
End Class
