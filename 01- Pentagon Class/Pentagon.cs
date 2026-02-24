using System;

class Pentagon
{
    private double side;


    public Pentagon(double s)
    {
        side = s;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) / 4) * side * side;
    }

    public void Display()
    {
        Console.WriteLine("\n--- PENTAGON DETAILS ---");
        Console.WriteLine("Side Length: {0:F3}", side);
        Console.WriteLine("Perimeter: {0:F3}", GetPerimeter());
        Console.WriteLine("Area: {0:F3}", GetArea());
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter side length of the pentagon: ");
        double side = double.Parse(Console.ReadLine());

        Pentagon p = new Pentagon(side);

        p.Display();
    }
}
