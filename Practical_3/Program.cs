// PRACTICAL 3 : "IDENTIFY AGE"

// Write a C# program that does the following
// - user will input their year of birth
// - the program will calculate and display the age, generation and stage

// Example:
// If the birth year is 1992 the program should display: 32 years old, Millenial, Early Adulthood

// Refer to this chart to know the generation and stage to display
//             Generation             Time Frame              Age Now
//        The Silent Generation       1928 - 1945          79-96 years old
//            Baby Boomers            1946 - 1964          60-78 years old
//               Gen X                1965 - 1980          44-59 years old
//             Millenials             1981 - 1996          28-43 years old
//               Gen Z                1997 - 2012          12-27 years old
//             Gen Alpha           Early 2010s - 2025      o-approx. 11 years old

//              STAGES
//          Infant ages 0 - 3
//          Early Childhood ages 3 - 6
//          Middle Childhood ages 6 - 8
//          Late Childhood ages 9 - 11
//          Adolescence ages 12 - 20
//          Early Adulthood ages 21 - 35
//          Midlife ages 35 - 50
//          Mature Adulthood Ages 50 - 80
//          Late Adulthood ages 80+

namespace Practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to input a birthyear
            Console.Write("Enter year of birth: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());
            //determines the age through simple math equation
            int age = 2024 - birthyear;

            //compare the birthyear through different conditional statements to determine the generation
            GenerationDeterminer(birthyear, age);
        }
        public static void GenerationDeterminer(int birthyear, int age)
        {
            if (birthyear < 1928)
            {
                Console.WriteLine($"{age} year/s old, and Late Adulthood Ages. Unfortunately we don't have enough data to determine your generation");
            }
            else if (birthyear >= 1928 && birthyear <= 1945)
            {
                AgeStagesDeterminerTheSilentGeneration(age);
            }
            else if (birthyear >= 1946 && birthyear <= 1964)
            {
                Console.WriteLine($"{age} year/s old, Baby Boomers, Mature Adulthood ages");
            }
            else if (birthyear >= 1965 && birthyear <= 1980)
            {
                AgeStagesDeterminerGenX(age);
            }
            else if (birthyear >= 1981 && birthyear <= 1996)
            {
                AgeStagesDeterminerMillenials(age);
            }
            else if (birthyear >= 1997 && birthyear <= 2012)
            {
                AgeStagesDeterminerGenZ1(age);
            }
            else if (birthyear >= 1997 && birthyear <= 2012)
            {
                AgeStagesDeterminerGenZ2(age);

            }
            else if (birthyear > 2024)
            {
                Console.WriteLine("How are you here? you're not born yet :o");
            }
        }
        public static void AgeStagesDeterminerTheSilentGeneration(int age)
        {
            Console.WriteLine($"{age} year/s old, The Silent Generation, ");

            //compares age to a specific ages to determine the life stages
            if (age > 80)
            {
                Console.Write("Late Adulthood ages");
            }
            else
            {
                Console.Write("Mature Adulthood ages");
            }
        }
        public static void AgeStagesDeterminerGenX(int age)
        {
            Console.WriteLine($"{age} year/s old, Gen X, ");
            if (age > 50)
            {
                Console.Write("Mature Adulthood ages");
            }
            else
            {
                Console.Write("Midlife ages");
            }
        }
        public static void AgeStagesDeterminerMillenials(int age)
        {
            Console.WriteLine($"{age} year/s old, Millenials, ");
            if (age > 35)
            {
                Console.Write("Midlife ages");
            }
            else
            {
                Console.Write("Early Adulthood ages");
            }
        }
        public static void AgeStagesDeterminerGenZ1(int age)
        {
            Console.WriteLine($"{age} year/s old, Gen Z, ");
            if (age > 21)
            {
                Console.Write("Early Adulthood ages");
            }
            else
            {
                Console.Write("Adolescence ages");
            }
        }
        public static void AgeStagesDeterminerGenZ2(int age)
        {
            Console.WriteLine($"{age} year/s old, Gen Z, ");
            if (age > 9)
            {
                Console.Write("Late Childhood ages");
            }
            else if (age > 6)
            {
                Console.Write("Middle Childhood ages");
            }
            else if (age > 3)
            {
                Console.Write("Early Childhood ages");
            }
            else if (age > 0)
            {
                Console.Write("Infant ages");
            }
        }
    }
}
