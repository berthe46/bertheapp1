Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If chmail.Text = "" Or chmp.Text = "" Then
            MsgBox("Renseignez les champs")

        ElseIf chmail.Text = "BertheL2" And chmp.Text = "BERThe44" Then
            Form3.Show()
            Me.Hide()
            Exit Sub
        Else
            MsgBox("Ce compte n'existe pas")
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If chmail.Text = "BertheL2" Then
            MsgBox("le mot de passe correspondant à ce mail est: BERThe44")
        Else
            MsgBox("Entrez votre nom d'utilisateur")

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class