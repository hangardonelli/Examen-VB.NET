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
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PorIDToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PorIDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PorIDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PorIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasÚltimoMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid
        '
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid.Location = New System.Drawing.Point(0, 24)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(800, 426)
        Me.dataGrid.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ItemsDeVentaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem2, Me.ToolStripMenuItem4, Me.PorIDToolStripMenuItem3})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'TodosToolStripMenuItem2
        '
        Me.TodosToolStripMenuItem2.Name = "TodosToolStripMenuItem2"
        Me.TodosToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.TodosToolStripMenuItem2.Text = "Todos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(177, 6)
        '
        'PorIDToolStripMenuItem3
        '
        Me.PorIDToolStripMenuItem3.Name = "PorIDToolStripMenuItem3"
        Me.PorIDToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.PorIDToolStripMenuItem3.Text = "Por ID"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem1, Me.ToolStripMenuItem3, Me.PorIDToolStripMenuItem2})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'TodosToolStripMenuItem1
        '
        Me.TodosToolStripMenuItem1.Name = "TodosToolStripMenuItem1"
        Me.TodosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.TodosToolStripMenuItem1.Text = "Todos"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'PorIDToolStripMenuItem2
        '
        Me.PorIDToolStripMenuItem2.Name = "PorIDToolStripMenuItem2"
        Me.PorIDToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.PorIDToolStripMenuItem2.Text = "Por ID"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasToolStripMenuItem, Me.ToolStripMenuItem1, Me.PorIDToolStripMenuItem1})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'PorIDToolStripMenuItem1
        '
        Me.PorIDToolStripMenuItem1.Name = "PorIDToolStripMenuItem1"
        Me.PorIDToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PorIDToolStripMenuItem1.Text = "Por ID"
        '
        'ItemsDeVentaToolStripMenuItem
        '
        Me.ItemsDeVentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem, Me.ToolStripMenuItem2, Me.PorIDToolStripMenuItem})
        Me.ItemsDeVentaToolStripMenuItem.Name = "ItemsDeVentaToolStripMenuItem"
        Me.ItemsDeVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ItemsDeVentaToolStripMenuItem.Text = "Items de Venta"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'PorIDToolStripMenuItem
        '
        Me.PorIDToolStripMenuItem.Name = "PorIDToolStripMenuItem"
        Me.PorIDToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PorIDToolStripMenuItem.Text = "Por ID de venta"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem1, Me.ClienteToolStripMenuItem1, Me.ProductoToolStripMenuItem})
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'VentaToolStripMenuItem1
        '
        Me.VentaToolStripMenuItem1.Name = "VentaToolStripMenuItem1"
        Me.VentaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.VentaToolStripMenuItem1.Text = "Venta"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem2, Me.ProductoToolStripMenuItem2})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem2.Text = "Cliente"
        '
        'ProductoToolStripMenuItem2
        '
        Me.ProductoToolStripMenuItem2.Name = "ProductoToolStripMenuItem2"
        Me.ProductoToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem2.Text = "Producto"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ProductosToolStripMenuItem1})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem1.Text = "Producto"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasÚltimoMesToolStripMenuItem, Me.ReporteDeVentaDeProductosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasÚltimoMesToolStripMenuItem
        '
        Me.VentasÚltimoMesToolStripMenuItem.Name = "VentasÚltimoMesToolStripMenuItem"
        Me.VentasÚltimoMesToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.VentasÚltimoMesToolStripMenuItem.Text = "Reporte de ventas"
        '
        'ReporteDeVentaDeProductosToolStripMenuItem
        '
        Me.ReporteDeVentaDeProductosToolStripMenuItem.Name = "ReporteDeVentaDeProductosToolStripMenuItem"
        Me.ReporteDeVentaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.ReporteDeVentaDeProductosToolStripMenuItem.Text = "Reporte de venta de productos en el último mes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents PorIDToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents PorIDToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents PorIDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ItemsDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PorIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasÚltimoMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem2 As ToolStripMenuItem
End Class
