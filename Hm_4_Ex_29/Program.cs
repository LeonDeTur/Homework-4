// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

NewRandomArrayFrom(8);

void NewRandomArrayFrom(int arrayLength)
{ 
    int [] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rand.Next(-2147483648, 2147483647);
    }

    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine(array[i]);
    }
}


