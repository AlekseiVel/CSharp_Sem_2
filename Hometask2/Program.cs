// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

int number = new Random().Next(100,1000);
int first = -1, third = -1;

Console.WriteLine($"Случайное число: {number}");

first = number / 100;
third = number % 10;

Console.WriteLine($"Вторая цифра удалена, результат: {first}{third}");