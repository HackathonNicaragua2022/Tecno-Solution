<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlumnos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTituloEdicion = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtCodigoMined = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdAlumno = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnLote = New System.Windows.Forms.Panel()
        Me.LblTotallote = New System.Windows.Forms.Label()
        Me.ChkMatricular = New System.Windows.Forms.CheckBox()
        Me.DtDatos = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChkLote = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Opciones1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MatricularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatricularToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TTMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.TxtBusquedaApellidos = New System.Windows.Forms.TextBox()
        Me.CmbGrado_Buscar_Listado = New System.Windows.Forms.ComboBox()
        Me.CmbModalidad_Buscar_Listado = New System.Windows.Forms.ComboBox()
        Me.CmbEGrado = New System.Windows.Forms.ComboBox()
        Me.CmbEModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbECorte = New System.Windows.Forms.ComboBox()
        Me.CmbETurno = New System.Windows.Forms.ComboBox()
        Me.CmbESeccion = New System.Windows.Forms.ComboBox()
        Me.BtnExportar = New UIDC.UI_CustomButton()
        Me.BtnFiltrar = New UIDC.UI_CustomButton()
        Me.BtnCorregirMatricula = New System.Windows.Forms.Button()
        Me.BtnBuscarMatriculaTransicion = New UIDC.UI_CustomButton()
        Me.CmbTurnoTransisionM = New System.Windows.Forms.ComboBox()
        Me.CmbSeccionTransisionM = New System.Windows.Forms.ComboBox()
        Me.CmbTurno_Buscar_Listado = New System.Windows.Forms.ComboBox()
        Me.CmbSeccion_Buscar_Listado = New System.Windows.Forms.ComboBox()
        Me.UI_CustomButton1 = New UIDC.UI_CustomButton()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.EpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnMatricula = New System.Windows.Forms.FlowLayoutPanel()
        Me.pntitulo = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.ChkLotesMatricula = New System.Windows.Forms.CheckBox()
        Me.BtnNuevaMatricula = New System.Windows.Forms.Button()
        Me.PnMatriculaNormal = New System.Windows.Forms.Panel()
        Me.CmbSeccion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbGrado_Matricular = New System.Windows.Forms.ComboBox()
        Me.CmbModalidadMatricular = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LblTituloMatricula = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtIdAlumnoMatricula = New System.Windows.Forms.TextBox()
        Me.PnMatricula_Lotes = New System.Windows.Forms.Panel()
        Me.ChkRegistrar = New System.Windows.Forms.CheckBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.PictureBox()
        Me.LblRegistros = New System.Windows.Forms.Label()
        Me.DtListadoMatricula_Lotes = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCargarMatriculaLotes = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnCancelarMatricula = New System.Windows.Forms.Button()
        Me.BtnGuardarMatricula = New System.Windows.Forms.Button()
        Me.BtnEditarMatricula = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnMejorAlumno = New System.Windows.Forms.Panel()
        Me.lblcontador = New System.Windows.Forms.Label()
        Me.DtExcelenciaAcademica = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Opcion = New System.Windows.Forms.ComboBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Anio = New UIDC.UI_Numeric()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnMatricularSeleccion = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtAñoMatricula = New UIDC.UI_Numeric()
        Me.CmbSn = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CmbTn = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CmbGd = New System.Windows.Forms.ComboBox()
        Me.CmbMd = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DtMatricula = New System.Windows.Forms.DataGridView()
        Me.OpciondeMatricula = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarMatrículaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspenderMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnM_Inicial = New UIDC.UI_CustomButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PnOpcionesMatricula = New System.Windows.Forms.Panel()
        Me.TxtAñoMatricular = New UIDC.UI_MaterialTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CmbSeccionDestino = New System.Windows.Forms.ComboBox()
        Me.CmbGradoDestino = New System.Windows.Forms.ComboBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbTurnoDestino = New System.Windows.Forms.ComboBox()
        Me.CmbModalidadDestino = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LblBuscar_Al_Cambiar = New System.Windows.Forms.Label()
        Me.ChkBuscar_Al_Cambio = New UIDC.UI_MaterialToggle()
        Me.Chkmarcartodos = New System.Windows.Forms.CheckBox()
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.cmbModalidad = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New UIDC.UI_Numeric()
        Me.DtMatriculaAnterior = New System.Windows.Forms.DataGridView()
        Me.ChkMarcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnMatricular = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TxtAño_Buscar_Listado = New UIDC.UI_Numeric()
        Me.DtListado_Estudiantes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LblTotalListadoEstudiantes = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnLote.SuspendLayout()
        CType(Me.DtDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Opciones1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PnMatricula.SuspendLayout()
        Me.pntitulo.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.PnMatriculaNormal.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnMatricula_Lotes.SuspendLayout()
        CType(Me.Load, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtListadoMatricula_Lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnMejorAlumno.SuspendLayout()
        CType(Me.DtExcelenciaAcademica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.PnMatricularSeleccion.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpciondeMatricula.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PnOpcionesMatricula.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DtMatriculaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.DtListado_Estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.DtNacimiento)
        Me.Panel1.Controls.Add(Me.CmbSexo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblTituloEdicion)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.TxtCodigoMined)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TxtNombres)
        Me.Panel1.Controls.Add(Me.TxtApellidos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtIdAlumno)
        Me.Panel1.Location = New System.Drawing.Point(28, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 284)
        Me.Panel1.TabIndex = 8
        '
        'DtNacimiento
        '
        Me.DtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtNacimiento.Location = New System.Drawing.Point(511, 231)
        Me.DtNacimiento.Name = "DtNacimiento"
        Me.DtNacimiento.Size = New System.Drawing.Size(200, 25)
        Me.DtNacimiento.TabIndex = 5
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"F", "M"})
        Me.CmbSexo.Location = New System.Drawing.Point(112, 230)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 26)
        Me.CmbSexo.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LblTituloEdicion
        '
        Me.LblTituloEdicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTituloEdicion.AutoSize = True
        Me.LblTituloEdicion.BackColor = System.Drawing.SystemColors.Control
        Me.LblTituloEdicion.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloEdicion.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LblTituloEdicion.Location = New System.Drawing.Point(75, 28)
        Me.LblTituloEdicion.Name = "LblTituloEdicion"
        Me.LblTituloEdicion.Size = New System.Drawing.Size(438, 23)
        Me.LblTituloEdicion.TabIndex = 41
        Me.LblTituloEdicion.Text = "Centro Educativo Francica Hernández Espininoza."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label25.Location = New System.Drawing.Point(24, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(155, 18)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Codigo del Estudiante"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(627, 9)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(140, 42)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtCodigoMined
        '
        Me.TxtCodigoMined.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtCodigoMined.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtCodigoMined.Location = New System.Drawing.Point(205, 123)
        Me.TxtCodigoMined.Name = "TxtCodigoMined"
        Me.TxtCodigoMined.ReadOnly = True
        Me.TxtCodigoMined.Size = New System.Drawing.Size(268, 25)
        Me.TxtCodigoMined.TabIndex = 1
        Me.TTMensaje.SetToolTip(Me.TxtCodigoMined, "Contenido Neto Unitario")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(404, 238)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 18)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Nacimiento:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label23.Location = New System.Drawing.Point(20, 233)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 18)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Sexo:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(398, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 18)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Apellidos:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label21.Location = New System.Drawing.Point(20, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 18)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Nombres:"
        '
        'TxtNombres
        '
        Me.TxtNombres.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNombres.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtNombres.Location = New System.Drawing.Point(101, 193)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.ReadOnly = True
        Me.TxtNombres.Size = New System.Drawing.Size(268, 25)
        Me.TxtNombres.TabIndex = 2
        Me.TTMensaje.SetToolTip(Me.TxtNombres, "Contenido Neto Unitario")
        '
        'TxtApellidos
        '
        Me.TxtApellidos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtApellidos.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtApellidos.Location = New System.Drawing.Point(480, 193)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.ReadOnly = True
        Me.TxtApellidos.Size = New System.Drawing.Size(274, 25)
        Me.TxtApellidos.TabIndex = 3
        Me.TTMensaje.SetToolTip(Me.TxtApellidos, "Stock Máximo")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "id Alumno:"
        '
        'TxtIdAlumno
        '
        Me.TxtIdAlumno.BackColor = System.Drawing.Color.Ivory
        Me.TxtIdAlumno.Enabled = False
        Me.TxtIdAlumno.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtIdAlumno.Location = New System.Drawing.Point(133, 79)
        Me.TxtIdAlumno.Name = "TxtIdAlumno"
        Me.TxtIdAlumno.ReadOnly = True
        Me.TxtIdAlumno.Size = New System.Drawing.Size(134, 25)
        Me.TxtIdAlumno.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1117, 686)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edición"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.PnLote)
        Me.Panel3.Controls.Add(Me.ChkLote)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.BtnEditar)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnGuardar)
        Me.Panel3.Location = New System.Drawing.Point(89, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(834, 771)
        Me.Panel3.TabIndex = 13
        '
        'PnLote
        '
        Me.PnLote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnLote.BackColor = System.Drawing.SystemColors.Control
        Me.PnLote.Controls.Add(Me.LblTotallote)
        Me.PnLote.Controls.Add(Me.ChkMatricular)
        Me.PnLote.Controls.Add(Me.DtDatos)
        Me.PnLote.Controls.Add(Me.PictureBox3)
        Me.PnLote.Controls.Add(Me.Label5)
        Me.PnLote.Controls.Add(Me.Button1)
        Me.PnLote.Location = New System.Drawing.Point(28, 415)
        Me.PnLote.Name = "PnLote"
        Me.PnLote.Size = New System.Drawing.Size(783, 279)
        Me.PnLote.TabIndex = 31
        Me.PnLote.Visible = False
        '
        'LblTotallote
        '
        Me.LblTotallote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotallote.AutoSize = True
        Me.LblTotallote.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotallote.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblTotallote.Location = New System.Drawing.Point(299, 72)
        Me.LblTotallote.Name = "LblTotallote"
        Me.LblTotallote.Size = New System.Drawing.Size(112, 17)
        Me.LblTotallote.TabIndex = 45
        Me.LblTotallote.Text = "Total Registros 0"
        '
        'ChkMatricular
        '
        Me.ChkMatricular.AutoSize = True
        Me.ChkMatricular.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkMatricular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.ChkMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkMatricular.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.ChkMatricular.Location = New System.Drawing.Point(593, 72)
        Me.ChkMatricular.Name = "ChkMatricular"
        Me.ChkMatricular.Size = New System.Drawing.Size(174, 22)
        Me.ChkMatricular.TabIndex = 44
        Me.ChkMatricular.Text = "Matricular Estudiantes"
        Me.ChkMatricular.UseVisualStyleBackColor = True
        '
        'DtDatos
        '
        Me.DtDatos.AllowUserToAddRows = False
        Me.DtDatos.AllowUserToDeleteRows = False
        Me.DtDatos.AllowUserToOrderColumns = True
        Me.DtDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtDatos.Location = New System.Drawing.Point(13, 100)
        Me.DtDatos.Name = "DtDatos"
        Me.DtDatos.ReadOnly = True
        Me.DtDatos.Size = New System.Drawing.Size(754, 160)
        Me.DtDatos.TabIndex = 43
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(75, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(411, 23)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Interfaz de Inscripción de Estudiantes por Lote"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button1.Location = New System.Drawing.Point(627, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cargar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChkLote
        '
        Me.ChkLote.AutoSize = True
        Me.ChkLote.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLote.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ChkLote.Location = New System.Drawing.Point(659, 371)
        Me.ChkLote.Name = "ChkLote"
        Me.ChkLote.Size = New System.Drawing.Size(139, 22)
        Me.ChkLote.TabIndex = 30
        Me.ChkLote.Text = "Ingresar por Lote"
        Me.ChkLote.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(325, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 27)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Datos del Alumnos"
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEditar.Location = New System.Drawing.Point(520, 708)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(140, 42)
        Me.BtnEditar.TabIndex = 11
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(671, 708)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
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
        Me.BtnGuardar.Location = New System.Drawing.Point(370, 708)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Opciones1
        '
        Me.Opciones1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.ToolStripSeparator1, Me.MatricularToolStripMenuItem, Me.NotasToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem, Me.OpcionesDeEstudiantesToolStripMenuItem})
        Me.Opciones1.Name = "Opciones1"
        Me.Opciones1.Size = New System.Drawing.Size(204, 170)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'MatricularToolStripMenuItem
        '
        Me.MatricularToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatricularToolStripMenuItem1, Me.EditarMatriculaToolStripMenuItem})
        Me.MatricularToolStripMenuItem.Name = "MatricularToolStripMenuItem"
        Me.MatricularToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MatricularToolStripMenuItem.Text = "Matricula"
        '
        'MatricularToolStripMenuItem1
        '
        Me.MatricularToolStripMenuItem1.Name = "MatricularToolStripMenuItem1"
        Me.MatricularToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.MatricularToolStripMenuItem1.Text = "Matricular"
        '
        'EditarMatriculaToolStripMenuItem
        '
        Me.EditarMatriculaToolStripMenuItem.Name = "EditarMatriculaToolStripMenuItem"
        Me.EditarMatriculaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EditarMatriculaToolStripMenuItem.Text = "Editar Matricula"
        Me.EditarMatriculaToolStripMenuItem.Visible = False
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NotasToolStripMenuItem.Text = "Notas"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SalirToolStripMenuItem.Text = "Salir."
        '
        'OpcionesDeEstudiantesToolStripMenuItem
        '
        Me.OpcionesDeEstudiantesToolStripMenuItem.Name = "OpcionesDeEstudiantesToolStripMenuItem"
        Me.OpcionesDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.OpcionesDeEstudiantesToolStripMenuItem.Text = "Opciones de estudiantes"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Controls.Add(Me.BtnImprimir)
        Me.Panel4.Controls.Add(Me.BtnEliminar)
        Me.Panel4.Controls.Add(Me.LblTotal)
        Me.Panel4.Controls.Add(Me.chkEliminar)
        Me.Panel4.Location = New System.Drawing.Point(23, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(886, 50)
        Me.Panel4.TabIndex = 9
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimir.Enabled = False
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ForeColor = System.Drawing.Color.White
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(653, 6)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(112, 42)
        Me.BtnImprimir.TabIndex = 8
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = True
        Me.BtnImprimir.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(771, 6)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(104, 42)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.White
        Me.LblTotal.Location = New System.Drawing.Point(321, 22)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(112, 17)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.Text = "Total Registros 0"
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.ForeColor = System.Drawing.Color.White
        Me.chkEliminar.Location = New System.Drawing.Point(17, 17)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(81, 22)
        Me.chkEliminar.TabIndex = 4
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AllowUserToOrderColumns = True
        Me.Datalistado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.Datalistado.ContextMenuStrip = Me.Opciones1
        Me.Datalistado.Location = New System.Drawing.Point(23, 124)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.Size = New System.Drawing.Size(886, 160)
        Me.Datalistado.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'TTMensaje
        '
        Me.TTMensaje.AutoPopDelay = 5000
        Me.TTMensaje.InitialDelay = 500
        Me.TTMensaje.IsBalloon = True
        Me.TTMensaje.ReshowDelay = 2000
        Me.TTMensaje.ShowAlways = True
        '
        'TxtBusquedaNombre
        '
        Me.TxtBusquedaNombre.ForeColor = System.Drawing.Color.Green
        Me.TxtBusquedaNombre.Location = New System.Drawing.Point(109, 17)
        Me.TxtBusquedaNombre.Name = "TxtBusquedaNombre"
        Me.TxtBusquedaNombre.Size = New System.Drawing.Size(170, 25)
        Me.TxtBusquedaNombre.TabIndex = 1
        Me.TTMensaje.SetToolTip(Me.TxtBusquedaNombre, "Nombres de Alumno.")
        '
        'TxtBusquedaApellidos
        '
        Me.TxtBusquedaApellidos.ForeColor = System.Drawing.Color.Green
        Me.TxtBusquedaApellidos.Location = New System.Drawing.Point(285, 17)
        Me.TxtBusquedaApellidos.Name = "TxtBusquedaApellidos"
        Me.TxtBusquedaApellidos.Size = New System.Drawing.Size(170, 25)
        Me.TxtBusquedaApellidos.TabIndex = 10
        Me.TTMensaje.SetToolTip(Me.TxtBusquedaApellidos, "Apellidos del Alumno.")
        '
        'CmbGrado_Buscar_Listado
        '
        Me.CmbGrado_Buscar_Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbGrado_Buscar_Listado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrado_Buscar_Listado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbGrado_Buscar_Listado.FormattingEnabled = True
        Me.CmbGrado_Buscar_Listado.Location = New System.Drawing.Point(551, 16)
        Me.CmbGrado_Buscar_Listado.Name = "CmbGrado_Buscar_Listado"
        Me.CmbGrado_Buscar_Listado.Size = New System.Drawing.Size(125, 27)
        Me.CmbGrado_Buscar_Listado.TabIndex = 12
        Me.TTMensaje.SetToolTip(Me.CmbGrado_Buscar_Listado, "Grado")
        '
        'CmbModalidad_Buscar_Listado
        '
        Me.CmbModalidad_Buscar_Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbModalidad_Buscar_Listado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidad_Buscar_Listado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbModalidad_Buscar_Listado.FormattingEnabled = True
        Me.CmbModalidad_Buscar_Listado.Location = New System.Drawing.Point(243, 16)
        Me.CmbModalidad_Buscar_Listado.Name = "CmbModalidad_Buscar_Listado"
        Me.CmbModalidad_Buscar_Listado.Size = New System.Drawing.Size(171, 27)
        Me.CmbModalidad_Buscar_Listado.TabIndex = 11
        Me.TTMensaje.SetToolTip(Me.CmbModalidad_Buscar_Listado, "Modalidad")
        '
        'CmbEGrado
        '
        Me.CmbEGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbEGrado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEGrado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbEGrado.FormattingEnabled = True
        Me.CmbEGrado.Location = New System.Drawing.Point(548, 75)
        Me.CmbEGrado.Name = "CmbEGrado"
        Me.CmbEGrado.Size = New System.Drawing.Size(170, 27)
        Me.CmbEGrado.TabIndex = 40
        Me.TTMensaje.SetToolTip(Me.CmbEGrado, "Grado")
        '
        'CmbEModalidad
        '
        Me.CmbEModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbEModalidad.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEModalidad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbEModalidad.FormattingEnabled = True
        Me.CmbEModalidad.Location = New System.Drawing.Point(230, 75)
        Me.CmbEModalidad.Name = "CmbEModalidad"
        Me.CmbEModalidad.Size = New System.Drawing.Size(200, 27)
        Me.CmbEModalidad.TabIndex = 39
        Me.TTMensaje.SetToolTip(Me.CmbEModalidad, "Modalidad")
        '
        'CmbECorte
        '
        Me.CmbECorte.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.CmbECorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbECorte.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbECorte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmbECorte.FormattingEnabled = True
        Me.CmbECorte.Items.AddRange(New Object() {""})
        Me.CmbECorte.Location = New System.Drawing.Point(314, 13)
        Me.CmbECorte.Name = "CmbECorte"
        Me.CmbECorte.Size = New System.Drawing.Size(199, 31)
        Me.CmbECorte.TabIndex = 39
        Me.TTMensaje.SetToolTip(Me.CmbECorte, "Seleccione el Corte Evaluativo")
        '
        'CmbETurno
        '
        Me.CmbETurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbETurno.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbETurno.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbETurno.FormattingEnabled = True
        Me.CmbETurno.Location = New System.Drawing.Point(436, 75)
        Me.CmbETurno.Name = "CmbETurno"
        Me.CmbETurno.Size = New System.Drawing.Size(106, 27)
        Me.CmbETurno.TabIndex = 40
        Me.TTMensaje.SetToolTip(Me.CmbETurno, "Turno")
        '
        'CmbESeccion
        '
        Me.CmbESeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbESeccion.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbESeccion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbESeccion.FormattingEnabled = True
        Me.CmbESeccion.Location = New System.Drawing.Point(724, 75)
        Me.CmbESeccion.Name = "CmbESeccion"
        Me.CmbESeccion.Size = New System.Drawing.Size(106, 27)
        Me.CmbESeccion.TabIndex = 40
        Me.TTMensaje.SetToolTip(Me.CmbESeccion, "Seccion")
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.BackgroundColor = System.Drawing.Color.White
        Me.BtnExportar.ButtonImage = CType(resources.GetObject("BtnExportar.ButtonImage"), System.Drawing.Image)
        Me.BtnExportar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnExportar.ButtonText = ""
        Me.BtnExportar.ClickBackColor = System.Drawing.Color.Black
        Me.BtnExportar.ClickTextColor = System.Drawing.Color.Black
        Me.BtnExportar.CornerRadius = 5
        Me.BtnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnExportar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnExportar.HoverBackgroundColor = System.Drawing.Color.Black
        Me.BtnExportar.HoverTextColor = System.Drawing.Color.White
        Me.BtnExportar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnExportar.Location = New System.Drawing.Point(-16, 64)
        Me.BtnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(43, 41)
        Me.BtnExportar.TabIndex = 43
        Me.BtnExportar.Text = "UI_CustomButton1"
        Me.BtnExportar.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTMensaje.SetToolTip(Me.BtnExportar, "Exportar")
        Me.BtnExportar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.BackgroundColor = System.Drawing.Color.Transparent
        Me.BtnFiltrar.ButtonImage = CType(resources.GetObject("BtnFiltrar.ButtonImage"), System.Drawing.Image)
        Me.BtnFiltrar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnFiltrar.ButtonText = ""
        Me.BtnFiltrar.ClickBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnFiltrar.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnFiltrar.CornerRadius = 5
        Me.BtnFiltrar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnFiltrar.HoverBackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.BtnFiltrar.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnFiltrar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnFiltrar.Location = New System.Drawing.Point(844, 59)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(46, 43)
        Me.BtnFiltrar.TabIndex = 42
        Me.BtnFiltrar.TextColor = System.Drawing.Color.DodgerBlue
        Me.TTMensaje.SetToolTip(Me.BtnFiltrar, "Generar Filtro")
        Me.BtnFiltrar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'BtnCorregirMatricula
        '
        Me.BtnCorregirMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCorregirMatricula.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCorregirMatricula.FlatAppearance.BorderSize = 0
        Me.BtnCorregirMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorregirMatricula.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCorregirMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnCorregirMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCorregirMatricula.Location = New System.Drawing.Point(867, 8)
        Me.BtnCorregirMatricula.Name = "BtnCorregirMatricula"
        Me.BtnCorregirMatricula.Size = New System.Drawing.Size(42, 42)
        Me.BtnCorregirMatricula.TabIndex = 8
        Me.BtnCorregirMatricula.Text = "Corregir Matricula"
        Me.TTMensaje.SetToolTip(Me.BtnCorregirMatricula, "Corrige la matricula de los alumnos seleccionado en la tabla")
        Me.BtnCorregirMatricula.UseVisualStyleBackColor = False
        Me.BtnCorregirMatricula.Visible = False
        '
        'BtnBuscarMatriculaTransicion
        '
        Me.BtnBuscarMatriculaTransicion.BackgroundColor = System.Drawing.Color.Transparent
        Me.BtnBuscarMatriculaTransicion.ButtonImage = CType(resources.GetObject("BtnBuscarMatriculaTransicion.ButtonImage"), System.Drawing.Image)
        Me.BtnBuscarMatriculaTransicion.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnBuscarMatriculaTransicion.ButtonText = ""
        Me.BtnBuscarMatriculaTransicion.ClickBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscarMatriculaTransicion.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscarMatriculaTransicion.CornerRadius = 5
        Me.BtnBuscarMatriculaTransicion.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnBuscarMatriculaTransicion.HoverBackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.BtnBuscarMatriculaTransicion.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscarMatriculaTransicion.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnBuscarMatriculaTransicion.Location = New System.Drawing.Point(863, 16)
        Me.BtnBuscarMatriculaTransicion.Name = "BtnBuscarMatriculaTransicion"
        Me.BtnBuscarMatriculaTransicion.Size = New System.Drawing.Size(46, 43)
        Me.BtnBuscarMatriculaTransicion.TabIndex = 45
        Me.BtnBuscarMatriculaTransicion.TextColor = System.Drawing.Color.DodgerBlue
        Me.TTMensaje.SetToolTip(Me.BtnBuscarMatriculaTransicion, "Generar Filtro")
        Me.BtnBuscarMatriculaTransicion.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'CmbTurnoTransisionM
        '
        Me.CmbTurnoTransisionM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTurnoTransisionM.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurnoTransisionM.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbTurnoTransisionM.FormattingEnabled = True
        Me.CmbTurnoTransisionM.Location = New System.Drawing.Point(424, 16)
        Me.CmbTurnoTransisionM.Name = "CmbTurnoTransisionM"
        Me.CmbTurnoTransisionM.Size = New System.Drawing.Size(106, 27)
        Me.CmbTurnoTransisionM.TabIndex = 43
        Me.TTMensaje.SetToolTip(Me.CmbTurnoTransisionM, "Turno")
        '
        'CmbSeccionTransisionM
        '
        Me.CmbSeccionTransisionM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSeccionTransisionM.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeccionTransisionM.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbSeccionTransisionM.FormattingEnabled = True
        Me.CmbSeccionTransisionM.Location = New System.Drawing.Point(733, 16)
        Me.CmbSeccionTransisionM.Name = "CmbSeccionTransisionM"
        Me.CmbSeccionTransisionM.Size = New System.Drawing.Size(106, 27)
        Me.CmbSeccionTransisionM.TabIndex = 44
        Me.TTMensaje.SetToolTip(Me.CmbSeccionTransisionM, "Seccion")
        '
        'CmbTurno_Buscar_Listado
        '
        Me.CmbTurno_Buscar_Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTurno_Buscar_Listado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurno_Buscar_Listado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbTurno_Buscar_Listado.FormattingEnabled = True
        Me.CmbTurno_Buscar_Listado.Location = New System.Drawing.Point(429, 16)
        Me.CmbTurno_Buscar_Listado.Name = "CmbTurno_Buscar_Listado"
        Me.CmbTurno_Buscar_Listado.Size = New System.Drawing.Size(106, 27)
        Me.CmbTurno_Buscar_Listado.TabIndex = 45
        Me.TTMensaje.SetToolTip(Me.CmbTurno_Buscar_Listado, "Turno")
        '
        'CmbSeccion_Buscar_Listado
        '
        Me.CmbSeccion_Buscar_Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSeccion_Buscar_Listado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeccion_Buscar_Listado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbSeccion_Buscar_Listado.FormattingEnabled = True
        Me.CmbSeccion_Buscar_Listado.Location = New System.Drawing.Point(693, 16)
        Me.CmbSeccion_Buscar_Listado.Name = "CmbSeccion_Buscar_Listado"
        Me.CmbSeccion_Buscar_Listado.Size = New System.Drawing.Size(71, 27)
        Me.CmbSeccion_Buscar_Listado.TabIndex = 46
        Me.TTMensaje.SetToolTip(Me.CmbSeccion_Buscar_Listado, "Seccion")
        '
        'UI_CustomButton1
        '
        Me.UI_CustomButton1.BackgroundColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.ButtonImage = CType(resources.GetObject("UI_CustomButton1.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton1.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton1.ButtonText = ""
        Me.UI_CustomButton1.ClickBackColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.CornerRadius = 5
        Me.UI_CustomButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton1.HoverBackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.UI_CustomButton1.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton1.Location = New System.Drawing.Point(794, 16)
        Me.UI_CustomButton1.Name = "UI_CustomButton1"
        Me.UI_CustomButton1.Size = New System.Drawing.Size(46, 43)
        Me.UI_CustomButton1.TabIndex = 47
        Me.UI_CustomButton1.TextColor = System.Drawing.Color.DodgerBlue
        Me.TTMensaje.SetToolTip(Me.UI_CustomButton1, "Generar Filtro")
        Me.UI_CustomButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'Lbltitulo
        '
        Me.Lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Roboto Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbltitulo.Location = New System.Drawing.Point(657, 9)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(290, 33)
        Me.Lbltitulo.TabIndex = 30
        Me.Lbltitulo.Text = ".: Gestión de Matrícula:."
        Me.Lbltitulo.Visible = False
        '
        'EpError
        '
        Me.EpError.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Búsqueda..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Roboto Medium", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1279, 717)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.PnMatricula)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1271, 686)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Estudiantes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PnMatricula
        '
        Me.PnMatricula.AutoScroll = True
        Me.PnMatricula.Controls.Add(Me.pntitulo)
        Me.PnMatricula.Controls.Add(Me.Panel12)
        Me.PnMatricula.Controls.Add(Me.PnMatriculaNormal)
        Me.PnMatricula.Controls.Add(Me.PnMatricula_Lotes)
        Me.PnMatricula.Controls.Add(Me.Panel9)
        Me.PnMatricula.Controls.Add(Me.Panel7)
        Me.PnMatricula.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PnMatricula.Location = New System.Drawing.Point(3, 6)
        Me.PnMatricula.Name = "PnMatricula"
        Me.PnMatricula.Size = New System.Drawing.Size(21, 769)
        Me.PnMatricula.TabIndex = 34
        Me.PnMatricula.Visible = False
        '
        'pntitulo
        '
        Me.pntitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pntitulo.Controls.Add(Me.Label8)
        Me.pntitulo.Controls.Add(Me.Button7)
        Me.pntitulo.Location = New System.Drawing.Point(3, 3)
        Me.pntitulo.Name = "pntitulo"
        Me.pntitulo.Size = New System.Drawing.Size(973, 68)
        Me.pntitulo.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(410, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Datos del Alumnos"
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.AutoSize = True
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.Button7.Location = New System.Drawing.Point(940, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 29)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = " "
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'Panel12
        '
        Me.Panel12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel12.Controls.Add(Me.ChkLotesMatricula)
        Me.Panel12.Controls.Add(Me.BtnNuevaMatricula)
        Me.Panel12.Location = New System.Drawing.Point(99, 77)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(780, 60)
        Me.Panel12.TabIndex = 38
        '
        'ChkLotesMatricula
        '
        Me.ChkLotesMatricula.AutoSize = True
        Me.ChkLotesMatricula.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLotesMatricula.Enabled = False
        Me.ChkLotesMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLotesMatricula.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ChkLotesMatricula.Location = New System.Drawing.Point(-1, 32)
        Me.ChkLotesMatricula.Name = "ChkLotesMatricula"
        Me.ChkLotesMatricula.Size = New System.Drawing.Size(139, 22)
        Me.ChkLotesMatricula.TabIndex = 32
        Me.ChkLotesMatricula.Text = "Ingresar por Lote"
        Me.ChkLotesMatricula.UseVisualStyleBackColor = True
        '
        'BtnNuevaMatricula
        '
        Me.BtnNuevaMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevaMatricula.FlatAppearance.BorderSize = 0
        Me.BtnNuevaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaMatricula.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaMatricula.Image = CType(resources.GetObject("BtnNuevaMatricula.Image"), System.Drawing.Image)
        Me.BtnNuevaMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevaMatricula.Location = New System.Drawing.Point(589, 12)
        Me.BtnNuevaMatricula.Name = "BtnNuevaMatricula"
        Me.BtnNuevaMatricula.Size = New System.Drawing.Size(192, 42)
        Me.BtnNuevaMatricula.TabIndex = 31
        Me.BtnNuevaMatricula.Text = "Nueva Matrícula"
        Me.BtnNuevaMatricula.UseVisualStyleBackColor = True
        '
        'PnMatriculaNormal
        '
        Me.PnMatriculaNormal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnMatriculaNormal.BackColor = System.Drawing.SystemColors.Control
        Me.PnMatriculaNormal.Controls.Add(Me.CmbSeccion)
        Me.PnMatriculaNormal.Controls.Add(Me.Label10)
        Me.PnMatriculaNormal.Controls.Add(Me.CmbTurno)
        Me.PnMatriculaNormal.Controls.Add(Me.Label6)
        Me.PnMatriculaNormal.Controls.Add(Me.CmbGrado_Matricular)
        Me.PnMatriculaNormal.Controls.Add(Me.CmbModalidadMatricular)
        Me.PnMatriculaNormal.Controls.Add(Me.PictureBox5)
        Me.PnMatriculaNormal.Controls.Add(Me.LblTituloMatricula)
        Me.PnMatriculaNormal.Controls.Add(Me.Label13)
        Me.PnMatriculaNormal.Controls.Add(Me.Label15)
        Me.PnMatriculaNormal.Controls.Add(Me.Label16)
        Me.PnMatriculaNormal.Controls.Add(Me.TxtIdAlumnoMatricula)
        Me.PnMatriculaNormal.Location = New System.Drawing.Point(98, 143)
        Me.PnMatriculaNormal.Name = "PnMatriculaNormal"
        Me.PnMatriculaNormal.Size = New System.Drawing.Size(783, 246)
        Me.PnMatriculaNormal.TabIndex = 8
        '
        'CmbSeccion
        '
        Me.CmbSeccion.FormattingEnabled = True
        Me.CmbSeccion.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I"})
        Me.CmbSeccion.Location = New System.Drawing.Point(112, 206)
        Me.CmbSeccion.Name = "CmbSeccion"
        Me.CmbSeccion.Size = New System.Drawing.Size(189, 26)
        Me.CmbSeccion.TabIndex = 47
        Me.CmbSeccion.Text = "A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(38, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Sección:"
        '
        'CmbTurno
        '
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.Items.AddRange(New Object() {"Matutino", "Vespertino", "Sabatino", "Dominical"})
        Me.CmbTurno.Location = New System.Drawing.Point(565, 154)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(189, 26)
        Me.CmbTurno.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(507, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Turno:"
        '
        'CmbGrado_Matricular
        '
        Me.CmbGrado_Matricular.FormattingEnabled = True
        Me.CmbGrado_Matricular.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGrado_Matricular.Location = New System.Drawing.Point(565, 99)
        Me.CmbGrado_Matricular.Name = "CmbGrado_Matricular"
        Me.CmbGrado_Matricular.Size = New System.Drawing.Size(189, 26)
        Me.CmbGrado_Matricular.TabIndex = 43
        '
        'CmbModalidadMatricular
        '
        Me.CmbModalidadMatricular.FormattingEnabled = True
        Me.CmbModalidadMatricular.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL", "PREESCOLAR COMUNITARIO", "PREESCOLAR COMUNITARIO MULTINIVEL", "PRIMARIA REGULAR", "PRIMARIA MULTIGRADO", "SECUNDARIA REGULAR", "SECUNDARIA DIURNA", "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidadMatricular.Location = New System.Drawing.Point(112, 154)
        Me.CmbModalidadMatricular.Name = "CmbModalidadMatricular"
        Me.CmbModalidadMatricular.Size = New System.Drawing.Size(333, 26)
        Me.CmbModalidadMatricular.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'LblTituloMatricula
        '
        Me.LblTituloMatricula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTituloMatricula.AutoSize = True
        Me.LblTituloMatricula.BackColor = System.Drawing.SystemColors.Control
        Me.LblTituloMatricula.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloMatricula.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LblTituloMatricula.Location = New System.Drawing.Point(75, 28)
        Me.LblTituloMatricula.Name = "LblTituloMatricula"
        Me.LblTituloMatricula.Size = New System.Drawing.Size(438, 23)
        Me.LblTituloMatricula.TabIndex = 41
        Me.LblTituloMatricula.Text = "Centro Educativo Francica Hernández Espininoza."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(24, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 18)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Modalidad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(507, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 18)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Grado:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(24, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 18)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "id Alumno:"
        '
        'TxtIdAlumnoMatricula
        '
        Me.TxtIdAlumnoMatricula.BackColor = System.Drawing.Color.Ivory
        Me.TxtIdAlumnoMatricula.Enabled = False
        Me.TxtIdAlumnoMatricula.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtIdAlumnoMatricula.Location = New System.Drawing.Point(114, 100)
        Me.TxtIdAlumnoMatricula.Name = "TxtIdAlumnoMatricula"
        Me.TxtIdAlumnoMatricula.ReadOnly = True
        Me.TxtIdAlumnoMatricula.Size = New System.Drawing.Size(278, 25)
        Me.TxtIdAlumnoMatricula.TabIndex = 3
        '
        'PnMatricula_Lotes
        '
        Me.PnMatricula_Lotes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnMatricula_Lotes.BackColor = System.Drawing.SystemColors.Control
        Me.PnMatricula_Lotes.Controls.Add(Me.ChkRegistrar)
        Me.PnMatricula_Lotes.Controls.Add(Me.btnHelp)
        Me.PnMatricula_Lotes.Controls.Add(Me.Load)
        Me.PnMatricula_Lotes.Controls.Add(Me.LblRegistros)
        Me.PnMatricula_Lotes.Controls.Add(Me.DtListadoMatricula_Lotes)
        Me.PnMatricula_Lotes.Controls.Add(Me.PictureBox4)
        Me.PnMatricula_Lotes.Controls.Add(Me.Label7)
        Me.PnMatricula_Lotes.Controls.Add(Me.BtnCargarMatriculaLotes)
        Me.PnMatricula_Lotes.Location = New System.Drawing.Point(98, 395)
        Me.PnMatricula_Lotes.Name = "PnMatricula_Lotes"
        Me.PnMatricula_Lotes.Size = New System.Drawing.Size(783, 329)
        Me.PnMatricula_Lotes.TabIndex = 31
        Me.PnMatricula_Lotes.Visible = False
        '
        'ChkRegistrar
        '
        Me.ChkRegistrar.AutoSize = True
        Me.ChkRegistrar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkRegistrar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ChkRegistrar.Location = New System.Drawing.Point(593, 57)
        Me.ChkRegistrar.Name = "ChkRegistrar"
        Me.ChkRegistrar.Size = New System.Drawing.Size(171, 22)
        Me.ChkRegistrar.TabIndex = 48
        Me.ChkRegistrar.Text = "Registrar si no existe."
        Me.ChkRegistrar.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(740, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 42)
        Me.btnHelp.TabIndex = 47
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Image = CType(resources.GetObject("Load.Image"), System.Drawing.Image)
        Me.Load.Location = New System.Drawing.Point(229, 100)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(325, 217)
        Me.Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Load.TabIndex = 46
        Me.Load.TabStop = False
        Me.Load.Visible = False
        '
        'LblRegistros
        '
        Me.LblRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRegistros.AutoSize = True
        Me.LblRegistros.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistros.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblRegistros.Location = New System.Drawing.Point(299, 72)
        Me.LblRegistros.Name = "LblRegistros"
        Me.LblRegistros.Size = New System.Drawing.Size(112, 17)
        Me.LblRegistros.TabIndex = 45
        Me.LblRegistros.Text = "Total Registros 0"
        '
        'DtListadoMatricula_Lotes
        '
        Me.DtListadoMatricula_Lotes.AllowUserToAddRows = False
        Me.DtListadoMatricula_Lotes.AllowUserToDeleteRows = False
        Me.DtListadoMatricula_Lotes.AllowUserToOrderColumns = True
        Me.DtListadoMatricula_Lotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtListadoMatricula_Lotes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DtListadoMatricula_Lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtListadoMatricula_Lotes.GridColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DtListadoMatricula_Lotes.Location = New System.Drawing.Point(13, 100)
        Me.DtListadoMatricula_Lotes.Name = "DtListadoMatricula_Lotes"
        Me.DtListadoMatricula_Lotes.ReadOnly = True
        Me.DtListadoMatricula_Lotes.Size = New System.Drawing.Size(754, 217)
        Me.DtListadoMatricula_Lotes.TabIndex = 43
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(75, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Interfaz de Matrícula de Estudiantes por Lote"
        '
        'BtnCargarMatriculaLotes
        '
        Me.BtnCargarMatriculaLotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCargarMatriculaLotes.FlatAppearance.BorderSize = 0
        Me.BtnCargarMatriculaLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargarMatriculaLotes.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarMatriculaLotes.ForeColor = System.Drawing.Color.White
        Me.BtnCargarMatriculaLotes.Image = CType(resources.GetObject("BtnCargarMatriculaLotes.Image"), System.Drawing.Image)
        Me.BtnCargarMatriculaLotes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCargarMatriculaLotes.Location = New System.Drawing.Point(594, 9)
        Me.BtnCargarMatriculaLotes.Name = "BtnCargarMatriculaLotes"
        Me.BtnCargarMatriculaLotes.Size = New System.Drawing.Size(140, 42)
        Me.BtnCargarMatriculaLotes.TabIndex = 8
        Me.BtnCargarMatriculaLotes.Text = "Cargar Datos"
        Me.BtnCargarMatriculaLotes.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel9.Controls.Add(Me.BtnCancelarMatricula)
        Me.Panel9.Controls.Add(Me.BtnGuardarMatricula)
        Me.Panel9.Controls.Add(Me.BtnEditarMatricula)
        Me.Panel9.Location = New System.Drawing.Point(982, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(786, 67)
        Me.Panel9.TabIndex = 35
        '
        'BtnCancelarMatricula
        '
        Me.BtnCancelarMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarMatricula.FlatAppearance.BorderSize = 0
        Me.BtnCancelarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarMatricula.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarMatricula.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelarMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelarMatricula.Location = New System.Drawing.Point(628, 13)
        Me.BtnCancelarMatricula.Name = "BtnCancelarMatricula"
        Me.BtnCancelarMatricula.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelarMatricula.TabIndex = 10
        Me.BtnCancelarMatricula.Text = "Cancelar"
        Me.BtnCancelarMatricula.UseVisualStyleBackColor = True
        '
        'BtnGuardarMatricula
        '
        Me.BtnGuardarMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarMatricula.FlatAppearance.BorderSize = 0
        Me.BtnGuardarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarMatricula.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarMatricula.Image = CType(resources.GetObject("BtnGuardarMatricula.Image"), System.Drawing.Image)
        Me.BtnGuardarMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarMatricula.Location = New System.Drawing.Point(482, 13)
        Me.BtnGuardarMatricula.Name = "BtnGuardarMatricula"
        Me.BtnGuardarMatricula.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardarMatricula.TabIndex = 9
        Me.BtnGuardarMatricula.Text = "Guardar"
        Me.BtnGuardarMatricula.UseVisualStyleBackColor = True
        '
        'BtnEditarMatricula
        '
        Me.BtnEditarMatricula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditarMatricula.FlatAppearance.BorderSize = 0
        Me.BtnEditarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarMatricula.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarMatricula.ForeColor = System.Drawing.Color.White
        Me.BtnEditarMatricula.Image = CType(resources.GetObject("BtnEditarMatricula.Image"), System.Drawing.Image)
        Me.BtnEditarMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEditarMatricula.Location = New System.Drawing.Point(339, 13)
        Me.BtnEditarMatricula.Name = "BtnEditarMatricula"
        Me.BtnEditarMatricula.Size = New System.Drawing.Size(140, 42)
        Me.BtnEditarMatricula.TabIndex = 11
        Me.BtnEditarMatricula.Text = "Editar"
        Me.BtnEditarMatricula.UseVisualStyleBackColor = True
        Me.BtnEditarMatricula.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Location = New System.Drawing.Point(982, 76)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(784, 1)
        Me.Panel7.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PnMejorAlumno)
        Me.Panel2.Controls.Add(Me.PnMatricularSeleccion)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1248, 769)
        Me.Panel2.TabIndex = 45
        '
        'PnMejorAlumno
        '
        Me.PnMejorAlumno.Controls.Add(Me.lblcontador)
        Me.PnMejorAlumno.Controls.Add(Me.DtExcelenciaAcademica)
        Me.PnMejorAlumno.Controls.Add(Me.Panel16)
        Me.PnMejorAlumno.Location = New System.Drawing.Point(9, 15)
        Me.PnMejorAlumno.Name = "PnMejorAlumno"
        Me.PnMejorAlumno.Size = New System.Drawing.Size(56, 87)
        Me.PnMejorAlumno.TabIndex = 49
        Me.PnMejorAlumno.Visible = False
        '
        'lblcontador
        '
        Me.lblcontador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontador.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblcontador.Location = New System.Drawing.Point(-402, 163)
        Me.lblcontador.Name = "lblcontador"
        Me.lblcontador.Size = New System.Drawing.Size(433, 18)
        Me.lblcontador.TabIndex = 43
        Me.lblcontador.Text = "0  Registros en total."
        Me.lblcontador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtExcelenciaAcademica
        '
        Me.DtExcelenciaAcademica.AllowUserToAddRows = False
        Me.DtExcelenciaAcademica.AllowUserToDeleteRows = False
        Me.DtExcelenciaAcademica.AllowUserToOrderColumns = True
        Me.DtExcelenciaAcademica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtExcelenciaAcademica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtExcelenciaAcademica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        Me.DtExcelenciaAcademica.ContextMenuStrip = Me.Opciones1
        Me.DtExcelenciaAcademica.Location = New System.Drawing.Point(23, 185)
        Me.DtExcelenciaAcademica.Name = "DtExcelenciaAcademica"
        Me.DtExcelenciaAcademica.ReadOnly = True
        Me.DtExcelenciaAcademica.Size = New System.Drawing.Size(33, 0)
        Me.DtExcelenciaAcademica.TabIndex = 36
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel16.Controls.Add(Me.BtnExportar)
        Me.Panel16.Controls.Add(Me.BtnFiltrar)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.CmbETurno)
        Me.Panel16.Controls.Add(Me.CmbESeccion)
        Me.Panel16.Controls.Add(Me.CmbEGrado)
        Me.Panel16.Controls.Add(Me.CmbECorte)
        Me.Panel16.Controls.Add(Me.Opcion)
        Me.Panel16.Controls.Add(Me.CmbEModalidad)
        Me.Panel16.Controls.Add(Me.Button10)
        Me.Panel16.Controls.Add(Me.Anio)
        Me.Panel16.Controls.Add(Me.Label9)
        Me.Panel16.Location = New System.Drawing.Point(23, 21)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(33, 117)
        Me.Panel16.TabIndex = 35
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel17.Location = New System.Drawing.Point(18, 46)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(685, 2)
        Me.Panel17.TabIndex = 41
        '
        'Opcion
        '
        Me.Opcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Opcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Opcion.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Opcion.FormattingEnabled = True
        Me.Opcion.Items.AddRange(New Object() {"Excelencia académica", "Alumnos destacados", "Alumnos con aprendizaje Elemental", "Alumnos con aprendizaje Inicial", "Alumos Reprobados", "Alumos Reprobados en detalle", "Matricula", "Estudiantes Retirados"})
        Me.Opcion.Location = New System.Drawing.Point(18, 13)
        Me.Opcion.Name = "Opcion"
        Me.Opcion.Size = New System.Drawing.Size(290, 31)
        Me.Opcion.TabIndex = 39
        Me.Opcion.Text = " Excelencia académica"
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.AutoSize = True
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.Button10.Location = New System.Drawing.Point(-6, 9)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(30, 29)
        Me.Button10.TabIndex = 32
        Me.Button10.Text = " "
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Anio
        '
        Me.Anio.BaseColour = System.Drawing.Color.White
        Me.Anio.BorderColour = System.Drawing.Color.Gray
        Me.Anio.ButtonColour = System.Drawing.Color.Gainsboro
        Me.Anio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Anio.FontColour = System.Drawing.Color.DodgerBlue
        Me.Anio.Location = New System.Drawing.Point(99, 78)
        Me.Anio.Maximum = CType(9999999, Long)
        Me.Anio.Minimum = CType(0, Long)
        Me.Anio.Name = "Anio"
        Me.Anio.SecondBorderColour = System.Drawing.Color.DodgerBlue
        Me.Anio.SignsColor = System.Drawing.Color.DodgerBlue
        Me.Anio.Size = New System.Drawing.Size(115, 24)
        Me.Anio.TabIndex = 38
        Me.Anio.Text = "UI_Numeric1"
        Me.Anio.Value = CType(2021, Long)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 18)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Búsqueda..."
        '
        'PnMatricularSeleccion
        '
        Me.PnMatricularSeleccion.Controls.Add(Me.Panel15)
        Me.PnMatricularSeleccion.Controls.Add(Me.Panel14)
        Me.PnMatricularSeleccion.Location = New System.Drawing.Point(6, 207)
        Me.PnMatricularSeleccion.Name = "PnMatricularSeleccion"
        Me.PnMatricularSeleccion.Size = New System.Drawing.Size(46, 92)
        Me.PnMatricularSeleccion.TabIndex = 48
        Me.PnMatricularSeleccion.Visible = False
        '
        'Panel15
        '
        Me.Panel15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel15.Controls.Add(Me.Button8)
        Me.Panel15.Controls.Add(Me.Button6)
        Me.Panel15.Controls.Add(Me.Button9)
        Me.Panel15.Location = New System.Drawing.Point(-443, 346)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(932, 56)
        Me.Panel15.TabIndex = 50
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button8.Location = New System.Drawing.Point(789, 7)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(140, 42)
        Me.Button8.TabIndex = 48
        Me.Button8.Text = "Cancelar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button6.Location = New System.Drawing.Point(387, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 42)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Editar"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button9.Location = New System.Drawing.Point(640, 7)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(140, 42)
        Me.Button9.TabIndex = 47
        Me.Button9.Text = "Guardar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel14.BackColor = System.Drawing.SystemColors.Control
        Me.Panel14.Controls.Add(Me.txtAñoMatricula)
        Me.Panel14.Controls.Add(Me.CmbSn)
        Me.Panel14.Controls.Add(Me.Label29)
        Me.Panel14.Controls.Add(Me.CmbTn)
        Me.Panel14.Controls.Add(Me.Label30)
        Me.Panel14.Controls.Add(Me.CmbGd)
        Me.Panel14.Controls.Add(Me.CmbMd)
        Me.Panel14.Controls.Add(Me.PictureBox6)
        Me.Panel14.Controls.Add(Me.Label31)
        Me.Panel14.Controls.Add(Me.Label32)
        Me.Panel14.Controls.Add(Me.Label33)
        Me.Panel14.Location = New System.Drawing.Point(-442, 75)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(931, 242)
        Me.Panel14.TabIndex = 46
        '
        'txtAñoMatricula
        '
        Me.txtAñoMatricula.BaseColour = System.Drawing.Color.White
        Me.txtAñoMatricula.BorderColour = System.Drawing.Color.Gray
        Me.txtAñoMatricula.ButtonColour = System.Drawing.Color.Gainsboro
        Me.txtAñoMatricula.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtAñoMatricula.FontColour = System.Drawing.Color.DodgerBlue
        Me.txtAñoMatricula.Location = New System.Drawing.Point(708, 36)
        Me.txtAñoMatricula.Maximum = CType(9999999, Long)
        Me.txtAñoMatricula.Minimum = CType(0, Long)
        Me.txtAñoMatricula.Name = "txtAñoMatricula"
        Me.txtAñoMatricula.SecondBorderColour = System.Drawing.Color.DodgerBlue
        Me.txtAñoMatricula.SignsColor = System.Drawing.Color.DodgerBlue
        Me.txtAñoMatricula.Size = New System.Drawing.Size(103, 24)
        Me.txtAñoMatricula.TabIndex = 48
        Me.txtAñoMatricula.Text = "UI_Numeric1"
        Me.txtAñoMatricula.Value = CType(2021, Long)
        '
        'CmbSn
        '
        Me.CmbSn.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSn.FormattingEnabled = True
        Me.CmbSn.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I"})
        Me.CmbSn.Location = New System.Drawing.Point(622, 165)
        Me.CmbSn.Name = "CmbSn"
        Me.CmbSn.Size = New System.Drawing.Size(189, 27)
        Me.CmbSn.TabIndex = 47
        Me.CmbSn.Text = "A"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label29.Location = New System.Drawing.Point(542, 173)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(70, 19)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Sección:"
        '
        'CmbTn
        '
        Me.CmbTn.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTn.FormattingEnabled = True
        Me.CmbTn.Items.AddRange(New Object() {"Matutino", "Vespertino", "Sabatino", "Dominical"})
        Me.CmbTn.Location = New System.Drawing.Point(129, 165)
        Me.CmbTn.Name = "CmbTn"
        Me.CmbTn.Size = New System.Drawing.Size(241, 27)
        Me.CmbTn.TabIndex = 45
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label30.Location = New System.Drawing.Point(64, 173)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 19)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "Turno:"
        '
        'CmbGd
        '
        Me.CmbGd.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGd.FormattingEnabled = True
        Me.CmbGd.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGd.Location = New System.Drawing.Point(622, 99)
        Me.CmbGd.Name = "CmbGd"
        Me.CmbGd.Size = New System.Drawing.Size(189, 27)
        Me.CmbGd.TabIndex = 43
        '
        'CmbMd
        '
        Me.CmbMd.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMd.FormattingEnabled = True
        Me.CmbMd.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL", "PREESCOLAR COMUNITARIO", "PREESCOLAR COMUNITARIO MULTINIVEL", "PRIMARIA REGULAR", "PRIMARIA MULTIGRADO", "SECUNDARIA REGULAR", "SECUNDARIA DIURNA", "SECUNDARIA EN EL CAMPO"})
        Me.CmbMd.Location = New System.Drawing.Point(129, 99)
        Me.CmbMd.Name = "CmbMd"
        Me.CmbMd.Size = New System.Drawing.Size(365, 27)
        Me.CmbMd.TabIndex = 4
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label31.Location = New System.Drawing.Point(75, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(257, 23)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Edición de matrícula por lote"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label32.Location = New System.Drawing.Point(34, 107)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(89, 19)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Modalidad:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label33.Location = New System.Drawing.Point(558, 107)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 19)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "Grado:"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.DtMatricula)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(160, 340)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(931, 254)
        Me.Panel6.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'DtMatricula
        '
        Me.DtMatricula.AllowUserToAddRows = False
        Me.DtMatricula.AllowUserToDeleteRows = False
        Me.DtMatricula.AllowUserToOrderColumns = True
        Me.DtMatricula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtMatricula.ContextMenuStrip = Me.OpciondeMatricula
        Me.DtMatricula.Location = New System.Drawing.Point(23, 73)
        Me.DtMatricula.Name = "DtMatricula"
        Me.DtMatricula.ReadOnly = True
        Me.DtMatricula.Size = New System.Drawing.Size(886, 154)
        Me.DtMatricula.TabIndex = 11
        '
        'OpciondeMatricula
        '
        Me.OpciondeMatricula.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarMatrículaToolStripMenuItem, Me.EliminarMatriculaToolStripMenuItem, Me.SuspenderMatriculaToolStripMenuItem, Me.RestaurarMatriculaToolStripMenuItem})
        Me.OpciondeMatricula.Name = "OpciondeMatricula"
        Me.OpciondeMatricula.Size = New System.Drawing.Size(183, 92)
        '
        'EditarMatrículaToolStripMenuItem
        '
        Me.EditarMatrículaToolStripMenuItem.Name = "EditarMatrículaToolStripMenuItem"
        Me.EditarMatrículaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EditarMatrículaToolStripMenuItem.Text = "Editar Matrícula"
        '
        'EliminarMatriculaToolStripMenuItem
        '
        Me.EliminarMatriculaToolStripMenuItem.Name = "EliminarMatriculaToolStripMenuItem"
        Me.EliminarMatriculaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EliminarMatriculaToolStripMenuItem.Text = "Eliminar Matrícula"
        '
        'SuspenderMatriculaToolStripMenuItem
        '
        Me.SuspenderMatriculaToolStripMenuItem.Name = "SuspenderMatriculaToolStripMenuItem"
        Me.SuspenderMatriculaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SuspenderMatriculaToolStripMenuItem.Text = "Suspender Matricula"
        '
        'RestaurarMatriculaToolStripMenuItem
        '
        Me.RestaurarMatriculaToolStripMenuItem.Name = "RestaurarMatriculaToolStripMenuItem"
        Me.RestaurarMatriculaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RestaurarMatriculaToolStripMenuItem.Text = "Restaurar Matricula"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(85, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Datos de Matricula"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.BtnM_Inicial)
        Me.Panel5.Controls.Add(Me.Datalistado)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.TxtBusquedaApellidos)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.TxtBusquedaNombre)
        Me.Panel5.Location = New System.Drawing.Point(160, 15)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(931, 305)
        Me.Panel5.TabIndex = 0
        '
        'BtnM_Inicial
        '
        Me.BtnM_Inicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnM_Inicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnM_Inicial.BackgroundColor = System.Drawing.Color.Transparent
        Me.BtnM_Inicial.ButtonImage = Global.Ctrl_Estudiantil.My.Resources.Resources.business_report
        Me.BtnM_Inicial.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnM_Inicial.ButtonText = "Matricula Inicial"
        Me.BtnM_Inicial.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BtnM_Inicial.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnM_Inicial.CornerRadius = 5
        Me.BtnM_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnM_Inicial.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnM_Inicial.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnM_Inicial.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnM_Inicial.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnM_Inicial.Location = New System.Drawing.Point(794, 17)
        Me.BtnM_Inicial.Name = "BtnM_Inicial"
        Me.BtnM_Inicial.Size = New System.Drawing.Size(113, 38)
        Me.BtnM_Inicial.TabIndex = 14
        Me.BtnM_Inicial.Text = "UI_CustomButton1"
        Me.BtnM_Inicial.TextColor = System.Drawing.Color.DodgerBlue
        Me.BtnM_Inicial.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PnOpcionesMatricula)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1271, 686)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transición de Matricula"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PnOpcionesMatricula
        '
        Me.PnOpcionesMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnOpcionesMatricula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnOpcionesMatricula.Controls.Add(Me.TxtAñoMatricular)
        Me.PnOpcionesMatricula.Controls.Add(Me.Button3)
        Me.PnOpcionesMatricula.Controls.Add(Me.CmbSeccionDestino)
        Me.PnOpcionesMatricula.Controls.Add(Me.CmbGradoDestino)
        Me.PnOpcionesMatricula.Controls.Add(Me.BtnAceptar)
        Me.PnOpcionesMatricula.Controls.Add(Me.CmbTurnoDestino)
        Me.PnOpcionesMatricula.Controls.Add(Me.CmbModalidadDestino)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label27)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label18)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label26)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label24)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label19)
        Me.PnOpcionesMatricula.Controls.Add(Me.Label17)
        Me.PnOpcionesMatricula.Location = New System.Drawing.Point(186, 227)
        Me.PnOpcionesMatricula.Name = "PnOpcionesMatricula"
        Me.PnOpcionesMatricula.Size = New System.Drawing.Size(524, 387)
        Me.PnOpcionesMatricula.TabIndex = 2
        Me.PnOpcionesMatricula.Visible = False
        '
        'TxtAñoMatricular
        '
        Me.TxtAñoMatricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAñoMatricular.BackColor = System.Drawing.Color.White
        Me.TxtAñoMatricular.FocusedColor = "#508ef5"
        Me.TxtAñoMatricular.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAñoMatricular.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtAñoMatricular.IsEnabled = True
        Me.TxtAñoMatricular.Location = New System.Drawing.Point(238, 73)
        Me.TxtAñoMatricular.MaxLength = 32767
        Me.TxtAñoMatricular.Name = "TxtAñoMatricular"
        Me.TxtAñoMatricular.Size = New System.Drawing.Size(200, 24)
        Me.TxtAñoMatricular.TabIndex = 54
        Me.TxtAñoMatricular.Text = "2022"
        Me.TxtAñoMatricular.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAñoMatricular.UIFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAñoMatricular.UIFontColor = "#3598DB"
        Me.TxtAñoMatricular.UIMultiline = False
        Me.TxtAñoMatricular.UIReadOnly = False
        Me.TxtAñoMatricular.UseSystemPasswordChar = False
        Me.TxtAñoMatricular.ValidateMessageText = "Solo se aceptan números"
        Me.TxtAñoMatricular.ValidateMessageTitle = "Validación"
        Me.TxtAñoMatricular.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Numeric
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.Location = New System.Drawing.Point(249, 303)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 42)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CmbSeccionDestino
        '
        Me.CmbSeccionDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSeccionDestino.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeccionDestino.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbSeccionDestino.FormattingEnabled = True
        Me.CmbSeccionDestino.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N"})
        Me.CmbSeccionDestino.Location = New System.Drawing.Point(238, 246)
        Me.CmbSeccionDestino.Name = "CmbSeccionDestino"
        Me.CmbSeccionDestino.Size = New System.Drawing.Size(170, 27)
        Me.CmbSeccionDestino.TabIndex = 12
        Me.CmbSeccionDestino.Text = "A"
        '
        'CmbGradoDestino
        '
        Me.CmbGradoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbGradoDestino.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGradoDestino.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbGradoDestino.FormattingEnabled = True
        Me.CmbGradoDestino.Location = New System.Drawing.Point(238, 160)
        Me.CmbGradoDestino.Name = "CmbGradoDestino"
        Me.CmbGradoDestino.Size = New System.Drawing.Size(170, 27)
        Me.CmbGradoDestino.TabIndex = 12
        Me.CmbGradoDestino.Text = "Primero"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.FlatAppearance.BorderSize = 0
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(383, 303)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(121, 42)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbTurnoDestino
        '
        Me.CmbTurnoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTurnoDestino.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurnoDestino.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbTurnoDestino.FormattingEnabled = True
        Me.CmbTurnoDestino.Items.AddRange(New Object() {"Matutino", "Vespertino", "Sabatino", "Dominical"})
        Me.CmbTurnoDestino.Location = New System.Drawing.Point(238, 203)
        Me.CmbTurnoDestino.Name = "CmbTurnoDestino"
        Me.CmbTurnoDestino.Size = New System.Drawing.Size(200, 27)
        Me.CmbTurnoDestino.TabIndex = 11
        Me.CmbTurnoDestino.Text = "Matutino"
        '
        'CmbModalidadDestino
        '
        Me.CmbModalidadDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbModalidadDestino.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidadDestino.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbModalidadDestino.FormattingEnabled = True
        Me.CmbModalidadDestino.Items.AddRange(New Object() {"PRIMARIA REGULAR", "PRIMARIA MULTIGRADO", "SECUNDARIA REGULAR", "SECUNDARIA DIURNA", "SECUNDARIA A DISTANCIA EN EL CAMPO"})
        Me.CmbModalidadDestino.Location = New System.Drawing.Point(238, 117)
        Me.CmbModalidadDestino.Name = "CmbModalidadDestino"
        Me.CmbModalidadDestino.Size = New System.Drawing.Size(200, 27)
        Me.CmbModalidadDestino.TabIndex = 11
        Me.CmbModalidadDestino.Text = "PRIMARIA REGULAR"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label27.Location = New System.Drawing.Point(126, 250)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 18)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Sección:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Location = New System.Drawing.Point(140, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Grado:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label26.Location = New System.Drawing.Point(141, 207)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Turno:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.SlateGray
        Me.Label24.Location = New System.Drawing.Point(124, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(302, 27)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Datos Generales de Matrícula"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(153, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Año:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(54, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Modalidad Destino:"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.LblBuscar_Al_Cambiar)
        Me.Panel8.Controls.Add(Me.ChkBuscar_Al_Cambio)
        Me.Panel8.Controls.Add(Me.BtnBuscarMatriculaTransicion)
        Me.Panel8.Controls.Add(Me.CmbTurnoTransisionM)
        Me.Panel8.Controls.Add(Me.CmbSeccionTransisionM)
        Me.Panel8.Controls.Add(Me.Chkmarcartodos)
        Me.Panel8.Controls.Add(Me.CmbGrado)
        Me.Panel8.Controls.Add(Me.cmbModalidad)
        Me.Panel8.Controls.Add(Me.TxtAño)
        Me.Panel8.Controls.Add(Me.DtMatriculaAnterior)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Location = New System.Drawing.Point(20, 43)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1232, 622)
        Me.Panel8.TabIndex = 1
        '
        'LblBuscar_Al_Cambiar
        '
        Me.LblBuscar_Al_Cambiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBuscar_Al_Cambiar.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar_Al_Cambiar.ForeColor = System.Drawing.Color.DimGray
        Me.LblBuscar_Al_Cambiar.Location = New System.Drawing.Point(1065, 25)
        Me.LblBuscar_Al_Cambiar.Name = "LblBuscar_Al_Cambiar"
        Me.LblBuscar_Al_Cambiar.Size = New System.Drawing.Size(103, 40)
        Me.LblBuscar_Al_Cambiar.TabIndex = 9
        Me.LblBuscar_Al_Cambiar.Text = "Buscar al Hacer Cambios"
        '
        'ChkBuscar_Al_Cambio
        '
        Me.ChkBuscar_Al_Cambio.AutoSize = True
        Me.ChkBuscar_Al_Cambio.EllipseBorderColor = "#7B7B7B"
        Me.ChkBuscar_Al_Cambio.EllipseColor = "#808080"
        Me.ChkBuscar_Al_Cambio.Location = New System.Drawing.Point(1014, 31)
        Me.ChkBuscar_Al_Cambio.Name = "ChkBuscar_Al_Cambio"
        Me.ChkBuscar_Al_Cambio.Size = New System.Drawing.Size(47, 19)
        Me.ChkBuscar_Al_Cambio.TabIndex = 48
        Me.ChkBuscar_Al_Cambio.Text = "UI_MaterialToggle1"
        Me.ChkBuscar_Al_Cambio.UseVisualStyleBackColor = True
        '
        'Chkmarcartodos
        '
        Me.Chkmarcartodos.AutoSize = True
        Me.Chkmarcartodos.Checked = True
        Me.Chkmarcartodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chkmarcartodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chkmarcartodos.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Chkmarcartodos.Location = New System.Drawing.Point(23, 128)
        Me.Chkmarcartodos.Name = "Chkmarcartodos"
        Me.Chkmarcartodos.Size = New System.Drawing.Size(114, 22)
        Me.Chkmarcartodos.TabIndex = 13
        Me.Chkmarcartodos.Text = "Marcar todos"
        Me.Chkmarcartodos.UseVisualStyleBackColor = True
        '
        'CmbGrado
        '
        Me.CmbGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbGrado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbGrado.FormattingEnabled = True
        Me.CmbGrado.Location = New System.Drawing.Point(545, 16)
        Me.CmbGrado.Name = "CmbGrado"
        Me.CmbGrado.Size = New System.Drawing.Size(170, 27)
        Me.CmbGrado.TabIndex = 12
        '
        'cmbModalidad
        '
        Me.cmbModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbModalidad.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModalidad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbModalidad.FormattingEnabled = True
        Me.cmbModalidad.Location = New System.Drawing.Point(218, 16)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Size = New System.Drawing.Size(200, 27)
        Me.cmbModalidad.TabIndex = 11
        '
        'TxtAño
        '
        Me.TxtAño.BaseColour = System.Drawing.Color.White
        Me.TxtAño.BorderColour = System.Drawing.Color.Gray
        Me.TxtAño.ButtonColour = System.Drawing.Color.Gainsboro
        Me.TxtAño.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAño.FontColour = System.Drawing.Color.DodgerBlue
        Me.TxtAño.Location = New System.Drawing.Point(112, 19)
        Me.TxtAño.Maximum = CType(9999999, Long)
        Me.TxtAño.Minimum = CType(0, Long)
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.SecondBorderColour = System.Drawing.Color.DodgerBlue
        Me.TxtAño.SignsColor = System.Drawing.Color.DodgerBlue
        Me.TxtAño.Size = New System.Drawing.Size(95, 24)
        Me.TxtAño.TabIndex = 10
        Me.TxtAño.Text = "UI_Numeric1"
        Me.TxtAño.Value = CType(2021, Long)
        '
        'DtMatriculaAnterior
        '
        Me.DtMatriculaAnterior.AllowUserToAddRows = False
        Me.DtMatriculaAnterior.AllowUserToDeleteRows = False
        Me.DtMatriculaAnterior.AllowUserToOrderColumns = True
        Me.DtMatriculaAnterior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtMatriculaAnterior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtMatriculaAnterior.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChkMarcar})
        Me.DtMatriculaAnterior.ContextMenuStrip = Me.Opciones1
        Me.DtMatriculaAnterior.Location = New System.Drawing.Point(23, 156)
        Me.DtMatriculaAnterior.Name = "DtMatriculaAnterior"
        Me.DtMatriculaAnterior.ReadOnly = True
        Me.DtMatriculaAnterior.Size = New System.Drawing.Size(1187, 446)
        Me.DtMatriculaAnterior.TabIndex = 2
        '
        'ChkMarcar
        '
        Me.ChkMarcar.Frozen = True
        Me.ChkMarcar.HeaderText = "Marcar"
        Me.ChkMarcar.Name = "ChkMarcar"
        Me.ChkMarcar.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(20, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Búsqueda..."
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel10.Controls.Add(Me.Button2)
        Me.Panel10.Controls.Add(Me.BtnMatricular)
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Location = New System.Drawing.Point(23, 68)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1187, 50)
        Me.Panel10.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.Location = New System.Drawing.Point(958, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 42)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BtnMatricular
        '
        Me.BtnMatricular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMatricular.FlatAppearance.BorderSize = 0
        Me.BtnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMatricular.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMatricular.ForeColor = System.Drawing.Color.White
        Me.BtnMatricular.Image = CType(resources.GetObject("BtnMatricular.Image"), System.Drawing.Image)
        Me.BtnMatricular.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnMatricular.Location = New System.Drawing.Point(1072, 6)
        Me.BtnMatricular.Name = "BtnMatricular"
        Me.BtnMatricular.Size = New System.Drawing.Size(104, 42)
        Me.BtnMatricular.TabIndex = 3
        Me.BtnMatricular.Text = "Matricular"
        Me.BtnMatricular.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(316, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Total Registros 0"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel11)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1117, 686)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Listado"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.UI_CustomButton1)
        Me.Panel11.Controls.Add(Me.CmbTurno_Buscar_Listado)
        Me.Panel11.Controls.Add(Me.CmbSeccion_Buscar_Listado)
        Me.Panel11.Controls.Add(Me.BtnCorregirMatricula)
        Me.Panel11.Controls.Add(Me.CmbGrado_Buscar_Listado)
        Me.Panel11.Controls.Add(Me.CmbModalidad_Buscar_Listado)
        Me.Panel11.Controls.Add(Me.TxtAño_Buscar_Listado)
        Me.Panel11.Controls.Add(Me.DtListado_Estudiantes)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Location = New System.Drawing.Point(50, 36)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(931, 549)
        Me.Panel11.TabIndex = 2
        '
        'TxtAño_Buscar_Listado
        '
        Me.TxtAño_Buscar_Listado.BaseColour = System.Drawing.Color.White
        Me.TxtAño_Buscar_Listado.BorderColour = System.Drawing.Color.Gray
        Me.TxtAño_Buscar_Listado.ButtonColour = System.Drawing.Color.Gainsboro
        Me.TxtAño_Buscar_Listado.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAño_Buscar_Listado.FontColour = System.Drawing.Color.DodgerBlue
        Me.TxtAño_Buscar_Listado.Location = New System.Drawing.Point(112, 19)
        Me.TxtAño_Buscar_Listado.Maximum = CType(9999999, Long)
        Me.TxtAño_Buscar_Listado.Minimum = CType(0, Long)
        Me.TxtAño_Buscar_Listado.Name = "TxtAño_Buscar_Listado"
        Me.TxtAño_Buscar_Listado.SecondBorderColour = System.Drawing.Color.DodgerBlue
        Me.TxtAño_Buscar_Listado.SignsColor = System.Drawing.Color.DodgerBlue
        Me.TxtAño_Buscar_Listado.Size = New System.Drawing.Size(115, 24)
        Me.TxtAño_Buscar_Listado.TabIndex = 10
        Me.TxtAño_Buscar_Listado.Text = "UI_Numeric1"
        Me.TxtAño_Buscar_Listado.Value = CType(2021, Long)
        '
        'DtListado_Estudiantes
        '
        Me.DtListado_Estudiantes.AllowUserToAddRows = False
        Me.DtListado_Estudiantes.AllowUserToDeleteRows = False
        Me.DtListado_Estudiantes.AllowUserToOrderColumns = True
        Me.DtListado_Estudiantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtListado_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtListado_Estudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.DtListado_Estudiantes.ContextMenuStrip = Me.Opciones1
        Me.DtListado_Estudiantes.Location = New System.Drawing.Point(23, 156)
        Me.DtListado_Estudiantes.Name = "DtListado_Estudiantes"
        Me.DtListado_Estudiantes.ReadOnly = True
        Me.DtListado_Estudiantes.Size = New System.Drawing.Size(886, 373)
        Me.DtListado_Estudiantes.TabIndex = 2
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.Frozen = True
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label28.Location = New System.Drawing.Point(20, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Búsqueda..."
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel13.Controls.Add(Me.Button4)
        Me.Panel13.Controls.Add(Me.Button5)
        Me.Panel13.Controls.Add(Me.LblTotalListadoEstudiantes)
        Me.Panel13.Location = New System.Drawing.Point(23, 68)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(886, 50)
        Me.Panel13.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.Location = New System.Drawing.Point(657, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Imprimir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button5.Location = New System.Drawing.Point(771, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 42)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Matricular"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'LblTotalListadoEstudiantes
        '
        Me.LblTotalListadoEstudiantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalListadoEstudiantes.AutoSize = True
        Me.LblTotalListadoEstudiantes.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalListadoEstudiantes.ForeColor = System.Drawing.Color.White
        Me.LblTotalListadoEstudiantes.Location = New System.Drawing.Point(15, 20)
        Me.LblTotalListadoEstudiantes.Name = "LblTotalListadoEstudiantes"
        Me.LblTotalListadoEstudiantes.Size = New System.Drawing.Size(112, 17)
        Me.LblTotalListadoEstudiantes.TabIndex = 5
        Me.LblTotalListadoEstudiantes.Text = "Total Registros 0"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.AutoSize = True
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.BtnCerrar.Location = New System.Drawing.Point(1251, 20)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 29)
        Me.BtnCerrar.TabIndex = 31
        Me.BtnCerrar.Text = " "
        Me.BtnCerrar.UseVisualStyleBackColor = False
        Me.BtnCerrar.Visible = False
        '
        'FrmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 749)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAlumnos"
        Me.Text = ".:. Alumnos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnLote.ResumeLayout(False)
        Me.PnLote.PerformLayout()
        CType(Me.DtDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Opciones1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PnMatricula.ResumeLayout(False)
        Me.pntitulo.ResumeLayout(False)
        Me.pntitulo.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.PnMatriculaNormal.ResumeLayout(False)
        Me.PnMatriculaNormal.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnMatricula_Lotes.ResumeLayout(False)
        Me.PnMatricula_Lotes.PerformLayout()
        CType(Me.Load, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtListadoMatricula_Lotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnMejorAlumno.ResumeLayout(False)
        CType(Me.DtExcelenciaAcademica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.PnMatricularSeleccion.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtMatricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpciondeMatricula.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.PnOpcionesMatricula.ResumeLayout(False)
        Me.PnOpcionesMatricula.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DtMatriculaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.DtListado_Estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TTMensaje As ToolTip
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdAlumno As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents chkEliminar As CheckBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents Lbltitulo As Label
    Friend WithEvents EpError As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtBusquedaNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtCodigoMined As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblTituloEdicion As Label
    Friend WithEvents TxtBusquedaApellidos As TextBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents DtNacimiento As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DtMatricula As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Opciones1 As ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MatricularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnLote As Panel
    Friend WithEvents ChkMatricular As CheckBox
    Friend WithEvents DtDatos As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ChkLote As CheckBox
    Friend WithEvents LblTotallote As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents PnMatricula_Lotes As Panel
    Friend WithEvents LblRegistros As Label
    Friend WithEvents DtListadoMatricula_Lotes As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCargarMatriculaLotes As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnEditarMatricula As Button
    Friend WithEvents PnMatriculaNormal As Panel
    Friend WithEvents CmbGrado_Matricular As ComboBox
    Friend WithEvents CmbModalidadMatricular As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LblTituloMatricula As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtIdAlumnoMatricula As TextBox
    Friend WithEvents BtnCancelarMatricula As Button
    Friend WithEvents BtnGuardarMatricula As Button
    Friend WithEvents OpciondeMatricula As ContextMenuStrip
    Friend WithEvents EditarMatrículaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PnMatricula As FlowLayoutPanel
    Friend WithEvents pntitulo As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents ChkLotesMatricula As CheckBox
    Friend WithEvents BtnNuevaMatricula As Button
    Friend WithEvents Panel9 As Panel
#Disable Warning BC40004 ' WithEvents variable 'Load' entra en conflicto con event 'Load' en la base class 'Form' y se debe declarar como 'Shadows'.
    Friend WithEvents Load As PictureBox
#Enable Warning BC40004 ' WithEvents variable 'Load' entra en conflicto con event 'Load' en la base class 'Form' y se debe declarar como 'Shadows'.
    Friend WithEvents SuspenderMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaurarMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmbSeccion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TxtAño As UIDC.UI_Numeric
    Friend WithEvents DtMatriculaAnterior As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnMatricular As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents cmbModalidad As ComboBox
    Friend WithEvents Chkmarcartodos As CheckBox
    Friend WithEvents ChkMarcar As DataGridViewCheckBoxColumn
    Friend WithEvents PnOpcionesMatricula As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents CmbSeccionDestino As ComboBox
    Friend WithEvents CmbGradoDestino As ComboBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents CmbTurnoDestino As ComboBox
    Friend WithEvents CmbModalidadDestino As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CmbGrado_Buscar_Listado As ComboBox
    Friend WithEvents CmbModalidad_Buscar_Listado As ComboBox
    Friend WithEvents TxtAño_Buscar_Listado As UIDC.UI_Numeric
    Friend WithEvents DtListado_Estudiantes As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents LblTotalListadoEstudiantes As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents BtnCorregirMatricula As Button
    Friend WithEvents MatricularToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnMatricularSeleccion As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents CmbSn As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CmbTn As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents CmbGd As ComboBox
    Friend WithEvents CmbMd As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents txtAñoMatricula As UIDC.UI_Numeric
    Friend WithEvents PnMejorAlumno As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents DtExcelenciaAcademica As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents BtnFiltrar As UIDC.UI_CustomButton
    Friend WithEvents Panel17 As Panel
    Friend WithEvents CmbETurno As ComboBox
    Friend WithEvents CmbESeccion As ComboBox
    Friend WithEvents CmbEGrado As ComboBox
    Friend WithEvents CmbEModalidad As ComboBox
    Friend WithEvents Anio As UIDC.UI_Numeric
    Friend WithEvents Label9 As Label
    Friend WithEvents Opcion As ComboBox
    Friend WithEvents CmbECorte As ComboBox
    Friend WithEvents lblcontador As Label
    Friend WithEvents OpcionesDeEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnExportar As UIDC.UI_CustomButton
    Friend WithEvents BtnM_Inicial As UIDC.UI_CustomButton
    Friend WithEvents ChkRegistrar As CheckBox
    Friend WithEvents BtnBuscarMatriculaTransicion As UIDC.UI_CustomButton
    Friend WithEvents CmbTurnoTransisionM As ComboBox
    Friend WithEvents CmbSeccionTransisionM As ComboBox
    Friend WithEvents LblBuscar_Al_Cambiar As Label
    Friend WithEvents ChkBuscar_Al_Cambio As UIDC.UI_MaterialToggle
    Friend WithEvents TxtAñoMatricular As UIDC.UI_MaterialTextBox
    Friend WithEvents CmbTurno_Buscar_Listado As ComboBox
    Friend WithEvents CmbSeccion_Buscar_Listado As ComboBox
    Friend WithEvents UI_CustomButton1 As UIDC.UI_CustomButton
End Class
