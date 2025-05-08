using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Studytime
{
    internal class consoleGradingSystem
    {
        static void Main(string[] args)
        {
            //User information

            Console.WriteLine("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string  inputAge = Console.ReadLine();
            int age = int.Parse(inputAge);

            Console.WriteLine("Enter the subject name: ");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter your mark: ");
            int mark = int.Parse(Console.ReadLine());
            
            // Grading System
             string grade ="";

            if (mark >0 
                && mark <60)
            {
                grade = "F";
            }
            else if (mark >= 60 
                     && mark <= 69)
            {
                grade = "D";
            }

            else if (mark >= 70
                     && mark <= 79)
            {
                grade = "C";
            }

            else if (mark >= 80
                     && mark <= 89)
            {
                grade = "B";
            }

            else if (mark >= 90
                     && mark <= 100)
            {
                grade = "A";
            }

            else
            {
                Console.WriteLine("Contact the admin for more information about this grade");
                return;
            }
            Console.WriteLine($"Hello {studentName}" + $" You are {age} years old" + $" and your grade for {subject} is {grade}");
           switch (grade)
           {
               case "F": Console.WriteLine(" Your can enrol for make up class to improve on this subject!");
                   break;

               case "D": Console.WriteLine(" You have passed this course, but there is room for improvement");
                   break;
               case "C": Console.WriteLine(" You doing well on average level, there is room for improvement");
                   break;
               case "B": Console.WriteLine(" Good Job! You have a good grade");
                   break;
               case "A": Console.WriteLine(" Excellent Performance! ");
                   break;
               default:Console.WriteLine("Incomplete information! Please Contact the admin for more information about this grade");
                   break;

           }

           Console.ReadLine();

        }
    }
}

