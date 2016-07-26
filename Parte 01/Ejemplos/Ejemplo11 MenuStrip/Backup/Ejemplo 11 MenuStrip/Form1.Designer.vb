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
        Me.MS_prueba = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperacionesBasicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar
        Me.MS_prueba.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_prueba
        '
        Me.MS_prueba.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MS_prueba.Location = New System.Drawing.Point(0, 0)
        Me.MS_prueba.Name = "MS_prueba"
        Me.MS_prueba.Size = New System.Drawing.Size(284, 24)
        Me.MS_prueba.TabIndex = 0
        Me.MS_prueba.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesBasicasToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'OperacionesBasicasToolStripMenuItem
        '
        Me.OperacionesBasicasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.OperacionesBasicasToolStripMenuItem.Name = "OperacionesBasicasToolStripMenuItem"
        Me.OperacionesBasicasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OperacionesBasicasToolStripMenuItem.Text = "Operaciones basicas"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        Me.CopiarToolStripMenuItem.Visible = False
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(62, 56)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 1
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(62, 87)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar2.TabIndex = 2
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(62, 123)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.MS_prueba)
        Me.MainMenuStrip = Me.MS_prueba
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MS_prueba.ResumeLayout(False)
        Me.MS_prueba.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS_prueba As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesBasicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar3 As System.Windows.Forms.HScrollBar

End Class
