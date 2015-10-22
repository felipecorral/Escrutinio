<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CargarAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarEscrutinioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox_Alumnos = New System.Windows.Forms.ListBox()
        Me.Button_mas1 = New System.Windows.Forms.Button()
        Me.Button_menos1 = New System.Windows.Forms.Button()
        Me.ListBox_Votados = New System.Windows.Forms.ListBox()
        Me.ListBox_Votos = New System.Windows.Forms.ListBox()
        Me.Button_Ordenar = New System.Windows.Forms.Button()
        Me.Label_Delegado = New System.Windows.Forms.Label()
        Me.Label_Subdelegado = New System.Windows.Forms.Label()
        Me.TextBox_Delegado = New System.Windows.Forms.TextBox()
        Me.TextBox_Subdelegado = New System.Windows.Forms.TextBox()
        Me.TextBox_Delegado_Votos = New System.Windows.Forms.TextBox()
        Me.TextBox_Subdelegado_Votos = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarAlumnosToolStripMenuItem, Me.GrabarEscrutinioToolStripMenuItem, Me.OrdenarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CargarAlumnosToolStripMenuItem
        '
        Me.CargarAlumnosToolStripMenuItem.Name = "CargarAlumnosToolStripMenuItem"
        Me.CargarAlumnosToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.CargarAlumnosToolStripMenuItem.Text = "&Cargar Alumnos"
        '
        'GrabarEscrutinioToolStripMenuItem
        '
        Me.GrabarEscrutinioToolStripMenuItem.Name = "GrabarEscrutinioToolStripMenuItem"
        Me.GrabarEscrutinioToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.GrabarEscrutinioToolStripMenuItem.Text = "&Grabar Escrutinio"
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OrdenarToolStripMenuItem.Text = "&Ordenar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ListBox_Alumnos
        '
        Me.ListBox_Alumnos.FormattingEnabled = True
        Me.ListBox_Alumnos.Location = New System.Drawing.Point(12, 27)
        Me.ListBox_Alumnos.Name = "ListBox_Alumnos"
        Me.ListBox_Alumnos.Size = New System.Drawing.Size(418, 407)
        Me.ListBox_Alumnos.TabIndex = 1
        '
        'Button_mas1
        '
        Me.Button_mas1.Location = New System.Drawing.Point(437, 167)
        Me.Button_mas1.Name = "Button_mas1"
        Me.Button_mas1.Size = New System.Drawing.Size(75, 23)
        Me.Button_mas1.TabIndex = 2
        Me.Button_mas1.Text = "+1"
        Me.Button_mas1.UseVisualStyleBackColor = True
        '
        'Button_menos1
        '
        Me.Button_menos1.Location = New System.Drawing.Point(437, 259)
        Me.Button_menos1.Name = "Button_menos1"
        Me.Button_menos1.Size = New System.Drawing.Size(75, 23)
        Me.Button_menos1.TabIndex = 3
        Me.Button_menos1.Text = "-1"
        Me.Button_menos1.UseVisualStyleBackColor = True
        '
        'ListBox_Votados
        '
        Me.ListBox_Votados.FormattingEnabled = True
        Me.ListBox_Votados.Location = New System.Drawing.Point(518, 27)
        Me.ListBox_Votados.Name = "ListBox_Votados"
        Me.ListBox_Votados.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox_Votados.Size = New System.Drawing.Size(404, 407)
        Me.ListBox_Votados.TabIndex = 4
        '
        'ListBox_Votos
        '
        Me.ListBox_Votos.FormattingEnabled = True
        Me.ListBox_Votos.Location = New System.Drawing.Point(928, 28)
        Me.ListBox_Votos.Name = "ListBox_Votos"
        Me.ListBox_Votos.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox_Votos.Size = New System.Drawing.Size(53, 407)
        Me.ListBox_Votos.TabIndex = 5
        '
        'Button_Ordenar
        '
        Me.Button_Ordenar.Location = New System.Drawing.Point(764, 454)
        Me.Button_Ordenar.Name = "Button_Ordenar"
        Me.Button_Ordenar.Size = New System.Drawing.Size(157, 23)
        Me.Button_Ordenar.TabIndex = 6
        Me.Button_Ordenar.Text = "Ordenar"
        Me.Button_Ordenar.UseVisualStyleBackColor = True
        '
        'Label_Delegado
        '
        Me.Label_Delegado.AutoSize = True
        Me.Label_Delegado.Location = New System.Drawing.Point(96, 463)
        Me.Label_Delegado.Name = "Label_Delegado"
        Me.Label_Delegado.Size = New System.Drawing.Size(67, 13)
        Me.Label_Delegado.TabIndex = 7
        Me.Label_Delegado.Text = "Delegado/a:"
        '
        'Label_Subdelegado
        '
        Me.Label_Subdelegado.AutoSize = True
        Me.Label_Subdelegado.Location = New System.Drawing.Point(96, 492)
        Me.Label_Subdelegado.Name = "Label_Subdelegado"
        Me.Label_Subdelegado.Size = New System.Drawing.Size(84, 13)
        Me.Label_Subdelegado.TabIndex = 8
        Me.Label_Subdelegado.Text = "Subdelegado/a:"
        '
        'TextBox_Delegado
        '
        Me.TextBox_Delegado.Location = New System.Drawing.Point(211, 460)
        Me.TextBox_Delegado.Name = "TextBox_Delegado"
        Me.TextBox_Delegado.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_Delegado.TabIndex = 9
        '
        'TextBox_Subdelegado
        '
        Me.TextBox_Subdelegado.Location = New System.Drawing.Point(211, 489)
        Me.TextBox_Subdelegado.Name = "TextBox_Subdelegado"
        Me.TextBox_Subdelegado.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_Subdelegado.TabIndex = 10
        '
        'TextBox_Delegado_Votos
        '
        Me.TextBox_Delegado_Votos.Location = New System.Drawing.Point(518, 460)
        Me.TextBox_Delegado_Votos.Name = "TextBox_Delegado_Votos"
        Me.TextBox_Delegado_Votos.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Delegado_Votos.TabIndex = 11
        '
        'TextBox_Subdelegado_Votos
        '
        Me.TextBox_Subdelegado_Votos.Location = New System.Drawing.Point(518, 486)
        Me.TextBox_Subdelegado_Votos.Name = "TextBox_Subdelegado_Votos"
        Me.TextBox_Subdelegado_Votos.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Subdelegado_Votos.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 565)
        Me.Controls.Add(Me.TextBox_Subdelegado_Votos)
        Me.Controls.Add(Me.TextBox_Delegado_Votos)
        Me.Controls.Add(Me.TextBox_Subdelegado)
        Me.Controls.Add(Me.TextBox_Delegado)
        Me.Controls.Add(Me.Label_Subdelegado)
        Me.Controls.Add(Me.Label_Delegado)
        Me.Controls.Add(Me.Button_Ordenar)
        Me.Controls.Add(Me.ListBox_Votos)
        Me.Controls.Add(Me.ListBox_Votados)
        Me.Controls.Add(Me.Button_menos1)
        Me.Controls.Add(Me.Button_mas1)
        Me.Controls.Add(Me.ListBox_Alumnos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CargarAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarEscrutinioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox_Alumnos As ListBox
    Friend WithEvents Button_mas1 As Button
    Friend WithEvents Button_menos1 As Button
    Friend WithEvents ListBox_Votados As ListBox
    Friend WithEvents ListBox_Votos As ListBox
    Friend WithEvents Button_Ordenar As Button
    Friend WithEvents Label_Delegado As Label
    Friend WithEvents Label_Subdelegado As Label
    Friend WithEvents TextBox_Delegado As TextBox
    Friend WithEvents TextBox_Subdelegado As TextBox
    Friend WithEvents TextBox_Delegado_Votos As TextBox
    Friend WithEvents TextBox_Subdelegado_Votos As TextBox
End Class
