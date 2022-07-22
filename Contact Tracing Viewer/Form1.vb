Imports System.IO
Public Class Form1
    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\justi\OneDrive\Desktop\Contact Tracing\Contact Tracing\bin\Debug\ContactTracingForm.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        display.Text = fileReader.ReadToEnd
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        display.Clear()
    End Sub
End Class
