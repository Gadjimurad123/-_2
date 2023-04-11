// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remainder(numberA, numberB);

if (result == 0)
{
    Console.Write("КРАТНОЕ");
}
else
{
    Console.Write($"НЕ КРАТНОЕ, остаток {result}");
}

int Remainder(int numA, int numB)
{
    return numA % numB;
}

