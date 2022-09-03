// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число");
string? check = Console.ReadLine();
ValidateInput (check);
int num = Convert.ToInt32(check);

Console.WriteLine("Сумма цифр равна: " + CountSum (num));

// Методы
void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Error: Пожалуйста, введите целое число .");
        Environment.Exit(0);
    }
}

int CountSum(int input)
{
    int result = 0;
    while (input > 1)
    {
        int summand = input % 10;
        result = result + summand;
        input = (int) input / 10;
    }
    return result;
}