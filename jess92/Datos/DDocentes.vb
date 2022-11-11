Imports System.Data, System.Data.SqlClient
Public Class DDocentes
    Inherits DDatos

    Private _Id_Docente As Int32
    Private _Cedula As String
    Private _User As String
    Private _Pass As String
    Private _Id_Asignacion As Int32
    Private _Acceso As String
    Private _Ip As String
    Private _Pc As String

    Public Property Ip As String
        Set(value As String)
            _Ip = value
        End Set
        Get
            Return _Ip
        End Get
    End Property

    Public Property Pc As String
        Set(value As String)
            _Pc = value
        End Set
        Get
            Return _Pc
        End Get
    End Property
    Public Property Id_Docente As Int32
        Set(value As Int32)
            _Id_Docente = value
        End Set
        Get
            Return _Id_Docente
        End Get
    End Property

    Public Property Id_Asignacion As Int32
        Set(value As Int32)
            _Id_Asignacion = value
        End Set
        Get
            Return _Id_Asignacion
        End Get
    End Property
    Public Property Cedula As String
        Set(value As String)
            _Cedula = value
        End Set
        Get
            Return _Cedula
        End Get
    End Property
    Public Property User As String
        Set(value As String)
            _User = value
        End Set
        Get
            Return _User
        End Get
    End Property
    Public Property Pass As String
        Set(value As String)
            _Pass = value
        End Set
        Get
            Return _Pass
        End Get
    End Property

    Public Property Acceso As String
        Set(value As String)
            _Acceso = value
        End Set
        Get
            Return _Acceso
        End Get
    End Property
    Public Sub New()

    End Sub
    Public Sub New(cedula_d As String, iddocente As Int32, usuario As String, contraseña As String, id_Asignacion As Int32, acceso As String, ip As String, pc As String)
        Me.Id_Docente = iddocente
        Me.Cedula = cedula_d
        Me.User = usuario
        Me.Pass = contraseña
        Me.Id_Asignacion = id_Asignacion
        Me.Acceso = acceso
        Me.Ip = ip
        Me.Pc = pc
    End Sub

    Public Function Insertar(Datos As DDocentes) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Docentes_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@Id_Alumno"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Direction = ParameterDirection.Output
            'SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Nombres As New SqlParameter()
            Par_Nombres.ParameterName = "@Nombres"
            Par_Nombres.SqlDbType = SqlDbType.NVarChar
            Par_Nombres.Size = 50
            Par_Nombres.Value = Datos.Nombres
            SqlCmd.Parameters.Add(Par_Nombres)

            Dim Par_Apellidos As New SqlParameter()
            Par_Apellidos.ParameterName = "@Apellidos"
            Par_Apellidos.SqlDbType = SqlDbType.NVarChar
            Par_Apellidos.Size = 60
            Par_Apellidos.Value = Datos.Apellidos
            SqlCmd.Parameters.Add(Par_Apellidos)

            Dim Par_Cedula As New SqlParameter()
            Par_Cedula.ParameterName = "@Cedula"
            Par_Cedula.SqlDbType = SqlDbType.NVarChar
            Par_Cedula.Size = 50
            Par_Cedula.Value = Datos.Cedula
            SqlCmd.Parameters.Add(Par_Cedula)

            Dim Par_Sexo As New SqlParameter()
            Par_Sexo.ParameterName = "@Sexo"
            Par_Sexo.SqlDbType = SqlDbType.NChar
            Par_Sexo.Size = 10
            Par_Sexo.Value = Datos.Sexo
            SqlCmd.Parameters.Add(Par_Sexo)

            Dim Par_User As New SqlParameter()
            Par_User.ParameterName = "@User"
            Par_User.SqlDbType = SqlDbType.NVarChar
            Par_User.Value = Datos.User
            SqlCmd.Parameters.Add(Par_User)

            Dim Par_Pass As New SqlParameter()
            Par_Pass.ParameterName = "@Pass"
            Par_Pass.SqlDbType = SqlDbType.NVarChar
            Par_Pass.Value = Datos.Pass
            SqlCmd.Parameters.Add(Par_Pass)

            Dim Par_Acceso As New SqlParameter()
            Par_Acceso.ParameterName = "@Acceso"
            Par_Acceso.SqlDbType = SqlDbType.NVarChar
            Par_Acceso.Value = Datos.Acceso
            SqlCmd.Parameters.Add(Par_Acceso)

            Dim Par_Telefono As New SqlParameter()
            Par_Telefono.ParameterName = "@Telefono"
            Par_Telefono.SqlDbType = SqlDbType.NVarChar
            Par_Telefono.Value = Datos.Telefono
            SqlCmd.Parameters.Add(Par_Telefono)

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

    Public Function Editar(Datos As DDocentes) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Docentes_Editar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@IdDocente"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Nombres As New SqlParameter()
            Par_Nombres.ParameterName = "@Nombres"
            Par_Nombres.SqlDbType = SqlDbType.NVarChar
            Par_Nombres.Size = 50
            Par_Nombres.Value = Datos.Nombres
            SqlCmd.Parameters.Add(Par_Nombres)

            Dim Par_Apellidos As New SqlParameter()
            Par_Apellidos.ParameterName = "@Apellidos"
            Par_Apellidos.SqlDbType = SqlDbType.NVarChar
            Par_Apellidos.Size = 60
            Par_Apellidos.Value = Datos.Apellidos
            SqlCmd.Parameters.Add(Par_Apellidos)

            Dim Par_Cedula As New SqlParameter()
            Par_Cedula.ParameterName = "@Cedula"
            Par_Cedula.SqlDbType = SqlDbType.NVarChar
            Par_Cedula.Size = 50
            Par_Cedula.Value = Datos.Cedula
            SqlCmd.Parameters.Add(Par_Cedula)

            Dim Par_Sexo As New SqlParameter()
            Par_Sexo.ParameterName = "@Sexo"
            Par_Sexo.SqlDbType = SqlDbType.NChar
            Par_Sexo.Size = 10
            Par_Sexo.Value = Datos.Sexo
            SqlCmd.Parameters.Add(Par_Sexo)

            Dim Par_User As New SqlParameter()
            Par_User.ParameterName = "@User"
            Par_User.SqlDbType = SqlDbType.NVarChar
            Par_User.Value = Datos.User
            SqlCmd.Parameters.Add(Par_User)

            Dim Par_Pass As New SqlParameter()
            Par_Pass.ParameterName = "@Pass"
            Par_Pass.SqlDbType = SqlDbType.NVarChar
            Par_Pass.Value = Datos.Pass
            SqlCmd.Parameters.Add(Par_Pass)

            Dim Par_Acceso As New SqlParameter()
            Par_Acceso.ParameterName = "@Acceso"
            Par_Acceso.SqlDbType = SqlDbType.NVarChar
            Par_Acceso.Value = Datos.Acceso
            SqlCmd.Parameters.Add(Par_Acceso)

            Dim Par_Telefono As New SqlParameter()
            Par_Telefono.ParameterName = "@Telefono"
            Par_Telefono.SqlDbType = SqlDbType.NVarChar
            Par_Telefono.Value = Datos.Telefono
            SqlCmd.Parameters.Add(Par_Telefono)

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

    Public Function Eliminar(id_docente As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Docentes_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@IdDocente"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Value = id_docente
            SqlCmd.Parameters.Add(Par_Id_Alumno)

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

    Public Function Buscar(Nombre As String, av As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Docentes_Buscar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Alumno As New SqlParameter()
            Par_Alumno.ParameterName = "@TextoBuscar"
            Par_Alumno.SqlDbType = SqlDbType.NVarChar
            Par_Alumno.Size = 50
            Par_Alumno.Value = Nombre
            SqlCmd.Parameters.Add(Par_Alumno)
            SqlCmd.Parameters.AddWithValue("@Avanzada", av)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            Dim SqlDT As New SqlDataAdapter(SqlCmd)
            SqlDT.Fill(Rpta)


        Catch ex As Exception
            Rpta = Nothing
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Asignar_Grado(Datos As DDocentes) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignacion_Grado_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            Dim ParIdDocente As New SqlParameter()
            ParIdDocente.ParameterName = "@Id_Docente"
            ParIdDocente.SqlDbType = SqlDbType.Int
            ParIdDocente.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(ParIdDocente)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NChar
            Par_Grado.Size = 15
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)


            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)
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


    Public Function Editar_asignacion_Grado(Datos As DDocentes) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignacion_Grado_Editar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim ParIdAsignacion As New SqlParameter()
            ParIdAsignacion.ParameterName = "@Id_Asignacion"
            ParIdAsignacion.SqlDbType = SqlDbType.Int
            ParIdAsignacion.Value = Datos.id_Asignacion
            SqlCmd.Parameters.Add(ParIdAsignacion)

            Dim ParIdDocente As New SqlParameter()
            ParIdDocente.ParameterName = "@Id_Docente"
            ParIdDocente.SqlDbType = SqlDbType.Int
            ParIdDocente.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(ParIdDocente)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NChar
            Par_Grado.Size = 15
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)

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

    Public Function Eliminar_Asignacion_Grado(IdAsignacion As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignacion_Grado_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim ParIdAsignacion As New SqlParameter()
            ParIdAsignacion.ParameterName = "@Id_Asignacion"
            ParIdAsignacion.SqlDbType = SqlDbType.Int
            ParIdAsignacion.Value = IdAsignacion
            SqlCmd.Parameters.Add(ParIdAsignacion)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            '
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Buscar_Asignacion_de_Grado(IdDocente As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Asignacion_Grado_Buscar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim ParIdDocente As New SqlParameter()
            ParIdDocente.ParameterName = "@Id_Docente"
            ParIdDocente.SqlDbType = SqlDbType.Int
            ParIdDocente.Value = IdDocente
            SqlCmd.Parameters.Add(ParIdDocente)

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

    Public Function Obtener_Id_Docente(Id_Alumno_Mined As String, Año As Int32) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32 = 0
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Get_Id_Docente"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@id_Alumno_Mined", Id_Alumno_Mined)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim i As Int32
            i = SqlCmd.ExecuteScalar
        Catch ex As Exception
            Rpta = 0
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Obtener_Id_Docente(Nombres As String, Apellidos As String) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32 = 0
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Obtener_Id_Docente"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Nombres", Nombres)
            SqlCmd.Parameters.AddWithValue("@Apellidos", Apellidos)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim i As Int32
            i = SqlCmd.ExecuteScalar
        Catch ex As Exception
            Rpta = 0
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function User_Login(datos As DDocentes) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Iniciar_Sesion"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim ParSesion As New SqlParameter
            ParSesion.ParameterName = "@Sesion"
            ParSesion.Direction = ParameterDirection.Output
            ParSesion.SqlDbType = SqlDbType.Int
            SqlCmd.Parameters.Add(ParSesion)

            SqlCmd.Parameters.AddWithValue("@User", datos.User)
            SqlCmd.Parameters.AddWithValue("@pass", datos.Pass)
            SqlCmd.Parameters.AddWithValue("@Ip", datos.Ip)
            SqlCmd.Parameters.AddWithValue("@Pc", datos.Pc)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            SqlCmd.ExecuteNonQuery()
            Rpta = SqlCmd.Parameters("@Sesion").Value


        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function User_Login_Datos(Sesion_Id As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Iniciar_Sesion_Datos"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Sesion", Sesion_Id)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)


        Catch ex As Exception
            Rpta = Nothing
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

End Class
