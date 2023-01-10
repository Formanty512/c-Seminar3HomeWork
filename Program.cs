// Задача 23

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void GetCubes (int n)
// {
//     int count = 1;
//     while (count <= n)
//     {
//         Console.Write((count*count*count) + " ");
//         count++;
//     }
// }
// Console.Write("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// GetCubes(n);



// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int temp = number;
// int reverse = 0;

// while (temp != 0)
// {
//     reverse = (reverse * 10) + (temp % 10);
//     temp = temp / 10;

// }
//  if (number == reverse)
//  {
//     Console.WriteLine("The number is Palindrome");
//  }
//  else
//  {
//     Console.WriteLine("The number is not a Palindrome");
//  }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (double xa, double ya, double za, double xb, double yb, double zb)
{
    double xCoor = xb - xa;
    double yCoor = yb - ya;
    double zCoor = zb - za;
    double dist = Math.Sqrt(xCoor * xCoor + yCoor * yCoor + zCoor * zCoor);
    return dist;
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Distance(x1, y1, z1, x2, y2, z2));
