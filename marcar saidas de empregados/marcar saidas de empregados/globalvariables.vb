﻿Module globalvariables
    Public Structure empregado
        Dim nome As String
        Dim palavrapasse As String
        Dim quandoentrou(,) As String
        Dim quandosaio(,) As String

    End Structure

    Public Structure admins
        Dim nome As String
        Dim palavrapasse As String
    End Structure

    Public empregados(0) As empregado
    Public admin(0) As admins
    Public usernumero As Integer



End Module