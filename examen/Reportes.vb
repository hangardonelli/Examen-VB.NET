Imports System.Data
Public Interface IReportes
    Function Generar() As DataTable
End Interface



Friend Class ReporteVenta
    Implements IReportes
    Public Function Generar() As DataTable Implements IReportes.Generar
        Return DbQueryAsDataTable("SELECT IDVenta As 'ID de la venta', ventas.Fecha as 'Fecha de la compra', ventas.IDCliente As 'ID del cliente', clientes.Cliente As 'Nombre del cliente',  productos.ID as 'ID Del producto', productos.Nombre As 'Nombre del producto', productos.Precio as 'Precio Individual', Cantidad, productos.Categoria as 'Categoría', ventasitems.PrecioTotal As 'Precio total de la compra' FROM ventasitems JOIN ventas ON IDVenta = ventas.ID JOIN productos ON productos.ID = ventasitems.IDProducto JOIN clientes ON clientes.ID = ventas.IDCliente")
    End Function
End Class

Friend Class ReporteVentaDeProductos
    Implements IReportes
    Public Function Generar() As DataTable Implements IReportes.Generar
        Return DbQueryAsDataTable("SELECT  IDProducto As 'Id del Producto', SUM(Cantidad) As 'Cantidad vendida' FROM ventasitems WHERE  ventasitems.IDVenta IN (SELECT ID FROM Ventas WHERE ID = ventasitems.IDVenta AND (Fecha >= DATEADD(MONTH, -1, CURRENT_TIMESTAMP)) AND Fecha < CURRENT_TIMESTAMP) GROUP BY IDProducto")
    End Function
End Class