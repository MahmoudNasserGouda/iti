using System;
using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        TraineeList trainees = new TraineeList(3);

        trainees[0] = new Trainee { Name = "Ahmed", Age = 25 };
        trainees[1] = new Trainee { Name = "Mahmoud", Age = 30 };
        trainees[2] = null;

        Console.WriteLine($"Trainee 1: {trainees[0]?.Name}, Age: {trainees[0]?.Age}"); //Trainee 1: John, Age: 25
        Console.WriteLine($"Trainee 2: {trainees[1]?.Name}, Age: {trainees[1]?.Age}"); //Trainee 2: Jane, Age: 30
        Console.WriteLine($"Trainee 3: {trainees[2]?.Name}, Age: {trainees[2]?.Age}"); //Trainee 3: , Age: 0

        Console.WriteLine($"Trainee 1: {trainees["John"]?.Name}, Age: {trainees["John"]?.Age}"); //Trainee 1: John, Age: 25
        Console.WriteLine($"Trainee 2: {trainees["Jane"]?.Name}, Age: {trainees["Jane"]?.Age}"); //Trainee 2: Jane, Age: 30
        Console.WriteLine($"Trainee 3: {trainees["Bob"]?.Name}, Age: {trainees["Bob"]?.Age}"); //Trainee 3: , Age: 0

        Console.ReadLine();
    }

}