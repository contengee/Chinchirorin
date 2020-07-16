<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPlayerMoney = New System.Windows.Forms.Label()
        Me.lblPlayerYaku = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSai3 = New System.Windows.Forms.PictureBox()
        Me.picSai2 = New System.Windows.Forms.PictureBox()
        Me.picSai1 = New System.Windows.Forms.PictureBox()
        Me.lblYakuName = New System.Windows.Forms.Label()
        Me.lblComputerMoney = New System.Windows.Forms.Label()
        Me.lblComputerYaku = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picSai3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSai2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSai1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlayerMoney
        '
        Me.lblPlayerMoney.AutoSize = True
        Me.lblPlayerMoney.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.lblPlayerMoney.Location = New System.Drawing.Point(21, 111)
        Me.lblPlayerMoney.Name = "lblPlayerMoney"
        Me.lblPlayerMoney.Size = New System.Drawing.Size(66, 19)
        Me.lblPlayerMoney.TabIndex = 0
        Me.lblPlayerMoney.Text = "Label1"
        Me.lblPlayerMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlayerYaku
        '
        Me.lblPlayerYaku.AutoSize = True
        Me.lblPlayerYaku.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.lblPlayerYaku.Location = New System.Drawing.Point(21, 176)
        Me.lblPlayerYaku.Name = "lblPlayerYaku"
        Me.lblPlayerYaku.Size = New System.Drawing.Size(66, 19)
        Me.lblPlayerYaku.TabIndex = 1
        Me.lblPlayerYaku.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picSai3)
        Me.Panel1.Controls.Add(Me.picSai2)
        Me.Panel1.Controls.Add(Me.picSai1)
        Me.Panel1.Controls.Add(Me.lblYakuName)
        Me.Panel1.Location = New System.Drawing.Point(112, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 225)
        Me.Panel1.TabIndex = 2
        '
        'picSai3
        '
        Me.picSai3.Location = New System.Drawing.Point(274, 24)
        Me.picSai3.Name = "picSai3"
        Me.picSai3.Size = New System.Drawing.Size(84, 84)
        Me.picSai3.TabIndex = 1
        Me.picSai3.TabStop = False
        '
        'picSai2
        '
        Me.picSai2.Location = New System.Drawing.Point(157, 24)
        Me.picSai2.Name = "picSai2"
        Me.picSai2.Size = New System.Drawing.Size(84, 84)
        Me.picSai2.TabIndex = 1
        Me.picSai2.TabStop = False
        '
        'picSai1
        '
        Me.picSai1.Location = New System.Drawing.Point(36, 24)
        Me.picSai1.Name = "picSai1"
        Me.picSai1.Size = New System.Drawing.Size(84, 84)
        Me.picSai1.TabIndex = 1
        Me.picSai1.TabStop = False
        '
        'lblYakuName
        '
        Me.lblYakuName.AutoSize = True
        Me.lblYakuName.Font = New System.Drawing.Font("HG正楷書体-PRO", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblYakuName.Location = New System.Drawing.Point(147, 146)
        Me.lblYakuName.Name = "lblYakuName"
        Me.lblYakuName.Size = New System.Drawing.Size(94, 27)
        Me.lblYakuName.TabIndex = 0
        Me.lblYakuName.Text = "Label1"
        Me.lblYakuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputerMoney
        '
        Me.lblComputerMoney.AutoSize = True
        Me.lblComputerMoney.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.lblComputerMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblComputerMoney.Location = New System.Drawing.Point(504, 111)
        Me.lblComputerMoney.Name = "lblComputerMoney"
        Me.lblComputerMoney.Size = New System.Drawing.Size(66, 19)
        Me.lblComputerMoney.TabIndex = 3
        Me.lblComputerMoney.Text = "Label1"
        Me.lblComputerMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblComputerYaku
        '
        Me.lblComputerYaku.AutoSize = True
        Me.lblComputerYaku.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.lblComputerYaku.Location = New System.Drawing.Point(504, 178)
        Me.lblComputerYaku.Name = "lblComputerYaku"
        Me.lblComputerYaku.Size = New System.Drawing.Size(66, 19)
        Me.lblComputerYaku.TabIndex = 4
        Me.lblComputerYaku.Text = "Label1"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.lblMessage.Location = New System.Drawing.Point(238, 267)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(66, 19)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "Label1"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBet
        '
        Me.txtBet.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.txtBet.Location = New System.Drawing.Point(236, 300)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(154, 26)
        Me.txtBet.TabIndex = 6
        Me.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.btnPlay.Location = New System.Drawing.Point(236, 343)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(157, 46)
        Me.btnPlay.TabIndex = 7
        Me.btnPlay.Text = "サイコロを振る"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "あなた　"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(507, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CPU　  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(504, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "役　　　"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(144, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "賭け金"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(21, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "役　　　"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(507, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "CPU　  "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(21, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "持ち金　"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("HG正楷書体-PRO", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(504, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "持ち金　"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 411)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtBet)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblComputerYaku)
        Me.Controls.Add(Me.lblComputerMoney)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPlayerYaku)
        Me.Controls.Add(Me.lblPlayerMoney)
        Me.Name = "Form1"
        Me.Text = "ちんちろりん"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picSai3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSai2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSai1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerMoney As Label
    Friend WithEvents lblPlayerYaku As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picSai3 As PictureBox
    Friend WithEvents picSai2 As PictureBox
    Friend WithEvents picSai1 As PictureBox
    Friend WithEvents lblYakuName As Label
    Friend WithEvents lblComputerMoney As Label
    Friend WithEvents lblComputerYaku As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtBet As TextBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
End Class
