﻿// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Объявляем и запрашиваем переменные:
Console.WriteLine("Введите число, которое хотите проверить на кратность 7 И 23: ");
int number = Convert.ToInt32(Console.ReadLine());
// Проверяем условие кратности введенного числа и выводим ответ на экран:
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Число {number} кратно и 7, и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {number} не кратно и 7, и 23 одновременно");
}
// Ждём подтверждения от пользователя, что он прочёл ответ в терминале:
Console.ReadLine();