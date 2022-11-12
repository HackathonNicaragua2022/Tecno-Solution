Imports System.Data
Imports System.Data.SqlClient
Public Class DAlumnos
    Inherits DDatos

    Private _Id_Alumno As Int32
    Private _Id_Mined As String
    Private _Sexo As String

    Public Property Id_Alumnos As Int32
        Set(value As Int32)
            _Id_Alumno = value
        End Set
        Get
            Return _Id_Alumno
        End Get
    End Property
    Public Property Id_Mined As String
        Set(value As String)
            _Id_Mined = value 'C : \Jiuber\FHernandez\jess92\Datos\DAlumnos.vb
        End Set
        Get
            Return _Id_Mined
        End Get
    End Property
#Disable Warning BC40003 ' property 'Sexo' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
    Public Property Sexo As String
#Enable Warning BC40003 ' property 'Sexo' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
        Set(value As String)
            _Sexo = value
        End Set
        Get
            Return _Sexo
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(idalumno As Int32, idmined As String, sexo As String)
        Me.Id_Alumnos = idalumno
        Me.Id_Mined = idmined
        Me.Sexo = sexo
    End Sub

    Public Function Insertar(Datos As DAlumnos) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@Id_Alumno"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Direction = ParameterDirection.Output
            SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Id_Mined As New SqlParameter()
            Par_Id_Mined.ParameterName = "@IdMined"
            Par_Id_Mined.SqlDbType = SqlDbType.NVarChar
            Par_Id_Mined.Size = 50
            Par_Id_Mined.Value = Datos.Id_Mined
            SqlCmd.Parameters.Add(Par_Id_Mined)

            Dim Par_Nombres As New SqlParameter()
            Par_Nombres.ParameterName = "@Nombres"
            Par_Nombres.SqlDbType = SqlDbType.NVarChar
            Par_Nombres.Size = 70
            Par_Nombres.Value = Datos.Nombres
            SqlCmd.Parameters.Add(Par_Nombres)

            Dim Par_Apellidos As New SqlParameter()
            Par_Apellidos.ParameterName = "@Apellidos"
            Par_Apellidos.SqlDbType = SqlDbType.NVarChar
            Par_Apellidos.Size = 70
            Par_Apellidos.Value = Datos.Apellidos
            SqlCmd.Parameters.Add(Par_Apellidos)

            Dim Par_Sexo As New SqlParameter()
            Par_Sexo.ParameterName = "@Sexo"
            Par_Sexo.SqlDbType = SqlDbType.NChar
            Par_Sexo.Size = 10
            Par_Sexo.Value = Datos.Sexo
            SqlCmd.Parameters.Add(Par_Sexo)

            Dim Par_Nacimiento As New SqlParameter()
            Par_Nacimiento.ParameterName = "@Nacimiento"
            Par_Nacimiento.SqlDbType = SqlDbType.Date
            Par_Nacimiento.Value = Datos.Nacimiento
            SqlCmd.Parameters.Add(Par_Nacimiento)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = SqlCmd.Parameters("@Id_Alumno").Value.ToString
                'msg = New Utilidades().Mensaje(Rpta)
            Else
                Rpta = "0"
                'msg = New Utilidades().Mensaje(Rpta)
            End If

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Editar(Datos As DAlumnos) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Editar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@IdAlumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Datos.Id_Alumnos
            SqlCmd.Parameters.Add(Par_IdAlumno)

            Dim Par_Id_Mined As New SqlParameter()
            Par_Id_Mined.ParameterName = "@IdMined"
            Par_Id_Mined.SqlDbType = SqlDbType.NVarChar
            Par_Id_Mined.Size = 50
            Par_Id_Mined.Value = Datos.Id_Mined
            SqlCmd.Parameters.Add(Par_Id_Mined)

            Dim Par_Nombres As New SqlParameter()
            Par_Nombres.ParameterName = "@Nombres"
            Par_Nombres.SqlDbType = SqlDbType.NVarChar
            Par_Nombres.Size = 70
            Par_Nombres.Value = Datos.Nombres
            SqlCmd.Parameters.Add(Par_Nombres)

            Dim Par_Apellidos As New SqlParameter()
            Par_Apellidos.ParameterName = "@Apellidos"
            Par_Apellidos.SqlDbType = SqlDbType.NVarChar
            Par_Apellidos.Size = 70
            Par_Apellidos.Value = Datos.Apellidos
            SqlCmd.Parameters.Add(Par_Apellidos)

            Dim Par_Sexo As New SqlParameter()
            Par_Sexo.ParameterName = "@Sexo"
            Par_Sexo.SqlDbType = SqlDbType.NChar
            Par_Sexo.Size = 10
            Par_Sexo.Value = Datos.Sexo
            SqlCmd.Parameters.Add(Par_Sexo)

            Dim Par_Nacimiento As New SqlParameter()
            Par_Nacimiento.ParameterName = "@Nacimiento"
            Par_Nacimiento.SqlDbType = SqlDbType.Date
            Par_Nacimiento.Value = Datos.Nacimiento
            SqlCmd.Parameters.Add(Par_Nacimiento)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "OK"
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

    Public Function Eliminar(Datos As DAlumnos) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@IdAlumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Datos.Id_Alumnos
            SqlCmd.Parameters.Add(Par_IdAlumno)



            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "OK"
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

    Public Function Buscar(Nombre As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Buscar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Alumno As New SqlParameter()
            Par_Alumno.ParameterName = "@Nombres"
            Par_Alumno.SqlDbType = SqlDbType.NVarChar
            Par_Alumno.Size = 70
            Par_Alumno.Value = Nombre
            SqlCmd.Parameters.Add(Par_Alumno)


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

    Public Function Excelencia_Academica(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Excelencia_Academica"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Alumnos_Destacados(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Destacados"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Alumnos_en_Af(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_en_Af"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Alumnos_en_Ai(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_en_Ai"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Alumnos_Reprobados(año As Int32, corte As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Reprobados"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", año)
            SqlCmd.Parameters.AddWithValue("@Id_Corte", corte)


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
    Public Function Alumnos_Reprobados_Detallados(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Reprobados_Detallados"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Estudiantes_Retirados(año As Int32, corte As Int32, modalidad As String, turno As String, grado As String, seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Estudiantes_Retirados"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)
            SqlCmd.Parameters.AddWithValue("@IdCorte", corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", seccion)


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
    Public Function Matricula(año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Cantidad_Alumnos_Grado"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@anio", año)


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
    Public Function Mostrar_Notas(Id_Alumno As String, Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Mostrar_Boletin"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Alumno As New SqlParameter()
            Par_Alumno.ParameterName = "@IdAlumno"
            Par_Alumno.SqlDbType = SqlDbType.Int
            Par_Alumno.Value = Id_Alumno
            SqlCmd.Parameters.Add(Par_Alumno)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Año
            SqlCmd.Parameters.Add(Par_Año)


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

    Public Function Buscar_Apellido(Nombre As String, Apellidos As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Buscar_Apellidos"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Alumno As New SqlParameter()
            Par_Alumno.ParameterName = "@Nombres"
            Par_Alumno.SqlDbType = SqlDbType.NVarChar
            Par_Alumno.Size = 70
            Par_Alumno.Value = Nombre
            SqlCmd.Parameters.Add(Par_Alumno)

            Dim Par_Apellidos As New SqlParameter()
            Par_Apellidos.ParameterName = "@Apellidos"
            Par_Apellidos.SqlDbType = SqlDbType.NVarChar
            Par_Apellidos.Size = 70
            Par_Apellidos.Value = Apellidos
            SqlCmd.Parameters.Add(Par_Apellidos)


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

    Public Function Buscar_Matricula(Id_Alumno As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Alumnos_Buscar_Matricula"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@Id_Alumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Id_Alumno
            SqlCmd.Parameters.Add(Par_IdAlumno)


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
    Public Function Buscar_Matricula_Año(Año As Int32, modalidad As String, Turno As String, grado As String, Seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio_Modalidad_Grado"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@anio"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Año
            SqlCmd.Parameters.Add(Par_IdAlumno)

            SqlCmd.Parameters.AddWithValue("Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("Turno", Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", Seccion)

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

End Class
