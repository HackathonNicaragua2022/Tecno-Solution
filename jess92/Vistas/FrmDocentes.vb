Imports System.Data.OleDb

Public Class FrmDocentes
    Private IsNuevo As Boolean = False
    Private IsEditar As Boolean = False
    Dim Utilidades As New Utilidades()
    Dim Id_Docente As Int32


    Sub Habilitar_TXT(Valor As Boolean)
        Me.TxtNombres.ReadOnly = Not Valor
        Me.TxtApellidos.ReadOnly = Not Valor
        Me.CmbSexo.Enabled = Valor
        Me.CmbRol.Enabled = Valor
        Me.TxtCedula.ReadOnly = Not Valor
        Me.TxtUser.ReadOnly = Not Valor
        Me.TxtPass.ReadOnly = Not Valor
        Me.TxtTelefono.ReadOnly = Not Valor
    End Sub
    Sub Limpiar_Txt()
        Me.TxtNombres.Clear()
        Me.TxtApellidos.Clear()
        Me.CmbSexo.Text = ""
        Me.TxtCedula.Clear()
        Me.TxtUser.Clear()
        Me.TxtPass.Clear()
        Me.CmbRol.Text = ""
        Me.TxtTelefono.Clear()
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
            Me.BtnEditar.Enabled = False
            Me.BtnCancelar.Enabled = False
        End If
    End Sub
    Sub Buscar()
        Me.Datalistado.DataSource = New NDocentes().Buscar(TxtBusquedaNombre.Text, Avanzada)
        Me.Datalistado.Refresh()

        Datalistado.Columns(0).Visible = False
        Datalistado.Columns(1).Visible = False
        Try
            Maquillaje()
        Catch ex As Exception
            Maquillaje()
        End Try

        If Datalistado.Rows.Count > 0 Then Ocultar_Columnas()
        Me.LblTotal.Text = "Total Registro: " + Datalistado.Rows.Count.ToString
    End Sub
    Sub Maquillaje()
        If Acceso = "Director" Or Acceso = "Administrador" Or Acceso = "Sub Director" Then
            Datalistado.Columns(6).Visible = True
            Datalistado.Columns(7).Visible = True
            For Each row As DataGridViewRow In Datalistado.Rows
                If row.Cells(1).Value = UserID Then
                    row.DefaultCellStyle.ForeColor = Color.Black
                    row.DefaultCellStyle.SelectionForeColor = Color.Black
                Else
                    'row.Cells(3).Style.ForeColor = Color.Transparent
                End If
            Next
        ElseIf Acceso = "Docente" Then
            Datalistado.Columns(6).Visible = False
            Datalistado.Columns(7).Visible = False
            For Each row As DataGridViewRow In Datalistado.Rows
                If row.Cells(1).Value = UserID Then
                    row.DefaultCellStyle.ForeColor = Color.Black
                    row.DefaultCellStyle.SelectionForeColor = Color.Black
                    row.Cells(4).Style.ForeColor = Color.Black
                    row.Cells(4).Style.SelectionForeColor = Color.Black
                Else
                    row.Cells(4).Style.ForeColor = Color.Transparent
                    row.Cells(4).Style.SelectionForeColor = Color.Transparent
                End If
            Next
        End If
    End Sub
    Sub Ocultar_Columnas()
        Try
            Datalistado.Columns(0).Visible = False
            Datalistado.Columns(1).Visible = False
            Datalistado.Columns(7).Visible = False
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
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
                Mostrar_Error(TxtNombres, "Digite los nombres del Docente.")
                Rpta = False
            ElseIf Me.TxtApellidos.Text = String.Empty Then
                Mostrar_Error(TxtApellidos, "Digite los apellidos del Docente.")
                Rpta = False
            ElseIf Me.CmbSexo.Text = String.Empty Then
                Mostrar_Error(CmbSexo, "Especifique Sexo del Docente.")
                Rpta = False
            ElseIf Me.TxtCedula.Text.Length <> 16 Then
                Mostrar_Error(TxtCedula, "Proporcione un numero decedula valido. Ejemplo: xxx-xxxxxx-xxxxx")
                Rpta = False
            ElseIf Me.TxtUser.Text = "" Then
                Mostrar_Error(TxtUser, "Proporcione un Nombre de Usuario.")
                Rpta = False
            ElseIf Me.TxtPass.Text.Trim.Length < 6 Then
                Mostrar_Error(TxtPass, "Proporcione una Contraseña no menor de 6 digitos.")
                Rpta = False
            Else

                Rpta = True
            End If

            If Me.TxtNombres.Text <> String.Empty And Me.TxtApellidos.Text <> String.Empty And
            Me.CmbSexo.Text <> String.Empty And Me.TxtCedula.Text.Length = 16 And TxtUser.Text <> "" And
            TxtPass.Text.Trim.Length >= 6 Then
                Rpta = True
            End If


        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
        Return Rpta
    End Function
    Function Insertar_por_Lote()
        Dim rpta As String = ""
        Dim errorIngreso As Int32 = 0
        Dim Ingresados As Int32 = 0
        Dim iddocente As Int32 = 0
        Try
            If IsNuevo Then
                If DtDocentesLote.Rows.Count > 0 Then
                    For Each Row As DataGridViewRow In DtDocentesLote.Rows
                        Try
                            rpta = New NDocentes().Insertar(Row.Cells(0).Value.ToString.Trim.ToUpper,
                                                            Row.Cells(1).Value.ToString.Trim.ToUpper,
                                                            Row.Cells(2).Value.ToString.Trim.ToUpper,
                                                            Row.Cells(3).Value.ToString.Trim.ToUpper,
                                                            Row.Cells(4).Value.ToString.Trim,
                                                            Row.Cells(5).Value.ToString.Trim,
                                                            Row.Cells(6).Value.ToString.Trim,
                                                            Row.Cells(7).Value.ToString.Trim.ToUpper)
                            If rpta.Equals("Ok") Then
                                Ingresados += 1
                                Row.DefaultCellStyle.ForeColor = Color.DarkGreen
                                iddocente = New NDocentes().Obtener_Id_Docente(Row.Cells(0).Value.ToString.Trim.ToUpper, Row.Cells(1).Value.ToString.Trim.ToUpper)
                                '       Asignarle los grados a los docentes
                                If iddocente > 0 Then
                                    Try
                                        Dim rpt As String = rpta = New NDocentes().Asignar_Grado(iddocente, Row.Cells(8).Value.ToString.Trim.ToUpper,
                                                                                                                                    Row.Cells(9).Value.ToString.Trim.ToUpper,
                                                                                                                                    DateAndTime.Year(Date.Now),
                                                                                                                                    Row.Cells(10).Value.ToString.Trim.ToUpper,
                                                                                                                                    Row.Cells(11).Value.ToString.Trim.ToUpper)
                                    Catch ex As Exception

                                    End Try
                                End If
                            Else
                                errorIngreso += 1
                            End If
                        Catch ex As Exception
                            errorIngreso += 1
                            Row.DefaultCellStyle.ForeColor = Color.Red
                        End Try
                    Next
                End If
            End If
            Utilidades.Mensaje("Operacion realizada" + vbNewLine + vbNewLine + Ingresados.ToString +
                               " Registros Ingresados" + vbNewLine + errorIngreso.ToString + " Errores al Ingresar")
        Catch ex As Exception
            Utilidades.Mensaje(rpta, True)
        End Try
        Return rpta
    End Function
    Function Insertar() As String
        Dim rpta As String = ""
        Try
            If Validar() = True Then
                If IsNuevo Then
                    rpta = New NDocentes().Insertar(TxtNombres.Text.ToUpper, TxtApellidos.Text.ToUpper,
                                                    TxtCedula.Text, CmbSexo.Text.ToUpper, TxtUser.Text.Trim,
                                                    TxtPass.Text.Trim, CmbRol.Text.Trim, TxtTelefono.Text.Trim)
                    If rpta.Equals("Ok") Then Utilidades.Mensaje("Registros Insertados con Éxito.")

                ElseIf IsEditar Then
                    rpta = New NDocentes().Editar(TxtIdDocente.Text, TxtNombres.Text.ToUpper, TxtApellidos.Text.ToUpper,
                                                    TxtCedula.Text, CmbSexo.Text.ToUpper, TxtUser.Text.Trim,
                                                    TxtPass.Text.Trim, CmbRol.Text.Trim, TxtTelefono.Text.Trim)
                    If rpta.Equals("Ok") Then Utilidades.Mensaje("Registro actualizado con éxito.")

                End If
                If rpta.Equals("Ok") Then
                    IsNuevo = False
                    IsEditar = False
                    Botones()
                    Habilitar_TXT(False)
                    Buscar()
                    Me.ActiveControl = BtnNuevo
                Else
                    Utilidades.Mensaje(rpta, True)
                End If
            End If
        Catch ex As Exception
            Utilidades.Mensaje(rpta, True)
        End Try
        Return rpta
    End Function

    Private Sub Eliminar_Docentes()
        Dim Docentes As New NDocentes()
        Dim Rpta As String = ""
        Dim IsError As Boolean
        Dim TRM As Integer = 0
        Dim msg As String = "¿Desea elinar los siguientes Docentes "

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
                        Rpta = Docentes.Eliminar(Val(Row.Cells(1).Value))
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

    Private Sub FrmDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TxtBusquedaNombre.Text = UserName
            IsNuevo = False
            IsEditar = False
            Limpiar_Txt()
            Botones()
            Habilitar_TXT(False)
            Buscar()
            Maquillaje()
            Roles()
            Utilidades.Alternar_Color_DatagridView(Me.Datalistado)
            Utilidades.Alternar_Color_DatagridView(Me.Dtasignaturas)
            Utilidades.Alternar_Color_DatagridView(Me.DtAsignaciones)
            Utilidades.Alternar_Color_DatagridView(Me.DtListadoAsignaturas)
            Utilidades.Alternar_Color_DatagridView(Me.DtGradoAsignacion)
            ' Buscar()
            Maquillaje()
        Catch ex As Exception

        End Try

    End Sub
    Sub Roles()
        Select Case Acceso
            Case "Administrador"
                Exit Select
            Case "Docente"
                Me.Opciones1.Items(0).Enabled = False
                Me.Opciones1.Items(1).Enabled = False
                Me.Opciones1.Items(3).Enabled = False
                Me.TabPage2.Enabled = False
                Me.BtnAsignarAsignaturas.Enabled = False
            Case "Director"
                Exit Select
            Case " Sub Director"
                'Me.Opciones1.Items(0).Enabled = False
                Me.Opciones1.Items(1).Enabled = False
                BtnEditar.Enabled = False
            Case "Editor"
                Me.Opciones1.Items(0).Enabled = False
                Me.Opciones1.Items(1).Enabled = False
                Me.Opciones1.Items(3).Enabled = False
                Me.Opciones1.Items(4).Enabled = False
                Me.TabPage2.Enabled = False
        End Select
    End Sub

    Sub AbrirPnAsignaciones()
        With PnAsignaciones
            .Width = 897
            .Height = 564
            .Location = New Point(23, 20)
            .Visible = True
        End With
    End Sub
    Sub HabilitarCmb(valor As Boolean)
        Me.CmbAsignaturas.Enabled = valor
        Me.CmbGrado.Enabled = valor
        Me.CmbModalidades.Enabled = valor

        Me.CmbAsignaturas.Text = String.Empty
        Me.CmbGrado.Text = String.Empty
        Me.CmbModalidades.Text = String.Empty

        If valor = True Then
            Me.BtnGuardarAsignacion.Enabled = True
            Me.BtnCancelarAsignacion.Enabled = True
            Me.BtnAsignarAsignatura.Enabled = False
        Else
            Me.BtnGuardarAsignacion.Enabled = False
            Me.BtnCancelarAsignacion.Enabled = False
            Me.BtnAsignarAsignatura.Enabled = True
        End If


    End Sub
    Private Sub BtnCerrarPnAsignaciones_Click(sender As Object, e As EventArgs) Handles BtnCerrarPnAsignaciones.Click
        Me.PnAsignaciones.Visible = False
    End Sub

    Private Sub BtnAsignarAsignatura_Click(sender As Object, e As EventArgs) Handles BtnAsignarAsignatura.Click
        HabilitarCmb(True)
        Cargar_Asignaturas()
        Anio.Value = Year(Now)
        mostrar_asignaciones(Anio.Value)
        Cargar_Modalidad(CmbModalidades, Anio.Value)
    End Sub
    Sub Cargar_Asignaturas()
        Me.CmbAsignaturas.DataSource = New NDocentes_Asignaciones().Mostrar_Asignaturas()
        Me.CmbAsignaturas.DisplayMember = "Nombre"
        Me.CmbAsignaturas.ValueMember = "IdAsignatura"
        Me.CmbAsignaturas.Refresh()
    End Sub
    Private Sub BtnAsignarAsignaturas_Click(sender As Object, e As EventArgs) Handles BtnAsignarAsignaturas.Click
        If Id_Docente > 0 Then
            'AbrirPnAsignaciones()
            PnAsignaciones.Dock = DockStyle.Fill
            PnAsignaciones.Visible = True
            HabilitarCmb(False)
            mostrar_asignaciones(Año)
        Else
            Utilidades.Mensaje("Por favor seleccione a un Docente.")
        End If

    End Sub

    Function validar_Asignacion()
        Dim Rpta As Boolean
        EpError.Clear()
        Try
            If Me.CmbModalidades.Text = String.Empty Then
                Mostrar_Error(CmbModalidades, "Seleccione la Modalidad.")
                Rpta = False
            ElseIf Me.CmbAsignaturas.Text = String.Empty Then
                Mostrar_Error(CmbAsignaturas, "Seleccione la Asignatura")
                Rpta = False
            ElseIf Me.CmbGrado.Text = String.Empty Then
                Mostrar_Error(CmbGrado, "Seleccione el Grado o Nivel")
                Rpta = False
            Else
                Rpta = True
            End If

            If Me.CmbModalidades.Text <> String.Empty And Me.CmbAsignaturas.Text <> String.Empty And
            Me.CmbGrado.Text <> String.Empty Then
                Rpta = True
            End If


        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
        Return Rpta
    End Function
    Private Sub BtnGuardarAsignacion_Click(sender As Object, e As EventArgs) Handles BtnGuardarAsignacion.Click
        If validar_Asignacion() = True Then
            Dim Rpta As String = ""
            Dim Asignaciones As New NDocentes_Asignaciones()
            Rpta = Asignaciones.Insertar(CmbAsignaturas.SelectedValue, Id_Docente, Anio.Value, CmbGrado.Text.Trim, CmbModalidades.Text.Trim, CmTurno.Text.Trim, CmbSeccion.Text.Trim)
            If Rpta.Equals("Ok") Then
                Utilidades.Mensaje("Registro Insertado Con éxito.")
                HabilitarCmb(False)
                mostrar_asignaciones(Anio.Value)
            Else
                Utilidades.Mensaje(Rpta, True)
            End If
        End If
    End Sub
    Sub mostrar_asignaciones(año As Int32)
        Me.DtAsignaciones.DataSource = New NDocentes_Asignaciones().Mostrar(Id_Docente, DateAndTime.Year(Date.Now))
        Me.DtAsignaciones.Refresh()

        Me.DtAsignaciones.Columns(0).Visible = False
        Me.DtAsignaciones.Columns(1).Visible = False
        Me.DtAsignaciones.Columns(2).Visible = False
    End Sub
    Private Sub CmbAsignaturas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbAsignaturas.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbModalidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModalidades.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbGrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnCancelarAsignacion_Click(sender As Object, e As EventArgs) Handles BtnCancelarAsignacion.Click
        HabilitarCmb(False)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        mostrar_asignaciones(Anio.Value)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim rpta As String = ""
        Try
            rpta = New NDocentes_Asignaciones().Eliminar(Me.DtAsignaciones.CurrentRow.Cells(0).Value)
            If rpta.Equals("OK") Then
                Utilidades.Mensaje("Registro eliminado con éxito.")
                mostrar_asignaciones(Año)
            Else
                Utilidades.Mensaje(rpta, True)
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Cargar_Asignaturas()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnNuevaAsigbatura.Click
        Me.BtnGuardarAsignatura.Enabled = True
        BtnCancelarAsgnt.Enabled = True
        BtnNuevaAsigbatura.Enabled = False
        Me.TxtNombreAsignatura.ReadOnly = False
        Me.TxtIdAsignatura.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        With PnAsignaturas
            .Dock = DockStyle.Fill
            .Visible = True
        End With
        Me.BtnGuardarAsignatura.Enabled = False
        BtnCancelarAsgnt.Enabled = False
        BtnNuevaAsigbatura.Enabled = True
        Me.TxtNombreAsignatura.ReadOnly = True
        Me.TxtIdAsignatura.Enabled = False
        MostrarAsignaturas()
    End Sub
    Sub MostrarAsignaturas()
        Me.DtListadoAsignaturas.DataSource = New NDocentes_Asignaciones().Mostrar_Asignaturas()
        Me.DtListadoAsignaturas.Refresh()
        If DtListadoAsignaturas.Rows.Count > 0 Then
            Me.DtListadoAsignaturas.Columns(2).Visible = False
        End If
    End Sub
    Private Sub BtnGuardarAsignatura_Click(sender As Object, e As EventArgs) Handles BtnGuardarAsignatura.Click
        If Me.TxtNombreAsignatura.Text <> "" Then
            Try
                Dim rpta As String = New NDocentes_Asignaciones().Insertar_ASignatura(TxtNombreAsignatura.Text)
                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Registro Insertado Correctamente.")
                    MostrarAsignaturas()
                    Me.BtnGuardarAsignatura.Enabled = False
                    BtnCancelarAsgnt.Enabled = False
                    BtnNuevaAsigbatura.Enabled = True
                    Me.TxtNombreAsignatura.ReadOnly = True
                    Me.TxtIdAsignatura.Enabled = False
                    Me.TxtNombreAsignatura.Clear()
                Else
                    Utilidades.Mensaje(rpta, True)
                End If
            Catch ex As Exception
                Utilidades.Mensaje(ex.Message, True)
            End Try
            'Utilidades.Mensaje("Ingrese Un Nombre de Asignatura Por Favor.")
        End If
    End Sub

    Private Sub BtnCancelarAsgnt_Click(sender As Object, e As EventArgs) Handles BtnCancelarAsgnt.Click
        Me.BtnGuardarAsignatura.Enabled = False
        BtnCancelarAsgnt.Enabled = False
        BtnNuevaAsigbatura.Enabled = True
        Me.TxtNombreAsignatura.ReadOnly = True
        Me.TxtIdAsignatura.Enabled = False
        Me.TxtNombreAsignatura.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PnAsignaturas.Visible = False
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim rpta As String
        Try
            rpta = New NDocentes_Asignaciones().Eliminar_Asignatura(DtListadoAsignaturas.CurrentRow.Cells(0).Value)
            If rpta.Equals("OK") Then
                Utilidades.Mensaje("Registro Eliminado Con Éxito.")
                MostrarAsignaturas()
            Else
                Utilidades.Mensaje(rpta, True)
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Me.BtnGuardarAsignatura.Enabled = True
        BtnCancelarAsgnt.Enabled = True
        BtnNuevaAsigbatura.Enabled = False
        Me.TxtNombreAsignatura.ReadOnly = False
        Me.TxtIdAsignatura.Enabled = False
    End Sub

    Private Sub RefrescarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem.Click
        MostrarAsignaturas()
    End Sub

    Private Sub Datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick

        Try
            Id_Docente = Me.Datalistado.CurrentRow.Cells(1).Value

            BuscarGradosAsignados()


        Catch ex As Exception

        End Try
        Try
            Dim n As Int32 = 0
            If e.ColumnIndex = Datalistado.Columns(0).Index Then
                Dim chk As New DataGridViewCheckBoxCell
                chk = Datalistado.Rows(e.RowIndex).Cells(0)
                chk.Value = Not Convert.ToBoolean(chk.Value)
            End If
            For Each row As DataGridViewRow In Datalistado.Rows
                If row.Cells(0).Value = True Then
                    n += 1
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        IsNuevo = True
        IsEditar = False
        Botones()
        Habilitar_TXT(True)
        Limpiar_Txt()
        ActiveControl = TxtCedula
        ChkPorlote.Enabled = True
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ChkPorlote.Checked = True Then
            Insertar_por_Lote()
        Else
            Insertar()
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
        Limpiar_Txt()
    End Sub

    Private Sub TxtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaNombre.TextChanged
        Buscar()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellDoubleClick
        Cargar_Textbox()
    End Sub

    Sub Cargar_Textbox()
        Try
            Me.TxtIdDocente.Text = Me.Datalistado.CurrentRow.Cells(1).Value
            Me.TxtNombres.Text = Me.Datalistado.CurrentRow.Cells(2).Value
            Me.TxtApellidos.Text = Me.Datalistado.CurrentRow.Cells(3).Value
            Me.TxtCedula.Text = Me.Datalistado.CurrentRow.Cells(4).Value
            Me.CmbSexo.Text = Me.Datalistado.CurrentRow.Cells(5).Value
            Me.TxtUser.Text = Me.Datalistado.CurrentRow.Cells(6).Value
            Me.TxtPass.Text = Me.Datalistado.CurrentRow.Cells(7).Value
            Me.CmbRol.Text = Me.Datalistado.CurrentRow.Cells(8).Value
            Me.TxtTelefono.Text = Me.Datalistado.CurrentRow.Cells(9).Value
            If Acceso.Equals("Director") = True Or Acceso.Equals("Administrador") = True Then
                Me.BtnEditar.Enabled = True
            Else
                Me.BtnEditar.Enabled = False
            End If

            TabControl1.SelectTab(1)
        Catch ex As Exception
            Me.BtnEditar.Enabled = True
            TabControl1.SelectTab(1)
        End Try

    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TabControl1.SelectTab(1)
        IsNuevo = True
        IsEditar = False
        Botones()
        Habilitar_TXT(True)
        Limpiar_Txt()
        ActiveControl = TxtCedula
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        IsNuevo = False
        IsEditar = False
        Botones()
        Habilitar_TXT(False)
        Limpiar_Txt()
        Cargar_Textbox()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Me.TxtBusquedaNombre.Clear()
        Buscar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub w(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmDocentes_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkEliminar_CheckedChanged() Handles chkEliminar.CheckedChanged
        If chkEliminar.Checked = True Then
            Me.Datalistado.Columns(0).Visible = True
            Me.BtnEliminar.Enabled = True
        Else
            Me.Datalistado.Columns(0).Visible = False
            Me.BtnEliminar.Enabled = False
        End If
    End Sub
    Sub Eliminar_Docente()
        Dim Contador As Int32 = 0
        If Datalistado.Rows.Count > 0 Then
            For Each row As DataGridViewRow In Datalistado.Rows
                If row.Cells(0).Value = True Then
                    Contador += 1
                End If
            Next
            If Contador > 0 Then
                Dim Op As Boolean = Utilidades.Preguntar("¿Desea Eliminar " + Contador.ToString + " registros del sistema?", "Yes", "Control de Docentes")
                If Op = True Then
                    For Each row As DataGridViewRow In Datalistado.Rows
                        If row.Cells(0).Value = True Then
                            Try
                                Dim Rpta As String
                                Rpta = New NDocentes().Eliminar(row.Cells(1).Value)
                                If Not Rpta.Equals("Ok") Then
                                    Utilidades.Mensaje(Rpta, True)
                                    Exit For
                                End If
                            Catch ex As Exception
                                Utilidades.Mensaje(ex.Message, True)
                                Exit For
                            End Try
                        End If
                    Next
                    Buscar()
                    chkEliminar.Checked = False
                End If
            Else
                Utilidades.Mensaje("Por favor seleccione un Registro para eliminar.")
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Eliminar_Docente()
    End Sub

    '=================================================================================
    '*********************************************************************************

    '                  Ingreaso de Asignaciones de Grados
    '_________________________________________________________________________________

    Private Año As Int32
    Private Grado As String
    Private IdAsignacion As Int32
    Sub Limpiar_Txtasignacion()
        Me.CmbModalidadGrado.Text = ""
        Me.CmbTurno.Text = ""
        Me.TxtIdAsignacionGrado.Clear()
        Me.CmbGradoAsignar.Text = ""
        Me.TxtAño.Clear()
    End Sub
    Sub Deshabilitar_Controles(valor As Boolean)
        CmbModalidadGrado.Enabled = Not valor
        Me.TxtIdAsignacionGrado.ReadOnly = True
        Me.CmbGradoAsignar.Enabled = Not valor
        Me.CmbTurno.Enabled = Not valor

        If valor = True Then
            Me.BtnNuevoGradoAsignacion.Enabled = True
            Me.BtnGuardarGradoAsignado.Enabled = False
            Me.btnCancelarGradoAsignado.Enabled = False
        Else
            Me.BtnNuevoGradoAsignacion.Enabled = False
            Me.BtnGuardarGradoAsignado.Enabled = True
            Me.btnCancelarGradoAsignado.Enabled = True
        End If

    End Sub
    Sub Cargar_Modalidad(Cmb As ComboBox, año As Int32)
        Cmb.DataSource = New NMatricula().Buscar_Modalidad_Año(año)
        Cmb.Refresh()
        Cmb.DisplayMember = "Modalidad"
    End Sub
    Sub Cargar_Turno(Cmb As ComboBox, Año As Int32, Modalidad As String)
        Cmb.DataSource = New NMatricula().Buscar_Turno_Año(Modalidad, Año)
        Cmb.Refresh()
        Cmb.DisplayMember = "Turno"
    End Sub
    Sub cargar_Grado(Cmb As ComboBox, Año As Int32, Modalidad As String, Turno As String)
        Cmb.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(Año, Modalidad, Turno)
        Cmb.Refresh()
        Cmb.DisplayMember = "Grado"
    End Sub
    Sub cargar_Seccion(Cmb As ComboBox, Año As Int32, Modalidad As String, Turno As String, Grado As String)
        Cmb.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(Año, Modalidad, Turno, Grado)
        Cmb.Refresh()
        Cmb.DisplayMember = "Seccion"
    End Sub
    Private Sub BtnNuevoGradoAsignacion_Click(sender As Object, e As EventArgs) Handles BtnNuevoGradoAsignacion.Click
        Limpiar_Txtasignacion()
        Deshabilitar_Controles(False)
        BuscarGradosAsignados()
        Me.TxtAño.Text = Year(Now)
        IsNuevoGrado = True

        IsEditarGrado = False
        Cargar_Modalidad(CmbModalidadGrado, Val(TxtAño.Text))
    End Sub
    Function ValidarAsignacion()
        Dim año As Int32 = DateAndTime.Year(Date.Now)
        Dim rpta As Boolean = True
        For Each row As DataGridViewRow In DtGradoAsignacion.Rows
            If row.Cells(3).Value = CmbGradoAsignar.Text And row.Cells(7).Value = año Then
                rpta = False
                Exit For
            End If
        Next
        Return rpta
    End Function

    Dim IsEditarGrado As Boolean
    Dim IsNuevoGrado As Boolean
    Dim Id_Asignacion As Int32 = 0
    Sub Asignar_Grado()
        Dim rpta As String
        If ValidarAsignacion() = True Then
            If IsNuevoGrado = True Then
                rpta = New NDocentes().Asignar_Grado(Id_Docente, CmbGradoAsignar.Text.Trim, CmbModalidadGrado.Text.Trim, DateAndTime.Year(Date.Now), CmbTurno.Text.Trim, CmbSeccion.Text.Trim)
            ElseIf IsEditarGrado = True Then
                rpta = New NDocentes().Editar_Asignacion_Grado(Id_Asignacion, Id_Docente, CmbGradoAsignar.Text.Trim, CmbModalidadGrado.Text.Trim, DateAndTime.Year(Date.Now), CmbTurno.Text.Trim, CmbSeccion.Text.Trim)
            End If


            If rpta.Equals("Ok") Then
                Utilidades.Mensaje("Grado Asignado")
                Limpiar_Txtasignacion()
                Deshabilitar_Controles(True)
                EpError.Clear()
                IsNuevoGrado = False
                IsEditarGrado = False
            Else
                Utilidades.Mensaje(rpta, True)
            End If
        Else
            EpError.SetError(CmbGradoAsignar, "El Grado ya ha sido asignado.")
        End If
    End Sub


    Private Sub BtnGuardarGradoAsignado_Click(sender As Object, e As EventArgs) Handles BtnGuardarGradoAsignado.Click
        Asignar_Grado()
        BuscarGradosAsignados()
        IsEditarGrado = True
        IsNuevoGrado = False
    End Sub
    Private Sub BtnEditarGradoAsignado_Click(sender As Object, e As EventArgs) Handles BtnEditarAsignacion_Grado.Click
        Limpiar_Txtasignacion()
        Deshabilitar_Controles(False)
        IsEditarGrado = True
        IsNuevoGrado = False
    End Sub

    Sub BuscarGradosAsignados()

        Try
            Me.DtGradoAsignacion.DataSource = New DDocentes().Buscar_Asignacion_de_Grado(Id_Docente)
            Me.DtGradoAsignacion.Refresh()

            Me.Dtasignaturas.DataSource = New DDocentes().Buscar_Asignacion_de_Grado(Id_Docente)
            Me.Dtasignaturas.Refresh()

            DtGradoAsignacion.Columns(0).Visible = False
            DtGradoAsignacion.Columns(1).Visible = False

            Me.Dtasignaturas.Columns(0).Visible = False
            Me.Dtasignaturas.Columns(1).Visible = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCancelarGradoAsignado_Click(sender As Object, e As EventArgs) Handles btnCancelarGradoAsignado.Click
        Limpiar_Txtasignacion()
        Deshabilitar_Controles(True)
    End Sub

    Private Sub AsignarGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarGradoToolStripMenuItem.Click
        If Id_Docente > 0 Then
            Me.PnAsignaciondeGrados.Visible = True
            Me.PnAsignaciondeGrados.Dock = DockStyle.Fill
            BuscarGradosAsignados()
            Limpiar_Txtasignacion()
            Deshabilitar_Controles(True)
            Me.LBLDocenteasignacion.Text = Me.Datalistado.CurrentRow.Cells(2).Value.ToString + " " + Me.Datalistado.CurrentRow.Cells(3).Value.ToString
            Me.TxtAño.Text = Year(Now)
        Else
            Utilidades.Mensaje("Seleccione un Docente por favor.")
        End If

    End Sub

    Private Sub BtnCerrarGradoAsignacion_Click(sender As Object, e As EventArgs) Handles BtnCerrarGradoAsignacion.Click
        Me.PnAsignaciondeGrados.Visible = False
        Me.PnAsignaciondeGrados.Dock = DockStyle.None
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim rpta As String
        Try
            Try
                IdAsignacion = Dtasignaturas.CurrentRow.Cells(0).Value
            Catch ex As Exception
                Utilidades.Mensaje("Seleccione la Asignación a eliminar")
            End Try
            If IdAsignacion > 0 Then
                rpta = New NDocentes().Eliminar_Asignacion_Grado(Id_Asignacion)
                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Registro eliminado con exito")
                    BuscarGradosAsignados()
                Else
                    Utilidades.Mensaje(rpta, True)
                End If
            End If

        Catch ex As Exception
            Utilidades.Mensaje(rpta, True)
        End Try



    End Sub

    Private Sub Opciones1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Opciones1.Opening

    End Sub

    Private Sub CmbSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSexo.KeyPress, CmbRol.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbModalidadGrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModalidadGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbGradoAsignar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGradoAsignar.KeyPress, CmbTurno.KeyPress, CmbSeccion.KeyPress
        e.Handled = True
    End Sub

    Private Sub AsignarAsignaturasAGradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarAsignaturasAGradosToolStripMenuItem.Click
        Dim frm As New FrmGradosPorModalidad
        frm.ShowDialog()
    End Sub

    Private Sub CmbTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTurno.SelectedIndexChanged
        cargar_Grado(CmbGradoAsignar, Val(TxtAño.Text), CmbModalidadGrado.Text, CmbTurno.Text)
    End Sub

    Private Sub Datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        Try
            Id_Docente = Me.Datalistado.CurrentRow.Cells(1).Value

            BuscarGradosAsignados()

            '    If Acceso = "Director" Or Acceso = "Administrador" Or Acceso = "Sub Director" Then
            '        Datalistado.Columns(6).Visible = True
            '        Datalistado.Columns(7).Visible = True

            '        For Each row As DataGridViewRow In Datalistado.SelectedRows
            '            If row.Cells(1).Value = UserID Then
            '                row.DefaultCellStyle.ForeColor = Color.Black
            '                row.DefaultCellStyle.SelectionForeColor = Color.Black
            '            Else
            '                'row.Cells(3).Style.ForeColor = Color.Transparent
            '            End If
            '        Next
            '    Else
            '        Datalistado.Columns(6).Visible = False
            '        Datalistado.Columns(7).Visible = False

            '        For Each row As DataGridViewRow In Datalistado.SelectedRows
            '            If row.Cells(1).Value = UserID Then
            '                row.DefaultCellStyle.ForeColor = Color.Black
            '                row.DefaultCellStyle.SelectionForeColor = Color.Black
            '            Else
            '                row.Cells(4).Style.ForeColor = Color.Transparent
            '                row.Cells(4).Style.SelectionForeColor = Color.Transparent

            '            End If
            '        Next
            '    End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Datalistado_AlternatingRowsDefaultCellStyleChanged(sender As Object, e As EventArgs) Handles Datalistado.AlternatingRowsDefaultCellStyleChanged
        'If Acceso = "Director" Or Acceso = "Administrador" Or Acceso = "Sub Director" Then
        '    Datalistado.Columns(6).Visible = True
        '    Datalistado.Columns(7).Visible = True

        '    For Each row As DataGridViewRow In Datalistado.SelectedRows
        '        If row.Cells(1).Value = UserID Then
        '            row.DefaultCellStyle.ForeColor = Color.Black
        '        Else
        '            'row.Cells(3).Style.ForeColor = Color.Transparent
        '        End If
        '    Next
        'Else
        '    Datalistado.Columns(6).Visible = False
        '    Datalistado.Columns(7).Visible = False

        '    For Each row As DataGridViewRow In Datalistado.SelectedRows
        '        If row.Cells(1).Value = UserID Then
        '            row.DefaultCellStyle.ForeColor = Color.Black
        '        Else
        '            row.Cells(4).Style.ForeColor = Color.Transparent
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Datalistado_SelectionChanged(sender As Object, e As EventArgs) Handles Datalistado.SelectionChanged
        Try
            Id_Docente = Me.Datalistado.CurrentRow.Cells(1).Value

            BuscarGradosAsignados()


        Catch ex As Exception

        End Try
        'If Acceso = "Director" Or Acceso = "Administrador" Or Acceso = "Sub Director" Then
        '    Datalistado.Columns(6).Visible = True
        '    Datalistado.Columns(7).Visible = True

        '    For Each row As DataGridViewRow In Datalistado.Rows
        '        If row.Cells(1).Value = UserID Then
        '            row.DefaultCellStyle.ForeColor = Color.Black
        '            row.DefaultCellStyle.SelectionForeColor = Color.Black
        '        Else
        '            'row.Cells(3).Style.ForeColor = Color.Transparent
        '        End If
        '    Next
        'Else
        '    Datalistado.Columns(6).Visible = False
        '    Datalistado.Columns(7).Visible = False

        '    For Each row As DataGridViewRow In Datalistado.Rows
        '        If row.Cells(1).Value = UserID Then
        '            row.DefaultCellStyle.ForeColor = Color.Black
        '            row.DefaultCellStyle.SelectionForeColor = Color.Black
        '        Else
        '            row.Cells(4).Style.ForeColor = Color.Transparent
        '            row.Cells(4).Style.SelectionForeColor = Color.Transparent
        '        End If
        '    Next
        'End If
    End Sub
    Sub pasar_datos()
        Me.Id_Asignacion = Convert.ToInt32(Dtasignaturas.CurrentRow.Cells(0).Value)
        Me.Id_Docente = Dtasignaturas.CurrentRow.Cells(1).Value
        TxtAño.Text = Dtasignaturas.CurrentRow.Cells(7).Value
        CmbModalidadGrado.Text = Dtasignaturas.CurrentRow.Cells(3).Value.ToString.Trim
        CmbGradoAsignar.Text = Dtasignaturas.CurrentRow.Cells(4).Value
        CmbSeccion.Text = Dtasignaturas.CurrentRow.Cells(6).Value
        CmbTurno.Text = Dtasignaturas.CurrentRow.Cells(5).Value
        LBLDocenteasignacion.Text = Dtasignaturas.CurrentRow.Cells(2).Value


    End Sub
    Sub pasar_datos2()
        Me.Id_Asignacion = Convert.ToInt32(DtGradoAsignacion.CurrentRow.Cells(0).Value)
        Me.Id_Docente = DtGradoAsignacion.CurrentRow.Cells(1).Value
        TxtAño.Text = DtGradoAsignacion.CurrentRow.Cells(7).Value
        CmbModalidadGrado.Text = DtGradoAsignacion.CurrentRow.Cells(3).Value.ToString.Trim
        CmbGradoAsignar.Text = DtGradoAsignacion.CurrentRow.Cells(4).Value
        CmbSeccion.Text = DtGradoAsignacion.CurrentRow.Cells(6).Value
        CmbTurno.Text = DtGradoAsignacion.CurrentRow.Cells(5).Value
        LBLDocenteasignacion.Text = DtGradoAsignacion.CurrentRow.Cells(2).Value


    End Sub
    Private Sub EditarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem1.Click
        Limpiar_Txtasignacion()
        Deshabilitar_Controles(False)
        Me.Id_Asignacion = Convert.ToInt32(Dtasignaturas.CurrentRow.Cells(0).Value)
        Me.PnAsignaciondeGrados.Visible = True
        Me.PnAsignaciondeGrados.BringToFront()
        BtnEditarAsignacion_Grado.Enabled = True
        pasar_datos()
    End Sub

    Private Sub DtGradoAsignacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtGradoAsignacion.CellContentClick

    End Sub

    Private Sub DtGradoAsignacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtGradoAsignacion.CellDoubleClick
        Limpiar_Txtasignacion()
        Deshabilitar_Controles(False)
        Me.Id_Asignacion = Convert.ToInt32(DtGradoAsignacion.CurrentRow.Cells(0).Value)
        Me.PnAsignaciondeGrados.Visible = True
        Me.PnAsignaciondeGrados.BringToFront()
        BtnEditarAsignacion_Grado.Enabled = True
        pasar_datos()
    End Sub

    Private Sub Dtasignaturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtasignaturas.CellContentClick
        Try
            Me.Id_Asignacion = Convert.ToInt32(Dtasignaturas.CurrentRow.Cells(0).Value)
            If Id_Asignacion > 0 Then
                EditarToolStripMenuItem1.Enabled = True
            Else
                EditarToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            EditarToolStripMenuItem.Enabled = False
        End Try

    End Sub
    Dim Avanzada As String = 0
    Private Sub UI_CheckWindows1_CheckedChanged(sender As Object, e As EventArgs) Handles UI_CheckWindows1.CheckedChanged
        If UI_CheckWindows1.Checked = True Then
            Avanzada = 1
        Else
            Avanzada = 0
        End If
    End Sub

    Private Sub LblAvanzado_Click(sender As Object, e As EventArgs) Handles LblAvanzado.Click
        If UI_CheckWindows1.Checked = True Then
            UI_CheckWindows1.Checked = False
        Else
            UI_CheckWindows1.Checked = True
        End If
    End Sub

    Private Sub CmbAsignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAsignaturas.SelectedIndexChanged
        cargar_Modalidad_E()
    End Sub

    Sub cargar_Modalidad_E()
        Me.CmbModalidades.DataSource = New NMatricula().Buscar_Modalidad_Año(Anio.Value)
        Me.CmbModalidades.Refresh()
        Me.CmbModalidades.DisplayMember = "Modalidad"
        ' Me.CmbModalidades.Text = ""
    End Sub

    Sub cargar_Modalidad_Turno_E()
        Me.CmTurno.DataSource = New NMatricula().Buscar_Turno_Año(CmbModalidades.Text.Trim, Anio.Value)
        Me.CmTurno.Refresh()
        Me.CmTurno.DisplayMember = "Turno"
        'MsgBox(CmbEModalidad.Text.Trim + ". ." + Anio.Value.ToString.Trim)

        'Me.CmbTurno.Text = ""
    End Sub

    Sub cargar_Modalidad_Turno_Grado_E()
        Me.CmbGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(Anio.Value, CmbModalidades.Text.Trim, CmTurno.Text.Trim)
        Me.CmbGrado.Refresh()
        Me.CmbGrado.DisplayMember = "Grado"

        ' Me.CmbGrado.Text = ""
    End Sub
    Sub cargar_Modalidad_Turno_Grado_Seccion_E()
        Me.CmbAula.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(Anio.Value, CmbModalidades.Text.Trim, CmTurno.Text.Trim, CmbGrado.Text.Trim)
        Me.CmbAula.Refresh()
        Me.CmbAula.DisplayMember = "Seccion"

        ' Me.CmbSeccion.Text = ""
    End Sub

    Private Sub CmbModalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidades.SelectedIndexChanged
        cargar_Modalidad_Turno_E()

    End Sub

    Private Sub CmTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmTurno.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_E()
    End Sub

    Private Sub CmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_Seccion_E()
    End Sub

    Private Sub CmbModalidades_TextChanged(sender As Object, e As EventArgs) Handles CmbModalidades.TextChanged
        cargar_Modalidad_Turno_E()
    End Sub

    Private Sub ChkPorlote_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPorlote.CheckedChanged
        If ChkPorlote.Checked = True Then
            PnDocentes_Lotes.Visible = True
            Panel1.Visible = False
        Else
            PnDocentes_Lotes.Visible = False
            Panel1.Visible = True
        End If
    End Sub

    Private Sub BtnCargarMatriculaLotes_Click(sender As Object, e As EventArgs) Handles BtnCargarMatriculaLotes.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivo"
            .Filter = "Archivo Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Load.Visible = True
                Cargar_Datos(.FileName, DtDocentesLote)
                Load.Visible = False
            End If
            Utilidades.Alternar_Color_DatagridView(DtDocentesLote)
            LblRegistros.Text = "Total de Registros: " + DtDocentesLote.Rows.Count.ToString
        End With
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

    Private Sub CmbModalidadGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidadGrado.SelectedIndexChanged
        Cargar_Turno(CmbTurno, Val(TxtAño.Text), CmbModalidadGrado.Text)
    End Sub

    Private Sub CmbGradoAsignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradoAsignar.SelectedIndexChanged
        cargar_Seccion(CmbSeccion, Val(TxtAño.Text), CmbModalidadGrado.Text, CmbTurno.Text, CmbGradoAsignar.Text)
    End Sub
End Class