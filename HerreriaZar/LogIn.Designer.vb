﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BotonDeIngreso = New System.Windows.Forms.Button()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MensajeDeBienvenida = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BotonDeIngreso)
        Me.Panel1.Controls.Add(Me.Contraseña)
        Me.Panel1.Controls.Add(Me.Usuario)
        Me.Panel1.Controls.Add(Me.LabelMensaje)
        Me.Panel1.Controls.Add(Me.LabelContraseña)
        Me.Panel1.Controls.Add(Me.LabelUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(379, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 453)
        Me.Panel1.TabIndex = 0
        '
        'BotonDeIngreso
        '
        Me.BotonDeIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonDeIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonDeIngreso.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonDeIngreso.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonDeIngreso.Location = New System.Drawing.Point(136, 352)
        Me.BotonDeIngreso.Name = "BotonDeIngreso"
        Me.BotonDeIngreso.Size = New System.Drawing.Size(185, 45)
        Me.BotonDeIngreso.TabIndex = 6
        Me.BotonDeIngreso.Text = "Ingresar"
        Me.BotonDeIngreso.UseVisualStyleBackColor = False
        '
        'Contraseña
        '
        Me.Contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contraseña.Location = New System.Drawing.Point(76, 284)
        Me.Contraseña.Margin = New System.Windows.Forms.Padding(8)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(277, 20)
        Me.Contraseña.TabIndex = 5
        Me.Contraseña.UseSystemPasswordChar = True
        '
        'Usuario
        '
        Me.Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Usuario.Location = New System.Drawing.Point(76, 196)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(8)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(277, 20)
        Me.Usuario.TabIndex = 4
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMensaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelMensaje.Location = New System.Drawing.Point(73, 117)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(126, 17)
        Me.LabelMensaje.TabIndex = 3
        Me.LabelMensaje.Text = "Ingresa a tu cuenta"
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseña.Location = New System.Drawing.Point(73, 261)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(77, 17)
        Me.LabelContraseña.TabIndex = 2
        Me.LabelContraseña.Text = "Contraseña"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.Location = New System.Drawing.Point(72, 165)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(60, 19)
        Me.LabelUsuario.TabIndex = 1
        Me.LabelUsuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'MensajeDeBienvenida
        '
        Me.MensajeDeBienvenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajeDeBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MensajeDeBienvenida.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MensajeDeBienvenida.Location = New System.Drawing.Point(27, 144)
        Me.MensajeDeBienvenida.Name = "MensajeDeBienvenida"
        Me.MensajeDeBienvenida.Size = New System.Drawing.Size(326, 154)
        Me.MensajeDeBienvenida.TabIndex = 1
        Me.MensajeDeBienvenida.Text = "Bienvenido de vuelta!"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.Control
        Me.Fecha.Location = New System.Drawing.Point(108, 398)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(144, 19)
        Me.Fecha.TabIndex = 2
        Me.Fecha.Text = "17 de Abril del 2021"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MensajeDeBienvenida)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MensajeDeBienvenida As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents Usuario As TextBox
    Friend WithEvents BotonDeIngreso As Button
    Friend WithEvents Fecha As Label
End Class
