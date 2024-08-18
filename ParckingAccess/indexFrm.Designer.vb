<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class indexFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox1 = New GroupBox()
        tbxMoto = New TextBox()
        tbxCar = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        btnValidTime = New Button()
        btnMoto = New Button()
        btnCar = New Button()
        Label2 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        GroupBox2 = New GroupBox()
        txtCoutCar = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        GroupBox3 = New GroupBox()
        Label10 = New Label()
        txtCoutMoto = New Label()
        PictureBox2 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(369, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 27)
        Label1.TabIndex = 0
        Label1.Text = "TicketAccess"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(GroupBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 0)
        TableLayoutPanel1.Location = New Point(12, 50)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(887, 430)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbxMoto)
        GroupBox1.Controls.Add(tbxCar)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnValidTime)
        GroupBox1.Controls.Add(btnMoto)
        GroupBox1.Controls.Add(btnCar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 424)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' tbxMoto
        ' 
        tbxMoto.Enabled = False
        tbxMoto.Font = New Font("Microsoft Sans Serif", 12.0F)
        tbxMoto.Location = New Point(262, 230)
        tbxMoto.Name = "tbxMoto"
        tbxMoto.PlaceholderText = "TK00"
        tbxMoto.Size = New Size(100, 26)
        tbxMoto.TabIndex = 7
        ' 
        ' tbxCar
        ' 
        tbxCar.Enabled = False
        tbxCar.Font = New Font("Microsoft Sans Serif", 12.0F)
        tbxCar.Location = New Point(262, 108)
        tbxCar.Name = "tbxCar"
        tbxCar.PlaceholderText = "TK00"
        tbxCar.Size = New Size(100, 26)
        tbxCar.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.0F)
        Label4.Location = New Point(218, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 30)
        Label4.TabIndex = 5
        Label4.Text = "="
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.0F)
        Label3.Location = New Point(218, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 30)
        Label3.TabIndex = 4
        Label3.Text = "="
        ' 
        ' btnValidTime
        ' 
        btnValidTime.Cursor = Cursors.Hand
        btnValidTime.Font = New Font("Lucida Sans", 12.0F, FontStyle.Bold)
        btnValidTime.Location = New Point(86, 319)
        btnValidTime.Name = "btnValidTime"
        btnValidTime.Size = New Size(276, 74)
        btnValidTime.TabIndex = 3
        btnValidTime.Text = "Validar Tiempo"
        btnValidTime.UseVisualStyleBackColor = True
        ' 
        ' btnMoto
        ' 
        btnMoto.Cursor = Cursors.Hand
        btnMoto.Font = New Font("Lucida Sans", 12.0F, FontStyle.Bold)
        btnMoto.Location = New Point(42, 192)
        btnMoto.Name = "btnMoto"
        btnMoto.Size = New Size(170, 99)
        btnMoto.TabIndex = 2
        btnMoto.Text = "Motocicleta"
        btnMoto.UseVisualStyleBackColor = True
        ' 
        ' btnCar
        ' 
        btnCar.Cursor = Cursors.Hand
        btnCar.Font = New Font("Lucida Sans", 12.0F, FontStyle.Bold)
        btnCar.Location = New Point(42, 68)
        btnCar.Name = "btnCar"
        btnCar.Size = New Size(170, 99)
        btnCar.TabIndex = 1
        btnCar.Text = "Automovil"
        btnCar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(132, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 22)
        Label2.TabIndex = 0
        Label2.Text = "Generar Ticket"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Controls.Add(GroupBox2, 0, 0)
        TableLayoutPanel2.Controls.Add(GroupBox3, 0, 1)
        TableLayoutPanel2.Location = New Point(446, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Size = New Size(438, 424)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtCoutCar)
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(3, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 206)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' txtCoutCar
        ' 
        txtCoutCar.AutoSize = True
        txtCoutCar.Font = New Font("Lucida Sans Typewriter", 15.75F)
        txtCoutCar.Location = New Point(205, 141)
        txtCoutCar.Name = "txtCoutCar"
        txtCoutCar.Size = New Size(36, 23)
        txtCoutCar.TabIndex = 3
        txtCoutCar.Text = "00"
        txtCoutCar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.car_icon
        PictureBox1.Location = New Point(174, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 77)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(72, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(313, 22)
        Label5.TabIndex = 1
        Label5.Text = "Estacionamientos Disponibles"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtCoutMoto)
        GroupBox3.Controls.Add(PictureBox2)
        GroupBox3.Location = New Point(3, 215)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(432, 206)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(72, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(313, 22)
        Label10.TabIndex = 7
        Label10.Text = "Estacionamientos Disponibles"
        ' 
        ' txtCoutMoto
        ' 
        txtCoutMoto.AutoSize = True
        txtCoutMoto.Font = New Font("Lucida Sans Typewriter", 15.75F)
        txtCoutMoto.Location = New Point(205, 155)
        txtCoutMoto.Name = "txtCoutMoto"
        txtCoutMoto.Size = New Size(36, 23)
        txtCoutMoto.TabIndex = 5
        txtCoutMoto.Text = "00"
        txtCoutMoto.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.moto_icon
        PictureBox2.Location = New Point(174, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(123, 77)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' indexFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(911, 498)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "indexFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TicketAccess"
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnValidTime As Button
    Friend WithEvents btnMoto As Button
    Friend WithEvents btnCar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxMoto As TextBox
    Friend WithEvents tbxCar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCoutCar As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCoutMoto As Label

End Class
