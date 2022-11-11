Imports System.Data
Imports System.Data.SqlClient
Public Class DMatricula
    Inherits DAlumnos

    Private _Id_Matricula As Int32
    Private _Turno As String
    Private _Seccion As String

    Public Property Id_Matricula As Int32
        Set(value As Int32)
            _Id_Matricula = value
        End Set
        Get
            Return _Id_Matricula
        End Get
    End Property
#Disable Warning BC40003 ' property 'Turno' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
    Public Property Turno As String
#Enable Warning BC40003 ' property 'Turno' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
        Set(value As String)
            _Turno = value
        End Set
        Get
            Return _Turno
        End Get
    End Property
#Disable Warning BC40003 ' property 'Seccion' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
    Public Property Seccion As String
#Enable Warning BC40003 ' property 'Seccion' prevalece sobre un miembro que se puede sobrecargar declarado en la base class 'DDatos'. Si quiere sobrecargar el método base, este método se debe declarar como 'Overloads'.
        Set(value As String)
            _Seccion = value
        End Set
        Get
            Return _Seccion
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub New(idMatricula As Int32)
        Me.Id_Matricula = idMatricula
    End Sub

    Public Function Insertar_Matricula(Datos As DMatricula) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@Id_Alumno"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Value = Datos.Id_Alumnos
            SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NVarChar
            Par_Grado.Size = 20
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NVarChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Fecha As New SqlParameter()
            Par_Fecha.ParameterName = "@Fecha"
            Par_Fecha.SqlDbType = SqlDbType.Date
            Par_Fecha.Value = Datos.Fecha
            SqlCmd.Parameters.Add(Par_Fecha)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)

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

    Public Function Insertar_Matricula_id_Mined(Datos As DMatricula) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Insertar_Id_Mined"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Respuesta As New SqlParameter()
            Par_Respuesta.Direction = ParameterDirection.Output
            Par_Respuesta.ParameterName = "@Respuesta"
            Par_Respuesta.SqlDbType = SqlDbType.NVarChar
            Par_Respuesta.Size = 255
            SqlCmd.Parameters.Add(Par_Respuesta)

            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@Id_Alumno"
            Par_Id_Alumno.SqlDbType = SqlDbType.NVarChar
            Par_Id_Alumno.Size = 50
            Par_Id_Alumno.Value = Datos.Id_Mined.Trim
            SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NVarChar
            Par_Grado.Size = 20
            Par_Grado.Value = Datos.Grado.Trim
            SqlCmd.Parameters.Add(Par_Grado)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NVarChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Fecha As New SqlParameter()
            Par_Fecha.ParameterName = "@Fecha"
            Par_Fecha.SqlDbType = SqlDbType.Date
            Par_Fecha.Value = Datos.Fecha
            SqlCmd.Parameters.Add(Par_Fecha)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                If SqlCmd.Parameters("@Respuesta").Value = "Ok" Then
                    Rpta = "Ok"
                Else
                    Rpta = SqlCmd.Parameters("@Respuesta").Value
                End If
            Else
                Rpta = SqlCmd.Parameters("@Respuesta").Value ' "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Editar_Matricula(Datos As DMatricula) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Editar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Alumno As New SqlParameter()
            Par_Id_Alumno.ParameterName = "@Id_Alumno"
            Par_Id_Alumno.SqlDbType = SqlDbType.Int
            Par_Id_Alumno.Value = Datos.Id_Alumnos
            SqlCmd.Parameters.Add(Par_Id_Alumno)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.NVarChar
            Par_Grado.Size = 20
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NVarChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_id_Matricula As New SqlParameter()
            Par_id_Matricula.ParameterName = "@Id_Matricula"
            Par_id_Matricula.SqlDbType = SqlDbType.Int
            Par_id_Matricula.Value = Datos.Id_Matricula
            SqlCmd.Parameters.Add(Par_id_Matricula)

            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error al ejecutar el comando"
            End If

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Eliminar_Matricula(id_matricula As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Matricula As New SqlParameter()
            Par_Id_Matricula.ParameterName = "@id_matricula"
            Par_Id_Matricula.SqlDbType = SqlDbType.Int
            Par_Id_Matricula.Value = id_matricula
            SqlCmd.Parameters.Add(Par_Id_Matricula)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

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

    Public Function Suspender_Matricula(id_matricula As Int32, idalumno As Int32, año As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Suspender"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_matricula", id_matricula)



            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = New DNotas().Suspender_Nota(idalumno, año)

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

    Public Function Restaurar_Matricula(id_matricula As Int32, idalumno As Int32, año As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Matricula_Restaurar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Matricula As New SqlParameter()
            Par_Id_Matricula.ParameterName = "@id_matricula"
            Par_Id_Matricula.SqlDbType = SqlDbType.Int
            Par_Id_Matricula.Value = id_matricula
            SqlCmd.Parameters.Add(Par_Id_Matricula)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = New DNotas().Restaurar_Nota(idalumno, año)
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

    Public Function Buscar_Modalidad_Año(Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Matricula_Extraer_Modalidades"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@anio"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Año
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

    Public Function Buscar_Turno_Año(Modalidad As String, Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Matricula_Extraer_Turno"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)

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
    Public Function Buscar_Grado_Modalidad_Año(Año As Int32, Modalidad As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Matricula_Extraer_Grados_Por_Modalidad"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)


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
    Public Function Buscar_Grado_Modalidad_Año_Turno(Año As Int32, Modalidad As String, Turno As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Matricula_Extraer_Grados_Por_Modalidad_Turno"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Turno)


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
    Public Function Buscar_Seccion_Grado_Modalidad_Año_Turno(Año As Int32, Modalidad As String, Turno As String, Grado As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Matricula_Extraer_Seccion_Por_Grados_Modalidad_Turno"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Grado)


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

    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String, Grado As String, Seccion As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio_Modalidad_Turno_Grado_Seccion"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
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
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String, Grado As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio_Modalidad_Turno_Grado"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Grado)


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
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String, Turno As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio_Modalidad_Turno"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Turno)


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
    Public Function Buscar_Listado_Estudiantes(Año As Int32, Modalidad As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio_Modalidad"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)


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
    Public Function Buscar_Listado_Estudiantes(Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Alumnos_Buscar_Matricula_Anio"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)


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
    Public Function Get_IdMatricula(IdAlumno As Int32, año As Int32) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32 = 0
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Get_Id_Matricula"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""


            SqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno)
            SqlCmd.Parameters.AddWithValue("@Anio", año)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            Rpta = SqlCmd.ExecuteScalar

        Catch ex As Exception
            Rpta = 0
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
End Class
