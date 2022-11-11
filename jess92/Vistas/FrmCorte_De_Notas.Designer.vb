<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorte_De_Notas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorte_De_Notas))
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmbCorte = New System.Windows.Forms.ComboBox()
        Me.PnOpciones = New System.Windows.Forms.Panel()
        Me.CmbModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.CmbSeccion = New System.Windows.Forms.ComboBox()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.NumericUpDown()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.DtNotas = New System.Windows.Forms.DataGridView()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.LiAsignaturas = New System.Windows.Forms.ListBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TxtNota = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnOpciones.SuspendLayout()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.TxtNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListado
        '
        Me.DataListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(30, 80)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.Size = New System.Drawing.Size(1004, 200)
        Me.DataListado.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 74)
        Me.Panel1.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel6.Location = New System.Drawing.Point(30, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1018, 74)
        Me.Panel6.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.CmbCorte)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnOpciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.TxtAño)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1018, 74)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TxtBusqueda)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Location = New System.Drawing.Point(3, 13)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(303, 42)
        Me.Panel7.TabIndex = 0
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.ForeColor = System.Drawing.Color.Black
        Me.TxtBusqueda.HideSelection = False
        Me.TxtBusqueda.Location = New System.Drawing.Point(38, 7)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(245, 23)
        Me.TxtBusqueda.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CmbCorte
        '
        Me.CmbCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCorte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbCorte.FormattingEnabled = True
        Me.CmbCorte.Location = New System.Drawing.Point(312, 20)
        Me.CmbCorte.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbCorte.Name = "CmbCorte"
        Me.CmbCorte.Size = New System.Drawing.Size(97, 28)
        Me.CmbCorte.TabIndex = 62
        '
        'PnOpciones
        '
        Me.PnOpciones.Controls.Add(Me.CmbModalidad)
        Me.PnOpciones.Controls.Add(Me.CmbGrado)
        Me.PnOpciones.Controls.Add(Me.CmbSeccion)
        Me.PnOpciones.Controls.Add(Me.CmbTurno)
        Me.PnOpciones.Location = New System.Drawing.Point(415, 13)
        Me.PnOpciones.Name = "PnOpciones"
        Me.PnOpciones.Size = New System.Drawing.Size(503, 42)
        Me.PnOpciones.TabIndex = 63
        '
        'CmbModalidad
        '
        Me.CmbModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbModalidad.FormattingEnabled = True
        Me.CmbModalidad.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA MULTIGRADO" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA DIURNA" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidad.Location = New System.Drawing.Point(3, 7)
        Me.CmbModalidad.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbModalidad.Name = "CmbModalidad"
        Me.CmbModalidad.Size = New System.Drawing.Size(214, 28)
        Me.CmbModalidad.TabIndex = 59
        Me.CmbModalidad.Text = "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'CmbGrado
        '
        Me.CmbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbGrado.FormattingEnabled = True
        Me.CmbGrado.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGrado.Location = New System.Drawing.Point(224, 7)
        Me.CmbGrado.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbGrado.Name = "CmbGrado"
        Me.CmbGrado.Size = New System.Drawing.Size(122, 28)
        Me.CmbGrado.TabIndex = 58
        Me.CmbGrado.Text = "Primero"
        '
        'CmbSeccion
        '
        Me.CmbSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeccion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbSeccion.FormattingEnabled = True
        Me.CmbSeccion.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.CmbSeccion.Location = New System.Drawing.Point(455, 7)
        Me.CmbSeccion.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbSeccion.Name = "CmbSeccion"
        Me.CmbSeccion.Size = New System.Drawing.Size(43, 28)
        Me.CmbSeccion.TabIndex = 62
        Me.CmbSeccion.Text = "A"
        '
        'CmbTurno
        '
        Me.CmbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.CmbTurno.Location = New System.Drawing.Point(352, 7)
        Me.CmbTurno.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(97, 28)
        Me.CmbTurno.TabIndex = 62
        Me.CmbTurno.Text = "Vespertino"
        '
        'TxtAño
        '
        Me.TxtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAño.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtAño.Location = New System.Drawing.Point(924, 20)
        Me.TxtAño.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TxtAño.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.TxtAño.Minimum = New Decimal(New Integer() {2021, 0, 0, 0})
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(80, 26)
        Me.TxtAño.TabIndex = 61
        Me.TxtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAño.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Location = New System.Drawing.Point(30, 269)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1004, 54)
        Me.Panel12.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(430, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Asignaturas:"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel14)
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel16)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(30, 331)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1004, 288)
        Me.FlowLayoutPanel4.TabIndex = 6
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.DtNotas)
        Me.Panel14.Location = New System.Drawing.Point(15, 3)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(320, 256)
        Me.Panel14.TabIndex = 0
        '
        'DtNotas
        '
        Me.DtNotas.AllowUserToAddRows = False
        Me.DtNotas.AllowUserToDeleteRows = False
        Me.DtNotas.AllowUserToOrderColumns = True
        Me.DtNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DtNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtNotas.Location = New System.Drawing.Point(-1, 3)
        Me.DtNotas.Name = "DtNotas"
        Me.DtNotas.ReadOnly = True
        Me.DtNotas.Size = New System.Drawing.Size(318, 250)
        Me.DtNotas.TabIndex = 2
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.LiAsignaturas)
        Me.Panel15.Location = New System.Drawing.Point(353, 3)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(226, 253)
        Me.Panel15.TabIndex = 1
        '
        'LiAsignaturas
        '
        Me.LiAsignaturas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LiAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LiAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiAsignaturas.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiAsignaturas.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.LiAsignaturas.FormattingEnabled = True
        Me.LiAsignaturas.ItemHeight = 23
        Me.LiAsignaturas.Location = New System.Drawing.Point(0, 0)
        Me.LiAsignaturas.Name = "LiAsignaturas"
        Me.LiAsignaturas.Size = New System.Drawing.Size(226, 253)
        Me.LiAsignaturas.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnGuardar)
        Me.Panel16.Controls.Add(Me.Panel13)
        Me.Panel16.Controls.Add(Me.TxtNota)
        Me.Panel16.Controls.Add(Me.Label1)
        Me.Panel16.Location = New System.Drawing.Point(597, 3)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(248, 253)
        Me.Panel16.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(65, 185)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(35, 64)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(200, 2)
        Me.Panel13.TabIndex = 64
        '
        'TxtNota
        '
        Me.TxtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtNota.Location = New System.Drawing.Point(51, 100)
        Me.TxtNota.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(177, 32)
        Me.TxtNota.TabIndex = 62
        Me.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(101, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Nota:"
        '
        'FrmCorte_De_Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 634)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataListado)
        Me.Name = "FrmCorte_De_Notas"
        Me.Text = "FrmCorte_De_Notas"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnOpciones.ResumeLayout(False)
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.TxtNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmbCorte As ComboBox
    Friend WithEvents PnOpciones As Panel
    Friend WithEvents CmbModalidad As ComboBox
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents CmbSeccion As ComboBox
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents TxtAño As NumericUpDown
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents DtNotas As DataGridView
    Friend WithEvents Panel15 As Panel
    Friend WithEvents LiAsignaturas As ListBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TxtNota As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
