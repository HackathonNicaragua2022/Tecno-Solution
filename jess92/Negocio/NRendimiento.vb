Public Class NRendimiento
    Public Function Insertar_Rendimiento_Primaria(ID_Corte As Int32, Año As Int32, Grado As String, Nivel As Int32, modalidad As String, Corte As String, MI_AS As Int32, MI_F As Int32, MA_AS As Int32, MA_F As Int32,
                   Aprovados_Limpios_AS As Int32, Aprovados_Limpios_F As Int32, Aplasados_AS As Int32, Aplasados_F As Int32, Aplasados_1a2_AS As Int32, Aplasados_1a2_F As Int32, Aplasados_3_a_mas_AS As Int32,
                   Aplasados_3_a_mas_F As Int32, Apr_L_Matematica_AS As Int32, Apr_L_Matematica_F As Int32, Apr_L_Español_AS As Int32, Apr_L_Español_F As Int32, Apr_L_Ingles_AS As Int32,
                   Apr_L_Ingles_F As Int32, Apr_L_TAC_AS As Int32, Apr_L_TAC_F As Int32, Apr_L_CV_AS As Int32, Apr_L_CV_F As Int32, Apr_L_EEFF_AS As Int32, Apr_L_EEFF_F As Int32, Apr_L_EAEP_AS As Int32,
                   Apr_L_EAEP_F As Int32, Apr_L_CCNN_AS As Int32, Apr_L_CCNN_F As Int32, Apr_L_CCSS_AS As Int32, Apr_L_CCSS_F As Int32, Apr_L_CONOCIENDO_MI_M_AS As Int32, Apr_L_CONOCIENDO_MI_M_F As Int32,
                   Apr_L_DERECHO_DIGNIDAD_AS As Int32, Apr_L_DERECHO_DIGNIDAD_F As Int32, AA_1_AS As Int32, AA_1_F As Int32, AS_1_AS As Int32, AS_1_F As Int32, AF_1_AS As Int32, AF_1_F As Int32, AI_1_AS As Int32,
                   AI_1_F As Int32, AA_2_AS As Int32, AA_2_F As Int32, AS_2_AS As Int32, AS_2_F As Int32, AF_2_AS As Int32, AF_2_F As Int32, AI_2_AS As Int32, AI_2_F As Int32, AA_3_A_6_AS As Int32, AA_3_A_6_F As Int32,
                   AS_3_A_6_AS As Int32, AS_3_A_6_F As Int32, AF_3_A_6_AS As Int32, AF_3_A_6_F As Int32, AI_3_A_6_AS As Int32, AI_3_A_6_F As Int32)
        Dim obj As New DRendimiento
        obj.ID_Corte = ID_Corte
        obj.Año = Año
        obj.Grado = Grado
        obj.Nivel = Nivel
        obj.modalidad = modalidad
        obj.Corte = Corte
        obj.MI_AS = MI_AS
        obj.MI_F = MI_F
        obj.MA_AS = MA_AS
        obj.MA_F = MA_F
        obj.Aprovados_Limpios_AS = Aprovados_Limpios_AS
        obj.Aprovados_Limpios_F = Aprovados_Limpios_F
        obj.Aplasados_AS = Aplasados_AS
        obj.Aplasados_F = Aplasados_F
        obj.Aplasados_1a2_AS = Aplasados_1a2_AS
        obj.Aplasados_1a2_F = Aplasados_1a2_F
        obj.Aplasados_3_a_mas_AS = Aplasados_3_a_mas_AS
        obj.Aplasados_3_a_mas_F = Aplasados_3_a_mas_F
        obj.Apr_L_Matematica_AS = Apr_L_Matematica_AS
        obj.Apr_L_Matematica_F = Apr_L_Matematica_F
        obj.Apr_L_Español_AS = Apr_L_Español_AS
        obj.Apr_L_Español_F = Apr_L_Español_F
        obj.Apr_L_Ingles_AS = Apr_L_Ingles_AS
        obj.Apr_L_Ingles_F = Apr_L_Ingles_F
        obj.Apr_L_TAC_AS = Apr_L_TAC_AS
        obj.Apr_L_TAC_F = Apr_L_TAC_F
        obj.Apr_L_CV_AS = Apr_L_CV_AS
        obj.Apr_L_CV_F = Apr_L_CV_F
        obj.Apr_L_EEFF_AS = Apr_L_EEFF_AS
        obj.Apr_L_EEFF_F = Apr_L_EEFF_F
        obj.Apr_L_EAEP_AS = Apr_L_EAEP_AS
        obj.Apr_L_EAEP_F = Apr_L_EAEP_F
        obj.Apr_L_CCNN_AS = Apr_L_CCNN_AS
        obj.Apr_L_CCNN_F = Apr_L_CCNN_F
        obj.Apr_L_CCSS_AS = Apr_L_CCSS_AS
        obj.Apr_L_CCSS_F = Apr_L_CCSS_F
        obj.Apr_L_CONOCIENDO_MI_M_AS = Apr_L_CONOCIENDO_MI_M_AS
        obj.Apr_L_CONOCIENDO_MI_M_F = Apr_L_CONOCIENDO_MI_M_F
        obj.Apr_L_DERECHO_DIGNIDAD_AS = Apr_L_DERECHO_DIGNIDAD_AS
        obj.Apr_L_DERECHO_DIGNIDAD_F = Apr_L_DERECHO_DIGNIDAD_F
        obj.AA_1_AS = AA_1_AS
        obj.AA_1_F = AA_1_F
        obj.AS_1_AS = AS_1_AS
        obj.AS_1_F = AS_1_F
        obj.AF_1_AS = AF_1_AS
        obj.AF_1_F = AF_1_F
        obj.AI_1_AS = AI_1_AS
        obj.AI_1_F = AI_1_F
        obj.AA_2_AS = AA_2_AS
        obj.AA_2_F = AA_2_F
        obj.AS_2_AS = AS_2_AS
        obj.AS_2_F = AS_2_F
        obj.AF_2_AS = AF_2_AS
        obj.AF_2_F = AF_2_F
        obj.AI_2_AS = AI_2_AS
        obj.AI_2_F = AI_2_F
        obj.AA_3_A_6_AS = AA_3_A_6_AS
        obj.AA_3_A_6_F = AA_3_A_6_F
        obj.AS_3_A_6_AS = AS_3_A_6_AS
        obj.AS_3_A_6_F = AS_3_A_6_F
        obj.AF_3_A_6_AS = AF_3_A_6_AS
        obj.AF_3_A_6_F = AF_3_A_6_F
        obj.AI_3_A_6_AS = AI_3_A_6_AS
        obj.AI_3_A_6_F = AI_3_A_6_F
        Return obj.Insertar_Rendimiento_Primaria(obj)
    End Function
    Public Function Calcular_Rendimiento(idCorte As Int32, año As Int32, Modalidad As String)
        Return New DRendimiento().Calcular_Rendimiento(idCorte, año, Modalidad)
    End Function

    Public Function Validar_Matricula_Inicial(Año As Int32, Modalidad As String) As String
        Return New DRendimiento().Validar_Matricula_Inicial(Año, Modalidad)
    End Function

End Class
