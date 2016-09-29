<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Config
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
        Me.ComboBox_PortaSerial = New System.Windows.Forms.ComboBox()
        Me.Botao_Conectar = New System.Windows.Forms.Button()
        Me.Botao_Desconectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_StatusSerial = New System.Windows.Forms.Label()
        Me.Botao_Voltar = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_Status = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox_PortaSerial
        '
        Me.ComboBox_PortaSerial.FormattingEnabled = True
        Me.ComboBox_PortaSerial.Location = New System.Drawing.Point(12, 32)
        Me.ComboBox_PortaSerial.Name = "ComboBox_PortaSerial"
        Me.ComboBox_PortaSerial.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_PortaSerial.TabIndex = 0
        '
        'Botao_Conectar
        '
        Me.Botao_Conectar.Location = New System.Drawing.Point(156, 12)
        Me.Botao_Conectar.Name = "Botao_Conectar"
        Me.Botao_Conectar.Size = New System.Drawing.Size(76, 23)
        Me.Botao_Conectar.TabIndex = 1
        Me.Botao_Conectar.Text = "&Conectar"
        Me.Botao_Conectar.UseVisualStyleBackColor = True
        '
        'Botao_Desconectar
        '
        Me.Botao_Desconectar.Location = New System.Drawing.Point(156, 41)
        Me.Botao_Desconectar.Name = "Botao_Desconectar"
        Me.Botao_Desconectar.Size = New System.Drawing.Size(76, 23)
        Me.Botao_Desconectar.TabIndex = 2
        Me.Botao_Desconectar.Text = "&Desconectar"
        Me.Botao_Desconectar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Porta Serial:"
        '
        'Label_StatusSerial
        '
        Me.Label_StatusSerial.AutoSize = True
        Me.Label_StatusSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_StatusSerial.ForeColor = System.Drawing.Color.Red
        Me.Label_StatusSerial.Location = New System.Drawing.Point(58, 84)
        Me.Label_StatusSerial.Name = "Label_StatusSerial"
        Me.Label_StatusSerial.Size = New System.Drawing.Size(93, 13)
        Me.Label_StatusSerial.TabIndex = 4
        Me.Label_StatusSerial.Text = "Desconectado!"
        '
        'Botao_Voltar
        '
        Me.Botao_Voltar.Location = New System.Drawing.Point(157, 79)
        Me.Botao_Voltar.Name = "Botao_Voltar"
        Me.Botao_Voltar.Size = New System.Drawing.Size(75, 23)
        Me.Botao_Voltar.TabIndex = 5
        Me.Botao_Voltar.Text = "&Voltar"
        Me.Botao_Voltar.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 2400
        Me.SerialPort1.ReadTimeout = 500
        Me.SerialPort1.WriteTimeout = 500
        '
        'Timer_Status
        '
        Me.Timer_Status.Enabled = True
        Me.Timer_Status.Interval = 5000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status:"
        '
        'Form_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 116)
        Me.Controls.Add(Me.Label_StatusSerial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Botao_Voltar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Botao_Desconectar)
        Me.Controls.Add(Me.Botao_Conectar)
        Me.Controls.Add(Me.ComboBox_PortaSerial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Porta Serial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_PortaSerial As System.Windows.Forms.ComboBox
    Friend WithEvents Botao_Conectar As System.Windows.Forms.Button
    Friend WithEvents Botao_Desconectar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_StatusSerial As System.Windows.Forms.Label
    Friend WithEvents Botao_Voltar As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer_Status As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
