Imports System.Data, System.Data.SqlClient
Public Class DRendimiento
    Public Nivel, modalidad, Corte As String
    Public ID_Corte, Año, Grado, MI_AS, MI_F, MA_AS, MA_F, Aprovados_Limpios_AS As Int32
    Public Aprovados_Limpios_F, Aplasados_AS, Aplasados_F, Aplasados_1a2_AS, Aplasados_1a2_F, Aplasados_3_a_mas_AS As Int32
    Public Aplasados_3_a_mas_F, Apr_L_Matematica_AS, Apr_L_Matematica_F, Apr_L_Español_AS, Apr_L_Español_F, Apr_L_Ingles_AS As Int32
    Public Apr_L_Ingles_F, Apr_L_TAC_AS, Apr_L_TAC_F As Int32
    Public Apr_L_CV_AS, Apr_L_CV_F, Apr_L_EEFF_AS, Apr_L_EEFF_F, Apr_L_EAEP_AS, Apr_L_EAEP_F, Apr_L_CCNN_AS, Apr_L_CCNN_F, Apr_L_CCSS_AS As Int32
    Public Apr_L_CCSS_F, Apr_L_CONOCIENDO_MI_M_AS, Apr_L_CONOCIENDO_MI_M_F, Apr_L_DERECHO_DIGNIDAD_AS, Apr_L_DERECHO_DIGNIDAD_F As Int32
    Public AA_1_AS, AA_1_F, AS_1_AS, AS_1_F, AF_1_AS, AF_1_F, AI_1_AS, AI_1_F, AA_2_AS, AA_2_F, AS_2_AS, AS_2_F, AF_2_AS, AF_2_F, AI_2_AS, AI_2_F, AA_3_A_6_AS As Int32
    Public AA_3_A_6_F, AS_3_A_6_AS, AS_3_A_6_F, AF_3_A_6_AS, AF_3_A_6_F, AI_3_A_6_AS, AI_3_A_6_F As Int32


    Public Sub New()
    End Sub
    Public Sub New(ID_Corte As Int32, Año As Int32, Grado As String, Nivel As Int32, modalidad As String, Corte As String, MI_AS As Int32, MI_F As Int32, MA_AS As Int32, MA_F As Int32,
                   Aprovados_Limpios_AS As Int32, Aprovados_Limpios_F As Int32, Aplasados_AS As Int32, Aplasados_F As Int32, Aplasados_1a2_AS As Int32, Aplasados_1a2_F As Int32, Aplasados_3_a_mas_AS As Int32,
                   Aplasados_3_a_mas_F As Int32, Apr_L_Matematica_AS As Int32, Apr_L_Matematica_F As Int32, Apr_L_Español_AS As Int32, Apr_L_Español_F As Int32, Apr_L_Ingles_AS As Int32,
                   Apr_L_Ingles_F As Int32, Apr_L_TAC_AS As Int32, Apr_L_TAC_F As Int32, Apr_L_CV_AS As Int32, Apr_L_CV_F As Int32, Apr_L_EEFF_AS As Int32, Apr_L_EEFF_F As Int32, Apr_L_EAEP_AS As Int32,
                   Apr_L_EAEP_F As Int32, Apr_L_CCNN_AS As Int32, Apr_L_CCNN_F As Int32, Apr_L_CCSS_AS As Int32, Apr_L_CCSS_F As Int32, Apr_L_CONOCIENDO_MI_M_AS As Int32, Apr_L_CONOCIENDO_MI_M_F As Int32,
                   Apr_L_DERECHO_DIGNIDAD_AS As Int32, Apr_L_DERECHO_DIGNIDAD_F As Int32, AA_1_AS As Int32, AA_1_F As Int32, AS_1_AS As Int32, AS_1_F As Int32, AF_1_AS As Int32, AF_1_F As Int32, AI_1_AS As Int32,
                   AI_1_F As Int32, AA_2_AS As Int32, AA_2_F As Int32, AS_2_AS As Int32, AS_2_F As Int32, AF_2_AS As Int32, AF_2_F As Int32, AI_2_AS As Int32, AI_2_F As Int32, AA_3_A_6_AS As Int32, AA_3_A_6_F As Int32,
                   AS_3_A_6_AS As Int32, AS_3_A_6_F As Int32, AF_3_A_6_AS As Int32, AF_3_A_6_F As Int32, AI_3_A_6_AS As Int32, AI_3_A_6_F As Int32)
        Me.ID_Corte = ID_Corte
        Me.Año = Año
        Me.Grado = Grado
        Me.Nivel = Nivel
        Me.modalidad = modalidad
        Me.Corte = Corte
        Me.MI_AS = MI_AS
        Me.MI_F = MI_F
        Me.MA_AS = MA_AS
        Me.MA_F = MA_F
        Me.Aprovados_Limpios_AS = Aprovados_Limpios_AS
        Me.Aprovados_Limpios_F = Aprovados_Limpios_F
        Me.Aplasados_AS = Aplasados_AS
        Me.Aplasados_F = Aplasados_F
        Me.Aplasados_1a2_AS = Aplasados_1a2_AS
        Me.Aplasados_1a2_F = Aplasados_1a2_F
        Me.Aplasados_3_a_mas_AS = Aplasados_3_a_mas_AS
        Me.Aplasados_3_a_mas_F = Aplasados_3_a_mas_F
        Me.Apr_L_Matematica_AS = Apr_L_Matematica_AS
        Me.Apr_L_Matematica_F = Apr_L_Matematica_F
        Me.Apr_L_Español_AS = Apr_L_Español_AS
        Me.Apr_L_Español_F = Apr_L_Español_F
        Me.Apr_L_Ingles_AS = Apr_L_Ingles_AS
        Me.Apr_L_Ingles_F = Apr_L_Ingles_F
        Me.Apr_L_TAC_AS = Apr_L_TAC_AS
        Me.Apr_L_TAC_F = Apr_L_TAC_F
        Me.Apr_L_CV_AS = Apr_L_CV_AS
        Me.Apr_L_CV_F = Apr_L_CV_F
        Me.Apr_L_EEFF_AS = Apr_L_EEFF_AS
        Me.Apr_L_EEFF_F = Apr_L_EEFF_F
        Me.Apr_L_EAEP_AS = Apr_L_EAEP_AS
        Me.Apr_L_EAEP_F = Apr_L_EAEP_F
        Me.Apr_L_CCNN_AS = Apr_L_CCNN_AS
        Me.Apr_L_CCNN_F = Apr_L_CCNN_F
        Me.Apr_L_CCSS_AS = Apr_L_CCSS_AS
        Me.Apr_L_CCSS_F = Apr_L_CCSS_F
        Me.Apr_L_CONOCIENDO_MI_M_AS = Apr_L_CONOCIENDO_MI_M_AS
        Me.Apr_L_CONOCIENDO_MI_M_F = Apr_L_CONOCIENDO_MI_M_F
        Me.Apr_L_DERECHO_DIGNIDAD_AS = Apr_L_DERECHO_DIGNIDAD_AS
        Me.Apr_L_DERECHO_DIGNIDAD_F = Apr_L_DERECHO_DIGNIDAD_F
        Me.AA_1_AS = AA_1_AS
        Me.AA_1_F = AA_1_F
        Me.AS_1_AS = AS_1_AS
        Me.AS_1_F = AS_1_F
        Me.AF_1_AS = AF_1_AS
        Me.AF_1_F = AF_1_F
        Me.AI_1_AS = AI_1_AS
        Me.AI_1_F = AI_1_F
        Me.AA_2_AS = AA_2_AS
        Me.AA_2_F = AA_2_F
        Me.AS_2_AS = AS_2_AS
        Me.AS_2_F = AS_2_F
        Me.AF_2_AS = AF_2_AS
        Me.AF_2_F = AF_2_F
        Me.AI_2_AS = AI_2_AS
        Me.AI_2_F = AI_2_F
        Me.AA_3_A_6_AS = AA_3_A_6_AS
        Me.AA_3_A_6_F = AA_3_A_6_F
        Me.AS_3_A_6_AS = AS_3_A_6_AS
        Me.AS_3_A_6_F = AS_3_A_6_F
        Me.AF_3_A_6_AS = AF_3_A_6_AS
        Me.AF_3_A_6_F = AF_3_A_6_F
        Me.AI_3_A_6_AS = AI_3_A_6_AS
        Me.AI_3_A_6_F = AI_3_A_6_F
    End Sub

    Public Function Insertar_Rendimiento_Primaria(Datos As DRendimiento) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Rendimiento_Academico_Primaria_Insertar_Lote"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Me.ID_Corte", Datos.ID_Corte)
            SqlCmd.Parameters.AddWithValue("@Año", Datos.Año)
            SqlCmd.Parameters.AddWithValue("@Grado", Datos.Grado)
            SqlCmd.Parameters.AddWithValue("@Nivel", Datos.Nivel)
            SqlCmd.Parameters.AddWithValue("@modalidad", Datos.modalidad)
            SqlCmd.Parameters.AddWithValue("@Corte", Datos.Corte)
            SqlCmd.Parameters.AddWithValue("@MI_AS", Datos.MI_AS)
            SqlCmd.Parameters.AddWithValue("@MI_F", Datos.MI_F)
            SqlCmd.Parameters.AddWithValue("@MA_AS", Datos.MA_AS)
            SqlCmd.Parameters.AddWithValue("@MA_F", Datos.MA_F)
            SqlCmd.Parameters.AddWithValue("@Aprovados_Limpios_AS", Datos.Aprovados_Limpios_AS)
            SqlCmd.Parameters.AddWithValue("@Aprovados_Limpios_F", Datos.Aprovados_Limpios_F)
            SqlCmd.Parameters.AddWithValue("@Aplasados_AS", Datos.Aplasados_AS)
            SqlCmd.Parameters.AddWithValue("@Aplasados_F", Datos.Aplasados_F)
            SqlCmd.Parameters.AddWithValue("@Aplasados_1a2_AS", Datos.Aplasados_1a2_AS)
            SqlCmd.Parameters.AddWithValue("@Aplasados_1a2_F", Datos.Aplasados_1a2_F)
            SqlCmd.Parameters.AddWithValue("@Aplasados_3_a_mas_AS", Datos.Aplasados_3_a_mas_AS)
            SqlCmd.Parameters.AddWithValue("@Aplasados_3_a_mas_F", Datos.Aplasados_3_a_mas_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Matematica_AS", Datos.Apr_L_Matematica_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Matematica_F", Datos.Apr_L_Matematica_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Español_AS", Datos.Apr_L_Español_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Español_F", Datos.Apr_L_Español_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Ingles_AS", Datos.Apr_L_Ingles_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_Ingles_F", Datos.Apr_L_Ingles_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_TAC_AS", Datos.Apr_L_TAC_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_TAC_F", Datos.Apr_L_TAC_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CV_AS", Datos.Apr_L_CV_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CV_F", Datos.Apr_L_CV_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_EEFF_AS", Datos.Apr_L_EEFF_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_EEFF_F", Datos.Apr_L_EEFF_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_EAEP_AS", Datos.Apr_L_EAEP_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_EAEP_F", Datos.Apr_L_EAEP_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CCNN_AS", Datos.Apr_L_CCNN_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CCNN_F", Datos.Apr_L_CCNN_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CCSS_AS", Datos.Apr_L_CCSS_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CCSS_F", Datos.Apr_L_CCSS_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CONOCIENDO_MI_M_AS", Datos.Apr_L_CONOCIENDO_MI_M_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_CONOCIENDO_MI_M_F", Datos.Apr_L_CONOCIENDO_MI_M_F)
            SqlCmd.Parameters.AddWithValue("@Apr_L_DERECHO_DIGNIDAD_AS", Datos.Apr_L_DERECHO_DIGNIDAD_AS)
            SqlCmd.Parameters.AddWithValue("@Apr_L_DERECHO_DIGNIDAD_F", Datos.Apr_L_DERECHO_DIGNIDAD_F)
            SqlCmd.Parameters.AddWithValue("@AA_1_AS", Datos.AA_1_AS)
            SqlCmd.Parameters.AddWithValue("@AA_1_F", Datos.AA_1_F)
            SqlCmd.Parameters.AddWithValue("@AS_1_AS", Datos.AS_1_AS)
            SqlCmd.Parameters.AddWithValue("@AS_1_F", Datos.AS_1_F)
            SqlCmd.Parameters.AddWithValue("@AF_1_AS", Datos.AF_1_AS)
            SqlCmd.Parameters.AddWithValue("@AF_1_F", Datos.AF_1_F)
            SqlCmd.Parameters.AddWithValue("@AI_1_AS", Datos.AI_1_AS)
            SqlCmd.Parameters.AddWithValue("@AI_1_F", Datos.AI_1_F)
            SqlCmd.Parameters.AddWithValue("@AA_2_AS", Datos.AA_2_AS)
            SqlCmd.Parameters.AddWithValue("@AA_2_F", Datos.AA_2_F)
            SqlCmd.Parameters.AddWithValue("@AS_2_AS", Datos.AS_2_AS)
            SqlCmd.Parameters.AddWithValue("@AS_2_F", Datos.AS_2_F)
            SqlCmd.Parameters.AddWithValue("@AF_2_AS", Datos.AF_2_AS)
            SqlCmd.Parameters.AddWithValue("@AF_2_F", Datos.AF_2_F)
            SqlCmd.Parameters.AddWithValue("@AI_2_AS", Datos.AI_2_AS)
            SqlCmd.Parameters.AddWithValue("@AI_2_F", Datos.AI_2_F)
            SqlCmd.Parameters.AddWithValue("@AA_3_A_6_AS", Datos.AA_3_A_6_AS)
            SqlCmd.Parameters.AddWithValue("@AA_3_A_6_F", Datos.AA_3_A_6_F)
            SqlCmd.Parameters.AddWithValue("@AS_3_A_6_AS", Datos.AS_3_A_6_AS)
            SqlCmd.Parameters.AddWithValue("@AS_3_A_6_F", Datos.AS_3_A_6_F)
            SqlCmd.Parameters.AddWithValue("@AF_3_A_6_AS", Datos.AF_3_A_6_AS)
            SqlCmd.Parameters.AddWithValue("@AF_3_A_6_F", Datos.AF_3_A_6_F)
            SqlCmd.Parameters.AddWithValue("@AI_3_A_6_AS", Datos.AI_3_A_6_AS)
            SqlCmd.Parameters.AddWithValue("@AI_3_A_6_F", Datos.AI_3_A_6_F)


            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""
            'Dim msg As Boolean
            Dim i As Integer = SqlCmd.ExecuteNonQuery
            If i = 1 Then
                Rpta = "Ok"
            End If
        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Validar_Matricula_Inicial(Año As Int32, Modalidad As String) As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Validar_si_existe_M_Inicial"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""

            SqlCmd.Parameters.AddWithValue("@Anio", Año)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)



            '       Ejecución del Comando
            '""""""""""""""""""""""""""""""""""""""

            Dim i As Int32 = SqlCmd.ExecuteScalar
            If i = 1 Then Rpta = "Ok"
            If i = 0 Then Rpta = "no todos los grados tienen asignada la matrícula inicial para esta modalidad."

        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta
    End Function

    Public Function Calcular_Rendimiento(id_Corte As Int32, año As Int32, Modalidad As String) As DataTable
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Rendimiento_Primaria_Calcular"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            '       Parametros de la funcion
            '""""""""""""""""""""""""""""""""""""""""
            SqlCmd.Parameters.AddWithValue("@Id_Corte", id_Corte)
            SqlCmd.Parameters.AddWithValue("@Modalidad", Modalidad)
            SqlCmd.Parameters.AddWithValue("@Año", año)



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

End Class
