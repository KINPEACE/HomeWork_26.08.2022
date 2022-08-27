// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create()
{
    int[,] array = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
    return array;
}
double[] Show(int[,] arr)
{
    double sum = 0;
    int size = arr.GetLength(0);
    double[] average = new double[arr.GetLength(1)];
    int M = 0;
    for(int i = 0; i < average.Length; i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, M];
            for(int N = 0; N < arr.GetLength(1); N++)
            {
                average[i] = sum /size;
            }
        }
        M++;
        sum = 0;
    }
    return average;
}

void PrintShow(double[] Ar)
{
    for(int i = 0; i < Ar.Length; i++)
    {
        Console.Write(Math.Round(Ar[i], 2) + "| ");
    }
    Console.WriteLine();
}
PrintShow(Show(Create()));