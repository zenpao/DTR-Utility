<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChPASS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChPASS))
        Me.lblOld = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.BackColor = System.Drawing.Color.Transparent
        Me.lblOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOld.Location = New System.Drawing.Point(32, 23)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(88, 13)
        Me.lblOld.TabIndex = 0
        Me.lblOld.Text = "Old Password:"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(26, 48)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(94, 13)
        Me.lblNew.TabIndex = 1
        Me.lblNew.Text = "New Password:"
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BackColor = System.Drawing.Color.Transparent
        Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheck.Location = New System.Drawing.Point(13, 74)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(111, 13)
        Me.lblCheck.TabIndex = 2
        Me.lblCheck.Text = "Confirm Password:"
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(126, 15)
        Me.txtOld.MaxLength = 12
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(151, 20)
        Me.txtOld.TabIndex = 5
        Me.txtOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOld.UseSystemPasswordChar = True
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(126, 41)
        Me.txtNew.MaxLength = 12
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(151, 20)
        Me.txtNew.TabIndex = 6
        Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNew.UseSystemPasswordChar = True
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(126, 67)
        Me.txtCheck.MaxLength = 12
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCheck.Size = New System.Drawing.Size(151, 20)
        Me.txtCheck.TabIndex = 7
        Me.txtCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCheck.UseSystemPasswordChar = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(283, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 72)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ChPASS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(369, 99)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblOld)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChPASS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOld As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
