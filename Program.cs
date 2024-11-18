using System.Diagnostics;

namespace Assignment3_1_5
{
    internal class Program
    {
        // Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 1, 1 , 2, 5, 1, 1};
            PrintArray(arr);
            Console.WriteLine();
            FindOnes(arr);
            Console.WriteLine();
            PrintArray(arr);
        }

        // Takes an array of integers and finds the first occurance of 2 consecutive 1s, changes them to 0, and break when true
        static void FindOnes(int[] intArr)
        {
            for (int i = 0; i < intArr.Length-1; i++)
            {
                if (intArr[i] == 1 && intArr[i+1] == 1)
                {
                    intArr[i] = 0;
                    intArr[i + 1] = 0;
                    break;
                }
            }    
        }

        // Prints out the array to the Console
        static void PrintArray(int[] intArr)
        {
            foreach (int elem in intArr)
            {
                Console.Write($"{ elem } ");
            }
        }
    }
}
