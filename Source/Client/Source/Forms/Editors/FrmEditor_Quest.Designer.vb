<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_Quest
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
        Me.fraQuestList = New DarkUI.Controls.DarkGroupBox()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        Me.DarkGroupBox5 = New DarkUI.Controls.DarkGroupBox()
        Me.btnRemoveTask = New DarkUI.Controls.DarkButton()
        Me.btnAddTask = New DarkUI.Controls.DarkButton()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox4 = New DarkUI.Controls.DarkGroupBox()
        Me.lstRequirements = New System.Windows.Forms.ListBox()
        Me.btnRemoveRequirement = New DarkUI.Controls.DarkButton()
        Me.btnAddRequirement = New DarkUI.Controls.DarkButton()
        Me.DarkGroupBox3 = New DarkUI.Controls.DarkGroupBox()
        Me.nudItemRewValue = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.cmbItemReward = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.nudExpReward = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.btnRemoveReward = New DarkUI.Controls.DarkButton()
        Me.btnAddReward = New DarkUI.Controls.DarkButton()
        Me.lstRewards = New System.Windows.Forms.ListBox()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.txtEndText = New DarkUI.Controls.DarkTextBox()
        Me.txtProgressText = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.txtStartText = New DarkUI.Controls.DarkTextBox()
        Me.chkQuestCancel = New DarkUI.Controls.DarkCheckBox()
        Me.chkRepeat = New DarkUI.Controls.DarkCheckBox()
        Me.txtName = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel8 = New DarkUI.Controls.DarkLabel()
        Me.btnSave = New DarkUI.Controls.DarkButton()
        Me.btnCancel = New DarkUI.Controls.DarkButton()
        Me.fraTasks = New DarkUI.Controls.DarkGroupBox()
        Me.btnCancelTask = New DarkUI.Controls.DarkButton()
        Me.btnSaveTask = New DarkUI.Controls.DarkButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.optTask7 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask6 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask5 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask4 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask3 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask2 = New DarkUI.Controls.DarkRadioButton()
        Me.DarkLabel16 = New DarkUI.Controls.DarkLabel()
        Me.optTask1 = New DarkUI.Controls.DarkRadioButton()
        Me.optTask0 = New DarkUI.Controls.DarkRadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbResource = New DarkUI.Controls.DarkComboBox()
        Me.cmbMap = New DarkUI.Controls.DarkComboBox()
        Me.cmbItem = New DarkUI.Controls.DarkComboBox()
        Me.cmbNpc = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel17 = New DarkUI.Controls.DarkLabel()
        Me.lblTaskNum = New DarkUI.Controls.DarkLabel()
        Me.nudAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel15 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel14 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel13 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel12 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel11 = New DarkUI.Controls.DarkLabel()
        Me.chkEnd = New DarkUI.Controls.DarkCheckBox()
        Me.txtTaskSpeech = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel10 = New DarkUI.Controls.DarkLabel()
        Me.txtTaskLog = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel9 = New DarkUI.Controls.DarkLabel()
        Me.fraRequirements = New DarkUI.Controls.DarkGroupBox()
        Me.DarkGroupBox6 = New DarkUI.Controls.DarkGroupBox()
        Me.btnRequirementCancel = New DarkUI.Controls.DarkButton()
        Me.btnRequirementSave = New DarkUI.Controls.DarkButton()
        Me.nudTakeAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel23 = New DarkUI.Controls.DarkLabel()
        Me.cmbEndItem = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel24 = New DarkUI.Controls.DarkLabel()
        Me.nudGiveAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel22 = New DarkUI.Controls.DarkLabel()
        Me.cmbStartItem = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel21 = New DarkUI.Controls.DarkLabel()
        Me.cmbClassReq = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel20 = New DarkUI.Controls.DarkLabel()
        Me.rdbClassReq = New DarkUI.Controls.DarkRadioButton()
        Me.cmbQuestReq = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel19 = New DarkUI.Controls.DarkLabel()
        Me.rdbQuestReq = New DarkUI.Controls.DarkRadioButton()
        Me.cmbItemReq = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel18 = New DarkUI.Controls.DarkLabel()
        Me.rdbItemReq = New DarkUI.Controls.DarkRadioButton()
        Me.rdbNoneReq = New DarkUI.Controls.DarkRadioButton()
        Me.fraQuestList.SuspendLayout
        Me.DarkGroupBox2.SuspendLayout
        Me.DarkGroupBox5.SuspendLayout
        Me.DarkGroupBox4.SuspendLayout
        Me.DarkGroupBox3.SuspendLayout
        CType(Me.nudItemRewValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudExpReward,System.ComponentModel.ISupportInitialize).BeginInit
        Me.fraTasks.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.fraRequirements.SuspendLayout
        Me.DarkGroupBox6.SuspendLayout
        CType(Me.nudTakeAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudGiveAmount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'fraQuestList
        '
        Me.fraQuestList.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.fraQuestList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.fraQuestList.Controls.Add(Me.lstIndex)
        Me.fraQuestList.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraQuestList.Location = New System.Drawing.Point(4, 3)
        Me.fraQuestList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraQuestList.Name = "fraQuestList"
        Me.fraQuestList.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraQuestList.Size = New System.Drawing.Size(247, 561)
        Me.fraQuestList.TabIndex = 0
        Me.fraQuestList.TabStop = false
        Me.fraQuestList.Text = "Quest List"
        '
        'lstIndex
        '
        Me.lstIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIndex.FormattingEnabled = true
        Me.lstIndex.ItemHeight = 15
        Me.lstIndex.Location = New System.Drawing.Point(10, 22)
        Me.lstIndex.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(226, 527)
        Me.lstIndex.TabIndex = 1
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox5)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox4)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox3)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox2.Controls.Add(Me.txtEndText)
        Me.DarkGroupBox2.Controls.Add(Me.txtProgressText)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox2.Controls.Add(Me.txtStartText)
        Me.DarkGroupBox2.Controls.Add(Me.chkQuestCancel)
        Me.DarkGroupBox2.Controls.Add(Me.chkRepeat)
        Me.DarkGroupBox2.Controls.Add(Me.txtName)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel1)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(258, 3)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(580, 528)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = false
        Me.DarkGroupBox2.Text = "General Settings"
        '
        'DarkGroupBox5
        '
        Me.DarkGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox5.Controls.Add(Me.btnRemoveTask)
        Me.DarkGroupBox5.Controls.Add(Me.btnAddTask)
        Me.DarkGroupBox5.Controls.Add(Me.lstTasks)
        Me.DarkGroupBox5.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox5.Location = New System.Drawing.Point(290, 293)
        Me.DarkGroupBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox5.Name = "DarkGroupBox5"
        Me.DarkGroupBox5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox5.Size = New System.Drawing.Size(284, 230)
        Me.DarkGroupBox5.TabIndex = 12
        Me.DarkGroupBox5.TabStop = false
        Me.DarkGroupBox5.Text = "Quest Tasks"
        '
        'btnRemoveTask
        '
        Me.btnRemoveTask.Location = New System.Drawing.Point(141, 196)
        Me.btnRemoveTask.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveTask.Name = "btnRemoveTask"
        Me.btnRemoveTask.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRemoveTask.Size = New System.Drawing.Size(138, 27)
        Me.btnRemoveTask.TabIndex = 5
        Me.btnRemoveTask.Text = "Remove Task"
        '
        'btnAddTask
        '
        Me.btnAddTask.Location = New System.Drawing.Point(5, 196)
        Me.btnAddTask.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Padding = New System.Windows.Forms.Padding(6)
        Me.btnAddTask.Size = New System.Drawing.Size(130, 27)
        Me.btnAddTask.TabIndex = 4
        Me.btnAddTask.Text = "Add Task"
        '
        'lstTasks
        '
        Me.lstTasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTasks.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstTasks.FormattingEnabled = true
        Me.lstTasks.ItemHeight = 15
        Me.lstTasks.Location = New System.Drawing.Point(7, 22)
        Me.lstTasks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(269, 167)
        Me.lstTasks.TabIndex = 3
        '
        'DarkGroupBox4
        '
        Me.DarkGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox4.Controls.Add(Me.lstRequirements)
        Me.DarkGroupBox4.Controls.Add(Me.btnRemoveRequirement)
        Me.DarkGroupBox4.Controls.Add(Me.btnAddRequirement)
        Me.DarkGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DarkGroupBox4.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox4.Location = New System.Drawing.Point(0, 293)
        Me.DarkGroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox4.Name = "DarkGroupBox4"
        Me.DarkGroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox4.Size = New System.Drawing.Size(284, 230)
        Me.DarkGroupBox4.TabIndex = 11
        Me.DarkGroupBox4.TabStop = false
        Me.DarkGroupBox4.Text = "Quest Requirements"
        '
        'lstRequirements
        '
        Me.lstRequirements.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRequirements.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstRequirements.FormattingEnabled = true
        Me.lstRequirements.Location = New System.Drawing.Point(7, 22)
        Me.lstRequirements.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRequirements.Name = "lstRequirements"
        Me.lstRequirements.Size = New System.Drawing.Size(269, 158)
        Me.lstRequirements.TabIndex = 2
        '
        'btnRemoveRequirement
        '
        Me.btnRemoveRequirement.Location = New System.Drawing.Point(128, 196)
        Me.btnRemoveRequirement.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveRequirement.Name = "btnRemoveRequirement"
        Me.btnRemoveRequirement.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRemoveRequirement.Size = New System.Drawing.Size(150, 27)
        Me.btnRemoveRequirement.TabIndex = 1
        Me.btnRemoveRequirement.Text = "Remove Requirement"
        '
        'btnAddRequirement
        '
        Me.btnAddRequirement.Location = New System.Drawing.Point(5, 196)
        Me.btnAddRequirement.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddRequirement.Name = "btnAddRequirement"
        Me.btnAddRequirement.Padding = New System.Windows.Forms.Padding(6)
        Me.btnAddRequirement.Size = New System.Drawing.Size(119, 27)
        Me.btnAddRequirement.TabIndex = 0
        Me.btnAddRequirement.Text = "Add Requirement"
        '
        'DarkGroupBox3
        '
        Me.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox3.Controls.Add(Me.nudItemRewValue)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel7)
        Me.DarkGroupBox3.Controls.Add(Me.cmbItemReward)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox3.Controls.Add(Me.nudExpReward)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox3.Controls.Add(Me.btnRemoveReward)
        Me.DarkGroupBox3.Controls.Add(Me.btnAddReward)
        Me.DarkGroupBox3.Controls.Add(Me.lstRewards)
        Me.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox3.Location = New System.Drawing.Point(7, 165)
        Me.DarkGroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox3.Name = "DarkGroupBox3"
        Me.DarkGroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox3.Size = New System.Drawing.Size(566, 121)
        Me.DarkGroupBox3.TabIndex = 10
        Me.DarkGroupBox3.TabStop = false
        Me.DarkGroupBox3.Text = "Rewards"
        '
        'nudItemRewValue
        '
        Me.nudItemRewValue.Location = New System.Drawing.Point(443, 91)
        Me.nudItemRewValue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudItemRewValue.Name = "nudItemRewValue"
        Me.nudItemRewValue.Size = New System.Drawing.Size(115, 23)
        Me.nudItemRewValue.TabIndex = 8
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = true
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(383, 93)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(54, 15)
        Me.DarkLabel7.TabIndex = 7
        Me.DarkLabel7.Text = "Amount:"
        '
        'cmbItemReward
        '
        Me.cmbItemReward.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemReward.FormattingEnabled = true
        Me.cmbItemReward.Location = New System.Drawing.Point(425, 60)
        Me.cmbItemReward.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbItemReward.Name = "cmbItemReward"
        Me.cmbItemReward.Size = New System.Drawing.Size(134, 24)
        Me.cmbItemReward.TabIndex = 6
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = true
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(383, 63)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(34, 15)
        Me.DarkLabel6.TabIndex = 5
        Me.DarkLabel6.Text = "Item:"
        '
        'nudExpReward
        '
        Me.nudExpReward.Location = New System.Drawing.Point(465, 25)
        Me.nudExpReward.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudExpReward.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudExpReward.Name = "nudExpReward"
        Me.nudExpReward.Size = New System.Drawing.Size(93, 23)
        Me.nudExpReward.TabIndex = 4
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = true
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(383, 28)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(69, 15)
        Me.DarkLabel5.TabIndex = 3
        Me.DarkLabel5.Text = "Exp Gained:"
        '
        'btnRemoveReward
        '
        Me.btnRemoveReward.Location = New System.Drawing.Point(288, 88)
        Me.btnRemoveReward.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveReward.Name = "btnRemoveReward"
        Me.btnRemoveReward.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRemoveReward.Size = New System.Drawing.Size(88, 27)
        Me.btnRemoveReward.TabIndex = 2
        Me.btnRemoveReward.Text = "Remove"
        '
        'btnAddReward
        '
        Me.btnAddReward.Location = New System.Drawing.Point(288, 22)
        Me.btnAddReward.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddReward.Name = "btnAddReward"
        Me.btnAddReward.Padding = New System.Windows.Forms.Padding(6)
        Me.btnAddReward.Size = New System.Drawing.Size(88, 27)
        Me.btnAddReward.TabIndex = 1
        Me.btnAddReward.Text = "Add"
        '
        'lstRewards
        '
        Me.lstRewards.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRewards.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstRewards.FormattingEnabled = true
        Me.lstRewards.ItemHeight = 15
        Me.lstRewards.Location = New System.Drawing.Point(7, 22)
        Me.lstRewards.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRewards.Name = "lstRewards"
        Me.lstRewards.Size = New System.Drawing.Size(274, 92)
        Me.lstRewards.TabIndex = 0
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = true
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(377, 65)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(51, 15)
        Me.DarkLabel4.TabIndex = 9
        Me.DarkLabel4.Text = "End Text"
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = true
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(190, 65)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(89, 15)
        Me.DarkLabel3.TabIndex = 8
        Me.DarkLabel3.Text = "In Progress Text"
        '
        'txtEndText
        '
        Me.txtEndText.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtEndText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtEndText.Location = New System.Drawing.Point(380, 83)
        Me.txtEndText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEndText.Multiline = true
        Me.txtEndText.Name = "txtEndText"
        Me.txtEndText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEndText.Size = New System.Drawing.Size(179, 75)
        Me.txtEndText.TabIndex = 7
        '
        'txtProgressText
        '
        Me.txtProgressText.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtProgressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProgressText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtProgressText.Location = New System.Drawing.Point(194, 83)
        Me.txtProgressText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtProgressText.Multiline = true
        Me.txtProgressText.Name = "txtProgressText"
        Me.txtProgressText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProgressText.Size = New System.Drawing.Size(179, 75)
        Me.txtProgressText.TabIndex = 6
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = true
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(7, 65)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(55, 15)
        Me.DarkLabel2.TabIndex = 5
        Me.DarkLabel2.Text = "Start Text"
        '
        'txtStartText
        '
        Me.txtStartText.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtStartText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStartText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtStartText.Location = New System.Drawing.Point(7, 83)
        Me.txtStartText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtStartText.Multiline = true
        Me.txtStartText.Name = "txtStartText"
        Me.txtStartText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStartText.Size = New System.Drawing.Size(179, 75)
        Me.txtStartText.TabIndex = 4
        '
        'chkQuestCancel
        '
        Me.chkQuestCancel.AutoSize = true
        Me.chkQuestCancel.Location = New System.Drawing.Point(434, 23)
        Me.chkQuestCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkQuestCancel.Name = "chkQuestCancel"
        Me.chkQuestCancel.Size = New System.Drawing.Size(96, 19)
        Me.chkQuestCancel.TabIndex = 3
        Me.chkQuestCancel.Text = "Cancel Quest"
        '
        'chkRepeat
        '
        Me.chkRepeat.AutoSize = true
        Me.chkRepeat.Location = New System.Drawing.Point(326, 23)
        Me.chkRepeat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkRepeat.Name = "chkRepeat"
        Me.chkRepeat.Size = New System.Drawing.Size(89, 19)
        Me.chkRepeat.TabIndex = 2
        Me.chkRepeat.Text = "Repeatable?"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtName.Location = New System.Drawing.Point(94, 22)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 23)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = true
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(7, 24)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(76, 15)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Quest Name:"
        '
        'DarkLabel8
        '
        Me.DarkLabel8.AutoSize = true
        Me.DarkLabel8.ForeColor = System.Drawing.Color.Red
        Me.DarkLabel8.Location = New System.Drawing.Point(258, 535)
        Me.DarkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel8.Name = "DarkLabel8"
        Me.DarkLabel8.Size = New System.Drawing.Size(238, 15)
        Me.DarkLabel8.TabIndex = 2
        Me.DarkLabel8.Text = "Use /questreset # to reset a quest for testing"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(653, 539)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(6)
        Me.btnSave.Size = New System.Drawing.Size(88, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(749, 539)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(6)
        Me.btnCancel.Size = New System.Drawing.Size(88, 27)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'fraTasks
        '
        Me.fraTasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.fraTasks.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.fraTasks.Controls.Add(Me.btnCancelTask)
        Me.fraTasks.Controls.Add(Me.btnSaveTask)
        Me.fraTasks.Controls.Add(Me.Panel2)
        Me.fraTasks.Controls.Add(Me.Panel1)
        Me.fraTasks.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraTasks.Location = New System.Drawing.Point(845, 3)
        Me.fraTasks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraTasks.Name = "fraTasks"
        Me.fraTasks.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraTasks.Size = New System.Drawing.Size(839, 573)
        Me.fraTasks.TabIndex = 5
        Me.fraTasks.TabStop = false
        Me.fraTasks.Text = "Tasks"
        '
        'btnCancelTask
        '
        Me.btnCancelTask.Location = New System.Drawing.Point(162, 398)
        Me.btnCancelTask.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancelTask.Name = "btnCancelTask"
        Me.btnCancelTask.Padding = New System.Windows.Forms.Padding(6)
        Me.btnCancelTask.Size = New System.Drawing.Size(131, 27)
        Me.btnCancelTask.TabIndex = 3
        Me.btnCancelTask.Text = "Cancel Task"
        '
        'btnSaveTask
        '
        Me.btnSaveTask.Location = New System.Drawing.Point(7, 398)
        Me.btnSaveTask.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSaveTask.Name = "btnSaveTask"
        Me.btnSaveTask.Padding = New System.Windows.Forms.Padding(6)
        Me.btnSaveTask.Size = New System.Drawing.Size(128, 27)
        Me.btnSaveTask.TabIndex = 2
        Me.btnSaveTask.Text = "Save Task"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.optTask7)
        Me.Panel2.Controls.Add(Me.optTask6)
        Me.Panel2.Controls.Add(Me.optTask5)
        Me.Panel2.Controls.Add(Me.optTask4)
        Me.Panel2.Controls.Add(Me.optTask3)
        Me.Panel2.Controls.Add(Me.optTask2)
        Me.Panel2.Controls.Add(Me.DarkLabel16)
        Me.Panel2.Controls.Add(Me.optTask1)
        Me.Panel2.Controls.Add(Me.optTask0)
        Me.Panel2.Location = New System.Drawing.Point(300, 22)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 227)
        Me.Panel2.TabIndex = 1
        '
        'optTask7
        '
        Me.optTask7.AutoSize = true
        Me.optTask7.Location = New System.Drawing.Point(7, 202)
        Me.optTask7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask7.Name = "optTask7"
        Me.optTask7.Size = New System.Drawing.Size(124, 19)
        Me.optTask7.TabIndex = 8
        Me.optTask7.TabStop = true
        Me.optTask7.Text = "Get Item from Npc"
        '
        'optTask6
        '
        Me.optTask6.AutoSize = true
        Me.optTask6.Location = New System.Drawing.Point(7, 175)
        Me.optTask6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask6.Name = "optTask6"
        Me.optTask6.Size = New System.Drawing.Size(116, 19)
        Me.optTask6.TabIndex = 7
        Me.optTask6.TabStop = true
        Me.optTask6.Text = "Gather Resources"
        '
        'optTask5
        '
        Me.optTask5.AutoSize = true
        Me.optTask5.Location = New System.Drawing.Point(7, 149)
        Me.optTask5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask5.Name = "optTask5"
        Me.optTask5.Size = New System.Drawing.Size(114, 19)
        Me.optTask5.TabIndex = 6
        Me.optTask5.TabStop = true
        Me.optTask5.Text = "Give Item to Npc"
        '
        'optTask4
        '
        Me.optTask4.AutoSize = true
        Me.optTask4.Location = New System.Drawing.Point(7, 122)
        Me.optTask4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask4.Name = "optTask4"
        Me.optTask4.Size = New System.Drawing.Size(84, 19)
        Me.optTask4.TabIndex = 5
        Me.optTask4.TabStop = true
        Me.optTask4.Text = "Reach Map"
        '
        'optTask3
        '
        Me.optTask3.AutoSize = true
        Me.optTask3.Location = New System.Drawing.Point(7, 96)
        Me.optTask3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask3.Name = "optTask3"
        Me.optTask3.Size = New System.Drawing.Size(85, 19)
        Me.optTask3.TabIndex = 4
        Me.optTask3.TabStop = true
        Me.optTask3.Text = "Talk To Npc"
        '
        'optTask2
        '
        Me.optTask2.AutoSize = true
        Me.optTask2.Location = New System.Drawing.Point(7, 69)
        Me.optTask2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask2.Name = "optTask2"
        Me.optTask2.Size = New System.Drawing.Size(92, 19)
        Me.optTask2.TabIndex = 3
        Me.optTask2.TabStop = true
        Me.optTask2.Text = "Gather Items"
        '
        'DarkLabel16
        '
        Me.DarkLabel16.AutoSize = true
        Me.DarkLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel16.Location = New System.Drawing.Point(4, 29)
        Me.DarkLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel16.Name = "DarkLabel16"
        Me.DarkLabel16.Size = New System.Drawing.Size(237, 15)
        Me.DarkLabel16.TabIndex = 2
        Me.DarkLabel16.Text = "----------------------------------------------"
        '
        'optTask1
        '
        Me.optTask1.AutoSize = true
        Me.optTask1.Location = New System.Drawing.Point(7, 43)
        Me.optTask1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask1.Name = "optTask1"
        Me.optTask1.Size = New System.Drawing.Size(92, 19)
        Me.optTask1.TabIndex = 1
        Me.optTask1.TabStop = true
        Me.optTask1.Text = "Defeat Npc's"
        '
        'optTask0
        '
        Me.optTask0.AutoSize = true
        Me.optTask0.Location = New System.Drawing.Point(7, 6)
        Me.optTask0.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optTask0.Name = "optTask0"
        Me.optTask0.Size = New System.Drawing.Size(69, 19)
        Me.optTask0.TabIndex = 0
        Me.optTask0.TabStop = true
        Me.optTask0.Text = "Nothing"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbResource)
        Me.Panel1.Controls.Add(Me.cmbMap)
        Me.Panel1.Controls.Add(Me.cmbItem)
        Me.Panel1.Controls.Add(Me.cmbNpc)
        Me.Panel1.Controls.Add(Me.DarkLabel17)
        Me.Panel1.Controls.Add(Me.lblTaskNum)
        Me.Panel1.Controls.Add(Me.nudAmount)
        Me.Panel1.Controls.Add(Me.DarkLabel15)
        Me.Panel1.Controls.Add(Me.DarkLabel14)
        Me.Panel1.Controls.Add(Me.DarkLabel13)
        Me.Panel1.Controls.Add(Me.DarkLabel12)
        Me.Panel1.Controls.Add(Me.DarkLabel11)
        Me.Panel1.Controls.Add(Me.chkEnd)
        Me.Panel1.Controls.Add(Me.txtTaskSpeech)
        Me.Panel1.Controls.Add(Me.DarkLabel10)
        Me.Panel1.Controls.Add(Me.txtTaskLog)
        Me.Panel1.Controls.Add(Me.DarkLabel9)
        Me.Panel1.Location = New System.Drawing.Point(7, 22)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 369)
        Me.Panel1.TabIndex = 0
        '
        'cmbResource
        '
        Me.cmbResource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbResource.FormattingEnabled = true
        Me.cmbResource.Location = New System.Drawing.Point(72, 230)
        Me.cmbResource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbResource.Name = "cmbResource"
        Me.cmbResource.Size = New System.Drawing.Size(140, 24)
        Me.cmbResource.TabIndex = 20
        '
        'cmbMap
        '
        Me.cmbMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMap.FormattingEnabled = true
        Me.cmbMap.Location = New System.Drawing.Point(72, 200)
        Me.cmbMap.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMap.Name = "cmbMap"
        Me.cmbMap.Size = New System.Drawing.Size(140, 24)
        Me.cmbMap.TabIndex = 19
        '
        'cmbItem
        '
        Me.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItem.FormattingEnabled = true
        Me.cmbItem.Location = New System.Drawing.Point(72, 170)
        Me.cmbItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(140, 24)
        Me.cmbItem.TabIndex = 18
        '
        'cmbNpc
        '
        Me.cmbNpc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNpc.FormattingEnabled = true
        Me.cmbNpc.Location = New System.Drawing.Point(72, 140)
        Me.cmbNpc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbNpc.Name = "cmbNpc"
        Me.cmbNpc.Size = New System.Drawing.Size(140, 24)
        Me.cmbNpc.TabIndex = 17
        '
        'DarkLabel17
        '
        Me.DarkLabel17.AutoSize = true
        Me.DarkLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel17.Location = New System.Drawing.Point(8, 257)
        Me.DarkLabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel17.Name = "DarkLabel17"
        Me.DarkLabel17.Size = New System.Drawing.Size(382, 15)
        Me.DarkLabel17.TabIndex = 16
        Me.DarkLabel17.Text = "---------------------------------------------------------------------------"
        '
        'lblTaskNum
        '
        Me.lblTaskNum.AutoSize = true
        Me.lblTaskNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.lblTaskNum.Location = New System.Drawing.Point(4, 343)
        Me.lblTaskNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskNum.Name = "lblTaskNum"
        Me.lblTaskNum.Size = New System.Drawing.Size(79, 15)
        Me.lblTaskNum.TabIndex = 15
        Me.lblTaskNum.Text = "Task Number:"
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(74, 276)
        Me.nudAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(140, 23)
        Me.nudAmount.TabIndex = 14
        '
        'DarkLabel15
        '
        Me.DarkLabel15.AutoSize = true
        Me.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel15.Location = New System.Drawing.Point(4, 278)
        Me.DarkLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel15.Name = "DarkLabel15"
        Me.DarkLabel15.Size = New System.Drawing.Size(54, 15)
        Me.DarkLabel15.TabIndex = 13
        Me.DarkLabel15.Text = "Amount:"
        '
        'DarkLabel14
        '
        Me.DarkLabel14.AutoSize = true
        Me.DarkLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel14.Location = New System.Drawing.Point(4, 233)
        Me.DarkLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel14.Name = "DarkLabel14"
        Me.DarkLabel14.Size = New System.Drawing.Size(58, 15)
        Me.DarkLabel14.TabIndex = 11
        Me.DarkLabel14.Text = "Resource:"
        '
        'DarkLabel13
        '
        Me.DarkLabel13.AutoSize = true
        Me.DarkLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel13.Location = New System.Drawing.Point(4, 203)
        Me.DarkLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel13.Name = "DarkLabel13"
        Me.DarkLabel13.Size = New System.Drawing.Size(34, 15)
        Me.DarkLabel13.TabIndex = 9
        Me.DarkLabel13.Text = "Map:"
        '
        'DarkLabel12
        '
        Me.DarkLabel12.AutoSize = true
        Me.DarkLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel12.Location = New System.Drawing.Point(4, 173)
        Me.DarkLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel12.Name = "DarkLabel12"
        Me.DarkLabel12.Size = New System.Drawing.Size(34, 15)
        Me.DarkLabel12.TabIndex = 7
        Me.DarkLabel12.Text = "Item:"
        '
        'DarkLabel11
        '
        Me.DarkLabel11.AutoSize = true
        Me.DarkLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel11.Location = New System.Drawing.Point(4, 143)
        Me.DarkLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel11.Name = "DarkLabel11"
        Me.DarkLabel11.Size = New System.Drawing.Size(32, 15)
        Me.DarkLabel11.TabIndex = 5
        Me.DarkLabel11.Text = "Npc:"
        '
        'chkEnd
        '
        Me.chkEnd.AutoSize = true
        Me.chkEnd.ForeColor = System.Drawing.Color.Lime
        Me.chkEnd.Location = New System.Drawing.Point(4, 99)
        Me.chkEnd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkEnd.Name = "chkEnd"
        Me.chkEnd.Size = New System.Drawing.Size(113, 19)
        Me.chkEnd.TabIndex = 4
        Me.chkEnd.Text = "End Quest Now?"
        '
        'txtTaskSpeech
        '
        Me.txtTaskSpeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtTaskSpeech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaskSpeech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtTaskSpeech.Location = New System.Drawing.Point(4, 69)
        Me.txtTaskSpeech.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTaskSpeech.Name = "txtTaskSpeech"
        Me.txtTaskSpeech.Size = New System.Drawing.Size(275, 23)
        Me.txtTaskSpeech.TabIndex = 3
        '
        'DarkLabel10
        '
        Me.DarkLabel10.AutoSize = true
        Me.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel10.Location = New System.Drawing.Point(4, 51)
        Me.DarkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel10.Name = "DarkLabel10"
        Me.DarkLabel10.Size = New System.Drawing.Size(70, 15)
        Me.DarkLabel10.TabIndex = 2
        Me.DarkLabel10.Text = "Task Speech"
        '
        'txtTaskLog
        '
        Me.txtTaskLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtTaskLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaskLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtTaskLog.Location = New System.Drawing.Point(4, 24)
        Me.txtTaskLog.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTaskLog.Name = "txtTaskLog"
        Me.txtTaskLog.Size = New System.Drawing.Size(275, 23)
        Me.txtTaskLog.TabIndex = 1
        '
        'DarkLabel9
        '
        Me.DarkLabel9.AutoSize = true
        Me.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel9.Location = New System.Drawing.Point(4, 6)
        Me.DarkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel9.Name = "DarkLabel9"
        Me.DarkLabel9.Size = New System.Drawing.Size(52, 15)
        Me.DarkLabel9.TabIndex = 0
        Me.DarkLabel9.Text = "Task Log"
        '
        'fraRequirements
        '
        Me.fraRequirements.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.fraRequirements.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.fraRequirements.Controls.Add(Me.DarkGroupBox6)
        Me.fraRequirements.Controls.Add(Me.cmbClassReq)
        Me.fraRequirements.Controls.Add(Me.DarkLabel20)
        Me.fraRequirements.Controls.Add(Me.rdbClassReq)
        Me.fraRequirements.Controls.Add(Me.cmbQuestReq)
        Me.fraRequirements.Controls.Add(Me.DarkLabel19)
        Me.fraRequirements.Controls.Add(Me.rdbQuestReq)
        Me.fraRequirements.Controls.Add(Me.cmbItemReq)
        Me.fraRequirements.Controls.Add(Me.DarkLabel18)
        Me.fraRequirements.Controls.Add(Me.rdbItemReq)
        Me.fraRequirements.Controls.Add(Me.rdbNoneReq)
        Me.fraRequirements.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraRequirements.Location = New System.Drawing.Point(845, 3)
        Me.fraRequirements.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraRequirements.Name = "fraRequirements"
        Me.fraRequirements.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fraRequirements.Size = New System.Drawing.Size(611, 573)
        Me.fraRequirements.TabIndex = 6
        Me.fraRequirements.TabStop = false
        Me.fraRequirements.Text = "Requirements"
        Me.fraRequirements.Visible = false
        '
        'DarkGroupBox6
        '
        Me.DarkGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox6.Controls.Add(Me.btnRequirementCancel)
        Me.DarkGroupBox6.Controls.Add(Me.btnRequirementSave)
        Me.DarkGroupBox6.Controls.Add(Me.nudTakeAmount)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel23)
        Me.DarkGroupBox6.Controls.Add(Me.cmbEndItem)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel24)
        Me.DarkGroupBox6.Controls.Add(Me.nudGiveAmount)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel22)
        Me.DarkGroupBox6.Controls.Add(Me.cmbStartItem)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel21)
        Me.DarkGroupBox6.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox6.Location = New System.Drawing.Point(7, 183)
        Me.DarkGroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox6.Name = "DarkGroupBox6"
        Me.DarkGroupBox6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox6.Size = New System.Drawing.Size(394, 332)
        Me.DarkGroupBox6.TabIndex = 10
        Me.DarkGroupBox6.TabStop = false
        Me.DarkGroupBox6.Text = "Items Needed For Quest"
        '
        'btnRequirementCancel
        '
        Me.btnRequirementCancel.Location = New System.Drawing.Point(300, 299)
        Me.btnRequirementCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRequirementCancel.Name = "btnRequirementCancel"
        Me.btnRequirementCancel.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRequirementCancel.Size = New System.Drawing.Size(88, 27)
        Me.btnRequirementCancel.TabIndex = 9
        Me.btnRequirementCancel.Text = "Cancel"
        '
        'btnRequirementSave
        '
        Me.btnRequirementSave.Location = New System.Drawing.Point(205, 299)
        Me.btnRequirementSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRequirementSave.Name = "btnRequirementSave"
        Me.btnRequirementSave.Padding = New System.Windows.Forms.Padding(6)
        Me.btnRequirementSave.Size = New System.Drawing.Size(88, 27)
        Me.btnRequirementSave.TabIndex = 8
        Me.btnRequirementSave.Text = "Save"
        '
        'nudTakeAmount
        '
        Me.nudTakeAmount.Location = New System.Drawing.Point(306, 84)
        Me.nudTakeAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudTakeAmount.Name = "nudTakeAmount"
        Me.nudTakeAmount.Size = New System.Drawing.Size(82, 23)
        Me.nudTakeAmount.TabIndex = 7
        '
        'DarkLabel23
        '
        Me.DarkLabel23.AutoSize = true
        Me.DarkLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel23.Location = New System.Drawing.Point(245, 87)
        Me.DarkLabel23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel23.Name = "DarkLabel23"
        Me.DarkLabel23.Size = New System.Drawing.Size(54, 15)
        Me.DarkLabel23.TabIndex = 6
        Me.DarkLabel23.Text = "Amount:"
        '
        'cmbEndItem
        '
        Me.cmbEndItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEndItem.FormattingEnabled = true
        Me.cmbEndItem.Location = New System.Drawing.Point(78, 83)
        Me.cmbEndItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbEndItem.Name = "cmbEndItem"
        Me.cmbEndItem.Size = New System.Drawing.Size(159, 24)
        Me.cmbEndItem.TabIndex = 5
        '
        'DarkLabel24
        '
        Me.DarkLabel24.AutoSize = true
        Me.DarkLabel24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel24.Location = New System.Drawing.Point(7, 87)
        Me.DarkLabel24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel24.Name = "DarkLabel24"
        Me.DarkLabel24.Size = New System.Drawing.Size(60, 15)
        Me.DarkLabel24.TabIndex = 4
        Me.DarkLabel24.Text = "Take Item:"
        '
        'nudGiveAmount
        '
        Me.nudGiveAmount.Location = New System.Drawing.Point(306, 33)
        Me.nudGiveAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudGiveAmount.Name = "nudGiveAmount"
        Me.nudGiveAmount.Size = New System.Drawing.Size(82, 23)
        Me.nudGiveAmount.TabIndex = 3
        '
        'DarkLabel22
        '
        Me.DarkLabel22.AutoSize = true
        Me.DarkLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel22.Location = New System.Drawing.Point(245, 36)
        Me.DarkLabel22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel22.Name = "DarkLabel22"
        Me.DarkLabel22.Size = New System.Drawing.Size(54, 15)
        Me.DarkLabel22.TabIndex = 2
        Me.DarkLabel22.Text = "Amount:"
        '
        'cmbStartItem
        '
        Me.cmbStartItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStartItem.FormattingEnabled = true
        Me.cmbStartItem.Location = New System.Drawing.Point(78, 32)
        Me.cmbStartItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbStartItem.Name = "cmbStartItem"
        Me.cmbStartItem.Size = New System.Drawing.Size(159, 24)
        Me.cmbStartItem.TabIndex = 1
        '
        'DarkLabel21
        '
        Me.DarkLabel21.AutoSize = true
        Me.DarkLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel21.Location = New System.Drawing.Point(7, 36)
        Me.DarkLabel21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel21.Name = "DarkLabel21"
        Me.DarkLabel21.Size = New System.Drawing.Size(60, 15)
        Me.DarkLabel21.TabIndex = 0
        Me.DarkLabel21.Text = "Give Item:"
        '
        'cmbClassReq
        '
        Me.cmbClassReq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClassReq.FormattingEnabled = true
        Me.cmbClassReq.Location = New System.Drawing.Point(216, 147)
        Me.cmbClassReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbClassReq.Name = "cmbClassReq"
        Me.cmbClassReq.Size = New System.Drawing.Size(185, 24)
        Me.cmbClassReq.TabIndex = 9
        '
        'DarkLabel20
        '
        Me.DarkLabel20.AutoSize = true
        Me.DarkLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel20.Location = New System.Drawing.Point(93, 150)
        Me.DarkLabel20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel20.Name = "DarkLabel20"
        Me.DarkLabel20.Size = New System.Drawing.Size(108, 15)
        Me.DarkLabel20.TabIndex = 8
        Me.DarkLabel20.Text = "Class Requirement:"
        '
        'rdbClassReq
        '
        Me.rdbClassReq.AutoSize = true
        Me.rdbClassReq.Location = New System.Drawing.Point(12, 148)
        Me.rdbClassReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbClassReq.Name = "rdbClassReq"
        Me.rdbClassReq.Size = New System.Drawing.Size(52, 19)
        Me.rdbClassReq.TabIndex = 7
        Me.rdbClassReq.TabStop = true
        Me.rdbClassReq.Text = "Class"
        '
        'cmbQuestReq
        '
        Me.cmbQuestReq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbQuestReq.FormattingEnabled = true
        Me.cmbQuestReq.Location = New System.Drawing.Point(216, 105)
        Me.cmbQuestReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbQuestReq.Name = "cmbQuestReq"
        Me.cmbQuestReq.Size = New System.Drawing.Size(185, 24)
        Me.cmbQuestReq.TabIndex = 6
        '
        'DarkLabel19
        '
        Me.DarkLabel19.AutoSize = true
        Me.DarkLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel19.Location = New System.Drawing.Point(93, 108)
        Me.DarkLabel19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel19.Name = "DarkLabel19"
        Me.DarkLabel19.Size = New System.Drawing.Size(112, 15)
        Me.DarkLabel19.TabIndex = 5
        Me.DarkLabel19.Text = "Quest Requirement:"
        '
        'rdbQuestReq
        '
        Me.rdbQuestReq.AutoSize = true
        Me.rdbQuestReq.Location = New System.Drawing.Point(12, 106)
        Me.rdbQuestReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbQuestReq.Name = "rdbQuestReq"
        Me.rdbQuestReq.Size = New System.Drawing.Size(56, 19)
        Me.rdbQuestReq.TabIndex = 4
        Me.rdbQuestReq.TabStop = true
        Me.rdbQuestReq.Text = "Quest"
        '
        'cmbItemReq
        '
        Me.cmbItemReq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemReq.FormattingEnabled = true
        Me.cmbItemReq.Location = New System.Drawing.Point(216, 63)
        Me.cmbItemReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbItemReq.Name = "cmbItemReq"
        Me.cmbItemReq.Size = New System.Drawing.Size(185, 24)
        Me.cmbItemReq.TabIndex = 3
        '
        'DarkLabel18
        '
        Me.DarkLabel18.AutoSize = true
        Me.DarkLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel18.Location = New System.Drawing.Point(93, 67)
        Me.DarkLabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel18.Name = "DarkLabel18"
        Me.DarkLabel18.Size = New System.Drawing.Size(105, 15)
        Me.DarkLabel18.TabIndex = 2
        Me.DarkLabel18.Text = "Item Requirement:"
        '
        'rdbItemReq
        '
        Me.rdbItemReq.AutoSize = true
        Me.rdbItemReq.Location = New System.Drawing.Point(12, 65)
        Me.rdbItemReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbItemReq.Name = "rdbItemReq"
        Me.rdbItemReq.Size = New System.Drawing.Size(49, 19)
        Me.rdbItemReq.TabIndex = 1
        Me.rdbItemReq.TabStop = true
        Me.rdbItemReq.Text = "Item"
        '
        'rdbNoneReq
        '
        Me.rdbNoneReq.AutoSize = true
        Me.rdbNoneReq.Location = New System.Drawing.Point(12, 24)
        Me.rdbNoneReq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbNoneReq.Name = "rdbNoneReq"
        Me.rdbNoneReq.Size = New System.Drawing.Size(54, 19)
        Me.rdbNoneReq.TabIndex = 0
        Me.rdbNoneReq.TabStop = true
        Me.rdbNoneReq.Text = "None"
        '
        'frmEditor_Quest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1252, 570)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DarkLabel8)
        Me.Controls.Add(Me.DarkGroupBox2)
        Me.Controls.Add(Me.fraQuestList)
        Me.Controls.Add(Me.fraRequirements)
        Me.Controls.Add(Me.fraTasks)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmEditor_Quest"
        Me.Text = "Quest Editor"
        Me.fraQuestList.ResumeLayout(false)
        Me.DarkGroupBox2.ResumeLayout(false)
        Me.DarkGroupBox2.PerformLayout
        Me.DarkGroupBox5.ResumeLayout(false)
        Me.DarkGroupBox4.ResumeLayout(false)
        Me.DarkGroupBox3.ResumeLayout(false)
        Me.DarkGroupBox3.PerformLayout
        CType(Me.nudItemRewValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudExpReward,System.ComponentModel.ISupportInitialize).EndInit
        Me.fraTasks.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).EndInit
        Me.fraRequirements.ResumeLayout(false)
        Me.fraRequirements.PerformLayout
        Me.DarkGroupBox6.ResumeLayout(false)
        Me.DarkGroupBox6.PerformLayout
        CType(Me.nudTakeAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudGiveAmount,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents fraQuestList As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIndex As Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents chkRepeat As DarkUI.Controls.DarkCheckBox
    Friend WithEvents chkQuestCancel As DarkUI.Controls.DarkCheckBox
    Friend WithEvents txtStartText As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtEndText As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtProgressText As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox3 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstRewards As Windows.Forms.ListBox
    Friend WithEvents btnAddReward As DarkUI.Controls.DarkButton
    Friend WithEvents btnRemoveReward As DarkUI.Controls.DarkButton
    Friend WithEvents nudExpReward As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudItemRewValue As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbItemReward As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox4 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkGroupBox5 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnAddRequirement As DarkUI.Controls.DarkButton
    Friend WithEvents btnRemoveRequirement As DarkUI.Controls.DarkButton
    Friend WithEvents lstRequirements As Windows.Forms.ListBox
    Friend WithEvents lstTasks As Windows.Forms.ListBox
    Friend WithEvents btnRemoveTask As DarkUI.Controls.DarkButton
    Friend WithEvents btnAddTask As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel8 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnSave As DarkUI.Controls.DarkButton
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraTasks As DarkUI.Controls.DarkGroupBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txtTaskLog As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel9 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtTaskSpeech As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel10 As DarkUI.Controls.DarkLabel
    Friend WithEvents chkEnd As DarkUI.Controls.DarkCheckBox
    Friend WithEvents DarkLabel11 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel13 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel12 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel14 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel15 As DarkUI.Controls.DarkLabel
    Friend WithEvents lblTaskNum As DarkUI.Controls.DarkLabel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents optTask0 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents DarkLabel16 As DarkUI.Controls.DarkLabel
    Friend WithEvents optTask1 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask2 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask3 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask4 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask5 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask6 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optTask7 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents DarkLabel17 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraRequirements As DarkUI.Controls.DarkGroupBox
    Friend WithEvents rdbNoneReq As DarkUI.Controls.DarkRadioButton
    Friend WithEvents rdbItemReq As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbItemReq As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel18 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbQuestReq As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel19 As DarkUI.Controls.DarkLabel
    Friend WithEvents rdbQuestReq As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbClassReq As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel20 As DarkUI.Controls.DarkLabel
    Friend WithEvents rdbClassReq As DarkUI.Controls.DarkRadioButton
    Friend WithEvents DarkGroupBox6 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbStartItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel21 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudGiveAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel22 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudTakeAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel23 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbEndItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel24 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnRequirementSave As DarkUI.Controls.DarkButton
    Friend WithEvents btnRequirementCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnCancelTask As DarkUI.Controls.DarkButton
    Friend WithEvents btnSaveTask As DarkUI.Controls.DarkButton
    Friend WithEvents cmbResource As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbMap As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbNpc As DarkUI.Controls.DarkComboBox
End Class
