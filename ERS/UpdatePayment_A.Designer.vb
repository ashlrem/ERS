<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePayment_A
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
        Me.SearchAddpayemt_btn = New System.Windows.Forms.Button()
        Me.sn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Payment_grp = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mid_btn = New System.Windows.Forms.Button()
        Me.pre_btn = New System.Windows.Forms.Button()
        Me.midterm = New System.Windows.Forms.Label()
        Me.prelim = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Payment_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchAddpayemt_btn
        '
        Me.SearchAddpayemt_btn.Location = New System.Drawing.Point(278, 15)
        Me.SearchAddpayemt_btn.Name = "SearchAddpayemt_btn"
        Me.SearchAddpayemt_btn.Size = New System.Drawing.Size(75, 23)
        Me.SearchAddpayemt_btn.TabIndex = 5
        Me.SearchAddpayemt_btn.Text = "Search"
        Me.SearchAddpayemt_btn.UseVisualStyleBackColor = True
        '
        'sn
        '
        Me.sn.Location = New System.Drawing.Point(142, 15)
        Me.sn.Name = "sn"
        Me.sn.Size = New System.Drawing.Size(130, 20)
        Me.sn.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Student Number:"
        '
        'Payment_grp
        '
        Me.Payment_grp.Controls.Add(Me.Label10)
        Me.Payment_grp.Controls.Add(Me.Label8)
        Me.Payment_grp.Controls.Add(Me.mid_btn)
        Me.Payment_grp.Controls.Add(Me.pre_btn)
        Me.Payment_grp.Controls.Add(Me.midterm)
        Me.Payment_grp.Controls.Add(Me.prelim)
        Me.Payment_grp.Enabled = False
        Me.Payment_grp.Location = New System.Drawing.Point(58, 68)
        Me.Payment_grp.Name = "Payment_grp"
        Me.Payment_grp.Size = New System.Drawing.Size(233, 89)
        Me.Payment_grp.TabIndex = 7
        Me.Payment_grp.TabStop = False
        Me.Payment_grp.Text = "Partial Payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "SecondPayment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "First Payment::"
        '
        'mid_btn
        '
        Me.mid_btn.Location = New System.Drawing.Point(152, 47)
        Me.mid_btn.Name = "mid_btn"
        Me.mid_btn.Size = New System.Drawing.Size(49, 23)
        Me.mid_btn.TabIndex = 2
        Me.mid_btn.Text = "Pay"
        Me.mid_btn.UseVisualStyleBackColor = True
        Me.mid_btn.Visible = False
        '
        'pre_btn
        '
        Me.pre_btn.Location = New System.Drawing.Point(152, 20)
        Me.pre_btn.Name = "pre_btn"
        Me.pre_btn.Size = New System.Drawing.Size(49, 23)
        Me.pre_btn.TabIndex = 2
        Me.pre_btn.Text = "Pay"
        Me.pre_btn.UseVisualStyleBackColor = True
        Me.pre_btn.Visible = False
        '
        'midterm
        '
        Me.midterm.AutoSize = True
        Me.midterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midterm.Location = New System.Drawing.Point(115, 52)
        Me.midterm.Name = "midterm"
        Me.midterm.Size = New System.Drawing.Size(14, 18)
        Me.midterm.TabIndex = 1
        Me.midterm.Text = "-"
        '
        'prelim
        '
        Me.prelim.AutoSize = True
        Me.prelim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prelim.Location = New System.Drawing.Point(115, 25)
        Me.prelim.Name = "prelim"
        Me.prelim.Size = New System.Drawing.Size(19, 18)
        Me.prelim.TabIndex = 1
        Me.prelim.Text = "- "
        '
        'grade
        '
        Me.grade.AutoSize = True
        Me.grade.Location = New System.Drawing.Point(139, 38)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(10, 13)
        Me.grade.TabIndex = 8
        Me.grade.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Grade Level:"
        '
        'UpdatePayment_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 178)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.Payment_grp)
        Me.Controls.Add(Me.SearchAddpayemt_btn)
        Me.Controls.Add(Me.sn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "UpdatePayment_A"
        Me.Text = "UpdatePayment_A"
        Me.Payment_grp.ResumeLayout(False)
        Me.Payment_grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchAddpayemt_btn As System.Windows.Forms.Button
    Friend WithEvents sn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Payment_grp As System.Windows.Forms.GroupBox
    Friend WithEvents mid_btn As System.Windows.Forms.Button
    Friend WithEvents pre_btn As System.Windows.Forms.Button
    Friend WithEvents midterm As System.Windows.Forms.Label
    Friend WithEvents prelim As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grade As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
