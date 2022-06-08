
using System;

namespace IT213M2_Graves_CS
{ 
    using static System.Environment;
    class program {
        static void Main(string[] args) {

//*********************************************************
//****Assessment IT213M2 Section 1
//*********************************************************
// This program uses a while loop structure that creates a loop based on a counter variable, which will cycle through 10 iterations.
// Each iteration of the loop requests a grade from the user, which is added to the running total. Prints total and class average.
            
            int Sum = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.Write("Enter Grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Sum = Sum + grade;
                Console.WriteLine("");
            }

            int Average = Sum / 10;
            Console.WriteLine("Total of all 10 grades is {0}" +NewLine, Sum);
            Console.WriteLine("Class average is {0}" +NewLine, Average);

//*********************************************************
//****Assessment IT213M2 Section 2
//*********************************************************
// Two nested for loops that will iterate from 5 to 1(outer loop, k) by increments of 1 and iterate from 0 to 10(inner loop, i) by increments of 2. 
// Print both loop index values for each iteration of inner loop.
            
            for (int k = 5; k > 0; k--)
            {
                for (int i = 0; i < 11; i+=2)
                {
                Console.Write("k = {0}, ", k);
                Console.WriteLine("i = {0}" +NewLine, i);

                }            
            }

//*********************************************************
//****Assessment IT213M2 Section 3
//*********************************************************
// While loop to process user-entered numbers. Inform user to enter a positive number to be added to the total or type "-1" to end.
// Print total of numbers entered(not including "-1" end command)
            
            int end = 1;
            int sum2 = 0;

            while (end > 0)
            {
                Console.Write("Enter a positive number to be added to the total or -1 to end. ");
                int positive = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (positive == -1)
                {
                    Console.WriteLine("The sum of all numbers entered is {0}" +NewLine, sum2);
                    end = -1;
                }
                else
                {
                    sum2 = sum2 + positive;
                }
            }
        }
    }
}
