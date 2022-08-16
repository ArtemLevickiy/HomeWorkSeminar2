// Найти кубы чисел от 1 до N.

Console.WriteLine("Найти кубы чисел от 1 до N ");
Console.Write("Введите число N : ");
int userNumber = int.Parse(Console.ReadLine());
int count = 1;
while (count <= userNumber)
{
    Console.WriteLine(count * count * count);
    count++;
}