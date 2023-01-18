// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. (Цифры считать справа налево)

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int num1 = number % 1000;
int result = num1 / 100;
if(result == 0)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    Console.WriteLine($"Третья цифра {result}");
}





