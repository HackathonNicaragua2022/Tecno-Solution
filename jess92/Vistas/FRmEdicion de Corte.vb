Imports System.Data, System.Data.SqlClient
Public Class FRmEdicion_de_Corte
    Dim Utilidades As New Utilidades
    Dim IsNuevo, IsEditar As Boolean

    Private Sub BtnNuevaAsigbatura_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.TxtCorte.Clear()
        Me.TxtIdCorte.Clear()
        Me.TxtIdCorte.ReadOnly = False
        Me.TxtCorte.ReadOnly = False
        IsNuevo = True
        IsEditar = False
        Botones()
        Me.ActiveControl = TxtCorte
    End Sub
    Sub Botones()
        If IsNuevo Or IsEditar Then
            BtnNuevo.Enabled = False
            BtnCancelar.Enabled = True
            BtnGuardar.Enabled = True
        Else
            BtnNuevo.Enabled = True
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.TxtCorte.Clear()
        Me.TxtIdCorte.Clear()
        Me.TxtIdCorte.ReadOnly = True
        Me.TxtCorte.ReadOnly = True
        IsNuevo = False
        IsEditar = False
        Botones()
    End Sub
    Sub Mostrar()
        Me.DataListado.DataSource = CargarCorte()
        Me.DataListado.Refresh()
    End Sub
    Function Validar() As Boolean
        Dim rpta As Boolean = True
        For Each Row As DataGridViewRow In DataListado.Rows
            If Row.Cells(1).ToString = TxtCorte.Text.Trim.ToUpper Then
                rpta = False
                Exit For
            End If
        Next
        Return rpta
    End Function
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Rpta As String = ""
        If IsNuevo Then
            If TxtCorte.Text <> String.Empty And TxtCorte.Text.Length >= 5 And Validar() = True Then
                Rpta = Insertar_Corte()
                If Rpta.Equals("Ok") Then
                    Mostrar()
                Else
                    Utilidades.Mensaje(Rpta, True)
                End If
            End If
        ElseIf IsEditar Then
            If TxtCorte.Text <> String.Empty And TxtCorte.Text.Length > 6 And Val(TxtIdCorte.Text.Trim) > 0 Then
                Rpta = Editar_Corte()
                If Rpta.Equals("Ok") Then
                    Mostrar()
                Else
                    Utilidades.Mensaje(Rpta, True)
                End If
            End If

        End If
        If Rpta.Equals("Ok") Then
            Mostrar()
            TxtIdCorte.Clear()
            TxtCorte.Clear()
            TxtIdCorte.ReadOnly = True
            TxtCorte.ReadOnly = True
        End If
    End Sub

    Private Sub FRmEdicion_de_Corte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.Alternar_Color_DatagridView(DataListado)
        Mostrar()
        TxtIdCorte.Clear()
        TxtCorte.Clear()
        TxtIdCorte.ReadOnly = True
        TxtCorte.ReadOnly = True
        IsNuevo = False
        IsEditar = False
        Botones()

    End Sub

    Function CargarCorte() As DataTable
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
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta

    End Function

    Function Insertar_Corte() As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "insert into Corte (Nombre) Values(@Nombre)"
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.Connection = sqlcon
            SqlCmd.Parameters.AddWithValue("@Nombre", TxtCorte.Text.Trim.ToUpper)


            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error."
            End If
        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta

    End Function

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        Me.TxtIdCorte.Text = DataListado.CurrentRow.Cells(0).Value
        Me.TxtCorte.Text = DataListado.CurrentRow.Cells(1).Value.ToString.Trim
        Me.TxtCorte.ReadOnly = False
        IsEditar = True
        IsNuevo = False
        Botones()
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        Dim titulo As String
        titulo = DataListado.Columns.Item(1).Name.ToString
        'MsgBox(titulo)
    End Sub

    Function Editar_Corte() As String
        Dim sqlcon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim Rpta As String = ""
        Try
            sqlcon.ConnectionString = New DConexion().Cn
            sqlcon.Open()

            SqlCmd.CommandText = "Update Corte set Nombre=@Nombre where IdCorte=@Id"
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.Connection = sqlcon
            SqlCmd.Parameters.AddWithValue("@Nombre", TxtCorte.Text.Trim.ToUpper)
            SqlCmd.Parameters.AddWithValue("@Id", Val(TxtIdCorte.Text.Trim))


            If SqlCmd.ExecuteNonQuery = 1 Then
                Rpta = "Ok"
            Else
                Rpta = "Ocurrio un error."
            End If
        Catch ex As Exception
            Rpta = ex.Message
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

        Return Rpta

    End Function
End Class