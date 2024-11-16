<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        ListView1 = New ListView()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        ComboBox4 = New ComboBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(27, 186)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(523, 217)
        ListView1.TabIndex = 16
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(232, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 29)
        Button1.TabIndex = 15
        Button1.Text = "Proses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 57)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(185, 23)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(80, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(185, 23)
        TextBox1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 9
        Label1.Text = "NIM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(281, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 19
        Label5.Text = "Jenis Kelamin"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(365, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(154, 23)
        ComboBox1.TabIndex = 20
        ComboBox1.Text = "Pilih Jenis Kelamin "
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"YNTKTS", "YTBSJTS"})
        ComboBox2.Location = New Point(365, 57)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(154, 23)
        ComboBox2.TabIndex = 22
        ComboBox2.Text = "Pilih Fakultas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(286, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 21
        Label6.Text = "Fakultas"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Teknik Industri", "Teknik Informatika", "Teknik Mesin"})
        ComboBox3.Location = New Point(80, 100)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(154, 23)
        ComboBox3.TabIndex = 24
        ComboBox3.Text = "Pilih Program Studi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 23
        Label4.Text = "Prodi"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        ComboBox4.Location = New Point(365, 97)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(154, 23)
        ComboBox4.TabIndex = 26
        ComboBox4.Text = "Pilih Semester"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(281, 100)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 25
        Label7.Text = "Semester"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(642, 501)
        Controls.Add(ComboBox4)
        Controls.Add(Label7)
        Controls.Add(ComboBox3)
        Controls.Add(Label4)
        Controls.Add(ComboBox2)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(ListView1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label7 As Label
End Class
