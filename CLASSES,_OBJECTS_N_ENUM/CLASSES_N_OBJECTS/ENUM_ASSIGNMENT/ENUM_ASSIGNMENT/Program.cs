using System.Runtime.InteropServices;

namespace ENUM_ASSIGNMENT
{
    internal class Program
    {
        /*ENUM ASSIGNMENT
           Create an enum for dayoftheweek i.e from Sunday-Saturday. Then create a method IsWeekend that takes a DayOfWeek enum value and returns whether it's the weekend (Saturday or Sunday).
           INSTRUCTIONS
           1.	Define the DayOfWeek enum.
           2.	Create the IsWeekend method that returns true if the day is Saturday or Sunday, otherwise false.
           3.	In your Main method, ask the user to input a day of the week (e.g., "Monday") and determine if it’s a weekend.
           */
        static void Main(string[] args)
        {
            // --- DayOfWeek Enum Test ---
            Console.Write("Enter a day of the week (e.g., Monday): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out DayOfWeek theday))
            {
                Console.WriteLine(DayCalender.IsWeekend(daysoftheweek.Thursday)
                    ? $"{theday} is a weekend"
                    : $"{theday} is a weekday");
            }
            else
            {
                Console.WriteLine("Incorrect selection!! Please try again");
            }
        }
    }

}
    

