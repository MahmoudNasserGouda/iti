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
        int dividend = 25, divisor = 4;
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);

        //7.	Program to Check Whether a Number is Even or Odd
        int numtocheck = 10;
        if (numtocheck % 2 == 0)
            Console.WriteLine(numtocheck + " is even");
        else
            Console.WriteLine(numtocheck + " is odd");

        //8.	Program to Find the Largest Number Among Three Numbers
        int number1 = 10, number2 = 25, number3 = 20;
        int largest = number1;
        if (number2 > largest)
            largest = number2;
        if (number3 > largest)
            largest = number3;
        Console.WriteLine("The largest number among " + number1 + ", " + number2 + " and " + number3 + " is " + largest);

        //9.	Program that takes the degree from user, and switch on it to print the corresponding Grade:
        //      A => Excellent
        //      B => Very Good
        //      C => Good
        //      D => fair
        //      E => failed
        Console.WriteLine("Enter your degree: ");
        string degree = Console.ReadLine();
        switch (degree.ToUpper())
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Very Good");
                break;
            case "C":
                Console.WriteLine("Good");
                break;
            case "D":
                Console.WriteLine("Fair");
                break;
            case "E":
                Console.WriteLine("Failed");
                break;
            default:
                Console.WriteLine("Invalid degree");
                break;
        }

        //10.   Program to print total of numbers when it gets to 100. (sum)
        int sum_of_numbers = 0;
        for (int i = 0; i <= 100; i++)
            sum_of_numbers += i;
        Console.WriteLine("The sum of numbers entered is " + sum_of_numbers);

        //11.   Program to Generate Multiplication Table "1*3=3, 2*3=6, ..."
        int table = 3;
        for (int i = 1; i <= 12; i++)
        {
            int result = table * i;
            Console.WriteLine(table + " * " + i + " = " + result);
        }

        //12.	Program to Check Whether a Character is an Alphabet or not
        char ch = 'a';
        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            Console.WriteLine(ch + " is an alphabet");
        else
            Console.WriteLine(ch + " is not an alphabet");

        //Bonus:
        //1.    Program to count number of Alphabets & number of words in a sentence. (word count)
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        int wordCount = sentence.Split(' ').Length;
        int alphabetCount = sentence.Length;
        Console.WriteLine("Number of words in the sentence: " + wordCount);
        Console.WriteLine("Number of alphabets in the sentence: " + alphabetCount);

    }
}