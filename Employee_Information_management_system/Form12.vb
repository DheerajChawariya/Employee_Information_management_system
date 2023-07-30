Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form12
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.BackColor = Drawing.Color.White
        Me.ForeColor = Drawing.Color.Black

        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Label1.ForeColor = Color.Black

        Button7.BackColor = Color.White
        Button7.ForeColor = Color.Black
        Label2.ForeColor = Color.Black

        Button9.BackColor = Color.White
        Button9.ForeColor = Color.Black
        Label3.ForeColor = Color.Black

        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
        Label7.ForeColor = Color.Black
        Label8.ForeColor = Color.Black


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.BackColor = Drawing.Color.Indigo
        Me.ForeColor = Drawing.Color.White

        Button1.BackColor = Color.Indigo
        Button1.ForeColor = Color.White

        Button7.BackColor = Color.Indigo
        Button7.ForeColor = Color.White


        Button9.BackColor = Color.Indigo
        Button9.ForeColor = Color.White
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MessageBox.Show("you can block all the messages")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MessageBox.Show("all the messages are blocked")
    End Sub
End Class