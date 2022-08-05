<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_VisualWarp
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
        Me.btnWarpOK = New DarkUI.Controls.DarkButton()
        Me.DarkLabel15 = New DarkUI.Controls.DarkLabel()
        Me.lstMaps = New System.Windows.Forms.ListBox()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.lblSelX = New DarkUI.Controls.DarkLabel()
        Me.lblSelY = New DarkUI.Controls.DarkLabel()
        Me.pnlPreview.SuspendLayout
        CType(Me.picPreview,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnWarpOK
        '
        Me.btnWarpOK.Location = New System.Drawing.Point(14, 582)
        Me.btnWarpOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnWarpOK.Name = "btnWarpOK"
        Me.btnWarpOK.Padding = New System.Windows.Forms.Padding(6)
        Me.btnWarpOK.Size = New System.Drawing.Size(195, 27)
        Me.btnWarpOK.TabIndex = 4
        Me.btnWarpOK.Text = "Ok"
        '
        'DarkLabel15
        '
        Me.DarkLabel15.AutoSize = true
        Me.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.DarkLabel15.Location = New System.Drawing.Point(14, 10)
        Me.DarkLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel15.Name = "DarkLabel15"
        Me.DarkLabel15.Size = New System.Drawing.Size(52, 15)
        Me.DarkLabel15.TabIndex = 3
        Me.DarkLabel15.Text = "Map List"
        '
        'lstMaps
        '
        Me.lstMaps.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.lstMaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMaps.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstMaps.FormattingEnabled = true
        Me.lstMaps.ItemHeight = 15
        Me.lstMaps.Location = New System.Drawing.Point(14, 29)
        Me.lstMaps.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstMaps.Name = "lstMaps"
        Me.lstMaps.Size = New System.Drawing.Size(202, 317)
        Me.lstMaps.TabIndex = 2
        '
        'pnlPreview
        '
        Me.pnlPreview.AutoScroll = true
        Me.pnlPreview.Controls.Add(Me.picPreview)
        Me.pnlPreview.Location = New System.Drawing.Point(223, 14)
        Me.pnlPreview.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(687, 594)
        Me.pnlPreview.TabIndex = 1
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(4, 3)
        Me.picPreview.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(415, 434)
        Me.picPreview.TabIndex = 0
        Me.picPreview.TabStop = false
        '
        'lblSelX
        '
        Me.lblSelX.AutoSize = true
        Me.lblSelX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.lblSelX.Location = New System.Drawing.Point(14, 361)
        Me.lblSelX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelX.Name = "lblSelX"
        Me.lblSelX.Size = New System.Drawing.Size(73, 15)
        Me.lblSelX.TabIndex = 5
        Me.lblSelX.Text = "Selected X: 0"
        '
        'lblSelY
        '
        Me.lblSelY.AutoSize = true
        Me.lblSelY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.lblSelY.Location = New System.Drawing.Point(14, 390)
        Me.lblSelY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelY.Name = "lblSelY"
        Me.lblSelY.Size = New System.Drawing.Size(73, 15)
        Me.lblSelY.TabIndex = 6
        Me.lblSelY.Text = "Selected Y: 0"
        '
        'frmEditor_VisualWarp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(919, 622)
        Me.Controls.Add(Me.lblSelY)
        Me.Controls.Add(Me.lblSelX)
        Me.Controls.Add(Me.pnlPreview)
        Me.Controls.Add(Me.btnWarpOK)
        Me.Controls.Add(Me.DarkLabel15)
        Me.Controls.Add(Me.lstMaps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmEditor_VisualWarp"
        Me.Text = "Visual Warp"
        Me.pnlPreview.ResumeLayout(false)
        CType(Me.picPreview,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnWarpOK As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel15 As DarkUI.Controls.DarkLabel
    Friend WithEvents lstMaps As Windows.Forms.ListBox
    Friend WithEvents pnlPreview As Windows.Forms.Panel
    Friend WithEvents picPreview As Windows.Forms.PictureBox
    Friend WithEvents lblSelX As DarkUI.Controls.DarkLabel
    Friend WithEvents lblSelY As DarkUI.Controls.DarkLabel
End Class
