<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indicador
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Indicador))
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.chk_todo = New System.Windows.Forms.CheckBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Cmb_Genero = New System.Windows.Forms.ComboBox()
        Me.cmb_CausaMuerte = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btn_lupa = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.cmb_periodo = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(170, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(479, 39)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Indicador de Mortalidad"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Location = New System.Drawing.Point(12, 75)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(833, 435)
        Me.tabControl1.TabIndex = 2
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.Color.Transparent
        Me.tabPage1.Controls.Add(Me.Chart1)
        Me.tabPage1.Controls.Add(Me.label5)
        Me.tabPage1.Controls.Add(Me.lbl_num)
        Me.tabPage1.Controls.Add(Me.chk_todo)
        Me.tabPage1.Controls.Add(Me.label10)
        Me.tabPage1.Controls.Add(Me.Cmb_Genero)
        Me.tabPage1.Controls.Add(Me.cmb_CausaMuerte)
        Me.tabPage1.Controls.Add(Me.label9)
        Me.tabPage1.Controls.Add(Me.lbl_total)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.pictureBox1)
        Me.tabPage1.Controls.Add(Me.label4)
        Me.tabPage1.Controls.Add(Me.btn_lupa)
        Me.tabPage1.Controls.Add(Me.button1)
        Me.tabPage1.Controls.Add(Me.cmb_periodo)
        Me.tabPage1.Controls.Add(Me.label3)
        Me.tabPage1.Controls.Add(Me.dataGridView1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(825, 409)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Mortalidad por Periodo"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(513, 139)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Indicador"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(253, 199)
        Me.Chart1.TabIndex = 20
        Me.Chart1.Text = "Chart1"
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(510, 115)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(216, 26)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Indicador por Mes y edad"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(639, 52)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(0, 20)
        Me.lbl_num.TabIndex = 18
        '
        'chk_todo
        '
        Me.chk_todo.AutoSize = True
        Me.chk_todo.Location = New System.Drawing.Point(426, 45)
        Me.chk_todo.Name = "chk_todo"
        Me.chk_todo.Size = New System.Drawing.Size(85, 17)
        Me.chk_todo.TabIndex = 16
        Me.chk_todo.Text = "Mostrar todo"
        Me.chk_todo.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.label10.ForeColor = System.Drawing.Color.Black
        Me.label10.Location = New System.Drawing.Point(213, 57)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(52, 13)
        Me.label10.TabIndex = 15
        Me.label10.Text = "Genero:"
        '
        'Cmb_Genero
        '
        Me.Cmb_Genero.FormattingEnabled = True
        Me.Cmb_Genero.Location = New System.Drawing.Point(279, 54)
        Me.Cmb_Genero.Name = "Cmb_Genero"
        Me.Cmb_Genero.Size = New System.Drawing.Size(141, 21)
        Me.Cmb_Genero.TabIndex = 14
        '
        'cmb_CausaMuerte
        '
        Me.cmb_CausaMuerte.FormattingEnabled = True
        Me.cmb_CausaMuerte.Location = New System.Drawing.Point(279, 81)
        Me.cmb_CausaMuerte.Name = "cmb_CausaMuerte"
        Me.cmb_CausaMuerte.Size = New System.Drawing.Size(141, 21)
        Me.cmb_CausaMuerte.TabIndex = 13
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.label9.Location = New System.Drawing.Point(170, 84)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(103, 13)
        Me.label9.TabIndex = 12
        Me.label9.Text = "Causa de Muerte"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(591, 92)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 20)
        Me.lbl_total.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(509, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(160, 20)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Total de fallecidos:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(155, 135)
        Me.pictureBox1.TabIndex = 8
        Me.pictureBox1.TabStop = False
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(179, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(487, 39)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Muestra  el total de fallecidos por el Año seleccionado."
        '
        'btn_lupa
        '
        Me.btn_lupa.Image = CType(resources.GetObject("btn_lupa.Image"), System.Drawing.Image)
        Me.btn_lupa.Location = New System.Drawing.Point(426, 115)
        Me.btn_lupa.Name = "btn_lupa"
        Me.btn_lupa.Size = New System.Drawing.Size(33, 27)
        Me.btn_lupa.TabIndex = 6
        Me.btn_lupa.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(720, 36)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 39)
        Me.button1.TabIndex = 5
        Me.button1.UseVisualStyleBackColor = True
        '
        'cmb_periodo
        '
        Me.cmb_periodo.FormattingEnabled = True
        Me.cmb_periodo.Location = New System.Drawing.Point(279, 117)
        Me.cmb_periodo.Name = "cmb_periodo"
        Me.cmb_periodo.Size = New System.Drawing.Size(141, 21)
        Me.cmb_periodo.TabIndex = 4
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(198, 117)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Periodo:"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(28, 178)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(483, 199)
        Me.dataGridView1.TabIndex = 0
        '
        'Indicador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 530)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Indicador"
        Me.Text = "Indicador de Mortalidad"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label5 As Label
    Private WithEvents lbl_num As Label
    Private WithEvents chk_todo As CheckBox
    Private WithEvents label10 As Label
    Private WithEvents Cmb_Genero As ComboBox
    Private WithEvents cmb_CausaMuerte As ComboBox
    Private WithEvents label9 As Label
    Private WithEvents lbl_total As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents btn_lupa As Button
    Private WithEvents button1 As Button
    Private WithEvents cmb_periodo As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents dataGridView1 As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
