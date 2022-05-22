// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Y = 1;
int sum = 0;
while (Y <= N)
{
    sum = Y*Y*Y;
    Console.WriteLine($"{Y}*{Y}*{Y} = {sum}");
    Y++;
}
