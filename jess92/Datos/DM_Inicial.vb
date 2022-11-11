Imports System.Data, System.Data.SqlClient
Public Class DM_Inicial
    Inherits DDatos
    Private _Id_m_Inicial As Int32
    Private _AbS As Int32
    Private _F As Int32

    Public Property Id_m_Inicial As Int32
        Set(value As Int32)
            _Id_m_Inicial = value
        End Set
        Get
            Return _Id_m_Inicial
        End Get
    End Property

    Public Property AbS As Int32
        Set(value As Int32)
            _AbS = value
        End Set
        Get
            Return _AbS
        End Get
    End Property

    Public Property F As Int32
        Set(value As Int32)
            _f = value
        End Set
        Get
            Return _f
        End Get
    End Property
    Public Sub New()

    End Sub
    Public Sub New(id As Int32, abs As Int32, f As Int32)
        Me.Id_m_Inicial = id
        Me.AbS = abs
        Me.F = f
    End Sub

    Public Function Insertar(Datos As DM_Inicial) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "M_Inicial_Insertar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Datos.Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)
            SqlCmd.Parameters.AddWithValue("@AS", Datos.AbS)
            SqlCmd.Parameters.AddWithValue("@F", Datos.F)
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"
        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
        Return Rpta
    End Function
    Public Function Editar(Datos As DM_Inicial) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "M_Inicial_Editar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Id_M_Inicial", Datos.Id_m_Inicial)
            SqlCmd.Parameters.AddWithValue("@Anio", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Datos.Modalidad)
            SqlCmd.Parameters.AddWithValue("@Turno", Datos.Turno)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Seccion", Datos.Seccion)
            SqlCmd.Parameters.AddWithValue("@AS", Datos.AbS)
            SqlCmd.Parameters.AddWithValue("@F", Datos.F)
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"
        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
        Return Rpta
    End Function
    Public Function Eliminar(Id As Int32) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "M_Inicial_Eliminar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Id_M_Inicial", Id)
            SqlCmd.ExecuteNonQuery()
            Rpta = "Ok"
        Catch ex As Exception
            Rpta = New Utilidades().Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
        Return Rpta
    End Function

    Public Function Buscar(TextoBuscar As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "M_Inicial_Buscar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@TextoBuscar", TextoBuscar)

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
