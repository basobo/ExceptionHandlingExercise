using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            // Create a list called numbers that will hold integers
            List<int> number = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            string str = string.Empty;
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()

           
            foreach(var character in arr)
            {
              
                try
                {
                    str=character.ToString();
                    int num = int.Parse(str);
                    number.Add(num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                    Console.WriteLine(ex.Message);
                }
            }
            // and Exceptions will be thrown 

            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array

            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            Console.WriteLine();
            Console.Write("Number: ");

            foreach (var num in number)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
