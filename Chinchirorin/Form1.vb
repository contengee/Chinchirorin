Public Class Form1
    Dim BasePath As String '画像のあるフォルダのフルパス
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BasePath = Application.StartupPath & "\image"
        lblPlayerMoney.Text = "10000"
        lblComputerMoney.Text = "10000"
    End Sub

    Private Sub btnPlay_Click(ByVal sen As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        '▼サイコロを振る
        Chinchirorin()
    End Sub

    Private Sub Chinchirorin()
        Dim Rnd As New Random
        Dim Saikoro1 As Integer = Rnd.Next(1, 7)
        Dim Saikoro2 As Integer = Rnd.Next(1, 7)
        Dim Saikoro3 As Integer = Rnd.Next(1, 7)
        Dim File1 As String = BasePath & "\Saikoro" & Saikoro1 & ".bmp"
        Dim File2 As String = BasePath & "\Saikoro" & Saikoro2 & ".bmp"
        Dim File3 As String = BasePath & "\Saikoro" & Saikoro3 & ".bmp"
        picSai1.Image = Image.FromFile(File1)
        picSai2.Image = Image.FromFile(File2)
        picSai3.Image = Image.FromFile(File3)
    End Sub
End Class
