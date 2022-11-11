<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCortes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCortes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UI_CustomButton1 = New UIDC.UI_CustomButton()
        Me.TxtBusqueda = New UIDC.UI_MaterialTextBox()
        Me.CmbCorte = New System.Windows.Forms.ComboBox()
        Me.OPCorteEvaluativo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarEvaluacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnOpciones = New System.Windows.Forms.Panel()
        Me.CmbModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.CmbSeccion = New System.Windows.Forms.ComboBox()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CmbDocente = New System.Windows.Forms.ComboBox()
        Me.BtnInforme = New UIDC.UI_CustomButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtnInformeNotas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PnAutorizacion = New System.Windows.Forms.Panel()
        Me.TxtPasword = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New UIDC.UI_CustomButton()
        Me.BtnAutorizar = New UIDC.UI_CustomButton()
        Me.txtpass = New UIDC.UI_UserPasswordTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.DtNotas = New System.Windows.Forms.DataGridView()
        Me.OpcionesNotas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarNotasPorLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.LiAsignaturas = New System.Windows.Forms.ListBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TxtNota = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsPrincipal1 = New Ctrl_Estudiantil.DsPrincipal()
        Me.TtMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.CorregirGradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.OPCorteEvaluativo.SuspendLayout()
        Me.PnOpciones.SuspendLayout()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PnAutorizacion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpcionesNotas.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.TxtNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 96)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel6.Location = New System.Drawing.Point(12, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1047, 96)
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1047, 96)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.UI_CustomButton1)
        Me.Panel7.Controls.Add(Me.TxtBusqueda)
        Me.Panel7.Location = New System.Drawing.Point(3, 13)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(303, 42)
        Me.Panel7.TabIndex = 0
        '
        'UI_CustomButton1
        '
        Me.UI_CustomButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_CustomButton1.BackColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.BackgroundColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.ButtonImage = CType(resources.GetObject("UI_CustomButton1.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton1.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton1.ButtonText = ""
        Me.UI_CustomButton1.ClickBackColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.CornerRadius = 5
        Me.UI_CustomButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.UI_CustomButton1.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton1.Location = New System.Drawing.Point(6, 1)
        Me.UI_CustomButton1.Name = "UI_CustomButton1"
        Me.UI_CustomButton1.Size = New System.Drawing.Size(39, 38)
        Me.UI_CustomButton1.TabIndex = 55
        Me.UI_CustomButton1.Text = "UI_CustomButton1"
        Me.UI_CustomButton1.TextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TxtBusqueda.FocusedColor = "#508ef5"
        Me.TxtBusqueda.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtBusqueda.IsEnabled = True
        Me.TxtBusqueda.Location = New System.Drawing.Point(47, 9)
        Me.TxtBusqueda.MaxLength = 32767
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.TxtBusqueda.Size = New System.Drawing.Size(254, 24)
        Me.TxtBusqueda.TabIndex = 54
        Me.TxtBusqueda.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBusqueda.UIFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtBusqueda.UIFontColor = "#999999"
        Me.TxtBusqueda.UIMultiline = False
        Me.TxtBusqueda.UIReadOnly = False
        Me.TxtBusqueda.UseSystemPasswordChar = False
        Me.TxtBusqueda.ValidateMessageText = ""
        Me.TxtBusqueda.ValidateMessageTitle = "Validación"
        Me.TxtBusqueda.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Text
        '
        'CmbCorte
        '
        Me.CmbCorte.ContextMenuStrip = Me.OPCorteEvaluativo
        Me.CmbCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCorte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbCorte.FormattingEnabled = True
        Me.CmbCorte.Location = New System.Drawing.Point(312, 20)
        Me.CmbCorte.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbCorte.Name = "CmbCorte"
        Me.CmbCorte.Size = New System.Drawing.Size(97, 28)
        Me.CmbCorte.TabIndex = 62
        '
        'OPCorteEvaluativo
        '
        Me.OPCorteEvaluativo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem4, Me.InsertarEvaluacionesToolStripMenuItem})
        Me.OPCorteEvaluativo.Name = "OpcionesNotas"
        Me.OPCorteEvaluativo.Size = New System.Drawing.Size(185, 70)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "Actualizar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem4.Text = "Editar Cortes"
        '
        'InsertarEvaluacionesToolStripMenuItem
        '
        Me.InsertarEvaluacionesToolStripMenuItem.Name = "InsertarEvaluacionesToolStripMenuItem"
        Me.InsertarEvaluacionesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.InsertarEvaluacionesToolStripMenuItem.Text = "Insertar Evaluaciones"
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
        Me.CmbGrado.Location = New System.Drawing.Point(327, 7)
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
        Me.CmbTurno.Location = New System.Drawing.Point(223, 7)
        Me.CmbTurno.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(97, 28)
        Me.CmbTurno.TabIndex = 62
        Me.CmbTurno.Text = "Matutino"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 48)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.CmbDocente)
        Me.Panel5.Controls.Add(Me.BtnInforme)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.BtnInformeNotas)
        Me.Panel5.Location = New System.Drawing.Point(12, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1022, 48)
        Me.Panel5.TabIndex = 3
        '
        'CmbDocente
        '
        Me.CmbDocente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDocente.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbDocente.FormattingEnabled = True
        Me.CmbDocente.Location = New System.Drawing.Point(357, 14)
        Me.CmbDocente.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbDocente.Name = "CmbDocente"
        Me.CmbDocente.Size = New System.Drawing.Size(474, 28)
        Me.CmbDocente.TabIndex = 60
        '
        'BtnInforme
        '
        Me.BtnInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnInforme.BackgroundColor = System.Drawing.Color.Transparent
        Me.BtnInforme.ButtonImage = Global.Ctrl_Estudiantil.My.Resources.Resources.business_report
        Me.BtnInforme.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnInforme.ButtonText = "Informe de Notas"
        Me.BtnInforme.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BtnInforme.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnInforme.CornerRadius = 5
        Me.BtnInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInforme.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnInforme.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnInforme.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnInforme.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnInforme.Location = New System.Drawing.Point(830, 4)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Size = New System.Drawing.Size(189, 38)
        Me.BtnInforme.TabIndex = 13
        Me.BtnInforme.Text = "UI_CustomButton1"
        Me.BtnInforme.TextColor = System.Drawing.Color.DodgerBlue
        Me.BtnInforme.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.LblTotal)
        Me.Panel8.Location = New System.Drawing.Point(3, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(343, 30)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 24)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(180, 2)
        Me.Panel9.TabIndex = 1
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblTotal.Location = New System.Drawing.Point(3, 4)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(162, 17)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "0 registros encontrados."
        '
        'BtnInformeNotas
        '
        Me.BtnInformeNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInformeNotas.FlatAppearance.BorderSize = 0
        Me.BtnInformeNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformeNotas.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInformeNotas.ForeColor = System.Drawing.Color.White
        Me.BtnInformeNotas.Image = CType(resources.GetObject("BtnInformeNotas.Image"), System.Drawing.Image)
        Me.BtnInformeNotas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnInformeNotas.Location = New System.Drawing.Point(584, 4)
        Me.BtnInformeNotas.Name = "BtnInformeNotas"
        Me.BtnInformeNotas.Size = New System.Drawing.Size(177, 42)
        Me.BtnInformeNotas.TabIndex = 10
        Me.BtnInformeNotas.Text = "Informe de Notas"
        Me.BtnInformeNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInformeNotas.UseVisualStyleBackColor = True
        Me.BtnInformeNotas.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 605)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PnAutorizacion)
        Me.Panel4.Controls.Add(Me.Datalistado)
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel4.Location = New System.Drawing.Point(12, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1022, 535)
        Me.Panel4.TabIndex = 2
        '
        'PnAutorizacion
        '
        Me.PnAutorizacion.Controls.Add(Me.TxtPasword)
        Me.PnAutorizacion.Controls.Add(Me.BtnCancelar)
        Me.PnAutorizacion.Controls.Add(Me.BtnAutorizar)
        Me.PnAutorizacion.Controls.Add(Me.txtpass)
        Me.PnAutorizacion.Controls.Add(Me.Label3)
        Me.PnAutorizacion.Controls.Add(Me.PictureBox2)
        Me.PnAutorizacion.Location = New System.Drawing.Point(258, 32)
        Me.PnAutorizacion.Name = "PnAutorizacion"
        Me.PnAutorizacion.Size = New System.Drawing.Size(524, 260)
        Me.PnAutorizacion.TabIndex = 5
        Me.PnAutorizacion.Visible = False
        '
        'TxtPasword
        '
        Me.TxtPasword.BackColor = System.Drawing.Color.Silver
        Me.TxtPasword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPasword.Location = New System.Drawing.Point(157, 98)
        Me.TxtPasword.Name = "TxtPasword"
        Me.TxtPasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasword.Size = New System.Drawing.Size(226, 28)
        Me.TxtPasword.TabIndex = 10
        Me.TxtPasword.UseSystemPasswordChar = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Blue
        Me.BtnCancelar.BackgroundColor = System.Drawing.Color.Crimson
        Me.BtnCancelar.ButtonImage = Nothing
        Me.BtnCancelar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnCancelar.ButtonText = "Cancelar"
        Me.BtnCancelar.ClickBackColor = System.Drawing.Color.Crimson
        Me.BtnCancelar.ClickTextColor = System.Drawing.Color.Azure
        Me.BtnCancelar.CornerRadius = 10
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnCancelar.HoverBackgroundColor = System.Drawing.Color.Red
        Me.BtnCancelar.HoverTextColor = System.Drawing.Color.Wheat
        Me.BtnCancelar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnCancelar.Location = New System.Drawing.Point(159, 205)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 41)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.TextColor = System.Drawing.Color.White
        Me.BtnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'BtnAutorizar
        '
        Me.BtnAutorizar.BackColor = System.Drawing.Color.Blue
        Me.BtnAutorizar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAutorizar.ButtonImage = Nothing
        Me.BtnAutorizar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnAutorizar.ButtonText = "Autorizar"
        Me.BtnAutorizar.ClickBackColor = System.Drawing.Color.DarkBlue
        Me.BtnAutorizar.ClickTextColor = System.Drawing.Color.Azure
        Me.BtnAutorizar.CornerRadius = 10
        Me.BtnAutorizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAutorizar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnAutorizar.HoverBackgroundColor = System.Drawing.Color.MediumBlue
        Me.BtnAutorizar.HoverTextColor = System.Drawing.Color.White
        Me.BtnAutorizar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnAutorizar.Location = New System.Drawing.Point(261, 205)
        Me.BtnAutorizar.Name = "BtnAutorizar"
        Me.BtnAutorizar.Size = New System.Drawing.Size(99, 41)
        Me.BtnAutorizar.TabIndex = 8
        Me.BtnAutorizar.Text = "Iniciar..."
        Me.BtnAutorizar.TextColor = System.Drawing.Color.White
        Me.BtnAutorizar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.BackgroundColour = System.Drawing.Color.Silver
        Me.txtpass.Borde = False
        Me.txtpass.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtpass.BorderSize = 3
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.DimGray
        Me.txtpass.Location = New System.Drawing.Point(131, 95)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Radio = 12
        Me.txtpass.Size = New System.Drawing.Size(262, 33)
        Me.txtpass.TabIndex = 6
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpass.UseSystemPasswordChar = True
        Me.txtpass.VisualImage = UIDC.UI_UserPasswordTextBox.Visual.Black
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(75, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 92)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Autorización de Eliminación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(524, 260)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AllowUserToOrderColumns = True
        Me.Datalistado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Datalistado.Location = New System.Drawing.Point(18, 18)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.Size = New System.Drawing.Size(970, 152)
        Me.Datalistado.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "OpcionesNotas"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem1.Text = "Actualizar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem3.Text = "Mostrar Notas"
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Location = New System.Drawing.Point(18, 184)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(970, 53)
        Me.Panel12.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(413, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Asignaturas:"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel14)
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel16)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(71, 244)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(863, 270)
        Me.FlowLayoutPanel4.TabIndex = 4
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
        Me.DtNotas.ContextMenuStrip = Me.OpcionesNotas
        Me.DtNotas.Location = New System.Drawing.Point(-1, 3)
        Me.DtNotas.Name = "DtNotas"
        Me.DtNotas.ReadOnly = True
        Me.DtNotas.Size = New System.Drawing.Size(318, 250)
        Me.DtNotas.TabIndex = 2
        '
        'OpcionesNotas
        '
        Me.OpcionesNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.MostrarNotasToolStripMenuItem, Me.InsertarNotasPorLoteToolStripMenuItem, Me.CorregirGradoToolStripMenuItem})
        Me.OpcionesNotas.Name = "OpcionesNotas"
        Me.OpcionesNotas.Size = New System.Drawing.Size(195, 136)
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'MostrarNotasToolStripMenuItem
        '
        Me.MostrarNotasToolStripMenuItem.Name = "MostrarNotasToolStripMenuItem"
        Me.MostrarNotasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MostrarNotasToolStripMenuItem.Text = "Mostrar Notas"
        '
        'InsertarNotasPorLoteToolStripMenuItem
        '
        Me.InsertarNotasPorLoteToolStripMenuItem.Name = "InsertarNotasPorLoteToolStripMenuItem"
        Me.InsertarNotasPorLoteToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.InsertarNotasPorLoteToolStripMenuItem.Text = "Insertar Notas por Lote"
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
        'DsPrincipal1
        '
        Me.DsPrincipal1.DataSetName = "DsPrincipal"
        Me.DsPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TtMensaje
        '
        Me.TtMensaje.IsBalloon = True
        Me.TtMensaje.ShowAlways = True
        Me.TtMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtMensaje.ToolTipTitle = "Seleccione el docente por favor"
        '
        'CorregirGradoToolStripMenuItem
        '
        Me.CorregirGradoToolStripMenuItem.Name = "CorregirGradoToolStripMenuItem"
        Me.CorregirGradoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CorregirGradoToolStripMenuItem.Text = "Corregir Grado"
        '
        'FrmCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCortes"
        Me.Text = "Cortes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.OPCorteEvaluativo.ResumeLayout(False)
        Me.PnOpciones.ResumeLayout(False)
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PnAutorizacion.ResumeLayout(False)
        Me.PnAutorizacion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.DtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpcionesNotas.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.TxtNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CmbModalidad As ComboBox
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents TxtAño As NumericUpDown
    Friend WithEvents CmbCorte As ComboBox
    Friend WithEvents DtNotas As DataGridView
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TxtNota As NumericUpDown
    Friend WithEvents LiAsignaturas As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OpcionesNotas As ContextMenuStrip
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnInformeNotas As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents MostrarNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents OPCorteEvaluativo As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents InsertarEvaluacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents DsPrincipal1 As DsPrincipal
    Friend WithEvents PnOpciones As Panel
    Friend WithEvents CmbSeccion As ComboBox
    Friend WithEvents BtnInforme As UIDC.UI_CustomButton
    Friend WithEvents UI_CustomButton1 As UIDC.UI_CustomButton
    Friend WithEvents TxtBusqueda As UIDC.UI_MaterialTextBox
    Friend WithEvents PnAutorizacion As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnAutorizar As UIDC.UI_CustomButton
    Friend WithEvents txtpass As UIDC.UI_UserPasswordTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancelar As UIDC.UI_CustomButton
    Friend WithEvents TxtPasword As TextBox
    Friend WithEvents CmbDocente As ComboBox
    Friend WithEvents TtMensaje As ToolTip
    Friend WithEvents InsertarNotasPorLoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorregirGradoToolStripMenuItem As ToolStripMenuItem
End Class
