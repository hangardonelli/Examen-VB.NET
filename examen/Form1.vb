Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Collections.Specialized


Public Class Form1
    Public Sub CargarProductos()
        'Cargamos los productos de la base de datos a una lista de productos para no hacer constantes
        'consultas a la base de datos y optimizar la velocidad del programa
        Text = "Cargando datos..."

        'Guardo la lista de productos en un datatable y nos intentamos conectar a la base de datos
        Dim dtProductos As New DataTable
        dtProductos = Nothing
        While IsNothing(dtProductos)
            dtProductos = DbQueryAsDataTable("SELECT * FROM productos")
        End While



        'Itero el datatable para crear objetos de productos y meterlos a la lista listProductos
        For i As Integer = 0 To dtProductos.Rows.Count - 1


            Dim producto = New Productos
            producto.ID = dtProductos.Rows(i).Item("ID")
            producto.Nombre = dtProductos.Rows(i).Item("Nombre")
            producto.Precio = dtProductos.Rows(i).Item("Precio")
            producto.Categoria = dtProductos.Rows(i).Item("Categoria")



            NuevaVenta.listProductos.Add(producto)


        Next
        Text = "Programa Examen - Autos"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()

    End Sub
    Private Sub TodosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem2.Click
        dataGrid.DataSource = DbQueryAsDataTable("SELECT * FROM clientes")
    End Sub

    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        dataGrid.DataSource = DbQueryAsDataTable("SELECT * FROM productos")
    End Sub

    Private Sub TodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasToolStripMenuItem.Click
        dataGrid.DataSource = DbQueryAsDataTable("SELECT * FROM ventas")
    End Sub

    Private Sub PorIDToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PorIDToolStripMenuItem3.Click
        Dim valor As Integer = InputBox("Seleccione el ID")
        dataGrid.DataSource = DbQueryAsDataTable($"SELECT * FROM clientes WHERE ID = {valor}")
    End Sub

    Private Sub PorIDToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PorIDToolStripMenuItem2.Click
        Dim valor As Integer = InputBox("Seleccione el ID")
        dataGrid.DataSource = DbQueryAsDataTable($"SELECT * FROM productos WHERE ID = {valor}")
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        dataGrid.DataSource = DbQueryAsDataTable("SELECT * FROM ventasitems")
    End Sub

    Private Sub PorIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorIDToolStripMenuItem.Click
        Dim valor As Integer = InputBox("Seleccione el ID de venta")
        dataGrid.DataSource = DbQueryAsDataTable($"SELECT * FROM ventasitems WHERE IDVenta = {valor}")
    End Sub

    Private Sub PorIDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorIDToolStripMenuItem1.Click
        Dim valor As Integer = InputBox("Seleccione el ID")
        dataGrid.DataSource = DbQueryAsDataTable($"SELECT * FROM ventas WHERE ID = {valor}")
    End Sub
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        IniciarCreadorDeClientes()
    End Sub

    Private Sub VentasÚltimoMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasÚltimoMesToolStripMenuItem.Click
        Dim reporte As New ReporteVenta()
        dataGrid.DataSource = reporte.Generar()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Try
            IniciarCreadorDeProductos()
        Catch ex As Exception
            MsgBox("Hubo un error al introducir los datos")
        End Try

        CargarProductos()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        NuevaVenta.ShowDialog(Me)
    End Sub


    Private Sub VentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem1.Click

        Dim venta As New Ventas
        venta = DevolverVentaSiExiste()
        If IsNothing(venta) Then
            MsgBox("No se puede encontrar la venta porque no se encontró")
            Exit Sub
        End If
        venta.Eliminar()
        MsgBox($"Se eliminó la venta de un valor de {venta.Total} correctamente")
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        Dim IDcliente As Integer = InputBox("Ingrese el ID del cliente a remover")
        Dim cliente As New Cliente(IDcliente)
        If IsNothing(cliente.Cliente) Then
            MsgBox("No se pudo eliminar al cliente porque no se encontró")
            Exit Sub
        End If
        cliente.Eliminar()
        MsgBox($"Se eliminó al cliente {cliente.Cliente} correctamente")
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim venta As New Ventas
        venta = DevolverVentaSiExiste()
        If IsNothing(venta) Then
            MsgBox("No se pudo encontrar la venta")
            Exit Sub
        End If

        Try
            venta.IDCliente = InputBox("Ingrese el ID del cliente")
            venta.Total = InputBox("Ingrese el precio total")
        Catch ex As Exception
            MsgBox("Hubo un error al ingresar los datos")
        Finally
            venta.Modificar()
        End Try

    End Sub

    Private Sub ProductoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem2.Click
        Dim producto As New Productos
        producto = DevolverProductoSiExiste()

        If IsNothing(producto) Then
            MsgBox("No se pudo encontrar la venta")
            Exit Sub
        End If

        Try
            producto.Nombre = InputBox("Ingrese el nuevo nombre del producto")
            If (producto.Nombre = "" Or IsNothing(producto.Nombre)) Then
                MsgBox("Error al introducir el nombre del producto")
                Exit Sub
            End If

            producto.Precio = InputBox("Ingrese el precio del producto")

            producto.Categoria = DevolverCategoriaPorID(InputBox("Elija la categoría del vehículo"))
            If IsNothing(producto.Categoria) Then
                MsgBox("Error al escribir la categoría")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Hubo un error al ingresar los datos")
        Finally
            producto.Modificar()
        End Try

    End Sub

    Private Sub ReporteDeVentaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentaDeProductosToolStripMenuItem.Click
        Dim reporte As New ReporteVentaDeProductos()
        dataGrid.DataSource = reporte.Generar()
    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem2.Click
        Dim cliente As New Cliente
        cliente = DevolverClienteSiExiste()
        If IsNothing(cliente) Then
            MsgBox("El cliente no existe")
            Exit Sub
        End If

        Try
            cliente.Cliente = InputBox("Ingrese el nuevo nombre del cliente")
            cliente.Telefono = InputBox("Ingrese el nuevo teléfono del cliente")
            cliente.Correo = InputBox("Ingrese el nuevo correo del cliente")

        Catch ex As Exception
            MsgBox("Hubo un error al ingresar los datos")

        Finally

            cliente.Modificar()
        End Try

    End Sub
End Class

