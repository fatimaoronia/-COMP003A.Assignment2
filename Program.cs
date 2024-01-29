/*
 * Author: Fatima Oronia
 * Course: COMP-003A
 * Purpose: 
 * Reference: 
 */

namespace COMP003A.Assignment2;
class Program
{
    static void Main(string[] args)
    {

        // Console Section
        Console.Title = "COMP-003A - Assignment 2";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        // String Section
        Console.WriteLine("Enter your First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your Middle Name:");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter your Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter your Age in 2023:");
        string inputAge = Console.ReadLine();
        int yearBorn = 2023 - Convert.ToInt32(inputAge);

        Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

        // Math Section
        Console.WriteLine("Enter an integer:");
        int integer1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another integer:");
        int integer2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
        Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
        Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");

        if (integer2 != 0)
        {
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        // Circle Area & Circumference Calculator Section
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine($"The area of the circle is: {area}");
        Console.WriteLine($"The circumference of the circle is: {circumference}");

        Console.ReadLine(); // Keep the console window open
    }
}
