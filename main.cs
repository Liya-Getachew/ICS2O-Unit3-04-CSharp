// Created by: liya getachew
// Created on: Nov 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;

        Console.WriteLine("This program converts fahrenheit to celsius.");

        Console.WriteLine("Enter temperature in °F: ");
        Console.WriteLine("");

        Console.Write("fahrenheit (°F) = ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("");
        Console.WriteLine("Celsius = " + celsius.ToString("0.00") + " °C.");

        Console.WriteLine("\nDone.");
    }
}