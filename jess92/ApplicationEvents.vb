Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: Se genera cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: Se genera después de haberse cerrado todos los formularios de aplicación.  Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: Se genera si la aplicación encuentra una excepción no controlada.
    ' StartupNextInstance: Se genera cuando se inicia una aplicación de instancia única y dicha aplicación está ya activa. 
    ' NetworkAvailabilityChanged: Se genera cuando se conecta o desconecta la conexión de red.
    Partial Friend Class MyApplication

        Dim utilidades As New Utilidades
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            utilidades.Mensaje("Ha ocurrido Un Excepción no controlada" + vbNewLine + vbNewLine + e.Exception.Message, True)
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            utilidades.Mensaje("El sistema ya esta corriendo.")
            'If utilidades.Preguntar("¿Desea Reiniciarlo?") = True Then

            'End If
        End Sub
    End Class
End Namespace
