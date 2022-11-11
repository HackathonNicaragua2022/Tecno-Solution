Public Class NM_Inicial
    Public Function Insertar(Año As Int32, Modalidad As String, Turno As String, Grado As String,
                             Seccion As String, Abs As Int32, F As Int32) As String
        Dim obj As New DM_Inicial
        obj.Año = Año
        obj.Modalidad = Modalidad
        obj.Turno = Turno
        obj.Grado = Grado
        obj.Seccion = Seccion
        obj.AbS = Abs
        obj.F = F
        Return obj.Insertar(obj)
    End Function

    Public Function Editar(Id As Int32, Año As Int32, Modalidad As String, Turno As String, Grado As String,
                           Seccion As String, Abs As Int32, F As Int32) As String
        Dim obj As New DM_Inicial
        obj.Id_m_Inicial = Id
        obj.Año = Año
        obj.Modalidad = Modalidad
        obj.Turno = Turno
        obj.Grado = Grado
        obj.Seccion = Seccion
        obj.AbS = Abs
        obj.F = F
        Return obj.Editar(obj)
    End Function
    Public Function Eliminar(Id As Int32) As String
        Return New DM_Inicial().Eliminar(Id)
    End Function
    Public Function Buscar(TextoBuscar As String) As DataTable
        Return New DM_Inicial().Buscar(TextoBuscar)
    End Function
End Class
