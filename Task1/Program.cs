// Задача 1.

// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillArray(int[] Array)
{

    Random rand = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rand.Next(100,1000);
    }

}

void PrintArray(int[] Array)
{
    Console.Write("["+string.Join(", " , Array)+"]");
}



int n = 4;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);

Console.WriteLine();
int numbers=0;
int i=0;
int sum=0;
numbers=arr[0];
for (i=0;i<4;i++)
{
    numbers=arr[i]%2;
    if (numbers == 0)
     {
        sum+=1;
     }

}
Console.WriteLine(sum);
