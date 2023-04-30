using ConsoleApp1;
internal class Program
{
    private static void Main(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(4, -1);

        Console.WriteLine(c1); // (2,3)
        Console.WriteLine(c2); // (4,-1)

        Console.WriteLine(c1 + c2); // (6,2)
        Console.WriteLine(c1 - c2); // (-2,4)
        Console.WriteLine(c1 * c2); // (11,10)
        Console.WriteLine(c1 / c2); // (0.29411764705882354,0.8235294117647058)
        Console.WriteLine(++c1); // (3,4)

        Console.WriteLine(c1 >= c2); // True
        Console.WriteLine(c1 <= c2); // False

        Console.WriteLine((ComplexNumber)5); // (5,0)


        //-------------------------------------------------------------------------------------------------------------------------------------------


        Employee employee = new Employee("Ahmed", 20, 5000, "246810", "a@b.com");
        employee.ShowData(); 

        var manager = new Manager("Mahmoud", 40, 10000, "13579", "c@d.com");
        manager.ShowData();

        manager.AccessFields();

        Point point1 = new Point (0, 0);
        Point point2 = new Point (100, 100);
        Color color = new Color (255, 0, 0);
        Line line = new Line (point1, point2, color);

    }
}