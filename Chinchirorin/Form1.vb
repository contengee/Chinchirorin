Public Class Form1
    Private Enum ChinchirorinYaku
        Hifumi = -1
        Menashi = 1
        Deme1 = 2
        Deme2 = 3
        Deme3 = 4
        Deme4 = 5
        Deme5 = 6
        Deme6 = 7
        Arashi = 8
        Arashi5 = 9
        Arashi1 = 10
        Sigoro = 11
    End Enum

    Private Enum Bgm
        Win = 1
        Lose = 2
        Even = 3
    End Enum


    Dim PlayerYaku As ChinchirorinYaku 'プレイヤーの出した役
    Dim ComputerYaku As ChinchirorinYaku 'コンピュータの出した役
    Dim BasePath As String '基準になるフォルダのフルパス
    Dim BaseImagePath As String '画像のあるフォルダのフルパス
    Dim BaseMusicPath As String '音源のあるフォルダのフルパス

    Private player As Media.SoundPlayer = Nothing

    Private Sub Form1_Load(ByVal sender As System.Object,
                           ByVal e As System.EventArgs) Handles MyBase.Load
        BasePath = Application.StartupPath
        BasePath = IO.Directory.GetParent(BasePath).ToString
        BaseImagePath = IO.Directory.GetParent(BasePath).ToString & "\image"

        lblPlayerMoney.Text = "10000"
        lblComputerMoney.Text = "10000"
        lblPlayerYaku.Text = ""
        lblComputerYaku.Text = ""
        lblMessage.Text = "いざ勝負"
        lblYakuName.Text = "チンチロリン"

        picSai1.Image = Image.FromFile(BaseImagePath & "\Saikoro1.bmp")
        picSai2.Image = Image.FromFile(BaseImagePath & "\Saikoro1.bmp")
        picSai3.Image = Image.FromFile(BaseImagePath & "\Saikoro1.bmp")

    End Sub

    Private Function GetYakuName(ByVal Yaku As ChinchirorinYaku) As String
        Select Case Yaku
            Case ChinchirorinYaku.Deme1
                Return "出目１"
            Case ChinchirorinYaku.Deme2
                Return "出目２"
            Case ChinchirorinYaku.Deme3
                Return "出目３"
            Case ChinchirorinYaku.Deme4
                Return "出目４"
            Case ChinchirorinYaku.Deme5
                Return "出目５"
            Case ChinchirorinYaku.Deme6
                Return "出目６"
            Case ChinchirorinYaku.Arashi1
                Return "ピンゾロ"
            Case ChinchirorinYaku.Arashi5
                Return "ゴゾロ"
            Case ChinchirorinYaku.Arashi
                Return "アラシ"
            Case ChinchirorinYaku.Sigoro
                Return "シゴロ"
            Case ChinchirorinYaku.Hifumi
                Return "ヒフミ"
            Case ChinchirorinYaku.Menashi
                Return "目なし"
        End Select
    End Function

    Private Function GetYaku(ByVal Number1 As Integer,
                             ByVal Number2 As Integer,
                             ByVal Number3 As Integer) As ChinchirorinYaku
        Dim Deme As Integer
        '▼アラシ（ゾロ目）の判断
        If Number1 = Number2 AndAlso Number1 = Number3 Then
            If Number1 = 1 Then
                'ピンゾロ（１のゾロ目）、ゴゾロ（５のゾロ目）
                Return ChinchirorinYaku.Arashi1
            ElseIf Number1 = 5 Then
                Return ChinchirorinYaku.Arashi5
            Else
                'その他のゾロ目
                Return ChinchirorinYaku.Arashi
            End If
        End If

        '▼出目の判断

        '注:「出目」とは同じ数字が2つある場合の残りの数字の事を言う。
        '例えば、「244」の場合、出目は2、「535」の場合、出目は3

        If Number1 = Number2 Then
            Deme = Number3
        ElseIf Number1 = Number3 Then
            Deme = Number2
        ElseIf Number2 = Number3 Then
            Deme = Number1
        End If

        Select Case Deme
            Case 1
                Return ChinchirorinYaku.Deme1
            Case 2
                Return ChinchirorinYaku.Deme2
            Case 3
                Return ChinchirorinYaku.Deme3
            Case 4
                Return ChinchirorinYaku.Deme4
            Case 5
                Return ChinchirorinYaku.Deme5
            Case 6
                Return ChinchirorinYaku.Deme6
        End Select

        '▼ヒフミとシゴロの判断
        If Number1 + Number2 + Number3 = 6 Then
            Return ChinchirorinYaku.Hifumi
        End If

        If Number1 + Number2 + Number3 = 15 Then
            Return ChinchirorinYaku.Sigoro
        End If

        '▼役なし
        Return ChinchirorinYaku.Menashi
    End Function

    Private Function GetYakuPoint(ByVal Yaku As ChinchirorinYaku) As Integer
        Select Case Yaku
            Case ChinchirorinYaku.Hifumi
                Return 3
            Case ChinchirorinYaku.Menashi
                Return 0
            Case ChinchirorinYaku.Deme1
                Return 1
            Case ChinchirorinYaku.Deme2
                Return 1
            Case ChinchirorinYaku.Deme3
                Return 1
            Case ChinchirorinYaku.Deme4
                Return 1
            Case ChinchirorinYaku.Deme5
                Return 1
            Case ChinchirorinYaku.Deme6
                Return 1
            Case ChinchirorinYaku.Arashi1
                Return 5
            Case ChinchirorinYaku.Arashi5
                Return 5
            Case ChinchirorinYaku.Arashi
                Return 2
            Case ChinchirorinYaku.Sigoro
                Return 3
            Case Else
                Return 0 '本来は中断処理
        End Select
    End Function

    Private Sub btnPlay_Click(ByVal sen As System.Object,
                              ByVal e As System.EventArgs) Handles btnPlay.Click
        '▼賭け金のチェック
        If Not IsNumeric(txtBet.Text) OrElse CInt(txtBet.Text) = 0 Then
            MsgBox("賭け金を入力して下さい。", MsgBoxStyle.Information)
            Exit Sub
        End If

        '▼表示の初期化
        lblPlayerYaku.Text = ""
        lblComputerYaku.Text = ""
        lblMessage.Text = ""

        '▼プレイヤーの手番
        PlayerYaku = Chinchirorin() 'サイコロを振る
        lblPlayerYaku.Text = GetYakuName(PlayerYaku) '出た役の名前を表示

        '▼コンピュータの手番
        btnPlay.Enabled = False
        Timer1.Enabled = True 'コンピュータの番に移行するためにタイマーを作動させる

    End Sub

    Private Function Chinchirorin() As ChinchirorinYaku
        Dim Rnd As New Random
        Dim Saikoro1 As Integer = Rnd.Next(1, 7)
        Dim Saikoro2 As Integer = Rnd.Next(1, 7)
        Dim Saikoro3 As Integer = Rnd.Next(1, 7)
        Dim File1 As String = BaseImagePath & "\Saikoro" & Saikoro1 & ".bmp"
        Dim File2 As String = BaseImagePath & "\Saikoro" & Saikoro2 & ".bmp"
        Dim File3 As String = BaseImagePath & "\Saikoro" & Saikoro3 & ".bmp"
        Dim Yaku As ChinchirorinYaku

        picSai1.Image = Image.FromFile(File1)
        picSai2.Image = Image.FromFile(File2)
        picSai3.Image = Image.FromFile(File3)

        Yaku = GetYaku(Saikoro1, Saikoro2, Saikoro3)
        lblYakuName.Text = GetYakuName(Yaku)

        Return Yaku

    End Function

    Private Sub Timer1_Tick(sender As Object,
                            e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        '▼サイコロを振る
        ComputerYaku = Chinchirorin()
        lblComputerYaku.Text = GetYakuName(ComputerYaku)

        '▼勝敗判定
        '書肺判定に伴う表示や金額の足し引きなどは全てJudgeメソッドで行う
        Call Judge()

        btnPlay.Enabled = True

    End Sub

    Private Sub Judge()
        Dim PlayerMoney As Integer = CInt(lblPlayerMoney.Text)
        Dim ComputerMoney As Integer = CInt(lblComputerMoney.Text)
        Dim Bet As Integer = CInt(txtBet.Text)
        Dim Point As Integer
        If PlayerYaku > ComputerYaku Then

            '●プレイヤーが勝った場合
            '倍率の取得
            If ComputerYaku < 0 Then
                'コンピュータがヒフミで負けた場合は、ヒフミの倍率を求める。
                Point = GetYakuPoint(ComputerYaku)
            Else
                'ヒフミ以外の場合は、プレイヤーの役を元に倍率を求める。
                Point = GetYakuPoint(PlayerYaku)
            End If

            PlayerMoney += Bet * Point 'プレイヤーの獲得金額
            ComputerMoney -= Bet * Point 'コンピュータの損失金額
            lblMessage.Text = Bet * Point & "円の勝ちです！"
            lblPlayerYaku.ForeColor = Color.Red
            lblComputerYaku.ForeColor = Color.Black
            PlaySound(Bgm.Win)

        ElseIf PlayerYaku < ComputerYaku Then
            '●コンピュータが勝った場合
            If PlayerYaku < 0 Then
                Point = GetYakuPoint(PlayerYaku)
            Else
                Point = GetYakuPoint(ComputerYaku)
            End If

            PlayerMoney -= Bet * Point
            ComputerMoney += Bet * Point
            lblMessage.Text = Bet * Point & "円の負けです（真顔）"
            lblPlayerYaku.ForeColor = Color.Black
            lblComputerYaku.ForeColor = Color.Red
            PlaySound(Bgm.Lose)
        Else

            '●ワカレ(引き分け)の場合
            lblMessage.Text = "ワカレ（引き分け）です。"
            lblPlayerYaku.ForeColor = Color.Black
            lblComputerYaku.ForeColor = Color.Black
            PlaySound(Bgm.Even)
        End If

        lblPlayerMoney.Text = PlayerMoney
        lblComputerMoney.Text = ComputerMoney

    End Sub

    'WAVEファイルを再生する
    Private Sub PlaySound(ByVal bgm As Bgm)
        BaseMusicPath = IO.Directory.GetParent(BasePath).ToString & "\wav"

        If bgm = Bgm.Win Then
            '読み込む
            player = New Media.SoundPlayer(BaseMusicPath & "\win.wav")
            player.Play()
        ElseIf bgm = Bgm.Lose Then
            player = New Media.SoundPlayer(BaseMusicPath & "\lose.wav")
        Else
            player = New Media.SoundPlayer(BaseMusicPath & "\even.wav")
        End If

        player.Play()
    End Sub

End Class
