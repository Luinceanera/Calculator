Class Source : Inherits Calculation
    Function GetLetterStored(letter As String, language As String) As String
        Select Case language
            Case "English"
                Return "Stored on Storage " + letter
            Case "French"
                Return "Stocké sur le stockage " + letter
            Case "German"
                Return "Aufbewahrung " + letter
            Case "Italian"
                Return "Memorizzato nella memoria " + letter
            Case "Portuguese"
                Return "Armazenado no Armazenamento " + letter
            Case "Spanish"
                Return "Almacenado en Almacenamiento " + letter
        End Select
        Return ""
    End Function
    Function GetError(letter As String, language As String) As String
        Dim messageLetter As String = ""
        Select Case letter
            ' Sin-1 and Cos-1 '
            Case "InvSinCosCscCotOutOfRange"
                Select Case language
                    Case "English"
                        messageLetter = "Error: When Solving for Inverse Sin, Cosine, Cosecant, and/or Secant, make sure you insert a value that is no greater than 1 and no less than -1."
                    Case "French"
                        messageLetter = "Erreur: Lors de la résolution du sinus inverse, du cosinus, du cosécant et/ou de la sécante, veillez à insérer une valeur comprise entre 1 et -1."
                    Case "German"
                        messageLetter = "Fehler: Wenn Sie nach Inversem Sinus, Cosinus, Cosecantus und / oder Secantus suchen, müssen Sie einen Wert eingeben, der nicht größer als 1 und nicht kleiner als -1 ist."
                    Case "Italian"
                        messageLetter = "Errore: quando si risolve Seno inverso, Coseno, Cosecante e / o Secante, assicurarsi di inserire un valore non superiore a 1 e non inferiore a -1."
                    Case "Portuguese"
                        messageLetter = "Erro: Ao resolver Seno Inverso, Cosine, Cosecant e/ou Secant, insira um valor que não seja maior que 1 e que não seja menor que -1."
                    Case "Spanish"
                        messageLetter = "Error: al resolver el seno inverso, coseno, cosecante y / o secante, asegúrese de insertar un valor que no sea mayor que 1 y no menor que -1."
                End Select
        End Select
        Return messageLetter
    End Function
    Function RCLFunction(language As String) As String
        Dim messageLetter As String = ""
        Select Case language
            Case "English"
                messageLetter = "The following entries are currently holding their value:"
            Case "French"
                messageLetter = "Les entrées suivantes conservent actuellement leur valeur:"
            Case "German"
                messageLetter = "Die folgenden Einträge behalten derzeit ihren Wert:"
            Case "Italian"
                messageLetter = "Le seguenti voci stanno attualmente tenendo il loro valore:"
            Case "Portuguese"
                messageLetter = "As seguintes entradas estão atualmente mantendo seu valor:"
            Case "Spanish"
                messageLetter = "Las siguientes entradas mantienen actualmente su valor:"
        End Select
        Return messageLetter
    End Function
End Class


'Select Case language
'Case "English"
'
'Case "French"
'
'Case "German"
'
'Case "Italian"
'
'Case "Portuguese"
'
'Case "Spanish"
'
'End Select
