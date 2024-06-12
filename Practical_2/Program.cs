//Practical 2:
//Write a C# program that does the following
//user will input a day number
//program will display the corresponding day
//program will ask the user to input another number to add to the day number
//program will compute and display the corresponding day

//Use the following reference day reference:
//1 is Monday
//2 is Tuesday
//3 is Wednesday
//4 is Thursday
//5 is Friday
//6 is Saturday
//7 is Sunday

//If the user inputs a number beyond the numbers between 1 and 7 the program should display that the input is invalid

using System.Runtime.Intrinsics.X86;

namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to input/enter a day number
            Console.Write("Enter a day number (1-7): ");
            int daynumber = Convert.ToInt32(Console.ReadLine());

            //input validation
            if (daynumber < 1 || daynumber > 7 ) 
            {
                Console.WriteLine("Error: Please enter a day number between 1-7.");
                return;
            }

            //Tells the day equivalent of 
            DayTeller(daynumber);

            //tells the user to enter a new number to add on the initial number
            Console.Write("Enter another number to add to the day number: ");
            int numtoadd = Convert.ToInt32(Console.ReadLine());

            //uses mathematical equation to determine the day
            int numandday = numtoadd + daynumber;
            int asd = numandday % 7;

            //tells the 2nd day equivalent
            DayTeller2(asd);
        }

        public static void DayTeller(int daynumber)
        {
            if (daynumber == 1)
            {
                Console.WriteLine("The Day is Monday");
            }
            else if (daynumber == 2)
            {
                Console.WriteLine("The Day is Tuesday");
            }
            else if (daynumber == 3)
            {
                Console.WriteLine("The Day is Wednesday");
            }
            else if (daynumber == 4)
            {
                Console.WriteLine("The Day is Thursday");
            }
            else if (daynumber == 5)
            {
                Console.WriteLine("The Day is Friday");
            }
            else if (daynumber == 6)
            {
                Console.WriteLine("The Day is Saturday");
            }
            else if (daynumber == 7)
            {
                Console.WriteLine("The Day is Sunday");
            }
        }

        public static void DayTeller2(int asd)
        {
            if (asd == 1)
            {
                Console.WriteLine("The New Day is Monday");
            }
            else if (asd == 2)
            {
                Console.WriteLine("The New Day is Tuesday");
            }
            else if (asd == 3)
            {
                Console.WriteLine("The New Day is Wednesday");
            }
            else if (asd == 4)
            {
                Console.WriteLine("The New Day is Thursday");
            }
            else if (asd == 5)
            {
                Console.WriteLine("The New Day is Friday");
            }
            else if (asd == 6)
            {
                Console.WriteLine("The New Day is Saturday");
            }
            else if (asd == 0)
            {
                Console.WriteLine("The New Day is Sunday");
            }
        }
    }
}
