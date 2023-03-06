// homework3
// 1. Create a variable "num" with a value of 20. Add the number 5 to it. Adding is done by shorthand for adding a number to a variable.
// Display information in the following format: "Variable: var ", where var is your variable num.

using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Runtime.InteropServices.JavaScript;
using System;

var num = 20;
Console.WriteLine($"Task 1. Variable + 5 = {num += 5}");

//2. Write a program that will receive a four-digit number from the user that represents n days.
//Calculate and output to the console how many given numbers of days in years, months, days. (5 years , 2 months , 1 day ).

Console.Write("Task 2. Write four-digit number of days to convert them to years and month: ");
ushort daysNumber = ushort.Parse(Console.ReadLine());
ushort years = (ushort)(daysNumber / 365);
ushort months = (ushort)((daysNumber % 365) / 30);
ushort days = (ushort)((daysNumber % 365) % 30);
Console.WriteLine($"{daysNumber} days are equal to {years} year(s), {months} month(s) and {days} day(s)");


//3. Create a program that will take a number (n) entered by the user and return the result as (n + n * 2)

Console.Write("Task 3. Write number N: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine($"'N + N * 2' will be {n + n * 2}");

//4. Create variables to hold the following values: -34, 4, ' Hello ', ' R ', 23.093433222, 40000, true, 0.
//Think about the data types for the variables so that they fit each value as best as possible.

sbyte a = -34;
byte b = 4;
string c = "Hello";
char d = 'R';
float e = 23.093433222F;
ushort f = 40000;
bool g = true;
byte h = 0;

//5. Get data from the user and write it to variables with data types: short, ulong, char, double. 

Console.Write("Task 5. Write short, ulong, char, double: ");
short nShort = Convert.ToInt16(Console.ReadLine());
ulong nUlong = Convert.ToUInt64(Console.ReadLine());
char nChar = char.Parse(Console.ReadLine());
double nDouble = double.Parse(Console.ReadLine());
Console.WriteLine($"Short: {nShort}, Ulong: {nUlong}, Char: {nChar}, Double: {nDouble}");


//6. Create a variable with a value of -5. Perform operations on it: multiply it by 7; perform a decrement on the one).

//option 1 - operations one by one
Console.Write("Task 6. option 1 - operations one by one: ");
var a1 = -5;
Console.WriteLine($"'a' multiplied by 7: {a1 *= 7}, Decrement: {--a1}");

//option 2 - separate operations
var b1 = -5;
var b1Multiplied = b1 * 7;
var b1Decrement = --b1;
Console.WriteLine($"Option 2 - separate operations. 'b' multiplied by 7: {b1Multiplied}, Decrement: {b1Decrement}");

//7. Ask the user to enter a number. Display information about whether a number is even or not

Console.Write("Task 7. Write any number: ");
double randomNumber = double.Parse(Console.ReadLine());
if (randomNumber % 2 == 0)
{
    Console.WriteLine($"Your number is even");
}
else
{
    Console.WriteLine($"Your number is not even");
};

//8. *Ask the user to enter a number and assign the entered value to variable A.
//Using the if construct else, create a test that will display the word " Working " if variable A is less than 50 and not equal to 37,
//but not less than or equal to 32.
//Add an OR test to the condition itself: if the number A is equal to 0 or 15, then the condition will also be fulfilled.

Console.Write("Task 8. Write any number: ");
double variableA = double.Parse(Console.ReadLine());
if ((variableA < 50 && variableA != 37 && variableA > 32 && variableA != 32) || variableA == 0 || variableA == 15)
{
    Console.WriteLine($"Working");
}
else
{
    Console.WriteLine($"Condition is not working");
};

//9. *Ask the user to enter two numbers as well as an arithmetic operation (+, -, *, /).
//Depending on the character that will be entered, perform mathematical operations on the numbers that the user has entered.
//For checks data use switch case statement.

Console.Write("Task 9. Write 2 numbers: ");
double variableOne = double.Parse(Console.ReadLine());
double variableTwo = double.Parse(Console.ReadLine());
Console.Write("Write which action you want to perform with your numbers: + - * / : ");
char variableChar = char.Parse(Console.ReadLine());
switch (variableChar)
{
    case '+':
        Console.WriteLine($"{variableOne + variableTwo}");
        break;

    case '-':
        Console.WriteLine($"{variableOne - variableTwo}");
        break;

    case '*':
        Console.WriteLine($"{variableOne * variableTwo}");
        break;

    case '/':
        Console.WriteLine($"{variableOne / variableTwo}");
        break;

}
