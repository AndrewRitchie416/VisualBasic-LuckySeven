<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBox1 = New System.Windows.Forms.Label()
        Me.lblBox2 = New System.Windows.Forms.Label()
        Me.lblBox3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSuperSpin = New System.Windows.Forms.Button()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(80, 146)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(111, 53)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(80, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 60)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBox1
        '
        Me.lblBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBox1.Location = New System.Drawing.Point(253, 119)
        Me.lblBox1.Name = "lblBox1"
        Me.lblBox1.Size = New System.Drawing.Size(74, 100)
        Me.lblBox1.TabIndex = 2
        Me.lblBox1.Text = "0"
        Me.lblBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBox2
        '
        Me.lblBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBox2.Location = New System.Drawing.Point(357, 119)
        Me.lblBox2.Name = "lblBox2"
        Me.lblBox2.Size = New System.Drawing.Size(74, 100)
        Me.lblBox2.TabIndex = 3
        Me.lblBox2.Text = "0"
        Me.lblBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBox3
        '
        Me.lblBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBox3.Location = New System.Drawing.Point(448, 119)
        Me.lblBox3.Name = "lblBox3"
        Me.lblBox3.Size = New System.Drawing.Size(74, 100)
        Me.lblBox3.TabIndex = 4
        Me.lblBox3.Text = "0"
        Me.lblBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(266, 241)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(256, 49)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Lucky Seven"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBox1
        '
        Me.picBox1.Image = CType(resources.GetObject("picBox1.Image"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(266, 293)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(290, 176)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 6
        Me.picBox1.TabStop = False
        '
        'btnSuperSpin
        '
        Me.btnSuperSpin.Location = New System.Drawing.Point(80, 225)
        Me.btnSuperSpin.Name = "btnSuperSpin"
        Me.btnSuperSpin.Size = New System.Drawing.Size(111, 46)
        Me.btnSuperSpin.TabIndex = 7
        Me.btnSuperSpin.Text = "Super Spin"
        Me.btnSuperSpin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 499)
        Me.Controls.Add(Me.btnSuperSpin)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblBox3)
        Me.Controls.Add(Me.lblBox2)
        Me.Controls.Add(Me.lblBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblBox1 As Label
    Friend WithEvents lblBox2 As Label
    Friend WithEvents lblBox3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents btnSuperSpin As Button
End Class
