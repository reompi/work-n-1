﻿
Public Class userform

    Private ticker2 As Integer

    Private Sub entradasbutao_Click(sender As Object, e As EventArgs) Handles entradasbutao.Click

        If empregados(usernumero).flag = False And empregados(usernumero).dianterior = DateTime.Now.Day Then
            Exit Sub
        End If

        ReDim Preserve empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)

        ReDim Preserve empregados(usernumero).quandosaiohoras(DateTime.Now.Month, quantosdiastemes)

        ReDim Preserve empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, quantosdiastemes)

        ReDim Preserve empregados(usernumero).quandosaiominutos(DateTime.Now.Month, quantosdiastemes)

        empregados(usernumero).dianterior = DateTime.Now.Day


        If empregados(usernumero).tickermarcada Mod 2 = 0 Then
            Label1.Text = ("saída")
            entradasbutao.Image = My.Resources.poweroff
            empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Hours
            empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Minutes
            Label2.Text = empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, DateTime.Now.Day).ToString & " : " & empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            empregados(usernumero).flag = True
        Else
            Label1.Text = ("entrada")
            entradasbutao.Image = My.Resources.poweron
            empregados(usernumero).quandosaiohoras(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Hours
            empregados(usernumero).quandosaiominutos(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Minutes
            Label2.Text = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, DateTime.Now.Day).ToString & " : " & empregados(usernumero).quandosaiominutos(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            empregados(usernumero).flag = False

        End If
        empregados(usernumero).tickermarcada += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ticker2 += 1
        If ticker2 = 15 Then
            Timer1.Stop()
            Label2.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        login.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        userformdados.Show()
    End Sub


End Class