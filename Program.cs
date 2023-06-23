// Задача 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num, r, sum =0, t;
int num;
Console.WriteLine("Введите пятизначное число: ");
string s = Console.ReadLine();
num = Convert.ToInt32(s);
if (s.Length == 5)
{
  Console.WriteLine("Число явл пятизначныm");
  string s2 = Reverse(s);
  Console.WriteLine(s2);
  if (s.Equals(s2))
  {
    Console.WriteLine($"Число {s} явл полиндромом"); 
  }
  else 
  {
    Console.WriteLine($"Число {s} не явл полиндромом"); 
  }
} else
Console.WriteLine("Число не пятизначное!");

static string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int inputN(string message)
{
  System.Console.Write($"{message} > ");
  int value;
  if(int.TryParse(Console.ReadLine(), out value))
  {
    return value;
  }
  System.Console.WriteLine("Вы ввели не число");
  Environment.Exit(1);
  return 0;
}
int x1 = inputN("Введите точку координата Х точки А ");
int y1 = inputN("Введите точку координата y точки А ");
int z1 = inputN("Введите точку координата z точки А ");
int x2 = inputN("Введите точку координата Х точки B ");
int y2 = inputN("Введите точку координата y точки B ");
int z2 = inputN("Введите точку координата z точки B ");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
  int deltax = x2 - x1;
  int deltay = y2 - y1;
  int deltaz = z2 - z1;
  return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}

double r = dis(x1, y1, z1, x2, y2, z2);

System.Console.Write($"Расстояние между точками А и B равно {r:F2}");


// Задача 3.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: \n ");
for(int i = 1; i <= n; i ++)
{
  int k = i*i*i;
  Console.Write($"{k}");
}