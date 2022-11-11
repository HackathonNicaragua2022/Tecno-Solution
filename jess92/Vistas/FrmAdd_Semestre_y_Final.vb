Imports System.Data, System.Data.SqlClient
Imports System.Data.OleDb

Public Class FrmAdd_Semestre_y_Final
    Dim utilidades As New Utilidades
    Private Sub FrmAdd_Semestre_y_Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblCentro.Text = Escuela
        CargarCorte()
        Me.TxtAño.Value = Year(Now)
    End Sub
    Sub CargarCorte()
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Sp_Cortes_Mostrar"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)
            CmbCorte.DataSource = Rpta
            CmbCorte.DisplayMember = "Nombre"
            CmbCorte.ValueMember = "IdCorte"
            CmbCorte.Refresh()

        Catch ex As Exception
            utilidades.Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
    End Sub

    Sub Buscar_Notas()
        Dim grado As String = CmbGrado.Text.Trim
        Dim Modalidad As String = CmbModalidad.Text.Trim
        Dim año As Int32 = TxtAño.Value
        Dim evaluacion As String = CmbCorte.Text.Trim.ToUpper
        If evaluacion.Equals("I SEMESTRE") Or evaluacion.Equals("I") Then
            evaluacion = "I"
        ElseIf evaluacion.Equals("II SEMESTRE") Or evaluacion.Equals("II") Then
            evaluacion = "II"
        Else
            evaluacion = "FINAL"
        End If

        Try
            'Dim id_Evaluacion As Int32 = CmbCorte.SelectedValue
            If grado = "Primero" Or grado = "Segundo" Then
                If Not evaluacion.Equals("FINAL") Then
                    DataListado.DataSource = New NNotas().Mostrar_Semestre_Primero_Segundo(grado, año, evaluacion)
                    DataListado.Refresh()


                Else
                    ' MsgBox(grado + " " + año.ToString)
                    DataListado.DataSource = New NNotas().Mostrar_Final_Primero_Segundo(grado, año)
                    DataListado.Refresh()

                End If
                'MsgBox("Estamos en primero y segundo")
            End If

            If grado = "Tercero" Or grado = "Cuarto" Or grado = "Quinto" Or grado = "Sexto" Then
                If Not evaluacion.Equals("FINAL") Then
                    DataListado.DataSource = New NNotas().Mostrar_Semestre_Tercero_Sexto(grado, año, evaluacion)
                    DataListado.Refresh()
                Else
                    DataListado.DataSource = New NNotas().Mostrar_Final_Tercero_Sexto(grado, año)
                    DataListado.Refresh()
                End If
                'MsgBox("Estamos en tercero a sexto")
            End If

            If grado = "SEPTIMO" Or grado = "OCTAVO" Or grado = "NOVENO" Or grado = "DÉCIMO" Or grado = "UNDÉCIMO" Then
                If Not evaluacion.Equals("FINAL") Then
                    DataListado.DataSource = New NNotas().Mostrar_Semestre_Secundaria(grado, año, evaluacion)
                    DataListado.Refresh()
                Else
                    DataListado.DataSource = New NNotas().Mostrar_Final_Secundaria(grado, año)
                    DataListado.Refresh()
                End If
                ' MsgBox("Estamos en Secundaria")
            End If
        Catch ex As Exception
            'utilidades.Mensaje(ex.Message, True)
        End Try


    End Sub

    Private Sub CmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado.SelectedIndexChanged
        Buscar_Notas()
    End Sub

    Private Sub CmbCorte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCorte.SelectedIndexChanged
        Buscar_Notas()
    End Sub

    Private Sub TxtAño_ValueChanged(sender As Object, e As EventArgs) Handles TxtAño.ValueChanged
        Buscar_Notas()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Insertar()
    End Sub
    Sub Insertar()
        Dim Col_Name As String = ""
        Dim Col_Index As Int32
        Dim Asignatura As String = ""
        Dim rpta As String = ""
        Dim año As Int32 = DateAndTime.Year(Now)
        Dim Id_Alumno As Int32 = 0
        Dim Id_Docente As Int32
        Dim Id_Corte As Int32 = CmbCorte.SelectedValue
        Dim Nivel As String = CmbGrado.Text.Trim
        Dim Nota As Int32 = 0
        Dim Contador As Int32 = 0

        For Each col As DataGridViewColumn In DataListado.Columns
            Col_Name = col.Name.ToString.Trim
            Col_Index = col.Index
            Asignatura = Col_Name
            For Each row As DataGridViewRow In DataListado.Rows
                Try
                    If IsNumeric(row.Cells(Col_Index).Value) And Not Col_Name.Equals("IdDocente") And Not Col_Name.Equals("IdAlumno") And Not Col_Name.Equals("PROMEDIO") Then
                        If row.Cells(Col_Index).Value >= 0 And row.Cells(Col_Index).Value <= 100 Then
                            Id_Alumno = row.Cells(4).Value
                            Id_Docente = row.Cells(5).Value
                            If Id_Alumno > 0 Then
                                Nota = row.Cells(Col_Index).Value

                                If Nota > 0 Then
                                    Try
                                        rpta = New NNotas().Insertar_Nota_Lote(Id_Alumno, Id_Corte, Asignatura, Id_Docente, Nivel, año, Nota)
                                        If rpta.Equals("Ok") Then Contador += 1
                                    Catch ex As Exception
                                        row.DefaultCellStyle.ForeColor = Color.Red
                                    End Try

                                End If

                            End If
                        End If
                    End If
                Catch ex As Exception
                    row.DefaultCellStyle.ForeColor = Color.Red
                End Try
            Next
        Next
        If Contador > 0 Then
            'utilidades.Mensaje("Ocurrierón " + Contador.ToString + " errores de inserción.")
        End If
        utilidades.Mensaje("Registros Insertados.")
    End Sub

    Private Sub BtnCalcularRendimiento_Click(sender As Object, e As EventArgs) Handles BtnCalcularRendimiento.Click
        Me.DtRendimiento.DataSource = New NRendimiento().Calcular_Rendimiento(CmbCorte.SelectedValue, 2021, CmbModalidad.Text.Trim)
        Me.DtRendimiento.Refresh()
    End Sub

    Private Sub BtnCargarNotas_Click(sender As Object, e As EventArgs) Handles BtnCargarNotas.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivo"
            .Filter = "Archivo Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Cargar_Datos(.FileName, DtNotas)
            End If
            utilidades.Alternar_Color_DatagridView(DtNotas)
            LblRegistros.Text = "Total de Registros: " + DtNotas.Rows.Count.ToString
        End With
        LblEstado.Visible = False
        LblErrores.Visible = False
    End Sub
    Public Function Cargar_Datos(ByRef path As String, ByVal Datagrid As DataGridView)
        Try
            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            Dim Hoja As String = InputBox("¿Cual es el nombre de la Hoja del libro de Excel que desea cargar?", "Fuente de datos", "Hoja1")
            If Hoja = String.Empty Then
                Exit Function
            End If
            Dim Cmd As New OleDbCommand("Select * From [" + Hoja.Trim + "$]")
            Dim Ds As New DataSet
            Dim Da As New OleDbDataAdapter
            Dim Dt As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            Datagrid.Columns.Clear()
            Datagrid.DataSource = Dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function
    Function TRANSFORMAR(NOTA As String) As Int32
        Dim RPTA As Int32
        If NOTA = "AA" Then RPTA = 95
        If NOTA = "AS" Then RPTA = 85
        If NOTA = "AF" Then RPTA = 65
        If NOTA = "AI" Then RPTA = 55

        Return RPTA
    End Function
    Function Convertir_Nota(Asignatura As String, Nota As String) As Int32
        Dim rpta As Int32
        Try
            If Asignatura.Equals("EAEP") Or Asignatura.Equals("TAC") Or Asignatura.Equals("DERECHO Y DIGNIDAD DE LA MUJER") Or Asignatura.Equals("EE FF") Then
                rpta = TRANSFORMAR(Nota)
            ElseIf IsNumeric(Nota) Then
                rpta = Convert.ToInt32(Nota)
            Else
                rpta = 0
            End If
        Catch ex As Exception

        End Try
        Return rpta
    End Function
    Function Insertar_Notas() As String
        Dim Contador As Int32 = 0
        Dim rpta As String = ""
        Dim rpt As String = ""
        Dim Corte As String
        Dim Asignatura As String
        Dim CodigoAlumno As String
        Dim IdDocente As Int32
        Dim Nivel As String
        Dim Anio As Int32
        Dim Nota As Int32
        Dim Col_Name As String = ""
        Dim Col_Index As Int32
        Dim Errores As Int32 = 0
        Dim Estudiante As String = ""
        Try
            ' utilidades.Mensaje("Insertando Notas...")
            LblEstado.Visible = True
            LblEstado.Text = "Insertando Notas..."
            If DtNotas.Rows.Count > 0 Then

                For Each col As DataGridViewColumn In DtNotas.Columns
                    Col_Name = col.Name.ToString.Trim
                    Col_Index = col.Index
                    Asignatura = Col_Name
                    LblEstado.Text = "Recorriendo la Columna " + Col_Name
                    For Each row As DataGridViewRow In DtNotas.Rows

                        LblEstado.Text = "Recorriendo la Fila " + row.Index.ToString

                        If IsNumeric(row.Cells(Col_Index).Value) And Not Col_Name.Equals("IdDocente") And Not Col_Name.Equals("PROMEDIO") And Not Col_Name.Equals("N") And Not Col_Name.Equals("Anio") Then 'thenAnd
                            'Not Col_Name.Equals("Docente Guia") And Not Col_Name.Equals("NOMBRES Y APELLIDOS") And Not Col_Name.Equals("CODIGO DEL ESTUDIANTE") And Not Col_Name.Equals("Corte") And
                            'Not Col_Name.Equals("Grado") And Not Col_Name.Equals("Turno") And Not Col_Name.Equals("Seccion") Then
                            If row.Cells(Col_Index).Value >= 0 And row.Cells(Col_Index).Value <= 100 Then
                                Try

                                    Corte = row.Cells(5).Value.ToString.Trim
                                    CodigoAlumno = row.Cells(4).Value
                                    IdDocente = row.Cells(1).Value
                                    Nivel = row.Cells(6).Value
                                    Anio = row.Cells(9).Value
                                    Estudiante = row.Cells(3).Value.ToString.Trim
                                    LblEstado.Text = "Verificando si el Id del docentes es valido"
                                    If IdDocente > 0 Then
                                        'Nota = Convertir_Nota(Asignatura, row.Cells(Col_Index).Value.ToString.Trim)
                                        Nota = row.Cells(Col_Index).Value
                                        If Nota > 0 Then
                                            Try
                                                LblEstado.Text = "Insertando " + Asignatura.ToString.Trim + " " + row.Index.ToString + " de " + DtNotas.Rows.Count.ToString + "..."
                                                rpta = New NNotas().Insertar_Nota_Por_Lote(CodigoAlumno, Corte, Asignatura.Trim, IdDocente, Nivel, Anio, Nota)
                                                If rpta.Equals("Ok") Then
                                                    Contador += 1
                                                    row.DefaultCellStyle.ForeColor = Color.DarkGreen
                                                Else
                                                    row.DefaultCellStyle.ForeColor = Color.Red
                                                    Errores += 1
                                                    LblErrores.Text = Errores.ToString + " al Intentar insertar. Descrición: " + rpta
                                                    LblErrores.Visible = True
                                                End If
                                            Catch ex As Exception
                                                utilidades.Mensaje(ex.Message, True)
                                            End Try
                                        End If
                                    Else
                                        LblEstado.Text = "Id del docentes no es valido " + IdDocente.ToString + " Para el estudiante " + Estudiante
                                    End If
                                Catch ex As Exception
                                    utilidades.Mensaje(ex.Message, True)
                                End Try
                            End If
                        Else
                            ' utilidades.Mensaje("No es Númerico " + row.Cells(Col_Index).Value.ToString)
                        End If

                    Next
                Next
            End If
        Catch ex As Exception
            utilidades.Mensaje(ex.Message, True)
        End Try
        Dim asiertos As Int32 = DtNotas.Rows.Count - Errores
        rpt = "Se lograrón Insertar " + asiertos.ToString + " de las diferntes asignaturas" + " y ocurrierón " + Errores.ToString
        Return rpt
    End Function
    Private Sub BtnGuardarNotas_Click(sender As Object, e As EventArgs) Handles BtnGuardarNotas.Click
        Insertar_Notas()
    End Sub

    Private Sub CmbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidad.SelectedIndexChanged

    End Sub
End Class