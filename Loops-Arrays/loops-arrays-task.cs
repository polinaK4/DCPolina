//Task 1
//The user enters any positive number. Write a program that calculates the sum of numbers from 0 to the given number.
//Write a result of the calculation to the console.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Task 1. Enter any positive number: ");
int positiveNumber = int.Parse(Console.ReadLine());
int sum1 = 0;
for (int i = 0; i <= positiveNumber; i++)
{
    sum1 += i;
}
Console.WriteLine($"The sum of numbers from 0 to the given number : {sum1}");

//Task 2
//Using a while loop write the multiplication table for the number 3 to the console.

Console.WriteLine("Task 2. Multiplication table for the number 3: ");
int number2 = 3;
int multiplication2 = 0;
while (multiplication2 <= 10)
{
    Console.WriteLine($"{number2} * {multiplication2} = {number2 * multiplication2}");
    multiplication2++;
}

//Task 3
//Create an array of numbers [3, 5, 9, 8, 15]. Find the product of these numbers and write the result to the console.

int[] numbers3 = { 3, 5, 9, 8, 15 };
int result3 = 1;

foreach (int value in numbers3)
{
    result3 *= value;
}
Console.WriteLine($"Task 3. Product of array [3, 5, 9, 8, 15] : {result3}");

//Task 4
//Write a program that calculates how many times 2048 must be divided by 2 to make it less than 10.

int calk4 = 0;
for (int numberToDevide = 2048; numberToDevide > 10; calk4++)
{
    numberToDevide /= 2;
}
Console.WriteLine($"Task 4. How many times 2048 must be divided by 2 to make it less than 10 : {calk4} \n");

//Task 5
//Create an array of strings. Write a program that analyzes a created array and, if there is a string with the value “Hello”,
//displays the word “Labas!” in console and leaves the loop once it is found.

Console.Write("Task 5.");
string[] greetings5 = { "Hola", "Hello", "Cześć" };
for (int l = 0; l < greetings5.Length; l++)
{
    if (greetings5[l] == "Hello")
        break;
    Console.WriteLine("Labas!");

}

//Task 6
//Create an array of numbers. Write a program that calculates the sum of the first and last element of an array and writes it to the console.

int[] numbersArray6 = { 3, 5, 9, 8, 15 };
int sum6 = 0;
for (int m = 0; m < numbersArray6.Length; m++)
{
    if (m == 0 || m == (numbersArray6.Length - 1))
        sum6 += numbersArray6[m];

};
Console.WriteLine($"Task 6. Sum of the first and last element of an array: {sum6}");

//Task 7
//Create an array of numbers. Find the sum of indexes of minimum and maximum array elements.

int[] numbersArray7 = { 3, 5, 1, 8, 15 };
int min7 = numbersArray7[0];
int max7 = numbersArray7[0];
for (int q = 0; q < numbersArray7.Length; q++)
{
    if (numbersArray7[q] > max7)
    {
        max7 = numbersArray7[q];
    }

    if (numbersArray7[q] < min7)
    {
        min7 = numbersArray7[q];
    }

}
Console.WriteLine($"Task 7.Max number is {max7} and Min number is {min7}");

//Task 8
//Create an array of numbers and sort its elements in ascending order (without using function Sort).

int[] numbersArray8 = { 3, 5, 1, 8, 15, 222, 55 };
int temp8;
for (int v = 0; v < numbersArray8.Length - 1; v++)
{
    for (int w = v + 1; w < numbersArray8.Length; w++)
    {
        if (numbersArray8[v] > numbersArray8[w])
        {
            temp8 = numbersArray8[v];
            numbersArray8[v] = numbersArray8[w];
            numbersArray8[w] = temp8;
        }
    }
}
Console.WriteLine("Array sorted in ASD order: ");
for (int v = 0; v < numbersArray8.Length; v++)
{
    Console.WriteLine(numbersArray8[v]);
}

//Task 9
//Write to the console a multiplication table for numbers from 1 to 10.

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

//Task 10
//Using a two-dimensional array containing numbers from 1 to 9, write to the console these numbers in the following way (....)

Console.Write("Task 10. Two-dimensional array containing numbers from 1 to 9: \n");
int[,] dimentionalArray10 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int rows10 = dimentionalArray10.GetUpperBound(0) + 1;
int columns10 = dimentionalArray10.Length / rows10;

for (int i = 0; i < rows10; i++)
{
    for (int j = 0; j < columns10; j++)
    {
        Console.Write($"{dimentionalArray10[i, j]} \t");
    }
    Console.WriteLine();
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

int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Task 11. array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } \n 1. Add a number to the end:");
Array.Resize(ref array, array.Length + 1); //12   
array[array.Length - 1] = 11;
foreach (int z in array)
{
    Console.Write($"{z} ");
}

Console.WriteLine("\n 2. Add a number to the beginning: ");
Array.Resize(ref array, array.Length + 1); //13
for (int u = 1; u < array.Length; u++)
{

    array[array.Length - u] = array[array.Length - u - 1];

}
array[0] = -1;
foreach (int i in array)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n 3. Add number 12 to position 4: ");
Array.Resize(ref array, array.Length + 1); //14
for (int u = 1; u <= array.Length - 4; u++)
{

    array[array.Length - u] = array[array.Length - u - 1];

}
array[3] = 12;
foreach (int i in array)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n 4. Remove the first element of the array: ");

int[] newArray3 = new int[array.Length - 1]; //14-1
for (int u = 1; u < array.Length - 1; u++)
{

    newArray3[newArray3.Length - u] = array[array.Length - u];

}
foreach (int i in newArray3)
{
    Console.Write($"{i} ");
}
// Normal solution:)
//array = array.Skip(1).ToArray();
//foreach (int i in array)
//{
//    Console.Write($"{i} ");
//}

Console.WriteLine("\n 5. Creating an array from two arrays: ");
int[] array2 = { 100, 200, 300 };
int[] newArray5 = new int[newArray3.Length + array2.Length]; //13+3
for (int i = 0, f = 0; i < newArray5.Length; i++)
{
    if (i < newArray3.Length)
    {
        newArray5[i] = newArray3[i];
    }
    else
    {
            newArray5[i] = array2[f];
            f++;
    }
}
foreach (int i in newArray5)
{
    Console.Write($"{i} ");
}
// Normal solution:)
//int[] resultArray = array.Concat(array2).ToArray();
//foreach (int i in resultArray)
//{
//    Console.Write($"{i} ");
//}