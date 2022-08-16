// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.Write("Введите число обозначающее день недели[1;7] ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber <= 5)
{
    Console.Write(+userNumber + " не является выходным ");
}
if (userNumber > 5 && userNumber < 8)
{
    Console.Write(+userNumber + " Является выходным ");
}
