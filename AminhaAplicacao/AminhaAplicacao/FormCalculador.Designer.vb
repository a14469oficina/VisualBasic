<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculador
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
        Me.botFechar = New System.Windows.Forms.Button()
        Me.botDivisao = New System.Windows.Forms.Button()
        Me.botApagar = New System.Windows.Forms.Button()
        Me.botMultiplicar = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.botSubtrair = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.botSomar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.botCalcular = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.botDecimal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.botInverterSinal = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextFinal = New System.Windows.Forms.TextBox()
        Me.Textexpressao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'botFechar
        '
        Me.botFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botFechar.Location = New System.Drawing.Point(12, 369)
        Me.botFechar.Name = "botFechar"
        Me.botFechar.Size = New System.Drawing.Size(305, 89)
        Me.botFechar.TabIndex = 0
        Me.botFechar.Text = "Fechar Calculadora"
        Me.botFechar.UseVisualStyleBackColor = True
        '
        'botDivisao
        '
        Me.botDivisao.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botDivisao.Location = New System.Drawing.Point(167, 100)
        Me.botDivisao.Name = "botDivisao"
        Me.botDivisao.Size = New System.Drawing.Size(59, 46)
        Me.botDivisao.TabIndex = 2
        Me.botDivisao.Text = "/"
        Me.botDivisao.UseVisualStyleBackColor = False
        '
        'botApagar
        '
        Me.botApagar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botApagar.Location = New System.Drawing.Point(102, 100)
        Me.botApagar.Name = "botApagar"
        Me.botApagar.Size = New System.Drawing.Size(59, 46)
        Me.botApagar.TabIndex = 18
        Me.botApagar.Text = "<=|"
        Me.botApagar.UseVisualStyleBackColor = False
        '
        'botMultiplicar
        '
        Me.botMultiplicar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botMultiplicar.Location = New System.Drawing.Point(232, 100)
        Me.botMultiplicar.Name = "botMultiplicar"
        Me.botMultiplicar.Size = New System.Drawing.Size(59, 46)
        Me.botMultiplicar.TabIndex = 17
        Me.botMultiplicar.Text = "*"
        Me.botMultiplicar.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button9.Location = New System.Drawing.Point(167, 152)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(59, 46)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'botSubtrair
        '
        Me.botSubtrair.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botSubtrair.Location = New System.Drawing.Point(232, 152)
        Me.botSubtrair.Name = "botSubtrair"
        Me.botSubtrair.Size = New System.Drawing.Size(59, 46)
        Me.botSubtrair.TabIndex = 15
        Me.botSubtrair.Text = "-"
        Me.botSubtrair.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(167, 204)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(59, 46)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'botSomar
        '
        Me.botSomar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botSomar.Location = New System.Drawing.Point(232, 204)
        Me.botSomar.Name = "botSomar"
        Me.botSomar.Size = New System.Drawing.Size(59, 46)
        Me.botSomar.TabIndex = 13
        Me.botSomar.Text = "+"
        Me.botSomar.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(37, 152)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(59, 46)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(167, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 46)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(37, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 46)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'botLimpar
        '
        Me.botLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botLimpar.Location = New System.Drawing.Point(37, 100)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(59, 46)
        Me.botLimpar.TabIndex = 9
        Me.botLimpar.Text = "C"
        Me.botLimpar.UseVisualStyleBackColor = False
        '
        'botCalcular
        '
        Me.botCalcular.BackColor = System.Drawing.SystemColors.Highlight
        Me.botCalcular.Location = New System.Drawing.Point(232, 256)
        Me.botCalcular.Name = "botCalcular"
        Me.botCalcular.Size = New System.Drawing.Size(59, 98)
        Me.botCalcular.TabIndex = 8
        Me.botCalcular.Text = "="
        Me.botCalcular.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(102, 152)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(59, 46)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(37, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(102, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 46)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'botDecimal
        '
        Me.botDecimal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botDecimal.Location = New System.Drawing.Point(167, 308)
        Me.botDecimal.Name = "botDecimal"
        Me.botDecimal.Size = New System.Drawing.Size(59, 46)
        Me.botDecimal.TabIndex = 4
        Me.botDecimal.Text = ","
        Me.botDecimal.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(102, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'botInverterSinal
        '
        Me.botInverterSinal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botInverterSinal.Location = New System.Drawing.Point(37, 308)
        Me.botInverterSinal.Name = "botInverterSinal"
        Me.botInverterSinal.Size = New System.Drawing.Size(59, 46)
        Me.botInverterSinal.TabIndex = 10
        Me.botInverterSinal.Text = "+/-"
        Me.botInverterSinal.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button0.Location = New System.Drawing.Point(102, 308)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(59, 46)
        Me.Button0.TabIndex = 20
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(305, 351)
        Me.TextBox1.TabIndex = 21
        '
        'TextFinal
        '
        Me.TextFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFinal.Location = New System.Drawing.Point(37, 49)
        Me.TextFinal.Multiline = True
        Me.TextFinal.Name = "TextFinal"
        Me.TextFinal.Size = New System.Drawing.Size(254, 45)
        Me.TextFinal.TabIndex = 22
        Me.TextFinal.Text = "0"
        Me.TextFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Textexpressao
        '
        Me.Textexpressao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textexpressao.Location = New System.Drawing.Point(37, 23)
        Me.Textexpressao.Multiline = True
        Me.Textexpressao.Name = "Textexpressao"
        Me.Textexpressao.Size = New System.Drawing.Size(254, 20)
        Me.Textexpressao.TabIndex = 23
        Me.Textexpressao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormCalculador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 466)
        Me.Controls.Add(Me.Textexpressao)
        Me.Controls.Add(Me.TextFinal)
        Me.Controls.Add(Me.botDivisao)
        Me.Controls.Add(Me.botApagar)
        Me.Controls.Add(Me.botMultiplicar)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.botSubtrair)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.botSomar)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.botLimpar)
        Me.Controls.Add(Me.botCalcular)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.botDecimal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.botInverterSinal)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.botFechar)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FormCalculador"
        Me.Text = "FormCalculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botFechar As Button
    Friend WithEvents botDivisao As Button
    Friend WithEvents botApagar As Button
    Friend WithEvents botMultiplicar As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents botSubtrair As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents botSomar As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents botLimpar As Button
    Friend WithEvents botCalcular As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents botDecimal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents botInverterSinal As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextFinal As TextBox
    Friend WithEvents Textexpressao As TextBox
End Class
