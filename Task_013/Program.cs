﻿//напишите программу, которая принимает на вход два числа и проверяет, 
//является ли второе число кратным первому
Console.Clear();
Console.Write("Введите первое число: ");

int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else 
{
    int N = num1 / num2;

Console.WriteLine("не кратно");
Console.WriteLine($"остаток {num1 - num2*N}");
}