// Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет!

int numberA = 0, third = 0;

Console.Write("Введите число: ");
numberA = int.Parse(Console.ReadLine()!);

if(numberA >=100 && numberA <= 999)
{
    third = numberA % 10;
    Console.WriteLine($"Третья цифра числа {numberA}: {third}");
}
if(numberA <= 99)
{
    Console.WriteLine($"У числа {numberA} нет второй цифры");
}

if(numberA >= 1000)
{
    int mid = numberA;
    while(mid > 999)
    {
        mid = mid / 10;
    }
    third = mid % 10;

Console.WriteLine($"Третья цифра числа {numberA}: {third}");
}
