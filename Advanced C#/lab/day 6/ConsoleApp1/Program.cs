namespace ConsoleApp1;
internal class Program
{
    private static void Main(string[] args)
    {
        StudentList students = new StudentList();
        students.Add(new Student(1, "Mahmoud", "A"));
        students.Add(new Student(2, "Ahmed", "C"));
        students.Add(new Student(3, "Mohamed", "B"));
        students.Add(new Student(4, "Ali", "A"));
        students.Add(new Student(5, "Said", "D"));

        IEnumerable<Student> result = students.Where(s => s.Name.StartsWith("M"));

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}