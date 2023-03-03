// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int Number() // Длинна массива
{
    Console.WriteLine("Задайте количество элементов в массиве: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 2; i < array.Length; i++)
    {
        if(i % 2 == 0) count++;
    }
    return count;
}

int[] array = new int[Number()];
FillArray(array);
Console.WriteLine($"Количество чисел на четных позициях: {Count(array)}");