Imports System.IO
Public Module Conf
    Public UserID As Int32
    Public User As String
    Public UserName As String
    Public UserPass As String
    Public UserGrado As String
    Public UserModalidad As String
    Public UserTurno As String
    Public UserSeccion As String
    Public Empresa As String
    Public Logo As Image
    Public Slogan As String
    Public BackUp_al_Cerrar As Boolean
    Public Sesion As Int32
    Public Acceso As String
    Public ClientIP As String                   '   ip de la pc cliente
    Public ClientName As String                 '   Nombre de la Pc Cliente
    Public Logo_Empresa() As Byte
    Public Id_Escuela As Int32
    Public Escuela As String
    Public Codigo_Escuela As String
    Public Metodo_Ingreso_de_Nota As String = ""      '   Estado para definir el tipo de ingreso de notas   DISCIPLINA,GRADO
    Public Ruta_Backup As String
    Public Modo_de_Busqueda As String
    Public Imprimir_Error As Int32
    Public Ultimo_Backup As Date
    Public Tipo_de_Centro As String               '    NER,UNICO
    Public Cliente_o_Server As String = ""              ' determinar si la pc es cliente o servidor


End Module
