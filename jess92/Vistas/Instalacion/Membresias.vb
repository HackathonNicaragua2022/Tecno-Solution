﻿Imports System.Data.SqlClient
Imports System.Xml
Imports System.Management
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Membresias
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private aes As New AES()
    Sub mostrar_nombre_de_admin()
        ' Dim SqlCon As New SqlConnection(New Conexion().Cn)
        'Dim importe As Double
        'Dim com As New SqlCommand("Select Nombre_y_Apelllidos from USUARIO2 where Login='admin'", SqlCon)

        Try

            '   SqlCon.Open()
            '  importe = (com.ExecuteScalar())
            ' SqlCon.Close()
            'lblnombreAdmin.Text = importe

        Catch ex As Exception

        End Try


    End Sub
    Sub mostrar_empresa()
        'Dim Sqlcon As New SqlConnection(New dConexion().Cn)
        'Dim importe As Double
        'Dim com As New SqlCommand("Select Nombre_Empresa from EMPRESA", Sqlcon)

        'Try
        '    Sqlcon.Open()
        '    importe = (com.ExecuteScalar())
        '    Sqlcon.Close()
        '    lblEmpresa.Text = importe

        'Catch ex As Exception

        'End Try


    End Sub
    Sub mostrar_correo_de_empresa()

        'Dim Sqlcon As New SqlConnection(New Conexion().Cn)
        'Dim importe As String
        'Dim com As New SqlCommand("Select Correo_para_envio_de_reportes from EMPRESA", Sqlcon)

        Try
            'Sqlcon.Open()
            'importe = (com.ExecuteScalar())
            'Sqlcon.Close()
            'txtcorreo.Text = importe

        Catch ex As Exception

        End Try


    End Sub
    Sub crear_licencia()


        Dim CMD As SqlCommand
        Try
            ' abrirWEB()
            ' CMD = New SqlCommand("Insertar_lic", conexionWEB)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Serial_pc", txtSerial.Text)
            CMD.Parameters.AddWithValue("@Serial_Licencia", "Ninguna")
            CMD.Parameters.AddWithValue("@Fecha_de_finalizacion", Now())
            CMD.Parameters.AddWithValue("@Estado", "PENDIENTE")
            CMD.Parameters.AddWithValue("@Nombre_admin", lblnombreAdmin.Text)
            CMD.Parameters.AddWithValue("@Empresa", lblEmpresa.Text)
            CMD.Parameters.AddWithValue("@Correo", txtcorreo.Text)
            CMD.Parameters.AddWithValue("@Periodo", "1 mes (es)")
            CMD.Parameters.AddWithValue("@Software", "Ada_369")
            CMD.Parameters.AddWithValue("@Fecha_de_solicitud", Now())
            CMD.Parameters.AddWithValue("@Fecha_de_activacion", Now())
            CMD.ExecuteNonQuery()
            '  CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
            PanelConexion.Visible = True
            Label7.Text = "Sin conexion a Internet "
            desconectado.Visible = True
        End Try
    End Sub
    Public Sub ReadfromXML_SERIAL_PC()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(lblruta.Text)
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            lblarchivo1.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox(ex.Message)

        End Try
    End Sub
    Dim dbcnString As String
    Sub MOSTRAR_licencia_temporal()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim Sqlcon As New SqlConnection(New DConexion().Cn)
        Try
            Sqlcon.Open()
            da = New SqlDataAdapter("SELECT * FROM Marcan", Sqlcon)

            da.Fill(dt)
            datalistado_licencia_temporal.DataSource = dt
            Sqlcon.Close()


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With dlg
            .InitialDirectory = ""
            .Filter = "Licencia J E S S 92|*.xml"
            .FilterIndex = 2
            .Title = "Cargador de Licencia  J E S S 92"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                lblruta.Text = Path.GetFullPath(dlg.FileName)
                ReadfromXML_SERIAL_PC()
                Dim cadena As String = lblarchivo1.Text

                Dim separadas As String()

                separadas = cadena.Split("|")
                lblSerial.Text = separadas(1)
                lblFecha.Text = separadas(2)
                lblEstado.Text = separadas(3)
                lblSoftware.Text = separadas(4)

                Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
                lblIDSERIAL.Text = serialDD.Properties("SerialNumber").Value.ToString
                lblIDSERIAL.Text = Encriptar(lblIDSERIAL.Text.Trim())
            Catch ex As Exception

            End Try

            'MsgBox(lblSerial.Text + " " + lblSoftware.Text.Trim + " " + lblIDSERIAL.Text)

            If lblSoftware.Text.Trim = "Control_Estudiantil" And lblEstado.Text = "PENDIENTE" And lblSerial.Text.Trim = lblIDSERIAL.Text.Trim Then
                'MsgBox("Instalando Licencia")
                ACTIVACION_DE_LICENCIA_manual()
                MOSTRAR_licencia_temporal()


                Try
                    txtfecha_final_licencia_temporal.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)
                    lblSerialPcLocal.Text = (datalistado_licencia_temporal.SelectedCells.Item(2).Value.Trim)
                    LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
                    txtfecha_inicio_licencia.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(5).Value.Trim)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'MsgBox(lblSerialPcLocal.Text + " = " + lblIDSERIAL.Text)
                If txtfecha_final_licencia_temporal.Value >= txtfecha_inicio_licencia.Value And lblSerialPcLocal.Text = lblIDSERIAL.Text Then
                    'If txtfecha_inicio_licencia.Value <= txtfecha_final_licencia_temporal.Value Then
                    ' MsgBox(LBLESTADOLicenciaLocal.Text)
                    If LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
                        PanelActivando_licencia.Visible = True
                        PanelActivando_licencia.Dock = DockStyle.Fill
                        'PictureBox1.Visible = False
                        lblActivando_licencia.Text = "Licencia Activada hasta " & lblFecha.Text
                    End If


                    ' Else

                    'End If
                End If



            Else
                MessageBox.Show("Archivo de licencia rechazado por Datos Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

        'cargarLicencia_solicitada()
        'Try
        '    Label6.Text = datalistadoLicencias.SelectedCells.Item(1).Value
        '    lblActivando_licencia.Text = "Ya solicitaste tu Licencia vuelve a abrir el Aplicativo mas tarde"
        'Catch ex As Exception
        '    crear_licencia()
        '    lblActivando_licencia.Text = "Aun no Realizas la Compra de tu Licencia, se te direccionara a nuestra pagina Web: magbri.co"
        'End Try


        ''ACTIVAR_LICENCIA.ShowDialog()

    End Sub
    Sub cargarLicencia_solicitada()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim Sqlcon As New SqlConnection(New DConexion().Cn)
        Try
            Sqlcon.Open()
            da = New SqlDataAdapter("mostrar_estado_de_licencia", Sqlcon)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial", txtSerial.Text)

            da.Fill(dt)
            datalistadoLicencias.DataSource = dt
            Sqlcon.Close()
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub ACTIVACION_DE_LICENCIA_manual()
        Dim SERIALpC As String
        Dim Sqlcon As New SqlConnection(New DConexion().Cn)
        SERIALpC = (Me.lblIDSERIAL.Text.Trim)

        Dim FECHA_FINAL As String
        FECHA_FINAL = Encriptar(Me.lblFecha.Text.Trim)
        Dim estado As String
        estado = Encriptar("?ACTIVADO PRO?")
        Dim fecha_activacion
        fecha_activacion = Encriptar(Me.TXTFECHA_SISTEMA.Text.Trim)
        Dim CMD As SqlCommand
        Try
            Sqlcon.Open()
            CMD = New SqlCommand("EDITAR_marcan_a", Sqlcon)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@e", estado)
            CMD.Parameters.AddWithValue("@fa", fecha_activacion)
            CMD.Parameters.AddWithValue("@f", FECHA_FINAL)
            CMD.Parameters.AddWithValue("@s", SERIALpC)

            CMD.ExecuteNonQuery()
            Sqlcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ACTIVACION_DE_LICENCIA_Temporal()
        Dim SERIALpC As String
        Dim Sqlcon As New SqlConnection(New DConexion().Cn)
        SERIALpC = (Me.lblIDSERIAL.Text.Trim)

        Dim FECHA_FINAL As String
        FECHA_FINAL = Encriptar(Me.lblFecha.Text.Trim)
        Dim estado As String
        estado = Encriptar("?ACTIVO?")
        Dim fecha_activacion
        fecha_activacion = Encriptar(Me.TXTFECHA_SISTEMA.Text.Trim)
        Dim CMD As SqlCommand
        Try
            Sqlcon.Open()
            CMD = New SqlCommand("Insertar_marcan", Sqlcon)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@e", estado)
            CMD.Parameters.AddWithValue("@fa", fecha_activacion)
            CMD.Parameters.AddWithValue("@f", FECHA_FINAL)
            CMD.Parameters.AddWithValue("@s", SERIALpC)

            CMD.ExecuteNonQuery()
            Sqlcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub SavetoXML_SERIAL_LICENCIA(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        ''doc.Load("Serial_l.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Serial_l.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Serial_l = dbcnString
        'utilidades.AddUpdateAppSettingns("Serial_l", dbcnString)
    End Sub
    Public Sub SavetoXML_SERIAL_PC(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Serial_x.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Serial_x.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Serial_x = dbcnString
        ' utilidades.AddUpdateAppSettingns("Serial_x", dbcnString)
    End Sub
    Public Sub SavetoXML_fecha_expiracion(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Serial_ff.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Serial_ff.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Serial_ff = dbcnString
        My.Settings.Save()
        'utilidades.AddUpdateAppSettingns("Serial_ff", dbcnString)
    End Sub
    Dim utilidades As New Utilidades
    Sub Activar_licencia()
        Dim CMD As SqlCommand
        Try
            ' abrirWEB()
            ' CMD = New SqlCommand("Activar_l", conexionWEB)
            'CMD.CommandType = CommandType.StoredProcedure
            'CMD.Parameters.AddWithValue("@id", datalistado_licencias.SelectedCells.Item(1).Value)
            'CMD.Parameters.AddWithValue("@Fecha_de_activacion", Now())
            'CMD.ExecuteNonQuery()
            '  CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Membresias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        txtSerial.Text = serialDD.Properties("SerialNumber").Value.ToString
        txtSerial.Text = Encriptar(txtSerial.Text.Trim())
        'mostrar_correo_de_empresa()
        mostrar_nombre_de_admin()
        mostrar_empresa()

        'ACTIVACION_AUTOMATICA_DE_LICENCIA()


    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        ' crear_licencia()

        Try

            ' System.Diagnostics.Process.Start("https://magbri.co/product/sistema-de-ventas-magbriventa/")
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub Membresias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    '    Close()

    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReadfromXML_SERIAL_PC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    Dim serialWeb As String
    Sub Obtener_serial_web()
        Try
            Dim cmd As New SqlCommand
            ' abrirWEB()
            ' cmd = New SqlCommand("BUSCAR_L", conexionWEB)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serial_pc", txtSerial.Text)
            serialWeb = Desencriptar(cmd.ExecuteScalar())
            ' CerrarWEB()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim cmd As New SqlCommand
        'Dim conexionWEB As New SqlConnection(checkServerWEB)
        'conexionWEB.Open()
        'cmd = New SqlCommand("select Top 1  Id_Usuario  from Usuarios", conexionWEB)
        'idusuario = cmd.ExecuteScalar()
        'conexionWEB.Close()
        Dim f1 As Date = Now()
        Dim dia, mes, anio As Int32

        Try

            Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
            lblIDSERIAL.Text = serialDD.Properties("SerialNumber").Value.ToString
            lblIDSERIAL.Text = Encriptar(lblIDSERIAL.Text.Trim())

            dia = DateAndTime.Day(Now())
            mes = DateAndTime.Month(Now())
            anio = DateAndTime.Year(Now())
            If mes = 12 Then
                If dia = 31 Then dia = 30
                If mes = 1 Then dia = 28
                mes = 1
                anio += 1
                f1 = (dia.ToString + "/" + mes.ToString + "/" + anio.ToString)
                FechaTemporal.Value = f1
            Else
                If dia = 31 Then dia = 30
                If mes = 1 Then dia = 28
                mes += 1
                f1 = (dia.ToString + "/" + mes.ToString + "/" + anio.ToString)
                FechaTemporal.Value = f1
            End If

            lblSerial.Text = lblIDSERIAL.Text
            lblFecha.Text = FechaTemporal.Value
            lblEstado.Text = "?ACTIVO?"
            lblSoftware.Text = "Control_Estudiantil"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MOSTRAR_licencia_temporal()

        If datalistado_licencia_temporal.Rows.Count = 0 Then

            ACTIVACION_DE_LICENCIA_Temporal()
            'msgBox(Mes.tostring)
            MOSTRAR_licencia_temporal()


            Try
                txtfecha_final_licencia_temporal.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)
                lblSerialPcLocal.Text = (datalistado_licencia_temporal.SelectedCells.Item(2).Value.Trim)
                LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
                txtfecha_inicio_licencia.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(5).Value.Trim)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If txtfecha_final_licencia_temporal.Value >= TXTFECHA_SISTEMA.Value And lblSerialPcLocal.Text = lblIDSERIAL.Text Then
                If txtfecha_inicio_licencia.Value <= TXTFECHA_SISTEMA.Value Then

                    If LBLESTADOLicenciaLocal.Text = "?ACTIVO?" Then
                        PanelActivando_licencia.Visible = True
                        PanelActivando_licencia.Dock = DockStyle.Fill
                        PictureBox1.Visible = False
                        lblActivando_licencia.Text = "Licencia Temporal Activada hasta " & lblFecha.Text
                    End If


                Else

                End If
            End If



        Else
            MessageBox.Show("Usted ya activo la licencia temporal y vencio el " & txtfecha_final_licencia_temporal.Value, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        Clipboard.SetText(txtSerial.Text)
    End Sub

    Private Sub Membresias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If PanelActivando_licencia.Visible = True Then
            End
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class