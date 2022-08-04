<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_AutoMapper
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlResources = New System.Windows.Forms.Panel()
        Me.btnAddResource = New DarkUI.Controls.DarkButton()
        Me.btnRemoveResource = New DarkUI.Controls.DarkButton()
        Me.btnUpdateResource = New DarkUI.Controls.DarkButton()
        Me.btnSaveResource = New DarkUI.Controls.DarkButton()
        Me.btnCloseResource = New DarkUI.Controls.DarkButton()
        Me.txtResource = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel8 = New DarkUI.Controls.DarkLabel()
        Me.lstResources = New System.Windows.Forms.ListBox()
        Me.pnlTileConfig = New System.Windows.Forms.Panel()
        Me.btnTileSetSave = New DarkUI.Controls.DarkButton()
        Me.btnTileSetClose = New DarkUI.Controls.DarkButton()
        Me.DarkLabel10 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel9 = New DarkUI.Controls.DarkLabel()
        Me.cmbLayer = New DarkUI.Controls.DarkComboBox()
        Me.cmbPrefab = New DarkUI.Controls.DarkComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAutotile = New DarkUI.Controls.DarkTextBox()
        Me.txtTileY = New DarkUI.Controls.DarkTextBox()
        Me.txtTileX = New DarkUI.Controls.DarkTextBox()
        Me.txtTileset = New DarkUI.Controls.DarkTextBox()
        Me.chkBlocked = New DarkUI.Controls.DarkCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DarkMenu = New DarkUI.Controls.DarkMenuStrip()
        Me.ConfigurationsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiversToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MountainsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverGrassToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.txtMapStart = New DarkUI.Controls.DarkTextBox()
        Me.txtMapSize = New DarkUI.Controls.DarkTextBox()
        Me.txtMapX = New DarkUI.Controls.DarkTextBox()
        Me.txtMapY = New DarkUI.Controls.DarkTextBox()
        Me.txtSandBorder = New DarkUI.Controls.DarkTextBox()
        Me.txtDetail = New DarkUI.Controls.DarkTextBox()
        Me.txtResourceFreq = New DarkUI.Controls.DarkTextBox()
        Me.btnStart = New DarkUI.Controls.DarkButton()
        Me.pnlResources.SuspendLayout
        Me.pnlTileConfig.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.DarkMenu.SuspendLayout
        Me.SuspendLayout
        '
        'pnlResources
        '
        Me.pnlResources.Controls.Add(Me.btnAddResource)
        Me.pnlResources.Controls.Add(Me.btnRemoveResource)
        Me.pnlResources.Controls.Add(Me.btnUpdateResource)
        Me.pnlResources.Controls.Add(Me.btnSaveResource)
        Me.pnlResources.Controls.Add(Me.btnCloseResource)
        Me.pnlResources.Controls.Add(Me.txtResource)
        Me.pnlResources.Controls.Add(Me.DarkLabel8)
        Me.pnlResources.Controls.Add(Me.lstResources)
        Me.pnlResources.Location = New System.Drawing.Point(439, 27)
        Me.pnlResources.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlResources.Name = "pnlResources"
        Me.pnlResources.Size = New System.Drawing.Size(449, 308)
        Me.pnlResources.TabIndex = 24
        Me.pnlResources.Visible = false
        '
        'btnAddResource
        '
        Me.btnAddResource.Location = New System.Drawing.Point(296, 173)
        Me.btnAddResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Padding = New System.Windows.Forms.Padding(6)
        Me.btnAddResource.Size = New System.Drawing.Size(142, 27)
        Me.btnAddResource.TabIndex = 14
        Me.btnAddResource.Text = "Add Resources"
        '
        'btnRemoveResource
        '
        Me.btnRemoveResource.Location = New System.Drawing.Point(296, 206)
        Me.btnRemoveResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveResource.Name = "btnRemoveResource"
        Me.btnRemoveResource.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRemoveResource.Size = New System.Drawing.Size(142, 27)
        Me.btnRemoveResource.TabIndex = 13
        Me.btnRemoveResource.Text = "Remove Resources"
        '
        'btnUpdateResource
        '
        Me.btnUpdateResource.Location = New System.Drawing.Point(296, 239)
        Me.btnUpdateResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUpdateResource.Name = "btnUpdateResource"
        Me.btnUpdateResource.Padding = New System.Windows.Forms.Padding(6)
        Me.btnUpdateResource.Size = New System.Drawing.Size(142, 27)
        Me.btnUpdateResource.TabIndex = 12
        Me.btnUpdateResource.Text = "Update Resources"
        '
        'btnSaveResource
        '
        Me.btnSaveResource.Location = New System.Drawing.Point(296, 272)
        Me.btnSaveResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSaveResource.Name = "btnSaveResource"
        Me.btnSaveResource.Padding = New System.Windows.Forms.Padding(6)
        Me.btnSaveResource.Size = New System.Drawing.Size(142, 27)
        Me.btnSaveResource.TabIndex = 11
        Me.btnSaveResource.Text = "Save"
        '
        'btnCloseResource
        '
        Me.btnCloseResource.Location = New System.Drawing.Point(8, 272)
        Me.btnCloseResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCloseResource.Name = "btnCloseResource"
        Me.btnCloseResource.Padding = New System.Windows.Forms.Padding(6)
        Me.btnCloseResource.Size = New System.Drawing.Size(142, 27)
        Me.btnCloseResource.TabIndex = 10
        Me.btnCloseResource.Text = "Close"
        '
        'txtResource
        '
        Me.txtResource.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtResource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtResource.Location = New System.Drawing.Point(121, 177)
        Me.txtResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtResource.Name = "txtResource"
        Me.txtResource.Size = New System.Drawing.Size(167, 23)
        Me.txtResource.TabIndex = 9
        '
        'DarkLabel8
        '
        Me.DarkLabel8.AutoSize = true
        Me.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel8.Location = New System.Drawing.Point(8, 180)
        Me.DarkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel8.Name = "DarkLabel8"
        Me.DarkLabel8.Size = New System.Drawing.Size(105, 15)
        Me.DarkLabel8.TabIndex = 8
        Me.DarkLabel8.Text = "Resource Number:"
        '
        'lstResources
        '
        Me.lstResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.lstResources.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstResources.FormattingEnabled = true
        Me.lstResources.ItemHeight = 15
        Me.lstResources.Location = New System.Drawing.Point(4, 3)
        Me.lstResources.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstResources.Name = "lstResources"
        Me.lstResources.Size = New System.Drawing.Size(434, 154)
        Me.lstResources.TabIndex = 0
        '
        'pnlTileConfig
        '
        Me.pnlTileConfig.Controls.Add(Me.btnTileSetSave)
        Me.pnlTileConfig.Controls.Add(Me.btnTileSetClose)
        Me.pnlTileConfig.Controls.Add(Me.DarkLabel10)
        Me.pnlTileConfig.Controls.Add(Me.DarkLabel9)
        Me.pnlTileConfig.Controls.Add(Me.cmbLayer)
        Me.pnlTileConfig.Controls.Add(Me.cmbPrefab)
        Me.pnlTileConfig.Controls.Add(Me.GroupBox1)
        Me.pnlTileConfig.Location = New System.Drawing.Point(896, 27)
        Me.pnlTileConfig.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTileConfig.Name = "pnlTileConfig"
        Me.pnlTileConfig.Size = New System.Drawing.Size(444, 312)
        Me.pnlTileConfig.TabIndex = 25
        Me.pnlTileConfig.Visible = false
        '
        'btnTileSetSave
        '
        Me.btnTileSetSave.Location = New System.Drawing.Point(347, 274)
        Me.btnTileSetSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTileSetSave.Name = "btnTileSetSave"
        Me.btnTileSetSave.Padding = New System.Windows.Forms.Padding(6)
        Me.btnTileSetSave.Size = New System.Drawing.Size(88, 27)
        Me.btnTileSetSave.TabIndex = 45
        Me.btnTileSetSave.Text = "Save"
        '
        'btnTileSetClose
        '
        Me.btnTileSetClose.Location = New System.Drawing.Point(8, 274)
        Me.btnTileSetClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTileSetClose.Name = "btnTileSetClose"
        Me.btnTileSetClose.Padding = New System.Windows.Forms.Padding(6)
        Me.btnTileSetClose.Size = New System.Drawing.Size(88, 27)
        Me.btnTileSetClose.TabIndex = 44
        Me.btnTileSetClose.Text = "Close"
        '
        'DarkLabel10
        '
        Me.DarkLabel10.AutoSize = true
        Me.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel10.Location = New System.Drawing.Point(8, 43)
        Me.DarkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel10.Name = "DarkLabel10"
        Me.DarkLabel10.Size = New System.Drawing.Size(103, 15)
        Me.DarkLabel10.TabIndex = 43
        Me.DarkLabel10.Text = "Choose The Layer:"
        '
        'DarkLabel9
        '
        Me.DarkLabel9.AutoSize = true
        Me.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel9.Location = New System.Drawing.Point(8, 12)
        Me.DarkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel9.Name = "DarkLabel9"
        Me.DarkLabel9.Size = New System.Drawing.Size(109, 15)
        Me.DarkLabel9.TabIndex = 43
        Me.DarkLabel9.Text = "Choose The Prefab:"
        '
        'cmbLayer
        '
        Me.cmbLayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLayer.FormattingEnabled = true
        Me.cmbLayer.Items.AddRange(New Object() {"Ground", "Mask", "Mask 2", "Fringe", "Fringe 2"})
        Me.cmbLayer.Location = New System.Drawing.Point(134, 39)
        Me.cmbLayer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbLayer.Name = "cmbLayer"
        Me.cmbLayer.Size = New System.Drawing.Size(293, 24)
        Me.cmbLayer.TabIndex = 43
        '
        'cmbPrefab
        '
        Me.cmbPrefab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPrefab.FormattingEnabled = true
        Me.cmbPrefab.Items.AddRange(New Object() {"Water", "Sand", "Grass", "Passing", "Overgrass", "River", "Mountain"})
        Me.cmbPrefab.Location = New System.Drawing.Point(134, 8)
        Me.cmbPrefab.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbPrefab.Name = "cmbPrefab"
        Me.cmbPrefab.Size = New System.Drawing.Size(293, 24)
        Me.cmbPrefab.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAutotile)
        Me.GroupBox1.Controls.Add(Me.txtTileY)
        Me.GroupBox1.Controls.Add(Me.txtTileX)
        Me.GroupBox1.Controls.Add(Me.txtTileset)
        Me.GroupBox1.Controls.Add(Me.chkBlocked)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(427, 195)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Tile Settings"
        '
        'txtAutotile
        '
        Me.txtAutotile.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtAutotile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutotile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtAutotile.Location = New System.Drawing.Point(126, 113)
        Me.txtAutotile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAutotile.Name = "txtAutotile"
        Me.txtAutotile.Size = New System.Drawing.Size(294, 23)
        Me.txtAutotile.TabIndex = 47
        '
        'txtTileY
        '
        Me.txtTileY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtTileY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtTileY.Location = New System.Drawing.Point(126, 83)
        Me.txtTileY.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTileY.Name = "txtTileY"
        Me.txtTileY.Size = New System.Drawing.Size(294, 23)
        Me.txtTileY.TabIndex = 46
        '
        'txtTileX
        '
        Me.txtTileX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtTileX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtTileX.Location = New System.Drawing.Point(126, 53)
        Me.txtTileX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTileX.Name = "txtTileX"
        Me.txtTileX.Size = New System.Drawing.Size(294, 23)
        Me.txtTileX.TabIndex = 45
        '
        'txtTileset
        '
        Me.txtTileset.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtTileset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtTileset.Location = New System.Drawing.Point(126, 23)
        Me.txtTileset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTileset.Name = "txtTileset"
        Me.txtTileset.Size = New System.Drawing.Size(294, 23)
        Me.txtTileset.TabIndex = 44
        '
        'chkBlocked
        '
        Me.chkBlocked.AutoSize = true
        Me.chkBlocked.Location = New System.Drawing.Point(8, 170)
        Me.chkBlocked.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkBlocked.Name = "chkBlocked"
        Me.chkBlocked.Size = New System.Drawing.Size(94, 19)
        Me.chkBlocked.TabIndex = 43
        Me.chkBlocked.Text = "Is It Blocked?"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(13, 115)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 15)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "AutoTile:"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(13, 85)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "TileSet Y:"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(13, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "TileSet X:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(13, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "TileSet Number:"
        '
        'DarkMenu
        '
        Me.DarkMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationsToolStripMenuItem2, Me.GenerateToolStripMenuItem1})
        Me.DarkMenu.Location = New System.Drawing.Point(0, 0)
        Me.DarkMenu.Name = "DarkMenu"
        Me.DarkMenu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.DarkMenu.Size = New System.Drawing.Size(440, 24)
        Me.DarkMenu.TabIndex = 27
        '
        'ConfigurationsToolStripMenuItem2
        '
        Me.ConfigurationsToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.ConfigurationsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TilesetsToolStripMenuItem, Me.ResourcesToolStripMenuItem})
        Me.ConfigurationsToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.ConfigurationsToolStripMenuItem2.Name = "ConfigurationsToolStripMenuItem2"
        Me.ConfigurationsToolStripMenuItem2.Size = New System.Drawing.Size(93, 20)
        Me.ConfigurationsToolStripMenuItem2.Text = "Configuration"
        '
        'TilesetsToolStripMenuItem
        '
        Me.TilesetsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.TilesetsToolStripMenuItem.Name = "TilesetsToolStripMenuItem"
        Me.TilesetsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TilesetsToolStripMenuItem.Text = "Tilesets"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ResourcesToolStripMenuItem.Text = "Resources"
        '
        'GenerateToolStripMenuItem1
        '
        Me.GenerateToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.GenerateToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathsToolStripMenuItem1, Me.RiversToolStripMenuItem1, Me.MountainsToolStripMenuItem1, Me.OverGrassToolStripMenuItem1, Me.ResourcesToolStripMenuItem3, Me.DetailsToolStripMenuItem1})
        Me.GenerateToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.GenerateToolStripMenuItem1.Name = "GenerateToolStripMenuItem1"
        Me.GenerateToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.GenerateToolStripMenuItem1.Text = "Generate"
        '
        'PathsToolStripMenuItem1
        '
        Me.PathsToolStripMenuItem1.Checked = true
        Me.PathsToolStripMenuItem1.CheckOnClick = true
        Me.PathsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PathsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.PathsToolStripMenuItem1.Name = "PathsToolStripMenuItem1"
        Me.PathsToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.PathsToolStripMenuItem1.Text = "Paths"
        '
        'RiversToolStripMenuItem1
        '
        Me.RiversToolStripMenuItem1.Checked = true
        Me.RiversToolStripMenuItem1.CheckOnClick = true
        Me.RiversToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RiversToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RiversToolStripMenuItem1.Name = "RiversToolStripMenuItem1"
        Me.RiversToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.RiversToolStripMenuItem1.Text = "Rivers"
        '
        'MountainsToolStripMenuItem1
        '
        Me.MountainsToolStripMenuItem1.Checked = true
        Me.MountainsToolStripMenuItem1.CheckOnClick = true
        Me.MountainsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MountainsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.MountainsToolStripMenuItem1.Name = "MountainsToolStripMenuItem1"
        Me.MountainsToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.MountainsToolStripMenuItem1.Text = "Mountains"
        '
        'OverGrassToolStripMenuItem1
        '
        Me.OverGrassToolStripMenuItem1.Checked = true
        Me.OverGrassToolStripMenuItem1.CheckOnClick = true
        Me.OverGrassToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OverGrassToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.OverGrassToolStripMenuItem1.Name = "OverGrassToolStripMenuItem1"
        Me.OverGrassToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.OverGrassToolStripMenuItem1.Text = "OverGrass"
        '
        'ResourcesToolStripMenuItem3
        '
        Me.ResourcesToolStripMenuItem3.Checked = true
        Me.ResourcesToolStripMenuItem3.CheckOnClick = true
        Me.ResourcesToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ResourcesToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.ResourcesToolStripMenuItem3.Name = "ResourcesToolStripMenuItem3"
        Me.ResourcesToolStripMenuItem3.Size = New System.Drawing.Size(131, 22)
        Me.ResourcesToolStripMenuItem3.Text = "Resources"
        '
        'DetailsToolStripMenuItem1
        '
        Me.DetailsToolStripMenuItem1.Checked = true
        Me.DetailsToolStripMenuItem1.CheckOnClick = true
        Me.DetailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DetailsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DetailsToolStripMenuItem1.Name = "DetailsToolStripMenuItem1"
        Me.DetailsToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.DetailsToolStripMenuItem1.Text = "Details"
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = true
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(14, 36)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(61, 15)
        Me.DarkLabel1.TabIndex = 28
        Me.DarkLabel1.Text = "Start Map:"
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = true
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(14, 66)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(68, 15)
        Me.DarkLabel2.TabIndex = 29
        Me.DarkLabel2.Text = "Island Area:"
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = true
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(15, 96)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(66, 15)
        Me.DarkLabel3.TabIndex = 30
        Me.DarkLabel3.Text = "Max Size X:"
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = true
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(14, 126)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(67, 15)
        Me.DarkLabel4.TabIndex = 31
        Me.DarkLabel4.Text = "Map Size Y:"
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = true
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(15, 156)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(74, 15)
        Me.DarkLabel5.TabIndex = 32
        Me.DarkLabel5.Text = "Sand Border:"
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = true
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(15, 186)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(121, 15)
        Me.DarkLabel6.TabIndex = 33
        Me.DarkLabel6.Text = "Detail Frequency 1 of "
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = true
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(14, 216)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(136, 15)
        Me.DarkLabel7.TabIndex = 34
        Me.DarkLabel7.Text = "Resource Frequency 1 of"
        '
        'txtMapStart
        '
        Me.txtMapStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtMapStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtMapStart.Location = New System.Drawing.Point(169, 32)
        Me.txtMapStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMapStart.Name = "txtMapStart"
        Me.txtMapStart.Size = New System.Drawing.Size(258, 23)
        Me.txtMapStart.TabIndex = 35
        Me.txtMapStart.Text = "1"
        '
        'txtMapSize
        '
        Me.txtMapSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtMapSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtMapSize.Location = New System.Drawing.Point(169, 62)
        Me.txtMapSize.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMapSize.Name = "txtMapSize"
        Me.txtMapSize.Size = New System.Drawing.Size(258, 23)
        Me.txtMapSize.TabIndex = 36
        Me.txtMapSize.Text = "4"
        '
        'txtMapX
        '
        Me.txtMapX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtMapX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtMapX.Location = New System.Drawing.Point(169, 92)
        Me.txtMapX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMapX.Name = "txtMapX"
        Me.txtMapX.Size = New System.Drawing.Size(258, 23)
        Me.txtMapX.TabIndex = 37
        Me.txtMapX.Text = "50"
        '
        'txtMapY
        '
        Me.txtMapY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtMapY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtMapY.Location = New System.Drawing.Point(169, 122)
        Me.txtMapY.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMapY.Name = "txtMapY"
        Me.txtMapY.Size = New System.Drawing.Size(258, 23)
        Me.txtMapY.TabIndex = 38
        Me.txtMapY.Text = "50"
        '
        'txtSandBorder
        '
        Me.txtSandBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtSandBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSandBorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtSandBorder.Location = New System.Drawing.Point(169, 152)
        Me.txtSandBorder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSandBorder.Name = "txtSandBorder"
        Me.txtSandBorder.Size = New System.Drawing.Size(258, 23)
        Me.txtSandBorder.TabIndex = 39
        Me.txtSandBorder.Text = "4"
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtDetail.Location = New System.Drawing.Point(169, 182)
        Me.txtDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(258, 23)
        Me.txtDetail.TabIndex = 40
        Me.txtDetail.Text = "10"
        '
        'txtResourceFreq
        '
        Me.txtResourceFreq.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtResourceFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResourceFreq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtResourceFreq.Location = New System.Drawing.Point(169, 212)
        Me.txtResourceFreq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtResourceFreq.Name = "txtResourceFreq"
        Me.txtResourceFreq.Size = New System.Drawing.Size(258, 23)
        Me.txtResourceFreq.TabIndex = 41
        Me.txtResourceFreq.Text = "20"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(15, 290)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Padding = New System.Windows.Forms.Padding(6)
        Me.btnStart.Size = New System.Drawing.Size(412, 38)
        Me.btnStart.TabIndex = 42
        Me.btnStart.Text = "Create The World"
        '
        'frmEditor_AutoMapper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(440, 334)
        Me.Controls.Add(Me.pnlResources)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtResourceFreq)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.txtSandBorder)
        Me.Controls.Add(Me.txtMapY)
        Me.Controls.Add(Me.txtMapX)
        Me.Controls.Add(Me.txtMapSize)
        Me.Controls.Add(Me.txtMapStart)
        Me.Controls.Add(Me.DarkLabel7)
        Me.Controls.Add(Me.DarkLabel6)
        Me.Controls.Add(Me.DarkLabel5)
        Me.Controls.Add(Me.DarkLabel4)
        Me.Controls.Add(Me.DarkLabel3)
        Me.Controls.Add(Me.DarkLabel2)
        Me.Controls.Add(Me.DarkLabel1)
        Me.Controls.Add(Me.pnlTileConfig)
        Me.Controls.Add(Me.DarkMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmEditor_AutoMapper"
        Me.Text = "Auto Mapper"
        Me.pnlResources.ResumeLayout(false)
        Me.pnlResources.PerformLayout
        Me.pnlTileConfig.ResumeLayout(false)
        Me.pnlTileConfig.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.DarkMenu.ResumeLayout(false)
        Me.DarkMenu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pnlResources As Windows.Forms.Panel
    Friend WithEvents lstResources As Windows.Forms.ListBox
    Friend WithEvents pnlTileConfig As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents DarkMenu As DarkUI.Controls.DarkMenuStrip
    Friend WithEvents ConfigurationsToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TilesetsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiversToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MountainsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverGrassToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtMapStart As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapSize As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapX As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapY As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtSandBorder As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtDetail As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtResourceFreq As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnStart As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel8 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCloseResource As DarkUI.Controls.DarkButton
    Friend WithEvents txtResource As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnSaveResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnUpdateResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnRemoveResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnAddResource As DarkUI.Controls.DarkButton
    Friend WithEvents cmbPrefab As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbLayer As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel10 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel9 As DarkUI.Controls.DarkLabel
    Friend WithEvents chkBlocked As DarkUI.Controls.DarkCheckBox
    Friend WithEvents txtTileset As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtAutotile As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtTileY As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtTileX As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnTileSetClose As DarkUI.Controls.DarkButton
    Friend WithEvents btnTileSetSave As DarkUI.Controls.DarkButton
End Class
