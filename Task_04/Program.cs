// Найти расстояние между точками в пространстве 2D/3D.

Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D. ");
Console.Write("Введите координаты x точки A : ");
int userNumberX1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y точки A : ");
int userNumberY1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y точки A : ");
int userNumberZ1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты x точки B : ");
int userNumberX2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y точки B : ");
int userNumberY2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y точки B : ");
int userNumberZ2 = int.Parse(Console.ReadLine());

double Rast = Math.Sqrt((userNumberX2 - userNumberX1) * (userNumberX2 - userNumberX1) + (userNumberY2 - userNumberY1) * (userNumberY2 - userNumberY1) + (userNumberZ2 - userNumberY1) * (userNumberZ2 - userNumberY1));

Console.Write("Расстояние между точками A и B " + Rast);