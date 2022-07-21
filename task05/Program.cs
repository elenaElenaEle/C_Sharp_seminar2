// Напишите программу, которая выводит третью цифру заданного числа или сообщает что третьего числа нет.

int num = new Random().Next();
Console.WriteLine("Число " + num );

if (num < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (num >= 1000)
{
    num = num / 10;
}

int num1 = num % 10;
Console.WriteLine(num1);}