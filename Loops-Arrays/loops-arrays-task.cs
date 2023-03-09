//Task 1
//The user enters any positive number. Write a program that calculates the sum of numbers from 0 to the given number.
//Write a result of the calculation to the console.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

{
    Console.WriteLine("Task 1. Enter any positive number: ");
    int positiveNumber = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 0; i <= positiveNumber; i++)
    {
        sum += i;
    }
    Console.WriteLine($"The sum of numbers from 0 to the given number : {sum}");
}
//Task 2
//Using a while loop write the multiplication table for the number 3 to the console.
{
    Console.WriteLine("Task 2. Multiplication table for the number 3: ");
    int number = 3;
    int multiplication = 0;
    while (multiplication <= 10)
    {
        Console.WriteLine($"{number} * {multiplication} = {number * multiplication}");
        multiplication++;
    }
}

//Task 3
//Create an array of numbers [3, 5, 9, 8, 15]. Find the product of these numbers and write the result to the console.
{
    int[] numbers = { 3, 5, 9, 8, 15 };
    int result = 1;

    foreach (int value in numbers)
    {
        result *= value;
    }
    Console.WriteLine($"Task 3. Product of array [3, 5, 9, 8, 15] : {result}");
}
//Task 4
//Write a program that calculates how many times 2048 must be divided by 2 to make it less than 10.
{
    int calk = 0;
    for (int numberToDevide = 2048; numberToDevide > 10; calk++)
    {
        numberToDevide /= 2;
    }
    Console.WriteLine($"Task 4. How many times 2048 must be divided by 2 to make it less than 10 : {calk} \n");
}
//Task 5
//Create an array of strings. Write a program that analyzes a created array and, if there is a string with the value “Hello”,
//displays the word “Labas!” in console and leaves the loop once it is found.
{
    Console.Write("Task 5.");
    string[] greetings = { "Chao", "Hola", "Hello", "Cześć" };
    for (int i = 0; i < greetings.Length; i++)
    {
        if (greetings[i] == "Hello")
        {
            Console.WriteLine("Labas!");
            break;
        }
    }
}
//Task 6
//Create an array of numbers. Write a program that calculates the sum of the first and last element of an array and writes it to the console.
{
    int[] numbersArray = { 3, 5, 9, 8, 15 };
    int sum = numbersArray[0] + numbersArray[numbersArray.Length - 1];
    //int sum = 0; // solution with cycles
    //for (int i = 0; i < numbersArray.Length; m++)
    //{
    //    if (i == 0 || i == (numbersArray.Length - 1))
    //    {
    //        sum += numbersArray[i];
    //    }
    //};
    Console.WriteLine($"Task 6. Sum of the first and last element of an array: {sum}");
}
//Task 7
//Create an array of numbers. Find the sum of indexes of minimum and maximum array elements.
{
    int[] numbersArray = { 3, 5, 1, 8, 15 };
    int min = numbersArray[0];
    int max = numbersArray[0];
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > max)
        {
            max = numbersArray[i];
        }

        if (numbersArray[i] < min)
        {
            min = numbersArray[i];
        }

    }
    Console.WriteLine($"Task 7.Max number is {max} and Min number is {min}");
}
//Task 8
//Create an array of numbers and sort its elements in ascending order (without using function Sort).
{
    int[] numbersArray = { 3, 5, 1, 8, 15, 222, 55 };
    int temp;
    for (int i = 0; i < numbersArray.Length - 1; i++)
    {
        for (int j = i + 1; j < numbersArray.Length; j++)
        {
            if (numbersArray[i] > numbersArray[j])
            {
                temp = numbersArray[i];
                numbersArray[i] = numbersArray[j];
                numbersArray[j] = temp;
            }
        }
    }
    Console.WriteLine("Array sorted in ASD order: ");
    for (int i = 0; i < numbersArray.Length; i++)
    {
        Console.WriteLine(numbersArray[i]);
    }
}
//Task 9
//Write to the console a multiplication table for numbers from 1 to 10.
{ 
Console.Write("Task 9. Multiplication table for numbers from 1 to 10: \n");

for (int nmb = 1; nmb <= 10; nmb++)
{
    for (int mlt = 1; mlt <= 10; mlt++)
    {
        if (mlt <= 10)
            Console.Write($"{mlt}x{nmb} = {mlt * nmb}  ");

    }
    Console.WriteLine();
}
}
//Task 10
//Using a two-dimensional array containing numbers from 1 to 9, write to the console these numbers in the following way (....)
{
    Console.Write("Task 10. Two-dimensional array containing numbers from 1 to 9: \n");
    int[,] dimentionalArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    for (int i = 0; i < dimentionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimentionalArray.GetLength(1); j++)
        {
            Console.Write($"{dimentionalArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
//Task 11
//Create an array of numbers: int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Perform the following operations:
//1.Add the number 11 to the end of the array
//2. Add the number -1 to the beginning of the array
//3. Add number 12 to position 4
//4. Remove the first element of the array
//5. Creating an array from two arrays: the first array is array, the second is int[] array2 = { 100, 200, 300 }. 
//The resulting array must contain both array and array2 numbers
{
    int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine("Task 11. array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } \n 1. Add a number to the end:");
    Array.Resize(ref array, array.Length + 1); //12   
    array[array.Length - 1] = 11;
    foreach (int value in array)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine("\n 2. Add a number to the beginning: ");
    Array.Resize(ref array, array.Length + 1); //13
    for (int i = 1; i < array.Length; i++)
    {

        array[array.Length - i] = array[array.Length - i - 1];

    }
    array[0] = -1;
    foreach (int value in array)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine("\n 3. Add number 12 to position 4: ");
    Array.Resize(ref array, array.Length + 1); //14
    for (int i = 1; i <= array.Length - 4; i++)
    {

        array[array.Length - i] = array[array.Length - i - 1];

    }
    array[3] = 12;
    foreach (int value in array)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine("\n 4. Remove the first element of the array: ");
    for (int i = 0; i < array.Length - 1; i++)
    {

        array[i] = array[i + 1];

    }
    Array.Resize(ref array, array.Length - 1);
    foreach (int value in array)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine("\n 5. Creating an array from two arrays: ");
    int[] array2 = { 100, 200, 300 };
    int[] newArray = new int[array.Length + array2.Length]; //13+3
    for (int i = 0, f = 0; i < newArray.Length; i++)
    {
        if (i < array.Length)
        {
            newArray[i] = array[i];
        }
        else
        {
            newArray[i] = array2[f];
            f++;
        }
    }
    foreach (int i in newArray)
    {
        Console.Write($"{i} ");
    }
}