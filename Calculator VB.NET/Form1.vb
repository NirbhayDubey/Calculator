Public Class Form1
    Dim a, b, c As Integer
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtbox.Text &= 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtbox.Text &= 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtbox.Text &= 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtbox.Text &= 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtbox.Text &= 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtbox.Text &= 6
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtbox.Text &= 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtbox.Text &= 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtbox.Text &= 9
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtbox.Text &= 0
    End Sub

    Private Sub btndot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndot.Click
        txtbox.Text &= "."
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        a = CInt(txtbox.Text)
        txtbox.Text = ""
        txtopbox.Text = "+"
    End Sub

    Private Sub btnmulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmulti.Click
        a = CInt(txtbox.Text)
        txtbox.Text = ""
        txtopbox.Text = "*"
    End Sub

    Private Sub btndvd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndvd.Click
        a = CInt(txtbox.Text)
        txtbox.Text = ""
        txtopbox.Text = "/"
    End Sub

    Private Sub btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsub.Click
        a = CInt(txtbox.Text)
        txtbox.Text = ""
        txtopbox.Text = "-"
    End Sub

    Private Sub btnoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoff.Click
        Me.Close()
    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        a = CInt(txtbox.Text)
        txtbox.Text = ""
        txtopbox.Text = "%"
    End Sub

    Private Sub btnac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnac.Click
        txtbox.Clear()
        a = b = c = 0
        txtansadd.Text = 0
        txtanssub.Text = 0
        txtansmulti.Text = 0
        txtansdvd.Text = 0
        txtopbox.Text = "C"
        txtansadd.BackColor = Color.White
        txtanssub.BackColor = Color.White
        txtansmulti.BackColor = Color.White
        txtansdvd.BackColor = Color.White

    End Sub

    Private Sub btneql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneql.Click
        b = CInt(txtbox.Text)
        txtbox.Text = a * b / 100
        txtansadd.Text = a + b
        txtanssub.Text = a - b
        txtansmulti.Text = a * b
        txtansdvd.Text = a / b
        If txtopbox.Text = "+" Then
            txtansadd.BackColor = Color.Cyan
        ElseIf txtopbox.Text = "-" Then
            txtanssub.BackColor = Color.Coral
        ElseIf txtopbox.Text = "*" Then
            txtansmulti.BackColor = Color.Coral
        ElseIf txtopbox.Text = "/" Then
            txtansdvd.BackColor = Color.Coral
        End If

    End Sub

    Private Sub btnsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsm.Click
        txtbox.Text &= "☺"
        txtopbox.Text = "☺"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
