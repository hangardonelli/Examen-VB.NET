Imports System.Linq
Public Class NuevaVenta

    'listProductos va a tomar valores cuando Form1 Cargue
    Public listProductos As New List(Of Productos)


    'Esta Lista es un "Carrito de compra" en donde se van anotando _
    'todos los productos que se quieren comprar
    Dim listProductosEnVenta As New List(Of VentasItem)

    Dim clienteVenta As New Cliente

    Public Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Ajustamos el estilo de la ventana
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle



    End Sub
    Private Function CalcularIDDeVenta() As Integer
        'Calculamos el id de venta que tendra nuestra venta actual, sumandole uno al ID anterior
        Try
            Return Convert.ToInt32(DbQueryAsValue("SELECT max(id) FROM ventas")) + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function

    ''' <summary>
    ''' Funcion que obtiene los precios totales de todos los elementos del carrito
    ''' </summary>
    ''' <returns>Long sin signo, que denota el precio total</returns>
    ''' Aclaración: Utilicé ULong y no entero, en primer lugar porque un precio no va a tener valor negativo _
    ''' y en segundo, porque si se llegase a producir una compra exorbital un int capaz hace overflow
    Private Function RecargarPreciosTotales() As ULong
        Dim Precio As Integer = 0
        For Each item As VentasItem In listProductosEnVenta
            Precio = Precio + item.ObtenerPrecioTotal()
        Next
        Return Precio
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim ID As Integer
            ID = DbQueryAsValue($"SELECT * FROM clientes WHERE ID = {idTxt.Text}")


            Dim cliente As New Cliente(ID)
                clienteVenta = cliente
                IDNameLabel.Text = cliente.Cliente

        Catch ex As Exception
            MsgBox($"El ID no existe, compruebe que lo haya escrito correctamente, error: {ex.Message}", vbCritical)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim IDProducto As Integer
        Dim CantidadProd As Integer
        Try
            IDProducto = InputBox("Ingrese el ID del producto a agregar")
            CantidadProd = InputBox("Ingrese la cantidad a agregar")
            'Hacemos una consulta LINQ para asegurarnos de que ingresó correctamente el ID del producto
            If listProductos.Any(Function(x) x.ID = IDProducto) And CantidadProd >= 0 Then
                DataGridView1.Rows.Add(IDProducto, CantidadProd)

                Dim ventaitem As New VentasItem
                ventaitem.Cantidad = CantidadProd
                ventaitem.IDProducto = IDProducto
                ventaitem.IDVenta = Convert.ToInt32(CalcularIDDeVenta())
                'precio.Text = Convert.ToUInt64(ventaitem.ObtenerPrecioTotal())
                listProductosEnVenta.Add(ventaitem)
                precio.Text = RecargarPreciosTotales()
            Else
                MsgBox("El ID ingresado es incorrecto o la cantidad es invalida, ingrese nuevamente los valores")
            End If


        Catch ex As Exception
            MsgBox("Error al agregar los datos")
        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not IsNothing(clienteVenta) Then
            If Not listProductosEnVenta.Count = 0 Then
                For Each producto As VentasItem In listProductosEnVenta
                    producto.Crear()
                Next
                Dim venta As New Ventas
                venta.IDCliente = clienteVenta.ID
                venta.Total = Convert.ToUInt64(precio.Text)
                venta.Crear()
                Me.Close()
            Else
                MsgBox("No se agregaron productos a la venta")
                Exit Sub
            End If
        Else
            MsgBox("No se agregó al cliente", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim IDProducto As Integer
            IDProducto = InputBox("Ingrese el ID del producto a ser eliminado")

            'Verificamos antes del borrado si se encuentra en la lista, y recargamos el formulario
            'Como los items se encuentran en la variable listProductosEnVenta, recargar el formulario es
            'mucho más rapido que iterar entre las columnas hasta encontrar el valor que queremos borrar.

            Dim ProductoAEliminar As New VentasItem
            ProductoAEliminar = listProductosEnVenta.FirstOrDefault(Function(x) x.IDProducto = IDProducto)


            If Not listProductosEnVenta.Remove(ProductoAEliminar) Then
                MsgBox("El no producto no se encuentra en la lista!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Refresh()
            For Each producto As VentasItem In listProductosEnVenta
                DataGridView1.Rows.Add(producto.IDProducto, producto.Cantidad)

            Next
            precio.Text = RecargarPreciosTotales()


        Catch ex As Exception
            MsgBox("Hubo un error al introducir los datos")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
