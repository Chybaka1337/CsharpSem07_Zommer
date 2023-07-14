namespace Task52 
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrix();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum of cols");
            foreach(var element in matrix.GetSumCols())
            {
                Console.Write(element + "\t");
            }
        }

        static int[,] GetMatrix() 
        {
            var matrix = new int[4, 4];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-10, 10);
                }
            }
            return matrix;
        }
    }

    static class MatrixExtension
    {
        public static double[] GetSumCols(this int[, ] matrix) 
        {
            var sumCols = new double[matrix.GetLength(1)];
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    sumCols[j] += matrix[i, j];
                }
                sumCols[j] /= matrix.GetLength(0);
            }
            return sumCols;
        }
    }
}