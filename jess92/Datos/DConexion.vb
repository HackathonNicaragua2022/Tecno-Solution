Imports System.Xml
Imports System.Configuration
Public Class DConexion
    Dim dbcnstring As String
    Public Cn As String = My.Settings.Cn 'New AES().Decrypt(checkServer(), appPwdUnique, Integer.Parse("256"))



    Public Function ObtenerCadenaConexion(nameConnectionString As String) As String

        ' Obtenemos el archivo de configuración de la aplicación. 
        ' 
        Dim config As Configuration =
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        Dim cs As ConnectionStringSettings =
            config.ConnectionStrings.ConnectionStrings(nameConnectionString)

        If (cs Is Nothing) Then Throw New ArgumentNullException("nameConnectionString", "El nombre de la cadena de conexión no existe en el archivo de configuración de la aplicación.")

        ' Devolvemos la cadena de conexión que se
        ' corresponda con el nombre especificado.
        '
        Return cs.ConnectionString

    End Function

    Public Sub ModificarCadenaConexion(nameConnectionString As String, connectionString As String)

        ' Obtenemos el archivo de configuración de la aplicación. 
        ' 
        Dim config As Configuration =
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Obtenemos la cadena de conexión.
        '
        Dim cs As ConnectionStringSettings =
         config.ConnectionStrings.ConnectionStrings(nameConnectionString)

        ' Modificamos el valor de la cadena de conexión.
        '
        cs.ConnectionString = connectionString

        ' Guardamos los cambios.
        '
        config.Save(ConfigurationSaveMode.Modified)

    End Sub

    Public Sub New()
        ' tratar de modificar la variable My.Settings.Cn desde aqui....
    End Sub


End Class
