namespace Task47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("row = ");
            int.TryParse(Console.ReadLine(), out int row);
            Console.Write("col =");
            int.TryParse(Console.ReadLine(), out int col);
            var matrix = GetMatrix(row, col);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static double[,] GetMatrix(int row, int col) 
        {
            var matrix = new double[row, col];
            for(int i = 0; i < matrix.GetLength(0); i++) 
            {
                for(int j = 0; j < matrix.GetLength(1); j++) 
                {
                    matrix[i, j] = new Random().NextDouble() * 20 - 10;
                }
            }
            return matrix;
        }
    }
}