// Задача 3.Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите пять элементов массива, через пробел :");
int[] massiv = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
//Console.WriteLine("[" + string.Join(", ", coordsA) + "]");
int min = massiv[0];
int max = massiv[0];
int sum = 0;

for (int i = 1; i < 5; i++)
{
    if (min > massiv[i])
    {
        min = massiv[i];
    }

    if (max < massiv[i])
    {
        max = massiv[i];
    }

}
sum = max - min;
Console.WriteLine($"Минимальный элемент массива : {min}");
Console.WriteLine($"Максимальный элемент массива : {max}");
Console.WriteLine($"Разница между минимальным и максимальны м элементом массива : {sum}");
