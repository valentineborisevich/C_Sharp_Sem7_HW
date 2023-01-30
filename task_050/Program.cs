
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9
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

void FindByIndexes(int[,] matrix, int rowslength, int columnslength, int index1, int index2)
{
    if (index1 >= rowslength | index2 >= columnslength)
    {
        System.Console.WriteLine("There's no such element");
    }
    else
    {
        for (int i = 0; i < rowslength; i++)
        {
            for (int j = 0; j < columnslength; j++)
            {
                if (i == index1 && j == index2)
                {
                    Console.WriteLine($"value = {matrix[i, j]} ");
                }
            }
        }
    }
}
Console.WriteLine("Enter matrix's length - rows");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int c = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[r, c];

Console.WriteLine("Your matrix is: ");
FillArrayWRandom(matrix, r, c);

Console.WriteLine("Enter element's indexes and I will return it's value");
Console.WriteLine("Enter element's index for rows");
int iR = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter element's index for columns");
int jC = Convert.ToInt32(Console.ReadLine());
FindByIndexes(matrix, r, c, iR, jC);