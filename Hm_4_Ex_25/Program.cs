// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Вводим переменные
Console.WriteLine("Введите число A");
string? check = Console.ReadLine();
ValidateInput (check);
int a = Convert.ToInt32(check);
Console.WriteLine("Введите число B");
check = Console.ReadLine();
ValidateInput (check);
int b = Convert.ToInt32(check);

// Выполняем цикл
int result = a;
for (int i = 1; i < b; i++)
{
    result = a * result;
} 

Console.WriteLine(result);

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
