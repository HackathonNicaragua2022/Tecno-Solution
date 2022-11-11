<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfig))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.LblClienteServidor = New System.Windows.Forms.Label()
        Me.ChkCliente_Servidor = New UIDC.UI_MaterialToggle()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.CmbMetodoIngresoNota = New System.Windows.Forms.ComboBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TxtBarrio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BtnAddEslogan = New System.Windows.Forms.Button()
        Me.PnEslogan = New System.Windows.Forms.PictureBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnAddLogo = New System.Windows.Forms.Button()
        Me.PnLogo = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtEscuela = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.LblNombreProyecto = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PnEslogan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 522)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel23)
        Me.Panel2.Controls.Add(Me.Panel20)
        Me.Panel2.Controls.Add(Me.Panel15)
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel18)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(537, 798)
        Me.Panel2.TabIndex = 0
        '
        'Panel23
        '
        Me.Panel23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel23.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel23.Controls.Add(Me.LblClienteServidor)
        Me.Panel23.Controls.Add(Me.ChkCliente_Servidor)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.Label9)
        Me.Panel23.Controls.Add(Me.Panel25)
        Me.Panel23.Location = New System.Drawing.Point(3, 689)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(522, 85)
        Me.Panel23.TabIndex = 16
        '
        'LblClienteServidor
        '
        Me.LblClienteServidor.AutoSize = True
        Me.LblClienteServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClienteServidor.ForeColor = System.Drawing.Color.White
        Me.LblClienteServidor.Location = New System.Drawing.Point(71, 21)
        Me.LblClienteServidor.Name = "LblClienteServidor"
        Me.LblClienteServidor.Size = New System.Drawing.Size(73, 20)
        Me.LblClienteServidor.TabIndex = 49
        Me.LblClienteServidor.Text = "Label10"
        '
        'ChkCliente_Servidor
        '
        Me.ChkCliente_Servidor.AutoSize = True
        Me.ChkCliente_Servidor.Checked = True
        Me.ChkCliente_Servidor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCliente_Servidor.EllipseBorderColor = "#FFFFFF"
        Me.ChkCliente_Servidor.EllipseColor = "#508EF5"
        Me.ChkCliente_Servidor.Location = New System.Drawing.Point(18, 21)
        Me.ChkCliente_Servidor.Name = "ChkCliente_Servidor"
        Me.ChkCliente_Servidor.Size = New System.Drawing.Size(47, 19)
        Me.ChkCliente_Servidor.TabIndex = 48
        Me.ChkCliente_Servidor.Text = "UI_MaterialToggle1"
        Me.ChkCliente_Servidor.UseVisualStyleBackColor = True
        '
        'Panel24
        '
        Me.Panel24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel24.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel24.Location = New System.Drawing.Point(15, 50)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(490, 4)
        Me.Panel24.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(14, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(396, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Define si la PC se conecta de manera remota o es el Servidor"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(5, 85)
        Me.Panel25.TabIndex = 2
        '
        'Panel20
        '
        Me.Panel20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel20.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel20.Controls.Add(Me.CmbMetodoIngresoNota)
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Controls.Add(Me.Label8)
        Me.Panel20.Controls.Add(Me.Panel22)
        Me.Panel20.Location = New System.Drawing.Point(3, 602)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(522, 67)
        Me.Panel20.TabIndex = 15
        '
        'CmbMetodoIngresoNota
        '
        Me.CmbMetodoIngresoNota.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CmbMetodoIngresoNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbMetodoIngresoNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMetodoIngresoNota.FormattingEnabled = True
        Me.CmbMetodoIngresoNota.Items.AddRange(New Object() {"GRADO", "DISCIPLINA"})
        Me.CmbMetodoIngresoNota.Location = New System.Drawing.Point(15, 10)
        Me.CmbMetodoIngresoNota.Name = "CmbMetodoIngresoNota"
        Me.CmbMetodoIngresoNota.Size = New System.Drawing.Size(503, 32)
        Me.CmbMetodoIngresoNota.TabIndex = 5
        Me.CmbMetodoIngresoNota.Text = "GRADO"
        '
        'Panel21
        '
        Me.Panel21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel21.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel21.Location = New System.Drawing.Point(15, 37)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(490, 4)
        Me.Panel21.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(14, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Metodo de Ingreso de Notas"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(5, 67)
        Me.Panel22.TabIndex = 2
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.TxtBarrio)
        Me.Panel15.Controls.Add(Me.Label7)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Location = New System.Drawing.Point(3, 319)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(527, 67)
        Me.Panel15.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel16.Location = New System.Drawing.Point(15, 37)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(495, 4)
        Me.Panel16.TabIndex = 4
        '
        'TxtBarrio
        '
        Me.TxtBarrio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBarrio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarrio.ForeColor = System.Drawing.Color.White
        Me.TxtBarrio.Location = New System.Drawing.Point(18, 6)
        Me.TxtBarrio.Name = "TxtBarrio"
        Me.TxtBarrio.Size = New System.Drawing.Size(494, 25)
        Me.TxtBarrio.TabIndex = 3
        Me.TxtBarrio.Text = "Pedro Juaquin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(14, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Barrio Comunidad"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(5, 67)
        Me.Panel17.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel12.Controls.Add(Me.BtnAddEslogan)
        Me.Panel12.Controls.Add(Me.PnEslogan)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Location = New System.Drawing.Point(241, 397)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(289, 190)
        Me.Panel12.TabIndex = 14
        '
        'BtnAddEslogan
        '
        Me.BtnAddEslogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddEslogan.ForeColor = System.Drawing.Color.DimGray
        Me.BtnAddEslogan.Location = New System.Drawing.Point(228, 135)
        Me.BtnAddEslogan.Name = "BtnAddEslogan"
        Me.BtnAddEslogan.Size = New System.Drawing.Size(49, 49)
        Me.BtnAddEslogan.TabIndex = 6
        Me.BtnAddEslogan.Text = "+"
        Me.BtnAddEslogan.UseVisualStyleBackColor = True
        '
        'PnEslogan
        '
        Me.PnEslogan.Image = CType(resources.GetObject("PnEslogan.Image"), System.Drawing.Image)
        Me.PnEslogan.Location = New System.Drawing.Point(18, 17)
        Me.PnEslogan.Name = "PnEslogan"
        Me.PnEslogan.Size = New System.Drawing.Size(258, 112)
        Me.PnEslogan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PnEslogan.TabIndex = 5
        Me.PnEslogan.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel13.Location = New System.Drawing.Point(15, 158)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(200, 4)
        Me.Panel13.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(14, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Eslogan del Año"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(5, 190)
        Me.Panel14.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel9.Controls.Add(Me.BtnAddLogo)
        Me.Panel9.Controls.Add(Me.PnLogo)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Location = New System.Drawing.Point(3, 397)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(230, 190)
        Me.Panel9.TabIndex = 12
        '
        'BtnAddLogo
        '
        Me.BtnAddLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddLogo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnAddLogo.Location = New System.Drawing.Point(169, 58)
        Me.BtnAddLogo.Name = "BtnAddLogo"
        Me.BtnAddLogo.Size = New System.Drawing.Size(49, 49)
        Me.BtnAddLogo.TabIndex = 6
        Me.BtnAddLogo.Text = "+"
        Me.BtnAddLogo.UseVisualStyleBackColor = True
        '
        'PnLogo
        '
        Me.PnLogo.Image = CType(resources.GetObject("PnLogo.Image"), System.Drawing.Image)
        Me.PnLogo.Location = New System.Drawing.Point(18, 17)
        Me.PnLogo.Name = "PnLogo"
        Me.PnLogo.Size = New System.Drawing.Size(135, 126)
        Me.PnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PnLogo.TabIndex = 5
        Me.PnLogo.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel10.Location = New System.Drawing.Point(15, 157)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(212, 4)
        Me.Panel10.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(14, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Logotipo del centro educativo"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 190)
        Me.Panel11.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.TxtCodigo)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Location = New System.Drawing.Point(3, 238)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(527, 71)
        Me.Panel6.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel7.Location = New System.Drawing.Point(15, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(495, 4)
        Me.Panel7.TabIndex = 4
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.White
        Me.TxtCodigo.Location = New System.Drawing.Point(18, 8)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(494, 25)
        Me.TxtCodigo.TabIndex = 3
        Me.TxtCodigo.Text = "15942"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(14, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Código único del Centro"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 71)
        Me.Panel8.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.TxtEscuela)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(3, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 93)
        Me.Panel3.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.Location = New System.Drawing.Point(15, 57)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(495, 4)
        Me.Panel5.TabIndex = 4
        '
        'TxtEscuela
        '
        Me.TxtEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEscuela.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtEscuela.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEscuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEscuela.ForeColor = System.Drawing.Color.White
        Me.TxtEscuela.Location = New System.Drawing.Point(18, 26)
        Me.TxtEscuela.Name = "TxtEscuela"
        Me.TxtEscuela.Size = New System.Drawing.Size(494, 25)
        Me.TxtEscuela.TabIndex = 3
        Me.TxtEscuela.Text = "Francisca Hernández Espinoza"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(14, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Especifique aquí el nombre del Centro Educativo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 93)
        Me.Panel4.TabIndex = 2
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel18.Controls.Add(Me.LblNombreProyecto)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.Label1)
        Me.Panel18.Location = New System.Drawing.Point(3, 9)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(527, 100)
        Me.Panel18.TabIndex = 9
        '
        'LblNombreProyecto
        '
        Me.LblNombreProyecto.AutoSize = True
        Me.LblNombreProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreProyecto.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblNombreProyecto.Location = New System.Drawing.Point(14, 51)
        Me.LblNombreProyecto.Name = "LblNombreProyecto"
        Me.LblNombreProyecto.Size = New System.Drawing.Size(326, 20)
        Me.LblNombreProyecto.TabIndex = 2
        Me.LblNombreProyecto.Text = "Especificación de datos del Centro educativo"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(5, 100)
        Me.Panel19.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Control de Notas"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(420, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.DimGray
        Me.BtnAceptar.Location = New System.Drawing.Point(294, 540)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(120, 36)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConfig"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PnEslogan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TxtBarrio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnAddEslogan As Button
    Friend WithEvents PnEslogan As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnAddLogo As Button
    Friend WithEvents PnLogo As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtEscuela As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents LblNombreProyecto As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Panel20 As Panel
    Friend WithEvents CmbMetodoIngresoNota As ComboBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents ChkCliente_Servidor As UIDC.UI_MaterialToggle
    Friend WithEvents LblClienteServidor As Label
End Class
