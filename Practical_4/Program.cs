// PRACTICAL 4 : "SIMPLE CALCULATOR"

// Write a C# program that does the following
// - Display the operations ADD, SUBTRACT, MULTIPLY, DIVIDE
// - Ask the user to select operation
// - Ask the user to input 2 numbers
// - Program will perform the selected operation on the 2 numbers and display the result

//      EXAMPLE OUTPUT:
//      Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE
//      User input: 1
//      Input first number: 20
//      Input first number: 30

//      ADD 20 and 30 the result is 50

// Apply the following rules:
// if the user selected SUBTRACT or DIVIDE the first number should be greater than the second number
// if the user DIVIDE and the second number is 0 the program should display invalid input 

namespace Practical_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the operations ADD, SUBTRACT, MULTIPLY, DIVIDE and Ask user to enter a choice
            Console.Write("Select an operation from the following choices:" +
                "\n1. ADD" +
                "\n2. SUBTRACT" +
                "\n3. MULTIPLY" +
                "\n4. DIVIDE" +
                "\nEnter your choice of operation (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            //Input Validation lang
            if (choice < 0 || choice > 4) 
            {
                Console.WriteLine("Error: Please select from the option (1-4) ");
                return;
            }

            //ask the user to for the 2 number to be divided, added, subtract or multiply.
            Console.Write("Enter 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            //variable declaration for the result
            int result;

            //switch case for different choices
            switch (choice)
            {
                //simple addition code
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"ADDING {num1} and {num2} will result an answer of {result}");
                    break;

                //has a condition that stops the code if the 1st number is less than the 2nd number
                case 2:
                    if (num1 > num2)
                    {
                        
                        result = num1 - num2;
                        Console.WriteLine($"SUBTRACTING {num1} and {num2} will result an answer of {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: The 1st number must be greater than the 2nd number, please try again.");
                        break;
                    }

                //simple multiplication code 
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"ADDING {num1} and {num2} will result an answer of {result}");
                    break;

                //the same with case 2 but displays invalid input if num 2 is 0 
                case 4:
                    if (num1 > num2)
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Invalid Input");
                            break;
                        }
                        else 
                        { 
                        result = num1 / num2;
                        Console.WriteLine($"DIVIDING {num1} and {num2} will result an answer of {result}");
                        break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: The 1st number must be greater than the 2nd number, please try again.");
                        break;
                    }
                default:
                    Console.WriteLine("Error: Please enter a number between 1-4 only");
                    return;

            }
        }
    }
}
