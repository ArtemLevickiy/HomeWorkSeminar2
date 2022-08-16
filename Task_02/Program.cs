// По двум заданным числам проверять является ли одно квадратом другого.

Console.Write("Введите число A : ");
int userNumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B : ");
int userNumberB = int.Parse(Console.ReadLine());

if (userNumberA != userNumberB * userNumberB && userNumberB != userNumberA * userNumberA)
{
    Console.Write("Ни число " + userNumberA + " ни число " + userNumberB + " не являются квадратами второго. ");
}
if (userNumberA == userNumberB * userNumberB)
{
    Console.Write("Число " + userNumberA + " = квадрату числа " + userNumberB);
}
if (userNumberB == userNumberA * userNumberA)
{
    Console.Write("Квадрат числа " + userNumberA + " = числу " + userNumberB);
}
