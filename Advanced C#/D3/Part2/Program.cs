
public class Program
{
    public static int? GetInteger()
    {
        int? value = null;
        try
        {
            value = int.Parse(Console.ReadLine());

        }
        catch
        {
        }
        return value;
    }


    public static bool GetInteger(out int value)
    {
        
        try
        {
            value = int.Parse(Console.ReadLine());
            return true;
        }
        catch
        {
            value = 0;
            return false;
        }
    }


    public static void Main()
    {

        /*
            NULL, null
            Indicates That The Variable 
            Doesn Not Refere To Any Data On the 
            Heap
         */
       
        //int X;
        //bool OK = GetInteger(out X);
        //if(OK == true)
        //{
        //    Console.WriteLine(X);
        //}
        //else
        //{
        //    Console.WriteLine("In Valid");
        //}



        int? obj = GetInteger();
        //Nullable<int> value = GetInteger();
        if (obj != null)
        {
            Console.WriteLine(obj.Value);
        }
        else
        {
            Console.WriteLine(obj);
        }





        Console.ReadKey();

    }
}