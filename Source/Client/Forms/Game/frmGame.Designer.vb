<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGame))
        Me.picscreen = New System.Windows.Forms.PictureBox()
        Me.pnlCurrency = New System.Windows.Forms.Panel()
        Me.lblCurrencyCancel = New System.Windows.Forms.Label()
        Me.lblCurrencyOk = New System.Windows.Forms.Label()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        CType(Me.picscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCurrency.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picscreen
        '
        Me.picscreen.Location = New System.Drawing.Point(0, 0)
        Me.picscreen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picscreen.Name = "picscreen"
        Me.picscreen.Size = New System.Drawing.Size(800, 608)
        Me.picscreen.TabIndex = 4
        Me.picscreen.TabStop = False
        '
        'pnlCurrency
        '
        Me.pnlCurrency.BackColor = System.Drawing.Color.DimGray
        Me.pnlCurrency.Controls.Add(Me.lblCurrencyCancel)
        Me.pnlCurrency.Controls.Add(Me.lblCurrencyOk)
        Me.pnlCurrency.Controls.Add(Me.txtCurrency)
        Me.pnlCurrency.Controls.Add(Me.lblCurrency)
        Me.pnlCurrency.Location = New System.Drawing.Point(152, 271)
        Me.pnlCurrency.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlCurrency.Name = "pnlCurrency"
        Me.pnlCurrency.Size = New System.Drawing.Size(410, 113)
        Me.pnlCurrency.TabIndex = 16
        Me.pnlCurrency.Visible = False
        '
        'lblCurrencyCancel
        '
        Me.lblCurrencyCancel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrencyCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrencyCancel.ForeColor = System.Drawing.Color.White
        Me.lblCurrencyCancel.Location = New System.Drawing.Point(250, 82)
        Me.lblCurrencyCancel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrencyCancel.Name = "lblCurrencyCancel"
        Me.lblCurrencyCancel.Size = New System.Drawing.Size(126, 18)
        Me.lblCurrencyCancel.TabIndex = 4
        Me.lblCurrencyCancel.Text = "Cancel"
        Me.lblCurrencyCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrencyOk
        '
        Me.lblCurrencyOk.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrencyOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrencyOk.ForeColor = System.Drawing.Color.White
        Me.lblCurrencyOk.Location = New System.Drawing.Point(15, 82)
        Me.lblCurrencyOk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrencyOk.Name = "lblCurrencyOk"
        Me.lblCurrencyOk.Size = New System.Drawing.Size(119, 18)
        Me.lblCurrencyOk.TabIndex = 3
        Me.lblCurrencyOk.Text = "Okay"
        Me.lblCurrencyOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrency
        '
        Me.txtCurrency.Location = New System.Drawing.Point(98, 40)
        Me.txtCurrency.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(209, 23)
        Me.txtCurrency.TabIndex = 2
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrency.ForeColor = System.Drawing.Color.White
        Me.lblCurrency.Location = New System.Drawing.Point(4, 0)
        Me.lblCurrency.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(402, 28)
        Me.lblCurrency.TabIndex = 1
        Me.lblCurrency.Text = "How many do you want to drop?"
        Me.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackgroundImage = CType(resources.GetObject("pnlMain.BackgroundImage"), System.Drawing.Image)
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlMain.Controls.Add(Me.PictureBox5)
        Me.pnlMain.Controls.Add(Me.PictureBox4)
        Me.pnlMain.Controls.Add(Me.PictureBox3)
        Me.pnlMain.Controls.Add(Me.PictureBox2)
        Me.pnlMain.Controls.Add(Me.PictureBox1)
        Me.pnlMain.Location = New System.Drawing.Point(806, 6)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(130, 385)
        Me.pnlMain.TabIndex = 17
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(66, 311)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(66, 259)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 259)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.DimGray
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Location = New System.Drawing.Point(3, 614)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(797, 16)
        Me.txtInput.TabIndex = 19
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.DimGray
        Me.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChat.ForeColor = System.Drawing.Color.White
        Me.txtChat.Location = New System.Drawing.Point(3, 636)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(797, 150)
        Me.txtChat.TabIndex = 20
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 788)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlCurrency)
        Me.Controls.Add(Me.picscreen)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "FrmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainGame"
        CType(Me.picscreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCurrency.ResumeLayout(False)
        Me.pnlCurrency.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picscreen As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCurrency As System.Windows.Forms.Panel
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents lblCurrencyCancel As System.Windows.Forms.Label
    Friend WithEvents lblCurrencyOk As System.Windows.Forms.Label
    Friend WithEvents txtCurrency As System.Windows.Forms.TextBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtInput As TextBox
    Public WithEvents txtChat As TextBox
End Class
