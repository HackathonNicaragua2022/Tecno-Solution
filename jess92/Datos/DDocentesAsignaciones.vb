Imports System.Data, System.Data.SqlClient
Public Class DDocentesAsignaciones
    Private _Id_Asignaciones As Int32
    Private _Id_Asignaturas As Int32
    Private _Id_Docente As Int32
    Private _Año As Int32
    Private _Grado As String
    Private _Modalidad As String
    Private _Asignatura As String
    Private _Turno As String
    Private _Seccion As String

    Public Property Seccion
        Set(value)
            _Seccion = value
        End Set
        Get
            Return _Seccion
        End Get
    End Property

    Public Property Turno
        Set(value)
            _Turno = value
        End Set
        Get
            Return _Turno
        End Get
    End Property
    Public Property Id_Asignaciones
        Set(value)
            _Id_Asignaciones = value
        End Set
        Get
            Return _Id_Asignaciones
        End Get
    End Property
    Public Property Id_Asignaturas
        Set(value)
            _Id_Asignaturas = value
        End Set
        Get
            Return _Id_Asignaturas
        End Get
    End Property
    Public Property Id_Docente
        Set(value)
            _Id_Docente = value
        End Set
        Get
            Return _Id_Docente
        End Get
    End Property
    Public Property Año
        Set(value)
            _Año = value
        End Set
        Get
            Return _Año
        End Get
    End Property
    Public Property Grado
        Set(value)
            _Grado = value
        End Set
        Get
            Return _Grado
        End Get
    End Property
    Public Property Modalidad
        Set(value)
            _Modalidad = value
        End Set
        Get
            Return _Modalidad
        End Get
    End Property

    Public Property Asignatura
        Set(value)
            _Asignatura = value
        End Set
        Get
            Return _Asignatura
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(idasignacion As Int32, idasignatura As Int32, iddocente As Int32, vaño As Int32, vgrado As String, vmodalidad As String,
                   vasignatura As String, turno As String, seccion As String)
        Me.Id_Asignaciones = idasignacion
        Me.Id_Asignaturas = idasignatura
        Me.Id_Docente = iddocente
        Me.Año = vaño
        Me.Grado = vgrado
        Me.Modalidad = vmodalidad
        Me.Asignatura = vasignatura
        Me.Turno = turno
        Me.Seccion = seccion
    End Sub

    Public Function Insertar(Datos As DDocentesAsignaciones) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaciones_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Asignatura As New SqlParameter()
            Par_Id_Asignatura.ParameterName = "@IdAsignatura"
            Par_Id_Asignatura.SqlDbType = SqlDbType.Int
            Par_Id_Asignatura.Value = Datos.Id_Asignaturas
            SqlCmd.Parameters.Add(Par_Id_Asignatura)

            Dim Par_Id_Docente As New SqlParameter()
            Par_Id_Docente.ParameterName = "@IdDocente"
            Par_Id_Docente.SqlDbType = SqlDbType.Int
            Par_Id_Docente.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(Par_Id_Docente)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NVarChar
            Par_Modalidad.Size = 100
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NVarChar
            Par_Grado.Size = 60
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)

            'Dim Par_Turno As New SqlParameter()
            'Par_Turno.ParameterName = "@Turno"
            'Par_Turno.SqlDbType = SqlDbType.NVarChar
            'Par_Turno.Size = 30
            'Par_Turno.Value = Datos.Turno
            'SqlCmd.Parameters.Add(Par_Turno)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Insertar_Asignatura(Datos As DDocentesAsignaciones) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaturas_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '"""""""""""""""""""""""""""""""""""""""

            Dim Par_Asignatura As New SqlParameter()
            Par_Asignatura.ParameterName = "@Nombre"
            Par_Asignatura.SqlDbType = SqlDbType.NVarChar
            Par_Asignatura.Size = 50
            Par_Asignatura.Value = Datos.Asignatura
            SqlCmd.Parameters.Add(Par_Asignatura)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = ex.Message ' New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Eliminar(IdAsignaciones As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaciones_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Asignaciones As New SqlParameter()
            Par_Id_Asignaciones.ParameterName = "@idasignacion"
            Par_Id_Asignaciones.SqlDbType = SqlDbType.Int
            Par_Id_Asignaciones.Value = IdAsignaciones
            SqlCmd.Parameters.Add(Par_Id_Asignaciones)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Eliminar_Asignatura(IdAsignatura As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaturas_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAsignatura As New SqlParameter()
            Par_IdAsignatura.ParameterName = "@IdAsignatura"
            Par_IdAsignatura.SqlDbType = SqlDbType.Int
            Par_IdAsignatura.Value = IdAsignatura
            SqlCmd.Parameters.Add(Par_IdAsignatura)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Mostrar(Datos As DDocentesAsignaciones) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaciones_Mostrar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Docente As New SqlParameter()
            Par_Id_Docente.ParameterName = "@IdDocente"
            Par_Id_Docente.SqlDbType = SqlDbType.Int
            Par_Id_Docente.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(Par_Id_Docente)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)

        Catch ex As Exception
            Rpta = Nothing
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Mostrar_Asignatura() As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignaturas_Mostrar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)

        Catch ex As Exception
            Rpta = Nothing
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
End Class

