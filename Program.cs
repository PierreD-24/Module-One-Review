using System;

public class Program
{
    public static void Main()
    {
        float radius = 5.5f;
        float area = CalculateAreaCircle(radius);
        Console.WriteLine($"The area of the circle is: {area}");
    }
    public static float CalculateAreaCircle(float radius)
    {
        return (float)(Math.PI * radius * radius);
    }
}
