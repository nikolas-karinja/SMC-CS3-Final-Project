<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinalPrj
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSummation = New System.Windows.Forms.Button()
        Me.btnAge = New System.Windows.Forms.Button()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number (n):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Summation of numbers from 1 to (n):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter your birthdate (MM/DD/YYYY):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Your age is:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter a number less than 10 (n):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Average of random numbers generated:"
        '
        'btnSummation
        '
        Me.btnSummation.Location = New System.Drawing.Point(294, 43)
        Me.btnSummation.Name = "btnSummation"
        Me.btnSummation.Size = New System.Drawing.Size(100, 29)
        Me.btnSummation.TabIndex = 6
        Me.btnSummation.Text = "&Summation"
        Me.btnSummation.UseVisualStyleBackColor = True
        '
        'btnAge
        '
        Me.btnAge.Location = New System.Drawing.Point(294, 119)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(100, 29)
        Me.btnAge.TabIndex = 7
        Me.btnAge.Text = "&Age"
        Me.btnAge.UseVisualStyleBackColor = True
        '
        'btnAvg
        '
        Me.btnAvg.Location = New System.Drawing.Point(294, 197)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(100, 29)
        Me.btnAvg.TabIndex = 8
        Me.btnAvg.Text = "A&verage"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.Location = New System.Drawing.Point(294, 12)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 27)
        Me.txtNumber.TabIndex = 9
        '
        'txtBirthDate
        '
        Me.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthDate.Location = New System.Drawing.Point(294, 87)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(100, 27)
        Me.txtBirthDate.TabIndex = 10
        '
        'txtAvg
        '
        Me.txtAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg.Location = New System.Drawing.Point(294, 164)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(100, 27)
        Me.txtAvg.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(62, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFinalPrj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 304)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.btnAge)
        Me.Controls.Add(Me.btnSummation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFinalPrj"
        Me.Text = "Final Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSummation As Button
    Friend WithEvents btnAge As Button
    Friend WithEvents btnAvg As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
