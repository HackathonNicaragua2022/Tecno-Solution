Public Class FrmGradosPorModalidad
    Private Sub BtnNuevoGradoAsignacion_Click(sender As Object, e As EventArgs) Handles BtnNuevoGradoAsignacion.Click

    End Sub

    Private Sub FrmGradosPorModalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Asignaturas()
        Cargar_Asignaturas_por_grado()
        lblMainTitulo.Text = Escuela
    End Sub
    Sub Cargar_Asignaturas_por_grado()
        Me.DtGradoAsignacion.DataSource = New NNotas().Mostrar_AsignarAsignaturas_Por_Grado_Modalidad(CmbModalidadGrado.Text.Trim, CmbGradoAsignar.Text.Trim)
        Me.DtGradoAsignacion.Refresh()
        ' Utilidades.Mensaje("'" + CmbModalidadGrado.Text.Trim + "'" + " " + "'" + CmbGradoAsignar.Text.Trim + "'")
    End Sub
    Sub Cargar_Asignaturas()
        Me.CmbAsignaturas.DataSource = New NDocentes_Asignaciones().Mostrar_Asignaturas()
        Me.CmbAsignaturas.Refresh()
        Me.CmbAsignaturas.DisplayMember = "Nombre"
        Me.CmbAsignaturas.ValueMember = "IdAsignatura"
    End Sub

    Private Sub BtnGuardarGradoAsignado_Click(sender As Object, e As EventArgs) Handles BtnGuardarGradoAsignado.Click
        Dim rpta As String = New NNotas().AsignarAsignaturas_A_Grado_Modalidad(CmbAsignaturas.SelectedValue, CmbModalidadGrado.Text.Trim, Me.CmbGradoAsignar.Text.Trim)
        If Not rpta.Equals("Ok") Then
            Dim n As Boolean = New Utilidades().Mensaje(rpta, True)
        Else
            Me.CmbAsignaturas.Text = ""
            Cargar_Asignaturas_por_grado()
        End If
    End Sub

    Private Sub CmbGradoAsignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradoAsignar.SelectedIndexChanged
        Cargar_Asignaturas_por_grado()
    End Sub

    Private Sub CmbGradoAsignar_TextChanged(sender As Object, e As EventArgs) Handles CmbGradoAsignar.TextChanged
        Cargar_Asignaturas_por_grado()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Cargar_Asignaturas_por_grado()
    End Sub
    Public Utilidades As New Utilidades
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim rpta As String = ""
        If DtGradoAsignacion.Rows.Count > 0 Then
            If DtGradoAsignacion.CurrentRow.Cells(0).Value > 0 Then
                If Utilidades.Preguntar("¿Desea eliminar esta Asignatura del grado asignado?") = True Then
                    rpta = New NNotas().Asignaturas_Por_Grado_Modalidad_Eliminar(DtGradoAsignacion.CurrentRow.Cells(0).Value)
                    If rpta.Equals("Ok") Then
                        Utilidades.Mensaje("Asignatura eliminada con éxito.!")
                    Else
                        Utilidades.Mensaje(rpta, True)
                    End If
                End If

            End If

        End If
    End Sub
End Class