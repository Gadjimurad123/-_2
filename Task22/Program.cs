// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Pow2(number);


void Pow2 (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write(count + " " );
        Console.WriteLine(Math.Pow(count, 2));
        count ++;
    }
}
