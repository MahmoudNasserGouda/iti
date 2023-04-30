using System.Security.Cryptography;

namespace ConsoleApp1
{
    public class Employee
    {
        private string _Name;
        private string _Address;
        private string _NID;
        private decimal _Salary;
        private string _Title;
        private static int _count;
        private static string _DepartmentName;

        public string Name { get => _Name; set => _Name = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string NID { get => _NID; set => _NID = value; }
        public decimal Salary
        {
            get => _Salary; 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary cannot be a negative number.");
                }
                else
                {
                    _Salary = value;
                }
            }
        }
        public string Title { get => _Title; set => _Title = value; }

        public Employee()
        {
            _count++;
        }

        public Employee(string name, string address, string nid, decimal salary, string title) : this()
        {
            Name = name;
            Address = address;
            NID = nid;
            Salary = salary;
            Title = title;
        }

        static Employee()
        {
            _DepartmentName = ".Net Department";
        }

        public static void DisplayCount()
        {
            Console.WriteLine($"Total number of employees: {_count}");
        }

        public void Display()
        {
            PrintEmployee(this);
        }

        private void PrintEmployee(Employee obj)
        {
            Console.WriteLine(obj);
        }

        public override string ToString()
        {
            return $"[Name: {Name}, Address: {Address}, NID: {NID}, Salary: {Salary}, Title: {Title}, DepartmentName: {_DepartmentName}]";
        }
    }
}