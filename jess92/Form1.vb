Imports System.Data.SqlClient, System.Management
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Xml

Public Class Form1
    Private aes As New AES()
    Private Hilo As Thread
    Dim ruta As String
    Dim acaba As Boolean = False
    Dim txtsoftware As String
    Dim Servidor As String
    Dim Base_De_datos As String
    Dim Ruta_BuckUp As String

    Private _Usuario As String
    Private _Pass As String
    Public Property Usuario
        Set(value)
            _Usuario = value
        End Set
        Get
            Return _Usuario
        End Get
    End Property
    Public Property Pass
        Set(value)
            _Pass = value
        End Set
        Get
            Return _Pass
        End Get
    End Property

#Region "FUNCIONES DE RESIZE DEL FORMULARIO"

    Dim press As Boolean
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub


    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub



    'LLAMAR METODO EN EVENTO MOUSEMOVE DEL PANEL BARRA TITULO
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If press = True Then
            If Me.BtnRestaurar.Visible = True Then
                'BtnRestaurar_Click(sender, e)
            End If
        End If
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL 
    Public Sub AbrirFormEnPanel(Of Forms As {Form, New})()
        Try
            Dim formulario As Form
            formulario = PanelContenedor.Controls.OfType(Of Forms)().FirstOrDefault()

            If formulario Is Nothing Then
                formulario = New Forms()
                formulario.TopLevel = False
                formulario.FormBorderStyle = FormBorderStyle.None
                formulario.Dock = DockStyle.Fill
                PanelContenedor.Controls.Add(formulario)
                PanelContenedor.Tag = formulario
                formulario.Show()
                formulario.BringToFront()
                AddHandler formulario.FormClosed, AddressOf Me.SerrarForm
            Else

                If formulario.WindowState = FormWindowState.Minimized Then
                    formulario.WindowState = FormWindowState.Normal
                End If

                formulario.BringToFront()
            End If
        Catch ex As Exception
            Utilidad.Mensaje(ex.Message)
        End Try

    End Sub

    Sub SerrarForm()

    End Sub

    Public Sub LeerXML_base_de_datos()
        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("Base_de_datos.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'Base_De_datos = root.Attributes.Item(0).Value
            Base_De_datos = (aes.Decrypt(My.Settings.Base_de_Datos, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
        End Try
    End Sub
    Public Sub LeerXML_Servidor()

        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("Servidor.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'Servidor = root.Attributes.Item(0).Value
            Servidor = (aes.Decrypt(My.Settings.Servidor, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub

    Public Sub LeerXML_Nombre_De_software()

        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("Software.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'txtsoftware = root.Attributes.Item(0).Value
            txtsoftware = (aes.Decrypt(My.Settings.Software, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Sub executa()
        LeerXML_Nombre_De_software()
        LeerXML_base_de_datos()
        Dim miCarpeta As String = "Copias_de_Seguridad_de_" & txtsoftware
        If My.Computer.FileSystem.DirectoryExists(Ruta_BuckUp & miCarpeta) Then
        Else
            My.Computer.FileSystem.CreateDirectory(Ruta_BuckUp & "\" & miCarpeta)
        End If
        Dim ruta_completa As String = Ruta_BuckUp & "\" & miCarpeta
        Dim SubCarpeta As String = ruta_completa & "\Respaldo_al_" & Now.Day & "_" & MonthName(Now.Month) & "_" & Now.Year & "_" & Hour(TimeOfDay) & "_" & Minute(TimeOfDay)

        Try
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta_completa, SubCarpeta))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim sqlcon As New SqlConnection(New DConexion().Cn)
        Try
            Dim v_nombre_respaldo As String
            'MsgBox(Base_De_datos + ", " + txtsoftware)
            v_nombre_respaldo = Base_De_datos & ".bak"

            '   CREAR ARCHIVO *.BAK AQUI

            ruta = Path.Combine(SubCarpeta & "\", v_nombre_respaldo)

            Dim fi As FileInfo = New FileInfo(ruta)
            Dim sw As StreamWriter

            Try
                If File.Exists(ruta) = False Then

                    sw = File.CreateText(ruta)
                    sw.Flush()
                    sw.Close()
                ElseIf File.Exists(ruta) = True Then
                    File.Delete(ruta)
                    sw = File.CreateText(ruta)
                    sw.Flush()
                    sw.Close()
                End If
            Catch ex As Exception

            End Try



            sqlcon.Open()
            ' Dim cmd As New SqlCommand("BACKUP DATABASE " & Base_De_datos & " TO DISK = '" & SubCarpeta & "\" & v_nombre_respaldo & "'", sqlcon)
            Dim cmd As New SqlCommand("BACKUP DATABASE " & Base_De_datos & " TO DISK = '" & ruta & "'", sqlcon)
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            acaba = True
        Catch ex As Exception
            acaba = False
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

    End Sub
    Sub Generar_BackUp()
        If Ruta_BuckUp <> "" Then
            'lblDireccionBackup.Text = ruta
            Hilo = New Thread(New ThreadStart(AddressOf executa))
            'txtRuta.BackColor = Color.White
            'PnBackUp.Visible = True
            'PnBackUp.BringToFront()
            PictureBox1.Visible = True
            Panel1.Enabled = False
            'lbldirectorio.Visible = False

            Panel2.Visible = False
            acaba = False
            Hilo.Start()
            Timer2.Enabled = True
        Else
            MessageBox.Show("La ruta seleccionada es Inaccesible", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Int32
    Dim sw, sh As Int32

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click

        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        Me.BtnRestaurar.Visible = False
        Me.BtnMaximizar.Visible = True
        press = False
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click

        Me.lx = Me.Location.X
        Me.ly = Me.Location.Y
        Me.sw = Me.Size.Width
        Me.sh = Me.Size.Height

        Me.BtnRestaurar.Visible = True
        Me.BtnMaximizar.Visible = False

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        press = False
    End Sub

    Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitulo.Paint

    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs)
        ' AbrirFormEnPanel(Of FrmCategorias)()
    End Sub

    Private Sub LblMainTitle_Click(sender As Object, e As EventArgs) Handles LblMainTitle.Click

    End Sub

#End Region
    Public Utilidad As New Utilidades()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            'Validacion de Licencia
            obtener_serial_pc()
            VALIDACION_DE_LICENCIAS()
            Me.IpPrincipal.Text = ClientIP
            Dim stmLogo As New MemoryStream(Logo_Empresa)
            Me.PbLogo.Image = Image.FromStream(stmLogo)
            Me.LblMainTitle.Text = Empresa + " (" + ClientIP + ")"

            If Metodo_Ingreso_de_Nota = String.Empty Then
                Mostrar_Logo()
            End If

            LblUser.Text = User
            If Acceso <> "Docente" Then
                If Acceso = "Administrador" Then
                    LblResumen.Text = Acceso.Trim + " del Sistema"
                    Button20.Visible = True
                Else
                    LblResumen.Text = Acceso.Trim + " del Centro educativo"
                    BtnConfig.Visible = False
                    Button20.Visible = False
                End If
                PbConfiguracion.Visible = True
            Else
                Panel7.Visible = False
                Panel12.Visible = False
                PnlRendimiento.Visible = False
                LblResumen.Text = Acceso.Trim + " de " + UserGrado.Trim.ToLower + " grado " + UserSeccion + " " + UserModalidad.Trim
                PbConfiguracion.Visible = False
            End If

            lblPc.Text = ClientName
            lblip.Text = ClientIP

            BtnMaximizar_Click(sender, e)
        Catch ex As Exception
            Utilidad.Mensaje(ex.Message)
        End Try
        ReadCliente_O_Servidor()
        'If Cliente_o_Server.Trim = "Cliente" Then
        '    Me.IpPrincipal.Text = Servidor
        'End If

        Dibujar_Usuario()
    End Sub

    Sub obtener_serial_pc()
        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        lblIDSERIAL.Text = serialDD.Properties("SerialNumber").Value.ToString
        lblIDSERIAL.Text = Encriptar(lblIDSERIAL.Text.Trim())
        'txtfecha_final_licencia_temporal2.Text = lblIDSERIAL.Text
    End Sub

    Sub validar_licencia_pro()
        MOSTRAR_licencia_temporal()


        Try

            LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
            txtfecha_final_licencia_temporal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)

        Catch ex As Exception
        End Try

        If LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
            PanelLicencia.Visible = True
            lblActivando_licencia.Text = "Licencia PROFESIONAL Activada hasta " & txtfecha_final_licencia_temporal2.Text
            Button20.Visible = False

        Else
            PanelLicencia.Visible = True
            lblActivando_licencia.Text = "Licencia de Prueba Activada hasta " & txtfecha_final_licencia_temporal2.Text
            Button20.Visible = True

        End If

    End Sub
    Sub VALIDACION_DE_LICENCIAS()
        MOSTRAR_licencia_temporal()
        'ReadfromXML_SERIAL_PC()
        Try
            txtfecha_final_licencia_temporal.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)
            lblSerialPcLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(2).Value.Trim)
            LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
            txtfecha_inicio_licencia.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(5).Value.Trim)

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        'MsgBox(LBLESTADOLicenciaLocal.Text)
        If LBLESTADOLicenciaLocal.Text <> "VENCIDO" Then

            If Cliente_o_Server = "SERVIDOR" Then
                If txtfecha_final_licencia_temporal.Value >= TXTFECHA_SISTEMA.Value And lblSerialPcLocal.Text = Desencriptar(lblIDSERIAL.Text) Then
                    If txtfecha_final_licencia_temporal.Value >= txtfecha_inicio_licencia.Value Then
                        If LBLESTADOLicenciaLocal.Text = "?ACTIVO?" Then
                            PanelLicencia.Visible = True
                            Label5.Text = "Licencia de prueba Activa hasta " + txtfecha_final_licencia_temporal.Value


                        ElseIf LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
                            PanelLicencia.Visible = False

                        End If


                    Else
                        'MsgBox(txtfecha_inicio_licencia.Value + " <= " + TXTFECHA_SISTEMA.Value)
                        EDITAR_ESTADO_LICENCIA_LOCAL()

                        Dispose()
                        Membresias.Show()
                    End If
                Else
                    EDITAR_ESTADO_LICENCIA_LOCAL()

                    Dispose()
                    Membresias.Show()
                End If
            Else
                If txtfecha_final_licencia_temporal.Value >= TXTFECHA_SISTEMA.Value Then
                    If txtfecha_final_licencia_temporal.Value >= txtfecha_inicio_licencia.Value Then
                        If LBLESTADOLicenciaLocal.Text = "?ACTIVO?" Then
                            PanelLicencia.Visible = True
                            Label5.Text = "Licencia de prueba Activa hasta " + txtfecha_final_licencia_temporal.Value
                            Button20.Visible = False

                        ElseIf LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
                            PanelLicencia.Visible = False
                        End If
                    Else
                        'MsgBox(txtfecha_inicio_licencia.Value + " <= " + TXTFECHA_SISTEMA.Value)
                        EDITAR_ESTADO_LICENCIA_LOCAL()
                        Dispose()
                        Membresias.Show()
                    End If
                Else
                    EDITAR_ESTADO_LICENCIA_LOCAL()

                    Dispose()
                    Membresias.Show()
                End If


            End If
        Else
            Dispose()
            'MsgBox(txtfecha_inicio_licencia.Value + " <= " + TXTFECHA_SISTEMA.Value)
            Membresias.Show()
        End If
    End Sub
    Sub MOSTRAR_licencia_temporal()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Dim SqlCon As New SqlConnection(New DConexion().Cn)
            SqlCon.Open()
            da = New SqlDataAdapter("SELECT * FROM Marcan", SqlCon)

            da.Fill(dt)
            datalistado_licencia_temporal.DataSource = dt
            SqlCon.Close()


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub EDITAR_ESTADO_LICENCIA_LOCAL()
        Dim estado As String
        estado = Encriptar("VENCIDO")
        Dim sqlCon As New SqlConnection(New DConexion().Cn)
        Try
            Dim cmd As New SqlCommand
            sqlCon.Open()
            cmd = New SqlCommand("EDITAR_marcan", sqlCon)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@e", estado)

            cmd.ExecuteNonQuery()
            sqlCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Dim dbcnstring As String
    Public Sub ReadfromXML_FECHA()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Serial_ff.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnstring = root.Attributes.Item(0).Value
            lblfecha_expiracionWEB.Text = (aes.Decrypt(dbcnstring, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            lblfecha_expiracionWEB.Text = "NULO"
        End Try
    End Sub
    Public Sub ReadCliente_O_Servidor()
        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("Servidor_Remoto.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'Dim Client_Server As String = root.Attributes.Item(0).Value
            Cliente_o_Server = (aes.Decrypt(My.Settings.Servidor_o_Cliente, appPwdUnique, Integer.Parse("256")))
            LblClienteServidor.Text = Cliente_o_Server
            LblClienteServidor.Visible = True
            LblClienteServidor.BringToFront()
            If Cliente_o_Server = String.Empty Then
                LblClienteServidor.Text = "NULL"
            End If
        Catch ex As System.Security.Cryptography.CryptographicException
            Utilidad.Mensaje(ex.Message)
            LblClienteServidor.Text = "NULO"
        End Try
    End Sub
    Public Sub ReadfromXML_SERIAL_PC()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Serial_x.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnstring = root.Attributes.Item(0).Value
            lblSerialPc_WEB.Text = (aes.Decrypt(dbcnstring, appPwdUnique, Integer.Parse("256")))


        Catch ex As System.Security.Cryptography.CryptographicException
            lblSerialPc_WEB.Text = "NULO"
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelTitulo_DoubleClick(sender As Object, e As EventArgs) Handles PanelTitulo.DoubleClick
        If Me.BtnRestaurar.Visible = False Then
            BtnMaximizar_Click(sender, e)
        Else
            BtnRestaurar_Click(sender, e)
        End If
    End Sub

    Private Sub LblMainTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LblMainTitle.MouseMove
        If Me.BtnRestaurar.Visible = True Then
            'BtnRestaurar_Click(sender, e)
        End If
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub LblMainTitle_DoubleClick(sender As Object, e As EventArgs) Handles LblMainTitle.DoubleClick
        If Me.BtnRestaurar.Visible = False Then
            BtnMaximizar_Click(sender, e)
        Else
            BtnRestaurar_Click(sender, e)
        End If
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs)
        'AbrirFormEnPanel(Of FrmEmpleados)()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(Of FrmAlumnos)()
    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint
        Me.Panel5.Visible = False
    End Sub
    Sub Mostrar_Logo()
        Try
            Dim SqlCon As New SqlConnection()
            SqlCon.ConnectionString = New DConexion().Cn
            Dim sqlcmd As New SqlCommand("SELECT * FROM Escuela", SqlCon)
            Dim da As New SqlDataAdapter(sqlcmd)
            Dim ds As New DataSet()
            da.Fill(ds, "Escuela")
            Dim c As Int32 = ds.Tables("Escuela").Rows.Count

            If c > 0 Then
                Dim byt_Logo() As Byte
                byt_Logo = ds.Tables("Escuela").Rows(c - 1)("Logo")
                Escuela = ds.Tables("Escuela").Rows(c - 1)("Nombre")
                Codigo_Escuela = ds.Tables("Escuela").Rows(c - 1)("Codigo_Unico")
                Metodo_Ingreso_de_Nota = ds.Tables("Escuela").Rows(c - 1)("Metodo_Ingreso_Notas")

                Empresa = Escuela
                Dim stmLogo As New MemoryStream(byt_Logo)
                PbLogo.Image = Image.FromStream(stmLogo)


            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
            ocultar_ImgSeleccion()
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
            ocultar_ImgSeleccion()
        End If
    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
            Activar_Boton(VentanaActiva)
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
            Me.PbLogo.Width -= 2
            Me.PbLogo.Height -= 2
            Me.PbLogo.Left -= 1.4
            Me.Panel1.Top -= 2
            tooltip.SetToolTip(btnDashBoard, PanelMenu.Width.ToString)
        End If

    End Sub
    Sub ocultar_ImgSeleccion()
        Me.ImgDasboard.Visible = False
        Me.ImgDocente.Visible = False
        Me.ImgAlumnos.Visible = False
        Me.ImgCortes.Visible = False
        Me.ImgHorarios.Visible = False
    End Sub

    Dim VentanaActiva As String
    Public Sub Activar_Boton(Ventana As String)
        Me.pnDashboard.BackColor = Color.FromArgb(145, 110, 21)
        Me.PnDocentes.BackColor = Color.FromArgb(145, 110, 21)
        Me.PnAlumnos.BackColor = Color.FromArgb(145, 110, 21)
        Me.PnHorarios.BackColor = Color.FromArgb(145, 110, 21)
        Me.PnCortes.BackColor = Color.FromArgb(145, 110, 21)
        Me.PnRendimiento.BackColor = Color.FromArgb(145, 110, 21)

        ocultar_ImgSeleccion()
        VentanaActiva = Ventana
        If PanelMenu.Width = 220 Then
            Me.ImgDasboard.Left = 201
            Me.ImgDocente.Left = 201
            Me.ImgAlumnos.Left = 201
            Me.ImgCortes.Left = 201
            Me.ImgHorarios.Left = 201
            Me.ImgRendimiento.Left = 201
        Else
            Me.ImgDasboard.Left = 50
            Me.ImgDocente.Left = 50
            Me.ImgAlumnos.Left = 50
            Me.ImgCortes.Left = 50
            Me.ImgHorarios.Left = 50
            Me.ImgRendimiento.Left = 50
        End If


        Select Case Ventana
            Case "Dashboard"
                Me.pnDashboard.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgDasboard.Visible = True
            Case "Matrícula"
                Me.PnAlumnos.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgAlumnos.Visible = True
            Case "Docentes"
                Me.PnDocentes.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgDocente.Visible = True
            Case "Horarios"
                Me.PnHorarios.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgHorarios.Visible = True
            Case "Cortes"
                Me.PnCortes.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgCortes.Visible = True
            Case "Rendimiento"
                Me.PnRendimiento.BackColor = Color.FromArgb(41, 182, 246)
                Me.ImgRendimiento.Visible = True
        End Select
    End Sub
    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
            Activar_Boton(VentanaActiva)
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
            Me.PbLogo.Width += 2
            Me.PbLogo.Height += 2
            Me.PbLogo.Left += 1.4
            Me.Panel1.Top += 2
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Activar_Boton("Matrícula")
        AbrirFormEnPanel(Of FrmAlumnos)()
        Me.LblMainTitle.Text = Escuela + " - Matrícula" ' + Utilidad.Get_IP()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Activar_Boton("Docentes")
        AbrirFormEnPanel(Of FrmDocentes)()
        Me.LblMainTitle.Text = Escuela + "- Docentes"
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        Activar_Boton("Dashboard")
        Me.LblMainTitle.Text = Escuela + " ==> DashBoard"
        AbrirFormEnPanel(Of FrmDashboard)()
    End Sub

    Private Sub btnProductos_Click_1(sender As Object, e As EventArgs) Handles btnProductos.Click
        Activar_Boton("Cortes")
        'FrmCortes.Show()
        AbrirFormEnPanel(Of FrmCortes)()
        Me.LblMainTitle.Text = Escuela + " ==> Ingreso de Notas"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Activar_Boton("Horarios")
        'AbrirFormEnPanel(Of FrmCorte_De_Notas)()
        AbrirFormEnPanel(Of FrmAddAsignaturaA_Notas)()
        Me.LblMainTitle.Text = Escuela + " ==>  Horarios"
    End Sub

    Private Sub btnRendimiento_Click(sender As Object, e As EventArgs) Handles btnRendimiento.Click
        Activar_Boton("Rendimiento")
        AbrirFormEnPanel(Of frmRendimiento)()
        Me.LblMainTitle.Text = Escuela + " ==> Rendimiento" '+ Utilidad.Get_IP()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PbConfiguracion.Click
        Dim frm As New FrmConfig
        frm.ShowDialog()
    End Sub
    Public Function cerrar_sesion(idsesion As Int32) As Boolean
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim rpta As Boolean = False
        Dim sqlcmd As New SqlCommand("update loging set Fin=@Fin where IdLoging=@Sesion", SqlCon)

        Try
            sqlcmd.Parameters.AddWithValue("@Fin", DateTime.Now())
            sqlcmd.Parameters.AddWithValue("@Sesion", idsesion)
            SqlCon.Open()

            If sqlcmd.ExecuteNonQuery <> 1 Then
                Utilidad.Mensaje("Error al cerrar la sesion", True)
            End If
            rpta = True
        Catch ex As Exception
            MsgBox(ex.Message)
            rpta = False
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
        Return rpta
    End Function
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cerrar_sesion(Sesion)
    End Sub

    Private Sub lblPc_Click(sender As Object, e As EventArgs) Handles lblPc.Click

    End Sub

    Private Sub lblip_Click(sender As Object, e As EventArgs) Handles lblip.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (acaba = True) Then


            'Me.Button2.Enabled = True

            'Me.Button2.Refresh()

            'Timer2.Enabled = False
            ''lbldirectorio.Visible = True
            ''lbldirectorio.Text = "Copia Guardada en: " & ruta

            'Panel2.Visible = True
            ''txtRuta.BackColor = Color.White
            ''editar_Empresa_copia_de_seguridad()
            ''MOSTRAR_cajas_por_serial()
            Try
                lblDireccionBackup.Text = ruta
                ProgressBar2.Value += 5
                If ProgressBar2.Value >= 50 Then
                    ActualizarFechaGackUp()
                    Application.Exit()
                End If

            Catch ex As Exception

            Finally
                Application.Exit()
            End Try
        End If
    End Sub
    Sub ActualizarFechaGackUp()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As SqlCommand
        If Verificar_Si_Existe_Registro_de_Empresa() > 0 Then
            sqlcmd = New SqlCommand("Update  Empresa set  Fecha_Ultima_Copia_de_Seguridad=@Fecha where Id_Empresa=" + Id_Empresa.ToString, SqlCon)
        Else
            sqlcmd = New SqlCommand("INSERT INTO Empresa (Fecha_Ultima_Copia_de_Seguridad) VALUES (@Fecha)", SqlCon)
        End If


        Try
            sqlcmd.Parameters.AddWithValue("@Fecha", Now())

            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()

        End Try
    End Sub
    Dim Id_Empresa As Int32 = 0
    Public Function Verificar_Si_Existe_Registro_de_Empresa() As Int32

        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn

        Dim sqlcmd As New SqlCommand("SELECT * FROM Empresa", SqlCon)
        Try
            SqlCon.Open()
            Id_Empresa = sqlcmd.ExecuteScalar
            SqlCon.Close()
        Catch ex As Exception

        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try

        Return Id_Empresa
    End Function

    Private Sub BtnConexion_Click(sender As Object, e As EventArgs) Handles BtnConexion.Click
        conexion_manual.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Membresias.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles BtnConfig.Click
        AbrirFormEnPanel(Of FrmConfig)()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Visible = False
        Button7.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button5.Visible = True
        Button7.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub
    Sub Dibujar_Usuario()
        Dim letra As String
        letra = Mid(User, 1, 1)
        BtnUsuario.ButtonText = letra
    End Sub
    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        If Panel5.Visible = True Then

            Panel5.Visible = False
        Else
            PanelContenedor.Controls.Add(Panel5)
            Panel5.Visible = True
            Panel5.BringToFront()
            Panel5.Top = 84
            Panel5.Left = PanelContenedor.Width - Panel5.Width
        End If
        lblDocente.Text = User.Trim
        LblModalidad.Text = UserModalidad.Trim
        LblTurno.Text = UserTurno.Trim
        LblGrado.Text = UserGrado.Trim
        LblSeccion.Text = UserSeccion.Trim
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AbrirFormEnPanel(Of FrmDocentes)()
        Me.Panel5.Visible = False
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        If cerrar_sesion(Sesion) = True Then
            Dim frm As New FrmLogin()
            frm.Show()
            Dispose()
        Else
            Utilidad.Mensaje("Ocurrio un error al cerrar la sesión." + vbNewLine + "El sistema se reiniciara...")
            Application.Restart()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        press = True
    End Sub



    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        press = False
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Panel5.Visible = False
    End Sub

End Class


