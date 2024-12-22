// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Sum Calculator");
        Console.WriteLine("Enter number 1:");
        double num1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        double num2=Convert.ToDouble(Console.ReadLine());
        double sum=num1+num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }
}