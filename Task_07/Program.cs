// Определить количество цифр в числе.

Console.WriteLine("Определить количество цифр в числе N. ");
Console.Write("Введите число N : ");
int userNumber = int.Parse(Console.ReadLine());
int userNumber2 = userNumber;
int digits = 0; // кол-во цифр
while (userNumber2 > 0)
{
  digits++;
  userNumber2 = userNumber2/10;
}
Console.WriteLine(digits);