// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите чисто от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 1)
{
    Console.WriteLine("Понедельник (будний день)");
}
if(number == 2)
{
    Console.WriteLine("Вторник (будний день)");
}
if(number == 3)
{
    Console.WriteLine("Среда (будний день)");
}
if(number == 4)
{
    Console.WriteLine("Четверг (будний день)");
}
if(number == 5)
{
    Console.WriteLine("Пятница (будний день)");
}
if(number == 6)
{
    Console.WriteLine("Поздравляем, сегодня суббота - выходной!");
}
if(number == 7)
{
    Console.WriteLine("Поздравляем, сегодня воскресенье - выходной!");
}
else if(number < 1 || number > 7)
{ 
    Console.Write("Такого дня недели нет");
}  

