namespace Part6
{
    public class Utility
    {
        public static int  GetInetger()
        {
            int value = 0;
            value = int.Parse(Console.ReadLine());
            if (value <= 0)
                throw new IDMustBeGreaterThanOrEqualOneException("Must Be More Than Zero");
            return value;
        }
    }
}