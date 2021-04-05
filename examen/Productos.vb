Public Class Productos
    Implements IComponentes

    Public Sub New()
    End Sub

    Public ID As Integer
    Public Nombre As String
    Public Precio As Integer
    Public Categoria As Categorias




    Public Sub New(id As Integer)
        ' Construimos el objeto a partir de la ID

        Dim dt As DataTable
        dt = DbQueryAsDataTable($"SELECT * FROM Productos WHERE ID = {id}")

        Me.ID = dt.Rows(0).Item("ID")
        Me.Nombre = dt.Rows(0).Item("Nombre")
        Me.Precio = dt.Rows(0).Item("Precio")
        Me.Categoria = dt.Rows(0).Item("Categoria")

    End Sub

    Public Sub Crear() Implements IComponentes.Crear
        DbQuery($"INSERT INTO Productos(Nombre, Precio, Categoria) VALUES ('{Nombre}', '{Precio}', {Convert.ToInt32(Categoria)})")
    End Sub

    Public Sub Eliminar() Implements IComponentes.Eliminar
        DbQuery($"DELETE FROM Productos WHERE ID = {ID}")
    End Sub

    Public Sub Modificar() Implements IComponentes.Modificar
        DbQuery($"UPDATE Productos SET Nombre = '{Nombre}', Precio = '{Precio}', Categoria = '{Convert.ToInt32(Categoria)} WHERE ID = {ID}'")
    End Sub



    Enum Categorias
        REM Modifiqué el Tipo varchar(255) por INT ya que me pareció más conveniente que las categorías
        ' Se guarden como enteros (que vendrían a ser IDs) ya que es una lista corta de categorías, y no algo irrepetible como un nombre o un
        ' número de teléfono
        Sedan = 0
        SUV = 1
        Hatchback = 2
        Deportivo = 3
        Van = 4
        Pickup = 5
        Camion = 6
    End Enum

End Class
