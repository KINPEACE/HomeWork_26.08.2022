// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите первую позицию: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую позицию: ");
int N = Convert.ToInt32(Console.ReadLine());


int[,] Random()
{
    int[,] randomArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 100);
        }
    }
    return randomArray;
}
void Show(int[,] array, int pos1, int pos2)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    if (pos1 <= a && pos2 <= b && pos1 > 0 && pos2 > 0)
    {
        Console.WriteLine($"Элемент на позиции: {pos1} {pos2} = {array[pos1 - 1, pos2 - 1]}");
    }
    else
    {
        Console.WriteLine($"Элемент не найден на позиции: {pos1} {pos2}");
    }
}

Show(Random(), M, N);

