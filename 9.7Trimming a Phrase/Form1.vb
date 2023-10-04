Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim myPhrase As String

		myPhrase = InputBox("Enter your phrase")
		TextBox1.Text = Trim(myPhrase) 'Trims the empty spaces on both sides of the phrase

	End Sub
End Class
