using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(new Employee { Id = 10, Name = "Ahmed" }, new Employee { Id = 20, Name = "Mahmoud" });
            ht.Add(new Employee { Id = 10, Name = "Ahmed" }, new Employee { Id = 20, Name = "Mahmoud" });

        }
    }
}