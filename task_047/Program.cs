// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// //matrix[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(0, 9), 1);
void FillArrayWRandomDouble(double[,] matrix, int rowslength, int columnslength)
{
    for (int i = 0; i < rowslength; i++)
    {
        for (int j = 0; j < columnslength; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter matrix's length - rows");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int c = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[r, c];

Console.WriteLine("Your matrix is: ");
FillArrayWRandomDouble(matrix, r, c);