/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
System.Console.WriteLine("Введите пятизначное число: ");
string? Namber = Console.ReadLine();
if (Namber?.Length == 5 && Namber[0] == Namber[4] && Namber[1] == Namber[3])
{
    System.Console.WriteLine($"Число: {Namber}-зеркальнное");
}
else if (Namber?.Length == 5 && Namber[0] != Namber[4] && Namber[1] != Namber[3])
{
    System.Console.WriteLine($"Число: {Namber}-не зеркальнное");
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное чесло");
}
