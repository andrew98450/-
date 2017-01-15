Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox6.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox6.Text = "" Then
            MsgBox("未輸入號碼")
        ElseIf TextBox6.Text = TextBox1.Text Then
            MsgBox("恭喜中1000萬")
        ElseIf TextBox6.Text = TextBox2.Text Then
            MsgBox("恭喜中200萬")
        ElseIf TextBox6.Text = TextBox3.Text Or TextBox6.Text = TextBox4.Text Or TextBox6.Text = TextBox5.Text Then
            MsgBox("恭喜中20萬")
        ElseIf TextBox6.Text.Remove(0, 1) = TextBox3.Text.Remove(0, 1) Or TextBox6.Text.Remove(0, 1) = TextBox4.Text.Remove(0, 1) Or TextBox6.Text.Remove(0, 1) = TextBox5.Text.Remove(0, 1) Then
            MsgBox("恭喜中4萬")
        ElseIf TextBox6.Text.Remove(0, 2) = TextBox3.Text.Remove(0, 2) Or TextBox6.Text.Remove(0, 2) = TextBox4.Text.Remove(0, 2) Or TextBox6.Text.Remove(0, 2) = TextBox5.Text.Remove(0, 2) Then
            MsgBox("恭喜中1萬")
        ElseIf TextBox6.Text.Remove(0, 3) = TextBox3.Text.Remove(0, 3) Or TextBox6.Text.Remove(0, 3) = TextBox4.Text.Remove(0, 3) Or TextBox6.Text.Remove(0, 3) = TextBox5.Text.Remove(0, 3) Then
            MsgBox("恭喜中4千")
        ElseIf TextBox6.Text.Remove(0, 4) = TextBox3.Text.Remove(0, 4) Or TextBox6.Text.Remove(0, 4) = TextBox4.Text.Remove(0, 4) Or TextBox6.Text.Remove(0, 4) = TextBox5.Text.Remove(0, 4) Then
            MsgBox("恭喜中1千")
        ElseIf TextBox6.Text.Remove(0, 5) = TextBox3.Text.Remove(0, 5) Or TextBox6.Text.Remove(0, 5) = TextBox4.Text.Remove(0, 5) Or TextBox6.Text.Remove(0, 5) = TextBox5.Text.Remove(0, 5) Then
            MsgBox("恭喜中2百")
        Else
            MsgBox("沒中獎")
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim r As New Random
        TextBox1.Text = r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10)
        TextBox2.Text = r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10)
        TextBox3.Text = r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10)
        TextBox4.Text = r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10)
        TextBox5.Text = r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10) & r.Next(10)
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub
End Class
