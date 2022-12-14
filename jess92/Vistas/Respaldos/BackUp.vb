Imports System.IO
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Management
Imports System.Xml

Public Class BackUp
    'variables 
    Private Hilo As Thread
    Dim acaba As Boolean = False
    Dim Ruta_BuckUp As String
    Private aes As New AES()

    Private Sub BackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_id_serial_pc()
        Me.txtRuta.Text = Ruta_BuckUp
        'MOSTRAR_cajas_por_serial()
        Try
            'txtRuta.Text = datalistado_cajas.SelectedCells.Item(8).Value
            'lblfecha.Text = datalistado_cajas.SelectedCells.Item(9).Value
            '.Text = "Copia Guardada en: " & txtRuta.Text & "\" & "BASEMACKEYS.bak"
            lbldirectorio.Visible = False
            'lblfrecuencia.Text = datalistado_cajas.SelectedCells.Item(11).Value
            'idcaja = datalistado_cajas.SelectedCells.Item(3).Value
        Catch ex As Exception

        End Try
        txtRuta.BackColor = Color.White
    End Sub

    Public Shared Sub Main()
        Dim path As String = "C:\CI"
        Dim di As DirectoryInfo = Directory.CreateDirectory(path)
        Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path))
        di.Delete()
        Console.WriteLine("el directorio fue eliminado sastifactoriamente")
        Try

            If Directory.Exists(path) Then
                Console.WriteLine("ese directorio ya existe.")
                Return
            End If


        Catch e As Exception
            MsgBox("HOLA")
            Console.WriteLine("The process failed: {0}", e.ToString())

        Finally
        End Try
    End Sub
    Sub Cargar_id_serial_pc()
        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        lblIDSERIAL.Text = serialDD.Properties("SerialNumber").Value.ToString
        lblIDSERIAL.Text = Encriptar(lblIDSERIAL.Text.Trim())
    End Sub
    Sub MOSTRAR_cajas_por_serial()

        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    ' abrir()
        '    ' da = New SqlDataAdapter("MOSTRAR_cajas_por_serial", Conexion)
        '    da.SelectCommand.CommandType = 4
        '    da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)
        '    da.Fill(dt)
        '    datalistado_cajas.DataSource = dt
        '    '  Cerrar()

        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try



    End Sub
    'Private Sub GENERAR_COPIAS_DE_SEGURIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Cargar_id_serial_pc()
    '    Me.txtRuta.Text = Ruta_BuckUp
    '    'MOSTRAR_cajas_por_serial()
    '    Try
    '        'txtRuta.Text = datalistado_cajas.SelectedCells.Item(8).Value
    '        'lblfecha.Text = datalistado_cajas.SelectedCells.Item(9).Value
    '        '.Text = "Copia Guardada en: " & txtRuta.Text & "\" & "BASEMACKEYS.bak"
    '        lbldirectorio.Visible = False
    '        'lblfrecuencia.Text = datalistado_cajas.SelectedCells.Item(11).Value
    '        'idcaja = datalistado_cajas.SelectedCells.Item(3).Value
    '    Catch ex As Exception

    '    End Try
    '    txtRuta.BackColor = Color.White
    'End Sub
    Dim idcaja As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim ruta1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim ruta2 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim miCarpeta As String = "C:\Respaldos_CapsAdmin"
        Try
            If Directory.Exists(miCarpeta) Then

            Else

                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta1, miCarpeta))

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Sub ActualizarRuta()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As SqlCommand
        If Verificar_Si_Existe_Registro_de_Empresa() > 0 Then
            sqlcmd = New SqlCommand("Update  Escuela set Ruta_De_BackUp=@Ruta, Fecha_Ultima_Copia_de_Seguridad=@Fecha where Id_Empresa=" + Id_Empresa.ToString, SqlCon)
        Else
            sqlcmd = New SqlCommand("INSERT INTO Escuela (Ruta_De_BackUp,Fecha_Ultima_Copia_de_Seguridad) VALUES (@Ruta,@Fecha)", SqlCon)
        End If


        Try
            sqlcmd.Parameters.AddWithValue("@Ruta", txtRuta.Text.Trim)
            sqlcmd.Parameters.AddWithValue("@Fecha", Now())

            'SqlCon.Open()
            'sqlcmd.ExecuteNonQuery()
            'SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtRuta.Text <> "" Then
            Hilo = New Thread(New ThreadStart(AddressOf executa))
            txtRuta.BackColor = Color.White
            PictureBox1.Visible = True
            Panel1.Enabled = False
            lbldirectorio.Visible = False
            Panel2.Visible = False
            acaba = False
            Hilo.Start()
            ActualizarRuta()
            Timer1.Enabled = True
        Else
            MessageBox.Show("Selecciona una Ruta donde Guardar las Copias de Seguridad", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRuta.Focus()
            txtRuta.BackColor = Color.FromArgb(255, 255, 192)
        End If

    End Sub
    Dim Base_De_datos As String
    Public Sub LeerXML_base_de_datos()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            Base_De_datos = root.Attributes.Item(0).Value
            Base_De_datos = (aes.Decrypt(Base_De_datos, appPwdUnique, Integer.Parse("256")))
        Catch ex As System.Security.Cryptography.CryptographicException
        End Try
    End Sub
    Dim Servidor As String
    Public Sub LeerXML_Servidor()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Servidor.xml")
            Dim root As XmlElement = doc.DocumentElement
            Servidor = root.Attributes.Item(0).Value
            Servidor = (aes.Decrypt(Servidor, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Dim txtsoftware As String
    Public Sub LeerXML_Nombre_De_software()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Software.xml")
            Dim root As XmlElement = doc.DocumentElement
            txtsoftware = root.Attributes.Item(0).Value
            txtsoftware = (aes.Decrypt(txtsoftware, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Dim ruta As String
    Sub executa()
        LeerXML_Nombre_De_software()
        LeerXML_base_de_datos()
        'MsgBox(Base_De_datos.ToString)
        Dim miCarpeta As String = "Copias_de_Seguridad_de_" & txtsoftware
        If My.Computer.FileSystem.DirectoryExists(txtRuta.Text & miCarpeta) Then
        Else
            My.Computer.FileSystem.CreateDirectory(txtRuta.Text & "\" & miCarpeta)
        End If
        Dim ruta_completa As String = txtRuta.Text & "\" & miCarpeta
        Dim SubCarpeta As String = ruta_completa & "\Respaldo_al_" & Now.Day & "_" & MonthName(Now.Month) & "_" & Now.Year & "_" & Hour(TimeOfDay) & "_" & Minute(TimeOfDay)
        Try
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta_completa, SubCarpeta))
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
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
        Finally
            If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
        End Try

    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtRuta.Text = FolderBrowserDialog1.SelectedPath

            editar_frecuencia_y_ruta()



        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (acaba = True) Then


            Me.Button2.Enabled = True

            Me.Button2.Refresh()

            'PicBox.Visible = False
            PictureBox1.Visible = False
            Panel1.Enabled = True
            Timer1.Enabled = False
            lbldirectorio.Visible = True
            lbldirectorio.Text = "Copia Guardada en: " & ruta

            Panel2.Visible = True
            txtRuta.BackColor = Color.White
            'editar_Empresa_copia_de_seguridad()
            'MOSTRAR_cajas_por_serial()
            Try
                'lblfecha.Text = datalistado_cajas.SelectedCells.Item(9).Value
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub editar_Empresa_copia_de_seguridad()

        Try
            Dim cmd As New SqlCommand
            ' abrir()
            ' cmd = New SqlCommand("editar_copia_de_seguridad", Conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_caja", idcaja)

            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_de_seguridad", txtfechaSistema.Value)
            cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtRuta.Text)
            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_date", txtfechaSistema.Value)
            cmd.ExecuteNonQuery()
            'Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click

    End Sub

    Private Sub txtRuta_Click(sender As Object, e As EventArgs) Handles txtRuta.Click

    End Sub

    Private Sub txtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' MASCARA1.hide()
        Dispose()
        ' VENTAS_MENU_PRINCIPAL.TimerhideMascara.Start()

    End Sub

    Private Sub lblfrecuencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblfrecuencia.SelectedIndexChanged
        editar_frecuencia_y_ruta()
    End Sub
    Sub editar_frecuencia_y_ruta()
        Try
            Dim cmd As New SqlCommand

            'abrir()
            'cmd = New SqlCommand("editar_frecuencia_y_carpeta_Por_Caja", Conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Id_Caja", idcaja)
            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_de_seguridad", Now())
            cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtRuta.Text)
            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_date", Now())
            cmd.Parameters.AddWithValue("@Frecuencia_de_copias", lblfrecuencia.Text)
            cmd.ExecuteNonQuery()
            ' Cerrar()
            ' VENTAS_MENU_PRINCIPAL.TimerEmpresa.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblfrecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblfrecuencia.KeyPress
        e.KeyChar = ""
    End Sub

End Class