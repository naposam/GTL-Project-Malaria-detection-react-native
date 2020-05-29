<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.REGISTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWRECORDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASSESSMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATERECORDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESULTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTRESULTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GENERALRESULTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBJECTRESULTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTERToolStripMenuItem, Me.VIEWRECORDSToolStripMenuItem, Me.ASSESSMENTToolStripMenuItem, Me.UPDATERECORDSToolStripMenuItem, Me.RESULTSToolStripMenuItem, Me.PRINTRESULTSToolStripMenuItem, Me.GENERALRESULTToolStripMenuItem, Me.SUBJECTRESULTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REGISTERToolStripMenuItem
        '
        Me.REGISTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STAFFToolStripMenuItem, Me.STUDENTToolStripMenuItem})
        Me.REGISTERToolStripMenuItem.Name = "REGISTERToolStripMenuItem"
        Me.REGISTERToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.REGISTERToolStripMenuItem.Text = "REGISTER"
        '
        'STAFFToolStripMenuItem
        '
        Me.STAFFToolStripMenuItem.Name = "STAFFToolStripMenuItem"
        Me.STAFFToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.STAFFToolStripMenuItem.Text = "STAFF"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'VIEWRECORDSToolStripMenuItem
        '
        Me.VIEWRECORDSToolStripMenuItem.Name = "VIEWRECORDSToolStripMenuItem"
        Me.VIEWRECORDSToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.VIEWRECORDSToolStripMenuItem.Text = "ENTER ASSESSMENT"
        '
        'ASSESSMENTToolStripMenuItem
        '
        Me.ASSESSMENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentRecordsToolStripMenuItem, Me.StaffRecordsToolStripMenuItem})
        Me.ASSESSMENTToolStripMenuItem.Name = "ASSESSMENTToolStripMenuItem"
        Me.ASSESSMENTToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ASSESSMENTToolStripMenuItem.Text = "VIEW RECORDS"
        '
        'StudentRecordsToolStripMenuItem
        '
        Me.StudentRecordsToolStripMenuItem.Name = "StudentRecordsToolStripMenuItem"
        Me.StudentRecordsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.StudentRecordsToolStripMenuItem.Text = "Student Records"
        '
        'StaffRecordsToolStripMenuItem
        '
        Me.StaffRecordsToolStripMenuItem.Name = "StaffRecordsToolStripMenuItem"
        Me.StaffRecordsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.StaffRecordsToolStripMenuItem.Text = "Staff Records"
        '
        'UPDATERECORDSToolStripMenuItem
        '
        Me.UPDATERECORDSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffRecordsToolStripMenuItem1, Me.StudentRecordsToolStripMenuItem1})
        Me.UPDATERECORDSToolStripMenuItem.Name = "UPDATERECORDSToolStripMenuItem"
        Me.UPDATERECORDSToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.UPDATERECORDSToolStripMenuItem.Text = "UPDATE Staff  RECORDS"
        '
        'StaffRecordsToolStripMenuItem1
        '
        Me.StaffRecordsToolStripMenuItem1.Name = "StaffRecordsToolStripMenuItem1"
        Me.StaffRecordsToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.StaffRecordsToolStripMenuItem1.Text = "Staff Records"
        '
        'StudentRecordsToolStripMenuItem1
        '
        Me.StudentRecordsToolStripMenuItem1.Name = "StudentRecordsToolStripMenuItem1"
        Me.StudentRecordsToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.StudentRecordsToolStripMenuItem1.Text = "Student Records"
        '
        'RESULTSToolStripMenuItem
        '
        Me.RESULTSToolStripMenuItem.Name = "RESULTSToolStripMenuItem"
        Me.RESULTSToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.RESULTSToolStripMenuItem.Text = "CHECK RESULTS"
        '
        'PRINTRESULTSToolStripMenuItem
        '
        Me.PRINTRESULTSToolStripMenuItem.Name = "PRINTRESULTSToolStripMenuItem"
        Me.PRINTRESULTSToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.PRINTRESULTSToolStripMenuItem.Text = "PRINT RESULTS"
        '
        'GENERALRESULTToolStripMenuItem
        '
        Me.GENERALRESULTToolStripMenuItem.Name = "GENERALRESULTToolStripMenuItem"
        Me.GENERALRESULTToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.GENERALRESULTToolStripMenuItem.Text = "GENERAL RESULT"
        '
        'SUBJECTRESULTToolStripMenuItem
        '
        Me.SUBJECTRESULTToolStripMenuItem.Name = "SUBJECTRESULTToolStripMenuItem"
        Me.SUBJECTRESULTToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.SUBJECTRESULTToolStripMenuItem.Text = "SUBJECT RESULT"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(973, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(88, 33)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "TIME"
        '
        'Timer1
        '
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Our_ProjectWork.My.Resources.Resources.dpsschool
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 591)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT ASSESSMENT RECORDS APP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents REGISTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STAFFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STUDENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWRECORDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASSESSMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPDATERECORDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RESULTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTRESULTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GENERALRESULTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUBJECTRESULTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
