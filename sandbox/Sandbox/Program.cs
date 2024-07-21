using System;

class Program
{
    static void Main(string[] args)
    {
        string greeting = "Hello Sandbox World!";
        Console.WriteLine($"{greeting}");

        List<RoundShape> myList = [new Circle(1.0), new Cylinder(1.0,2.0), new Sphere(1.0)];
        foreach (RoundShape shape in myList)
        {
            Console.WriteLine(shape.Area());
        }
    }
}