<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        Me.chkSavePass = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLoginPass = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.txtRPass2 = New System.Windows.Forms.TextBox()
        Me.btnCreateAccount = New System.Windows.Forms.PictureBox()
        Me.lblNewAccPass2 = New System.Windows.Forms.Label()
        Me.txtRPass = New System.Windows.Forms.TextBox()
        Me.lblNewAccPass = New System.Windows.Forms.Label()
        Me.txtRuser = New System.Windows.Forms.TextBox()
        Me.lblNewAccName = New System.Windows.Forms.Label()
        Me.lblNewAccount = New System.Windows.Forms.Label()
        Me.pnlNewChar = New System.Windows.Forms.Panel()
        Me.btnCreateCharacter = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblNewCharSprite = New System.Windows.Forms.Label()
        Me.placeholderforsprite = New System.Windows.Forms.PictureBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.cmbJob = New System.Windows.Forms.ComboBox()
        Me.lblNewCharGender = New System.Windows.Forms.Label()
        Me.lblNewCharJob = New System.Windows.Forms.Label()
        Me.txtCharName = New System.Windows.Forms.TextBox()
        Me.lblNewCharName = New System.Windows.Forms.Label()
        Me.lblNewChar = New System.Windows.Forms.Label()
        Me.pnlCredits = New System.Windows.Forms.Panel()
        Me.lblCreditsTop = New System.Windows.Forms.Label()
        Me.lblScrollingCredits = New System.Windows.Forms.Label()
        Me.tmrCredits = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.lblStatusHeader = New System.Windows.Forms.Label()
        Me.lblServerStatus = New System.Windows.Forms.Label()
        Me.pnlCharSelect = New System.Windows.Forms.Panel()
        Me.btnDelChar = New System.Windows.Forms.PictureBox()
        Me.btnUseChar = New System.Windows.Forms.PictureBox()
        Me.btnNewChar = New System.Windows.Forms.PictureBox()
        Me.picChar3 = New System.Windows.Forms.PictureBox()
        Me.picChar2 = New System.Windows.Forms.PictureBox()
        Me.picChar1 = New System.Windows.Forms.PictureBox()
        Me.lblCharSelect = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNewsHeader = New System.Windows.Forms.Label()
        Me.lblNews = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegister.SuspendLayout()
        CType(Me.btnCreateAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNewChar.SuspendLayout()
        CType(Me.btnCreateCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.placeholderforsprite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCredits.SuspendLayout()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCharSelect.SuspendLayout()
        CType(Me.btnDelChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUseChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.BackgroundImage = CType(resources.GetObject("pnlLogin.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.chkSavePass)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.lblLoginPass)
        Me.pnlLogin.Controls.Add(Me.txtLogin)
        Me.pnlLogin.Controls.Add(Me.lblLoginName)
        Me.pnlLogin.Controls.Add(Me.lblLogin)
        Me.pnlLogin.ForeColor = System.Drawing.Color.White
        Me.pnlLogin.Location = New System.Drawing.Point(213, 14)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(270, 261)
        Me.pnlLogin.TabIndex = 37
        Me.pnlLogin.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(151, 213)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(106, 38)
        Me.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.TabStop = False
        '
        'chkSavePass
        '
        Me.chkSavePass.AutoSize = True
        Me.chkSavePass.BackColor = System.Drawing.Color.Transparent
        Me.chkSavePass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkSavePass.Location = New System.Drawing.Point(30, 120)
        Me.chkSavePass.Name = "chkSavePass"
        Me.chkSavePass.Size = New System.Drawing.Size(123, 21)
        Me.chkSavePass.TabIndex = 25
        Me.chkSavePass.Text = "Save Password?"
        Me.chkSavePass.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(100, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(151, 25)
        Me.txtPassword.TabIndex = 24
        '
        'lblLoginPass
        '
        Me.lblLoginPass.AutoSize = True
        Me.lblLoginPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLoginPass.Location = New System.Drawing.Point(27, 93)
        Me.lblLoginPass.Name = "lblLoginPass"
        Me.lblLoginPass.Size = New System.Drawing.Size(70, 17)
        Me.lblLoginPass.TabIndex = 23
        Me.lblLoginPass.Text = "Password:"
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtLogin.Location = New System.Drawing.Point(100, 55)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(151, 25)
        Me.txtLogin.TabIndex = 17
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLoginName.Location = New System.Drawing.Point(27, 58)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(48, 17)
        Me.lblLoginName.TabIndex = 16
        Me.lblLoginName.Text = "Name:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogin.Location = New System.Drawing.Point(100, 7)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(69, 30)
        Me.lblLogin.TabIndex = 15
        Me.lblLogin.Text = "Login"
        '
        'pnlRegister
        '
        Me.pnlRegister.BackColor = System.Drawing.Color.Transparent
        Me.pnlRegister.BackgroundImage = CType(resources.GetObject("pnlRegister.BackgroundImage"), System.Drawing.Image)
        Me.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRegister.Controls.Add(Me.txtRPass2)
        Me.pnlRegister.Controls.Add(Me.btnCreateAccount)
        Me.pnlRegister.Controls.Add(Me.lblNewAccPass2)
        Me.pnlRegister.Controls.Add(Me.txtRPass)
        Me.pnlRegister.Controls.Add(Me.lblNewAccPass)
        Me.pnlRegister.Controls.Add(Me.txtRuser)
        Me.pnlRegister.Controls.Add(Me.lblNewAccName)
        Me.pnlRegister.Controls.Add(Me.lblNewAccount)
        Me.pnlRegister.ForeColor = System.Drawing.Color.White
        Me.pnlRegister.Location = New System.Drawing.Point(213, 14)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(270, 261)
        Me.pnlRegister.TabIndex = 38
        Me.pnlRegister.Visible = False
        '
        'txtRPass2
        '
        Me.txtRPass2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtRPass2.Location = New System.Drawing.Point(153, 124)
        Me.txtRPass2.Name = "txtRPass2"
        Me.txtRPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPass2.Size = New System.Drawing.Size(110, 25)
        Me.txtRPass2.TabIndex = 21
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Image = CType(resources.GetObject("btnCreateAccount.Image"), System.Drawing.Image)
        Me.btnCreateAccount.Location = New System.Drawing.Point(153, 213)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(106, 38)
        Me.btnCreateAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCreateAccount.TabIndex = 22
        Me.btnCreateAccount.TabStop = False
        '
        'lblNewAccPass2
        '
        Me.lblNewAccPass2.AutoSize = True
        Me.lblNewAccPass2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewAccPass2.Location = New System.Drawing.Point(25, 127)
        Me.lblNewAccPass2.Name = "lblNewAccPass2"
        Me.lblNewAccPass2.Size = New System.Drawing.Size(116, 17)
        Me.lblNewAccPass2.TabIndex = 20
        Me.lblNewAccPass2.Text = "Retype Password:"
        '
        'txtRPass
        '
        Me.txtRPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtRPass.Location = New System.Drawing.Point(153, 92)
        Me.txtRPass.Name = "txtRPass"
        Me.txtRPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPass.Size = New System.Drawing.Size(110, 25)
        Me.txtRPass.TabIndex = 19
        '
        'lblNewAccPass
        '
        Me.lblNewAccPass.AutoSize = True
        Me.lblNewAccPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewAccPass.Location = New System.Drawing.Point(71, 95)
        Me.lblNewAccPass.Name = "lblNewAccPass"
        Me.lblNewAccPass.Size = New System.Drawing.Size(70, 17)
        Me.lblNewAccPass.TabIndex = 18
        Me.lblNewAccPass.Text = "Password:"
        '
        'txtRuser
        '
        Me.txtRuser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtRuser.Location = New System.Drawing.Point(153, 58)
        Me.txtRuser.Name = "txtRuser"
        Me.txtRuser.Size = New System.Drawing.Size(110, 25)
        Me.txtRuser.TabIndex = 17
        '
        'lblNewAccName
        '
        Me.lblNewAccName.AutoSize = True
        Me.lblNewAccName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewAccName.Location = New System.Drawing.Point(71, 60)
        Me.lblNewAccName.Name = "lblNewAccName"
        Me.lblNewAccName.Size = New System.Drawing.Size(73, 17)
        Me.lblNewAccName.TabIndex = 16
        Me.lblNewAccName.Text = "Username:"
        '
        'lblNewAccount
        '
        Me.lblNewAccount.AutoSize = True
        Me.lblNewAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewAccount.Location = New System.Drawing.Point(57, 9)
        Me.lblNewAccount.Name = "lblNewAccount"
        Me.lblNewAccount.Size = New System.Drawing.Size(147, 30)
        Me.lblNewAccount.TabIndex = 15
        Me.lblNewAccount.Text = "New Account"
        '
        'pnlNewChar
        '
        Me.pnlNewChar.BackColor = System.Drawing.Color.Transparent
        Me.pnlNewChar.BackgroundImage = CType(resources.GetObject("pnlNewChar.BackgroundImage"), System.Drawing.Image)
        Me.pnlNewChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlNewChar.Controls.Add(Me.btnCreateCharacter)
        Me.pnlNewChar.Controls.Add(Me.txtDescription)
        Me.pnlNewChar.Controls.Add(Me.lblNewCharSprite)
        Me.pnlNewChar.Controls.Add(Me.placeholderforsprite)
        Me.pnlNewChar.Controls.Add(Me.rdoFemale)
        Me.pnlNewChar.Controls.Add(Me.rdoMale)
        Me.pnlNewChar.Controls.Add(Me.cmbJob)
        Me.pnlNewChar.Controls.Add(Me.lblNewCharGender)
        Me.pnlNewChar.Controls.Add(Me.lblNewCharJob)
        Me.pnlNewChar.Controls.Add(Me.txtCharName)
        Me.pnlNewChar.Controls.Add(Me.lblNewCharName)
        Me.pnlNewChar.Controls.Add(Me.lblNewChar)
        Me.pnlNewChar.ForeColor = System.Drawing.Color.White
        Me.pnlNewChar.Location = New System.Drawing.Point(213, 14)
        Me.pnlNewChar.Name = "pnlNewChar"
        Me.pnlNewChar.Size = New System.Drawing.Size(270, 261)
        Me.pnlNewChar.TabIndex = 43
        Me.pnlNewChar.Visible = False
        '
        'btnCreateCharacter
        '
        Me.btnCreateCharacter.Image = CType(resources.GetObject("btnCreateCharacter.Image"), System.Drawing.Image)
        Me.btnCreateCharacter.Location = New System.Drawing.Point(152, 213)
        Me.btnCreateCharacter.Name = "btnCreateCharacter"
        Me.btnCreateCharacter.Size = New System.Drawing.Size(106, 38)
        Me.btnCreateCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCreateCharacter.TabIndex = 45
        Me.btnCreateCharacter.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDescription.Location = New System.Drawing.Point(13, 199)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(133, 52)
        Me.txtDescription.TabIndex = 44
        '
        'lblNewCharSprite
        '
        Me.lblNewCharSprite.AutoSize = True
        Me.lblNewCharSprite.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewCharSprite.Location = New System.Drawing.Point(49, 71)
        Me.lblNewCharSprite.Name = "lblNewCharSprite"
        Me.lblNewCharSprite.Size = New System.Drawing.Size(42, 17)
        Me.lblNewCharSprite.TabIndex = 43
        Me.lblNewCharSprite.Text = "Sprite"
        '
        'placeholderforsprite
        '
        Me.placeholderforsprite.Location = New System.Drawing.Point(50, 91)
        Me.placeholderforsprite.Name = "placeholderforsprite"
        Me.placeholderforsprite.Size = New System.Drawing.Size(48, 60)
        Me.placeholderforsprite.TabIndex = 41
        Me.placeholderforsprite.TabStop = False
        Me.placeholderforsprite.Visible = False
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoFemale.Location = New System.Drawing.Point(135, 118)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(67, 21)
        Me.rdoFemale.TabIndex = 38
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoMale.Location = New System.Drawing.Point(135, 93)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(55, 21)
        Me.rdoMale.TabIndex = 37
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'cmbJob
        '
        Me.cmbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbJob.FormattingEnabled = True
        Me.cmbJob.Location = New System.Drawing.Point(55, 167)
        Me.cmbJob.Name = "cmbJob"
        Me.cmbJob.Size = New System.Drawing.Size(157, 25)
        Me.cmbJob.TabIndex = 36
        '
        'lblNewCharGender
        '
        Me.lblNewCharGender.AutoSize = True
        Me.lblNewCharGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewCharGender.Location = New System.Drawing.Point(133, 75)
        Me.lblNewCharGender.Name = "lblNewCharGender"
        Me.lblNewCharGender.Size = New System.Drawing.Size(54, 17)
        Me.lblNewCharGender.TabIndex = 34
        Me.lblNewCharGender.Text = "Gender:"
        '
        'lblNewCharJob
        '
        Me.lblNewCharJob.AutoSize = True
        Me.lblNewCharJob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewCharJob.Location = New System.Drawing.Point(17, 167)
        Me.lblNewCharJob.Name = "lblNewCharJob"
        Me.lblNewCharJob.Size = New System.Drawing.Size(32, 17)
        Me.lblNewCharJob.TabIndex = 33
        Me.lblNewCharJob.Text = "Job:"
        '
        'txtCharName
        '
        Me.txtCharName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCharName.Location = New System.Drawing.Point(59, 42)
        Me.txtCharName.Name = "txtCharName"
        Me.txtCharName.Size = New System.Drawing.Size(121, 25)
        Me.txtCharName.TabIndex = 32
        '
        'lblNewCharName
        '
        Me.lblNewCharName.AutoSize = True
        Me.lblNewCharName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewCharName.ForeColor = System.Drawing.Color.White
        Me.lblNewCharName.Location = New System.Drawing.Point(13, 45)
        Me.lblNewCharName.Name = "lblNewCharName"
        Me.lblNewCharName.Size = New System.Drawing.Size(46, 17)
        Me.lblNewCharName.TabIndex = 31
        Me.lblNewCharName.Text = "Name:"
        '
        'lblNewChar
        '
        Me.lblNewChar.AutoSize = True
        Me.lblNewChar.Font = New System.Drawing.Font("Segoe UI Semibold", 16.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewChar.ForeColor = System.Drawing.Color.White
        Me.lblNewChar.Location = New System.Drawing.Point(47, 0)
        Me.lblNewChar.Name = "lblNewChar"
        Me.lblNewChar.Size = New System.Drawing.Size(187, 31)
        Me.lblNewChar.TabIndex = 30
        Me.lblNewChar.Text = "Create Character"
        '
        'pnlCredits
        '
        Me.pnlCredits.BackColor = System.Drawing.Color.Transparent
        Me.pnlCredits.BackgroundImage = CType(resources.GetObject("pnlCredits.BackgroundImage"), System.Drawing.Image)
        Me.pnlCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlCredits.Controls.Add(Me.lblCreditsTop)
        Me.pnlCredits.Controls.Add(Me.lblScrollingCredits)
        Me.pnlCredits.ForeColor = System.Drawing.Color.White
        Me.pnlCredits.Location = New System.Drawing.Point(213, 14)
        Me.pnlCredits.Name = "pnlCredits"
        Me.pnlCredits.Size = New System.Drawing.Size(270, 261)
        Me.pnlCredits.TabIndex = 39
        Me.pnlCredits.Visible = False
        '
        'lblCreditsTop
        '
        Me.lblCreditsTop.BackColor = System.Drawing.Color.Transparent
        Me.lblCreditsTop.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCreditsTop.Location = New System.Drawing.Point(13, 7)
        Me.lblCreditsTop.Name = "lblCreditsTop"
        Me.lblCreditsTop.Size = New System.Drawing.Size(247, 34)
        Me.lblCreditsTop.TabIndex = 15
        Me.lblCreditsTop.Text = "Credits"
        Me.lblCreditsTop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScrollingCredits
        '
        Me.lblScrollingCredits.AutoSize = True
        Me.lblScrollingCredits.BackColor = System.Drawing.Color.Transparent
        Me.lblScrollingCredits.Location = New System.Drawing.Point(70, 179)
        Me.lblScrollingCredits.Name = "lblScrollingCredits"
        Me.lblScrollingCredits.Size = New System.Drawing.Size(0, 13)
        Me.lblScrollingCredits.TabIndex = 17
        Me.lblScrollingCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrCredits
        '
        Me.tmrCredits.Enabled = True
        Me.tmrCredits.Interval = 1000
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlay.Location = New System.Drawing.Point(247, 97)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(204, 30)
        Me.btnPlay.TabIndex = 59
        Me.btnPlay.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BackgroundImage = CType(resources.GetObject("btnRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRegister.Location = New System.Drawing.Point(247, 133)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(204, 30)
        Me.btnRegister.TabIndex = 60
        Me.btnRegister.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Location = New System.Drawing.Point(247, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(204, 30)
        Me.btnExit.TabIndex = 61
        Me.btnExit.TabStop = False
        '
        'lblStatusHeader
        '
        Me.lblStatusHeader.AutoSize = True
        Me.lblStatusHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusHeader.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStatusHeader.ForeColor = System.Drawing.Color.White
        Me.lblStatusHeader.Location = New System.Drawing.Point(205, 278)
        Me.lblStatusHeader.Name = "lblStatusHeader"
        Me.lblStatusHeader.Size = New System.Drawing.Size(77, 13)
        Me.lblStatusHeader.TabIndex = 44
        Me.lblStatusHeader.Text = "Server Status:"
        '
        'lblServerStatus
        '
        Me.lblServerStatus.AutoSize = True
        Me.lblServerStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblServerStatus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblServerStatus.ForeColor = System.Drawing.Color.Red
        Me.lblServerStatus.Location = New System.Drawing.Point(279, 278)
        Me.lblServerStatus.Name = "lblServerStatus"
        Me.lblServerStatus.Size = New System.Drawing.Size(42, 13)
        Me.lblServerStatus.TabIndex = 45
        Me.lblServerStatus.Text = "Offline"
        '
        'pnlCharSelect
        '
        Me.pnlCharSelect.BackColor = System.Drawing.Color.Transparent
        Me.pnlCharSelect.BackgroundImage = CType(resources.GetObject("pnlCharSelect.BackgroundImage"), System.Drawing.Image)
        Me.pnlCharSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlCharSelect.Controls.Add(Me.btnDelChar)
        Me.pnlCharSelect.Controls.Add(Me.btnUseChar)
        Me.pnlCharSelect.Controls.Add(Me.btnNewChar)
        Me.pnlCharSelect.Controls.Add(Me.picChar3)
        Me.pnlCharSelect.Controls.Add(Me.picChar2)
        Me.pnlCharSelect.Controls.Add(Me.picChar1)
        Me.pnlCharSelect.Controls.Add(Me.lblCharSelect)
        Me.pnlCharSelect.Controls.Add(Me.Label16)
        Me.pnlCharSelect.ForeColor = System.Drawing.Color.White
        Me.pnlCharSelect.Location = New System.Drawing.Point(213, 14)
        Me.pnlCharSelect.Name = "pnlCharSelect"
        Me.pnlCharSelect.Size = New System.Drawing.Size(270, 261)
        Me.pnlCharSelect.TabIndex = 57
        Me.pnlCharSelect.Visible = False
        '
        'btnDelChar
        '
        Me.btnDelChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelChar.Image = CType(resources.GetObject("btnDelChar.Image"), System.Drawing.Image)
        Me.btnDelChar.Location = New System.Drawing.Point(76, 213)
        Me.btnDelChar.Name = "btnDelChar"
        Me.btnDelChar.Size = New System.Drawing.Size(106, 38)
        Me.btnDelChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDelChar.TabIndex = 55
        Me.btnDelChar.TabStop = False
        '
        'btnUseChar
        '
        Me.btnUseChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUseChar.Image = CType(resources.GetObject("btnUseChar.Image"), System.Drawing.Image)
        Me.btnUseChar.Location = New System.Drawing.Point(76, 167)
        Me.btnUseChar.Name = "btnUseChar"
        Me.btnUseChar.Size = New System.Drawing.Size(106, 38)
        Me.btnUseChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUseChar.TabIndex = 54
        Me.btnUseChar.TabStop = False
        '
        'btnNewChar
        '
        Me.btnNewChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNewChar.Image = CType(resources.GetObject("btnNewChar.Image"), System.Drawing.Image)
        Me.btnNewChar.Location = New System.Drawing.Point(76, 120)
        Me.btnNewChar.Name = "btnNewChar"
        Me.btnNewChar.Size = New System.Drawing.Size(106, 38)
        Me.btnNewChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnNewChar.TabIndex = 53
        Me.btnNewChar.TabStop = False
        '
        'picChar3
        '
        Me.picChar3.BackColor = System.Drawing.Color.Transparent
        Me.picChar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picChar3.Location = New System.Drawing.Point(161, 52)
        Me.picChar3.Name = "picChar3"
        Me.picChar3.Size = New System.Drawing.Size(48, 60)
        Me.picChar3.TabIndex = 44
        Me.picChar3.TabStop = False
        '
        'picChar2
        '
        Me.picChar2.BackColor = System.Drawing.Color.Transparent
        Me.picChar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picChar2.Location = New System.Drawing.Point(107, 52)
        Me.picChar2.Name = "picChar2"
        Me.picChar2.Size = New System.Drawing.Size(48, 60)
        Me.picChar2.TabIndex = 43
        Me.picChar2.TabStop = False
        '
        'picChar1
        '
        Me.picChar1.BackColor = System.Drawing.Color.Transparent
        Me.picChar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picChar1.Location = New System.Drawing.Point(52, 52)
        Me.picChar1.Name = "picChar1"
        Me.picChar1.Size = New System.Drawing.Size(48, 60)
        Me.picChar1.TabIndex = 42
        Me.picChar1.TabStop = False
        '
        'lblCharSelect
        '
        Me.lblCharSelect.BackColor = System.Drawing.Color.Transparent
        Me.lblCharSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 16.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCharSelect.Location = New System.Drawing.Point(18, 7)
        Me.lblCharSelect.Name = "lblCharSelect"
        Me.lblCharSelect.Size = New System.Drawing.Size(234, 33)
        Me.lblCharSelect.TabIndex = 15
        Me.lblCharSelect.Text = "Character Selection"
        Me.lblCharSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(70, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewsHeader
        '
        Me.lblNewsHeader.AutoSize = True
        Me.lblNewsHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblNewsHeader.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewsHeader.Location = New System.Drawing.Point(702, 24)
        Me.lblNewsHeader.Name = "lblNewsHeader"
        Me.lblNewsHeader.Size = New System.Drawing.Size(171, 40)
        Me.lblNewsHeader.TabIndex = 36
        Me.lblNewsHeader.Text = "Latest News"
        '
        'lblNews
        '
        Me.lblNews.BackColor = System.Drawing.Color.Gray
        Me.lblNews.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNews.Location = New System.Drawing.Point(673, 64)
        Me.lblNews.Name = "lblNews"
        Me.lblNews.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNews.Size = New System.Drawing.Size(234, 121)
        Me.lblNews.TabIndex = 37
        Me.lblNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.lblNewsHeader)
        Me.Controls.Add(Me.lblServerStatus)
        Me.Controls.Add(Me.lblNews)
        Me.Controls.Add(Me.lblStatusHeader)
        Me.Controls.Add(Me.pnlNewChar)
        Me.Controls.Add(Me.pnlCharSelect)
        Me.Controls.Add(Me.pnlCredits)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        CType(Me.btnCreateAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNewChar.ResumeLayout(False)
        Me.pnlNewChar.PerformLayout()
        CType(Me.btnCreateCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.placeholderforsprite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCredits.ResumeLayout(False)
        Me.pnlCredits.PerformLayout()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCharSelect.ResumeLayout(False)
        Me.pnlCharSelect.PerformLayout()
        CType(Me.btnDelChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUseChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents chkSavePass As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginPass As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents pnlRegister As System.Windows.Forms.Panel
    Friend WithEvents txtRPass2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNewAccPass2 As System.Windows.Forms.Label
    Friend WithEvents txtRPass As System.Windows.Forms.TextBox
    Friend WithEvents lblNewAccPass As System.Windows.Forms.Label
    Friend WithEvents txtRuser As System.Windows.Forms.TextBox
    Friend WithEvents lblNewAccName As System.Windows.Forms.Label
    Friend WithEvents lblNewAccount As System.Windows.Forms.Label
    Friend WithEvents pnlCredits As System.Windows.Forms.Panel
    Friend WithEvents lblCreditsTop As System.Windows.Forms.Label
    Friend WithEvents lblScrollingCredits As System.Windows.Forms.Label
    Friend WithEvents tmrCredits As System.Windows.Forms.Timer
    Friend WithEvents pnlNewChar As System.Windows.Forms.Panel
    Friend WithEvents placeholderforsprite As System.Windows.Forms.PictureBox
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbJob As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewCharGender As System.Windows.Forms.Label
    Friend WithEvents lblNewCharJob As System.Windows.Forms.Label
    Friend WithEvents txtCharName As System.Windows.Forms.TextBox
    Friend WithEvents lblNewCharName As System.Windows.Forms.Label
    Friend WithEvents lblNewChar As System.Windows.Forms.Label
    Friend WithEvents lblStatusHeader As System.Windows.Forms.Label
    Friend WithEvents lblServerStatus As System.Windows.Forms.Label
    Friend WithEvents lblNewsHeader As System.Windows.Forms.Label
    Friend WithEvents lblNews As System.Windows.Forms.Label
    Friend WithEvents pnlCharSelect As Windows.Forms.Panel
    Friend WithEvents lblCharSelect As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents picChar3 As Windows.Forms.PictureBox
    Friend WithEvents picChar2 As Windows.Forms.PictureBox
    Friend WithEvents picChar1 As Windows.Forms.PictureBox
    Friend WithEvents txtDescription As Windows.Forms.TextBox
    Friend WithEvents lblNewCharSprite As Windows.Forms.Label
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents btnRegister As PictureBox
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents btnNewChar As PictureBox
    Friend WithEvents btnDelChar As PictureBox
    Friend WithEvents btnUseChar As PictureBox
    Friend WithEvents btnCreateCharacter As PictureBox
    Friend WithEvents btnCreateAccount As PictureBox
    Friend WithEvents btnLogin As PictureBox
End Class
