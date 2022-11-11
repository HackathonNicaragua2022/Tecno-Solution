<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRendimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRendimiento))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Ra_Primaria_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrincipal = New Ctrl_Estudiantil.DsPrincipal()
        Me.Ra_Secundaria_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnInforme = New UIDC.UI_CustomButton()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.UI_CustomButton2 = New UIDC.UI_CustomButton()
        Me.UI_CustomButton1 = New UIDC.UI_CustomButton()
        Me.CmbModalidad = New System.Windows.Forms.ComboBox()
        Me.CmbCorte = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RptSecundaria = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RptPrimaria = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Ra_Primaria_2TableAdapter = New Ctrl_Estudiantil.DsPrincipalTableAdapters.Ra_Primaria_2TableAdapter()
        Me.Ra_Secundaria_2TableAdapter = New Ctrl_Estudiantil.DsPrincipalTableAdapters.Ra_Secundaria_2TableAdapter()
        CType(Me.Ra_Primaria_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ra_Secundaria_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ra_Primaria_2BindingSource
        '
        Me.Ra_Primaria_2BindingSource.DataMember = "Ra_Primaria_2"
        Me.Ra_Primaria_2BindingSource.DataSource = Me.DsPrincipal
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "DsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ra_Secundaria_2BindingSource
        '
        Me.Ra_Secundaria_2BindingSource.DataMember = "Ra_Secundaria_2"
        Me.Ra_Secundaria_2BindingSource.DataSource = Me.DsPrincipal
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnInforme)
        Me.Panel1.Controls.Add(Me.CmbTurno)
        Me.Panel1.Controls.Add(Me.UI_CustomButton2)
        Me.Panel1.Controls.Add(Me.UI_CustomButton1)
        Me.Panel1.Controls.Add(Me.CmbModalidad)
        Me.Panel1.Controls.Add(Me.CmbCorte)
        Me.Panel1.Controls.Add(Me.TxtAño)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 77)
        Me.Panel1.TabIndex = 1
        '
        'BtnInforme
        '
        Me.BtnInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInforme.BackgroundColor = System.Drawing.Color.Transparent
        Me.BtnInforme.ButtonImage = CType(resources.GetObject("BtnInforme.ButtonImage"), System.Drawing.Image)
        Me.BtnInforme.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnInforme.ButtonText = "Generar Informe"
        Me.BtnInforme.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnInforme.ClickTextColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnInforme.CornerRadius = 5
        Me.BtnInforme.Font = New System.Drawing.Font("Roboto Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInforme.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnInforme.HoverBackgroundColor = System.Drawing.Color.Green
        Me.BtnInforme.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BtnInforme.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnInforme.Location = New System.Drawing.Point(756, 12)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Size = New System.Drawing.Size(157, 50)
        Me.BtnInforme.TabIndex = 67
        Me.BtnInforme.Text = "Generar Informe"
        Me.BtnInforme.TextColor = System.Drawing.Color.CadetBlue
        Me.BtnInforme.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'CmbTurno
        '
        Me.CmbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.Location = New System.Drawing.Point(367, 24)
        Me.CmbTurno.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(122, 28)
        Me.CmbTurno.TabIndex = 70
        '
        'UI_CustomButton2
        '
        Me.UI_CustomButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_CustomButton2.BackgroundColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton2.ButtonImage = CType(resources.GetObject("UI_CustomButton2.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton2.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton2.ButtonText = ""
        Me.UI_CustomButton2.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_CustomButton2.ClickTextColor = System.Drawing.Color.DeepSkyBlue
        Me.UI_CustomButton2.CornerRadius = 5
        Me.UI_CustomButton2.Font = New System.Drawing.Font("Roboto Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton2.HoverBackgroundColor = System.Drawing.Color.Green
        Me.UI_CustomButton2.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton2.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton2.Location = New System.Drawing.Point(736, 12)
        Me.UI_CustomButton2.Name = "UI_CustomButton2"
        Me.UI_CustomButton2.Size = New System.Drawing.Size(60, 50)
        Me.UI_CustomButton2.TabIndex = 69
        Me.UI_CustomButton2.Text = "Generar Informe"
        Me.UI_CustomButton2.TextColor = System.Drawing.Color.CadetBlue
        Me.UI_CustomButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton2.Visible = False
        '
        'UI_CustomButton1
        '
        Me.UI_CustomButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_CustomButton1.BackgroundColor = System.Drawing.Color.Transparent
        Me.UI_CustomButton1.ButtonImage = CType(resources.GetObject("UI_CustomButton1.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton1.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton1.ButtonText = "Informe Secundaria"
        Me.UI_CustomButton1.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_CustomButton1.ClickTextColor = System.Drawing.Color.DeepSkyBlue
        Me.UI_CustomButton1.CornerRadius = 5
        Me.UI_CustomButton1.Font = New System.Drawing.Font("Roboto Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton1.HoverBackgroundColor = System.Drawing.Color.Green
        Me.UI_CustomButton1.HoverTextColor = System.Drawing.Color.DodgerBlue
        Me.UI_CustomButton1.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton1.Location = New System.Drawing.Point(688, 12)
        Me.UI_CustomButton1.Name = "UI_CustomButton1"
        Me.UI_CustomButton1.Size = New System.Drawing.Size(46, 50)
        Me.UI_CustomButton1.TabIndex = 68
        Me.UI_CustomButton1.Text = "Generar Informe"
        Me.UI_CustomButton1.TextColor = System.Drawing.Color.CadetBlue
        Me.UI_CustomButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton1.Visible = False
        '
        'CmbModalidad
        '
        Me.CmbModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModalidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbModalidad.FormattingEnabled = True
        Me.CmbModalidad.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA MULTIGRADO" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA DIURNA" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidad.Location = New System.Drawing.Point(107, 24)
        Me.CmbModalidad.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.CmbModalidad.Name = "CmbModalidad"
        Me.CmbModalidad.Size = New System.Drawing.Size(244, 28)
        Me.CmbModalidad.TabIndex = 64
        Me.CmbModalidad.Text = "PRIMARIA REGULAR"
        '
        'CmbCorte
        '
        Me.CmbCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCorte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CmbCorte.FormattingEnabled = True
        Me.CmbCorte.Location = New System.Drawing.Point(504, 24)
        Me.CmbCorte.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.CmbCorte.Name = "CmbCorte"
        Me.CmbCorte.Size = New System.Drawing.Size(122, 28)
        Me.CmbCorte.TabIndex = 66
        '
        'TxtAño
        '
        Me.TxtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAño.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtAño.Location = New System.Drawing.Point(15, 24)
        Me.TxtAño.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TxtAño.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.TxtAño.Minimum = New Decimal(New Integer() {2021, 0, 0, 0})
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(80, 27)
        Me.TxtAño.TabIndex = 65
        Me.TxtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAño.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.RptSecundaria)
        Me.Panel2.Controls.Add(Me.RptPrimaria)
        Me.Panel2.Location = New System.Drawing.Point(12, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 421)
        Me.Panel2.TabIndex = 3
        '
        'RptSecundaria
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Ra_Secundaria_2BindingSource
        Me.RptSecundaria.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptSecundaria.LocalReport.ReportEmbeddedResource = "Ctrl_Estudiantil.Ra_Secundaria_2.rdlc"
        Me.RptSecundaria.Location = New System.Drawing.Point(243, 20)
        Me.RptSecundaria.Name = "RptSecundaria"
        Me.RptSecundaria.ServerReport.BearerToken = Nothing
        Me.RptSecundaria.Size = New System.Drawing.Size(215, 144)
        Me.RptSecundaria.TabIndex = 1
        Me.RptSecundaria.Visible = False
        Me.RptSecundaria.WaitControlDisplayAfter = 3000
        '
        'RptPrimaria
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Ra_Primaria_2BindingSource
        Me.RptPrimaria.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptPrimaria.LocalReport.ReportEmbeddedResource = "Ctrl_Estudiantil.Ra_Primaria_2.rdlc"
        Me.RptPrimaria.Location = New System.Drawing.Point(22, 20)
        Me.RptPrimaria.Name = "RptPrimaria"
        Me.RptPrimaria.ServerReport.BearerToken = Nothing
        Me.RptPrimaria.Size = New System.Drawing.Size(215, 144)
        Me.RptPrimaria.TabIndex = 0
        Me.RptPrimaria.Visible = False
        Me.RptPrimaria.WaitControlDisplayAfter = 3000
        '
        'Ra_Primaria_2TableAdapter
        '
        Me.Ra_Primaria_2TableAdapter.ClearBeforeFill = True
        '
        'Ra_Secundaria_2TableAdapter
        '
        Me.Ra_Secundaria_2TableAdapter.ClearBeforeFill = True
        '
        'frmRendimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRendimiento"
        Me.Text = "frmRendimiento"
        CType(Me.Ra_Primaria_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ra_Secundaria_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TxtAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmbModalidad As ComboBox
    Friend WithEvents CmbCorte As ComboBox
    Friend WithEvents TxtAño As NumericUpDown
    Friend WithEvents BtnInforme As UIDC.UI_CustomButton
    Friend WithEvents Sp_MostrarNota_Tercero_A_SextoBindingSource As BindingSource
    'Friend WithEvents Sp_Rendimiento_SecundariaBindingSource As BindingSource
    'Friend WithEvents Sp_Rendimiento_SecundariaTableAdapter As DsPrincipalTableAdapters.Rendimiento_SecundariaTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UI_CustomButton1 As UIDC.UI_CustomButton
    Friend WithEvents UI_CustomButton2 As UIDC.UI_CustomButton
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents RptPrimaria As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RptSecundaria As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Ra_Primaria_2BindingSource As BindingSource
    Friend WithEvents DsPrincipal As DsPrincipal
    Friend WithEvents Ra_Primaria_2TableAdapter As DsPrincipalTableAdapters.Ra_Primaria_2TableAdapter
    Friend WithEvents Ra_Secundaria_2BindingSource As BindingSource
    Friend WithEvents Ra_Secundaria_2TableAdapter As DsPrincipalTableAdapters.Ra_Secundaria_2TableAdapter
End Class
