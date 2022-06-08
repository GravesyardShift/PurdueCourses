/* This code has two functions. 1. Locate and return the largest value in an integer array.
2. Loop through the given integer array, check each value for even/odd and return appropriate word in a string array.
Expected output is at the bottom. */

using System;

namespace IT213M4_Graves_CS
{
    using static System.Environment;
    class program {
        static void evenOrOdd(int[] integerArray, string[] stringArray){
            for (int i = 0; i < 10; i++)
               {
                   Console.Write(integerArray[i] + " is ");

                   if (integerArray[i]%2 == 0) {
                    Console.WriteLine(stringArray[i] +NewLine);
                   } else {
                    stringArray[i] = "odd";
                    Console.WriteLine(stringArray[i] +NewLine);
                     }
                }
        }
        static void findMax(int[] integerArray){
            int largestNumber = 0;
            int arrayPosition = 0;
            for (int i = 0; i < 10; i++)
            {
                if (integerArray[i] > largestNumber)
                {
                    largestNumber = integerArray[i];
                    arrayPosition = i;
                }
            }
             Console.WriteLine("The largest number in the array is {0} located at array index {1}" + NewLine, largestNumber, arrayPosition);
             Console.WriteLine("The numbers were:" + NewLine);
        }
        static void Main(string[] args) {

            int[] integerArray = new int[10] { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };
            string [] stringArray = new string[10] {"even", "even", "even", "even", "even", "even", "even", "even", "even", "even"};

            Console.WriteLine("{0}" + NewLine, string.Join(", ", integerArray));
         
            findMax(integerArray);
            evenOrOdd(integerArray, stringArray);
        }
    }
}

/* Expected output: 
56, 77, 23, 12, 88, 59, 97, 33, 38, 64
The largest number in the array is 97 located at array index 6.
The number were:
56 is even
77 is odd
23 is odd
12 is even
88 is even
59 is off
97 is odd
33 is odd
38 is even
64 is even */
