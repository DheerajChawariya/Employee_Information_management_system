Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.BackColor = Drawing.Color.White
        Me.ForeColor = Drawing.Color.Black

        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Label1.ForeColor = Color.Black


        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
        Label2.ForeColor = Color.Black


        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Black
        Label3.ForeColor = Color.Black


        Button4.BackColor = Color.White
        Button4.ForeColor = Color.Black
        Label4.ForeColor = Color.Black


        Button6.BackColor = Color.White
        Button6.ForeColor = Color.Black
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

        Button2.BackColor = Color.Indigo
        Button2.ForeColor = Color.White

        Button3.BackColor = Color.Indigo
        Button3.ForeColor = Color.White

        Button4.BackColor = Color.Indigo
        Button4.ForeColor = Color.White

        Button6.BackColor = Color.Indigo
        Button6.ForeColor = Color.White
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("you can block all the messages")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Now all the Duplicate files are deleted")
    End Sub

End Class