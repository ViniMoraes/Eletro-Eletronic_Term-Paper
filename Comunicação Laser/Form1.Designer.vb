<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gb_Manual = New System.Windows.Forms.GroupBox()
        Me.Botao_Desligar = New System.Windows.Forms.Button()
        Me.Botao_Ligar = New System.Windows.Forms.Button()
        Me.Label_statusbomba = New System.Windows.Forms.Label()
        Me.Botao_N1 = New System.Windows.Forms.Button()
        Me.Botao_N3 = New System.Windows.Forms.Button()
        Me.Botao_N4 = New System.Windows.Forms.Button()
        Me.Botao_N5 = New System.Windows.Forms.Button()
        Me.Botao_N6 = New System.Windows.Forms.Button()
        Me.Botao_N2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer_Leitura = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Enviar_A = New System.Windows.Forms.Timer(Me.components)
        Me.GB_Autom = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Timer_Enviar_M = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_statusporta = New System.Windows.Forms.Label()
        Me.Timer_Encher = New System.Windows.Forms.Timer(Me.components)
        Me.barradeprogresso = New Comunicação_Laser.MyVerticalProgessBar()
        Me.MenuStrip1.SuspendLayout()
        Me.Gb_Manual.SuspendLayout()
        Me.GB_Autom.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(393, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProgramaToolStripMenuItem.Text = "Programa"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'Gb_Manual
        '
        Me.Gb_Manual.Controls.Add(Me.Botao_Desligar)
        Me.Gb_Manual.Controls.Add(Me.Botao_Ligar)
        Me.Gb_Manual.Location = New System.Drawing.Point(15, 99)
        Me.Gb_Manual.Name = "Gb_Manual"
        Me.Gb_Manual.Size = New System.Drawing.Size(141, 73)
        Me.Gb_Manual.TabIndex = 1
        Me.Gb_Manual.TabStop = False
        Me.Gb_Manual.Text = "Manual"
        '
        'Botao_Desligar
        '
        Me.Botao_Desligar.Location = New System.Drawing.Point(6, 43)
        Me.Botao_Desligar.Name = "Botao_Desligar"
        Me.Botao_Desligar.Size = New System.Drawing.Size(128, 23)
        Me.Botao_Desligar.TabIndex = 1
        Me.Botao_Desligar.Text = "&Desligar Bomba"
        Me.Botao_Desligar.UseVisualStyleBackColor = True
        '
        'Botao_Ligar
        '
        Me.Botao_Ligar.Location = New System.Drawing.Point(6, 14)
        Me.Botao_Ligar.Name = "Botao_Ligar"
        Me.Botao_Ligar.Size = New System.Drawing.Size(128, 23)
        Me.Botao_Ligar.TabIndex = 0
        Me.Botao_Ligar.Text = "&Ligar Bomba"
        Me.Botao_Ligar.UseVisualStyleBackColor = True
        '
        'Label_statusbomba
        '
        Me.Label_statusbomba.AutoSize = True
        Me.Label_statusbomba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_statusbomba.ForeColor = System.Drawing.Color.Red
        Me.Label_statusbomba.Location = New System.Drawing.Point(254, 37)
        Me.Label_statusbomba.Name = "Label_statusbomba"
        Me.Label_statusbomba.Size = New System.Drawing.Size(109, 16)
        Me.Label_statusbomba.TabIndex = 2
        Me.Label_statusbomba.Text = "Sem informação!"
        '
        'Botao_N1
        '
        Me.Botao_N1.Location = New System.Drawing.Point(6, 39)
        Me.Botao_N1.Name = "Botao_N1"
        Me.Botao_N1.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N1.TabIndex = 3
        Me.Botao_N1.Text = "1"
        Me.Botao_N1.UseVisualStyleBackColor = True
        '
        'Botao_N3
        '
        Me.Botao_N3.Location = New System.Drawing.Point(107, 39)
        Me.Botao_N3.Name = "Botao_N3"
        Me.Botao_N3.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N3.TabIndex = 4
        Me.Botao_N3.Text = "3"
        Me.Botao_N3.UseVisualStyleBackColor = True
        '
        'Botao_N4
        '
        Me.Botao_N4.Location = New System.Drawing.Point(6, 76)
        Me.Botao_N4.Name = "Botao_N4"
        Me.Botao_N4.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N4.TabIndex = 5
        Me.Botao_N4.Text = "4"
        Me.Botao_N4.UseVisualStyleBackColor = True
        '
        'Botao_N5
        '
        Me.Botao_N5.Location = New System.Drawing.Point(56, 76)
        Me.Botao_N5.Name = "Botao_N5"
        Me.Botao_N5.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N5.TabIndex = 6
        Me.Botao_N5.Text = "5"
        Me.Botao_N5.UseVisualStyleBackColor = True
        '
        'Botao_N6
        '
        Me.Botao_N6.Location = New System.Drawing.Point(108, 76)
        Me.Botao_N6.Name = "Botao_N6"
        Me.Botao_N6.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N6.TabIndex = 7
        Me.Botao_N6.Text = "6"
        Me.Botao_N6.UseVisualStyleBackColor = True
        '
        'Botao_N2
        '
        Me.Botao_N2.Location = New System.Drawing.Point(56, 39)
        Me.Botao_N2.Name = "Botao_N2"
        Me.Botao_N2.Size = New System.Drawing.Size(27, 23)
        Me.Botao_N2.TabIndex = 8
        Me.Botao_N2.Text = "2"
        Me.Botao_N2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "--- Sensor 6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "--- Sensor 5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "--- Sensor 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "--- Sensor 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "--- Sensor 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "--- Sensor 1"
        '
        'Timer_Leitura
        '
        Me.Timer_Leitura.Enabled = True
        Me.Timer_Leitura.Interval = 2000
        '
        'Timer_Enviar_A
        '
        Me.Timer_Enviar_A.Enabled = True
        Me.Timer_Enviar_A.Interval = 1000
        '
        'GB_Autom
        '
        Me.GB_Autom.Controls.Add(Me.Label7)
        Me.GB_Autom.Controls.Add(Me.Botao_N5)
        Me.GB_Autom.Controls.Add(Me.Botao_N2)
        Me.GB_Autom.Controls.Add(Me.Botao_N3)
        Me.GB_Autom.Controls.Add(Me.Botao_N4)
        Me.GB_Autom.Controls.Add(Me.Botao_N1)
        Me.GB_Autom.Controls.Add(Me.Botao_N6)
        Me.GB_Autom.Location = New System.Drawing.Point(15, 180)
        Me.GB_Autom.Name = "GB_Autom"
        Me.GB_Autom.Size = New System.Drawing.Size(141, 105)
        Me.GB_Autom.TabIndex = 16
        Me.GB_Autom.TabStop = False
        Me.GB_Autom.Text = "Automático"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sensores:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 66)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de controle:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Manual"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Automático"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Timer_Enviar_M
        '
        Me.Timer_Enviar_M.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Bomba:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Porta Serial:"
        '
        'Label_statusporta
        '
        Me.Label_statusporta.AutoSize = True
        Me.Label_statusporta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_statusporta.ForeColor = System.Drawing.Color.Red
        Me.Label_statusporta.Location = New System.Drawing.Point(254, 69)
        Me.Label_statusporta.Name = "Label_statusporta"
        Me.Label_statusporta.Size = New System.Drawing.Size(100, 16)
        Me.Label_statusporta.TabIndex = 20
        Me.Label_statusporta.Text = "Desconectado!"
        '
        'Timer_Encher
        '
        Me.Timer_Encher.Interval = 1000
        '
        'barradeprogresso
        '
        Me.barradeprogresso.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.barradeprogresso.Location = New System.Drawing.Point(162, 117)
        Me.barradeprogresso.Name = "barradeprogresso"
        Me.barradeprogresso.Size = New System.Drawing.Size(155, 168)
        Me.barradeprogresso.TabIndex = 9
        Me.barradeprogresso.Value = 94
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 296)
        Me.Controls.Add(Me.Label_statusporta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GB_Autom)
        Me.Controls.Add(Me.barradeprogresso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_statusbomba)
        Me.Controls.Add(Me.Gb_Manual)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Supervisório"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Gb_Manual.ResumeLayout(False)
        Me.GB_Autom.ResumeLayout(False)
        Me.GB_Autom.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gb_Manual As System.Windows.Forms.GroupBox
    Friend WithEvents Botao_Desligar As System.Windows.Forms.Button
    Friend WithEvents Botao_Ligar As System.Windows.Forms.Button
    Friend WithEvents Label_statusbomba As System.Windows.Forms.Label
    Friend WithEvents Botao_N1 As System.Windows.Forms.Button
    Friend WithEvents Botao_N3 As System.Windows.Forms.Button
    Friend WithEvents Botao_N4 As System.Windows.Forms.Button
    Friend WithEvents Botao_N5 As System.Windows.Forms.Button
    Friend WithEvents Botao_N6 As System.Windows.Forms.Button
    Friend WithEvents Botao_N2 As System.Windows.Forms.Button
    Friend WithEvents barradeprogresso As Comunicação_Laser.MyVerticalProgessBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer_Leitura As System.Windows.Forms.Timer
    Friend WithEvents Timer_Enviar_A As System.Windows.Forms.Timer
    Friend WithEvents GB_Autom As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer_Enviar_M As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_statusporta As System.Windows.Forms.Label
    Friend WithEvents Timer_Encher As System.Windows.Forms.Timer
End Class
