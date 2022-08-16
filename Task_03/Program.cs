// Задать номер четверти, показать диапазоны для возможных координат.

Console.Write("Введите номер четверти [1;4] : ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber > 0 && userNumber <= 4)
{
    if (userNumber == 1)
    {
        Console.WriteLine("Координаты X > 0");
        Console.WriteLine("Координаты y > 0");
    }
    if (userNumber == 2)
    {
        Console.WriteLine("Координаты X > 0");
        Console.WriteLine("Координаты y < 0");
    }
    if (userNumber == 3)
    {
        Console.WriteLine("Координаты X < 0");
        Console.WriteLine("Координаты y < 0");
    }
    if (userNumber == 4)
    {
        Console.WriteLine("Координаты X < 0");
        Console.WriteLine("Координаты y > 0");
    }
}
else
{
    Console.WriteLine("Неправильное число введено. ");
}