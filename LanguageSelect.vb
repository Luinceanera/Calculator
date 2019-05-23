Imports System.IO
Public Class LanguageSelect
    Sub LanguageEnglish(sender As Object, e As EventArgs) Handles buttonEnglish.Click
        Calculation.Show()
        Calculation.SetLanguage("English")
        Me.Close()
    End Sub
    Sub LanguageFrench(sender As Object, e As EventArgs) Handles buttonFrench.Click
        Calculation.Show()
        Calculation.SetLanguage("French")
        Me.Close()
    End Sub
    Sub LanguageGerman(sender As Object, e As EventArgs) Handles buttonGerman.Click
        Calculation.Show()
        Calculation.SetLanguage("German")
        Me.Close()
    End Sub
    Sub LanguageItalian(sender As Object, e As EventArgs) Handles buttonItalian.Click
        Calculation.Show()
        Calculation.SetLanguage("Italian")
        Me.Close()
    End Sub
    Sub LanguagePortuguese(sender As Object, e As EventArgs) Handles buttonPortuguese.Click
        Calculation.Show()
        Calculation.SetLanguage("Portuguese")
        Me.Close()
    End Sub
    Sub LanguageSpanish(sender As Object, e As EventArgs) Handles buttonSpanish.Click
        Calculation.Show()
        Calculation.SetLanguage("Spanish")
        Me.Close()
    End Sub
    Sub LoadCalculator(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If System.IO.File.Exists("Calculation.txt") Then
            Dim calculatorFileRead As StreamReader = File.OpenText("Calculation.txt")
            Dim array(28) As String
            Dim text As String
            Dim b As Integer = 0
            text = calculatorFileRead.ReadLine()
            calculatorFileRead.Close()
            Dim textArray() As String = Split(text)
            For i As Integer = 0 To textArray.Length - 1
                If textArray(i) = " " Then
                    'Do Nothing'
                Else
                    array(b) = textArray(i)
                    b += 1
                End If
                'Coming Soon'
            Next
            Calculation.Show()
            Calculation.SetLanguage(array(0))
            Me.Close()
        End If
    End Sub
End Class