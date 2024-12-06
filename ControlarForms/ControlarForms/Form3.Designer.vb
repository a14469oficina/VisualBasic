<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valor1 = New System.Windows.Forms.TextBox()
        Me.valor2 = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Somar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Num2"
        '
        'valor1
        '
        Me.valor1.Location = New System.Drawing.Point(288, 13)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(100, 20)
        Me.valor1.TabIndex = 3
        '
        'valor2
        '
        Me.valor2.Location = New System.Drawing.Point(288, 39)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(100, 20)
        Me.valor2.TabIndex = 4
        '
        'resultado
        '
        Me.resultado.Enabled = False
        Me.resultado.Location = New System.Drawing.Point(288, 65)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(100, 20)
        Me.resultado.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Fechar Janela"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 284)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valor1 As TextBox
    Friend WithEvents valor2 As TextBox
    Friend WithEvents resultado As TextBox
    Friend WithEvents Button2 As Button
End Class
