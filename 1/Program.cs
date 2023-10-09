

using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

void arrFull(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите значение для {i} элемента массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.Write("Введенный массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int surchNegativeCount(int[] arr)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] < 0)
        index ++;
    }
    return index;
}


System.Console.Write("Введите число элемнотов в массиве: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLength];
arrFull(array);
System.Console.WriteLine($"Элементов с отрицательным значением: {surchNegativeCount(array)}");
