<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSTRUCCIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INSTRUCCIONES))
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtescolaridad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSuId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.dtpfechahoy = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(45, 493)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(55, 20)
        Me.txtId.TabIndex = 177
        Me.txtId.Visible = False
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.Color.Honeydew
        Me.txtPuesto.Enabled = False
        Me.txtPuesto.Location = New System.Drawing.Point(618, 441)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(307, 20)
        Me.txtPuesto.TabIndex = 176
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.Honeydew
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(618, 419)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(55, 20)
        Me.txtEdad.TabIndex = 175
        '
        'txtescolaridad
        '
        Me.txtescolaridad.BackColor = System.Drawing.Color.Honeydew
        Me.txtescolaridad.Enabled = False
        Me.txtescolaridad.Location = New System.Drawing.Point(618, 395)
        Me.txtescolaridad.Name = "txtescolaridad"
        Me.txtescolaridad.Size = New System.Drawing.Size(307, 20)
        Me.txtescolaridad.TabIndex = 174
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Honeydew
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(618, 371)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(307, 20)
        Me.txtNombre.TabIndex = 173
        '
        'txtSuId
        '
        Me.txtSuId.BackColor = System.Drawing.Color.Honeydew
        Me.txtSuId.Enabled = False
        Me.txtSuId.Location = New System.Drawing.Point(618, 346)
        Me.txtSuId.Name = "txtSuId"
        Me.txtSuId.Size = New System.Drawing.Size(71, 20)
        Me.txtSuId.TabIndex = 172
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Honeydew
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(435, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "SU ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Honeydew
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(435, 444)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 19)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "PUESTO SOLICITADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Honeydew
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(435, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "EDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Honeydew
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(435, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 19)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "ESCOLARIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Honeydew
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(435, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "NOMBRE"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Honeydew
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.OliveDrab
        Me.RichTextBox1.Location = New System.Drawing.Point(-2, 12)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1265, 312)
        Me.RichTextBox1.TabIndex = 166
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'dtpfechahoy
        '
        Me.dtpfechahoy.Enabled = False
        Me.dtpfechahoy.Location = New System.Drawing.Point(1050, 372)
        Me.dtpfechahoy.Name = "dtpfechahoy"
        Me.dtpfechahoy.Size = New System.Drawing.Size(200, 20)
        Me.dtpfechahoy.TabIndex = 179
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.santadeo_testpsicometrico.My.Resources.Resources.logowhite
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(9, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 157)
        Me.PictureBox1.TabIndex = 180
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Image = Global.santadeo_testpsicometrico.My.Resources.Resources.boton_iniciar
        Me.Button2.Location = New System.Drawing.Point(617, 478)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 33)
        Me.Button2.TabIndex = 178
        Me.Button2.UseVisualStyleBackColor = True
        '
        'INSTRUCCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(1264, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpfechahoy)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtescolaridad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtSuId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(2000, 562)
        Me.MinimumSize = New System.Drawing.Size(1278, 562)
        Me.Name = "INSTRUCCIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instrucciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtescolaridad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSuId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpfechahoy As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
