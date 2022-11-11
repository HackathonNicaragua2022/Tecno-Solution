Public Class FrmNotas_Por_Alumno
    Public id_alumno As Int32
    Dim utilidades As New Utilidades
    Sub Buscar()
        ' MsgBox(id_alumno)
        Me.Datalistado.DataSource = New Nalumnos().Mostrar_Notas(id_alumno, Val(CmbAño.Text))
        Datalistado.Refresh()
        Dim rendimiento As Int32 = 0
        Dim n As Int32 = 0
        Try
            If Datalistado.Rows.Count > 0 Then
                Me.LblAlumno.Text = Datalistado.CurrentRow.Cells(4).Value.ToString
                Me.LblId_Mined.Text = Datalistado.CurrentRow.Cells(5).Value.ToString
                Me.TxtGrado.Text = Datalistado.CurrentRow.Cells(2).Value.ToString
                Me.TxtModalidad.Text = Datalistado.CurrentRow.Cells(3).Value.ToString

                Me.Datalistado.Columns(1).Visible = False
                Me.Datalistado.Columns(2).Visible = False
                Me.Datalistado.Columns(3).Visible = False
                Me.Datalistado.Columns(4).Visible = False
                Me.Datalistado.Columns(5).Visible = False

                For Each row As DataGridViewRow In Datalistado.Rows
                    rendimiento += row.Cells(12).Value
                    n += 1
                Next
            End If
            LblRendimiento.Text = (rendimiento / n).ToString + " %"
            ' MsgBox(rendimiento.ToString + " " + n.ToString)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmNotas_Por_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbAño.Text = Year(Now)
        Me.LblTitulo.Text = "NOTAS " + Escuela + " (" + Codigo_Escuela + ")"
        utilidades.Alternar_Color_DatagridView(Datalistado)
        ' MsgBox(id_alumno)
        Buscar()


    End Sub

    Private Sub CmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAño.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub CmbAño_TextChanged(sender As Object, e As EventArgs) Handles CmbAño.TextChanged
        Buscar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Buscar()
    End Sub
End Class