# DiagonalDifference en C#

Este repositorio contiene una aplicación de consola en C# que calcula la diferencia entre las dos diagonales de una matriz cuadrada.

## ¿Como ejecutar la aplicación?

**Par poder ejecutar la aplicación es necesario tener instalado Visual Studio u otro IDE que permita ejecutar aplicaciones en C#.**

----------------------------------------------------------------------------------------------------------------------------------
# Funcionamiento

El método DiagonalDifference utiliza un ciclo for para sumar los elementos de las diagonales. Primero, se obtiene la longitud de la primera dimensión 
de la matriz con el método GetLength y se guarda en la variable n. Luego, se inicializan dos variables para guardar la suma de cada diagonal, upDiagonal 
y downDiagonal.

En el ciclo for, se suman los elementos de cada diagonal utilizando la variable i como índice. La suma de la diagonal principal se realiza sumando los
elementos de los índices [0,0], [1,1] y [2,2] de la matriz. La suma de la diagonal secundaria se realiza sumando los elementos de los índices
[0,2], [1,1] y [2,0] de la matriz.

Por último, se utiliza el método Abs de la clase Math para obtener la diferencia absoluta entre las dos diagonales y se retorna como resultado.

```C#
 static int DiagonalDifference(int[,] arr)
        {
            int n = arr.GetLength(0);
            int upDiagonal = 0;
            int downDiagonal = 0;

            for(int i = 0; i < n; i++)
            {
                upDiagonal += arr[i, i];
                downDiagonal += arr[i, n - i - 1];
            }
           
            return Math.Abs(upDiagonal - downDiagonal);
        }
        
