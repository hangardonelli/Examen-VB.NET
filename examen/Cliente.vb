Public Class Cliente
    Implements IComponentes

    Public Sub New()
    End Sub



    Public ID As Integer
    Public Cliente As String
    Public Telefono As String
    Public Correo As String
    Public Sub New(id As Integer)
        'Obtener cliente a partir de ID en la base de datos

        Dim dtCliente As New DataTable
        dtCliente = DbQueryAsDataTable($"SELECT * FROM clientes WHERE ID = {id}")


        Me.ID = dtCliente.Rows(0).Item("ID")
        Me.Cliente = dtCliente.Rows(0).Item("Cliente")
        Me.Telefono = dtCliente.Rows(0).Item("Telefono")
        Me.Correo = dtCliente.Rows(0).Item("Correo")


    End Sub
    Public Sub Crear() Implements IComponentes.Crear
        If Not (Cliente = Nothing Or Telefono = Nothing Or Correo = Nothing) Then
            DbQuery($"INSERT INTO clientes(Cliente, Telefono, Correo) VALUES ('{Cliente}', '{Telefono}', '{Correo}') ")
        End If

    End Sub

    Public Sub Eliminar() Implements IComponentes.Eliminar
        DbQuery($"DELETE FROM clientes WHERE ID = {ID}")
    End Sub

    Public Sub Modificar() Implements IComponentes.Modificar
        DbQuery($"UPDATE clientes SET Cliente = '{Cliente}', Telefono = '{Telefono}', Correo = {Correo} WHERE ID = {ID}")
    End Sub


End Class
