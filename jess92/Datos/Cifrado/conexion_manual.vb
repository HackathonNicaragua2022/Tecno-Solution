Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Public Class conexion_manual
    Private aes As New AES()
    Private Sub ObtenerDatos()
        Dim nombreHost As String = System.Net.Dns.GetHostName
#Disable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
        Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)
#Enable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
        For Each ip As System.Net.IPAddress In hostInfo.AddressList
            txtdatasource.Text = ip.ToString
        Next

    End Sub
    Dim Utilidades As New Utilidades
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim cmd As New SqlCommand
    '    abrir()
    '    cmd = New SqlCommand("Insertar_caja", conexion)
    '    cmd.CommandType = 4


    '    cmd.Parameters.AddWithValue("@descripcion", TXTPC2.Text)
    '    cmd.Parameters.AddWithValue("@saldo", 0)
    '    cmd.Parameters.AddWithValue("@Id_empresa", datalistado_empresas_nuevas.SelectedCells.Item(1).Value)
    '    cmd.Parameters.AddWithValue("@PC_Asignada", TXTPC2.Text)
    '    cmd.Parameters.AddWithValue("@IP", TXTIP2.Text)



    '    cmd.ExecuteNonQuery()

    '    Cerrar()
    '    mostrar_empresas_nuevas()
    'End Sub

    'Private Sub CONEXION_MANUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MiAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Dim MiSeccion As ConnectionStringsSection = DirectCast(MiAppConfig.GetSection("connectionStrings"), ConnectionStringsSection)
        MiSeccion.ConnectionStrings("FHernandez.My.MySettings.Cn").ConnectionString = txtdatasource.Text
        MiSeccion.ConnectionStrings("FHernandez.My.MySettings.Francisaca_Hernandez_EConnectionString").ConnectionString = txtdatasource.Text
        MiAppConfig.Save()
        MessageBox.Show("Conexion generada")
        Application.Restart()
        'Me.txtCnString.Text = New DConexion().ObtenerCadenaConexion(Me.TxtNameConeccion.Text)

    End Sub
    Public Sub Guardar_Cadenas(ConexionName As String, Cadena As String)
        Dim MiAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Dim MiSeccion As ConnectionStringsSection = DirectCast(MiAppConfig.GetSection("connectionStrings"), ConnectionStringsSection)
        MiSeccion.ConnectionStrings(ConexionName).ConnectionString = Cadena
        MiAppConfig.Save()
        Dim configuracon = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    End Sub

    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SavetoHTML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("Diseño_html.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("Diseño_html.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub

    Dim dbcnString As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de Conexión..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'SavetoXML(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
            Try
                Guardar_Cadenas("Ctrl_Estudiantil.My.MySettings.Cn", txtCnString.Text)
                Guardar_Cadenas("Ctrl_Estudiantil.My.MySettings.Francisca_Hernandez_EConnectionString", txtCnString.Text)

                'Actualizar los valores de conexion

                My.Settings.Servidor = aes.Encrypt(TxtServidor.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Base_de_Datos = aes.Encrypt(TxtBaseDeDatos.Text, appPwdUnique, Integer.Parse("256"))
                My.Settings.Pasword_BD = aes.Encrypt(TxtPassword.Text, appPwdUnique, Integer.Parse("256"))

                'Utilidades.AddUpdateAppSettingns("Servidor", aes.Encrypt(TxtServidor.Text, appPwdUnique, Integer.Parse("256")))
                'Utilidades.AddUpdateAppSettingns("Base_de_Datos", aes.Encrypt(TxtBaseDeDatos.Text, appPwdUnique, Integer.Parse("256")))
                'Utilidades.AddUpdateAppSettingns("Pasword_BD", aes.Encrypt(TxtPassword.Text, appPwdUnique, Integer.Parse("256")))

                If TxtServidor.Text = "." Or TxtServidor.Text = "(local)" Then
                    My.Settings.Servidor_o_Cliente = aes.Encrypt("Servidor", appPwdUnique, Integer.Parse("256"))
                    'Utilidades.AddUpdateAppSettingns("Servidor_o_Cliente", aes.Encrypt("Servidor", appPwdUnique, Integer.Parse("256")))
                Else
                    My.Settings.Servidor_o_Cliente = aes.Encrypt("Cliente", appPwdUnique, Integer.Parse("256"))
                    'Utilidades.AddUpdateAppSettingns("Servidor_o_Cliente", aes.Encrypt("Cliente", appPwdUnique, Integer.Parse("256")))
                End If
                'guardar la configuracion

                My.Settings.Save()

                SavetoXML(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
                Save_Servidor_To_Xml(aes.Encrypt(TxtServidor.Text, appPwdUnique, Integer.Parse("256")))
                Save_Bd_To_Xml(aes.Encrypt(TxtBaseDeDatos.Text, appPwdUnique, Integer.Parse("256")))
                'MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar_usuario()
                Application.Restart()
            Catch ex As Exception

            End Try

        End If

    End Sub
    Public Sub ReadBDfromXML()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            Dim bd As String = root.Attributes.Item(0).Value
            TxtBaseDeDatos.Text = (aes.Decrypt(bd, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ReadServidorfromXML()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Servidor.xml")
            Dim root As XmlElement = doc.DocumentElement
            Dim Servidor As String = root.Attributes.Item(0).Value
            TxtServidor.Text = (aes.Decrypt(Servidor, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ReadfromXML()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Save_Bd_To_Xml(bd As String)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = bd
            Dim writer As XmlTextWriter = New XmlTextWriter("Base_de_datos.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Save_Servidor_To_Xml(Servidor As String)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("Servidor.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = Servidor
            Dim writer As XmlTextWriter = New XmlTextWriter("Servidor.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ReadfromXMLWEB()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            ' doc.Load("Conexion_web.xml")
            'Dim root As XmlElement = doc.DocumentElement
            'dbcnString = root.Attributes.Item(0).Value
            'txtCnStringWEB.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException

        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
    Public Sub SavetoXML_SERIAL_LICENCIA(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("Serial_l.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("Serial_l.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SavetoXML_SERIAL_PC(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load("Serial_x.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("Serial_x.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SavetoWeb(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        Try
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("Conexion_web.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception

        End Try
        'doc.Load("Conexion_web.xml")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtCnStringWEB.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoWeb(aes.Encrypt(txtCnStringWEB.Text, appPwdUnique, Integer.Parse("256")))
            MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Application.Exit()
        End If
    End Sub
    Sub mostrar_usuario()

        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            da = New SqlDataAdapter("select * from docentes", txtCnString.Text)
            da.Fill(dt)
            datalistado_movimientos_validar.DataSource = dt

            MessageBox.Show("Conexion Creada Correctamente, El sistema se Reiniciara...", "Conexion completada", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("Conexion Fallida, Revisa de nuevo la Cadena de Conexion o Escribenos para Ayudarte de Inmediato", "Sin Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'ObtenerDatos()
        'ReadfromXML()
        mostrar_usuario()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ObtenerDatos()
        ReadfromXMLWEB()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        mostrar_usuario()

    End Sub
    Private Sub conexion_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatos()
        ReadBDfromXML()
        ReadServidorfromXML()
        ReadfromXML()
        'ReadfromXMLWEB()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ReadfromXML()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtCnString.Text = My.Settings.Cn
    End Sub

    Private Sub TxtServidor_TextChanged(sender As Object, e As EventArgs) Handles TxtServidor.TextChanged
        Dim cn As String
        If Me.TxtBaseDeDatos.Text <> String.Empty Then
            cn = "Data Source=" + TxtServidor.Text.Trim + ";Initial Catalog=" + TxtBaseDeDatos.Text.Trim + ";User ID=jess;Password=" + TxtPassword.Text.Trim + ";Connect Timeout=2400"
            txtCnString.Text = cn
        Else
            cn = "Data Source=" + TxtServidor.Text.Trim + ";Initial Catalog=Ctrl_Estudiantil;User ID=jess;Password=" + TxtPassword.Text.Trim + ";Connect Timeout=2400"
            txtCnString.Text = cn
        End If
    End Sub

    Private Sub TxtBaseDeDatos_TextChanged(sender As Object, e As EventArgs) Handles TxtBaseDeDatos.TextChanged
        Dim cn As String
        If Me.TxtServidor.Text <> String.Empty Then
            cn = "Data Source=" + TxtServidor.Text.Trim + ";Initial Catalog=" + TxtBaseDeDatos.Text.Trim + ";User ID=jess;Password=" + TxtPassword.Text.Trim + ";Connect Timeout=2400"
            txtCnString.Text = cn
        Else
            cn = "Data Source=.;Initial Catalog=" + TxtBaseDeDatos.Text.Trim + ";User ID=jess;Password=" + TxtPassword.Text.Trim + ";Connect Timeout=2400"
            txtCnString.Text = cn
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        Dim cn As String
        cn = "Data Source=" + TxtServidor.Text.Trim + ";Initial Catalog=" + TxtBaseDeDatos.Text.Trim + ";User ID=jess;Password=" + TxtPassword.Text.Trim + ";Connect Timeout=2400"
        txtCnString.Text = cn

    End Sub
End Class