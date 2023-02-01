namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            Console.WriteLine(DiagonalDifference(matrix));
      
            Console.ReadKey();
        }

        static int DiagonalDifference(int[,] arr)
        {
            // Primero obtenemos la longitud de la primera dimención
            int n = arr.GetLength(0);
            // Definimos las variables que contendran el valor de la suma de las diagonales
            int upDiagonal = 0;
            int downDiagonal = 0;

            for(int i = 0; i < n; i++)
            {
                //Sumamos los indices 0,0 + 1,1 + 2,2
                upDiagonal += arr[i, i];
                //Sumamos los indices 0,2 + 1,1 + 2,0
                downDiagonal += arr[i, n - i - 1];
            }
            //Utilizamos el método Abs de la clase Math para obtener la diferencia absoluta.
            return Math.Abs(upDiagonal - downDiagonal);
        }
    
    }
}