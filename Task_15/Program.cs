
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int day;
while (true) // проверка на корректность ввода целого числа
{
Console.WriteLine("ВВЕДИТЕ ДЕНЬ НЕДЕЛИ");
if (int.TryParse(Console.ReadLine(), out day))
    break;
Console.WriteLine("Число не является целым");
}

if ((day < 1) && (day > 7)) //проверка на день недели
    Console.WriteLine("введеное число не день недели");
else if ((day == 6) || (day == 7))
    Console.WriteLine("Ура, Выходной!!!");
else
Console.WriteLine("Рабочий день");
