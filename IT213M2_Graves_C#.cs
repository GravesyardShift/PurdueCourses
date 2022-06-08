
using System;

namespace IT213M2_Graves_CS
{ 
    using static System.Environment;
    class program {
        static void Main(string[] args) {

//*********************************************************

//****Assessment IT213M2 Section 1

//*********************************************************
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