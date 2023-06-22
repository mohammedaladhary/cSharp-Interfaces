using static interfaces.ISquare;

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

            Square square = new Square(3);
            Square square1 = new Square(2);

            Console.WriteLine(square.CompareTo(square1));

            int[] i = {1,2,3,4,5,6,7};
            for(int a = 0; a < i.Length; a++)
            {
                Console.WriteLine(i[a]);
            }
            Console.WriteLine("Printing using for each");
            Person[] people = new Person[3];
            people[0] = new Person("Mohammed", "16-0450", 24);
            people[1] = new Person("Ahmed", "25-4324", 54);
            people[2] = new Person("Hamed", "16-4532", 10);

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }


        }
    }
}