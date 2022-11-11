Imports System.Data.SqlClient

Public Class FrmAddAsignaturaA_Notas
    Dim Utilidades As New Utilidades
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("alter table Registro_de_Notas add " + TxtAsignatura.Text.Trim.ToUpper + " int null", SqlCon)

        Try
            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()

            Dim Mostrar As New SqlCommand("select * from Registro_de_Notas", SqlCon)
            Try
                SqlCon.Open()
                Dim SqlDt As New SqlDataAdapter(Mostrar)
                Dim rpta As New DataTable
                SqlDt.Fill(rpta)
                SqlCon.Close()
                Me.DataListado.DataSource = rpta
                Me.DataListado.Refresh()

            Catch ex As Exception
                Utilidades.Mensaje(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub

    Sub BuscarNotas()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("select * from Notas", SqlCon)

        Try
            SqlCon.Open()
            Dim sqldt As New SqlDataAdapter(sqlcmd)
            Dim rpt As New DataTable
            sqldt.Fill(rpt)
            Me.DataListado.DataSource = rpt
            Me.DataListado.Refresh()
            SqlCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub
    Sub BuscarAlumnos()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("select * from Matricula where anio=2022 and modalidad='Secundaria Diurna' and Estado='Activo'", SqlCon)

        Try
            SqlCon.Open()
            Dim sqldt As New SqlDataAdapter(sqlcmd)
            Dim rpt As New DataTable
            sqldt.Fill(rpt)
            Me.DataListado.DataSource = rpt
            Me.DataListado.Refresh()
            SqlCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub
    Private Sub FrmAddAsignaturaA_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarNotas()
    End Sub

    Private Sub BtnAddNota_Click(sender As Object, e As EventArgs) Handles BtnAddNota.Click

        For Each row As DataGridViewRow In DataListado.Rows
            Dim SqlCon As New SqlConnection()
            SqlCon.ConnectionString = New DConexion().Cn
            Dim sqlcmd As New SqlCommand()

            Try

                SqlCon.Open()
                sqlcmd.Connection = SqlCon
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "IngresarNota"

                sqlcmd.Parameters.AddWithValue("@id_Corte", row.Cells(1).Value)
                sqlcmd.Parameters.AddWithValue("@Id_Asignatura", row.Cells(2).Value)
                sqlcmd.Parameters.AddWithValue("@id_Alumno", row.Cells(3).Value)
                sqlcmd.Parameters.AddWithValue("@año", row.Cells(6).Value)
                sqlcmd.Parameters.AddWithValue("@Nota", row.Cells(8).Value)

                sqlcmd.ExecuteNonQuery()
                SqlCon.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
            End Try
        Next

    End Sub

    Private Sub BtnAddRendimiento_Click(sender As Object, e As EventArgs) Handles BtnAddRendimiento.Click

        For Each row As DataGridViewRow In DataListado.Rows
            Dim SqlCon As New SqlConnection()
            SqlCon.ConnectionString = New DConexion().Cn
            Dim sqlcmd As New SqlCommand()

            Try

                SqlCon.Open()
                sqlcmd.Connection = SqlCon
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "IngresarRendimiento"

                sqlcmd.Parameters.AddWithValue("@id_Corte", row.Cells(1).Value)
                sqlcmd.Parameters.AddWithValue("@Id_Asignatura", row.Cells(2).Value)
                sqlcmd.Parameters.AddWithValue("@id_Alumno", row.Cells(3).Value)
                sqlcmd.Parameters.AddWithValue("@Año", row.Cells(6).Value)
                sqlcmd.Parameters.AddWithValue("@Nota", row.Cells(8).Value)

                sqlcmd.ExecuteNonQuery()
                SqlCon.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
            End Try
        Next
    End Sub

    Sub Corregir_Grado()
        For Each row As DataGridViewRow In DataListado.Rows
            Dim SqlCon As New SqlConnection()
            SqlCon.ConnectionString = New DConexion().Cn
            Dim sqlcmd As New SqlCommand()

            Try

                SqlCon.Open()
                sqlcmd.Connection = SqlCon
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "Corregir_Grado"

                sqlcmd.Parameters.AddWithValue("@corte", 3)
                sqlcmd.Parameters.AddWithValue("@id_Alumno", row.Cells(1).Value)
                sqlcmd.Parameters.AddWithValue("@Anio", row.Cells(5).Value)
                sqlcmd.Parameters.AddWithValue("@Grado", row.Cells(2).Value)

                sqlcmd.ExecuteNonQuery()
                SqlCon.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
            End Try
        Next
    End Sub

    Private Sub BtnBuscarAlumnos_Click(sender As Object, e As EventArgs) Handles BtnBuscarAlumnos.Click
        BuscarAlumnos()
    End Sub

    Private Sub BtnCorregirGrado_Click(sender As Object, e As EventArgs) Handles BtnCorregirGrado.Click
        Corregir_Grado()
    End Sub
End Class