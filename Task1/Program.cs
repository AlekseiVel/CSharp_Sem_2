﻿// Напишите программу, которая принимает на вход трехзначное 
// число и на выходе показывает последнюю цифру этого числа

// int a1 = 456;
// int a2 = 782;
// int a3 = 918;

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Последнее число {number % 10}");