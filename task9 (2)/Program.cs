﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write ("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b || b == a*a)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно, ни другое число не являются квадратом другого");  
}