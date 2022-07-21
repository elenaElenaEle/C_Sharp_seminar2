// Напишите программу, которая принимает на вход число и проверет, 
// кратно ли оно одновременно 7 и 23.
//14 -> нет
//161 -> да

//int num = new Random().Next(1, 1000);
//Console.Write("Число " + num );
int x = 7*23;

Console.Write ("Введите число, которое хотите проверить на кратность: ");
int num = int.Parse(Console.ReadLine());

//if (num % x == 0) 
if (num % 7 == 0 & num % 23 ==0)
{
    Console.Write(" Кратно 7 и 23");
}
else
{
    Console.Write(" НЕ кратно 7 и 23");
}