<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas_Preescolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotas_Preescolar))
        Me.UI_TabControl1 = New UIDC.UI_TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UI_ShadowPanel3 = New UIDC.UI_ShadowPanel()
        Me.UI_ShadowPanel2 = New UIDC.UI_ShadowPanel()
        Me.DtAlumnos = New System.Windows.Forms.DataGridView()
        Me.LblTotalRegistros = New System.Windows.Forms.Label()
        Me.UI_MaterialToggle1 = New UIDC.UI_MaterialToggle()
        Me.UI_ShadowPanel1 = New UIDC.UI_ShadowPanel()
        Me.TxtBusqueda = New UIDC.UI_RadioTextBox()
        Me.CmbNivel = New UIDC.UI_ComboBox()
        Me.txtyear = New UIDC.UI_Numeric()
        Me.CmbSeccion = New UIDC.UI_ComboBox()
        Me.CmbTurno = New UIDC.UI_ComboBox()
        Me.CmbModalidad = New UIDC.UI_ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UI_Separator1 = New UIDC.uI_Separator()
        Me.UI_LabelMaterial9 = New UIDC.UI_LabelMaterial()
        Me.CmbETurno = New System.Windows.Forms.ComboBox()
        Me.CmbESeccion = New System.Windows.Forms.ComboBox()
        Me.CmbEGrado = New System.Windows.Forms.ComboBox()
        Me.CmbEModalidad = New System.Windows.Forms.ComboBox()
        Me.TxtAs = New UIDC.UI_MaterialTextBox()
        Me.TxtF = New UIDC.UI_MaterialTextBox()
        Me.UI_LabelMaterial8 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.TxtAño = New UIDC.UI_MaterialTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.BtnEliminar = New UIDC.UI_CustomButton()
        Me.BtnBuscar = New UIDC.UI_CustomButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.UI_TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.UI_ShadowPanel2.SuspendLayout()
        CType(Me.DtAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_ShadowPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UI_TabControl1
        '
        Me.UI_TabControl1.ActiveColour = System.Drawing.Color.DarkGray
        Me.UI_TabControl1.BackTabColour = System.Drawing.Color.White
        Me.UI_TabControl1.BaseColour = System.Drawing.Color.Gainsboro
        Me.UI_TabControl1.BorderColour = System.Drawing.Color.WhiteSmoke
        Me.UI_TabControl1.BorderSize = 1
        Me.UI_TabControl1.Controls.Add(Me.TabPage1)
        Me.UI_TabControl1.Controls.Add(Me.TabPage2)
        Me.UI_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UI_TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UI_TabControl1.HorizontalLineColour = System.Drawing.Color.Gainsboro
        Me.UI_TabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.UI_TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UI_TabControl1.Name = "UI_TabControl1"
        Me.UI_TabControl1.SelectedIndex = 0
        Me.UI_TabControl1.Size = New System.Drawing.Size(1046, 541)
        Me.UI_TabControl1.TabIndex = 54
        Me.UI_TabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_TabControl1.UpLineColour = System.Drawing.Color.DimGray
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.UI_ShadowPanel3)
        Me.TabPage1.Controls.Add(Me.UI_ShadowPanel2)
        Me.TabPage1.Controls.Add(Me.UI_MaterialToggle1)
        Me.TabPage1.Controls.Add(Me.UI_ShadowPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1038, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'UI_ShadowPanel3
        '
        Me.UI_ShadowPanel3.BaseColor = System.Drawing.Color.White
        Me.UI_ShadowPanel3.Location = New System.Drawing.Point(439, 315)
        Me.UI_ShadowPanel3.Name = "UI_ShadowPanel3"
        Me.UI_ShadowPanel3.ParentControl = Me
        Me.UI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.UI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel3.Size = New System.Drawing.Size(172, 140)
        Me.UI_ShadowPanel3.TabIndex = 60
        '
        'UI_ShadowPanel2
        '
        Me.UI_ShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.UI_ShadowPanel2.Controls.Add(Me.DtAlumnos)
        Me.UI_ShadowPanel2.Controls.Add(Me.LblTotalRegistros)
        Me.UI_ShadowPanel2.Location = New System.Drawing.Point(11, 88)
        Me.UI_ShadowPanel2.Name = "UI_ShadowPanel2"
        Me.UI_ShadowPanel2.ParentControl = Me
        Me.UI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.UI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel2.Size = New System.Drawing.Size(1013, 208)
        Me.UI_ShadowPanel2.TabIndex = 59
        '
        'DtAlumnos
        '
        Me.DtAlumnos.AllowUserToAddRows = False
        Me.DtAlumnos.AllowUserToDeleteRows = False
        Me.DtAlumnos.AllowUserToOrderColumns = True
        Me.DtAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAlumnos.Location = New System.Drawing.Point(12, 15)
        Me.DtAlumnos.Name = "DtAlumnos"
        Me.DtAlumnos.ReadOnly = True
        Me.DtAlumnos.Size = New System.Drawing.Size(985, 162)
        Me.DtAlumnos.TabIndex = 48
        '
        'LblTotalRegistros
        '
        Me.LblTotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalRegistros.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalRegistros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblTotalRegistros.Location = New System.Drawing.Point(788, 180)
        Me.LblTotalRegistros.Name = "LblTotalRegistros"
        Me.LblTotalRegistros.Size = New System.Drawing.Size(209, 19)
        Me.LblTotalRegistros.TabIndex = 50
        Me.LblTotalRegistros.Text = "Registros en total"
        Me.LblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UI_MaterialToggle1
        '
        Me.UI_MaterialToggle1.AutoSize = True
        Me.UI_MaterialToggle1.Checked = True
        Me.UI_MaterialToggle1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UI_MaterialToggle1.EllipseBorderColor = "#7B7B7B"
        Me.UI_MaterialToggle1.EllipseColor = "#808080"
        Me.UI_MaterialToggle1.Location = New System.Drawing.Point(971, 78)
        Me.UI_MaterialToggle1.Name = "UI_MaterialToggle1"
        Me.UI_MaterialToggle1.Size = New System.Drawing.Size(47, 19)
        Me.UI_MaterialToggle1.TabIndex = 47
        Me.UI_MaterialToggle1.Text = "UI_MaterialToggle1"
        Me.UI_MaterialToggle1.UseVisualStyleBackColor = True
        Me.UI_MaterialToggle1.Visible = False
        '
        'UI_ShadowPanel1
        '
        Me.UI_ShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.UI_ShadowPanel1.Controls.Add(Me.TxtBusqueda)
        Me.UI_ShadowPanel1.Controls.Add(Me.CmbNivel)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtyear)
        Me.UI_ShadowPanel1.Controls.Add(Me.CmbSeccion)
        Me.UI_ShadowPanel1.Controls.Add(Me.BtnEliminar)
        Me.UI_ShadowPanel1.Controls.Add(Me.CmbTurno)
        Me.UI_ShadowPanel1.Controls.Add(Me.BtnBuscar)
        Me.UI_ShadowPanel1.Controls.Add(Me.CmbModalidad)
        Me.UI_ShadowPanel1.Location = New System.Drawing.Point(12, 6)
        Me.UI_ShadowPanel1.Name = "UI_ShadowPanel1"
        Me.UI_ShadowPanel1.ParentControl = Me
        Me.UI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.UI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel1.Size = New System.Drawing.Size(1012, 66)
        Me.UI_ShadowPanel1.TabIndex = 58
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.TxtBusqueda.BackgroundColour = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.Borde = False
        Me.TxtBusqueda.BorderColour = System.Drawing.Color.DodgerBlue
        Me.TxtBusqueda.BorderSize = 1
        Me.TxtBusqueda.Location = New System.Drawing.Point(45, 19)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtBusqueda.MaxLength = 32767
        Me.TxtBusqueda.Multiline = False
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.TxtBusqueda.Radio = 12
        Me.TxtBusqueda.ReadOnly = False
        Me.TxtBusqueda.Size = New System.Drawing.Size(230, 29)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBusqueda.TextColour = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBusqueda.UseSystemPasswordChar = False
        '
        'CmbNivel
        '
        Me.CmbNivel.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.CmbNivel.BackColor = System.Drawing.Color.Transparent
        Me.CmbNivel.BaseColour = System.Drawing.Color.White
        Me.CmbNivel.BorderColour = System.Drawing.Color.Gray
        Me.CmbNivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNivel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbNivel.FontColour = System.Drawing.Color.Black
        Me.CmbNivel.FormattingEnabled = True
        Me.CmbNivel.LineColour = System.Drawing.Color.DodgerBlue
        Me.CmbNivel.Location = New System.Drawing.Point(719, 22)
        Me.CmbNivel.Name = "CmbNivel"
        Me.CmbNivel.Size = New System.Drawing.Size(65, 26)
        Me.CmbNivel.SqaureColour = System.Drawing.Color.Gainsboro
        Me.CmbNivel.SqaureHoverColour = System.Drawing.Color.Gray
        Me.CmbNivel.StartIndex = 0
        Me.CmbNivel.TabIndex = 57
        '
        'txtyear
        '
        Me.txtyear.BaseColour = System.Drawing.Color.White
        Me.txtyear.BorderColour = System.Drawing.Color.Gray
        Me.txtyear.ButtonColour = System.Drawing.Color.Gainsboro
        Me.txtyear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtyear.FontColour = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtyear.Location = New System.Drawing.Point(312, 22)
        Me.txtyear.Maximum = CType(9999999, Long)
        Me.txtyear.Minimum = CType(0, Long)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.SecondBorderColour = System.Drawing.Color.Gray
        Me.txtyear.SignsColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtyear.Size = New System.Drawing.Size(93, 24)
        Me.txtyear.TabIndex = 49
        Me.txtyear.Text = "UI_Numeric1"
        Me.txtyear.Value = CType(2022, Long)
        Me.txtyear.Visible = False
        '
        'CmbSeccion
        '
        Me.CmbSeccion.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.CmbSeccion.BackColor = System.Drawing.Color.Transparent
        Me.CmbSeccion.BaseColour = System.Drawing.Color.White
        Me.CmbSeccion.BorderColour = System.Drawing.Color.Gray
        Me.CmbSeccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSeccion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbSeccion.FontColour = System.Drawing.Color.Black
        Me.CmbSeccion.FormattingEnabled = True
        Me.CmbSeccion.LineColour = System.Drawing.Color.DodgerBlue
        Me.CmbSeccion.Location = New System.Drawing.Point(791, 22)
        Me.CmbSeccion.Name = "CmbSeccion"
        Me.CmbSeccion.Size = New System.Drawing.Size(65, 26)
        Me.CmbSeccion.SqaureColour = System.Drawing.Color.Gainsboro
        Me.CmbSeccion.SqaureHoverColour = System.Drawing.Color.Gray
        Me.CmbSeccion.StartIndex = 0
        Me.CmbSeccion.TabIndex = 56
        '
        'CmbTurno
        '
        Me.CmbTurno.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.CmbTurno.BackColor = System.Drawing.Color.Transparent
        Me.CmbTurno.BaseColour = System.Drawing.Color.White
        Me.CmbTurno.BorderColour = System.Drawing.Color.Gray
        Me.CmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTurno.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbTurno.FontColour = System.Drawing.Color.Black
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.LineColour = System.Drawing.Color.DodgerBlue
        Me.CmbTurno.Location = New System.Drawing.Point(582, 22)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(131, 26)
        Me.CmbTurno.SqaureColour = System.Drawing.Color.Gainsboro
        Me.CmbTurno.SqaureHoverColour = System.Drawing.Color.Gray
        Me.CmbTurno.StartIndex = 0
        Me.CmbTurno.TabIndex = 55
        '
        'CmbModalidad
        '
        Me.CmbModalidad.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.CmbModalidad.BackColor = System.Drawing.Color.Transparent
        Me.CmbModalidad.BaseColour = System.Drawing.Color.White
        Me.CmbModalidad.BorderColour = System.Drawing.Color.Gray
        Me.CmbModalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbModalidad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbModalidad.FontColour = System.Drawing.Color.Black
        Me.CmbModalidad.FormattingEnabled = True
        Me.CmbModalidad.LineColour = System.Drawing.Color.DodgerBlue
        Me.CmbModalidad.Location = New System.Drawing.Point(427, 22)
        Me.CmbModalidad.Name = "CmbModalidad"
        Me.CmbModalidad.Size = New System.Drawing.Size(149, 26)
        Me.CmbModalidad.SqaureColour = System.Drawing.Color.Gainsboro
        Me.CmbModalidad.SqaureHoverColour = System.Drawing.Color.Gray
        Me.CmbModalidad.StartIndex = 0
        Me.CmbModalidad.TabIndex = 54
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "tab1"
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.UI_Separator1)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial9)
        Me.TabPage2.Controls.Add(Me.CmbETurno)
        Me.TabPage2.Controls.Add(Me.CmbESeccion)
        Me.TabPage2.Controls.Add(Me.CmbEGrado)
        Me.TabPage2.Controls.Add(Me.CmbEModalidad)
        Me.TabPage2.Controls.Add(Me.TxtAs)
        Me.TabPage2.Controls.Add(Me.TxtF)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial8)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial5)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial6)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial7)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial4)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial3)
        Me.TabPage2.Controls.Add(Me.TxtAño)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial2)
        Me.TabPage2.Controls.Add(Me.UI_LabelMaterial1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.BtnNuevo)
        Me.TabPage2.Controls.Add(Me.BtnEditar)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1038, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edicion"
        '
        'UI_Separator1
        '
        Me.UI_Separator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_Separator1.BackColor = System.Drawing.Color.Transparent
        Me.UI_Separator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.UI_Separator1.LineSize = 2
        Me.UI_Separator1.Location = New System.Drawing.Point(218, 92)
        Me.UI_Separator1.Name = "UI_Separator1"
        Me.UI_Separator1.Size = New System.Drawing.Size(369, 18)
        Me.UI_Separator1.TabIndex = 72
        Me.UI_Separator1.Transparency = 100
        Me.UI_Separator1.Vertical = False
        '
        'UI_LabelMaterial9
        '
        Me.UI_LabelMaterial9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial9.AutoSize = True
        Me.UI_LabelMaterial9.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial9.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial9.Location = New System.Drawing.Point(172, 300)
        Me.UI_LabelMaterial9.Name = "UI_LabelMaterial9"
        Me.UI_LabelMaterial9.Size = New System.Drawing.Size(73, 17)
        Me.UI_LabelMaterial9.TabIndex = 66
        Me.UI_LabelMaterial9.Text = "Matrícula:"
        '
        'CmbETurno
        '
        Me.CmbETurno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbETurno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmbETurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbETurno.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbETurno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbETurno.FormattingEnabled = True
        Me.CmbETurno.Location = New System.Drawing.Point(290, 188)
        Me.CmbETurno.Name = "CmbETurno"
        Me.CmbETurno.Size = New System.Drawing.Size(300, 27)
        Me.CmbETurno.TabIndex = 55
        '
        'CmbESeccion
        '
        Me.CmbESeccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbESeccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmbESeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbESeccion.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbESeccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbESeccion.FormattingEnabled = True
        Me.CmbESeccion.Location = New System.Drawing.Point(290, 259)
        Me.CmbESeccion.Name = "CmbESeccion"
        Me.CmbESeccion.Size = New System.Drawing.Size(300, 27)
        Me.CmbESeccion.TabIndex = 57
        '
        'CmbEGrado
        '
        Me.CmbEGrado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbEGrado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmbEGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbEGrado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEGrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbEGrado.FormattingEnabled = True
        Me.CmbEGrado.Location = New System.Drawing.Point(290, 223)
        Me.CmbEGrado.Name = "CmbEGrado"
        Me.CmbEGrado.Size = New System.Drawing.Size(300, 27)
        Me.CmbEGrado.TabIndex = 56
        '
        'CmbEModalidad
        '
        Me.CmbEModalidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbEModalidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmbEModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbEModalidad.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEModalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbEModalidad.FormattingEnabled = True
        Me.CmbEModalidad.Location = New System.Drawing.Point(290, 151)
        Me.CmbEModalidad.Name = "CmbEModalidad"
        Me.CmbEModalidad.Size = New System.Drawing.Size(300, 27)
        Me.CmbEModalidad.TabIndex = 54
        '
        'TxtAs
        '
        Me.TxtAs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAs.BackColor = System.Drawing.Color.White
        Me.TxtAs.FocusedColor = "#508ef5"
        Me.TxtAs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtAs.IsEnabled = True
        Me.TxtAs.Location = New System.Drawing.Point(322, 293)
        Me.TxtAs.MaxLength = 32767
        Me.TxtAs.Name = "TxtAs"
        Me.TxtAs.Size = New System.Drawing.Size(112, 24)
        Me.TxtAs.TabIndex = 58
        Me.TxtAs.Text = "0"
        Me.TxtAs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtAs.UIFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtAs.UIFontColor = "#999999"
        Me.TxtAs.UIMultiline = False
        Me.TxtAs.UIReadOnly = False
        Me.TxtAs.UseSystemPasswordChar = False
        Me.TxtAs.ValidateMessageText = "Solo se aceptan números"
        Me.TxtAs.ValidateMessageTitle = "Validación"
        Me.TxtAs.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Numeric
        '
        'TxtF
        '
        Me.TxtF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtF.BackColor = System.Drawing.Color.White
        Me.TxtF.FocusedColor = "#508ef5"
        Me.TxtF.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtF.IsEnabled = True
        Me.TxtF.Location = New System.Drawing.Point(466, 293)
        Me.TxtF.MaxLength = 32767
        Me.TxtF.Name = "TxtF"
        Me.TxtF.Size = New System.Drawing.Size(124, 24)
        Me.TxtF.TabIndex = 59
        Me.TxtF.Text = "0"
        Me.TxtF.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtF.UIFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtF.UIFontColor = "#999999"
        Me.TxtF.UIMultiline = False
        Me.TxtF.UIReadOnly = False
        Me.TxtF.UseSystemPasswordChar = False
        Me.TxtF.ValidateMessageText = "Solo se aceptan números"
        Me.TxtF.ValidateMessageTitle = "Validación"
        Me.TxtF.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Numeric
        '
        'UI_LabelMaterial8
        '
        Me.UI_LabelMaterial8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial8.AutoSize = True
        Me.UI_LabelMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial8.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial8.Location = New System.Drawing.Point(440, 300)
        Me.UI_LabelMaterial8.Name = "UI_LabelMaterial8"
        Me.UI_LabelMaterial8.Size = New System.Drawing.Size(20, 17)
        Me.UI_LabelMaterial8.TabIndex = 59
        Me.UI_LabelMaterial8.Text = "F:"
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(287, 300)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(29, 17)
        Me.UI_LabelMaterial5.TabIndex = 58
        Me.UI_LabelMaterial5.Text = "AS:"
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(168, 262)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(62, 17)
        Me.UI_LabelMaterial6.TabIndex = 57
        Me.UI_LabelMaterial6.Text = "Sección:"
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(168, 194)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(50, 17)
        Me.UI_LabelMaterial7.TabIndex = 56
        Me.UI_LabelMaterial7.Text = "Turno:"
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Roboto Medium", 14.0!)
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.Gray
        Me.UI_LabelMaterial4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(242, 65)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(242, 23)
        Me.UI_LabelMaterial4.TabIndex = 55
        Me.UI_LabelMaterial4.Text = "Edicion de Matrícula Inicial"
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(168, 160)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(80, 17)
        Me.UI_LabelMaterial3.TabIndex = 54
        Me.UI_LabelMaterial3.Text = "Modalidad:"
        '
        'TxtAño
        '
        Me.TxtAño.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAño.BackColor = System.Drawing.Color.White
        Me.TxtAño.FocusedColor = "#508ef5"
        Me.TxtAño.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtAño.IsEnabled = True
        Me.TxtAño.Location = New System.Drawing.Point(290, 123)
        Me.TxtAño.MaxLength = 32767
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(300, 24)
        Me.TxtAño.TabIndex = 53
        Me.TxtAño.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtAño.UIFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtAño.UIFontColor = "#999999"
        Me.TxtAño.UIMultiline = False
        Me.TxtAño.UIReadOnly = False
        Me.TxtAño.UseSystemPasswordChar = False
        Me.TxtAño.ValidateMessageText = "Solo se aceptan números"
        Me.TxtAño.ValidateMessageTitle = "Validación"
        Me.TxtAño.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Numeric
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(168, 226)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(51, 17)
        Me.UI_LabelMaterial2.TabIndex = 52
        Me.UI_LabelMaterial2.Text = "Grado:"
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(168, 130)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(37, 17)
        Me.UI_LabelMaterial1.TabIndex = 50
        Me.UI_LabelMaterial1.Text = "Año:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackgroundColor = System.Drawing.Color.White
        Me.BtnEliminar.ButtonImage = CType(resources.GetObject("BtnEliminar.ButtonImage"), System.Drawing.Image)
        Me.BtnEliminar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnEliminar.ButtonText = "Eliminar"
        Me.BtnEliminar.ClickBackColor = System.Drawing.Color.LightGray
        Me.BtnEliminar.ClickTextColor = System.Drawing.Color.Black
        Me.BtnEliminar.CornerRadius = 5
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnEliminar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnEliminar.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEliminar.HoverTextColor = System.Drawing.Color.DimGray
        Me.BtnEliminar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnEliminar.Location = New System.Drawing.Point(880, 15)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 43)
        Me.BtnEliminar.TabIndex = 51
        Me.BtnEliminar.Text = "UI_CustomButton1"
        Me.BtnEliminar.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEliminar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundColor = System.Drawing.Color.White
        Me.BtnBuscar.ButtonImage = Global.Ctrl_Estudiantil.My.Resources.Resources.lupa
        Me.BtnBuscar.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnBuscar.ButtonText = ""
        Me.BtnBuscar.ClickBackColor = System.Drawing.Color.Black
        Me.BtnBuscar.ClickTextColor = System.Drawing.Color.Black
        Me.BtnBuscar.CornerRadius = 5
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBuscar.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnBuscar.HoverBackgroundColor = System.Drawing.Color.Black
        Me.BtnBuscar.HoverTextColor = System.Drawing.Color.White
        Me.BtnBuscar.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnBuscar.Location = New System.Drawing.Point(11, 19)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 29)
        Me.BtnBuscar.TabIndex = 53
        Me.BtnBuscar.Text = "UI_CustomButton1"
        Me.BtnBuscar.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBuscar.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(168, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(177, 361)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(89, 36)
        Me.BtnNuevo.TabIndex = 71
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(383, 361)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(87, 36)
        Me.BtnEditar.TabIndex = 70
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(478, 361)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(105, 36)
        Me.BtnCancelar.TabIndex = 61
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(272, 361)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(105, 36)
        Me.BtnGuardar.TabIndex = 60
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'frmNotas_Preescolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 541)
        Me.Controls.Add(Me.UI_TabControl1)
        Me.Name = "frmNotas_Preescolar"
        Me.Text = "frmNotas_Preescolar"
        Me.UI_TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.UI_ShadowPanel2.ResumeLayout(False)
        CType(Me.DtAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_ShadowPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_TabControl1 As UIDC.UI_TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnEliminar As UIDC.UI_CustomButton
    Friend WithEvents LblTotalRegistros As Label
    Friend WithEvents txtyear As UIDC.UI_Numeric
    Friend WithEvents DtAlumnos As DataGridView
    Friend WithEvents UI_MaterialToggle1 As UIDC.UI_MaterialToggle
    Friend WithEvents TxtBusqueda As UIDC.UI_RadioTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UI_Separator1 As UIDC.uI_Separator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents UI_LabelMaterial9 As UIDC.UI_LabelMaterial
    Friend WithEvents CmbETurno As ComboBox
    Friend WithEvents CmbESeccion As ComboBox
    Friend WithEvents CmbEGrado As ComboBox
    Friend WithEvents CmbEModalidad As ComboBox
    Friend WithEvents TxtAs As UIDC.UI_MaterialTextBox
    Friend WithEvents TxtF As UIDC.UI_MaterialTextBox
    Friend WithEvents UI_LabelMaterial8 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents TxtAño As UIDC.UI_MaterialTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents BtnBuscar As UIDC.UI_CustomButton
    Friend WithEvents CmbNivel As UIDC.UI_ComboBox
    Friend WithEvents CmbSeccion As UIDC.UI_ComboBox
    Friend WithEvents CmbTurno As UIDC.UI_ComboBox
    Friend WithEvents CmbModalidad As UIDC.UI_ComboBox
    Friend WithEvents UI_ShadowPanel3 As UIDC.UI_ShadowPanel
    Friend WithEvents UI_ShadowPanel2 As UIDC.UI_ShadowPanel
    Friend WithEvents UI_ShadowPanel1 As UIDC.UI_ShadowPanel
End Class
