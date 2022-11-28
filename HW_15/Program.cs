// Задача 15. Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 5 && day < 8)
    Console.WriteLine("Да");
if(day > 0 && day < 6)
    Console.WriteLine("Нет");
if(day < 1 || day > 7)
    Console.WriteLine("Не день недели");