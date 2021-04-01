Public Class Form1
    '********************
    '*   project euler  *
    '*     problem 4    *
    '*     solved by    *
    '* WhatDoesThisMean *
    '*    03/31/2021    *
    '********************
    '*   you can solve  *
    '*      it too      *
    '* projecteuler.net *
    '********************
    'Problem 4 is to find the highest palindromic result when multiplying two three-digit numbers together.

    Dim intNum1 As Integer = 100 'first three digit number
    Dim intNum2 As Integer = 100 'second three digit number
    Dim intCount As Integer = 0 'counts the number of items in the results list
    Dim intResult As Integer 'holds the result of each round of multiplication


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For intNum2 = 100 To 999

            'the inner for next loop does the multiplication and counts intNum1 through all the numbers from 100 - 999
            For intNum1 = 100 To 999

                'multiply intNum1 by intNum2
                intResult = intNum1 * intNum2

                'Weed out the non-palindromic results and save the palindromic results in a list.
                'The palindromes are found by comparing the elements in the string First:Last then by index of the elements in the string 1:4 2:3
                'Results with a length less than 6 are also weeded out, since we are looking for the highest palindromic result, and there are some palindromic results with 6 digits.
                If intResult.ToString.Length = 6 And intResult.ToString.First = intResult.ToString.Last And intResult.ToString.ElementAt(1) = intResult.ToString.ElementAt(4) And intResult.ToString.ElementAt(2) = intResult.ToString.ElementAt(3) Then
                    lstResult.Items.Add(intResult.ToString)
                End If

            Next

            'outer for next loop runs once everytime the inner for next loop finishes a complete cycle. It counts intNum2 through all the  numbers from 100 - 999

        Next

        'Display the answer to the challenge by taking the last item in the (sorted=true) list and putting it in a label.

        intCount = lstResult.Items.Count - 1

        lblHighest.Text = lstResult.Items(intCount)

    End Sub
End Class
