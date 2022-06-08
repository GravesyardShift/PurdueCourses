
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