Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Imports System.Xml

Public Class FrmSplash
    Dim Utilidades As New Utilidades
    Private Hilo As Thread
    Dim acaba As Boolean = False
    Dim nombre_del_equipo_usuario As String
    Dim nombre_usuario_pc As String
    Dim ruta As String
    Private aes As New AES()
    Dim indicador As String
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostrar_Logo()
    End Sub
    Sub Mostrar_Logo()
        'Try
        '    Dim SqlCon As New SqlConnection()
        '    SqlCon.ConnectionString = New DConexion().Cn
        '    Dim sqlcmd As New SqlCommand("SELECT * FROM Escuela", SqlCon)
        '    Dim da As New SqlDataAdapter(sqlcmd)
        '    Dim ds As New DataSet()
        '    da.Fill(ds, "Escuela")
        '    Dim c As Int32 = ds.Tables("Escuela").Rows.Count

        '    If c > 0 Then
        '        Dim byt_Logo() As Byte
        '        byt_Logo = ds.Tables("Escuela").Rows(c - 1)("Logo")
        '        Empresa = ds.Tables("Escuela").Rows(c - 1)("Nombre")
        '        Codigo_Escuela = ds.Tables("Escuela").Rows(c - 1)("Codigo_Unico")
        '        Escuela = Empresa
        '        Logo_Empresa = ds.Tables("Escuela").Rows(c - 1)("Logo")
        '        Dim stmLogo As New MemoryStream(Logo_Empresa)
        '        Me.PBLogo.Image = Image.FromStream(stmLogo)

        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub PBLogo_Click(sender As Object, e As EventArgs) Handles PBLogo.Click

    End Sub

    'Function Comprobar_si_hay_Base_instalada() As Boolean
    '    Dim rpta As Boolean
    '    Dim str As String
    '    Dim myConn As SqlConnection = New SqlConnection("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
    '    str = "select * from Escuela"
    '    Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
    '    Try
    '        myConn.Open()
    '        myCommand.ExecuteNonQuery()
    '        rpta = True
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '        rpta = False
    '    Finally
    '        If (myConn.State = ConnectionState.Open) Then
    '            myConn.Close()
    '        End If
    '    End Try
    '    Return rpta
    'End Function
    'Dim Hay_Servidor As Boolean = False
    'Public Function Comprobar_Servidor() As Boolean

    '    Dim cnn As New SqlConnection("Server=(local);database=master; integrated security=yes")

    '    Dim s As String = "select * from spt_monitor"
    '    Dim cmd As New SqlCommand(s, cnn)

    '    Try

    '        cnn.Open()
    '        cmd.ExecuteNonQuery()
    '        Hay_Servidor = True
    '    Catch ex As Exception
    '        'If Utilidades.Preguntar("No hay servidor Instalado." + vbNewLine + "¿Desea Intentar Instalar Un Servidor?") = True Then
    '        '    Dim frm As New FrmInstalacion_del_Servidor_Sql_Server
    '        '    frm.Show()
    '        '    Me.Dispose()
    '        'End If
    '        Hay_Servidor = False
    '    Finally
    '        If cnn.State = ConnectionState.Open Then
    '            cnn.Close()
    '        End If
    '    End Try
    '    Return Hay_Servidor
    'End Function
    'Sub ejecutar_scryt_crearBase()

    '    Dim cnn As New SqlConnection(
    '                   "Server=" & txtservidor.Text & "; " &
    '                   "database=master; integrated security=yes")

    '    Dim s As String = "CREATE DATABASE " & TXTbasededatos.Text
    '    Dim cmd As New SqlCommand(s, cnn)

    '    Try

    '        cnn.Open()
    '        cmd.ExecuteNonQuery()

    '        SavetoXML(aes.Encrypt("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True", appPwdUnique, Integer.Parse("256")))
    '        Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Cn", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
    '        Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Francisaca_Hernandez_EConnectionString", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
    '        ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
    '    Catch ex As Exception
    '        Utilidades.Mensaje(ex.Message, True)
    '    Finally
    '        If cnn.State = ConnectionState.Open Then
    '            cnn.Close()
    '        End If
    '    End Try
    'End Sub
    'Sub ejecutar_scryt_crearBase_comprobacion_De_inicio()
    '    Dim cnn As New SqlConnection(
    '                   "Server=" & txtservidor.Text & "; " &
    '                   "database=master; integrated security=yes")

    '    Dim s As String = "CREATE DATABASE " & TXTbasededatos.Text
    '    Dim cmd As New SqlCommand(s, cnn)
    '    Try
    '        cnn.Open()
    '        cmd.ExecuteNonQuery()
    '        SavetoXML(aes.Encrypt("Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True", appPwdUnique, Integer.Parse("256")))
    '        Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Cn", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
    '        Utilidades.Guardar_Conexion("FHernandez.My.MySettings.Francisaca_Hernandez_EConnectionString", "Data Source=" & txtservidor.Text & ";Initial Catalog=" & TXTbasededatos.Text & ";Integrated Security=True")
    '        ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
    '        'PanelInstalando_servidor.Dock = DockStyle.Fill
    '        'LabelAnuncio_de_instalando_servidor.Text = "Instancia Encontrada...
    '        'No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo"
    '        'Label3.Visible = False
    '        'PanelTemporizador.Visible = False
    '        Timer4.Start()
    '    Catch ex As Exception
    '        'Me.Cursor = Cursors.Default
    '        'Label3.Visible = True
    '        'PanelTemporizador.Visible = True
    '        'Button2.Visible = True
    '        'PanelInstalando_servidor.Visible = False
    '        'PanelInstalando_servidor.Dock = DockStyle.None
    '        'lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor "
    '        '' MsgBox(ex.Message)
    '        If Utilidades.Preguntar("No se Encontro servidor Instalado." + vbNewLine + "¿Desea intentar instalarel servidor?") = True Then
    '            Dim frm As New FrmInstalacion_del_Servidor_Sql_Server
    '            frm.Show()
    '            Me.Dispose()
    '        End If
    '    Finally
    '        If cnn.State = ConnectionState.Open Then
    '            cnn.Close()
    '        End If
    '    End Try
    'End Sub
    'Public Sub SavetoXML(ByVal dbcnString)
    '    Try
    '        Dim doc As XmlDocument = New XmlDocument()
    '        doc.Load("ConnectionString.xml")
    '        Dim root As XmlElement = doc.DocumentElement
    '        root.Attributes.Item(0).Value = dbcnString
    '        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
    '        writer.Formatting = Formatting.Indented
    '        doc.Save(writer)
    '        writer.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Es la Primera vez que estas abriendo jess92 Debes Ejecutar el Aplicativo como Administrador, da anticlik izquierdo y Elije *Ejecutar como Administrador*", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End
    '    End Try

    'End Sub

    'Sub ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()

    '    ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text & ".txt")

    '    Dim fi As FileInfo = New FileInfo(ruta)
    '    Dim sw As StreamWriter

    '    Try
    '        If File.Exists(ruta) = False Then

    '            sw = File.CreateText(ruta)
    '            sw.WriteLine(txtCrear_procedimientos.Text)
    '            sw.Flush()
    '            sw.Close()
    '        ElseIf File.Exists(ruta) = True Then
    '            File.Delete(ruta)
    '            sw = File.CreateText(ruta)
    '            sw.WriteLine(txtCrear_procedimientos.Text)
    '            sw.Flush()
    '            sw.Close()
    '        End If
    '    Catch ex As Exception

    '    End Try

    '    Try
    '        Dim Pross As Process = New Process

    '        Pross.StartInfo.FileName = "sqlcmd"
    '        Pross.StartInfo.Arguments = " -S " & txtservidor.Text & " -i " & txtnombre_scrypt.Text & ".txt"
    '        Pross.Start()
    '        SavetoXML_servidor(aes.Encrypt(txtservidor.Text, appPwdUnique, Integer.Parse("256")))
    '        SavetoXML_Base_de_datos(aes.Encrypt(TXTbasededatos.Text, appPwdUnique, Integer.Parse("256")))
    '        SavetoXML_Software(aes.Encrypt(txtsoftware.Text, appPwdUnique, Integer.Parse("256")))
    '        SavetoXML_Contraseña_de_Base_de_datos(aes.Encrypt(lblcontraseña.Text, appPwdUnique, Integer.Parse("256")))
    '        'SavetoXMLWeb(aes.Encrypt(lblconexionweb.Text, appPwdUnique, Integer.Parse("256")))
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Public Sub SavetoXML_servidor(ByVal dbcnString)
    '    Dim doc As XmlDocument = New XmlDocument()
    '    doc.Load("Servidor.xml")
    '    Dim root As XmlElement = doc.DocumentElement
    '    root.Attributes.Item(0).Value = dbcnString
    '    Dim writer As XmlTextWriter = New XmlTextWriter("Servidor.xml", Nothing)
    '    writer.Formatting = Formatting.Indented
    '    doc.Save(writer)
    '    writer.Close()
    'End Sub
    'Public Sub SavetoXML_Software(ByVal dbcnString)
    '    Dim doc As XmlDocument = New XmlDocument()
    '    doc.Load("Software.xml")
    '    Dim root As XmlElement = doc.DocumentElement
    '    root.Attributes.Item(0).Value = dbcnString
    '    Dim writer As XmlTextWriter = New XmlTextWriter("Software.xml", Nothing)
    '    writer.Formatting = Formatting.Indented
    '    doc.Save(writer)
    '    writer.Close()
    'End Sub
    'Public Sub SavetoXML_Base_de_datos(ByVal dbcnString)
    '    Dim doc As XmlDocument = New XmlDocument()
    '    doc.Load("Base_de_datos.xml")
    '    Dim root As XmlElement = doc.DocumentElement
    '    root.Attributes.Item(0).Value = dbcnString
    '    Dim writer As XmlTextWriter = New XmlTextWriter("Base_de_datos.xml", Nothing)
    '    writer.Formatting = Formatting.Indented
    '    doc.Save(writer)
    '    writer.Close()
    'End Sub

    'Public Sub SavetoXML_Contraseña_de_Base_de_datos(ByVal dbcnString)
    '    Dim doc As XmlDocument = New XmlDocument()
    '    doc.Load("Passwor_Base_de_datos.xml")
    '    Dim root As XmlElement = doc.DocumentElement
    '    root.Attributes.Item(0).Value = dbcnString
    '    Dim writer As XmlTextWriter = New XmlTextWriter("Passwor_Base_de_datos.xml", Nothing)
    '    writer.Formatting = Formatting.Indented
    '    doc.Save(writer)
    '    writer.Close()
    'End Sub

    'Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

    'End Sub
End Class