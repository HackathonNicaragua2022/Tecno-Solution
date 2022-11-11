Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Imports System.Xml
Public Class FrmLogin
    Private Hilo As Thread
    Dim acaba As Boolean = False
    Dim nombre_del_equipo_usuario As String
    Dim nombre_usuario_pc As String
    Dim ruta As String
    Private aes As New AES()
    Dim indicador As String
    Private Sub ObtenerDatos()
        Dim nombreHost As String = System.Net.Dns.GetHostName
#Disable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
        Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)
#Enable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
        ClientName = hostInfo.HostName
        For Each ip As System.Net.IPAddress In hostInfo.AddressList
            ClientIP = ip.ToString
        Next
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtservidor.Text = "."

        txtEliminarBase.Text = txtEliminarBase.Text.Replace("BASEADA", TXTbasededatos.Text)
        txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("Francisca_Hernandez_E", TXTbasededatos.Text)

        '                        Qutando las Ñ para evitar conflixtos
        txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("Eslogan_Del_Año", "Eslogan_Del_Anio")
        txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("Año", "Anio")
        txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("@Año", "@Anio")

        txtCrearUsaurioDb.Text = txtCrearUsaurioDb.Text.Replace("ada369", txtusuario.Text)
        txtCrearUsaurioDb.Text = txtCrearUsaurioDb.Text.Replace("softwarereal", lblcontraseña.Text)
        txtCrearUsaurioDb.Text = txtCrearUsaurioDb.Text.Replace("BASEADA", TXTbasededatos.Text)

        txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + vbCr + txtCrearUsaurioDb.Text
        ' Timer1.Enabled = True
        Try
            ObtenerDatos()
            Mostrar_Logo()
            Me.LblTitulo.Text = Empresa
            TxtUser.Select()
            Me.ActiveControl = TxtUser
        Catch ex As Exception

        End Try

    End Sub

    Function Comprobar_Conexion() As Boolean
        Dim rpta As Boolean = False
        Dim Id_Empresa As Int32 = 0
        Dim cnn As New SqlConnection()
        If verificar_si_hay_Servidor() = True Then
            Try
                cnn.ConnectionString = New DConexion().Cn

                Dim s As String = "SELECT  * from Escuela"
                Dim cmd As New SqlCommand(s, cnn)

                cnn.Open()
                Dim n As Int32 = cmd.ExecuteNonQuery()
                Dispose()
                rpta = True

                'Exit Function
            Catch ex As Exception
                ' utilidades.Mensaje(ex.Message + vbNewLine + ex.GetHashCode.ToString)

                '   CREAR BASE DE DATOS
                Try
                    If Utilidades.Preguntar("No se ha encontrado base de datos instalada. se procedera a crearla si está de acuerdo de clic en 'Si' de lo contrario no acepte y comuniquese con el administrador del sistema. ", "No", "Control Estudiantil") = True Then

                        'Dispose()
                        'FrmInstalacion_del_Servidor_Sql_Server.Show()
                        ejecutar_scryt_crearBase()
                    Else
                        If Utilidades.Preguntar("¿Desea verificar la conexión?") = True Then
                            If InputBox("Contraseña por Favor:", "Control Estudiantil") = "SoftwareReal" Then
                                conexion_manual.Show()
                                Dispose()
                            Else
                                Application.Exit()
                            End If
                        Else
                            Application.Exit()
                        End If
                    End If
                Catch exx As Exception
                    Utilidades.Mensaje("Por favor corrija la conexión al servidor.." + vbNewLine + ex.Message)
                    If InputBox("Contraseña por Favor:", "Control Estudiantil") = "SoftwareReal" Then
                        Dispose()
                        conexion_manual.Show()
                    Else
                        Application.Exit()
                    End If
                End Try
            Finally
                If cnn.State = ConnectionState.Open Then cnn.Close()
            End Try

            'Exit Function
        Else

            txtservidor.Text = txtservidor.Text & "\" & lblnombredeservicio.Text
            If verificar_si_hay_Servidor() = True Then
                Try
                    cnn.ConnectionString = New DConexion().Cn

                    Dim s As String = "SELECT  * from Escuela"
                    Dim cmd As New SqlCommand(s, cnn)

                    cnn.Open()
                    Dim n As Int32 = cmd.ExecuteNonQuery()
                    Dispose()
                    rpta = True

                    'Exit Function
                Catch ex As Exception
                    ' utilidades.Mensaje(ex.Message + vbNewLine + ex.GetHashCode.ToString)

                    '   CREAR BASE DE DATOS
                    Try
                        If Utilidades.Preguntar("No se ha encontrado base de datos instalada. se procedera a crearla si está de acuerdo de clic en 'Si' de lo contrario no acepte y comuniquese con el administrador del sistema. ", "No", "Control Estudiantil") = True Then

                            'Dispose()
                            'FrmInstalacion_del_Servidor_Sql_Server.Show()
                            ejecutar_scryt_crearBase()
                        Else
                            If Utilidades.Preguntar("¿Desea verificar la conexión?") = True Then
                                If InputBox("Contraseña por Favor:", "Control Estudiantil") = "SoftwareReal" Then
                                    conexion_manual.Show()
                                    Dispose()
                                Else
                                    Application.Exit()
                                End If
                            Else
                                Application.Exit()
                            End If
                        End If
                    Catch exx As Exception
                        Utilidades.Mensaje("Por favor corrija la conexión al servidor.." + vbNewLine + ex.Message)
                        If InputBox("Contraseña por Favor:", "Control Estudiantil") = "SoftwareReal" Then
                            Dispose()
                            conexion_manual.Show()
                        Else
                            Application.Exit()
                        End If
                    End Try
                Finally
                    If cnn.State = ConnectionState.Open Then cnn.Close()
                End Try
                Return rpta
                Exit Function
            Else

                Conexion_Pc_Secundaria.Show()
                Dispose()
            End If
        End If
        Return rpta
    End Function
    Dim variables As Boolean
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
                Logo_Empresa = ds.Tables("Escuela").Rows(c - 1)("Logo")
                Dim stm As New MemoryStream(Logo_Empresa)
                Me.PbLogo.Image = Image.FromStream(stm)
                Id_Escuela = ds.Tables("Escuela").Rows(c - 1)("Id_Escuela")
                Empresa = ds.Tables("Escuela").Rows(c - 1)("Nombre")
                Metodo_Ingreso_de_Nota = ds.Tables("Escuela").Rows(c - 1)("Metodo_Ingreso_Notas").ToString.Trim
                Codigo_Escuela = ds.Tables("Escuela").Rows(c - 1)("Codigo_Unico")
                variables = True
                Try
                    Tipo_de_Centro = ds.Tables("Escuela").Rows(c - 1)("Tipo_de_Centro")
                    Ruta_Backup = ds.Tables("Escuela").Rows(c - 1)("Ruta_De_BackUp")
                    Modo_de_Busqueda = ds.Tables("Escuela").Rows(c - 1)("Modo_de_Busqueda")
                    BackUp_al_Cerrar = ds.Tables("Escuela").Rows(c - 1)("Copias_De_Seguridad_despues_de_cerrar")
                    Imprimir_Error = ds.Tables("Escuela").Rows(c - 1)("Mostrar_Errores")
                    Ultimo_Backup = ds.Tables("Escuela").Rows(c - 1)("Fecha_Ultima_Copias_De_Seguridad")
                Catch ex As Exception

                    ' Utilidades.Mensaje(ex.Message)
                End Try

                Escuela = Empresa

                Dim stmLogo As New MemoryStream(Logo_Empresa)
                Me.PbLogo.Image = Image.FromStream(stmLogo)

                If Escuela = "" Then
                    Me.Hide()
                    FrmConfiguracionInicial.Show()
                End If
            Else
                variables = False
                Dim frm As New FrmConfiguracionInicial
                frm.ShowDialog()
                Me.Dispose()
            End If
        Catch ex As Exception
            'Utilidades.Mensaje("Estamos e un Error:  " + ex.Message)
            variables = False
            If Not Empresa <> "" Then
                If Utilidades.Preguntar("Ocurrieron errores de conectividad." + vbNewLine + "¿Desea verificar si existe servidor y base de datos instalados?") = True Then
                    If Comprobar_Conexion() = True Then
                        Me.ActiveControl = TxtUser
                        TxtUser.Select()
                        ObtenerDatos()
                        Mostrar_Logo()
                        Me.LblTitulo.Text = Empresa
                    ElseIf Utilidades.Preguntar("¿Desea intentar instalar un servidor?", "Si") = True Then

                        Eleccion_Servidor_o_remoto.Show()
                        Me.Dispose()
                    End If
                End If
            End If

        End Try

    End Sub
    Private Sub UI_CustomButton1_Click(sender As Object, e As EventArgs) Handles UI_CustomButton1.Click
        If variables = False Then
            If Utilidades.Preguntar("Las Variables de Entorno no Han sido cargadas Correctamente." + vbNewLine + "¿Desea Intentar cargarlas O continuar sin la Información?", "Yes") = True Then
                Mostrar_Logo()
                If variables = False Then
                    Utilidades.Mensaje("No se logró cargarla informacion requerida. verifique si su conexión con el servidor es correcta o si su servicio de base de datos se esta ejecutando")
                End If
            Else
                Utilidades.Mensaje("Es posible que no pueda ingresar 'Notas' sin cargar las variables del entorno de trabajo.")
            End If
        End If
        Sesion = New NDocentes().User_Login(TxtUser.Text.Trim, txtpass.Text.Trim, ClientIP, ClientName)
        If Sesion > 0 Then
            If cargar_Datos() = True Then
                Dim frm As New Form1
                frm.Show()
                Me.Close()
            Else
                Utilidades.Mensaje("Usuario o Contraseña Incorrectos" + vbNewLine + vbNewLine + "Buelva a intentarlo")
                Me.TxtUser.Text = String.Empty
                Me.txtpass.Text = String.Empty
                Me.ActiveControl = TxtUser
            End If
        End If

    End Sub
    Dim Utilidades As New Utilidades
    Function cargar_Datos() As Boolean
        Dim rpta As Boolean = False
        Try
            Me.DtDatos_Usuario.DataSource = New NDocentes().User_Login_Datos(Sesion)
            Me.DtDatos_Usuario.Refresh()
            UserID = DtDatos_Usuario.CurrentRow.Cells(0).Value
            User = DtDatos_Usuario.CurrentRow.Cells(1).Value
            UserName = TxtUser.Text
            UserModalidad = DtDatos_Usuario.CurrentRow.Cells(3).Value
            UserGrado = DtDatos_Usuario.CurrentRow.Cells(4).Value
            UserTurno = DtDatos_Usuario.CurrentRow.Cells(5).Value
            Acceso = DtDatos_Usuario.CurrentRow.Cells(6).Value
            UserSeccion = DtDatos_Usuario.CurrentRow.Cells(7).Value
            UserPass = txtpass.Text
            If UserID > 0 Then
                rpta = True
            Else
                rpta = False
            End If
        Catch ex As Exception
            rpta = False
            CerrarSesion()
            Utilidades.Mensaje(ex.Message, True)
        End Try
        Return rpta
    End Function

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sesion = New NDocentes().User_Login(TxtUser.Text.Trim, txtpass.Text.Trim, ClientIP, ClientName)
        If Sesion > 0 Then
            If cargar_Datos() = True Then
                Dim frm As New Form1
                frm.Show()
                Me.Close()
            Else
                Utilidades.Mensaje("Usuario o Contraseña Incorrectos" + vbNewLine + vbNewLine + "Vuelva a intentarlo" + " " + Sesion.ToString)
                Me.TxtUser.Text = String.Empty
                Me.txtpass.Text = String.Empty
                Me.ActiveControl = TxtUser
            End If
        End If
    End Sub
    Sub CerrarSesion()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("update loging set Fin=@Fin where IdLoging=@Sesion", SqlCon)

        Try
            sqlcmd.Parameters.AddWithValue("@Fin", DateTime.Now())
            sqlcmd.Parameters.AddWithValue("@Sesion", Sesion)
            SqlCon.Open()

            If sqlcmd.ExecuteNonQuery <> 1 Then
                'Utilidad.Mensaje("Error al cerrar la sesion", True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Function Comprobar_si_hay_Base_instalada() As Boolean
        Dim rpta As Boolean
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
        str = "select * from Escuela"
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        'Utilidades.Mensaje(myConn.ToString + vbNewLine + "Comprobar si hay Bd Instalada")
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            rpta = True
        Catch ex As Exception
            'MsgBox(ex.Message)
            rpta = False
            Utilidades.Mensaje("No se encontro base de datos")
            'Utilidades.Mensaje(myConn.ConnectionString.ToString + vbNewLine + "Comprobar si hay Bd Instalada")
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
        Return rpta
    End Function
    Dim Hay_Servidor As Boolean = False
    Public Function verificar_si_hay_Servidor() As Boolean
        Dim rpta As Boolean = True

        Dim cnn As New SqlConnection("Data Source=" & txtservidor.Text & ";Initial Catalog=master;Integrated Security=True")

        Dim s As String = "SELECT  lastrun  FROM spt_monitor"
        Dim cmd As New SqlCommand(s, cnn)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Utilidades.Mensaje(cnn.ConnectionString.ToString + vbNewLine + "verificar si hay servidor")
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
            rpta = False
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
        End Try
        Return rpta
    End Function
    Sub ejecutar_scryt_crearBase()
        Dim cnn As New SqlConnection("Data Source=" & txtservidor.Text &
                ";Initial Catalog=master;Integrated Security=True")
        Dim s As String = "CREATE DATABASE " & TXTbasededatos.Text
        Dim cmd As New SqlCommand(s, cnn)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Utilidades.Guardar_Conexion("Ctrl_Estudiantil.My.MySettings.Cn", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
            Utilidades.Guardar_Conexion("Ctrl_Estudiantil.My.MySettings.Francisca_Hernandez_EConnectionString", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
            Try
                'SavetoXML(aes.Encrypt("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True", appPwdUnique, Integer.Parse("256")))

            Catch ex As Exception

            End Try

            'txtservidor.Text = ".\" & lblnombredeservicio.Text
            'Utilidades.Mensaje(cnn.ConnectionString.ToString + vbNewLine + "Crear base")
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
            If Utilidades.Preguntar("La base de datos ya existe. ¿Desea eliminarla?") = True Then
                ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio()
                If indicador = "CORRECTO" Then
                    ejecutar_scryt_crearBase_comprobacion_De_inicio()
                ElseIf Utilidades.Preguntar("Desea Intentar Instalar el servidor") = True Then
                    Eleccion_Servidor_o_remoto.Show()
                Else
                    Application.Exit()
                End If
            Else
                Application.Exit()
            End If
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()

            End If
        End Try

    End Sub

    Private Sub Guardar_Cadenas(v1 As String, v2 As String)
        Throw New NotImplementedException()
    End Sub

    Sub ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & txtservidor.Text & ";Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            indicador = "CORRECTO"
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
            indicador = "INCORRECTO"
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()                '
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearBase_comprobacion_De_inicio()
        Dim cnn As New SqlConnection(
                       "Server=" & txtservidor.Text & "; " &
                       "database=master; integrated security=yes")

        Dim s As String = "CREATE DATABASE " & TXTbasededatos.Text
        Dim cmd As New SqlCommand(s, cnn)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Cn", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
            Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Francisaca_Hernandez_EConnectionString", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
            Try
                SavetoXML(aes.Encrypt("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True", appPwdUnique, Integer.Parse("256")))
            Catch ex As Exception

            End Try
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            'PanelInstalando_servidor.Dock = DockStyle.Fill
            'LabelAnuncio_de_instalando_servidor.Text = "Instancia Encontrada...
            'No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo"
            'Label3.Visible = False
            'PanelTemporizador.Visible = False
            'Timer4.Start()
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            'Label3.Visible = True
            'PanelTemporizador.Visible = True
            'Button2.Visible = True
            'PanelInstalando_servidor.Visible = False
            'PanelInstalando_servidor.Dock = DockStyle.None
            'lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor "
            '' MsgBox(ex.Message)
            If Utilidades.Preguntar("No se Encontro servidor Instalado." + vbNewLine + "¿Desea intentar instalarel servidor?") = True Then
                Dim frm As New FrmInstalacion_del_Servidor_Sql_Server
                frm.Show()
                Me.Dispose()
            End If
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("ConnectionString.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'root.Attributes.Item(0).Value = dbcnString
            'Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
            'writer.Formatting = Formatting.Indented
            'doc.Save(writer)
            'writer.Close()
            Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Cn", dbcnString)
            Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Francisca_Hernandez_EConnectionString", dbcnString)

        Catch ex As Exception
            MessageBox.Show("Es la Primera vez que estas abriendo jess92 Debes Ejecutar el Aplicativo como Administrador, da anticlik izquierdo y Elije *Ejecutar como Administrador*", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

    End Sub

    Sub ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()

        ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text & ".txt")

        Dim fi As FileInfo = New FileInfo(ruta)
        Dim sw As StreamWriter

        Try
            If File.Exists(ruta) = False Then

                sw = File.CreateText(ruta)
                sw.WriteLine(txtCrear_procedimientos.Text)
                sw.Flush()
                sw.Close()
            ElseIf File.Exists(ruta) = True Then
                File.Delete(ruta)
                sw = File.CreateText(ruta)
                sw.WriteLine(txtCrear_procedimientos.Text)
                sw.Flush()
                sw.Close()
            End If
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
        End Try

        Try
            Dim Pross As Process = New Process

            Pross.StartInfo.FileName = "sqlcmd"
            Pross.StartInfo.Arguments = " -R -S " & txtservidor.Text & " -i " & txtnombre_scrypt.Text & ".txt "
            Pross.Start()
            Try
                My.Settings.Servidor = aes.Encrypt(txtservidor.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Base_de_Datos = aes.Encrypt(TXTbasededatos.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Software = aes.Encrypt(txtsoftware.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Pasword_BD = aes.Encrypt(lblcontraseña.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Save()
                'Utilidades.AddUpdateAppSettingns("Servidor", aes.Encrypt(txtservidor.Text, appPwdUnique, Integer.Parse("256")))
                'Utilidades.AddUpdateAppSettingns("Base_de_Datos", aes.Encrypt(TXTbasededatos.Text, appPwdUnique, Integer.Parse("256")))
                'Utilidades.AddUpdateAppSettingns("Software ", aes.Encrypt(txtsoftware.Text, appPwdUnique, Integer.Parse("256")))
                'Utilidades.AddUpdateAppSettingns("Pasword_BD", aes.Encrypt(lblcontraseña.Text, appPwdUnique, Integer.Parse("256")))
                'My.Settings.Save()

                'SavetoXML_servidor(aes.Encrypt(txtservidor.Text, appPwdUnique, Integer.Parse("256")))
                'SavetoXML_Base_de_datos(aes.Encrypt(TXTbasededatos.Text, appPwdUnique, Integer.Parse("256")))
                'SavetoXML_Software(aes.Encrypt(txtsoftware.Text, appPwdUnique, Integer.Parse("256")))
                'SavetoXML_Contraseña_de_Base_de_datos(aes.Encrypt(lblcontraseña.Text, appPwdUnique, Integer.Parse("256")))
            Catch ex As Exception

            End Try
            Utilidades.Mensaje("Creando los procedimientos")
            'SavetoXMLWeb(aes.Encrypt(lblconexionweb.Text, appPwdUnique, Integer.Parse("256")))
            Application.Restart()
        Catch ex As Exception
            Utilidades.Mensaje(ex.Message, True)
            Application.Exit()
        End Try
    End Sub
    Public Sub SavetoXML_servidor(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Servidor.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Servidor.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()

        My.Settings.Servidor = dbcnString
        'Utilidades.AddUpdateAppSettingns("Servidor", dbcnString)
        ' My.Settings.Save()
    End Sub
    Public Sub SavetoXML_Software(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Software.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Software.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Software = dbcnString
        'Utilidades.AddUpdateAppSettingns("Software", dbcnString)
        My.Settings.Save()
    End Sub
    Public Sub SavetoXML_Base_de_datos(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Base_de_datos.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Base_de_datos.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Base_de_Datos = dbcnString
        'Utilidades.AddUpdateAppSettingns("Base_de_Datos", dbcnString)
        My.Settings.Save()
    End Sub

    Public Sub SavetoXML_Contraseña_de_Base_de_datos(ByVal dbcnString)
        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load("Passwor_Base_de_datos.xml")
        'Dim root As XmlElement = doc.DocumentElement
        'root.Attributes.Item(0).Value = dbcnString
        'Dim writer As XmlTextWriter = New XmlTextWriter("Passwor_Base_de_datos.xml", Nothing)
        'writer.Formatting = Formatting.Indented
        'doc.Save(writer)
        'writer.Close()
        My.Settings.Pasword_BD = dbcnString
        ' Utilidades.AddUpdateAppSettingns("Pasword_BD", dbcnString)
        My.Settings.Save()
    End Sub
    Dim N As Int32

    Public Sub ReadfromXML_Cliente_Servidor()
        Try
            'Dim doc As XmlDocument = New XmlDocument()
            'doc.Load("Cliente_Servidor.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'Dim valor As String = root.Attributes.Item(0).Value
            Cliente_o_Server = (aes.Decrypt(My.Settings.Servidor_o_Cliente, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            Cliente_o_Server = "Cliente"
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        N += 1
        If N = 5 Then
            Comprobar_Conexion()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New conexion_manual
        frm.ShowDialog()
    End Sub
End Class