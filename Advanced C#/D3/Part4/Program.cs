


using Part4;

struct App
{
    static void Main()
    {
        Account A = new Account();
        A.Balance = float.Parse(Console.ReadLine());
        A.Number = 10;
        Console.WriteLine(A.Balance);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Account B = new Account();
        B.Number = 0;
        B.Balance = float.Parse(Console.ReadLine());





        

        Console.WriteLine(B.ToString());


        Employee E = new Employee() {  };
        Console.WriteLine(E.ID);



        Console.ReadKey(); 
    }
}