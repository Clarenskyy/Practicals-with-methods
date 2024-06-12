//Practical 1:
//Write a C# program that does the following:
//- User will input grades and ask the user how many grades will be entered
//- the program will calculate the average and display the corresponding grade equivalent of the average grade
//If average grade is below 50 the equivalent is FAILED
//If average grade is 50 the equivalent is FAILED
//If average grade is above 50 but less than or equal to 70 the equivalent is FAIR
//if average grade is above 70 the equivalent is GOOD
//if average grade is 80 and below the equivalent is GOOD
//if average grade is above 80 until 90 the equivalent is VERY GOOD
//if average grade is above 90 but not greater than 100 the equivalent is EXCELLENT
//if the user entered a negative number and above 100 the program will display invalid input
using System.Collections.Generic;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to enter number of grades to be average
            Console.Write("Enter the number of grades to be average: ");
            int noofgrade = Convert.ToInt32(Console.ReadLine());

            // Input validation: Ensure a positive number of grades
            noofgrade = InputValidationNoofGrade(noofgrade);

            double total = 0;
            double grade;
            int limit = 0;

            //Loops to get the total grade
            while (limit < noofgrade)
            {
                Console.WriteLine("Enter the Grades: ");
                grade = Convert.ToDouble(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error: Please Enter a Grade within 1-100.");
                    return;
                }

                limit++;
                total += grade;

            }

            double Average = total / noofgrade;

            //conditional statements that tells the equivalent of a grade
            Evaluator(Average);

        }

        public static int InputValidationNoofGrade(int noofgrade)
        {
            if (noofgrade < 1)
            {
                Console.WriteLine("Error: Please Enter a Positive number above 0");
                return 0;
            }
            else
            {
                return noofgrade;
            }
        }

        
        public static void Evaluator(double Average)
        {
            if (Average > 90 && Average <= 100)
            {
                Console.WriteLine($"{Average} is equivalent to EXCELLENT");
            }
            else if (Average > 80 && Average <= 90)
            {
                Console.WriteLine($"{Average} is equivalent to VERY GOOD");
            }
            else if (Average > 70 && Average <= 80)
            {
                Console.WriteLine($"{Average} is equivalent to GOOD");
            }
            else if (Average > 50 && Average <= 70)
            {
                Console.WriteLine($"{Average} is equivalent to FAIR");
            }
            else if (Average <= 50)
            {
                Console.WriteLine($"{Average} is equivalent to FAILED");
            }
        }
    }
}
