// Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа
// выводит остаток от деления

int numberA = 0, numberB = 0, remainder = 0;

Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
numberB = int.Parse(Console.ReadLine()!);

remainder = numberA % numberB;

if(remainder == 0)
{
    Console.WriteLine($"Число {numberA} кратно числу {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не кратно числу {numberB}");
}