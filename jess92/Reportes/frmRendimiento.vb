Imports System.Data.SqlClient

Public Class frmRendimiento
    Dim Utilidades As New Utilidades()
    Private Sub frmRendimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtAño.Value = Year(Now())
        Cargar_Cortes()
        cargar_Modalidad(TxtAño.Value)
    End Sub

    Sub Cargar_Cortes()
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

    Sub cargar_Modalidad(Año As Int32)
        Me.CmbModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(Año)
        Me.CmbModalidad.Refresh()
        Me.CmbModalidad.DisplayMember = "Modalidad"
    End Sub
    Sub cargar_Turno(Modalidad As String, Año As Int32)
        Me.CmbTurno.DataSource = New NMatricula().Buscar_Turno_Año(Modalidad, Año)
        Me.CmbTurno.Refresh()
        Me.CmbTurno.DisplayMember = "Turno"
    End Sub

    Function Validar() As Boolean
        Dim rpta As String = ""
        rpta = New NRendimiento().Validar_Matricula_Inicial(TxtAño.Value, CmbModalidad.Text.Trim)
        If rpta.Equals("Ok") Then
            Return True
        Else
            Utilidades.Mensaje(rpta)
            Return False
        End If
    End Function
    Private Sub UI_CustomButton1_Click(sender As Object, e As EventArgs) Handles BtnInforme.Click
        If Validar() = False Then
            If Utilidades.Preguntar("¿Desea actualizar la Matrícula Inicial para esta modalidad?", "Si") = True Then
                Dim frm As New FrmMatriculaInicial
                frm.ShowIcon = True
                frm.Show()
            Else
                Utilidades.Mensaje("El Rendimiento no se calculara hasta que actualice la matrícula Inicial para esta modalidad", True)
                Exit Sub
            End If
        End If

        If CmbModalidad.Text.Trim.Equals("SECUNDARIA DIURNA") Or CmbModalidad.Text.Trim.Equals("SECUNDARIA EN EL CAMPO") Or CmbModalidad.Text.Trim.Equals("SECUNDARIA REGULAR") Then
            Try
                RptSecundaria.Dock = DockStyle.Fill
                RptSecundaria.BringToFront()
                RptPrimaria.Visible = False
                RptSecundaria.Visible = True
                Me.Ra_Secundaria_2TableAdapter.Fill(Me.DsPrincipal.Ra_Secundaria_2, CmbCorte.SelectedValue, CmbModalidad.Text.Trim, CmbTurno.Text.Trim, TxtAño.Value)
                RptSecundaria.RefreshReport()

            Catch ex As Exception
                Utilidades.Mensaje(ex.Message)
                RptSecundaria.RefreshReport()
            End Try

        ElseIf CmbModalidad.Text.Trim.Equals("PRIMARIA REGULAR") Or CmbModalidad.Text.Trim.Equals("PRIMARIA MULTIGRADO") Then
            Try
                RptPrimaria.Dock = DockStyle.Fill
                RptPrimaria.BringToFront()
                RptPrimaria.Visible = True
                RptSecundaria.Visible = False
                Me.Ra_Primaria_2TableAdapter.Fill(Me.DsPrincipal.Ra_Primaria_2, CmbCorte.SelectedValue, CmbModalidad.Text.Trim, CmbTurno.Text.Trim, TxtAño.Value)
                Me.RptPrimaria.RefreshReport()
                'MsgBox(CmbModalidad.Text.Trim + "_" + CmbCorte.SelectedValue.ToString + "_" + TxtAño.Value.ToString + " " + Me.Sp_Rendimiento_PrimariaTableAdapter.Connection.ConnectionTimeout.ToString)
            Catch ex As Exception
                Me.RptPrimaria.RefreshReport()
                'MsgBox(ex.Message + vbNewLine + CmbModalidad.Text.Trim + "_" + CmbCorte.SelectedValue.ToString + "_" + TxtAño.Value.ToString + " " + Me.Sp_Rendimiento_PrimariaTableAdapter.Connection.ConnectionTimeout.ToString)
            End Try
        End If
    End Sub

    Private Sub UI_CustomButton1_Click_1(sender As Object, e As EventArgs) Handles UI_CustomButton1.Click
        Try
            RptSecundaria.Dock = DockStyle.Fill
            RptSecundaria.BringToFront()
            RptPrimaria.Visible = False
            RptSecundaria.Visible = True
            'Me.Rendimiento_SecundariaTableAdapter.Fill(Me.DsPrincipal.Rendimiento_Secundaria, CmbCorte.SelectedValue, CmbModalidad.Text.Trim, TxtAño.Value)
            RptSecundaria.RefreshReport()
            MsgBox(CmbModalidad.Text.Trim + "_" + CmbCorte.SelectedValue.ToString + "_" + TxtAño.Value.ToString)
        Catch ex As Exception
            RptSecundaria.RefreshReport()
        End Try
    End Sub

    Private Sub UI_CustomButton2_Click(sender As Object, e As EventArgs) Handles UI_CustomButton2.Click
        'Try
        '    Rpt_Secundaria2.Dock = DockStyle.Fill
        '    Rpt_Secundaria2.BringToFront()
        '    RptPrimaria.Visible = False
        '    Rpt_Secundaria2.Visible = True
        'Me.Rendimiento_Secundaria_2TableAdapter.Fill(Me.DsPrincipal.Rendimiento_Secundaria_2, CmbCorte.SelectedValue, CmbModalidad.Text.Trim, TxtAño.Value)

        'Rpt_Secundaria2.RefreshReport()
        'Catch ex As Exception
        '    Rpt_Secundaria2.RefreshReport()
        'End Try
    End Sub

    Private Sub TxtAño_ValueChanged(sender As Object, e As EventArgs) Handles TxtAño.ValueChanged
        cargar_Modalidad(TxtAño.Value)
    End Sub

    Private Sub CmbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidad.SelectedIndexChanged
        cargar_Turno(CmbModalidad.Text.Trim, TxtAño.Value)
    End Sub
End Class