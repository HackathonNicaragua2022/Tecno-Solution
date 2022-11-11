Imports System.Data.SqlClient
Imports System.IO

Public Class FrmConfiguracionInicial
    Dim LOGO_path As String = ""
    Dim SLOGAN_path As String = ""
    Dim Id_Escuela As Int32 = 0
    Dim Utilidades As New Utilidades
    Private Sub FrmConfiguracionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Registros()
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

            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub Insertar_Nuevo_Registro()
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("INSERT INTO Escuela (Nombre, Codigo_Unico,Logo,Eslogan_Del_Anio,Barrio) VALUES (@Nombre,@Codigo,@Logo,@Eslogan,@Barrio)", SqlCon)

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
        Dim sqlcmd As New SqlCommand("UPDATE  Escuela SET Nombre=@Nombre, Codigo_Unico=@Codigo,Logo=@Logo,Eslogan_Del_Anio=@Eslogan ,Barrio=@Barrio where Id_Escuela=" + Id_Escuela.ToString, SqlCon)

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

            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error")
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
    End Sub

    Function Insertar_Usuario() As Boolean

        Dim rpta As Boolean = False
        Dim SqlCon As New SqlConnection()
        SqlCon.ConnectionString = New DConexion().Cn
        Dim sqlcmd As New SqlCommand("insert into Docentes(Nombres,Apellidos,Cedula,Telefono,[User],Pass,Acceso)
values(@nombres,@apellidos,@cedula,@telefono,@user,@pass,'Administrador')", SqlCon)

        Try
            Dim ms As MemoryStream = New MemoryStream
            Dim mss As MemoryStream = New MemoryStream

            sqlcmd.Parameters.AddWithValue("@nombres", TxtNombres.Text)
            sqlcmd.Parameters.AddWithValue("@apellidos", TxtApellidos.Text)
            sqlcmd.Parameters.AddWithValue("@cedula", TxtCedula.Text)
            sqlcmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text)
            sqlcmd.Parameters.AddWithValue("@user", TxtUsuario.Text)
            sqlcmd.Parameters.AddWithValue("@pass", TxtPass.Text)

            SqlCon.Open()
            sqlcmd.ExecuteNonQuery()
            SqlCon.Close()
            rpta = True
        Catch ex As Exception
            MsgBox("Ocurrio un error al insertar el usuario")
            rpta = False
        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()
        End Try
        Return rpta
    End Function
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Verificar_Si_Existe_Registro() > 0 Then
            Actualizar_Escuela()
            If Insertar_Usuario() = True Then
                Utilidades.Mensaje("Usuario creado con éxito." + vbNewLine + "El Sistema se reiniciara")
                Application.Restart()
            End If
        Else
            Insertar_Nuevo_Registro()
            If Insertar_Usuario() = True Then
                Utilidades.Mensaje("Usuario creado con éxito." + vbNewLine + "El Sistema se reiniciara")
                Application.Restart()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New conexion_manual
        frm.Show()
    End Sub
End Class