
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayWRandom(int[,] matrix, int rowslength, int columnslength)
{
    for (int i = 0; i < rowslength; i++)
    {
        for (int j = 0; j < columnslength; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MeanSquareRootPerColumn(int[,] matrix, int rowslength, int columnslength)
{
    for (int j = 0; j < columnslength; j++)
    {
        double sum = 0;
        for (int i = 0; i < rowslength; i++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"for {j} column = {Math.Round(sum / rowslength, 2)} ");
    }
}

Console.WriteLine("Enter matrix's length - rows");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int c = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[r, c];

Console.WriteLine("Your matrix is: ");
FillArrayWRandom(matrix, r, c);
Console.WriteLine("Mean square roots for each column:");
MeanSquareRootPerColumn(matrix, r, c);



