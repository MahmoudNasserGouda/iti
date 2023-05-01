namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(10, 10);
            Console.WriteLine(s);
            s.Display();

            Rectangle r = new Rectangle(10, 10, 10, 10);
            Console.WriteLine(r);
            r.Display();

            Circle c = new Circle(10, 10, 10);
            Console.WriteLine(c);
            Console.WriteLine(c.Area());
            c.Display();

            Ellipse e = new Ellipse(10, 10, 10, 10);
            Console.WriteLine(e);
            Console.WriteLine(e.Area());
            e.Display();
        }
    }
}