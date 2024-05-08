// Задача: Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
using System;

class Program
{
    static void Main()
    {
        int arraySize = RequestArraySize();
        string[] inputStrings = ReadInputStrings(arraySize);
        string[] suitableStrings = FilterStrings(inputStrings);
        DisplayResults(inputStrings, suitableStrings);
    }

    static int RequestArraySize()
    {
        Console.Write("Введите количество строк в массиве: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static string[] ReadInputStrings(int arraySize)
    {
        string[] strings = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
        return strings;
    }

    static string[] FilterStrings(string[] inputStrings)
    {
        int suitableCount = CountSuitableStrings(inputStrings);
        string[] suitableStrings = new string[suitableCount];
        int index = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                suitableStrings[index] = str;
                index++;
            }
        }
        return suitableStrings;
    }

    static int CountSuitableStrings(string[] strings)
    {
        int count = 0;
        foreach (string str in strings)
        {
            if (str.Length <= 3)
                count++;
        }
        return count;
    }

    static void DisplayResults(string[] inputStrings, string[] suitableStrings)
    {
        Console.WriteLine("Исходный массив строк:");
        foreach (string str in inputStrings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Новый массив с подходящими строками (длина <= 3 символов):");
        foreach (string str in suitableStrings)
        {
            Console.WriteLine(str);
        }
    }
}