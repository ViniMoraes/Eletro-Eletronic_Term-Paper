Imports System.IO.Ports
Public Class Form_Config
    Private Sub Form_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SerialPort1.IsOpen Then
            Label_StatusSerial.Text = "Conectado!"
        Else
            Label_StatusSerial.Text = "Desconectado!"
        End If
        ComboBox_PortaSerial.Items.Clear()
        For Each PortaCOM As String In SerialPort.GetPortNames
            ComboBox_PortaSerial.Items.Add(PortaCOM)
        Next
    End Sub

    Private Sub Botao_Conectar_Click(sender As Object, e As EventArgs) Handles Botao_Conectar.Click
        Botao_Conectar.Enabled = False
        If ComboBox_PortaSerial.Text = "" Then
            MsgBox("Selecione uma porta!", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            SerialPort1.PortName = ComboBox_PortaSerial.Text()
            SerialPort1.Open()
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical)
        End Try

        SerialPort1.DiscardOutBuffer()

    End Sub

    Private Sub Botao_Desconectar_Click(sender As Object, e As EventArgs) Handles Botao_Desconectar.Click
        Botao_Desconectar.Enabled = False
        Try
            SerialPort1.Close()
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Botao_Voltar_Click(sender As Object, e As EventArgs) Handles Botao_Voltar.Click
        Me.Close()
    End Sub

    Private Sub Timer_Status_Tick(sender As Object, e As EventArgs) Handles Timer_Status.Tick
        If SerialPort1.IsOpen Then
            Botao_Conectar.Enabled = False
            Botao_Desconectar.Enabled = True
            Label_StatusSerial.Text = "Conectado!"
            Label_StatusSerial.ForeColor = Color.Green
            Form_Principal.Label_statusporta.Text = "Conectado!"
            Form_Principal.Label_statusporta.ForeColor = Color.Green
        Else
            Botao_Conectar.Enabled = True
            Botao_Desconectar.Enabled = False
            Label_StatusSerial.Text = "Desconectado!"
            Label_StatusSerial.ForeColor = Color.Red
            Form_Principal.Label_statusporta.Text = "Desconectado!"
            Form_Principal.Label_statusporta.ForeColor = Color.Red
            Form_Principal.Label_statusbomba.Text = "Sem informação!"
            Form_Principal.Label_statusbomba.ForeColor = Color.Red
        End If
    End Sub
End Class