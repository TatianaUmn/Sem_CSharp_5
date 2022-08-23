// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void ResultMultiplication (int[] array)
{
    int n = array.Length - 1;
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < (array.Length)/ 2; i++)
        {
            Console.Write(array[i] * array[n] + " ");
            n--;
        }
    }
    else 
    {
        for (int i = 0; i < array.Length/ 2; i++)
        {
            Console.Write(array[i] * array[n] + " ");
            n--;
        } 
        Console.Write(array[(array.Length - 1)/ 2]);
    }
}

int[] array = CreateArray(length, 1, 10); // ограничила величины выводимых рандомно цифр

PrintArray(array);
ResultMultiplication(array);
