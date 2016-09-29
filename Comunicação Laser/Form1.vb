Public Class Form_Principal
    Public Valor As Integer = 0
    Public Nivel As Integer = 0
    Public Captura As String = "0"
    Dim Ligar As Char = "L"
    Dim Desligar As Char = "D"
    Dim Enviar_Manual As Boolean
    Dim StatusBomba As Boolean
    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Form_Config.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Leitura.Tick

        If Form_Config.SerialPort1.IsOpen Then
            Try
                Captura = Form_Config.SerialPort1.ReadLine
            Catch
            End Try
            Form_Config.SerialPort1.DiscardInBuffer()

            If StatusBomba = True Then
                Label_statusbomba.Text = "Ligada!"
                Label_statusbomba.ForeColor = Color.Green
            ElseIf StatusBomba = False Then
                Label_statusbomba.Text = "Desligada!"
                Label_statusbomba.ForeColor = Color.Red
            End If

        End If

        If Captura = "G" Then
            barradeprogresso.Value = 95
            Nivel = 6
            StatusBomba = True
        ElseIf Captura = "F" Then
            barradeprogresso.Value = 77
            Nivel = 5
            StatusBomba = True
        ElseIf Captura = "E" Then
            barradeprogresso.Value = 59
            Nivel = 4
            StatusBomba = True
        ElseIf Captura = "D" Then
            barradeprogresso.Value = 41
            Nivel = 3
            StatusBomba = True
        ElseIf Captura = "C" Then
            barradeprogresso.Value = 23
            Nivel = 2
            StatusBomba = True
        ElseIf Captura = "B" Then
            barradeprogresso.Value = 5
            Nivel = 1
            StatusBomba = True
        ElseIf Captura = "A" Then
            barradeprogresso.Value = 0
            Nivel = 0
            StatusBomba = True

        ElseIf Captura = "g" Then
            barradeprogresso.Value = 95
            Nivel = 6
            StatusBomba = False
        ElseIf Captura = "f" Then
            barradeprogresso.Value = 77
            Nivel = 5
            StatusBomba = False
        ElseIf Captura = "e" Then
            barradeprogresso.Value = 59
            Nivel = 4
            StatusBomba = False
        ElseIf Captura = "d" Then
            barradeprogresso.Value = 41
            Nivel = 3
            StatusBomba = False
        ElseIf Captura = "c" Then
            barradeprogresso.Value = 23
            Nivel = 2
            StatusBomba = False
        ElseIf Captura = "b" Then
            barradeprogresso.Value = 5
            Nivel = 1
            StatusBomba = False
        ElseIf Captura = "a" Then
            barradeprogresso.Value = 0
            Nivel = 0
            StatusBomba = False

        End If

    End Sub

    Private Sub Botao_N1_Click(sender As Object, e As EventArgs) Handles Botao_N1.Click

        Valor = 1

        Botao_N1.Enabled = False
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Blue
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub Form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Checked = True
        barradeprogresso.Value = 95
        Nivel = 6

        Valor = 1

        Botao_N1.Enabled = False
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Blue

    End Sub

    Private Sub Botao_N2_Click(sender As Object, e As EventArgs) Handles Botao_N2.Click

        Valor = 2

        Botao_N1.Enabled = True
        Botao_N2.Enabled = False
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Blue
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub Botao_N3_Click(sender As Object, e As EventArgs) Handles Botao_N3.Click

        Valor = 3

        Botao_N1.Enabled = True
        Botao_N2.Enabled = True
        Botao_N3.Enabled = False
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Blue
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub Botao_N4_Click(sender As Object, e As EventArgs) Handles Botao_N4.Click

        Valor = 4

        Botao_N1.Enabled = True
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = False
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Blue
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub Botao_N5_Click(sender As Object, e As EventArgs) Handles Botao_N5.Click

        Valor = 5

        Botao_N1.Enabled = True
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = False
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Blue
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub Botao_N6_Click(sender As Object, e As EventArgs) Handles Botao_N6.Click

        Valor = 6

        Botao_N1.Enabled = True
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = False
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Blue

    End Sub

    Private Sub Timer_Enviar_Tick(sender As Object, e As EventArgs) Handles Timer_Enviar_A.Tick

        If Form_Config.SerialPort1.IsOpen Then
            If Nivel < Valor Then
                Timer_Encher.Enabled = True
                Timer_Enviar_A.Enabled = False
            ElseIf Nivel >= Valor Then
                Form_Config.SerialPort1.Write(Desligar)
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GB_Autom.Enabled = True
        Gb_Manual.Enabled = False
        Timer_Enviar_A.Enabled = True
        Timer_Enviar_M.Enabled = False
        Botao_N1.Enabled = False
        Botao_N2.Enabled = True
        Botao_N3.Enabled = True
        Botao_N4.Enabled = True
        Botao_N5.Enabled = True
        Botao_N6.Enabled = True
        Label6.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GB_Autom.Enabled = False
        Gb_Manual.Enabled = True
        Timer_Encher.Enabled = False
        Timer_Enviar_A.Enabled = False
        Timer_Enviar_M.Enabled = True
        Enviar_Manual = False
        Botao_Desligar.Enabled = False
        Botao_Ligar.Enabled = True
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Botao_Ligar_Click(sender As Object, e As EventArgs) Handles Botao_Ligar.Click
        Botao_Desligar.Enabled = True
        Botao_Ligar.Enabled = False
        Enviar_Manual = True
    End Sub

    Private Sub Botao_Desligar_Click(sender As Object, e As EventArgs) Handles Botao_Desligar.Click
        Botao_Desligar.Enabled = False
        Botao_Ligar.Enabled = True
        Enviar_Manual = False
    End Sub

    Private Sub Timer_Enviar_M_Tick(sender As Object, e As EventArgs) Handles Timer_Enviar_M.Tick
        If Form_Config.SerialPort1.IsOpen Then
            If Enviar_Manual = True Then
                Form_Config.SerialPort1.Write(Ligar)
                If Nivel = 6 Then
                    Botao_Desligar.Enabled = False
                    Botao_Ligar.Enabled = True
                    Enviar_Manual = False
                End If
            Else
                Form_Config.SerialPort1.Write(Desligar)
            End If
        End If
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Form_Sobre.ShowDialog()
    End Sub

    Private Sub Timer_Encher_Tick(sender As Object, e As EventArgs) Handles Timer_Encher.Tick

        If Form_Config.SerialPort1.IsOpen Then
            If Nivel < 6 Then
                Form_Config.SerialPort1.Write(Ligar)
            ElseIf Nivel = 6 Then
                Timer_Encher.Enabled = False
                Timer_Enviar_A.Enabled = True
            End If
        End If
    End Sub
End Class