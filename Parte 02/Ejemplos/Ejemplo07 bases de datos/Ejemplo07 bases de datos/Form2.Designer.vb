<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Vb_mysqlDataSet = New Ejemplo07_bases_de_datos.vb_mysqlDataSet()
        Me.VbmysqlDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Ejemplo07_bases_de_datos.vb_mysqlDataSetTableAdapters.DataTable1TableAdapter()
        Me.IddvdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vb_mysqlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbmysqlDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddvdDataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.DirectorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VbmysqlDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(53, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Vb_mysqlDataSet
        '
        Me.Vb_mysqlDataSet.DataSetName = "vb_mysqlDataSet"
        Me.Vb_mysqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VbmysqlDataSetBindingSource
        '
        Me.VbmysqlDataSetBindingSource.DataMember = "DataTable1"
        Me.VbmysqlDataSetBindingSource.DataSource = Me.Vb_mysqlDataSet
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'IddvdDataGridViewTextBoxColumn
        '
        Me.IddvdDataGridViewTextBoxColumn.DataPropertyName = "id_dvd"
        Me.IddvdDataGridViewTextBoxColumn.HeaderText = "id_dvd"
        Me.IddvdDataGridViewTextBoxColumn.Name = "IddvdDataGridViewTextBoxColumn"
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        '
        'DirectorDataGridViewTextBoxColumn
        '
        Me.DirectorDataGridViewTextBoxColumn.DataPropertyName = "director"
        Me.DirectorDataGridViewTextBoxColumn.HeaderText = "director"
        Me.DirectorDataGridViewTextBoxColumn.Name = "DirectorDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 282)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vb_mysqlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbmysqlDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VbmysqlDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vb_mysqlDataSet As Ejemplo07_bases_de_datos.vb_mysqlDataSet
    Friend WithEvents DataTable1TableAdapter As Ejemplo07_bases_de_datos.vb_mysqlDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents IddvdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
