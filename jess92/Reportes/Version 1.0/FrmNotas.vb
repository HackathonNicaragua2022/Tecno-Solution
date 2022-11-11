Imports System.Data.SqlClient
Public Class FrmNotas
    Dim Utilidades As New Utilidades
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
    Sub CargarModalidad()
        Me.CmbModalidad.DataSource = New NMatricula().Buscar_Modalidad_Año(TxtAño.Value)
        Me.CmbModalidad.Refresh()
        Me.CmbModalidad.DisplayMember = "Modalidad"
    End Sub
    Sub CargarGrado()
        Me.CmbGrado.DataSource = New NMatricula().Buscar_Grado_Modalidad_Año(TxtAño.Value, CmbModalidad.Text.Trim)
        Me.CmbGrado.Refresh()
        Me.CmbGrado.DisplayMember = "Grado"
    End Sub
    Sub Reporte()
        Try
            Dim Grado As String = CmbGrado.Text.Trim
            Dim Corte As Int32 = CmbCorte.SelectedValue
            Dim Modalidad As String = CmbModalidad.Text.Trim
            Dim Turno As String = CmbTurno.Text.Trim
            Dim seccion As String = CmbSeccion.Text.Trim
            Dim Año As Int32 = TxtAño.Value
            Dim Carta As New Printing.PaperSize("Carta", 364, 269)
            Dim Legal As New Printing.PaperSize("Legal", 406, 269)
            Dim p As New Printing.PageSettings

            If Grado = "Primero" Or Grado = "Segundo" Then
                Try
                    Me.MostrarNota_Primero_SegundoTableAdapter.Fill(Me.DsPrincipal.MostrarNota_Primero_Segundo, Modalidad, Grado, Corte, Año, Turno, seccion)
                    ocultarReporte()
                    Me.RptPrimero_Segundo.Dock = DockStyle.Fill
                    Me.RptPrimero_Segundo.Visible = True
                    'With p
                    '    .PaperSize = Carta
                    '    .Landscape = True
                    'End With
                    'Me.RptPrimer_Segundo.SetPageSettings(p)
                    Me.RptPrimero_Segundo.RefreshReport()
                Catch ex As Exception
                    Utilidades.Mensaje(ex.Message)
                    Me.RptPrimero_Segundo.RefreshReport()
                End Try
            ElseIf Grado.Equals("Tercero") Or Grado.Equals("Cuarto") Or
                Grado.Equals("Quinto") Or Grado.Equals("Sexto") Then
                Try
                    Me.MostrarNota_Tercero_A_SextoTableAdapter.Fill(Me.DsPrincipal.MostrarNota_Tercero_A_Sexto, Modalidad, Grado, Corte, Año, Turno, seccion)
                    ocultarReporte()
                    Me.RptTercero_Sexto.Dock = DockStyle.Fill
                    Me.RptTercero_Sexto.Visible = True
                    'With p
                    '    .PaperSize = Legal
                    '    .Landscape = True
                    'End With
                    'Me.RptPrimer_Segundo.SetPageSettings(p)
                    Me.RptTercero_Sexto.RefreshReport()
                Catch ex As Exception
                    Utilidades.Mensaje(ex.Message)
                    Me.RptTercero_Sexto.RefreshReport()
                End Try
            ElseIf Grado.Equals("SEPTIMO") Or Grado.Equals("OCTAVO") Or
            Grado.Equals("NOVENO") Or Grado.Equals("DÉCIMO") Or Grado.Equals("UNDÉCIMO") Then
                Try
                    Me.Mostrar_Nota_SecundariaTableAdapter.Fill(Me.DsPrincipal.Mostrar_Nota_Secundaria, Modalidad, Turno, Grado, seccion, Corte, Año)
                    ocultarReporte()
                    Me.RptSecundaria.Dock = DockStyle.Fill
                    Me.RptSecundaria.Visible = True
                    'With p
                    '    .PaperSize = Legal
                    '    .Landscape = True
                    'End With
                    'Me.RptPrimer_Segundo.SetPageSettings(p)
                    Me.RptSecundaria.RefreshReport()
                Catch ex As Exception
                    Me.RptSecundaria.RefreshReport()
                End Try
            End If
        Catch ex As Exception
            ' Me.RptPrimer_Segundo.RefreshReport()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs)

    End Sub
    Sub ocultarReporte()
        Me.RptPrimero_Segundo.Visible = False
        Me.RptTercero_Sexto.Visible = False
        Me.RptSecundaria.Visible = False
        'Me.RptPrimaria.Visible = False

        Me.RptPrimero_Segundo.Dock = DockStyle.None
        Me.RptTercero_Sexto.Dock = DockStyle.None
        Me.RptSecundaria.Dock = DockStyle.None
        ' Me.RptPrimaria.Dock = DockStyle.None

        Dim p As New Printing.PageSettings
        p.Landscape = True
        Me.RptPrimero_Segundo.SetPageSettings(p)
        Me.RptTercero_Sexto.SetPageSettings(p)
        Me.RptSecundaria.SetPageSettings(p)
        ' Me.RptPrimaria.SetPageSettings(p)
    End Sub
    Private Sub FrmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TxtAño.Value = Year(Now)
        'CargarModalidad()
        CargarCorte()
        ocultarReporte()
    End Sub

    Private Sub TxtAño_ValueChanged(sender As Object, e As EventArgs) Handles TxtAño.ValueChanged
        Cargar_Modalidad(CmbModalidad, TxtAño.Value)
    End Sub

    Private Sub CbmModalidad_SelectedIndexChanged(sender As Object, e As EventArgs)
        CargarGrado()
    End Sub

    Private Sub UI_CustomButton1_Click(sender As Object, e As EventArgs) Handles UI_CustomButton1.Click
        Reporte()
    End Sub

    Private Sub CmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrado.SelectedIndexChanged
        cargar_Seccion(CmbSeccion, TxtAño.Value, CmbModalidad.Text.Trim, CmbTurno.Text.Trim, CmbGrado.Text.Trim)
    End Sub

    Private Sub CmbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModalidad.SelectedIndexChanged
        Cargar_Turno(CmbTurno, TxtAño.Value, CmbModalidad.Text.Trim)
    End Sub

    Private Sub CmbTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTurno.SelectedIndexChanged
        cargar_Grado(CmbGrado, TxtAño.Value, CmbModalidad.Text.Trim, CmbTurno.Text.Trim)
    End Sub

    Private Sub CmbSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSeccion.SelectedIndexChanged

    End Sub
End Class