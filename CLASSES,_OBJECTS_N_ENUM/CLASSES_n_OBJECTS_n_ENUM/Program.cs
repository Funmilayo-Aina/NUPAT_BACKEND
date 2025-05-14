using System.ComponentModel;

namespace CLASSES_n_OBJECTS_n_ENUM
{
    public class ClassesObjectsAndEnums
    {
        static void NumberGuessingGame(int[] intArray, string msg)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} {1}",msg,k);
            }

            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Random rnd = new Random();
            int secretNum = rnd.Next(1, 100);
            int numberGuessed = 0;
            Console.WriteLine("Random Num:  ", secretNum);

            do
            {
                Console.WriteLine("Enter a number a number between 1 and 100: ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
                if (numberGuessed < secretNum)
                {
                    Console.WriteLine("Go higher");
                }
                else if (numberGuessed > secretNum)

                {
                    Console.WriteLine("You a lower number");
                }
                else
                {
                    Console.WriteLine("Excellent!");
                }
            } while (secretNum != numberGuessed);

            Console.WriteLine("You guessed {0}!", secretNum
        );

    }

    }
    
}
