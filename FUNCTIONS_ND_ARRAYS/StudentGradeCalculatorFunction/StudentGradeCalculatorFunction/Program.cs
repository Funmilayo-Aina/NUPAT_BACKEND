using System;

class Program
{
    public static void ConsoleDecorator()
    {

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

    }
    public static double AvgCalculator(int[] grades)
    {
        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return (double)sum / grades.Length;
    }

    public static int Higest(int[] grades)
    {
        int max = grades[0];
        foreach (int grade in grades)
        {
            if (grade > max)
                max = grade;
        }
        return max;
    }

    public static int Lowest(int[] grades)
    {
        int min = grades[0];
        foreach (int grade in grades)
        {
            if (grade < min)
                min = grade;
        }
        return min;
    }
    static void Main()
    {
        ConsoleDecorator();

      /*Ask for the number of student and parse response to integer*/
        Console.Write("Enter the number of students: ");
        int counter = int.Parse(Console.ReadLine());

       // Arrays to store student names and grades
        string[] studentNames = new string[counter];
        int[] grades = new int[counter];

        // get users input
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"Enter student names {i + 1}: ");
            studentNames[i] = Console.ReadLine();

            Console.Write($"Input grade for {studentNames[i]}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }

        // Calling the Function
        double average = AvgCalculator(grades);
        int highestgrade = Higest(grades);
        int lowestgrade = Lowest(grades);

        Console.WriteLine("\n----------------------------------------------");
         //
        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine($"{studentNames[i]}: {grades[i]}");
        }
        Console.WriteLine($"Lowest Grade: {lowestgrade}");
        
        Console.WriteLine($"Highest Grade: {highestgrade}");
        Console.WriteLine($"\nAverage Grade: {average}");
        Console.WriteLine($"The Average grade is: {average} , the lowest grade is: {lowestgrade} and the highest grade is: {highestgrade}");
        Console.ReadLine();
    }

   
}
