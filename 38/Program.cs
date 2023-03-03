// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int Number() // Длинна массива
{
    Console.WriteLine("Задайте количество элементов в массиве: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int num = new Random().Next(-100, 100); // Задаем рандомное число
        array[i] = new Random().NextDouble() + num; // Прибавляем к числу, чтобы
                                                    // не было только от 0 до 1
    }
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)    
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double[] array = new double[Number()];
FillArray(array);
Console.WriteLine($"Максимальное число: {Max(array)}");
Console.WriteLine($"Минимальное число: {Min(array)}");
Console.WriteLine($"Разница между min и max = {Max(array) - Min(array)}");