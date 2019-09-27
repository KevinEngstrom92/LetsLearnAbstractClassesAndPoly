using System;

namespace InheritanceAndPolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape litenFyrkant = new Square("black", 20);
            Shape storFyrkant = new Square("Green", 100);
            Shape circle = new Circle("Yellow", 30);
            Shape rectangle = new Rectangle("Blue", 20, 5);

            Console.WriteLine($"{litenFyrkant.Color} Fyrkant med Arean {litenFyrkant.Area()}");
            Console.WriteLine($"{storFyrkant.Color} Fyrkant med Arean {storFyrkant.Area()}");
            Console.WriteLine($"{circle.Color} Cirkel med Arean {circle.Area()}");
            Console.WriteLine($"{rectangle.Color} Fyrkant med Arean {rectangle.Area()}");
        }
    }
}
