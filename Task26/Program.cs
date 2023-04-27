// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int lenght = Length(number);
Console.WriteLine($"Колличество чисел в {number} = {lenght}");

int Length(int num)
{
    int count = 0;
    while (num != 0)
    {
       num /= 10;
       count++;
    }
    return count;
}