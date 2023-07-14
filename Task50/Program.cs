namespace Task50
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

            Console.WriteLine("Enter row");
            int.TryParse(Console.ReadLine(), out int row);
            Console.WriteLine("Enter col");
            int.TryParse(Console.ReadLine(), out int col);

            if((row >= 0 && row < matrix.GetLength(0)) && (col >= 0 && col < matrix.GetLength(1)))
            {
                Console.WriteLine(matrix[row, col]);
            }
            else 
            {
                Console.WriteLine("Такого элемента в матрице нет");
            }
        }

        static int[,] GetMatrix() 
        {
            int[,] matrix = new int[4, 4];
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
}