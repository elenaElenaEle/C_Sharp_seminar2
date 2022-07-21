// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num == 0 || num > 7)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else {
if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной");
}
else{
    Console.WriteLine("Будний");
}}