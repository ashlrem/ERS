<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteSubj_R
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteSubj_btn = New System.Windows.Forms.Button()
        Me.gl = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchSubj_btn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteSubj_btn)
        Me.GroupBox2.Controls.Add(Me.gl)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(16, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 116)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Information"
        '
        'DeleteSubj_btn
        '
        Me.DeleteSubj_btn.Location = New System.Drawing.Point(239, 75)
        Me.DeleteSubj_btn.Name = "DeleteSubj_btn"
        Me.DeleteSubj_btn.Size = New System.Drawing.Size(159, 27)
        Me.DeleteSubj_btn.TabIndex = 6
        Me.DeleteSubj_btn.Text = "Delete Subject"
        Me.DeleteSubj_btn.UseVisualStyleBackColor = True
        '
        'gl
        '
        Me.gl.Location = New System.Drawing.Point(115, 32)
        Me.gl.Name = "gl"
        Me.gl.Size = New System.Drawing.Size(170, 20)
        Me.gl.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Grade_Level"
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(87, 29)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(170, 20)
        Me.sec.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter Section"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchSubj_btn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.sec)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 81)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Subject"
        '
        'SearchSubj_btn
        '
        Me.SearchSubj_btn.Location = New System.Drawing.Point(262, 31)
        Me.SearchSubj_btn.Name = "SearchSubj_btn"
        Me.SearchSubj_btn.Size = New System.Drawing.Size(75, 23)
        Me.SearchSubj_btn.TabIndex = 2
        Me.SearchSubj_btn.Text = "Search"
        Me.SearchSubj_btn.UseVisualStyleBackColor = True
        '
        'DeleteSubj_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 243)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DeleteSubj_R"
        Me.Text = "DeleteSubj_R"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteSubj_btn As System.Windows.Forms.Button
    Friend WithEvents sec As System.Windows.Forms.TextBox
    Friend WithEvents gl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchSubj_btn As System.Windows.Forms.Button
End Class
