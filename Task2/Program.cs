﻿// Напишите программу, которая выводит случайное число 
// из отрезка [10,99] и показывает наибольшую цифру числа

int number = new Random().Next(10,100);

Console.WriteLine($"Случайное число: {number}");

int first = number / 10;
int second = number % 10;

if(first > second)
{
    Console.WriteLine("Наибольшая цифра в нем: " + first);
}
else
{
    Console.WriteLine("Наибольшая цифра в нем: " + second);
}