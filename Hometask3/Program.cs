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
int mid_res = 0;
if(numberA >= 1000)
{
for(mid_res = numberA; 
    mid_res >= 100 && mid_res <= 1000; 
    third = mid_res % 10)
    {
        Console.WriteLine($"Третья цифра числа {numberA}: {third}");
    }
}