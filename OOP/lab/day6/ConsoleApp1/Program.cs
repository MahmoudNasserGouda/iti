namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(0);
            c.Drive();
            c.Refuel(10);
            c.Drive();
            c.Move();
            c.Accelerate();

            CustomStack<int> s = new CustomStack<int>(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            //s.Push(6);    //error

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());   '//error


        }
    }
}