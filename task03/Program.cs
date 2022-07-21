// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

Console.Write ("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
//int num1 = new Random().Next(100, 1000);
//Console.WriteLine("Первое число " + num1);

Console.Write ("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
//int num2 = new Random().Next(100, 1000);
//Console.WriteLine("Второе число " + num2);

if ((num2 % num1) == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine(num2 % num1);
}