
using Part1;

public class Program
{
    static void Main()
    {
        #region Previous Part I
        /*
        int x = 10;
        int y = x;

        x = 11;

        EMployee E;
        E.ID = 10;
        E.Name = "Ahmed";

        EMployee E2 = E;
        E.ID = 11;
        Console.WriteLine(E2.ID);
        Console.WriteLine();



        Console.WriteLine("Choose :");
        Console.WriteLine("1- Add :");
        Console.WriteLine("2- Edit :");
        Console.WriteLine("3- Remove :");
        Console.WriteLine("4- Display :");
        Console.WriteLine("5- Display List :");


        UserOption choice =
             (UserOption)(byte.Parse(Console.ReadLine()));

        switch (choice)
        {
            case UserOption.Add:
                {
                    Console.WriteLine("Adding ..");
                }
                break;
            case UserOption.Edit:
                {
                    Console.WriteLine("Editing ..");
                }
                break;
            case UserOption.Remove:
                {

                }break;
        }
        */
        #endregion

        /*
        Console.ForegroundColor
             = ConsoleColor.Green;
        Console.WriteLine("Hello World");
        */


        int x = 10;
        float y = (float)15.6;
        string n = "ITI";
        int[] arr = new int[2]  { 10, 45 };
        EMployee e = new EMployee()
        { ID = 10, Name = "ITI" };

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(n);
        Console.WriteLine(e);
        Console.WriteLine(arr);

        int XVal = 10; 
        object o = XVal; // Boxing 
        //o = new EMployee();
        int Y = (int)o; // Un Boxing  
        Console.WriteLine(Y);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        string Name = "Hany";
        string Name2 = Name;

        Name = "Test";

        Console.WriteLine(Name2);
        

        //Console.WriteLine(MyArr[0]);
        Console.WriteLine();
        Console.WriteLine();


        EMployee EE = new EMployee() { ID = 60 };
        EMployee EE2 = EE;
        EE.ID = 40;
        Console.WriteLine(  EE2.ID);


        Console.WriteLine();
        Console.WriteLine();



        EMployee B = EE;

        Console.ReadKey();
    }
}
