Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a > b Then GoTo mayor1 Else GoTo mayor1e
mayor1:
        If a > c Then GoTo mayor2 Else GoTo mayor2e
mayor2:
        If b > c Then GoTo mayor3 Else GoTo mayor3e
mayor3:
        TextBox4.Text = c.ToString() + " " + b.ToString() + " " + a.ToString()
        TextBox5.Text = a.ToString() + " " + b.ToString() + " " + c.ToString()
        GoTo salir
mayor3e:
        TextBox4.Text = a.ToString() + " " + c.ToString() + " " + b.ToString()
        TextBox5.Text = b.ToString() + " " + c.ToString() + " " + a.ToString()
        GoTo salir
mayor2e:
        TextBox4.Text = b.ToString() + " " + a.ToString() + " " + c.ToString()
        TextBox5.Text = c.ToString() + " " + a.ToString() + " " + b.ToString()
        GoTo salir
mayor1e:
        If b > c Then GoTo mayor4 Else GoTo mayor4e
mayor4:
        If a > c Then GoTo mayor5 Else GoTo mayor5e
mayor5:
        TextBox4.Text = c.ToString() + " " + a.ToString() + " " + b.ToString()
        TextBox5.Text = b.ToString() + " " + a.ToString() + " " + c.ToString()
        GoTo salir
mayor5e:
        TextBox4.Text = a.ToString() + " " + c.ToString() + " " + b.ToString()
        TextBox5.Text = b.ToString() + " " + c.ToString() + " " + a.ToString()
        GoTo salir
mayor4e:
        TextBox4.Text = a.ToString() + " " + b.ToString() + " " + c.ToString()
        TextBox5.Text = c.ToString() + " " + b.ToString() + " " + a.ToString()
        GoTo salir


salir:


    End Sub
End Class
