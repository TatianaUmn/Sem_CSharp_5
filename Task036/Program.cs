// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumElemets(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            counter = counter + array[i];
        }
    }
    return counter;
}

int[] array = CreateArray(length, -99, 100); // ограничила величину выводимых чисел

PrintArray(array);

int sum = SumElemets(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: {sum}");
