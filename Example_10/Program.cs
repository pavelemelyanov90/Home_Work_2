// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int num1 = number % 100;
int result = num1 / 10;

Console.WriteLine($"Вторая цифра числа {result}");



