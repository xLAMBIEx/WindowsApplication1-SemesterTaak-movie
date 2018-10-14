<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NowShowing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NowShowing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbxMovies = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbxShowTime = New System.Windows.Forms.ListBox()
        Me.numTickets = New System.Windows.Forms.NumericUpDown()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.radCinema1 = New System.Windows.Forms.RadioButton()
        Me.radCinema2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.numTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbxMovies)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(75, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 614)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie Titles"
        '
        'lbxMovies
        '
        Me.lbxMovies.FormattingEnabled = True
        Me.lbxMovies.ItemHeight = 16
        Me.lbxMovies.Location = New System.Drawing.Point(22, 29)
        Me.lbxMovies.Name = "lbxMovies"
        Me.lbxMovies.Size = New System.Drawing.Size(331, 564)
        Me.lbxMovies.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(468, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 316)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 279)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(475, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 204)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(920, 659)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lbxShowTime)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(824, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 613)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Show Times"
        '
        'lbxShowTime
        '
        Me.lbxShowTime.FormattingEnabled = True
        Me.lbxShowTime.ItemHeight = 16
        Me.lbxShowTime.Location = New System.Drawing.Point(20, 29)
        Me.lbxShowTime.Name = "lbxShowTime"
        Me.lbxShowTime.Size = New System.Drawing.Size(255, 564)
        Me.lbxShowTime.TabIndex = 0
        '
        'numTickets
        '
        Me.numTickets.Location = New System.Drawing.Point(1013, 659)
        Me.numTickets.Name = "numTickets"
        Me.numTickets.Size = New System.Drawing.Size(86, 22)
        Me.numTickets.TabIndex = 4
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(953, 697)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(146, 47)
        Me.btnBook.TabIndex = 5
        Me.btnBook.Text = "Book Now"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'radCinema1
        '
        Me.radCinema1.AutoSize = True
        Me.radCinema1.Location = New System.Drawing.Point(699, 670)
        Me.radCinema1.Name = "radCinema1"
        Me.radCinema1.Size = New System.Drawing.Size(91, 21)
        Me.radCinema1.TabIndex = 6
        Me.radCinema1.TabStop = True
        Me.radCinema1.Text = "Cinema1"
        Me.radCinema1.UseVisualStyleBackColor = True
        '
        'radCinema2
        '
        Me.radCinema2.AutoSize = True
        Me.radCinema2.Location = New System.Drawing.Point(699, 697)
        Me.radCinema2.Name = "radCinema2"
        Me.radCinema2.Size = New System.Drawing.Size(91, 21)
        Me.radCinema2.TabIndex = 7
        Me.radCinema2.TabStop = True
        Me.radCinema2.Text = "Cinema2"
        Me.radCinema2.UseVisualStyleBackColor = True
        '
        'NowShowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1194, 756)
        Me.Controls.Add(Me.radCinema2)
        Me.Controls.Add(Me.radCinema1)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numTickets)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "NowShowing"
        Me.Text = "NowShowing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.numTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxMovies As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxShowTime As System.Windows.Forms.ListBox
    Friend WithEvents numTickets As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBook As System.Windows.Forms.Button
    Friend WithEvents radCinema1 As System.Windows.Forms.RadioButton
    Friend WithEvents radCinema2 As System.Windows.Forms.RadioButton
End Class
