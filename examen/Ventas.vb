Public Class Ventas
    Implements IComponentes

    Public Sub New()
    End Sub

    Public ID As Integer
    Public IDCliente As Integer
    Public Fecha As Object
    Public Total As Integer


    Public Sub New(id As Integer)
        Dim dt As DataTable
        dt = DbQueryAsDataTable($"SELECT * FROM ventas WHERE ID = {id}")
        Try
            Me.ID = dt.Rows(0).Item("ID")
            Me.IDCliente = dt.Rows(0).Item("IDCliente")
            Me.Fecha = dt.Rows(0).Item("Fecha")
            Me.Total = dt.Rows(0).Item("Total")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Crear() Implements IComponentes.Crear
        DbQuery($"INSERT INTO ventas(IDCliente, Fecha, Total) VALUES ({IDCliente}, CURRENT_TIMESTAMP, {Total})")
    End Sub

    Public Sub Eliminar() Implements IComponentes.Eliminar
        DbQuery($"DELETE FROM ventas WHERE ID = {ID}")
        DbQuery($"DELETE FROM ventasitems WHERE IDVenta = {ID}")
    End Sub

    Public Sub Modificar() Implements IComponentes.Modificar
        DbQuery($"UPDATE ventas SET Fecha = CURRENT_TIMESTAMP WHERE ID = {ID}")
    End Sub


End Class

Friend Class VentasItem
    Implements IComponentes

    Public ID As Integer
    Public IDVenta As Integer
    Public IDProducto As Integer
    Public Cantidad As Integer

    Public Sub New()
    End Sub

    Public Sub New(id As Integer)
        Dim dt As DataTable
        dt = DbQueryAsDataTable($"SELECT * FROM ventasitems WHERE ID = {id}")

        Me.ID = dt.Rows(0).Item("ID")
        Me.IDVenta = dt.Rows(0).Item("IDVenta")
        Me.IDProducto = dt.Rows(0).Item("IDProducto")
        Me.Cantidad = dt.Rows(0).Item("Cantidad")

    End Sub
    Public Function ObtenerPrecioUnitario()
        Dim Producto As New Productos(IDProducto)
        Return Producto.Precio
    End Function
    Public Function ObtenerPrecioTotal()
        Return Cantidad * ObtenerPrecioUnitario()
    End Function


    Public Sub Crear() Implements IComponentes.Crear
        DbQuery($"INSERT INTO ventasitems(IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES ({IDVenta}, {IDProducto}, {ObtenerPrecioUnitario()}, {Cantidad}, {ObtenerPrecioTotal()})")
    End Sub

    Public Sub Eliminar() Implements IComponentes.Eliminar
        DbQuery($"DELETE FROM ventasitems WHERE ID = {ID}")
    End Sub

    Public Sub Modificar() Implements IComponentes.Modificar
        DbQuery($"UPDATE ventasitems SET IDVenta = {IDVenta}, IDProducto = {IDProducto}, PrecioUnitario = {ObtenerPrecioUnitario()}, Cantidad = {Cantidad}, PrecioTotal = {ObtenerPrecioTotal()}  WHERE ID = {ID}")
    End Sub


End Class