<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNotas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotas))
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.CmbModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbCorte = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.NumericUpDown()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.UI_CustomButton1 = New UIDC.UI_CustomButton()
        Me.CmbSeccion = New System.Windows.Forms.ComboBox()
        Me.RptPrimero_Segundo = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsPrincipal = New Ctrl_Estudiantil.DsPrincipal()
        Me.MostrarNota_Primero_SegundoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MostrarNota_Primero_SegundoTableAdapter = New Ctrl_Estudiantil.DsPrincipalTableAdapters.MostrarNota_Primero_SegundoTableAdapter()
        Me.RptTercero_Sexto = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MostrarNota_Tercero_A_SextoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MostrarNota_Tercero_A_SextoTableAdapter = New Ctrl_Estudiantil.DsPrincipalTableAdapters.MostrarNota_Tercero_A_SextoTableAdapter()
        Me.RptSecundaria = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Mostrar_Nota_SecundariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_Nota_SecundariaTableAdapter = New Ctrl_Estudiantil.DsPrincipalTableAdapters.Mostrar_Nota_SecundariaTableAdapter()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarNota_Primero_SegundoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarNota_Tercero_A_SextoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mostrar_Nota_SecundariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbGrado
        '
        Me.CmbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbGrado.FormattingEnabled = True
        Me.CmbGrado.Location = New System.Drawing.Point(424, 15)
        Me.CmbGrado.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbGrado.Name = "CmbGrado"
        Me.CmbGrado.Size = New System.Drawing.Size(138, 28)
        Me.CmbGrado.TabIndex = 63
        '
        'CmbModalidad
        '
        Me.CmbModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbModalidad.FormattingEnabled = True
        Me.CmbModalidad.Location = New System.Drawing.Point(97, 16)
        Me.CmbModalidad.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbModalidad.Name = "CmbModalidad"
        Me.CmbModalidad.Size = New System.Drawing.Size(193, 28)
        Me.CmbModalidad.TabIndex = 64
        Me.CmbModalidad.Text = "PREESCOLAR FORMAL"
        '
        'CmbCorte
        '
        Me.CmbCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCorte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbCorte.FormattingEnabled = True
        Me.CmbCorte.Location = New System.Drawing.Point(606, 15)
        Me.CmbCorte.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbCorte.Name = "CmbCorte"
        Me.CmbCorte.Size = New System.Drawing.Size(122, 28)
        Me.CmbCorte.TabIndex = 66
        '
        'TxtAño
        '
        Me.TxtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAño.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtAño.Location = New System.Drawing.Point(11, 16)
        Me.TxtAño.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TxtAño.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.TxtAño.Minimum = New Decimal(New Integer() {2021, 0, 0, 0})
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(80, 26)
        Me.TxtAño.TabIndex = 65
        Me.TxtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAño.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'Lbltitulo
        '
        Me.Lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Roboto Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbltitulo.Location = New System.Drawing.Point(362, 14)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(275, 33)
        Me.Lbltitulo.TabIndex = 31
        Me.Lbltitulo.Text = ".: Reportes de Notas :."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Lbltitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 5)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.CmbTurno)
        Me.Panel2.Controls.Add(Me.CmbModalidad)
        Me.Panel2.Controls.Add(Me.UI_CustomButton1)
        Me.Panel2.Controls.Add(Me.CmbGrado)
        Me.Panel2.Controls.Add(Me.CmbCorte)
        Me.Panel2.Controls.Add(Me.TxtAño)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1017, 59)
        Me.Panel2.TabIndex = 7
        '
        'CmbTurno
        '
        Me.CmbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.Location = New System.Drawing.Point(296, 15)
        Me.CmbTurno.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(122, 28)
        Me.CmbTurno.TabIndex = 67
        '
        'UI_CustomButton1
        '
        Me.UI_CustomButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_CustomButton1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.UI_CustomButton1.BackgroundColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.ButtonImage = Global.Ctrl_Estudiantil.My.Resources.Resources.business_report
        Me.UI_CustomButton1.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton1.ButtonText = "Generar Reporte"
        Me.UI_CustomButton1.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.UI_CustomButton1.ClickTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.CornerRadius = 5
        Me.UI_CustomButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.UI_CustomButton1.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton1.Location = New System.Drawing.Point(839, 12)
        Me.UI_CustomButton1.Name = "UI_CustomButton1"
        Me.UI_CustomButton1.Size = New System.Drawing.Size(166, 38)
        Me.UI_CustomButton1.TabIndex = 12
        Me.UI_CustomButton1.Text = "UI_CustomButton1"
        Me.UI_CustomButton1.TextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'CmbSeccion
        '
        Me.CmbSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeccion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbSeccion.FormattingEnabled = True
        Me.CmbSeccion.Location = New System.Drawing.Point(568, 15)
        Me.CmbSeccion.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbSeccion.Name = "CmbSeccion"
        Me.CmbSeccion.Size = New System.Drawing.Size(32, 28)
        Me.CmbSeccion.TabIndex = 68
        '
        'RptPrimero_Segundo
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MostrarNota_Primero_SegundoBindingSource
        Me.RptPrimero_Segundo.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptPrimero_Segundo.LocalReport.ReportEmbeddedResource = "Ctrl_Estudiantil.MostrarNotas_1_y_2.rdlc"
        Me.RptPrimero_Segundo.Location = New System.Drawing.Point(31, 122)
        Me.RptPrimero_Segundo.Name = "RptPrimero_Segundo"
        Me.RptPrimero_Segundo.ServerReport.BearerToken = Nothing
        Me.RptPrimero_Segundo.Size = New System.Drawing.Size(121, 80)
        Me.RptPrimero_Segundo.TabIndex = 69
        Me.RptPrimero_Segundo.Visible = False
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "DsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrarNota_Primero_SegundoBindingSource
        '
        Me.MostrarNota_Primero_SegundoBindingSource.DataMember = "MostrarNota_Primero_Segundo"
        Me.MostrarNota_Primero_SegundoBindingSource.DataSource = Me.DsPrincipal
        '
        'MostrarNota_Primero_SegundoTableAdapter
        '
        Me.MostrarNota_Primero_SegundoTableAdapter.ClearBeforeFill = True
        '
        'RptTercero_Sexto
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.MostrarNota_Tercero_A_SextoBindingSource
        Me.RptTercero_Sexto.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptTercero_Sexto.LocalReport.ReportEmbeddedResource = "Ctrl_Estudiantil.MostrarNotas_Tercero_Sexto.rdlc"
        Me.RptTercero_Sexto.Location = New System.Drawing.Point(172, 122)
        Me.RptTercero_Sexto.Name = "RptTercero_Sexto"
        Me.RptTercero_Sexto.ServerReport.BearerToken = Nothing
        Me.RptTercero_Sexto.Size = New System.Drawing.Size(118, 80)
        Me.RptTercero_Sexto.TabIndex = 70
        Me.RptTercero_Sexto.Visible = False
        '
        'MostrarNota_Tercero_A_SextoBindingSource
        '
        Me.MostrarNota_Tercero_A_SextoBindingSource.DataMember = "MostrarNota_Tercero_A_Sexto"
        Me.MostrarNota_Tercero_A_SextoBindingSource.DataSource = Me.DsPrincipal
        '
        'MostrarNota_Tercero_A_SextoTableAdapter
        '
        Me.MostrarNota_Tercero_A_SextoTableAdapter.ClearBeforeFill = True
        '
        'RptSecundaria
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.Mostrar_Nota_SecundariaBindingSource
        Me.RptSecundaria.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RptSecundaria.LocalReport.ReportEmbeddedResource = "Ctrl_Estudiantil.Mostrar_Notas_Secundaria.rdlc"
        Me.RptSecundaria.Location = New System.Drawing.Point(296, 122)
        Me.RptSecundaria.Name = "RptSecundaria"
        Me.RptSecundaria.ServerReport.BearerToken = Nothing
        Me.RptSecundaria.Size = New System.Drawing.Size(149, 80)
        Me.RptSecundaria.TabIndex = 71
        Me.RptSecundaria.Visible = False
        '
        'Mostrar_Nota_SecundariaBindingSource
        '
        Me.Mostrar_Nota_SecundariaBindingSource.DataMember = "Mostrar_Nota_Secundaria"
        Me.Mostrar_Nota_SecundariaBindingSource.DataSource = Me.DsPrincipal
        '
        'Mostrar_Nota_SecundariaTableAdapter
        '
        Me.Mostrar_Nota_SecundariaTableAdapter.ClearBeforeFill = True
        '
        'FrmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 450)
        Me.Controls.Add(Me.RptSecundaria)
        Me.Controls.Add(Me.RptTercero_Sexto)
        Me.Controls.Add(Me.RptPrimero_Segundo)
        Me.Controls.Add(Me.CmbSeccion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNotas"
        Me.Text = "Cuadro de Notas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarNota_Primero_SegundoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarNota_Tercero_A_SextoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mostrar_Nota_SecundariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents CmbModalidad As ComboBox
    Friend WithEvents CmbCorte As ComboBox
    Friend WithEvents TxtAño As NumericUpDown
    Friend WithEvents Lbltitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UI_CustomButton1 As UIDC.UI_CustomButton
    Friend WithEvents CmbSeccion As ComboBox
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents RptPrimero_Segundo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MostrarNota_Primero_SegundoBindingSource As BindingSource
    Friend WithEvents DsPrincipal As DsPrincipal
    Friend WithEvents MostrarNota_Primero_SegundoTableAdapter As DsPrincipalTableAdapters.MostrarNota_Primero_SegundoTableAdapter
    Friend WithEvents RptTercero_Sexto As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MostrarNota_Tercero_A_SextoBindingSource As BindingSource
    Friend WithEvents MostrarNota_Tercero_A_SextoTableAdapter As DsPrincipalTableAdapters.MostrarNota_Tercero_A_SextoTableAdapter
    Friend WithEvents RptSecundaria As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_Nota_SecundariaBindingSource As BindingSource
    Friend WithEvents Mostrar_Nota_SecundariaTableAdapter As DsPrincipalTableAdapters.Mostrar_Nota_SecundariaTableAdapter
End Class
