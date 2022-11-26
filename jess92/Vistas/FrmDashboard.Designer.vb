<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.LblRuta = New System.Windows.Forms.TextBox()
        Me.UI_CustomButton5 = New UIDC.UI_CustomButton()
        Me.UI_CustomButton6 = New UIDC.UI_CustomButton()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PnMatricula_Inicial = New UIDC.UI_ShadowPanel()
        Me.PnMatricula_Actual = New UIDC.UI_ShadowPanel()
        Me.PnRetencion = New UIDC.UI_ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UI_ShadowPanel1 = New UIDC.UI_ShadowPanel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel12.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PnMatricula_Inicial.SuspendLayout()
        Me.PnMatricula_Actual.SuspendLayout()
        Me.PnRetencion.SuspendLayout()
        Me.UI_ShadowPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.LblRuta)
        Me.Panel12.Controls.Add(Me.UI_CustomButton5)
        Me.Panel12.Controls.Add(Me.UI_CustomButton6)
        Me.Panel12.Location = New System.Drawing.Point(0, 10)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(172, 80)
        Me.Panel12.TabIndex = 14
        '
        'LblRuta
        '
        Me.LblRuta.Location = New System.Drawing.Point(177, 12)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(114, 20)
        Me.LblRuta.TabIndex = 39
        '
        'UI_CustomButton5
        '
        Me.UI_CustomButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton5.ButtonImage = CType(resources.GetObject("UI_CustomButton5.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton5.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton5.ButtonText = "Copias de seguridad"
        Me.UI_CustomButton5.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UI_CustomButton5.ClickTextColor = System.Drawing.Color.White
        Me.UI_CustomButton5.CornerRadius = 5
        Me.UI_CustomButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_CustomButton5.HoverTextColor = System.Drawing.Color.Gainsboro
        Me.UI_CustomButton5.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton5.Location = New System.Drawing.Point(7, 7)
        Me.UI_CustomButton5.Name = "UI_CustomButton5"
        Me.UI_CustomButton5.Size = New System.Drawing.Size(153, 29)
        Me.UI_CustomButton5.TabIndex = 6
        Me.UI_CustomButton5.Text = "Inventarios"
        Me.UI_CustomButton5.TextColor = System.Drawing.Color.White
        Me.UI_CustomButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'UI_CustomButton6
        '
        Me.UI_CustomButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton6.ButtonImage = Nothing
        Me.UI_CustomButton6.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton6.ButtonText = "Restaurar Base de datos"
        Me.UI_CustomButton6.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UI_CustomButton6.ClickTextColor = System.Drawing.Color.White
        Me.UI_CustomButton6.CornerRadius = 5
        Me.UI_CustomButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton6.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton6.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_CustomButton6.HoverTextColor = System.Drawing.Color.Gainsboro
        Me.UI_CustomButton6.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton6.Location = New System.Drawing.Point(7, 44)
        Me.UI_CustomButton6.Name = "UI_CustomButton6"
        Me.UI_CustomButton6.Size = New System.Drawing.Size(153, 29)
        Me.UI_CustomButton6.TabIndex = 7
        Me.UI_CustomButton6.Text = "Restaurar Base de datos"
        Me.UI_CustomButton6.TextColor = System.Drawing.Color.White
        Me.UI_CustomButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel12)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnMatricula_Inicial)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnMatricula_Actual)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnRetencion)
        Me.FlowLayoutPanel1.Controls.Add(Me.UI_ShadowPanel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1122, 90)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'PnMatricula_Inicial
        '
        Me.PnMatricula_Inicial.BaseColor = System.Drawing.Color.White
        Me.PnMatricula_Inicial.Controls.Add(Me.Label1)
        Me.PnMatricula_Inicial.Controls.Add(Me.Label3)
        Me.PnMatricula_Inicial.Controls.Add(Me.Label2)
        Me.PnMatricula_Inicial.Location = New System.Drawing.Point(175, 13)
        Me.PnMatricula_Inicial.Name = "PnMatricula_Inicial"
        Me.PnMatricula_Inicial.ParentControl = Me
        Me.PnMatricula_Inicial.Radius = 3
        Me.PnMatricula_Inicial.ShadowColor = System.Drawing.Color.Black
        Me.PnMatricula_Inicial.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.PnMatricula_Inicial.Size = New System.Drawing.Size(200, 77)
        Me.PnMatricula_Inicial.TabIndex = 15
        '
        'PnMatricula_Actual
        '
        Me.PnMatricula_Actual.BaseColor = System.Drawing.Color.White
        Me.PnMatricula_Actual.Controls.Add(Me.Label4)
        Me.PnMatricula_Actual.Controls.Add(Me.Label5)
        Me.PnMatricula_Actual.Controls.Add(Me.Label6)
        Me.PnMatricula_Actual.Location = New System.Drawing.Point(381, 13)
        Me.PnMatricula_Actual.Name = "PnMatricula_Actual"
        Me.PnMatricula_Actual.ParentControl = Me
        Me.PnMatricula_Actual.Radius = 3
        Me.PnMatricula_Actual.ShadowColor = System.Drawing.Color.Black
        Me.PnMatricula_Actual.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.PnMatricula_Actual.Size = New System.Drawing.Size(200, 77)
        Me.PnMatricula_Actual.TabIndex = 16
        '
        'PnRetencion
        '
        Me.PnRetencion.BaseColor = System.Drawing.Color.White
        Me.PnRetencion.Controls.Add(Me.Label7)
        Me.PnRetencion.Controls.Add(Me.Label8)
        Me.PnRetencion.Controls.Add(Me.Label9)
        Me.PnRetencion.Location = New System.Drawing.Point(587, 13)
        Me.PnRetencion.Name = "PnRetencion"
        Me.PnRetencion.ParentControl = Me
        Me.PnRetencion.Radius = 3
        Me.PnRetencion.ShadowColor = System.Drawing.Color.Black
        Me.PnRetencion.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.PnRetencion.Size = New System.Drawing.Size(200, 77)
        Me.PnRetencion.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrícula Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(68, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "700"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 57)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "∑"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Matrícula Actual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 57)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "∑"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(84, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "700"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Retención"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Location = New System.Drawing.Point(19, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 57)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label9.Location = New System.Drawing.Point(84, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "700"
        '
        'UI_ShadowPanel1
        '
        Me.UI_ShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.UI_ShadowPanel1.Controls.Add(Me.NumericUpDown1)
        Me.UI_ShadowPanel1.Location = New System.Drawing.Point(793, 13)
        Me.UI_ShadowPanel1.Name = "UI_ShadowPanel1"
        Me.UI_ShadowPanel1.ParentControl = Me
        Me.UI_ShadowPanel1.Radius = 3
        Me.UI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.UI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel1.Size = New System.Drawing.Size(200, 77)
        Me.UI_ShadowPanel1.TabIndex = 18
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.NumericUpDown1.Location = New System.Drawing.Point(34, 19)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(141, 35)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 459)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 100)
        Me.Panel2.TabIndex = 16
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 100)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(424, 359)
        Me.Chart1.TabIndex = 17
        Me.Chart1.Text = "Chart1"
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "FrmDashboard"
        Me.Text = "FrmDashboard"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PnMatricula_Inicial.ResumeLayout(False)
        Me.PnMatricula_Inicial.PerformLayout()
        Me.PnMatricula_Actual.ResumeLayout(False)
        Me.PnMatricula_Actual.PerformLayout()
        Me.PnRetencion.ResumeLayout(False)
        Me.PnRetencion.PerformLayout()
        Me.UI_ShadowPanel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel12 As Panel
    Friend WithEvents UI_CustomButton5 As UIDC.UI_CustomButton
    Friend WithEvents UI_CustomButton6 As UIDC.UI_CustomButton
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LblRuta As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PnMatricula_Inicial As UIDC.UI_ShadowPanel
    Friend WithEvents PnMatricula_Actual As UIDC.UI_ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PnRetencion As UIDC.UI_ShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents UI_ShadowPanel1 As UIDC.UI_ShadowPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
