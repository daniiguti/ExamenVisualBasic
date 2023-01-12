<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DGB_gbColores = New System.Windows.Forms.GroupBox()
        Me.DGB_lbColorSelec = New System.Windows.Forms.Label()
        Me.DGB_btAnadir = New System.Windows.Forms.Button()
        Me.DGB_tbColor = New System.Windows.Forms.TextBox()
        Me.DGB_lbxColores = New System.Windows.Forms.ListBox()
        Me.DGB_gbProbarLabel = New System.Windows.Forms.GroupBox()
        Me.DGB_lbHolaMundo = New System.Windows.Forms.Label()
        Me.DGB_btBackground = New System.Windows.Forms.Button()
        Me.DGB_btForeground = New System.Windows.Forms.Button()
        Me.DGB_gbAnuncio = New System.Windows.Forms.GroupBox()
        Me.DGB_btParada = New System.Windows.Forms.Button()
        Me.DGB_btInicio = New System.Windows.Forms.Button()
        Me.DGB_pbImagen = New System.Windows.Forms.PictureBox()
        Me.DGB_gbConcesionario = New System.Windows.Forms.GroupBox()
        Me.DGB_lbColorCoche = New System.Windows.Forms.Label()
        Me.DGB_lbTipoCoche = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGB_rbAzul = New System.Windows.Forms.RadioButton()
        Me.DGB_rbRojo = New System.Windows.Forms.RadioButton()
        Me.DGB_rbAmarillo = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DGB_rbElectrico = New System.Windows.Forms.RadioButton()
        Me.DGB_rbDiesel = New System.Windows.Forms.RadioButton()
        Me.DGB_rbGasolina = New System.Windows.Forms.RadioButton()
        Me.DGB_Menu = New System.Windows.Forms.MenuStrip()
        Me.EjerciciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcesionarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbarLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnuncioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGB_barraEstado = New System.Windows.Forms.StatusStrip()
        Me.DGB_ejercicio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGB_cuadroColor = New System.Windows.Forms.ColorDialog()
        Me.DGB_ilCoches = New System.Windows.Forms.ImageList(Me.components)
        Me.DGB_tmCoches = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DGB_tsConcesionario = New System.Windows.Forms.ToolStripButton()
        Me.DGB_tsColores = New System.Windows.Forms.ToolStripButton()
        Me.DGB_tsProbarLabel = New System.Windows.Forms.ToolStripButton()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGB_gbColores.SuspendLayout()
        Me.DGB_gbProbarLabel.SuspendLayout()
        Me.DGB_gbAnuncio.SuspendLayout()
        CType(Me.DGB_pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGB_gbConcesionario.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.DGB_Menu.SuspendLayout()
        Me.DGB_barraEstado.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGB_gbColores
        '
        Me.DGB_gbColores.Controls.Add(Me.DGB_lbColorSelec)
        Me.DGB_gbColores.Controls.Add(Me.DGB_btAnadir)
        Me.DGB_gbColores.Controls.Add(Me.DGB_tbColor)
        Me.DGB_gbColores.Controls.Add(Me.DGB_lbxColores)
        Me.DGB_gbColores.Location = New System.Drawing.Point(571, 58)
        Me.DGB_gbColores.Name = "DGB_gbColores"
        Me.DGB_gbColores.Size = New System.Drawing.Size(541, 403)
        Me.DGB_gbColores.TabIndex = 1
        Me.DGB_gbColores.TabStop = False
        Me.DGB_gbColores.Text = "Colores"
        '
        'DGB_lbColorSelec
        '
        Me.DGB_lbColorSelec.AutoSize = True
        Me.DGB_lbColorSelec.Location = New System.Drawing.Point(378, 246)
        Me.DGB_lbColorSelec.Name = "DGB_lbColorSelec"
        Me.DGB_lbColorSelec.Size = New System.Drawing.Size(0, 20)
        Me.DGB_lbColorSelec.TabIndex = 3
        '
        'DGB_btAnadir
        '
        Me.DGB_btAnadir.Location = New System.Drawing.Point(92, 161)
        Me.DGB_btAnadir.Name = "DGB_btAnadir"
        Me.DGB_btAnadir.Size = New System.Drawing.Size(94, 29)
        Me.DGB_btAnadir.TabIndex = 2
        Me.DGB_btAnadir.Text = "Añadir"
        Me.DGB_btAnadir.UseVisualStyleBackColor = True
        '
        'DGB_tbColor
        '
        Me.DGB_tbColor.Location = New System.Drawing.Point(78, 86)
        Me.DGB_tbColor.Name = "DGB_tbColor"
        Me.DGB_tbColor.Size = New System.Drawing.Size(125, 27)
        Me.DGB_tbColor.TabIndex = 1
        '
        'DGB_lbxColores
        '
        Me.DGB_lbxColores.FormattingEnabled = True
        Me.DGB_lbxColores.ItemHeight = 20
        Me.DGB_lbxColores.Location = New System.Drawing.Point(333, 86)
        Me.DGB_lbxColores.Name = "DGB_lbxColores"
        Me.DGB_lbxColores.Size = New System.Drawing.Size(150, 104)
        Me.DGB_lbxColores.TabIndex = 0
        '
        'DGB_gbProbarLabel
        '
        Me.DGB_gbProbarLabel.Controls.Add(Me.DGB_lbHolaMundo)
        Me.DGB_gbProbarLabel.Controls.Add(Me.DGB_btBackground)
        Me.DGB_gbProbarLabel.Controls.Add(Me.DGB_btForeground)
        Me.DGB_gbProbarLabel.Location = New System.Drawing.Point(12, 483)
        Me.DGB_gbProbarLabel.Name = "DGB_gbProbarLabel"
        Me.DGB_gbProbarLabel.Size = New System.Drawing.Size(541, 403)
        Me.DGB_gbProbarLabel.TabIndex = 2
        Me.DGB_gbProbarLabel.TabStop = False
        Me.DGB_gbProbarLabel.Text = "ProbarLabel"
        '
        'DGB_lbHolaMundo
        '
        Me.DGB_lbHolaMundo.AutoSize = True
        Me.DGB_lbHolaMundo.Location = New System.Drawing.Point(334, 192)
        Me.DGB_lbHolaMundo.Name = "DGB_lbHolaMundo"
        Me.DGB_lbHolaMundo.Size = New System.Drawing.Size(108, 20)
        Me.DGB_lbHolaMundo.TabIndex = 3
        Me.DGB_lbHolaMundo.Text = "HOLA MUNDO"
        '
        'DGB_btBackground
        '
        Me.DGB_btBackground.Location = New System.Drawing.Point(53, 249)
        Me.DGB_btBackground.Name = "DGB_btBackground"
        Me.DGB_btBackground.Size = New System.Drawing.Size(130, 29)
        Me.DGB_btBackground.TabIndex = 1
        Me.DGB_btBackground.Text = "BACKGROUND"
        Me.DGB_btBackground.UseVisualStyleBackColor = True
        '
        'DGB_btForeground
        '
        Me.DGB_btForeground.Location = New System.Drawing.Point(53, 109)
        Me.DGB_btForeground.Name = "DGB_btForeground"
        Me.DGB_btForeground.Size = New System.Drawing.Size(130, 29)
        Me.DGB_btForeground.TabIndex = 0
        Me.DGB_btForeground.Text = "FOREGROUND"
        Me.DGB_btForeground.UseVisualStyleBackColor = True
        '
        'DGB_gbAnuncio
        '
        Me.DGB_gbAnuncio.Controls.Add(Me.DGB_btParada)
        Me.DGB_gbAnuncio.Controls.Add(Me.DGB_btInicio)
        Me.DGB_gbAnuncio.Controls.Add(Me.DGB_pbImagen)
        Me.DGB_gbAnuncio.Location = New System.Drawing.Point(571, 483)
        Me.DGB_gbAnuncio.Name = "DGB_gbAnuncio"
        Me.DGB_gbAnuncio.Size = New System.Drawing.Size(541, 403)
        Me.DGB_gbAnuncio.TabIndex = 3
        Me.DGB_gbAnuncio.TabStop = False
        Me.DGB_gbAnuncio.Text = "Anuncio"
        '
        'DGB_btParada
        '
        Me.DGB_btParada.Location = New System.Drawing.Point(92, 259)
        Me.DGB_btParada.Name = "DGB_btParada"
        Me.DGB_btParada.Size = New System.Drawing.Size(94, 29)
        Me.DGB_btParada.TabIndex = 2
        Me.DGB_btParada.Text = "PARAR"
        Me.DGB_btParada.UseVisualStyleBackColor = True
        '
        'DGB_btInicio
        '
        Me.DGB_btInicio.Location = New System.Drawing.Point(92, 109)
        Me.DGB_btInicio.Name = "DGB_btInicio"
        Me.DGB_btInicio.Size = New System.Drawing.Size(94, 29)
        Me.DGB_btInicio.TabIndex = 1
        Me.DGB_btInicio.Text = "INICIAR"
        Me.DGB_btInicio.UseVisualStyleBackColor = True
        '
        'DGB_pbImagen
        '
        Me.DGB_pbImagen.Location = New System.Drawing.Point(333, 145)
        Me.DGB_pbImagen.Name = "DGB_pbImagen"
        Me.DGB_pbImagen.Size = New System.Drawing.Size(136, 120)
        Me.DGB_pbImagen.TabIndex = 0
        Me.DGB_pbImagen.TabStop = False
        '
        'DGB_gbConcesionario
        '
        Me.DGB_gbConcesionario.Controls.Add(Me.DGB_lbColorCoche)
        Me.DGB_gbConcesionario.Controls.Add(Me.DGB_lbTipoCoche)
        Me.DGB_gbConcesionario.Controls.Add(Me.GroupBox6)
        Me.DGB_gbConcesionario.Controls.Add(Me.GroupBox5)
        Me.DGB_gbConcesionario.Location = New System.Drawing.Point(12, 58)
        Me.DGB_gbConcesionario.Name = "DGB_gbConcesionario"
        Me.DGB_gbConcesionario.Size = New System.Drawing.Size(541, 403)
        Me.DGB_gbConcesionario.TabIndex = 4
        Me.DGB_gbConcesionario.TabStop = False
        Me.DGB_gbConcesionario.Text = "Concesionario"
        '
        'DGB_lbColorCoche
        '
        Me.DGB_lbColorCoche.AutoSize = True
        Me.DGB_lbColorCoche.Location = New System.Drawing.Point(352, 219)
        Me.DGB_lbColorCoche.Name = "DGB_lbColorCoche"
        Me.DGB_lbColorCoche.Size = New System.Drawing.Size(0, 20)
        Me.DGB_lbColorCoche.TabIndex = 3
        '
        'DGB_lbTipoCoche
        '
        Me.DGB_lbTipoCoche.AutoSize = True
        Me.DGB_lbTipoCoche.Location = New System.Drawing.Point(352, 170)
        Me.DGB_lbTipoCoche.Name = "DGB_lbTipoCoche"
        Me.DGB_lbTipoCoche.Size = New System.Drawing.Size(0, 20)
        Me.DGB_lbTipoCoche.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGB_rbAzul)
        Me.GroupBox6.Controls.Add(Me.DGB_rbRojo)
        Me.GroupBox6.Controls.Add(Me.DGB_rbAmarillo)
        Me.GroupBox6.Location = New System.Drawing.Point(23, 219)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(191, 149)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Color de Coche"
        '
        'DGB_rbAzul
        '
        Me.DGB_rbAzul.AutoSize = True
        Me.DGB_rbAzul.Location = New System.Drawing.Point(30, 96)
        Me.DGB_rbAzul.Name = "DGB_rbAzul"
        Me.DGB_rbAzul.Size = New System.Drawing.Size(59, 24)
        Me.DGB_rbAzul.TabIndex = 2
        Me.DGB_rbAzul.TabStop = True
        Me.DGB_rbAzul.Text = "Azul"
        Me.DGB_rbAzul.UseVisualStyleBackColor = True
        '
        'DGB_rbRojo
        '
        Me.DGB_rbRojo.AutoSize = True
        Me.DGB_rbRojo.Location = New System.Drawing.Point(30, 66)
        Me.DGB_rbRojo.Name = "DGB_rbRojo"
        Me.DGB_rbRojo.Size = New System.Drawing.Size(61, 24)
        Me.DGB_rbRojo.TabIndex = 1
        Me.DGB_rbRojo.TabStop = True
        Me.DGB_rbRojo.Text = "Rojo"
        Me.DGB_rbRojo.UseVisualStyleBackColor = True
        '
        'DGB_rbAmarillo
        '
        Me.DGB_rbAmarillo.AutoSize = True
        Me.DGB_rbAmarillo.Location = New System.Drawing.Point(30, 36)
        Me.DGB_rbAmarillo.Name = "DGB_rbAmarillo"
        Me.DGB_rbAmarillo.Size = New System.Drawing.Size(87, 24)
        Me.DGB_rbAmarillo.TabIndex = 0
        Me.DGB_rbAmarillo.TabStop = True
        Me.DGB_rbAmarillo.Text = "Amarillo"
        Me.DGB_rbAmarillo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DGB_rbElectrico)
        Me.GroupBox5.Controls.Add(Me.DGB_rbDiesel)
        Me.GroupBox5.Controls.Add(Me.DGB_rbGasolina)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 41)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(191, 149)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Coche"
        '
        'DGB_rbElectrico
        '
        Me.DGB_rbElectrico.AutoSize = True
        Me.DGB_rbElectrico.Location = New System.Drawing.Point(30, 89)
        Me.DGB_rbElectrico.Name = "DGB_rbElectrico"
        Me.DGB_rbElectrico.Size = New System.Drawing.Size(87, 24)
        Me.DGB_rbElectrico.TabIndex = 2
        Me.DGB_rbElectrico.TabStop = True
        Me.DGB_rbElectrico.Text = "Electrico"
        Me.DGB_rbElectrico.UseVisualStyleBackColor = True
        '
        'DGB_rbDiesel
        '
        Me.DGB_rbDiesel.AutoSize = True
        Me.DGB_rbDiesel.Location = New System.Drawing.Point(30, 59)
        Me.DGB_rbDiesel.Name = "DGB_rbDiesel"
        Me.DGB_rbDiesel.Size = New System.Drawing.Size(71, 24)
        Me.DGB_rbDiesel.TabIndex = 1
        Me.DGB_rbDiesel.TabStop = True
        Me.DGB_rbDiesel.Text = "Diesel"
        Me.DGB_rbDiesel.UseVisualStyleBackColor = True
        '
        'DGB_rbGasolina
        '
        Me.DGB_rbGasolina.AutoSize = True
        Me.DGB_rbGasolina.Location = New System.Drawing.Point(30, 29)
        Me.DGB_rbGasolina.Name = "DGB_rbGasolina"
        Me.DGB_rbGasolina.Size = New System.Drawing.Size(87, 24)
        Me.DGB_rbGasolina.TabIndex = 0
        Me.DGB_rbGasolina.TabStop = True
        Me.DGB_rbGasolina.Text = "Gasolina"
        Me.DGB_rbGasolina.UseVisualStyleBackColor = True
        '
        'DGB_Menu
        '
        Me.DGB_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DGB_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjerciciosToolStripMenuItem, Me.InfoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.DGB_Menu.Location = New System.Drawing.Point(0, 0)
        Me.DGB_Menu.Name = "DGB_Menu"
        Me.DGB_Menu.Size = New System.Drawing.Size(1140, 28)
        Me.DGB_Menu.TabIndex = 5
        Me.DGB_Menu.Text = "MenuStrip1"
        '
        'EjerciciosToolStripMenuItem
        '
        Me.EjerciciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConcesionarioToolStripMenuItem, Me.ColoresToolStripMenuItem, Me.ProbarLabelToolStripMenuItem, Me.AnuncioToolStripMenuItem})
        Me.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem"
        Me.EjerciciosToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.EjerciciosToolStripMenuItem.Text = "Ejercicios"
        '
        'ConcesionarioToolStripMenuItem
        '
        Me.ConcesionarioToolStripMenuItem.Name = "ConcesionarioToolStripMenuItem"
        Me.ConcesionarioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ConcesionarioToolStripMenuItem.Text = "Concesionario"
        '
        'ColoresToolStripMenuItem
        '
        Me.ColoresToolStripMenuItem.Name = "ColoresToolStripMenuItem"
        Me.ColoresToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ColoresToolStripMenuItem.Text = "Colores"
        '
        'ProbarLabelToolStripMenuItem
        '
        Me.ProbarLabelToolStripMenuItem.Name = "ProbarLabelToolStripMenuItem"
        Me.ProbarLabelToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProbarLabelToolStripMenuItem.Text = "ProbarLabel"
        '
        'AnuncioToolStripMenuItem
        '
        Me.AnuncioToolStripMenuItem.Name = "AnuncioToolStripMenuItem"
        Me.AnuncioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AnuncioToolStripMenuItem.Text = "Anuncio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DGB_barraEstado
        '
        Me.DGB_barraEstado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DGB_barraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DGB_ejercicio})
        Me.DGB_barraEstado.Location = New System.Drawing.Point(0, 906)
        Me.DGB_barraEstado.Name = "DGB_barraEstado"
        Me.DGB_barraEstado.Size = New System.Drawing.Size(1140, 22)
        Me.DGB_barraEstado.TabIndex = 6
        Me.DGB_barraEstado.Text = "DGB_barraEstado"
        '
        'DGB_ejercicio
        '
        Me.DGB_ejercicio.Name = "DGB_ejercicio"
        Me.DGB_ejercicio.Size = New System.Drawing.Size(0, 16)
        '
        'DGB_ilCoches
        '
        Me.DGB_ilCoches.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.DGB_ilCoches.ImageStream = CType(resources.GetObject("DGB_ilCoches.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DGB_ilCoches.TransparentColor = System.Drawing.Color.Transparent
        Me.DGB_ilCoches.Images.SetKeyName(0, "coche_antiguo.jpeg")
        Me.DGB_ilCoches.Images.SetKeyName(1, "coche_dibujo.jpg")
        Me.DGB_ilCoches.Images.SetKeyName(2, "porsche-model.png")
        Me.DGB_ilCoches.Images.SetKeyName(3, "seat.jpg")
        '
        'DGB_tmCoches
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DGB_tsConcesionario, Me.DGB_tsColores, Me.DGB_tsProbarLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 27)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DGB_tsConcesionario
        '
        Me.DGB_tsConcesionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DGB_tsConcesionario.Image = Global.DGB_examenVB.My.Resources.Resources.uno
        Me.DGB_tsConcesionario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DGB_tsConcesionario.Name = "DGB_tsConcesionario"
        Me.DGB_tsConcesionario.Size = New System.Drawing.Size(29, 24)
        Me.DGB_tsConcesionario.Text = "Concesionario"
        '
        'DGB_tsColores
        '
        Me.DGB_tsColores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DGB_tsColores.Image = Global.DGB_examenVB.My.Resources.Resources.dos
        Me.DGB_tsColores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DGB_tsColores.Name = "DGB_tsColores"
        Me.DGB_tsColores.Size = New System.Drawing.Size(29, 24)
        Me.DGB_tsColores.Text = "Colores"
        '
        'DGB_tsProbarLabel
        '
        Me.DGB_tsProbarLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DGB_tsProbarLabel.Image = Global.DGB_examenVB.My.Resources.Resources.tres
        Me.DGB_tsProbarLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DGB_tsProbarLabel.Name = "DGB_tsProbarLabel"
        Me.DGB_tsProbarLabel.Size = New System.Drawing.Size(29, 24)
        Me.DGB_tsProbarLabel.Text = "Probar Label"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 928)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGB_barraEstado)
        Me.Controls.Add(Me.DGB_gbConcesionario)
        Me.Controls.Add(Me.DGB_gbAnuncio)
        Me.Controls.Add(Me.DGB_gbProbarLabel)
        Me.Controls.Add(Me.DGB_gbColores)
        Me.Controls.Add(Me.DGB_Menu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipal"
        Me.DGB_gbColores.ResumeLayout(False)
        Me.DGB_gbColores.PerformLayout()
        Me.DGB_gbProbarLabel.ResumeLayout(False)
        Me.DGB_gbProbarLabel.PerformLayout()
        Me.DGB_gbAnuncio.ResumeLayout(False)
        CType(Me.DGB_pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGB_gbConcesionario.ResumeLayout(False)
        Me.DGB_gbConcesionario.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.DGB_Menu.ResumeLayout(False)
        Me.DGB_Menu.PerformLayout()
        Me.DGB_barraEstado.ResumeLayout(False)
        Me.DGB_barraEstado.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGB_gbColores As GroupBox
    Friend WithEvents DGB_gbProbarLabel As GroupBox
    Friend WithEvents DGB_gbAnuncio As GroupBox
    Friend WithEvents DGB_gbConcesionario As GroupBox
    Friend WithEvents DGB_Menu As MenuStrip
    Friend WithEvents DGB_lbTipoCoche As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGB_rbAzul As RadioButton
    Friend WithEvents DGB_rbRojo As RadioButton
    Friend WithEvents DGB_rbAmarillo As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DGB_rbElectrico As RadioButton
    Friend WithEvents DGB_rbDiesel As RadioButton
    Friend WithEvents DGB_rbGasolina As RadioButton
    Friend WithEvents EjerciciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGB_barraEstado As StatusStrip
    Friend WithEvents DGB_lbColorCoche As Label
    Friend WithEvents ConcesionarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGB_lbColorSelec As Label
    Friend WithEvents DGB_btAnadir As Button
    Friend WithEvents DGB_tbColor As TextBox
    Friend WithEvents DGB_lbxColores As ListBox
    Friend WithEvents ColoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbarLabelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGB_lbHolaMundo As Label
    Friend WithEvents DGB_btBackground As Button
    Friend WithEvents DGB_btForeground As Button
    Friend WithEvents DGB_cuadroColor As ColorDialog
    Friend WithEvents AnuncioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGB_btParada As Button
    Friend WithEvents DGB_btInicio As Button
    Friend WithEvents DGB_pbImagen As PictureBox
    Friend WithEvents DGB_ilCoches As ImageList
    Friend WithEvents DGB_tmCoches As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DGB_tsConcesionario As ToolStripButton
    Friend WithEvents DGB_tsColores As ToolStripButton
    Friend WithEvents DGB_tsProbarLabel As ToolStripButton
    Friend WithEvents DGB_ejercicio As ToolStripStatusLabel
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
End Class
