// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите размер строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1,10);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
mas(m, n);
if (m2 < 1 || m2 > m ||  n2 < 1 || n2 >m)
    Console.Write("Такого элемента нет");
    Console.Write($"Значение элемента равно: {randomArray[m2 - 1, n2 - 1]} ");
