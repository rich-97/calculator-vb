<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEq = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnAns = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnDEL = New System.Windows.Forms.Button()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnGroup2 = New System.Windows.Forms.Button()
        Me.btnGroup1 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnCbrt = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.btnPowM = New System.Windows.Forms.Button()
        Me.btnPow3 = New System.Windows.Forms.Button()
        Me.btnPow2 = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnLn = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblOutput.Location = New System.Drawing.Point(0, 50)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(318, 50)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "0."
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblInput
        '
        Me.lblInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblInput.Location = New System.Drawing.Point(0, 0)
        Me.lblInput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(318, 50)
        Me.lblInput.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblInput)
        Me.Panel1.Controls.Add(Me.lblOutput)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEq)
        Me.Panel2.Controls.Add(Me.btnDot)
        Me.Panel2.Controls.Add(Me.btnExp)
        Me.Panel2.Controls.Add(Me.btnAns)
        Me.Panel2.Controls.Add(Me.btnPlus)
        Me.Panel2.Controls.Add(Me.btnMinus)
        Me.Panel2.Controls.Add(Me.btn1)
        Me.Panel2.Controls.Add(Me.btn0)
        Me.Panel2.Controls.Add(Me.btnDiv)
        Me.Panel2.Controls.Add(Me.btnMultiply)
        Me.Panel2.Controls.Add(Me.btn3)
        Me.Panel2.Controls.Add(Me.btn2)
        Me.Panel2.Controls.Add(Me.btnDEL)
        Me.Panel2.Controls.Add(Me.btnAC)
        Me.Panel2.Controls.Add(Me.btn5)
        Me.Panel2.Controls.Add(Me.btn4)
        Me.Panel2.Controls.Add(Me.btnGroup2)
        Me.Panel2.Controls.Add(Me.btnGroup1)
        Me.Panel2.Controls.Add(Me.btn7)
        Me.Panel2.Controls.Add(Me.btn6)
        Me.Panel2.Controls.Add(Me.btnCbrt)
        Me.Panel2.Controls.Add(Me.btnSqrt)
        Me.Panel2.Controls.Add(Me.btn9)
        Me.Panel2.Controls.Add(Me.btn8)
        Me.Panel2.Controls.Add(Me.btnPercentage)
        Me.Panel2.Controls.Add(Me.btnPowM)
        Me.Panel2.Controls.Add(Me.btnPow3)
        Me.Panel2.Controls.Add(Me.btnPow2)
        Me.Panel2.Controls.Add(Me.btnPi)
        Me.Panel2.Controls.Add(Me.btnTan)
        Me.Panel2.Controls.Add(Me.btnCos)
        Me.Panel2.Controls.Add(Me.btnSin)
        Me.Panel2.Controls.Add(Me.btnE)
        Me.Panel2.Controls.Add(Me.btnLn)
        Me.Panel2.Controls.Add(Me.btnLog)
        Me.Panel2.Controls.Add(Me.btnFactorial)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Panel2.Location = New System.Drawing.Point(15, 127)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 370)
        Me.Panel2.TabIndex = 2
        '
        'btnEq
        '
        Me.btnEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnEq.Location = New System.Drawing.Point(243, 328)
        Me.btnEq.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnEq.Name = "btnEq"
        Me.btnEq.Size = New System.Drawing.Size(68, 33)
        Me.btnEq.TabIndex = 35
        Me.btnEq.Text = "="
        Me.btnEq.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDot.Location = New System.Drawing.Point(162, 328)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(68, 33)
        Me.btnDot.TabIndex = 34
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnExp.Location = New System.Drawing.Point(0, 328)
        Me.btnExp.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(68, 33)
        Me.btnExp.TabIndex = 32
        Me.btnExp.Text = "EXP"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnAns
        '
        Me.btnAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnAns.Location = New System.Drawing.Point(78, 328)
        Me.btnAns.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnAns.Name = "btnAns"
        Me.btnAns.Size = New System.Drawing.Size(68, 33)
        Me.btnAns.TabIndex = 33
        Me.btnAns.Text = "Ans"
        Me.btnAns.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPlus.Location = New System.Drawing.Point(243, 287)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(68, 33)
        Me.btnPlus.TabIndex = 31
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnMinus.Location = New System.Drawing.Point(162, 287)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(68, 33)
        Me.btnMinus.TabIndex = 30
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn1.Location = New System.Drawing.Point(78, 287)
        Me.btn1.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(68, 33)
        Me.btn1.TabIndex = 29
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn0.Location = New System.Drawing.Point(0, 287)
        Me.btn0.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(68, 33)
        Me.btn0.TabIndex = 28
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDiv.Location = New System.Drawing.Point(243, 246)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(68, 33)
        Me.btnDiv.TabIndex = 27
        Me.btnDiv.Text = "÷"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnMultiply.Location = New System.Drawing.Point(162, 246)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(68, 33)
        Me.btnMultiply.TabIndex = 26
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn3.Location = New System.Drawing.Point(78, 246)
        Me.btn3.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(68, 33)
        Me.btn3.TabIndex = 25
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn2.Location = New System.Drawing.Point(0, 246)
        Me.btn2.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(68, 33)
        Me.btn2.TabIndex = 24
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnDEL
        '
        Me.btnDEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDEL.Location = New System.Drawing.Point(243, 205)
        Me.btnDEL.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnDEL.Name = "btnDEL"
        Me.btnDEL.Size = New System.Drawing.Size(68, 33)
        Me.btnDEL.TabIndex = 23
        Me.btnDEL.Text = "DEL"
        Me.btnDEL.UseVisualStyleBackColor = True
        '
        'btnAC
        '
        Me.btnAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnAC.Location = New System.Drawing.Point(162, 205)
        Me.btnAC.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(68, 33)
        Me.btnAC.TabIndex = 22
        Me.btnAC.Text = "AC"
        Me.btnAC.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn5.Location = New System.Drawing.Point(78, 205)
        Me.btn5.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(68, 33)
        Me.btn5.TabIndex = 21
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn4.Location = New System.Drawing.Point(0, 205)
        Me.btn4.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(68, 33)
        Me.btn4.TabIndex = 20
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnGroup2
        '
        Me.btnGroup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGroup2.Location = New System.Drawing.Point(243, 164)
        Me.btnGroup2.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnGroup2.Name = "btnGroup2"
        Me.btnGroup2.Size = New System.Drawing.Size(68, 33)
        Me.btnGroup2.TabIndex = 19
        Me.btnGroup2.Text = ")"
        Me.btnGroup2.UseVisualStyleBackColor = True
        '
        'btnGroup1
        '
        Me.btnGroup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGroup1.Location = New System.Drawing.Point(162, 164)
        Me.btnGroup1.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnGroup1.Name = "btnGroup1"
        Me.btnGroup1.Size = New System.Drawing.Size(68, 33)
        Me.btnGroup1.TabIndex = 18
        Me.btnGroup1.Text = "("
        Me.btnGroup1.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn7.Location = New System.Drawing.Point(78, 164)
        Me.btn7.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(68, 33)
        Me.btn7.TabIndex = 17
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn6.Location = New System.Drawing.Point(0, 164)
        Me.btn6.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(68, 33)
        Me.btn6.TabIndex = 16
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnCbrt
        '
        Me.btnCbrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnCbrt.Location = New System.Drawing.Point(243, 123)
        Me.btnCbrt.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnCbrt.Name = "btnCbrt"
        Me.btnCbrt.Size = New System.Drawing.Size(68, 33)
        Me.btnCbrt.TabIndex = 15
        Me.btnCbrt.Text = "3√"
        Me.btnCbrt.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnSqrt.Location = New System.Drawing.Point(162, 123)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(68, 33)
        Me.btnSqrt.TabIndex = 14
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn9.Location = New System.Drawing.Point(78, 123)
        Me.btn9.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(68, 33)
        Me.btn9.TabIndex = 13
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn8.Location = New System.Drawing.Point(0, 123)
        Me.btn8.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(68, 33)
        Me.btn8.TabIndex = 12
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btnPercentage
        '
        Me.btnPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPercentage.Location = New System.Drawing.Point(243, 82)
        Me.btnPercentage.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(68, 33)
        Me.btnPercentage.TabIndex = 11
        Me.btnPercentage.Text = "%"
        Me.btnPercentage.UseVisualStyleBackColor = True
        '
        'btnPowM
        '
        Me.btnPowM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPowM.Location = New System.Drawing.Point(162, 82)
        Me.btnPowM.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPowM.Name = "btnPowM"
        Me.btnPowM.Size = New System.Drawing.Size(68, 33)
        Me.btnPowM.TabIndex = 10
        Me.btnPowM.Text = "xᵐ"
        Me.btnPowM.UseVisualStyleBackColor = True
        '
        'btnPow3
        '
        Me.btnPow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPow3.Location = New System.Drawing.Point(78, 82)
        Me.btnPow3.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPow3.Name = "btnPow3"
        Me.btnPow3.Size = New System.Drawing.Size(68, 33)
        Me.btnPow3.TabIndex = 9
        Me.btnPow3.Text = "x³"
        Me.btnPow3.UseVisualStyleBackColor = True
        '
        'btnPow2
        '
        Me.btnPow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPow2.Location = New System.Drawing.Point(0, 82)
        Me.btnPow2.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPow2.Name = "btnPow2"
        Me.btnPow2.Size = New System.Drawing.Size(68, 33)
        Me.btnPow2.TabIndex = 8
        Me.btnPow2.Text = "x²"
        Me.btnPow2.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPi.Location = New System.Drawing.Point(243, 41)
        Me.btnPi.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(68, 33)
        Me.btnPi.TabIndex = 7
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTan.Location = New System.Drawing.Point(162, 41)
        Me.btnTan.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(68, 33)
        Me.btnTan.TabIndex = 6
        Me.btnTan.Text = "tan"
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnCos.Location = New System.Drawing.Point(78, 41)
        Me.btnCos.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(68, 33)
        Me.btnCos.TabIndex = 5
        Me.btnCos.Text = "cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnSin.Location = New System.Drawing.Point(0, 41)
        Me.btnSin.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(68, 33)
        Me.btnSin.TabIndex = 4
        Me.btnSin.Text = "sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnE.Location = New System.Drawing.Point(243, 0)
        Me.btnE.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(68, 33)
        Me.btnE.TabIndex = 3
        Me.btnE.Text = "e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnLn
        '
        Me.btnLn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLn.Location = New System.Drawing.Point(162, 0)
        Me.btnLn.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnLn.Name = "btnLn"
        Me.btnLn.Size = New System.Drawing.Size(68, 33)
        Me.btnLn.TabIndex = 2
        Me.btnLn.Text = "ln"
        Me.btnLn.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLog.Location = New System.Drawing.Point(78, 0)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(68, 33)
        Me.btnLog.TabIndex = 1
        Me.btnLog.Text = "log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnFactorial.Location = New System.Drawing.Point(0, 0)
        Me.btnFactorial.Margin = New System.Windows.Forms.Padding(6, 4, 10, 4)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(68, 33)
        Me.btnFactorial.TabIndex = 0
        Me.btnFactorial.Text = "x!"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnEq As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnAns As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnDEL As Button
    Friend WithEvents btnAC As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnGroup2 As Button
    Friend WithEvents btnGroup1 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnCbrt As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btnPercentage As Button
    Friend WithEvents btnPowM As Button
    Friend WithEvents btnPow3 As Button
    Friend WithEvents btnPow2 As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents btnTan As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnLn As Button
    Friend WithEvents btnLog As Button
End Class
