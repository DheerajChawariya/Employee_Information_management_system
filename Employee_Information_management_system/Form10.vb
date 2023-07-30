Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
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

        Button8.BackColor = Color.White
        Button8.ForeColor = Color.Black
        Label3.ForeColor = Color.Black

        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
        Label7.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        Label9.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        Label14.ForeColor = Color.Black
        Label15.ForeColor = Color.Black
        Label16.ForeColor = Color.Black
        Label17.ForeColor = Color.Black
        Label18.ForeColor = Color.Black
        Label19.ForeColor = Color.Black
        Label20.ForeColor = Color.Black
        Label21.ForeColor = Color.Black
        Label22.ForeColor = Color.Black

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.BackColor = Drawing.Color.Indigo
        Me.ForeColor = Drawing.Color.White

        Button1.BackColor = Color.Indigo
        Button1.ForeColor = Color.White

        Button7.BackColor = Color.Indigo
        Button7.ForeColor = Color.White

        Button8.BackColor = Color.Indigo
        Button8.ForeColor = Color.White

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
         MessageBox.Show("you can block all the messages")
    End Sub
End Class