using System;

public class Program
{
    public static void Main()
    {
        float radius = 5.5f;

        double baseLength = 3.55;
        double height = 5.55;

        double length = 6.77;
        double width = 8.99;

        double side = 2.34;

        float circleArea = CalculateAreaCircle(radius);
        double triangleArea = CalculateAreaTriangle(baseLength, height);
        double rectangleArea = CalculateAreaRectangle(length, width);
        double squareArea = CalculateAreaSquare(side);

        Console.WriteLine($"The area of the circle is: {circleArea}");
        Console.WriteLine($"The area of the triangle is: {triangleArea}");
        Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
        Console.WriteLine($"The area of the square is: {squareArea}");
    }
    public static float CalculateAreaCircle(float radius)
    {
        return (float)(Math.PI * radius * radius);
    }

    public static double CalculateAreaTriangle(double baseLength, double height)
    {
        return (double)((baseLength * height) /2);
    }

    public static double CalculateAreaRectangle(double length, double width)
    {
        return (double)(length * width);
    }

    public static double CalculateAreaSquare(double side)
    {
        return side * side;
    }
}
