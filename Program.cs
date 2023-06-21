namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine("Circle - Area: " + circle.getArea());
            Console.WriteLine("Rectangle - Area: " + rectangle.getArea());
            Console.WriteLine("Circle - Perimeter: " + circle.getPerimeter());
            Console.WriteLine("Rectangle - Perimeter: " + rectangle.getPerimeter());

        }
    }
}