<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_Recipe
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
        Me.DarkGroupBox1 = New DarkUI.Controls.DarkGroupBox()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        Me.btnCancel = New DarkUI.Controls.DarkButton()
        Me.btnDelete = New DarkUI.Controls.DarkButton()
        Me.btnSave = New DarkUI.Controls.DarkButton()
        Me.nudCreateTime = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox3 = New DarkUI.Controls.DarkGroupBox()
        Me.btnIngredientAdd = New DarkUI.Controls.DarkButton()
        Me.numItemAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.cmbIngredient = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.lstIngredients = New System.Windows.Forms.ListBox()
        Me.nudAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.cmbMakeItem = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.cmbType = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.txtName = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox1.SuspendLayout
        Me.DarkGroupBox2.SuspendLayout
        CType(Me.nudCreateTime,System.ComponentModel.ISupportInitialize).BeginInit
        Me.DarkGroupBox3.SuspendLayout
        CType(Me.numItemAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DarkGroupBox1
        '
        Me.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox1.Controls.Add(Me.lstIndex)
        Me.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.DarkGroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox1.Name = "DarkGroupBox1"
        Me.DarkGroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox1.Size = New System.Drawing.Size(243, 367)
        Me.DarkGroupBox1.TabIndex = 0
        Me.DarkGroupBox1.TabStop = false
        Me.DarkGroupBox1.Text = "Recipe List"
        '
        'lstIndex
        '
        Me.lstIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIndex.FormattingEnabled = true
        Me.lstIndex.ItemHeight = 15
        Me.lstIndex.Location = New System.Drawing.Point(7, 17)
        Me.lstIndex.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(228, 332)
        Me.lstIndex.TabIndex = 1
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox2.Controls.Add(Me.btnCancel)
        Me.DarkGroupBox2.Controls.Add(Me.btnDelete)
        Me.DarkGroupBox2.Controls.Add(Me.btnSave)
        Me.DarkGroupBox2.Controls.Add(Me.nudCreateTime)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel7)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox3)
        Me.DarkGroupBox2.Controls.Add(Me.nudAmount)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox2.Controls.Add(Me.cmbMakeItem)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox2.Controls.Add(Me.cmbType)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox2.Controls.Add(Me.txtName)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel1)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(253, 2)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(425, 367)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = false
        Me.DarkGroupBox2.Text = "Settings"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(329, 331)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(6)
        Me.btnCancel.Size = New System.Drawing.Size(88, 27)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(166, 331)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(6)
        Me.btnDelete.Size = New System.Drawing.Size(88, 27)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(8, 331)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(6)
        Me.btnSave.Size = New System.Drawing.Size(88, 27)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'nudCreateTime
        '
        Me.nudCreateTime.Location = New System.Drawing.Point(200, 136)
        Me.nudCreateTime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudCreateTime.Name = "nudCreateTime"
        Me.nudCreateTime.Size = New System.Drawing.Size(140, 23)
        Me.nudCreateTime.TabIndex = 10
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = true
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(7, 138)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(112, 15)
        Me.DarkLabel7.TabIndex = 9
        Me.DarkLabel7.Text = "Create Time In Secs:"
        '
        'DarkGroupBox3
        '
        Me.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.DarkGroupBox3.Controls.Add(Me.btnIngredientAdd)
        Me.DarkGroupBox3.Controls.Add(Me.numItemAmount)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox3.Controls.Add(Me.cmbIngredient)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox3.Controls.Add(Me.lstIngredients)
        Me.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox3.Location = New System.Drawing.Point(10, 166)
        Me.DarkGroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox3.Name = "DarkGroupBox3"
        Me.DarkGroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DarkGroupBox3.Size = New System.Drawing.Size(402, 159)
        Me.DarkGroupBox3.TabIndex = 8
        Me.DarkGroupBox3.TabStop = false
        Me.DarkGroupBox3.Text = "Ingredients"
        '
        'btnIngredientAdd
        '
        Me.btnIngredientAdd.Location = New System.Drawing.Point(204, 118)
        Me.btnIngredientAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnIngredientAdd.Name = "btnIngredientAdd"
        Me.btnIngredientAdd.Padding = New System.Windows.Forms.Padding(6)
        Me.btnIngredientAdd.Size = New System.Drawing.Size(168, 27)
        Me.btnIngredientAdd.TabIndex = 6
        Me.btnIngredientAdd.Text = "Update List"
        '
        'numItemAmount
        '
        Me.numItemAmount.Location = New System.Drawing.Point(334, 72)
        Me.numItemAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.numItemAmount.Name = "numItemAmount"
        Me.numItemAmount.Size = New System.Drawing.Size(62, 23)
        Me.numItemAmount.TabIndex = 5
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = true
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(184, 74)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(98, 15)
        Me.DarkLabel6.TabIndex = 4
        Me.DarkLabel6.Text = "Amount Needed:"
        '
        'cmbIngredient
        '
        Me.cmbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIngredient.FormattingEnabled = true
        Me.cmbIngredient.Location = New System.Drawing.Point(188, 40)
        Me.cmbIngredient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbIngredient.Name = "cmbIngredient"
        Me.cmbIngredient.Size = New System.Drawing.Size(207, 24)
        Me.cmbIngredient.TabIndex = 3
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = true
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(184, 22)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(104, 15)
        Me.DarkLabel5.TabIndex = 2
        Me.DarkLabel5.Text = "Choose Ingredient"
        '
        'lstIngredients
        '
        Me.lstIngredients.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIngredients.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIngredients.FormattingEnabled = true
        Me.lstIngredients.ItemHeight = 15
        Me.lstIngredients.Location = New System.Drawing.Point(7, 22)
        Me.lstIngredients.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstIngredients.Name = "lstIngredients"
        Me.lstIngredients.Size = New System.Drawing.Size(170, 122)
        Me.lstIngredients.TabIndex = 1
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(364, 99)
        Me.nudAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(49, 23)
        Me.nudAmount.TabIndex = 7
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = true
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(346, 102)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(14, 15)
        Me.DarkLabel4.TabIndex = 6
        Me.DarkLabel4.Text = "X"
        '
        'cmbMakeItem
        '
        Me.cmbMakeItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMakeItem.FormattingEnabled = true
        Me.cmbMakeItem.Location = New System.Drawing.Point(102, 98)
        Me.cmbMakeItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMakeItem.Name = "cmbMakeItem"
        Me.cmbMakeItem.Size = New System.Drawing.Size(237, 24)
        Me.cmbMakeItem.TabIndex = 5
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = true
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(7, 102)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(76, 15)
        Me.DarkLabel3.TabIndex = 4
        Me.DarkLabel3.Text = "Creates Item:"
        '
        'cmbType
        '
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.FormattingEnabled = true
        Me.cmbType.Items.AddRange(New Object() {"Herbalist", "WoodWorking", "MetalWorking"})
        Me.cmbType.Location = New System.Drawing.Point(102, 62)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(311, 24)
        Me.cmbType.TabIndex = 3
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = true
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(7, 66)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(34, 15)
        Me.DarkLabel2.TabIndex = 2
        Me.DarkLabel2.Text = "Type:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.txtName.Location = New System.Drawing.Point(102, 29)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(311, 23)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = true
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(7, 31)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(42, 15)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Name:"
        '
        'frmEditor_Recipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(682, 371)
        Me.Controls.Add(Me.DarkGroupBox2)
        Me.Controls.Add(Me.DarkGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmEditor_Recipe"
        Me.Text = "Recipe Editor"
        Me.DarkGroupBox1.ResumeLayout(false)
        Me.DarkGroupBox2.ResumeLayout(false)
        Me.DarkGroupBox2.PerformLayout
        CType(Me.nudCreateTime,System.ComponentModel.ISupportInitialize).EndInit
        Me.DarkGroupBox3.ResumeLayout(false)
        Me.DarkGroupBox3.PerformLayout
        CType(Me.numItemAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DarkGroupBox1 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIndex As Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbType As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbMakeItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox3 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIngredients As Windows.Forms.ListBox
    Friend WithEvents cmbIngredient As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents numItemAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents btnIngredientAdd As DarkUI.Controls.DarkButton
    Friend WithEvents nudCreateTime As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnDelete As DarkUI.Controls.DarkButton
    Friend WithEvents btnSave As DarkUI.Controls.DarkButton
End Class
