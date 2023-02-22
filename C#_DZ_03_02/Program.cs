/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
 между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

System.Console.WriteLine("Ввдите координаты x точки A ");
int[] coordsA = new int[3];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввдите координаты y точки A ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввдите координаты z точки A ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ввдите координаты x точки B ");
int[] coordsB = new int[3];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввдите координаты y точки B ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввдите координаты z точки B ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

int distensX = (int)Math.Pow(coordsA[0] - coordsB[0], 2);
int distensY = (int)Math.Pow(coordsA[1] - coordsB[1], 2);
int distensZ = (int)Math.Pow(coordsA[2] - coordsB[2], 2);

double Resalt = Math.Sqrt(distensX + distensY + distensZ);

System.Console.WriteLine("Результат: " + Math.Round(Resalt, 2));