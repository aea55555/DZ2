﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1 = num/10;
// int num2 = num1%10;

// Console.WriteLine(num2);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введи число:");
// int num = Convert.ToInt32(Console.ReadLine());

// while (num > 999)
// {
//     num /= 10;
// }

// Console.WriteLine(num % 10);




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введи число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 6 || num == 7)
// {
//     System.Console.WriteLine("Выходной");
// }
// else
// {
//     System.Console.WriteLine("Будний");
// }