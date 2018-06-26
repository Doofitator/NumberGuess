<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_numberGuess
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
        Me.btn_main = New System.Windows.Forms.Button()
        Me.btn_higher = New System.Windows.Forms.Button()
        Me.btn_lower = New System.Windows.Forms.Button()
        Me.lbl_display = New System.Windows.Forms.Label()
        Me.lbl_hint = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_main
        '
        Me.btn_main.Location = New System.Drawing.Point(166, 125)
        Me.btn_main.Name = "btn_main"
        Me.btn_main.Size = New System.Drawing.Size(75, 56)
        Me.btn_main.TabIndex = 0
        Me.btn_main.Text = "Start"
        Me.btn_main.UseVisualStyleBackColor = True
        '
        'btn_higher
        '
        Me.btn_higher.Enabled = False
        Me.btn_higher.Location = New System.Drawing.Point(12, 125)
        Me.btn_higher.Name = "btn_higher"
        Me.btn_higher.Size = New System.Drawing.Size(75, 23)
        Me.btn_higher.TabIndex = 1
        Me.btn_higher.Text = "Higher"
        Me.btn_higher.UseVisualStyleBackColor = True
        '
        'btn_lower
        '
        Me.btn_lower.Enabled = False
        Me.btn_lower.Location = New System.Drawing.Point(12, 158)
        Me.btn_lower.Name = "btn_lower"
        Me.btn_lower.Size = New System.Drawing.Size(75, 23)
        Me.btn_lower.TabIndex = 2
        Me.btn_lower.Text = "Lower"
        Me.btn_lower.UseVisualStyleBackColor = True
        '
        'lbl_display
        '
        Me.lbl_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display.Location = New System.Drawing.Point(12, 58)
        Me.lbl_display.Name = "lbl_display"
        Me.lbl_display.Size = New System.Drawing.Size(229, 33)
        Me.lbl_display.TabIndex = 3
        Me.lbl_display.Text = "0"
        Me.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_hint
        '
        Me.lbl_hint.Location = New System.Drawing.Point(9, 9)
        Me.lbl_hint.Name = "lbl_hint"
        Me.lbl_hint.Size = New System.Drawing.Size(232, 19)
        Me.lbl_hint.TabIndex = 4
        Me.lbl_hint.Text = "Think of a number between 1 and 100"
        Me.lbl_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_numberGuess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 193)
        Me.Controls.Add(Me.lbl_hint)
        Me.Controls.Add(Me.lbl_display)
        Me.Controls.Add(Me.btn_lower)
        Me.Controls.Add(Me.btn_higher)
        Me.Controls.Add(Me.btn_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_numberGuess"
        Me.Text = "Number Guesser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_main As Button
    Friend WithEvents btn_higher As Button
    Friend WithEvents btn_lower As Button
    Friend WithEvents lbl_display As Label
    Friend WithEvents lbl_hint As Label
End Class
