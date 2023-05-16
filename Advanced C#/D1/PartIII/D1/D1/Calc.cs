using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    public class Calc
    {
        private List<int> GetNumbers()
        {
            Console.WriteLine("Enter Numbers : ");
            List<int> numbers = new List<int>();
            while (true)
            {
                string value  = Console.ReadLine();
                if (value == "")
                    break;
                else
                {
                    numbers.Add(int.Parse(value));
                }
            }
            return numbers;
        }
        public void ShowMenu()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Subtract");
            Console.WriteLine("3- Exit ");
        }
        public int GetUserOption()
        {
            Console.WriteLine("Choice");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public void ProcessUserOption(int _option)
        {
            switch (_option)
            {
                case 1:
                    {
                        List<int> numbers  =  GetNumbers();
                        int sum = 0; 
                        foreach(int i in numbers)
                            sum  += i;
                        Console.WriteLine($"Sum  = {sum}");
                    }
                    break;
                case 2:
                    { } break;
            }
        }
    }
}
