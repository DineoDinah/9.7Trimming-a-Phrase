﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Button1 = New Button()
		Label1 = New Label()
		TextBox1 = New TextBox()
		SuspendLayout()
		' 
		' Button1
		' 
		Button1.Location = New Point(257, 200)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 0
		Button1.Text = "Button1"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(198, 45)
		Label1.Name = "Label1"
		Label1.Size = New Size(123, 25)
		Label1.TabIndex = 1
		Label1.Text = "Enter a Phrase"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(377, 45)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(TextBox1)
		Controls.Add(Label1)
		Controls.Add(Button1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
End Class
