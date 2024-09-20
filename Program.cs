using System;
using System.Runtime.InteropServices.Marshalling;

public class Program
{
    public static void Main()
    {
        do
        {
            MainMenu();
            string? readResult = Console.ReadLine();

            if (int.TryParse(readResult, out int userInput))
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please enter a radius for your circle");
                        float radius = float.Parse(Console.ReadLine() ?? "0");
                        float circleArea = CalculateAreaCircle(radius);
                        Console.WriteLine($"The area of the circle is: {circleArea}");
                        break;

                    case 2:
                        Console.WriteLine("Please enter a base length for your triangle");
                        double baseLength = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("Please enter a height for your triangle");
                        double height = double.Parse(Console.ReadLine() ?? "0");
                        double triangleArea = CalculateAreaTriangle(baseLength, height);
                        Console.WriteLine($"The area of the triangle is: {triangleArea}");
                        break;

                    case 3:
                        Console.WriteLine("Please enter a length for your rectangle");
                        double length = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("Please enter a width for your rectangle");
                        double width = double.Parse(Console.ReadLine() ?? "0");
                        double rectangleArea = CalculateAreaRectangle(length, width);
                        Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
                        break;

                    case 4:
                        Console.WriteLine("Please enter the length for the sides of your square.");
                        double side = double.Parse(Console.ReadLine() ?? "0");
                        double squareArea = CalculateAreaSquare(side);
                        Console.WriteLine($"The area of the square is: {squareArea}");
                        break;

                    case 5:
                        Console.WriteLine("Exiting");
                        return;

                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;

                }
            }
        } while (true);
    }
    public static float CalculateAreaCircle(float radius)
    {
        return (float)(Math.PI * radius * radius);
    }

    public static double CalculateAreaTriangle(double baseLength, double height)
    {
        return (double)((baseLength * height) / 2);
    }

    public static double CalculateAreaRectangle(double length, double width)
    {
        return (double)(length * width);
    }

    public static double CalculateAreaSquare(double side)
    {
        return side * side;
    }

    public static void MainMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("Please choose a shape");
        Console.WriteLine("1. Cricle");
        Console.WriteLine("2. Triangle");
        Console.WriteLine("3. Rectangle");
        Console.WriteLine("4. Square");
        Console.WriteLine("5. Exit");
    }
}
