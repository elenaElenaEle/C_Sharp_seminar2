﻿// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine("Число " + num );
num = (num % 100) /10;
Console.WriteLine("Вторая цифра числа " + num);

************************************************************************************************************************************************
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