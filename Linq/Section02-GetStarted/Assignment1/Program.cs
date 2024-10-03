using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            // Write a simple C# program to declare a list of integer values,
            // followed by a simple LINQ query to check for even numbers, 
            // and finally print them to the console.
            // NOTE: You may refer to the sample program we used before for 
            //       reference.

            // Step 1: Getting data source


            // Step 2: Writing query
                // Part 1: Data source
                // Part 2: Filter    
                // Part 3: Select

            // Step 3: Executing query

            List<int> numbers= new List<int>(){1,2,3,4,5,6,7,8,9,10};
            IEnumerable<int> evenNo = from n in numbers 
                                        where n % 2 == 0 
                                        select n;
            foreach(int no in evenNo)
            System.Console.WriteLine("Even No: {0}",no);   

            
        }
    }
}
