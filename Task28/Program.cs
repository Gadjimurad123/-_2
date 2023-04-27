// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int multiNumbers = MultiNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiNumbers}");

int MultiNumbers(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multi = multi * i;
        }
        
    }
    return multi;
}
