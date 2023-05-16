using  Part6;
public class App
{
    static void Main()
    {
        try
        {
            int var = Utility.GetInetger();
        }
        catch(OverflowException err)
        {

        }
        catch(IDMustBeGreaterThanOrEqualOneException err)
        {
            Console.WriteLine( "");
        }
      
    }
}