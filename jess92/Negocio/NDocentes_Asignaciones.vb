Public Class NDocentes_Asignaciones
    Public Function Insertar(id_asignatura As Int32, id_docente As Int32, año As Int32, grado As String, modalidad As String, turno As String, seccion As String) As String
        Dim Obj As New DDocentesAsignaciones
        With Obj
            .Id_Asignaturas = id_asignatura
            .Id_Docente = id_docente
            .Modalidad = modalidad
            .Grado = grado
            .Año = año
            .Turno = turno
            .Seccion = seccion
        End With
        Return Obj.Insertar(Obj)
    End Function

    Public Function Eliminar(id_asignacion As Int32) As String
        Return New DDocentesAsignaciones().Eliminar(id_asignacion)
    End Function

    Public Function Mostrar(id_docente As Int32, año As Int32) As DataTable
        Dim obj As New DDocentesAsignaciones
        obj.Id_Docente = id_docente
        obj.Año = año
        Return obj.Mostrar(obj)
    End Function

    Public Function Insertar_ASignatura(Nombre As String) As String
        Dim obj As New DDocentesAsignaciones
        obj.Asignatura = Nombre
        Return obj.Insertar_Asignatura(obj)
    End Function

    Public Function Eliminar_Asignatura(Id_Asignatura As Int32) As String
        Return New DDocentesAsignaciones().Eliminar_Asignatura(Id_Asignatura)
    End Function

    Public Function Mostrar_Asignaturas() As DataTable
        Return New DDocentesAsignaciones().Mostrar_Asignatura()
    End Function
End Class
