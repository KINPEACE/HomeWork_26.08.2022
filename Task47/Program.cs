// Задайте двумерный массив размером MxN, заполненый случайными вещественными числами.

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"M = {M}, N = {N}.");

double[,] array = new double[M, N];

void CreateArray(double[,] array)
{
    for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}
Console.WriteLine();
void WriteArray(double[,] array)
{
    for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            double Num = Math.Round(array[i, j], 1);
            Console.Write("(" + Num + ") ");
        }
        Console.WriteLine();
    }
}

CreateArray(array);
WriteArray(array);
