/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
string threeDigitNumber = Console.ReadLine();

if (threeDigitNumber.Length < 3)
{
    Console.WriteLine($"В числе {threeDigitNumber} меньше трёх цифр.");
}
else
{
    Console.WriteLine($"Третья цифра числа {threeDigitNumber} - {threeDigitNumber[2]}.");
}
