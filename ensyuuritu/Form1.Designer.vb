<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPi = New System.Windows.Forms.TextBox()
        Me.txtTrials = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(10, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "【画像描写】"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(39, 86)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 29)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "計算開始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "円周率："
        '
        'txtPi
        '
        Me.txtPi.Location = New System.Drawing.Point(90, 21)
        Me.txtPi.Name = "txtPi"
        Me.txtPi.Size = New System.Drawing.Size(144, 27)
        Me.txtPi.TabIndex = 4
        '
        'txtTrials
        '
        Me.txtTrials.Location = New System.Drawing.Point(117, 41)
        Me.txtTrials.MaxLength = 200
        Me.txtTrials.Name = "txtTrials"
        Me.txtTrials.Size = New System.Drawing.Size(144, 27)
        Me.txtTrials.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "試行回数："
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(167, 86)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTrials)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Location = New System.Drawing.Point(450, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 134)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "【パラメータ】"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCopy)
        Me.GroupBox2.Controls.Add(Me.txtPi)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 167)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "【計算結果】"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(240, 19)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(72, 29)
        Me.btnCopy.TabIndex = 8
        Me.btnCopy.Text = "コピー"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "モンテカルロシミュレーション"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPi As TextBox
    Friend WithEvents txtTrials As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCopy As Button
End Class
