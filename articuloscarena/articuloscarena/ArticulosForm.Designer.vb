<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Codigo = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.Label
        Me.Unidad = New System.Windows.Forms.Label
        Me.Stock = New System.Windows.Forms.Label
        Me.Costo = New System.Windows.Forms.Label
        Me.Iva = New System.Windows.Forms.Label
        Me.Utilidad = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Venta = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(172, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(172, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(172, 118)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(172, 150)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Location = New System.Drawing.Point(24, 36)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(40, 13)
        Me.Codigo.TabIndex = 5
        Me.Codigo.Text = "Codigo"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(24, 64)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 6
        Me.Descripcion.Text = "Descripcion"
        '
        'Unidad
        '
        Me.Unidad.AutoSize = True
        Me.Unidad.Location = New System.Drawing.Point(24, 95)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(41, 13)
        Me.Unidad.TabIndex = 7
        Me.Unidad.Text = "Unidad"
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.Location = New System.Drawing.Point(24, 121)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(35, 13)
        Me.Stock.TabIndex = 8
        Me.Stock.Text = "Stock"
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Location = New System.Drawing.Point(24, 153)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(34, 13)
        Me.Costo.TabIndex = 9
        Me.Costo.Text = "Costo"
        '
        'Iva
        '
        Me.Iva.AutoSize = True
        Me.Iva.Location = New System.Drawing.Point(24, 185)
        Me.Iva.Name = "Iva"
        Me.Iva.Size = New System.Drawing.Size(22, 13)
        Me.Iva.TabIndex = 10
        Me.Iva.Text = "Iva"
        '
        'Utilidad
        '
        Me.Utilidad.AutoSize = True
        Me.Utilidad.Location = New System.Drawing.Point(24, 213)
        Me.Utilidad.Name = "Utilidad"
        Me.Utilidad.Size = New System.Drawing.Size(42, 13)
        Me.Utilidad.TabIndex = 11
        Me.Utilidad.Text = "Utilidad"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(172, 182)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(172, 210)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(197, 292)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Location = New System.Drawing.Point(24, 246)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(35, 13)
        Me.Venta.TabIndex = 15
        Me.Venta.Text = "Venta"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(172, 243)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 16
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 338)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Utilidad)
        Me.Controls.Add(Me.Iva)
        Me.Controls.Add(Me.Costo)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Unidad)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ArticulosForm"
        Me.Text = "ArticulosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents Unidad As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents Costo As System.Windows.Forms.Label
    Friend WithEvents Iva As System.Windows.Forms.Label
    Friend WithEvents Utilidad As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Venta As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
End Class
