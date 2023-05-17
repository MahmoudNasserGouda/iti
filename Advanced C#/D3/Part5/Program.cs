


using Part5;

public class Program
{
    public static void Main()
    {

        int[] mobiles = new int[10];
        string[] NamesOfStudents = new string[3]
            { "Ahmed", "Hany", "Sara" };
        NamesOfStudents[0] = "Mostafa";
        Console.WriteLine(NamesOfStudents[0]);

        Console.WriteLine();

      

        EmployeeList eL = new EmployeeList();
        
        eL[0] = new Employee() { ID  = 1, Name ="Saja"};
        eL[1] = new Employee() { ID = 2, Name = "Gamal" };
        eL[2] = new Employee() { ID = 3, Name = "Donia" };

        Console.WriteLine((eL["Gamal"]).ToString());


       


        Console.ReadKey();
    }
}