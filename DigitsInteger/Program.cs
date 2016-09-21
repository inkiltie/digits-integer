using System;
public class DigitsInteger
{
    public static void Main(string[] args)
    {
        int number;
        int digit1;
        int digit2;
        int digit3;
        int digit4;
        int digit5;

        Console.Write("Enter 5 digits: ");
        number = Convert.ToInt32(Console.ReadLine());

        digit1 = number / 10000;
        digit2 = number % 10000 / 1000;
        digit3 = number % 1000 / 100;
        digit4 = number % 100 / 10;
        digit5 = number % 10;

        Console.WriteLine("{0}   {1}   {2}   {3}   {4}", digit1, digit2, digit3, digit4, digit5);
    }
}