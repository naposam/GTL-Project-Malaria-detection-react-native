<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLog
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLOGIN = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LblWel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbTim = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(113, 135)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(314, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(113, 197)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(314, 20)
        Me.txtPass.TabIndex = 0
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnLOGIN
        '
        Me.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLOGIN.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOGIN.ForeColor = System.Drawing.Color.White
        Me.btnLOGIN.Location = New System.Drawing.Point(339, 257)
        Me.btnLOGIN.Name = "btnLOGIN"
        Me.btnLOGIN.Size = New System.Drawing.Size(121, 54)
        Me.btnLOGIN.TabIndex = 1
        Me.btnLOGIN.Text = "LOGIN"
        Me.btnLOGIN.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(69, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 54)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'LblWel
        '
        Me.LblWel.AutoSize = True
        Me.LblWel.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWel.Location = New System.Drawing.Point(145, 9)
        Me.LblWel.Name = "LblWel"
        Me.LblWel.Size = New System.Drawing.Size(188, 25)
        Me.LblWel.TabIndex = 2
        Me.LblWel.Text = "WELCOME ADMIN"
        '
        'Timer1
        '
        '
        'LbTim
        '
        Me.LbTim.AutoSize = True
        Me.LbTim.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTim.Location = New System.Drawing.Point(339, 58)
        Me.LbTim.Name = "LbTim"
        Me.LbTim.Size = New System.Drawing.Size(0, 19)
        Me.LbTim.TabIndex = 3
        '
        'AdminLog
        '
        Me.AcceptButton = Me.btnLOGIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Our_ProjectWork.My.Resources.Resources.admin2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(503, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbTim)
        Me.Controls.Add(Me.LblWel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLOGIN)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.DoubleBuffered = True
        Me.Name = "AdminLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnLOGIN As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LblWel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LbTim As System.Windows.Forms.Label
End Class
