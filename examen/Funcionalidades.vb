Imports System.Data
Public Module Funcionalidades

    ''' <summary>
    ''' Iniciador.
    '''  'Ejecuta Inputboxs en donde se le hace escribir al usuario los datos del cliente y los crea
    ''' </summary>
    Public Sub IniciarCreadorDeClientes()

        Dim cliente As New Cliente()

        cliente.ID = DbQueryAsValue("SELECT max(ID) FROM clientes") + 1
        cliente.Cliente = InputBox($"Introduzca el nombre del futuro cliente con ID {cliente.ID}")
        cliente.Telefono = InputBox($"Introduzca el teléfono del futuro cliente llamado {cliente.Cliente}")
        cliente.Correo = InputBox($"Introduzca el correo del futuro cliente llamado {cliente.Cliente}")

        cliente.Crear()
    End Sub

    ''' <summary>
    ''' Iniciador.
    '''  'Ejecuta Inputboxs en donde se le hace escribir al usuario los datos del producto y lo crea
    ''' </summary>
    Public Sub IniciarCreadorDeProductos()
        Dim producto As New Productos()
        producto.Nombre = InputBox("Ingrese el nombre del producto")
        producto.Precio = InputBox("Ingrese el precio de producto")
        producto.Categoria = Convert.ToInt16(InputBox("Ingrese la categoría del producto"))

        producto.Crear()
    End Sub

    ''' <summary>
    ''' Devuelve una categoría de auto al introducirle su ID
    ''' </summary>
    ''' <param name="id">Un entero que representa al id</param>
    ''' <returns>Un Enum de tipo Productos.Categoria</returns>
    Public Function DevolverCategoriaPorID(id As Integer) As Productos.Categorias

        Dim Cat As New Productos.Categorias

        Try
            Select Case id
                Case 0
                    Return Cat.Sedan
                Case 1
                    Return Cat.SUV
                Case 2
                    Return Cat.Hatchback
                Case 3
                    Return Cat.Deportivo
                Case 4
                    Return Cat.Van
                Case 5
                    Return Cat.Pickup
                Case 6
                    Return Cat.Camion
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Hace al usuario introducir el id de un producto y lo devuelve.
    ''' </summary>
    ''' <returns>Un producto, en caso de que exista el producto con dicho ID. De lo contrario, Nothing</returns>
    Public Function DevolverProductoSiExiste() As Productos
        Dim IDProducto As Integer = InputBox("Ingrese el ID Del producto")
        Dim producto As New Productos(IDProducto)
        If IsNothing(producto.Nombre) Or producto.Nombre = "" Then
            Return Nothing
        End If
        Return producto
    End Function
    ''' <summary>
    ''' Hace al usuario introducir el id de un cliente y lo devuelve.
    ''' </summary>
    ''' <returns>Un cliente, en caso de que exista el cliente con dicho ID. De lo contrario, Nothing</returns>

    Public Function DevolverClienteSiExiste() As Cliente
        Dim IDcliente As Integer = InputBox("Ingrese el ID Del cliente")
        Dim cliente As New Cliente(IDcliente)
        If IsNothing(cliente.Cliente) Or cliente.Cliente = "" Then
            Return Nothing
        End If
        Return cliente
    End Function
    ''' <summary>
    ''' Hace al usuario introducir el id de una venta y lo devuelve.
    ''' </summary>
    ''' <returns>Una venta, en caso de que exista la venta con dicho ID. De lo contrario, Nothing</returns>

    Public Function DevolverVentaSiExiste() As Ventas
        Dim IDVenta As Integer = InputBox("Ingrese el ID de la venta a remover")
        Dim venta As New Ventas(IDVenta)
        If venta.IDCliente = 0 Then
            Return Nothing
        End If
        Return venta

    End Function



End Module
