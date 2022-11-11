Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class FrmDashboard
    Dim aes As New AES
    Dim Servidor As String
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
    Public Sub LeerXML_Servidor()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Servidor.xml")
            Dim root As XmlElement = doc.DocumentElement
            Servidor = root.Attributes.Item(0).Value
            Servidor = (AES.Decrypt(Servidor, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Sub restaurar_base_para_versiones_no_express()
        Dim cnn As New SqlConnection("Server=.\;database=master; integrated security=yes")
        cnn.Open()
        Dim DropRes As String = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BASEADA' USE [master] ALTER DATABASE [BASEADA] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [BASEADA] RESTORE DATABASE BASEADA FROM DISK = N'" & LblRuta.Text & "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10"

        Try

            Dim BorraRestaura As New SqlCommand(DropRes, cnn)
            BorraRestaura.ExecuteNonQuery()

            MessageBox.Show("La base de datos " & Microsoft.VisualBasic.Left(LblRuta.Text, LblRuta.TextLength - 4) & " ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Sistema", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al restaurar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub dibujarAsignaturas()

    End Sub

    Private Sub UI_CustomButton5_Click(sender As Object, e As EventArgs) Handles UI_CustomButton5.Click
        GENERAR_COPIAS_DE_SEGURIDAD.ShowDialog()
    End Sub

    Private Sub UI_CustomButton6_Click(sender As Object, e As EventArgs) Handles UI_CustomButton6.Click
        LeerXML_base_de_datos()
        LeerXML_Servidor()

        With dlg
            .InitialDirectory = ""
            .Filter = "Backup " & Base_De_datos & "|*.bak"
            .FilterIndex = 2
            .Title = "Cargador de Backup " & Me.Text

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                LblRuta.Text = Path.GetFullPath(dlg.FileName)

            Catch ex As Exception

            End Try
        End If

        If MessageBox.Show("Usted está a punto de restaurar la base de datos," & vbCrLf &
"asegurese de que el archivo .bak sea reciente, de" & vbCrLf &
"lo contrario podría perder información y no podrá" & vbCrLf &
"recuperarla, ¿desea continuar?", "Restauración de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim cnn As New SqlConnection("Server=" & Servidor & ";database=master; integrated security=yes")
            cnn.Open()
            Dim DropRes As String = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" & Base_De_datos & "' USE [master] ALTER DATABASE [" & Base_De_datos & "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" & Base_De_datos & "] RESTORE DATABASE " & Base_De_datos & " FROM DISK = N'" & LblRuta.Text & "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10"

            Try

                Dim BorraRestaura As New SqlCommand(DropRes, cnn)
                BorraRestaura.ExecuteNonQuery()

                MessageBox.Show("La base de datos " & Microsoft.VisualBasic.Left(LblRuta.Text, LblRuta.TextLength - 4) & " ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Sistema", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Catch ex As Exception
                ' restaurar_base_para_versiones_no_express()
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        Else ' No restaura 
            Exit Sub
        End If
    End Sub
End Class