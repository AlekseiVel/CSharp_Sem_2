﻿// Напишите программу, которая принимает на вход трехзначное 
// число и на выходе показывает последнюю цифру этого числа

int a1 = 456;
int a2 = 782;
int a3 = 918;

a1 = a1 % 10;
a2 = a2 % 10;
a3 = a3 % 10;

Console.WriteLine($"{a1} {a2} {a3}");