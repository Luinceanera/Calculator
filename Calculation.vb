Imports System.IO
Imports System.Math

Public Class Calculation
    Dim answer As Double
    ReadOnly alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim calculatorFileRead As StreamReader
    Dim calculatorFileWrite As StreamWriter
    Dim entry1 As Double = 0
    Dim entry2 As Double = 0
    ReadOnly fileDirectory As String = "Calculation.txt"
    Dim language As String
    ReadOnly letterEntry(27) As Double
    Dim operations As Integer
    Dim operatorFunction As Boolean = False
    Dim power As Boolean = False
    Dim result As Boolean = False
    Dim second As Boolean = False
    Dim storage As Boolean = False
    Dim circleMode As String = "Radians"
    ReadOnly version As String = "1.A1"

    Sub Addition(sender As Object, e As EventArgs) Handles buttonAdd.Click
        entry1 = CDec(textBoxOutputMain.Text)
        EntryAlternative()
        If entry1 < 0 Then
            textBoxOutput.Text += "(" + entry1.ToString + ")"
        Else
            textBoxOutput.Text += entry1.ToString
        End If
        textBoxOutput.Text += " + "
        textBoxOutputMain.Text = "0"
        operatorFunction = True
        operations = 1 ' = + 
        CalculatorCheck()
    End Sub
    Sub Backspace(sender As Object, e As EventArgs) Handles buttonBackSpace.Click
        If textBoxOutputMain.Text.Length > 1 Then
            textBoxOutputMain.Text = textBoxOutputMain.Text.Remove(textBoxOutputMain.Text.Length - 1, 1)
        ElseIf textBoxOutputMain.Text = "0" Then
            'Do Nothing'
        Else
            textBoxOutputMain.Text = "0"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry0(sender As Object, e As EventArgs) Handles button0.Click
        If result = True Then
            textBoxOutputMain.Text = "0"
            textBoxOutput.Text = ""
            result = False
        Else
            If textBoxOutputMain.Text <> "0" Then
                textBoxOutputMain.Text += "0"
            Else
                textBoxOutputMain.Text = "0"
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry1(sender As Object, e As EventArgs) Handles button1.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "1"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "1"
            End If
        Else
            textBoxOutputMain.Text = "1"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry2(sender As Object, e As EventArgs) Handles button2.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "2"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "2"
            End If
        Else
            textBoxOutputMain.Text = "2"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry3(sender As Object, e As EventArgs) Handles button3.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "3"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "3"
            End If
        Else
            textBoxOutputMain.Text = "3"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry4(sender As Object, e As EventArgs) Handles button4.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "4"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "4"
            End If
        Else
            textBoxOutputMain.Text = "4"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry5(sender As Object, e As EventArgs) Handles button5.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "5"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "5"
            End If
        Else
            textBoxOutputMain.Text = "5"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry6(sender As Object, e As EventArgs) Handles button6.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "6"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "6"
            End If
        Else
            textBoxOutputMain.Text = "6"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry7(sender As Object, e As EventArgs) Handles button7.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "7"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "7"
            End If
        Else
            textBoxOutputMain.Text = "7"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry8(sender As Object, e As EventArgs) Handles button8.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "8"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "8"
            End If
        Else
            textBoxOutputMain.Text = "8"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntry9(sender As Object, e As EventArgs) Handles button9.Click
        If textBoxOutputMain.Text <> "0" Then
            If result = True Then
                textBoxOutputMain.Text = "9"
                textBoxOutput.Text = ""
                result = False
            Else
                textBoxOutputMain.Text += "9"
            End If
        Else
            textBoxOutputMain.Text = "9"
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryA(sender As Object, e As EventArgs) Handles buttonA.Click
        If storage = True Then
            letterEntry(0) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("A", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(0).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryB(sender As Object, e As EventArgs) Handles buttonB.Click
        If storage = True Then
            letterEntry(1) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("B", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(1).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryC(sender As Object, e As EventArgs) Handles buttonC.Click
        If storage = True Then
            letterEntry(2) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("C", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(2).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryD(sender As Object, e As EventArgs) Handles buttonD.Click
        If storage = True Then
            letterEntry(3) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("D", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(3).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryE(sender As Object, e As EventArgs) Handles buttonE.Click
        If storage = True Then
            letterEntry(4) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("E", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(4).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryF(sender As Object, e As EventArgs) Handles buttonF.Click
        If storage = True Then
            letterEntry(5) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("F", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(5).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryG(sender As Object, e As EventArgs) Handles buttonG.Click
        If storage = True Then
            letterEntry(6) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("G", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(6).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryH(sender As Object, e As EventArgs) Handles buttonH.Click
        If storage = True Then
            letterEntry(7) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("H", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(7).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryI(sender As Object, e As EventArgs) Handles buttonI.Click
        If storage = True Then
            letterEntry(8) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("I", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(8).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryJ(sender As Object, e As EventArgs) Handles buttonJ.Click
        If storage = True Then
            letterEntry(9) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("J", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(9).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryK(sender As Object, e As EventArgs) Handles buttonK.Click
        If storage = True Then
            letterEntry(10) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("K", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(10).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryL(sender As Object, e As EventArgs) Handles buttonL.Click
        If storage = True Then
            letterEntry(11) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("L", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(11).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryM(sender As Object, e As EventArgs) Handles buttonM.Click
        If storage = True Then
            letterEntry(12) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("M", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(12).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryN(sender As Object, e As EventArgs) Handles buttonN.Click
        If storage = True Then
            letterEntry(13) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("N", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(13).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryO(sender As Object, e As EventArgs) Handles buttonO.Click
        If storage = True Then
            letterEntry(14) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("O", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(14).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryP(sender As Object, e As EventArgs) Handles buttonP.Click
        If storage = True Then
            letterEntry(15) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("P", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(15).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryQ(sender As Object, e As EventArgs) Handles buttonQ.Click
        If storage = True Then
            letterEntry(16) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("Q", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(16).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryR(sender As Object, e As EventArgs) Handles buttonR.Click
        If storage = True Then
            letterEntry(17) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("R", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(17).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryS(sender As Object, e As EventArgs) Handles buttonS.Click
        If storage = True Then
            letterEntry(18) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("S", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(18).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryT(sender As Object, e As EventArgs) Handles buttonT.Click
        If storage = True Then
            letterEntry(19) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("T", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(19).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryU(sender As Object, e As EventArgs) Handles buttonU.Click
        If storage = True Then
            letterEntry(20) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("U", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(20).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryV(sender As Object, e As EventArgs) Handles buttonV.Click
        If storage = True Then
            letterEntry(21) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("V", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(21).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryW(sender As Object, e As EventArgs) Handles buttonW.Click
        If storage = True Then
            letterEntry(22) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("W", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(22).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryX(sender As Object, e As EventArgs) Handles buttonX.Click
        If storage = True Then
            letterEntry(23) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("X", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(23).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryY(sender As Object, e As EventArgs) Handles buttonY.Click
        If storage = True Then
            letterEntry(24) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("Y", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(24).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonEntryZ(sender As Object, e As EventArgs) Handles buttonZ.Click
        If storage = True Then
            letterEntry(25) = CDec(textBoxOutputMain.Text)
            labelActivity.Text = Source.GetLetterStored("Z", language)
            storage = False
            labelStorage.Text = ""
        Else
            textBoxOutputMain.Text = letterEntry(25).ToString
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonSecond_Click(sender As Object, e As EventArgs) Handles buttonSecond.Click
        If labelSecond.Text = "" Then
            labelSecond.Text = "2nd"
            second = True
        Else
            labelSecond.Text = ""
            second = False
        End If
        CalculatorCheck()
    End Sub
    Sub ButtonStorage_Click(sender As Object, e As EventArgs) Handles buttonStorage.Click
        If labelStorage.Text = "" Then
            labelStorage.Text = "1→A"
            storage = True
        Else
            labelStorage.Text = ""
            storage = False
        End If
        CalculatorCheck()
    End Sub
    Sub DateAndTimeInsertion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim month As String
        Dim day As String
        Dim year As String
        Dim dayOfWeek As String
        Dim hour As Integer
        Dim minute As String
        Dim second As String
        Dim milliSecond As String
        Dim category As String

        day = DateTime.Now.Day.ToString
        year = DateTime.Now.Year.ToString
        dayOfWeek = DateTime.Now.DayOfWeek.ToString

        If (DateTime.Now.Hour = 0) Then
            hour = 12
            category = " Ante Meridiem"
        ElseIf (DateTime.Now.Hour < 12) Then
            hour = DateTime.Now.Hour
            category = " Ante Meridiem"
        ElseIf (DateTime.Now.Hour = 12) Then
            hour = DateTime.Now.Hour
            category = "Prime Meridiem"
        Else
            hour = DateTime.Now.Hour - 12
            category = "Prime Meridiem"
        End If
        If (DateTime.Now.Minute < 10) Then
            minute = "0" + DateTime.Now.Minute.ToString()
        Else
            minute = DateTime.Now.Minute.ToString()
        End If
        If (DateTime.Now.Second < 10) Then
            second = "0" + DateTime.Now.Second.ToString()
        Else
            second = DateTime.Now.Second.ToString()
        End If
        If (DateTime.Now.Millisecond < 10) Then
            milliSecond = "00" + DateTime.Now.Millisecond.ToString()
        ElseIf (DateTime.Now.Millisecond < 100) Then
            milliSecond = "0" + DateTime.Now.Millisecond.ToString()
        Else
            milliSecond = DateTime.Now.Millisecond.ToString()
        End If
        Select Case language
            Case "English"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Sunday"
                    Case "Monday"
                        dayOfWeek = "Monday"
                    Case "Tuesday"
                        dayOfWeek = "Tuesday"
                    Case "Wednesday"
                        dayOfWeek = "Wednesday"
                    Case "Thursday"
                        dayOfWeek = "Thursday"
                    Case "Friday"
                        dayOfWeek = "Friday"
                    Case "Saturday"
                        dayOfWeek = "Saturday"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "January"
                    Case 2
                        month = "February"
                    Case 3
                        month = "March"
                    Case 4
                        month = "April"
                    Case 5
                        month = "May"
                    Case 6
                        month = "June"
                    Case 7
                        month = "July"
                    Case 8
                        month = "August"
                    Case 9
                        month = "September"
                    Case 10
                        month = "October"
                    Case 11
                        month = "November"
                    Case 12
                        month = "December"
                End Select
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                labelDate.Text = dayOfWeek + " " + month + " " + day + ", " + year.ToString()
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
            Case "French"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Dimanche"
                    Case "Monday"
                        dayOfWeek = "Lundi"
                    Case "Tuesday"
                        dayOfWeek = "Mardi"
                    Case "Wednesday"
                        dayOfWeek = "Mercredi"
                    Case "Thursday"
                        dayOfWeek = "Jeudi"
                    Case "Friday"
                        dayOfWeek = "Vendredi"
                    Case "Saturday"
                        dayOfWeek = "Samedi"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "Janvier"
                    Case 2
                        month = "Février"
                    Case 3
                        month = "Mars"
                    Case 4
                        month = "Avril"
                    Case 5
                        month = "Mai"
                    Case 6
                        month = "Juin"
                    Case 7
                        month = "Juillet"
                    Case 8
                        month = "Août"
                    Case 9
                        month = "Septembre"
                    Case 10
                        month = "Octobre"
                    Case 11
                        month = "Novembre"
                    Case 12
                        month = "Décembre"
                End Select
                labelDate.Text = dayOfWeek + " " + day + " " + month + ", " + year.ToString()
            Case "German"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Sonntag"
                    Case "Monday"
                        dayOfWeek = "Montag"
                    Case "Tuesday"
                        dayOfWeek = "Dienstag"
                    Case "Wednesday"
                        dayOfWeek = "Mittwoch"
                    Case "Thursday"
                        dayOfWeek = "Donnerstag"
                    Case "Friday"
                        dayOfWeek = "Freitag"
                    Case "Saturday"
                        dayOfWeek = "Samstag"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "Januar"
                    Case 2
                        month = "Februar"
                    Case 3
                        month = "März"
                    Case 4
                        month = "April"
                    Case 5
                        month = "Mai"
                    Case 6
                        month = "Juni"
                    Case 7
                        month = "Juli"
                    Case 8
                        month = "August"
                    Case 9
                        month = "September"
                    Case 10
                        month = "Oktober"
                    Case 11
                        month = "November"
                    Case 12
                        month = "Dezember"
                End Select
                labelDate.Text = dayOfWeek + " " + day + " " + month + ", " + year.ToString()
            Case "Italian"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Domenica"
                    Case "Monday"
                        dayOfWeek = "Lunedi"
                    Case "Tuesday"
                        dayOfWeek = "Martedì"
                    Case "Wednesday"
                        dayOfWeek = "Mercoledì"
                    Case "Thursday"
                        dayOfWeek = "Giovedi"
                    Case "Friday"
                        dayOfWeek = "Venerdì"
                    Case "Saturday"
                        dayOfWeek = "Sabato"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "Gennaio"
                    Case 2
                        month = "Febbraio"
                    Case 3
                        month = "Marzo"
                    Case 4
                        month = "Aprile"
                    Case 5
                        month = "Maggio"
                    Case 6
                        month = "Giugno"
                    Case 7
                        month = "Luglio"
                    Case 8
                        month = "Agosto"
                    Case 9
                        month = "Settembre"
                    Case 10
                        month = "Ottobre"
                    Case 11
                        month = "Novembre"
                    Case 12
                        month = "Dicembre"
                End Select
                labelDate.Text = dayOfWeek + " " + day + " " + month + ", " + year.ToString()
            Case "Portugese"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Domingo"
                    Case "Monday"
                        dayOfWeek = "Segunda-Feira"
                    Case "Tuesday"
                        dayOfWeek = "Terça"
                    Case "Wednesday"
                        dayOfWeek = "Quarta-Feira"
                    Case "Thursday"
                        dayOfWeek = "Quinta-Feira"
                    Case "Friday"
                        dayOfWeek = "Sexta-Feira"
                    Case "Saturday"
                        dayOfWeek = "Sábado"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "Janeiro"
                    Case 2
                        month = "Fevereio"
                    Case 3
                        month = "Março"
                    Case 4
                        month = "Abril"
                    Case 5
                        month = "Maio"
                    Case 6
                        month = "Junho"
                    Case 7
                        month = "Julho"
                    Case 8
                        month = "Agosto"
                    Case 9
                        month = "Setembro"
                    Case 10
                        month = "Outubro"
                    Case 11
                        month = "Novembro"
                    Case 12
                        month = "Dezembro"
                End Select
                labelDate.Text = dayOfWeek + " " + day + " de " + month + ", " + year.ToString()
            Case "Spanish"
                Select Case dayOfWeek
                    Case "Sunday"
                        dayOfWeek = "Domingo"
                    Case "Monday"
                        dayOfWeek = "Lunes"
                    Case "Tuesday"
                        dayOfWeek = "Martes"
                    Case "Wednesday"
                        dayOfWeek = "Miércoles"
                    Case "Thursday"
                        dayOfWeek = "Jueves"
                    Case "Friday"
                        dayOfWeek = "Viernes"
                    Case "Saturday"
                        dayOfWeek = "Sábado"
                End Select
                Select Case DateTime.Now.Month
                    Case 1
                        month = "Enero"
                    Case 2
                        month = "Febrero"
                    Case 3
                        month = "Marzo"
                    Case 4
                        month = "Abril"
                    Case 5
                        month = "Mayo"
                    Case 6
                        month = "Junio"
                    Case 7
                        month = "Julio"
                    Case 8
                        month = "Agosto"
                    Case 9
                        month = "Septiembre"
                    Case 10
                        month = "Octubre"
                    Case 11
                        month = "Noviembre"
                    Case 12
                        month = "Diciembre"
                End Select
                labelDate.Text = dayOfWeek + " " + day + " de " + month + ", " + year.ToString()
        End Select
        If (hour < 10) Then
            labelTime.Text = " " + hour.ToString() + ":" + minute + ":" + second + ":" + milliSecond + "   " + category
        Else
            labelTime.Text = hour.ToString() + ":" + minute + ":" + second + ":" + milliSecond + "   " + category
        End If
    End Sub
    Sub Division(sender As Object, e As EventArgs) Handles buttonDivide.Click
        entry1 = CDec(textBoxOutputMain.Text)
        EntryAlternative()
        If entry1 < 0 Then
            textBoxOutput.Text += "(" + entry1.ToString + ")"
        Else
            textBoxOutput.Text += entry1.ToString
        End If
        textBoxOutput.Text += " / "
        textBoxOutputMain.Text = "0"
        operatorFunction = True
        operations = 4 ' /
    End Sub
    Sub Entry(sender As Object, e As EventArgs) Handles buttonEnter.Click
        If operatorFunction = True Then
            entry1 = CDec(textBoxOutputMain.Text)
            result = True
            textBoxOutput.Text += entry1.ToString
            If operations = 1 Then
                answer = entry2 + entry1
            ElseIf operations = 2 Then
                answer = entry2 - entry1
            ElseIf operations = 3 Then
                answer = entry2 * entry1
            ElseIf operations = 4 Then
                If entry1 = 0 Then
                    textBoxOutputMain.Text = "±∞"
                Else
                    answer = entry2 / entry1
                End If
                answer = entry2 / entry1
            ElseIf operations = 5 Then
                answer = entry2 ^ entry1
                '    ElseIf Operations = 6 Then
                '    textBoxOutputMain.Text = CType(entry1 )
            End If
            textBoxOutputMain.Text = CType(answer, String)
            entry1 = 0
            entry2 = 0
            operations = 0
            operatorFunction = False
            result = True
        End If
    End Sub
    Sub EntryAlternative()
        If operations = 0 Then
            entry2 = entry1
        Else
            If operations = 1 Then
                entry2 += entry1
            ElseIf operations = 2 Then
                entry2 -= entry1
            ElseIf operations = 3 Then
                entry2 *= entry1
            ElseIf operations = 4 Then
                If entry1 = 0 Then
                    textBoxOutputMain.Text = "±∞"
                    result = True
                Else
                    entry2 /= entry1
                End If
            ElseIf operations = 5 Then
                entry2 ^= entry1
                '    ElseIf Operations = 6 Then
                '    textBoxOutputMain.Text = CType(entry1)
            End If
        End If
    End Sub
    Sub EntryDouble(sender As Object, e As EventArgs) Handles buttonDecimal.Click
        If Not (textBoxOutputMain.Text.Contains(".")) Then
            textBoxOutputMain.Text += "."
        End If
    End Sub
    Sub ExitDebugger(sender As Object, e As EventArgs) Handles toolTipExit.Click
        End
    End Sub
    Sub TheLanguage(language As String)
        If language = "English" Then
            labelVersion.Text = "Version "
            MenuStrip1.Text = "Calculator"
            toolTipExit.Text = "Exit"
            toolTipFile.Text = "File"
            toolTipInformation.Text = "About"
            toolTipLanguage.Text = "Language"
            toolTipOption.Text = "Options"
        ElseIf language = "French" Then
            labelVersion.Text = "Version "
            MenuStrip1.Text = "Calculateur"
            toolTipExit.Text = "Sortie"
            toolTipFile.Text = "Fichier"
            toolTipInformation.Text = "Sur"
            toolTipLanguage.Text = "Langue"
            toolTipOption.Text = "Options"
        ElseIf language = "German" Then
            labelVersion.Text = "Ausführung "
            MenuStrip1.Text = "Berechnen"
            toolTipExit.Text = "Ausgang"
            toolTipFile.Text = "Datei"
            toolTipInformation.Text = "Über"
            toolTipLanguage.Text = "Sprache"
            toolTipOption.Text = "Optionen"
        ElseIf language = "Italian" Then
            labelVersion.Text = "Versione "
            MenuStrip1.Text = "Calcolatore"
            toolTipExit.Text = "Uscita"
            toolTipFile.Text = "File"
            toolTipInformation.Text = "Di"
            toolTipLanguage.Text = "Linguaggio"
            toolTipOption.Text = "Opzioni"
        ElseIf language = "Portuguese" Then
            labelVersion.Text = "Versão "
            MenuStrip1.Text = "Cálculo"
            toolTipExit.Text = "Sair"
            toolTipFile.Text = "Arquivo"
            toolTipInformation.Text = "Sobre"
            toolTipLanguage.Text = "Língua"
            toolTipOption.Text = "Opções"
        ElseIf language = "Spanish" Then
            labelVersion.Text = "Versión "
            MenuStrip1.Text = "Calculadora"
            toolTipExit.Text = "Salir"
            toolTipFile.Text = "Ficha"
            toolTipInformation.Text = "Sobre"
            toolTipLanguage.Text = "Idioma"
            toolTipOption.Text = "Opciones"
        End If
        labelVersion.Text += version
    End Sub
    Sub LoadCalculator(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(fileDirectory) Then
            calculatorFileRead = File.OpenText(fileDirectory)
            Dim array(28) As String
            Dim text As String
            Dim b As Integer = 0
            text = calculatorFileRead.ReadLine()
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
            For i As Integer = 1 To 27
                letterEntry(i - 1) = CDec(array(i))
            Next
            circleMode = array(28)
            calculatorFileRead.Close()
            If circleMode = "Radians" Then
                labelCircle.Text = "RAD"
            Else
                labelCircle.Text = "DEG"
            End If
        End If
    End Sub
    Sub Multiplication(sender As Object, e As EventArgs) Handles buttonMultiply.Click
        entry1 = CDec(textBoxOutputMain.Text)
        EntryAlternative()
        If entry1 < 0 Then
            textBoxOutput.Text += "(" + entry1.ToString + ")"
        Else
            textBoxOutput.Text += entry1.ToString
        End If
        textBoxOutput.Text += " * "
        textBoxOutputMain.Text = "0"
        operatorFunction = True
        operations = 3 '=x 
        CalculatorCheck()
    End Sub
    Sub OpenLanguage(sender As Object, e As EventArgs) Handles toolTipLanguage.Click
        LanguageSelect.Visible = True
        CalculatorCheck()
    End Sub
    Sub PowerSwitch(sender As Object, e As EventArgs) Handles buttonPowerSwitch.Click
        If power.Equals(False) Then
            button0.Enabled = True
            button1.Enabled = True
            button2.Enabled = True
            button3.Enabled = True
            button4.Enabled = True
            button5.Enabled = True
            button6.Enabled = True
            button7.Enabled = True
            button8.Enabled = True
            button9.Enabled = True
            buttonA.Enabled = True
            buttonAdd.Enabled = True
            buttonB.Enabled = True
            buttonBackSpace.Enabled = True
            buttonC.Enabled = True
            buttonCircle.Enabled = True
            buttonClear.Enabled = True
            buttonCosecant.Enabled = True
            buttonCosine.Enabled = True
            buttonCotangent.Enabled = True
            buttonD.Enabled = True
            buttonDecimal.Enabled = True
            buttonDivide.Enabled = True
            buttonE.Enabled = True
            buttonEnter.Enabled = True
            buttonExponent.Enabled = True
            buttonF.Enabled = True
            buttonFactorial.Enabled = True
            buttonG.Enabled = True
            buttonH.Enabled = True
            buttonI.Enabled = True
            buttonInvert.Enabled = True
            buttonJ.Enabled = True
            buttonK.Enabled = True
            buttonL.Enabled = True
            buttonM.Enabled = True
            buttonMenu.Enabled = True
            buttonMultiply.Enabled = True
            buttonN.Enabled = True
            buttonO.Enabled = True
            buttonP.Enabled = True
            buttonPi.Enabled = True
            buttonPower.Enabled = True
            buttonQ.Enabled = True
            buttonR.Enabled = True
            buttonS.Enabled = True
            buttonSecant.Enabled = True
            buttonSecond.Enabled = True
            buttonSine.Enabled = True
            buttonSpace.Enabled = True
            buttonStorage.Enabled = True
            buttonSubtract.Enabled = True
            buttonT.Enabled = True
            buttonTangent.Enabled = True
            buttonU.Enabled = True
            buttonV.Enabled = True
            buttonW.Enabled = True
            buttonX.Enabled = True
            buttonY.Enabled = True
            buttonZ.Enabled = True
            textBoxOutputMain.Enabled = True
            labelCircle.Enabled = True
            textBoxOutput.Enabled = True
            labelSecond.Enabled = True
            power = True
            textBoxOutputMain.Text = "0"
        Else
            'Coming Soon'
            button0.Enabled = False
            button1.Enabled = False
            button2.Enabled = False
            button3.Enabled = False
            button4.Enabled = False
            button5.Enabled = False
            button6.Enabled = False
            button7.Enabled = False
            button8.Enabled = False
            button9.Enabled = False
            buttonA.Enabled = False
            buttonAdd.Enabled = False
            buttonB.Enabled = False
            buttonBackSpace.Enabled = False
            buttonC.Enabled = False
            buttonCircle.Enabled = False
            buttonClear.Enabled = False
            buttonCosecant.Enabled = False
            buttonCosine.Enabled = False
            buttonCotangent.Enabled = False
            buttonD.Enabled = False
            buttonDecimal.Enabled = False
            buttonDivide.Enabled = False
            buttonE.Enabled = False
            buttonEnter.Enabled = False
            buttonExponent.Enabled = False
            buttonF.Enabled = False
            buttonFactorial.Enabled = False
            buttonG.Enabled = False
            buttonH.Enabled = False
            buttonI.Enabled = False
            buttonInvert.Enabled = False
            buttonJ.Enabled = False
            buttonK.Enabled = False
            buttonL.Enabled = False
            buttonM.Enabled = False
            buttonMenu.Enabled = False
            buttonMultiply.Enabled = False
            buttonN.Enabled = False
            buttonO.Enabled = False
            buttonP.Enabled = False
            buttonPi.Enabled = False
            buttonPower.Enabled = False
            buttonQ.Enabled = False
            buttonR.Enabled = False
            buttonS.Enabled = False
            buttonSecant.Enabled = False
            buttonSecond.Enabled = False
            buttonSine.Enabled = False
            buttonSpace.Enabled = False
            buttonStorage.Enabled = False
            buttonSubtract.Enabled = False
            buttonT.Enabled = False
            buttonTangent.Enabled = False
            buttonU.Enabled = False
            buttonV.Enabled = False
            buttonW.Enabled = False
            buttonX.Enabled = False
            buttonY.Enabled = False
            buttonZ.Enabled = False
            textBoxOutputMain.Enabled = False
            labelCircle.Enabled = False
            textBoxOutput.Enabled = False
            labelSecond.Enabled = False
            power = False
            textBoxOutput.Text = ""
            textBoxOutputMain.Text = ""
            result = False
            entry1 = 0
            entry2 = 0
        End If
    End Sub
    Sub SaveCalculator(sender As Object, e As EventArgs) Handles MyBase.Closed
        calculatorFileWrite = File.CreateText(fileDirectory)
        calculatorFileWrite.Flush()
        calculatorFileWrite.Write(language + " ")
        For index As Integer = 0 To 26
            calculatorFileWrite.Write(letterEntry(index))
            calculatorFileWrite.Write(" ")
        Next
        calculatorFileWrite.Write(circleMode)
        calculatorFileWrite.Close()
    End Sub
    Sub SetLanguage(a As String)
        language = a
        TheLanguage(a)
    End Sub
    Sub Subtraction(sender As Object, e As EventArgs) Handles buttonSubtract.Click
        entry1 = CDec(textBoxOutputMain.Text)
        EntryAlternative()
        If entry1 < 0 Then
            textBoxOutput.Text += "(" + entry1.ToString + ")"
        Else
            textBoxOutput.Text += entry1.ToString
        End If
        textBoxOutput.Text += " - "
        textBoxOutputMain.Text = "0"
        operatorFunction = True
        operations = 2 ' - - 
        CalculatorCheck()
    End Sub
    Private Sub EnglishLanguage(sender As Object, e As EventArgs) Handles toolStripEnglish.Click
        SetLanguage("English")
        labelActivity.Text = "Switched to English"
        CalculatorCheck()
    End Sub
    Private Sub SpanishLanguage(sender As Object, e As EventArgs) Handles toolStripSpanish.Click
        SetLanguage("Spanish")
        labelActivity.Text = "Cambiado a español"
        CalculatorCheck()
    End Sub
    Private Sub PortugueseLanguage(sender As Object, e As EventArgs) Handles toolStripPortuguese.Click
        SetLanguage("Portuguese")
        CalculatorCheck()
        labelActivity.Text = "Mudou para Português"
    End Sub
    Private Sub ItalianLanguage(sender As Object, e As EventArgs) Handles toolStripItalian.Click
        SetLanguage("Italian")
        labelActivity.Text = "Passato all'Italiano"
        CalculatorCheck()
    End Sub
    Private Sub GermanLanguage(sender As Object, e As EventArgs) Handles toolStripGerman.Click
        SetLanguage("German")
        labelActivity.Text = "Auf deutsch umgestellt"
        CalculatorCheck()
    End Sub
    Private Sub FrenchLanguage(sender As Object, e As EventArgs) Handles toolStripFrench.Click
        SetLanguage("French")
        labelActivity.Text = "Changé en français"
        CalculatorCheck()
    End Sub
    Sub EntryPi(sender As Object, e As EventArgs) Handles buttonPi.Click
        If second = True Then
            If textBoxOutputMain.Text <> "0" Then
                If result = True Then
                    textBoxOutputMain.Text = e.ToString
                    'textBoxOutputMain.Text = "2.71828182845904523536028747135266249775724709369995"
                    textBoxOutput.Text = ""
                    result = False
                End If
            Else
                textBoxOutputMain.Text = "2.71828182845904523536028747135266249775724709369995"
            End If
            second = False
            labelSecond.Text = ""
        Else
            If textBoxOutputMain.Text <> "0" Then
                If result = True Then
                    textBoxOutputMain.Text = PI.ToString
                    'textBoxOutputMain.Text = "3.14159265358979323846264338327950288419716939937510"
                    textBoxOutput.Text = ""
                    result = False
                End If
            Else
                textBoxOutputMain.Text = "3.14159265358979323846264338327950288419716939937510"
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub EntryClear(sender As Object, e As EventArgs) Handles buttonClear.Click
        If second = True Then
            entry1 = 0
            entry2 = 0
            textBoxOutputMain.Text = "0"
            textBoxOutput.Text = ""
            operations = 0
        Else
            textBoxOutputMain.Text = "0"
        End If
        CalculatorCheck()
    End Sub
    Sub EntryPower(sender As Object, e As EventArgs) Handles buttonPower.Click
        If (second = True) Then
            entry1 = CDec(textBoxOutputMain.Text)
            textBoxOutputMain.Text = Sqrt(CDbl(entry1)).ToString
            entry1 = 0
            second = False
            labelSecond.Text = ""
        Else
            entry1 = CDec(textBoxOutputMain.Text)
            EntryAlternative()
            If entry1 < 0 Then
                textBoxOutput.Text += "(" + entry1.ToString + ")"
            Else
                textBoxOutput.Text += entry1.ToString
            End If
            textBoxOutput.Text += " ^ "
            textBoxOutputMain.Text = "0"
            operatorFunction = True
            operations = 5 ' - - 
            CalculatorCheck()
        End If
        CalculatorCheck()
    End Sub
    Sub Sine(sender As Object, e As EventArgs) Handles buttonSine.Click
        If (second = True) Then
            second = False
            labelSecond.Text = ""
            If (CDec(textBoxOutputMain.Text) > 1 Or CDec(textBoxOutputMain.Text) < -1) Then
                textBoxOutputMain.Text = Source.GetError("InvSinCosOutOfRange", language)
                result = True
                entry1 = 0
                entry2 = 0
            Else
                entry1 = CDec(textBoxOutputMain.Text)
                If circleMode = "Radian" Then
                    textBoxOutputMain.Text = Asin(entry1).ToString
                Else
                    textBoxOutputMain.Text = ConvRadToDeg(CDec(Asin(entry1))).ToString
                End If
                entry1 = 0
            End If
        Else
            Dim a As Double = CDec(textBoxOutputMain.Text)
            If circleMode = "Degree" Then
                entry1 = ConvDegToRad(a)
            Else
                entry1 = a
            End If
            textBoxOutputMain.Text = Sin(CDbl(entry1)).ToString
            entry1 = 0
        End If
        CalculatorCheck()
    End Sub
    Sub Cosine(sender As Object, e As EventArgs) Handles buttonCosine.Click
        If (second = True) Then
            second = False
            labelSecond.Text = ""
            If (CDec(textBoxOutputMain.Text) > 1 Or CDec(textBoxOutputMain.Text) < -1) Then
                textBoxOutputMain.Text = Source.GetError("InvSinCosCscCotOutOfRange", language)
                result = True
                entry1 = 0
                entry2 = 0
            Else
                entry1 = CDec(textBoxOutputMain.Text)
                If circleMode = "Radian" Then
                    textBoxOutputMain.Text = Acos(entry1).ToString
                Else
                    textBoxOutputMain.Text = ConvRadToDeg(CDec(Acos(entry1))).ToString
                End If
                entry1 = 0
            End If
        Else
            Dim a As Double = CDec(textBoxOutputMain.Text)
            If circleMode = "Degree" Then
                entry1 = ConvDegToRad(a)
            Else
                entry1 = a
            End If
            textBoxOutputMain.Text = Cos(CDbl(entry1)).ToString
            entry1 = 0
        End If
        CalculatorCheck()
    End Sub
    Sub Tangent(sender As Object, e As EventArgs) Handles buttonTangent.Click
        Dim a As Double = CDbl(textBoxOutputMain.Text)
        If (second = True) Then
            second = False
            labelSecond.Text = ""
            If (labelCircle.Text = "Degree") Then
                textBoxOutputMain.Text = ConvRadToDeg(Atan(a)).ToString
            Else
                textBoxOutputMain.Text = Atan(a).ToString
            End If
        Else
            If (circleMode = "Radian") Then
                While (a > (2 * PI))
                    a -= CDec(2 * PI)
                End While
                While (a < (-2 * PI))
                    a += CDec(2 * PI)
                End While
                If (Abs(a) = (PI / 2) Or (Abs(a) = (3 * PI) / 2)) Then
                    textBoxOutputMain.Text = "±∞"
                    result = True
                Else
                    textBoxOutputMain.Text = Tan(a).ToString
                End If
            ElseIf (circleMode = "Degree") Then
                While (a > 360)
                    a -= 360
                End While
                While (a < -360)
                    a += 360
                End While
                If (Abs(a) = 90 Or Abs(a) = 270) Then
                    textBoxOutputMain.Text = "±∞"
                    result = True
                Else
                    textBoxOutputMain.Text = Tan(ConvDegToRad(a)).ToString
                End If
                entry1 = 0
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub Cosecant(sender As Object, e As EventArgs) Handles buttonCosecant.Click
        If (second = True) Then
            second = False
            labelSecond.Text = ""
            If (CDec(textBoxOutputMain.Text) > 1 Or CDec(textBoxOutputMain.Text) < -1) Then
                textBoxOutputMain.Text = Source.GetError("InvSinCosCscCotOutOfRange", language)
                result = True
                entry1 = 0
                entry2 = 0
            ElseIf (CDec(textBoxOutputMain.Text) = 0) Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                Dim a As Double = CDec(textBoxOutputMain.Text)
                entry1 = 1 / Asin(CDec(a))
                If (circleMode = "Radian") Then
                    textBoxOutputMain.Text = entry1.ToString
                Else
                    textBoxOutputMain.Text = ConvRadToDeg(entry1).ToString
                End If
            End If
        Else
            Dim a As Double
            If (labelCircle.Text = "Degree") Then
                a = ConvDegToRad(CDec(textBoxOutputMain.Text))
            Else
                a = CDec(textBoxOutputMain.Text)
            End If
            While (a > (2 * PI))
                a -= (2 * PI)
            End While
            While (a < (-2 * PI))
                a += (2 * PI)
            End While
            If ((a) = 0 Or Abs(a) = (PI) Or Abs(a) = (2 * PI)) Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                entry1 = CDec(1 / Cos(CDec(a)))
                textBoxOutputMain.Text = entry1.ToString
                entry1 = 0
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub Secant(sender As Object, e As EventArgs) Handles buttonSecant.Click
        If (second = True) Then
            second = False
            labelSecond.Text = ""
            If (CDec(textBoxOutputMain.Text) > 1 Or CDec(textBoxOutputMain.Text) < -1) Then
                textBoxOutputMain.Text = Source.GetError("InvSinCosCscCotOutOfRange", language)
                result = True
                entry1 = 0
                entry2 = 0
            ElseIf (CDec(textBoxOutputMain.Text) = 0) Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                Dim a As Double = CDec(textBoxOutputMain.Text)
                Try
                    entry1 = 1 / Acos(CDec(a))
                    If (circleMode = "Radian") Then
                        textBoxOutputMain.Text = entry1.ToString
                    Else
                        textBoxOutputMain.Text = ConvRadToDeg(entry1).ToString
                    End If
                Catch ex As DivideByZeroException
                    textBoxOutputMain.Text = "±∞"
                    result = True
                End Try
            End If
        Else
            Dim a As Double
            If (labelCircle.Text = "Degree") Then
                a = ConvDegToRad(CDec(textBoxOutputMain.Text))
            Else
                a = CDec(textBoxOutputMain.Text)
            End If
            While (a > (2 * PI))
                a -= (2 * PI)
            End While
            While (a < (-2 * PI))
                a += (2 * PI)
            End While
            If ((a) = 0 Or Abs(a) = (PI / 2) Or Abs(a) = ((3 * PI) / 2)) Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                entry1 = CDec(1 / Cos(CDec(a)))
                textBoxOutputMain.Text = entry1.ToString
                entry1 = 0
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub Cotangent(sender As Object, e As EventArgs) Handles buttonCotangent.Click
        If (second = True) Then
            If (textBoxOutputMain.Text = "0") Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                entry1 = CDec(1 / Atan(CDec(textBoxOutputMain.Text)))
                textBoxOutputMain.Text = entry1.ToString
                entry1 = 0
            End If
        Else
            Dim a As Double
            If (labelCircle.Text = "Degree") Then
                a = ConvDegToRad(CDec(textBoxOutputMain.Text))
            Else
                a = CDec(textBoxOutputMain.Text)
            End If
            While (a > (2 * PI))
                a -= (2 * PI)
            End While
            While (a < (-2 * PI))
                a += (2 * PI)
            End While
            If ((a = 0) Or (Abs(a) = (PI / 2)) Or (Abs(a) = PI) Or (Abs(a) = ((3 * PI) / 2)) Or (Abs(a) = (2 * PI))) Then
                textBoxOutputMain.Text = "±∞"
                result = True
            Else
                entry1 = CDec(1 / Tan(CDec(a)))
                textBoxOutputMain.Text = entry1.ToString
                entry1 = 0
            End If
        End If
        CalculatorCheck()
    End Sub
    Sub ExponentInsert(sender As Object, e As EventArgs) Handles buttonExponent.Click
        If (second = True) Then
            labelSecond.Text = ""
            second = False
            textBoxOutputMain.Text = Source.RCLFunction(language)
            textBoxOutputMain.Text += vbNewLine
            For Index As Integer = 0 To 25
                textBoxOutputMain.Text += (alphabet.ElementAt(Index) + " = " + letterEntry(Index).ToString + vbNewLine)
            Next
            result = True
        Else
            If textBoxOutputMain.Text <> "0" Then
                If result = True Then
                    textBoxOutputMain.Text = "1E"
                    textBoxOutput.Text = ""
                    result = False
                Else
                    textBoxOutputMain.Text += "E"
                End If
            Else
                textBoxOutputMain.Text = "1E"
            End If
        End If
        CalculatorCheck()
    End Sub
    Function GetLanguage() As String
        Return language
    End Function
    Function GetVersion() As String
        Return version
    End Function
    Sub OpenAbout(sender As Object, e As EventArgs) Handles toolTipInformation.Click
        Credits.Show()
        CalculatorCheck()
    End Sub
    Sub ChangeCircleMode(sender As Object, e As EventArgs) Handles buttonCircle.Click
        If (circleMode = "Radian") Then
            circleMode = "Degree"
            labelCircle.Text = "DEG"
        Else
            circleMode = "Radian"
            labelCircle.Text = "RAD"
        End If
        CalculatorCheck()
    End Sub
    Function ConvDegToRad(degree As Double) As Double
        Dim radian As Double = CDec((degree * PI) / 180)
        Return radian
    End Function
    Function ConvRadToDeg(radian As Double) As Double
        Dim degree As Double = CDec((radian * 180) / PI)
        Return degree
    End Function
    Sub CalculatorCheck()
        If power = True Then
            If (textBoxOutputMain.Text = "") Then
                textBoxOutputMain.Text = "0"
            Else
                'Do Nothing'
            End If
        Else
            'Do Nothing'
        End If
    End Sub
    Sub Invert(sender As Object, e As EventArgs) Handles buttonInvert.Click
        entry1 = CDbl(textBoxOutputMain.Text)
        entry1 *= -1
        textBoxOutputMain.Text = entry1.ToString
        entry1 = 0
    End Sub
End Class