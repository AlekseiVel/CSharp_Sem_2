// Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет!

int numberA = 0, middle_result = 0, third = -1;

Console.Write("Введите число: ");
numberA = int.Parse(Console.ReadLine()!);

if(numberA >=100 && numberA <= 999)
{
    third = numberA % 10;
    Console.WriteLine($"Третья цифра числа {numberA}: {third}");
}

while(middle_result >= 100 && middle_result <= 999)
{
    middle_result = numberA / 10;
}
third = middle_result % 10;
Console.WriteLine($"Третья цифра числа {numberA}: {third}");
if(numberA >= 1 && numberA <= 99)
{
    Console.WriteLine($"У числа {numberA} нет второй цифры");
}
