


public class Program
{
    
    public static int GetInetger()
    {
        int value = 0;
        try
        {
            value = int.Parse(Console.ReadLine());
        }
        catch (OverflowException err)
        {
            Console.WriteLine("Over Flow Occured ");
        }
        catch (FormatException err)
        {
            FileStream fs = new FileStream("F:Log.txt",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"Date : {DateTime.Now}, Info: {err.Message}, Stack : {err.StackTrace}");
            sw.Close();
            Console.WriteLine("Invalid Value");
        }
        catch (Exception err)
        {
        }
        finally
        {
            Console.WriteLine("End Of GetInetger");
        }
       
        return value;
    }

    public static void Main()
    {

        try
        {
            Console.WriteLine("Start Of Program");
            Console.WriteLine(GetInetger());
            Console.WriteLine("End Of Program");
        }
        catch
        { 
        }
        Console.ReadLine();
    }
}