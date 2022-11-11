<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdd_Semestre_y_Final
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdd_Semestre_y_Final))
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCalcularRendimiento = New System.Windows.Forms.Button()
        Me.CmbModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.CmbCorte = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LblCentro = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtRendimiento = New System.Windows.Forms.DataGridView()
        Me.UI_TabControl1 = New UIDC.UI_TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblErrores = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.LblRegistros = New System.Windows.Forms.Label()
        Me.BtnCargarNotas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DtNotas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardarNotas = New System.Windows.Forms.Button()
        Me.BtnCancelarMatricula = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DtRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataListado
        '
        Me.DataListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListado.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(12, 109)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.Size = New System.Drawing.Size(932, 146)
        Me.DataListado.TabIndex = 39
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbltitulo)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(15, 30, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(984, 85)
        Me.FlowLayoutPanel1.TabIndex = 37
        '
        'Lbltitulo
        '
        Me.Lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Roboto Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbltitulo.Location = New System.Drawing.Point(18, 30)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(383, 33)
        Me.Lbltitulo.TabIndex = 34
        Me.Lbltitulo.Text = ".:  Inserción de notas por lote  :."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnCalcularRendimiento)
        Me.Panel1.Controls.Add(Me.CmbModalidad)
        Me.Panel1.Controls.Add(Me.CmbGrado)
        Me.Panel1.Controls.Add(Me.CmbCorte)
        Me.Panel1.Controls.Add(Me.TxtAño)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.DataListado)
        Me.Panel1.Controls.Add(Me.LblCentro)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 264)
        Me.Panel1.TabIndex = 38
        '
        'BtnCalcularRendimiento
        '
        Me.BtnCalcularRendimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCalcularRendimiento.FlatAppearance.BorderSize = 0
        Me.BtnCalcularRendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcularRendimiento.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcularRendimiento.ForeColor = System.Drawing.Color.White
        Me.BtnCalcularRendimiento.Image = CType(resources.GetObject("BtnCalcularRendimiento.Image"), System.Drawing.Image)
        Me.BtnCalcularRendimiento.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCalcularRendimiento.Location = New System.Drawing.Point(804, 13)
        Me.BtnCalcularRendimiento.Name = "BtnCalcularRendimiento"
        Me.BtnCalcularRendimiento.Size = New System.Drawing.Size(140, 42)
        Me.BtnCalcularRendimiento.TabIndex = 54
        Me.BtnCalcularRendimiento.Text = "Calcular"
        Me.BtnCalcularRendimiento.UseVisualStyleBackColor = True
        '
        'CmbModalidad
        '
        Me.CmbModalidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbModalidad.FormattingEnabled = True
        Me.CmbModalidad.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL", "PREESCOLAR COMUNITARIO", "PREESCOLAR COMUNITARIO MULTINIVEL", "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA MULTIGRADO", "SECUNDARIA REGULAR", "SECUNDARIA DIURNA", "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidad.Location = New System.Drawing.Point(358, 68)
        Me.CmbModalidad.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbModalidad.Name = "CmbModalidad"
        Me.CmbModalidad.Size = New System.Drawing.Size(244, 28)
        Me.CmbModalidad.TabIndex = 64
        Me.CmbModalidad.Text = "PRIMARIA REGULAR"
        Me.CmbModalidad.Visible = False
        '
        'CmbGrado
        '
        Me.CmbGrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbGrado.FormattingEnabled = True
        Me.CmbGrado.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGrado.Location = New System.Drawing.Point(608, 68)
        Me.CmbGrado.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbGrado.Name = "CmbGrado"
        Me.CmbGrado.Size = New System.Drawing.Size(122, 28)
        Me.CmbGrado.TabIndex = 63
        Me.CmbGrado.Text = "Primero"
        '
        'CmbCorte
        '
        Me.CmbCorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCorte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbCorte.FormattingEnabled = True
        Me.CmbCorte.Location = New System.Drawing.Point(736, 68)
        Me.CmbCorte.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbCorte.Name = "CmbCorte"
        Me.CmbCorte.Size = New System.Drawing.Size(122, 28)
        Me.CmbCorte.TabIndex = 66
        '
        'TxtAño
        '
        Me.TxtAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAño.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtAño.Location = New System.Drawing.Point(864, 68)
        Me.TxtAño.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TxtAño.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.TxtAño.Minimum = New Decimal(New Integer() {2021, 0, 0, 0})
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(80, 26)
        Me.TxtAño.TabIndex = 65
        Me.TxtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAño.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(4, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'LblCentro
        '
        Me.LblCentro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCentro.AutoSize = True
        Me.LblCentro.BackColor = System.Drawing.SystemColors.Control
        Me.LblCentro.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCentro.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LblCentro.Location = New System.Drawing.Point(66, 33)
        Me.LblCentro.Name = "LblCentro"
        Me.LblCentro.Size = New System.Drawing.Size(156, 23)
        Me.LblCentro.TabIndex = 55
        Me.LblCentro.Text = "Centro Educativo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(806, 451)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(144, 44)
        Me.BtnGuardar.TabIndex = 52
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.DtRendimiento)
        Me.Panel2.Location = New System.Drawing.Point(6, 279)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 153)
        Me.Panel2.TabIndex = 53
        '
        'DtRendimiento
        '
        Me.DtRendimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtRendimiento.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DtRendimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtRendimiento.Location = New System.Drawing.Point(12, 12)
        Me.DtRendimiento.Name = "DtRendimiento"
        Me.DtRendimiento.Size = New System.Drawing.Size(932, 133)
        Me.DtRendimiento.TabIndex = 39
        '
        'UI_TabControl1
        '
        Me.UI_TabControl1.ActiveColour = System.Drawing.Color.DodgerBlue
        Me.UI_TabControl1.BackTabColour = System.Drawing.Color.White
        Me.UI_TabControl1.BaseColour = System.Drawing.Color.White
        Me.UI_TabControl1.BorderColour = System.Drawing.Color.WhiteSmoke
        Me.UI_TabControl1.BorderSize = 2
        Me.UI_TabControl1.Controls.Add(Me.TabPage1)
        Me.UI_TabControl1.Controls.Add(Me.TabPage2)
        Me.UI_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UI_TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UI_TabControl1.HorizontalLineColour = System.Drawing.Color.DodgerBlue
        Me.UI_TabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.UI_TabControl1.Location = New System.Drawing.Point(0, 85)
        Me.UI_TabControl1.Name = "UI_TabControl1"
        Me.UI_TabControl1.SelectedIndex = 0
        Me.UI_TabControl1.Size = New System.Drawing.Size(984, 560)
        Me.UI_TabControl1.TabIndex = 54
        Me.UI_TabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_TabControl1.UpLineColour = System.Drawing.Color.WhiteSmoke
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.LblErrores)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.BtnGuardarNotas)
        Me.TabPage1.Controls.Add(Me.BtnCancelarMatricula)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 520)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Cortes Evaluativos"
        '
        'LblErrores
        '
        Me.LblErrores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblErrores.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblErrores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblErrores.Location = New System.Drawing.Point(7, 498)
        Me.LblErrores.Name = "LblErrores"
        Me.LblErrores.Size = New System.Drawing.Size(370, 17)
        Me.LblErrores.TabIndex = 64
        Me.LblErrores.Text = "0 Errores"
        Me.LblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblErrores.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.LblEstado)
        Me.Panel3.Controls.Add(Me.btnHelp)
        Me.Panel3.Controls.Add(Me.LblRegistros)
        Me.Panel3.Controls.Add(Me.BtnCargarNotas)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.DtNotas)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(2, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(965, 436)
        Me.Panel3.TabIndex = 39
        '
        'LblEstado
        '
        Me.LblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEstado.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.LightSlateGray
        Me.LblEstado.Location = New System.Drawing.Point(579, 74)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(370, 17)
        Me.LblEstado.TabIndex = 63
        Me.LblEstado.Text = "Insertando Notas..."
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblEstado.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(922, 20)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 42)
        Me.btnHelp.TabIndex = 62
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'LblRegistros
        '
        Me.LblRegistros.AutoSize = True
        Me.LblRegistros.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistros.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblRegistros.Location = New System.Drawing.Point(14, 74)
        Me.LblRegistros.Name = "LblRegistros"
        Me.LblRegistros.Size = New System.Drawing.Size(112, 17)
        Me.LblRegistros.TabIndex = 61
        Me.LblRegistros.Text = "Total Registros 0"
        '
        'BtnCargarNotas
        '
        Me.BtnCargarNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCargarNotas.FlatAppearance.BorderSize = 0
        Me.BtnCargarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargarNotas.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarNotas.ForeColor = System.Drawing.Color.White
        Me.BtnCargarNotas.Image = CType(resources.GetObject("BtnCargarNotas.Image"), System.Drawing.Image)
        Me.BtnCargarNotas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCargarNotas.Location = New System.Drawing.Point(776, 23)
        Me.BtnCargarNotas.Name = "BtnCargarNotas"
        Me.BtnCargarNotas.Size = New System.Drawing.Size(140, 42)
        Me.BtnCargarNotas.TabIndex = 57
        Me.BtnCargarNotas.Text = "Cargar Datos"
        Me.BtnCargarNotas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'DtNotas
        '
        Me.DtNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtNotas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DtNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtNotas.Location = New System.Drawing.Point(12, 94)
        Me.DtNotas.Name = "DtNotas"
        Me.DtNotas.Size = New System.Drawing.Size(936, 333)
        Me.DtNotas.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(66, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 23)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Ingreso de notas Por Lote"
        '
        'BtnGuardarNotas
        '
        Me.BtnGuardarNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarNotas.FlatAppearance.BorderSize = 0
        Me.BtnGuardarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarNotas.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarNotas.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarNotas.Image = CType(resources.GetObject("BtnGuardarNotas.Image"), System.Drawing.Image)
        Me.BtnGuardarNotas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarNotas.Location = New System.Drawing.Point(664, 458)
        Me.BtnGuardarNotas.Name = "BtnGuardarNotas"
        Me.BtnGuardarNotas.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardarNotas.TabIndex = 58
        Me.BtnGuardarNotas.Text = "Guardar"
        Me.BtnGuardarNotas.UseVisualStyleBackColor = True
        '
        'BtnCancelarMatricula
        '
        Me.BtnCancelarMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarMatricula.FlatAppearance.BorderSize = 0
        Me.BtnCancelarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarMatricula.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarMatricula.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelarMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelarMatricula.Location = New System.Drawing.Point(810, 458)
        Me.BtnCancelarMatricula.Name = "BtnCancelarMatricula"
        Me.BtnCancelarMatricula.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelarMatricula.TabIndex = 59
        Me.BtnCancelarMatricula.Text = "Cancelar"
        Me.BtnCancelarMatricula.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 520)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Semestre y Final"
        '
        'FrmAdd_Semestre_y_Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 645)
        Me.Controls.Add(Me.UI_TabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "FrmAdd_Semestre_y_Final"
        Me.Text = "FrmAdd_Semestre_y_Final"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DtRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataListado As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Lbltitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblCentro As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtRendimiento As DataGridView
    Friend WithEvents CmbModalidad As ComboBox
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents CmbCorte As ComboBox
    Friend WithEvents TxtAño As NumericUpDown
    Friend WithEvents BtnCalcularRendimiento As Button
    Friend WithEvents UI_TabControl1 As UIDC.UI_TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DtNotas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCargarNotas As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents LblRegistros As Label
    Friend WithEvents BtnGuardarNotas As Button
    Friend WithEvents BtnCancelarMatricula As Button
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblErrores As Label
End Class
