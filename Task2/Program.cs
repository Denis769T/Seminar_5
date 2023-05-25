// Задача 2.  Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] Array)
{

    Random rand = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rand.Next(0,20);
    }

}

void PrintArray(int[] Array)
{
    Console.Write("["+string.Join(", ", Array)+"]");
}



int n = 4;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);

Console.WriteLine();

int sum=0;
sum=arr[1]+arr[3];

Console.WriteLine(sum);
