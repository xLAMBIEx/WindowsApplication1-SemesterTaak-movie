<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIN))
        Me.txtLogInPassword = New System.Windows.Forms.TextBox()
        Me.txtEmailLogIn = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLogInPassword
        '
        Me.txtLogInPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogInPassword.Location = New System.Drawing.Point(180, 58)
        Me.txtLogInPassword.Name = "txtLogInPassword"
        Me.txtLogInPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLogInPassword.Size = New System.Drawing.Size(252, 15)
        Me.txtLogInPassword.TabIndex = 0
        '
        'txtEmailLogIn
        '
        Me.txtEmailLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailLogIn.Location = New System.Drawing.Point(167, 20)
        Me.txtEmailLogIn.Name = "txtEmailLogIn"
        Me.txtEmailLogIn.Size = New System.Drawing.Size(153, 15)
        Me.txtEmailLogIn.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(92, 20)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(58, 17)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'BtnLogIn
        '
        Me.BtnLogIn.BackColor = System.Drawing.Color.White
        Me.BtnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogIn.Location = New System.Drawing.Point(78, 242)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(153, 57)
        Me.BtnLogIn.TabIndex = 4
        Me.BtnLogIn.Text = "Log in"
        Me.BtnLogIn.UseVisualStyleBackColor = False
        '
        'LogIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 534)
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtEmailLogIn)
        Me.Controls.Add(Me.txtLogInPassword)
        Me.Name = "LogIN"
        Me.Text = "LogIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogInPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailLogIn As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogIn As System.Windows.Forms.Button
End Class
