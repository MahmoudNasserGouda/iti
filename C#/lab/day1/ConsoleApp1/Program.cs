internal class Program
{
    private static void Main(string[] args)
    {
        //Assignments
        //1.    Program to print "Hello World"
        Console.WriteLine("Hello World");

        //2.	Program to print ASCII number of a char
        char c = 'A';
        Console.WriteLine("The ASCII value of " + c + " is " + (int)c);

        //3.	Program to print a float number entered by the user
        float numf;
        Console.WriteLine("Enter a float number: ");
        numf = float.Parse(Console.ReadLine());
        Console.WriteLine("The entered number is: " + numf);

        //4.	Program to add two integers
        int num1, num2, sum;
        Console.WriteLine("Enter two integers: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

        //5.	C# Program to print Hexa of a number
        int numtohex = 255;
        string hex = numtohex.ToString("X");
        Console.WriteLine("The hexadecimal representation of " + numtohex + " is: " + hex);

        //6.	C# Program to compute Quotient and Remainder
        //7.	Program to Check Whether a Number is Even or Odd
        //8.	Program to Find the Largest Number Among Three Numbers
        //9.	Program that takes the degree from user, and switch on it to print the corresponding Grade:
        //      A => Excellent
        //      B => Very Good
        //      C => Good
        //      D => fair
        //      E => failed
        //10.   Program to print total of numbers when it gets to 100. (sum)
        //11.   Program to Generate Multiplication Table "1*3=3, 2*3=6, ..."
        //12.	Program to Check Whether a Character is an Alphabet or not

        //Bonus:
        //1.    Program to count number of Alphabets & number of words in a sentence. (word count)
        //2.    Program to display "MagicBox"
        //3.	Program to take char and displays if it is "Normal or Extended key" along with its Ascii value.

    }
}