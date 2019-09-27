<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporte1))
        Me.rh_candidatos_empleosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistasDataSet = New santadeo_testpsicometrico.VistasDataSet()
        Me.rh_test_merrilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rh_candidatos_explabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btcurriculum = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rh_test_merrilTableAdapter = New santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_test_merrilTableAdapter()
        Me.rh_candidatos_empleosTableAdapter = New santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_candidatos_empleosTableAdapter()
        Me.rh_candidatos_explabTableAdapter = New santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_candidatos_explabTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.rh_candidatos_empleosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rh_test_merrilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rh_candidatos_explabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rh_candidatos_empleosBindingSource
        '
        Me.rh_candidatos_empleosBindingSource.DataMember = "rh_candidatos_empleos"
        Me.rh_candidatos_empleosBindingSource.DataSource = Me.VistasDataSet
        '
        'VistasDataSet
        '
        Me.VistasDataSet.DataSetName = "VistasDataSet"
        Me.VistasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rh_test_merrilBindingSource
        '
        Me.rh_test_merrilBindingSource.DataMember = "rh_test_merril"
        Me.rh_test_merrilBindingSource.DataSource = Me.VistasDataSet
        '
        'rh_candidatos_explabBindingSource
        '
        Me.rh_candidatos_explabBindingSource.DataMember = "rh_candidatos_explab"
        Me.rh_candidatos_explabBindingSource.DataSource = Me.VistasDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.rh_candidatos_empleosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "santadeo_testpsicometrico.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 45)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(841, 945)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecciona un candidato para ver resultados"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todos"})
        Me.ComboBox1.Location = New System.Drawing.Point(328, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(269, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.rh_test_merrilBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "santadeo_testpsicometrico.Report1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 45)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(841, 945)
        Me.ReportViewer2.TabIndex = 5
        Me.ReportViewer2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 45)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btcurriculum
        '
        Me.btcurriculum.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btcurriculum.BackgroundImage = Global.santadeo_testpsicometrico.My.Resources.Resources.icono_download
        Me.btcurriculum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btcurriculum.Location = New System.Drawing.Point(610, 0)
        Me.btcurriculum.Name = "btcurriculum"
        Me.btcurriculum.Size = New System.Drawing.Size(40, 45)
        Me.btcurriculum.TabIndex = 6
        Me.btcurriculum.UseVisualStyleBackColor = False
        Me.btcurriculum.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.BackgroundImage = Global.santadeo_testpsicometrico.My.Resources.Resources.back_158150_640
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(788, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet_exp"
        ReportDataSource3.Value = Me.rh_candidatos_explabBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "santadeo_testpsicometrico.Report3.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 45)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(841, 945)
        Me.ReportViewer3.TabIndex = 7
        Me.ReportViewer3.Visible = False
        '
        'rh_test_merrilTableAdapter
        '
        Me.rh_test_merrilTableAdapter.ClearBeforeFill = True
        '
        'rh_candidatos_empleosTableAdapter
        '
        Me.rh_candidatos_empleosTableAdapter.ClearBeforeFill = True
        '
        'rh_candidatos_explabTableAdapter
        '
        Me.rh_candidatos_explabTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(648, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "EXPERIENCIAS"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'reporte1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 990)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Controls.Add(Me.btcurriculum)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "reporte1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reportes"
        CType(Me.rh_candidatos_empleosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rh_test_merrilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rh_candidatos_explabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents rh_test_merrilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistasDataSet As santadeo_testpsicometrico.VistasDataSet
    Friend WithEvents rh_test_merrilTableAdapter As santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_test_merrilTableAdapter
    Friend WithEvents rh_candidatos_empleosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rh_candidatos_empleosTableAdapter As santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_candidatos_empleosTableAdapter
    Friend WithEvents btcurriculum As System.Windows.Forms.Button
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rh_candidatos_explabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rh_candidatos_explabTableAdapter As santadeo_testpsicometrico.VistasDataSetTableAdapters.rh_candidatos_explabTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
End Class
