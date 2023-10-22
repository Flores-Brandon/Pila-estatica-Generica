Imports System

Module Module1

    Sub Main(args As String())
        ' Se creea una pila de enteros con capacidad máxima de 5 elementos.
        Dim pilaEnteros As New MiPila(Of Integer)(5)
        ' Agregamos elementos a la pila de enteros.
        pilaEnteros.Push(1)
        pilaEnteros.Push(2)
        pilaEnteros.Push(3)

        ' Imprimimos un mensaje en la consola.
        Console.WriteLine("Elementos en la pila de enteros:")

        ' Repetimos el While mientras la pila de enteros no esté vacía.
        While pilaEnteros.Count > 0
            ' Sacamos y mostramos el elemento superior de la pila.
            Console.WriteLine(pilaEnteros.Pop())
        End While

        ' Creamos una pila de cadenas con capacidad máxima de 3 elementos.
        Dim pilaCadenas As New MiPila(Of String)(3)
        ' Agregamos elementos a la pila de cadenas.
        pilaCadenas.Push("Hola")
        pilaCadenas.Push("Mundo")

        ' Imprimimos un mensaje en la consola.
        Console.WriteLine("Elementos en la pila de cadenas:")

        ' Volvemos a reptir el While como la vez pasada mientras la pila de cadenas no esté vacía.
        While pilaCadenas.Count > 0
            ' Sacamos y mostramos el elemento superior de la pila.
            Console.WriteLine(pilaCadenas.Pop())
        End While
    End Sub

    Public Class MiPila(Of T)
        ' Creamos variables para almacenar elementos, capacidad y contador.
        Private elementos As T()
        Private capacidad As Integer
        Private contador As Integer

        'Creamos el Constructor para inicializar la pila con una capacidad máxima.
        Public Sub New(capacidad As Integer)
            Me.capacidad = capacidad
            ' Creamos un arreglo para almacenar los elementos.
            Me.elementos = New T(capacidad - 1) {}
            ' Inicializamos el contador en 0.
            Me.contador = 0
        End Sub

        ' Creamos el Método para agregar elementos a la pila.
        Public Sub Push(elemento As T)
            ' Verificamos si la pila no está llena.
            If contador < capacidad Then
                ' Agregamos el elemento y aumentamos el contador.
                elementos(contador) = elemento
                contador += 1
            Else
                ' Mostramos un mensaje si la pila está llena.
                Console.WriteLine("La pila está llena. No se puede agregar más elementos.")
            End If
        End Sub

        ' Creamos el Método para sacar y devolver el elemento superior de la pila.
        Public Function Pop() As T
            ' Verificamos si la pila no está vacía.
            If contador > 0 Then
                ' Disminuimos el contador, sacamos el elemento y restablecemos a Nothing (o null).
                contador -= 1
                Dim elemento As T = elementos(contador)
                elementos(contador) = Nothing ' Restablecer el valor a Nothing (nulo) para tipos de referencia
                Return elemento
            Else
                ' Mostramos un mensaje si la pila está vacía y devolvemos Nothing.
                Console.WriteLine("La pila está vacía. No se pueden sacar más elementos.")
                Return Nothing ' Valor predeterminado para el tipo T (por ejemplo, Nothing para tipos de referencia)
            End If
        End Function

        'Creamos el Método para ver el elemento superior de la pila sin sacarlo.
        Public Function Peek() As T
            ' Verificamos si la pila no está vacía.
            If contador > 0 Then
                ' Devolvemos el elemento superior sin modificar la pila.
                Return elementos(contador - 1)
            Else
                ' Mostramos un mensaje si la pila está vacía y devolvemos Nothing.
                Console.WriteLine("La pila está vacía. No hay elementos para ver.")
                Return Nothing ' Valor predeterminado para el tipo T
            End If
        End Function

        ' Esta Propiedad es solo lectura para obtener la cantidad de elementos en la pila.
        Public ReadOnly Property Count As Integer
            Get
                Return contador
            End Get
        End Property
    End Class

End Module
