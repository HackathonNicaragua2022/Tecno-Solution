Imports System.Data, System.Data.SqlClient
Public Class FrmCortes

    Dim Utilidades As New Utilidades
    Private Sub FrmCortes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Utilidades.Alternar_Color_DatagridView(Datalistado)
            Utilidades.Alternar_Color_DatagridView(DtNotas)
            Me.TxtAño.Value = Year(Now)
            CargarCorte()

            Me.CmbCorte.SelectedIndex = 0
            'Me.CmbModalidad.SelectedIndex = 4
            'BuscarAlumnos()

            cargar_Modalidad_E()

        Catch ex As Exception

        End Try
        If Acceso = "Docente" Then
            If Metodo_Ingreso_de_Nota.Equals("DISCIPLINA") Then
                CmbDocente.Visible = False
            End If
            BtnInformeNotas.Visible = False
            InsertarNotasPorLoteToolStripMenuItem.Visible = False
        End If
    End Sub
    Dim Bmodalidad As String
    Dim BGrado As String
    Dim BTurno As String
    Dim BCorte As Int32
    Dim BAño As Int32
    Dim Bseccion As String
    Sub Parametros()
        If Acceso = "Administrador" Or Acceso = "Director" Or Acceso = "Secretario" Or Acceso = "Subdirector" Then
            PnOpciones.Visible = True
            Bmodalidad = CmbModalidad.Text.Trim
            BGrado = CmbGrado.Text.Trim
            BTurno = CmbTurno.Text.Trim
            BCorte = CmbCorte.SelectedValue
            BAño = TxtAño.Value
            Bseccion = CmbSeccion.Text.Trim

        ElseIf Acceso = "Docente" Then
            If Metodo_Ingreso_de_Nota.Equals("DISCIPLINA") Then
                PnOpciones.Visible = True
                Bmodalidad = CmbModalidad.Text.Trim
                BGrado = CmbGrado.Text.Trim
                BTurno = CmbTurno.Text.Trim
                BCorte = CmbCorte.SelectedValue
                BAño = TxtAño.Value
                Bseccion = CmbSeccion.Text.Trim
                CmbDocente.Visible = False
            Else
                PnOpciones.Visible = False
                Bmodalidad = UserModalidad.Trim
                BGrado = UserGrado.Trim
                BTurno = UserTurno.Trim
                BCorte = CmbCorte.SelectedValue
                BAño = TxtAño.Value
                Bseccion = UserSeccion.Trim
                CmbDocente.Visible = False
            End If
        End If
        'MsgBox(UserID.ToString + "--" + User + "--" + UserModalidad + "--" + UserTurno + "--" + UserGrado + "--" + UserSeccion + "--" + Metodo_Ingreso_de_Nota + "--")
    End Sub
    Sub BuscarAlumnos()
        Try

            Parametros()
            Datalistado.DataSource = New NNotas().MostrarAlumnosparaInsertar(TxtBusqueda.Text, Bmodalidad, BGrado, BAño, BCorte, BTurno, Bseccion)

            Datalistado.Columns(0).Visible = False
            Datalistado.Columns(1).Visible = False
            LblTotal.Text = Datalistado.Rows.Count.ToString + " registros encontrados."
            Datalistado.Refresh()
        Catch ex As Exception
            'Utilidades.Mensaje(ex.Message, True)
        End Try

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
            Utilidades.Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
    End Sub

    Sub CargarDocentes()
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As New DataTable
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Docentes_Mostrar_Asignaturas"
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Connection = sqlcon

            SqlCmd.Parameters.AddWithValue("@anio", TxtAño.Value)
            SqlCmd.Parameters.AddWithValue("@Modalidad", CmbModalidad.Text.Trim)
            SqlCmd.Parameters.AddWithValue("@Turno", CmbTurno.Text.Trim)
            SqlCmd.Parameters.AddWithValue("@Grado", CmbGrado.Text.Trim)
            SqlCmd.Parameters.AddWithValue("@Seccion", CmbSeccion.Text.Trim)


            Dim sqldt As New SqlDataAdapter(SqlCmd)
            sqldt.Fill(Rpta)
            CmbDocente.DataSource = Rpta
            CmbDocente.DisplayMember = "Docente"
            CmbDocente.ValueMember = "IdDocente"
            CmbDocente.Refresh()
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try
    End Sub
    Private Sub FrmCortes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub



    Private Sub CmbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidad.SelectedIndexChanged
        cargar_Modalidad_Turno_E()
    End Sub

    Private Sub CmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_Seccion_E()

    End Sub

    Private Sub CmbCorte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCorte.SelectedIndexChanged
        cargar_Modalidad_E()
        If Acceso.Trim = "Docente" Then
            BuscarAlumnos()
        End If

    End Sub

    Private Sub TxtAño_ValueChanged(sender As Object, e As EventArgs) Handles TxtAño.ValueChanged
        BuscarAlumnos()
    End Sub
    Dim Docente_Seleccionado As String
    Sub cargarAsignaturas()
        Try
            If Datalistado.Rows.Count > 0 And CmbCorte.Text <> "" Then
                If Metodo_Ingreso_de_Nota.Trim.Equals("GRADO") Then
                    Me.LiAsignaturas.DataSource = New NNotas().Mostrar_Asignaturas(Datalistado.CurrentRow.Cells(0).Value, BCorte, Bmodalidad, BGrado, BAño)
                ElseIf Metodo_Ingreso_de_Nota.Trim.Equals("DISCIPLINA") Then
                    If Acceso <> "Docente" Then
                        'MsgBox("DISCIPLINA")
                        CmbDocente.Visible = True
                        Me.LiAsignaturas.DataSource = New NNotas().Mostrar_Asignaturas_Por_Docente(Datalistado.CurrentRow.Cells(0).Value,
                                                                                        CmbCorte.SelectedValue, BAño, CmbDocente.SelectedValue,
                                                                                        CmbModalidad.Text.Trim, CmbTurno.Text.Trim, CmbGrado.Text.Trim, CmbSeccion.Text.Trim)
                    Else
                        CmbDocente.Visible = False
                        Me.LiAsignaturas.DataSource = New NNotas().Mostrar_Asignaturas_Por_Docente(Datalistado.CurrentRow.Cells(0).Value,
                                                                                         CmbCorte.SelectedValue, BAño, UserID,
                                                                                        CmbModalidad.Text.Trim, CmbTurno.Text.Trim, CmbGrado.Text.Trim, CmbSeccion.Text.Trim)
                    End If
                Else
                    Utilidades.Mensaje("Aun no ha sido configurado el Metodo de Ingreso de notas." + vbNewLine + "Consulte al administrador del sistema.")
                End If
                ' Me.LiAsignaturas.DataSource = New NNotas().Mostrar_Asignaturas(Datalistado.CurrentRow.Cells(0).Value, BCorte, Bmodalidad, BGrado, BAño)
                Me.LiAsignaturas.Refresh()
                Me.LiAsignaturas.DisplayMember = "Asignatura"
                Me.LiAsignaturas.ValueMember = "IdAsignatura"
            End If

        Catch ex As Exception
            Utilidades.Mensaje("Aun no ha sido configurado el Metodo de Ingreso de notas." + vbNewLine + "Consulte al administrador del sistema.")
        End Try

    End Sub
    Private Sub Datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        'cargar_Notas()
    End Sub
    Sub cargar_Notas()
        Try
            If Datalistado.Rows.Count > 0 And CmbCorte.Text <> "" Then
                Me.DtNotas.DataSource = New NNotas().Mostrar_Notas(Datalistado.CurrentRow.Cells(0).Value, CmbCorte.SelectedValue, BAño)
                Me.DtNotas.Refresh()

                DtNotas.Columns(0).Visible = False
                DtNotas.Columns(1).Visible = False
            End If

        Catch ex As Exception
            Utilidades.Mensaje("Aun no ha sido configurado el Metodo de Ingreso de notas." + vbNewLine + "Consulte al administrador del sistema.")
        End Try

        cargarAsignaturas()
    End Sub

    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota.KeyPress
        If TxtNota.Value.ToString.Length = 3 Then
            e.Handled = True
        End If

    End Sub
    Private Sub TxtNota_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNota.KeyDown
        If e.KeyCode = 13 Then
            If TxtNota.Value > 0 And TxtNota.Value <= 100 And LiAsignaturas.Items.Count > 0 And LiAsignaturas.SelectedValue > 0 Then
                insertar_Nota()
            Else
                If TxtNota.Value > 100 Then Utilidades.Mensaje("La nota a insertar no cumple con las normas establecidas.")
                If LiAsignaturas.Items.Count = 0 Then Utilidades.Mensaje("Ya fueron ingresadas todas las notas.")
                If LiAsignaturas.SelectedValue = vbNull Then Utilidades.Mensaje("Error al seleccionar la asignatura")
            End If
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNota.Value > 0 And TxtNota.Value <= 100 And LiAsignaturas.Items.Count > 0 And LiAsignaturas.SelectedValue > 0 Then
            insertar_Nota()
        Else
            If TxtNota.Value > 100 Then Utilidades.Mensaje("La nota a insertar no cumple con las normas establecidas.")
            If LiAsignaturas.Items.Count = 0 Then Utilidades.Mensaje("Ya fuerón ingresadas todas las notas.")
            If LiAsignaturas.SelectedValue = vbNull Then Utilidades.Mensaje("Error al seleccionar la asignatura")
        End If
    End Sub
    Sub insertar_Nota()
        Dim idalumno As Int32 = Datalistado.CurrentRow.Cells(0).Value
        Dim idcorte As String = CmbCorte.SelectedValue
        Dim idasignatura As Int32 = LiAsignaturas.SelectedValue
        Dim iddocente As Int32 = Datalistado.CurrentRow.Cells(1).Value
        Dim nivel As String = CmbGrado.Text.Trim
        Dim Corte As String = CmbCorte.Text
        If Acceso = "Docente" And Metodo_Ingreso_de_Nota = "Grado" Then
            nivel = UserGrado
        Else
            nivel = CmbGrado.Text.Trim
        End If

        Dim año As Int32 = TxtAño.Value
        Dim nota As Int32 = TxtNota.Value

        Dim rpta As String = ""
        Try
            rpta = New NNotas().Insertar_Nota(idalumno, idcorte, idasignatura, iddocente, nivel, año, nota, Corte)
            If rpta.Equals("Ok") Then
                cargar_Notas()
                TxtNota.Value = 0
                Me.ActiveControl = TxtNota
                TxtNota.Select(0, TxtNota.Value.ToString.Length)
            Else
                Utilidades.Mensaje(rpta)
                cargar_Notas()
                TxtNota.Value = 0
                Me.ActiveControl = TxtNota
                TxtNota.Select(0, TxtNota.Value.ToString.Length)
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
            cargar_Notas()
        End Try
    End Sub

    Private Sub LiAsignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LiAsignaturas.SelectedIndexChanged
        'ActiveControl = TxtNota
        'TxtNota.Value = 0
        'TxtNota.Select(0, TxtNota.Value.ToString.Length)
    End Sub
    Dim id_al As Int32
    Dim id_as As Int32
    Dim nota As Int32 = 0
    Dim Estudiante As String
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        id_al = Datalistado.CurrentRow.Cells(0).Value
        id_as = DtNotas.CurrentRow.Cells(1).Value
        nota = DtNotas.CurrentRow.Cells(3).Value
        Estudiante = Datalistado.CurrentRow.Cells(2).Value
        With PnAutorizacion
            .Visible = True
            .Left = (Me.Width / 2) - (.Width / 2)
            '.Top = (Me.Height / 3) ' - (.Height / 2)
            .BringToFront()
        End With
        Me.TxtPasword.Clear()
        Me.ActiveControl = TxtPasword


    End Sub
    Sub ValidarClasesDeGrado()
        'Dim Preescolar As Array()
    End Sub

    Private Sub Datalistado_SelectionChanged(sender As Object, e As EventArgs) Handles Datalistado.SelectionChanged
        cargar_Notas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnInformeNotas.Click


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick

    End Sub

    Private Sub LiAsignaturas_Click(sender As Object, e As EventArgs) Handles LiAsignaturas.Click
        ActiveControl = TxtNota
        TxtNota.Value = 0
        TxtNota.Select(0, TxtNota.Value.ToString.Length)
    End Sub

    Private Sub MostrarNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarNotasToolStripMenuItem.Click
        Dim frm As New FrmNotas_Por_Alumno
        frm.id_alumno = Datalistado.CurrentRow.Cells(0).Value
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        BuscarAlumnos()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim frm As New FrmNotas_Por_Alumno
        frm.id_alumno = Datalistado.CurrentRow.Cells(0).Value
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        CargarCorte()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim frm As New FRmEdicion_de_Corte
        frm.ShowDialog()
    End Sub
    Private Sub CmbCorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCorte.KeyPress, CmbTurno.KeyPress, CmbSeccion.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAño.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbGrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbModalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModalidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub InsertarEvaluacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEvaluacionesToolStripMenuItem.Click
        Dim frm As New FrmAdd_Semestre_y_Final
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PnOpciones_Paint(sender As Object, e As PaintEventArgs) Handles PnOpciones.Paint

    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles BtnInforme.Click
        Form1.AbrirFormEnPanel(Of FrmNotas)()
        Dim frm As New FrmNotas()
        frm.ShowDialog()
    End Sub

    Private Sub UI_CustomButton1_Click(sender As Object, e As EventArgs) Handles UI_CustomButton1.Click

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarAlumnos()
    End Sub

    Sub cargar_Modalidad_E()
        Me.CmbModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(TxtAño.Value)
        Me.CmbModalidad.Refresh()
        Me.CmbModalidad.DisplayMember = "Modalidad"
        If Acceso = "Docente" Then
            CmbModalidad.Text = UserModalidad

        End If
        'Me.CmbModalidad.Text = ""
    End Sub

    Sub cargar_Modalidad_Turno_E()
        Me.CmbTurno.DataSource = New NMatricula().Buscar_Turno_Año(CmbModalidad.Text.Trim, TxtAño.Value)
        Me.CmbTurno.Refresh()
        Me.CmbTurno.DisplayMember = "Turno"
        If Acceso = "Docente" Then
            CmbTurno.Text = UserTurno
        End If
    End Sub

    Sub cargar_Modalidad_Turno_Grado_E()
        Me.CmbGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(TxtAño.Value, CmbModalidad.Text.Trim, CmbTurno.Text.Trim)
        Me.CmbGrado.Refresh()
        Me.CmbGrado.DisplayMember = "Grado"

        'Me.CmbGrado.Text = ""
    End Sub
    Sub cargar_Modalidad_Turno_Grado_Seccion_E()
        Me.CmbSeccion.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(TxtAño.Value, CmbModalidad.Text.Trim, CmbTurno.Text.Trim, CmbGrado.Text.Trim)
        Me.CmbSeccion.Refresh()
        Me.CmbSeccion.DisplayMember = "Seccion"

        ' Me.CmbSeccion.Text = ""
    End Sub

    Private Sub CmbTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTurno.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_E()
    End Sub

    Private Sub CmbSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSeccion.SelectedIndexChanged
        BuscarAlumnos()
        Try
            'MsgBox(Metodo_Ingreso_de_Nota)
            If Metodo_Ingreso_de_Nota.Equals("DISCIPLINA") And Acceso.Trim.Equals("Administrador") Then
                CargarDocentes()
                CmbDocente.Visible = True
            Else
                CmbDocente.Visible = False
            End If
        Catch ex As Exception
            If Utilidades.Preguntar("El Metodo de insercion de Notas no esta definido. " + vbNewLine + "¿Desea Definirlo?", "Yes") = True Then
                If Acceso = "Administrador" Or Acceso = "Director" Or Acceso = "Subdirector" Then
                    Dim frm As New FrmConfig
                    frm.WindowState = FormWindowState.Maximized
                    frm.AutoScroll = True
                    frm.ShowDialog()
                Else
                    Utilidades.Mensaje("No cuenta con acceso para realizar esta operación.")
                End If
            End If
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.PnAutorizacion.Visible = False
    End Sub

    Dim Id_Autorizador, Roll, Docente As String

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub
    Sub Autorizar()
        Dim rpta As String
        rpta = New NNotas().Autorizacion_De_Eliminacon(TxtPasword.Text.Trim)
        Dim Autorizacion As String()
        Autorizacion = rpta.Split("|")
        Roll = Autorizacion(0).ToString.Trim
        Id_Autorizador = Convert.ToInt32(Autorizacion(1))
        Docente = Autorizacion(2).ToString.Trim

        If Roll.Equals("Administrador") Or Roll.Equals("Director") Or Roll.Equals("Sub Director") Then
            rpta = New NNotas().Eliminar_Nota(DtNotas.CurrentRow.Cells(0).Value, CmbCorte.Text.Trim, id_al, TxtAño.Value, id_as)
            If rpta.Equals("Ok") Then
                'Utilidades.Mensaje("Nota Eliminada con Éxito.")
                rpta = New NNotas().Autorizacion_Eliminacion_Insertar(Id_Autorizador, UserID, id_al, CmbCorte.SelectedValue, TxtAño.Value, id_as, nota)
                If Not rpta.Equals("Ok") Then
                    Utilidades.Mensaje(rpta)
                End If
                cargar_Notas()
            Else

                cargar_Notas()
            End If

        ElseIf Roll.Equals("Docente") Then
            rpta = New NNotas().Intentos_de_Eliminacion_Insertar(Sesion, Id_Autorizador, UserID, id_al, CmbCorte.SelectedValue, TxtAño.Value, id_as, nota,
            "El Docente: " + Docente + " Intento Eliminar La nota del " + CmbCorte.Text.Trim + " de " + DtNotas.CurrentRow.Cells(2).Value.ToString + " con un valor de " + nota.ToString +
            " Del Estudiante: " + Estudiante.ToUpper + ", mientras el sitema era usado por " + User)
            Utilidades.Mensaje("No cuenta con autorización Para Eliminar registros del Sistema.", True)
        Else
            Utilidades.Mensaje("Clave de autorización incorrecta.", True)
            rpta = New NNotas().Intentos_de_Eliminacion_Insertar(Sesion, Id_Autorizador, UserID, id_al, CmbCorte.SelectedValue, TxtAño.Value, id_as, nota,
            "Se Intento Eliminar La nota del " + CmbCorte.Text.Trim + " de " + DtNotas.CurrentRow.Cells(2).Value.ToString + " con un valor de " + nota.ToString +
            " Del Estudiante: " + Estudiante.ToUpper + ", mientras el sitema era usado por " + User +
            " Con una Clave de autorización Incorrecta 'CLAVE':'" + TxtPasword.Text.Trim + "'")

        End If
        PnAutorizacion.Visible = False
        Id_Autorizador = 0
        Roll = "0"
        Docente = "0"
        txtpass.Text = ""
    End Sub
    Private Sub BtnAutorizar_Click(sender As Object, e As EventArgs) Handles BtnAutorizar.Click
        Autorizar()
    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress

    End Sub

    Private Sub TxtPasword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPasword.KeyPress

    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown


    End Sub

    Private Sub EliminarToolStripMenuItem_TextChanged(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.TextChanged

    End Sub

    Private Sub CmbDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDocente.SelectedIndexChanged
        cargarAsignaturas()
        Me.Docente_Seleccionado = CmbDocente.Text.Trim

    End Sub

    Private Sub InsertarNotasPorLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarNotasPorLoteToolStripMenuItem.Click
        Dim frm As New FrmAdd_Semestre_y_Final
        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()

    End Sub

    Private Sub TxtPasword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPasword.KeyDown
        If e.KeyValue = Keys.Enter Then
            Autorizar()
        End If
    End Sub

    Private Sub CorregirGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorregirGradoToolStripMenuItem.Click
        Dim frm As New FrmAddAsignaturaA_Notas
        frm.Show()
    End Sub

    Private Sub Datalistado_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles Datalistado.CellContextMenuStripNeeded

    End Sub

    Private Sub TxtBusqueda_Click(sender As Object, e As EventArgs) Handles TxtBusqueda.Click
        TxtBusqueda.Text = ""
    End Sub
End Class