// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

//Понедельник(рабочий) = 1;
//Вторник(рабочий) = 2;
//Среда(рабочий) = 3;
//Четверг(рабочий) = 4;
//Пятница(рабочий) = 5;
//Суббота(выходной) = 6;
//Воскресенье(выходной) = 7;

Console.WriteLine("ведите номер дня недели? (1-7)");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:
    {
        Console.WriteLine("Понедельник(рабочий)");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вторник(рабочий)");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда(рабочий)");
        break;
    }    
    case 4:
    {
        Console.WriteLine("Четверг(рабочий)");
        break;
    }
    case 5:
    {
        Console.WriteLine("Пятница(рабочий)");
        break;
    }
    case 6:
    {
        Console.WriteLine("Суббота - ура, выходной!!!");
        break;
    }
    case 7:
    {
        Console.WriteLine("Воскресенье - ура, выходной!!!");
        break;
    }
}