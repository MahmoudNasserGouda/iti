using Utility;

public class Program
{
    static void Main()
    {
        int var = 0;
        while (var == 0)
        {
            try
            {
                var = Utility.Utility.GetInetger();
            }
            catch (OverflowException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (IDMustBeGreaterThanOrEqualOneException err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                Console.WriteLine(var);
            }
        }

    }
}