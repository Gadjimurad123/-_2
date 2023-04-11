// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {number}");
int CenterDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int answer = firstDigit * 10 + thirdDigit;
    return answer;
}
int centerDigit = CenterDigit(number);
Console.WriteLine($"Двузначное число {CenterDigit(number)}");