<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIMC
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextIMC = New System.Windows.Forms.TextBox()
        Me.textAltura = New System.Windows.Forms.TextBox()
        Me.textPeso = New System.Windows.Forms.TextBox()
        Me.botCalcularIMC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(19, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fechar IMC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calcular IMC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PESO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ALTURA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "IMC"
        '
        'TextIMC
        '
        Me.TextIMC.Location = New System.Drawing.Point(154, 214)
        Me.TextIMC.Multiline = True
        Me.TextIMC.Name = "TextIMC"
        Me.TextIMC.ReadOnly = True
        Me.TextIMC.Size = New System.Drawing.Size(127, 33)
        Me.TextIMC.TabIndex = 5
        '
        'textAltura
        '
        Me.textAltura.Location = New System.Drawing.Point(154, 130)
        Me.textAltura.Multiline = True
        Me.textAltura.Name = "textAltura"
        Me.textAltura.Size = New System.Drawing.Size(127, 33)
        Me.textAltura.TabIndex = 6
        '
        'textPeso
        '
        Me.textPeso.Location = New System.Drawing.Point(154, 67)
        Me.textPeso.Multiline = True
        Me.textPeso.Name = "textPeso"
        Me.textPeso.Size = New System.Drawing.Size(127, 33)
        Me.textPeso.TabIndex = 7
        '
        'botCalcularIMC
        '
        Me.botCalcularIMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botCalcularIMC.Location = New System.Drawing.Point(154, 170)
        Me.botCalcularIMC.Name = "botCalcularIMC"
        Me.botCalcularIMC.Size = New System.Drawing.Size(127, 38)
        Me.botCalcularIMC.TabIndex = 8
        Me.botCalcularIMC.Text = "Calcular IMC"
        Me.botCalcularIMC.UseVisualStyleBackColor = True
        '
        'FormIMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 357)
        Me.Controls.Add(Me.botCalcularIMC)
        Me.Controls.Add(Me.textPeso)
        Me.Controls.Add(Me.textAltura)
        Me.Controls.Add(Me.TextIMC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormIMC"
        Me.Text = "FormIMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextIMC As TextBox
    Friend WithEvents textAltura As TextBox
    Friend WithEvents textPeso As TextBox
    Friend WithEvents botCalcularIMC As Button
End Class
