﻿// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// Например: 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
        Console.WriteLine("{0} -> {1}",input, input[1]);
    }