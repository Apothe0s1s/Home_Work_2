// Задача 10. Показывает 2-ю цифру 3-значного числа.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if ((N<1000) && (N>99))
    Console.WriteLine("Вторая цифра " + (N/10)% 10);    
else
    Console.WriteLine("Не трехзначное число");