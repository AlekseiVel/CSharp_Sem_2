// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

int number = 0, first = 0, third = 0;

Console.Write("Введите трехзначное число: ");
number = int.Parse(Console.ReadLine()!);

first = number / 100;
third = number % 10;

Console.WriteLine($"Вторая цифра удалена, результат: {first}{third}");