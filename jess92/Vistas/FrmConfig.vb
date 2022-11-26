Imports System.Data, System.Data.SqlClient, System.IO
Imports System.Xml

Public Class FrmConfig
    Dim AES As New AES
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAddLogo_Click(sender As Object, e As EventArgs) Handles BtnAddLogo.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar Logotipo"
            .Filter = "Archivo de Imagen(*.png;*.jpg)|*.png;*jpg"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PnLogo.Image = Image.FromFile(.FileName)
                Me.LOGO_path = .FileName
            End If
        End With

    End Sub

    Private Sub BtnAddEslogan_Click(sender As Object, e As EventArgs) Handles BtnAddEslogan.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar Eslogan del año"
            .Filter = "Archivo de Imagen(*.png;*.jpg)|*.png;*jpg"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PnEslogan.Image = Image.FromFile(.FileName)
                Me.SLOGAN_path = .FileName
            End If
        End With
    End Sub
    Dim LOGO_path As String = ""
    Dim SLOGAN_path As String = ""
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Verificar_Si_Existe_Registro() > 0 Then
            Actualizar_Escuela()
        Else
            Insertar_Nuevo_Registro()
        End If
        Dim op As Boolean = New Utilidades().Preguntar("Debe reiniciar el sistema para aplicar los cambios" + vbNewLine + "¿Desea Reiniciar ahora?", "Yes", "Control de Notas")
        If op = True Then
            Application.Restart()
        Else
            Me.Dispose()
        End If
    End Sub
    Dim Id_Escuela As Int32 = 0

    Public Sub SavetoXML_Servidor_Remoto(Servidor_o_Remoto As String)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Servidor_Remoto.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = Servidor_o_Remoto
        Dim writer As XmlTextWriter = New XmlTextWriter("Servidor_Remoto.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Public Function Verificar_Si_Existe_Registro() As Int32

        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("SELECT * FROM Escuela", SqlCon)
        Try
            SqlCon.Open()
            Id_Escuela = sqlcmd.ExecuteScalar
            SqlCon.Close()
        Catch ex As Exception

        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try

        Return Id_Escuela
    End Function
    Sub Mostrar_Registros()
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
                Dim stmLogo As New MemoryStream(byt_Logo)
                PnLogo.Image = Image.FromStream(stmLogo)

                Dim byt_slogan() As Byte
                byt_slogan = ds.Tables("Escuela").Rows(c - 1)("Eslogan_Del_Anio")
                Dim stmSlogan As New MemoryStream(byt_slogan)
                PnEslogan.Image = Image.FromStream(stmSlogan)

                Me.TxtEscuela.Text = ds.Tables("Escuela").Rows(c - 1)("Nombre").ToString
                Me.TxtCodigo.Text = ds.Tables("Escuela").Rows(c - 1)("Codigo_Unico").ToString
                Me.TxtBarrio.Text = ds.Tables("Escuela").Rows(c - 1)("Barrio").ToString
                Me.CmbMetodoIngresoNota.Text = ds.Tables("Escuela").Rows(c - 1)("Metodo_Ingreso_Notas").ToString

            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub Insertar_Nuevo_Registro()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("INSERT INTO Escuela (Nombre, Codigo_Unico,Logo,Eslogan_Del_Anio,Barrio,Metodo_Ingreso_Notas) VALUES (@Nombre,@Codigo,@Logo,@Eslogan,@Barrio,@Metodo_Ingreso_Nota)", SqlCon)

        Try
            Dim ms As MemoryStream = New MemoryStream
            Dim mss As MemoryStream = New MemoryStream
            Me.PnLogo.Image.Save(ms, PnLogo.Image.RawFormat)
            Dim Byte_Logo() As Byte
            Byte_Logo = ms.GetBuffer

            Me.PnEslogan.Image.Save(mss, PnEslogan.Image.RawFormat)
            Dim Byte_Slogan() As Byte
            Byte_Slogan = mss.GetBuffer

            Dim ParLogo As New SqlParameter("@Logo", Byte_Logo)
            Dim ParSlogan As New SqlParameter("@Eslogan", Byte_Slogan)
            Dim ParNombre As New SqlParameter("@Nombre", TxtEscuela.Text.Trim)
            Dim ParCodigo As New SqlParameter("@Codigo", TxtCodigo.Text.Trim)
            Dim ParBarrio As New SqlParameter("@Barrio", TxtBarrio.Text.Trim)

            sqlcmd.Parameters.Add(ParLogo)
            sqlcmd.Parameters.Add(ParSlogan)
            sqlcmd.Parameters.Add(ParNombre)
            sqlcmd.Parameters.Add(ParCodigo)
            sqlcmd.Parameters.Add(ParBarrio)
            sqlcmd.Parameters.AddWithValue("@Metodo_Ingreso_Nota", CmbMetodoIngresoNota.Text)

            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub
    Sub Actualizar_Escuela()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("UPDATE  Escuela SET Nombre=@Nombre, Codigo_Unico=@Codigo,Logo=@Logo,Eslogan_Del_Anio=@Eslogan ,Barrio=@Barrio, Metodo_Ingreso_Notas=@Metodo_Ingreso_Nota where Id_Escuela=" + Id_Escuela.ToString, SqlCon)

        Try
            Dim ms As MemoryStream = New MemoryStream
            Dim mss As MemoryStream = New MemoryStream

            Me.PnLogo.Image.Save(ms, PnLogo.Image.RawFormat)
            Dim Byte_Logo() As Byte
            Byte_Logo = ms.GetBuffer

            Me.PnEslogan.Image.Save(mss, PnEslogan.Image.RawFormat)
            Dim Byte_Slogan() As Byte
            Byte_Slogan = mss.GetBuffer

            Dim ParLogo As New SqlParameter("@Logo", Byte_Logo)
            Dim ParSlogan As New SqlParameter("@Eslogan", Byte_Slogan)
            Dim ParNombre As New SqlParameter("@Nombre", TxtEscuela.Text.Trim)
            Dim ParCodigo As New SqlParameter("@Codigo", TxtCodigo.Text.Trim)
            Dim ParBarrio As New SqlParameter("@Barrio", TxtBarrio.Text.Trim)

            sqlcmd.Parameters.Add(ParLogo)
            sqlcmd.Parameters.Add(ParSlogan)
            sqlcmd.Parameters.Add(ParNombre)
            sqlcmd.Parameters.Add(ParCodigo)
            sqlcmd.Parameters.Add(ParBarrio)
            sqlcmd.Parameters.AddWithValue("@Metodo_Ingreso_Nota", CmbMetodoIngresoNota.Text.Trim)

            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un errror")
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub

    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Registros()
        If Cliente_o_Server.Equals("Servidor") Then
            ChkCliente_Servidor.Checked = True
            LblClienteServidor.Text = "Servidor"
        Else
            ChkCliente_Servidor.Checked = False
            LblClienteServidor.Text = "Cliente"
        End If
    End Sub
    Public Sub ReadSoftwarefromXML()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            Dim bd As String = root.Attributes.Item(0).Value
            LblNombreProyecto.Text = (AES.Decrypt(bd, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub ChkCliente_Servidor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCliente_Servidor.CheckedChanged

    End Sub
    Sub CambiarEstado()
        If ChkCliente_Servidor.Checked = True Then
            LblClienteServidor.Text = "Servidor"
            SavetoXML_Servidor_Remoto(AES.Encrypt("Servidor", appPwdUnique, Integer.Parse("256")))
            Cliente_o_Server = "Servidor"
        Else
            LblClienteServidor.Text = "Cliente"
            SavetoXML_Servidor_Remoto(AES.Encrypt("Cliente", appPwdUnique, Integer.Parse("256")))
            Cliente_o_Server = "Cliente"
        End If
    End Sub

    Private Sub LblClienteServidor_Click(sender As Object, e As EventArgs) Handles LblClienteServidor.Click
        If ChkCliente_Servidor.Checked = True Then
            ChkCliente_Servidor.Checked = False
        Else
            ChkCliente_Servidor.Checked = True
        End If
        CambiarEstado()
    End Sub

    Private Sub ChkCliente_Servidor_Click(sender As Object, e As EventArgs) Handles ChkCliente_Servidor.Click
        CambiarEstado()
    End Sub
End Class