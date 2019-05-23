Public Class Credits
    Dim language As String
    Dim version As String
    Sub CreditText(sender As Object, e As EventArgs) Handles Me.Load
        Dim numberValue As Integer
        Dim rand As New Random
        numberValue = rand.Next(50) + 51
        Select Case numberValue
            Case 51
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._51
            Case 52
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._52
            Case 53
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._53
            Case 54
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._54
            Case 55
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._55
            Case 56
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._56
            Case 57
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._57
            Case 58
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._58
            Case 59
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._59
            Case 60
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._60
            Case 61
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._61
            Case 62
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._62
            Case 63
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._63
            Case 64
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._64
            Case 65
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._65
            Case 66
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._66
            Case 67
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._67
            Case 68
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._68
            Case 69
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._69
            Case 70
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._70
            Case 71
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._71
            Case 72
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._72
            Case 73
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._73
            Case 74
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._74
            Case 75
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._75
            Case 76
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._76
            Case 77
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._77
            Case 78
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._78
            Case 79
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._79
            Case 80
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._80
            Case 81
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._81
            Case 82
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._82
            Case 83
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._83
            Case 84
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._84
            Case 85
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._85
            Case 86
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._86
            Case 87
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._87
            Case 88
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._88
            Case 89
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._89
            Case 90
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._90
            Case 91
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._91
            Case 92
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._92
            Case 93
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._93
            Case 94
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._94
            Case 95
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._95
            Case 96
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._96
            Case 97
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._97
            Case 98
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._98
            Case 99
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._99
            Case 100
                Me.BackgroundImage = Global.Calculator.My.Resources.Resources._100
        End Select
        language = Calculation.GetLanguage()
        version = Calculation.GetVersion()
        Select Case language
            Case "English"
                buttonOK.Text = "Close"
                labelInformation.Text = "Version " + version + vbNewLine + "Contributors: Luis Cerrillo"
            Case "French"
                buttonOK.Text = "Sortie"
                labelInformation.Text = "Version " + version + vbNewLine + "Contributeurs: Luis Cerrillo"
            Case "German"
                buttonOK.Text = "Schließen"
                labelInformation.Text = "Ausführung " + version + vbNewLine + "Mitwirkende: Luis Cerrillo"
            Case "Italian"
                buttonOK.Text = "Uscita"
                labelInformation.Text = "Versione " + version + vbNewLine + "Contributori: Luis Cerrillo"
            Case "Portuguese"
                buttonOK.Text = "Sair"
                labelInformation.Text = "Versão: " + version + vbNewLine + "Colaboradores: Luis Cerrillo"
            Case "Spanish"
                buttonOK.Text = "Salir"
                labelInformation.Text = "Versión " + version + vbNewLine + "Contribuyentes: Luis Cerrillo"
        End Select
    End Sub
    Sub ExitButton(sender As Object, e As EventArgs) Handles buttonOK.Click
        Me.Close()
    End Sub
End Class