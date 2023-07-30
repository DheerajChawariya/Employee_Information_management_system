<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Label6 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.Lock_image
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(460, 296)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 40)
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.user_icon
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(457, 213)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(56, 40)
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel2.Location = New Point(640, 544)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(168, 28)
        LinkLabel2.TabIndex = 23
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forget password"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(618, 489)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(202, 28)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create new Account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Comapny_logo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(44, 157)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(340, 272)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.Lime
        Button2.FlatAppearance.BorderSize = 5
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(767, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 73)
        Button2.TabIndex = 21
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(172, 472)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 31)
        Label6.TabIndex = 13
        Label6.Text = "Tagline"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.Lime
        Button1.FlatAppearance.BorderSize = 5
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(519, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 73)
        Button1.TabIndex = 20
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(565, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(211, 31)
        Label4.TabIndex = 19
        Label4.Text = "Admin Login page"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(667, 297)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(334, 27)
        TextBox2.TabIndex = 18
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(667, 217)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(334, 27)
        TextBox1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(519, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 15
        Label2.Text = "Username"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(-42, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 667)
        Panel2.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(140, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 31)
        Label5.TabIndex = 12
        Label5.Text = "Company Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(36, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(577, 38)
        Label1.TabIndex = 0
        Label1.Text = "Employee information mangement system"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-34, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1287, 40)
        Panel1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(519, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 16
        Label3.Text = "Password"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1185, 701)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label


End Class
