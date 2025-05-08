namespace CLASSES_N_OBJECTS
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //3.In the Main method, create at least 2 student objects, display their info, and check if they passed.

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White; 

            Student firstStudent  = new Student{FirstName = "Funmi ", LastName = "Aina ",Age=60,Grade=90};
            Student secondStudent = new Student { FirstName = "Gladys ", LastName = "Michael ", Age = 22, Grade = 49 };

            firstStudent.DisplayStudentInfo();
            {
                Console.WriteLine($"Passed: {firstStudent.IsPassed()}");
            }
            Console.WriteLine("---------------------------------------------------");
            secondStudent.DisplayStudentInfo();
            {
                Console.WriteLine($"Passed: {secondStudent.IsPassed()}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
