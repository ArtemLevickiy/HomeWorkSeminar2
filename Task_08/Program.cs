// Подсчитать сумму цифр в числе.

Console.WriteLine("Подсчитать сумму цифр в числе N. ");
Console.Write("Введите число N : ");
int userNumber = int.Parse(Console.ReadLine());
int Summ = 0;
while (userNumber > 0)
{
    Summ = Summ + userNumber% 10;
    userNumber = userNumber / 10;
}

Console.WriteLine(Summ);