/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000);

string num2 = Convert.ToString(number);

Console.WriteLine(number);
Console.WriteLine(num2[1]);