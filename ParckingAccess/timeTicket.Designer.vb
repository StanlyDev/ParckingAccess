<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timeTicket
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        SplitContainer1 = New SplitContainer()
        ListView1 = New ListView()
        Label2 = New Label()
        ListView2 = New ListView()
        Label3 = New Label()
        Timer1 = New Timer(components)
        btnDelTK = New Button()
        tbxDelTK = New TextBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 16F, FontStyle.Bold)
        Label1.Location = New Point(148, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 25)
        Label1.TabIndex = 0
        Label1.Text = "Validacion de tiempo"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(12, 37)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ListView1)
        SplitContainer1.Panel1.Controls.Add(Label2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(ListView2)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Size = New Size(560, 462)
        SplitContainer1.SplitterDistance = 278
        SplitContainer1.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(3, 33)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(272, 426)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 12F)
        Label2.Location = New Point(85, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 18)
        Label2.TabIndex = 0
        Label2.Text = "Automoviles"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListView2
        ' 
        ListView2.Location = New Point(3, 33)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(272, 426)
        ListView2.TabIndex = 2
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 12F)
        Label3.Location = New Point(93, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 18)
        Label3.TabIndex = 1
        Label3.Text = "Motocicletas"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' btnDelTK
        ' 
        btnDelTK.Cursor = Cursors.Hand
        btnDelTK.Font = New Font("Lucida Sans", 12F)
        btnDelTK.Location = New Point(288, 507)
        btnDelTK.Name = "btnDelTK"
        btnDelTK.Size = New Size(130, 44)
        btnDelTK.TabIndex = 4
        btnDelTK.Text = "Eliminar Ticket"
        btnDelTK.UseVisualStyleBackColor = True
        ' 
        ' tbxDelTK
        ' 
        tbxDelTK.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDelTK.Location = New Point(182, 517)
        tbxDelTK.Name = "tbxDelTK"
        tbxDelTK.PlaceholderText = "TK00"
        tbxDelTK.Size = New Size(100, 26)
        tbxDelTK.TabIndex = 5
        ' 
        ' timeTicket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(584, 563)
        Controls.Add(tbxDelTK)
        Controls.Add(btnDelTK)
        Controls.Add(SplitContainer1)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "timeTicket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "timeTicket"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnDelTK As Button
    Friend WithEvents tbxDelTK As TextBox
End Class
