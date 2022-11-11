Imports System.Net.Mail
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.BarcodeCodabar
Imports System.Configuration

Public Class Utilidades

    'Sub AddUpdateAppSettingns(key As String, value As String)
    '    Try
    '        Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '        Dim settings = configFile.AppSettings.Settings

    '        If IsNothing(settings(key)) Then
    '            Mensaje("La variable de configuraciónn no existe")
    '            'settings.Add(key, value)
    '        Else
    '            settings(key).Value = value
    '        End If
    '        configFile.Save(ConfigurationSaveMode.Modified)
    '        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
    '    Catch ex As ConfigurationErrorsException
    '        Mensaje(ex.Message, True)
    '    End Try
    'End Sub
    Public Function Enviar_Email(De As String, pass As String, A As String, Mensaje As String, Optional Asunto As String = "JESS 92", Optional IsHTML As Boolean = False) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(De, pass)
            'Smtp_Server.Port = 587
            Smtp_Server.Port = 465
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage
            e_mail.From = New MailAddress(De)
            e_mail.To.Add(A) 'correo destino
            e_mail.Subject = Asunto
            If IsHTML = True Then
                e_mail.IsBodyHtml = True
            Else
                e_mail.IsBodyHtml = False
            End If

            e_mail.Body = Mensaje
            Smtp_Server.Send(e_mail)
            rpta = True
        Catch ex As Exception
            Me.Mensaje(ex.Message, True)
            rpta = False
        End Try
        Return rpta
    End Function


    Public Sub Alternar_Color_DatagridView(Grid As DataGridView)
        Grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(231, 230, 230)
        Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242)
        Grid.RowsDefaultCellStyle.Font = New Font("Roboto Light", 10)
        Grid.RowsDefaultCellStyle.Padding = New Padding(7)
        Grid.DefaultCellStyle.ForeColor = Color.FromArgb(123, 123, 123)

        Grid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 201, 201)
        Grid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(68, 84, 106)

        ' Grid.GridColor = Color.FromArgb(231, 230, 230)

        Grid.EnableHeadersVisualStyles = False
        Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219)
        Grid.ColumnHeadersDefaultCellStyle.Font = New Font("Roboto Light", 12)
        Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(242, 242, 242)
        Grid.ColumnHeadersDefaultCellStyle.Padding = New Padding(8)

        'Grid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 116, 120)
        'Grid.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(242, 242, 242)

        'Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Grid.ColumnHeadersHeight = 40
        Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        Grid.BackgroundColor = Color.FromArgb(245, 245, 245)
        Grid.BorderStyle = BorderStyle.None
        Grid.RowHeadersVisible = False


        Grid.CellBorderStyle = DataGridViewCellBorderStyle.None
        Grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Grid.MultiSelect = True

        ' Auto scroll

        ' Grid.FirstDisplayedScrollingRowIndex = Grid.Rows.Count - 1
    End Sub

    Public Shared Function BarCode_128(ByVal _code As String, Optional ByVal vertexto As Boolean = False, Optional ByVal Height As Single = 0)
        Dim barcode As New Barcode128
        If Height <> 0 Then
            barcode.BarHeight = Height
        Else
            barcode.BarHeight = 20
        End If
        barcode.Code = _code
        barcode.ChecksumText = True
        barcode.CodeType = CODE128

        Try
            Dim bm As New Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))
            Dim img As Image
            img = New Bitmap(bm.Width, bm.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            g.DrawImage(bm, 0, 0)
            Return img
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function SoloNumero(sender As Object, e As KeyPressEventArgs)

        Try
            If e.KeyChar = "." Or e.KeyChar = "," Or IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch

        End Try
        Return e.Handled
    End Function

    Public Function Mensaje(Texto As String, Optional iserror As Boolean = False, Optional Titulo As String = "Control Estudiantil") As Boolean
        Dim rpta As Boolean
        Try
            If iserror = True Then
                MessageBox.Show(Texto, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Texto, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            rpta = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            rpta = False
        End Try
        Return rpta
    End Function

    Public Function Preguntar(Pregunta As String, Optional ByVal Boton As String = "No", Optional Titulo As String = "Control Estudiantil") As Boolean
        Dim Rpta As Boolean
        If Pregunta <> String.Empty Then
            Try
                Dim Op As DialogResult
                If Boton = "Yes" Then
                    Op = MessageBox.Show(Pregunta, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                                          MessageBoxDefaultButton.Button1)
                ElseIf Boton = "No" Then
                    Op = MessageBox.Show(Pregunta, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                                          MessageBoxDefaultButton.Button2)
                Else
                    Op = MessageBox.Show(Pregunta, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                                          MessageBoxDefaultButton.Button2)
                End If

                If Op = DialogResult.Yes Then
                    Rpta = True
                Else
                    Rpta = False
                End If
            Catch ex As Exception
                Mensaje(ex.Message, True)
            End Try
        End If
        Return Rpta
    End Function

    Public Function Get_IP() As String
        Dim Direccion_Ip As String = ""
        Dim Equipo As String
        Dim dirip As Net.IPHostEntry
        Try
            Equipo = System.Net.Dns.GetHostName
#Disable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
            dirip = System.Net.Dns.GetHostByName(Equipo)
#Enable Warning BC40000 ' 'Public Shared Overloads Function GetHostByName(hostName As String) As IPHostEntry' está obsoleto: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'.
            Direccion_Ip = dirip.AddressList(0).ToString
        Catch ex As Exception
            Mensaje(ex.Message, True)
        End Try

        Return Direccion_Ip
    End Function

    Public Function Capturar_Pantalla() As PictureBox
        Dim Imagen As PictureBox = Nothing
        Dim bounds As Rectangle
        Dim Screenshot As System.Drawing.Bitmap
        Dim Graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        Screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Graph = Graphics.FromImage(Screenshot)
        Graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)

        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        Imagen.Image = Screenshot

        Return Imagen
    End Function
    Public Sub Guardar_Conexion(ConexionName As String, Cadena As String)
        Dim MiAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Dim MiSeccion As ConnectionStringsSection = DirectCast(MiAppConfig.GetSection("connectionStrings"), ConnectionStringsSection)
        MiSeccion.ConnectionStrings(ConexionName).ConnectionString = Cadena
        MiAppConfig.Save()
    End Sub

End Class
