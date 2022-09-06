// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int[] result = NewRandomArray(8);
PrintArray (result);

int[] NewRandomArray(int num)
{ 
    int [] array = new int[num];
    Random rand = new Random();
    int i = 0;
    while ( i < num)
    {
        array[i] = rand.Next(-2147483648, 2147483647);
        i++;
    }
    return array;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}    
