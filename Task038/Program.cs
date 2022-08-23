// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

Console.Write($"Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] CreateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*100; // создается массив рандомных вещественных чисел от 10 до 100
        array[i] = Math.Round(array[i], 2);   // ограничила вывод числа двумя цифрами после запятой
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] array = CreateArray(length);

double maxNumber = array[0];
double minNumber = array[0];
for (int i = 0; i < length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

PrintArray(array);
Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным {minNumber} значениями = {maxNumber - minNumber}");
