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
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.BtnSkills = New Engine.CustomButton()
        Me.BtnInventory = New Engine.CustomButton()
        Me.lstInv = New System.Windows.Forms.ListBox()
        Me.lstSkills = New System.Windows.Forms.ListBox()
        Me.panel20 = New System.Windows.Forms.Panel()
        Me.lblRoomName = New System.Windows.Forms.Label()
        Me.pnlChat = New System.Windows.Forms.Panel()
        Me.pnlCurrency = New System.Windows.Forms.Panel()
        Me.lblCurrencyCancel = New System.Windows.Forms.Label()
        Me.lblCurrencyOk = New System.Windows.Forms.Label()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.rtbChat = New System.Windows.Forms.RichTextBox()
        Me.pnlRoomDesc = New System.Windows.Forms.Panel()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.pnlMiniMap = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.pnlDialog = New System.Windows.Forms.Panel()
        Me.BtnDialogClose = New Engine.CustomButton()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRoomContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblSpirit = New System.Windows.Forms.Label()
        Me.lblLuck = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.pnlExp = New System.Windows.Forms.Panel()
        Me.picExp = New System.Windows.Forms.PictureBox()
        Me.pnlStamina = New System.Windows.Forms.Panel()
        Me.picStamina = New System.Windows.Forms.PictureBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblVit = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pnlMP = New System.Windows.Forms.Panel()
        Me.picMP = New System.Windows.Forms.PictureBox()
        Me.pnlHP = New System.Windows.Forms.Panel()
        Me.picHP = New System.Windows.Forms.PictureBox()
        Me.panel15 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picPAvatar = New System.Windows.Forms.PictureBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblStamina = New System.Windows.Forms.Label()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.pnlActionBtns = New System.Windows.Forms.Panel()
        Me.BtnAction6 = New Engine.CustomButton()
        Me.BtnAction5 = New Engine.CustomButton()
        Me.BtnAction4 = New Engine.CustomButton()
        Me.BtnAction3 = New Engine.CustomButton()
        Me.BtnAction2 = New Engine.CustomButton()
        Me.BtnAction1 = New Engine.CustomButton()
        CType(Me.picscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        Me.panel20.SuspendLayout()
        Me.pnlChat.SuspendLayout()
        Me.pnlCurrency.SuspendLayout()
        Me.pnlRoomDesc.SuspendLayout()
        Me.pnlMiniMap.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDialog.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStats.SuspendLayout()
        Me.pnlExp.SuspendLayout()
        CType(Me.picExp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStamina.SuspendLayout()
        CType(Me.picStamina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMP.SuspendLayout()
        CType(Me.picMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHP.SuspendLayout()
        CType(Me.picHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel15.SuspendLayout()
        CType(Me.picPAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActionBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'picscreen
        '
        Me.picscreen.Location = New System.Drawing.Point(1081, 89)
        Me.picscreen.Name = "picscreen"
        Me.picscreen.Size = New System.Drawing.Size(630, 440)
        Me.picscreen.TabIndex = 4
        Me.picscreen.TabStop = False
        '
        'pnlInventory
        '
        Me.pnlInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlInventory.Controls.Add(Me.BtnSkills)
        Me.pnlInventory.Controls.Add(Me.BtnInventory)
        Me.pnlInventory.Controls.Add(Me.lstInv)
        Me.pnlInventory.Controls.Add(Me.lstSkills)
        Me.pnlInventory.Location = New System.Drawing.Point(5, 301)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(195, 251)
        Me.pnlInventory.TabIndex = 116
        '
        'BtnSkills
        '
        Me.BtnSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSkills.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSkills.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnSkills.BorderRadius = 0
        Me.BtnSkills.BorderSize = 1
        Me.BtnSkills.FlatAppearance.BorderSize = 0
        Me.BtnSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSkills.ForeColor = System.Drawing.Color.White
        Me.BtnSkills.Location = New System.Drawing.Point(98, 3)
        Me.BtnSkills.Name = "BtnSkills"
        Me.BtnSkills.Size = New System.Drawing.Size(95, 22)
        Me.BtnSkills.TabIndex = 6
        Me.BtnSkills.Text = "Skills/Spells"
        Me.BtnSkills.TextColor = System.Drawing.Color.White
        Me.BtnSkills.UseVisualStyleBackColor = False
        '
        'BtnInventory
        '
        Me.BtnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BtnInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BtnInventory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnInventory.BorderRadius = 0
        Me.BtnInventory.BorderSize = 1
        Me.BtnInventory.FlatAppearance.BorderSize = 0
        Me.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventory.ForeColor = System.Drawing.Color.White
        Me.BtnInventory.Location = New System.Drawing.Point(3, 3)
        Me.BtnInventory.Name = "BtnInventory"
        Me.BtnInventory.Size = New System.Drawing.Size(95, 22)
        Me.BtnInventory.TabIndex = 5
        Me.BtnInventory.Text = "Inventory"
        Me.BtnInventory.TextColor = System.Drawing.Color.White
        Me.BtnInventory.UseVisualStyleBackColor = False
        '
        'lstInv
        '
        Me.lstInv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lstInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstInv.ForeColor = System.Drawing.Color.White
        Me.lstInv.FormattingEnabled = True
        Me.lstInv.Items.AddRange(New Object() {"Inventory"})
        Me.lstInv.Location = New System.Drawing.Point(4, 31)
        Me.lstInv.Name = "lstInv"
        Me.lstInv.Size = New System.Drawing.Size(187, 208)
        Me.lstInv.TabIndex = 3
        '
        'lstSkills
        '
        Me.lstSkills.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lstSkills.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSkills.ForeColor = System.Drawing.Color.White
        Me.lstSkills.FormattingEnabled = True
        Me.lstSkills.Items.AddRange(New Object() {"Skills"})
        Me.lstSkills.Location = New System.Drawing.Point(4, 31)
        Me.lstSkills.Name = "lstSkills"
        Me.lstSkills.Size = New System.Drawing.Size(187, 208)
        Me.lstSkills.TabIndex = 4
        '
        'panel20
        '
        Me.panel20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.panel20.Controls.Add(Me.lblRoomName)
        Me.panel20.Location = New System.Drawing.Point(204, 8)
        Me.panel20.Name = "panel20"
        Me.panel20.Size = New System.Drawing.Size(621, 20)
        Me.panel20.TabIndex = 115
        '
        'lblRoomName
        '
        Me.lblRoomName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRoomName.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomName.ForeColor = System.Drawing.Color.Khaki
        Me.lblRoomName.Location = New System.Drawing.Point(4, 1)
        Me.lblRoomName.Name = "lblRoomName"
        Me.lblRoomName.Size = New System.Drawing.Size(612, 15)
        Me.lblRoomName.TabIndex = 3
        Me.lblRoomName.Text = "Boars Tusk Inn"
        Me.lblRoomName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlChat
        '
        Me.pnlChat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChat.Controls.Add(Me.pnlCurrency)
        Me.pnlChat.Controls.Add(Me.rtbChat)
        Me.pnlChat.Location = New System.Drawing.Point(204, 158)
        Me.pnlChat.Name = "pnlChat"
        Me.pnlChat.Size = New System.Drawing.Size(528, 368)
        Me.pnlChat.TabIndex = 113
        '
        'pnlCurrency
        '
        Me.pnlCurrency.BackColor = System.Drawing.Color.DimGray
        Me.pnlCurrency.Controls.Add(Me.lblCurrencyCancel)
        Me.pnlCurrency.Controls.Add(Me.lblCurrencyOk)
        Me.pnlCurrency.Controls.Add(Me.txtCurrency)
        Me.pnlCurrency.Controls.Add(Me.lblCurrency)
        Me.pnlCurrency.Location = New System.Drawing.Point(107, 60)
        Me.pnlCurrency.Name = "pnlCurrency"
        Me.pnlCurrency.Size = New System.Drawing.Size(351, 98)
        Me.pnlCurrency.TabIndex = 16
        Me.pnlCurrency.Visible = False
        '
        'lblCurrencyCancel
        '
        Me.lblCurrencyCancel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrencyCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencyCancel.ForeColor = System.Drawing.Color.White
        Me.lblCurrencyCancel.Location = New System.Drawing.Point(214, 71)
        Me.lblCurrencyCancel.Name = "lblCurrencyCancel"
        Me.lblCurrencyCancel.Size = New System.Drawing.Size(108, 16)
        Me.lblCurrencyCancel.TabIndex = 4
        Me.lblCurrencyCancel.Text = "Cancel"
        Me.lblCurrencyCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrencyOk
        '
        Me.lblCurrencyOk.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrencyOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencyOk.ForeColor = System.Drawing.Color.White
        Me.lblCurrencyOk.Location = New System.Drawing.Point(13, 71)
        Me.lblCurrencyOk.Name = "lblCurrencyOk"
        Me.lblCurrencyOk.Size = New System.Drawing.Size(102, 16)
        Me.lblCurrencyOk.TabIndex = 3
        Me.lblCurrencyOk.Text = "Okay"
        Me.lblCurrencyOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrency
        '
        Me.txtCurrency.Location = New System.Drawing.Point(84, 35)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(180, 20)
        Me.txtCurrency.TabIndex = 2
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.ForeColor = System.Drawing.Color.White
        Me.lblCurrency.Location = New System.Drawing.Point(3, 0)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(345, 24)
        Me.lblCurrency.TabIndex = 1
        Me.lblCurrency.Text = "How many do you want to drop?"
        Me.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbChat
        '
        Me.rtbChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbChat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbChat.ForeColor = System.Drawing.Color.White
        Me.rtbChat.Location = New System.Drawing.Point(0, 0)
        Me.rtbChat.Name = "rtbChat"
        Me.rtbChat.ReadOnly = True
        Me.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbChat.Size = New System.Drawing.Size(526, 366)
        Me.rtbChat.TabIndex = 19
        Me.rtbChat.Text = ""
        '
        'pnlRoomDesc
        '
        Me.pnlRoomDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRoomDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlRoomDesc.Controls.Add(Me.label30)
        Me.pnlRoomDesc.Controls.Add(Me.label29)
        Me.pnlRoomDesc.Controls.Add(Me.label28)
        Me.pnlRoomDesc.Location = New System.Drawing.Point(204, 32)
        Me.pnlRoomDesc.Name = "pnlRoomDesc"
        Me.pnlRoomDesc.Size = New System.Drawing.Size(621, 121)
        Me.pnlRoomDesc.TabIndex = 114
        '
        'label30
        '
        Me.label30.AutoEllipsis = True
        Me.label30.AutoSize = True
        Me.label30.BackColor = System.Drawing.Color.Transparent
        Me.label30.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label30.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label30.Location = New System.Drawing.Point(50, 101)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(39, 14)
        Me.label30.TabIndex = 87
        Me.label30.Text = "East."
        '
        'label29
        '
        Me.label29.AutoEllipsis = True
        Me.label29.AutoSize = True
        Me.label29.BackColor = System.Drawing.Color.Transparent
        Me.label29.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label29.Location = New System.Drawing.Point(6, 101)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(44, 14)
        Me.label29.TabIndex = 86
        Me.label29.Text = "Exits:"
        '
        'label28
        '
        Me.label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label28.BackColor = System.Drawing.Color.Transparent
        Me.label28.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label28.Location = New System.Drawing.Point(6, 6)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(610, 81)
        Me.label28.TabIndex = 85
        Me.label28.Text = resources.GetString("label28.Text")
        '
        'pnlMiniMap
        '
        Me.pnlMiniMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMiniMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlMiniMap.Controls.Add(Me.pictureBox4)
        Me.pnlMiniMap.Controls.Add(Me.picMap)
        Me.pnlMiniMap.Location = New System.Drawing.Point(829, 320)
        Me.pnlMiniMap.Name = "pnlMiniMap"
        Me.pnlMiniMap.Size = New System.Drawing.Size(230, 232)
        Me.pnlMiniMap.TabIndex = 112
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.Location = New System.Drawing.Point(109, 127)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(12, 12)
        Me.pictureBox4.TabIndex = 1
        Me.pictureBox4.TabStop = False
        '
        'picMap
        '
        Me.picMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picMap.Image = CType(resources.GetObject("picMap.Image"), System.Drawing.Image)
        Me.picMap.Location = New System.Drawing.Point(-47, -471)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(358, 715)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMap.TabIndex = 0
        Me.picMap.TabStop = False
        '
        'pnlDialog
        '
        Me.pnlDialog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlDialog.Controls.Add(Me.BtnDialogClose)
        Me.pnlDialog.Controls.Add(Me.label5)
        Me.pnlDialog.Controls.Add(Me.label4)
        Me.pnlDialog.Controls.Add(Me.label3)
        Me.pnlDialog.Controls.Add(Me.label2)
        Me.pnlDialog.Controls.Add(Me.pictureBox1)
        Me.pnlDialog.Location = New System.Drawing.Point(204, 386)
        Me.pnlDialog.Name = "pnlDialog"
        Me.pnlDialog.Size = New System.Drawing.Size(621, 121)
        Me.pnlDialog.TabIndex = 118
        Me.pnlDialog.Visible = False
        '
        'BtnDialogClose
        '
        Me.BtnDialogClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDialogClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnDialogClose.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnDialogClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnDialogClose.BorderRadius = 0
        Me.BtnDialogClose.BorderSize = 1
        Me.BtnDialogClose.FlatAppearance.BorderSize = 0
        Me.BtnDialogClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDialogClose.ForeColor = System.Drawing.Color.White
        Me.BtnDialogClose.Location = New System.Drawing.Point(533, 94)
        Me.BtnDialogClose.Name = "BtnDialogClose"
        Me.BtnDialogClose.Size = New System.Drawing.Size(82, 22)
        Me.BtnDialogClose.TabIndex = 90
        Me.BtnDialogClose.Text = "Close"
        Me.BtnDialogClose.TextColor = System.Drawing.Color.White
        Me.BtnDialogClose.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoEllipsis = True
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.label5.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.label5.Location = New System.Drawing.Point(234, 101)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(136, 13)
        Me.label5.TabIndex = 89
        Me.label5.Text = "Mind your business!"
        '
        'label4
        '
        Me.label4.AutoEllipsis = True
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.label4.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.label4.Location = New System.Drawing.Point(7, 101)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(179, 13)
        Me.label4.TabIndex = 88
        Me.label4.Text = "I'm looking for somebody."
        '
        'label3
        '
        Me.label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoEllipsis = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label3.Location = New System.Drawing.Point(61, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(557, 60)
        Me.label3.TabIndex = 84
        Me.label3.Text = "Hello adventurer!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What brings you to the city of Nightmist?"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.label2.Location = New System.Drawing.Point(61, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 14)
        Me.label2.TabIndex = 83
        Me.label2.Text = "Kubrick"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Black
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(7, 8)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 82
        Me.pictureBox1.TabStop = False
        '
        'pnlRoomContent
        '
        Me.pnlRoomContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRoomContent.AutoScroll = True
        Me.pnlRoomContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlRoomContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlRoomContent.Location = New System.Drawing.Point(829, 8)
        Me.pnlRoomContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRoomContent.Name = "pnlRoomContent"
        Me.pnlRoomContent.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlRoomContent.Size = New System.Drawing.Size(230, 306)
        Me.pnlRoomContent.TabIndex = 117
        Me.pnlRoomContent.WrapContents = False
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlStats.Controls.Add(Me.lblSpirit)
        Me.pnlStats.Controls.Add(Me.lblLuck)
        Me.pnlStats.Controls.Add(Me.label13)
        Me.pnlStats.Controls.Add(Me.label12)
        Me.pnlStats.Controls.Add(Me.pnlExp)
        Me.pnlStats.Controls.Add(Me.pnlStamina)
        Me.pnlStats.Controls.Add(Me.lblClass)
        Me.pnlStats.Controls.Add(Me.lblRace)
        Me.pnlStats.Controls.Add(Me.label18)
        Me.pnlStats.Controls.Add(Me.label16)
        Me.pnlStats.Controls.Add(Me.lblInt)
        Me.pnlStats.Controls.Add(Me.lblVit)
        Me.pnlStats.Controls.Add(Me.lblEnd)
        Me.pnlStats.Controls.Add(Me.lblStr)
        Me.pnlStats.Controls.Add(Me.label8)
        Me.pnlStats.Controls.Add(Me.label1)
        Me.pnlStats.Controls.Add(Me.pnlMP)
        Me.pnlStats.Controls.Add(Me.pnlHP)
        Me.pnlStats.Controls.Add(Me.panel15)
        Me.pnlStats.Controls.Add(Me.lblBank)
        Me.pnlStats.Controls.Add(Me.lblGold)
        Me.pnlStats.Controls.Add(Me.Label10)
        Me.pnlStats.Controls.Add(Me.Label9)
        Me.pnlStats.Controls.Add(Me.lblLevel)
        Me.pnlStats.Controls.Add(Me.Label7)
        Me.pnlStats.Controls.Add(Me.lblMP)
        Me.pnlStats.Controls.Add(Me.lblHP)
        Me.pnlStats.Controls.Add(Me.lblStamina)
        Me.pnlStats.Controls.Add(Me.lblExp)
        Me.pnlStats.Controls.Add(Me.label11)
        Me.pnlStats.Controls.Add(Me.label6)
        Me.pnlStats.Location = New System.Drawing.Point(5, 8)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(195, 287)
        Me.pnlStats.TabIndex = 110
        '
        'lblSpirit
        '
        Me.lblSpirit.AutoEllipsis = True
        Me.lblSpirit.BackColor = System.Drawing.Color.Transparent
        Me.lblSpirit.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblSpirit.ForeColor = System.Drawing.Color.Khaki
        Me.lblSpirit.Location = New System.Drawing.Point(101, 143)
        Me.lblSpirit.Name = "lblSpirit"
        Me.lblSpirit.Size = New System.Drawing.Size(70, 12)
        Me.lblSpirit.TabIndex = 125
        Me.lblSpirit.Text = "16"
        Me.lblSpirit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLuck
        '
        Me.lblLuck.AutoEllipsis = True
        Me.lblLuck.BackColor = System.Drawing.Color.Transparent
        Me.lblLuck.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblLuck.ForeColor = System.Drawing.Color.Khaki
        Me.lblLuck.Location = New System.Drawing.Point(101, 132)
        Me.lblLuck.Name = "lblLuck"
        Me.lblLuck.Size = New System.Drawing.Size(70, 12)
        Me.lblLuck.TabIndex = 124
        Me.lblLuck.Text = "16"
        Me.lblLuck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label13
        '
        Me.label13.AutoEllipsis = True
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(3, 143)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(80, 12)
        Me.label13.TabIndex = 123
        Me.label13.Text = "Spirit"
        '
        'label12
        '
        Me.label12.AutoEllipsis = True
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(2, 132)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(80, 12)
        Me.label12.TabIndex = 122
        Me.label12.Text = "Luck"
        '
        'pnlExp
        '
        Me.pnlExp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExp.Controls.Add(Me.picExp)
        Me.pnlExp.Location = New System.Drawing.Point(3, 266)
        Me.pnlExp.Name = "pnlExp"
        Me.pnlExp.Size = New System.Drawing.Size(188, 11)
        Me.pnlExp.TabIndex = 121
        '
        'picExp
        '
        Me.picExp.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picExp.Location = New System.Drawing.Point(-1, -1)
        Me.picExp.Name = "picExp"
        Me.picExp.Size = New System.Drawing.Size(188, 10)
        Me.picExp.TabIndex = 1
        Me.picExp.TabStop = False
        '
        'pnlStamina
        '
        Me.pnlStamina.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlStamina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStamina.Controls.Add(Me.picStamina)
        Me.pnlStamina.Location = New System.Drawing.Point(3, 238)
        Me.pnlStamina.Name = "pnlStamina"
        Me.pnlStamina.Size = New System.Drawing.Size(188, 11)
        Me.pnlStamina.TabIndex = 118
        '
        'picStamina
        '
        Me.picStamina.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.picStamina.Location = New System.Drawing.Point(-1, -1)
        Me.picStamina.Name = "picStamina"
        Me.picStamina.Size = New System.Drawing.Size(188, 10)
        Me.picStamina.TabIndex = 1
        Me.picStamina.TabStop = False
        '
        'lblClass
        '
        Me.lblClass.AutoEllipsis = True
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblClass.ForeColor = System.Drawing.Color.Khaki
        Me.lblClass.Location = New System.Drawing.Point(135, 50)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(55, 12)
        Me.lblClass.TabIndex = 117
        Me.lblClass.Text = "Fighter"
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRace
        '
        Me.lblRace.AutoEllipsis = True
        Me.lblRace.BackColor = System.Drawing.Color.Transparent
        Me.lblRace.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblRace.ForeColor = System.Drawing.Color.Khaki
        Me.lblRace.Location = New System.Drawing.Point(135, 40)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(55, 12)
        Me.lblRace.TabIndex = 116
        Me.lblRace.Text = "Dwarf"
        Me.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label18
        '
        Me.label18.AutoEllipsis = True
        Me.label18.BackColor = System.Drawing.Color.Transparent
        Me.label18.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label18.Location = New System.Drawing.Point(98, 50)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(34, 12)
        Me.label18.TabIndex = 115
        Me.label18.Text = "Class"
        '
        'label16
        '
        Me.label16.AutoEllipsis = True
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label16.Location = New System.Drawing.Point(98, 40)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(33, 12)
        Me.label16.TabIndex = 114
        Me.label16.Text = "Race"
        '
        'lblInt
        '
        Me.lblInt.AutoEllipsis = True
        Me.lblInt.BackColor = System.Drawing.Color.Transparent
        Me.lblInt.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblInt.ForeColor = System.Drawing.Color.Khaki
        Me.lblInt.Location = New System.Drawing.Point(101, 121)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(70, 12)
        Me.lblInt.TabIndex = 113
        Me.lblInt.Text = "16"
        Me.lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVit
        '
        Me.lblVit.AutoEllipsis = True
        Me.lblVit.BackColor = System.Drawing.Color.Transparent
        Me.lblVit.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblVit.ForeColor = System.Drawing.Color.Khaki
        Me.lblVit.Location = New System.Drawing.Point(101, 110)
        Me.lblVit.Name = "lblVit"
        Me.lblVit.Size = New System.Drawing.Size(70, 12)
        Me.lblVit.TabIndex = 112
        Me.lblVit.Text = "16"
        Me.lblVit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEnd
        '
        Me.lblEnd.AutoEllipsis = True
        Me.lblEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblEnd.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnd.ForeColor = System.Drawing.Color.Khaki
        Me.lblEnd.Location = New System.Drawing.Point(101, 99)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(70, 12)
        Me.lblEnd.TabIndex = 111
        Me.lblEnd.Text = "16"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStr
        '
        Me.lblStr.AutoEllipsis = True
        Me.lblStr.BackColor = System.Drawing.Color.Transparent
        Me.lblStr.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblStr.ForeColor = System.Drawing.Color.Khaki
        Me.lblStr.Location = New System.Drawing.Point(101, 88)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(70, 12)
        Me.lblStr.TabIndex = 110
        Me.lblStr.Text = "16"
        Me.lblStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label8
        '
        Me.label8.AutoEllipsis = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(2, 110)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(80, 12)
        Me.label8.TabIndex = 108
        Me.label8.Text = "Vitality"
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(2, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 12)
        Me.label1.TabIndex = 106
        Me.label1.Text = "Strength"
        '
        'pnlMP
        '
        Me.pnlMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMP.Controls.Add(Me.picMP)
        Me.pnlMP.Location = New System.Drawing.Point(3, 210)
        Me.pnlMP.Name = "pnlMP"
        Me.pnlMP.Size = New System.Drawing.Size(188, 11)
        Me.pnlMP.TabIndex = 101
        '
        'picMP
        '
        Me.picMP.BackColor = System.Drawing.Color.RoyalBlue
        Me.picMP.Location = New System.Drawing.Point(-1, -1)
        Me.picMP.Name = "picMP"
        Me.picMP.Size = New System.Drawing.Size(188, 10)
        Me.picMP.TabIndex = 1
        Me.picMP.TabStop = False
        '
        'pnlHP
        '
        Me.pnlHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHP.Controls.Add(Me.picHP)
        Me.pnlHP.Location = New System.Drawing.Point(3, 182)
        Me.pnlHP.Name = "pnlHP"
        Me.pnlHP.Size = New System.Drawing.Size(188, 11)
        Me.pnlHP.TabIndex = 100
        '
        'picHP
        '
        Me.picHP.BackColor = System.Drawing.Color.Firebrick
        Me.picHP.Location = New System.Drawing.Point(-1, -1)
        Me.picHP.Name = "picHP"
        Me.picHP.Size = New System.Drawing.Size(188, 10)
        Me.picHP.TabIndex = 0
        Me.picHP.TabStop = False
        '
        'panel15
        '
        Me.panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panel15.Controls.Add(Me.lblName)
        Me.panel15.Controls.Add(Me.picPAvatar)
        Me.panel15.Location = New System.Drawing.Point(3, 3)
        Me.panel15.Name = "panel15"
        Me.panel15.Size = New System.Drawing.Size(188, 34)
        Me.panel15.TabIndex = 99
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Khaki
        Me.lblName.Location = New System.Drawing.Point(37, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 14)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Xlithan"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picPAvatar
        '
        Me.picPAvatar.Image = CType(resources.GetObject("picPAvatar.Image"), System.Drawing.Image)
        Me.picPAvatar.Location = New System.Drawing.Point(3, 3)
        Me.picPAvatar.Name = "picPAvatar"
        Me.picPAvatar.Size = New System.Drawing.Size(28, 28)
        Me.picPAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPAvatar.TabIndex = 1
        Me.picPAvatar.TabStop = False
        '
        'lblBank
        '
        Me.lblBank.AutoEllipsis = True
        Me.lblBank.BackColor = System.Drawing.Color.Transparent
        Me.lblBank.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblBank.ForeColor = System.Drawing.Color.Khaki
        Me.lblBank.Location = New System.Drawing.Point(38, 62)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(60, 12)
        Me.lblBank.TabIndex = 98
        Me.lblBank.Text = "13,220"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGold
        '
        Me.lblGold.AutoEllipsis = True
        Me.lblGold.BackColor = System.Drawing.Color.Transparent
        Me.lblGold.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblGold.ForeColor = System.Drawing.Color.Khaki
        Me.lblGold.Location = New System.Drawing.Point(38, 51)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(60, 12)
        Me.lblGold.TabIndex = 97
        Me.lblGold.Text = "6,837"
        Me.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(2, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 12)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Bank"
        '
        'Label9
        '
        Me.Label9.AutoEllipsis = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(2, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 12)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Gold"
        '
        'lblLevel
        '
        Me.lblLevel.AutoEllipsis = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblLevel.ForeColor = System.Drawing.Color.Khaki
        Me.lblLevel.Location = New System.Drawing.Point(38, 40)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(60, 12)
        Me.lblLevel.TabIndex = 93
        Me.lblLevel.Text = "16"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(2, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 12)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Level"
        '
        'lblMP
        '
        Me.lblMP.AutoEllipsis = True
        Me.lblMP.AutoSize = True
        Me.lblMP.BackColor = System.Drawing.Color.Transparent
        Me.lblMP.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMP.Location = New System.Drawing.Point(5, 197)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(56, 12)
        Me.lblMP.TabIndex = 104
        Me.lblMP.Text = "Mana: 0/0"
        '
        'lblHP
        '
        Me.lblHP.AutoEllipsis = True
        Me.lblHP.AutoSize = True
        Me.lblHP.BackColor = System.Drawing.Color.Transparent
        Me.lblHP.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblHP.Location = New System.Drawing.Point(5, 169)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(87, 12)
        Me.lblHP.TabIndex = 103
        Me.lblHP.Text = "Health: 180/180"
        '
        'lblStamina
        '
        Me.lblStamina.AutoEllipsis = True
        Me.lblStamina.AutoSize = True
        Me.lblStamina.BackColor = System.Drawing.Color.Transparent
        Me.lblStamina.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStamina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStamina.Location = New System.Drawing.Point(5, 225)
        Me.lblStamina.Name = "lblStamina"
        Me.lblStamina.Size = New System.Drawing.Size(71, 12)
        Me.lblStamina.TabIndex = 119
        Me.lblStamina.Text = "Stamina: 4/4"
        '
        'lblExp
        '
        Me.lblExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExp.AutoEllipsis = True
        Me.lblExp.AutoSize = True
        Me.lblExp.BackColor = System.Drawing.Color.Transparent
        Me.lblExp.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblExp.Location = New System.Drawing.Point(5, 253)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(62, 12)
        Me.lblExp.TabIndex = 120
        Me.lblExp.Text = "Exp: 76.6%"
        '
        'label11
        '
        Me.label11.AutoEllipsis = True
        Me.label11.BackColor = System.Drawing.Color.Transparent
        Me.label11.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(2, 121)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(80, 12)
        Me.label11.TabIndex = 109
        Me.label11.Text = "Intelligence"
        '
        'label6
        '
        Me.label6.AutoEllipsis = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(2, 99)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 12)
        Me.label6.TabIndex = 107
        Me.label6.Text = "Endurance"
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtText.ForeColor = System.Drawing.Color.White
        Me.txtText.Location = New System.Drawing.Point(204, 532)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(528, 20)
        Me.txtText.TabIndex = 109
        '
        'pnlActionBtns
        '
        Me.pnlActionBtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlActionBtns.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlActionBtns.Controls.Add(Me.BtnAction6)
        Me.pnlActionBtns.Controls.Add(Me.BtnAction5)
        Me.pnlActionBtns.Controls.Add(Me.BtnAction4)
        Me.pnlActionBtns.Controls.Add(Me.BtnAction3)
        Me.pnlActionBtns.Controls.Add(Me.BtnAction2)
        Me.pnlActionBtns.Controls.Add(Me.BtnAction1)
        Me.pnlActionBtns.Location = New System.Drawing.Point(735, 158)
        Me.pnlActionBtns.Name = "pnlActionBtns"
        Me.pnlActionBtns.Size = New System.Drawing.Size(90, 394)
        Me.pnlActionBtns.TabIndex = 111
        '
        'BtnAction6
        '
        Me.BtnAction6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction6.BorderRadius = 0
        Me.BtnAction6.BorderSize = 1
        Me.BtnAction6.FlatAppearance.BorderSize = 0
        Me.BtnAction6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction6.ForeColor = System.Drawing.Color.White
        Me.BtnAction6.Location = New System.Drawing.Point(3, 143)
        Me.BtnAction6.Name = "BtnAction6"
        Me.BtnAction6.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction6.TabIndex = 5
        Me.BtnAction6.Text = "Empty"
        Me.BtnAction6.TextColor = System.Drawing.Color.White
        Me.BtnAction6.UseVisualStyleBackColor = False
        Me.BtnAction6.Visible = False
        '
        'BtnAction5
        '
        Me.BtnAction5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction5.BorderRadius = 0
        Me.BtnAction5.BorderSize = 1
        Me.BtnAction5.FlatAppearance.BorderSize = 0
        Me.BtnAction5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction5.ForeColor = System.Drawing.Color.White
        Me.BtnAction5.Location = New System.Drawing.Point(3, 115)
        Me.BtnAction5.Name = "BtnAction5"
        Me.BtnAction5.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction5.TabIndex = 4
        Me.BtnAction5.Text = "Mock Dialog"
        Me.BtnAction5.TextColor = System.Drawing.Color.White
        Me.BtnAction5.UseVisualStyleBackColor = False
        '
        'BtnAction4
        '
        Me.BtnAction4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction4.BorderRadius = 0
        Me.BtnAction4.BorderSize = 1
        Me.BtnAction4.FlatAppearance.BorderSize = 0
        Me.BtnAction4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction4.ForeColor = System.Drawing.Color.White
        Me.BtnAction4.Location = New System.Drawing.Point(3, 87)
        Me.BtnAction4.Name = "BtnAction4"
        Me.BtnAction4.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction4.TabIndex = 3
        Me.BtnAction4.Text = "Set As Local"
        Me.BtnAction4.TextColor = System.Drawing.Color.White
        Me.BtnAction4.UseVisualStyleBackColor = False
        '
        'BtnAction3
        '
        Me.BtnAction3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction3.BorderRadius = 0
        Me.BtnAction3.BorderSize = 1
        Me.BtnAction3.FlatAppearance.BorderSize = 0
        Me.BtnAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction3.ForeColor = System.Drawing.Color.White
        Me.BtnAction3.Location = New System.Drawing.Point(3, 59)
        Me.BtnAction3.Name = "BtnAction3"
        Me.BtnAction3.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction3.TabIndex = 2
        Me.BtnAction3.Text = "Restore"
        Me.BtnAction3.TextColor = System.Drawing.Color.White
        Me.BtnAction3.UseVisualStyleBackColor = False
        '
        'BtnAction2
        '
        Me.BtnAction2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction2.BorderRadius = 0
        Me.BtnAction2.BorderSize = 1
        Me.BtnAction2.FlatAppearance.BorderSize = 0
        Me.BtnAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction2.ForeColor = System.Drawing.Color.White
        Me.BtnAction2.Location = New System.Drawing.Point(3, 31)
        Me.BtnAction2.Name = "BtnAction2"
        Me.BtnAction2.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction2.TabIndex = 1
        Me.BtnAction2.Text = "Get Drunk"
        Me.BtnAction2.TextColor = System.Drawing.Color.White
        Me.BtnAction2.UseVisualStyleBackColor = False
        '
        'BtnAction1
        '
        Me.BtnAction1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAction1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnAction1.BorderRadius = 0
        Me.BtnAction1.BorderSize = 1
        Me.BtnAction1.FlatAppearance.BorderSize = 0
        Me.BtnAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction1.ForeColor = System.Drawing.Color.White
        Me.BtnAction1.Location = New System.Drawing.Point(3, 3)
        Me.BtnAction1.Name = "BtnAction1"
        Me.BtnAction1.Size = New System.Drawing.Size(82, 22)
        Me.BtnAction1.TabIndex = 0
        Me.BtnAction1.Text = "Look Around"
        Me.BtnAction1.TextColor = System.Drawing.Color.White
        Me.BtnAction1.UseVisualStyleBackColor = False
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 561)
        Me.Controls.Add(Me.pnlDialog)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.panel20)
        Me.Controls.Add(Me.pnlChat)
        Me.Controls.Add(Me.pnlRoomDesc)
        Me.Controls.Add(Me.pnlMiniMap)
        Me.Controls.Add(Me.pnlRoomContent)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.pnlActionBtns)
        Me.Controls.Add(Me.picscreen)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1080, 600)
        Me.Name = "FrmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainGame"
        CType(Me.picscreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        Me.panel20.ResumeLayout(False)
        Me.pnlChat.ResumeLayout(False)
        Me.pnlCurrency.ResumeLayout(False)
        Me.pnlCurrency.PerformLayout()
        Me.pnlRoomDesc.ResumeLayout(False)
        Me.pnlRoomDesc.PerformLayout()
        Me.pnlMiniMap.ResumeLayout(False)
        Me.pnlMiniMap.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDialog.ResumeLayout(False)
        Me.pnlDialog.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.pnlExp.ResumeLayout(False)
        CType(Me.picExp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStamina.ResumeLayout(False)
        CType(Me.picStamina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMP.ResumeLayout(False)
        CType(Me.picMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHP.ResumeLayout(False)
        CType(Me.picHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel15.ResumeLayout(False)
        Me.panel15.PerformLayout()
        CType(Me.picPAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActionBtns.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picscreen As System.Windows.Forms.PictureBox
    Public WithEvents pnlInventory As Panel
    Public WithEvents lstInv As ListBox
    Public WithEvents lstSkills As ListBox
    Private WithEvents panel20 As Panel
    Public WithEvents lblRoomName As Label
    Private WithEvents pnlChat As Panel
    Friend WithEvents pnlCurrency As Panel
    Friend WithEvents lblCurrencyCancel As Label
    Friend WithEvents lblCurrencyOk As Label
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents lblCurrency As Label
    Public WithEvents rtbChat As RichTextBox
    Private WithEvents pnlRoomDesc As Panel
    Friend WithEvents label30 As Label
    Friend WithEvents label29 As Label
    Private WithEvents label28 As Label
    Private WithEvents pnlMiniMap As Panel
    Private WithEvents pictureBox4 As PictureBox
    Public WithEvents picMap As PictureBox
    Private WithEvents pnlDialog As Panel
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Public WithEvents pnlRoomContent As FlowLayoutPanel
    Private WithEvents pnlStats As Panel
    Friend WithEvents lblSpirit As Label
    Friend WithEvents lblLuck As Label
    Friend WithEvents label13 As Label
    Friend WithEvents label12 As Label
    Private WithEvents pnlExp As Panel
    Public WithEvents picExp As PictureBox
    Private WithEvents pnlStamina As Panel
    Public WithEvents picStamina As PictureBox
    Friend WithEvents lblClass As Label
    Friend WithEvents lblRace As Label
    Friend WithEvents label18 As Label
    Friend WithEvents label16 As Label
    Friend WithEvents lblInt As Label
    Friend WithEvents lblVit As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblStr As Label
    Friend WithEvents label8 As Label
    Friend WithEvents label1 As Label
    Private WithEvents pnlMP As Panel
    Public WithEvents picMP As PictureBox
    Private WithEvents pnlHP As Panel
    Public WithEvents picHP As PictureBox
    Private WithEvents panel15 As Panel
    Public WithEvents lblName As Label
    Public WithEvents picPAvatar As PictureBox
    Friend WithEvents lblBank As Label
    Friend WithEvents lblGold As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMP As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblStamina As Label
    Friend WithEvents lblExp As Label
    Friend WithEvents label11 As Label
    Friend WithEvents label6 As Label
    Public WithEvents txtText As TextBox
    Private WithEvents pnlActionBtns As Panel
    Friend WithEvents BtnSkills As CustomButton
    Friend WithEvents BtnInventory As CustomButton
    Friend WithEvents BtnAction6 As CustomButton
    Friend WithEvents BtnAction5 As CustomButton
    Friend WithEvents BtnAction4 As CustomButton
    Friend WithEvents BtnAction3 As CustomButton
    Friend WithEvents BtnAction2 As CustomButton
    Friend WithEvents BtnAction1 As CustomButton
    Friend WithEvents BtnDialogClose As CustomButton
End Class
