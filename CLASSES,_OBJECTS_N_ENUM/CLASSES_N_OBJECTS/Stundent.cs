using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES_N_OBJECTS
{
    /*CLASSES AND OBJECTS ASSIGNMENT
       Create a class called Student with the following properties:
       •	FirstName (string)
       •	LastName (string)
       •	Age (int)
       •	Grade (double)
       Write a method DisplayStudentInfo that prints the student's information in a formatted manner.
       Additionally, create a method IsPassed that checks if the student's grade is 50 or higher (returning true if they passed and false otherwise).
       INSTRUCTIONS:
       1.	Define the Student class with the properties mentioned.
       2.	Add two methods:
       o	DisplayStudentInfo: Display the student's details.
       o	IsPassed: Check if the grade is 50 or above.
       3.	In the Main method, create at least 2 student objects, display their info, and check if they passed.
       */ 
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public double Grade;

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name:{FirstName}{LastName} Age: {Age} and your grade is {Grade}");
        }

        public bool IsPassed()
        {
            return Grade > 50;
        }
    }
// Write a method DisplayStudentInfo that prints the student's information in a formatted manner.
}
