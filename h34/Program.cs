﻿// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[4];

int count=0;
for ( int i=0; i< arr.Length; i++ ) 
{
    arr[i]=new Random().Next(100,1000); // рандомный массив от 100 до 999 включительно

        if (arr[i]%2==0) // если элемент делится на 2 
        {
           count++; // то увеличиваем счетчик
         
         }
         
}
Console.WriteLine("Массив: ");
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine($"колличество четных чисел в массиве = {count}");