namespace ConsoleApp1
{
    public class Manager : Employee
    {
        public Manager(string name, int age, int salary, string phoneNumber, string email) 
            : base(name, age, salary, phoneNumber, email)
        {

        }

        public void AccessFields()
        {
            Name = "name";
            Age = 30;
            Salary = 3000;
            PhoneNumber = "12356789";
            Email = "someone@test.com";
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}, Phone: {PhoneNumber}, Email: {Email}");
        }
    }
}
