// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.
// Например: 
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(n1, Math.Max(n2, n3)));