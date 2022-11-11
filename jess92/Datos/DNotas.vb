Imports System.Data, System.Data.SqlClient
Public Class DNotas
    Inherits DDatos

    Private _Id_Nota As Int32
    Private _Id_Corte As Int32
    Private _Id_Asignatura As Int32
    Private _Asignatura As String
    Private _Id_Alumno As Int32
    Private _Id_Docente As Int32
    Private _Nivel As String

    Public Property Id_Nota As Int32
        Set(value As Int32)
            _Id_Nota = value
        End Set
        Get
            Return _Id_Nota
        End Get
    End Property
    Public Property Id_Corte As Int32
        Set(value As Int32)
            _Id_Corte = value
        End Set
        Get
            Return _Id_Corte
        End Get
    End Property
    Public Property Id_Asignatura As Int32
        Set(value As Int32)
            _Id_Asignatura = value
        End Set
        Get
            Return _Id_Asignatura
        End Get
    End Property
    Public Property Id_Alumno As Int32
        Set(value As Int32)
            _Id_Alumno = value
        End Set
        Get
            Return _Id_Alumno
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
    Public Property Nivel As String
        Set(value As String)
            _Nivel = value
        End Set
        Get
            Return _Nivel
        End Get
    End Property
    Public Property Asignatura As String
        Set(value As String)
            _Asignatura = value
        End Set
        Get
            Return _Asignatura
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(idnota As Int32, iddocente As Int32, idalumno As Int32, idcorte As Int32, idasignatura As Int32, nivel As String, asig As String)
        Me.Id_Nota = idnota
        Me.Id_Corte = idcorte
        Me.Id_Asignatura = idasignatura
        Me.Id_Alumno = idalumno
        Me.Id_Docente = iddocente
        Me.Nivel = nivel
        Me.Asignatura = asig
    End Sub

    Public Function MostrarAlumnos_paraInsertar(Datos As DNotas) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Mostrar_ParaIngrsar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Corte As New SqlParameter()
            Par_Id_Corte.ParameterName = "@IdCorte"
            Par_Id_Corte.SqlDbType = SqlDbType.Int
            Par_Id_Corte.Value = Datos.Id_Corte
            SqlCmd.Parameters.Add(Par_Id_Corte)

            'Enviar Alumno en la propiedad Nombres

            Dim Par_Alumno As New SqlParameter()
            Par_Alumno.ParameterName = "@Alumno"
            Par_Alumno.SqlDbType = SqlDbType.NVarChar
            Par_Alumno.Size = 50
            Par_Alumno.Value = Datos.Nombres
            SqlCmd.Parameters.Add(Par_Alumno)

            Dim Par_Modalidad As New SqlParameter()
            Par_Modalidad.ParameterName = "@Modalidad"
            Par_Modalidad.SqlDbType = SqlDbType.NVarChar
            Par_Modalidad.Size = 50
            Par_Modalidad.Value = Datos.Modalidad
            SqlCmd.Parameters.Add(Par_Modalidad)

            Dim Par_Grado As New SqlParameter()
            Par_Grado.ParameterName = "@Grado"
            Par_Grado.SqlDbType = SqlDbType.VarChar
            Par_Grado.Size = 20
            Par_Grado.Value = Datos.Grado
            SqlCmd.Parameters.Add(Par_Grado)

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
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Mostrar_Notas(Datos As DNotas) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Mostrar_Notas"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Corte As New SqlParameter()
            Par_Id_Corte.ParameterName = "@idCorte"
            Par_Id_Corte.SqlDbType = SqlDbType.Int
            Par_Id_Corte.Value = Datos.Id_Corte
            SqlCmd.Parameters.Add(Par_Id_Corte)

            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@IdAlumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Datos.Id_Alumno
            SqlCmd.Parameters.Add(Par_IdAlumno)

            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)



            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Mostrar_Asignaturas_Por_Docente(Datos As DNotas) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Mostrar_Asignaturas_Por_Docente"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Id_Corte", Datos.Id_Corte)
            SqlCmd.Parameters.AddWithValue("@id_Docente", Datos.Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Id_Alumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Datos.Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Mostrar_Asignaturas(Datos As DNotas) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_CargarAsignaturas"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Corte As New SqlParameter()
            Par_Id_Corte.ParameterName = "@idCorte"
            Par_Id_Corte.SqlDbType = SqlDbType.Int
            Par_Id_Corte.Value = Datos.Id_Corte
            SqlCmd.Parameters.Add(Par_Id_Corte)

            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@IdAlumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Datos.Id_Alumno
            SqlCmd.Parameters.Add(Par_IdAlumno)

            SqlCmd.Parameters.AddWithValue("@Modaliad", Datos.Modalidad)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Asignaturas_Eliminadas(TextoBuscar As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Mostrar_Asignaturas_Eliminadas"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@TextoBuscar", TextoBuscar)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Intentos_de_Eliminacion(TextoBuscar As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Mostrar_Intentos_de_Eliminacion"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@TextoBuscar", TextoBuscar)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Insertar_Nota(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_Corte As New SqlParameter()
            Par_Id_Corte.ParameterName = "@IdCorte"
            Par_Id_Corte.SqlDbType = SqlDbType.Int
            Par_Id_Corte.Value = Datos.Id_Corte
            SqlCmd.Parameters.Add(Par_Id_Corte)

            Dim Par_IdAsignatura As New SqlParameter()
            Par_IdAsignatura.ParameterName = "@IdAsignatura"
            Par_IdAsignatura.SqlDbType = SqlDbType.Int
            Par_IdAsignatura.Value = Datos.Id_Asignatura
            SqlCmd.Parameters.Add(Par_IdAsignatura)

            Dim Par_IdAlumno As New SqlParameter()
            Par_IdAlumno.ParameterName = "@IdAlumno"
            Par_IdAlumno.SqlDbType = SqlDbType.Int
            Par_IdAlumno.Value = Datos.Id_Alumno
            SqlCmd.Parameters.Add(Par_IdAlumno)

            Dim Par_IdDocente As New SqlParameter()
            Par_IdDocente.ParameterName = "@IdDocente"
            Par_IdDocente.SqlDbType = SqlDbType.Int
            Par_IdDocente.Value = Datos.Id_Docente
            SqlCmd.Parameters.Add(Par_IdDocente)

            Dim Par_Año As New SqlParameter()
            Par_Año.ParameterName = "@Anio"
            Par_Año.SqlDbType = SqlDbType.Int
            Par_Año.Value = Datos.Año
            SqlCmd.Parameters.Add(Par_Año)

            Dim Par_Nota As New SqlParameter()
            Par_Nota.ParameterName = "@Nota"
            Par_Nota.SqlDbType = SqlDbType.Int
            Par_Nota.Value = Datos.Nota
            SqlCmd.Parameters.Add(Par_Nota)

            Dim Par_Nivel As New SqlParameter()
            Par_Nivel.ParameterName = "@Nivel"
            Par_Nivel.SqlDbType = SqlDbType.NChar
            Par_Nivel.Size = 20
            Par_Nivel.Value = Datos.Nivel
            SqlCmd.Parameters.Add(Par_Nivel)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"
            Dim rp As String = ""
            If Datos.Corte = "II CORTE" Then
                rp = Insertar_Nota_Semestre(Datos)
            ElseIf Corte = "IV CORTE" Then
                Insertar_Nota_Semestre(Datos)
                Insertar_Nota_Final(Datos)
                rp = "Ok"
            End If


        Catch ex As Exception
            Rpta = ex.Message
            'Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Insertar_Nota_Semestre(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Notas_Insertar_Semestre"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@IdCorte", Datos.Id_Corte)
            SqlCmd.Parameters.AddWithValue("@IdAsignatura", Datos.Id_Asignatura)
            SqlCmd.Parameters.AddWithValue("@IdAlumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@IdDocente", Datos.Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Nivel", Datos.Nivel)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"


        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Insertar_Nota_Final(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Notas_Insertar_Final"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@IdCorte", Datos.Id_Corte)
            SqlCmd.Parameters.AddWithValue("@IdAsignatura", Datos.Id_Asignatura)
            SqlCmd.Parameters.AddWithValue("@IdAlumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@IdDocente", Datos.Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Nivel", Datos.Nivel)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"


        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Insertar_Nota_Lote(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Insertar_Lote"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@IdCorte", Datos.Id_Corte)
            SqlCmd.Parameters.AddWithValue("@Asignatura", Datos.Asignatura)
            SqlCmd.Parameters.AddWithValue("@IdAlumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@IdDocente", Datos.Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Nivel", Datos.Nivel)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Nota", Datos.Nota)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"
        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Insertar_Nota_Por_Lote(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpt As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Insertar_Por_Lote"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Corte", Datos.Corte)
            SqlCmd.Parameters.AddWithValue("@Asignatura", Datos.Asignatura)
            SqlCmd.Parameters.AddWithValue("@CodigoAlumno", Datos.Id_Mined)
            SqlCmd.Parameters.AddWithValue("@IdDocente", Datos.Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Nivel", Datos.Nivel)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Nota", Datos.Nota)

            SqlCmd.ExecuteNonQuery()
            Rpt = "Ok"

        Catch ex As Exception
            Rpt = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpt
    End Function

    Public Function Eliminar_Nota(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            Dim Par_Id_nota As New SqlParameter()
            Par_Id_nota.ParameterName = "@id_nota"
            Par_Id_nota.SqlDbType = SqlDbType.Int
            Par_Id_nota.Value = Datos.Id_Nota
            SqlCmd.Parameters.Add(Par_Id_nota)



            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"


            If Datos.Corte.Trim = "II CORTE" Then Eliminar_Nota_Semestre(Datos)
            If Datos.Corte.Trim = "IV CORTE" Then
                Eliminar_Nota_Semestre(Datos)
                Eliminar_Nota_Final(Datos)
            End If


        Catch ex As Exception
            Rpta = ex.Message
            'Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Autorizacion_De_Eliminacon(pass As String) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Autorizar_Eliminacion"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Pass", pass)

            Dim da As New SqlDataAdapter(SqlCmd)
            Dim ds As New DataSet()
            da.Fill(ds, "Docentes")
            Dim c As Int32 = ds.Tables("Docentes").Rows.Count

            Dim Roll As String = ""
            Dim IdDocente As Int32 = 0
            Dim Docente As String = ""
            If c > 0 Then
                Roll = ds.Tables("Docentes").Rows(c - 1)("Acceso")
                IdDocente = ds.Tables("Docentes").Rows(c - 1)("IdDocente")
                Docente = ds.Tables("Docentes").Rows(c - 1)("Docente")
                Rpta = Roll + "|" + IdDocente.ToString + "|" + Docente
            Else
                Rpta = "0|0|0"
            End If


        Catch ex As Exception
            Rpta = "0|0|0"
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Intentos_de_Eliminacion_Insertar(Id_Login As Int32, Autorizador As Int32, Id_Docente As Int32, Id_Alumno As Int32, Id_Corte As Int32,
                                           Anio As Int32, Id_Asignatura As Int32, Nota As Int32, Descripcion As String) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Intentos_De_Eliminacion_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Id_Login", Id_Login)
            SqlCmd.Parameters.AddWithValue("@Autorizador", Autorizador)
            SqlCmd.Parameters.AddWithValue("@Id_Docente", Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Id_Alumno", Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@Id_Corte", Id_Corte)
            SqlCmd.Parameters.AddWithValue("@Anio", Anio)
            SqlCmd.Parameters.AddWithValue("@Id_Asignatura", Id_Asignatura)
            SqlCmd.Parameters.AddWithValue("@Nota", Nota)
            SqlCmd.Parameters.AddWithValue("@Descripcion", Descripcion)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Autorizacion_Eliminacion_Insertar(Autorizador As Int32, Id_Docente As Int32, Id_Alumno As Int32, Id_Corte As Int32,
                                            Anio As Int32, Id_Asignatura As Int32, Nota As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Autorizacion_Eliminacion_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Autorizador", Autorizador)
            SqlCmd.Parameters.AddWithValue("@Id_Docente", Id_Docente)
            SqlCmd.Parameters.AddWithValue("@Id_Alumno", Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@Id_Corte", Id_Corte)
            SqlCmd.Parameters.AddWithValue("@Anio", Anio)
            SqlCmd.Parameters.AddWithValue("@Id_Asignatura", Id_Asignatura)
            SqlCmd.Parameters.AddWithValue("@Nota", Nota)

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function


    Public Function Eliminar_Nota_Semestre(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim Corte_Name As String = ""
        Dim Rpta As String = ""
        Try
            If Datos.Corte.Trim = "II CORTE" Then
                Corte_Name = "I SEMESTRE"
            ElseIf Datos.Corte.Trim = "IV CORTE" Then
                Corte_Name = "II SEMESTRE"
            End If
            Dim SqlCmd As New SqlCommand("delete Notas where IdAlumno=@id_Alumno and Anio=@Anio and IdCorte=dbo.ID_CORTE('" + Corte_Name.Trim + "') and IdAsignatura=@id_Asignatura")
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_Alumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@id_Asignatura", Datos.Id_Asignatura)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'If SqlCmd.ExecuteNonQuery = 1 Then
            '    Rpta = "Ok"
            'Else
            '    Rpta = "Error al ejecutar el Comando"
            'End If
            'MsgBox(Datos.Id_Alumno.ToString + " " + Datos.Id_Asignatura.ToString + " " + Datos.Año.ToString)
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = ex.Message
            'Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Eliminar_Nota_Final(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim Corte_Name As String = ""
        Dim Rpta As String = ""
        Try
            If Datos.Corte.Trim = "IV CORTE" Then
                Corte_Name = "FINAL"
            End If
            Dim SqlCmd As New SqlCommand("delete Notas where IdAlumno=@id_Alumno and Anio=@Anio and IdCorte=dbo.ID_CORTE('" + Corte_Name.Trim + "') and IdAsignatura=@id_Asignatura")
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_Alumno", Datos.Id_Alumno)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@id_Asignatura", Datos.Id_Asignatura)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'If SqlCmd.ExecuteNonQuery = 1 Then
            '    Rpta = "Ok"
            'Else
            '    Rpta = "Error al ejecutar el Comando"
            'End If

            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Suspender_Nota(idAlumno As Int32, Año As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Suspender"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_Alumno", idAlumno)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            If SqlCmd.ExecuteNonQuery >= 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ok"'"El Alumno aun no tiene notas ingresadas en este año"
            End If

        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Restaurar_Nota(idAlumno As Int32, Año As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Notas_Restaurar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_Alumno", idAlumno)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            If SqlCmd.ExecuteNonQuery >= 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ok"
            End If

        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Asignar_Asignatura_y_Modalidad_A_Grado(Datos As DNotas) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_AsignaturasPorGrado_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Id_Asignatura", Datos.Id_Asignatura)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Datos.Modalidad)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Error al ejecutar el Comando"
            End If

        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Asignatura_y_Modalidad_Por_Grado(modalidad As String, Grado As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_AsignaturasPorGrado_Mostrar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            SqlCmd.Parameters.AddWithValue("@Modalidad", modalidad)
            SqlCmd.Parameters.AddWithValue("@Grado", Grado)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)

        Catch ex As Exception
            Rpta = Nothing
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function AsignaturasPorGrado_Eliminar(id_Asignacion As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_AsignaturasPorGrado_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@id_Asignacion", id_Asignacion)

            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"

        Catch ex As Exception
            Rpta = ex.Message
            ' Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    '       MOSTRAR LAS NOTAS DE LOS SEMSTRES Y FINAL PARA INGRESAR

    Public Function Mostrar_Semestre_Primero_Segundo(Grado As String, Año As Int32, Semestre As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Semestre_Primero_Segundo_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@semestre", Semestre)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Final_Primero_Segundo(Grado As String, Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        'Try
        sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Nota_Final_Primero_Segundo_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
        SqlCmd.Parameters.AddWithValue("@Anio", Año)


        '       Ejecución del Comando
        '""""""""""""""""""""""""""""""""""""""
        'Dim msg As Boolean
        Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        'Catch ex As Exception
        '    Rpta = Nothing
        '    Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        'Finally
        If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        'End Try

        Return Rpta
    End Function
    Public Function Mostrar_Semestre_Tercero_Sexto(Grado As String, Año As Int32, Semestre As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Semestre_Tercero_A_Sexto_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@semestre", Semestre)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Final_Tercero_Sexto(Grado As String, Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Nota_Final_Tercero_A_Sexto_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Semestre_Secundaria(Grado As String, Año As Int32, Semestre As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Semestre_Secundaria_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@semestre", Semestre)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function
    Public Function Mostrar_Final_Secundaria(Grado As String, Año As Int32) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Nota_Final_Secundaria_Cuantitativo"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Grado", Grado)
            SqlCmd.Parameters.AddWithValue("@Anio", Año)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim SqlDt As New SqlDataAdapter(SqlCmd)
            SqlDt.Fill(Rpta)
        Catch ex As Exception
            Rpta = Nothing
            Dim n As Boolean = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Obtener_Id_Asignatuta(Asignatura As String) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32 = 0
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Get_ID_Asignatura"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Asignatura", Asignatura)


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

    Public Function Obtener_Id_Alumno(Id_Mined As String) As Int32
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As Int32 = 0
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Get_ID_Alumno"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Id_Mined", Id_Mined)


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

End Class
