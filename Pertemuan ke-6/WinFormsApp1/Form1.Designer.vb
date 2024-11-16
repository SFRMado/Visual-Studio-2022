<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnProsesGaji = New Button()
        btnClear = New Button()
        btnExit = New Button()
        txtNIP = New TextBox()
        txtPotongan = New TextBox()
        txtGajiBersih = New TextBox()
        txtGajiKotor = New TextBox()
        txtNama = New TextBox()
        cbJabatan = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 25)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(94, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(94, 321)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 25)
        Label3.TabIndex = 1
        Label3.Text = "Clean Gaji"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(94, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 25)
        Label4.TabIndex = 2
        Label4.Text = "Potongan (pph 2%)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(94, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 3
        Label5.Text = "Dirty Gaji"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(94, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 25)
        Label6.TabIndex = 4
        Label6.Text = "Jabatan"
        ' 
        ' btnProsesGaji
        ' 
        btnProsesGaji.Location = New Point(137, 424)
        btnProsesGaji.Name = "btnProsesGaji"
        btnProsesGaji.Size = New Size(112, 34)
        btnProsesGaji.TabIndex = 5
        btnProsesGaji.Text = "Proses Gaji"
        btnProsesGaji.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(266, 424)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(77, 34)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(362, 424)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(66, 34)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(192, 42)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(323, 31)
        txtNIP.TabIndex = 8
        ' 
        ' txtPotongan
        ' 
        txtPotongan.Location = New Point(266, 256)
        txtPotongan.Name = "txtPotongan"
        txtPotongan.Size = New Size(323, 31)
        txtPotongan.TabIndex = 9
        ' 
        ' txtGajiBersih
        ' 
        txtGajiBersih.Location = New Point(192, 321)
        txtGajiBersih.Name = "txtGajiBersih"
        txtGajiBersih.Size = New Size(323, 31)
        txtGajiBersih.TabIndex = 10
        ' 
        ' txtGajiKotor
        ' 
        txtGajiKotor.Location = New Point(192, 196)
        txtGajiKotor.Name = "txtGajiKotor"
        txtGajiKotor.Size = New Size(323, 31)
        txtGajiKotor.TabIndex = 12
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(192, 89)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(323, 31)
        txtNama.TabIndex = 13
        ' 
        ' cbJabatan
        ' 
        cbJabatan.FormattingEnabled = True
        cbJabatan.Location = New Point(192, 144)
        cbJabatan.Name = "cbJabatan"
        cbJabatan.Size = New Size(323, 33)
        cbJabatan.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(896, 615)
        Controls.Add(cbJabatan)
        Controls.Add(txtNama)
        Controls.Add(txtGajiKotor)
        Controls.Add(txtGajiBersih)
        Controls.Add(txtPotongan)
        Controls.Add(txtNIP)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnProsesGaji)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProsesGaji As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtPotongan As TextBox
    Friend WithEvents txtGajiBersih As TextBox
    Friend WithEvents txtGajiKotor As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbJabatan As ComboBox

End Class
