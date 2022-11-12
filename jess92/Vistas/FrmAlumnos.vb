'Imports CapaNegocio
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports SpreadsheetLight

Public Class FrmAlumnos
    Private IsNuevo As Boolean = False
    Private IsEditar As Boolean = False
    ' Private Proveedor As NProveedor
    Dim Utilidades As New Utilidades()


    Sub Habilitar_TXT(Valor As Boolean)
        Me.TxtNombres.ReadOnly = Not Valor
        Me.TxtApellidos.ReadOnly = Not Valor
        Me.CmbSexo.Enabled = Valor
        Me.DtNacimiento.Enabled = Valor
        Me.TxtCodigoMined.ReadOnly = Not Valor
    End Sub
    Sub Limpiar_Txt()
        Me.TxtNombres.Clear()
        Me.TxtApellidos.Clear()
        Me.CmbSexo.Text = ""
        Me.DtNacimiento.Value = Date.Now()
        Me.TxtCodigoMined.Clear()
    End Sub
    Sub Botones()
        If IsNuevo Or IsEditar Then
            Me.BtnNuevo.Enabled = False
            Me.BtnGuardar.Enabled = True
            Me.BtnEditar.Enabled = False
            Me.BtnCancelar.Enabled = True
        Else
            Me.BtnNuevo.Enabled = True
            Me.BtnGuardar.Enabled = False
            Me.BtnEditar.Enabled = True
            Me.BtnCancelar.Enabled = False
        End If
    End Sub
    Sub Buscar()

        If TxtBusquedaApellidos.Text = "" Then
            Me.Datalistado.DataSource = New Nalumnos().Buscar(TxtBusquedaNombre.Text)
        Else
            Me.Datalistado.DataSource = New Nalumnos().Buscar_Apellido(TxtBusquedaNombre.Text, TxtBusquedaApellidos.Text)
        End If
        Me.Datalistado.Refresh()
        Try
            If Datalistado.Rows.Count > 0 Then Ocultar_Columnas()
            Dim n As Int32 = 0
            For Each row As DataGridViewRow In Datalistado.Rows
                If row.Cells(5).Value.ToString.Trim = "F" Then
                    n += 1
                End If
            Next
            Me.LblTotal.Text = " Registros en total  -->  AS: " + Datalistado.Rows.Count.ToString + "  -  F: " + n.ToString
        Catch ex As Exception
            Try
                Me.LblTotal.Text = " Registros en total  -->  AS: " + Datalistado.Rows.Count.ToString
            Catch e As Exception

            End Try
        End Try

    End Sub
    Sub Ocultar_Columnas()
        Try
            Datalistado.Columns(0).Visible = False
            Datalistado.Columns(1).Visible = False
            'Datalistado.Columns(11).Visible = False
        Catch ex As Exception

        End Try

    End Sub
    Sub Mostrar_Error(Control As Control, Mensaje As String)
        EpError.SetError(Control, Mensaje)
        Me.ActiveControl = Control
    End Sub
    Function Validar() As Boolean
        Dim Rpta As Boolean
        EpError.Clear()
        Try
            If Me.TxtNombres.Text = String.Empty Then
                Mostrar_Error(TxtNombres, "Digite los nombres del Alumno.")
                Rpta = False
            ElseIf Me.TxtApellidos.Text = String.Empty Then
                Mostrar_Error(TxtApellidos, "Digite los apellidos del Alumno.")
                Rpta = False
            ElseIf Me.CmbSexo.Text = String.Empty Then
                Mostrar_Error(CmbSexo, "Especifique Sexo del Alumno.")
                Rpta = False
            ElseIf Me.DtNacimiento.Value >= Date.Now Then
                Mostrar_Error(DtNacimiento, "Especifique una fecha valida.")
                Rpta = False
            Else
                Rpta = True
            End If

            If Me.TxtNombres.Text <> String.Empty And Me.TxtApellidos.Text <> String.Empty And
            Me.CmbSexo.Text <> String.Empty And Me.DtNacimiento.Value < Date.Now Then
                Rpta = True
            End If

            If ChkLote.Checked = True Then
                Rpta = True
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
        Return Rpta
    End Function
    Function Insertar(Codigo_Mined As String, Nombres As String,
                      Apellidos As String, Sexo As String, Nacimiento As Date) As Int32
        Dim rpta As String = ""
        Try
            If Validar() = True Then
                If IsNuevo Then
                    rpta = New Nalumnos().Insertar(Codigo_Mined, Nombres, Apellidos, Sexo, Nacimiento)
                    If IsNumeric(rpta) Then
                        If Me.ChkLote.Checked = False Then
                            Utilidades.Mensaje("Registro ingresado con éxito.")
                        End If
                    End If

                ElseIf IsEditar Then
                    rpta = New Nalumnos().Editar(TxtIdAlumno.Text, Codigo_Mined, Nombres, Apellidos, Sexo, Nacimiento)

                    If rpta.Equals("OK") Then Utilidades.Mensaje("Registro actualizado con éxito.")
                End If
                If IsNumeric(rpta) Then
                    If Convert.ToInt32(rpta) > 0 Then
                        IsNuevo = False
                        IsEditar = False
                        Botones()
                        Habilitar_TXT(False)
                        Buscar()
                        Me.ActiveControl = BtnNuevo
                    End If
                Else
                    ' Utilidades.Mensaje(rpta)
                    rpta = "0"
                    IsNuevo = False
                    IsEditar = False
                    Botones()
                    Habilitar_TXT(False)
                    Buscar()
                    Me.ActiveControl = BtnNuevo
                End If

            End If
        Catch ex As Exception
            Utilidades.Mensaje(rpta, True)
        End Try

        Return rpta


    End Function
    Sub Eliminar_Alumno()
        Dim Alumno As New Nalumnos()
        Dim Rpta As String = ""
        Dim IsError As Boolean
        Dim TRM As Integer = 0
        Dim msg As String = "¿Desea elinar los siguientes Alumnos "

        For Each Row1 As DataGridViewRow In Datalistado.Rows
            If Row1.Cells(0).Value = True Then
                msg = msg + vbNewLine + Row1.Cells(2).Value
                TRM = TRM + 1
                'Me.Text = Me.Text + " " + Convert.ToString(Row1.Cells(1).Value)
            End If
        Next

        Dim Op As DialogResult
        If TRM > 0 Then
            Op = MessageBox.Show(msg + vbNewLine + vbNewLine + "Totalmente del sistema?", "Francisca Hernández", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            If Op = DialogResult.OK Then
                For Each Row As DataGridViewRow In Datalistado.Rows
                    If Row.Cells(0).Value = True Then
                        Rpta = Alumno.Eliminar(Val(Row.Cells(1).Value))
                        If Not Rpta.Equals("OK") Then
                            IsError = True
                        End If
                    End If
                Next
            End If
        Else
            Utilidades.Mensaje("Seleccione el Registro a eliminar", True)
            Exit Sub
        End If

        If IsError = True Then
            Utilidades.Mensaje("Ocurrierón errores al intentar eliminar los registros del sistema" + vbNewLine + vbNewLine + Rpta, True)
        ElseIf Op = Windows.Forms.DialogResult.OK Then
            Utilidades.Mensaje("Registros eliminados satisfactoriamente" + vbNewLine + Rpta, False)
            Me.chkEliminar.Checked = False
            Buscar()
        Else
            Me.chkEliminar.Checked = False
            Buscar()
        End If
    End Sub


    Private Sub FrmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TTMensaje.SetToolTip(TxtBusquedaNombre, "Forma de Búsqueda" + vbNewLine + "Nombres: 'Nombre_1 Nombre_2'" + vbNewLine + "Apellidos: 'Apellido_1 Apellido_2'" + vbNewLine +
                             "Nombre Completo: 'Nombre_1 Nombre_2 Apellido_1 Apellido_2'" + vbNewLine + "Código: 'ANSJ-9112008-4524994'" + vbNewLine +
                             "Modalidad: 'SECUNDARIA REGULAR, PRIMARIA REGULAR'" + vbNewLine +
                             "A detalle: 'Grado', Ejemplo: 'Septimo', Se filtraran los septimo de todos los años y Secciones." + vbNewLine +
                             "Grado - Sección: 'Septimo A' -> Se filtrara solo los septimo A de todos los Años." + vbNewLine +
                             "Grado - Sección - Año: 'Septimo A 2022' Se optendra la matricula actual del Septimo A del año especificado.")
        'TabPage3.Visible = False
        'TabPage4.Visible = False


        Utilidades.Alternar_Color_DatagridView(Datalistado)
        Utilidades.Alternar_Color_DatagridView(DtMatricula)
        Utilidades.Alternar_Color_DatagridView(DtListadoMatricula_Lotes)
        Utilidades.Alternar_Color_DatagridView(DtMatriculaAnterior)
        Utilidades.Alternar_Color_DatagridView(DtListado_Estudiantes)
        Me.LblTituloEdicion.Text = "Centro Educativo " + Empresa
        Me.LblTituloMatricula.Text = "Centro Educativo " + Empresa
        Me.TxtAño.Value = Year(Now)
        Me.TxtAño_Buscar_Listado.Value = Year(Now)
        Buscar()
        Ocultar_Columnas()
        Habilitar_TXT(False)
        Limpiar_Txt()
        IsNuevo = False
        IsEditar = False
        Botones()
        Me.ActiveControl = Me.TxtBusquedaNombre
        Me.Panel3.Height = 507

        If Acceso = "Docente" Then
            NotasToolStripMenuItem.Enabled = False
            EliminarMatriculaToolStripMenuItem.Enabled = False
            EditarMatrículaToolStripMenuItem.Enabled = False
            Me.TxtBusquedaNombre.Text = UserGrado.Trim + " " + UserSeccion.Trim + " " + Year(Now).ToString.Trim
            Me.TxtBusquedaNombre.ReadOnly = True
            Me.TxtBusquedaApellidos.ReadOnly = True
            Me.BtnCorregirMatricula.Visible = False
            TabControl1.TabPages.Item(2).Enabled = False
            TabControl1.TabPages.Item(3).Enabled = False
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim rpta As String = ""
        If Me.ChkLote.Checked = False Then
            rpta = Insertar(TxtCodigoMined.Text, TxtNombres.Text, TxtApellidos.Text,
                                                   CmbSexo.Text, DtNacimiento.Value)
        Else
            Dim IdAlumno As Int32

            For Each Row As DataGridViewRow In DtDatos.Rows
                '       Insertar los Datos a Alumnos
                '""""""""""""""""""""""""""""""""""""""""""""
                IsNuevo = True

                If Row.Cells(8).Value.ToString <> String.Empty And Row.Cells(2).Value.ToString <> String.Empty And
                    Row.Cells(3).Value.ToString <> String.Empty Then

                    IdAlumno = Insertar(Row.Cells(8).Value, (Row.Cells(2).Value + " " + Row.Cells(3).Value),
                                    (Row.Cells(4).Value + " " + Row.Cells(5).Value), Row.Cells(7).Value, Row.Cells(6).Value)

                    '             Matricular al Alumno
                    '""""""""""""""""""""""""""""""""""""""""""""
                    If ChkMatricular.Checked And IdAlumno > 0 Then
                        rpta = New NMatricula().Insertar(IdAlumno, Row.Cells(1).Value, Row.Cells(0).Value,
                                                                       Date.Now, DateAndTime.Year(Date.Now()))
                        If Not rpta.Equals("OK") Then
                            Utilidades.Mensaje(rpta, True)
                            IsNuevo = False
                            IsEditar = False
                            Botones()
                            Habilitar_TXT(False)
                            Buscar()
                            Me.ActiveControl = BtnNuevo
                            Exit For
                        End If
                    End If
                End If
            Next
            Me.ChkLote.Checked = False
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        IsNuevo = False
        IsEditar = True
        Botones()
        Habilitar_TXT(True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        IsNuevo = False
        IsEditar = False
        Botones()
        Habilitar_TXT(False)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        IsNuevo = True
        IsEditar = False
        Botones()
        Habilitar_TXT(True)
        Limpiar_Txt()
        Me.ActiveControl = Me.TxtNombres
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Eliminar_Alumno()
    End Sub

    Private Sub Datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        Try
            If e.ColumnIndex = Datalistado.Columns(0).Index Then
                Dim chk As New DataGridViewCheckBoxCell
                chk = Datalistado.Rows(e.RowIndex).Cells(0)
                chk.Value = Not Convert.ToBoolean(chk.Value)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Datalistado_CellDoubleClick() Handles Datalistado.CellDoubleClick
        Try
            Me.TxtIdAlumno.Text = Datalistado.CurrentRow.Cells(1).Value
            Me.TxtCodigoMined.Text = Datalistado.CurrentRow.Cells(2).Value
            Me.TxtNombres.Text = Datalistado.CurrentRow.Cells(3).Value
            Me.TxtApellidos.Text = Datalistado.CurrentRow.Cells(4).Value
            Me.CmbSexo.SelectedItem = Datalistado.CurrentRow.Cells(5).Value
            Me.DtNacimiento.Value = Datalistado.CurrentRow.Cells(6).Value


            TabControl1.SelectTab(1)
            BtnEditar.Enabled = True
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaNombre.TextChanged
        Buscar()
    End Sub


    Private Sub TxtBusquedaApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaApellidos.TextChanged
        Buscar()
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If Me.chkEliminar.Checked Then
            Datalistado.Columns(0).Visible = True
        Else
            Datalistado.Columns(0).Visible = False
        End If
    End Sub
    Sub Cargar_Matricula()
        Try
            If Datalistado.Rows.Count > 0 Then
                DtMatricula.DataSource = New Nalumnos().Buscar_Matricula(Datalistado.CurrentRow.Cells(1).Value)
                DtMatricula.Refresh()
                If DtMatricula.Rows.Count > 0 Then
                    DtMatricula.Columns(0).Visible = False
                    DtMatricula.Columns(1).Visible = False
                    Dim año As Int32 = 0
                    Dim grado As String = ""
                    If Acceso = "Docente" Then
                        For Each row As DataGridViewRow In DtMatricula.Rows
                            año = row.Cells(7).Value
                            If row.Cells(7).Value = Year(Now) Then
                                grado = row.Cells(4).Value.ToString.Trim
                                If row.Cells(4).Value.ToString.Trim = UserGrado.Trim Then
                                    NotasToolStripMenuItem.Enabled = True
                                    Exit For
                                Else
                                    NotasToolStripMenuItem.Enabled = False
                                End If
                            Else
                                NotasToolStripMenuItem.Enabled = False
                            End If
                        Next
                    End If
                    'Utilidades.Mensaje(Acceso + " " + grado + " " + año.ToString)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        Cargar_Matricula()


    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TabControl1.SelectTab(1)
        BtnNuevo_Click(sender, e)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Datalistado_CellDoubleClick()
        BtnEditar_Click(sender, e)
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Datalistado.Refresh()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub ChkLote_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLote.CheckedChanged
        If ChkLote.Checked Then
            Me.PnLote.Visible = True
            Me.PnLote.Enabled = True

            Me.Panel1.Enabled = False
            Me.Panel3.Height = 780
        Else
            Me.PnLote.Visible = False
            Me.PnLote.Enabled = False

            Me.Panel1.Enabled = True
            Me.Panel3.Height = 507
        End If
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivo"
            .Filter = "Archivo Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Cargar_Datos(.FileName, DtDatos)
            End If
            LblTotallote.Text = "Total de Registros: " + DtDatos.Rows.Count.ToString
        End With
    End Sub

    Private Sub MatricularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatricularToolStripMenuItem.Click


    End Sub

    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        Dim frm As New FrmNotas_Por_Alumno
        frm.id_alumno = Datalistado.CurrentRow.Cells(1).Value
        frm.ShowDialog()
    End Sub

    '________________________________________________________________
    '================================================================
    '                 Codigo para laMatrícula
    '________________________________________________________________


    Sub LimpiartxtMatricula()
        'Me.TxtIdAlumnoMatricula.Clear()
        Me.CmbGrado_Matricular.Text = ""
        Me.CmbGrado_Matricular.Text = ""
        CmbTurno.Text = ""
        CmbSeccion.Text = ""
    End Sub

    Sub DeshabilitarControles(Valor As Boolean)
        Me.TxtIdAlumnoMatricula.ReadOnly = Not Valor
        Me.CmbModalidadMatricular.Enabled = Not Valor
        Me.CmbGrado_Matricular.Enabled = Not Valor
        Me.CmbTurno.Enabled = Not Valor
        Me.CmbSeccion.Enabled = Not Valor

        If nuevo = True Or editar = True Then
            Me.BtnCancelarMatricula.Enabled = True
            Me.BtnNuevaMatricula.Enabled = False
            Me.BtnEditarMatricula.Enabled = False
            Me.BtnGuardarMatricula.Enabled = True
            Me.ChkLotesMatricula.Enabled = True
        Else
            Me.BtnCancelarMatricula.Enabled = False
            Me.BtnNuevaMatricula.Enabled = True
            Me.BtnEditarMatricula.Enabled = False
            Me.BtnGuardarMatricula.Enabled = False
            Me.ChkLotesMatricula.Enabled = False
        End If
    End Sub
    Dim nuevo, editar As Boolean

    Private Sub BtnCargarMatriculaLotes_Click(sender As Object, e As EventArgs) Handles BtnCargarMatriculaLotes.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivo"
            .Filter = "Archivo Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Load.Visible = True
                Cargar_Datos(.FileName, DtListadoMatricula_Lotes)
                Load.Visible = False
            End If
            Utilidades.Alternar_Color_DatagridView(DtListadoMatricula_Lotes)
            LblRegistros.Text = "Total de Registros: " + DtListadoMatricula_Lotes.Rows.Count.ToString
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.PnMatricula.Visible = False
    End Sub


    Private Sub BtnNuevaMatricula_Click(sender As Object, e As EventArgs) Handles BtnNuevaMatricula.Click
        LimpiartxtMatricula()
        nuevo = True
        editar = False
        DeshabilitarControles(False)
        ChkLotesMatricula.Visible = True
    End Sub
    Sub InsertarMatricula()
        If ValidarMatricula() = True Then
            Try
                Dim rpta As String = ""
                If nuevo = True Then
                    rpta = New NMatricula().Insertar_Id_Mined(TxtIdAlumnoMatricula.Text,
                                                                              CmbGrado_Matricular.Text.ToString.Trim,
                                                                              CmbModalidadMatricular.Text,
                                                                              Date.Now, DateAndTime.Year(Date.Now), CmbTurno.Text, CmbSeccion.Text)
                ElseIf editar = True Then
                    rpta = New NMatricula().Editar(Id_Matricula, ID_Alumno, CmbGrado_Matricular.Text, CmbModalidadMatricular.Text, CmbTurno.Text, CmbSeccion.Text)
                End If


                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Operación realizada con éxito")
                    PnMatricula.Visible = False
                    nuevo = False
                    editar = False
                    DeshabilitarControles(True)
                    Cargar_Matricula()
                Else
                    Utilidades.Mensaje(rpta)
                End If
            Catch ex As Exception
                Utilidades.Mensaje(ex.Message, True)
            End Try
        Else
            Utilidades.Mensaje("Error de validacion", True)
        End If
    End Sub
    Private Sub BtnGuardarMatricula_Click(sender As Object, e As EventArgs) Handles BtnGuardarMatricula.Click
        If ChkLotesMatricula.Checked = True Then
            Matricular_Por_Lotes()
        Else
            InsertarMatricula()
        End If
    End Sub

    Sub Matricular_Por_Lotes()
        Dim rpta As String = ""
        Dim Matriculados As Int32 = 0
        Dim ErroresenMatricula As Int32 = 0
        Dim Registrados As Int32 = 0
        Dim Errores_En_Registro As Int32 = 0
        Try
            If ChkLotesMatricula.Checked = True Then
                For Each Row As DataGridViewRow In DtListadoMatricula_Lotes.Rows

                    ' FORMATO en Exel
                    '   Modalidad |  Nivel  |	Sección |	Turno   |	Nombre1 |	Nombre2 |	Apellido1   |	Apellido2   |	Fecha de Nac    |	Sexo    |	Código Estudiante   |
                    ' FORMATO en Funcion
                    '   ID_MINED | GRADO | MODALIDAD | FECHA |AÑO | TURNO | SECCION |
                    rpta = New NMatricula().Insertar_Id_Mined(Row.Cells(10).Value, Row.Cells(1).Value, Row.Cells(0).Value, Date.Now, DateAndTime.Year(Date.Now), Row.Cells(3).Value, Row.Cells(2).Value)
                    If rpta.Equals("El alumno no existe en la base de datos") Then
                        'Ingresar los datos del alumno si no existe en el sistema
                        If ChkRegistrar.Checked = True Then
                            Dim RP As String = New Nalumnos().Insertar(Row.Cells(10).Value, (Row.Cells(4).Value.ToString.Trim + " " + Row.Cells(5).Value.ToString.Trim),
                                                                       (Row.Cells(6).Value.ToString.Trim + " " + Row.Cells(7).Value.ToString.Trim), Row.Cells(9).Value, Row.Cells(8).Value)
                            If Convert.ToInt32(RP) = 0 Then
                                Row.DefaultCellStyle.ForeColor = Color.Red
                                Errores_En_Registro += 1
                            Else
                                Registrados += 1
                                Dim rpt As String = New NMatricula().Insertar_Id_Mined(Row.Cells(10).Value, Row.Cells(1).Value, Row.Cells(0).Value, Date.Now, DateAndTime.Year(Date.Now), Row.Cells(3).Value, Row.Cells(2).Value)

                                If Not rpt.Equals("Ok") Then
                                    ErroresenMatricula += 1
                                    Row.DefaultCellStyle.ForeColor = Color.Red
                                ElseIf rpt.Equals("Ok") Then
                                    Row.DefaultCellStyle.ForeColor = Color.Blue
                                    Matriculados += 1
                                End If
                            End If

                        End If
                    ElseIf rpta.Equals("El alumno ya esta matriculado") Then
                        Row.DefaultCellStyle.ForeColor = Color.Green
                    ElseIf rpta.Equals("Ok") Then
                        Matriculados += 1
                    End If
                Next
                Utilidades.Mensaje("Estudiantes Registrados: " + Registrados.ToString + vbNewLine + "Estudiantes Matrículados: " + Matriculados.ToString +
                                   vbNewLine + "Errores en Registro al Sistema: " + Errores_En_Registro.ToString + vbNewLine + "Errores al Matrícular: " + ErroresenMatricula.ToString +
                                   vbNewLine + "Los errore y aciertos se represntan con el color del texto: Error de Ingreso y Matrícula color 'Rojo', Si ya existe en la base de datos Color 'Verde', Matrículado e Ingresado Color 'Azul'")
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try

    End Sub

    Private Sub BtnCancelarMatricula_Click(sender As Object, e As EventArgs) Handles BtnCancelarMatricula.Click
        nuevo = False
        editar = False
        LimpiartxtMatricula()
        DeshabilitarControles(True)
        PnMatricula.Visible = False
    End Sub
    Dim ID_Alumno As Int32
    Dim Id_Matricula As Int32
    Private Sub EditarMatrículaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarMatrículaToolStripMenuItem.Click
        Try
            If Me.DtMatricula.CurrentRow.Cells(0).Value > 0 Then
                ID_Alumno = Me.DtMatricula.CurrentRow.Cells(1).Value
                Me.Id_Matricula = Me.DtMatricula.CurrentRow.Cells(0).Value
                Me.TxtIdAlumnoMatricula.Text = Me.DtMatricula.CurrentRow.Cells(1).Value
                Me.CmbModalidadMatricular.Text = Me.DtMatricula.CurrentRow.Cells(3).Value
                Me.CmbGrado_Matricular.Text = Me.DtMatricula.CurrentRow.Cells(4).Value
                Me.CmbTurno.Text = Me.DtMatricula.CurrentRow.Cells(5).Value
                Me.CmbSeccion.Text = Me.DtMatricula.CurrentRow.Cells(6).Value


                Me.PnMatricula.Visible = True
                Me.PnMatricula.Dock = DockStyle.Fill
                editar = True
                nuevo = False
                DeshabilitarControles(False)
                ChkLotesMatricula.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChkLotesMatricula_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotesMatricula.CheckedChanged
        If Me.ChkLotesMatricula.Checked = True Then
            PnMatricula_Lotes.Visible = True
            Me.PnMatriculaNormal.Visible = False
        Else
            PnMatricula_Lotes.Visible = False
            Me.PnMatriculaNormal.Visible = True
        End If
    End Sub



    Private Sub PnMatricula_Resize(sender As Object, e As EventArgs) Handles PnMatricula.Resize
        pntitulo.Width = PnMatricula.Width
    End Sub

    Private Sub EliminarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMatriculaToolStripMenuItem.Click
        Dim op As Boolean = Utilidades.Preguntar("¿Desea eliminar el Registro de Matrícula?", "No", "Matrícula")
        If op = True Then
            Dim rpta As String = New NMatricula().Eliminar(DtMatricula.CurrentRow.Cells(0).Value)
            If rpta.Equals("Ok") Then
                Utilidades.Mensaje("Registro eliminado exitosamente")
                Cargar_Matricula()
            Else
                Utilidades.Mensaje(rpta, True)
            End If
        End If
    End Sub

    Private Sub CmbModalidadMatricular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModalidadMatricular.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbGrado_Matricular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGrado_Matricular.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSexo.KeyPress
        e.Handled = True
    End Sub

    Private Sub Datalistado_SelectionChanged(sender As Object, e As EventArgs) Handles Datalistado.SelectionChanged
        Cargar_Matricula()
        Try
            Dim n As Int32 = 0
            For Each row As DataGridViewRow In Datalistado.SelectedRows
                n += 1
            Next
            If n > 1 Then
                EditarMatriculaToolStripMenuItem.Visible = True
            Else
                EditarMatriculaToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pntitulo_Paint(sender As Object, e As PaintEventArgs) Handles pntitulo.Paint

    End Sub

    Private Sub BtnEditarMatricula_Click(sender As Object, e As EventArgs) Handles BtnEditarMatricula.Click

    End Sub

    Private Sub DtListadoMatricula_Lotes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtListadoMatricula_Lotes.CellContentClick

    End Sub

    Private Sub SuspenderMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspenderMatriculaToolStripMenuItem.Click
        Dim op As Boolean = Utilidades.Preguntar("¿Desea suspender la Matrícula?", "No", "Matrícula")
        If op = True Then
            Dim rpta As String = New NMatricula().Suspender(DtMatricula.CurrentRow.Cells(0).Value, DtMatricula.CurrentRow.Cells(1).Value, DtMatricula.CurrentRow.Cells(7).Value)
            If rpta.Equals("Ok") Then
                Utilidades.Mensaje("Operación realizado con Éxito.")
                Cargar_Matricula()
            Else
                ' Utilidades.Mensaje(rpta, True)
                Cargar_Matricula()
            End If
        End If
    End Sub

    Private Sub RestaurarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarMatriculaToolStripMenuItem.Click
        'MsgBox(DtMatricula.CurrentRow.Cells(8).Value + ".")
        If DtMatricula.CurrentRow.Cells(8).Value.ToString.Trim.Equals("Suspendido") Then
            Dim op As Boolean = Utilidades.Preguntar("¿Desea Restaurar la Matrícula?", "No", "Matrícula")
            If op = True Then
                Dim rpta As String = New NMatricula().Restaurar(DtMatricula.CurrentRow.Cells(0).Value, DtMatricula.CurrentRow.Cells(1).Value, DtMatricula.CurrentRow.Cells(7).Value)
                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Operación realizado con Éxito.")
                    Cargar_Matricula()
                Else
                    Utilidades.Mensaje(rpta, True)
                End If
            End If
        End If
    End Sub

    Private Sub Datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellDoubleClick

    End Sub

    Private Sub TxtAño_Click(sender As Object, e As EventArgs) Handles TxtAño.Click
        Cargar_Modalidad(cmbModalidad, TxtAño.Value)
        If ChkBuscar_Al_Cambio.Checked = True Then
            Buscar_Matricula_Anterior()
        End If
    End Sub
    Sub Cargar_Modalidades()
        Try
            Me.cmbModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(Val(TxtAño.Value))
            Me.cmbModalidad.Refresh()
            Me.cmbModalidad.DisplayMember = "Modalidad"
            Me.cmbModalidad.SelectedItem = 1
        Catch ex As Exception

        End Try

    End Sub
    Sub Cargar_Grados()
        Try
            Me.CmbGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año(Val(TxtAño.Value), cmbModalidad.Text.ToString.Trim)
            Me.CmbGrado.Refresh()
            Me.CmbGrado.DisplayMember = "Grado"
            Me.CmbGrado.SelectedItem = 1
        Catch ex As Exception
            'If Mostrar_Error() = True Then
            Utilidades.Mensaje(ex.Message, True)
            'End If
        End Try
    End Sub
    Sub Buscar_Matricula_Anterior()
        Try
            'MsgBox(TxtAño.Value.ToString + " " + cmbModalidad.Text.Trim + " " + CmbTurnoTransisionM.Text.Trim + " " + CmbGrado.Text.Trim + " " + CmbSeccionTransisionM.Text.Trim)
            Dim n As Int32 = 0
            DtMatriculaAnterior.DataSource = New Nalumnos().Buscar_Matricula_Año(TxtAño.Value, cmbModalidad.Text.Trim, CmbTurnoTransisionM.Text.Trim, CmbGrado.Text.Trim, CmbSeccionTransisionM.Text.Trim)
            DtMatriculaAnterior.Refresh()

            Try
                DtMatriculaAnterior.Columns(1).Visible = False
                DtMatriculaAnterior.Columns(2).Visible = False
                DtMatriculaAnterior.Columns(8).Visible = False
                For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
                    row.Cells(0).Value = True
                    If row.Cells(4).Value.trim.ToString = "F" Then
                        n += 1
                    End If
                Next
            Catch ex As Exception
                Utilidades.Mensaje(ex.Message, True)
            End Try
            Me.Label12.Text = " Registros en total -->>  AS: " + DtMatriculaAnterior.Rows.Count.ToString + "  -  F: " + n.ToString

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModalidad.SelectedIndexChanged

        Cargar_Modalidad_Turno(CmbTurnoTransisionM, TxtAño.Value, cmbModalidad.Text.Trim)
        If ChkBuscar_Al_Cambio.Checked = True Then
            Buscar_Matricula_Anterior()
        End If
    End Sub

    Private Sub CmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado.SelectedIndexChanged
        Cargar_Modalidad_Turno_Grado_Seccion(CmbSeccionTransisionM, TxtAño.Value, cmbModalidad.Text.Trim, CmbTurnoTransisionM.Text.Trim, CmbGrado.Text.Trim)
        If ChkBuscar_Al_Cambio.Checked = True Then
            Buscar_Matricula_Anterior()
        End If
    End Sub
    Dim Grado_numerico As Int32

    Sub Posicionar_Opciones()
        With PnOpcionesMatricula
            .Width = 524
            .Height = 357
            .Left = Me.Width / 2 - .Width / 2
            .Top = Me.Height / 2 - .Height / 2
            .BringToFront()
            .Visible = True
        End With
    End Sub
    Function Grado_a_Texto(Grado As Int32) As String
        Dim rpta As String = "Primero"
        Try
            Select Case Grado
                Case 1
                    rpta = "Primero"
                Case 2
                    rpta = "Segundo"
                Case 3
                    rpta = "Tercero"
                Case 4
                    rpta = "Cuarto"
                Case 5
                    rpta = "Quinto"
                Case 6
                    rpta = "Sexto"
                Case 7
                    rpta = "SEPTIMO"
                Case 8
                    rpta = "OCTAVO"
                Case 9
                    rpta = "NOVENO"
                Case 10
                    rpta = "DÉCIMO"
                Case 11
                    rpta = "UNDÉCIMO"
            End Select

        Catch ex As Exception

        End Try
        Return rpta
    End Function
    Function Grado_a_Numero(Grado As String) As Int32
        Dim rpta As Int32 = 1
        Try
            Select Case Grado
                Case "Primero"
                    rpta = 1
                Case "Segundo"
                    rpta = 2
                Case "Tercero"
                    rpta = 3
                Case "Cuarto"
                    rpta = 4
                Case "Quinto"
                    rpta = 5
                Case "Sexto"
                    rpta = 6
                Case "SEPTIMO"
                    rpta = 7
                Case "OCTAVO"
                    rpta = 8
                Case "NOVENO"
                    rpta = 9
                Case "DÉCIMO"
                    rpta = 10
                Case "UNDÉCIMO"
                    rpta = 11
            End Select

        Catch ex As Exception

        End Try
        Return rpta
    End Function
    Private Sub BtnMatricular_Click(sender As Object, e As EventArgs) Handles BtnMatricular.Click
        CmbGradoDestino.Items.Clear()
        Posicionar_Opciones()
        Me.CmbModalidadDestino.Text = Me.cmbModalidad.Text
        Grado_numerico = DtMatriculaAnterior.CurrentRow.Cells(8).Value + 1
        If cmbModalidad.Text = "Primaria Regular" Or cmbModalidad.Text = "Primaria Multigrado" Then
            CmbGradoDestino.Items.Add("Primero")
            CmbGradoDestino.Items.Add("Segundo")
            CmbGradoDestino.Items.Add("Tercero")
            CmbGradoDestino.Items.Add("Cuarto")
            CmbGradoDestino.Items.Add("Quinto")
            CmbGradoDestino.Items.Add("Sexto")
            CmbGradoDestino.Items.Add("SEPTIMO")
        ElseIf cmbModalidad.Text = "Secundaria Regular" Or cmbModalidad.Text = "Secundaria diurna" Or cmbModalidad.Text = "Secundaria A distancia en el campo" Then
            CmbGradoDestino.Items.Add("SEPTIMO")
            CmbGradoDestino.Items.Add("OCTAVO")
            CmbGradoDestino.Items.Add("NOVENO")
            CmbGradoDestino.Items.Add("DÉCIMO")
            CmbGradoDestino.Items.Add("UNDÉCIMO")
        End If
        Me.CmbGradoDestino.Text = Grado_a_Texto(DtMatriculaAnterior.CurrentRow.Cells(8).Value + 1)
        If Month(Now) <= 4 Then
            Me.TxtAñoMatricular.Text = Year(Now)
        Else
            Me.TxtAñoMatricular.Text = Year(Now) + 1
        End If
        Me.TxtAñoMatricular.Text = Year(Now)
        Me.CmbTurnoDestino.Text = "Matutino"
        Me.CmbSeccionDestino.Text = "A"
    End Sub

    Sub Matricular_Continuidad()
        Dim rpta As String = ""
        For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
            If row.Cells(0).Value = True Then
                rpta = New NMatricula().Insertar_Id_Mined(row.Cells(5).Value, Me.CmbGradoDestino.Text, Me.CmbModalidadDestino.Text.Trim, Now, Val(TxtAñoMatricular.Text), Me.CmbTurnoDestino.Text.Trim, Me.CmbSeccionDestino.Text.Trim)
                If Not rpta.Equals("Ok") Then
                    'colorear la fila -->>
                End If
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.PnOpcionesMatricula.Visible = False
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Matricular_Continuidad()
        Me.PnOpcionesMatricula.Visible = False
    End Sub

    Private Sub CmbModalidadDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidadDestino.SelectedIndexChanged
        CmbGradoDestino.Items.Clear()

        Select Case CmbModalidadDestino.Text
            Case "PRIMARIA REGULAR"
                With CmbGradoDestino
                    .Items.Add("Primero")
                    .Items.Add("Segundo")
                    .Items.Add("Tercero")
                    .Items.Add("Cuarto")
                    .Items.Add("Quinto")
                    .Items.Add("Sexto")
                End With
            Case "PRIMARIA MULTIGRADO"
                With CmbGradoDestino
                    .Items.Add("Primero")
                    .Items.Add("Segundo")
                    .Items.Add("Tercero")
                    .Items.Add("Cuarto")
                    .Items.Add("Quinto")
                    .Items.Add("Sexto")
                End With
            Case "SECUNDARIA DIURNA"
                With CmbGradoDestino
                    .Items.Add("SEPTIMO")
                    .Items.Add("OCTAVO")
                    .Items.Add("NOVENO")
                    .Items.Add("DÉCIMO")
                    .Items.Add("UNDÉCIMO")
                End With
            Case "SECUNDARIA A DISTANCIA EN EL CAMPO"
                With CmbGradoDestino
                    .Items.Add("SEPTIMO")
                    .Items.Add("OCTAVO")
                    .Items.Add("NOVENO")
                    .Items.Add("DÉCIMO")
                    .Items.Add("UNDÉCIMO")
                End With
        End Select
    End Sub

    Private Sub CmbModalidadDestino_MouseDown(sender As Object, e As MouseEventArgs) Handles CmbModalidadDestino.MouseDown

    End Sub

    Private Sub CmbModalidadDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModalidadDestino.KeyPress
        e.Handled = False
    End Sub

    Private Sub CmbGradoDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGradoDestino.KeyPress
        e.Handled = True
    End Sub

    Private Sub DtMatriculaAnterior_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtMatriculaAnterior.CellContentClick
        Try
            Dim n As Int32 = 0
            If e.ColumnIndex = DtMatriculaAnterior.Columns(0).Index Then
                Dim chk As New DataGridViewCheckBoxCell
                chk = DtMatriculaAnterior.Rows(e.RowIndex).Cells(0)
                chk.Value = Not Convert.ToBoolean(chk.Value)
            End If
            For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
                If row.Cells(0).Value = True Then
                    n += 1
                End If
            Next
            If n = DtMatriculaAnterior.Rows.Count Then
                Me.Chkmarcartodos.Checked = True
            Else
                Me.Chkmarcartodos.Checked = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chkmarcartodos.CheckedChanged
        'If Chkmarcartodos.Checked Then
        '    For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
        '        row.Cells(0).Value = True
        '    Next
        'Else
        '    For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
        '        row.Cells(0).Value = False
        '    Next
        'End If
    End Sub

    Private Sub CmbGradoDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradoDestino.SelectedIndexChanged
        If (Grado_numerico - 1) > Grado_a_Numero(CmbGradoDestino.Text.Trim) Then
            Utilidades.Mensaje("el grado seleccionado es menor que el grado del año anterior", True)
            Me.CmbGradoDestino.Text = Grado_a_Texto(Grado_numerico + 1)
        End If
    End Sub

    Function ValidarMatricula() As Boolean
        Dim rpta As Boolean = False
        Try
            If Me.CmbModalidadMatricular.Text = "" Then
                EpError.SetError(CmbModalidadMatricular, "Seleccione una Modalidad")
                rpta = False
            ElseIf Me.CmbGrado_Matricular.Text = "" Then
                EpError.SetError(CmbGrado_Matricular, "Especifique un Grado para el Alumno.")
                rpta = False
            ElseIf Me.TxtIdAlumnoMatricula.Text = "" Then
                EpError.SetError(TxtIdAlumnoMatricula, "Debe ingresar el ID del Estudiante.")
                rpta = False
            End If

            If Me.CmbModalidadMatricular.Text <> "" And Me.CmbGrado_Matricular.Text <> "" And
                Me.TxtIdAlumnoMatricula.Text <> "" Then
                rpta = True
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
        Return rpta
    End Function

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

    End Sub
    Sub cargar_Modalidad()
        Me.CmbModalidad_Buscar_Listado.DataSource = New NMatricula().Buscar_Modalidad_Año(TxtAño_Buscar_Listado.Value)
        Me.CmbModalidad_Buscar_Listado.Refresh()
        Me.CmbModalidad_Buscar_Listado.DisplayMember = "Modalidad"
        Me.CmbModalidad_Buscar_Listado.Text = ""
    End Sub
    Sub cargar_Modalidad_E()
        Me.CmbEModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(Anio.Value)
        Me.CmbEModalidad.Refresh()
        Me.CmbEModalidad.DisplayMember = "Modalidad"
        Me.CmbEModalidad.Text = ""
    End Sub
    Sub Cargar_Modalidad(Control As ComboBox, año As Int32, Optional Vacio As Boolean = False)
        Control.DataSource = New NMatricula().Buscar_Modalidad_Año(año)
        Control.Refresh()
        Control.DisplayMember = "Modalidad"
        If Vacio = True Then
            Control.Text = String.Empty
        End If
    End Sub
    Sub cargar_Modalidad_Grado()
        Me.CmbGrado_Buscar_Listado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año(TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim)
        Me.CmbGrado_Buscar_Listado.Refresh()
        Me.CmbGrado_Buscar_Listado.DisplayMember = "Grado"

        Me.CmbGrado_Buscar_Listado.Text = ""
    End Sub
    Sub cargar_Modalidad_Turno_Grado_E()
        Me.CmbEGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(Anio.Value, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim)
        Me.CmbEGrado.Refresh()
        Me.CmbEGrado.DisplayMember = "Grado"

        Me.CmbEGrado.Text = ""
    End Sub

    Sub Cargar_Modalidad_Turno_Grado(Control As ComboBox, año As Int32, Modalidad As String, Turno As String, Optional Vacio As Boolean = False)
        Try
            Control.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(año, Modalidad, Turno)
            Control.Refresh()
            Control.DisplayMember = "Grado"
            If Vacio = True Then
                Control.Text = String.Empty
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub cargar_Modalidad_Turno_Grado_Seccion_E()
        Me.CmbESeccion.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(Anio.Value, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim)
        Me.CmbESeccion.Refresh()
        Me.CmbESeccion.DisplayMember = "Seccion"

        Me.CmbESeccion.Text = ""
    End Sub

    Sub Cargar_Modalidad_Turno_Grado_Seccion(Control As ComboBox, año As Int32, Modalidad As String, Turno As String, Grado As String, Optional Vacio As Boolean = False)
        Try
            Control.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(año, Modalidad, Turno, Grado)
            Control.Refresh()
            Control.DisplayMember = "Seccion"
            If Vacio = True Then
                Control.Text = String.Empty
            End If
        Catch ex As Exception

        End Try


        ' Control.Text = ""
    End Sub
    Sub cargar_Modalidad_Turno_E()
        Me.CmbETurno.DataSource = New NMatricula().Buscar_Turno_Año(CmbEModalidad.Text.Trim, Anio.Value)
        Me.CmbETurno.Refresh()
        Me.CmbETurno.DisplayMember = "Turno"
        'MsgBox(CmbEModalidad.Text.Trim + ". ." + Anio.Value.ToString.Trim)

        Me.CmbETurno.Text = ""
    End Sub

    Sub Cargar_Modalidad_Turno(Control As ComboBox, año As Int32, Modalidad As String, Optional Vacio As Boolean = False)
        Try
            Control.DataSource = New NMatricula().Buscar_Turno_Año(Modalidad, año)
            Control.Refresh()
            Control.DisplayMember = "Turno"

            If Vacio = True Then
                Control.Text = String.Empty
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UI_Numeric1_Click(sender As Object, e As EventArgs) Handles TxtAño_Buscar_Listado.Click
        Cargar_Modalidad(CmbModalidad_Buscar_Listado, TxtAño_Buscar_Listado.Value, True)
        'Buscar_Listado_Estudiantes(1)
    End Sub

    Sub Buscar_Listado_Estudiantes(criterio As Int32)
        Try
            If criterio = 1 Then
                Me.DtListado_Estudiantes.DataSource = New NMatricula().Buscar_Listado_Estudiantes(TxtAño_Buscar_Listado.Value)
            ElseIf criterio = 2 Then
                Me.DtListado_Estudiantes.DataSource = New NMatricula().Buscar_Listado_Estudiantes(TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim)
            ElseIf criterio = 3 Then
                Me.DtListado_Estudiantes.DataSource = New NMatricula().Buscar_Listado_Estudiantes(TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim, CmbTurno_Buscar_Listado.Text.Trim)
            ElseIf criterio = 4 Then
                Me.DtListado_Estudiantes.DataSource = New NMatricula().Buscar_Listado_Estudiantes(TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim, CmbTurno_Buscar_Listado.Text.Trim, CmbGrado_Buscar_Listado.Text.Trim)
            ElseIf criterio = 5 Then
                Me.DtListado_Estudiantes.DataSource = New NMatricula().Buscar_Listado_Estudiantes(TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim, CmbTurno_Buscar_Listado.Text.Trim, CmbGrado_Buscar_Listado.Text.Trim, CmbSeccion_Buscar_Listado.Text.Trim)
            End If
            Me.DtListado_Estudiantes.Refresh()
            DtListado_Estudiantes.Columns(0).Visible = False
            DtListado_Estudiantes.Columns(1).Visible = False
            DtListado_Estudiantes.Columns(2).Visible = False
            Dim n As Int32 = 0
            For Each row As DataGridViewRow In DtListado_Estudiantes.Rows
                row.Cells(0).Value = True
                If row.Cells(4).Value.ToString.Trim = "F" Then
                    n += 1
                End If
            Next
            Me.LblTotalListadoEstudiantes.Text = " Registros en total  -->  AS: " + DtListado_Estudiantes.Rows.Count.ToString + "  -  F: " + n.ToString

        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try

    End Sub

    Private Sub CmbModalidad_Buscar_Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidad_Buscar_Listado.SelectedIndexChanged
        If CmbModalidad_Buscar_Listado.Text.Length > 0 Then
            Cargar_Modalidad_Turno(CmbTurno_Buscar_Listado, TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text, True)
            ' Buscar_Listado_Estudiantes(2)
        End If
    End Sub

    Private Sub CmbGrado_Buscar_Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado_Buscar_Listado.SelectedIndexChanged
        Cargar_Modalidad_Turno_Grado_Seccion(CmbSeccion_Buscar_Listado, TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim, CmbTurno_Buscar_Listado.Text.Trim, CmbGrado_Buscar_Listado.Text.Trim, True)
        ' Buscar_Listado_Estudiantes(4)
    End Sub

    Private Sub Chkmarcartodos_Click(sender As Object, e As EventArgs) Handles Chkmarcartodos.Click
        If Chkmarcartodos.Checked Then
            For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In DtMatriculaAnterior.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub CmbGrado_Buscar_Listado_TextChanged(sender As Object, e As EventArgs) Handles CmbGrado_Buscar_Listado.TextChanged
        ' If Me.CmbGrado_Buscar_Listado.Text.Length > 0 Then Buscar_Listado_Estudiantes(3)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Utilidades.Mensaje("Modalidad |  Nivel  |	Sección |	Turno   |	Nombre1 |	Nombre2 |	Apellido1   |	Apellido2   |	Fecha de Nac    |	Sexo    |	Código Estudiante   |", False, "Formato del Documento")
    End Sub

    Private Sub BtnCorregirMatricula_Click(sender As Object, e As EventArgs) Handles BtnCorregirMatricula.Click

        Dim rpta As String = ""
        Dim idCorte As Int32 = 0
        Dim Año As Int32 = 0

        Dim sqlcon As New SqlConnection()
        Try
            idCorte = Convert.ToInt32(InputBox("Id Corte:", "Parametros", "1"))
            Año = Convert.ToInt32(InputBox("Año", "Parametros", Year(Now).ToString))
        Catch ex As Exception
            Exit Sub
        End Try

        If Año = 0 Then
            Exit Sub
        End If
        Dim n As Int32 = 0
        For Each row As DataGridViewRow In DtListado_Estudiantes.Rows
            Try

                Dim sqlcmd As New SqlCommand("update notas set Nivel=@Nivel where IdAlumno=@idAlumno and IdCorte=@IdCorte and Año=@Año")
                sqlcon.ConnectionString = New DConexion().Cn
                sqlcon.Open()
                sqlcmd.Connection = sqlcon

                sqlcmd.Parameters.AddWithValue("@Nivel", row.Cells(7).Value.ToString.Trim)
                sqlcmd.Parameters.AddWithValue("@idAlumno", row.Cells(2).Value)
                sqlcmd.Parameters.AddWithValue("@idCorte", idCorte)
                sqlcmd.Parameters.AddWithValue("@Año", Año)

                If sqlcmd.ExecuteNonQuery = 1 Then
                    rpta = "Ok"
                Else
                    rpta = "Ocurrio un Error"
                    n += n
                End If
            Catch ex As Exception
                Utilidades.Mensaje(ex.Message, True)
            Finally
                If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
            End Try
        Next
        If n > 0 Then
            Utilidades.Mensaje("Ocurrirerón " + n.ToString + " errores de actualizacion de Grados en Notas")
        Else
            Utilidades.Mensaje("Operación realizada con éxito.")
        End If
    End Sub

    Private Sub MatricularToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MatricularToolStripMenuItem1.Click
        PnMatricula.Visible = True
        PnMatricula.Height = 827
        PnMatricula.Dock = DockStyle.Fill
        DeshabilitarControles(True)
        Try
            Me.TxtIdAlumnoMatricula.Text = Datalistado.CurrentRow.Cells(2).Value
        Catch ex As Exception
            Utilidades.Mensaje("No se Ha seleccionado Ningún Id de Estudiante", True)
            If Acceso = "Administrador" Then
                PnMatricula.Visible = True
            Else
                PnMatricula.Visible = False
            End If

        End Try
    End Sub

    Private Sub EditarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarMatriculaToolStripMenuItem.Click
        If Acceso <> "Docente" Then
            PnMatricularSeleccion.Visible = True
            PnMatricularSeleccion.Dock = DockStyle.Fill
            PnMatricularSeleccion.BringToFront()
            CmbMd.Text = ""
            CmbGd.Text = ""
            CmbTn.Text = ""
            CmbSn.Text = ""
            txtAñoMatricula.Value = Year(Now)
        End If
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSn.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PnMatricularSeleccion.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CmbMd.Text <> "" And CmbGd.Text <> "" And CmbTn.Text <> "" And CmbSn.Text <> "" Then
            Dim n As Int32 = 0
            Dim Total As Int32 = 0
            Dim Rpta As String = ""
            Dim IdMatricula As Int32 = 0
            Dim IdAlumno As Int32 = 0
            Dim Grado As String = ""
            Dim Modalidad As String = ""
            Dim Seccion As String = ""
            Dim Turno As String = ""

            Dim Msg As String = ""

            For Each row As DataGridViewRow In Datalistado.SelectedRows
                IdAlumno = row.Cells(1).Value
                IdMatricula = New NMatricula().Get_Id_Matricula(IdAlumno, txtAñoMatricula.Value)
                Grado = CmbGd.Text.Trim
                Modalidad = CmbMd.Text.Trim
                Seccion = CmbSn.Text.Trim
                Turno = CmbTn.Text.Trim
                If IdMatricula > 0 Then
                    Rpta = New NMatricula().Editar(IdMatricula, IdAlumno, Grado, Modalidad, Turno, Seccion)
                Else
                    Msg += vbNewLine + row.Cells(3).Value + " " + row.Cells(4).Value + " ==> " + row.Cells(3).Value + " --- Error ---"
                    n += 1
                End If
                Total += 1
            Next
            If n > 0 Then
                Utilidades.Mensaje("ocurrierón Errores al actualizar " + n.ToString + " registros de " + Total.ToString + " en total" + Msg, True)
            Else
                Utilidades.Mensaje("Registros Actualizados con éxito.")
                Buscar()
                PnMatricularSeleccion.Visible = False
            End If
        Else
            Utilidades.Mensaje("debe completar todos los campos")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.PnMejorAlumno.Visible = False
    End Sub

    Private Sub Anio_Click(sender As Object, e As EventArgs) Handles Anio.Click
        Cargar_Corte_E(Anio.Value)
        cargar_Modalidad_E()
    End Sub

    Private Sub CmbEModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEModalidad.SelectedIndexChanged
        If CmbEModalidad.Text.Length > 0 Then
            cargar_Modalidad_Turno_E()
            CmbETurno.Text = String.Empty
        End If
    End Sub

    Private Sub CmbETurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbETurno.SelectedIndexChanged

    End Sub

    Private Sub CmbEGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEGrado.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Opcion.SelectedIndexChanged, CmbECorte.SelectedIndexChanged
        If Opcion.Text = "Alumos Reprobados" Then
            ' Me.CmbECorte.Enabled = False
            Me.CmbEModalidad.Enabled = False
            Me.CmbETurno.Enabled = False
            Me.CmbEGrado.Enabled = False
            Me.CmbESeccion.Enabled = False
        Else
            Me.CmbECorte.Enabled = True
            Me.CmbEModalidad.Enabled = True
            Me.CmbETurno.Enabled = True
            Me.CmbEGrado.Enabled = True
            Me.CmbESeccion.Enabled = True
        End If
        If Opcion.Text = "Estudiantes Retirados" Then
            Me.CmbECorte.Enabled = False
        Else
            Me.CmbECorte.Enabled = True
        End If
        Buscar_Opciones_de_Alumnos()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Buscar_Opciones_de_Alumnos()
    End Sub

    Sub Buscar_Opciones_de_Alumnos()
        Dim Op As String = Opcion.Text.Trim
        Try
            Select Case Op
                Case "Excelencia académica"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Excelencia_Academica(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case "Alumnos destacados"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Alumnos_Destacados(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case "Alumnos con aprendizaje Elemental"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Alumnos_en_Af(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case "Alumnos con aprendizaje Inicial"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Alumnos_en_Ai(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case "Alumos Reprobados"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Alumnos_Reprobados(Anio.Value, CmbECorte.SelectedValue)
                Case "Alumos Reprobados en detalle"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Alumnos_Reprobados_Detallados(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case "Matricula"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Matricula(Anio.Value)
                Case "Estudiantes Retirados"
                    DtExcelenciaAcademica.DataSource = New Nalumnos().Estudiantes_Retirados(Anio.Value, CmbECorte.SelectedValue, CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim, CmbESeccion.Text.Trim)
                Case Else
                    ' Utilidades.Mensaje("Opcion Incorrecta")
            End Select
            DtExcelenciaAcademica.Refresh()
            lblcontador.Text = DtExcelenciaAcademica.Rows.Count.ToString + "  Registros en total."
        Catch ex As Exception

        End Try

        Try
            Me.DtExcelenciaAcademica.Columns(0).Visible = False
            Me.DtExcelenciaAcademica.Columns(1).Visible = False
            If Opcion.Text = "Alumos Reprobados" Or Opcion.Text = "Alumos Reprobados en detalle" Then
                Me.DtExcelenciaAcademica.Columns(5).Visible = False
            Else
                Me.DtExcelenciaAcademica.Columns(5).Visible = True
            End If
        Catch ex As Exception
            DtExcelenciaAcademica.Refresh()
            lblcontador.Text = DtExcelenciaAcademica.Rows.Count.ToString + "  Registros en total."
        End Try

    End Sub

    Private Sub OpcionesDeEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesDeEstudiantesToolStripMenuItem.Click
        Utilidades.Alternar_Color_DatagridView(DtExcelenciaAcademica)
        PnMejorAlumno.Visible = True
        PnMejorAlumno.Dock = DockStyle.Fill
        PnMejorAlumno.BringToFront()
        Anio.Value = Year(Now())
        Cargar_Corte_E(Anio.Value)
        cargar_Modalidad_E()
        Buscar_Opciones_de_Alumnos()
    End Sub

    Sub Cargar_Corte_E(año As Int32)
        Dim Sqlcon As New SqlConnection()
        Dim SqlCmd As New SqlCommand("select distinct(c.IdCorte),c.Nombre from corte c inner join Notas N on n.IdCorte=c.IdCorte
                                      where n.Anio=@Anio order by c.IdCorte asc")
        Dim Rpta As New DataTable
        Try
            Sqlcon.ConnectionString = New DConexion().Cn
            Sqlcon.Open()


            SqlCmd.Connection = Sqlcon
            SqlCmd.Parameters.AddWithValue("@Anio", año)

            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)
            CmbECorte.DataSource = Rpta
            CmbECorte.DisplayMember = "Nombre"
            CmbECorte.ValueMember = "IdCorte"
            CmbECorte.Refresh()
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        Finally
            If Sqlcon.State = ConnectionState.Open Then Sqlcon.Close()
        End Try
    End Sub

    Private Sub CmbModalidad_Buscar_Listado_TextChanged(sender As Object, e As EventArgs) Handles CmbModalidad_Buscar_Listado.TextChanged
        'If CmbModalidad_Buscar_Listado.Text.Length > 0 Then
        '    cargar_Modalidad_Grado()
        '    CmbGrado_Buscar_Listado.Text = String.Empty
        '    Buscar_Listado_Estudiantes(2)
        'End If

    End Sub

    Private Sub CmbEModalidad_TextChanged(sender As Object, e As EventArgs) Handles CmbEModalidad.TextChanged
        If CmbModalidad_Buscar_Listado.Text.Length > 0 Then
            cargar_Modalidad_Turno_E()
            CmbETurno.Text = String.Empty
        End If
    End Sub

    Private Sub CmbETurno_TextChanged(sender As Object, e As EventArgs) Handles CmbETurno.TextChanged
        If CmbETurno.Text.Length > 0 Then
            cargar_Modalidad_Turno_Grado_E()
            CmbEGrado.Text = String.Empty
        End If
    End Sub

    Private Sub CmbESeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbESeccion.SelectedIndexChanged

    End Sub

    Private Sub CmbEGrado_TextChanged(sender As Object, e As EventArgs) Handles CmbEGrado.TextChanged
        If CmbEGrado.Text.Length > 0 Then
            cargar_Modalidad_Turno_Grado_Seccion_E()
            CmbESeccion.Text = String.Empty
        End If
    End Sub

    Private Sub Opcion_TextChanged(sender As Object, e As EventArgs) Handles Opcion.TextChanged

    End Sub

    Private Sub CmbEModalidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbEModalidad.SelectedValueChanged

    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Exportar()
    End Sub

    Private Sub BtnM_Inicial_Click(sender As Object, e As EventArgs) Handles BtnM_Inicial.Click
        Dim frm As New FrmMatriculaInicial
        frm.ShowDialog()
    End Sub

    Private Sub CmbTurnoTransisionM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTurnoTransisionM.SelectedIndexChanged
        Cargar_Modalidad_Turno_Grado(CmbGrado, TxtAño.Value, cmbModalidad.Text.Trim, CmbTurnoTransisionM.Text.Trim)
        If ChkBuscar_Al_Cambio.Checked = True Then
            Buscar_Matricula_Anterior()
        End If
    End Sub

    Private Sub BtnBuscarMatriculaTransicion_Click(sender As Object, e As EventArgs) Handles BtnBuscarMatriculaTransicion.Click
        Buscar_Matricula_Anterior()
    End Sub

    Private Sub CmbSeccionTransisionM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSeccionTransisionM.SelectedIndexChanged
        If ChkBuscar_Al_Cambio.Checked = True Then
            Buscar_Matricula_Anterior()
        End If
    End Sub

    Private Sub ChkBuscar_Al_Cambio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBuscar_Al_Cambio.CheckedChanged
        If ChkBuscar_Al_Cambio.Checked = True Then
            BtnBuscarMatriculaTransicion.Visible = False
        Else
            BtnBuscarMatriculaTransicion.Visible = True
        End If
    End Sub

    Private Sub LblBuscar_Al_Cambiar_Click(sender As Object, e As EventArgs) Handles LblBuscar_Al_Cambiar.Click
        If ChkBuscar_Al_Cambio.Checked = True Then
            ChkBuscar_Al_Cambio.Checked = False
            BtnBuscarMatriculaTransicion.Visible = True
        Else
            ChkBuscar_Al_Cambio.Checked = True
            BtnBuscarMatriculaTransicion.Visible = False
        End If
    End Sub

    Private Sub CmbTurno_Buscar_Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTurno_Buscar_Listado.SelectedIndexChanged
        Cargar_Modalidad_Turno_Grado(CmbGrado_Buscar_Listado, TxtAño_Buscar_Listado.Value, CmbModalidad_Buscar_Listado.Text.Trim, CmbTurno_Buscar_Listado.Text.Trim, True)
        'Buscar_Listado_Estudiantes(3)
    End Sub

    Private Sub CmbSeccion_Buscar_Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSeccion_Buscar_Listado.SelectedIndexChanged
        'Buscar_Listado_Estudiantes(5)
    End Sub

    Private Sub UI_CustomButton1_Click(sender As Object, e As EventArgs) Handles UI_CustomButton1.Click
        If CmbSeccion_Buscar_Listado.Text <> "" Then
            Buscar_Listado_Estudiantes(5)
            Exit Sub
        ElseIf CmbGrado_Buscar_Listado.Text <> "" Then
            Buscar_Listado_Estudiantes(4)
            Exit Sub
        ElseIf CmbTurno_Buscar_Listado.Text <> "" Then
            Buscar_Listado_Estudiantes(3)
            Exit Sub
        ElseIf CmbModalidad_Buscar_Listado.Text <> "" Then
            Buscar_Listado_Estudiantes(2)
            Exit Sub
        Else
            Buscar_Listado_Estudiantes(1)
        End If

    End Sub

    Sub Exportar()
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        My.Computer.FileSystem.CreateDirectory(dir + "\Control Estudiantil")
        dir = dir + "\Control Estudiantil"
        'MsgBox(dir)
        Dim sl As New SLDocument
        Dim Estilo, Estilo2 As New SLStyle
        Estilo.Font.FontSize = 11
        Estilo.Font.Bold = True
        Estilo.Font.Italic = True
        Estilo.SetHorizontalAlignment(DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center)
        Estilo.SetVerticalAlignment(DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center)
        Estilo.SetVerticalBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, Color.Black)
        Estilo.SetWrapText(True)
        Dim brd As New SLBorder
        brd.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, Color.Black)
        Estilo.Border = brd
        Dim i As Int32 = 0
        Dim cl As Int32 = 0
        sl.SetColumnWidth(1, 9.97)
        sl.SetColumnWidth(2, 36.29)
        sl.SetColumnWidth(3, 21.57)
        sl.SetColumnWidth(4, 9.94)
        sl.SetColumnWidth(5, 19.29)

        sl.Filter(1, 1, DtExcelenciaAcademica.Rows.Count + 1, DtExcelenciaAcademica.Columns.Count - 1)

        '   RECORRER LOS ROTULOS DEL GRID

        For Each Col As DataGridViewColumn In DtExcelenciaAcademica.Columns
            sl.SetCellValue(1, cl, Col.HeaderText.ToString)
            sl.SetCellStyle(1, cl, Estilo)
            cl += 1
            If cl = (DtExcelenciaAcademica.Columns.Count) Then Exit For
        Next

        Estilo2.Font.FontSize = 10
        Estilo2.Font.FontColor = Color.Black
        Estilo2.Font.Italic = True
        Dim bordes As New SLBorder
        bordes.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, Color.Black)
        bordes.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, Color.Black)
        bordes.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, Color.Black)
        Estilo2.Border = bordes
        Estilo2.SetWrapText(False)

        Dim Fila As Int32 = 2

        For Each Row As DataGridViewRow In DtExcelenciaAcademica.Rows
            For i = 1 To DtExcelenciaAcademica.Columns.Count - 1
                sl.SetCellValue(Fila, i, Row.Cells(i).Value)
                sl.SetCellStyle(Fila, i, Estilo2)
            Next


            Fila += 1
        Next
        Dim ruta As String


        ruta = dir + "\ " + Opcion.Text.Trim + " " + CmbECorte.Text.Trim + " " + Anio.Value.ToString.Trim + ".xlsx"


        Try
            sl.SaveAs(ruta)
            Dim mensaje As String = "Registro guardado en: " + vbNewLine + ruta

        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
    End Sub
End Class