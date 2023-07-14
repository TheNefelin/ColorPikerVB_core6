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
        components = New ComponentModel.Container()
        btnStart = New Button()
        btnStop = New Button()
        pnlColor = New Panel()
        Label1 = New Label()
        txtlRojo = New TextBox()
        txtVerde = New TextBox()
        Label2 = New Label()
        txtAzul = New TextBox()
        Label3 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(12, 12)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(107, 45)
        btnStart.TabIndex = 0
        btnStart.Text = "Buscar Color"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(12, 63)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(107, 45)
        btnStop.TabIndex = 1
        btnStop.Text = "Detener"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' pnlColor
        ' 
        pnlColor.BackColor = Color.Black
        pnlColor.Location = New Point(125, 12)
        pnlColor.Name = "pnlColor"
        pnlColor.Size = New Size(195, 195)
        pnlColor.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 3
        Label1.Text = "Rojo"
        ' 
        ' txtlRojo
        ' 
        txtlRojo.Location = New Point(66, 114)
        txtlRojo.Name = "txtlRojo"
        txtlRojo.ReadOnly = True
        txtlRojo.Size = New Size(52, 27)
        txtlRojo.TabIndex = 4
        txtlRojo.Text = "0"
        txtlRojo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtVerde
        ' 
        txtVerde.Location = New Point(67, 147)
        txtVerde.Name = "txtVerde"
        txtVerde.ReadOnly = True
        txtVerde.Size = New Size(52, 27)
        txtVerde.TabIndex = 6
        txtVerde.Text = "0"
        txtVerde.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Verde"
        ' 
        ' txtAzul
        ' 
        txtAzul.Location = New Point(67, 180)
        txtAzul.Name = "txtAzul"
        txtAzul.ReadOnly = True
        txtAzul.Size = New Size(52, 27)
        txtAzul.TabIndex = 8
        txtAzul.Text = "0"
        txtAzul.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 7
        Label3.Text = "Azul"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(334, 221)
        Controls.Add(txtAzul)
        Controls.Add(Label3)
        Controls.Add(txtVerde)
        Controls.Add(Label2)
        Controls.Add(txtlRojo)
        Controls.Add(Label1)
        Controls.Add(pnlColor)
        Controls.Add(btnStop)
        Controls.Add(btnStart)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Selecciona tu Color y Wea"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents pnlColor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlRojo As TextBox
    Friend WithEvents txtVerde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAzul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
