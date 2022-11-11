Imports SpreadsheetLight
Imports System.Data.OleDb

Public Class FrmMatriculaInicial
    Dim Utilidades As New Utilidades
    Dim Id_M_Inicial As Int32 = 0
    Dim IsNuevo As Boolean = False
    Dim IsEditar As Boolean = False

    Sub Limpiar_Txt()
        Me.Id_M_Inicial = 0
        Me.TxtAño.Text = ""
        Me.CmbEModalidad.Text = ""
        Me.CmbETurno.Text = ""
        Me.CmbEGrado.Text = ""
        Me.CmbESeccion.Text = ""
        Me.TxtAs.Text = ""
        Me.TxtF.Text = ""
    End Sub

    Sub Habilitar_Txt(Valor As Boolean)
        Me.TxtAño.UIReadOnly = Not Valor
        Me.CmbEModalidad.Enabled = Valor
        Me.CmbETurno.Enabled = Valor
        Me.CmbEGrado.Enabled = Valor
        Me.CmbESeccion.Enabled = Valor
        Me.TxtAs.UIReadOnly = Not Valor
        Me.TxtF.UIReadOnly = Not Valor
    End Sub

    Sub Botones()
        If IsNuevo Or IsEditar Then
            Me.BtnGuardar.Enabled = True
            Me.BtnCancelar.Enabled = True
            Me.BtnNuevo.Enabled = False
            Me.BtnEditar.Enabled = False
        Else
            Me.BtnGuardar.Enabled = False
            Me.BtnCancelar.Enabled = False
            Me.BtnNuevo.Enabled = True
            Me.BtnEditar.Enabled = False
        End If
    End Sub
    Private Sub DtExcelenciaAcademica_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub UI_TitleBanner1_Click(sender As Object, e As EventArgs) Handles UI_TitleBanner1.Click

    End Sub

    Sub buscar()
        Me.DataListado.DataSource = New NM_Inicial().Buscar(TxtBusqueda.Text)
        Me.DataListado.Refresh()
        Try
            Me.DataListado.Columns(0).Visible = False
            Me.LblTotalRegistros.Text = DataListado.Rows.Count.ToString + " Registros en Total."
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmMatriculaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar()
        Utilidades.Alternar_Color_DatagridView(DataListado)
        IsNuevo = False
        IsEditar = False
        Botones()
        Habilitar_Txt(False)
    End Sub
    Public Function Validar() As Boolean
        Dim rpta As Boolean = False
        Erp.Clear()
        If Me.TxtAño.Text = "" Then
            Erp.SetError(TxtAño, "Por favor digite un año valido")
            rpta = False

        End If

        If CmbEModalidad.Text = "" Then
            Erp.SetError(CmbEModalidad, "Especifique la modalidad")
            rpta = False
        End If
        If CmbEModalidad.Text = "" Then
            Erp.SetError(CmbETurno, "Especifique el Turno")
            rpta = False
        End If
        If CmbEGrado.Text = "" Then
            Erp.SetError(CmbEGrado, "Especifique el grado")
            rpta = False
        End If
        If CmbESeccion.Text = "" Then
            Erp.SetError(CmbESeccion, "Especifique la seccion")
            rpta = False
        End If

        If Me.TxtAño.Text <> "" And Me.TxtAs.Text <> "" And Me.TxtF.Text <> "" And Me.CmbEModalidad.Text <> "" And CmbETurno.Text <> "" And
                Me.CmbEGrado.Text <> "" And Me.CmbESeccion.Text <> "" Then
            rpta = True
        Else
            rpta = False
        End If
        If Val(Me.TxtAño.Text) < 2022 Then
            Erp.SetError(TxtAño, "Por favor digite un año valido")
            rpta = False
        End If
        If Me.TxtAño.Text.Length > 4 Then
            Erp.SetError(TxtAño, "Por favor digite un año valido")
            rpta = False
        End If
        If Val(TxtAs.Text) < Val(TxtF.Text) Then
            Erp.SetError(TxtAs, "El total de la matrícula no puede ser menor que el total de femeninos")
            rpta = False
        End If

        Return rpta

    End Function
    Sub cargar_Modalidad()
        Me.CmbEModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(Val(TxtAño.Text))
        Me.CmbEModalidad.Refresh()
        Me.CmbEModalidad.DisplayMember = "Modalidad"
    End Sub
    Sub cargar_Modalidad_Turno_E()
        Me.CmbETurno.DataSource = New NMatricula().Buscar_Turno_Año(CmbEModalidad.Text.Trim, Val(TxtAño.Text))
        Me.CmbETurno.Refresh()
        Me.CmbETurno.DisplayMember = "Turno"
    End Sub
    Sub cargar_Modalidad_Turno_Grado_E()
        Me.CmbEGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año_Turno(Val(TxtAño.Text), CmbEModalidad.Text.Trim, CmbETurno.Text.Trim)
        Me.CmbEGrado.Refresh()
        Me.CmbEGrado.DisplayMember = "Grado"
    End Sub
    Sub cargar_Modalidad_Turno_Grado_Seccion_E()
        Me.CmbESeccion.DataSource = New NMatricula().Buscar_Seccion_Grado_Modalidad_Año_Turno(Val(TxtAño.Text), CmbEModalidad.Text.Trim, CmbETurno.Text.Trim, CmbEGrado.Text.Trim)
        Me.CmbESeccion.Refresh()
        Me.CmbESeccion.DisplayMember = "Seccion"
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Insertar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        IsNuevo = True
        IsEditar = False
        Limpiar_Txt()
        Botones()
        Habilitar_Txt(True)

        Me.TxtAño.Text = Year(Now).ToString
        cargar_Modalidad()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        IsNuevo = False
        IsEditar = False
        Habilitar_Txt(False)
        Limpiar_Txt()
        Botones()
    End Sub

    Private Sub CmbEModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEModalidad.SelectedIndexChanged
        cargar_Modalidad_Turno_E()
    End Sub

    Private Sub CmbETurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbETurno.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_E()
    End Sub

    Private Sub CmbEGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEGrado.SelectedIndexChanged
        cargar_Modalidad_Turno_Grado_Seccion_E()
    End Sub

    Sub Insertar()
        Dim rpta As String = ""
        If Validar() = True Then
            If IsNuevo Then
                rpta = New NM_Inicial().Insertar(Val(TxtAño.Text), CmbEModalidad.Text, CmbETurno.Text, CmbEGrado.Text,
                                               CmbESeccion.Text, Val(TxtAs.Text), Val(TxtF.Text))
                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Registro ingresado con éxito.")
                ElseIf rpta = "Esta Matrícula ya ha sido ingresada" Then
                    Utilidades.Mensaje("El Registro ya existe. por favor verifique los datos")

                End If
            ElseIf IsEditar Then
                rpta = New NM_Inicial().Editar(Id_M_Inicial, Val(TxtAño.Text), CmbEModalidad.Text, CmbETurno.Text, CmbEGrado.Text,
                                               CmbESeccion.Text, Val(TxtAs.Text), Val(TxtF.Text))
                If rpta.Equals("Ok") Then
                    Utilidades.Mensaje("Registro actualizado con éxito.")
                End If
            End If
            If rpta.Equals("Ok") Then
                buscar()
                IsNuevo = False
                IsEditar = False
                Botones()
                Limpiar_Txt()
                Habilitar_Txt(False)
            ElseIf rpta <> "Esta Matrícula ya ha sido ingresada" Then
                Utilidades.Mensaje(rpta)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        IsNuevo = False
        IsEditar = True
        Habilitar_Txt(True)
        Botones()
    End Sub

    Private Sub CmbEModalidad_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbEModalidad.KeyDown
        e.Handled = True
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        buscar()
    End Sub

    Private Sub CmbEModalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEModalidad.KeyPress
        e.Handled = True

    End Sub



    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub
    Sub Trasladar_Datos()
        Try
            If DataListado.Rows.Count > 0 Then
                Me.Id_M_Inicial = Val(DataListado.CurrentRow.Cells(0).Value)
                Me.TxtAño.Text = DataListado.CurrentRow.Cells(8).Value
                Me.CmbEModalidad.Text = DataListado.CurrentRow.Cells(1).Value
                Me.CmbETurno.Text = DataListado.CurrentRow.Cells(2).Value
                Me.CmbEGrado.Text = DataListado.CurrentRow.Cells(3).Value
                Me.CmbESeccion.Text = DataListado.CurrentRow.Cells(4).Value
                Me.TxtAs.Text = DataListado.CurrentRow.Cells(5).Value
                Me.TxtF.Text = DataListado.CurrentRow.Cells(6).Value
                Me.BtnEditar.Enabled = True
                UI_TabControl1.SelectTab(1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        Trasladar_Datos()

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Trasladar_Datos()
        BtnEditar_Click(sender, e)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Sub Eliminar()
        Dim rpta As String = ""
        Dim TotalErrores As Int32 = 0
        Try
            If Utilidades.Preguntar("¿Desea eliminar todos los registros seleccionados?", "NO") = True Then
                For Each Row As DataGridViewRow In DataListado.SelectedRows
                    rpta = New NM_Inicial().Eliminar(Val(Row.Cells(0).Value))
                    If Not rpta.Equals("Ok") Then
                        TotalErrores += 1
                    End If
                Next
                If TotalErrores > 0 Then
                    Utilidades.Mensaje("Ocurrieron Errores durante el proceso verifique los datos. seran actualizados.")
                Else
                    Utilidades.Mensaje("Operacion realizado con éxito.")
                End If
                buscar()
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        buscar()
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
        sl.SetColumnWidth(1, 36.29)
        sl.SetColumnWidth(2, 9.97)
        sl.SetColumnWidth(3, 21.57)
        sl.SetColumnWidth(4, 9.94)

        sl.Filter(1, 1, DataListado.Rows.Count + 1, DataListado.Columns.Count - 1)

        '   RECORRER LOS ROTULOS DEL GRID

        For Each Col As DataGridViewColumn In DataListado.Columns
            sl.SetCellValue(1, cl, Col.HeaderText.ToString)
            sl.SetCellStyle(1, cl, Estilo)
            cl += 1
            If cl = (DataListado.Columns.Count) Then Exit For
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

        For Each Row As DataGridViewRow In DataListado.Rows
            For i = 1 To DataListado.Columns.Count - 1
                sl.SetCellValue(Fila, i, Row.Cells(i).Value)
                sl.SetCellStyle(Fila, i, Estilo2)
            Next


            Fila += 1
        Next
        Dim ruta As String


        ruta = dir + "\Matricula Inicial " + Year(Now).ToString + ".xlsx"


        Try
            sl.SaveAs(ruta)
            Dim mensaje As String = "Registro guardado en: " + vbNewLine + ruta

        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Exportar()
    End Sub

    Private Sub CmbETurno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbETurno.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbEGrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbESeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbESeccion.KeyPress
        e.Handled = True
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        BtnNuevo_Click(sender, e)
        UI_TabControl1.SelectTab(1)
    End Sub
End Class