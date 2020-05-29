<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINVIEWRECORDS
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
        Me.btnVStaff = New System.Windows.Forms.Button()
        Me.btnVStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVStaff
        '
        Me.btnVStaff.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVStaff.Location = New System.Drawing.Point(100, 42)
        Me.btnVStaff.Name = "btnVStaff"
        Me.btnVStaff.Size = New System.Drawing.Size(206, 63)
        Me.btnVStaff.TabIndex = 0
        Me.btnVStaff.Text = "VIEW STAFF RECORDS"
        Me.btnVStaff.UseVisualStyleBackColor = True
        '
        'btnVStudent
        '
        Me.btnVStudent.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVStudent.Location = New System.Drawing.Point(100, 172)
        Me.btnVStudent.Name = "btnVStudent"
        Me.btnVStudent.Size = New System.Drawing.Size(206, 63)
        Me.btnVStudent.TabIndex = 0
        Me.btnVStudent.Text = "VIEW STUDENT RECORDS"
        Me.btnVStudent.UseVisualStyleBackColor = True
        '
        'ADMINVIEWRECORDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(366, 289)
        Me.Controls.Add(Me.btnVStudent)
        Me.Controls.Add(Me.btnVStaff)
        Me.Name = "ADMINVIEWRECORDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINVIEWRECORDS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVStaff As System.Windows.Forms.Button
    Friend WithEvents btnVStudent As System.Windows.Forms.Button
End Class
