<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conexion_manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conexion_manual))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Logo_empresa = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtCnStringWEB = New System.Windows.Forms.TextBox()
        Me.txtCnString = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdatasource = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datalistado_movimientos_validar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TxtNameConeccion = New System.Windows.Forms.TextBox()
        Me.TxtServidor = New System.Windows.Forms.TextBox()
        Me.TxtBaseDeDatos = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistado_movimientos_validar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(628, 267)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 603
        Me.PictureBox1.TabStop = False
        '
        'Logo_empresa
        '
        Me.Logo_empresa.BackColor = System.Drawing.Color.White
        Me.Logo_empresa.Image = CType(resources.GetObject("Logo_empresa.Image"), System.Drawing.Image)
        Me.Logo_empresa.Location = New System.Drawing.Point(628, 36)
        Me.Logo_empresa.Name = "Logo_empresa"
        Me.Logo_empresa.Size = New System.Drawing.Size(63, 54)
        Me.Logo_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_empresa.TabIndex = 604
        Me.Logo_empresa.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(62, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 1)
        Me.Panel2.TabIndex = 602
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(63, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 28)
        Me.Button3.TabIndex = 600
        Me.Button3.Text = "Generar Conexion Web"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(296, 415)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 28)
        Me.Button5.TabIndex = 601
        Me.Button5.Text = "Mostrar Conexion Web"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtCnStringWEB
        '
        Me.txtCnStringWEB.BackColor = System.Drawing.Color.White
        Me.txtCnStringWEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCnStringWEB.Location = New System.Drawing.Point(63, 327)
        Me.txtCnStringWEB.Multiline = True
        Me.txtCnStringWEB.Name = "txtCnStringWEB"
        Me.txtCnStringWEB.Size = New System.Drawing.Size(629, 82)
        Me.txtCnStringWEB.TabIndex = 591
        '
        'txtCnString
        '
        Me.txtCnString.BackColor = System.Drawing.Color.White
        Me.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCnString.Location = New System.Drawing.Point(59, 142)
        Me.txtCnString.Multiline = True
        Me.txtCnString.Name = "txtCnString"
        Me.txtCnString.Size = New System.Drawing.Size(629, 38)
        Me.txtCnString.TabIndex = 592
        Me.ToolTip1.SetToolTip(Me.txtCnString, "ConnectionString")
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(722, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 25)
        Me.Button2.TabIndex = 599
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(60, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(375, 19)
        Me.Label5.TabIndex = 593
        Me.Label5.Text = "Ingrese la cadena de conexion WEB"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(60, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 19)
        Me.Label3.TabIndex = 594
        Me.Label3.Text = "Ingrese la cadena de conexion LOCAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(41, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 597
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servidor"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ImageKey = "cross.png"
        Me.btnReset.Location = New System.Drawing.Point(-48, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(375, 28)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(19, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(10, 10)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'txtdatasource
        '
        Me.txtdatasource.Location = New System.Drawing.Point(112, 65)
        Me.txtdatasource.Name = "txtdatasource"
        Me.txtdatasource.Size = New System.Drawing.Size(360, 20)
        Me.txtdatasource.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(582, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Obtener Cn"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(57, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(449, 40)
        Me.Label4.TabIndex = 595
        Me.Label4.Text = "Una vez que estes listo dale a ""Generar cadena de conexion"", se creara un Archivo" &
    " que contendra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" &
    "ibles hackers"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageKey = "disk.png"
        Me.btnSave.Location = New System.Drawing.Point(63, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(222, 28)
        Me.btnSave.TabIndex = 598
        Me.btnSave.Text = "Generar cadena de conexion"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(57, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 40)
        Me.Label2.TabIndex = 596
        Me.Label2.Text = "Una vez que estes listo dale a ""Generar cadena de conexion"", se creara un Archivo" &
    " que contendra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" &
    "ibles hackers"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datalistado_movimientos_validar
        '
        Me.datalistado_movimientos_validar.AllowUserToAddRows = False
        Me.datalistado_movimientos_validar.AllowUserToDeleteRows = False
        Me.datalistado_movimientos_validar.AllowUserToResizeRows = False
        Me.datalistado_movimientos_validar.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_movimientos_validar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_movimientos_validar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_movimientos_validar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_movimientos_validar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_movimientos_validar.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_movimientos_validar.Location = New System.Drawing.Point(318, 51)
        Me.datalistado_movimientos_validar.Name = "datalistado_movimientos_validar"
        Me.datalistado_movimientos_validar.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_movimientos_validar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_movimientos_validar.RowHeadersVisible = False
        Me.datalistado_movimientos_validar.RowHeadersWidth = 5
        Me.datalistado_movimientos_validar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado_movimientos_validar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_movimientos_validar.Size = New System.Drawing.Size(88, 44)
        Me.datalistado_movimientos_validar.TabIndex = 605
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'Timer1
        '
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageKey = "disk.png"
        Me.Button6.Location = New System.Drawing.Point(437, 193)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 28)
        Me.Button6.TabIndex = 624
        Me.Button6.Text = "Sugerencia"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageKey = "disk.png"
        Me.Button4.Location = New System.Drawing.Point(292, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 28)
        Me.Button4.TabIndex = 623
        Me.Button4.Text = "Cargar Conexión"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TxtNameConeccion
        '
        Me.TxtNameConeccion.Location = New System.Drawing.Point(512, 48)
        Me.TxtNameConeccion.Name = "TxtNameConeccion"
        Me.TxtNameConeccion.Size = New System.Drawing.Size(100, 20)
        Me.TxtNameConeccion.TabIndex = 625
        Me.TxtNameConeccion.Visible = False
        '
        'TxtServidor
        '
        Me.TxtServidor.Location = New System.Drawing.Point(59, 95)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.Size = New System.Drawing.Size(308, 20)
        Me.TxtServidor.TabIndex = 626
        Me.ToolTip1.SetToolTip(Me.TxtServidor, "Data Source: ""Server Name"";")
        '
        'TxtBaseDeDatos
        '
        Me.TxtBaseDeDatos.Location = New System.Drawing.Point(383, 95)
        Me.TxtBaseDeDatos.Name = "TxtBaseDeDatos"
        Me.TxtBaseDeDatos.Size = New System.Drawing.Size(304, 20)
        Me.TxtBaseDeDatos.TabIndex = 627
        Me.ToolTip1.SetToolTip(Me.TxtBaseDeDatos, "Initial Catalog:""Data Base Name"";")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(59, 119)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(308, 20)
        Me.TxtPassword.TabIndex = 628
        Me.ToolTip1.SetToolTip(Me.TxtPassword, "Data Source: ""Server Name"";")
        '
        'conexion_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 235)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtBaseDeDatos)
        Me.Controls.Add(Me.TxtServidor)
        Me.Controls.Add(Me.TxtNameConeccion)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Logo_empresa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtCnStringWEB)
        Me.Controls.Add(Me.txtCnString)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdatasource)
        Me.Controls.Add(Me.datalistado_movimientos_validar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "conexion_manual"
        Me.Text = "conexion_manual"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalistado_movimientos_validar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logo_empresa As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtCnStringWEB As TextBox
    Friend WithEvents txtCnString As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtdatasource As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Public WithEvents datalistado_movimientos_validar As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TxtNameConeccion As TextBox
    Friend WithEvents TxtServidor As TextBox
    Friend WithEvents TxtBaseDeDatos As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TxtPassword As TextBox
End Class
