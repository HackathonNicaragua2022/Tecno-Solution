<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.PanelDios = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblnombredeservicio = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsoftware = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBasededatos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnombre_scrypt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTbasededatos = New System.Windows.Forms.TextBox()
        Me.lblcontraseña = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCrearUsaurioDb = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtArgumentosini = New System.Windows.Forms.RichTextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtservidor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEliminarBase = New System.Windows.Forms.RichTextBox()
        Me.lblRutaInstancia = New System.Windows.Forms.Label()
        Me.min2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.seg2 = New System.Windows.Forms.Label()
        Me.milise = New System.Windows.Forms.Label()
        Me.mils2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCrear_procedimientos = New System.Windows.Forms.RichTextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TimerCRARINI = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDios.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PBLogo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 296)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(297, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PBLogo
        '
        Me.PBLogo.Image = CType(resources.GetObject("PBLogo.Image"), System.Drawing.Image)
        Me.PBLogo.Location = New System.Drawing.Point(50, 61)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(200, 174)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'PanelDios
        '
        Me.PanelDios.AutoScroll = True
        Me.PanelDios.BackColor = System.Drawing.Color.Black
        Me.PanelDios.Controls.Add(Me.GroupBox4)
        Me.PanelDios.Controls.Add(Me.GroupBox6)
        Me.PanelDios.Controls.Add(Me.Button4)
        Me.PanelDios.Controls.Add(Me.Button3)
        Me.PanelDios.Controls.Add(Me.GroupBox3)
        Me.PanelDios.Controls.Add(Me.Panel10)
        Me.PanelDios.Controls.Add(Me.GroupBox2)
        Me.PanelDios.Controls.Add(Me.datalistado)
        Me.PanelDios.Location = New System.Drawing.Point(317, 12)
        Me.PanelDios.Name = "PanelDios"
        Me.PanelDios.Size = New System.Drawing.Size(699, 568)
        Me.PanelDios.TabIndex = 626
        Me.PanelDios.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblnombredeservicio)
        Me.GroupBox4.Controls.Add(Me.txtusuario)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtsoftware)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lblBasededatos)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtnombre_scrypt)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TXTbasededatos)
        Me.GroupBox4.Controls.Add(Me.lblcontraseña)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox4.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(646, 200)
        Me.GroupBox4.TabIndex = 625
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "YA TENGO SQL SERVER INSTALADO"
        '
        'lblnombredeservicio
        '
        Me.lblnombredeservicio.Location = New System.Drawing.Point(184, 57)
        Me.lblnombredeservicio.MaxLength = 15
        Me.lblnombredeservicio.Name = "lblnombredeservicio"
        Me.lblnombredeservicio.Size = New System.Drawing.Size(182, 20)
        Me.lblnombredeservicio.TabIndex = 621
        Me.lblnombredeservicio.Text = "SQLEXPRESS"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(184, 83)
        Me.txtusuario.MaxLength = 15
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(122, 20)
        Me.txtusuario.TabIndex = 626
        Me.txtusuario.Text = "jess92"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(132, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 625
        Me.Label15.Text = "Usuario:"
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(321, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(233, 19)
        Me.Label14.TabIndex = 623
        Me.Label14.Text = "Se creara una base de datos con este Nombre"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Aqua
        Me.Label13.Location = New System.Drawing.Point(372, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(185, 51)
        Me.Label13.TabIndex = 623
        Me.Label13.Text = "Si ya tienes SQLServer Instalado y NO es Express entonces deja en Blanco este Tex" &
    "box"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(7, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(412, 13)
        Me.Label12.TabIndex = 623
        Me.Label12.Text = "Usa _ en lugar de espacios y no uses Caracteres especiales solo usa letras y nume" &
    "ros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 623
        Me.Label1.Text = "NOMBRE DE TU SOFTWARE"
        '
        'txtsoftware
        '
        Me.txtsoftware.Location = New System.Drawing.Point(185, 32)
        Me.txtsoftware.MaxLength = 15
        Me.txtsoftware.Name = "txtsoftware"
        Me.txtsoftware.Size = New System.Drawing.Size(133, 20)
        Me.txtsoftware.TabIndex = 624
        Me.txtsoftware.Text = "Control_Estudiantil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(64, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 618
        Me.Label8.Text = "Nombre de Instancia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(83, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 618
        Me.Label6.Text = "Contraseña SQL:"
        '
        'lblBasededatos
        '
        Me.lblBasededatos.AutoSize = True
        Me.lblBasededatos.ForeColor = System.Drawing.Color.White
        Me.lblBasededatos.Location = New System.Drawing.Point(92, 141)
        Me.lblBasededatos.Name = "lblBasededatos"
        Me.lblBasededatos.Size = New System.Drawing.Size(78, 13)
        Me.lblBasededatos.TabIndex = 618
        Me.lblBasededatos.Text = "Base de datos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(77, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 618
        Me.Label9.Text = "Nombre de Scrypt:"
        '
        'txtnombre_scrypt
        '
        Me.txtnombre_scrypt.Location = New System.Drawing.Point(185, 161)
        Me.txtnombre_scrypt.Name = "txtnombre_scrypt"
        Me.txtnombre_scrypt.Size = New System.Drawing.Size(79, 20)
        Me.txtnombre_scrypt.TabIndex = 621
        Me.txtnombre_scrypt.Text = "ScriptSIAUDR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(270, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 618
        Me.Label11.Text = ".text"
        '
        'TXTbasededatos
        '
        Me.TXTbasededatos.Location = New System.Drawing.Point(184, 135)
        Me.TXTbasededatos.Name = "TXTbasededatos"
        Me.TXTbasededatos.Size = New System.Drawing.Size(134, 20)
        Me.TXTbasededatos.TabIndex = 621
        Me.TXTbasededatos.Text = "Ctrl_Estudiantil"
        '
        'lblcontraseña
        '
        Me.lblcontraseña.Location = New System.Drawing.Point(185, 109)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(134, 20)
        Me.lblcontraseña.TabIndex = 621
        Me.lblcontraseña.Text = "softwarereal"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtCrearUsaurioDb)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(443, 244)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 220)
        Me.GroupBox6.TabIndex = 630
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Servira para Crear un Usuario para el Servidor - NO TOCAR"
        '
        'txtCrearUsaurioDb
        '
        Me.txtCrearUsaurioDb.Location = New System.Drawing.Point(6, 32)
        Me.txtCrearUsaurioDb.Multiline = True
        Me.txtCrearUsaurioDb.Name = "txtCrearUsaurioDb"
        Me.txtCrearUsaurioDb.Size = New System.Drawing.Size(205, 159)
        Me.txtCrearUsaurioDb.TabIndex = 630
        Me.txtCrearUsaurioDb.Text = resources.GetString("txtCrearUsaurioDb.Text")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(8, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 99)
        Me.Button4.TabIndex = 627
        Me.Button4.Text = "Iniciar Transmision"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(8, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 117)
        Me.Button3.TabIndex = 626
        Me.Button3.Text = "Volver a modo Normal"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtArgumentosini)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(21, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(404, 101)
        Me.GroupBox3.TabIndex = 623
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos para Instalar SQLServer Express NO TOCAR"
        '
        'txtArgumentosini
        '
        Me.txtArgumentosini.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArgumentosini.Location = New System.Drawing.Point(11, 19)
        Me.txtArgumentosini.Name = "txtArgumentosini"
        Me.txtArgumentosini.Size = New System.Drawing.Size(352, 70)
        Me.txtArgumentosini.TabIndex = 589
        Me.txtArgumentosini.Text = resources.GetString("txtArgumentosini.Text")
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.txtservidor)
        Me.Panel10.Controls.Add(Me.GroupBox1)
        Me.Panel10.Controls.Add(Me.min2)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Controls.Add(Me.seg2)
        Me.Panel10.Controls.Add(Me.milise)
        Me.Panel10.Controls.Add(Me.mils2)
        Me.Panel10.Location = New System.Drawing.Point(21, 478)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(531, 135)
        Me.Panel10.TabIndex = 608
        '
        'txtservidor
        '
        Me.txtservidor.AutoSize = True
        Me.txtservidor.ForeColor = System.Drawing.Color.White
        Me.txtservidor.Location = New System.Drawing.Point(10, 10)
        Me.txtservidor.Name = "txtservidor"
        Me.txtservidor.Size = New System.Drawing.Size(16, 13)
        Me.txtservidor.TabIndex = 611
        Me.txtservidor.Text = "---"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEliminarBase)
        Me.GroupBox1.Controls.Add(Me.lblRutaInstancia)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 109)
        Me.GroupBox1.TabIndex = 608
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Script para Eliminar la base de datos NO TOCAR"
        '
        'txtEliminarBase
        '
        Me.txtEliminarBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEliminarBase.Location = New System.Drawing.Point(8, 25)
        Me.txtEliminarBase.Name = "txtEliminarBase"
        Me.txtEliminarBase.Size = New System.Drawing.Size(487, 77)
        Me.txtEliminarBase.TabIndex = 589
        Me.txtEliminarBase.Text = "alter database BASEADA set single_user with rollback immediate " & Global.Microsoft.VisualBasic.ChrW(10) & "DROP DATABASE BAS" &
    "EADA"
        '
        'lblRutaInstancia
        '
        Me.lblRutaInstancia.AutoSize = True
        Me.lblRutaInstancia.BackColor = System.Drawing.Color.White
        Me.lblRutaInstancia.Location = New System.Drawing.Point(32, 44)
        Me.lblRutaInstancia.Name = "lblRutaInstancia"
        Me.lblRutaInstancia.Size = New System.Drawing.Size(99, 13)
        Me.lblRutaInstancia.TabIndex = 605
        Me.lblRutaInstancia.Text = "lblRutaInstancia"
        '
        'min2
        '
        Me.min2.AutoSize = True
        Me.min2.ForeColor = System.Drawing.Color.White
        Me.min2.Location = New System.Drawing.Point(102, 110)
        Me.min2.Name = "min2"
        Me.min2.Size = New System.Drawing.Size(19, 13)
        Me.min2.TabIndex = 618
        Me.min2.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(112, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 618
        Me.Label7.Text = "Servidor:"
        '
        'seg2
        '
        Me.seg2.AutoSize = True
        Me.seg2.ForeColor = System.Drawing.Color.White
        Me.seg2.Location = New System.Drawing.Point(127, 110)
        Me.seg2.Name = "seg2"
        Me.seg2.Size = New System.Drawing.Size(19, 13)
        Me.seg2.TabIndex = 618
        Me.seg2.Text = "00"
        '
        'milise
        '
        Me.milise.AutoSize = True
        Me.milise.ForeColor = System.Drawing.Color.White
        Me.milise.Location = New System.Drawing.Point(130, 85)
        Me.milise.Name = "milise"
        Me.milise.Size = New System.Drawing.Size(19, 13)
        Me.milise.TabIndex = 618
        Me.milise.Text = "00"
        '
        'mils2
        '
        Me.mils2.AutoSize = True
        Me.mils2.ForeColor = System.Drawing.Color.White
        Me.mils2.Location = New System.Drawing.Point(208, 110)
        Me.mils2.Name = "mils2"
        Me.mils2.Size = New System.Drawing.Size(19, 13)
        Me.mils2.TabIndex = 618
        Me.mils2.Text = "00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCrear_procedimientos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(21, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 121)
        Me.GroupBox2.TabIndex = 622
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PEGA TU Script para Crear las Tablas y Procedimientos"
        '
        'txtCrear_procedimientos
        '
        Me.txtCrear_procedimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrear_procedimientos.Location = New System.Drawing.Point(11, 32)
        Me.txtCrear_procedimientos.Name = "txtCrear_procedimientos"
        Me.txtCrear_procedimientos.Size = New System.Drawing.Size(352, 79)
        Me.txtCrear_procedimientos.TabIndex = 589
        Me.txtCrear_procedimientos.Text = resources.GetString("txtCrear_procedimientos.Text")
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToOrderColumns = True
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.Color.LightGray
        Me.datalistado.Location = New System.Drawing.Point(558, 478)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 5
        Me.datalistado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.Height = 60
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(110, 122)
        Me.datalistado.TabIndex = 625
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox5.Location = New System.Drawing.Point(36, 337)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(130, 45)
        Me.GroupBox5.TabIndex = 628
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "NO TENGO SQL SERVER INSTALADO"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(7, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(548, 66)
        Me.Button5.TabIndex = 611
        Me.Button5.Text = "Instalar Servidor"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TimerCRARINI
        '
        Me.TimerCRARINI.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 293)
        Me.Controls.Add(Me.PanelDios)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplash"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDios.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PanelDios As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblnombredeservicio As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsoftware As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBasededatos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnombre_scrypt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTbasededatos As TextBox
    Friend WithEvents lblcontraseña As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtCrearUsaurioDb As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtArgumentosini As RichTextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtservidor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEliminarBase As RichTextBox
    Friend WithEvents lblRutaInstancia As Label
    Friend WithEvents min2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents seg2 As Label
    Friend WithEvents milise As Label
    Friend WithEvents mils2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCrear_procedimientos As RichTextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TimerCRARINI As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
End Class
