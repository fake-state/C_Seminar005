// Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Number() // Длинна массива
{
    Console.WriteLine("Задайте количество элементов в массиве: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

void FillArray(int[] array, int NumberOfEllements)
{
    for (int i = 0; i < NumberOfEllements; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int N = Number();
int[] array = new int[N];
FillArray(array, N);
Console.WriteLine($"Количество чётных чисел в массиве: {Count(array)}");