Public Class DDatos
    Private _Nombres As String
    Private _Pellidos As String
    Private _Telefono As String
    Private _Nacimiento As Date
    Private _Año As Int32
    Private _Fecha As Date
    Private _Grado As String
    Private _Nota As Int32
    Private _Corte As String
    Private _Semestre As String
    Private _Modalidad As String
    Private _Turno As String
    Private _Seccion As String
    Private _Id_Mined As String

    Private _Sexo As String

    Public Property Id_Mined As String
        Set(value As String)
            _Id_Mined = value
        End Set
        Get
            Return _Id_Mined
        End Get
    End Property
    Public Property Seccion As String
        Set(value As String)
            _Seccion = value
        End Set
        Get
            Return _Seccion
        End Get
    End Property
    Public Property Telefono As String
        Set(value As String)
            _Telefono = value
        End Set
        Get
            Return _Telefono
        End Get
    End Property
    Public Property Turno As String
        Set(value As String)
            _Turno = value
        End Set
        Get
            Return _Turno
        End Get
    End Property
    Public Property Sexo As String
        Set(value As String)
            _Sexo = value
        End Set
        Get
            Return _Sexo
        End Get
    End Property

    Public Property Nombres As String
        Set(value As String)
            _Nombres = value
        End Set
        Get
            Return _Nombres
        End Get
    End Property
    Public Property Apellidos As String
        Set(value As String)
            _Pellidos = value
        End Set
        Get
            Return _Pellidos
        End Get
    End Property
    Public Property Nacimiento As Date
        Set(value As Date)
            _Nacimiento = value
        End Set
        Get
            Return _Nacimiento
        End Get
    End Property
    Public Property Año As Int32
        Set(value As Int32)
            _Año = value
        End Set
        Get
            Return _Año
        End Get
    End Property
    Public Property Fecha As Date
        Set(value As Date)
            _Fecha = value
        End Set
        Get
            Return _Fecha
        End Get
    End Property
    Public Property Grado As String
        Set(value As String)
            _Grado = value
        End Set
        Get
            Return _Grado
        End Get
    End Property
    Public Property Nota As Int32
        Set(value As Int32)
            _Nota = value
        End Set
        Get
            Return _Nota
        End Get
    End Property
    Public Property Corte As String
        Set(value As String)
            _Corte = value
        End Set
        Get
            Return _Corte
        End Get
    End Property
    Public Property Semestre As String
        Set(value As String)
            _Semestre = value
        End Set
        Get
            Return _Semestre
        End Get
    End Property

    Public Property Modalidad As String
        Set(value As String)
            _Modalidad = value
        End Set
        Get
            Return _Modalidad
        End Get
    End Property
    Public Sub New()

    End Sub

    Public Sub New(nombres As String, apellidos As String, nacimiento As Date,
                   año As Int32, fecha As Date, grado As String, nota As Int32,
                   corte As String, semestre As String, modalidad As String,
                   sex As String, turno As String, seccion As String, telef As String, idmined As String)
        Me.Nombres = nombres
        Me.Apellidos = apellidos
        Me.Nacimiento = nacimiento
        Me.Año = año
        Me.Fecha = fecha
        Me.Grado = grado
        Me.Nota = nota
        Me.Corte = corte
        Me.Semestre = semestre
        Me.Modalidad = modalidad
        Me.Sexo = sex
        Me.Turno = turno
        Me.Seccion = seccion
        Me.Telefono = telef
        Me.Id_Mined = idmined
    End Sub
End Class
